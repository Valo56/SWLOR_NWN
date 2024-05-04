﻿using System.Collections.Generic;
using SWLOR.Game.Server.Core.NWScript.Enum;
using SWLOR.Game.Server.Core.NWScript.Enum.VisualEffect;
using SWLOR.Game.Server.Service;
using SWLOR.Game.Server.Service.CombatService;
using SWLOR.Game.Server.Service.PerkService;
using SWLOR.Game.Server.Service.SkillService;
using SWLOR.Game.Server.Service.SpaceService;
using Random = SWLOR.Game.Server.Service.Random;

namespace SWLOR.Game.Server.Feature.ShipModuleDefinition
{
    public class LaserCannonBatteryModuleDefinition : IShipModuleListDefinition
    {
        private readonly ShipModuleBuilder _builder = new ShipModuleBuilder();

        public Dictionary<string, ShipModuleDetail> BuildShipModules()
        {
            LaserCannonBattery("lasbattery1", "Laser Cannon Battery I", "Las Cann Bat 1", "Fires at 50% of nearby targets. Fires once every 2 seconds for 18 seconds.", 20);

            return _builder.Build();
        }

        private void LaserCannonBattery(
            string itemTag,
            string name,
            string shortName,
            string description,
            int dmg)
        {
        _builder.Create(itemTag)
            .Name(name)
            .ShortName(shortName)
            .Type(ShipModuleType.LaserBattery)
            .Texture("iit_ess8_088")
            .Description(description)
            .ValidTargetType(ObjectType.Creature)
            .MaxDistance(20f)
            .PowerType(ShipModulePowerType.High)
            .RequirePerk(PerkType.OffensiveModules, 5)
            .Recast(18f)
            .Capacitor(15)
            .CapitalClassModule()
            .CanTargetSelf()
            .ActivatedAction((activator, activatorShipStatus, target, targetShipStatus, moduleBonus) =>
            {
                var attackBonus = activatorShipStatus.ThermalDamage;
                var attackerStat = GetAbilityScore(activator, AbilityType.Perception);
                var attack = Stat.GetAttack(activator, AbilityType.Perception, SkillType.Piloting, attackBonus);
                if (GetHasFeat(FeatType.IntuitivePiloting, activator) && GetAbilityScore(activator, AbilityType.Willpower) > GetAbilityScore(activator, AbilityType.Perception))
                {
                    attackerStat = GetAbilityScore(activator, AbilityType.Willpower);
                    attack = Stat.GetAttack(activator, AbilityType.Willpower, SkillType.Piloting, attackBonus);
                }

                dmg += moduleBonus / 2;
                var sound = EffectVisualEffect(VisualEffect.Vfx_Ship_Blast);
                var missile = EffectVisualEffect(VisualEffect.Mirv_StarWars_Bolt2);

                for (int i = 0; i < 9; i++)
                {
                    float delay = i * 2f;
                    DelayCommand(delay, () =>
                    {
                        target = GetFirstObjectInShape(Shape.Sphere, 20f, GetLocation(activator), true, ObjectType.Creature);
                        while (GetIsObjectValid(target))
                        {
                            if (target != activator && Random.D2(1) == 1)
                            {
                                var defenseBonus = targetShipStatus.ThermalDefense * 2;
                                var defense = Stat.GetDefense(target, CombatDamageType.Thermal, AbilityType.Vitality, defenseBonus);
                                var defenderStat = GetAbilityScore(target, AbilityType.Vitality);
                                var damage = Combat.CalculateDamage(
                                    attack,
                                    dmg,
                                    attackerStat,
                                    defense,
                                    defenderStat,
                                    0);
                                var sound = EffectVisualEffect(VisualEffect.Vfx_Ship_Blast);
                                var chanceToHit = Space.CalculateChanceToHit(activator, target);
                                var roll = Random.D100(1);
                                var isHit = roll <= chanceToHit;
                                ApplyEffectToObject(DurationType.Instant, missile, target);
                                if (isHit)
                                {
                                    Space.ApplyShipDamage(activator, target, damage);
                                }

                                var attackId = isHit ? 1 : 4;
                                var combatLogMessage = Combat.BuildCombatLogMessage(activator, target, attackId, chanceToHit);
                                Messaging.SendMessageNearbyToPlayers(target, combatLogMessage, 60f);

                                Enmity.ModifyEnmity(activator, target, damage);
                                CombatPoint.AddCombatPoint(activator, target, SkillType.Piloting);
                            }
                            target = GetNextObjectInShape(Shape.Sphere, 20f, GetLocation(activator), true, ObjectType.Creature);
                            }
                    });
                }
            });
        }
    }
}