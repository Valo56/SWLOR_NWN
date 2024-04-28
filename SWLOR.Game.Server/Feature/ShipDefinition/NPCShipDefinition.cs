﻿using System.Collections.Generic;
using SWLOR.Game.Server.Core.NWScript.Enum;
using SWLOR.Game.Server.Service.PerkService;
using SWLOR.Game.Server.Service.SpaceService;

namespace SWLOR.Game.Server.Feature.ShipDefinition
{
    public class NPCShipDefinition : IShipListDefinition
    {
        private readonly ShipBuilder _builder = new();
        public Dictionary<string, ShipDetail> BuildShips()
        {
            Tier1();
            Tier2();
            Tier3();
            Tier4();
            Tier5();

            return _builder.Build();
        }

        private void Tier1()
        {
            _builder.Create("NPC_Bomber1")
                .ItemResref("t1bomber")
                .Name("NPC - Septra Khanate Bomber")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(50)
                .MaxCapacitor(50)
                .MaxShield(50)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Cargo1")
                .ItemResref("t1cargo")
                .Name("NPC - Septra Khanate Scrap Hauler")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(80)
                .MaxCapacitor(50)
                .MaxShield(80)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Platform1")
                .ItemResref("t1platform")
                .Name("NPC - Septra Khanate Defense Platform")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(80)
                .MaxCapacitor(50)
                .MaxShield(80)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Fighter1")
                .ItemResref("t1fighter")
                .Name("NPC - Septra Khanate Fighter")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(40)
                .MaxCapacitor(50)
                .MaxShield(40)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Gunship1")
                .ItemResref("t1gunship")
                .Name("NPC - Septra Khanate Gunship")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(80)
                .MaxCapacitor(50)
                .MaxShield(80)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Interceptor1")
                .ItemResref("t1interceptor")
                .Name("NPC - Septra Khanate Interceptor")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(40)
                .MaxCapacitor(50)
                .MaxShield(40)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Capital1")
                .ItemResref("t1capital")
                .Name("NPC - Septra Khanate Raidmaster")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(200)
                .MaxCapacitor(1000)
                .MaxShield(200)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);
        }


        private void Tier2()
        {
            _builder.Create("NPC_Bomber2")
                .ItemResref("t2bomber")
                .Name("NPC - Krakenborne Bomber")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(80)
                .MaxCapacitor(100)
                .MaxShield(80)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Cargo2")
                .ItemResref("t2cargo")
                .Name("NPC - Krakenborne Trovehauler")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(120)
                .MaxCapacitor(50)
                .MaxShield(120)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Platform2")
                .ItemResref("t2platform")
                .Name("NPC - Krakenborne Defense Platform")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(120)
                .MaxCapacitor(50)
                .MaxShield(120)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Fighter2")
                .ItemResref("t2fighter")
                .Name("NPC - Krakenbornee Fighter")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(75)
                .MaxCapacitor(100)
                .MaxShield(75)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Gunship2")
                .ItemResref("t2gunship")
                .Name("NPC - Krakenborne Gunship")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(120)
                .MaxCapacitor(50)
                .MaxShield(120)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Interceptor2")
                .ItemResref("t2interceptor")
                .Name("NPC - Krakenborne Interceptor")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(75)
                .MaxCapacitor(100)
                .MaxShield(75)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Capital2")
                .ItemResref("t2capital")
                .Name("NPC - Krakenborne Privateer")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(300)
                .MaxCapacitor(1000)
                .MaxShield(300)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);
        }

        private void Tier3()
        {
            _builder.Create("NPC_Bomber3")
                .ItemResref("t3bomber")
                .Name("NPC - Snowdrift Syndicate Bomber")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(130)
                .MaxCapacitor(150)
                .MaxShield(130)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Cargo3")
                .ItemResref("t3cargo")
                .Name("NPC - Snowdrift Syndicate Frostvault")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(175)
                .MaxCapacitor(150)
                .MaxShield(175)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Platform3")
                .ItemResref("t3platform")
                .Name("NPC - Snowdrift Syndicate Defense Platform")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(175)
                .MaxCapacitor(150)
                .MaxShield(175)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Fighter3")
                .ItemResref("t3fighter")
                .Name("NPC - Snowdrift Syndicate Fighter")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(125)
                .MaxCapacitor(150)
                .MaxShield(125)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Gunship3")
                .ItemResref("t3gunship")
                .Name("NPC - Snowdrift Syndicate Gunship")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(175)
                .MaxCapacitor(150)
                .MaxShield(175)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Interceptor3")
                .ItemResref("t3interceptor")
                .Name("NPC - Snowdrift Syndicate Interceptor")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(125)
                .MaxCapacitor(150)
                .MaxShield(125)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Capital3")
                .ItemResref("t3capital")
                .Name("NPC - Snowdrift Syndicate Snowpiercer")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(450)
                .MaxCapacitor(1000)
                .MaxShield(450)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);
        }

        private void Tier4()
        {
            _builder.Create("NPC_Bomber4")
                .ItemResref("t4bomber")
                .Name("NPC - Clan Zel Arun Bomber")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(180)
                .MaxCapacitor(200)
                .MaxShield(180)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Cargo4")
                .ItemResref("t4cargo")
                .Name("NPC - Clan Zel Arun Treasure Barge")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(250)
                .MaxCapacitor(200)
                .MaxShield(250)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Platform4")
                .ItemResref("t4platform")
                .Name("NPC - Clan Zel Arun Defense Platform")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(250)
                .MaxCapacitor(200)
                .MaxShield(250)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Fighter4")
                .ItemResref("t4fighter")
                .Name("NPC - Clan Zel Arun Fighter")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(160)
                .MaxCapacitor(200)
                .MaxShield(160)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Gunship4")
                .ItemResref("t4gunship")
                .Name("NPC - Clan Zel Arun Gunship")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(250)
                .MaxCapacitor(200)
                .MaxShield(250)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Interceptor4")
                .ItemResref("t4interceptor")
                .Name("NPC - Clan Zel Arun Interceptor")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(160)
                .MaxCapacitor(200)
                .MaxShield(160)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Capital4")
                .ItemResref("t4capital")
                .Name("NPC - Clan Zel Arun Yacht")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(600)
                .MaxCapacitor(1000)
                .MaxShield(600)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);
        }

        private void Tier5()
        {
            _builder.Create("NPC_Bomber5")
                .ItemResref("t5bomber")
                .Name("NPC - Red Hand Bomber")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(250)
                .MaxCapacitor(250)
                .MaxShield(250)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Cargo5")
                .ItemResref("t5cargo")
                .Name("NPC - Red Hand Munitions Smuggler")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(350)
                .MaxCapacitor(250)
                .MaxShield(350)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Platform5")
                .ItemResref("t5platform")
                .Name("NPC - Red Hand Defense Platform")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(350)
                .MaxCapacitor(250)
                .MaxShield(350)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Fighter5")
                .ItemResref("t5fighter")
                .Name("NPC - Red Hand Fighter")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(225)
                .MaxCapacitor(250)
                .MaxShield(225)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Gunship5")
                .ItemResref("t5gunship")
                .Name("NPC - Red Hand Gunship")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(350)
                .MaxCapacitor(250)
                .MaxShield(350)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Interceptor5")
                .ItemResref("t5interceptor")
                .Name("NPC - Red Hand Interceptor")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(225)
                .MaxCapacitor(250)
                .MaxShield(225)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Capital5")
                .ItemResref("t5capital")
                .Name("NPC - Red Hand Marauder")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(1000)
                .MaxCapacitor(50)
                .MaxShield(1000)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Bomber6")
                .ItemResref("t6bomber")
                .Name("NPC - Imperial Bomber")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(400)
                .MaxCapacitor(300)
                .MaxShield(400)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Cargo6")
                .ItemResref("t6cargo")
                .Name("NPC - Imperial Logistics Vessel")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(550)
                .MaxCapacitor(300)
                .MaxShield(550)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Platform6")
                .ItemResref("t6platform")
                .Name("NPC - Imperial Defense Platform")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(550)
                .MaxCapacitor(300)
                .MaxShield(550)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Fighter6")
                .ItemResref("t6fighter")
                .Name("NPC - Imperial Fighter")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(650)
                .MaxCapacitor(300)
                .MaxShield(0)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Gunship6")
                .ItemResref("t6gunship")
                .Name("NPC - Imperial Gunship")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(550)
                .MaxCapacitor(300)
                .MaxShield(550)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_Interceptor6")
                .ItemResref("t6interceptor")
                .Name("NPC - Imperial Interceptor")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(375)
                .MaxCapacitor(300)
                .MaxShield(375)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_SithCap1")
                .ItemResref("sithcap1")
                .Name("NPC - Thranta Corvette")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(1000)
                .MaxCapacitor(5000)
                .MaxShield(1000)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_SithCap2")
                .ItemResref("sithcap2")
                .Name("NPC - Derriphan Destroyer")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(2500)
                .MaxCapacitor(5000)
                .MaxShield(0)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_SithCap3")
                .ItemResref("sithcap3")
                .Name("NPC - Inquisitor Assault Cruiser")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(2000)
                .MaxCapacitor(5000)
                .MaxShield(2000)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_SithCap4")
                .ItemResref("sithcap4")
                .Name("NPC - Interdictor Heavy Cruiser")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(3000)
                .MaxCapacitor(5000)
                .MaxShield(3000)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_SithCap5")
                .ItemResref("sithcap5")
                .Name("NPC - Centurion Battlecruiser")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(4500)
                .MaxCapacitor(5000)
                .MaxShield(4500)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_SithCap6")
                .ItemResref("sithcap6")
                .Name("NPC - Supremacy Battleship")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(6000)
                .MaxCapacitor(5000)
                .MaxShield(6000)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_SithCap7")
                .ItemResref("sithcap7")
                .Name("NPC - Harrower Dreadnought")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(9999)
                .MaxCapacitor(5000)
                .MaxShield(9999)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_MandoCap1")
                .ItemResref("mandocap1")
                .Name("NPC - Jahaveyir Cruiser")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(2000)
                .MaxCapacitor(5000)
                .MaxShield(2000)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_MandoCap2")
                .ItemResref("mandocap2")
                .Name("NPC - Kyramud Battleship")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(6000)
                .MaxCapacitor(5000)
                .MaxShield(6000)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);

            _builder.Create("NPC_MandoCap3")
                .ItemResref("mandocap3")
                .Name("NPC - Kandosii Dreadnought")
                .RequirePerk(PerkType.Starships, 0)
                .MaxArmor(9999)
                .MaxCapacitor(5000)
                .MaxShield(9999)
                .ShieldRechargeRate(1)
                .HighPowerNodes(8)
                .LowPowerNodes(8)
                .ShipConfigurationNodes(1);
        }
    }
}
