﻿namespace ow.Framework.IO.Network.Sync.Commands
{
    public enum SCSkill : byte
    {
        PassiveSkillReq = 0x6,
        PassiveSkillRes = 0x7,
        PassiveSkillEndReq = 0x5,
        ActiveSkillReq = 0x8,
        ActiveSkillRes = 0x9,
        ActiveSkillBt = 0x10,
        ActionSkillReq = 0x11,
        ActionSkillRes = 0x12,
        ActionSkillBt = 0x13,
        BuffUpdateBt = 0x14,
        BuffDeleteBt = 0x15,
        BuffChangeBt = 0x16,
        BuffDamageBt = 0x17,
        AuraUpdateBt = 0x18,
        BuffActiveBroachEffect = 0x19,
        CallOutSkillReq = 0x1A,
        CallOutSkillRes = 0x1B,
        CallOutSkillBt = 0x1C,
        AkashicRecordReq = 0x20,
        AkashicRecordRes = 0x21,
        AkashicRecordBt = 0x22,
        ProjectileReq = 0x31,
        ProjectileBt = 0x32,
        TrapPosUpdateReq = 0x33,
        TrapPosUpdateBt = 0x34,
        ProjectileAttachBt = 0x35,
        PreTargetList = 0x36,
        ChainReq = 0x37,
        ChainBt = 0x38,
        ChainUpdateTarget = 0x39,
        ProjectileUpdateTarget = 0x3A,
        ProjectileRemove = 0x3B,
        CombatType = 0x3C,
        SkillKeypressReq = 0x41,
        SkillKeypressBt = 0x42,
        SkillTargetChangeReq = 0x43,
        SkillTargetChangeBt = 0x44,
        SkillWarpPositionReq = 0x45,
        SkillWarpPositionBt = 0x46,
        SkillSyncPositionReq = 0x47,
        SkillSyncPositionBt = 0x48,
        SkillMoveWithTimeBt = 0x49,
        SkillSuboInputReq = 0x4A,
        SkillSuboInputBt = 0x4B,
        SkillChargingStart = 0x4C,
        SkillChargingStartBt = 0x4D,
        SkillChargingEnd = 0x4E,
        SkillChargingEndBt = 0x50,
        SkillChargingBothInputReq = 0x51,
        SkillChargingBothInputBt = 0x52,
        SkillMovingTarget = 0x53,
        DeckPageActive = 0x54,
        DeckPageName = 0x55,
        SkillDeckPageOpen = 0x56,
        SkillStartSoulViperBt = 0x61,
        SkillEndSoulViperBt = 0x62,
        SkillDelete = 0x63,
        SkillResetCooltime = 0x64,
        SkillLoadInfo = 0x70,
        SkillLearn = 0x71,
        SkillReset = 0x72,
        SkillUpdatePoint = 0x73,
        SkillLoadDeck = 0x74,
        SkillUpdateDeck = 0x75,
        SkillAddDeckSlot = 0x76,
        SkillDivergenceLearn = 0x77,
        GestureQuickSlot = 0x78,
        SkillDeckBonus = 0x79,
        SkillResetTaget = 0x7A,
        SkillSummonAkashic = 0x7B,
        SkillCooltimeReduce = 0x7C,
        SkillDefenceType = 0x7D,
        PassiveSkillCooltime = 0x7E,
    };
}
