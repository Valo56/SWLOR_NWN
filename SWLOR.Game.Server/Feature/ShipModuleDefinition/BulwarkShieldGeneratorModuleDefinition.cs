﻿using System.Collections.Generic;
using SWLOR.Game.Server.Core.NWScript.Enum;
using SWLOR.Game.Server.Core.NWScript.Enum.VisualEffect;
using SWLOR.Game.Server.Entity;
using SWLOR.Game.Server.Service;
using SWLOR.Game.Server.Service.SkillService;
using SWLOR.Game.Server.Service.SpaceService;

namespace SWLOR.Game.Server.Feature.ShipModuleDefinition
{
    public class BulwarkShieldGeneratorModuleDefinition : IShipModuleListDefinition
    {
        private readonly ShipModuleBuilder _builder = new ShipModuleBuilder();

        public Dictionary<string, ShipModuleDetail> BuildShipModules()
        {
            BulwarkShieldGenerator("bulwarkgen", "Bulwark Shield Generator", "Bulwark Gen", "An advanced suite of shield generators project at a wide range, protecting allied ships and reinforcing their defenses, and forcing most nearby foes to target the user. Lasts 12 seconds.", 10);

            return _builder.Build();
        }

        private void BulwarkShieldGenerator(
            string itemTag,
            string name,
            string shortName,
            string description,
            int repairAmount)
        {
            _builder.Create(itemTag)
                .Name(name)
                .ShortName(shortName)
                .Type(ShipModuleType.RepairFieldGenerator)
                .Texture("iit_ess_075")
                .Description(description)
                .PowerType(ShipModulePowerType.High)
                .Capacitor(25)
                .Recast(30f)
                .CapitalClassModule()
                .CanTargetSelf()
                .ActivatedAction((activator, activatorShipStatus, target, targetShipStatus, moduleBonus) =>
                {
                    var industrialBonus = Space.GetShipStatus(activator).Industrial;
                    repairAmount += (industrialBonus + moduleBonus) / 2;

                    for (int i = 0; i < 6; i++)
                    {
                        float delay = i * 2f;
                        DelayCommand(delay, () =>
                        {
                            target = GetFirstObjectInShape(Shape.Sphere, 8.0f, GetLocation(activator), true, ObjectType.Creature);
                            ApplyEffectToObject(DurationType.Temporary, EffectVisualEffect(VisualEffect.Vfx_Dur_Aura_Pulse_Blue_White), activator, 2.0f);
                            if (!GetIsEnemy(target, activator) && !GetIsDead(activator))
                            {
                                targetShipStatus = Space.GetShipStatus(target);
                                if (target != activator)
                                {
                                    ApplyEffectToObject(DurationType.Temporary, EffectVisualEffect(VisualEffect.Vfx_Beam_Cold), target, 2.0f);
                                    ApplyEffectToObject(DurationType.Temporary, EffectVisualEffect(VisualEffect.Vfx_Dur_Aura_Pulse_Blue_White), target, 2.0f);
                                    ApplyEffectToObject(DurationType.Temporary, EffectAbilityIncrease(AbilityType.Vitality, 4), target, 2.0f);
                                }
                                Space.RestoreShield(target, targetShipStatus, repairAmount);
                            }
                        });
                    }

                    Enmity.ModifyEnmityOnAll(activator, 250 + (repairAmount * 6));
                    Messaging.SendMessageNearbyToPlayers(activator, $"{GetName(activator)} begins restoring {repairAmount * 6} shield HP to nearby ships, and reinforces their shield integrity.");
                    CombatPoint.AddCombatPointToAllTagged(activator, SkillType.Piloting);
                });
        }
    }
}
