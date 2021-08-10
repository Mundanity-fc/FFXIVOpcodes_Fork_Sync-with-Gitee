// Generated by https://github.com/zhyupe/ffxiv-opcode-worker

namespace FFXIVOpcodes.CN
{
    enum ServerLobbyIpcType : ushort
    {

    };

    enum ClientLobbyIpcType : ushort
    {

    };

    enum ServerZoneIpcType : ushort
    {
        ActorCast = 0x01E6,
        ActorControl = 0x008B,
        ActorControlSelf = 0x0190,
        ActorControlTarget = 0x032E,
        ActorGauge = 0x01F6,
        ActorMove = 0x01CB,
        ActorSetPos = 0x03D1,
        AirshipExplorationResult = 0x00A5,
        AirshipStatus = 0x03C9,
        AirshipStatusList = 0x0106,
        AoeEffect16 = 0x0110,
        AoeEffect24 = 0x03DC,
        AoeEffect32 = 0x03D5,
        AoeEffect8 = 0x00FF,
        CEDirector = 0x0308,
        CFNotify = 0x00EE,
        CFPreferredRole = 0x033D,
        ContainerInfo = 0x0149,
        CurrencyCrystalInfo = 0x0238,
        DesynthResult = 0x0335,
        Effect = 0x0085,
        EffectResult = 0x02D5,
        EventFinish = 0x0107,
        EventPlay = 0x014D,
        EventPlay4 = 0x00F1,
        EventStart = 0x02C1,
        Examine = 0x0334,
        ExamineSearchInfo = 0x02BF,
        FreeCompanyDialog = 0x0086,
        FreeCompanyInfo = 0x01E8,
        HousingWardInfo = 0x0141,
        InitZone = 0x036E,
        InventoryActionAck = 0x038E,
        InventoryTransaction = 0x0376,
        InventoryTransactionFinish = 0x00C9,
        ItemInfo = 0x0322,
        Logout = 0x039c,
        MarketBoardItemListing = 0x0315,
        MarketBoardItemListingCount = 0x00D8,
        MarketBoardItemListingHistory = 0x03E0,
        MarketBoardPurchase = 0x033E,
        MarketBoardSearchResult = 0x018A,
        MiniCactpotInit = 0x02DA,
        NpcSpawn = 0x00F0,
        ObjectSpawn = 0x03B5,
        PlaceFieldMarker = 0x0113,
        PlaceFieldMarkerPreset = 0x0298,
        PlayerSetup = 0x01BF,
        PlayerSpawn = 0x0323,
        PlayerStats = 0x01E5,
        Playtime = 0x01E9,
        PrepareZoning = 0x0318,
        ResultDialog = 0x0258,
        RetainerInformation = 0x019C,
        SomeDirectorUnk4 = 0x00BE,
        StatusEffectList = 0x0287,
        SubmarineExplorationResult = 0x03D3,
        SubmarineProgressionStatus = 0x009E,
        SubmarineStatusList = 0x00F2,
        UpdateClassInfo = 0x006F,
        UpdateHpMpTp = 0x01AC,
        UpdateInventorySlot = 0x0386,
        UpdateSearchInfo = 0x00E9,
    };

    enum ClientZoneIpcType : ushort
    {
        ChatHandler = 0x03CA,
        ClientTrigger = 0x03C1,
        InventoryModifyHandler = 0x01B1,
        MarketBoardPurchaseHandler = 0x02AC,
        SetSearchInfoHandler = 0x0221,
        UpdatePositionHandler = 0x03B2,
        UpdatePositionInstance = 0x01CB,
    };

    enum ServerChatIpcType : ushort
    {

    };

    enum ClientChatIpcType : ushort
    {

    };
}
