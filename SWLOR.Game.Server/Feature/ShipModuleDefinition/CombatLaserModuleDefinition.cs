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
    public class CombatLaserModuleDefinition : IShipModuleListDefinition
    {
        private readonly ShipModuleBuilder _builder = new ShipModuleBuilder();

        public Dictionary<string, ShipModuleDetail> BuildShipModules()
        {
            CombatLaser("com_laser_b", "Basic Combat Laser", "B. Cmbt Laser", "Deals 8 thermal DMG to your target.", 1, 8);
            CombatLaser("com_laser_1", "Combat Laser I", "Cmbt Laser I", "Deals 12 thermal DMG to your target.", 2, 12);
            CombatLaser("com_laser_2", "Combat Laser II", "Cmbt Laser II", "Deals 17 thermal DMG to your target.", 3, 17);
            CombatLaser("com_laser_3", "Combat Laser III", "Cmbt Laser III", "Deals 21 thermal DMG to your target.", 4, 21);
            CombatLaser("com_laser_4", "Combat Laser IV", "Cmbt Laser IV", "Deals 26 thermal DMG to your target.", 5, 26);

            return _builder.Build();
        }

        private void CombatLaser(
            string itemTag,
            string name,
            string shortName,
            string description,
            int requiredLevel,
            int dmg)
        {
            _builder.Create(itemTag)
                .Name(name)
                .ShortName(shortName)
                .Type(ShipModuleType.CombatLaser)
                .Texture("iit_ess_004")
                .Description(description)
                .MaxDistance(30f)
                .ValidTargetType(ObjectType.Creature)
                .PowerType(ShipModulePowerType.High)
                .RequirePerk(PerkType.OffensiveModules, requiredLevel)
                .Recast(8f)
                .ActivatedAction((activator, activatorShipStatus, target, targetShipStatus, moduleBonus) =>
                {
                    var attackBonus = activatorShipStatus.ThermalDamage;
                    var attackerStat = GetAbilityScore(activator, AbilityType.Perception);
                    var attack = Stat.GetAttack(activator, AbilityType.Perception, SkillType.Piloting, attackBonus);
                    if (GetHasFeat(FeatType.ZenMarksmanship, activator) && GetAbilityScore(activator, AbilityType.Willpower) > GetAbilityScore(activator, AbilityType.Perception))
                    {
                        attackerStat = GetAbilityScore(activator, AbilityType.Willpower);
                        attack = Stat.GetAttack(activator, AbilityType.Willpower, SkillType.Piloting, attackBonus);
                    }
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

                    dmg += moduleBonus / 2;
                    var chanceToHit = Space.CalculateChanceToHit(activator, target);
                    var roll = Random.D100(1);
                    var isHit = roll <= chanceToHit;
                    var sound = EffectVisualEffect(VisualEffect.Vfx_Ship_Blast);
                    var missile = EffectVisualEffect(VisualEffect.Mirv_StarWars_Bolt2);

                    if (isHit)
                    {
                        AssignCommand(activator, () =>
                        {
                            ApplyEffectToObject(DurationType.Instant, sound, target);
                            ApplyEffectToObject(DurationType.Instant, missile, target);

                            DelayCommand(0.3f, () =>
                            {
                                Space.ApplyShipDamage(activator, target, damage);
                            });
                        });
                    }
                    else
                    {
                        AssignCommand(activator, () =>
                        {
                            ApplyEffectToObject(DurationType.Instant, sound, target);
                            ApplyEffectToObject(DurationType.Instant, missile, target);
                        });
                    }

                    var attackId = isHit ? 1 : 4;
                    var combatLogMessage = Combat.BuildCombatLogMessage(activator, target, attackId, chanceToHit);
                    Messaging.SendMessageNearbyToPlayers(target, combatLogMessage, 60f);

                    Enmity.ModifyEnmity(activator, target, damage);
                    CombatPoint.AddCombatPoint(activator, target, SkillType.Piloting);
                });
        }
    }
}
