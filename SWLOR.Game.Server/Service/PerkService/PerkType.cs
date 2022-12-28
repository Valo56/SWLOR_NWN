﻿namespace SWLOR.Game.Server.Service.PerkService
{
    // Note: These IDs are tied to 2DAs. Don't reassign ID numbers unless you also update the 2DA files.
    // 2DA files: iprp_resperk.2da
    public enum PerkType
    {
        Invalid = 0,
        Doublehand = 1,
        DualWield = 2,
        WeaponFinesse = 3,
        WeaponFocusVibroblades = 4,
        ImprovedCriticalVibroblades = 5,
        VibrobladeProficiency = 6,
        VibrobladeMastery = 7,
        HackingBlade = 8,
        RiotBlade = 9,
        WeaponFocusFinesseVibroblades = 10,
        ImprovedCriticalFinesseVibroblades = 11,
        FinesseVibrobladeProficiency = 12,
        FinesseVibrobladeMastery = 13,
        PoisonStab = 14,
        Backstab = 15,
        WeaponFocusLightsabers = 16,
        ImprovedCriticalLightsabers = 17,
        LightsaberProficiency = 18,
        LightsaberMastery = 19,
        ForceLeap = 20,
        SaberStrike = 21,
        PowerAttack = 22,
        SuperiorWeaponFocus = 23,
        IncreasedMultiplier = 24,
        Cleave = 25,
        WeaponFocusHeavyVibroblades = 26,
        ImprovedCriticalHeavyVibroblades = 27,
        HeavyVibrobladeProficiency = 28,
        HeavyVibrobladeMastery = 29,
        CrescentMoon = 30,
        HardSlash = 31,
        WeaponFocusPolearms = 32,
        ImprovedCriticalPolearms = 33,
        PolearmProficiency = 34,
        PolearmMastery = 35,
        Skewer = 36,
        DoubleThrust = 37,
        WeaponFocusTwinBlades = 38,
        ImprovedCriticalTwinBlades = 39,
        TwinBladeProficiency = 40,
        TwinBladeMastery = 41,
        LegSweep = 42,
        CrossCut = 43,
        WeaponFocusSaberstaffs = 44,
        ImprovedCriticalSaberstaffs = 45,
        SaberstaffProficiency = 46,
        SaberstaffMastery = 47,
        CircleSlash = 48,
        DoubleStrike = 49,
        Knockdown = 50,
        Furor = 51,
        InnerStrength = 52,
        ImprovedTwoWeaponFightingOneHanded = 53,
        WeaponFocusKatars = 54,
        ImprovedCriticalKatars = 55,
        KatarProficiency = 56,
        KatarMastery = 57,
        ElectricFist = 58,
        StrikingCobra = 59,
        WeaponFocusStaves = 60,
        ImprovedCriticalStaves = 61,
        StaffProficiency = 62,
        StaffMastery = 63,
        Slam = 64,
        SpinningWhirl = 65,
        RapidShot = 66,
        RapidReload = 67,
        ZenMarksmanship = 68,
        PrecisionAim = 69,
        PointBlankShot = 70,
        WeaponFocusPistols = 71,
        ImprovedCriticalPistols = 72,
        PistolProficiency = 73,
        PistolMastery = 74,
        QuickDraw = 75,
        DoubleShot = 76,
        WeaponFocusThrowingWeapons = 77,
        ImprovedCriticalThrowingWeapons = 78,
        ThrowingWeaponProficiency = 79,
        ThrowingWeaponMastery = 80,
        ExplosiveToss = 81,
        PiercingToss = 82,
        WeaponFocusCannons = 83,
        ImprovedCriticalCannons = 84,
        CannonProficiency = 85,
        CannonMastery = 86,
        FullAuto = 87,
        HammerShot = 88,
        WeaponFocusRifles = 89,
        ImprovedCriticalRifles = 90,
        RifleProficiency = 91,
        RifleMastery = 92,
        TranquilizerShot = 93,
        CripplingShot = 94,
        ForcePush = 95,
        BurstOfSpeed = 96,
        ThrowLightsaber = 97,
        ForceStun = 98,
        ComprehendSpeech = 99,
        BattleInsight = 100,
        MindTrick = 101,
        CloakProficiency = 102,
        BeltProficiency = 103,
        RingProficiency = 104,
        NecklaceProficiency = 105,
        BreastplateProficiency = 106,
        HelmetProficiency = 107,
        BracerProficiency = 108,
        LeggingProficiency = 109,
        ShieldProficiency = 110,
        TunicProficiency = 111,
        CapProficiency = 112,
        GloveProficiency = 113,
        BootProficiency = 114,
        Resuscitation = 115,
        Starships = 116,
        DefensiveModules = 117,
        OffensiveModules = 118,
        EnergyManagement = 119,
        MiningModules = 120,
        StarshipMining = 121,
        RangedHealing = 122,
        FrugalMedic = 123,
        MedKit = 124,
        TreatmentKit = 125,
        Shielding = 126,
        OneHandedBlueprints = 127,
        TwoHandedBlueprints = 128,
        MartialBlueprints = 129,
        RangedBlueprints = 130,
        CityManagement = 131,
        ArmorBlueprints = 132,
        AccessoryBlueprints = 133,
        Upkeep = 134,
        ImprovedTwoWeaponFightingTwoHanded = 135,
        RapidSynthesisSmithery = 136,
        CarefulSynthesisSmithery = 137,
        BasicTouchSmithery = 138,
        StandardTouchSmithery = 139,
        PreciseTouchSmithery = 140,
        MastersMendSmithery = 141,
        SteadyHandSmithery = 142,
        MuscleMemorySmithery = 143,
        VenerationSmithery = 144,
        WasteNotSmithery = 145,
        RapidSynthesisFabrication = 146,
        CarefulSynthesisFabrication = 147,
        BasicTouchFabrication = 148,
        FurnitureBlueprints = 149,
        StructureBlueprints = 150,
        Chi = 151,
        StarshipBlueprints = 152,
        StandardTouchFabrication = 153,
        PreciseTouchFabrication = 154,
        MastersMendFabrication= 155,
        SteadyHandFabrication = 156,
        Harvesting = 157,
        Refining = 158,
        RefineryManagement = 159,
        Scavenging = 160,
        HardLook = 161,
        ForceHeal = 162,
        ForceBurst = 163,
        ForceBody = 164,
        ForceDrain = 165,
        ForceLightning = 166,
        ForceMind = 167,
        Traumatize = 168,
        KoltoRecovery = 169,
        StasisField = 170,
        CombatEnhancement = 171,
        Provoke = 172,
        Cover = 173,
        ShieldExpertise = 174,
        Ironclad = 175,
        Mobility = 176,
        MuscleMemoryFabrication = 177,
        VenerationFabrication = 178,
        WasteNotFabrication = 179,
        Dash = 180,
        TreasureHunter = 181,
        CreditFinder = 182,
        RapidSynthesisCooking = 183,
        CarefulSynthesisCooking = 184,
        BasicTouchCooking = 185,
        StandardTouchCooking = 186,
        PreciseTouchCooking = 187,
        MastersMendCooking = 188,
        SteadyHandCooking = 189,
        MuscleMemoryCooking = 190,
        VenerationCooking = 191,
        WasteNotCooking = 192,
        CookingRecipes = 193,
        RapidSynthesisEngineering = 194,
        CarefulSynthesisEngineering = 195,
        BasicTouchEngineering = 196,
        StandardTouchEngineering = 197,
        PreciseTouchEngineering = 198,
        MastersMendEngineering = 199,
        SteadyHandEngineering = 200,
        MuscleMemoryEngineering = 201,
        VenerationEngineering = 202,
        WasteNotEngineering = 203,
        FragGrenade = 204,
        ConcussionGrenade = 205,
        FlashbangGrenade = 206,
        IonGrenade = 207,
        KoltoGrenade = 208,
        AdhesiveGrenade = 209,
        SmokeBomb = 210,
        KoltoBomb = 211,
        IncendiaryBomb = 212,
        GasBomb = 213,
        StealthGenerator = 214,
        Flamethrower = 215,
        WristRocket = 216,
        DeflectorShield = 217,
        DemolitionExpert = 218,
        GuildRelations = 219,
        SmitheryEquipment = 220,
        EngineeringEquipment = 221,
        FabricationEquipment = 222,
        AgricultureEquipment = 223,
        EnhancementBlueprints = 224,
        StrongStyleLightsaber = 225,
        StrongStyleSaberstaff = 226,
        Premonition = 227,
        Disturbance = 228,
        Benevolence = 229,
        ForceValor = 230,
        ForceSpark = 231,
        CreepingTerror = 232,
        ForceRage = 233,
        DroidEquipmentBlueprints = 234,
        ThrowRock = 235,
        FlurryStyle = 236,
        CrushingStyle = 237,
        Duelist = 238,
        ShieldMaster = 239,
        WailingBlows = 240,
        DirtyBlow = 241,
        ShieldBash = 242,
        ForceInspiration = 243,
        Bulwark = 244,
        RousingShout = 245,
        Dedication = 246,
        SoldiersSpeed = 247,
        SoldiersStrike = 248,
        Charge = 249,
        SoldiersPrecision = 250,
        ShockingShout = 251,
        Rejuvenation = 252,
        FrenziedShout = 253,

        FishingRods = 257,
        ShoutRange = 258,
        ShieldResistance = 259,
        Infusion = 260,
    }
}
