﻿using System.Collections.Generic;
using SWLOR.Game.Server.Core.NWScript.Enum;
using SWLOR.Game.Server.Service.PerkService;
using SWLOR.Game.Server.Service.PropertyService;
using SWLOR.Game.Server.Service.SpaceService;

namespace SWLOR.Game.Server.Feature.ShipDefinition
{
    public class PlayerShipDefinition : IShipListDefinition
    {
        private readonly ShipBuilder _builder = new();

        public Dictionary<string, ShipDetail> BuildShips()
        {
            StoreBoughtShips();
            Tier1();
            Tier2();
            Tier3();
            Tier4();
            Tier5();

            return _builder.Build();
        }

        private void StoreBoughtShips()
        {
            _builder.Create("ShipDeedLightFreighter")
                .ItemResref("sdeed_freighter")
                .Name("Light Freighter")
                .Appearance(AppearanceType.SWLORShipRepublicForay)
                .RequirePerk(PerkType.Starships, 1)
                .MaxArmor(50)
                .MaxCapacitor(40)
                .MaxShield(50)
                .ShieldRechargeRate(4)
                .HighPowerNodes(2)
                .LowPowerNodes(3)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.LightFreighter1);

            _builder.Create("ShipDeedLightEscort")
                .Name("Light Escort")
                .Appearance(AppearanceType.SWLORShipRepublicAurek)
                .RequirePerk(PerkType.Starships, 1)
                .ItemResref("sdeed_escort")
                .MaxArmor(40)
                .MaxCapacitor(60)
                .MaxShield(40)
                .ShieldRechargeRate(4)
                .HighPowerNodes(3)
                .LowPowerNodes(2)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.LightEscort1);
        }

        private void Tier1()
        {
            _builder.Create("sdeed_striker")
                .ItemResref("sdeed_striker")
                .Name("Striker")
                .Appearance(AppearanceType.SWLORShipNeutralStriker)
                .RequirePerk(PerkType.Starships, 1)
                .MaxArmor(50)
                .MaxCapacitor(40)
                .MaxShield(50)
                .ShieldRechargeRate(4)
                .HighPowerNodes(3)
                .LowPowerNodes(4)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Striker);

            _builder.Create("sdeed_condor")
                .ItemResref("sdeed_condor")
                .Name("Condor")
                .Appearance(AppearanceType.SWLORShipNeutralCondor)
                .RequirePerk(PerkType.Starships, 1)
                .MaxArmor(40)
                .MaxCapacitor(60)
                .MaxShield(40)
                .ShieldRechargeRate(4)
                .HighPowerNodes(4)
                .LowPowerNodes(3)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Condor);
        }

        private void Tier2()
        {
            _builder.Create("sdeed_hound")
                .ItemResref("sdeed_hound")
                .Name("Hound")
                .Appearance(AppearanceType.SWLORShipRepublicStrikerC)
                .RequirePerk(PerkType.Starships, 2)
                .MaxArmor(100)
                .MaxCapacitor(80)
                .MaxShield(100)
                .ShieldRechargeRate(6)
                .HighPowerNodes(4)
                .LowPowerNodes(5)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Hound);

            _builder.Create("sdeed_panther")
                .ItemResref("sdeed_panther")
                .Name("Panther")
                .Appearance(AppearanceType.SWLORShipSithScoutA)
                .RequirePerk(PerkType.Starships, 2)
                .MaxArmor(80)
                .MaxCapacitor(120)
                .MaxShield(80)
                .ShieldRechargeRate(6)
                .HighPowerNodes(5)
                .LowPowerNodes(4)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Panther);
        }

        private void Tier3()
        {
            _builder.Create("sdeed_saber")
                .ItemResref("sdeed_saber")
                .Name("Saber")
                .Appearance(AppearanceType.SWLORShipRepublicScoutC)
                .RequirePerk(PerkType.Starships, 3)
                .MaxArmor(150)
                .MaxCapacitor(120)
                .MaxShield(150)
                .ShieldRechargeRate(8)
                .HighPowerNodes(5)
                .LowPowerNodes(6)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Saber);

            _builder.Create("sdeed_falchion")
                .ItemResref("sdeed_falchion")
                .Name("Falchion")
                .Appearance(AppearanceType.SWLORShipSithScoutC)
                .RequirePerk(PerkType.Starships, 3)
                .MaxArmor(120)
                .MaxCapacitor(180)
                .MaxShield(120)
                .ShieldRechargeRate(8)
                .HighPowerNodes(6)
                .LowPowerNodes(5)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Falchion);
        }

        private void Tier4()
        {
            _builder.Create("sdeed_mule")
                .ItemResref("sdeed_mule")
                .Name("Mule")
                .Appearance(AppearanceType.SWLORShipRepublicGunshipC)
                .RequirePerk(PerkType.Starships, 4)
                .MaxArmor(200)
                .MaxCapacitor(160)
                .MaxShield(200)
                .ShieldRechargeRate(10)
                .HighPowerNodes(5)
                .LowPowerNodes(6)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Mule);

            _builder.Create("sdeed_merchant")
                .ItemResref("sdeed_merchant")
                .Name("Merchant")
                .Appearance(AppearanceType.SWLORShipSithGunshipC)
                .RequirePerk(PerkType.Starships, 4)
                .MaxArmor(160)
                .MaxCapacitor(240)
                .MaxShield(160)
                .ShieldRechargeRate(10)
                .HighPowerNodes(6)
                .LowPowerNodes(5)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Merchant);
        }

        private void Tier5()
        {
            _builder.Create("sdeed_throne")
                .ItemResref("sdeed_throne")
                .Name("Throne")
                .Appearance(AppearanceType.SWLORShipSithInfiltratorA)
                .RequirePerk(PerkType.Starships, 5)
                .MaxArmor(250)
                .MaxCapacitor(200)
                .MaxShield(250)
                .ShieldRechargeRate(12)
                .HighPowerNodes(6)
                .LowPowerNodes(7)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Throne);

            _builder.Create("sdeed_consular")
                .ItemResref("sdeed_consular")
                .Name("Consular")
                .Appearance(AppearanceType.SWLORShipRepublicGunshipC)
                .RequirePerk(PerkType.Starships, 5)
                .MaxArmor(200)
                .MaxCapacitor(300)
                .MaxShield(200)
                .ShieldRechargeRate(12)
                .HighPowerNodes(7)
                .LowPowerNodes(6)
                .ShipConfigurationNodes(1)
                .InteriorLayout(PropertyLayoutType.Consular);
        }
    }
}
