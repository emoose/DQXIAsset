using System;
using System.Collections.Generic;
using System.Text;

namespace DQAsset
{
    //---------------------------------------------------------------------------
    // Enums
    //---------------------------------------------------------------------------

    // Enum JackGame.EJackActionEffectCategory
    public enum EJackActionEffectCategory : byte
    {
        EJackActionEffectCategory__Muzzle = 0,
        EJackActionEffectCategory__Default = 1,
        EJackActionEffectCategory__Hit = 2,
        EJackActionEffectCategory__Damage = 3,
        EJackActionEffectCategory__MAX = 4
    }


    // Enum JackGame.EJackActionEffectSpawnTargetType
    public enum EJackActionEffectSpawnTargetType : byte
    {
        EJackActionEffectSpawnTargetType__None = 0,
        EJackActionEffectSpawnTargetType__World = 1,
        EJackActionEffectSpawnTargetType__Movement = 2,
        EJackActionEffectSpawnTargetType__CasterActor = 3,
        EJackActionEffectSpawnTargetType__TargetActor = 4,
        EJackActionEffectSpawnTargetType__HitActor = 5,
        EJackActionEffectSpawnTargetType__Camera = 6,
        EJackActionEffectSpawnTargetType__MAX = 7
    }


    // Enum JackGame.EJackActionEffectAxis
    public enum EJackActionEffectAxis : byte
    {
        EJackActionEffectAxis__X = 0,
        EJackActionEffectAxis__Y = 1,
        EJackActionEffectAxis__Z = 2,
        EJackActionEffectAxis__X_Neg = 3,
        EJackActionEffectAxis__Y_Neg = 4,
        EJackActionEffectAxis__Z_Neg = 5,
        EJackActionEffectAxis__EJackActionEffectAxis_MAX = 6
    }


    // Enum JackGame.EJackActionEffectEvent
    public enum EJackActionEffectEvent : byte
    {
        EJackActionEffectEvent__None = 0,
        EJackActionEffectEvent__SpawnHitEffects = 1,
        EJackActionEffectEvent__NotifyActionHit = 2,
        EJackActionEffectEvent__DeactivateDefaultEffects = 3,
        EJackActionEffectEvent__CallBlueprintEvent = 4,
        EJackActionEffectEvent__Destroy = 5,
        EJackActionEffectEvent__MAX = 6
    }


    // Enum JackGame.EJackActionEffectDeactivateDefaultEffectTiming
    public enum EJackActionEffectDeactivateDefaultEffectTiming : byte
    {
        EJackActionEffectDeactivateDefaultEffectTiming__None = 0,
        EJackActionEffectDeactivateDefaultEffectTiming__MovementAttachProgressComplete = 1,
        EJackActionEffectDeactivateDefaultEffectTiming__MovementComplete = 2,
        EJackActionEffectDeactivateDefaultEffectTiming__SpawnHitEffect = 3,
        EJackActionEffectDeactivateDefaultEffectTiming__Event = 4,
        EJackActionEffectDeactivateDefaultEffectTiming__MAX = 5
    }


    // Enum JackGame.EJackActionEffectNotifyActionHitTiming
    public enum EJackActionEffectNotifyActionHitTiming : byte
    {
        EJackActionEffectNotifyActionHitTiming__None = 0,
        EJackActionEffectNotifyActionHitTiming__MovementAttachProgressComplete = 1,
        EJackActionEffectNotifyActionHitTiming__MovementComplete = 2,
        EJackActionEffectNotifyActionHitTiming__SpawnHitEffect = 3,
        EJackActionEffectNotifyActionHitTiming__Event = 4,
        EJackActionEffectNotifyActionHitTiming__MAX = 5
    }


    // Enum JackGame.EJackActionEffectSpawnHitEffectTiming
    public enum EJackActionEffectSpawnHitEffectTiming : byte
    {
        EJackActionEffectSpawnHitEffectTiming__None = 0,
        EJackActionEffectSpawnHitEffectTiming__MovementAttachProgressComplete = 1,
        EJackActionEffectSpawnHitEffectTiming__MovementComplete = 2,
        EJackActionEffectSpawnHitEffectTiming__PhysicsCollisionHit = 3,
        EJackActionEffectSpawnHitEffectTiming__Event = 4,
        EJackActionEffectSpawnHitEffectTiming__MAX = 5
    }


    // Enum JackGame.EJackEquippedWeaponStyle
    public enum EJackEquippedWeaponStyle : byte
    {
        EJackEquippedWeaponStyle__NOT = 0,
        EJackEquippedWeaponStyle__SWD = 1,
        EJackEquippedWeaponStyle__DGR = 2,
        EJackEquippedWeaponStyle__AXE = 3,
        EJackEquippedWeaponStyle__STK = 4,
        EJackEquippedWeaponStyle__BOO = 5,
        EJackEquippedWeaponStyle__TSW = 6,
        EJackEquippedWeaponStyle__SPR = 7,
        EJackEquippedWeaponStyle__ROD = 8,
        EJackEquippedWeaponStyle__CLW = 9,
        EJackEquippedWeaponStyle__WHP = 10,
        EJackEquippedWeaponStyle__DSW = 11,
        EJackEquippedWeaponStyle__DDG = 12,
        EJackEquippedWeaponStyle__DAX = 13,
        EJackEquippedWeaponStyle__DST = 14,
        EJackEquippedWeaponStyle__DBO = 15,
        EJackEquippedWeaponStyle__MAX = 16
    }


    // Enum JackGame.EJackCharacterCoordinateParts
    public enum EJackCharacterCoordinateParts : byte
    {
        EJackCharacterCoordinateParts__UpperBody = 0,
        EJackCharacterCoordinateParts__LowerBody = 1,
        EJackCharacterCoordinateParts__Face = 2,
        EJackCharacterCoordinateParts__Hair = 3,
        EJackCharacterCoordinateParts__Beard = 4,
        EJackCharacterCoordinateParts__Accessory = 5,
        EJackCharacterCoordinateParts__Cloth1 = 6,
        EJackCharacterCoordinateParts__Cloth2 = 7,
        EJackCharacterCoordinateParts__Cloth3 = 8,
        EJackCharacterCoordinateParts__MAX = 9
    }


    // Enum JackGame.EJackCharacterHiddenPurpose
    public enum EJackCharacterHiddenPurpose : byte
    {
        LVD = 0,
        CutScene = 1,
        Battle = 2,
        AnimNotify = 3,
        DestructibleActor = 4,
        BPRenkei = 5,
        Engine = 6,
        NPCSystem = 7,
        CharacterStatus = 8,
        ActionSystem = 9,
        BattleSystem = 10,
        BattleMonsterAppearance = 11,
        BattleRenkei = 12,
        BattleCamera = 13,
        BattleActionCamera = 14,
        BattlePause = 15,
        BattleAISM = 16,
        OutBattleField = 17,
        MonsterGenerator = 18,
        AnimSM = 19,
        Camera = 20,
        FPSCamera = 21,
        VehicleRide = 22,
        GuestNpc = 23,
        SnowMan = 24,
        DeactivateWeaponEffects = 25,
        CategoryHidden = 26,
        LoadReduction = 27,
        PhotoMode = 28,
        Rura = 29,
        MAX = 30
    }


    // Enum JackGame.EJackCharacterIgnoreCollisionPurpose
    public enum EJackCharacterIgnoreCollisionPurpose : byte
    {
        EJackCharacterIgnoreCollisionPurpose__LVD = 0,
        EJackCharacterIgnoreCollisionPurpose__CutScene = 1,
        EJackCharacterIgnoreCollisionPurpose__Battle = 2,
        EJackCharacterIgnoreCollisionPurpose__Gimmick = 3,
        EJackCharacterIgnoreCollisionPurpose__AnimNotify = 4,
        EJackCharacterIgnoreCollisionPurpose__BattleActionAttach = 5,
        EJackCharacterIgnoreCollisionPurpose__Engine = 6,
        EJackCharacterIgnoreCollisionPurpose__AnimSM = 7,
        EJackCharacterIgnoreCollisionPurpose__HiddenControl = 8,
        EJackCharacterIgnoreCollisionPurpose__PlayerPenetration = 9,
        EJackCharacterIgnoreCollisionPurpose__MAX = 10
    }


    // Enum JackGame.EJackCharacterControlChannel
    public enum EJackCharacterControlChannel : byte
    {
        EJackCharacterControlChannel__Global = 0,
        EJackCharacterControlChannel__Blueprint = 1,
        EJackCharacterControlChannel__Character = 2,
        EJackCharacterControlChannel__Controller = 3,
        EJackCharacterControlChannel__AnimNotify = 4,
        EJackCharacterControlChannel__Renkei = 5,
        EJackCharacterControlChannel__Action = 6,
        EJackCharacterControlChannel__BattleManager = 7,
        EJackCharacterControlChannel__BattleComponent = 8,
        EJackCharacterControlChannel__BattleAI = 9,
        EJackCharacterControlChannel__BattleResult = 10,
        EJackCharacterControlChannel__CutScene = 11,
        EJackCharacterControlChannel__AnimSM = 12,
        EJackCharacterControlChannel__AnimBP = 13,
        EJackCharacterControlChannel__PartyTalk = 14,
        EJackCharacterControlChannel__Triple = 15,
        EJackCharacterControlChannel__Debug = 16,
        EJackCharacterControlChannel__MAX = 17
    }


    // Enum JackGame.EJackCharacterCoordinateLoader
    public enum EJackCharacterCoordinateLoader : byte
    {
        EJackCharacterCoordinateLoader__SyncLoadAndFixup = 0,
        EJackCharacterCoordinateLoader__AsyncLoadAndFixup = 1,
        EJackCharacterCoordinateLoader__AsyncLoadOnly = 2,
        EJackCharacterCoordinateLoader__NoControl = 3,
        EJackCharacterCoordinateLoader__MAX = 4
    }


    // Enum JackGame.EJackCharacterCoordinateLayer
    public enum EJackCharacterCoordinateLayer : byte
    {
        EJackCharacterCoordinateLayer__Base = 0,
        EJackCharacterCoordinateLayer__Equipments = 1,
        EJackCharacterCoordinateLayer__Dressup = 2,
        EJackCharacterCoordinateLayer__ExtraEquipments = 3,
        EJackCharacterCoordinateLayer__CutScene = 4,
        EJackCharacterCoordinateLayer__MAX = 5
    }


    // Enum JackGame.EJackCharacterLookAtPurpose
    public enum EJackCharacterLookAtPurpose : byte
    {
        EJackCharacterLookAtPurpose__Gimmick = 0,
        EJackCharacterLookAtPurpose__AnimationState = 1,
        EJackCharacterLookAtPurpose__Renkei = 2,
        EJackCharacterLookAtPurpose__MAX = 3
    }


    // Enum JackGame.EJackCharacterCoordinateLODInfo
    public enum EJackCharacterCoordinateLODInfo : byte
    {
        EJackCharacterCoordinateLODInfo__Default = 0,
        EJackCharacterCoordinateLODInfo__CutScene = 1,
        EJackCharacterCoordinateLODInfo__MAX = 2
    }


    // Enum JackGame.EJackCharacterPausePurpose
    public enum EJackCharacterPausePurpose : byte
    {
        EJackCharacterPausePurpose__LVD = 0,
        EJackCharacterPausePurpose__Battle = 1,
        EJackCharacterPausePurpose__CutScene = 2,
        EJackCharacterPausePurpose__Engine = 3,
        EJackCharacterPausePurpose__CategoryHidden = 4,
        EJackCharacterPausePurpose__LoadReduction = 5,
        EJackCharacterPausePurpose__LoadReductionHidden = 6,
        EJackCharacterPausePurpose__MonsterReduction = 7,
        EJackCharacterPausePurpose__TickInterval = 8,
        EJackCharacterPausePurpose__BattleInitialize = 9,
        EJackCharacterPausePurpose__BattleCharacterManager = 10,
        EJackCharacterPausePurpose__BattleActionCamera = 11,
        EJackCharacterPausePurpose__BattleRenkei = 12,
        EJackCharacterPausePurpose__BattleNigeru = 13,
        EJackCharacterPausePurpose__MAX = 14
    }


    // Enum JackGame.EJackCharacterCollisionResponse
    public enum EJackCharacterCollisionResponse : byte
    {
        EJackCharacterCollisionResponse__Instance = 0,
        EJackCharacterCollisionResponse__DefaultObject = 1,
        EJackCharacterCollisionResponse__MAX = 2
    }


    // Enum JackGame.EJackActionExecStateType
    public enum EJackActionExecStateType : byte
    {
        EJackActionExecStateType__None = 0,
        EJackActionExecStateType__ActionStart = 1,
        EJackActionExecStateType__ActionAssistMove = 2,
        EJackActionExecStateType__ActionAssistJump = 3,
        EJackActionExecStateType__ActionCast = 4,
        EJackActionExecStateType__ActionShot = 5,
        EJackActionExecStateType__ActionBackJump = 6,
        EJackActionExecStateType__ActionBackMove = 7,
        EJackActionExecStateType__ActionWait = 8,
        EJackActionExecStateType__ActionBP = 9,
        EJackActionExecStateType__ActionEnd = 10,
        EJackActionExecStateType__ActionSpecial = 11,
        EJackActionExecStateType__ActionSpecial2 = 12,
        EJackActionExecStateType__ActionSpecial3 = 13,
        EJackActionExecStateType__ActionBP2 = 14,
        EJackActionExecStateType__ActionBP3 = 15,
        EJackActionExecStateType__MAX = 16
    }


    // Enum JackGame.EJackItem_Bag
    public enum EJackItem_Bag : byte
    {
        EJackItem_Bag__Bag_P001 = 0,
        EJackItem_Bag__Bag_P002 = 1,
        EJackItem_Bag__Bag_P003 = 2,
        EJackItem_Bag__Bag_P004 = 3,
        EJackItem_Bag__Bag_P005 = 4,
        EJackItem_Bag__Bag_P006 = 5,
        EJackItem_Bag__Bag_P007 = 6,
        EJackItem_Bag__Bag_P008 = 7,
        EJackItem_Bag__Bag_Common = 8,
        EJackItem_Bag__Bag_Equipment = 9,
        EJackItem_Bag__Bag_Daizinamono = 10,
        EJackItem_Bag__Bag_RecipeBook = 11,
        EJackItem_Bag__Bag_Exchange = 12,
        EJackItem_Bag__MAX = 13
    }


    // Enum JackGame.EJackActionRequestType
    public enum EJackActionRequestType : byte
    {
        EJackActionRequestType__None = 0,
        EJackActionRequestType__Turn = 1,
        EJackActionRequestType__Other = 2,
        EJackActionRequestType__MAX = 3
    }


    // Enum JackGame.EJackActionPlayType
    public enum EJackActionPlayType : byte
    {
        EJackActionPlayType__Default = 0,
        EJackActionPlayType__FieldMode = 1,
        EJackActionPlayType__PreviewMode = 2,
        EJackActionPlayType__MAX = 3
    }


    // Enum JackGame.EJackActionConsumeResultType
    public enum EJackActionConsumeResultType : byte
    {
        EJackActionConsumeResultType__None = 0,
        EJackActionConsumeResultType__Consume = 1,
        EJackActionConsumeResultType__NotConsume = 2,
        EJackActionConsumeResultType__MAX = 3
    }


    // Enum JackGame.EJackActionResultType
    public enum EJackActionResultType : byte
    {
        EJackActionResultType__None = 0,
        EJackActionResultType__Success = 1,
        EJackActionResultType__NotMP = 2,
        EJackActionResultType__Fuuin = 3,
        EJackActionResultType__NotConsume = 4,
        EJackActionResultType__Fail = 5,
        EJackActionResultType__MAX = 6
    }


    // Enum JackGame.EJackDataTableReferType
    public enum EJackDataTableReferType : byte
    {
        EJackDataTableReferType__DTR_None = 0,
        EJackDataTableReferType__DTR_Action = 1,
        EJackDataTableReferType__DTR_Item = 2,
        EJackDataTableReferType__DTR_MeosiSlotItem = 3,
        EJackDataTableReferType__DTR_MeosiSlotMonster = 4,
        EJackDataTableReferType__DTR_Monster = 5,
        EJackDataTableReferType__DTR_NPC = 6,
        EJackDataTableReferType__DTR_OddEffect = 7,
        EJackDataTableReferType__DTR_Renkei = 8,
        EJackDataTableReferType__MAX = 9
    }


    // Enum JackGame.EJackActionTextType
    public enum EJackActionTextType : byte
    {
        EJackActionTextType__None = 0,
        EJackActionTextType__ActionName = 1,
        EJackActionTextType__Description1 = 2,
        EJackActionTextType__Description3 = 3,
        EJackActionTextType__Description4 = 4,
        EJackActionTextType__Description5 = 5,
        EJackActionTextType__PreKoudou1 = 6,
        EJackActionTextType__PreKoudou2 = 7,
        EJackActionTextType__PreKoudou3 = 8,
        EJackActionTextType__Koudou = 9,
        EJackActionTextType__ActionYuukou = 10,
        EJackActionTextType__ActionYuukouSosei = 11,
        EJackActionTextType__ActionOddEffectSet = 12,
        EJackActionTextType__ActionOddEffectClear = 13,
        EJackActionTextType__ActionMukou = 14,
        EJackActionTextType__ActionMukouMahotora = 15,
        EJackActionTextType__ActionMukouHP = 16,
        EJackActionTextType__ActionMukouLife = 17,
        EJackActionTextType__ActionOddClearMukou = 18,
        EJackActionTextType__ActionConsumeMukou = 19,
        EJackActionTextType__ActionSibou = 20,
        EJackActionTextType__ActionCritical = 21,
        EJackActionTextType__ActionShotCritical = 22,
        EJackActionTextType__TurnStart = 23,
        EJackActionTextType__OddEffectYuukou = 24,
        EJackActionTextType__SindoNemuri = 25,
        EJackActionTextType__SindoKonran = 26,
        EJackActionTextType__OddEffectYuukouOverlap = 27,
        EJackActionTextType__OddEffectMukou = 28,
        EJackActionTextType__OddEffectMukouMAX = 29,
        EJackActionTextType__OddEffectMukouSindo = 30,
        EJackActionTextType__OddEffectMukouSindoKeep = 31,
        EJackActionTextType__OddEffectMukouOverlap = 32,
        EJackActionTextType__OddEffectMukouStatus = 33,
        EJackActionTextType__OddEffectSlideLimit = 34,
        EJackActionTextType__OddEffectClear = 35,
        EJackActionTextType__OddEffectClearMukou = 36,
        EJackActionTextType__OddEffectInvoke1 = 37,
        EJackActionTextType__OddEffectInvoke1Mukou = 38,
        EJackActionTextType__OddEffectInvoke2 = 39,
        EJackActionTextType__OddEffectInvoke2Mukou = 40,
        EJackActionTextType__OddEffectSibou = 41,
        EJackActionTextType__OddEffectYuukouReverse = 42,
        EJackActionTextType__BattleStart = 43,
        EJackActionTextType__RoundStart = 44,
        EJackActionTextType__Koudou2 = 45,
        EJackActionTextType__Description2 = 46,
        EJackActionTextType__MAX = 47
    }


    // Enum JackGame.EJackMessageScriptEventType
    public enum EJackMessageScriptEventType : byte
    {
        EJackMessageScriptEventType__Motion = 0,
        EJackMessageScriptEventType__FacialUpper = 1,
        EJackMessageScriptEventType__FacialLower = 2,
        EJackMessageScriptEventType__Voice = 3,
        EJackMessageScriptEventType__NoLipSync = 4,
        EJackMessageScriptEventType__ExclamationIcon = 5,
        EJackMessageScriptEventType__QuestionIcon = 6,
        EJackMessageScriptEventType__TurnPc = 7,
        EJackMessageScriptEventType__TurnCamera = 8,
        EJackMessageScriptEventType__RestoreTurn = 9,
        EJackMessageScriptEventType__MAX = 10
    }


    // Enum JackGame.EJackTextDelegateType
    public enum EJackTextDelegateType : byte
    {
        EJackTextDelegateType__PrintLineDidEnd = 0,
        EJackTextDelegateType__PrintPageDidEnd = 1,
        EJackTextDelegateType__PrintLastPageDidEnd = 2,
        EJackTextDelegateType__PrintTextDidEnd = 3,
        EJackTextDelegateType__StartPage = 4,
        EJackTextDelegateType__StartSerifuPage = 5,
        EJackTextDelegateType__StartSerifuPageEventFinish = 6,
        EJackTextDelegateType__EnterPage = 7,
        EJackTextDelegateType__ItemSelectionDidChange = 8,
        EJackTextDelegateType__ItemSelectionDidDecide = 9,
        EJackTextDelegateType__WindowClosed = 10,
        EJackTextDelegateType__EJackTextDelegateType_MAX = 11
    }


    // Enum JackGame.EJackBattleFukidasiTalkConditionType
    public enum EJackBattleFukidasiTalkConditionType : byte
    {
        EJackBattleFukidasiTalkConditionType__None = 0,
        EJackBattleFukidasiTalkConditionType__SakusenGangan = 1,
        EJackBattleFukidasiTalkConditionType__SakusenBattiri = 2,
        EJackBattleFukidasiTalkConditionType__SakusenIroiro = 3,
        EJackBattleFukidasiTalkConditionType__SakusenMP = 4,
        EJackBattleFukidasiTalkConditionType__SakusenInoti = 5,
        EJackBattleFukidasiTalkConditionType__SakusenMeirei = 6,
        EJackBattleFukidasiTalkConditionType__PlayerAdvantage = 7,
        EJackBattleFukidasiTalkConditionType__MonsterAdvantage = 8,
        EJackBattleFukidasiTalkConditionType__Critical = 9,
        EJackBattleFukidasiTalkConditionType__HPDamage = 10,
        EJackBattleFukidasiTalkConditionType__HPDamageNextFuki = 11,
        EJackBattleFukidasiTalkConditionType__HPPerUnder = 12,
        EJackBattleFukidasiTalkConditionType__MPPerUnder = 13,
        EJackBattleFukidasiTalkConditionType__HPPerOver = 14,
        EJackBattleFukidasiTalkConditionType__MPPerOver = 15,
        EJackBattleFukidasiTalkConditionType__HPOver = 16,
        EJackBattleFukidasiTalkConditionType__MPOver = 17,
        EJackBattleFukidasiTalkConditionType__HPUnder = 18,
        EJackBattleFukidasiTalkConditionType__MPUnder = 19,
        EJackBattleFukidasiTalkConditionType__OddEffectSet = 20,
        EJackBattleFukidasiTalkConditionType__OddEffectStatusSet = 21,
        EJackBattleFukidasiTalkConditionType__OddEffect = 22,
        EJackBattleFukidasiTalkConditionType__OddEffectStatus = 23,
        EJackBattleFukidasiTalkConditionType__InvokeOddEffect = 24,
        EJackBattleFukidasiTalkConditionType__TurnStartOddEffect = 25,
        EJackBattleFukidasiTalkConditionType__EventBattle = 26,
        EJackBattleFukidasiTalkConditionType__BattleChara = 27,
        EJackBattleFukidasiTalkConditionType__DeadMonster = 28,
        EJackBattleFukidasiTalkConditionType__DeadPlayer = 29,
        EJackBattleFukidasiTalkConditionType__NigeruFaild = 30,
        EJackBattleFukidasiTalkConditionType__Nusumu = 31,
        EJackBattleFukidasiTalkConditionType__Action = 32,
        EJackBattleFukidasiTalkConditionType__ActionNextFuki = 33,
        EJackBattleFukidasiTalkConditionType__GuardSuccess = 34,
        EJackBattleFukidasiTalkConditionType__ResFuki = 35,
        EJackBattleFukidasiTalkConditionType__AppearMetal = 36,
        EJackBattleFukidasiTalkConditionType__KilledMetal = 37,
        EJackBattleFukidasiTalkConditionType__ManyDead = 38,
        EJackBattleFukidasiTalkConditionType__LevelUp = 39,
        EJackBattleFukidasiTalkConditionType__NormalDrop = 40,
        EJackBattleFukidasiTalkConditionType__RareDrop = 41,
        EJackBattleFukidasiTalkConditionType__EnemyVeryStrong = 42,
        EJackBattleFukidasiTalkConditionType__NoInput = 43,
        EJackBattleFukidasiTalkConditionType__MonsterEncount = 44,
        EJackBattleFukidasiTalkConditionType__RoundCount = 45,
        EJackBattleFukidasiTalkConditionType__DeadAction = 46,
        EJackBattleFukidasiTalkConditionType__CharacterRoundCount = 47,
        EJackBattleFukidasiTalkConditionType__CharacterRoundOver = 48,
        EJackBattleFukidasiTalkConditionType__SPFlag = 49,
        EJackBattleFukidasiTalkConditionType__MAX = 50
    }


    // Enum JackGame.EJackBattleFukidasiTalkCondChara
    public enum EJackBattleFukidasiTalkCondChara : byte
    {
        EJackBattleFukidasiTalkCondChara__None = 0,
        EJackBattleFukidasiTalkCondChara__CondChara = 1,
        EJackBattleFukidasiTalkCondChara__NoCondChara = 2,
        EJackBattleFukidasiTalkCondChara__MAX = 3
    }


    // Enum JackGame.EJackBattleFukidasiTalkTarget
    public enum EJackBattleFukidasiTalkTarget : byte
    {
        EJackBattleFukidasiTalkTarget__None = 0,
        EJackBattleFukidasiTalkTarget__Party = 1,
        EJackBattleFukidasiTalkTarget__Friend = 2,
        EJackBattleFukidasiTalkTarget__Enemys = 3,
        EJackBattleFukidasiTalkTarget__Boss = 4,
        EJackBattleFukidasiTalkTarget__CharacterID = 5,
        EJackBattleFukidasiTalkTarget__OtherCharacter = 6,
        EJackBattleFukidasiTalkTarget__MonsterBig = 7,
        EJackBattleFukidasiTalkTarget__MonsterSmall = 8,
        EJackBattleFukidasiTalkTarget__MonsterMetal = 9,
        EJackBattleFukidasiTalkTarget__MonsterDance = 10,
        EJackBattleFukidasiTalkTarget__MonsterHorror = 11,
        EJackBattleFukidasiTalkTarget__MonsterInsect = 12,
        EJackBattleFukidasiTalkTarget__MonsterCat = 13,
        EJackBattleFukidasiTalkTarget__MonsterBird = 14,
        EJackBattleFukidasiTalkTarget__MonsterMagic = 15,
        EJackBattleFukidasiTalkTarget__MonsterWarrior = 16,
        EJackBattleFukidasiTalkTarget__MonsterMimic = 17,
        EJackBattleFukidasiTalkTarget__MonsterUru1 = 18,
        EJackBattleFukidasiTalkTarget__MonsterUru2 = 19,
        EJackBattleFukidasiTalkTarget__MonsterUru = 20,
        EJackBattleFukidasiTalkTarget__MonsterNiz = 21,
        EJackBattleFukidasiTalkTarget__MonsterHome = 22,
        EJackBattleFukidasiTalkTarget__MonsterKira = 23,
        EJackBattleFukidasiTalkTarget__MonsterYaruki = 24,
        EJackBattleFukidasiTalkTarget__MonsterTyui = 25,
        EJackBattleFukidasiTalkTarget__MonsterReisei = 26,
        EJackBattleFukidasiTalkTarget__MonsterAseri = 27,
        EJackBattleFukidasiTalkTarget__MonsterIkari = 28,
        EJackBattleFukidasiTalkTarget__MonsterKansya = 29,
        EJackBattleFukidasiTalkTarget__MonsterYorokobi = 30,
        EJackBattleFukidasiTalkTarget__MonsterKonran = 31,
        EJackBattleFukidasiTalkTarget__MAX = 32
    }


    // Enum JackGame.EJackBattleCameraCategory
    public enum EJackBattleCameraCategory : byte
    {
        EJackBattleCameraCategory__UnknownCamera = 0,
        EJackBattleCameraCategory__BattleStartMenuCamera = 1,
        EJackBattleCameraCategory__AutoCommandCamera = 2,
        EJackBattleCameraCategory__ActionCamera = 3,
        EJackBattleCameraCategory__MonsterAppearCamera = 4,
        EJackBattleCameraCategory__MAX = 5
    }


    // Enum JackGame.EJackBattleFieldEffectStatus
    public enum EJackBattleFieldEffectStatus : byte
    {
        EJackBattleFieldEffectStatus__None = 0,
        EJackBattleFieldEffectStatus__AkaiKiri = 1,
        EJackBattleFieldEffectStatus__Fubuki = 2,
        EJackBattleFieldEffectStatus__TokiWoUbau = 3,
        EJackBattleFieldEffectStatus__YamiHomerosu2 = 4,
        EJackBattleFieldEffectStatus__MAX = 5
    }


    // Enum JackGame.EJackBattleResult
    public enum EJackBattleResult : byte
    {
        EJackBattleResult__None = 0,
        EJackBattleResult__Win = 1,
        EJackBattleResult__Lose = 2,
        EJackBattleResult__Escape = 3,
        EJackBattleResult__MAX = 4
    }


    // Enum JackGame.EJackFadeColor
    public enum EJackFadeColor : byte
    {
        EJackFadeColor__Black = 0,
        EJackFadeColor__White = 1,
        EJackFadeColor__Red = 2,
        EJackFadeColor__MAX = 3
    }


    // Enum JackGame.EJackBattleFoliageDitherBattleFieldType
    public enum EJackBattleFoliageDitherBattleFieldType : byte
    {
        EJackBattleFoliageDitherBattleFieldType__Default = 0,
        EJackBattleFoliageDitherBattleFieldType__AutoCommandCamera = 1,
        EJackBattleFoliageDitherBattleFieldType__OtherCamera = 2,
        EJackBattleFoliageDitherBattleFieldType__MAX = 3
    }


    // Enum JackGame.EJackBattleFoliageDitherRangeType
    public enum EJackBattleFoliageDitherRangeType : byte
    {
        EJackBattleFoliageDitherRangeType__Default = 0,
        EJackBattleFoliageDitherRangeType__MonsterAppear = 1,
        EJackBattleFoliageDitherRangeType__ActionCamera = 2,
        EJackBattleFoliageDitherRangeType__MAX = 3
    }


    // Enum JackGame.EJackMight
    public enum EJackMight : byte
    {
        EJackMight__Unknown = 0,
        EJackMight__Player = 1,
        EJackMight__Monster = 2,
        EJackMight__MAX = 3
    }


    // Enum JackGame.EJackBattleAdditionalResourceType
    public enum EJackBattleAdditionalResourceType : byte
    {
        EJackBattleAdditionalResourceType__None = 0,
        EJackBattleAdditionalResourceType__KiokusousituP002Voice = 1,
        EJackBattleAdditionalResourceType__MAX = 2
    }


    // Enum JackGame.EJackBattlePreemptiveAttack
    public enum EJackBattlePreemptiveAttack : byte
    {
        EJackBattlePreemptiveAttack__None = 0,
        EJackBattlePreemptiveAttack__Player = 1,
        EJackBattlePreemptiveAttack__Monster = 2,
        EJackBattlePreemptiveAttack__MAX = 3
    }


    // Enum JackGame.EJackBattleEncount
    public enum EJackBattleEncount : byte
    {
        EJackBattleEncount__Symbol = 0,
        EJackBattleEncount__Random = 1,
        EJackBattleEncount__Event = 2,
        EJackBattleEncount__MAX = 3
    }


    // Enum JackGame.EJackHitStopPresetType
    public enum EJackHitStopPresetType : byte
    {
        EJackHitStopPresetType__None = 0,
        EJackHitStopPresetType__N_SS = 1,
        EJackHitStopPresetType__N_S = 2,
        EJackHitStopPresetType__N_M = 3,
        EJackHitStopPresetType__N_L = 4,
        EJackHitStopPresetType__N_LL = 5,
        EJackHitStopPresetType__SS_SS = 6,
        EJackHitStopPresetType__SS_S = 7,
        EJackHitStopPresetType__SS_M = 8,
        EJackHitStopPresetType__SS_L = 9,
        EJackHitStopPresetType__SS_LL = 10,
        EJackHitStopPresetType__S_S = 11,
        EJackHitStopPresetType__S_M = 12,
        EJackHitStopPresetType__S_L = 13,
        EJackHitStopPresetType__S_LL = 14,
        EJackHitStopPresetType__M_M = 15,
        EJackHitStopPresetType__M_L = 16,
        EJackHitStopPresetType__M_LL = 17,
        EJackHitStopPresetType__L_L = 18,
        EJackHitStopPresetType__L_LL = 19,
        EJackHitStopPresetType__LL_LL = 20,
        EJackHitStopPresetType__UN1 = 21,
        EJackHitStopPresetType__UN2 = 22,
        EJackHitStopPresetType__MAX = 23
    }


    // Enum JackGame.EJackInteractor
    public enum EJackInteractor : byte
    {
        EJackInteractor__Unknown = 0,
        EJackInteractor__Hero = 1,
        EJackInteractor__Hero_Fish = 2,
        EJackInteractor__NPC = 3,
        EJackInteractor__Uma = 4,
        EJackInteractor__Eggurobo = 5,
        EJackInteractor__Sukaruraida = 6,
        EJackInteractor__Doragonraida = 7,
        EJackInteractor__Biraida = 8,
        EJackInteractor__Dexyurahanraido = 9,
        EJackInteractor__Herukattya = 10,
        EJackInteractor__UrufuDoragon = 11,
        EJackInteractor__MeidenDooru = 12,
        EJackInteractor__KiRaaPansar = 13,
        EJackInteractor__SuraimuNaito = 14,
        EJackInteractor__Gorem = 15,
        EJackInteractor__Gondora = 16,
        EJackInteractor__MAX = 17
    }


    // Enum JackGame.EJackGamePlayerCondition
    public enum EJackGamePlayerCondition : byte
    {
        InputDisable = 0,
        MoveInputDisable = 1,
        LookInputDisabled = 2,
        JumpDisabled = 3,
        AutoRunDisabled = 4,
        DisplayMainMenuDisabled = 5,
        DisplayMiniMapDisabled = 6,
        DisplayWorldMapDisabled = 7,
        DisplayFukidasiDisabled = 8,
        DisplaySyouLocationTitleDisabled = 9,
        MovementDisabled = 10,
        FieldActionDisabled = 11,
        MoveActionDisabled = 12,
        BenriButtonActionDisabled = 13,
        DisplayActionGuideDisabled = 14,
        RuraDisabled = 15,
        RiremitoDisabled = 16,
        SymbolEncountDisabled = 17,
        MountAndUnmountVehicleDisabled = 18,
        DisplayNorimonoGaugeDisabled = 19,
        LazyMessageDisabled = 20,
        RunningDisabledWhileLoading = 21,
        RunningDisabled = 22,
        VehicleRunningDisabled = 23,
        HideControlGuideUI = 24,
        PhotoModeDisable = 25,
        MAX = 26
    }


    // Enum JackGame.EJackPlayerControlPossessor
    public enum EJackPlayerControlPossessor : byte
    {
        EJackPlayerControlPossessor__None = 0,
        EJackPlayerControlPossessor__Battle = 1,
        EJackPlayerControlPossessor__FieldAttack = 2,
        EJackPlayerControlPossessor__FieldAttackEncount = 3,
        EJackPlayerControlPossessor__ActionGuideHelpTrigger = 4,
        EJackPlayerControlPossessor__PlayerTriggerVolume = 5,
        EJackPlayerControlPossessor__NakamaKaiwa = 6,
        EJackPlayerControlPossessor__PhotoMode = 7,
        EJackPlayerControlPossessor__ActionGuideHelp = 8,
        EJackPlayerControlPossessor__Syougou = 9,
        EJackPlayerControlPossessor__Tyuuyakirikae = 10,
        EJackPlayerControlPossessor__FirstPersonViewCamera = 11,
        EJackPlayerControlPossessor__MenuHUD = 12,
        EJackPlayerControlPossessor__BenriButtonAction = 13,
        EJackPlayerControlPossessor__RandomEncount = 14,
        EJackPlayerControlPossessor__FieldAction = 15,
        EJackPlayerControlPossessor__VehicleSplash = 16,
        EJackPlayerControlPossessor__MiniGame = 17,
        EJackPlayerControlPossessor__Event = 18,
        EJackPlayerControlPossessor__DontGo = 19,
        EJackPlayerControlPossessor__SymbolEncount = 20,
        EJackPlayerControlPossessor__LazyMessage = 21,
        EJackPlayerControlPossessor__MapJump = 22,
        EJackPlayerControlPossessor__Rura = 23,
        EJackPlayerControlPossessor__VehicleSpawn = 24,
        EJackPlayerControlPossessor__ReturnToAutoSaveVolume = 25,
        EJackPlayerControlPossessor__MAX = 26
    }


    // Enum JackGame.EJackGamePlayerConditionControlPurpose
    public enum EJackGamePlayerConditionControlPurpose : byte
    {
        EJackGamePlayerConditionControlPurpose__Level = 0,
        EJackGamePlayerConditionControlPurpose__Battle = 1,
        EJackGamePlayerConditionControlPurpose__BattleCameraMode = 2,
        EJackGamePlayerConditionControlPurpose__Gimmick = 3,
        EJackGamePlayerConditionControlPurpose__Gimmick3Steps = 4,
        EJackGamePlayerConditionControlPurpose__MiniGame = 5,
        EJackGamePlayerConditionControlPurpose__SyougouKakutoku = 6,
        EJackGamePlayerConditionControlPurpose__TyuuyaKirikae = 7,
        EJackGamePlayerConditionControlPurpose__NakamaKaiwa = 8,
        EJackGamePlayerConditionControlPurpose__FieldAttack = 9,
        EJackGamePlayerConditionControlPurpose__BPControl = 10,
        EJackGamePlayerConditionControlPurpose__CharacterJump = 11,
        EJackGamePlayerConditionControlPurpose__VehicleJump = 12,
        EJackGamePlayerConditionControlPurpose__DebugCamera = 13,
        EJackGamePlayerConditionControlPurpose__FirstParsonCamera = 14,
        EJackGamePlayerConditionControlPurpose__HUD = 15,
        EJackGamePlayerConditionControlPurpose__Event = 16,
        EJackGamePlayerConditionControlPurpose__VehicleMount = 17,
        EJackGamePlayerConditionControlPurpose__VehicleSplash = 18,
        EJackGamePlayerConditionControlPurpose__InRuraRiremito = 19,
        EJackGamePlayerConditionControlPurpose__PlayingME = 20,
        EJackGamePlayerConditionControlPurpose__NPCTalk = 21,
        EJackGamePlayerConditionControlPurpose__ReturnToAutoSave = 22,
        EJackGamePlayerConditionControlPurpose__BattleSubSequence = 23,
        EJackGamePlayerConditionControlPurpose__System = 24,
        EJackGamePlayerConditionControlPurpose__VehicleSpawn = 25,
        EJackGamePlayerConditionControlPurpose__LevelVisibleVolume = 26,
        EJackGamePlayerConditionControlPurpose__MAX = 27
    }


    // Enum JackGame.EJackSenaHairStyle
    public enum EJackSenaHairStyle : byte
    {
        EJackSenaHairStyle__Long = 0,
        EJackSenaHairStyle__Short = 1,
        EJackSenaHairStyle__MAX = 2
    }


    // Enum JackGame.EJackWhaleCharacterForm
    public enum EJackWhaleCharacterForm : byte
    {
        EJackWhaleCharacterForm__Normal = 0,
        EJackWhaleCharacterForm__Enhanced = 1,
        EJackWhaleCharacterForm__MAX = 2
    }


    // Enum JackGame.EJackHeroCharacterForm
    public enum EJackHeroCharacterForm : byte
    {
        EJackHeroCharacterForm__Human = 0,
        EJackHeroCharacterForm__Fish = 1,
        EJackHeroCharacterForm__MAX = 2
    }


    // Enum JackGame.EJackPlayerControlCharacter
    public enum EJackPlayerControlCharacter : byte
    {
        EJackPlayerControlCharacter__Hero = 0,
        EJackPlayerControlCharacter__Ship = 1,
        EJackPlayerControlCharacter__Whale = 2,
        EJackPlayerControlCharacter__MAX = 3
    }


    // Enum JackGame.EJackVehicleModelId
    public enum EJackVehicleModelId : byte
    {
        EJackVehicleModelId__None = 0,
        EJackVehicleModelId__V001_E001 = 1,
        EJackVehicleModelId__V001_E002 = 2,
        EJackVehicleModelId__V001_E003 = 3,
        EJackVehicleModelId__V001_E004 = 4,
        EJackVehicleModelId__V001_E005 = 5,
        EJackVehicleModelId__V001_E006 = 6,
        EJackVehicleModelId__V011_E001 = 7,
        EJackVehicleModelId__V011_E002 = 8,
        EJackVehicleModelId__V012_E001 = 9,
        EJackVehicleModelId__V101_E001 = 10,
        EJackVehicleModelId__V101_E002 = 11,
        EJackVehicleModelId__V101_E003 = 12,
        EJackVehicleModelId__V102_E001 = 13,
        EJackVehicleModelId__V102_E002 = 14,
        EJackVehicleModelId__V102_E003 = 15,
        EJackVehicleModelId__V102_E004 = 16,
        EJackVehicleModelId__V103_E001 = 17,
        EJackVehicleModelId__V103_E002 = 18,
        EJackVehicleModelId__V103_E003 = 19,
        EJackVehicleModelId__V103_E004 = 20,
        EJackVehicleModelId__V104_E001 = 21,
        EJackVehicleModelId__V104_E002 = 22,
        EJackVehicleModelId__V104_E003 = 23,
        EJackVehicleModelId__V105_E001 = 24,
        EJackVehicleModelId__V105_E002 = 25,
        EJackVehicleModelId__V105_E003 = 26,
        EJackVehicleModelId__V106_E001 = 27,
        EJackVehicleModelId__V106_E002 = 28,
        EJackVehicleModelId__V106_E003 = 29,
        EJackVehicleModelId__V201_E001 = 30,
        EJackVehicleModelId__V201_E002 = 31,
        EJackVehicleModelId__V201_E003 = 32,
        EJackVehicleModelId__V201_E004 = 33,
        EJackVehicleModelId__V202_E001 = 34,
        EJackVehicleModelId__V202_E002 = 35,
        EJackVehicleModelId__V202_E003 = 36,
        EJackVehicleModelId__V202_E004 = 37,
        EJackVehicleModelId__V203_E001 = 38,
        EJackVehicleModelId__V203_E002 = 39,
        EJackVehicleModelId__V203_E003 = 40,
        EJackVehicleModelId__V204_E001 = 41,
        EJackVehicleModelId__V204_E002 = 42,
        EJackVehicleModelId__V204_E003 = 43,
        EJackVehicleModelId__V205_E001 = 44,
        EJackVehicleModelId__V205_E002 = 45,
        EJackVehicleModelId__V205_E003 = 46,
        EJackVehicleModelId__V205_E004 = 47,
        EJackVehicleModelId__MAX = 48
    }


    // Enum JackGame.EJackVehicle
    public enum EJackVehicle : byte
    {
        None = 0,
        Uma = 1, // Horse
        Eggurobo = 2, // Eggsoskeleton
        Sukaruraida = 3, // Skullrider's Steed
        Doragonraida = 4, // Dragon Rider
        Biraida = 5, // Horknight Hornet
        Dexyurahanraido = 6, // Headless Horseman Horse?
        Herukattya = 7, // Face Invader
        UrufuDoragon = 8,
        MeidenDooru = 9,
        KiRaaPansar = 10,
        SuraimuNaito = 11, // Slime Knight
        Gorem = 12,
        Gondora = 13,
        Ship = 14,
        Whale = 15,
        Sakana = 16,
        Player = 17,
        MAX = 18
    }


    // Enum JackGame.EJackBGMVolumeResult
    public enum EJackBGMVolumeResult : byte
    {
        EJackBGMVolumeResult__None = 0,
        EJackBGMVolumeResult__FirstInVolume = 1,
        EJackBGMVolumeResult__ChangeInVolume = 2,
        EJackBGMVolumeResult__LastOutVolume = 3,
        EJackBGMVolumeResult__InOverlapVolume = 4,
        EJackBGMVolumeResult__OutOverlapVolume = 5,
        EJackBGMVolumeResult__MAX = 6
    }


    // Enum JackGame.EJackMusicEvent
    public enum EJackMusicEvent : byte
    {
        EJackMusicEvent__BGMChanged = 0,
        EJackMusicEvent__MEPlayStart = 1,
        EJackMusicEvent__MEPlayFinished = 2,
        EJackMusicEvent__Destroy = 3,
        EJackMusicEvent__EJackMusicEvent_MAX = 4
    }


    // Enum JackGame.EJackLanguage
    public enum EJackLanguage : byte
    {
        EJackLanguage__Japanese = 0,
        EJackLanguage__TraditionalChinese = 1,
        EJackLanguage__SimplifiedChinese = 2,
        EJackLanguage__Korean = 3,
        EJackLanguage__EnglishGB = 4,
        EJackLanguage__French = 5,
        EJackLanguage__Italian = 6,
        EJackLanguage__German = 7,
        EJackLanguage__Spanish = 8,
        EJackLanguage__MAX = 9
    }


    // Enum JackGame.EJackSEADCategory
    public enum EJackSEADCategory : byte
    {
        EJackSEADCategory__Music = 0,
        EJackSEADCategory__ME = 1,
        EJackSEADCategory__SE_System = 2,
        EJackSEADCategory__SE_PC_Move = 3,
        EJackSEADCategory__SE_Monster_Move = 4,
        EJackSEADCategory__SE_Weather = 5,
        EJackSEADCategory__SE_FieldSound = 6,
        EJackSEADCategory__SE_Battle = 7,
        EJackSEADCategory__SE_CS = 8,
        EJackSEADCategory__SE_Door = 9,
        EJackSEADCategory__SE_IndoorSound = 10,
        EJackSEADCategory__SE_NPC_Move = 11,
        EJackSEADCategory__SE_Minigame = 12,
        EJackSEADCategory__SE_PC_Footstep = 13,
        EJackSEADCategory__SE_NPC_Footstep = 14,
        EJackSEADCategory__SE_MON_Footstep = 15,
        EJackSEADCategory__SE_Vehicle_Footstep = 16,
        EJackSEADCategory__SE_Vehicle_Move = 17,
        EJackSEADCategory__SE_OneOffEvent = 18,
        EJackSEADCategory__SE_IE = 19,
        EJackSEADCategory__SE_Torch = 20,
        EJackSEADCategory__SE_B020_Monster = 21,
        EJackSEADCategory__Voice = 22,
        EJackSEADCategory__Voice_P001 = 23,
        EJackSEADCategory__Voice_NakamaBTL = 24,
        EJackSEADCategory__MAX = 25
    }


    // Enum JackGame.EJackNPCActionTypeInBPControl
    public enum EJackNPCActionTypeInBPControl : byte
    {
        EJackNPCActionTypeInBPControl__NoAction = 0,
        EJackNPCActionTypeInBPControl__Turn = 1,
        EJackNPCActionTypeInBPControl__Animation = 2,
        EJackNPCActionTypeInBPControl__MAX = 3
    }


    // Enum JackGame.EJackCharacter
    public enum EJackCharacter : byte
    {
        EJackCharacter__P001 = 0,
        EJackCharacter__P002 = 1,
        EJackCharacter__P003 = 2,
        EJackCharacter__P004 = 3,
        EJackCharacter__P005 = 4,
        EJackCharacter__P006 = 5,
        EJackCharacter__P007 = 6,
        EJackCharacter__P008 = 7,
        EJackCharacter__GN00001 = 8,
        EJackCharacter__GN00002 = 9,
        EJackCharacter__GN00003 = 10,
        EJackCharacter__GN00004 = 11,
        EJackCharacter__GN00005 = 12,
        EJackCharacter__GN00006 = 13,
        EJackCharacter__GN00007 = 14,
        EJackCharacter__GN00008 = 15,
        EJackCharacter__GN00009 = 16,
        EJackCharacter__GN00010 = 17,
        EJackCharacter__GN00011 = 18,
        EJackCharacter__GN00012 = 19,
        EJackCharacter__GN00013 = 20,
        EJackCharacter__GN00014 = 21,
        EJackCharacter__GN00015 = 22,
        EJackCharacter__GN00016 = 23,
        EJackCharacter__GN00017 = 24,
        EJackCharacter__GN00018 = 25,
        EJackCharacter__GN00019 = 26,
        EJackCharacter__GN00020 = 27,
        EJackCharacter__GN00021 = 28,
        EJackCharacter__GN00022 = 29,
        EJackCharacter__GN00023 = 30,
        EJackCharacter__GN00024 = 31,
        EJackCharacter__GN00025 = 32,
        EJackCharacter__GN00026 = 33,
        EJackCharacter__GN00027 = 34,
        EJackCharacter__GN00028 = 35,
        EJackCharacter__GN00029 = 36,
        EJackCharacter__GN00030 = 37,
        EJackCharacter__GN00031 = 38,
        EJackCharacter__GN00032 = 39,
        EJackCharacter__GN00033 = 40,
        EJackCharacter__GN00034 = 41,
        EJackCharacter__GN00035 = 42,
        EJackCharacter__GN00036 = 43,
        EJackCharacter__GN00037 = 44,
        EJackCharacter__GN00038 = 45,
        EJackCharacter__GN00039 = 46,
        EJackCharacter__GN00040 = 47,
        EJackCharacter__GN00041 = 48,
        EJackCharacter__GN00042 = 49,
        EJackCharacter__GN00043 = 50,
        EJackCharacter__Unknown = 51,
        EJackCharacter__Anyone = 52,
        EJackCharacter__MAX = 53
    }


    // Enum JackGame.EJackPlayableMovement
    public enum EJackPlayableMovement : byte
    {
        EJackPlayableMovement__None = 0,
        EJackPlayableMovement__Default = 1,
        EJackPlayableMovement__Field = 2,
        EJackPlayableMovement__NavMesh = 3,
        EJackPlayableMovement__Osihiki = 4,
        EJackPlayableMovement__RopeClimb = 5,
        EJackPlayableMovement__SuriSuri = 6,
        EJackPlayableMovement__Tunawatari = 7,
        EJackPlayableMovement__GakeNobori = 8,
        EJackPlayableMovement__Ladder = 9,
        EJackPlayableMovement__V104Gake = 10,
        EJackPlayableMovement__Battle = 11,
        EJackPlayableMovement__UmaRace = 12,
        EJackPlayableMovement__MAX = 13
    }


    // Enum JackGame.EJackPlayableMovementDefault
    public enum EJackPlayableMovementDefault : byte
    {
        EJackPlayableMovementDefault__None = 0,
        EJackPlayableMovementDefault__Idle = 1,
        EJackPlayableMovementDefault__Shiver = 2,
        EJackPlayableMovementDefault__Heat = 3,
        EJackPlayableMovementDefault__Dance = 4,
        EJackPlayableMovementDefault__WindBreak = 5,
        EJackPlayableMovementDefault__ThrustWay = 6,
        EJackPlayableMovementDefault__MAX = 7
    }


    // Enum JackGame.EJackPipipiType
    public enum EJackPipipiType : byte
    {
        EJackPipipiType__None = 0,
        EJackPipipiType__Middle = 1,
        EJackPipipiType__Lowest = 2,
        EJackPipipiType__Lower = 3,
        EJackPipipiType__Higher = 4,
        EJackPipipiType__Highest = 5,
        EJackPipipiType__Default = 6,
        EJackPipipiType__Unknown = 7,
        EJackPipipiType__MAX = 8
    }


    // Enum JackGame.EJackPlayableMovementAnimMontage
    public enum EJackPlayableMovementAnimMontage : byte
    {
        EJackPlayableMovementAnimMontage__Wait = 0,
        EJackPlayableMovementAnimMontage__Turn = 1,
        EJackPlayableMovementAnimMontage__MAX = 2
    }


    // Enum JackGame.EJackLadderMovementState
    public enum EJackLadderMovementState : byte
    {
        EJackLadderMovementState__Idle = 0,
        EJackLadderMovementState__Up = 1,
        EJackLadderMovementState__Down = 2,
        EJackLadderMovementState__MAX = 3
    }


    // Enum JackGame.EJackVehicleShipAnim
    public enum EJackVehicleShipAnim : byte
    {
        EJackVehicleShipAnim__SHIP_SINK = 0,
        EJackVehicleShipAnim__SHIP_LEAP = 1,
        EJackVehicleShipAnim__MAX = 2
    }


    // Enum JackGame.EJackUnmountNaviCheckOffPurpose
    public enum EJackUnmountNaviCheckOffPurpose : byte
    {
        EJackUnmountNaviCheckOffPurpose__Volume = 0,
        EJackUnmountNaviCheckOffPurpose__MAX = 1
    }


    // Enum JackGame.EJackVehcileMonsterSplashScoketType
    public enum EJackVehcileMonsterSplashScoketType : byte
    {
        EJackVehcileMonsterSplashScoketType__Free = 0,
        EJackVehcileMonsterSplashScoketType__SnapToTarget = 1,
        EJackVehcileMonsterSplashScoketType__SnapLocationProjectXY = 2,
        EJackVehcileMonsterSplashScoketType__MAX = 3
    }


    // Enum JackGame.EJackMonsterFieldDamageReaction
    public enum EJackMonsterFieldDamageReaction : byte
    {
        EJackMonsterFieldDamageReaction__None = 0,
        EJackMonsterFieldDamageReaction__BlowAway = 1,
        EJackMonsterFieldDamageReaction__SwordDamage = 2,
        EJackMonsterFieldDamageReaction__GolemPunch = 3,
        EJackMonsterFieldDamageReaction__MAX = 4
    }


    // Enum JackGame.EJackActionGuide
    public enum EJackActionGuide : byte
    {
        EJackActionGuide__None = 0,
        EJackActionGuide__Normal = 1,
        EJackActionGuide__MAX = 2
    }


    // Enum JackGame.EJackActionCursor
    public enum EJackActionCursor : byte
    {
        EJackActionCursor__Arrow = 0,
        EJackActionCursor__ExclamationMark = 1,
        EJackActionCursor__NPCNormal = 2,
        EJackActionCursor__FieldAttackSword = 3,
        EJackActionCursor__FieldAttackBowgun = 4,
        EJackActionCursor__None = 5,
        EJackActionCursor__MAX = 6
    }


    // Enum JackGame.EJackKeys
    public enum EJackKeys : byte
    {
        EJackKeys__DPad_Up = 0,
        EJackKeys__DPad_Down = 1,
        EJackKeys__DPad_Left = 2,
        EJackKeys__DPad_Right = 3,
        EJackKeys__FaceButton_Top = 4,
        EJackKeys__FaceButton_Bottom = 5,
        EJackKeys__FaceButton_Left = 6,
        EJackKeys__FaceButton_Right = 7,
        EJackKeys__L1 = 8,
        EJackKeys__L2 = 9,
        EJackKeys__L3 = 10,
        EJackKeys__R1 = 11,
        EJackKeys__R2 = 12,
        EJackKeys__R3 = 13,
        EJackKeys__Start = 14,
        EJackKeys__Select = 15,
        EJackKeys__Keyboard_Up = 16,
        EJackKeys__Keyboard_Down = 17,
        EJackKeys__Keyboard_Left = 18,
        EJackKeys__Keyboard_Right = 19,
        EJackKeys__Keyboard_Enter = 20,
        EJackKeys__Keyboard_BackSpace = 21,
        EJackKeys__PhysicalButtonMax = 22,
        EJackKeys__Up = 23,
        EJackKeys__Down = 24,
        EJackKeys__Left = 25,
        EJackKeys__Right = 26,
        EJackKeys__Convenience = 27,
        EJackKeys__Cancel = 28,
        EJackKeys__Enter = 29,
        EJackKeys__Any = 30,
        EJackKeys__None = 31,
        EJackKeys__Invalid = 32,
        EJackKeys__MAX = 33
    }


    // Enum JackGame.EJackEquipmentRegion
    public enum EJackEquipmentRegion : byte
    {
        EJackEquipmentRegion__Unknown = 0,
        EJackEquipmentRegion__Handedness = 1,
        EJackEquipmentRegion__Hand = 2,
        EJackEquipmentRegion__Head = 3,
        EJackEquipmentRegion__Body = 4,
        EJackEquipmentRegion__Accessory1 = 5,
        EJackEquipmentRegion__Accessory2 = 6,
        EJackEquipmentRegion__MAX = 7
    }


    // Enum JackGame.EJackPassiveTokugiType
    public enum EJackPassiveTokugiType : byte
    {
        EJackPassiveTokugiType__Unknown = 0,
        EJackPassiveTokugiType__Tikara_Plus = 1,
        EJackPassiveTokugiType__Minomamori_Plus = 2,
        EJackPassiveTokugiType__Subayasa_Plus = 3,
        EJackPassiveTokugiType__Kiyousa_Plus = 4,
        EJackPassiveTokugiType__Miryoku_Plus = 5,
        EJackPassiveTokugiType__KougekiMaryoku_Plus = 6,
        EJackPassiveTokugiType__KaifukuMaryoku_Plus = 7,
        EJackPassiveTokugiType__MaxHP_Plus = 8,
        EJackPassiveTokugiType__MaxMP_Plus = 9,
        EJackPassiveTokugiType__Kougekiryoku_Plus = 10,
        EJackPassiveTokugiType__Syubiryoku_Plus = 11,
        EJackPassiveTokugiType__HPKyuuSyuuRate_Plus = 12,
        EJackPassiveTokugiType__MPKyuuSyuuRate_Plus = 13,
        EJackPassiveTokugiType__TateGuardRate_Plus = 14,
        EJackPassiveTokugiType__BukiGuardRate_Plus = 15,
        EJackPassiveTokugiType__MikawasiRate_Plus = 16,
        EJackPassiveTokugiType__CriticalRate_Plus = 17,
        EJackPassiveTokugiType__ZoneOnRate_Plus = 18,
        EJackPassiveTokugiType__MeityuuRate_Plus = 19,
        EJackPassiveTokugiType__ZoneEffect_Up = 20,
        EJackPassiveTokugiType__OddEffectSuccessRate_Up = 21,
        EJackPassiveTokugiType__NusumuRate_Up = 22,
        EJackPassiveTokugiType__SenrituVolume_Up = 23,
        EJackPassiveTokugiType__SenrituEffect_Up = 24,
        EJackPassiveTokugiType__HonooAndTutiResist_Up = 25,
        EJackPassiveTokugiType__KooriAndKazeResist_Up = 26,
        EJackPassiveTokugiType__HikariAndKaminariResist_Up = 27,
        EJackPassiveTokugiType__BattleWinMPRecover = 28,
        EJackPassiveTokugiType__GuardCounter = 29,
        EJackPassiveTokugiType__NioudatiNoKokoroe = 30,
        EJackPassiveTokugiType__NitouNoKokoroe = 31,
        EJackPassiveTokugiType__NitouNoGokui = 32,
        EJackPassiveTokugiType__KabauNoKokoroe = 33,
        EJackPassiveTokugiType__KabauNoGokui = 34,
        EJackPassiveTokugiType__YamabikoNoKokoroe = 35,
        EJackPassiveTokugiType__MAX = 36
    }


    // Enum JackGame.EJackGambit
    public enum EJackGambit : byte
    {
        EJackGambit__Battiriganbare = 0,
        EJackGambit__Ganganikouze = 1,
        EJackGambit__Iroiroyarouze = 2,
        EJackGambit__Inotidaizini = 3,
        EJackGambit__MPTukauna = 4,
        EJackGambit__Meireisasero = 5,
        EJackGambit__Renkeisiyouze = 6,
        EJackGambit__MAX = 7
    }


    // Enum JackGame.EJackGender
    public enum EJackGender : byte
    {
        EJackGender__Unknown = 0,
        EJackGender__Male = 1,
        EJackGender__Female = 2,
        EJackGender__MAX = 3
    }


    // Enum JackGame.EJackJob
    public enum EJackJob : byte
    {
        EJackJob__Unknown = 0,
        EJackJob__Yuusya = 1,
        EJackJob__Sensi = 2,
        EJackJob__Mahoutukai = 3,
        EJackJob__Souryo = 4,
        EJackJob__Tabigeinin = 5,
        EJackJob__Butouka = 6,
        EJackJob__Kenja = 7,
        EJackJob__Paradexin = 8,
        EJackJob__MAX = 9
    }


    // Enum JackGame.EJackPosition
    public enum EJackPosition : byte
    {
        EJackPosition__Vanguard = 0,
        EJackPosition__Unknown = 1,
        EJackPosition__Rearguard = 2,
        EJackPosition__MAX = 3
    }


    // Enum JackGame.EJackMapChangeSound
    public enum EJackMapChangeSound : byte
    {
        EJackMapChangeSound__SE_No_Sound = 0,
        EJackMapChangeSound__SE_Default = 1,
        EJackMapChangeSound__SE_Door_001 = 2,
        EJackMapChangeSound__SE_Door_002 = 3,
        EJackMapChangeSound__SE_Door_003 = 4,
        EJackMapChangeSound__SE_Door_004 = 5,
        EJackMapChangeSound__SE_Door_005 = 6,
        EJackMapChangeSound__SE_Door_006 = 7,
        EJackMapChangeSound__SE_Door_007 = 8,
        EJackMapChangeSound__SE_Door_008 = 9,
        EJackMapChangeSound__SE_Door_009 = 10,
        EJackMapChangeSound__SE_Door_010 = 11,
        EJackMapChangeSound__SE_Door_011 = 12,
        EJackMapChangeSound__SE_Door_012 = 13,
        EJackMapChangeSound__SE_Door_013 = 14,
        EJackMapChangeSound__SE_Door_014 = 15,
        EJackMapChangeSound__SE_Door_015 = 16,
        EJackMapChangeSound__SE_CS_Door_001 = 17,
        EJackMapChangeSound__SE_CS_Door_002 = 18,
        EJackMapChangeSound__SE_CS_Door_003 = 19,
        EJackMapChangeSound__SE_CS_Door_004 = 20,
        EJackMapChangeSound__SE_CS_Door_005 = 21,
        EJackMapChangeSound__SE_CS_Door_006 = 22,
        EJackMapChangeSound__SE_CS_Door_007 = 23,
        EJackMapChangeSound__MAX = 24
    }


    // Enum JackGame.EJackFadeTime
    public enum EJackFadeTime : byte
    {
        EJackFadeTime__Default = 0,
        EJackFadeTime__MapChange = 1,
        EJackFadeTime__CutsceneInOut = 2,
        EJackFadeTime__CutsceneInIn = 3,
        EJackFadeTime__CutsceneOutOut = 4,
        EJackFadeTime__CutsceneOutIn = 5,
        EJackFadeTime__BattleCutSceneOut = 6,
        EJackFadeTime__CutsceneSkip = 7,
        EJackFadeTime__InnSleepOut = 8,
        EJackFadeTime__InnSleepIn = 9,
        EJackFadeTime__Gimmick = 10,
        EJackFadeTime__UI = 11,
        EJackFadeTime__Event = 12,
        EJackFadeTime__EventBattle = 13,
        EJackFadeTime__ObjectVisibility = 14,
        EJackFadeTime__RuraRiremito = 15,
        EJackFadeTime__KujiraFune = 16,
        EJackFadeTime__VehicleMount = 17,
        EJackFadeTime__PartyTalk = 18,
        EJackFadeTime__MAX = 19
    }


    // Enum JackGame.EJackBGMControl
    public enum EJackBGMControl : byte
    {
        EJackBGMControl__Keep = 0,
        EJackBGMControl__Rewind = 1,
        EJackBGMControl__Stop = 2,
        EJackBGMControl__Pause = 3,
        EJackBGMControl__Nothing = 4,
        EJackBGMControl__EventBattle = 5,
        EJackBGMControl__Continue = 6,
        EJackBGMControl__MAX = 7
    }


    // Enum JackGame.EJackItem_Classification
    public enum EJackItem_Classification : byte
    {
        EJackItem_Classification__Unknown = 0,
        EJackItem_Classification__Sword = 1,
        EJackItem_Classification__Dagger = 2,
        EJackItem_Classification__Ax = 3,
        EJackItem_Classification__Stick = 4,
        EJackItem_Classification__Boomerang = 5,
        EJackItem_Classification__DoubleSword = 6,
        EJackItem_Classification__Spear = 7,
        EJackItem_Classification__Staff = 8,
        EJackItem_Classification__Claw = 9,
        EJackItem_Classification__Whip = 10,
        EJackItem_Classification__Shield = 11,
        EJackItem_Classification__LargeShield = 12,
        EJackItem_Classification__Clothes = 13,
        EJackItem_Classification__Armor = 14,
        EJackItem_Classification__Robe = 15,
        EJackItem_Classification__Hat = 16,
        EJackItem_Classification__Helmet = 17,
        EJackItem_Classification__FaceAccessory = 18,
        EJackItem_Classification__NeckAccessory = 19,
        EJackItem_Classification__FingerAccessory = 20,
        EJackItem_Classification__HandAccessory = 21,
        EJackItem_Classification__ArmAccessory = 22,
        EJackItem_Classification__ShoesAccessory = 23,
        EJackItem_Classification__FootAccessory = 24,
        EJackItem_Classification__EtcAccessory = 25,
        EJackItem_Classification__UsableItem = 26,
        EJackItem_Classification__Daizinamono = 27,
        EJackItem_Classification__Material = 28,
        EJackItem_Classification__RecipeBook = 29,
        EJackItem_Classification__Exchange = 30,
        EJackItem_Classification__MAX = 31
    }


    // Enum JackGame.EJackItemGetIcon
    public enum EJackItemGetIcon : byte
    {
        EJackItemGetIcon__Item = 0,
        EJackItemGetIcon__Gold = 1,
        EJackItemGetIcon__CasinoCoin = 2,
        EJackItemGetIcon__TiisanaMedal = 3,
        EJackItemGetIcon__Houzyu = 4,
        EJackItemGetIcon__MAX = 5
    }


    // Enum JackGame.EJackGameFlagCategory
    public enum EJackGameFlagCategory : byte
    {
        EJackGameFlagCategory__None = 0,
        EJackGameFlagCategory__All = 1,
        EJackGameFlagCategory__Global = 2,
        EJackGameFlagCategory__GameProgress = 3,
        EJackGameFlagCategory__System = 4,
        EJackGameFlagCategory__Scenario = 5,
        EJackGameFlagCategory__Quest = 6,
        EJackGameFlagCategory__CutScene = 7,
        EJackGameFlagCategory__Gimmick = 8,
        EJackGameFlagCategory__MiniGame = 9,
        EJackGameFlagCategory__Guide = 10,
        EJackGameFlagCategory__Temporary = 11,
        EJackGameFlagCategory__TalkCounter = 12,
        EJackGameFlagCategory__MapVisit = 13,
        EJackGameFlagCategory__BoukenGuide = 14,
        EJackGameFlagCategory__MAX = 15
    }


    // Enum JackGame.EJackPhotoModeEvent
    public enum EJackPhotoModeEvent : byte
    {
        EJackPhotoModeEvent__HideHudStart = 0,
        EJackPhotoModeEvent__HideHudEnd = 1,
        EJackPhotoModeEvent__PhotoModeStart_FadeStart = 2,
        EJackPhotoModeEvent__PhotoModeStart_FadeBlackOut = 3,
        EJackPhotoModeEvent__PhotoModeStart_FadeEnd = 4,
        EJackPhotoModeEvent__PhotoModeEnd_FadeStart = 5,
        EJackPhotoModeEvent__PhotoModeEnd_FadeBlackOut = 6,
        EJackPhotoModeEvent__PhotoModeEnd_FadeEnd = 7,
        EJackPhotoModeEvent__MAX = 8
    }


    // Enum JackGame.EJackPhotoModeEmote
    public enum EJackPhotoModeEmote : byte
    {
        EJackPhotoModeEmote__Hoimi = 0,
        EJackPhotoModeEmote__Mera = 1,
        EJackPhotoModeEmote__Hyado = 2,
        EJackPhotoModeEmote__Parupunte = 3,
        EJackPhotoModeEmote__MAX = 4
    }


    // Enum JackGame.EJackPhotoModeErrorCode
    public enum EJackPhotoModeErrorCode : byte
    {
        EJackPhotoModeErrorCode__None = 0,
        EJackPhotoModeErrorCode__Unkown = 1,
        EJackPhotoModeErrorCode__NoSupport = 2,
        EJackPhotoModeErrorCode__DiskFull = 3,
        EJackPhotoModeErrorCode__EJackPhotoModeErrorCode_MAX = 4
    }


    // Enum JackGame.EJackPhotoModeCommand
    public enum EJackPhotoModeCommand : byte
    {
        EJackPhotoModeCommand__None = 0,
        EJackPhotoModeCommand__Rearrange = 1,
        EJackPhotoModeCommand__LookAt = 2,
        EJackPhotoModeCommand__Setting = 3,
        EJackPhotoModeCommand__EmoteUp = 4,
        EJackPhotoModeCommand__EmoteLeft = 5,
        EJackPhotoModeCommand__EmoteRight = 6,
        EJackPhotoModeCommand__EmoteDown = 7,
        EJackPhotoModeCommand__EmoteCancel = 8,
        EJackPhotoModeCommand__TakePhoto = 9,
        EJackPhotoModeCommand__MAX = 10
    }


    // Enum JackGame.EJackSibari
    public enum EJackSibari : byte
    {
        EJackSibari__NoEscape = 0,
        EJackSibari__NoShopping = 1,
        EJackSibari__NoEquip = 2,
        EJackSibari__EveryoneShyCurse = 3,
        EJackSibari__ShyCurse = 4,
        EJackSibari__WipeGameOver = 5,
        EJackSibari__AllEnemyStrong = 6,
        EJackSibari__DowngradeEnemyExp0 = 7,
        EJackSibari__NPCTellsLie = 8,
        EJackSibari__AloneBattle = 9,
        EJackSibari__MAX = 10
    }


    // Enum JackGame.EJackScenarioTimeZone
    public enum EJackScenarioTimeZone : byte
    {
        EJackScenarioTimeZone__None = 0,
        EJackScenarioTimeZone__Morning = 1,
        EJackScenarioTimeZone__Daytime = 2,
        EJackScenarioTimeZone__Evening = 3,
        EJackScenarioTimeZone__Night = 4,
        EJackScenarioTimeZone__Midnight = 5,
        EJackScenarioTimeZone__EarlyMorning = 6,
        EJackScenarioTimeZone__MAX = 7
    }


    // Enum JackGame.EJackTimeZone
    public enum EJackTimeZone : byte
    {
        EJackTimeZone__Morning = 0,
        EJackTimeZone__Daytime = 1,
        EJackTimeZone__Evening = 2,
        EJackTimeZone__Night = 3,
        EJackTimeZone__MAX = 4
    }


    // Enum JackGame.EJackWorldTimePausePurpose
    public enum EJackWorldTimePausePurpose : byte
    {
        EJackWorldTimePausePurpose__Talk = 0,
        EJackWorldTimePausePurpose__Battle = 1,
        EJackWorldTimePausePurpose__Camp = 2,
        EJackWorldTimePausePurpose__Window = 3,
        EJackWorldTimePausePurpose__Cutscene = 4,
        EJackWorldTimePausePurpose__Scenario = 5,
        EJackWorldTimePausePurpose__FastForward = 6,
        EJackWorldTimePausePurpose__PartyTalk = 7,
        EJackWorldTimePausePurpose__FPSCamera = 8,
        EJackWorldTimePausePurpose__Gimmick = 9,
        EJackWorldTimePausePurpose__BenriAction = 10,
        EJackWorldTimePausePurpose__MapJump = 11,
        EJackWorldTimePausePurpose__PhotoMode = 12,
        EJackWorldTimePausePurpose__MAX = 13
    }


    // Enum JackGame.EJackUMGTextColorSet
    public enum EJackUMGTextColorSet : byte
    {
        EJackUMGTextColorSet__Tuujou = 0,
        EJackUMGTextColorSet__Mukou = 1,
        EJackUMGTextColorSet__StateEqual = 2,
        EJackUMGTextColorSet__StateUp = 3,
        EJackUMGTextColorSet__StateDown = 4,
        EJackUMGTextColorSet__Kaifuku = 5,
        EJackUMGTextColorSet__Active = 6,
        EJackUMGTextColorSet__Standby = 7,
        EJackUMGTextColorSet__HP50Percent = 8,
        EJackUMGTextColorSet__HP25Percent = 9,
        EJackUMGTextColorSet__Sibou = 10,
        EJackUMGTextColorSet__Tyuumoku = 11,
        EJackUMGTextColorSet__PaperTitleKoi = 12,
        EJackUMGTextColorSet__PaperTitleUsui = 13,
        EJackUMGTextColorSet__PaperTitleSmall = 14,
        EJackUMGTextColorSet__PaperNormal = 15,
        EJackUMGTextColorSet__Fukidasi = 16,
        EJackUMGTextColorSet__RarityS = 17,
        EJackUMGTextColorSet__RarityA = 18,
        EJackUMGTextColorSet__RarityB = 19,
        EJackUMGTextColorSet__RarityC = 20,
        EJackUMGTextColorSet__RarityD = 21,
        EJackUMGTextColorSet__RarityE = 22,
        EJackUMGTextColorSet__RarityF = 23,
        EJackUMGTextColorSet__BatoruRenkei = 24,
        EJackUMGTextColorSet__RenrekiCompRate = 25,
        EJackUMGTextColorSet__SmallLocationTitle = 26,
        EJackUMGTextColorSet__LocationTitle = 27,
        EJackUMGTextColorSet__MapLocationTitle = 28,
        EJackUMGTextColorSet__MapTextColor = 29,
        EJackUMGTextColorSet__MapLayer = 30,
        EJackUMGTextColorSet__MapLocationContact = 31,
        EJackUMGTextColorSet__CasinoExchange = 32,
        EJackUMGTextColorSet__NoEquipment = 33,
        EJackUMGTextColorSet__SkillHissatu = 34,
        EJackUMGTextColorSet__ZoneState = 35,
        EJackUMGTextColorSet__ScenarioFukidasi = 36,
        EJackUMGTextColorSet__VoiceDramaNormal = 37,
        EJackUMGTextColorSet__VoiceDramaGray = 38,
        EJackUMGTextColorSet__VoiceDramaLogYellow = 39,
        EJackUMGTextColorSet__VoiceDramaLogBlue = 40,
        EJackUMGTextColorSet__VoiceDramaFastForward = 41,
        EJackUMGTextColorSet__VoiceDramaPafupafu = 42,
        EJackUMGTextColorSet__MAX = 43
    }


    // Enum JackGame.EJackUMGAnimMove
    public enum EJackUMGAnimMove : byte
    {
        EJackUMGAnimMove__OffsetPosition = 0,
        EJackUMGAnimMove__ToPosition = 1,
        EJackUMGAnimMove__MAX = 2
    }


    // Enum JackGame.EJackUMGSnapType
    public enum EJackUMGSnapType : byte
    {
        EJackUMGSnapType__None = 0,
        EJackUMGSnapType__RightSide = 1,
        EJackUMGSnapType__UnderSide = 2,
        EJackUMGSnapType__UnderLeftSide = 3,
        EJackUMGSnapType__UnderRightSide = 4,
        EJackUMGSnapType__UpperSide = 5,
        EJackUMGSnapType__Overrap = 6,
        EJackUMGSnapType__UnderRightAlign = 7,
        EJackUMGSnapType__MAX = 8
    }


    // Enum JackGame.EJackUMGPresetAnim
    public enum EJackUMGPresetAnim : byte
    {
        EJackUMGPresetAnim__MainOpen = 0,
        EJackUMGPresetAnim__MainClose = 1,
        EJackUMGPresetAnim__PageOpen = 2,
        EJackUMGPresetAnim__PageClose = 3,
        EJackUMGPresetAnim__PageShow = 4,
        EJackUMGPresetAnim__PageHide = 5,
        EJackUMGPresetAnim__FadeIn = 6,
        EJackUMGPresetAnim__FadeOut = 7,
        EJackUMGPresetAnim__AddOpen = 8,
        EJackUMGPresetAnim__TypeMax = 9,
        EJackUMGPresetAnim__Default = 10,
        EJackUMGPresetAnim__None = 11,
        EJackUMGPresetAnim__EJackUMGPresetAnim_MAX = 12
    }


    // Enum JackGame.EJackSlotResultType
    public enum EJackSlotResultType : byte
    {
        EJackSlotResultType__None = 0,
        EJackSlotResultType__Slime = 1,
        EJackSlotResultType__Slime01 = 2,
        EJackSlotResultType__Slime02 = 3,
        EJackSlotResultType__SlimeKight = 4,
        EJackSlotResultType__SlimeKight01 = 5,
        EJackSlotResultType__SlimeKight02 = 6,
        EJackSlotResultType__SlimeTower = 7,
        EJackSlotResultType__SlimeTower01 = 8,
        EJackSlotResultType__SlimeTower02 = 9,
        EJackSlotResultType__KightSlime = 10,
        EJackSlotResultType__KightSlime01 = 11,
        EJackSlotResultType__KightSlime02 = 12,
        EJackSlotResultType__Bar = 13,
        EJackSlotResultType__Bar01 = 14,
        EJackSlotResultType__Bar02 = 15,
        EJackSlotResultType__Seven = 16,
        EJackSlotResultType__Seven01 = 17,
        EJackSlotResultType__Seven02 = 18,
        EJackSlotResultType__Free = 19,
        EJackSlotResultType__Free01 = 20,
        EJackSlotResultType__Free02 = 21,
        EJackSlotResultType__Fever = 22,
        EJackSlotResultType__Fever01 = 23,
        EJackSlotResultType__Fever02 = 24,
        EJackSlotResultType__Bounus = 25,
        EJackSlotResultType__Bounus01 = 26,
        EJackSlotResultType__Bounus02 = 27,
        EJackSlotResultType__Wild = 28,
        EJackSlotResultType__Wild01 = 29,
        EJackSlotResultType__Wild02 = 30,
        EJackSlotResultType__Slime03 = 31,
        EJackSlotResultType__SlimeKight03 = 32,
        EJackSlotResultType__SlimeTower03 = 33,
        EJackSlotResultType__KightSlime03 = 34,
        EJackSlotResultType__Bar03 = 35,
        EJackSlotResultType__Seven03 = 36,
        EJackSlotResultType__Free03 = 37,
        EJackSlotResultType__Fever03 = 38,
        EJackSlotResultType__Bounus03 = 39,
        EJackSlotResultType__Wild03 = 40,
        EJackSlotResultType__Bounus_Lose = 41,
        EJackSlotResultType__Bounus_Win = 42,
        EJackSlotResultType__MAX = 43
    }


    // Enum JackGame.EJackMiniGameSlotHand
    public enum EJackMiniGameSlotHand : byte
    {
        EJackMiniGameSlotHand__Slime = 0,
        EJackMiniGameSlotHand__SlimeKight = 1,
        EJackMiniGameSlotHand__SlimeTower = 2,
        EJackMiniGameSlotHand__KingSlime = 3,
        EJackMiniGameSlotHand__BAR = 4,
        EJackMiniGameSlotHand__Seven = 5,
        EJackMiniGameSlotHand__AngelSlime = 6,
        EJackMiniGameSlotHand__DanseJewelry = 7,
        EJackMiniGameSlotHand__DeviateSlime = 8,
        EJackMiniGameSlotHand__TreasureBox = 9,
        EJackMiniGameSlotHand__MetalSlime = 10,
        EJackMiniGameSlotHand__MetalRaider = 11,
        EJackMiniGameSlotHand__MetalBrothers = 12,
        EJackMiniGameSlotHand__MetalKing = 13,
        EJackMiniGameSlotHand__TripleBER = 14,
        EJackMiniGameSlotHand__MetalSeven = 15,
        EJackMiniGameSlotHand__MetalTreasureBox = 16,
        EJackMiniGameSlotHand__None = 17,
        EJackMiniGameSlotHand__MAX = 18
    }


    // Enum JackGame.EJackSlotSetNumberType
    public enum EJackSlotSetNumberType : byte
    {
        EJackSlotSetNumberType__Five = 0,
        EJackSlotSetNumberType__Four = 1,
        EJackSlotSetNumberType__Three = 2,
        EJackSlotSetNumberType__None = 3,
        EJackSlotSetNumberType__MAX = 4
    }


    // Enum JackGame.EJackSlotHitLineType
    public enum EJackSlotHitLineType : byte
    {
        EJackSlotHitLineType__CenterLine = 0,
        EJackSlotHitLineType__UpperLine = 1,
        EJackSlotHitLineType__LowerLine = 2,
        EJackSlotHitLineType__MAX = 3
    }


    // Enum JackGame.EJackSlotGameState
    public enum EJackSlotGameState : byte
    {
        EJackSlotGameState__Init = 0,
        EJackSlotGameState__Bet = 1,
        EJackSlotGameState__BetMain = 2,
        EJackSlotGameState__Game = 3,
        EJackSlotGameState__ReelStart = 4,
        EJackSlotGameState__QueenSlime = 5,
        EJackSlotGameState__ReelChangeAngelSlime = 6,
        EJackSlotGameState__ReelEnd = 7,
        EJackSlotGameState__ResultFreeSpin = 8,
        EJackSlotGameState__ResultMetalChange = 9,
        EJackSlotGameState__ResultTreasureBox = 10,
        EJackSlotGameState__ResultDividend = 11,
        EJackSlotGameState__ResultCoinUpdate = 12,
        EJackSlotGameState__ResultLose = 13,
        EJackSlotGameState__ResultSelect = 14,
        EJackSlotGameState__MetalChangeEnd = 15,
        EJackSlotGameState__FreeSpinEnd = 16,
        EJackSlotGameState__RevertAngelSlime = 17,
        EJackSlotGameState__Retry = 18,
        EJackSlotGameState__FadeOut = 19,
        EJackSlotGameState__End = 20,
        EJackSlotGameState__FreeSpinStartMessage = 21,
        EJackSlotGameState__JackPotStart = 22,
        EJackSlotGameState__MAX = 23
    }


    // Enum JackGame.EJackBGMDiscVersion
    public enum EJackBGMDiscVersion : byte
    {
        EJackBGMDiscVersion__GoldDisc = 0,
        EJackBGMDiscVersion__OrchestraDisc = 1,
        EJackBGMDiscVersion__MAX = 2
    }


    // Enum JackGame.EJackAudioVolume
    public enum EJackAudioVolume : byte
    {
        EJackAudioVolume__Volume_Mute = 0,
        EJackAudioVolume__Volume = 1,
        EJackAudioVolume__Volume01 = 2,
        EJackAudioVolume__Volume02 = 3,
        EJackAudioVolume__Volume03 = 4,
        EJackAudioVolume__Volume04 = 5,
        EJackAudioVolume__Volume05 = 6,
        EJackAudioVolume__Volume06 = 7,
        EJackAudioVolume__Volume07 = 8,
        EJackAudioVolume__Volume08 = 9,
        EJackAudioVolume__Volume09 = 10,
        EJackAudioVolume__MAX = 11
    }


    // Enum JackGame.EJackMiniGameRouletteMenuSequenceEnum
    public enum EJackMiniGameRouletteMenuSequenceEnum : byte
    {
        EJackMiniGameRouletteMenuSequenceEnum__Init = 0,
        EJackMiniGameRouletteMenuSequenceEnum__ResultSelect = 1,
        EJackMiniGameRouletteMenuSequenceEnum__ResultStart = 2,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemo = 3,
        EJackMiniGameRouletteMenuSequenceEnum__ResultTreasureCoin = 4,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoWin = 5,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoLose = 6,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoJackPot = 7,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoJackPotMessage = 8,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoCoinGetMessage = 9,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoCoinMove = 10,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoCoinGet = 11,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoCoinUp = 12,
        EJackMiniGameRouletteMenuSequenceEnum__ResultDemoRetryMessage = 13,
        EJackMiniGameRouletteMenuSequenceEnum__Tutorial = 14,
        EJackMiniGameRouletteMenuSequenceEnum__StartMessage = 15,
        EJackMiniGameRouletteMenuSequenceEnum__GameBet = 16,
        EJackMiniGameRouletteMenuSequenceEnum__ToGame = 17,
        EJackMiniGameRouletteMenuSequenceEnum__EndQuestion = 18,
        EJackMiniGameRouletteMenuSequenceEnum__Finished = 19,
        EJackMiniGameRouletteMenuSequenceEnum__BetStart = 20,
        EJackMiniGameRouletteMenuSequenceEnum__MAX = 21
    }


    // Enum JackGame.EJackOmakeMessageState
    public enum EJackOmakeMessageState : byte
    {
        EJackOmakeMessageState__None = 0,
        EJackOmakeMessageState__Open = 1,
        EJackOmakeMessageState__Close = 2,
        EJackOmakeMessageState__Message = 3,
        EJackOmakeMessageState__MessageScrollCheck = 4,
        EJackOmakeMessageState__MessageScroll = 5,
        EJackOmakeMessageState__KeyWait = 6,
        EJackOmakeMessageState__EndKeyWait = 7,
        EJackOmakeMessageState__SelectWindowOpen = 8,
        EJackOmakeMessageState__SelectWindowUpdate = 9,
        EJackOmakeMessageState__SelectWindowClose = 10,
        EJackOmakeMessageState__Max = 11
    }


    // Enum JackGame.EJackWorldWindLevel
    public enum EJackWorldWindLevel : byte
    {
        EJackWorldWindLevel__Calm = 0,
        EJackWorldWindLevel__Weak = 1,
        EJackWorldWindLevel__Middle = 2,
        EJackWorldWindLevel__Strong = 3,
        EJackWorldWindLevel__MAX = 4
    }


    // Enum JackGame.EJackWorldWeather
    public enum EJackWorldWeather : byte
    {
        EJackWorldWeather__ClearAndSunny = 0,
        EJackWorldWeather__Sunny = 1,
        EJackWorldWeather__Cloudy = 2,
        EJackWorldWeather__LightRain = 3,
        EJackWorldWeather__Rain = 4,
        EJackWorldWeather__HeavyRain = 5,
        EJackWorldWeather__Thunderstorm = 6,
        EJackWorldWeather__Snow = 7,
        EJackWorldWeather__Snowstorm = 8,
        EJackWorldWeather__Fog = 9,
        EJackWorldWeather__HeavyFog = 10,
        EJackWorldWeather__MAX = 11
    }


    // Enum JackGame.EJackUIPlatformType
    public enum EJackUIPlatformType : byte
    {
        EJackUIPlatformType__Unknow = 0,
        EJackUIPlatformType__Other = 1,
        EJackUIPlatformType__Windows = 2,
        EJackUIPlatformType__PS4 = 3,
        EJackUIPlatformType__Switch = 4,
        EJackUIPlatformType__XboxOne = 5,
        EJackUIPlatformType__Steam = 6,
        EJackUIPlatformType__MSStore = 7,
        EJackUIPlatformType__EpicStore = 8,
        EJackUIPlatformType__Stadia = 9,
        EJackUIPlatformType__MAX = 10
    }


    // Enum JackGame.EJackUIStickMode
    public enum EJackUIStickMode : byte
    {
        EJackUIStickMode__AnalogStickMode = 0,
        EJackUIStickMode__DirectionKeyMode = 1,
        EJackUIStickMode__MAX = 2
    }


    // Enum JackGame.EJackPopupBalloon
    public enum EJackPopupBalloon : byte
    {
        EJackPopupBalloon__Default = 0,
        EJackPopupBalloon__DamagePlayer = 1,
        EJackPopupBalloon__DamageMonster = 2,
        EJackPopupBalloon__CriticalDamagePlayer = 3,
        EJackPopupBalloon__CriticalDamageMonster = 4,
        EJackPopupBalloon__RecoverHP = 5,
        EJackPopupBalloon__RecoverMP = 6,
        EJackPopupBalloon__Miss = 7,
        EJackPopupBalloon__DamageMP = 8,
        EJackPopupBalloon__DamageHPMiss = 9,
        EJackPopupBalloon__DamageMPMiss = 10,
        EJackPopupBalloon__RecoverHPMiss = 11,
        EJackPopupBalloon__RecoverMPMiss = 12,
        EJackPopupBalloon__KaziDamage = 13,
        EJackPopupBalloon__KaziRecover = 14,
        EJackPopupBalloon__KaziMiss = 15,
        EJackPopupBalloon__MAX = 16
    }


    // Enum JackGame.EJackUMGWindowCursorMoveMode
    public enum EJackUMGWindowCursorMoveMode : byte
    {
        EJackUMGWindowCursorMoveMode__EffectiveDirection = 0,
        EJackUMGWindowCursorMoveMode__ZeroAngle = 1,
        EJackUMGWindowCursorMoveMode__MoveDisable = 2,
        EJackUMGWindowCursorMoveMode__InputDisable = 3,
        EJackUMGWindowCursorMoveMode__MAX = 4
    }


    // Enum JackGame.EJackUMGMenuBGMode
    public enum EJackUMGMenuBGMode : byte
    {
        EJackUMGMenuBGMode__None = 0,
        EJackUMGMenuBGMode__Hide = 1,
        EJackUMGMenuBGMode__ShowDouguBG = 2,
        EJackUMGMenuBGMode__ShowShopBuyBG = 3,
        EJackUMGMenuBGMode__ShowShopSellBG = 4,
        EJackUMGMenuBGMode__MAX = 5
    }


    // Enum JackGame.EJackUMGItemActionCommand
    public enum EJackUMGItemActionCommand : byte
    {
        EJackUMGItemActionCommand__None = 0,
        EJackUMGItemActionCommand__Use = 1,
        EJackUMGItemActionCommand__Equipment = 2,
        EJackUMGItemActionCommand__Pass = 3,
        EJackUMGItemActionCommand__Remove = 4,
        EJackUMGItemActionCommand__Buy = 5,
        EJackUMGItemActionCommand__Sell = 6,
        EJackUMGItemActionCommand__DouguSeiri = 7,
        EJackUMGItemActionCommand__EquipmentWithRegion = 8,
        EJackUMGItemActionCommand__EquipmentDetach = 9,
        EJackUMGItemActionCommand__Add = 10,
        EJackUMGItemActionCommand__Swap = 11,
        EJackUMGItemActionCommand__Store = 12,
        EJackUMGItemActionCommand__MAX = 13
    }


    // Enum JackGame.EJackUMGItemFind
    public enum EJackUMGItemFind : byte
    {
        EJackUMGItemFind__All = 0,
        EJackUMGItemFind__Equipped = 1,
        EJackUMGItemFind__NoEquipment = 2,
        EJackUMGItemFind__MAX = 3
    }


    // Enum JackGame.EJackActionIconType
    public enum EJackActionIconType : byte
    {
        EJackActionIconType__None = 0,
        EJackActionIconType__Bouken = 1,
        EJackActionIconType__Jakutai = 2,
        EJackActionIconType__Kaifuku = 3,
        EJackActionIconType__Kougeki = 4,
        EJackActionIconType__Sien = 5,
        EJackActionIconType__MAX = 6
    }


    // Enum JackGame.EJackItem_DiscardType
    public enum EJackItem_DiscardType : byte
    {
        EJackItem_DiscardType__Unknown = 0,
        EJackItem_DiscardType__NG = 1,
        EJackItem_DiscardType__OK = 2,
        EJackItem_DiscardType__NeedConfirmation1 = 3,
        EJackItem_DiscardType__NeedConfirmation2 = 4,
        EJackItem_DiscardType__MAX = 5
    }


    // Enum JackGame.EJackUMGItemPlacedAcquisition
    public enum EJackUMGItemPlacedAcquisition : byte
    {
        EJackUMGItemPlacedAcquisition__BukiShop = 0,
        EJackUMGItemPlacedAcquisition__BouguShop = 1,
        EJackUMGItemPlacedAcquisition__BukiBouguShop = 2,
        EJackUMGItemPlacedAcquisition__DouguShop = 3,
        EJackUMGItemPlacedAcquisition__YorozuShop = 4,
        EJackUMGItemPlacedAcquisition__GyousyouninShop = 5,
        EJackUMGItemPlacedAcquisition__Casino = 6,
        EJackUMGItemPlacedAcquisition__Medal = 7,
        EJackUMGItemPlacedAcquisition__UmaRace = 8,
        EJackUMGItemPlacedAcquisition__Kira = 9,
        EJackUMGItemPlacedAcquisition__GmmickDrop = 10,
        EJackUMGItemPlacedAcquisition__MonsterDrop = 11,
        EJackUMGItemPlacedAcquisition__Other = 12,
        EJackUMGItemPlacedAcquisition__None = 13,
        EJackUMGItemPlacedAcquisition__MAX = 14
    }


    // Enum JackGame.EJackUMGItemClassification
    public enum EJackUMGItemClassification : byte
    {
        EJackUMGItemClassification__ItemNone = 0,
        EJackUMGItemClassification__ItemUnknow = 1,
        EJackUMGItemClassification__ItemWeapon = 2,
        EJackUMGItemClassification__ItemShield = 3,
        EJackUMGItemClassification__ItemArmor = 4,
        EJackUMGItemClassification__ItemAccessory = 5,
        EJackUMGItemClassification__ItemUsable = 6,
        EJackUMGItemClassification__ItemDaizinamono = 7,
        EJackUMGItemClassification__ItemMaterial = 8,
        EJackUMGItemClassification__ItemRecipe = 9,
        EJackUMGItemClassification__Exchange = 10,
        EJackUMGItemClassification__MAX = 11
    }


    // Enum JackGame.EJackUMGItemClassRefineType
    public enum EJackUMGItemClassRefineType : byte
    {
        EJackUMGItemClassRefineType__Unknown = 0,
        EJackUMGItemClassRefineType__Sword = 1,
        EJackUMGItemClassRefineType__Dagger = 2,
        EJackUMGItemClassRefineType__Ax = 3,
        EJackUMGItemClassRefineType__Stick = 4,
        EJackUMGItemClassRefineType__Boomerang = 5,
        EJackUMGItemClassRefineType__DoubleSword = 6,
        EJackUMGItemClassRefineType__Spear = 7,
        EJackUMGItemClassRefineType__Staff = 8,
        EJackUMGItemClassRefineType__Claw = 9,
        EJackUMGItemClassRefineType__Whip = 10,
        EJackUMGItemClassRefineType__Shield = 11,
        EJackUMGItemClassRefineType__Armor = 12,
        EJackUMGItemClassRefineType__Helmet = 13,
        EJackUMGItemClassRefineType__Accessory = 14,
        EJackUMGItemClassRefineType__Usable = 15,
        EJackUMGItemClassRefineType__Daizinamono = 16,
        EJackUMGItemClassRefineType__Material = 17,
        EJackUMGItemClassRefineType__RecipeBook = 18,
        EJackUMGItemClassRefineType__Exchange = 19,
        EJackUMGItemClassRefineType__MAX = 20
    }


    // Enum JackGame.EJackItem_ParameterType
    public enum EJackItem_ParameterType : byte
    {
        EJackItem_ParameterType__Unknown = 0,
        EJackItem_ParameterType__Kougekiryoku = 1,
        EJackItem_ParameterType__Syubiryoku = 2,
        EJackItem_ParameterType__MPKyuuSyuuRate = 3,
        EJackItem_ParameterType__TateGuardRate = 4,
        EJackItem_ParameterType__MikawasiRate = 5,
        EJackItem_ParameterType__CriticalRate = 6,
        EJackItem_ParameterType__ZoneOnRate = 7,
        EJackItem_ParameterType__Kiyousa = 8,
        EJackItem_ParameterType__Subayasa = 9,
        EJackItem_ParameterType__KougekiMaryoku = 10,
        EJackItem_ParameterType__KaifukuMaryoku = 11,
        EJackItem_ParameterType__MaxHP = 12,
        EJackItem_ParameterType__MaxMP = 13,
        EJackItem_ParameterType__Miryoku = 14,
        EJackItem_ParameterType__BukiGuardRate = 15,
        EJackItem_ParameterType__Tikara = 16,
        EJackItem_ParameterType__Minomamori = 17,
        EJackItem_ParameterType__MAX = 18
    }


    // Enum JackGame.EJackUMGItemOsyareType
    public enum EJackUMGItemOsyareType : byte
    {
        EJackUMGItemOsyareType__None = 0,
        EJackUMGItemOsyareType__Type1 = 1,
        EJackUMGItemOsyareType__Type2 = 2,
        EJackUMGItemOsyareType__MAX = 3
    }


    // Enum JackGame.EJackUMGGetItemParam
    public enum EJackUMGGetItemParam : byte
    {
        EJackUMGGetItemParam__None = 0,
        EJackUMGGetItemParam__IsCanConsume = 1,
        EJackUMGGetItemParam__IsLeaveAtSort = 2,
        EJackUMGGetItemParam__bStoreCommonBag = 3,
        EJackUMGGetItemParam__SellType = 4,
        EJackUMGGetItemParam__DiscardType = 5,
        EJackUMGGetItemParam__IsEquippedPossible = 6,
        EJackUMGGetItemParam__IsEquipmentPossibleP001 = 7,
        EJackUMGGetItemParam__IsEquipmentPossibleP002 = 8,
        EJackUMGGetItemParam__IsEquipmentPossibleP003 = 9,
        EJackUMGGetItemParam__IsEquipmentPossibleP004 = 10,
        EJackUMGGetItemParam__IsEquipmentPossibleP005 = 11,
        EJackUMGGetItemParam__IsEquipmentPossibleP006 = 12,
        EJackUMGGetItemParam__IsEquipmentPossibleP007 = 13,
        EJackUMGGetItemParam__IsEquipmentPossibleP008 = 14,
        EJackUMGGetItemParam__MAX = 15
    }


    // Enum JackGame.EJackUIScenarioNumber
    public enum EJackUIScenarioNumber : byte
    {
        EJackUIScenarioNumber__AScenario = 0,
        EJackUIScenarioNumber__BScenario = 1,
        EJackUIScenarioNumber__CScenario = 2,
        EJackUIScenarioNumber__SScenario = 3,
        EJackUIScenarioNumber__MAX = 4
    }


    // Enum JackGame.EJackUMGShopResult
    public enum EJackUMGShopResult : byte
    {
        EJackUMGShopResult__BagSuccessful = 0,
        EJackUMGShopResult__BagOverflow = 1,
        EJackUMGShopResult__BagCommonOverflow = 2,
        EJackUMGShopResult__BagCommonFull = 3,
        EJackUMGShopResult__CommonSuccessful = 4,
        EJackUMGShopResult__CommonOverflow = 5,
        EJackUMGShopResult__CommonFull = 6,
        EJackUMGShopResult__NoResult = 7,
        EJackUMGShopResult__MAX = 8
    }


    // Enum JackGame.EJackShop
    public enum EJackShop : byte
    {
        EJackShop__Unknown = 0,
        EJackShop__Buki_Shop = 1,
        EJackShop__Bougu_Shop = 2,
        EJackShop__BukiBougu_Shop = 3,
        EJackShop__Dougu_Shop = 4,
        EJackShop__Yorozu_Shop = 5,
        EJackShop__Gyousyounin_Shop = 6,
        EJackShop__MAX = 7
    }


    // Enum JackGame.EJackUMGMemberList
    public enum EJackUMGMemberList : byte
    {
        EJackUMGMemberList__All = 0,
        EJackUMGMemberList__Active = 1,
        EJackUMGMemberList__Standby = 2,
        EJackUMGMemberList__Single = 3,
        EJackUMGMemberList__MAX = 4
    }


    // Enum JackGame.EJackUMGItemSortType
    public enum EJackUMGItemSortType : byte
    {
        EJackUMGItemSortType__None = 0,
        EJackUMGItemSortType__GetOrder = 1,
        EJackUMGItemSortType__Classification = 2,
        EJackUMGItemSortType__Yomi = 3,
        EJackUMGItemSortType__Tuyosa = 4,
        EJackUMGItemSortType__Narabekae = 5,
        EJackUMGItemSortType__Equipment = 6,
        EJackUMGItemSortType__Pictorial = 7,
        EJackUMGItemSortType__MAX = 8
    }


    // Enum JackGame.EJackUMGBattleMenuCommand
    public enum EJackUMGBattleMenuCommand : byte
    {
        EJackUMGBattleMenuCommand__Kougeki = 0,
        EJackUMGBattleMenuCommand__Tokugi = 1,
        EJackUMGBattleMenuCommand__Jumon = 2,
        EJackUMGBattleMenuCommand__Dougu = 3,
        EJackUMGBattleMenuCommand__Bougyo = 4,
        EJackUMGBattleMenuCommand__Joutai = 5,
        EJackUMGBattleMenuCommand__Irekae = 6,
        EJackUMGBattleMenuCommand__Sakusen = 7,
        EJackUMGBattleMenuCommand__Nigeru = 8,
        EJackUMGBattleMenuCommand__Renkei = 9,
        EJackUMGBattleMenuCommand__Owari = 10,
        EJackUMGBattleMenuCommand__ToAI = 11,
        EJackUMGBattleMenuCommand__Soubi = 12,
        EJackUMGBattleMenuCommand__Tatakau = 13,
        EJackUMGBattleMenuCommand__Sakusengae = 14,
        EJackUMGBattleMenuCommand__MAX = 15
    }


    // Enum JackGame.EJackUMGUIActionFlow
    public enum EJackUMGUIActionFlow : byte
    {
        EJackUMGUIActionFlow__None = 0,
        EJackUMGUIActionFlow__Direct = 1,
        EJackUMGUIActionFlow__Self = 2,
        EJackUMGUIActionFlow__AllMember = 3,
        EJackUMGUIActionFlow__AllEnemy = 4,
        EJackUMGUIActionFlow__NearMember = 5,
        EJackUMGUIActionFlow__NearEnemy = 6,
        EJackUMGUIActionFlow__HPList = 7,
        EJackUMGUIActionFlow__MPList = 8,
        EJackUMGUIActionFlow__BuffList = 9,
        EJackUMGUIActionFlow__Tane = 10,
        EJackUMGUIActionFlow__MonsterList = 11,
        EJackUMGUIActionFlow__GroupList = 12,
        EJackUMGUIActionFlow__CustomFlow = 13,
        EJackUMGUIActionFlow__MAX = 14
    }


    // Enum JackGame.EJackCursorSaveTarget
    public enum EJackCursorSaveTarget : byte
    {
        EJackCursorSaveTarget__Command = 0,
        EJackCursorSaveTarget__Player = 1,
        EJackCursorSaveTarget__Monster = 2,
        EJackCursorSaveTarget__Dougu = 3,
        EJackCursorSaveTarget__Jumon = 4,
        EJackCursorSaveTarget__Tokugi = 5,
        EJackCursorSaveTarget__Renkei = 6,
        EJackCursorSaveTarget__Group = 7,
        EJackCursorSaveTarget__MAX = 8
    }


    // Enum JackGame.EJackRenkeiMember
    public enum EJackRenkeiMember : byte
    {
        EJackRenkeiMember__A = 0,
        EJackRenkeiMember__B = 1,
        EJackRenkeiMember__C = 2,
        EJackRenkeiMember__D = 3,
        EJackRenkeiMember__MAX_COUNT = 4,
        EJackRenkeiMember__SELECT = 5,
        EJackRenkeiMember__NONE = 6,
        EJackRenkeiMember__EJackRenkeiMember_MAX = 7
    }


    // Enum JackGame.EJackRenkeiCategory
    public enum EJackRenkeiCategory : byte
    {
        EJackRenkeiCategory__Program = 0,
        EJackRenkeiCategory__Matinee = 1,
        EJackRenkeiCategory__MAX = 2
    }


    // Enum JackGame.EJackRenkeiSpectacleShowStatus
    public enum EJackRenkeiSpectacleShowStatus : byte
    {
        EJackRenkeiSpectacleShowStatus__Available = 0,
        EJackRenkeiSpectacleShowStatus__AlreadyUsed = 1,
        EJackRenkeiSpectacleShowStatus__EventBattle = 2,
        EJackRenkeiSpectacleShowStatus__BattleFieldNarrow = 3,
        EJackRenkeiSpectacleShowStatus__Error = 4,
        EJackRenkeiSpectacleShowStatus__MAX = 5
    }


    // Enum JackGame.EJackTokugiNotAvailableReason
    public enum EJackTokugiNotAvailableReason : byte
    {
        EJackTokugiNotAvailableReason__None = 0,
        EJackTokugiNotAvailableReason__NotWeapon = 1,
        EJackTokugiNotAvailableReason__MismatchWeaponStyle = 2,
        EJackTokugiNotAvailableReason__NoMustEquipment = 3,
        EJackTokugiNotAvailableReason__NotAvailableSeijaNoUta = 4,
        EJackTokugiNotAvailableReason__NotAvailablePaladinGuard = 5,
        EJackTokugiNotAvailableReason__MAX = 6
    }


    // Enum JackGame.EJackFusigiKaziMaterialUseInfo
    public enum EJackFusigiKaziMaterialUseInfo : byte
    {
        EJackFusigiKaziMaterialUseInfo__NotEnough = 0,
        EJackFusigiKaziMaterialUseInfo__UseBag = 1,
        EJackFusigiKaziMaterialUseInfo__UseChara = 2,
        EJackFusigiKaziMaterialUseInfo__UseEquip = 3,
        EJackFusigiKaziMaterialUseInfo__TypeMAX = 4,
        EJackFusigiKaziMaterialUseInfo__Invalid = 5,
        EJackFusigiKaziMaterialUseInfo__EJackFusigiKaziMaterialUseInfo_MAX = 6
    }


    // Enum JackGame.EJackFusigiKaziUMGParts
    public enum EJackFusigiKaziUMGParts : byte
    {
        EJackFusigiKaziUMGParts__Entrance_StartCommand = 0,
        EJackFusigiKaziUMGParts__Entrance_SelectCategory = 1,
        EJackFusigiKaziUMGParts__Entrance_SelectParts = 2,
        EJackFusigiKaziUMGParts__Entrance_NeedMaterial = 3,
        EJackFusigiKaziUMGParts__Entrance_NeedInfo = 4,
        EJackFusigiKaziUMGParts__Entrance_SelectMaterial = 5,
        EJackFusigiKaziUMGParts__Entrance_SelectPlus = 6,
        EJackFusigiKaziUMGParts__Entrance_SelectMaterialPlus = 7,
        EJackFusigiKaziUMGParts__Retry_SelectPlayer = 8,
        EJackFusigiKaziUMGParts__Retry_SelectItemList = 9,
        EJackFusigiKaziUMGParts__Entrance_PlayerStatus = 10,
        EJackFusigiKaziUMGParts__Entrance_RetryBall = 11,
        EJackFusigiKaziUMGParts__Entrance_Setumei1 = 12,
        EJackFusigiKaziUMGParts__Entrance_Setumei2 = 13,
        EJackFusigiKaziUMGParts__Entrance_Difficulty = 14,
        EJackFusigiKaziUMGParts__Entrance_Kuwasiku = 15,
        EJackFusigiKaziUMGParts__Game_Base = 16,
        EJackFusigiKaziUMGParts__Game_SelectCommand = 17,
        EJackFusigiKaziUMGParts__Game_SelectSkill = 18,
        EJackFusigiKaziUMGParts__Game_MessageSpecial = 19,
        EJackFusigiKaziUMGParts__Game_MessageAction = 20,
        EJackFusigiKaziUMGParts__Game_ResultParts = 21,
        EJackFusigiKaziUMGParts__TypeMAX = 22,
        EJackFusigiKaziUMGParts__Invalid = 23,
        EJackFusigiKaziUMGParts__EJackFusigiKaziUMGParts_MAX = 24
    }


    // Enum JackGame.EJackFusigiKaziDifficultyType
    public enum EJackFusigiKaziDifficultyType : byte
    {
        EJackFusigiKaziDifficultyType__Easy = 0,
        EJackFusigiKaziDifficultyType__LittleEasy = 1,
        EJackFusigiKaziDifficultyType__Normal = 2,
        EJackFusigiKaziDifficultyType__LittleHard = 3,
        EJackFusigiKaziDifficultyType__Hard = 4,
        EJackFusigiKaziDifficultyType__TypeMAX = 5,
        EJackFusigiKaziDifficultyType__Invalid = 6,
        EJackFusigiKaziDifficultyType__EJackFusigiKaziDifficultyType_MAX = 7
    }


    // Enum JackGame.EJackFusigiKaziCreateCategory
    public enum EJackFusigiKaziCreateCategory : byte
    {
        EJackFusigiKaziCreateCategory__Weapon = 0,
        EJackFusigiKaziCreateCategory__Armor = 1,
        EJackFusigiKaziCreateCategory__Accessory = 2,
        EJackFusigiKaziCreateCategory__TypeMAX = 3,
        EJackFusigiKaziCreateCategory__Invalid = 4,
        EJackFusigiKaziCreateCategory__EJackFusigiKaziCreateCategory_MAX = 5
    }


    // Enum JackGame.EJackFusigiKaziCreateFrame
    public enum EJackFusigiKaziCreateFrame : byte
    {
        EJackFusigiKaziCreateFrame__A = 0,
        EJackFusigiKaziCreateFrame__B = 1,
        EJackFusigiKaziCreateFrame__C = 2,
        EJackFusigiKaziCreateFrame__D = 3,
        EJackFusigiKaziCreateFrame__E = 4,
        EJackFusigiKaziCreateFrame__F = 5,
        EJackFusigiKaziCreateFrame__G = 6,
        EJackFusigiKaziCreateFrame__H = 7,
        EJackFusigiKaziCreateFrame__I = 8,
        EJackFusigiKaziCreateFrame__J = 9,
        EJackFusigiKaziCreateFrame__K = 10,
        EJackFusigiKaziCreateFrame__L = 11,
        EJackFusigiKaziCreateFrame__TypeMAX = 12,
        EJackFusigiKaziCreateFrame__Invalid = 13,
        EJackFusigiKaziCreateFrame__EJackFusigiKaziCreateFrame_MAX = 14
    }


    // Enum JackGame.EJackFusigiKaziParts
    public enum EJackFusigiKaziParts : byte
    {
        EJackFusigiKaziParts__W_Sword = 0,
        EJackFusigiKaziParts__W_Rapier = 1,
        EJackFusigiKaziParts__W_Staff = 2,
        EJackFusigiKaziParts__A_Hand = 3,
        EJackFusigiKaziParts__W_DoubleSword = 4,
        EJackFusigiKaziParts__P_Robe = 5,
        EJackFusigiKaziParts__W_Dagger = 6,
        EJackFusigiKaziParts__W_Stick = 7,
        EJackFusigiKaziParts__A_Bracelet = 8,
        EJackFusigiKaziParts__W_Spear = 9,
        EJackFusigiKaziParts__W_Ax = 10,
        EJackFusigiKaziParts__W_Claw = 11,
        EJackFusigiKaziParts__P_Shield = 12,
        EJackFusigiKaziParts__P_Clothes = 13,
        EJackFusigiKaziParts__P_Helmet = 14,
        EJackFusigiKaziParts__P_Hat = 15,
        EJackFusigiKaziParts__A_Etc = 16,
        EJackFusigiKaziParts__W_Whip = 17,
        EJackFusigiKaziParts__W_Boomerang = 18,
        EJackFusigiKaziParts__P_LargeShield = 19,
        EJackFusigiKaziParts__P_Armor = 20,
        EJackFusigiKaziParts__A_Glasses = 21,
        EJackFusigiKaziParts__A_Earrings = 22,
        EJackFusigiKaziParts__A_Finger = 23,
        EJackFusigiKaziParts__A_Shoes = 24,
        EJackFusigiKaziParts__A_Neck = 25,
        EJackFusigiKaziParts__TypeMAX = 26,
        EJackFusigiKaziParts__Invalid = 27,
        EJackFusigiKaziParts__EJackFusigiKaziParts_MAX = 28
    }


    // Enum JackGame.EJackFusigiKaziKanagata
    public enum EJackFusigiKaziKanagata : byte
    {
        EJackFusigiKaziKanagata__Kata_1x3 = 0,
        EJackFusigiKaziKanagata__Kata_2x4 = 1,
        EJackFusigiKaziKanagata__Kata_1x2 = 2,
        EJackFusigiKaziKanagata__Kata_1x4 = 3,
        EJackFusigiKaziKanagata__Kata_2x2 = 4,
        EJackFusigiKaziKanagata__Kata_2x3 = 5,
        EJackFusigiKaziKanagata__Kata_2x1 = 6,
        EJackFusigiKaziKanagata__TypeMAX = 7,
        EJackFusigiKaziKanagata__Invalid = 8,
        EJackFusigiKaziKanagata__EJackFusigiKaziKanagata_MAX = 9
    }


    // Enum JackGame.EJackFusigiKaziMetalMaterial
    public enum EJackFusigiKaziMetalMaterial : byte
    {
        EJackFusigiKaziMetalMaterial__Iron = 0,
        EJackFusigiKaziMetalMaterial__Cloth = 1,
        EJackFusigiKaziMetalMaterial__Wood = 2,
        EJackFusigiKaziMetalMaterial__TypeMAX = 3,
        EJackFusigiKaziMetalMaterial__Invalid = 4,
        EJackFusigiKaziMetalMaterial__EJackFusigiKaziMetalMaterial_MAX = 5
    }


    // Enum JackGame.EJackFusigiKaziEffect
    public enum EJackFusigiKaziEffect : byte
    {
        EJackFusigiKaziEffect__Smoke_000 = 0,
        EJackFusigiKaziEffect__Half = 1,
        EJackFusigiKaziEffect__Hit_002 = 2,
        EJackFusigiKaziEffect__Hit_000 = 3,
        EJackFusigiKaziEffect__Hit_003 = 4,
        EJackFusigiKaziEffect__Snipe = 5,
        EJackFusigiKaziEffect__PowerUp = 6,
        EJackFusigiKaziEffect__PowerDown = 7,
        EJackFusigiKaziEffect__TemperBack_000 = 8,
        EJackFusigiKaziEffect__Smoke_001 = 9,
        EJackFusigiKaziEffect__HissatuCharge = 10,
        EJackFusigiKaziEffect__Hot = 11,
        EJackFusigiKaziEffect__Rise = 12,
        EJackFusigiKaziEffect__Hit_001 = 13,
        EJackFusigiKaziEffect__Square_000 = 14,
        EJackFusigiKaziEffect__Fire = 15,
        EJackFusigiKaziEffect__TypeMAX = 16,
        EJackFusigiKaziEffect__Invalid = 17,
        EJackFusigiKaziEffect__EJackFusigiKaziEffect_MAX = 18
    }


    // Enum JackGame.EJackFusigiKaziGameStat
    public enum EJackFusigiKaziGameStat : byte
    {
        EJackFusigiKaziGameStat__TurnInit = 0,
        EJackFusigiKaziGameStat__WaitInit = 1,
        EJackFusigiKaziGameStat__CleanBeforeTurn = 2,
        EJackFusigiKaziGameStat__MainCommand = 3,
        EJackFusigiKaziGameStat__SubCommand = 4,
        EJackFusigiKaziGameStat__SelectCursor = 5,
        EJackFusigiKaziGameStat__SceneKuwasiku = 6,
        EJackFusigiKaziGameStat__WaitAction = 7,
        EJackFusigiKaziGameStat__NextTurn = 8,
        EJackFusigiKaziGameStat__DecideEnd = 9,
        EJackFusigiKaziGameStat__TypeMAX = 10,
        EJackFusigiKaziGameStat__Invalid = 11,
        EJackFusigiKaziGameStat__EJackFusigiKaziGameStat_MAX = 12
    }


    // Enum JackGame.EJackFusigiKaziGameResult
    public enum EJackFusigiKaziGameResult : byte
    {
        EJackFusigiKaziGameResult__Sippai = 0,
        EJackFusigiKaziGameResult__Seikou = 1,
        EJackFusigiKaziGameResult__Seikou01 = 2,
        EJackFusigiKaziGameResult__Seikou02 = 3,
        EJackFusigiKaziGameResult__Daiseikou = 4,
        EJackFusigiKaziGameResult__TypeMAX = 5,
        EJackFusigiKaziGameResult__Invalid = 6,
        EJackFusigiKaziGameResult__EJackFusigiKaziGameResult_MAX = 7
    }


    // Enum JackGame.EJackFusigiKaziKuwasikuQuality
    public enum EJackFusigiKaziKuwasikuQuality : byte
    {
        EJackFusigiKaziKuwasikuQuality__FAILED = 0,
        EJackFusigiKaziKuwasikuQuality__FAILED01 = 1,
        EJackFusigiKaziKuwasikuQuality__FAILED_RETRY = 2,
        EJackFusigiKaziKuwasikuQuality__SUCCESS_NORMAL = 3,
        EJackFusigiKaziKuwasikuQuality__SUCCESS_PLUS = 4,
        EJackFusigiKaziKuwasikuQuality__SUCCESS_PLUS01 = 5,
        EJackFusigiKaziKuwasikuQuality__SUCCESS_PLUS02 = 6,
        EJackFusigiKaziKuwasikuQuality__TypeMAX = 7,
        EJackFusigiKaziKuwasikuQuality__Invalid = 8,
        EJackFusigiKaziKuwasikuQuality__EJackFusigiKaziKuwasikuQuality_MAX = 9
    }


    // Enum JackGame.EJackFusigiKaziGameTokugi
    public enum EJackFusigiKaziGameTokugi : byte
    {
        EJackFusigiKaziGameTokugi__Tataku = 0,
        EJackFusigiKaziGameTokugi__JougeUti = 1,
        EJackFusigiKaziGameTokugi__YonrenUti = 2,
        EJackFusigiKaziGameTokugi__SPYonrenUti = 3,
        EJackFusigiKaziGameTokugi__NanameUti = 4,
        EJackFusigiKaziGameTokugi__TekagenUti = 5,
        EJackFusigiKaziGameTokugi__NibaiUti = 6,
        EJackFusigiKaziGameTokugi__SanbaiUti = 7,
        EJackFusigiKaziGameTokugi__NeraiUti = 8,
        EJackFusigiKaziGameTokugi__KaryokuAge = 9,
        EJackFusigiKaziGameTokugi__NeppuOrosi = 10,
        EJackFusigiKaziGameTokugi__Hiyasikomi = 11,
        EJackFusigiKaziGameTokugi__MidareUti = 12,
        EJackFusigiKaziGameTokugi__Hepaitosu = 13,
        EJackFusigiKaziGameTokugi__KaisinUp_001 = 14,
        EJackFusigiKaziGameTokugi__KaisinUp_002 = 15,
        EJackFusigiKaziGameTokugi__KaisinUp_003 = 16,
        EJackFusigiKaziGameTokugi__Hissatu_Little = 17,
        EJackFusigiKaziGameTokugi__Tokugi = 18,
        EJackFusigiKaziGameTokugi__Kuwasiku = 19,
        EJackFusigiKaziGameTokugi__Siageru = 20,
        EJackFusigiKaziGameTokugi__Hissatu = 21,
        EJackFusigiKaziGameTokugi__TypeMAX = 22,
        EJackFusigiKaziGameTokugi__Invalid = 23,
        EJackFusigiKaziGameTokugi__EJackFusigiKaziGameTokugi_MAX = 24
    }


    // Enum JackGame.EJackFusigiKaziPossibleType
    public enum EJackFusigiKaziPossibleType : byte
    {
        EJackFusigiKaziPossibleType__OK = 0,
        EJackFusigiKaziPossibleType__NG_PlusMax = 1,
        EJackFusigiKaziPossibleType__NG_NoHaveMaterial = 2,
        EJackFusigiKaziPossibleType__NG_NoHaveRetryMaterial = 3,
        EJackFusigiKaziPossibleType__NG_NotExistRecipe = 4,
        EJackFusigiKaziPossibleType__TypeMAX = 5,
        EJackFusigiKaziPossibleType__Invalid = 6,
        EJackFusigiKaziPossibleType__EJackFusigiKaziPossibleType_MAX = 7
    }


    // Enum JackGame.EJackMiniGameTableCoinType
    public enum EJackMiniGameTableCoinType : byte
    {
        EJackMiniGameTableCoinType__OneCoin = 0,
        EJackMiniGameTableCoinType__TenCoin = 1,
        EJackMiniGameTableCoinType__HundredCoin = 2,
        EJackMiniGameTableCoinType__Max = 3
    }


    // Enum JackGame.EJackFusigiKaziMaterialSpecial
    public enum EJackFusigiKaziMaterialSpecial : byte
    {
        EJackFusigiKaziMaterialSpecial__None = 0,
        EJackFusigiKaziMaterialSpecial__UpDownPower = 1,
        EJackFusigiKaziMaterialSpecial__ChangeCP = 2,
        EJackFusigiKaziMaterialSpecial__RecoverHP = 3,
        EJackFusigiKaziMaterialSpecial__KaisinUp = 4,
        EJackFusigiKaziMaterialSpecial__TypeMAX = 5,
        EJackFusigiKaziMaterialSpecial__Invalid = 6,
        EJackFusigiKaziMaterialSpecial__EJackFusigiKaziMaterialSpecial_MAX = 7
    }


    // Enum JackGame.EJackUIFaceIcon
    public enum EJackUIFaceIcon : byte
    {
        EJackUIFaceIcon__HudAlive = 0,
        EJackUIFaceIcon__HudDead = 1,
        EJackUIFaceIcon__HudZone = 2,
        EJackUIFaceIcon__HudZoneStart = 3,
        EJackUIFaceIcon__HudZoneStop = 4,
        EJackUIFaceIcon__MenuBust = 5,
        EJackUIFaceIcon__MenuEye = 6,
        EJackUIFaceIcon__MenuFace = 7,
        EJackUIFaceIcon__FaceZoneOff = 8,
        EJackUIFaceIcon__FaceZoneKakuteiIn = 9,
        EJackUIFaceIcon__FaceZoneKakuteiWait = 10,
        EJackUIFaceIcon__FaceZoneIn = 11,
        EJackUIFaceIcon__FaceZoneWait = 12,
        EJackUIFaceIcon__FaceZoneLimitIn = 13,
        EJackUIFaceIcon__FaceZoneLimitWait = 14,
        EJackUIFaceIcon__FaceZoneOut = 15,
        EJackUIFaceIcon__FaceZoneAllSet = 16,
        EJackUIFaceIcon__HudAliveReset = 17,
        EJackUIFaceIcon__HudAliveZone = 18,
        EJackUIFaceIcon__MAX = 19
    }


    // Enum JackGame.EJackUMGJumonBasyo
    public enum EJackUMGJumonBasyo : byte
    {
        EJackUMGJumonBasyo__All = 0,
        EJackUMGJumonBasyo__Field = 1,
        EJackUMGJumonBasyo__Battle = 2,
        EJackUMGJumonBasyo__MAX = 3
    }


    // Enum JackGame.EJackUMGMembarZenin
    public enum EJackUMGMembarZenin : byte
    {
        EJackUMGMembarZenin__None = 0,
        EJackUMGMembarZenin__Top = 1,
        EJackUMGMembarZenin__Bottom = 2,
        EJackUMGMembarZenin__MAX = 3
    }


    // Enum JackGame.EJackUMGOsusumeSoubi
    public enum EJackUMGOsusumeSoubi : byte
    {
        EJackUMGOsusumeSoubi__KougekiRyoku = 0,
        EJackUMGOsusumeSoubi__SyubiRyoku = 1,
        EJackUMGOsusumeSoubi__KougekiMaryoku = 2,
        EJackUMGOsusumeSoubi__MAX = 3
    }


    // Enum JackGame.EJackPartyTalkState
    public enum EJackPartyTalkState : byte
    {
        EJackPartyTalkState__Possible = 0,
        EJackPartyTalkState__Impossible = 1,
        EJackPartyTalkState__NonParty = 2,
        EJackPartyTalkState__AllDead = 3,
        EJackPartyTalkState__MAX = 4
    }


    // Enum JackGame.EJackBattleCameraMode
    public enum EJackBattleCameraMode : byte
    {
        EJackBattleCameraMode__Free = 0,
        EJackBattleCameraMode__Simple = 1,
        EJackBattleCameraMode__MAX = 2
    }


    // Enum JackGame.EJackBattleSpeedMode
    public enum EJackBattleSpeedMode : byte
    {
        EJackBattleSpeedMode__Normal = 0,
        EJackBattleSpeedMode__Fast = 1,
        EJackBattleSpeedMode__VeryFast = 2,
        EJackBattleSpeedMode__MAX = 3
    }


    // Enum JackGame.EJackUMGBoukennoSyoAction
    public enum EJackUMGBoukennoSyoAction : byte
    {
        EJackUMGBoukennoSyoAction__Start = 0,
        EJackUMGBoukennoSyoAction__Make = 1,
        EJackUMGBoukennoSyoAction__Delete = 2,
        EJackUMGBoukennoSyoAction__StartTaiken = 3,
        EJackUMGBoukennoSyoAction__MAX = 4
    }


    // Enum JackGame.EJackUMGBoukennoSyoSubAction
    public enum EJackUMGBoukennoSyoSubAction : byte
    {
        EJackUMGBoukennoSyoSubAction__None = 0,
        EJackUMGBoukennoSyoSubAction__Sibai = 1,
        EJackUMGBoukennoSyoSubAction__Arasuzi = 2,
        EJackUMGBoukennoSyoSubAction__SibariArasuzi = 3,
        EJackUMGBoukennoSyoSubAction__MAX = 4
    }


    // Enum JackGame.EJackCameraSpeed
    public enum EJackCameraSpeed : byte
    {
        EJackCameraSpeed__VerySlow = 0,
        EJackCameraSpeed__VerySlow2 = 1,
        EJackCameraSpeed__Slow = 2,
        EJackCameraSpeed__Slow2 = 3,
        EJackCameraSpeed__Normal = 4,
        EJackCameraSpeed__Normal2 = 5,
        EJackCameraSpeed__LittleFast = 6,
        EJackCameraSpeed__LittleFast2 = 7,
        EJackCameraSpeed__Fast = 8,
        EJackCameraSpeed__Fast2 = 9,
        EJackCameraSpeed__MAX = 10
    }


    // Enum JackGame.EJackVoice
    public enum EJackVoice : byte
    {
        EJackVoice__EnglishGB = 0,
        EJackVoice__Japanese = 1,
        EJackVoice__None = 2,
        EJackVoice__MAX = 3
    }


    // Enum JackGame.EJackDisplayGamma
    public enum EJackDisplayGamma : byte
    {
        EJackDisplayGamma__Level = 0,
        EJackDisplayGamma__Level01 = 1,
        EJackDisplayGamma__Level02 = 2,
        EJackDisplayGamma__Level03 = 3,
        EJackDisplayGamma__Level04 = 4,
        EJackDisplayGamma__Level05 = 5,
        EJackDisplayGamma__Level06 = 6,
        EJackDisplayGamma__Level07 = 7,
        EJackDisplayGamma__Level08 = 8,
        EJackDisplayGamma__Level09 = 9,
        EJackDisplayGamma__Level10 = 10,
        EJackDisplayGamma__Level11 = 11,
        EJackDisplayGamma__Level12 = 12,
        EJackDisplayGamma__Level13 = 13,
        EJackDisplayGamma__Level14 = 14,
        EJackDisplayGamma__Level15 = 15,
        EJackDisplayGamma__Level16 = 16,
        EJackDisplayGamma__Level17 = 17,
        EJackDisplayGamma__Level18 = 18,
        EJackDisplayGamma__Level19 = 19,
        EJackDisplayGamma__Level20 = 20,
        EJackDisplayGamma__Level21 = 21,
        EJackDisplayGamma__Level22 = 22,
        EJackDisplayGamma__Level23 = 23,
        EJackDisplayGamma__Level24 = 24,
        EJackDisplayGamma__Level25 = 25,
        EJackDisplayGamma__Level26 = 26,
        EJackDisplayGamma__Level27 = 27,
        EJackDisplayGamma__Level28 = 28,
        EJackDisplayGamma__Level29 = 29,
        EJackDisplayGamma__Level30 = 30,
        EJackDisplayGamma__Level31 = 31,
        EJackDisplayGamma__Level32 = 32,
        EJackDisplayGamma__Level33 = 33,
        EJackDisplayGamma__Level34 = 34,
        EJackDisplayGamma__Level35 = 35,
        EJackDisplayGamma__Level36 = 36,
        EJackDisplayGamma__Level37 = 37,
        EJackDisplayGamma__Level38 = 38,
        EJackDisplayGamma__Level39 = 39,
        EJackDisplayGamma__Level40 = 40,
        EJackDisplayGamma__Level41 = 41,
        EJackDisplayGamma__Level42 = 42,
        EJackDisplayGamma__Level43 = 43,
        EJackDisplayGamma__Level44 = 44,
        EJackDisplayGamma__Level45 = 45,
        EJackDisplayGamma__Level46 = 46,
        EJackDisplayGamma__Level47 = 47,
        EJackDisplayGamma__Level48 = 48,
        EJackDisplayGamma__Level49 = 49,
        EJackDisplayGamma__Level50 = 50,
        EJackDisplayGamma__Level51 = 51,
        EJackDisplayGamma__Level52 = 52,
        EJackDisplayGamma__Level53 = 53,
        EJackDisplayGamma__Level54 = 54,
        EJackDisplayGamma__Level55 = 55,
        EJackDisplayGamma__Level56 = 56,
        EJackDisplayGamma__Level57 = 57,
        EJackDisplayGamma__Level58 = 58,
        EJackDisplayGamma__Level59 = 59,
        EJackDisplayGamma__Level60 = 60,
        EJackDisplayGamma__Level61 = 61,
        EJackDisplayGamma__Level62 = 62,
        EJackDisplayGamma__Level63 = 63,
        EJackDisplayGamma__Level64 = 64,
        EJackDisplayGamma__Level65 = 65,
        EJackDisplayGamma__Level66 = 66,
        EJackDisplayGamma__Level67 = 67,
        EJackDisplayGamma__Level68 = 68,
        EJackDisplayGamma__Level69 = 69,
        EJackDisplayGamma__Level70 = 70,
        EJackDisplayGamma__Level71 = 71,
        EJackDisplayGamma__Level72 = 72,
        EJackDisplayGamma__Level73 = 73,
        EJackDisplayGamma__Level74 = 74,
        EJackDisplayGamma__Level75 = 75,
        EJackDisplayGamma__Level76 = 76,
        EJackDisplayGamma__Level77 = 77,
        EJackDisplayGamma__Level78 = 78,
        EJackDisplayGamma__Level79 = 79,
        EJackDisplayGamma__Level80 = 80,
        EJackDisplayGamma__Level81 = 81,
        EJackDisplayGamma__Level82 = 82,
        EJackDisplayGamma__Level83 = 83,
        EJackDisplayGamma__Level84 = 84,
        EJackDisplayGamma__Level85 = 85,
        EJackDisplayGamma__Level86 = 86,
        EJackDisplayGamma__Level87 = 87,
        EJackDisplayGamma__Level88 = 88,
        EJackDisplayGamma__Level89 = 89,
        EJackDisplayGamma__Level90 = 90,
        EJackDisplayGamma__Level91 = 91,
        EJackDisplayGamma__Level92 = 92,
        EJackDisplayGamma__Level93 = 93,
        EJackDisplayGamma__Level94 = 94,
        EJackDisplayGamma__Level95 = 95,
        EJackDisplayGamma__Level96 = 96,
        EJackDisplayGamma__Level97 = 97,
        EJackDisplayGamma__Level98 = 98,
        EJackDisplayGamma__Level99 = 99,
        EJackDisplayGamma__MAX = 100
    }


    // Enum JackGame.EJackUMGRestartMenuType
    public enum EJackUMGRestartMenuType : byte
    {
        EJackUMGRestartMenuType__Oinori = 0,
        EJackUMGRestartMenuType__LastVisited = 1,
        EJackUMGRestartMenuType__AutoSave = 2,
        EJackUMGRestartMenuType__Cancel = 3,
        EJackUMGRestartMenuType__MAX = 4
    }


    // Enum JackGame.EJackPlayGoMenuType
    public enum EJackPlayGoMenuType : byte
    {
        EJackPlayGoMenuType__None = 0,
        EJackPlayGoMenuType__GoToTitle = 1,
        EJackPlayGoMenuType__FromBoukennosyo = 2,
        EJackPlayGoMenuType__FromFukkatunojumon = 3,
        EJackPlayGoMenuType__DontGo = 4,
        EJackPlayGoMenuType__VoiceDrama = 5,
        EJackPlayGoMenuType__MAX = 6
    }


    // Enum JackGame.EJackPlayGoMenuResult
    public enum EJackPlayGoMenuResult : byte
    {
        EJackPlayGoMenuResult__None = 0,
        EJackPlayGoMenuResult__Close = 1,
        EJackPlayGoMenuResult__CompleteInstall = 2,
        EJackPlayGoMenuResult__MAX = 3
    }


    // Enum JackGame.EJackRenkeiSettei
    public enum EJackRenkeiSettei : byte
    {
        EJackRenkeiSettei__JidouRenkei = 0,
        EJackRenkeiSettei__RenkeiSinai = 1,
        EJackRenkeiSettei__MAX = 2
    }


    // Enum JackGame.EJackKeyboardType
    public enum EJackKeyboardType : byte
    {
        EJackKeyboardType__Japanese = 0,
        EJackKeyboardType__English = 1,
        EJackKeyboardType__French = 2,
        EJackKeyboardType__Italian = 3,
        EJackKeyboardType__German = 4,
        EJackKeyboardType__Spanish = 5,
        EJackKeyboardType__MAX = 6
    }


    // Enum JackGame.EJackUMGSibariMode
    public enum EJackUMGSibariMode : byte
    {
        EJackUMGSibariMode__None = 0,
        EJackUMGSibariMode__Settei = 1,
        EJackUMGSibariMode__Kakunin = 2,
        EJackUMGSibariMode__Tassei = 3,
        EJackUMGSibariMode__MAX = 4
    }


    // Enum JackGame.EJackUMGGraphicOption
    public enum EJackUMGGraphicOption : byte
    {
        EJackUMGGraphicOption__All = 0,
        EJackUMGGraphicOption__AntiAliasing = 1,
        EJackUMGGraphicOption__PostProcessing = 2,
        EJackUMGGraphicOption__Shadow = 3,
        EJackUMGGraphicOption__Texture = 4,
        EJackUMGGraphicOption__VisualEffect = 5,
        EJackUMGGraphicOption__Foliage = 6,
        EJackUMGGraphicOption__FrameRate = 7,
        EJackUMGGraphicOption__VSync = 8,
        EJackUMGGraphicOption__Window = 9,
        EJackUMGGraphicOption__ScreenPercent = 10,
        EJackUMGGraphicOption__ScreenRes = 11,
        EJackUMGGraphicOption__EJackUMGGraphicOption_MAX = 12
    }


    // Enum JackGame.EJackSaveLoadResult
    public enum EJackSaveLoadResult : byte
    {
        EJackSaveLoadResult__SUCCESS = 0,
        EJackSaveLoadResult__BUSY = 1,
        EJackSaveLoadResult__NO_FILE = 2,
        EJackSaveLoadResult__NO_SPACE = 3,
        EJackSaveLoadResult__READ_ONLY = 4,
        EJackSaveLoadResult__EXIST_FILE = 5,
        EJackSaveLoadResult__INVALID_USER = 6,
        EJackSaveLoadResult__BROKEN = 7,
        EJackSaveLoadResult__NO_SYSTEM = 8,
        EJackSaveLoadResult__UNKNOWN_ERROR = 9,
        EJackSaveLoadResult__MAX = 10
    }


    // Enum JackGame.EJackScenarioPlaythrough
    public enum EJackScenarioPlaythrough : byte
    {
        EJackScenarioPlaythrough__First = 0,
        EJackScenarioPlaythrough__Second = 1,
        EJackScenarioPlaythrough__MAX = 2
    }


    // Enum JackGame.EJackFukkatunojumonSpell
    public enum EJackFukkatunojumonSpell : byte
    {
        EJackFukkatunojumonSpell__None = 0,
        EJackFukkatunojumonSpell__DQ11 = 1,
        EJackFukkatunojumonSpell__DQ1 = 2,
        EJackFukkatunojumonSpell__DQ2 = 3,
        EJackFukkatunojumonSpell__Special = 4,
        EJackFukkatunojumonSpell__EJackFukkatunojumonSpell_MAX = 5
    }


    // Enum JackGame.EJackFukkatunojumonPlatform
    public enum EJackFukkatunojumonPlatform : byte
    {
        EJackFukkatunojumonPlatform__None = 0,
        EJackFukkatunojumonPlatform__PS4 = 1,
        EJackFukkatunojumonPlatform__NT3DS = 2,
        EJackFukkatunojumonPlatform__NTSWITCH = 3,
        EJackFukkatunojumonPlatform__MARBLE = 4,
        EJackFukkatunojumonPlatform__EJackFukkatunojumonPlatform_MAX = 5
    }


    // Enum JackGame.EJackFukkatunojumon
    public enum EJackFukkatunojumon : byte
    {
        EJackFukkatunojumon__None = 0,
        EJackFukkatunojumon__DQ11_Normal = 1,
        EJackFukkatunojumon__DQ1_2_Normal = 2,
        EJackFukkatunojumon__DQ1_2_Fame = 3,
        EJackFukkatunojumon__Special_Triple = 4,
        EJackFukkatunojumon__Special_2ndLapEnding = 5,
        EJackFukkatunojumon__Special_StoreOpen = 6,
        EJackFukkatunojumon__Special_NewGamePlus = 7,
        EJackFukkatunojumon__MAX = 8
    }


    // Enum JackGame.EJackYadoyaMorningCallTimezone
    public enum EJackYadoyaMorningCallTimezone : byte
    {
        EJackYadoyaMorningCallTimezone__None = 0,
        EJackYadoyaMorningCallTimezone__Morning = 1,
        EJackYadoyaMorningCallTimezone__Noon = 2,
        EJackYadoyaMorningCallTimezone__Evening = 3,
        EJackYadoyaMorningCallTimezone__Night = 4,
        EJackYadoyaMorningCallTimezone__StayToMorning = 5,
        EJackYadoyaMorningCallTimezone__MAX = 6
    }


    // Enum JackGame.EJackCampMenuResult
    public enum EJackCampMenuResult : byte
    {
        EJackCampMenuResult__None = 0,
        EJackCampMenuResult__Break = 1,
        EJackCampMenuResult__Blacksmith = 2,
        EJackCampMenuResult__Church = 3,
        EJackCampMenuResult__CampQuit = 4,
        EJackCampMenuResult__MAX = 5
    }


    // Enum JackGame.EJackKyoukaiEffectEventType
    public enum EJackKyoukaiEffectEventType : byte
    {
        EJackKyoukaiEffectEventType__ExecuteRevive = 0,
        EJackKyoukaiEffectEventType__ExecuteTreat = 1,
        EJackKyoukaiEffectEventType__ExecuteDispel = 2,
        EJackKyoukaiEffectEventType__ExecuteSave = 3,
        EJackKyoukaiEffectEventType__MAX = 4
    }


    // Enum JackGame.EJackChurchFukkatunojumon
    public enum EJackChurchFukkatunojumon : byte
    {
        EJackChurchFukkatunojumon__Unknown = 0,
        EJackChurchFukkatunojumon__Open = 1,
        EJackChurchFukkatunojumon__Close = 2,
        EJackChurchFukkatunojumon__FlagCheck = 3,
        EJackChurchFukkatunojumon__MAX = 4
    }


    // Enum JackGame.EJackChurch
    public enum EJackChurch : byte
    {
        EJackChurch__Unknown = 0,
        EJackChurch__Church = 1,
        EJackChurch__Bible = 2,
        EJackChurch__ChapterSave = 3,
        EJackChurch__ChapterSaveYotti = 4,
        EJackChurch__MAX = 5
    }


    // Enum JackGame.EJackKyoukaiEventType
    public enum EJackKyoukaiEventType : byte
    {
        EJackKyoukaiEventType__None = 0,
        EJackKyoukaiEventType__ToTitle = 1,
        EJackKyoukaiEventType__SibariReset = 2,
        EJackKyoukaiEventType__MAX = 3
    }


    // Enum JackGame.EJackKyoukaiSavedFlag
    public enum EJackKyoukaiSavedFlag : byte
    {
        EJackKyoukaiSavedFlag__None = 0,
        EJackKyoukaiSavedFlag__UnSave = 1,
        EJackKyoukaiSavedFlag__Saved = 2,
        EJackKyoukaiSavedFlag__MAX = 3
    }


    // Enum JackGame.EJackMedal_Shop
    public enum EJackMedal_Shop : byte
    {
        EJackMedal_Shop__BranchOffice = 0,
        EJackMedal_Shop__GirlsHighSchool = 1,
        EJackMedal_Shop__MAX = 2
    }


    // Enum JackGame.EJackUMGShopType
    public enum EJackUMGShopType : byte
    {
        EJackUMGShopType__Shop = 0,
        EJackUMGShopType__Yadoya = 1,
        EJackUMGShopType__Kyoukai = 2,
        EJackUMGShopType__Ginkou = 3,
        EJackUMGShopType__CasinoCoin = 4,
        EJackUMGShopType__CasinoKeihin = 5,
        EJackUMGShopType__MedalStamp = 6,
        EJackUMGShopType__MedalKeihin = 7,
        EJackUMGShopType__UtinaosiNoHouju = 8,
        EJackUMGShopType__MAX = 9
    }


    // Enum JackGame.EJackUMGYaodyaState
    public enum EJackUMGYaodyaState : byte
    {
        EJackUMGYaodyaState__Enable = 0,
        EJackUMGYaodyaState__Disable = 1,
        EJackUMGYaodyaState__DisableStay = 2,
        EJackUMGYaodyaState__DisableBreak = 3,
        EJackUMGYaodyaState__MAX = 4
    }


    // Enum JackGame.EJackYadoyaEventType
    public enum EJackYadoyaEventType : byte
    {
        EJackYadoyaEventType__Stay = 0,
        EJackYadoyaEventType__Break = 1,
        EJackYadoyaEventType__Quit = 2,
        EJackYadoyaEventType__MAX = 3
    }


    // Enum JackGame.EJackUMGItemContainerType
    public enum EJackUMGItemContainerType : byte
    {
        EJackUMGItemContainerType__Value = 0,
        EJackUMGItemContainerType__Text = 1,
        EJackUMGItemContainerType__Image = 2,
        EJackUMGItemContainerType__Object = 3,
        EJackUMGItemContainerType__Visibility = 4,
        EJackUMGItemContainerType__MAX = 5
    }


    // Enum JackGame.EJackUMGWidgetConnectTarget
    public enum EJackUMGWidgetConnectTarget : byte
    {
        EJackUMGWidgetConnectTarget__Viewport = 0,
        EJackUMGWidgetConnectTarget__CanvasPanel = 1,
        EJackUMGWidgetConnectTarget__RootPanel = 2,
        EJackUMGWidgetConnectTarget__Menu = 3,
        EJackUMGWidgetConnectTarget__MAX = 4
    }


    // Enum JackGame.EJackUMGMenuLoadResult
    public enum EJackUMGMenuLoadResult : byte
    {
        EJackUMGMenuLoadResult__NoLoad = 0,
        EJackUMGMenuLoadResult__Error = 1,
        EJackUMGMenuLoadResult__Complate = 2,
        EJackUMGMenuLoadResult__Loading = 3,
        EJackUMGMenuLoadResult__MAX = 4
    }


    // Enum JackGame.EJackUMGMenuId
    public enum EJackUMGMenuId : byte
    {
        EJackUMGMenuId__NoOpen = 0,
        EJackUMGMenuId__CloseMenu = 1,
        EJackUMGMenuId__TitleMenu = 2,
        EJackUMGMenuId__BoukenNoSyoMenu = 3,
        EJackUMGMenuId__MainMenu = 4,
        EJackUMGMenuId__BattleMenu = 5,
        EJackUMGMenuId__ShopMenu = 6,
        EJackUMGMenuId__KyoukaiMenu = 7,
        EJackUMGMenuId__GinkouMenu = 8,
        EJackUMGMenuId__YadoyaMenu = 9,
        EJackUMGMenuId__CampStartMenu = 10,
        EJackUMGMenuId__CampMenu = 11,
        EJackUMGMenuId__BattleRoundMenu = 12,
        EJackUMGMenuId__BattleSakusenMenu = 13,
        EJackUMGMenuId__SakusenYoyakuMenu = 14,
        EJackUMGMenuId__CSSkipDialog = 15,
        EJackUMGMenuId__KaziMenu = 16,
        EJackUMGMenuId__SyougouDialog = 17,
        EJackUMGMenuId__UmaRaceMenu = 18,
        EJackUMGMenuId__WorldMap = 19,
        EJackUMGMenuId__LocalMap = 20,
        EJackUMGMenuId__MedalStampTyou = 21,
        EJackUMGMenuId__MedalKeihinKoukanMenu = 22,
        EJackUMGMenuId__CasinoCoinKoukanMenu = 23,
        EJackUMGMenuId__CasinoKeihinKoukanMenu = 24,
        EJackUMGMenuId__TabinoOmoideMenu = 25,
        EJackUMGMenuId__TokugiPanel = 26,
        EJackUMGMenuId__TutorialWindow = 27,
        EJackUMGMenuId__SyuurenjyouMenu = 28,
        EJackUMGMenuId__PlayGoMenu = 29,
        EJackUMGMenuId__ArasuziMenu = 30,
        EJackUMGMenuId__NerusenPicture = 31,
        EJackUMGMenuId__RestartMenu = 32,
        EJackUMGMenuId__KimeraMenu = 33,
        EJackUMGMenuId__MeosiMenu = 34,
        EJackUMGMenuId__QuestClearWindow = 35,
        EJackUMGMenuId__HoujuKoukanMenu = 36,
        EJackUMGMenuId__SibariTasseiMenu = 37,
        EJackUMGMenuId__ShortCutMenu = 38,
        EJackUMGMenuId__PhotoModeMenu = 39,
        EJackUMGMenuId__VoiceDrama = 40,
        EJackUMGMenuId__VoiceDramaList = 41,
        EJackUMGMenuId__PrivacyPolicy = 42,
        EJackUMGMenuId__SystemSetteiMenu = 43,
        EJackUMGMenuId__SuspendGameMenu = 44,
        EJackUMGMenuId__ChangeProfileMenu = 45,
        EJackUMGMenuId__PairingControllerMenu = 46,
        EJackUMGMenuId__DisplayProfile = 47,
        EJackUMGMenuId__InitControllerMenu = 48,
        EJackUMGMenuId__KeyConfigMenu = 49,
        EJackUMGMenuId__SelectKetteiKeyMenu = 50,
        EJackUMGMenuId__SubMenuSettei = 51,
        EJackUMGMenuId__JukeboxMenu = 52,
        EJackUMGMenuId__MenuDebugMenu = 53,
        EJackUMGMenuId__AllMenu = 54,
        EJackUMGMenuId__MAX = 55
    }


    // Enum JackGame.EJackUMGVoiceDramaMode
    public enum EJackUMGVoiceDramaMode : byte
    {
        EJackUMGVoiceDramaMode__VoiceDramaSelect = 0,
        EJackUMGVoiceDramaMode__VoiceDramaMain = 1,
        EJackUMGVoiceDramaMode__VoiceDramaStaff = 2,
        EJackUMGVoiceDramaMode__VoiceDramaPafuPafu = 3,
        EJackUMGVoiceDramaMode__MAX = 4
    }


    // Enum JackGame.EJackUMGCutSceneSkipEvent
    public enum EJackUMGCutSceneSkipEvent : byte
    {
        EJackUMGCutSceneSkipEvent__None = 0,
        EJackUMGCutSceneSkipEvent__CutSceneSkip = 1,
        EJackUMGCutSceneSkipEvent__SwitchAutoFeed = 2,
        EJackUMGCutSceneSkipEvent__MAX = 3
    }


    // Enum JackGame.EJackRuraPurpose
    public enum EJackRuraPurpose : byte
    {
        EJackRuraPurpose__Invalid = 0,
        EJackRuraPurpose__Rura = 1,
        EJackRuraPurpose__KazenoBousi = 2,
        EJackRuraPurpose__ChimeraWing = 3,
        EJackRuraPurpose__Riremito = 4,
        EJackRuraPurpose__OmoideNoSuzu = 5,
        EJackRuraPurpose__MAX = 6
    }


    // Enum JackGame.EJackCursorSaveScene
    public enum EJackCursorSaveScene : byte
    {
        EJackCursorSaveScene__Field = 0,
        EJackCursorSaveScene__Battle = 1,
        EJackCursorSaveScene__Other = 2,
        EJackCursorSaveScene__MAX = 3
    }


    // Enum JackGame.EJackSpeed
    public enum EJackSpeed : byte
    {
        EJackSpeed__None = 0,
        EJackSpeed__SpecialSlow = 1,
        EJackSpeed__Slowest = 2,
        EJackSpeed__Slower = 3,
        EJackSpeed__Slow = 4,
        EJackSpeed__Normal = 5,
        EJackSpeed__Fast = 6,
        EJackSpeed__Faster = 7,
        EJackSpeed__Fastest = 8,
        EJackSpeed__MAX = 9
    }


    // Enum JackGame.EJackUMGSyougouColor
    public enum EJackUMGSyougouColor : byte
    {
        EJackUMGSyougouColor__Legend = 0,
        EJackUMGSyougouColor__Platinum = 1,
        EJackUMGSyougouColor__Gold = 2,
        EJackUMGSyougouColor__MAX = 3
    }


    // Enum JackGame.EJackUMGPresetColor
    public enum EJackUMGPresetColor : byte
    {
        EJackUMGPresetColor__NormalColor = 0,
        EJackUMGPresetColor__DisableColor = 1,
        EJackUMGPresetColor__MAX = 2
    }


    // Enum JackGame.EJackUMGCutSceneSkipDialog
    public enum EJackUMGCutSceneSkipDialog : byte
    {
        EJackUMGCutSceneSkipDialog__Hide = 0,
        EJackUMGCutSceneSkipDialog__Show = 1,
        EJackUMGCutSceneSkipDialog__AlwaysShow = 2,
        EJackUMGCutSceneSkipDialog__Close = 3,
        EJackUMGCutSceneSkipDialog__Title = 4,
        EJackUMGCutSceneSkipDialog__MAX = 5
    }


    // Enum JackGame.EJackUMGNorimonoGauge
    public enum EJackUMGNorimonoGauge : byte
    {
        EJackUMGNorimonoGauge__Horse3 = 0,
        EJackUMGNorimonoGauge__Horse4 = 1,
        EJackUMGNorimonoGauge__Norimono = 2,
        EJackUMGNorimonoGauge__Norimono01 = 3,
        EJackUMGNorimonoGauge__Norimono02 = 4,
        EJackUMGNorimonoGauge__Norimono03 = 5,
        EJackUMGNorimonoGauge__Norimono04 = 6,
        EJackUMGNorimonoGauge__Norimono05 = 7,
        EJackUMGNorimonoGauge__Norimono06 = 8,
        EJackUMGNorimonoGauge__Norimono07 = 9,
        EJackUMGNorimonoGauge__Norimono_00 = 10,
        EJackUMGNorimonoGauge__Norimono_01 = 11,
        EJackUMGNorimonoGauge__Norimono_02 = 12,
        EJackUMGNorimonoGauge__Norimono_03 = 13,
        EJackUMGNorimonoGauge__MAX = 14
    }


    // Enum JackGame.EJackWorldMapOpenReason
    public enum EJackWorldMapOpenReason : byte
    {
        EJackWorldMapOpenReason__None = 0,
        EJackWorldMapOpenReason__OpenMapButton = 1,
        EJackWorldMapOpenReason__WorldMapMenu = 2,
        EJackWorldMapOpenReason__UseDaijinamono = 3,
        EJackWorldMapOpenReason__JumonRura = 4,
        EJackWorldMapOpenReason__MapRura = 5,
        EJackWorldMapOpenReason__MAX = 6
    }


    // Enum JackGame.EJackUMGNorimonoGaugeAction
    public enum EJackUMGNorimonoGaugeAction : byte
    {
        EJackUMGNorimonoGaugeAction__Oriru_On = 0,
        EJackUMGNorimonoGaugeAction__Oriru_Off = 1,
        EJackUMGNorimonoGaugeAction__SpecialOn = 2,
        EJackUMGNorimonoGaugeAction__SpecialOff = 3,
        EJackUMGNorimonoGaugeAction__None = 4,
        EJackUMGNorimonoGaugeAction__MAX = 5
    }


    // Enum JackGame.EJackUMGHudRegion
    public enum EJackUMGHudRegion : byte
    {
        EJackUMGHudRegion__Default = 0,
        EJackUMGHudRegion__FullScreen = 1,
        EJackUMGHudRegion__Menu = 2,
        EJackUMGHudRegion__HudStatus = 3,
        EJackUMGHudRegion__LocationTitle = 4,
        EJackUMGHudRegion__MAX = 5
    }


    // Enum JackGame.EJackUMGMenuLayout
    public enum EJackUMGMenuLayout : byte
    {
        EJackUMGMenuLayout__Default = 0,
        EJackUMGMenuLayout__LeftTop = 1,
        EJackUMGMenuLayout__RightTop = 2,
        EJackUMGMenuLayout__CenterTop = 3,
        EJackUMGMenuLayout__LeftBottom = 4,
        EJackUMGMenuLayout__RightBottom = 5,
        EJackUMGMenuLayout__CenterBottom = 6,
        EJackUMGMenuLayout__CenterCenter = 7,
        EJackUMGMenuLayout__LeftCenter = 8,
        EJackUMGMenuLayout__RightCenter = 9,
        EJackUMGMenuLayout__Zero = 10,
        EJackUMGMenuLayout__MAX = 11
    }


    // Enum JackGame.EJackUMGHudAnimationAction
    public enum EJackUMGHudAnimationAction : byte
    {
        EJackUMGHudAnimationAction__Open = 0,
        EJackUMGHudAnimationAction__Close = 1,
        EJackUMGHudAnimationAction__AnimWait = 2,
        EJackUMGHudAnimationAction__AnimActiveStart = 3,
        EJackUMGHudAnimationAction__AnimActiveWait = 4,
        EJackUMGHudAnimationAction__AnimActiveEnd = 5,
        EJackUMGHudAnimationAction__AnimDead = 6,
        EJackUMGHudAnimationAction__AnimNoActiveWait = 7,
        EJackUMGHudAnimationAction__AnimActiveEndOnce = 8,
        EJackUMGHudAnimationAction__CloseNoAnimation = 9,
        EJackUMGHudAnimationAction__SuperMode = 10,
        EJackUMGHudAnimationAction__MAX = 11
    }


    // Enum JackGame.EJackUMGSaveingIndicator
    public enum EJackUMGSaveingIndicator : byte
    {
        EJackUMGSaveingIndicator__ManualSave = 0,
        EJackUMGSaveingIndicator__AutoSave = 1,
        EJackUMGSaveingIndicator__FailedSave = 2,
        EJackUMGSaveingIndicator__FailedSaveVoiceDrama = 3,
        EJackUMGSaveingIndicator__MAX = 4
    }


    // Enum JackGame.EJackUMGHorizontalMode
    public enum EJackUMGHorizontalMode : byte
    {
        EJackUMGHorizontalMode__None = 0,
        EJackUMGHorizontalMode__DisplayGamma = 1,
        EJackUMGHorizontalMode__VolumeBGM = 2,
        EJackUMGHorizontalMode__VolumeSE = 3,
        EJackUMGHorizontalMode__VolumeVoice = 4,
        EJackUMGHorizontalMode__ScreenPercentage = 5,
        EJackUMGHorizontalMode__ShadowQuality = 6,
        EJackUMGHorizontalMode__MAX = 7
    }


    // Enum JackGame.EJackUMGHudInitQueued
    public enum EJackUMGHudInitQueued : byte
    {
        EJackUMGHudInitQueued__Queued = 0,
        EJackUMGHudInitQueued__NotQueued = 1,
        EJackUMGHudInitQueued__TokiWoUbau = 2,
        EJackUMGHudInitQueued__QueuedActive = 3,
        EJackUMGHudInitQueued__MAX = 4
    }


    // Enum JackGame.EJackUMGHudPlateAnim
    public enum EJackUMGHudPlateAnim : byte
    {
        EJackUMGHudPlateAnim__Start = 0,
        EJackUMGHudPlateAnim__END = 1,
        EJackUMGHudPlateAnim__Wait = 2,
        EJackUMGHudPlateAnim__StartActive = 3,
        EJackUMGHudPlateAnim__EndActive = 4,
        EJackUMGHudPlateAnim__WaitActive = 5,
        EJackUMGHudPlateAnim__Dead = 6,
        EJackUMGHudPlateAnim__EndActiveOnce = 7,
        EJackUMGHudPlateAnim__MAX = 8
    }


    // Enum JackGame.EJackUMGHudStatusMode
    public enum EJackUMGHudStatusMode : byte
    {
        EJackUMGHudStatusMode__Name = 0,
        EJackUMGHudStatusMode__Hp = 1,
        EJackUMGHudStatusMode__Mp = 2,
        EJackUMGHudStatusMode__Level = 3,
        EJackUMGHudStatusMode__MAX = 4
    }


    // Enum JackGame.EJackUMGNamePlatform
    public enum EJackUMGNamePlatform : byte
    {
        EJackUMGNamePlatform__PFSwitch = 0,
        EJackUMGNamePlatform__PFPs4 = 1,
        EJackUMGNamePlatform__PFWindows = 2,
        EJackUMGNamePlatform__PFOther = 3,
        EJackUMGNamePlatform__MAX = 4
    }


    // Enum JackGame.EJackVoiceDramaMode
    public enum EJackVoiceDramaMode : byte
    {
        EJackVoiceDramaMode__Init = 0,
        EJackVoiceDramaMode__Voice = 1,
        EJackVoiceDramaMode__Subtitle = 2,
        EJackVoiceDramaMode__Log = 3,
        EJackVoiceDramaMode__FastForward = 4,
        EJackVoiceDramaMode__FastBackward = 5,
        EJackVoiceDramaMode__StaffRoll = 6,
        EJackVoiceDramaMode__MAX = 7
    }


    // Enum JackGame.EJackVoiceDramaPausePurpose
    public enum EJackVoiceDramaPausePurpose : byte
    {
        EJackVoiceDramaPausePurpose__Window = 0,
        EJackVoiceDramaPausePurpose__Wait = 1,
        EJackVoiceDramaPausePurpose__LogMode = 2,
        EJackVoiceDramaPausePurpose__MenuEnd = 3,
        EJackVoiceDramaPausePurpose__Pafupafu = 4,
        EJackVoiceDramaPausePurpose__MAX = 5
    }


    // Enum JackGame.EJackVoiceDramaEvent
    public enum EJackVoiceDramaEvent : byte
    {
        EJackVoiceDramaEvent__PageEnd = 0,
        EJackVoiceDramaEvent__LogPageUpdate = 1,
        EJackVoiceDramaEvent__FastForwardStart = 2,
        EJackVoiceDramaEvent__FastForwardEnd = 3,
        EJackVoiceDramaEvent__FastBackwardStart = 4,
        EJackVoiceDramaEvent__FastBackwardEnd = 5,
        EJackVoiceDramaEvent__TagStart = 6,
        EJackVoiceDramaEvent__TagAllEnd = 7,
        EJackVoiceDramaEvent__CaptionFadeOut = 8,
        EJackVoiceDramaEvent__CancelButtonChange = 9,
        EJackVoiceDramaEvent__MAX = 10
    }


    // Enum JackGame.EJackVoiceDramaTagEvent
    public enum EJackVoiceDramaTagEvent : byte
    {
        EJackVoiceDramaTagEvent__Wait = 0,
        EJackVoiceDramaTagEvent__WaitTag = 1,
        EJackVoiceDramaTagEvent__BG = 2,
        EJackVoiceDramaTagEvent__BGHide = 3,
        EJackVoiceDramaTagEvent__BGWait = 4,
        EJackVoiceDramaTagEvent__Image = 5,
        EJackVoiceDramaTagEvent__ImageHide = 6,
        EJackVoiceDramaTagEvent__ImageWait = 7,
        EJackVoiceDramaTagEvent__FadeOut = 8,
        EJackVoiceDramaTagEvent__FadeIn = 9,
        EJackVoiceDramaTagEvent__FadeWait = 10,
        EJackVoiceDramaTagEvent__BGMPlay = 11,
        EJackVoiceDramaTagEvent__BGMStop = 12,
        EJackVoiceDramaTagEvent__BGMWait = 13,
        EJackVoiceDramaTagEvent__EnvPlay = 14,
        EJackVoiceDramaTagEvent__EnvStop = 15,
        EJackVoiceDramaTagEvent__EnvWait = 16,
        EJackVoiceDramaTagEvent__VoicePlay = 17,
        EJackVoiceDramaTagEvent__VoiceWait = 18,
        EJackVoiceDramaTagEvent__SEPlay = 19,
        EJackVoiceDramaTagEvent__SEWait = 20,
        EJackVoiceDramaTagEvent__MEPlay = 21,
        EJackVoiceDramaTagEvent__Pafupafu = 22,
        EJackVoiceDramaTagEvent__StaffRoll = 23,
        EJackVoiceDramaTagEvent__MAX = 24
    }


    // Enum JackGame.EJackVoiceDramaHDPafuPafuJoyConPower
    public enum EJackVoiceDramaHDPafuPafuJoyConPower : byte
    {
        EJackVoiceDramaHDPafuPafuJoyConPower__Mild = 0,
        EJackVoiceDramaHDPafuPafuJoyConPower__Strength = 1,
        EJackVoiceDramaHDPafuPafuJoyConPower__MostStrongth = 2,
        EJackVoiceDramaHDPafuPafuJoyConPower__NumValues = 3,
        EJackVoiceDramaHDPafuPafuJoyConPower__EJackVoiceDramaHDPafuPafuJoyConPower_MAX = 4
    }


    // Enum JackGame.EJackVoiceDramaHDPafuPafuLeftRight
    public enum EJackVoiceDramaHDPafuPafuLeftRight : byte
    {
        EJackVoiceDramaHDPafuPafuLeftRight__Left = 0,
        EJackVoiceDramaHDPafuPafuLeftRight__Right = 1,
        EJackVoiceDramaHDPafuPafuLeftRight__None = 2,
        EJackVoiceDramaHDPafuPafuLeftRight__EJackVoiceDramaHDPafuPafuLeftRight_MAX = 3
    }


    // Enum JackGame.EJackVoiceDramaHDPafuPafuVoiceTag
    public enum EJackVoiceDramaHDPafuPafuVoiceTag : byte
    {
        EJackVoiceDramaHDPafuPafuVoiceTag__Start = 0,
        EJackVoiceDramaHDPafuPafuVoiceTag__PafuPafu = 1,
        EJackVoiceDramaHDPafuPafuVoiceTag__Knockout = 2,
        EJackVoiceDramaHDPafuPafuVoiceTag__Wait = 3,
        EJackVoiceDramaHDPafuPafuVoiceTag__EJackVoiceDramaHDPafuPafuVoiceTag_MAX = 4
    }


    // Enum JackGame.EJackVoiceDramaHDPafuPafuWhatRound
    public enum EJackVoiceDramaHDPafuPafuWhatRound : byte
    {
        EJackVoiceDramaHDPafuPafuWhatRound__Round1 = 0,
        EJackVoiceDramaHDPafuPafuWhatRound__Round2 = 1,
        EJackVoiceDramaHDPafuPafuWhatRound__Round3 = 2,
        EJackVoiceDramaHDPafuPafuWhatRound__Round4 = 3,
        EJackVoiceDramaHDPafuPafuWhatRound__NumValues = 4,
        EJackVoiceDramaHDPafuPafuWhatRound__EJackVoiceDramaHDPafuPafuWhatRound_MAX = 5
    }


    // Enum JackGame.EJackVoiceDramaHDPafuPafuVoiceTagTutorial
    public enum EJackVoiceDramaHDPafuPafuVoiceTagTutorial : byte
    {
        EJackVoiceDramaHDPafuPafuVoiceTagTutorial__Start = 0,
        EJackVoiceDramaHDPafuPafuVoiceTagTutorial__Knockout = 1,
        EJackVoiceDramaHDPafuPafuVoiceTagTutorial__Wait = 2,
        EJackVoiceDramaHDPafuPafuVoiceTagTutorial__EJackVoiceDramaHDPafuPafuVoiceTagTutorial_MAX = 3
    }


    // Enum JackGame.EJackFukubikiPayout
    public enum EJackFukubikiPayout : byte
    {
        EJackFukubikiPayout__ThreeSunMarks = 0,
        EJackFukubikiPayout__ThreeStarMarks = 1,
        EJackFukubikiPayout__ThreeMoonMarks = 2,
        EJackFukubikiPayout__ThreeWaterMarks = 3,
        EJackFukubikiPayout__ThreeHeartMarks = 4,
        EJackFukubikiPayout__Losing = 5,
        EJackFukubikiPayout__MAX = 6
    }


    // Enum JackGame.EJackMessageOutputMode
    public enum EJackMessageOutputMode : byte
    {
        EJackMessageOutputMode__Default = 0,
        EJackMessageOutputMode__FadeInLine = 1,
        EJackMessageOutputMode__FadeInPage = 2,
        EJackMessageOutputMode__MAX = 3
    }


    // Enum JackGame.EJackUMGTextJustify
    public enum EJackUMGTextJustify : byte
    {
        EJackUMGTextJustify__Left = 0,
        EJackUMGTextJustify__Center = 1,
        EJackUMGTextJustify__Right = 2,
        EJackUMGTextJustify__FromCenter = 3,
        EJackUMGTextJustify__FromRight = 4,
        EJackUMGTextJustify__MAX = 5
    }


    // Enum JackGame.EJackSerifuWindowType
    public enum EJackSerifuWindowType : byte
    {
        EJackSerifuWindowType__SefiruWindow = 0,
        EJackSerifuWindowType__SimpleText = 1,
        EJackSerifuWindowType__TenNoKoe = 2,
        EJackSerifuWindowType__MovieMessage = 3,
        EJackSerifuWindowType__TokugiPanel = 4,
        EJackSerifuWindowType__MAX = 5
    }


    // Enum JackGame.EJackEvaluateType
    public enum EJackEvaluateType : byte
    {
        EJackEvaluateType__Equal = 0,
        EJackEvaluateType__Big = 1,
        EJackEvaluateType__Little = 2,
        EJackEvaluateType__Up = 3,
        EJackEvaluateType__Under = 4,
        EJackEvaluateType__EJackEvaluateType_MAX = 5
    }


    // Enum JackGame.EJackActionMotionCompleteType
    public enum EJackActionMotionCompleteType : byte
    {
        EJackActionMotionCompleteType__Playing = 0,
        EJackActionMotionCompleteType__ArrivalLoopSection = 1,
        EJackActionMotionCompleteType__PlayComplete = 2,
        EJackActionMotionCompleteType__MAX = 3
    }


    // Enum JackGame.EJackRandomCalcType
    public enum EJackRandomCalcType : byte
    {
        EJackRandomCalcType__None = 0,
        EJackRandomCalcType__Plus = 1,
        EJackRandomCalcType__Minus = 2,
        EJackRandomCalcType__PlusMinus = 3,
        EJackRandomCalcType__Rate = 4,
        EJackRandomCalcType__MAX = 5
    }


    // Enum JackGame.EJackActionEffectDirectionType
    public enum EJackActionEffectDirectionType : byte
    {
        EJackActionEffectDirectionType__None = 0,
        EJackActionEffectDirectionType__KeepStart = 1,
        EJackActionEffectDirectionType__Velocity = 2,
        EJackActionEffectDirectionType__Attach = 3,
        EJackActionEffectDirectionType__MAX = 4
    }


    // Enum JackGame.EJackAttachTargetType
    public enum EJackAttachTargetType : byte
    {
        EJackAttachTargetType__None = 0,
        EJackAttachTargetType__World = 1,
        EJackAttachTargetType__Actor = 2,
        EJackAttachTargetType__MAX = 3
    }


    // Enum JackGame.EJackActionComparison
    public enum EJackActionComparison : byte
    {
        EJackActionComparison__None = 0,
        EJackActionComparison__Equals = 1,
        EJackActionComparison__NotEquals = 2,
        EJackActionComparison__GreaterThan = 3,
        EJackActionComparison__GreaterThanEquals = 4,
        EJackActionComparison__LessThan = 5,
        EJackActionComparison__LessThanEquals = 6,
        EJackActionComparison__EJackActionComparison_MAX = 7
    }


    // Enum JackGame.EJackActionModuleCreateType
    public enum EJackActionModuleCreateType : byte
    {
        EJackActionModuleCreateType__None = 0,
        EJackActionModuleCreateType__Damage = 1,
        EJackActionModuleCreateType__OddEffect = 2,
        EJackActionModuleCreateType__Revive = 3,
        EJackActionModuleCreateType__Kyuusyuu = 4,
        EJackActionModuleCreateType__NakamaYobi = 5,
        EJackActionModuleCreateType__Nusumu = 6,
        EJackActionModuleCreateType__Other = 7,
        EJackActionModuleCreateType__MAX = 8
    }


    // Enum JackGame.EJackActionCalcOddEffectFlag
    public enum EJackActionCalcOddEffectFlag : byte
    {
        EJackActionCalcOddEffectFlag__CalcScore = 0,
        EJackActionCalcOddEffectFlag__CriticalEnable = 1,
        EJackActionCalcOddEffectFlag__CriticalDisable = 2,
        EJackActionCalcOddEffectFlag__MAX = 3
    }


    // Enum JackGame.EJackActionCalcDamageFlag
    public enum EJackActionCalcDamageFlag : byte
    {
        EJackActionCalcDamageFlag__CalcScore = 0,
        EJackActionCalcDamageFlag__CalcMantan = 1,
        EJackActionCalcDamageFlag__CriticalEnable = 2,
        EJackActionCalcDamageFlag__CriticalDisable = 3,
        EJackActionCalcDamageFlag__MissDisable = 4,
        EJackActionCalcDamageFlag__MikawasiDisable = 5,
        EJackActionCalcDamageFlag__TateGuardDisable = 6,
        EJackActionCalcDamageFlag__BukiGuardDisable = 7,
        EJackActionCalcDamageFlag__KanzenGuardDisable = 8,
        EJackActionCalcDamageFlag__KnockBackDisable = 9,
        EJackActionCalcDamageFlag__UkenagasiDisable = 10,
        EJackActionCalcDamageFlag__CounterDisable = 11,
        EJackActionCalcDamageFlag__KabauEnable = 12,
        EJackActionCalcDamageFlag__KabawareEnable = 13,
        EJackActionCalcDamageFlag__JumonHansyaEnable = 14,
        EJackActionCalcDamageFlag__DamageHosyou = 15,
        EJackActionCalcDamageFlag__MatchAttackEnable = 16,
        EJackActionCalcDamageFlag__MAX = 17
    }


    // Enum JackGame.EJackCalcActionFlag
    public enum EJackCalcActionFlag : byte
    {
        EJackCalcActionFlag__NotUseMP = 0,
        EJackCalcActionFlag__MAX = 1
    }


    // Enum JackGame.EJackActionWaitType
    public enum EJackActionWaitType : byte
    {
        EJackActionWaitType__Motion = 0,
        EJackActionWaitType__TimeFromShot = 1,
        EJackActionWaitType__TimeFromHit = 2,
        EJackActionWaitType__ActionExecEnd = 3,
        EJackActionWaitType__MAX = 4
    }


    // Enum JackGame.EJackActionCategory
    public enum EJackActionCategory : byte
    {
        EJackActionCategory__None = 0,
        EJackActionCategory__Kougeki = 1,
        EJackActionCategory__Tokugi = 2,
        EJackActionCategory__Jumon = 3,
        EJackActionCategory__Item = 4,
        EJackActionCategory__Renkei = 5,
        EJackActionCategory__Special = 6,
        EJackActionCategory__Nigeru = 7,
        EJackActionCategory__Nusumu = 8,
        EJackActionCategory__MAX = 9
    }


    // Enum JackGame.EJackAirBubble
    public enum EJackAirBubble : byte
    {
        EJackAirBubble__Small = 0,
        EJackAirBubble__Large = 1,
        EJackAirBubble__Side = 2,
        EJackAirBubble__MAX = 3
    }


    // Enum JackGame.EJackAirBubbleActivity
    public enum EJackAirBubbleActivity : byte
    {
        EJackAirBubbleActivity__Neutral = 0,
        EJackAirBubbleActivity__Active = 1,
        EJackAirBubbleActivity__Deactive = 2,
        EJackAirBubbleActivity__MAX = 3
    }


    // Enum JackGame.EJackAirBubbleControlPurpose
    public enum EJackAirBubbleControlPurpose : byte
    {
        EJackAirBubbleControlPurpose__CutScene = 0,
        EJackAirBubbleControlPurpose__Internal = 1,
        EJackAirBubbleControlPurpose__MAX = 2
    }


    // Enum JackGame.EJackIgnoreAnimNotifyPurpose
    public enum EJackIgnoreAnimNotifyPurpose : byte
    {
        EJackIgnoreAnimNotifyPurpose__WaterSurface = 0,
        EJackIgnoreAnimNotifyPurpose__LoadReduction = 1,
        EJackIgnoreAnimNotifyPurpose__UmaRace = 2,
        EJackIgnoreAnimNotifyPurpose__CharacterCapture = 3,
        EJackIgnoreAnimNotifyPurpose__BattleActionCamera = 4,
        EJackIgnoreAnimNotifyPurpose__DitherHide = 5,
        EJackIgnoreAnimNotifyPurpose__CategoryHidden = 6,
        EJackIgnoreAnimNotifyPurpose__BattleManager = 7,
        EJackIgnoreAnimNotifyPurpose__FollowingCharacter = 8,
        EJackIgnoreAnimNotifyPurpose__PhotoMode = 9,
        EJackIgnoreAnimNotifyPurpose__MAX = 10
    }


    // Enum JackGame.EJackWaiterDisablePurpose
    public enum EJackWaiterDisablePurpose : byte
    {
        EJackWaiterDisablePurpose__DamageField = 0,
        EJackWaiterDisablePurpose__Dash = 1,
        EJackWaiterDisablePurpose__PhotoMode = 2,
        EJackWaiterDisablePurpose__HasProps = 3,
        EJackWaiterDisablePurpose__MAX = 4
    }


    // Enum JackGame.EJackNumberOfAttacks
    public enum EJackNumberOfAttacks : byte
    {
        EJackNumberOfAttacks__Once = 0,
        EJackNumberOfAttacks__OnceInLoop = 1,
        EJackNumberOfAttacks__Every = 2,
        EJackNumberOfAttacks__MAX = 3
    }


    // Enum JackGame.EJackCSArmType
    public enum EJackCSArmType : byte
    {
        EJackCSArmType__Right = 0,
        EJackCSArmType__Left = 1,
        EJackCSArmType__MAX = 2
    }


    // Enum JackGame.EJackBattleActionCameraGroundCheck
    public enum EJackBattleActionCameraGroundCheck : byte
    {
        EJackBattleActionCameraGroundCheck__None = 0,
        EJackBattleActionCameraGroundCheck__StartFieldCheck = 1,
        EJackBattleActionCameraGroundCheck__PeriodicFrameCheck = 2,
        EJackBattleActionCameraGroundCheck__MAX = 3
    }


    // Enum JackGame.EJackBattleActionCameraLengthAdjustCategory
    public enum EJackBattleActionCameraLengthAdjustCategory : byte
    {
        EJackBattleActionCameraLengthAdjustCategory__None = 0,
        EJackBattleActionCameraLengthAdjustCategory__Attacker = 1,
        EJackBattleActionCameraLengthAdjustCategory__Defender = 2,
        EJackBattleActionCameraLengthAdjustCategory__Larger = 3,
        EJackBattleActionCameraLengthAdjustCategory__Smaller = 4,
        EJackBattleActionCameraLengthAdjustCategory__AttackerMightLarger = 5,
        EJackBattleActionCameraLengthAdjustCategory__DefenderMightLarger = 6,
        EJackBattleActionCameraLengthAdjustCategory__AllMightLarger = 7,
        EJackBattleActionCameraLengthAdjustCategory__MAX = 8
    }


    // Enum JackGame.EJackBattleActionCameraTimingCategory
    public enum EJackBattleActionCameraTimingCategory : byte
    {
        EJackBattleActionCameraTimingCategory__None = 0,
        EJackBattleActionCameraTimingCategory__CameraStart = 1,
        EJackBattleActionCameraTimingCategory__ActionShot = 2,
        EJackBattleActionCameraTimingCategory__ActionHit = 3,
        EJackBattleActionCameraTimingCategory__ActionHitComponent = 4,
        EJackBattleActionCameraTimingCategory__MAX = 5
    }


    // Enum JackGame.EJackBattleActionCameraHiddenCharacterCategory
    public enum EJackBattleActionCameraHiddenCharacterCategory : byte
    {
        EJackBattleActionCameraHiddenCharacterCategory__None = 0,
        EJackBattleActionCameraHiddenCharacterCategory__Player = 1,
        EJackBattleActionCameraHiddenCharacterCategory__Monster = 2,
        EJackBattleActionCameraHiddenCharacterCategory__NotAttackerCharacters = 3,
        EJackBattleActionCameraHiddenCharacterCategory__NotDefenderCharacters = 4,
        EJackBattleActionCameraHiddenCharacterCategory__NotRenkeiAttackerA = 5,
        EJackBattleActionCameraHiddenCharacterCategory__NotRenkeiAttackerB = 6,
        EJackBattleActionCameraHiddenCharacterCategory__MAX = 7
    }


    // Enum JackGame.EJackBattleActionCameraEyeLocationCategory
    public enum EJackBattleActionCameraEyeLocationCategory : byte
    {
        EJackBattleActionCameraEyeLocationCategory__Character = 0,
        EJackBattleActionCameraEyeLocationCategory__FieldCenter = 1,
        EJackBattleActionCameraEyeLocationCategory__Characker_RotationRelative = 2,
        EJackBattleActionCameraEyeLocationCategory__Characker_RotationRelative_ZeroPitch = 3,
        EJackBattleActionCameraEyeLocationCategory__MAX = 4
    }


    // Enum JackGame.EJackBattleActionCameraLoopCategory
    public enum EJackBattleActionCameraLoopCategory : byte
    {
        EJackBattleActionCameraLoopCategory__Wait = 0,
        EJackBattleActionCameraLoopCategory__End = 1,
        EJackBattleActionCameraLoopCategory__Loop = 2,
        EJackBattleActionCameraLoopCategory__MAX = 3
    }


    // Enum JackGame.EJackBattleActionCameraPlayConditions
    public enum EJackBattleActionCameraPlayConditions : byte
    {
        EJackBattleActionCameraPlayConditions__Time = 0,
        EJackBattleActionCameraPlayConditions__ActionShot = 1,
        EJackBattleActionCameraPlayConditions__MAX = 2
    }


    // Enum JackGame.EJackBattleActionCameraAtCategory
    public enum EJackBattleActionCameraAtCategory : byte
    {
        EJackBattleActionCameraAtCategory__TriggerCharacter = 0,
        EJackBattleActionCameraAtCategory__TriggerCharacterPartner = 1,
        EJackBattleActionCameraAtCategory__TargetCharacter = 2,
        EJackBattleActionCameraAtCategory__TriggerMightCenter = 3,
        EJackBattleActionCameraAtCategory__EnemyMightCenter = 4,
        EJackBattleActionCameraAtCategory__CharactersCenter = 5,
        EJackBattleActionCameraAtCategory__BattleFieldCenter = 6,
        EJackBattleActionCameraAtCategory__TargetCharactersCenter = 7,
        EJackBattleActionCameraAtCategory__TargetCharactersCenter2 = 8,
        EJackBattleActionCameraAtCategory__MAX = 9
    }


    // Enum JackGame.EJackBattleActionCameraAttackerCategory
    public enum EJackBattleActionCameraAttackerCategory : byte
    {
        EJackBattleActionCameraAttackerCategory__Player = 0,
        EJackBattleActionCameraAttackerCategory__Friend = 1,
        EJackBattleActionCameraAttackerCategory__Monster = 2,
        EJackBattleActionCameraAttackerCategory__Max = 3,
        EJackBattleActionCameraAttackerCategory__None = 4
    }


    // Enum JackGame.EJackBattleCommandAILayerType
    public enum EJackBattleCommandAILayerType : byte
    {
        EJackBattleCommandAILayerType__Main = 0,
        EJackBattleCommandAILayerType__Sub = 1,
        EJackBattleCommandAILayerType__Konran = 2,
        EJackBattleCommandAILayerType__MAX = 3
    }


    // Enum JackGame.EJackBattleLockOnNotify
    public enum EJackBattleLockOnNotify : byte
    {
        EJackBattleLockOnNotify__None = 0,
        EJackBattleLockOnNotify__MAX = 1
    }


    // Enum JackGame.EJackMonsterAlignmentSequenceEnum
    public enum EJackMonsterAlignmentSequenceEnum : byte
    {
        EJackMonsterAlignmentSequenceEnum__MonsterAlignmentSequence_OneLine_Third = 0,
        EJackMonsterAlignmentSequenceEnum__MonsterAlignmentSequence_OneLine_Event = 1,
        EJackMonsterAlignmentSequenceEnum__MonsterAlignmentSequence_OneLine_Event2 = 2,
        EJackMonsterAlignmentSequenceEnum__MonsterAlignmentSequence_MAX = 3
    }


    // Enum JackGame.EJackBattleNigeruSequenceEventType
    public enum EJackBattleNigeruSequenceEventType : byte
    {
        EJackBattleNigeruSequenceEventType__None = 0,
        EJackBattleNigeruSequenceEventType__PlayNigeruMessage = 1,
        EJackBattleNigeruSequenceEventType__PlayPostEffect = 2,
        EJackBattleNigeruSequenceEventType__PlayMawarikomaretaMessage = 3,
        EJackBattleNigeruSequenceEventType__End = 4,
        EJackBattleNigeruSequenceEventType__MAX = 5
    }


    // Enum JackGame.EJackBattleResultZenmetuEventType
    public enum EJackBattleResultZenmetuEventType : byte
    {
        EJackBattleResultZenmetuEventType__None = 0,
        EJackBattleResultZenmetuEventType__PlayZenmetuMessage = 1,
        EJackBattleResultZenmetuEventType__StopZenmetuMessage = 2,
        EJackBattleResultZenmetuEventType__End = 3,
        EJackBattleResultZenmetuEventType__MAX = 4
    }


    // Enum JackGame.EJackBattleFukidasiPlaySec
    public enum EJackBattleFukidasiPlaySec : byte
    {
        EJackBattleFukidasiPlaySec__None = 0,
        EJackBattleFukidasiPlaySec__Init = 1,
        EJackBattleFukidasiPlaySec__Start = 2,
        EJackBattleFukidasiPlaySec__Loop = 3,
        EJackBattleFukidasiPlaySec__OutAnimWait = 4,
        EJackBattleFukidasiPlaySec__End = 5,
        EJackBattleFukidasiPlaySec__MAX = 6
    }


    // Enum JackGame.EJackBattleFukidasiTextVoiceType
    public enum EJackBattleFukidasiTextVoiceType : byte
    {
        EJackBattleFukidasiTextVoiceType__None = 0,
        EJackBattleFukidasiTextVoiceType__Yaruki = 1,
        EJackBattleFukidasiTextVoiceType__Tyuuikanki = 2,
        EJackBattleFukidasiTextVoiceType__Reisei = 3,
        EJackBattleFukidasiTextVoiceType__Aseri = 4,
        EJackBattleFukidasiTextVoiceType__Ikari = 5,
        EJackBattleFukidasiTextVoiceType__Kansya = 6,
        EJackBattleFukidasiTextVoiceType__Yorokobi = 7,
        EJackBattleFukidasiTextVoiceType__Konran = 8,
        EJackBattleFukidasiTextVoiceType__VoiceID = 9,
        EJackBattleFukidasiTextVoiceType__MAX = 10
    }


    // Enum JackGame.EJackBattleFukidasiTalkValueParamCalcType
    public enum EJackBattleFukidasiTalkValueParamCalcType : byte
    {
        EJackBattleFukidasiTalkValueParamCalcType__Equal = 0,
        EJackBattleFukidasiTalkValueParamCalcType__High = 1,
        EJackBattleFukidasiTalkValueParamCalcType__Low = 2,
        EJackBattleFukidasiTalkValueParamCalcType__MAX = 3
    }


    // Enum JackGame.EJackBattleFukidasiTalkConditionPeriod
    public enum EJackBattleFukidasiTalkConditionPeriod : byte
    {
        EJackBattleFukidasiTalkConditionPeriod__None = 0,
        EJackBattleFukidasiTalkConditionPeriod__TurnEnd = 1,
        EJackBattleFukidasiTalkConditionPeriod__RoundEnd = 2,
        EJackBattleFukidasiTalkConditionPeriod__BattleEnd = 3,
        EJackBattleFukidasiTalkConditionPeriod__NextFukidasi = 4,
        EJackBattleFukidasiTalkConditionPeriod__NextFukiTurnEnd = 5,
        EJackBattleFukidasiTalkConditionPeriod__OneFrame = 6,
        EJackBattleFukidasiTalkConditionPeriod__MAX = 7
    }


    // Enum JackGame.EJackBattleFukidasiCalcType
    public enum EJackBattleFukidasiCalcType : byte
    {
        EJackBattleFukidasiCalcType__None = 0,
        EJackBattleFukidasiCalcType__And = 1,
        EJackBattleFukidasiCalcType__Or = 2,
        EJackBattleFukidasiCalcType__MAX = 3
    }


    // Enum JackGame.EJackBattleFukidasiSndCalcType
    public enum EJackBattleFukidasiSndCalcType : byte
    {
        EJackBattleFukidasiSndCalcType__None = 0,
        EJackBattleFukidasiSndCalcType__Uniform = 1,
        EJackBattleFukidasiSndCalcType__Multi = 2,
        EJackBattleFukidasiSndCalcType__Sub = 3,
        EJackBattleFukidasiSndCalcType__MAX = 4
    }


    // Enum JackGame.EJackBattleFukidasiTalkTurn
    public enum EJackBattleFukidasiTalkTurn : byte
    {
        EJackBattleFukidasiTalkTurn__None = 0,
        EJackBattleFukidasiTalkTurn__ActiveTurn = 1,
        EJackBattleFukidasiTalkTurn__NonActiveTurn = 2,
        EJackBattleFukidasiTalkTurn__MonsterTurn = 3,
        EJackBattleFukidasiTalkTurn__MAX = 4
    }


    // Enum JackGame.EJackBattleFukidasiUIType
    public enum EJackBattleFukidasiUIType : byte
    {
        EJackBattleFukidasiUIType__None = 0,
        EJackBattleFukidasiUIType__Left = 1,
        EJackBattleFukidasiUIType__Right = 2,
        EJackBattleFukidasiUIType__MAX = 3
    }


    // Enum JackGame.EJackBattleFukidasiTalkTimming
    public enum EJackBattleFukidasiTalkTimming : byte
    {
        EJackBattleFukidasiTalkTimming__None = 0,
        EJackBattleFukidasiTalkTimming__Init = 1,
        EJackBattleFukidasiTalkTimming__BattleStart = 2,
        EJackBattleFukidasiTalkTimming__TurnStart = 3,
        EJackBattleFukidasiTalkTimming__TurnOddEffect = 4,
        EJackBattleFukidasiTalkTimming__CommandInputStart = 5,
        EJackBattleFukidasiTalkTimming__CommandInput = 6,
        EJackBattleFukidasiTalkTimming__ActionStart = 7,
        EJackBattleFukidasiTalkTimming__ActionFinalHit = 8,
        EJackBattleFukidasiTalkTimming__ActionEnd = 9,
        EJackBattleFukidasiTalkTimming__IntActionStart = 10,
        EJackBattleFukidasiTalkTimming__IntActionEnd = 11,
        EJackBattleFukidasiTalkTimming__Sakusen = 12,
        EJackBattleFukidasiTalkTimming__NigeruFaild = 13,
        EJackBattleFukidasiTalkTimming__ResultLevelUp = 14,
        EJackBattleFukidasiTalkTimming__ResultItem = 15,
        EJackBattleFukidasiTalkTimming__BattleEnd = 16,
        EJackBattleFukidasiTalkTimming__AnimNotify = 17,
        EJackBattleFukidasiTalkTimming__MAX = 18
    }


    // Enum JackGame.EJackBattleFukidasiTextEnableType
    public enum EJackBattleFukidasiTextEnableType : byte
    {
        EJackBattleFukidasiTextEnableType__None = 0,
        EJackBattleFukidasiTextEnableType__Approach = 1,
        EJackBattleFukidasiTextEnableType__Auto = 2,
        EJackBattleFukidasiTextEnableType__MAX = 3
    }


    // Enum JackGame.EJackBattleInterruptActionTiming
    public enum EJackBattleInterruptActionTiming : byte
    {
        EJackBattleInterruptActionTiming__None = 0,
        EJackBattleInterruptActionTiming__BattleStart = 1,
        EJackBattleInterruptActionTiming__RoundStart = 2,
        EJackBattleInterruptActionTiming__TurnEnd = 3,
        EJackBattleInterruptActionTiming__RoundEnd = 4,
        EJackBattleInterruptActionTiming__MAX = 5
    }


    // Enum JackGame.EJackPrgCameraIDFlag
    public enum EJackPrgCameraIDFlag : byte
    {
        EJackPrgCameraIDFlag__CasterOnly = 0,
        EJackPrgCameraIDFlag__TargetOnly = 1,
        EJackPrgCameraIDFlag__TargetOnly2 = 2,
        EJackPrgCameraIDFlag__BackOnly = 3,
        EJackPrgCameraIDFlag__GreenRect = 4,
        EJackPrgCameraIDFlag__Shrink = 5,
        EJackPrgCameraIDFlag__Forward = 6,
        EJackPrgCameraIDFlag__NoLow = 7,
        EJackPrgCameraIDFlag__NoAnim = 8,
        EJackPrgCameraIDFlag__Relocation = 9,
        EJackPrgCameraIDFlag__MAX = 10
    }


    // Enum JackGame.EJackPrgCameraAvailType
    public enum EJackPrgCameraAvailType : byte
    {
        EJackPrgCameraAvailType__None = 0,
        EJackPrgCameraAvailType__NG = 1,
        EJackPrgCameraAvailType__PushOut = 2,
        EJackPrgCameraAvailType__ScoreBad = 3,
        EJackPrgCameraAvailType__ScoreGood = 4,
        EJackPrgCameraAvailType__Priority = 5,
        EJackPrgCameraAvailType__MAX = 6
    }


    // Enum JackGame.EJackPrgCameraScoreType
    public enum EJackPrgCameraScoreType : byte
    {
        EJackPrgCameraScoreType__None = 0,
        EJackPrgCameraScoreType__Overlap = 1,
        EJackPrgCameraScoreType__MarginH = 2,
        EJackPrgCameraScoreType__MarginW = 3,
        EJackPrgCameraScoreType__MarginAll = 4,
        EJackPrgCameraScoreType__TurnPCDist = 5,
        EJackPrgCameraScoreType__PreCamera = 6,
        EJackPrgCameraScoreType__MAX = 7
    }


    // Enum JackGame.EJackPrgCameraCalcType
    public enum EJackPrgCameraCalcType : byte
    {
        EJackPrgCameraCalcType__None = 0,
        EJackPrgCameraCalcType__Front = 1,
        EJackPrgCameraCalcType__Diagonal = 2,
        EJackPrgCameraCalcType__Bird = 3,
        EJackPrgCameraCalcType__Socket = 4,
        EJackPrgCameraCalcType__MAX = 5
    }


    // Enum JackGame.EJackBattleActionCameraBehavior
    public enum EJackBattleActionCameraBehavior : byte
    {
        EJackBattleActionCameraBehavior__None = 0,
        EJackBattleActionCameraBehavior__AllAction = 1,
        EJackBattleActionCameraBehavior__AllTokugi = 2,
        EJackBattleActionCameraBehavior__MeireiAction = 3,
        EJackBattleActionCameraBehavior__MeireiTokugi = 4,
        EJackBattleActionCameraBehavior__MAX = 5
    }


    // Enum JackGame.EJackBattleHazukasiiNoroiCharacterType
    public enum EJackBattleHazukasiiNoroiCharacterType : byte
    {
        EJackBattleHazukasiiNoroiCharacterType__None = 0,
        EJackBattleHazukasiiNoroiCharacterType__P001 = 1,
        EJackBattleHazukasiiNoroiCharacterType__P002 = 2,
        EJackBattleHazukasiiNoroiCharacterType__P002B = 3,
        EJackBattleHazukasiiNoroiCharacterType__P003 = 4,
        EJackBattleHazukasiiNoroiCharacterType__P004 = 5,
        EJackBattleHazukasiiNoroiCharacterType__P005 = 6,
        EJackBattleHazukasiiNoroiCharacterType__P006 = 7,
        EJackBattleHazukasiiNoroiCharacterType__P007 = 8,
        EJackBattleHazukasiiNoroiCharacterType__P008 = 9,
        EJackBattleHazukasiiNoroiCharacterType__MAX = 10
    }


    // Enum JackGame.EJackBattleActionSelectType
    public enum EJackBattleActionSelectType : byte
    {
        EJackBattleActionSelectType__None = 0,
        EJackBattleActionSelectType__ListTop = 1,
        EJackBattleActionSelectType__Top60 = 2,
        EJackBattleActionSelectType__ListBottom = 3,
        EJackBattleActionSelectType__MAX = 4
    }


    // Enum JackGame.EJackBattleActionTargetType
    public enum EJackBattleActionTargetType : byte
    {
        EJackBattleActionTargetType__Normal = 0,
        EJackBattleActionTargetType__Hate = 1,
        EJackBattleActionTargetType__HPLow = 2,
        EJackBattleActionTargetType__Random = 3,
        EJackBattleActionTargetType__MAX = 4
    }


    // Enum JackGame.EJackBattleMoreActionType
    public enum EJackBattleMoreActionType : byte
    {
        EJackBattleMoreActionType__Once = 0,
        EJackBattleMoreActionType__Twice = 1,
        EJackBattleMoreActionType__ThreeTimes = 2,
        EJackBattleMoreActionType__Random = 3,
        EJackBattleMoreActionType__OnceTwiceRepeat = 4,
        EJackBattleMoreActionType__TwiceOnceRepeat = 5,
        EJackBattleMoreActionType__MAX = 6
    }


    // Enum JackGame.EJackBattleActionPatternType
    public enum EJackBattleActionPatternType : byte
    {
        EJackBattleActionPatternType__None = 0,
        EJackBattleActionPatternType__Heiti = 1,
        EJackBattleActionPatternType__Gake = 2,
        EJackBattleActionPatternType__Saka = 3,
        EJackBattleActionPatternType__Kaidan = 4,
        EJackBattleActionPatternType__KaitenA = 5,
        EJackBattleActionPatternType__KaitenB = 6,
        EJackBattleActionPatternType__KaitenC = 7,
        EJackBattleActionPatternType__Manual = 8,
        EJackBattleActionPatternType__MAX = 9
    }


    // Enum JackGame.EJackBattleIgnoreFastModePurpose
    public enum EJackBattleIgnoreFastModePurpose : byte
    {
        EJackBattleIgnoreFastModePurpose__MonsterAppear = 0,
        EJackBattleIgnoreFastModePurpose__MatineeRenkei = 1,
        EJackBattleIgnoreFastModePurpose__BattleResult = 2,
        EJackBattleIgnoreFastModePurpose__MAX = 3
    }


    // Enum JackGame.EJackBattleWeaponMontageKey
    public enum EJackBattleWeaponMontageKey : byte
    {
        EJackBattleWeaponMontageKey__None = 0,
        EJackBattleWeaponMontageKey__Init = 1,
        EJackBattleWeaponMontageKey__Idle = 2,
        EJackBattleWeaponMontageKey__IdleSheathe = 3,
        EJackBattleWeaponMontageKey__BougyoStart = 4,
        EJackBattleWeaponMontageKey__BougyoIdle = 5,
        EJackBattleWeaponMontageKey__BougyoEnd = 6,
        EJackBattleWeaponMontageKey__Unsheathe = 7,
        EJackBattleWeaponMontageKey__Sheathe = 8,
        EJackBattleWeaponMontageKey__MAX = 9
    }


    // Enum JackGame.EJackBattleWeaponStateMachine
    public enum EJackBattleWeaponStateMachine : byte
    {
        EJackBattleWeaponStateMachine__None = 0,
        EJackBattleWeaponStateMachine__Default = 1,
        EJackBattleWeaponStateMachine__Action = 2,
        EJackBattleWeaponStateMachine__MAX = 3
    }


    // Enum JackGame.EJackBattleWeaponNotify
    public enum EJackBattleWeaponNotify : byte
    {
        EJackBattleWeaponNotify__None = 0,
        EJackBattleWeaponNotify__Start = 1,
        EJackBattleWeaponNotify__Unsheathe = 2,
        EJackBattleWeaponNotify__Sheathe = 3,
        EJackBattleWeaponNotify__Idle = 4,
        EJackBattleWeaponNotify__BougyoStart = 5,
        EJackBattleWeaponNotify__BougyoIdle = 6,
        EJackBattleWeaponNotify__MAX = 7
    }


    // Enum JackGame.EJackCharacterMeshCollisionControlPurpose
    public enum EJackCharacterMeshCollisionControlPurpose : byte
    {
        EJackCharacterMeshCollisionControlPurpose__BattleProjectile = 0,
        EJackCharacterMeshCollisionControlPurpose__MAX = 1
    }


    // Enum JackGame.EJackCharacterMeshControlChannel
    public enum EJackCharacterMeshControlChannel : byte
    {
        EJackCharacterMeshControlChannel__Projectile = 0,
        EJackCharacterMeshControlChannel__MAX = 1
    }


    // Enum JackGame.EJackCustomMomevent
    public enum EJackCustomMomevent : byte
    {
        EJackCustomMomevent__Blueprint = 0,
        EJackCustomMomevent__Free = 1,
        EJackCustomMomevent__SimpleAutoNavigation = 2,
        EJackCustomMomevent__Disabled = 3,
        EJackCustomMomevent__MAX = 4
    }


    // Enum JackGame.EJackTokiNoKesinMotionState
    public enum EJackTokiNoKesinMotionState : byte
    {
        EJackTokiNoKesinMotionState__Stand = 0,
        EJackTokiNoKesinMotionState__Sit = 1,
        EJackTokiNoKesinMotionState__Move = 2,
        EJackTokiNoKesinMotionState__MAX = 3
    }


    // Enum JackGame.EJackCutSceneFadeLayer
    public enum EJackCutSceneFadeLayer : byte
    {
        EJackCutSceneFadeLayer__Normal = 0,
        EJackCutSceneFadeLayer__High = 1,
        EJackCutSceneFadeLayer__EJackCutSceneFadeLayer_MAX = 2
    }


    // Enum JackGame.EJackFacialReferencedAnimSequence
    public enum EJackFacialReferencedAnimSequence : byte
    {
        EJackFacialReferencedAnimSequence__Default = 0,
        EJackFacialReferencedAnimSequence__Additional = 1,
        EJackFacialReferencedAnimSequence__CutScene = 2,
        EJackFacialReferencedAnimSequence__CutSceneAdditional = 3,
        EJackFacialReferencedAnimSequence__MAX = 4
    }


    // Enum JackGame.EJackFacialAnimCategory
    public enum EJackFacialAnimCategory : byte
    {
        EJackFacialAnimCategory__Upper = 0,
        EJackFacialAnimCategory__Lower = 1,
        EJackFacialAnimCategory__MAX = 2
    }


    // Enum JackGame.EJackMonsterFollowerReactionMode
    public enum EJackMonsterFollowerReactionMode : byte
    {
        EJackMonsterFollowerReactionMode__None = 0,
        EJackMonsterFollowerReactionMode__Follow = 1,
        EJackMonsterFollowerReactionMode__Synchronize = 2,
        EJackMonsterFollowerReactionMode__MAX = 3
    }


    // Enum JackGame.EJackMonsterFollowerFormation
    public enum EJackMonsterFollowerFormation : byte
    {
        EJackMonsterFollowerFormation__Default = 0,
        EJackMonsterFollowerFormation__Line = 1,
        EJackMonsterFollowerFormation__MAX = 2
    }


    // Enum JackGame.EJackMonsterApproachAction
    public enum EJackMonsterApproachAction : byte
    {
        EJackMonsterApproachAction__None = 0,
        EJackMonsterApproachAction__FindAndFieldAction = 1,
        EJackMonsterApproachAction__MAX = 2
    }


    // Enum JackGame.EJackMonsterReaction
    public enum EJackMonsterReaction : byte
    {
        EJackMonsterReaction__None = 0,
        EJackMonsterReaction__FindAndEscape = 1,
        EJackMonsterReaction__FeelDangerAndEscape = 2,
        EJackMonsterReaction__FindAndMeeting = 3,
        EJackMonsterReaction__FindAndChase = 4,
        EJackMonsterReaction__BehaviorLikeLeader = 5,
        EJackMonsterReaction__BehaviorLikeFollower = 6,
        EJackMonsterReaction__MAX = 7
    }


    // Enum JackGame.EJackMonsterDepopBehavior
    public enum EJackMonsterDepopBehavior : byte
    {
        EJackMonsterDepopBehavior__Default = 0,
        EJackMonsterDepopBehavior__ReturnToHome = 1,
        EJackMonsterDepopBehavior__GoToSpecifyPoint = 2,
        EJackMonsterDepopBehavior__MAX = 3
    }


    // Enum JackGame.EJackMonsterPatrolMovingMethod
    public enum EJackMonsterPatrolMovingMethod : byte
    {
        EJackMonsterPatrolMovingMethod__Walk = 0,
        EJackMonsterPatrolMovingMethod__Run = 1,
        EJackMonsterPatrolMovingMethod__SmoothWalk = 2,
        EJackMonsterPatrolMovingMethod__SmoothRun = 3,
        EJackMonsterPatrolMovingMethod__MAX = 4
    }


    // Enum JackGame.EJackMonsterPatrolMode
    public enum EJackMonsterPatrolMode : byte
    {
        EJackMonsterPatrolMode__None = 0,
        EJackMonsterPatrolMode__OneShot = 1,
        EJackMonsterPatrolMode__OneShotAndDepop = 2,
        EJackMonsterPatrolMode__LoopReverse = 3,
        EJackMonsterPatrolMode__LoopRound = 4,
        EJackMonsterPatrolMode__MAX = 5
    }


    // Enum JackGame.EJackMonsterPopCondition
    public enum EJackMonsterPopCondition : byte
    {
        EJackMonsterPopCondition__Default = 0,
        EJackMonsterPopCondition__Sleep = 1,
        EJackMonsterPopCondition__GateKeeper = 2,
        EJackMonsterPopCondition__LieInWait = 3,
        EJackMonsterPopCondition__LieInWait_Sense = 4,
        EJackMonsterPopCondition__TakeOff = 5,
        EJackMonsterPopCondition__TakeOff_Sense = 6,
        EJackMonsterPopCondition__Mimic = 7,
        EJackMonsterPopCondition__Mimic_Sense = 8,
        EJackMonsterPopCondition__Await = 9,
        EJackMonsterPopCondition__Await_Sense = 10,
        EJackMonsterPopCondition__MAX = 11
    }


    // Enum JackGame.EJackMonsterActiveScenario
    public enum EJackMonsterActiveScenario : byte
    {
        EJackMonsterActiveScenario__Always = 0,
        EJackMonsterActiveScenario__Scenario_A = 1,
        EJackMonsterActiveScenario__Scenario_B = 2,
        EJackMonsterActiveScenario__Scenario_C = 3,
        EJackMonsterActiveScenario__Scenario_S = 4,
        EJackMonsterActiveScenario__MAX = 5
    }


    // Enum JackGame.EJackMonsterActiveWeather
    public enum EJackMonsterActiveWeather : byte
    {
        EJackMonsterActiveWeather__None = 0,
        EJackMonsterActiveWeather__Fine = 1,
        EJackMonsterActiveWeather__Rain = 2,
        EJackMonsterActiveWeather__Snow = 3,
        EJackMonsterActiveWeather__All = 4,
        EJackMonsterActiveWeather__MAX = 5
    }


    // Enum JackGame.EJackZukanMotionEquippedShieldFlag
    public enum EJackZukanMotionEquippedShieldFlag : byte
    {
        EJackZukanMotionEquippedShieldFlag__Ignore = 0,
        EJackZukanMotionEquippedShieldFlag__On = 1,
        EJackZukanMotionEquippedShieldFlag__Off = 2,
        EJackZukanMotionEquippedShieldFlag__MAX = 3
    }


    // Enum JackGame.EJackStaffRollEventType
    public enum EJackStaffRollEventType : byte
    {
        EJackStaffRollEventType__None = 0,
        EJackStaffRollEventType__Initialize = 1,
        EJackStaffRollEventType__ClearFontCache = 2,
        EJackStaffRollEventType__Fade = 3,
        EJackStaffRollEventType__Background = 4,
        EJackStaffRollEventType__CenterText = 5,
        EJackStaffRollEventType__ScrollStart = 6,
        EJackStaffRollEventType__ScrollText = 7,
        EJackStaffRollEventType__FadeStart = 8,
        EJackStaffRollEventType__FadeText = 9,
        EJackStaffRollEventType__MAX = 10
    }


    // Enum JackGame.EJackDebugMenuCategory
    public enum EJackDebugMenuCategory : byte
    {
        EJackDebugMenuCategory__Game = 0,
        EJackDebugMenuCategory__Scenario = 1,
        EJackDebugMenuCategory__Battle = 2,
        EJackDebugMenuCategory__Monster = 3,
        EJackDebugMenuCategory__Player = 4,
        EJackDebugMenuCategory__Camera = 5,
        EJackDebugMenuCategory__Item = 6,
        EJackDebugMenuCategory__NPC = 7,
        EJackDebugMenuCategory__Character = 8,
        EJackDebugMenuCategory__GameCharacter = 9,
        EJackDebugMenuCategory__Field = 10,
        EJackDebugMenuCategory__CutScene = 11,
        EJackDebugMenuCategory__UI = 12,
        EJackDebugMenuCategory__Sound = 13,
        EJackDebugMenuCategory__MiniGame = 14,
        EJackDebugMenuCategory__Level = 15,
        EJackDebugMenuCategory__Macro = 16,
        EJackDebugMenuCategory__FlagDebugger = 17,
        EJackDebugMenuCategory__DisplayInfo = 18,
        EJackDebugMenuCategory__ItemPresent = 19,
        EJackDebugMenuCategory__RecipeBook = 20,
        EJackDebugMenuCategory__Medal = 21,
        EJackDebugMenuCategory__Coin = 22,
        EJackDebugMenuCategory__TextMacroReplace = 23,
        EJackDebugMenuCategory__Sibari = 24,
        EJackDebugMenuCategory__Fukkatunojumon = 25,
        EJackDebugMenuCategory__SQEXNGWord = 26,
        EJackDebugMenuCategory__SaveLoad = 27,
        EJackDebugMenuCategory__Save = 28,
        EJackDebugMenuCategory__Load = 29,
        EJackDebugMenuCategory__Profile = 30,
        EJackDebugMenuCategory__Debug = 31,
        EJackDebugMenuCategory__TestMaps = 32,
        EJackDebugMenuCategory__System = 33,
        EJackDebugMenuCategory__TextureStreaming = 34,
        EJackDebugMenuCategory__Engine = 35,
        EJackDebugMenuCategory__Stat = 36,
        EJackDebugMenuCategory__Show = 37,
        EJackDebugMenuCategory__Cheat = 38,
        EJackDebugMenuCategory__ShowDebug = 39,
        EJackDebugMenuCategory__Misc = 40,
        EJackDebugMenuCategory__MAX = 41
    }


    // Enum JackGame.EJackDisperisonLayer
    public enum EJackDisperisonLayer : byte
    {
        EJackDisperisonLayer__Blueprint01 = 0,
        EJackDisperisonLayer__Blueprint02 = 1,
        EJackDisperisonLayer__Blueprint03 = 2,
        EJackDisperisonLayer__Ohter = 3,
        EJackDisperisonLayer__MAX = 4
    }


    // Enum JackGame.EJackHideCompoHiddenPurpose
    public enum EJackHideCompoHiddenPurpose : byte
    {
        EJackHideCompoHiddenPurpose__CompoOff = 0,
        EJackHideCompoHiddenPurpose__Gimmick = 1,
        EJackHideCompoHiddenPurpose__BattleSystem = 2,
        EJackHideCompoHiddenPurpose__EquipmentSystem = 3,
        EJackHideCompoHiddenPurpose__WeaponSystem = 4,
        EJackHideCompoHiddenPurpose__CharacterSystem = 5,
        EJackHideCompoHiddenPurpose__Action = 6,
        EJackHideCompoHiddenPurpose__AnimNotify = 7,
        EJackHideCompoHiddenPurpose__AnimSM = 8,
        EJackHideCompoHiddenPurpose__Renkei = 9,
        EJackHideCompoHiddenPurpose__Result = 10,
        EJackHideCompoHiddenPurpose__VehicleRideV204 = 11,
        EJackHideCompoHiddenPurpose__MAX = 12
    }


    // Enum JackGame.EJackEquipmentHiddenPurpose
    public enum EJackEquipmentHiddenPurpose : byte
    {
        EJackEquipmentHiddenPurpose__NPC = 0,
        EJackEquipmentHiddenPurpose__Battle = 1,
        EJackEquipmentHiddenPurpose__Renkei = 2,
        EJackEquipmentHiddenPurpose__CutScene = 3,
        EJackEquipmentHiddenPurpose__Vehicle = 4,
        EJackEquipmentHiddenPurpose__Camp = 5,
        EJackEquipmentHiddenPurpose__Character = 6,
        EJackEquipmentHiddenPurpose__AnimSM = 7,
        EJackEquipmentHiddenPurpose__MAX = 8
    }


    // Enum JackGame.EJackEyeLookAtControlPurpose
    public enum EJackEyeLookAtControlPurpose : byte
    {
        EJackEyeLookAtControlPurpose__CutScene = 0,
        EJackEyeLookAtControlPurpose__MAX = 1
    }


    // Enum JackGame.EJackFacialControlLayer
    public enum EJackFacialControlLayer : byte
    {
        EJackFacialControlLayer__Default = 0,
        EJackFacialControlLayer__AnimNotifyState = 1,
        EJackFacialControlLayer__TakeOverToIE = 2,
        EJackFacialControlLayer__AnimNotify = 3,
        EJackFacialControlLayer__IE = 4,
        EJackFacialControlLayer__Renkei = 5,
        EJackFacialControlLayer__Battle = 6,
        EJackFacialControlLayer__CutScene = 7,
        EJackFacialControlLayer__CutSceneCaption = 8,
        EJackFacialControlLayer__MAX = 9
    }


    // Enum JackGame.EJackRandomLipSyncMode
    public enum EJackRandomLipSyncMode : byte
    {
        EJackRandomLipSyncMode__UseCurve = 0,
        EJackRandomLipSyncMode__Enabled = 1,
        EJackRandomLipSyncMode__Disabled = 2,
        EJackRandomLipSyncMode__MAX = 3
    }


    // Enum JackGame.EJackRandomBlinkMode
    public enum EJackRandomBlinkMode : byte
    {
        EJackRandomBlinkMode__UseCurve = 0,
        EJackRandomBlinkMode__Enabled = 1,
        EJackRandomBlinkMode__Disabled = 2,
        EJackRandomBlinkMode__MAX = 3
    }


    // Enum JackGame.EJackLowerFacialState
    public enum EJackLowerFacialState : byte
    {
        EJackLowerFacialState__State000 = 0,
        EJackLowerFacialState__State001 = 1,
        EJackLowerFacialState__State002 = 2,
        EJackLowerFacialState__State003 = 3,
        EJackLowerFacialState__State004 = 4,
        EJackLowerFacialState__State005 = 5,
        EJackLowerFacialState__State006 = 6,
        EJackLowerFacialState__State007 = 7,
        EJackLowerFacialState__MAX = 8
    }


    // Enum JackGame.EJackUpperFacialState
    public enum EJackUpperFacialState : byte
    {
        EJackUpperFacialState__State000 = 0,
        EJackUpperFacialState__State001 = 1,
        EJackUpperFacialState__State002 = 2,
        EJackUpperFacialState__State003 = 3,
        EJackUpperFacialState__State004 = 4,
        EJackUpperFacialState__State005 = 5,
        EJackUpperFacialState__State006 = 6,
        EJackUpperFacialState__State007 = 7,
        EJackUpperFacialState__MAX = 8
    }


    // Enum JackGame.EJackFacialAnimTransitionMode
    public enum EJackFacialAnimTransitionMode : byte
    {
        EJackFacialAnimTransitionMode__NegativeToPositive = 0,
        EJackFacialAnimTransitionMode__PositiveToPositive = 1,
        EJackFacialAnimTransitionMode__PositiveToNegative = 2,
        EJackFacialAnimTransitionMode__MAX = 3
    }


    // Enum JackGame.EJackMaterialParameterControlMethod
    public enum EJackMaterialParameterControlMethod : byte
    {
        EJackMaterialParameterControlMethod__NoCopy = 0,
        EJackMaterialParameterControlMethod__CopyMaterialInstanceParameters = 1,
        EJackMaterialParameterControlMethod__CopyParameterOverrides = 2,
        EJackMaterialParameterControlMethod__MAX = 3
    }


    // Enum JackGame.EJackEyeControl
    public enum EJackEyeControl : byte
    {
        EJackEyeControl__Bone = 0,
        EJackEyeControl__Texture = 1,
        EJackEyeControl__MAX = 2
    }


    // Enum JackGame.EJackFriendAnimation
    public enum EJackFriendAnimation : byte
    {
        EJackFriendAnimation__PostFullBodySlot = 0,
        EJackFriendAnimation__PostBasePose = 1,
        EJackFriendAnimation__PostFootIK = 2,
        EJackFriendAnimation__PostArmIK = 3,
        EJackFriendAnimation__PostLookAt = 4,
        EJackFriendAnimation__PostFacial = 5,
        EJackFriendAnimation__PostHair = 6,
        EJackFriendAnimation__PostDynamics = 7,
        EJackFriendAnimation__FullAnimation = 8,
        EJackFriendAnimation__MAX = 9
    }


    // Enum JackGame.EJackFukkatunojumonCategory
    public enum EJackFukkatunojumonCategory : byte
    {
        EJackFukkatunojumonCategory__None = 0,
        EJackFukkatunojumonCategory__Scenario = 1,
        EJackFukkatunojumonCategory__CutScene = 2,
        EJackFukkatunojumonCategory__GameProgress = 3,
        EJackFukkatunojumonCategory__System = 4,
        EJackFukkatunojumonCategory__Guide = 5,
        EJackFukkatunojumonCategory__Gimmick = 6,
        EJackFukkatunojumonCategory__Quest = 7,
        EJackFukkatunojumonCategory__MapVisit = 8,
        EJackFukkatunojumonCategory__Minigame = 9,
        EJackFukkatunojumonCategory__Daijinamono = 10,
        EJackFukkatunojumonCategory__MapStart = 11,
        EJackFukkatunojumonCategory__PlayerName = 12,
        EJackFukkatunojumonCategory__Level = 13,
        EJackFukkatunojumonCategory__Exp = 14,
        EJackFukkatunojumonCategory__Motimono = 15,
        EJackFukkatunojumonCategory__Equip = 16,
        EJackFukkatunojumonCategory__SkillPanel = 17,
        EJackFukkatunojumonCategory__Action = 18,
        EJackFukkatunojumonCategory__FriendJoin = 19,
        EJackFukkatunojumonCategory__GuestNPCJoin = 20,
        EJackFukkatunojumonCategory__Coordinate = 21,
        EJackFukkatunojumonCategory__ScenarioProgress = 22,
        EJackFukkatunojumonCategory__Gold = 23,
        EJackFukkatunojumonCategory__Medal = 24,
        EJackFukkatunojumonCategory__Coin = 25,
        EJackFukkatunojumonCategory__BagCommon = 26,
        EJackFukkatunojumonCategory__BagEquip = 27,
        EJackFukkatunojumonCategory__RecipeBook = 28,
        EJackFukkatunojumonCategory__MonsterZukan = 29,
        EJackFukkatunojumonCategory__ItemZukan = 30,
        EJackFukkatunojumonCategory__Achievement = 31,
        EJackFukkatunojumonCategory__MAX = 32
    }


    // Enum JackGame.EJackFukkatunojumonSpecial
    public enum EJackFukkatunojumonSpecial : byte
    {
        EJackFukkatunojumonSpecial__None = 0,
        EJackFukkatunojumonSpecial__Triple = 1,
        EJackFukkatunojumonSpecial__SecondLapEnding = 2,
        EJackFukkatunojumonSpecial__StoreOpen = 3,
        EJackFukkatunojumonSpecial__NewGamePlus = 4,
        EJackFukkatunojumonSpecial__EJackFukkatunojumonSpecial_MAX = 5
    }


    // Enum JackGame.EJackFusigiKaziGlowPattern
    public enum EJackFusigiKaziGlowPattern : byte
    {
        EJackFusigiKaziGlowPattern__Normal = 0,
        EJackFusigiKaziGlowPattern__ChargeUp = 1,
        EJackFusigiKaziGlowPattern__ChargeDown = 2,
        EJackFusigiKaziGlowPattern__TypeMAX = 3,
        EJackFusigiKaziGlowPattern__Invalid = 4,
        EJackFusigiKaziGlowPattern__EJackFusigiKaziGlowPattern_MAX = 5
    }


    // Enum JackGame.EJackFusigiKaziMetalType
    public enum EJackFusigiKaziMetalType : byte
    {
        EJackFusigiKaziMetalType__Default = 0,
        EJackFusigiKaziMetalType__Complete = 1,
        EJackFusigiKaziMetalType__OverForge = 2,
        EJackFusigiKaziMetalType__Forge = 3,
        EJackFusigiKaziMetalType__Power_2 = 4,
        EJackFusigiKaziMetalType__Power_0_5 = 5,
        EJackFusigiKaziMetalType__Power_0_501 = 6,
        EJackFusigiKaziMetalType__FireUp = 7,
        EJackFusigiKaziMetalType__FireDown = 8,
        EJackFusigiKaziMetalType__TypeMAX = 9,
        EJackFusigiKaziMetalType__Invalid = 10,
        EJackFusigiKaziMetalType__EJackFusigiKaziMetalType_MAX = 11
    }


    // Enum JackGame.EJackFusigiKaziGameActionCategory
    public enum EJackFusigiKaziGameActionCategory : byte
    {
        EJackFusigiKaziGameActionCategory__Tataku = 0,
        EJackFusigiKaziGameActionCategory__Tokugi = 1,
        EJackFusigiKaziGameActionCategory__Kuwasiku = 2,
        EJackFusigiKaziGameActionCategory__Siageru = 3,
        EJackFusigiKaziGameActionCategory__Hissatu = 4,
        EJackFusigiKaziGameActionCategory__TypeMAX = 5,
        EJackFusigiKaziGameActionCategory__Invalid = 6,
        EJackFusigiKaziGameActionCategory__EJackFusigiKaziGameActionCategory_MAX = 7
    }


    // Enum JackGame.EJackUIKeyBindType
    public enum EJackUIKeyBindType : byte
    {
        EJackUIKeyBindType__Unbind = 0,
        EJackUIKeyBindType__DefaultMenuBind = 1,
        EJackUIKeyBindType__SakusenYoyakuMenuBind = 2,
        EJackUIKeyBindType__PhotoModeBind = 3,
        EJackUIKeyBindType__MAX = 4
    }


    // Enum JackGame.EJackInteractiveActorComponentControlPurpose
    public enum EJackInteractiveActorComponentControlPurpose : byte
    {
        EJackInteractiveActorComponentControlPurpose__Monster = 0,
        EJackInteractiveActorComponentControlPurpose__MAX = 1
    }


    // Enum JackGame.EJackUIDisplayLocation
    public enum EJackUIDisplayLocation : byte
    {
        EJackUIDisplayLocation__Default = 0,
        EJackUIDisplayLocation__Fukidasi = 1,
        EJackUIDisplayLocation__NamePlate = 2,
        EJackUIDisplayLocation__EmotionIcon = 3,
        EJackUIDisplayLocation__FusigiKaziEffect = 4,
        EJackUIDisplayLocation__FusigiKaziTable = 5,
        EJackUIDisplayLocation__MAX = 6
    }


    // Enum JackGame.EJackDlcDataUpdatePhase
    public enum EJackDlcDataUpdatePhase : byte
    {
        EJackDlcDataUpdatePhase__None = 0,
        EJackDlcDataUpdatePhase__Start = 1,
        EJackDlcDataUpdatePhase__Mount = 2,
        EJackDlcDataUpdatePhase__PackageCache = 3,
        EJackDlcDataUpdatePhase__Load = 4,
        EJackDlcDataUpdatePhase__LoadtWait = 5,
        EJackDlcDataUpdatePhase__FlagUpdate = 6,
        EJackDlcDataUpdatePhase__End = 7,
        EJackDlcDataUpdatePhase__MAX = 8
    }


    // Enum JackGame.EJackLazyMessageQueueId
    public enum EJackLazyMessageQueueId : byte
    {
        EJackLazyMessageQueueId__Quest = 0,
        EJackLazyMessageQueueId__Tokugi = 1,
        EJackLazyMessageQueueId__Tutorial = 2,
        EJackLazyMessageQueueId__PartyConditionOff = 3,
        EJackLazyMessageQueueId__MAX = 4
    }


    // Enum JackGame.EJackLookAtControlBone
    public enum EJackLookAtControlBone : byte
    {
        EJackLookAtControlBone__Spine1 = 0,
        EJackLookAtControlBone__Spine2 = 1,
        EJackLookAtControlBone__Neck = 2,
        EJackLookAtControlBone__Head = 3,
        EJackLookAtControlBone__MAX = 4
    }


    // Enum JackGame.EJackMatineeFacialReferanceState
    public enum EJackMatineeFacialReferanceState : byte
    {
        EJackMatineeFacialReferanceState__ReferenceRuntimeCurve = 0,
        EJackMatineeFacialReferanceState__ReferenceAnimationCurve = 1,
        EJackMatineeFacialReferanceState__ReferenceBoneSRT = 2,
        EJackMatineeFacialReferanceState__EJackMatineeFacialReferanceState_MAX = 3
    }


    // Enum JackGame.EJackMedal_Event
    public enum EJackMedal_Event : byte
    {
        EJackMedal_Event__MedalStamp = 0,
        EJackMedal_Event__MedalStampAndUnlockFourPage = 1,
        EJackMedal_Event__DontHaveMedal = 2,
        EJackMedal_Event__BranchOffice_FirstContact = 3,
        EJackMedal_Event__BranchOffice_FirstContact2 = 4,
        EJackMedal_Event__BranchOffice_Completed = 5,
        EJackMedal_Event__GirlsHighSchool_FirstContact = 6,
        EJackMedal_Event__GirlsHighSchool_FirstContact2 = 7,
        EJackMedal_Event__GirlsHighSchool_Completed = 8,
        EJackMedal_Event__GirlsHighSchool_Exchange = 9,
        EJackMedal_Event__MAX = 10
    }


    // Enum JackGame.EJackMeosiSlotBarChanceAnimState
    public enum EJackMeosiSlotBarChanceAnimState : byte
    {
        EJackMeosiSlotBarChanceAnimState__Idle = 0,
        EJackMeosiSlotBarChanceAnimState__In = 1,
        EJackMeosiSlotBarChanceAnimState__Wait = 2,
        EJackMeosiSlotBarChanceAnimState__Out = 3,
        EJackMeosiSlotBarChanceAnimState__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotTimeZone
    public enum EJackMeosiSlotTimeZone : byte
    {
        EJackMeosiSlotTimeZone__Time_Daytime = 0,
        EJackMeosiSlotTimeZone__Time_Twilight = 1,
        EJackMeosiSlotTimeZone__Time_Night = 2,
        EJackMeosiSlotTimeZone__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotDebugDraw
    public enum EJackMeosiSlotDebugDraw : byte
    {
        EJackMeosiSlotDebugDraw__NONE = 0,
        EJackMeosiSlotDebugDraw__HANDS = 1,
        EJackMeosiSlotDebugDraw__STATE = 2,
        EJackMeosiSlotDebugDraw__LOGS = 3,
        EJackMeosiSlotDebugDraw__OTHERS = 4,
        EJackMeosiSlotDebugDraw__MAX = 5
    }


    // Enum JackGame.EJackMeosiSlotBonusMonsterSetting
    public enum EJackMeosiSlotBonusMonsterSetting : byte
    {
        EJackMeosiSlotBonusMonsterSetting__Setting1_BB = 0,
        EJackMeosiSlotBonusMonsterSetting__Setting1_SB = 1,
        EJackMeosiSlotBonusMonsterSetting__Setting2_BB = 2,
        EJackMeosiSlotBonusMonsterSetting__Setting2_SB = 3,
        EJackMeosiSlotBonusMonsterSetting__Setting3_BB = 4,
        EJackMeosiSlotBonusMonsterSetting__Setting3_SB = 5,
        EJackMeosiSlotBonusMonsterSetting__Setting4_BB = 6,
        EJackMeosiSlotBonusMonsterSetting__Setting4_SB = 7,
        EJackMeosiSlotBonusMonsterSetting__Setting5_BB = 8,
        EJackMeosiSlotBonusMonsterSetting__Setting5_SB = 9,
        EJackMeosiSlotBonusMonsterSetting__Setting6_BB = 10,
        EJackMeosiSlotBonusMonsterSetting__Setting6_SB = 11,
        EJackMeosiSlotBonusMonsterSetting__Setting7_BB = 12,
        EJackMeosiSlotBonusMonsterSetting__Setting7_SB = 13,
        EJackMeosiSlotBonusMonsterSetting__Setting_UraMode = 14,
        EJackMeosiSlotBonusMonsterSetting__MAX = 15
    }


    // Enum JackGame.EJackMeosiSlotMachineCondition
    public enum EJackMeosiSlotMachineCondition : byte
    {
        EJackMeosiSlotMachineCondition__Level1 = 0,
        EJackMeosiSlotMachineCondition__Level2 = 1,
        EJackMeosiSlotMachineCondition__Level3 = 2,
        EJackMeosiSlotMachineCondition__Level4 = 3,
        EJackMeosiSlotMachineCondition__Level5 = 4,
        EJackMeosiSlotMachineCondition__MAX = 5
    }


    // Enum JackGame.EJackMeosiSlotBonusMonsterLevel
    public enum EJackMeosiSlotBonusMonsterLevel : byte
    {
        EJackMeosiSlotBonusMonsterLevel__Level1 = 0,
        EJackMeosiSlotBonusMonsterLevel__Level2 = 1,
        EJackMeosiSlotBonusMonsterLevel__Level3 = 2,
        EJackMeosiSlotBonusMonsterLevel__Level4 = 3,
        EJackMeosiSlotBonusMonsterLevel__Level5 = 4,
        EJackMeosiSlotBonusMonsterLevel__MAX = 5
    }


    // Enum JackGame.EJackMeosiSlotBGM
    public enum EJackMeosiSlotBGM : byte
    {
        EJackMeosiSlotBGM__Morning = 0,
        EJackMeosiSlotBGM__Evening = 1,
        EJackMeosiSlotBGM__Night = 2,
        EJackMeosiSlotBGM__NormalBonusConfirm = 3,
        EJackMeosiSlotBGM__BounusGame = 4,
        EJackMeosiSlotBGM__Result = 5,
        EJackMeosiSlotBGM__VolcanoStage = 6,
        EJackMeosiSlotBGM__CastleStage = 7,
        EJackMeosiSlotBGM__WinDecide = 8,
        EJackMeosiSlotBGM__ShimohuriChance = 9,
        EJackMeosiSlotBGM__MediumBossBattle = 10,
        EJackMeosiSlotBGM__BossBattle01 = 11,
        EJackMeosiSlotBGM__BossBattle02 = 12,
        EJackMeosiSlotBGM__BossBattle03 = 13,
        EJackMeosiSlotBGM__Nasubinara = 14,
        EJackMeosiSlotBGM__Stock1 = 15,
        EJackMeosiSlotBGM__Stock2 = 16,
        EJackMeosiSlotBGM__Stock3 = 17,
        EJackMeosiSlotBGM__Stock4 = 18,
        EJackMeosiSlotBGM__Stock5 = 19,
        EJackMeosiSlotBGM__Stock6 = 20,
        EJackMeosiSlotBGM__Stock7 = 21,
        EJackMeosiSlotBGM__Stock8 = 22,
        EJackMeosiSlotBGM__Stock9 = 23,
        EJackMeosiSlotBGM__Stock10 = 24,
        EJackMeosiSlotBGM__Stock11 = 25,
        EJackMeosiSlotBGM__Stock12 = 26,
        EJackMeosiSlotBGM__Stock13 = 27,
        EJackMeosiSlotBGM__Stock14 = 28,
        EJackMeosiSlotBGM__Stock15 = 29,
        EJackMeosiSlotBGM__Union = 30,
        EJackMeosiSlotBGM__SpecialTraning = 31,
        EJackMeosiSlotBGM__EJackMeosiSlotBGM_MAX = 32
    }


    // Enum JackGame.EJackMeosiSlotMachineGroup
    public enum EJackMeosiSlotMachineGroup : byte
    {
        EJackMeosiSlotMachineGroup__ONE = 0,
        EJackMeosiSlotMachineGroup__TWO = 1,
        EJackMeosiSlotMachineGroup__THREE = 2,
        EJackMeosiSlotMachineGroup__FOUR = 3,
        EJackMeosiSlotMachineGroup__FIVE = 4,
        EJackMeosiSlotMachineGroup__SIX = 5,
        EJackMeosiSlotMachineGroup__SEVEN = 6,
        EJackMeosiSlotMachineGroup__EIGHT = 7,
        EJackMeosiSlotMachineGroup__NINE = 8,
        EJackMeosiSlotMachineGroup__TEN = 9,
        EJackMeosiSlotMachineGroup__ELEVEN = 10,
        EJackMeosiSlotMachineGroup__TWELVE = 11,
        EJackMeosiSlotMachineGroup__THIRTEEN = 12,
        EJackMeosiSlotMachineGroup__FOURTEEN = 13,
        EJackMeosiSlotMachineGroup__FIFTEEN = 14,
        EJackMeosiSlotMachineGroup__SIXTEEN = 15,
        EJackMeosiSlotMachineGroup__SEVENTEEN = 16,
        EJackMeosiSlotMachineGroup__EIGHTEEN = 17,
        EJackMeosiSlotMachineGroup__NINETEEN = 18,
        EJackMeosiSlotMachineGroup__TWENTY = 19,
        EJackMeosiSlotMachineGroup__MAX = 20
    }


    // Enum JackGame.EJackMeosiSlotDrakeeColor
    public enum EJackMeosiSlotDrakeeColor : byte
    {
        EJackMeosiSlotDrakeeColor__BLACK = 0,
        EJackMeosiSlotDrakeeColor__GREEN = 1,
        EJackMeosiSlotDrakeeColor__RED = 2,
        EJackMeosiSlotDrakeeColor__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotDrakeeEffect
    public enum EJackMeosiSlotDrakeeEffect : byte
    {
        EJackMeosiSlotDrakeeEffect__NOTHING = 0,
        EJackMeosiSlotDrakeeEffect__SINGLE = 1,
        EJackMeosiSlotDrakeeEffect__GUST = 2,
        EJackMeosiSlotDrakeeEffect__CALM = 3,
        EJackMeosiSlotDrakeeEffect__DOUBLE_A = 4,
        EJackMeosiSlotDrakeeEffect__DOUBLE_B = 5,
        EJackMeosiSlotDrakeeEffect__DOUBLE_C = 6,
        EJackMeosiSlotDrakeeEffect__TRIPPLE = 7,
        EJackMeosiSlotDrakeeEffect__SQUARE = 8,
        EJackMeosiSlotDrakeeEffect__DOGLEG = 9,
        EJackMeosiSlotDrakeeEffect__V_SHAPED = 10,
        EJackMeosiSlotDrakeeEffect__BACK_SLASH = 11,
        EJackMeosiSlotDrakeeEffect__MINUS = 12,
        EJackMeosiSlotDrakeeEffect__FLOCK = 13,
        EJackMeosiSlotDrakeeEffect__MAX = 14
    }


    // Enum JackGame.EJackMeosiSlotSoundEffect
    public enum EJackMeosiSlotSoundEffect : byte
    {
        EJackMeosiSlotSoundEffect__DEFAULT = 0,
        EJackMeosiSlotSoundEffect__SPECIAL = 1,
        EJackMeosiSlotSoundEffect__SILENT = 2,
        EJackMeosiSlotSoundEffect__BONUS = 3,
        EJackMeosiSlotSoundEffect__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotBattleBackPattern
    public enum EJackMeosiSlotBattleBackPattern : byte
    {
        EJackMeosiSlotBattleBackPattern__PAT_INVALID = 0,
        EJackMeosiSlotBattleBackPattern__PAT_RRRR = 1,
        EJackMeosiSlotBattleBackPattern__PAT_CCRR = 2,
        EJackMeosiSlotBattleBackPattern__PAT_CRRR = 3,
        EJackMeosiSlotBattleBackPattern__PAT_CBRR = 4,
        EJackMeosiSlotBattleBackPattern__PAT_CCBB = 5,
        EJackMeosiSlotBattleBackPattern__PAT_CRBB = 6,
        EJackMeosiSlotBattleBackPattern__PAT_CBBB = 7,
        EJackMeosiSlotBattleBackPattern__PAT_RRBB = 8,
        EJackMeosiSlotBattleBackPattern__PAT_RBRR = 9,
        EJackMeosiSlotBattleBackPattern__PAT_RBBB = 10,
        EJackMeosiSlotBattleBackPattern__PAT_BBBB = 11,
        EJackMeosiSlotBattleBackPattern__PAT_BRBB = 12,
        EJackMeosiSlotBattleBackPattern__MAX = 13
    }


    // Enum JackGame.EJackVowel
    public enum EJackVowel : byte
    {
        EJackVowel__A = 0,
        EJackVowel__I = 1,
        EJackVowel__U = 2,
        EJackVowel__E = 3,
        EJackVowel__O = 4,
        EJackVowel__N = 5,
        EJackVowel__NA = 6,
        EJackVowel__XUA = 7,
        EJackVowel__NU = 8,
        EJackVowel__SH = 9,
        EJackVowel__BMP = 10,
        EJackVowel__MAX = 11
    }


    // Enum JackGame.EJackMeosiSlotBarBackColor
    public enum EJackMeosiSlotBarBackColor : byte
    {
        EJackMeosiSlotBarBackColor__BLUE = 0,
        EJackMeosiSlotBarBackColor__RED = 1,
        EJackMeosiSlotBarBackColor__GOLD = 2,
        EJackMeosiSlotBarBackColor__MEAT = 3,
        EJackMeosiSlotBarBackColor__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotCutinColor
    public enum EJackMeosiSlotCutinColor : byte
    {
        EJackMeosiSlotCutinColor__WHITE = 0,
        EJackMeosiSlotCutinColor__BLUE = 1,
        EJackMeosiSlotCutinColor__RED = 2,
        EJackMeosiSlotCutinColor__RAINBOW = 3,
        EJackMeosiSlotCutinColor__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotFireLampColor
    public enum EJackMeosiSlotFireLampColor : byte
    {
        EJackMeosiSlotFireLampColor__ORANGE = 0,
        EJackMeosiSlotFireLampColor__BLUE = 1,
        EJackMeosiSlotFireLampColor__RED = 2,
        EJackMeosiSlotFireLampColor__YELLOW = 3,
        EJackMeosiSlotFireLampColor__GREEN = 4,
        EJackMeosiSlotFireLampColor__LIGHT_BLUE = 5,
        EJackMeosiSlotFireLampColor__PURPLE = 6,
        EJackMeosiSlotFireLampColor__RAINBOW = 7,
        EJackMeosiSlotFireLampColor__WHITE = 8,
        EJackMeosiSlotFireLampColor__NONE = 9,
        EJackMeosiSlotFireLampColor__MAX = 10
    }


    // Enum JackGame.EJackMeosiSlotBattleResult
    public enum EJackMeosiSlotBattleResult : byte
    {
        EJackMeosiSlotBattleResult__NONE = 0,
        EJackMeosiSlotBattleResult__WIN = 1,
        EJackMeosiSlotBattleResult__LOSE = 2,
        EJackMeosiSlotBattleResult__DRAW = 3,
        EJackMeosiSlotBattleResult__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotBattleSequence
    public enum EJackMeosiSlotBattleSequence : byte
    {
        EJackMeosiSlotBattleSequence__DEFAULT = 0,
        EJackMeosiSlotBattleSequence__EFFECT_APPEARANCE_ENEMY = 1,
        EJackMeosiSlotBattleSequence__MAX = 2
    }


    // Enum JackGame.EJackMeosiSlotAttackEffect
    public enum EJackMeosiSlotAttackEffect : byte
    {
        EJackMeosiSlotAttackEffect__NONE = 0,
        EJackMeosiSlotAttackEffect__MISS = 1,
        EJackMeosiSlotAttackEffect__SLASH = 2,
        EJackMeosiSlotAttackEffect__SLASH_CRITICAL = 3,
        EJackMeosiSlotAttackEffect__STRIKE = 4,
        EJackMeosiSlotAttackEffect__STRIKE_CRITICAL = 5,
        EJackMeosiSlotAttackEffect__MAGIC_WEAK = 6,
        EJackMeosiSlotAttackEffect__MAGIC_STRONG = 7,
        EJackMeosiSlotAttackEffect__MAX = 8
    }


    // Enum JackGame.EJackMeosiSlotAttackClass
    public enum EJackMeosiSlotAttackClass : byte
    {
        EJackMeosiSlotAttackClass__PHYSICAL = 0,
        EJackMeosiSlotAttackClass__MAGICAL = 1,
        EJackMeosiSlotAttackClass__MAX = 2
    }


    // Enum JackGame.EJackMeosiSlotBattleReaction
    public enum EJackMeosiSlotBattleReaction : byte
    {
        EJackMeosiSlotBattleReaction__NONE = 0,
        EJackMeosiSlotBattleReaction__AVOID = 1,
        EJackMeosiSlotBattleReaction__DAMAGE = 2,
        EJackMeosiSlotBattleReaction__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotBattleAction
    public enum EJackMeosiSlotBattleAction : byte
    {
        EJackMeosiSlotBattleAction__NONE = 0,
        EJackMeosiSlotBattleAction__ATTACK = 1,
        EJackMeosiSlotBattleAction__ESCAPE = 2,
        EJackMeosiSlotBattleAction__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotBattleActor
    public enum EJackMeosiSlotBattleActor : byte
    {
        EJackMeosiSlotBattleActor__PARTY = 0,
        EJackMeosiSlotBattleActor__ENEMY = 1,
        EJackMeosiSlotBattleActor__MAX = 2
    }


    // Enum JackGame.EJackMeosiSlotMonsterBehavior
    public enum EJackMeosiSlotMonsterBehavior : byte
    {
        EJackMeosiSlotMonsterBehavior__ATTACK_MISS = 0,
        EJackMeosiSlotMonsterBehavior__ATTACK_WEAK = 1,
        EJackMeosiSlotMonsterBehavior__ATTACK_STRONG = 2,
        EJackMeosiSlotMonsterBehavior__ATTACK_MOST_STRONG = 3,
        EJackMeosiSlotMonsterBehavior__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotMonsterBehaviorPattern
    public enum EJackMeosiSlotMonsterBehaviorPattern : byte
    {
        EJackMeosiSlotMonsterBehaviorPattern__FLAT = 0,
        EJackMeosiSlotMonsterBehaviorPattern__SLOPE = 1,
        EJackMeosiSlotMonsterBehaviorPattern__CLIFF = 2,
        EJackMeosiSlotMonsterBehaviorPattern__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotMonsterSize
    public enum EJackMeosiSlotMonsterSize : byte
    {
        EJackMeosiSlotMonsterSize__S = 0,
        EJackMeosiSlotMonsterSize__M = 1,
        EJackMeosiSlotMonsterSize__L = 2,
        EJackMeosiSlotMonsterSize__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotBattleBack
    public enum EJackMeosiSlotBattleBack : byte
    {
        EJackMeosiSlotBattleBack__PARTY_BLUE = 0,
        EJackMeosiSlotBattleBack__ENEMY_RED = 1,
        EJackMeosiSlotBattleBack__GO_BACK = 2,
        EJackMeosiSlotBattleBack__CENTER = 3,
        EJackMeosiSlotBattleBack__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotMonsterID
    public enum EJackMeosiSlotMonsterID : byte
    {
        EJackMeosiSlotMonsterID__IdSlime = 0,
        EJackMeosiSlotMonsterID__IdDrackey = 1,
        EJackMeosiSlotMonsterID__IdMomonjya = 2,
        EJackMeosiSlotMonsterID__IdMocoky = 3,
        EJackMeosiSlotMonsterID__IdTombrelo = 4,
        EJackMeosiSlotMonsterID__IdKarakuriEgg = 5,
        EJackMeosiSlotMonsterID__IdChimera = 6,
        EJackMeosiSlotMonsterID__IdRottenCadaver = 7,
        EJackMeosiSlotMonsterID__IdBeeRider = 8,
        EJackMeosiSlotMonsterID__IdGolem = 9,
        EJackMeosiSlotMonsterID__IdWanderArmor = 10,
        EJackMeosiSlotMonsterID__IdTorol = 11,
        EJackMeosiSlotMonsterID__IdWyburnDog = 12,
        EJackMeosiSlotMonsterID__IdKillerPanther = 13,
        EJackMeosiSlotMonsterID__IdDemonPriest = 14,
        EJackMeosiSlotMonsterID__IdKillerMachine = 15,
        EJackMeosiSlotMonsterID__IdDragonPhD = 16,
        EJackMeosiSlotMonsterID__IdUncleHorn = 17,
        EJackMeosiSlotMonsterID__IdGigantes = 18,
        EJackMeosiSlotMonsterID__IdGreatDragon = 19,
        EJackMeosiSlotMonsterID__IdKillerMajinga = 20,
        EJackMeosiSlotMonsterID__IdDemonClub = 21,
        EJackMeosiSlotMonsterID__IdPurgatoryPegasus = 22,
        EJackMeosiSlotMonsterID__IdMimic = 23,
        EJackMeosiSlotMonsterID__IdLiquidMetalSlime = 24,
        EJackMeosiSlotMonsterID__IdGoldenSlime = 25,
        EJackMeosiSlotMonsterID__IdGoldMan = 26,
        EJackMeosiSlotMonsterID__IdDragon = 27,
        EJackMeosiSlotMonsterID__IdSkyDragon = 28,
        EJackMeosiSlotMonsterID__IdDragonGaia = 29,
        EJackMeosiSlotMonsterID__IdBonusbi = 30,
        EJackMeosiSlotMonsterID__IdUnionSlime = 31,
        EJackMeosiSlotMonsterID__IdPeachSlime = 32,
        EJackMeosiSlotMonsterID__IdMetalSlime = 33,
        EJackMeosiSlotMonsterID__IdKingSlime = 34,
        EJackMeosiSlotMonsterID__IdQueenSlime = 35,
        EJackMeosiSlotMonsterID__IdMetalKing = 36,
        EJackMeosiSlotMonsterID__MAX = 37
    }


    // Enum JackGame.EJackMeosiSlotOrb
    public enum EJackMeosiSlotOrb : byte
    {
        EJackMeosiSlotOrb__BLUE = 0,
        EJackMeosiSlotOrb__GREEN = 1,
        EJackMeosiSlotOrb__RED = 2,
        EJackMeosiSlotOrb__SILVER = 3,
        EJackMeosiSlotOrb__YELLOW = 4,
        EJackMeosiSlotOrb__PURPLE = 5,
        EJackMeosiSlotOrb__MAX = 6
    }


    // Enum JackGame.EJackMeosiSlotFlavorItemRank
    public enum EJackMeosiSlotFlavorItemRank : byte
    {
        EJackMeosiSlotFlavorItemRank__ONE = 0,
        EJackMeosiSlotFlavorItemRank__TWO = 1,
        EJackMeosiSlotFlavorItemRank__THREE = 2,
        EJackMeosiSlotFlavorItemRank__FOUR = 3,
        EJackMeosiSlotFlavorItemRank__FIVE = 4,
        EJackMeosiSlotFlavorItemRank__MAX = 5
    }


    // Enum JackGame.EJackMeosiSlotItemKind
    public enum EJackMeosiSlotItemKind : byte
    {
        EJackMeosiSlotItemKind__NONE = 0,
        EJackMeosiSlotItemKind__PLANT = 1,
        EJackMeosiSlotItemKind__ORE = 2,
        EJackMeosiSlotItemKind__HIDE = 3,
        EJackMeosiSlotItemKind__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotBalloon
    public enum EJackMeosiSlotBalloon : byte
    {
        EJackMeosiSlotBalloon__WHITE = 0,
        EJackMeosiSlotBalloon__BLUE = 1,
        EJackMeosiSlotBalloon__YELLOW = 2,
        EJackMeosiSlotBalloon__GREEN = 3,
        EJackMeosiSlotBalloon__RED = 4,
        EJackMeosiSlotBalloon__RAINBOW = 5,
        EJackMeosiSlotBalloon__MAX = 6
    }


    // Enum JackGame.EJackMeosiSlotTreasureBox
    public enum EJackMeosiSlotTreasureBox : byte
    {
        EJackMeosiSlotTreasureBox__POT = 0,
        EJackMeosiSlotTreasureBox__WOOD = 1,
        EJackMeosiSlotTreasureBox__RED = 2,
        EJackMeosiSlotTreasureBox__BLACK = 3,
        EJackMeosiSlotTreasureBox__GOLD = 4,
        EJackMeosiSlotTreasureBox__MAX = 5
    }


    // Enum JackGame.EJackMeosiSlotItemSpec
    public enum EJackMeosiSlotItemSpec : byte
    {
        EJackMeosiSlotItemSpec__None = 0,
        EJackMeosiSlotItemSpec__GreenOrb = 1,
        EJackMeosiSlotItemSpec__SilverOrb = 2,
        EJackMeosiSlotItemSpec__RedOrb = 3,
        EJackMeosiSlotItemSpec__YellowOrb = 4,
        EJackMeosiSlotItemSpec__BlueOrb = 5,
        EJackMeosiSlotItemSpec__PurpleOrb = 6,
        EJackMeosiSlotItemSpec__Feed = 7,
        EJackMeosiSlotItemSpec__RuraStone = 8,
        EJackMeosiSlotItemSpec__FecesOfHorses = 9,
        EJackMeosiSlotItemSpec__FecesOfCattle = 10,
        EJackMeosiSlotItemSpec__BeastSkin = 11,
        EJackMeosiSlotItemSpec__CopperOre = 12,
        EJackMeosiSlotItemSpec__HempYarn = 13,
        EJackMeosiSlotItemSpec__WeightStone = 14,
        EJackMeosiSlotItemSpec__BushyFur = 15,
        EJackMeosiSlotItemSpec__SoftBranches = 16,
        EJackMeosiSlotItemSpec__IronOre = 17,
        EJackMeosiSlotItemSpec__CottonGrass = 18,
        EJackMeosiSlotItemSpec__Goald = 19,
        EJackMeosiSlotItemSpec__DragonSkin = 20,
        EJackMeosiSlotItemSpec__GoldBullion = 21,
        EJackMeosiSlotItemSpec__MagicTree = 22,
        EJackMeosiSlotItemSpec__Platibum = 23,
        EJackMeosiSlotItemSpec__ShiningGrass = 24,
        EJackMeosiSlotItemSpec__MythicalSkin = 25,
        EJackMeosiSlotItemSpec__HeavyMetal = 26,
        EJackMeosiSlotItemSpec__DragonTreeBranch = 27,
        EJackMeosiSlotItemSpec__MonsterSkin = 28,
        EJackMeosiSlotItemSpec__BeautifulBranch = 29,
        EJackMeosiSlotItemSpec__SilkeGrass = 30,
        EJackMeosiSlotItemSpec__E456Confirm = 31,
        EJackMeosiSlotItemSpec__E56Confirm = 32,
        EJackMeosiSlotItemSpec__E6Confirm = 33,
        EJackMeosiSlotItemSpec__EvenConfirm = 34,
        EJackMeosiSlotItemSpec__OddConfirm = 35,
        EJackMeosiSlotItemSpec__Miss = 36,
        EJackMeosiSlotItemSpec__Relpaly = 37,
        EJackMeosiSlotItemSpec__Plum = 38,
        EJackMeosiSlotItemSpec__Watermelon = 39,
        EJackMeosiSlotItemSpec__Cherry = 40,
        EJackMeosiSlotItemSpec__Chance = 41,
        EJackMeosiSlotItemSpec__Bonus = 42,
        EJackMeosiSlotItemSpec__Union = 43,
        EJackMeosiSlotItemSpec__VeryHot = 44,
        EJackMeosiSlotItemSpec__ChanceHint = 45,
        EJackMeosiSlotItemSpec__SpTraining = 46,
        EJackMeosiSlotItemSpec__SpeedSeed = 47,
        EJackMeosiSlotItemSpec__MiracleSeed = 48,
        EJackMeosiSlotItemSpec__MAX = 49
    }


    // Enum JackGame.EJackMeosiSlotItem
    public enum EJackMeosiSlotItem : byte
    {
        EJackMeosiSlotItem__NONE = 0,
        EJackMeosiSlotItem__ORB = 1,
        EJackMeosiSlotItem__FEED = 2,
        EJackMeosiSlotItem__MIMIC = 3,
        EJackMeosiSlotItem__FLAVOR = 4,
        EJackMeosiSlotItem__KEY = 5,
        EJackMeosiSlotItem__HINTHAND = 6,
        EJackMeosiSlotItem__HINTSETTING = 7,
        EJackMeosiSlotItem__HINTEFFECT = 8,
        EJackMeosiSlotItem__TRAINING = 9,
        EJackMeosiSlotItem__MAX = 10
    }


    // Enum JackGame.EJackMeosiSlotMonsterRank
    public enum EJackMeosiSlotMonsterRank : byte
    {
        EJackMeosiSlotMonsterRank__F = 0,
        EJackMeosiSlotMonsterRank__E = 1,
        EJackMeosiSlotMonsterRank__D = 2,
        EJackMeosiSlotMonsterRank__C = 3,
        EJackMeosiSlotMonsterRank__B = 4,
        EJackMeosiSlotMonsterRank__A = 5,
        EJackMeosiSlotMonsterRank__S = 6,
        EJackMeosiSlotMonsterRank__SS = 7,
        EJackMeosiSlotMonsterRank__SSS = 8,
        EJackMeosiSlotMonsterRank__MAX = 9
    }


    // Enum JackGame.EJackMeosiSlotKeySeType
    public enum EJackMeosiSlotKeySeType : byte
    {
        EJackMeosiSlotKeySeType__KeySe_None = 0,
        EJackMeosiSlotKeySeType__KeySe_Lever_SP = 1,
        EJackMeosiSlotKeySeType__KeySe_All_SP = 2,
        EJackMeosiSlotKeySeType__KeySe_Lever_Delay = 3,
        EJackMeosiSlotKeySeType__KeySe_All_Delay = 4,
        EJackMeosiSlotKeySeType__KeySe_Lever_Delay_SP = 5,
        EJackMeosiSlotKeySeType__KeySe_All_Delay_SP = 6,
        EJackMeosiSlotKeySeType__MAX = 7
    }


    // Enum JackGame.EJackMeosiSlotEffectKeyType
    public enum EJackMeosiSlotEffectKeyType : byte
    {
        EJackMeosiSlotEffectKeyType__KeyType_None = 0,
        EJackMeosiSlotEffectKeyType__KeyType_Lever = 1,
        EJackMeosiSlotEffectKeyType__KeyType_FirstStop = 2,
        EJackMeosiSlotEffectKeyType__KeyType_SecondStop = 3,
        EJackMeosiSlotEffectKeyType__KeyType_ThirdStop = 4,
        EJackMeosiSlotEffectKeyType__MAX = 5
    }


    // Enum JackGame.EJackMeosiSlotEffect
    public enum EJackMeosiSlotEffect : byte
    {
        EJackMeosiSlotEffect__NONE = 0,
        EJackMeosiSlotEffect__REEL_LIGHT_OFF = 1,
        EJackMeosiSlotEffect__FIRE_LAMP = 2,
        EJackMeosiSlotEffect__DOOR_EMISSION = 3,
        EJackMeosiSlotEffect__PSEUDO_CONTINUATION = 4,
        EJackMeosiSlotEffect__CHANCE_CUTIN_DEF = 5,
        EJackMeosiSlotEffect__FLASH = 6,
        EJackMeosiSlotEffect__DRAKEE = 7,
        EJackMeosiSlotEffect__FRAME_LAMP = 8,
        EJackMeosiSlotEffect__FRAME_FIRE_LAMP = 9,
        EJackMeosiSlotEffect__MAX = 10
    }


    // Enum JackGame.EJackMeosiSlotDirectImpact
    public enum EJackMeosiSlotDirectImpact : byte
    {
        EJackMeosiSlotDirectImpact__FromBattle = 0,
        EJackMeosiSlotDirectImpact__FromNormal = 1,
        EJackMeosiSlotDirectImpact__FromTBox = 2,
        EJackMeosiSlotDirectImpact__FromYakumono = 3,
        EJackMeosiSlotDirectImpact__ToChallenge = 4,
        EJackMeosiSlotDirectImpact__ToMAX = 5,
        EJackMeosiSlotDirectImpact__EJackMeosiSlotDirectImpact_MAX = 6
    }


    // Enum JackGame.EJackMeosiSlotContEvent
    public enum EJackMeosiSlotContEvent : byte
    {
        EJackMeosiSlotContEvent__ContToBonus = 0,
        EJackMeosiSlotContEvent__ContToChallenge = 1,
        EJackMeosiSlotContEvent__ContToNormal = 2,
        EJackMeosiSlotContEvent__ContToMAX = 3,
        EJackMeosiSlotContEvent__EJackMeosiSlotContEvent_MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotScenarioBranch
    public enum EJackMeosiSlotScenarioBranch : byte
    {
        EJackMeosiSlotScenarioBranch__NORMAL = 0,
        EJackMeosiSlotScenarioBranch__STOCKED_NORMAL = 1,
        EJackMeosiSlotScenarioBranch__TRAINING = 2,
        EJackMeosiSlotScenarioBranch__NO_USE = 3,
        EJackMeosiSlotScenarioBranch__STOCKED_BATTLE = 4,
        EJackMeosiSlotScenarioBranch__BATTLE = 5,
        EJackMeosiSlotScenarioBranch__STOCKED_BONUS_GAME = 6,
        EJackMeosiSlotScenarioBranch__BONUS_GAME = 7,
        EJackMeosiSlotScenarioBranch__NO_USE01 = 8,
        EJackMeosiSlotScenarioBranch__NO_USE02 = 9,
        EJackMeosiSlotScenarioBranch__FAKE_TRAINING = 10,
        EJackMeosiSlotScenarioBranch__CEILING = 11,
        EJackMeosiSlotScenarioBranch__MAX = 12
    }


    // Enum JackGame.EJackMeosiSlotScenarioTBoxItem
    public enum EJackMeosiSlotScenarioTBoxItem : byte
    {
        EJackMeosiSlotScenarioTBoxItem__ItemNone = 0,
        EJackMeosiSlotScenarioTBoxItem__ItemFeed = 1,
        EJackMeosiSlotScenarioTBoxItem__ItemOrb = 2,
        EJackMeosiSlotScenarioTBoxItem__ItemHintHand = 3,
        EJackMeosiSlotScenarioTBoxItem__ItemHintSetting = 4,
        EJackMeosiSlotScenarioTBoxItem__ItemBonusStone = 5,
        EJackMeosiSlotScenarioTBoxItem__ItemOther = 6,
        EJackMeosiSlotScenarioTBoxItem__ItemHintEffect = 7,
        EJackMeosiSlotScenarioTBoxItem__ItemSpTraining = 8,
        EJackMeosiSlotScenarioTBoxItem__ItemLottery = 9,
        EJackMeosiSlotScenarioTBoxItem__ItemMimic = 10,
        EJackMeosiSlotScenarioTBoxItem__ItemMAX = 11,
        EJackMeosiSlotScenarioTBoxItem__EJackMeosiSlotScenarioTBoxItem_MAX = 12
    }


    // Enum JackGame.EJackMeosiSlotSpTrainingButton
    public enum EJackMeosiSlotSpTrainingButton : byte
    {
        EJackMeosiSlotSpTrainingButton__SptButton_None = 0,
        EJackMeosiSlotSpTrainingButton__SptButton_Normal = 1,
        EJackMeosiSlotSpTrainingButton__SptButton_Big = 2,
        EJackMeosiSlotSpTrainingButton__SptButton_Slime = 3,
        EJackMeosiSlotSpTrainingButton__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotSpTrainingAct
    public enum EJackMeosiSlotSpTrainingAct : byte
    {
        EJackMeosiSlotSpTrainingAct__SptAct_None = 0,
        EJackMeosiSlotSpTrainingAct__SptAct_Fake = 1,
        EJackMeosiSlotSpTrainingAct__SptAct_Speed = 2,
        EJackMeosiSlotSpTrainingAct__SptAct_Miracle = 3,
        EJackMeosiSlotSpTrainingAct__SptAct_Dash = 4,
        EJackMeosiSlotSpTrainingAct__SptAct_BlueDoor = 5,
        EJackMeosiSlotSpTrainingAct__SptAct_RedDoor = 6,
        EJackMeosiSlotSpTrainingAct__SptAct_Cont = 7,
        EJackMeosiSlotSpTrainingAct__MAX = 8
    }


    // Enum JackGame.EJackMeosiSlotSpTrainingAuraColor
    public enum EJackMeosiSlotSpTrainingAuraColor : byte
    {
        EJackMeosiSlotSpTrainingAuraColor__SptAura_None = 0,
        EJackMeosiSlotSpTrainingAuraColor__SptAura_White = 1,
        EJackMeosiSlotSpTrainingAuraColor__SptAura_Blue = 2,
        EJackMeosiSlotSpTrainingAuraColor__SptAura_Green = 3,
        EJackMeosiSlotSpTrainingAuraColor__SptAura_Red = 4,
        EJackMeosiSlotSpTrainingAuraColor__SptAura_Rainbow = 5,
        EJackMeosiSlotSpTrainingAuraColor__MAX = 6
    }


    // Enum JackGame.EJackMeosiSlotSpTrainingGameState
    public enum EJackMeosiSlotSpTrainingGameState : byte
    {
        EJackMeosiSlotSpTrainingGameState__SptGameSt_None = 0,
        EJackMeosiSlotSpTrainingGameState__SptGameSt_Normal = 1,
        EJackMeosiSlotSpTrainingGameState__SptGameSt_Cont = 2,
        EJackMeosiSlotSpTrainingGameState__SptGameSt_PreLast = 3,
        EJackMeosiSlotSpTrainingGameState__SptGameSt_End = 4,
        EJackMeosiSlotSpTrainingGameState__MAX = 5
    }


    // Enum JackGame.EJackMeosiSlotUnionGameResult
    public enum EJackMeosiSlotUnionGameResult : byte
    {
        EJackMeosiSlotUnionGameResult__Result_Cont = 0,
        EJackMeosiSlotUnionGameResult__Result_End = 1,
        EJackMeosiSlotUnionGameResult__Result_Succeed = 2,
        EJackMeosiSlotUnionGameResult__Result_Failure = 3,
        EJackMeosiSlotUnionGameResult__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotEvent
    public enum EJackMeosiSlotEvent : byte
    {
        EJackMeosiSlotEvent__NONE = 0,
        EJackMeosiSlotEvent__BATTLE_DEFAULT = 1,
        EJackMeosiSlotEvent__BATTLE_MID_BOSS = 2,
        EJackMeosiSlotEvent__BATTLE_BOSS = 3,
        EJackMeosiSlotEvent__RECRUIT = 4,
        EJackMeosiSlotEvent__TREASURE_BOX_DISCOVERY = 5,
        EJackMeosiSlotEvent__CHANCE_CUTIN_STEP_UP = 6,
        EJackMeosiSlotEvent__SHIMOFURI_CHANCE = 7,
        EJackMeosiSlotEvent__UNION_CHALLENGE = 8,
        EJackMeosiSlotEvent__SPECIAL_TRAINING = 9,
        EJackMeosiSlotEvent__BAR_CHANCE = 10,
        EJackMeosiSlotEvent__CHANCE_SLIME = 11,
        EJackMeosiSlotEvent__TREASURE_BOX_RETRY = 12,
        EJackMeosiSlotEvent__DRAKEE = 13,
        EJackMeosiSlotEvent__MAX = 14
    }


    // Enum JackGame.EJackMeosiSlotUnionScenarioBranch
    public enum EJackMeosiSlotUnionScenarioBranch : byte
    {
        EJackMeosiSlotUnionScenarioBranch__Branch = 0,
        EJackMeosiSlotUnionScenarioBranch__Branch01 = 1,
        EJackMeosiSlotUnionScenarioBranch__Branch02 = 2,
        EJackMeosiSlotUnionScenarioBranch__Branch03 = 3,
        EJackMeosiSlotUnionScenarioBranch__Branch04 = 4,
        EJackMeosiSlotUnionScenarioBranch__Branch05 = 5,
        EJackMeosiSlotUnionScenarioBranch__Branch06 = 6,
        EJackMeosiSlotUnionScenarioBranch__Branch07 = 7,
        EJackMeosiSlotUnionScenarioBranch__Branch08 = 8,
        EJackMeosiSlotUnionScenarioBranch__Branch09 = 9,
        EJackMeosiSlotUnionScenarioBranch__Branch10 = 10,
        EJackMeosiSlotUnionScenarioBranch__Branch11 = 11,
        EJackMeosiSlotUnionScenarioBranch__Branch12 = 12,
        EJackMeosiSlotUnionScenarioBranch__Branch13 = 13,
        EJackMeosiSlotUnionScenarioBranch__Branch14 = 14,
        EJackMeosiSlotUnionScenarioBranch__Branch15 = 15,
        EJackMeosiSlotUnionScenarioBranch__Branch16 = 16,
        EJackMeosiSlotUnionScenarioBranch__Branch17 = 17,
        EJackMeosiSlotUnionScenarioBranch__Branch18 = 18,
        EJackMeosiSlotUnionScenarioBranch__Branch19 = 19,
        EJackMeosiSlotUnionScenarioBranch__MAX = 20
    }


    // Enum JackGame.EJackMeosiSlotUnionScenarioID
    public enum EJackMeosiSlotUnionScenarioID : byte
    {
        EJackMeosiSlotUnionScenarioID__Special = 0,
        EJackMeosiSlotUnionScenarioID__Succ2G = 1,
        EJackMeosiSlotUnionScenarioID__Succ2G01 = 2,
        EJackMeosiSlotUnionScenarioID__Succ2G02 = 3,
        EJackMeosiSlotUnionScenarioID__Cont3G = 4,
        EJackMeosiSlotUnionScenarioID__Cont3G01 = 5,
        EJackMeosiSlotUnionScenarioID__Cont3G02 = 6,
        EJackMeosiSlotUnionScenarioID__Cont3G03 = 7,
        EJackMeosiSlotUnionScenarioID__Cont3G04 = 8,
        EJackMeosiSlotUnionScenarioID__Cont3G05 = 9,
        EJackMeosiSlotUnionScenarioID__Cont3G06 = 10,
        EJackMeosiSlotUnionScenarioID__MAX = 11
    }


    // Enum JackGame.EJackMeosiSlotScenarioHazureKind
    public enum EJackMeosiSlotScenarioHazureKind : byte
    {
        EJackMeosiSlotScenarioHazureKind__Kind_Moving = 0,
        EJackMeosiSlotScenarioHazureKind__Kind_Fake = 1,
        EJackMeosiSlotScenarioHazureKind__Kind_EmptyTBox = 2,
        EJackMeosiSlotScenarioHazureKind__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotScenarioTBoxOpenTiming
    public enum EJackMeosiSlotScenarioTBoxOpenTiming : byte
    {
        EJackMeosiSlotScenarioTBoxOpenTiming__Timing_Default = 0,
        EJackMeosiSlotScenarioTBoxOpenTiming__Timing_SecondStop = 1,
        EJackMeosiSlotScenarioTBoxOpenTiming__Timing_ThirdStop = 2,
        EJackMeosiSlotScenarioTBoxOpenTiming__Timing_NextDefault = 3,
        EJackMeosiSlotScenarioTBoxOpenTiming__Timing_NextSecondStop = 4,
        EJackMeosiSlotScenarioTBoxOpenTiming__Timing_NextThirdStop = 5,
        EJackMeosiSlotScenarioTBoxOpenTiming__MAX = 6
    }


    // Enum JackGame.EJackMeosiSlotUnionSlime
    public enum EJackMeosiSlotUnionSlime : byte
    {
        EJackMeosiSlotUnionSlime__Slime = 0,
        EJackMeosiSlotUnionSlime__Slime01 = 1,
        EJackMeosiSlotUnionSlime__Slime02 = 2,
        EJackMeosiSlotUnionSlime__None = 3,
        EJackMeosiSlotUnionSlime__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotScenarioTBoxKind
    public enum EJackMeosiSlotScenarioTBoxKind : byte
    {
        EJackMeosiSlotScenarioTBoxKind__Kind_None = 0,
        EJackMeosiSlotScenarioTBoxKind__Kind_HintHand = 1,
        EJackMeosiSlotScenarioTBoxKind__Kind_HintSetting = 2,
        EJackMeosiSlotScenarioTBoxKind__Kind_Orb = 3,
        EJackMeosiSlotScenarioTBoxKind__Kind_Orb_Low = 4,
        EJackMeosiSlotScenarioTBoxKind__Kind_Orb_High = 5,
        EJackMeosiSlotScenarioTBoxKind__Kind_Feed = 6,
        EJackMeosiSlotScenarioTBoxKind__Kind_Feed_Low = 7,
        EJackMeosiSlotScenarioTBoxKind__Kind_Feed_High = 8,
        EJackMeosiSlotScenarioTBoxKind__Kind_Lottery = 9,
        EJackMeosiSlotScenarioTBoxKind__Kind_Mimic = 10,
        EJackMeosiSlotScenarioTBoxKind__MAX = 11
    }


    // Enum JackGame.EJackMeosiSlotScenarioMamonoKind
    public enum EJackMeosiSlotScenarioMamonoKind : byte
    {
        EJackMeosiSlotScenarioMamonoKind__Kind_None = 0,
        EJackMeosiSlotScenarioMamonoKind__Kind_Default = 1,
        EJackMeosiSlotScenarioMamonoKind__Kind_Default01 = 2,
        EJackMeosiSlotScenarioMamonoKind__Kind_Default02 = 3,
        EJackMeosiSlotScenarioMamonoKind__Kind_Default03 = 4,
        EJackMeosiSlotScenarioMamonoKind__Kind_StepUp = 5,
        EJackMeosiSlotScenarioMamonoKind__MAX = 6
    }


    // Enum JackGame.EJackMeosiSlotScenarioSubAct
    public enum EJackMeosiSlotScenarioSubAct : byte
    {
        EJackMeosiSlotScenarioSubAct__SubAct_None = 0,
        EJackMeosiSlotScenarioSubAct__SubAct_Random_01 = 1,
        EJackMeosiSlotScenarioSubAct__SubAct_Random_02 = 2,
        EJackMeosiSlotScenarioSubAct__SubAct_Random_03 = 3,
        EJackMeosiSlotScenarioSubAct__SubAct_Random_04 = 4,
        EJackMeosiSlotScenarioSubAct__SubAct_Drakee_01 = 5,
        EJackMeosiSlotScenarioSubAct__SubAct_Drakee_02 = 6,
        EJackMeosiSlotScenarioSubAct__SubAct_CutIn = 7,
        EJackMeosiSlotScenarioSubAct__SubAct_CutInStepUp = 8,
        EJackMeosiSlotScenarioSubAct__SubAct_Yakumono = 9,
        EJackMeosiSlotScenarioSubAct__SubAct_TurnOffReel = 10,
        EJackMeosiSlotScenarioSubAct__SubAct_FireLamp = 11,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameLamp_00 = 12,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameLamp_01 = 13,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameLamp_02 = 14,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameLamp_03 = 15,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameFire_00 = 16,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameFire_01 = 17,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameFire_02 = 18,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameFire_03 = 19,
        EJackMeosiSlotScenarioSubAct__SubAct_FrameFire_04 = 20,
        EJackMeosiSlotScenarioSubAct__MAX = 21
    }


    // Enum JackGame.EJackMeosiSlotScenarioActNo
    public enum EJackMeosiSlotScenarioActNo : byte
    {
        EJackMeosiSlotScenarioActNo__ActNo_None = 0,
        EJackMeosiSlotScenarioActNo__ActNo_End = 1,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_01 = 2,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_02 = 3,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_03 = 4,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_04 = 5,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_05 = 6,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_06 = 7,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_07 = 8,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_08 = 9,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono_09 = 10,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono = 11,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono01 = 12,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono02 = 13,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono03 = 14,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono04 = 15,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono05 = 16,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono06 = 17,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono07 = 18,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono08 = 19,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono09 = 20,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono10 = 21,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono11 = 22,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono12 = 23,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono13 = 24,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono14 = 25,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono15 = 26,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono16 = 27,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono17 = 28,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono18 = 29,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono19 = 30,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono20 = 31,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono21 = 32,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono22 = 33,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono23 = 34,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono24 = 35,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono25 = 36,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono26 = 37,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono27 = 38,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono28 = 39,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono29 = 40,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono30 = 41,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono31 = 42,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono32 = 43,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono33 = 44,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono34 = 45,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono35 = 46,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono36 = 47,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono37 = 48,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono38 = 49,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono39 = 50,
        EJackMeosiSlotScenarioActNo__ActNo_Mamono40 = 51,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_01 = 52,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_02 = 53,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_03 = 54,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_04 = 55,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_05 = 56,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_06 = 57,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_07 = 58,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_08 = 59,
        EJackMeosiSlotScenarioActNo__ActNo_TBox_09 = 60,
        EJackMeosiSlotScenarioActNo__ActNo_TBox = 61,
        EJackMeosiSlotScenarioActNo__ActNo_TBox01 = 62,
        EJackMeosiSlotScenarioActNo__ActNo_TBox02 = 63,
        EJackMeosiSlotScenarioActNo__ActNo_TBox03 = 64,
        EJackMeosiSlotScenarioActNo__ActNo_TBox04 = 65,
        EJackMeosiSlotScenarioActNo__ActNo_TBox05 = 66,
        EJackMeosiSlotScenarioActNo__ActNo_TBox06 = 67,
        EJackMeosiSlotScenarioActNo__ActNo_TBox07 = 68,
        EJackMeosiSlotScenarioActNo__ActNo_TBox08 = 69,
        EJackMeosiSlotScenarioActNo__ActNo_TBox09 = 70,
        EJackMeosiSlotScenarioActNo__ActNo_TBox10 = 71,
        EJackMeosiSlotScenarioActNo__ActNo_TBox11 = 72,
        EJackMeosiSlotScenarioActNo__ActNo_TBox12 = 73,
        EJackMeosiSlotScenarioActNo__ActNo_TBox13 = 74,
        EJackMeosiSlotScenarioActNo__ActNo_TBox14 = 75,
        EJackMeosiSlotScenarioActNo__ActNo_TBox15 = 76,
        EJackMeosiSlotScenarioActNo__ActNo_TBox16 = 77,
        EJackMeosiSlotScenarioActNo__ActNo_TBox17 = 78,
        EJackMeosiSlotScenarioActNo__ActNo_TBox18 = 79,
        EJackMeosiSlotScenarioActNo__ActNo_TBox19 = 80,
        EJackMeosiSlotScenarioActNo__ActNo_TBox20 = 81,
        EJackMeosiSlotScenarioActNo__ActNo_TBox21 = 82,
        EJackMeosiSlotScenarioActNo__ActNo_TBox22 = 83,
        EJackMeosiSlotScenarioActNo__ActNo_TBox23 = 84,
        EJackMeosiSlotScenarioActNo__ActNo_TBox24 = 85,
        EJackMeosiSlotScenarioActNo__ActNo_TBox25 = 86,
        EJackMeosiSlotScenarioActNo__ActNo_TBox26 = 87,
        EJackMeosiSlotScenarioActNo__ActNo_TBox27 = 88,
        EJackMeosiSlotScenarioActNo__ActNo_TBox28 = 89,
        EJackMeosiSlotScenarioActNo__ActNo_TBox29 = 90,
        EJackMeosiSlotScenarioActNo__ActNo_TBox30 = 91,
        EJackMeosiSlotScenarioActNo__ActNo_TBox31 = 92,
        EJackMeosiSlotScenarioActNo__ActNo_TBox32 = 93,
        EJackMeosiSlotScenarioActNo__ActNo_TBox33 = 94,
        EJackMeosiSlotScenarioActNo__ActNo_TBox34 = 95,
        EJackMeosiSlotScenarioActNo__ActNo_TBox35 = 96,
        EJackMeosiSlotScenarioActNo__ActNo_TBox36 = 97,
        EJackMeosiSlotScenarioActNo__ActNo_TBox37 = 98,
        EJackMeosiSlotScenarioActNo__ActNo_TBox38 = 99,
        EJackMeosiSlotScenarioActNo__ActNo_TBox39 = 100,
        EJackMeosiSlotScenarioActNo__ActNo_TBox40 = 101,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_01 = 102,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_02 = 103,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_03 = 104,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_04 = 105,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_05 = 106,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_06 = 107,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_07 = 108,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_08 = 109,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure_09 = 110,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure = 111,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure01 = 112,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure02 = 113,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure03 = 114,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure04 = 115,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure05 = 116,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure06 = 117,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure07 = 118,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure08 = 119,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure09 = 120,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure10 = 121,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure11 = 122,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure12 = 123,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure13 = 124,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure14 = 125,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure15 = 126,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure16 = 127,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure17 = 128,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure18 = 129,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure19 = 130,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure20 = 131,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure21 = 132,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure22 = 133,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure23 = 134,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure24 = 135,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure25 = 136,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure26 = 137,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure27 = 138,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure28 = 139,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure29 = 140,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure30 = 141,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure31 = 142,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure32 = 143,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure33 = 144,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure34 = 145,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure35 = 146,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure36 = 147,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure37 = 148,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure38 = 149,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure39 = 150,
        EJackMeosiSlotScenarioActNo__ActNo_Hazure40 = 151,
        EJackMeosiSlotScenarioActNo__ActNo_Random_01 = 152,
        EJackMeosiSlotScenarioActNo__ActNo_Random_02 = 153,
        EJackMeosiSlotScenarioActNo__ActNo_Random_03 = 154,
        EJackMeosiSlotScenarioActNo__ActNo_Random_04 = 155,
        EJackMeosiSlotScenarioActNo__ActNo_Random_05 = 156,
        EJackMeosiSlotScenarioActNo__ActNo_Random_06 = 157,
        EJackMeosiSlotScenarioActNo__ActNo_Random_07 = 158,
        EJackMeosiSlotScenarioActNo__ActNo_Random_08 = 159,
        EJackMeosiSlotScenarioActNo__ActNo_Random_09 = 160,
        EJackMeosiSlotScenarioActNo__ActNo_Random = 161,
        EJackMeosiSlotScenarioActNo__ActNo_Random01 = 162,
        EJackMeosiSlotScenarioActNo__ActNo_Random02 = 163,
        EJackMeosiSlotScenarioActNo__ActNo_Random03 = 164,
        EJackMeosiSlotScenarioActNo__ActNo_Random04 = 165,
        EJackMeosiSlotScenarioActNo__ActNo_Random05 = 166,
        EJackMeosiSlotScenarioActNo__ActNo_Random06 = 167,
        EJackMeosiSlotScenarioActNo__ActNo_Random07 = 168,
        EJackMeosiSlotScenarioActNo__ActNo_Random08 = 169,
        EJackMeosiSlotScenarioActNo__ActNo_Random09 = 170,
        EJackMeosiSlotScenarioActNo__ActNo_Random10 = 171,
        EJackMeosiSlotScenarioActNo__ActNo_Random11 = 172,
        EJackMeosiSlotScenarioActNo__ActNo_Random12 = 173,
        EJackMeosiSlotScenarioActNo__ActNo_Random13 = 174,
        EJackMeosiSlotScenarioActNo__ActNo_Random14 = 175,
        EJackMeosiSlotScenarioActNo__ActNo_Random15 = 176,
        EJackMeosiSlotScenarioActNo__ActNo_Random16 = 177,
        EJackMeosiSlotScenarioActNo__ActNo_Random17 = 178,
        EJackMeosiSlotScenarioActNo__ActNo_Random18 = 179,
        EJackMeosiSlotScenarioActNo__ActNo_Random19 = 180,
        EJackMeosiSlotScenarioActNo__ActNo_Random20 = 181,
        EJackMeosiSlotScenarioActNo__ActNo_Random21 = 182,
        EJackMeosiSlotScenarioActNo__ActNo_Random22 = 183,
        EJackMeosiSlotScenarioActNo__ActNo_Random23 = 184,
        EJackMeosiSlotScenarioActNo__ActNo_Random24 = 185,
        EJackMeosiSlotScenarioActNo__ActNo_Random25 = 186,
        EJackMeosiSlotScenarioActNo__ActNo_Random26 = 187,
        EJackMeosiSlotScenarioActNo__ActNo_Random27 = 188,
        EJackMeosiSlotScenarioActNo__ActNo_Random28 = 189,
        EJackMeosiSlotScenarioActNo__ActNo_Random29 = 190,
        EJackMeosiSlotScenarioActNo__ActNo_Random30 = 191,
        EJackMeosiSlotScenarioActNo__ActNo_Random31 = 192,
        EJackMeosiSlotScenarioActNo__ActNo_Random32 = 193,
        EJackMeosiSlotScenarioActNo__ActNo_Random33 = 194,
        EJackMeosiSlotScenarioActNo__ActNo_Random34 = 195,
        EJackMeosiSlotScenarioActNo__ActNo_Random35 = 196,
        EJackMeosiSlotScenarioActNo__ActNo_Random36 = 197,
        EJackMeosiSlotScenarioActNo__ActNo_Random37 = 198,
        EJackMeosiSlotScenarioActNo__ActNo_Random38 = 199,
        EJackMeosiSlotScenarioActNo__ActNo_Random39 = 200,
        EJackMeosiSlotScenarioActNo__ActNo_Random40 = 201,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_01 = 202,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_02 = 203,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_03 = 204,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_04 = 205,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_05 = 206,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_06 = 207,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_07 = 208,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_08 = 209,
        EJackMeosiSlotScenarioActNo__ActNo_Slime_09 = 210,
        EJackMeosiSlotScenarioActNo__ActNo_Slime = 211,
        EJackMeosiSlotScenarioActNo__ActNo_Slime01 = 212,
        EJackMeosiSlotScenarioActNo__ActNo_Slime02 = 213,
        EJackMeosiSlotScenarioActNo__ActNo_Slime03 = 214,
        EJackMeosiSlotScenarioActNo__ActNo_Slime04 = 215,
        EJackMeosiSlotScenarioActNo__ActNo_Slime05 = 216,
        EJackMeosiSlotScenarioActNo__ActNo_Slime06 = 217,
        EJackMeosiSlotScenarioActNo__ActNo_Slime07 = 218,
        EJackMeosiSlotScenarioActNo__ActNo_Slime08 = 219,
        EJackMeosiSlotScenarioActNo__ActNo_Slime09 = 220,
        EJackMeosiSlotScenarioActNo__ActNo_Slime10 = 221,
        EJackMeosiSlotScenarioActNo__ActNo_Slime11 = 222,
        EJackMeosiSlotScenarioActNo__ActNo_Slime12 = 223,
        EJackMeosiSlotScenarioActNo__ActNo_Slime13 = 224,
        EJackMeosiSlotScenarioActNo__ActNo_Slime14 = 225,
        EJackMeosiSlotScenarioActNo__ActNo_Slime15 = 226,
        EJackMeosiSlotScenarioActNo__ActNo_Slime16 = 227,
        EJackMeosiSlotScenarioActNo__ActNo_Slime17 = 228,
        EJackMeosiSlotScenarioActNo__ActNo_Slime18 = 229,
        EJackMeosiSlotScenarioActNo__ActNo_Slime19 = 230,
        EJackMeosiSlotScenarioActNo__ActNo_Slime20 = 231,
        EJackMeosiSlotScenarioActNo__ActNo_Slime21 = 232,
        EJackMeosiSlotScenarioActNo__ActNo_Slime22 = 233,
        EJackMeosiSlotScenarioActNo__ActNo_Slime23 = 234,
        EJackMeosiSlotScenarioActNo__ActNo_Slime24 = 235,
        EJackMeosiSlotScenarioActNo__ActNo_Slime25 = 236,
        EJackMeosiSlotScenarioActNo__ActNo_Slime26 = 237,
        EJackMeosiSlotScenarioActNo__ActNo_Slime27 = 238,
        EJackMeosiSlotScenarioActNo__ActNo_Slime28 = 239,
        EJackMeosiSlotScenarioActNo__ActNo_Slime29 = 240,
        EJackMeosiSlotScenarioActNo__ActNo_Slime30 = 241,
        EJackMeosiSlotScenarioActNo__ActNo_Slime31 = 242,
        EJackMeosiSlotScenarioActNo__ActNo_Slime32 = 243,
        EJackMeosiSlotScenarioActNo__ActNo_Slime33 = 244,
        EJackMeosiSlotScenarioActNo__ActNo_Slime34 = 245,
        EJackMeosiSlotScenarioActNo__ActNo_Slime35 = 246,
        EJackMeosiSlotScenarioActNo__ActNo_Slime36 = 247,
        EJackMeosiSlotScenarioActNo__ActNo_Slime37 = 248,
        EJackMeosiSlotScenarioActNo__ActNo_Slime38 = 249,
        EJackMeosiSlotScenarioActNo__ActNo_Slime39 = 250,
        EJackMeosiSlotScenarioActNo__ActNo_Slime40 = 251,
        EJackMeosiSlotScenarioActNo__MAX = 252
    }


    // Enum JackGame.EJackMeosiSlotParadiseModeType
    public enum EJackMeosiSlotParadiseModeType : byte
    {
        EJackMeosiSlotParadiseModeType__Type_A = 0,
        EJackMeosiSlotParadiseModeType__Type_B = 1,
        EJackMeosiSlotParadiseModeType__Type_C = 2,
        EJackMeosiSlotParadiseModeType__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotScenarioSPTraining
    public enum EJackMeosiSlotScenarioSPTraining : byte
    {
        EJackMeosiSlotScenarioSPTraining__Training_False = 0,
        EJackMeosiSlotScenarioSPTraining__Training_True = 1,
        EJackMeosiSlotScenarioSPTraining__MAX = 2
    }


    // Enum JackGame.EJackMeosiSlotScenarioHint
    public enum EJackMeosiSlotScenarioHint : byte
    {
        EJackMeosiSlotScenarioHint__Hint_None = 0,
        EJackMeosiSlotScenarioHint__Hint_Hazure = 1,
        EJackMeosiSlotScenarioHint__Hint_Chance = 2,
        EJackMeosiSlotScenarioHint__Hint_Hot = 3,
        EJackMeosiSlotScenarioHint__Hint_Expansion = 4,
        EJackMeosiSlotScenarioHint__Hint_Training = 5,
        EJackMeosiSlotScenarioHint__Hint_Bonus = 6,
        EJackMeosiSlotScenarioHint__Hint_Stock = 7,
        EJackMeosiSlotScenarioHint__Hint_Reach = 8,
        EJackMeosiSlotScenarioHint__Hint_Reach_Chance = 9,
        EJackMeosiSlotScenarioHint__Hint_Reach_Hot = 10,
        EJackMeosiSlotScenarioHint__Hint_Reach_Stock = 11,
        EJackMeosiSlotScenarioHint__MAX = 12
    }


    // Enum JackGame.EJackMeosiSlotScenarioStage
    public enum EJackMeosiSlotScenarioStage : byte
    {
        EJackMeosiSlotScenarioStage__Stage_None = 0,
        EJackMeosiSlotScenarioStage__Stage_Daytime = 1,
        EJackMeosiSlotScenarioStage__Stage_Twilight = 2,
        EJackMeosiSlotScenarioStage__Stage_Night = 3,
        EJackMeosiSlotScenarioStage__Stage_Union = 4,
        EJackMeosiSlotScenarioStage__Stage_SP_Traning = 5,
        EJackMeosiSlotScenarioStage__Stage_BonusFixing = 6,
        EJackMeosiSlotScenarioStage__MAX = 7
    }


    // Enum JackGame.EJackMeosiSlotScenarioActType
    public enum EJackMeosiSlotScenarioActType : byte
    {
        EJackMeosiSlotScenarioActType__Act_None = 0,
        EJackMeosiSlotScenarioActType__Act_Mamono = 1,
        EJackMeosiSlotScenarioActType__Act_TBox = 2,
        EJackMeosiSlotScenarioActType__Act_Hazure = 3,
        EJackMeosiSlotScenarioActType__Act_Random = 4,
        EJackMeosiSlotScenarioActType__Act_Slime = 5,
        EJackMeosiSlotScenarioActType__Act_ChanceZone = 6,
        EJackMeosiSlotScenarioActType__Act_ChanceZone01 = 7,
        EJackMeosiSlotScenarioActType__Act_BonusGame = 8,
        EJackMeosiSlotScenarioActType__Act_BossBattle = 9,
        EJackMeosiSlotScenarioActType__Act_Shimofuri = 10,
        EJackMeosiSlotScenarioActType__Act_LongFreeze = 11,
        EJackMeosiSlotScenarioActType__MAX = 12
    }


    // Enum JackGame.EJackMeosiSlotScenarioLotteryResult
    public enum EJackMeosiSlotScenarioLotteryResult : byte
    {
        EJackMeosiSlotScenarioLotteryResult__Lottery_None = 0,
        EJackMeosiSlotScenarioLotteryResult__Lottery_Succeed = 1,
        EJackMeosiSlotScenarioLotteryResult__Lottery_ErrPat = 2,
        EJackMeosiSlotScenarioLotteryResult__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotScenarioState
    public enum EJackMeosiSlotScenarioState : byte
    {
        EJackMeosiSlotScenarioState__State_None = 0,
        EJackMeosiSlotScenarioState__State_Normal = 1,
        EJackMeosiSlotScenarioState__State_ZakoBattle = 2,
        EJackMeosiSlotScenarioState__State_SpTBox = 3,
        EJackMeosiSlotScenarioState__State_UnionChallenge = 4,
        EJackMeosiSlotScenarioState__State_SpTraining = 5,
        EJackMeosiSlotScenarioState__State_BonusFixing = 6,
        EJackMeosiSlotScenarioState__State_BossBattle = 7,
        EJackMeosiSlotScenarioState__State_Shimofuri = 8,
        EJackMeosiSlotScenarioState__State_LongFreeze = 9,
        EJackMeosiSlotScenarioState__State_Recruit = 10,
        EJackMeosiSlotScenarioState__MAX = 11
    }


    // Enum JackGame.EJackMeosiSlotHsHand
    public enum EJackMeosiSlotHsHand : byte
    {
        EJackMeosiSlotHsHand__MISS_WEAK = 0,
        EJackMeosiSlotHsHand__MISS_STRONG = 1,
        EJackMeosiSlotHsHand__REPLAY_WEAK = 2,
        EJackMeosiSlotHsHand__REPLAY_STRONG = 3,
        EJackMeosiSlotHsHand__PLUM_WEAK = 4,
        EJackMeosiSlotHsHand__PLUM_STRONG = 5,
        EJackMeosiSlotHsHand__WATERMELON_WEAK = 6,
        EJackMeosiSlotHsHand__WATERMELON_STRONG = 7,
        EJackMeosiSlotHsHand__WATERMELON_CENTER = 8,
        EJackMeosiSlotHsHand__CHERRY_WEAK = 9,
        EJackMeosiSlotHsHand__CHERRY_STRONG = 10,
        EJackMeosiSlotHsHand__CHERRY_TRIPLE = 11,
        EJackMeosiSlotHsHand__CHERRY_CENTER = 12,
        EJackMeosiSlotHsHand__BELL_WEAK = 13,
        EJackMeosiSlotHsHand__BELL_STRONG = 14,
        EJackMeosiSlotHsHand__CHANCE_CHALLEGE = 15,
        EJackMeosiSlotHsHand__CHANCE_DIRECT_WEAK = 16,
        EJackMeosiSlotHsHand__CHANCE_DIRECT_STRONG = 17,
        EJackMeosiSlotHsHand__CHANCE_WEAK = 18,
        EJackMeosiSlotHsHand__CHANCE_STRONG = 19,
        EJackMeosiSlotHsHand__CHANCE_SPOT_WEAK = 20,
        EJackMeosiSlotHsHand__CHANCE_SPOT_STRONG = 21,
        EJackMeosiSlotHsHand__REACH_WEAK = 22,
        EJackMeosiSlotHsHand__REACH_STRONG = 23,
        EJackMeosiSlotHsHand__BIG_BONUS = 24,
        EJackMeosiSlotHsHand__SPECIAL_BONUS = 25,
        EJackMeosiSlotHsHand__LONG_FREEZE = 26,
        EJackMeosiSlotHsHand__BREAK_REPLAY = 27,
        EJackMeosiSlotHsHand__BAR_WEAK = 28,
        EJackMeosiSlotHsHand__BAR_STRONG = 29,
        EJackMeosiSlotHsHand__TYPE_MAX = 30,
        EJackMeosiSlotHsHand__GAMES_PARADISE = 31,
        EJackMeosiSlotHsHand__PARADISE_MODE = 32,
        EJackMeosiSlotHsHand__EJackMeosiSlotHsHand_MAX = 33
    }


    // Enum JackGame.EJackMeosiSlotHand
    public enum EJackMeosiSlotHand : byte
    {
        EJackMeosiSlotHand__MISS = 0,
        EJackMeosiSlotHand__REPLAY = 1,
        EJackMeosiSlotHand__PLUM_WEAK = 2,
        EJackMeosiSlotHand__PLUM_STRONG = 3,
        EJackMeosiSlotHand__WATERMELON_WEAK = 4,
        EJackMeosiSlotHand__WATERMELON_STRONG = 5,
        EJackMeosiSlotHand__CHERRY_WEAK = 6,
        EJackMeosiSlotHand__CHERRY_STRONG = 7,
        EJackMeosiSlotHand__CHERRY_TRIPLE = 8,
        EJackMeosiSlotHand__CHERRY_CENTER = 9,
        EJackMeosiSlotHand__BEL = 10,
        EJackMeosiSlotHand__CHANCE_WEAK = 11,
        EJackMeosiSlotHand__CHANCE_STRONG = 12,
        EJackMeosiSlotHand__CHANCE_MOST_STRONG = 13,
        EJackMeosiSlotHand__CHANCE_SPOT_WEAK = 14,
        EJackMeosiSlotHand__CHANCE_SPOT_STRONG = 15,
        EJackMeosiSlotHand__REACH = 16,
        EJackMeosiSlotHand__BIG_BONUS = 17,
        EJackMeosiSlotHand__SPECIAL_BONUS = 18,
        EJackMeosiSlotHand__MAX = 19
    }


    // Enum JackGame.EJackMeosiSlotReelPattern
    public enum EJackMeosiSlotReelPattern : byte
    {
        EJackMeosiSlotReelPattern__Exclusion = 0,
        EJackMeosiSlotReelPattern__NoHand_W = 1,
        EJackMeosiSlotReelPattern__NoHand_S = 2,
        EJackMeosiSlotReelPattern__Chance_W = 3,
        EJackMeosiSlotReelPattern__Chance_S = 4,
        EJackMeosiSlotReelPattern__Reach_W = 5,
        EJackMeosiSlotReelPattern__Reach_S = 6,
        EJackMeosiSlotReelPattern__BreakReplay = 7,
        EJackMeosiSlotReelPattern__Replay_W = 8,
        EJackMeosiSlotReelPattern__Replay_S = 9,
        EJackMeosiSlotReelPattern__Plum_W = 10,
        EJackMeosiSlotReelPattern__Plum_S = 11,
        EJackMeosiSlotReelPattern__Wmelon_W = 12,
        EJackMeosiSlotReelPattern__Wmelon_S = 13,
        EJackMeosiSlotReelPattern__Wmelon_C = 14,
        EJackMeosiSlotReelPattern__SingleCherry = 15,
        EJackMeosiSlotReelPattern__DoubleCherry = 16,
        EJackMeosiSlotReelPattern__TripleCherry = 17,
        EJackMeosiSlotReelPattern__CenterCherry = 18,
        EJackMeosiSlotReelPattern__Bell_W = 19,
        EJackMeosiSlotReelPattern__Bell_S = 20,
        EJackMeosiSlotReelPattern__Meat_W = 21,
        EJackMeosiSlotReelPattern__Meat_S = 22,
        EJackMeosiSlotReelPattern__Bonus = 23,
        EJackMeosiSlotReelPattern__SpecialBonus = 24,
        EJackMeosiSlotReelPattern__Bar_W = 25,
        EJackMeosiSlotReelPattern__Bar_S = 26,
        EJackMeosiSlotReelPattern__Exclusion_P = 27,
        EJackMeosiSlotReelPattern__NoHand_W_P = 28,
        EJackMeosiSlotReelPattern__NoHand_S_P = 29,
        EJackMeosiSlotReelPattern__Chance_W_P = 30,
        EJackMeosiSlotReelPattern__Chance_S_P = 31,
        EJackMeosiSlotReelPattern__Reach_W_P = 32,
        EJackMeosiSlotReelPattern__Reach_S_P = 33,
        EJackMeosiSlotReelPattern__BreakReplay_P = 34,
        EJackMeosiSlotReelPattern__Replay_W_P = 35,
        EJackMeosiSlotReelPattern__Replay_S_P = 36,
        EJackMeosiSlotReelPattern__Plum_W_P = 37,
        EJackMeosiSlotReelPattern__Plum_S_P = 38,
        EJackMeosiSlotReelPattern__Wmelon_W_P = 39,
        EJackMeosiSlotReelPattern__Wmelon_S_P = 40,
        EJackMeosiSlotReelPattern__Wmelon_C_P = 41,
        EJackMeosiSlotReelPattern__SingleCherry_P = 42,
        EJackMeosiSlotReelPattern__DoubleCherry_P = 43,
        EJackMeosiSlotReelPattern__TripleCherry_P = 44,
        EJackMeosiSlotReelPattern__CenterCherry_P = 45,
        EJackMeosiSlotReelPattern__Bell_W_P = 46,
        EJackMeosiSlotReelPattern__Bell_S_P = 47,
        EJackMeosiSlotReelPattern__Meat_W_P = 48,
        EJackMeosiSlotReelPattern__Meat_S_P = 49,
        EJackMeosiSlotReelPattern__Bonus_P = 50,
        EJackMeosiSlotReelPattern__SpecialBonus_P = 51,
        EJackMeosiSlotReelPattern__Bar_W_P = 52,
        EJackMeosiSlotReelPattern__Bar_S_P = 53,
        EJackMeosiSlotReelPattern__Exclusion_TP = 54,
        EJackMeosiSlotReelPattern__NoHand_W_TP = 55,
        EJackMeosiSlotReelPattern__NoHand_S_TP = 56,
        EJackMeosiSlotReelPattern__Chance_W_TP = 57,
        EJackMeosiSlotReelPattern__Chance_S_TP = 58,
        EJackMeosiSlotReelPattern__Reach_W_TP = 59,
        EJackMeosiSlotReelPattern__Reach_S_TP = 60,
        EJackMeosiSlotReelPattern__BreakReplay_TP = 61,
        EJackMeosiSlotReelPattern__Replay_W_TP = 62,
        EJackMeosiSlotReelPattern__Replay_S_TP = 63,
        EJackMeosiSlotReelPattern__Plum_W_TP = 64,
        EJackMeosiSlotReelPattern__Plum_S_TP = 65,
        EJackMeosiSlotReelPattern__Wmelon_W_TP = 66,
        EJackMeosiSlotReelPattern__Wmelon_S_TP = 67,
        EJackMeosiSlotReelPattern__Wmelon_C_TP = 68,
        EJackMeosiSlotReelPattern__SingleCherry_TP = 69,
        EJackMeosiSlotReelPattern__DoubleCherry_TP = 70,
        EJackMeosiSlotReelPattern__TripleCherry_TP = 71,
        EJackMeosiSlotReelPattern__CenterCherry_TP = 72,
        EJackMeosiSlotReelPattern__Bell_W_TP = 73,
        EJackMeosiSlotReelPattern__Bell_S_TP = 74,
        EJackMeosiSlotReelPattern__Meat_W_TP = 75,
        EJackMeosiSlotReelPattern__Meat_S_TP = 76,
        EJackMeosiSlotReelPattern__Bonus_TP = 77,
        EJackMeosiSlotReelPattern__SpecialBonus_TP = 78,
        EJackMeosiSlotReelPattern__Bar_W_TP = 79,
        EJackMeosiSlotReelPattern__Bar_S_TP = 80,
        EJackMeosiSlotReelPattern__MAX = 81
    }


    // Enum JackGame.EJackMeosiSlotReelBrightness
    public enum EJackMeosiSlotReelBrightness : byte
    {
        EJackMeosiSlotReelBrightness__Dark = 0,
        EJackMeosiSlotReelBrightness__Dim = 1,
        EJackMeosiSlotReelBrightness__Mid = 2,
        EJackMeosiSlotReelBrightness__Lightlight = 3,
        EJackMeosiSlotReelBrightness__Bright = 4,
        EJackMeosiSlotReelBrightness__MAX = 5
    }


    // Enum JackGame.EJackMeosiSlotReelLamp
    public enum EJackMeosiSlotReelLamp : byte
    {
        EJackMeosiSlotReelLamp__Neutral = 0,
        EJackMeosiSlotReelLamp__Normal = 1,
        EJackMeosiSlotReelLamp__LongFreeze = 2,
        EJackMeosiSlotReelLamp__Bell = 3,
        EJackMeosiSlotReelLamp__Shimofuri = 4,
        EJackMeosiSlotReelLamp__Putoff = 5,
        EJackMeosiSlotReelLamp__Puton = 6,
        EJackMeosiSlotReelLamp__BreakReplay = 7,
        EJackMeosiSlotReelLamp__MAX = 8
    }


    // Enum JackGame.EJackMeosiSlotPicture
    public enum EJackMeosiSlotPicture : byte
    {
        EJackMeosiSlotPicture__BEL = 0,
        EJackMeosiSlotPicture__REPLAY = 1,
        EJackMeosiSlotPicture__BAR = 2,
        EJackMeosiSlotPicture__CHERRRY = 3,
        EJackMeosiSlotPicture__WATERMELON = 4,
        EJackMeosiSlotPicture__PLUM = 5,
        EJackMeosiSlotPicture__BLANK = 6,
        EJackMeosiSlotPicture__CHANCE = 7,
        EJackMeosiSlotPicture__SEVEN = 8,
        EJackMeosiSlotPicture__MAX = 9
    }


    // Enum JackGame.EJackMeosiSlotReelStopTimes
    public enum EJackMeosiSlotReelStopTimes : byte
    {
        EJackMeosiSlotReelStopTimes__FIRST = 0,
        EJackMeosiSlotReelStopTimes__SECOND = 1,
        EJackMeosiSlotReelStopTimes__THIRD = 2,
        EJackMeosiSlotReelStopTimes__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotInternalProbabilityStatus
    public enum EJackMeosiSlotInternalProbabilityStatus : byte
    {
        EJackMeosiSlotInternalProbabilityStatus__DEFAULT = 0,
        EJackMeosiSlotInternalProbabilityStatus__HIGH = 1,
        EJackMeosiSlotInternalProbabilityStatus__HEAVEN = 2,
        EJackMeosiSlotInternalProbabilityStatus__MAX = 3
    }


    // Enum JackGame.EJackMeosiSlotStageMode
    public enum EJackMeosiSlotStageMode : byte
    {
        EJackMeosiSlotStageMode__NORMAL = 0,
        EJackMeosiSlotStageMode__CHANCE_ZONE = 1,
        EJackMeosiSlotStageMode__CHANCE_ZONE01 = 2,
        EJackMeosiSlotStageMode__BONUS_FIXING = 3,
        EJackMeosiSlotStageMode__BONUS_GAME = 4,
        EJackMeosiSlotStageMode__SP_BONUS_GAME = 5,
        EJackMeosiSlotStageMode__BOSS_BATTLE = 6,
        EJackMeosiSlotStageMode__BONUS_CONTINUE = 7,
        EJackMeosiSlotStageMode__MAX = 8
    }


    // Enum JackGame.EJackMeosiSlotStageState
    public enum EJackMeosiSlotStageState : byte
    {
        EJackMeosiSlotStageState__NORMAL_NORMAL = 0,
        EJackMeosiSlotStageState__NORMAL_BONUS = 1,
        EJackMeosiSlotStageState__NORMAL_BONUS_SUCCESS = 2,
        EJackMeosiSlotStageState__NORMAL_BONUS_DIRECT = 3,
        EJackMeosiSlotStageState__CHANCE_ZONE_NORMAL = 4,
        EJackMeosiSlotStageState__CHANCE_ZONE_INTRODUCTION = 5,
        EJackMeosiSlotStageState__CHANCE_ZONE_BATTLE = 6,
        EJackMeosiSlotStageState__CHANCE_ZONE_COMEBACK = 7,
        EJackMeosiSlotStageState__CHANCE_ZONE_WIN = 8,
        EJackMeosiSlotStageState__NORMAL_BATTLE_RESULT = 9,
        EJackMeosiSlotStageState__NORMAL_RESULT_COMEBACK = 10,
        EJackMeosiSlotStageState__STATE_INVALID = 11,
        EJackMeosiSlotStageState__MAX = 12
    }


    // Enum JackGame.EJackMeosiSlotStage
    public enum EJackMeosiSlotStage : byte
    {
        EJackMeosiSlotStage__DEFAULT = 0,
        EJackMeosiSlotStage__CHANCE_ZONE = 1,
        EJackMeosiSlotStage__CHANCE_ZONE01 = 2,
        EJackMeosiSlotStage__SPECIAL_TRAINING = 3,
        EJackMeosiSlotStage__MAX = 4
    }


    // Enum JackGame.EJackMeosiSlotSettingValue
    public enum EJackMeosiSlotSettingValue : byte
    {
        EJackMeosiSlotSettingValue__ONE = 0,
        EJackMeosiSlotSettingValue__TWO = 1,
        EJackMeosiSlotSettingValue__THREE = 2,
        EJackMeosiSlotSettingValue__FOUR = 3,
        EJackMeosiSlotSettingValue__FIVE = 4,
        EJackMeosiSlotSettingValue__SIX = 5,
        EJackMeosiSlotSettingValue__SEVEN = 6,
        EJackMeosiSlotSettingValue__MAX = 7
    }


    // Enum JackGame.EJackMeosiSlotReel
    public enum EJackMeosiSlotReel : byte
    {
        EJackMeosiSlotReel__LEFT = 0,
        EJackMeosiSlotReel__CENTER = 1,
        EJackMeosiSlotReel__RIGHT = 2,
        EJackMeosiSlotReel__MAX = 3
    }


    // Enum JackGame.EJackMiniGameDebugValueRange
    public enum EJackMiniGameDebugValueRange : byte
    {
        EJackMiniGameDebugValueRange__None = 0,
        EJackMiniGameDebugValueRange__Lower = 1,
        EJackMiniGameDebugValueRange__Upper = 2,
        EJackMiniGameDebugValueRange__Max = 3
    }


    // Enum JackGame.EJackMiniGameJackPotNPCState
    public enum EJackMiniGameJackPotNPCState : byte
    {
        EJackMiniGameJackPotNPCState__Initialize = 0,
        EJackMiniGameJackPotNPCState__JackPotLottey = 1,
        EJackMiniGameJackPotNPCState__JackPotNoLottey = 2,
        EJackMiniGameJackPotNPCState__Max = 3
    }


    // Enum JackGame.EJackMiniGameJackPotMachine
    public enum EJackMiniGameJackPotMachine : byte
    {
        EJackMiniGameJackPotMachine__Roulette = 0,
        EJackMiniGameJackPotMachine__Slot = 1,
        EJackMiniGameJackPotMachine__Max = 2
    }


    // Enum JackGame.EJackMiniGameJackPotState
    public enum EJackMiniGameJackPotState : byte
    {
        EJackMiniGameJackPotState__Normal = 0,
        EJackMiniGameJackPotState__EasyHit = 1,
        EJackMiniGameJackPotState__VeryEasyHit = 2,
        EJackMiniGameJackPotState__Max = 3
    }


    // Enum JackGame.EJackMiniGameKind
    public enum EJackMiniGameKind : byte
    {
        EJackMiniGameKind__None = 0,
        EJackMiniGameKind__Slot = 1,
        EJackMiniGameKind__Roulette = 2,
        EJackMiniGameKind__Poker = 3,
        EJackMiniGameKind__MeosiSlot = 4,
        EJackMiniGameKind__Max = 5
    }


    // Enum JackGame.EJackMiniGameJackPotLevel
    public enum EJackMiniGameJackPotLevel : byte
    {
        EJackMiniGameJackPotLevel__Level1 = 0,
        EJackMiniGameJackPotLevel__Level2 = 1,
        EJackMiniGameJackPotLevel__Level3 = 2,
        EJackMiniGameJackPotLevel__Level4 = 3,
        EJackMiniGameJackPotLevel__Level5 = 4,
        EJackMiniGameJackPotLevel__Max = 5
    }


    // Enum JackGame.EJackMiniGameJackPot
    public enum EJackMiniGameJackPot : byte
    {
        EJackMiniGameJackPot__Grotta = 0,
        EJackMiniGameJackPot__Soltico = 1,
        EJackMiniGameJackPot__Max = 2
    }


    // Enum JackGame.EJackMiniGameMeosiSlotPoint
    public enum EJackMiniGameMeosiSlotPoint : byte
    {
        EJackMiniGameMeosiSlotPoint__Grotta = 0,
        EJackMiniGameMeosiSlotPoint__Grotta_Second = 1,
        EJackMiniGameMeosiSlotPoint__Soltico = 2,
        EJackMiniGameMeosiSlotPoint__Max = 3
    }


    // Enum JackGame.EJackMiniGamePoker
    public enum EJackMiniGamePoker : byte
    {
        EJackMiniGamePoker__POKER_GAME_RESULT_NONE = 0,
        EJackMiniGamePoker__POKER_GAME_RESULT_HIGH_CARD = 1,
        EJackMiniGamePoker__POKER_GAME_RESULT_ONE_PAIR = 2,
        EJackMiniGamePoker__POKER_GAME_RESULT_TWO_PAIR = 3,
        EJackMiniGamePoker__POKER_GAME_RESULT_THREE_CARD = 4,
        EJackMiniGamePoker__POKER_GAME_RESULT_STRAIGHT = 5,
        EJackMiniGamePoker__POKER_GAME_RESULT_FLUSH = 6,
        EJackMiniGamePoker__POKER_GAME_RESULT_FULL_HOUSE = 7,
        EJackMiniGamePoker__POKER_GAME_RESULT_FOUR_CARD = 8,
        EJackMiniGamePoker__POKER_GAME_RESULT_STRAIGHT_FLUSH = 9,
        EJackMiniGamePoker__POKER_GAME_RESULT_FIVE_CARD = 10,
        EJackMiniGamePoker__POKER_GAME_RESULT_ROYAL_FLUSH = 11,
        EJackMiniGamePoker__POKER_GAME_RESULT_ROYAL_FLUSH_SPADE = 12,
        EJackMiniGamePoker__POKER_GAME_RESULT_DOUBLEUP_LOSE = 13,
        EJackMiniGamePoker__POKER_GAME_RESULT_DOUBLEUP_EVEN = 14,
        EJackMiniGamePoker__POKER_GAME_RESULT_DOUBLEUP_WIN = 15,
        EJackMiniGamePoker__POKER_GAME_RESULT_DOUBLEUP_TREASURECARD = 16,
        EJackMiniGamePoker__POKER_GAME_RESULT_UNABLE_BET = 17,
        EJackMiniGamePoker__POKER_GAME_RESULT_ENUM_MAX = 18,
        EJackMiniGamePoker__POKER_GAME_RESULT_FORCE_FOUR = 19,
        EJackMiniGamePoker__POKER_GAME_RESULT_MAX = 20
    }


    // Enum JackGame.EJackPokerSign
    public enum EJackPokerSign : byte
    {
        EJackPokerSign__POSITIVE = 0,
        EJackPokerSign__NEGATIVE = 1,
        EJackPokerSign__MAX = 2
    }


    // Enum JackGame.EJackPokerTreasureBox
    public enum EJackPokerTreasureBox : byte
    {
        EJackPokerTreasureBox__NONE = 0,
        EJackPokerTreasureBox__RED = 1,
        EJackPokerTreasureBox__BLACK = 2,
        EJackPokerTreasureBox__GOLD = 3,
        EJackPokerTreasureBox__MAX = 4
    }


    // Enum JackGame.EJackPokerCardNumber
    public enum EJackPokerCardNumber : byte
    {
        EJackPokerCardNumber__TWO = 0,
        EJackPokerCardNumber__THREE = 1,
        EJackPokerCardNumber__FOUR = 2,
        EJackPokerCardNumber__FIVE = 3,
        EJackPokerCardNumber__SIX = 4,
        EJackPokerCardNumber__SEVEN = 5,
        EJackPokerCardNumber__EIGHT = 6,
        EJackPokerCardNumber__NINE = 7,
        EJackPokerCardNumber__TEN = 8,
        EJackPokerCardNumber__JACK = 9,
        EJackPokerCardNumber__QUEEN = 10,
        EJackPokerCardNumber__KING = 11,
        EJackPokerCardNumber__ACE = 12,
        EJackPokerCardNumber__JOKER = 13,
        EJackPokerCardNumber__MAX = 14
    }


    // Enum JackGame.EJackPokerHand
    public enum EJackPokerHand : byte
    {
        EJackPokerHand__ROYAL_STRAIGHT_FLUSH_SPADE = 0,
        EJackPokerHand__ROYAL_STRAIGHT_FLUSH = 1,
        EJackPokerHand__FIVE_CARD = 2,
        EJackPokerHand__STRAIGHT_FLUSH = 3,
        EJackPokerHand__FOUR_CARD = 4,
        EJackPokerHand__FULL_HOUSE = 5,
        EJackPokerHand__FLUSH = 6,
        EJackPokerHand__STRAIGHT = 7,
        EJackPokerHand__THREE_CARD = 8,
        EJackPokerHand__TWO_PAIR = 9,
        EJackPokerHand__NONE = 10,
        EJackPokerHand__MAX = 11
    }


    // Enum JackGame.EJackPokerBetUnit
    public enum EJackPokerBetUnit : byte
    {
        EJackPokerBetUnit__ONE = 0,
        EJackPokerBetUnit__TEN = 1,
        EJackPokerBetUnit__HUNDRED = 2,
        EJackPokerBetUnit__MAX = 3
    }


    // Enum JackGame.EJackPokerWidgetID
    public enum EJackPokerWidgetID : byte
    {
        EJackPokerWidgetID__PokerResultBase = 0,
        EJackPokerWidgetID__PokerResult = 1,
        EJackPokerWidgetID__MAX = 2
    }


    // Enum JackGame.EJackMiniGameRouletteGameState
    public enum EJackMiniGameRouletteGameState : byte
    {
        EJackMiniGameRouletteGameState__Init = 0,
        EJackMiniGameRouletteGameState__Game = 1,
        EJackMiniGameRouletteGameState__EndDemo = 2,
        EJackMiniGameRouletteGameState__JackPotDemo = 3,
        EJackMiniGameRouletteGameState__Finished = 4,
        EJackMiniGameRouletteGameState__End = 5,
        EJackMiniGameRouletteGameState__MAX = 6
    }


    // Enum JackGame.EJackMiniGameTask
    public enum EJackMiniGameTask : byte
    {
        EJackMiniGameTask__Init = 0,
        EJackMiniGameTask__Wait = 1,
        EJackMiniGameTask__StartWait = 2,
        EJackMiniGameTask__Begin = 3,
        EJackMiniGameTask__Update = 4,
        EJackMiniGameTask__End = 5,
        EJackMiniGameTask__MAX = 6
    }


    // Enum JackGame.EJackModeType
    public enum EJackModeType : byte
    {
        EJackModeType__Mode2D = 0,
        EJackModeType__Mode3D = 1,
        EJackModeType__MAX = 2
    }


    // Enum JackGame.EJackMonsterMovingPathMethod
    public enum EJackMonsterMovingPathMethod : byte
    {
        EJackMonsterMovingPathMethod__Default = 0,
        EJackMonsterMovingPathMethod__CourseCurve = 1,
        EJackMonsterMovingPathMethod__SplinePath = 2,
        EJackMonsterMovingPathMethod__MAX = 3
    }


    // Enum JackGame.EJackMonsterMovingMode
    public enum EJackMonsterMovingMode : byte
    {
        EJackMonsterMovingMode__Default = 0,
        EJackMonsterMovingMode__Run = 1,
        EJackMonsterMovingMode__BackWalk = 2,
        EJackMonsterMovingMode__FieldRun = 3,
        EJackMonsterMovingMode__MAX = 4
    }


    // Enum JackGame.EJackDebugCommandForMonster
    public enum EJackDebugCommandForMonster : byte
    {
        EJackDebugCommandForMonster__Encount = 0,
        EJackDebugCommandForMonster__Attack = 1,
        EJackDebugCommandForMonster__Appeal = 2,
        EJackDebugCommandForMonster__Avoid = 3,
        EJackDebugCommandForMonster__Damage = 4,
        EJackDebugCommandForMonster__Sleep = 5,
        EJackDebugCommandForMonster__Paralysis = 6,
        EJackDebugCommandForMonster__Korobi = 7,
        EJackDebugCommandForMonster__Laugh = 8,
        EJackDebugCommandForMonster__MontagePlay = 9,
        EJackDebugCommandForMonster__Dead = 10,
        EJackDebugCommandForMonster__RecoverToIdle = 11,
        EJackDebugCommandForMonster__LieInWait = 12,
        EJackDebugCommandForMonster__Raid = 13,
        EJackDebugCommandForMonster__Advent = 14,
        EJackDebugCommandForMonster__Retreat = 15,
        EJackDebugCommandForMonster__Rove = 16,
        EJackDebugCommandForMonster__Deactive = 17,
        EJackDebugCommandForMonster__SpecialMove = 18,
        EJackDebugCommandForMonster__ToIdle = 19,
        EJackDebugCommandForMonster__MAX = 20
    }


    // Enum JackGame.EJackMonsterAttitudeControlSetting
    public enum EJackMonsterAttitudeControlSetting : byte
    {
        EJackMonsterAttitudeControlSetting__Always = 0,
        EJackMonsterAttitudeControlSetting__FieldOnly = 1,
        EJackMonsterAttitudeControlSetting__BattleOnly = 2,
        EJackMonsterAttitudeControlSetting__MAX = 3
    }


    // Enum JackGame.EJackPopDistanceEvaluation
    public enum EJackPopDistanceEvaluation : byte
    {
        EJackPopDistanceEvaluation__None = 0,
        EJackPopDistanceEvaluation__Pop = 1,
        EJackPopDistanceEvaluation__Active = 2,
        EJackPopDistanceEvaluation__Visible = 3,
        EJackPopDistanceEvaluation__EJackPopDistanceEvaluation_MAX = 4
    }


    // Enum JackGame.EJackMusicBGMVolumeType
    public enum EJackMusicBGMVolumeType : byte
    {
        EJackMusicBGMVolumeType__JP3DGoldVolume = 0,
        EJackMusicBGMVolumeType__JP3DOrcheVolume = 1,
        EJackMusicBGMVolumeType__NE3DGoldVolume = 2,
        EJackMusicBGMVolumeType__NE3DOrcheVolume = 3,
        EJackMusicBGMVolumeType__EJackMusicBGMVolumeType_MAX = 4
    }


    // Enum JackGame.EJackMusicContextState
    public enum EJackMusicContextState : byte
    {
        EJackMusicContextState__Initial = 0,
        EJackMusicContextState__LoadingAsset = 1,
        EJackMusicContextState__ReadyToStart = 2,
        EJackMusicContextState__Pregap = 3,
        EJackMusicContextState__Playing = 4,
        EJackMusicContextState__StopFadeOut = 5,
        EJackMusicContextState__Postgap = 6,
        EJackMusicContextState__Stopped = 7,
        EJackMusicContextState__EJackMusicContextState_MAX = 8
    }


    // Enum JackGame.EJackOddEffectFacialFlag
    public enum EJackOddEffectFacialFlag : byte
    {
        EJackOddEffectFacialFlag__InvalidLookAt = 0,
        EJackOddEffectFacialFlag__MAX = 1
    }


    // Enum JackGame.EJackOddEffectMotionFlag
    public enum EJackOddEffectMotionFlag : byte
    {
        EJackOddEffectMotionFlag__InvalidWeaponDisplay = 0,
        EJackOddEffectMotionFlag__InvalidLookAt = 1,
        EJackOddEffectMotionFlag__InvalidOddEffectFacial = 2,
        EJackOddEffectMotionFlag__EndSectionSkipEnable = 3,
        EJackOddEffectMotionFlag__MAX = 4
    }


    // Enum JackGame.EJackOddEffectConditionType
    public enum EJackOddEffectConditionType : byte
    {
        EJackOddEffectConditionType__None = 0,
        EJackOddEffectConditionType__Good = 1,
        EJackOddEffectConditionType__Bad = 2,
        EJackOddEffectConditionType__MAX = 3
    }


    // Enum JackGame.EJackOddEffectVoiceCategory
    public enum EJackOddEffectVoiceCategory : byte
    {
        EJackOddEffectVoiceCategory__None = 0,
        EJackOddEffectVoiceCategory__Set = 1,
        EJackOddEffectVoiceCategory__Clear = 2,
        EJackOddEffectVoiceCategory__MAX = 3
    }


    // Enum JackGame.EJackOddEffectEffectCategory
    public enum EJackOddEffectEffectCategory : byte
    {
        EJackOddEffectEffectCategory__None = 0,
        EJackOddEffectEffectCategory__Set = 1,
        EJackOddEffectEffectCategory__Invoke = 2,
        EJackOddEffectEffectCategory__Clear = 3,
        EJackOddEffectEffectCategory__MAX = 4
    }


    // Enum JackGame.EJackOddEffectTextType
    public enum EJackOddEffectTextType : byte
    {
        EJackOddEffectTextType__None = 0,
        EJackOddEffectTextType__OddEffectName = 1,
        EJackOddEffectTextType__OddEffectSetumei = 2,
        EJackOddEffectTextType__SetSuccess = 3,
        EJackOddEffectTextType__SetFail = 4,
        EJackOddEffectTextType__SetFail_Overlap = 5,
        EJackOddEffectTextType__Clear = 6,
        EJackOddEffectTextType__Invoke = 7,
        EJackOddEffectTextType__MAX = 8
    }


    // Enum JackGame.EJackOddEffectApply
    public enum EJackOddEffectApply : byte
    {
        EJackOddEffectApply__None = 0,
        EJackOddEffectApply__ParamAdd = 1,
        EJackOddEffectApply__ParamSet = 2,
        EJackOddEffectApply__ParamSetPer = 3,
        EJackOddEffectApply__Dot = 4,
        EJackOddEffectApply__MAX = 5
    }


    // Enum JackGame.EJackOddEffectInvokeTiming
    public enum EJackOddEffectInvokeTiming : byte
    {
        EJackOddEffectInvokeTiming__None = 0,
        EJackOddEffectInvokeTiming__BattleStart = 1,
        EJackOddEffectInvokeTiming__Kougeki = 2,
        EJackOddEffectInvokeTiming__KougekiMetal = 3,
        EJackOddEffectInvokeTiming__KougekiHikou = 4,
        EJackOddEffectInvokeTiming__Damage = 5,
        EJackOddEffectInvokeTiming__MAX = 6
    }


    // Enum JackGame.EJackOddEffectSlideRank
    public enum EJackOddEffectSlideRank : byte
    {
        EJackOddEffectSlideRank__Minus2 = 0,
        EJackOddEffectSlideRank__Minus1 = 1,
        EJackOddEffectSlideRank__Zero = 2,
        EJackOddEffectSlideRank__Plus1 = 3,
        EJackOddEffectSlideRank__Plus2 = 4,
        EJackOddEffectSlideRank__MAX = 5
    }


    // Enum JackGame.EJackOddEffectOverwriteResultType
    public enum EJackOddEffectOverwriteResultType : byte
    {
        EJackOddEffectOverwriteResultType__None = 0,
        EJackOddEffectOverwriteResultType__Invalid = 1,
        EJackOddEffectOverwriteResultType__New = 2,
        EJackOddEffectOverwriteResultType__Overwrite = 3,
        EJackOddEffectOverwriteResultType__DepthUp = 4,
        EJackOddEffectOverwriteResultType__DepthUpInvalid = 5,
        EJackOddEffectOverwriteResultType__Limit = 6,
        EJackOddEffectOverwriteResultType__MAX = 7
    }


    // Enum JackGame.EJackOddEffectCalcParameterType
    public enum EJackOddEffectCalcParameterType : byte
    {
        EJackOddEffectCalcParameterType__InvokeParameter_01 = 0,
        EJackOddEffectCalcParameterType__InvokeParameter_02 = 1,
        EJackOddEffectCalcParameterType__ReferenceParam = 2,
        EJackOddEffectCalcParameterType__MAX = 3
    }


    // Enum JackGame.EJackOddEffectCalcType
    public enum EJackOddEffectCalcType : byte
    {
        EJackOddEffectCalcType__None = 0,
        EJackOddEffectCalcType__Add = 1,
        EJackOddEffectCalcType__Overwrite = 2,
        EJackOddEffectCalcType__ForceOverwrite = 3,
        EJackOddEffectCalcType__Slide = 4,
        EJackOddEffectCalcType__MAX = 5
    }


    // Enum JackGame.EJackOddEffectOverwriteType
    public enum EJackOddEffectOverwriteType : byte
    {
        EJackOddEffectOverwriteType__None = 0,
        EJackOddEffectOverwriteType__NotOverwrite = 1,
        EJackOddEffectOverwriteType__Overwrite = 2,
        EJackOddEffectOverwriteType__ForceOverwrite = 3,
        EJackOddEffectOverwriteType__Depth = 4,
        EJackOddEffectOverwriteType__MAX = 5
    }


    // Enum JackGame.EJackOddEffectClearReasonType
    public enum EJackOddEffectClearReasonType : byte
    {
        EJackOddEffectClearReasonType__None = 0,
        EJackOddEffectClearReasonType__SetOddEffect = 1,
        EJackOddEffectClearReasonType__BattleEnd = 2,
        EJackOddEffectClearReasonType__MAX = 3
    }


    // Enum JackGame.EJackOddEffectReasonType
    public enum EJackOddEffectReasonType : byte
    {
        EJackOddEffectReasonType__None = 0,
        EJackOddEffectReasonType__Debug = 1,
        EJackOddEffectReasonType__Action = 2,
        EJackOddEffectReasonType__ActionTemp = 3,
        EJackOddEffectReasonType__BattleStart = 4,
        EJackOddEffectReasonType__BattleSystem = 5,
        EJackOddEffectReasonType__WeaponR = 6,
        EJackOddEffectReasonType__WeaponL = 7,
        EJackOddEffectReasonType__Equipment = 8,
        EJackOddEffectReasonType__Blueprint = 9,
        EJackOddEffectReasonType__Share = 10,
        EJackOddEffectReasonType__Slide = 11,
        EJackOddEffectReasonType__Damage = 12,
        EJackOddEffectReasonType__Passive = 13,
        EJackOddEffectReasonType__PassiveTokugi = 14,
        EJackOddEffectReasonType__MAX = 15
    }


    // Enum JackGame.EJackOddEffectCategoryType
    public enum EJackOddEffectCategoryType : byte
    {
        EJackOddEffectCategoryType__None = 0,
        EJackOddEffectCategoryType__Sibou = 1,
        EJackOddEffectCategoryType__Nemuri = 2,
        EJackOddEffectCategoryType__Genwaku = 3,
        EJackOddEffectCategoryType__Mahi = 4,
        EJackOddEffectCategoryType__Doku = 5,
        EJackOddEffectCategoryType__Konran = 6,
        EJackOddEffectCategoryType__Miryou = 7,
        EJackOddEffectCategoryType__Noroi = 8,
        EJackOddEffectCategoryType__Fuuin = 9,
        EJackOddEffectCategoryType__Yasumi = 10,
        EJackOddEffectCategoryType__HazukasiiNoroi = 11,
        EJackOddEffectCategoryType__KougekiryokuHenka = 12,
        EJackOddEffectCategoryType__SyubiryokuHenka = 13,
        EJackOddEffectCategoryType__SubayasaHenka = 14,
        EJackOddEffectCategoryType__KiyousaHenka = 15,
        EJackOddEffectCategoryType__KougekiJumonHenka = 16,
        EJackOddEffectCategoryType__KaifukuJumonHenka = 17,
        EJackOddEffectCategoryType__JumonTaiseiHenka = 18,
        EJackOddEffectCategoryType__TateGuardHasseiHenka = 19,
        EJackOddEffectCategoryType__BukiGuardHasseiHenka = 20,
        EJackOddEffectCategoryType__MikawasiHenka = 21,
        EJackOddEffectCategoryType__MitoresaseHenka = 22,
        EJackOddEffectCategoryType__BreathHenka = 23,
        EJackOddEffectCategoryType__KaisinHenka = 24,
        EJackOddEffectCategoryType__BousouHenka = 25,
        EJackOddEffectCategoryType__OddEffectTaiseiHenka = 26,
        EJackOddEffectCategoryType__HonooTaiseiHenka = 27,
        EJackOddEffectCategoryType__KooriTaiseiHenka = 28,
        EJackOddEffectCategoryType__KazeTaiseiHenka = 29,
        EJackOddEffectCategoryType__KaminariTaiseiHenka = 30,
        EJackOddEffectCategoryType__TutiTaiseiHenka = 31,
        EJackOddEffectCategoryType__YamiTaiseiHenka = 32,
        EJackOddEffectCategoryType__HikariTaiseiHenka = 33,
        EJackOddEffectCategoryType__KyuusyuuTaiseiHenka = 34,
        EJackOddEffectCategoryType__ElementalTaiseiHenka = 35,
        EJackOddEffectCategoryType__Zone = 36,
        EJackOddEffectCategoryType__OddEffectMukou = 37,
        EJackOddEffectCategoryType__IkinokoriSeijo = 38,
        EJackOddEffectCategoryType__IkinokoriMegami = 39,
        EJackOddEffectCategoryType__AutoZaoriku = 40,
        EJackOddEffectCategoryType__AutoZaorikuBunny = 41,
        EJackOddEffectCategoryType__AutoHPKaifuku = 42,
        EJackOddEffectCategoryType__AutoMPKaifuku = 43,
        EJackOddEffectCategoryType__Senritu = 44,
        EJackOddEffectCategoryType__JumonHansya = 45,
        EJackOddEffectCategoryType__JumonMukou = 46,
        EJackOddEffectCategoryType__Asutoron = 47,
        EJackOddEffectCategoryType__DamageKanzenGuard = 48,
        EJackOddEffectCategoryType__ButuriKanzenGuard = 49,
        EJackOddEffectCategoryType__KaisinKanzenGuard = 50,
        EJackOddEffectCategoryType__DamageKeigen = 51,
        EJackOddEffectCategoryType__KougekiHPKaifuku = 52,
        EJackOddEffectCategoryType__KougekiMPKaifuku = 53,
        EJackOddEffectCategoryType__KougekiMPKyuusyuu = 54,
        EJackOddEffectCategoryType__RaceTokkouMPKyuusyuu = 55,
        EJackOddEffectCategoryType__MPSyouhiZero = 56,
        EJackOddEffectCategoryType__MPSyouhiZouka = 57,
        EJackOddEffectCategoryType__Counter = 58,
        EJackOddEffectCategoryType__GuardCounter = 59,
        EJackOddEffectCategoryType__ImmediatelyCounter = 60,
        EJackOddEffectCategoryType__Nioudati = 61,
        EJackOddEffectCategoryType__Kabau = 62,
        EJackOddEffectCategoryType__Kabawareru = 63,
        EJackOddEffectCategoryType__KabauCounter = 64,
        EJackOddEffectCategoryType__Ukenagasi = 65,
        EJackOddEffectCategoryType__AcrobatStar = 66,
        EJackOddEffectCategoryType__CharaKyoukaRenkei = 67,
        EJackOddEffectCategoryType__GenteiTokugi = 68,
        EJackOddEffectCategoryType__AttackJousyou = 69,
        EJackOddEffectCategoryType__Fuzai = 70,
        EJackOddEffectCategoryType__KaifukuKoukaGyakuten = 71,
        EJackOddEffectCategoryType__Zibaria = 72,
        EJackOddEffectCategoryType__ActionLearn = 73,
        EJackOddEffectCategoryType__Yamabiko = 74,
        EJackOddEffectCategoryType__NusumuUp = 75,
        EJackOddEffectCategoryType__JoutaihenkaUp = 76,
        EJackOddEffectCategoryType__DokuTaiseiHenka = 77,
        EJackOddEffectCategoryType__NemuriTaiseiHenka = 78,
        EJackOddEffectCategoryType__KonranTaiseiHenka = 79,
        EJackOddEffectCategoryType__MahiTaiseiHenka = 80,
        EJackOddEffectCategoryType__SokusiTaiseiHenka = 81,
        EJackOddEffectCategoryType__MiryouTaiseiHenka = 82,
        EJackOddEffectCategoryType__GenwakuTaiseiHenka = 83,
        EJackOddEffectCategoryType__NoroiTaiseiHenka = 84,
        EJackOddEffectCategoryType__MitoreruTaiseiHenka = 85,
        EJackOddEffectCategoryType__FuuinJumonTaiseiHenka = 86,
        EJackOddEffectCategoryType__FuuinTokugiTaiseiHenka = 87,
        EJackOddEffectCategoryType__YasumiObieTaiseiHenka = 88,
        EJackOddEffectCategoryType__YasumiKorobiTaiseiHenka = 89,
        EJackOddEffectCategoryType__YasumiPafupafuTaiseiHenka = 90,
        EJackOddEffectCategoryType__YasumiWaraiTaiseiHenka = 91,
        EJackOddEffectCategoryType__YasumiOdoriTaiseiHenka = 92,
        EJackOddEffectCategoryType__KougekiryokuDownTaiseiHenka = 93,
        EJackOddEffectCategoryType__SyubiryokuDownTaiseiHenka = 94,
        EJackOddEffectCategoryType__SubayasaDownTaiseiHenka = 95,
        EJackOddEffectCategoryType__KougekiJumonDownTaiseiHenka = 96,
        EJackOddEffectCategoryType__KaifukuJumonDownTaiseiHenka = 97,
        EJackOddEffectCategoryType__JumonSyubiDownTaiseiHenka = 98,
        EJackOddEffectCategoryType__ZokuseiDownTaiseiHenka = 99,
        EJackOddEffectCategoryType__TaiseiDownTaiseiHenka = 100,
        EJackOddEffectCategoryType__BadTaiseiHenka = 101,
        EJackOddEffectCategoryType__PreemptiveAttackUp = 102,
        EJackOddEffectCategoryType__HateHenka = 103,
        EJackOddEffectCategoryType__DropUp = 104,
        EJackOddEffectCategoryType__GoldUp = 105,
        EJackOddEffectCategoryType__ExpUp = 106,
        EJackOddEffectCategoryType__DropConfirm = 107,
        EJackOddEffectCategoryType__TuikaDamage = 108,
        EJackOddEffectCategoryType__FixCritical = 109,
        EJackOddEffectCategoryType__Bougyo = 110,
        EJackOddEffectCategoryType__Bunsin = 111,
        EJackOddEffectCategoryType__BiriBiriBarrier = 112,
        EJackOddEffectCategoryType__MAX = 113
    }


    // Enum JackGame.EJackClosePairingType
    public enum EJackClosePairingType : byte
    {
        EJackClosePairingType__RemoveUserType = 0,
        EJackClosePairingType__RemoveControllerType = 1,
        EJackClosePairingType__MAX = 2
    }


    // Enum JackGame.EJackPairingPhase
    public enum EJackPairingPhase : byte
    {
        EJackPairingPhase__None = 0,
        EJackPairingPhase__WaitPairingEvent = 1,
        EJackPairingPhase__RemoveController = 2,
        EJackPairingPhase__ChangedUser = 3,
        EJackPairingPhase__RestartGameFade = 4,
        EJackPairingPhase__RemovedXUser = 5,
        EJackPairingPhase__MAX = 6
    }


    // Enum JackGame.EJackPhotoModeEmoteAnim
    public enum EJackPhotoModeEmoteAnim : byte
    {
        EJackPhotoModeEmoteAnim__Emote_Wave = 0,
        EJackPhotoModeEmoteAnim__Emote_Greeting = 1,
        EJackPhotoModeEmoteAnim__Emote_Clap = 2,
        EJackPhotoModeEmoteAnim__Emote_Dance = 3,
        EJackPhotoModeEmoteAnim__Emote_LevelUp = 4,
        EJackPhotoModeEmoteAnim__Emote_Provoke = 5,
        EJackPhotoModeEmoteAnim__Emote_Joy = 6,
        EJackPhotoModeEmoteAnim__Emote_Angry = 7,
        EJackPhotoModeEmoteAnim__Emote_Cry = 8,
        EJackPhotoModeEmoteAnim__Emote_Point = 9,
        EJackPhotoModeEmoteAnim__Emote_Panic = 10,
        EJackPhotoModeEmoteAnim__Emote_Pose = 11,
        EJackPhotoModeEmoteAnim__Emote_Default = 12,
        EJackPhotoModeEmoteAnim__Emote_ExceptDefault = 13,
        EJackPhotoModeEmoteAnim__Emote_All = 14,
        EJackPhotoModeEmoteAnim__MAX = 15
    }


    // Enum JackGame.EJackPlayerAnimInstanceStateMachineState
    public enum EJackPlayerAnimInstanceStateMachineState : byte
    {
        EJackPlayerAnimInstanceStateMachineState__Unknown = 0,
        EJackPlayerAnimInstanceStateMachineState__ShootBowgun = 1,
        EJackPlayerAnimInstanceStateMachineState__EndShootBowgun = 2,
        EJackPlayerAnimInstanceStateMachineState__MAX = 3
    }


    // Enum JackGame.EJackPokerDoubleUpResult
    public enum EJackPokerDoubleUpResult : byte
    {
        EJackPokerDoubleUpResult__WIN = 0,
        EJackPokerDoubleUpResult__DRAW = 1,
        EJackPokerDoubleUpResult__LOSE = 2,
        EJackPokerDoubleUpResult__MAX = 3
    }


    // Enum JackGame.EJackPlayerAnimBaseStateMachineMode
    public enum EJackPlayerAnimBaseStateMachineMode : byte
    {
        EJackPlayerAnimBaseStateMachineMode__Default = 0,
        EJackPlayerAnimBaseStateMachineMode__Battle = 1,
        EJackPlayerAnimBaseStateMachineMode__Bowgun = 2,
        EJackPlayerAnimBaseStateMachineMode__MAX = 3
    }


    // Enum JackGame.EJackCameraLightControlPurpose
    public enum EJackCameraLightControlPurpose : byte
    {
        EJackCameraLightControlPurpose__MiniGame = 0,
        EJackCameraLightControlPurpose__CutScene = 1,
        EJackCameraLightControlPurpose__Debug = 2,
        EJackCameraLightControlPurpose__MAX = 3
    }


    // Enum JackGame.EJackPropHiddenPurpose
    public enum EJackPropHiddenPurpose : byte
    {
        EJackPropHiddenPurpose__Engine = 0,
        EJackPropHiddenPurpose__Owner = 1,
        EJackPropHiddenPurpose__AnimNotify = 2,
        EJackPropHiddenPurpose__Matinee = 3,
        EJackPropHiddenPurpose__Battle = 4,
        EJackPropHiddenPurpose__Blueprint = 5,
        EJackPropHiddenPurpose__FieldAction = 6,
        EJackPropHiddenPurpose__PhotoMode = 7,
        EJackPropHiddenPurpose__AnimNotifyState = 8,
        EJackPropHiddenPurpose__MAX = 9
    }


    // Enum JackGame.EJackRenkeiEndCamera
    public enum EJackRenkeiEndCamera : byte
    {
        EJackRenkeiEndCamera__None = 0,
        EJackRenkeiEndCamera__AutoFree = 1,
        EJackRenkeiEndCamera__Auto = 2,
        EJackRenkeiEndCamera__MAX = 3
    }


    // Enum JackGame.EJackRigidBodyControlPurpose
    public enum EJackRigidBodyControlPurpose : byte
    {
        EJackRigidBodyControlPurpose__CutScene = 0,
        EJackRigidBodyControlPurpose__LOD = 1,
        EJackRigidBodyControlPurpose__MAX = 2
    }


    // Enum JackGame.EJackMiniGameRouletteBallState
    public enum EJackMiniGameRouletteBallState : byte
    {
        EJackMiniGameRouletteBallState__Init = 0,
        EJackMiniGameRouletteBallState__UpdateAnimation = 1,
        EJackMiniGameRouletteBallState__Finished = 2,
        EJackMiniGameRouletteBallState__PocketInUpdate = 3,
        EJackMiniGameRouletteBallState__EndDemo = 4,
        EJackMiniGameRouletteBallState__End = 5,
        EJackMiniGameRouletteBallState__Max = 6
    }


    // Enum JackGame.EJackMiniGameRouletteAgingType
    public enum EJackMiniGameRouletteAgingType : byte
    {
        EJackMiniGameRouletteAgingType__None = 0,
        EJackMiniGameRouletteAgingType__Random = 1,
        EJackMiniGameRouletteAgingType__Random10 = 2,
        EJackMiniGameRouletteAgingType__OneX36 = 3,
        EJackMiniGameRouletteAgingType__OneX3601 = 4,
        EJackMiniGameRouletteAgingType__Random_Num = 5,
        EJackMiniGameRouletteAgingType__OneX36_Num = 6,
        EJackMiniGameRouletteAgingType__MAX = 7
    }


    // Enum JackGame.EJackMiniGameRouletteTreasureCoin
    public enum EJackMiniGameRouletteTreasureCoin : byte
    {
        EJackMiniGameRouletteTreasureCoin__Type01 = 0,
        EJackMiniGameRouletteTreasureCoin__Type02 = 1,
        EJackMiniGameRouletteTreasureCoin__Type03 = 2,
        EJackMiniGameRouletteTreasureCoin__Type04 = 3,
        EJackMiniGameRouletteTreasureCoin__MAX = 4
    }


    // Enum JackGame.EJackMiniGameRouletteEffect
    public enum EJackMiniGameRouletteEffect : byte
    {
        EJackMiniGameRouletteEffect__None = 0,
        EJackMiniGameRouletteEffect__JackPot = 1,
        EJackMiniGameRouletteEffect__NearJackPot = 2,
        EJackMiniGameRouletteEffect__Other = 3,
        EJackMiniGameRouletteEffect__Max = 4
    }


    // Enum JackGame.EJackSlotLottey
    public enum EJackSlotLottey : byte
    {
        EJackSlotLottey__None = 0,
        EJackSlotLottey__Enable = 1,
        EJackSlotLottey__Disable = 2,
        EJackSlotLottey__EJackSlotLottey_MAX = 3
    }


    // Enum JackGame.EJackSoftBodyControlPurpose
    public enum EJackSoftBodyControlPurpose : byte
    {
        EJackSoftBodyControlPurpose__CutScene = 0,
        EJackSoftBodyControlPurpose__LOD = 1,
        EJackSoftBodyControlPurpose__AnimationCurve = 2,
        EJackSoftBodyControlPurpose__MAX = 3
    }


    // Enum JackGame.EJackStoreResult
    public enum EJackStoreResult : byte
    {
        EJackStoreResult__None = 0,
        EJackStoreResult__OK = 1,
        EJackStoreResult__Cancel = 2,
        EJackStoreResult__Purchased = 3,
        EJackStoreResult__Error = 4,
        EJackStoreResult__EJackStoreResult_MAX = 5
    }


    // Enum JackGame.EJackNetworkCheckResult
    public enum EJackNetworkCheckResult : byte
    {
        EJackNetworkCheckResult__None = 0,
        EJackNetworkCheckResult__Checking = 1,
        EJackNetworkCheckResult__Login = 2,
        EJackNetworkCheckResult__Logout = 3,
        EJackNetworkCheckResult__NotFound = 4,
        EJackNetworkCheckResult__Failures = 5,
        EJackNetworkCheckResult__EJackNetworkCheckResult_MAX = 6
    }


    // Enum JackGame.EJackDLCIndex
    public enum EJackDLCIndex : byte
    {
        EJackDLCIndex__VoiceDrama = 0,
        EJackDLCIndex__MultiVoice = 1,
        EJackDLCIndex__PresentItem_00 = 2,
        EJackDLCIndex__PresentItem_01 = 3,
        EJackDLCIndex__PresentItem_02 = 4,
        EJackDLCIndex__PresentItem_03 = 5,
        EJackDLCIndex__PresentItem_04 = 6,
        EJackDLCIndex__PresentItem_05 = 7,
        EJackDLCIndex__PresentItem_06 = 8,
        EJackDLCIndex__PresentItem_07 = 9,
        EJackDLCIndex__PresentItem_08 = 10,
        EJackDLCIndex__PresentItem_09 = 11,
        EJackDLCIndex__PresentItem = 12,
        EJackDLCIndex__PresentItem01 = 13,
        EJackDLCIndex__PresentItem02 = 14,
        EJackDLCIndex__PresentItem03 = 15,
        EJackDLCIndex__PresentItem04 = 16,
        EJackDLCIndex__PresentItem05 = 17,
        EJackDLCIndex__PresentItem06 = 18,
        EJackDLCIndex__PresentItem07 = 19,
        EJackDLCIndex__PresentItem08 = 20,
        EJackDLCIndex__PresentItem09 = 21,
        EJackDLCIndex__MAX = 22
    }


    // Enum JackGame.EJackDebugSettingInfoType
    public enum EJackDebugSettingInfoType : byte
    {
        EJackDebugSettingInfoType__Debug_Enable = 0,
        EJackDebugSettingInfoType__Debug_LongerStringFlag = 1,
        EJackDebugSettingInfoType__Debug_Gender = 2,
        EJackDebugSettingInfoType__Debug_PlrNounFlag = 3,
        EJackDebugSettingInfoType__Debug_ProNounFlag = 4,
        EJackDebugSettingInfoType__Debug_VowelFlag = 5,
        EJackDebugSettingInfoType__Debug_LastIsSFlag = 6,
        EJackDebugSettingInfoType__Debug_SingleFlag = 7,
        EJackDebugSettingInfoType__Debug_SoloFlag = 8,
        EJackDebugSettingInfoType__Debug_ListFlag = 9,
        EJackDebugSettingInfoType__Debug_Patchim = 10,
        EJackDebugSettingInfoType__Debug_Num = 11,
        EJackDebugSettingInfoType__Debug_MAX = 12
    }


    // Enum JackGame.EJackErrorType
    public enum EJackErrorType : byte
    {
        EJackErrorType__Error_None = 0,
        EJackErrorType__Error_MacroDef = 1,
        EJackErrorType__Error_MacroEnd = 2,
        EJackErrorType__Error_MacroArgEnd = 3,
        EJackErrorType__Error_MacroArgNum = 4,
        EJackErrorType__Error_TagName = 5,
        EJackErrorType__Error_TagEnd = 6,
        EJackErrorType__Error_HangStart = 7,
        EJackErrorType__Error_HangEnd = 8,
        EJackErrorType__Error_HangTying = 9,
        EJackErrorType__Error_Num = 10,
        EJackErrorType__Error_MAX = 11
    }


    // Enum JackGame.EJackKeyWordType
    public enum EJackKeyWordType : byte
    {
        EJackKeyWordType__KeyWord_None = 0,
        EJackKeyWordType__KeyWord_Str = 1,
        EJackKeyWordType__KeyWord_Tag = 2,
        EJackKeyWordType__KeyWord_Macro = 3,
        EJackKeyWordType__KeyWord_MAX = 4
    }


    // Enum JackGame.EJackTimeDilationMode
    public enum EJackTimeDilationMode : byte
    {
        EJackTimeDilationMode__Multiply = 0,
        EJackTimeDilationMode__Minimum = 1,
        EJackTimeDilationMode__Maximum = 2,
        EJackTimeDilationMode__MAX = 3
    }


    // Enum JackGame.EJackCameraSetteiKeyActionType
    public enum EJackCameraSetteiKeyActionType : byte
    {
        EJackCameraSetteiKeyActionType__None = 0,
        EJackCameraSetteiKeyActionType__Neutral = 1,
        EJackCameraSetteiKeyActionType__Up = 2,
        EJackCameraSetteiKeyActionType__Right = 3,
        EJackCameraSetteiKeyActionType__Down = 4,
        EJackCameraSetteiKeyActionType__Left = 5,
        EJackCameraSetteiKeyActionType__NotDisp = 6,
        EJackCameraSetteiKeyActionType__MAX = 7
    }


    // Enum JackGame.EJackTenseiOperationType
    public enum EJackTenseiOperationType : byte
    {
        EJackTenseiOperationType__None = 0,
        EJackTenseiOperationType__FriendJoin = 1,
        EJackTenseiOperationType__Action = 2,
        EJackTenseiOperationType__Item = 3,
        EJackTenseiOperationType__RecipeBook = 4,
        EJackTenseiOperationType__UmaRace = 5,
        EJackTenseiOperationType__MAX = 6
    }


    // Enum JackGame.EJackPatchimType
    public enum EJackPatchimType : byte
    {
        EJackPatchimType__No = 0,
        EJackPatchimType__Yes = 1,
        EJackPatchimType__Rieul = 2,
        EJackPatchimType__MAX = 3
    }


    // Enum JackGame.EJackGermanCaseType
    public enum EJackGermanCaseType : byte
    {
        EJackGermanCaseType__Case = 0,
        EJackGermanCaseType__Case01 = 1,
        EJackGermanCaseType__Case02 = 2,
        EJackGermanCaseType__Case03 = 3,
        EJackGermanCaseType__Case_MAX = 4
    }


    // Enum JackGame.EJackGermanRatingType
    public enum EJackGermanRatingType : byte
    {
        EJackGermanRatingType__RatingDef = 0,
        EJackGermanRatingType__RatingInDef = 1,
        EJackGermanRatingType__RatingNum = 2,
        EJackGermanRatingType__EJackGermanRatingType_MAX = 3
    }


    // Enum JackGame.EJackGermanSectionType
    public enum EJackGermanSectionType : byte
    {
        EJackGermanSectionType__SectionNoun = 0,
        EJackGermanSectionType__SectionArticle = 1,
        EJackGermanSectionType__SectionNum = 2,
        EJackGermanSectionType__EJackGermanSectionType_MAX = 3
    }


    // Enum JackGame.EJackTagCategory
    public enum EJackTagCategory : byte
    {
        EJackTagCategory__TagCategory_None = 0,
        EJackTagCategory__TagCategoryNoun_EventBattle = 1,
        EJackTagCategory__TagCategoryNoun_Monster = 2,
        EJackTagCategory__TagCategoryNoun_MonsterType = 3,
        EJackTagCategory__TagCategoryNoun_Character = 4,
        EJackTagCategory__TagCategoryNoun_Caster = 5,
        EJackTagCategory__TagCategoryNoun_Target = 6,
        EJackTagCategory__TagCategoryNoun_Action = 7,
        EJackTagCategory__TagCategoryNoun_SkillLine = 8,
        EJackTagCategory__TagCategoryNoun_Renkei = 9,
        EJackTagCategory__TagCategoryNoun_WeaponType = 10,
        EJackTagCategory__TagCategoryNoun_EquipParts = 11,
        EJackTagCategory__TagCategoryNoun_Status = 12,
        EJackTagCategory__TagCategoryNoun_Item = 13,
        EJackTagCategory__TagCategoryNoun_ItemCategory = 14,
        EJackTagCategory__TagCategoryNoun_ItemUnit = 15,
        EJackTagCategory__TagCategoryNoun_ItemConjunction = 16,
        EJackTagCategory__TagCategoryNoun_ItemSpace = 17,
        EJackTagCategory__TagCategoryNoun_ItemHalfSpace = 18,
        EJackTagCategory__TagCategoryNoun_ItemStoreTarget = 19,
        EJackTagCategory__TagCategoryNoun_ItemRare = 20,
        EJackTagCategory__TagCategoryNoun_Bag = 21,
        EJackTagCategory__TagCategoryNoun_Weather = 22,
        EJackTagCategory__TagCategoryNoun_Field = 23,
        EJackTagCategory__TagCategoryNoun_Restart = 24,
        EJackTagCategory__TagCategoryNoun_RuraPoint = 25,
        EJackTagCategory__TagCategoryNoun_Place = 26,
        EJackTagCategory__TagCategoryNoun_Altar = 27,
        EJackTagCategory__TagCategoryNoun_Quest = 28,
        EJackTagCategory__TagCategoryNoun_MeosiMonster = 29,
        EJackTagCategory__TagCategoryNoun_MeosiItem = 30,
        EJackTagCategory__TagCategoryNoun_PokerHand = 31,
        EJackTagCategory__TagCategoryNoun_UmaRaceRank = 32,
        EJackTagCategory__TagCategoryNoun_FusigikajiCategory = 33,
        EJackTagCategory__TagCategoryNoun_FusigikajiTokugi = 34,
        EJackTagCategory__TagCategoryNoun_Syuuren = 35,
        EJackTagCategory__TagCategoryNoun_ShibariPlay = 36,
        EJackTagCategory__TagCategoryNumeral_Item = 37,
        EJackTagCategory__TagCategoryNumeral_Member = 38,
        EJackTagCategory__TagCategoryNumeral_Exp = 39,
        EJackTagCategory__TagCategoryNumeral_Level = 40,
        EJackTagCategory__TagCategoryNumeral_SkillPoint = 41,
        EJackTagCategory__TagCategoryNumeral_Seed = 42,
        EJackTagCategory__TagCategoryNumeral_Tikara = 43,
        EJackTagCategory__TagCategoryNumeral_Minomamori = 44,
        EJackTagCategory__TagCategoryNumeral_Subayasa = 45,
        EJackTagCategory__TagCategoryNumeral_Kiyousa = 46,
        EJackTagCategory__TagCategoryNumeral_Miryoku = 47,
        EJackTagCategory__TagCategoryNumeral_Gold = 48,
        EJackTagCategory__TagCategoryNumeral_Damage = 49,
        EJackTagCategory__TagCategoryNumeral_Turn = 50,
        EJackTagCategory__TagCategoryNumeral_Treasure = 51,
        EJackTagCategory__TagCategoryNumeral_FieldTarget = 52,
        EJackTagCategory__TagCategoryNumeral_Minute = 53,
        EJackTagCategory__TagCategoryNumeral_RetryItem = 54,
        EJackTagCategory__TagCategoryNumeral_BlacksmithLevel = 55,
        EJackTagCategory__TagCategoryNumeral_UpCp = 56,
        EJackTagCategory__TagCategoryNumeral_Coin = 57,
        EJackTagCategory__TagCategoryNumeral_DoubleUp = 58,
        EJackTagCategory__TagCategoryNumeral_Card = 59,
        EJackTagCategory__TagCategoryNumeral_Roulette = 60,
        EJackTagCategory__TagCategoryNumeral_MedalSpin = 61,
        EJackTagCategory__TagCategoryNumeral_FleeSpin = 62,
        EJackTagCategory__TagCategoryNumeral_Game = 63,
        EJackTagCategory__TagCategoryNumeral_Setting = 64,
        EJackTagCategory__TagCategoryNumeral_Slotblock = 65,
        EJackTagCategory__TagCategoryNumeral_Medal = 66,
        EJackTagCategory__TagCategoryNumeral_Stamp = 67,
        EJackTagCategory__TagCategoryNumeral_Save = 68,
        EJackTagCategory__TagCategoryNumeral_Playtime = 69,
        EJackTagCategory__TagCategoryNumeral_MonsterQuantity = 70,
        EJackTagCategory__TagCategoryNumeral_MpRecovery = 71,
        EJackTagCategory__TagCategoryNumeral_TargetValue = 72,
        EJackTagCategory__TagCategoryNumeral_TargetNumber = 73,
        EJackTagCategory__TagCategoryNumeral_JumonNumber = 74,
        EJackTagCategory__TagCategoryFix_Player = 75,
        EJackTagCategory__TagCategoryFix_Players = 76,
        EJackTagCategory__TagCategoryFix_ControlledCharacter = 77,
        EJackTagCategory__TagCategoryFix_ControlledCharacters = 78,
        EJackTagCategory__TagCategoryFix_Gold = 79,
        EJackTagCategory__TagCategoryFix_Medal = 80,
        EJackTagCategory__TagCategoryFix_Coin = 81,
        EJackTagCategory__EJackTagCategory_MAX = 82
    }


    // Enum JackGame.EJackTagReferType
    public enum EJackTagReferType : byte
    {
        EJackTagReferType__TagRefer_None = 0,
        EJackTagReferType__TagRefer_Fix = 1,
        EJackTagReferType__TagRefer_OutSide_Member = 2,
        EJackTagReferType__TagRefer_Noun = 3,
        EJackTagReferType__TagRefer_Numeral = 4,
        EJackTagReferType__TagRefer_List = 5,
        EJackTagReferType__TagRefer_MAX = 6
    }


    // Enum JackGame.EJackHangType
    public enum EJackHangType : byte
    {
        EJackHangType__Hang_None = 0,
        EJackHangType__Hang_Left = 1,
        EJackHangType__Hang_Right = 2,
        EJackHangType__Hang_MAX = 3
    }


    // Enum JackGame.EJackMacroType
    public enum EJackMacroType : byte
    {
        EJackMacroType__Macro_None = 0,
        EJackMacroType__Macro_Normal = 1,
        EJackMacroType__Macro_HR_Tag = 2,
        EJackMacroType__Macro_HR_Mac = 3,
        EJackMacroType__Macro_HL_Tag = 4,
        EJackMacroType__Macro_HL_Mac = 5,
        EJackMacroType__Macro_TR_Noun = 6,
        EJackMacroType__Macro_TR_Numeral = 7,
        EJackMacroType__Macro_MAX = 8
    }


    // Enum JackGame.EJackSymbolType
    public enum EJackSymbolType : byte
    {
        EJackSymbolType__Symbol_None = 0,
        EJackSymbolType__Symbol_Start = 1,
        EJackSymbolType__Symbol_End = 2,
        EJackSymbolType__Symbol_MAX = 3
    }


    // Enum JackGame.EJackProcessType
    public enum EJackProcessType : byte
    {
        EJackProcessType__Proc_None = 0,
        EJackProcessType__Proc_Replacement = 1,
        EJackProcessType__Proc_Cap = 2,
        EJackProcessType__Proc_AllCap = 3,
        EJackProcessType__Proc_SglM = 4,
        EJackProcessType__Proc_SglF = 5,
        EJackProcessType__Proc_SglN = 6,
        EJackProcessType__Proc_Sgl = 7,
        EJackProcessType__Proc_IndefSgl = 8,
        EJackProcessType__Proc_DefSgl = 9,
        EJackProcessType__Proc_Plr = 10,
        EJackProcessType__Proc_IndefPlr = 11,
        EJackProcessType__Proc_IndefPlrIT = 12,
        EJackProcessType__Proc_DefPlr = 13,
        EJackProcessType__Proc_List = 14,
        EJackProcessType__Proc_Gender = 15,
        EJackProcessType__Proc_IfPr = 16,
        EJackProcessType__Proc_IfPlrNoun = 17,
        EJackProcessType__Proc_IfProperNoun = 18,
        EJackProcessType__Proc_IfSing = 19,
        EJackProcessType__Proc_IfFRSing = 20,
        EJackProcessType__Proc_IfSolo = 21,
        EJackProcessType__Proc_IfVowel = 22,
        EJackProcessType__Proc_IfLastIsS = 23,
        EJackProcessType__Proc_IfList = 24,
        EJackProcessType__Proc_IndefSgl_NOM = 25,
        EJackProcessType__Proc_IndefSgl_GEN = 26,
        EJackProcessType__Proc_IndefSgl_DAT = 27,
        EJackProcessType__Proc_IndefSgl_ACC = 28,
        EJackProcessType__Proc_DefSgl_NOM = 29,
        EJackProcessType__Proc_DefSgl_GEN = 30,
        EJackProcessType__Proc_DefSgl_DAT = 31,
        EJackProcessType__Proc_DefSgl_ACC = 32,
        EJackProcessType__Proc_IndefPlr_NOM = 33,
        EJackProcessType__Proc_IndefPlr_GEN = 34,
        EJackProcessType__Proc_IndefPlr_DAT = 35,
        EJackProcessType__Proc_IndefPlr_ACC = 36,
        EJackProcessType__Proc_DefPlr_NOM = 37,
        EJackProcessType__Proc_DefPlr_GEN = 38,
        EJackProcessType__Proc_DefPlr_DAT = 39,
        EJackProcessType__Proc_DefPlr_ACC = 40,
        EJackProcessType__Proc_IndefSgl_NOM_ART = 41,
        EJackProcessType__Proc_IndefSgl_GEN_ART = 42,
        EJackProcessType__Proc_IndefSgl_DAT_ART = 43,
        EJackProcessType__Proc_IndefSgl_ACC_ART = 44,
        EJackProcessType__Proc_DefSgl_NOM_ART = 45,
        EJackProcessType__Proc_DefSgl_GEN_ART = 46,
        EJackProcessType__Proc_DefSgl_DAT_ART = 47,
        EJackProcessType__Proc_DefSgl_ACC_ART = 48,
        EJackProcessType__Proc_IndefPlr_NOM_ART = 49,
        EJackProcessType__Proc_IndefPlr_GEN_ART = 50,
        EJackProcessType__Proc_IndefPlr_DAT_ART = 51,
        EJackProcessType__Proc_IndefPlr_ACC_ART = 52,
        EJackProcessType__Proc_DefPlr_NOM_ART = 53,
        EJackProcessType__Proc_DefPlr_GEN_ART = 54,
        EJackProcessType__Proc_DefPlr_DAT_ART = 55,
        EJackProcessType__Proc_DefPlr_ACC_ART = 56,
        EJackProcessType__Proc_PPN01 = 57,
        EJackProcessType__Proc_PPN02 = 58,
        EJackProcessType__Proc_IfTopRanker = 59,
        EJackProcessType__Proc_MAX = 60
    }


    // Enum JackGame.EJackControllerParts
    public enum EJackControllerParts : byte
    {
        EJackControllerParts__A = 0,
        EJackControllerParts__B = 1,
        EJackControllerParts__BJUMP = 2,
        EJackControllerParts__X = 3,
        EJackControllerParts__Y = 4,
        EJackControllerParts__LT = 5,
        EJackControllerParts__RT = 6,
        EJackControllerParts__LSB = 7,
        EJackControllerParts__RSB = 8,
        EJackControllerParts__START = 9,
        EJackControllerParts__PHOTO = 10,
        EJackControllerParts__DPAD_U = 11,
        EJackControllerParts__DPAD_D = 12,
        EJackControllerParts__DPAD_L = 13,
        EJackControllerParts__DPAD_R = 14,
        EJackControllerParts__LB = 15,
        EJackControllerParts__RB = 16,
        EJackControllerParts__LS_U = 17,
        EJackControllerParts__LS_D = 18,
        EJackControllerParts__LS_L = 19,
        EJackControllerParts__LS_R = 20,
        EJackControllerParts__RS_U = 21,
        EJackControllerParts__RS_D = 22,
        EJackControllerParts__RS_L = 23,
        EJackControllerParts__RS_R = 24,
        EJackControllerParts__MAX = 25
    }


    // Enum JackGame.EJackScreenPercentage
    public enum EJackScreenPercentage : byte
    {
        EJackScreenPercentage__GameDefault = 0,
        EJackScreenPercentage__PartyTalk = 1,
        EJackScreenPercentage__PhotoMode = 2,
        EJackScreenPercentage__CutScene = 3,
        EJackScreenPercentage__Casino = 4,
        EJackScreenPercentage__Custom = 5,
        EJackScreenPercentage__MAX = 6
    }


    // Enum JackGame.EJackPartySeizonJoutai
    public enum EJackPartySeizonJoutai : byte
    {
        EJackPartySeizonJoutai__None = 0,
        EJackPartySeizonJoutai__MainZenmetu = 1,
        EJackPartySeizonJoutai__AllZenmetu = 2,
        EJackPartySeizonJoutai__MAX = 3
    }


    // Enum JackGame.EJackCSMapLevelStatus
    public enum EJackCSMapLevelStatus : byte
    {
        EJackCSMapLevelStatus__None = 0,
        EJackCSMapLevelStatus__Load = 1,
        EJackCSMapLevelStatus__Visible = 2,
        EJackCSMapLevelStatus__Hidden = 3,
        EJackCSMapLevelStatus__Unload = 4,
        EJackCSMapLevelStatus__MAX = 5
    }


    // Enum JackGame.EJackQuestRewardType
    public enum EJackQuestRewardType : byte
    {
        EJackQuestRewardType__None = 0,
        EJackQuestRewardType__Item = 1,
        EJackQuestRewardType__Gold = 2,
        EJackQuestRewardType__PowerUp = 3,
        EJackQuestRewardType__MAX = 4
    }


    // Enum JackGame.EJackProgression
    public enum EJackProgression : byte
    {
        EJackProgression__NotListed = 0,
        EJackProgression__Published = 1,
        EJackProgression__Occurrence = 2,
        EJackProgression__Inorder = 3,
        EJackProgression__Active_010 = 4,
        EJackProgression__Active_020 = 5,
        EJackProgression__Active_030 = 6,
        EJackProgression__Active_040 = 7,
        EJackProgression__AchieveDisplayWait = 8,
        EJackProgression__Achieved = 9,
        EJackProgression__Terminated = 10,
        EJackProgression__MAX = 11
    }


    // Enum JackGame.EJackAchievement
    public enum EJackAchievement : byte
    {
        EJackAchievement__None = 0,
        EJackAchievement__ItemGetAnyWhere = 1,
        EJackAchievement__ItemGetSpecificArea = 2,
        EJackAchievement__ItemGetFusigiKaji = 3,
        EJackAchievement__ItemGetSpecificMonster = 4,
        EJackAchievement__ItemGetSpecificTreasureBox = 5,
        EJackAchievement__ItemGetSpecificKiraKira = 6,
        EJackAchievement__MonsterKnockDown = 7,
        EJackAchievement__MonsterKnockDownRule = 8,
        EJackAchievement__ReadSpecificBook = 9,
        EJackAchievement__ReadSpecificSignboard = 10,
        EJackAchievement__EquipSpecific = 11,
        EJackAchievement__ShowSpecificEquipmentTwice = 12,
        EJackAchievement__ToreachSpecificPlace = 13,
        EJackAchievement__TalkSpecificNpc = 14,
        EJackAchievement__ToSpecifiedValue = 15,
        EJackAchievement__TalkAgainAfterSpecifiedTime = 16,
        EJackAchievement__SpecifiedCoordinates = 17,
        EJackAchievement__ItemGetIceax = 18,
        EJackAchievement__ItemGetSickle = 19,
        EJackAchievement__RouletteJackpot = 20,
        EJackAchievement__MAX = 21
    }


    // Enum JackGame.EJackRestartProcessType
    public enum EJackRestartProcessType : byte
    {
        EJackRestartProcessType__Pray = 0,
        EJackRestartProcessType__Map = 1,
        EJackRestartProcessType__Event = 2,
        EJackRestartProcessType__MAX = 3
    }


    // Enum JackGame.EJackMapResourceLoadChannel
    public enum EJackMapResourceLoadChannel : byte
    {
        EJackMapResourceLoadChannel__MiniMap = 0,
        EJackMapResourceLoadChannel__LocalMap = 1,
        EJackMapResourceLoadChannel__WorldMap = 2,
        EJackMapResourceLoadChannel__MAX = 3
    }


    // Enum JackGame.EJackMapNowLoadingStatus
    public enum EJackMapNowLoadingStatus : byte
    {
        EJackMapNowLoadingStatus__None = 0,
        EJackMapNowLoadingStatus__Show = 1,
        EJackMapNowLoadingStatus__Hide = 2,
        EJackMapNowLoadingStatus__EJackMapNowLoadingStatus_MAX = 3
    }


    // Enum JackGame.EJackWorldMapState
    public enum EJackWorldMapState : byte
    {
        EJackWorldMapState__Default = 0,
        EJackWorldMapState__LocalMap = 1,
        EJackWorldMapState__WorldMap = 2,
        EJackWorldMapState__SeaMap = 3,
        EJackWorldMapState__SkyMap = 4,
        EJackWorldMapState__MapMenu = 5,
        EJackWorldMapState__WorldMapMenu = 6,
        EJackWorldMapState__SeaSkyMapMenu = 7,
        EJackWorldMapState__Quest = 8,
        EJackWorldMapState__Kira = 9,
        EJackWorldMapState__Facility = 10,
        EJackWorldMapState__Monster = 11,
        EJackWorldMapState__Rura = 12,
        EJackWorldMapState__DidRuraAction = 13,
        EJackWorldMapState__NeighborMap = 14,
        EJackWorldMapState__Zoom = 15,
        EJackWorldMapState__ZoomModeTransition = 16,
        EJackWorldMapState__DisplayingOtherFloor = 17,
        EJackWorldMapState__MiniMap = 18,
        EJackWorldMapState__MAX = 19
    }


    // Enum JackGame.EJackUIMapZoomState
    public enum EJackUIMapZoomState : byte
    {
        EJackUIMapZoomState__None = 0,
        EJackUIMapZoomState__ZoomIn = 1,
        EJackUIMapZoomState__Zoom = 2,
        EJackUIMapZoomState__ZoomOut = 3,
        EJackUIMapZoomState__MAX = 4
    }


    // Enum JackGame.EJackMapTextItemDisplayMethodInNeighborMapMode
    public enum EJackMapTextItemDisplayMethodInNeighborMapMode : byte
    {
        EJackMapTextItemDisplayMethodInNeighborMapMode__SameInCurrentMap = 0,
        EJackMapTextItemDisplayMethodInNeighborMapMode__Show = 1,
        EJackMapTextItemDisplayMethodInNeighborMapMode__Hide = 2,
        EJackMapTextItemDisplayMethodInNeighborMapMode__EJackMapTextItemDisplayMethodInNeighborMapMode_MAX = 3
    }


    // Enum JackGame.EJackMapTextItemControlMethod
    public enum EJackMapTextItemControlMethod : byte
    {
        EJackMapTextItemControlMethod__None = 0,
        EJackMapTextItemControlMethod__DataTable = 1,
        EJackMapTextItemControlMethod__CurrentMapID = 2,
        EJackMapTextItemControlMethod__CurrentMapVolumeID = 3,
        EJackMapTextItemControlMethod__Anchorage = 4,
        EJackMapTextItemControlMethod__GameFlag = 5,
        EJackMapTextItemControlMethod__MAX = 6
    }


    // Enum JackGame.EJackMapTextItemDrawTarget
    public enum EJackMapTextItemDrawTarget : byte
    {
        EJackMapTextItemDrawTarget__WorldMap = 0,
        EJackMapTextItemDrawTarget__MiniMap = 1,
        EJackMapTextItemDrawTarget__Both = 2,
        EJackMapTextItemDrawTarget__MAX = 3
    }


    // Enum JackGame.EJackMapPCMarkerDisplayMethod
    public enum EJackMapPCMarkerDisplayMethod : byte
    {
        EJackMapPCMarkerDisplayMethod__Show = 0,
        EJackMapPCMarkerDisplayMethod__ShowJustCurrentFloor = 1,
        EJackMapPCMarkerDisplayMethod__Hide = 2,
        EJackMapPCMarkerDisplayMethod__MAX = 3
    }


    // Enum JackGame.EJackLocationNameDisplayMethod
    public enum EJackLocationNameDisplayMethod : byte
    {
        EJackLocationNameDisplayMethod__None = 0,
        EJackLocationNameDisplayMethod__Show = 1,
        EJackLocationNameDisplayMethod__Hide = 2,
        EJackLocationNameDisplayMethod__Censored = 3,
        EJackLocationNameDisplayMethod__Grayout = 4,
        EJackLocationNameDisplayMethod__MAX = 5
    }


    // Enum JackGame.EJackFloorGroup
    public enum EJackFloorGroup : byte
    {
        EJackFloorGroup__None = 0,
        EJackFloorGroup__Group_A = 1,
        EJackFloorGroup__Group_B = 2,
        EJackFloorGroup__Group_C = 3,
        EJackFloorGroup__Group_D = 4,
        EJackFloorGroup__Group_E = 5,
        EJackFloorGroup__Group_F = 6,
        EJackFloorGroup__Group_G = 7,
        EJackFloorGroup__Group_H = 8,
        EJackFloorGroup__Group_I = 9,
        EJackFloorGroup__Group_J = 10,
        EJackFloorGroup__Group_K = 11,
        EJackFloorGroup__Group_L = 12,
        EJackFloorGroup__Group_M = 13,
        EJackFloorGroup__Group_N = 14,
        EJackFloorGroup__Group_O = 15,
        EJackFloorGroup__Group_P = 16,
        EJackFloorGroup__Group_Q = 17,
        EJackFloorGroup__Group_R = 18,
        EJackFloorGroup__Group_S = 19,
        EJackFloorGroup__Group_T = 20,
        EJackFloorGroup__Group_U = 21,
        EJackFloorGroup__Group_V = 22,
        EJackFloorGroup__Group_W = 23,
        EJackFloorGroup__Group_X = 24,
        EJackFloorGroup__Group_Y = 25,
        EJackFloorGroup__Group_Z = 26,
        EJackFloorGroup__Ido = 27,
        EJackFloorGroup__MAX = 28
    }


    // Enum JackGame.EJackFloorArea
    public enum EJackFloorArea : byte
    {
        EJackFloorArea__Area = 0,
        EJackFloorArea__Area01 = 1,
        EJackFloorArea__Area02 = 2,
        EJackFloorArea__Area03 = 3,
        EJackFloorArea__Area04 = 4,
        EJackFloorArea__Area05 = 5,
        EJackFloorArea__Area06 = 6,
        EJackFloorArea__Area07 = 7,
        EJackFloorArea__Area08 = 8,
        EJackFloorArea__Area09 = 9,
        EJackFloorArea__Area10 = 10,
        EJackFloorArea__Area11 = 11,
        EJackFloorArea__Area12 = 12,
        EJackFloorArea__Area13 = 13,
        EJackFloorArea__Area14 = 14,
        EJackFloorArea__Area15 = 15,
        EJackFloorArea__Area16 = 16,
        EJackFloorArea__Area17 = 17,
        EJackFloorArea__Area18 = 18,
        EJackFloorArea__Area19 = 19,
        EJackFloorArea__Area20 = 20,
        EJackFloorArea__Area21 = 21,
        EJackFloorArea__Area22 = 22,
        EJackFloorArea__Area23 = 23,
        EJackFloorArea__Area24 = 24,
        EJackFloorArea__Area25 = 25,
        EJackFloorArea__Area26 = 26,
        EJackFloorArea__Area27 = 27,
        EJackFloorArea__Area28 = 28,
        EJackFloorArea__Area29 = 29,
        EJackFloorArea__MAX = 30
    }


    // Enum JackGame.EJackFloorLevel
    public enum EJackFloorLevel : byte
    {
        EJackFloorLevel__None = 0,
        EJackFloorLevel__F1 = 1,
        EJackFloorLevel__F2 = 2,
        EJackFloorLevel__F3 = 3,
        EJackFloorLevel__F4 = 4,
        EJackFloorLevel__F5 = 5,
        EJackFloorLevel__F6 = 6,
        EJackFloorLevel__F7 = 7,
        EJackFloorLevel__F8 = 8,
        EJackFloorLevel__F9 = 9,
        EJackFloorLevel__F10 = 10,
        EJackFloorLevel__F11 = 11,
        EJackFloorLevel__F12 = 12,
        EJackFloorLevel__F13 = 13,
        EJackFloorLevel__F14 = 14,
        EJackFloorLevel__F15 = 15,
        EJackFloorLevel__F16 = 16,
        EJackFloorLevel__F17 = 17,
        EJackFloorLevel__F18 = 18,
        EJackFloorLevel__F19 = 19,
        EJackFloorLevel__F20 = 20,
        EJackFloorLevel__F21 = 21,
        EJackFloorLevel__F22 = 22,
        EJackFloorLevel__F23 = 23,
        EJackFloorLevel__F24 = 24,
        EJackFloorLevel__F25 = 25,
        EJackFloorLevel__F26 = 26,
        EJackFloorLevel__F27 = 27,
        EJackFloorLevel__F28 = 28,
        EJackFloorLevel__F29 = 29,
        EJackFloorLevel__F30 = 30,
        EJackFloorLevel__F31 = 31,
        EJackFloorLevel__F32 = 32,
        EJackFloorLevel__F33 = 33,
        EJackFloorLevel__F34 = 34,
        EJackFloorLevel__F35 = 35,
        EJackFloorLevel__F36 = 36,
        EJackFloorLevel__F37 = 37,
        EJackFloorLevel__F38 = 38,
        EJackFloorLevel__F39 = 39,
        EJackFloorLevel__F40 = 40,
        EJackFloorLevel__F41 = 41,
        EJackFloorLevel__F42 = 42,
        EJackFloorLevel__F43 = 43,
        EJackFloorLevel__F44 = 44,
        EJackFloorLevel__F45 = 45,
        EJackFloorLevel__F46 = 46,
        EJackFloorLevel__F47 = 47,
        EJackFloorLevel__F48 = 48,
        EJackFloorLevel__F49 = 49,
        EJackFloorLevel__F50 = 50,
        EJackFloorLevel__B1 = 51,
        EJackFloorLevel__B2 = 52,
        EJackFloorLevel__B3 = 53,
        EJackFloorLevel__B4 = 54,
        EJackFloorLevel__B5 = 55,
        EJackFloorLevel__B6 = 56,
        EJackFloorLevel__B7 = 57,
        EJackFloorLevel__B8 = 58,
        EJackFloorLevel__B9 = 59,
        EJackFloorLevel__B10 = 60,
        EJackFloorLevel__B11 = 61,
        EJackFloorLevel__B12 = 62,
        EJackFloorLevel__B13 = 63,
        EJackFloorLevel__B14 = 64,
        EJackFloorLevel__B15 = 65,
        EJackFloorLevel__B16 = 66,
        EJackFloorLevel__B17 = 67,
        EJackFloorLevel__B18 = 68,
        EJackFloorLevel__B19 = 69,
        EJackFloorLevel__B20 = 70,
        EJackFloorLevel__B21 = 71,
        EJackFloorLevel__B22 = 72,
        EJackFloorLevel__B23 = 73,
        EJackFloorLevel__B24 = 74,
        EJackFloorLevel__B25 = 75,
        EJackFloorLevel__B26 = 76,
        EJackFloorLevel__B27 = 77,
        EJackFloorLevel__B28 = 78,
        EJackFloorLevel__B29 = 79,
        EJackFloorLevel__B30 = 80,
        EJackFloorLevel__B31 = 81,
        EJackFloorLevel__B32 = 82,
        EJackFloorLevel__B33 = 83,
        EJackFloorLevel__B34 = 84,
        EJackFloorLevel__B35 = 85,
        EJackFloorLevel__B36 = 86,
        EJackFloorLevel__B37 = 87,
        EJackFloorLevel__B38 = 88,
        EJackFloorLevel__B39 = 89,
        EJackFloorLevel__B40 = 90,
        EJackFloorLevel__B41 = 91,
        EJackFloorLevel__B42 = 92,
        EJackFloorLevel__B43 = 93,
        EJackFloorLevel__B44 = 94,
        EJackFloorLevel__B45 = 95,
        EJackFloorLevel__B46 = 96,
        EJackFloorLevel__B47 = 97,
        EJackFloorLevel__B48 = 98,
        EJackFloorLevel__B49 = 99,
        EJackFloorLevel__B50 = 100,
        EJackFloorLevel__Invalid = 101,
        EJackFloorLevel__MAX = 102
    }


    // Enum JackGame.EJackMapFieldType
    public enum EJackMapFieldType : byte
    {
        EJackMapFieldType__Kyoten = 0,
        EJackMapFieldType__Dungeon = 1,
        EJackMapFieldType__Field = 2,
        EJackMapFieldType__Ido = 3,
        EJackMapFieldType__SeaSky = 4,
        EJackMapFieldType__WorldMap = 5,
        EJackMapFieldType__MAX = 6
    }


    // Enum JackGame.EJackMapInfoType
    public enum EJackMapInfoType : byte
    {
        EJackMapInfoType__Usual = 0,
        EJackMapInfoType__SLocationOnly = 1,
        EJackMapInfoType__NoMap = 2,
        EJackMapInfoType__MAX = 3
    }


    // Enum JackGame.EJackMapSymbol
    public enum EJackMapSymbol : byte
    {
        EJackMapSymbol__None = 0,
        EJackMapSymbol__Buki = 1,
        EJackMapSymbol__Bougu = 2,
        EJackMapSymbol__Dougu = 3,
        EJackMapSymbol__Yadoya = 4,
        EJackMapSymbol__Kyoukai = 5,
        EJackMapSymbol__MegamizouD17 = 6,
        EJackMapSymbol__Sakaba = 7,
        EJackMapSymbol__Ginkou = 8,
        EJackMapSymbol__Blacksmith = 9,
        EJackMapSymbol__Camp = 10,
        EJackMapSymbol__Medal = 11,
        EJackMapSymbol__HorseRace = 12,
        EJackMapSymbol__Casino = 13,
        EJackMapSymbol__CasinoCoin = 14,
        EJackMapSymbol__CasinoKeihin = 15,
        EJackMapSymbol__ScenarioGuide = 16,
        EJackMapSymbol__QuestGuide = 17,
        EJackMapSymbol__ActionGuide = 18,
        EJackMapSymbol__DestinationGuide1 = 19,
        EJackMapSymbol__DestinationGuide2 = 20,
        EJackMapSymbol__HorseCall = 21,
        EJackMapSymbol__Ido = 22,
        EJackMapSymbol__YusyaNoSekihi = 23,
        EJackMapSymbol__CurePoint = 24,
        EJackMapSymbol__TaijuNoNe = 25,
        EJackMapSymbol__TaijuNoNaegi = 26,
        EJackMapSymbol__RuraPoint1 = 27,
        EJackMapSymbol__RuraPoint2 = 28,
        EJackMapSymbol__MapJumpPoint = 29,
        EJackMapSymbol__MermaidHarpPoint = 30,
        EJackMapSymbol__LandingPoint1 = 31,
        EJackMapSymbol__LandingPoint2 = 32,
        EJackMapSymbol__Pier = 33,
        EJackMapSymbol__GoldenIceberg = 34,
        EJackMapSymbol__MagicDoor = 35,
        EJackMapSymbol__LastDoor = 36,
        EJackMapSymbol__S14 = 37,
        EJackMapSymbol__M14 = 38,
        EJackMapSymbol__D15 = 39,
        EJackMapSymbol__D17 = 40,
        EJackMapSymbol__KuroiTaiyou = 41,
        EJackMapSymbol__SaikyouBoss = 42,
        EJackMapSymbol__HorseRide = 43,
        EJackMapSymbol__MonsterRide = 44,
        EJackMapSymbol__Ship = 45,
        EJackMapSymbol__Gondola = 46,
        EJackMapSymbol__Castle = 47,
        EJackMapSymbol__C01 = 48,
        EJackMapSymbol__D14 = 49,
        EJackMapSymbol__S11 = 50,
        EJackMapSymbol__Rubble = 51,
        EJackMapSymbol__FloatingIsland = 52,
        EJackMapSymbol__KuroiKyutai = 53,
        EJackMapSymbol__Cave = 54,
        EJackMapSymbol__Delubrum = 55,
        EJackMapSymbol__Tower = 56,
        EJackMapSymbol__Village = 57,
        EJackMapSymbol__Town = 58,
        EJackMapSymbol__Kira1 = 59,
        EJackMapSymbol__Kira2 = 60,
        EJackMapSymbol__TimeZone_Daytime = 61,
        EJackMapSymbol__TimeZone_Night = 62,
        EJackMapSymbol__Weather_Sunny = 63,
        EJackMapSymbol__Weather_Rain = 64,
        EJackMapSymbol__Weather_Snow = 65,
        EJackMapSymbol__PCMarker = 66,
        EJackMapSymbol__PCFootmark = 67,
        EJackMapSymbol__CustomTexture = 68,
        EJackMapSymbol__Hidden = 69,
        EJackMapSymbol__MAX = 70
    }


    // Enum JackGame.EJackMapConditionType
    public enum EJackMapConditionType : byte
    {
        EJackMapConditionType__None = 0,
        EJackMapConditionType__InMap = 1,
        EJackMapConditionType__NotInMap = 2,
        EJackMapConditionType__HaveVisited = 3,
        EJackMapConditionType__NotHaveVisited = 4,
        EJackMapConditionType__MAX = 5
    }


    // Enum JackGame.EJackMapIDType
    public enum EJackMapIDType : byte
    {
        EJackMapIDType__None = 0,
        EJackMapIDType__MapID = 1,
        EJackMapIDType__MapVolumeID = 2,
        EJackMapIDType__MAX = 3
    }


    // Enum JackGame.EJackGameFlagOperator
    public enum EJackGameFlagOperator : byte
    {
        EJackGameFlagOperator__None = 0,
        EJackGameFlagOperator__Equal = 1,
        EJackGameFlagOperator__NotEqual = 2,
        EJackGameFlagOperator__IsTrue = 3,
        EJackGameFlagOperator__IsNotTrue = 4,
        EJackGameFlagOperator__IsFalse = 5,
        EJackGameFlagOperator__IsNotFalse = 6,
        EJackGameFlagOperator__Not = 7,
        EJackGameFlagOperator__MAX = 8
    }


    // Enum JackGame.EJackGameFlagDataType
    public enum EJackGameFlagDataType : byte
    {
        EJackGameFlagDataType__INVALID = 0,
        EJackGameFlagDataType__Bool = 1,
        EJackGameFlagDataType__Int = 2,
        EJackGameFlagDataType__Float = 3,
        EJackGameFlagDataType__String = 4,
        EJackGameFlagDataType__MAX = 5
    }


    // Enum JackGame.EJackScenarioID
    public enum EJackScenarioID : byte
    {
        EJackScenarioID__None = 0,
        EJackScenarioID__A010 = 1,
        EJackScenarioID__A020 = 2,
        EJackScenarioID__A030 = 3,
        EJackScenarioID__A040 = 4,
        EJackScenarioID__A050 = 5,
        EJackScenarioID__A060 = 6,
        EJackScenarioID__A070 = 7,
        EJackScenarioID__A080 = 8,
        EJackScenarioID__A090 = 9,
        EJackScenarioID__A100 = 10,
        EJackScenarioID__A110 = 11,
        EJackScenarioID__A120 = 12,
        EJackScenarioID__A130 = 13,
        EJackScenarioID__A140 = 14,
        EJackScenarioID__A150 = 15,
        EJackScenarioID__A160 = 16,
        EJackScenarioID__A170 = 17,
        EJackScenarioID__A180 = 18,
        EJackScenarioID__S010 = 19,
        EJackScenarioID__S020 = 20,
        EJackScenarioID__S030 = 21,
        EJackScenarioID__S040 = 22,
        EJackScenarioID__S050 = 23,
        EJackScenarioID__B010 = 24,
        EJackScenarioID__B020 = 25,
        EJackScenarioID__B030 = 26,
        EJackScenarioID__B040 = 27,
        EJackScenarioID__B050 = 28,
        EJackScenarioID__B060 = 29,
        EJackScenarioID__B070 = 30,
        EJackScenarioID__B080 = 31,
        EJackScenarioID__B090 = 32,
        EJackScenarioID__B100 = 33,
        EJackScenarioID__B110 = 34,
        EJackScenarioID__B120 = 35,
        EJackScenarioID__B130 = 36,
        EJackScenarioID__B140 = 37,
        EJackScenarioID__B150 = 38,
        EJackScenarioID__B160 = 39,
        EJackScenarioID__B170 = 40,
        EJackScenarioID__C010 = 41,
        EJackScenarioID__C020 = 42,
        EJackScenarioID__C030 = 43,
        EJackScenarioID__C040 = 44,
        EJackScenarioID__C050 = 45,
        EJackScenarioID__C060 = 46,
        EJackScenarioID__C070 = 47,
        EJackScenarioID__C080 = 48,
        EJackScenarioID__C090 = 49,
        EJackScenarioID__C100 = 50,
        EJackScenarioID__C110 = 51,
        EJackScenarioID__C120 = 52,
        EJackScenarioID__C130 = 53,
        EJackScenarioID__C140 = 54,
        EJackScenarioID__C150 = 55,
        EJackScenarioID__C160 = 56,
        EJackScenarioID__C170 = 57,
        EJackScenarioID__C180 = 58,
        EJackScenarioID__C190 = 59,
        EJackScenarioID__C200 = 60,
        EJackScenarioID__C210 = 61,
        EJackScenarioID__C220 = 62,
        EJackScenarioID__C230 = 63,
        EJackScenarioID__C240 = 64,
        EJackScenarioID__C250 = 65,
        EJackScenarioID__C260 = 66,
        EJackScenarioID__C270 = 67,
        EJackScenarioID__C280 = 68,
        EJackScenarioID__C290 = 69,
        EJackScenarioID__C300 = 70,
        EJackScenarioID__Y010 = 71,
        EJackScenarioID__NA = 72,
        EJackScenarioID__MAX = 73
    }


    // Enum JackGame.EJackScenarioGroup
    public enum EJackScenarioGroup : byte
    {
        EJackScenarioGroup__None = 0,
        EJackScenarioGroup__A = 1,
        EJackScenarioGroup__B = 2,
        EJackScenarioGroup__C = 3,
        EJackScenarioGroup__S = 4,
        EJackScenarioGroup__MAX = 5
    }


    // Enum JackGame.EJackEnlightenControlPurpose
    public enum EJackEnlightenControlPurpose : byte
    {
        EJackEnlightenControlPurpose__Battle = 0,
        EJackEnlightenControlPurpose__CutScene = 1,
        EJackEnlightenControlPurpose__MAX = 2
    }


    // Enum JackGame.EJackUMGFieldActionSoundType
    public enum EJackUMGFieldActionSoundType : byte
    {
        EJackUMGFieldActionSoundType__None = 0,
        EJackUMGFieldActionSoundType__Hoimi2 = 1,
        EJackUMGFieldActionSoundType__Zaoraru2 = 2,
        EJackUMGFieldActionSoundType__MAX = 3
    }


    // Enum JackGame.EJackLoadingScreenTips
    public enum EJackLoadingScreenTips : byte
    {
        EJackLoadingScreenTips__Group = 0,
        EJackLoadingScreenTips__Scenario = 1,
        EJackLoadingScreenTips__Level = 2,
        EJackLoadingScreenTips__MAX = 3
    }


    // Enum JackGame.EJackLoadingScreen
    public enum EJackLoadingScreen : byte
    {
        EJackLoadingScreen__Startup = 0,
        EJackLoadingScreen__TextOnly = 1,
        EJackLoadingScreen__WithProgress = 2,
        EJackLoadingScreen__WithTips = 3,
        EJackLoadingScreen__TextOnly_White = 4,
        EJackLoadingScreen__WithProgress_White = 5,
        EJackLoadingScreen__WithTips_White = 6,
        EJackLoadingScreen__Black = 7,
        EJackLoadingScreen__White = 8,
        EJackLoadingScreen__MAX = 9
    }


    // Enum JackGame.EJackPartyTalkIdleMotion
    public enum EJackPartyTalkIdleMotion : byte
    {
        EJackPartyTalkIdleMotion__Normal = 0,
        EJackPartyTalkIdleMotion__Serious = 1,
        EJackPartyTalkIdleMotion__Happy = 2,
        EJackPartyTalkIdleMotion__Angry = 3,
        EJackPartyTalkIdleMotion__Thinking = 4,
        EJackPartyTalkIdleMotion__Special = 5,
        EJackPartyTalkIdleMotion__Amnesia = 6,
        EJackPartyTalkIdleMotion__Reference = 7,
        EJackPartyTalkIdleMotion__MAX = 8
    }


    // Enum JackGame.EJackRuraOpenFlag
    public enum EJackRuraOpenFlag : byte
    {
        EJackRuraOpenFlag__Close = 0,
        EJackRuraOpenFlag__OpenUsable = 1,
        EJackRuraOpenFlag__OpenUnusable = 2,
        EJackRuraOpenFlag__MAX = 3
    }


    // Enum JackGame.EJackMonsterEmotionIcon
    public enum EJackMonsterEmotionIcon : byte
    {
        EJackMonsterEmotionIcon__Exclamation = 0,
        EJackMonsterEmotionIcon__Question = 1,
        EJackMonsterEmotionIcon__Angry = 2,
        EJackMonsterEmotionIcon__MAX = 3
    }


    // Enum JackGame.EJackActionGuideControlPurpose
    public enum EJackActionGuideControlPurpose : byte
    {
        EJackActionGuideControlPurpose__Gimmick = 0,
        EJackActionGuideControlPurpose__Interactor = 1,
        EJackActionGuideControlPurpose__InteractiveActorGroup = 2,
        EJackActionGuideControlPurpose__ActionCursor = 3,
        EJackActionGuideControlPurpose__Self = 4,
        EJackActionGuideControlPurpose__Others = 5,
        EJackActionGuideControlPurpose__Manager = 6,
        EJackActionGuideControlPurpose__MAX = 7
    }


    // Enum JackGame.EJackFukidasiDuration
    public enum EJackFukidasiDuration : byte
    {
        EJackFukidasiDuration__Normal = 0,
        EJackFukidasiDuration__Short = 1,
        EJackFukidasiDuration__MAX = 2
    }


    // Enum JackGame.EJackFukidasiType
    public enum EJackFukidasiType : byte
    {
        EJackFukidasiType__Normal = 0,
        EJackFukidasiType__MAX = 1
    }


    // Enum JackGame.EJackTextType
    public enum EJackTextType : byte
    {
        EJackTextType__None = 0,
        EJackTextType__Serifu = 1,
        EJackTextType__SerifuIE = 2,
        EJackTextType__SerifuCS = 3,
        EJackTextType__Fukidasi = 4,
        EJackTextType__SystemMessage = 5,
        EJackTextType__TenNoKoe = 6,
        EJackTextType__Arasuji = 7,
        EJackTextType__Caption = 8,
        EJackTextType__PartyTalk = 9,
        EJackTextType__TextPackCommon = 10,
        EJackTextType__TextPackScenario = 11,
        EJackTextType__Reference = 12,
        EJackTextType__NotExists = 13,
        EJackTextType__MAX = 14
    }


    // Enum JackGame.EJackTextCategory
    public enum EJackTextCategory : byte
    {
        EJackTextCategory__Test = 0,
        EJackTextCategory__Game = 1,
        EJackTextCategory__Battle = 2,
        EJackTextCategory__Menu = 3,
        EJackTextCategory__System = 4,
        EJackTextCategory__Fukidasi = 5,
        EJackTextCategory__Guide = 6,
        EJackTextCategory__MiniGame = 7,
        EJackTextCategory__Localization = 8,
        EJackTextCategory__Shop = 9,
        EJackTextCategory__Yadoya = 10,
        EJackTextCategory__Ginkou = 11,
        EJackTextCategory__Kyoukai = 12,
        EJackTextCategory__CasinoCoin = 13,
        EJackTextCategory__Medal = 14,
        EJackTextCategory__TextPack = 15,
        EJackTextCategory__IE = 16,
        EJackTextCategory__CS = 17,
        EJackTextCategory__FukidasiIE = 18,
        EJackTextCategory__RESERVED_B = 19,
        EJackTextCategory__RESERVED_C = 20,
        EJackTextCategory__RESERVED_D = 21,
        EJackTextCategory__RESERVED_E = 22,
        EJackTextCategory__ReservedFF = 23,
        EJackTextCategory__INVALID = 24,
        EJackTextCategory__MAX = 25
    }


    // Enum JackGame.EJackInputPriority
    public enum EJackInputPriority : byte
    {
        EJackInputPriority__CutScene = 0,
        EJackInputPriority__HUD = 1,
        EJackInputPriority__NakamaKaiwa = 2,
        EJackInputPriority__EndingInput = 3,
        EJackInputPriority__DebugCS = 4,
        EJackInputPriority__DebugCSExtra = 5,
        EJackInputPriority__DebugSimulation = 6,
        EJackInputPriority__MAX = 7
    }


    // Enum JackGame.EJackUIKeyGroup
    public enum EJackUIKeyGroup : byte
    {
        EJackUIKeyGroup__None = 0,
        EJackUIKeyGroup__HardButton = 1,
        EJackUIKeyGroup__HardCross = 2,
        EJackUIKeyGroup__LogicalButton = 3,
        EJackUIKeyGroup__LogicalCross = 4,
        EJackUIKeyGroup__HardLButton = 5,
        EJackUIKeyGroup__HardRButton = 6,
        EJackUIKeyGroup__MAX = 7
    }


    // Enum JackGame.EJackStreamingStatus
    public enum EJackStreamingStatus : byte
    {
        EJackStreamingStatus__Unloaded = 0,
        EJackStreamingStatus__UnloadedButStillAround = 1,
        EJackStreamingStatus__Loading = 2,
        EJackStreamingStatus__Loaded = 3,
        EJackStreamingStatus__MakingVisible = 4,
        EJackStreamingStatus__Visible = 5,
        EJackStreamingStatus__Preloading = 6,
        EJackStreamingStatus__MAX = 7
    }


    // Enum JackGame.EJackLevelStreamingRequest
    public enum EJackLevelStreamingRequest : byte
    {
        EJackLevelStreamingRequest__Unload = 0,
        EJackLevelStreamingRequest__Load = 1,
        EJackLevelStreamingRequest__BlockLoad = 2,
        EJackLevelStreamingRequest__MAX = 3
    }


    // Enum JackGame.EJackTimeDilationPurpose
    public enum EJackTimeDilationPurpose : byte
    {
        EJackTimeDilationPurpose__LVD = 0,
        EJackTimeDilationPurpose__CutScene = 1,
        EJackTimeDilationPurpose__AnimNotify = 2,
        EJackTimeDilationPurpose__HitStop = 3,
        EJackTimeDilationPurpose__MAX = 4
    }


    // Enum JackGame.EJackTutorialCategory
    public enum EJackTutorialCategory : byte
    {
        EJackTutorialCategory__Basic = 0,
        EJackTutorialCategory__Menu = 1,
        EJackTutorialCategory__Field = 2,
        EJackTutorialCategory__Battle = 3,
        EJackTutorialCategory__Item = 4,
        EJackTutorialCategory__Kaji = 5,
        EJackTutorialCategory__MiniGame = 6,
        EJackTutorialCategory__All = 7,
        EJackTutorialCategory__MAX = 8
    }


    // Enum JackGame.EJackAchievementTiming
    public enum EJackAchievementTiming : byte
    {
        EJackAchievementTiming__Playable = 0,
        EJackAchievementTiming__TokugiPanelOnly = 1,
        EJackAchievementTiming__MAX = 2
    }


    // Enum JackGame.EJackAchievementCondition
    public enum EJackAchievementCondition : byte
    {
        EJackAchievementCondition__AcquiredDirect = 0,
        EJackAchievementCondition__TokugiPanel_P001 = 1,
        EJackAchievementCondition__TokugiPanel_P002 = 2,
        EJackAchievementCondition__TokugiPanel_P003 = 3,
        EJackAchievementCondition__TokugiPanel_P004 = 4,
        EJackAchievementCondition__TokugiPanel_P005 = 5,
        EJackAchievementCondition__TokugiPanel_P006 = 6,
        EJackAchievementCondition__TokugiPanel_P007 = 7,
        EJackAchievementCondition__TokugiPanel_P008 = 8,
        EJackAchievementCondition__DefeatMonsterCount = 9,
        EJackAchievementCondition__DefeatMonsterCount_Metal = 10,
        EJackAchievementCondition__DefeatMonsterKind = 11,
        EJackAchievementCondition__BattleVictoryCount = 12,
        EJackAchievementCondition__UseTokugiCount = 13,
        EJackAchievementCondition__RenkeiUseCount = 14,
        EJackAchievementCondition__RenkeiUseKind = 15,
        EJackAchievementCondition__MonsterRenkeiExecuteKind = 16,
        EJackAchievementCondition__MonsterVehicleRideKind = 17,
        EJackAchievementCondition__BlowAwayMonsterCount = 18,
        EJackAchievementCondition__BattleCountBySwordAttack = 19,
        EJackAchievementCondition__AcquisitionItemKind = 20,
        EJackAchievementCondition__PossessionItemCount = 21,
        EJackAchievementCondition__TotalAcquisitionItemCount = 22,
        EJackAchievementCondition__UseItemCount = 23,
        EJackAchievementCondition__PossessionGold = 24,
        EJackAchievementCondition__TotalAcquisitionGold = 25,
        EJackAchievementCondition__AmountOfDeposit = 26,
        EJackAchievementCondition__CampCount = 27,
        EJackAchievementCondition__InnStayCount = 28,
        EJackAchievementCondition__ObjectDestructionCount = 29,
        EJackAchievementCondition__QuestClearCount = 30,
        EJackAchievementCondition__AchievementCount = 31,
        EJackAchievementCondition__LevelReached_P001 = 32,
        EJackAchievementCondition__LevelReached_P002 = 33,
        EJackAchievementCondition__LevelReached_P003 = 34,
        EJackAchievementCondition__LevelReached_P004 = 35,
        EJackAchievementCondition__LevelReached_P005 = 36,
        EJackAchievementCondition__LevelReached_P006 = 37,
        EJackAchievementCondition__LevelReached_P007 = 38,
        EJackAchievementCondition__LevelReached_P008 = 39,
        EJackAchievementCondition__FopperyEquip_P001 = 40,
        EJackAchievementCondition__FopperyEquip_P002 = 41,
        EJackAchievementCondition__FopperyEquip_P003 = 42,
        EJackAchievementCondition__FopperyEquip_P004 = 43,
        EJackAchievementCondition__FopperyEquip_P005 = 44,
        EJackAchievementCondition__FopperyEquip_P006 = 45,
        EJackAchievementCondition__FopperyEquip_P007 = 46,
        EJackAchievementCondition__FopperyEquip_P008 = 47,
        EJackAchievementCondition__FopperyEquip_ALL = 48,
        EJackAchievementCondition__MAX = 49
    }


    // Enum JackGame.EJackAchievementCategory
    public enum EJackAchievementCategory : byte
    {
        EJackAchievementCategory__Scenario = 0,
        EJackAchievementCategory__Battle = 1,
        EJackAchievementCategory__Kazi = 2,
        EJackAchievementCategory__Casino = 3,
        EJackAchievementCategory__Item = 4,
        EJackAchievementCategory__Etc = 5,
        EJackAchievementCategory__All = 6,
        EJackAchievementCategory__MAX = 7
    }


    // Enum JackGame.EJackAchievementRarity
    public enum EJackAchievementRarity : byte
    {
        EJackAchievementRarity__Legend = 0,
        EJackAchievementRarity__Platinum = 1,
        EJackAchievementRarity__Gold = 2,
        EJackAchievementRarity__MAX = 3
    }


    // Enum JackGame.EJackTokugiPanelScenario
    public enum EJackTokugiPanelScenario : byte
    {
        EJackTokugiPanelScenario__None = 0,
        EJackTokugiPanelScenario__P001 = 1,
        EJackTokugiPanelScenario__P00101 = 2,
        EJackTokugiPanelScenario__P00102 = 3,
        EJackTokugiPanelScenario__P00103 = 4,
        EJackTokugiPanelScenario__P00104 = 5,
        EJackTokugiPanelScenario__P002 = 6,
        EJackTokugiPanelScenario__P00201 = 7,
        EJackTokugiPanelScenario__P00202 = 8,
        EJackTokugiPanelScenario__P00203 = 9,
        EJackTokugiPanelScenario__P00204 = 10,
        EJackTokugiPanelScenario__P003 = 11,
        EJackTokugiPanelScenario__P00301 = 12,
        EJackTokugiPanelScenario__P00302 = 13,
        EJackTokugiPanelScenario__P00303 = 14,
        EJackTokugiPanelScenario__P00304 = 15,
        EJackTokugiPanelScenario__P004 = 16,
        EJackTokugiPanelScenario__P00401 = 17,
        EJackTokugiPanelScenario__P00402 = 18,
        EJackTokugiPanelScenario__P00403 = 19,
        EJackTokugiPanelScenario__P00404 = 20,
        EJackTokugiPanelScenario__P005 = 21,
        EJackTokugiPanelScenario__P00501 = 22,
        EJackTokugiPanelScenario__P00502 = 23,
        EJackTokugiPanelScenario__P00503 = 24,
        EJackTokugiPanelScenario__P00504 = 25,
        EJackTokugiPanelScenario__P006 = 26,
        EJackTokugiPanelScenario__P00601 = 27,
        EJackTokugiPanelScenario__P00602 = 28,
        EJackTokugiPanelScenario__P00603 = 29,
        EJackTokugiPanelScenario__P00604 = 30,
        EJackTokugiPanelScenario__P007 = 31,
        EJackTokugiPanelScenario__P00701 = 32,
        EJackTokugiPanelScenario__P00702 = 33,
        EJackTokugiPanelScenario__P00703 = 34,
        EJackTokugiPanelScenario__P00704 = 35,
        EJackTokugiPanelScenario__P008 = 36,
        EJackTokugiPanelScenario__P00801 = 37,
        EJackTokugiPanelScenario__P00802 = 38,
        EJackTokugiPanelScenario__P00803 = 39,
        EJackTokugiPanelScenario__P00804 = 40,
        EJackTokugiPanelScenario__MAX = 41
    }


    // Enum JackGame.EJackSkillLine
    public enum EJackSkillLine : byte
    {
        EJackSkillLine__None = 0,
        EJackSkillLine__Ken = 1,
        EJackSkillLine__Ryouteken = 2,
        EJackSkillLine__Tanken = 3,
        EJackSkillLine__Stick = 4,
        EJackSkillLine__Tue = 5,
        EJackSkillLine__Yari = 6,
        EJackSkillLine__Ono = 7,
        EJackSkillLine__Tume = 8,
        EJackSkillLine__Muti = 9,
        EJackSkillLine__Boomerang = 10,
        EJackSkillLine__Kensin = 11,
        EJackSkillLine__Yuusya = 12,
        EJackSkillLine__Kamiwaza = 13,
        EJackSkillLine__Tategoto = 14,
        EJackSkillLine__Madousyo = 15,
        EJackSkillLine__Kyokugei = 16,
        EJackSkillLine__Otome = 17,
        EJackSkillLine__Kisidou = 18,
        EJackSkillLine__Satori = 19,
        EJackSkillLine__Kakutou = 20,
        EJackSkillLine__Oiroke = 21,
        EJackSkillLine__Eiyuu = 22,
        EJackSkillLine__Hakuai = 23,
        EJackSkillLine__Tate = 24,
        EJackSkillLine__YuusyaNoKen = 25,
        EJackSkillLine__Other = 26,
        EJackSkillLine__MAX = 27
    }


    // Enum JackGame.EJackTokugiType
    public enum EJackTokugiType : byte
    {
        EJackTokugiType__Jumon = 0,
        EJackTokugiType__Active = 1,
        EJackTokugiType__Passive = 2,
        EJackTokugiType__MAX = 3
    }


    // Enum JackGame.EJackMedal_StampPage
    public enum EJackMedal_StampPage : byte
    {
        EJackMedal_StampPage__None = 0,
        EJackMedal_StampPage__Page1 = 1,
        EJackMedal_StampPage__Page2 = 2,
        EJackMedal_StampPage__Page3 = 3,
        EJackMedal_StampPage__Page4 = 4,
        EJackMedal_StampPage__MAX = 5
    }


    // Enum JackGame.EJackMedal_Trade
    public enum EJackMedal_Trade : byte
    {
        EJackMedal_Trade__Stamp = 0,
        EJackMedal_Trade__Exchange = 1,
        EJackMedal_Trade__MAX = 2
    }


    // Enum JackGame.EJackTreasureBoxPlacementCondition
    public enum EJackTreasureBoxPlacementCondition : byte
    {
        EJackTreasureBoxPlacementCondition__Initial = 0,
        EJackTreasureBoxPlacementCondition__FlagReference = 1,
        EJackTreasureBoxPlacementCondition__MAX = 2
    }


    // Enum JackGame.EJackGettableCommonPurpose
    public enum EJackGettableCommonPurpose : byte
    {
        EJackGettableCommonPurpose__BowgunTarget = 0,
        EJackGettableCommonPurpose__Etc = 1,
        EJackGettableCommonPurpose__All = 2,
        EJackGettableCommonPurpose__Undesignated = 3,
        EJackGettableCommonPurpose__MAX = 4
    }


    // Enum JackGame.EJackExchange
    public enum EJackExchange : byte
    {
        EJackExchange__Unknown = 0,
        EJackExchange__NoLimit = 1,
        EJackExchange__OnlyOne = 2,
        EJackExchange__MamonoNoLimit = 3,
        EJackExchange__MamonoOnlyOne = 4,
        EJackExchange__MAX = 5
    }


    // Enum JackGame.EJackItem_Key
    public enum EJackItem_Key : byte
    {
        EJackItem_Key__None = 0,
        EJackItem_Key__MahouNoKagi = 1,
        EJackItem_Key__SaigoNoKagi = 2,
        EJackItem_Key__DerukadaruNoKagi = 3,
        EJackItem_Key__MAX = 4
    }


    // Enum JackGame.EJackEquipmentMultiple
    public enum EJackEquipmentMultiple : byte
    {
        EJackEquipmentMultiple__Unknown = 0,
        EJackEquipmentMultiple__NG = 1,
        EJackEquipmentMultiple__OK = 2,
        EJackEquipmentMultiple__SameClassificationOnly = 3,
        EJackEquipmentMultiple__DifferentClassificationOnly = 4,
        EJackEquipmentMultiple__MAX = 5
    }


    // Enum JackGame.EJackItem_EquipmentSE
    public enum EJackItem_EquipmentSE : byte
    {
        EJackItem_EquipmentSE__Unknown = 0,
        EJackItem_EquipmentSE__Mute = 1,
        EJackItem_EquipmentSE__Default = 2,
        EJackItem_EquipmentSE__Metal = 3,
        EJackItem_EquipmentSE__Cloth = 4,
        EJackItem_EquipmentSE__MAX = 5
    }


    // Enum JackGame.EJackItem_WeaponAttackAttribute
    public enum EJackItem_WeaponAttackAttribute : byte
    {
        EJackItem_WeaponAttackAttribute__Unknown = 0,
        EJackItem_WeaponAttackAttribute__Honoo = 1,
        EJackItem_WeaponAttackAttribute__Koori = 2,
        EJackItem_WeaponAttackAttribute__Kaze = 3,
        EJackItem_WeaponAttackAttribute__Kaminari = 4,
        EJackItem_WeaponAttackAttribute__Tuti = 5,
        EJackItem_WeaponAttackAttribute__Yami = 6,
        EJackItem_WeaponAttackAttribute__Hikari = 7,
        EJackItem_WeaponAttackAttribute__Mu = 8,
        EJackItem_WeaponAttackAttribute__MAX = 9
    }


    // Enum JackGame.EJackItem_SellType
    public enum EJackItem_SellType : byte
    {
        EJackItem_SellType__Unknown = 0,
        EJackItem_SellType__NG = 1,
        EJackItem_SellType__OK = 2,
        EJackItem_SellType__NeedConfirmation1 = 3,
        EJackItem_SellType__NeedConfirmation2 = 4,
        EJackItem_SellType__MAX = 5
    }


    // Enum JackGame.EJackItem_BagSave
    public enum EJackItem_BagSave : byte
    {
        EJackItem_BagSave__Bag_Common_P001 = 0,
        EJackItem_BagSave__Bag_Common_P002 = 1,
        EJackItem_BagSave__Bag_Common_P005 = 2,
        EJackItem_BagSave__Bag_Common_P006 = 3,
        EJackItem_BagSave__Bag_Common_P007 = 4,
        EJackItem_BagSave__Bag_Equipment_P001 = 5,
        EJackItem_BagSave__Bag_Equipment_P002 = 6,
        EJackItem_BagSave__Bag_Equipment_P005 = 7,
        EJackItem_BagSave__Bag_Equipment_P006 = 8,
        EJackItem_BagSave__Bag_Equipment_P007 = 9,
        EJackItem_BagSave__Bag_Daizinamono_P001 = 10,
        EJackItem_BagSave__Bag_Daizinamono_P002 = 11,
        EJackItem_BagSave__Bag_Daizinamono_P005 = 12,
        EJackItem_BagSave__Bag_Daizinamono_P006 = 13,
        EJackItem_BagSave__Bag_Daizinamono_P007 = 14,
        EJackItem_BagSave__Bag_Exchange_P001 = 15,
        EJackItem_BagSave__Bag_Exchange_P002 = 16,
        EJackItem_BagSave__Bag_Exchange_P005 = 17,
        EJackItem_BagSave__Bag_Exchange_P006 = 18,
        EJackItem_BagSave__Bag_Exchange_P007 = 19,
        EJackItem_BagSave__MAX = 20
    }


    // Enum JackGame.EJackSenreki_ItemCategory
    public enum EJackSenreki_ItemCategory : byte
    {
        EJackSenreki_ItemCategory__Unknown = 0,
        EJackSenreki_ItemCategory__Buki = 1,
        EJackSenreki_ItemCategory__Bougu = 2,
        EJackSenreki_ItemCategory__Accessory = 3,
        EJackSenreki_ItemCategory__Dougu = 4,
        EJackSenreki_ItemCategory__Material = 5,
        EJackSenreki_ItemCategory__RecipeBook = 6,
        EJackSenreki_ItemCategory__Daizinamono = 7,
        EJackSenreki_ItemCategory__All = 8,
        EJackSenreki_ItemCategory__MAX = 9
    }


    // Enum JackGame.EJackNPCAttachmentType
    public enum EJackNPCAttachmentType : byte
    {
        EJackNPCAttachmentType__VisibleDaytimeOnly = 0,
        EJackNPCAttachmentType__VisibleNightOnly = 1,
        EJackNPCAttachmentType__Visible = 2,
        EJackNPCAttachmentType__Invisible = 3,
        EJackNPCAttachmentType__EJackNPCAttachmentType_MAX = 4
    }


    // Enum JackGame.EJackNPCImportance
    public enum EJackNPCImportance : byte
    {
        EJackNPCImportance__NotTalk = 0,
        EJackNPCImportance__Normal = 1,
        EJackNPCImportance__Quest = 2,
        EJackNPCImportance__ScenarioGuide = 3,
        EJackNPCImportance__Nakama = 4,
        EJackNPCImportance__EJackNPCImportance_MAX = 5
    }


    // Enum JackGame.EJackNPCTalkGazeMode
    public enum EJackNPCTalkGazeMode : byte
    {
        EJackNPCTalkGazeMode__Turn = 0,
        EJackNPCTalkGazeMode__LookAt1Bone = 1,
        EJackNPCTalkGazeMode__LookAt2Bone = 2,
        EJackNPCTalkGazeMode__TurnAndLookAt1Bone = 3,
        EJackNPCTalkGazeMode__TurnAndLookAt2Bone = 4,
        EJackNPCTalkGazeMode__Ignore = 5,
        EJackNPCTalkGazeMode__EJackNPCTalkGazeMode_MAX = 6
    }


    // Enum JackGame.EJackNPCTalkMode
    public enum EJackNPCTalkMode : byte
    {
        EJackNPCTalkMode__NotTalk = 0,
        EJackNPCTalkMode__TalkStart = 1,
        EJackNPCTalkMode__TalkSequence = 2,
        EJackNPCTalkMode__TalkEnd = 3,
        EJackNPCTalkMode__EJackNPCTalkMode_MAX = 4
    }


    // Enum JackGame.EJackNPCInterruptAccept
    public enum EJackNPCInterruptAccept : byte
    {
        EJackNPCInterruptAccept__Talk = 0,
        EJackNPCInterruptAccept__PlayerAvoid = 1,
        EJackNPCInterruptAccept__EscapeFastMoving = 2,
        EJackNPCInterruptAccept__ReactionAroundPlayer = 3,
        EJackNPCInterruptAccept__StopAtPlayerForTalk = 4,
        EJackNPCInterruptAccept__Ignore = 5,
        EJackNPCInterruptAccept__Uso = 6,
        EJackNPCInterruptAccept__EJackNPCInterruptAccept_MAX = 7
    }


    // Enum JackGame.EJackNPCReactionExternalTrigger
    public enum EJackNPCReactionExternalTrigger : byte
    {
        EJackNPCReactionExternalTrigger__CrushObject = 0,
        EJackNPCReactionExternalTrigger__OpenCloset = 1,
        EJackNPCReactionExternalTrigger__OpenTreasureBox = 2,
        EJackNPCReactionExternalTrigger__MAX = 3
    }


    // Enum JackGame.EJackNPCType
    public enum EJackNPCType : byte
    {
        EJackNPCType__N001 = 0,
        EJackNPCType__N002 = 1,
        EJackNPCType__N003 = 2,
        EJackNPCType__N004 = 3,
        EJackNPCType__N006 = 4,
        EJackNPCType__N007 = 5,
        EJackNPCType__N008 = 6,
        EJackNPCType__N009 = 7,
        EJackNPCType__N010 = 8,
        EJackNPCType__N011 = 9,
        EJackNPCType__N012 = 10,
        EJackNPCType__N013 = 11,
        EJackNPCType__N014 = 12,
        EJackNPCType__N015 = 13,
        EJackNPCType__N101 = 14,
        EJackNPCType__N102 = 15,
        EJackNPCType__N103 = 16,
        EJackNPCType__N109 = 17,
        EJackNPCType__N104 = 18,
        EJackNPCType__N105 = 19,
        EJackNPCType__N106 = 20,
        EJackNPCType__N107 = 21,
        EJackNPCType__N108 = 22,
        EJackNPCType__N201 = 23,
        EJackNPCType__N202 = 24,
        EJackNPCType__N203 = 25,
        EJackNPCType__N204 = 26,
        EJackNPCType__N205 = 27,
        EJackNPCType__A001 = 28,
        EJackNPCType__A002 = 29,
        EJackNPCType__A003 = 30,
        EJackNPCType__A004 = 31,
        EJackNPCType__A006 = 32,
        EJackNPCType__A007 = 33,
        EJackNPCType__A008 = 34,
        EJackNPCType__A013 = 35,
        EJackNPCType__A019 = 36,
        EJackNPCType__A020 = 37,
        EJackNPCType__A021 = 38,
        EJackNPCType__A023 = 39,
        EJackNPCType__A025 = 40,
        EJackNPCType__A026 = 41,
        EJackNPCType__A035 = 42,
        EJackNPCType__A036 = 43,
        EJackNPCType__A051 = 44,
        EJackNPCType__A052 = 45,
        EJackNPCType__M005 = 46,
        EJackNPCType__M014 = 47,
        EJackNPCType__M015 = 48,
        EJackNPCType__M022 = 49,
        EJackNPCType__M031 = 50,
        EJackNPCType__M034 = 51,
        EJackNPCType__M036 = 52,
        EJackNPCType__M043 = 53,
        EJackNPCType__M052 = 54,
        EJackNPCType__M057 = 55,
        EJackNPCType__M068 = 56,
        EJackNPCType__M112 = 57,
        EJackNPCType__M125 = 58,
        EJackNPCType__M152 = 59,
        EJackNPCType__M203 = 60,
        EJackNPCType__M504 = 61,
        EJackNPCType__M505 = 62,
        EJackNPCType__M515 = 63,
        EJackNPCType__M525 = 64,
        EJackNPCType__M526 = 65,
        EJackNPCType__M527 = 66,
        EJackNPCType__M530 = 67,
        EJackNPCType__M539 = 68,
        EJackNPCType__M543 = 69,
        EJackNPCType__M545 = 70,
        EJackNPCType__M548 = 71,
        EJackNPCType__M551 = 72,
        EJackNPCType__M560 = 73,
        EJackNPCType__M567 = 74,
        EJackNPCType__M572 = 75,
        EJackNPCType__MAX = 76
    }


    // Enum JackGame.EJackSheatheStatus
    public enum EJackSheatheStatus : byte
    {
        EJackSheatheStatus__Sheathe = 0,
        EJackSheatheStatus__Unsheathe = 1,
        EJackSheatheStatus__MAX = 2
    }


    // Enum JackGame.EJackEquippedHand
    public enum EJackEquippedHand : byte
    {
        EJackEquippedHand__Hand_L = 0,
        EJackEquippedHand__Hand_R = 1,
        EJackEquippedHand__MAX = 2
    }


    // Enum JackGame.EJackWeapon
    public enum EJackWeapon : byte
    {
        EJackWeapon__None = 0,
        EJackWeapon__MAX = 1
    }


    // Enum JackGame.EJackHitStopType
    public enum EJackHitStopType : byte
    {
        EJackHitStopType__None = 0,
        EJackHitStopType__SS = 1,
        EJackHitStopType__S = 2,
        EJackHitStopType__M = 3,
        EJackHitStopType__L = 4,
        EJackHitStopType__LL = 5,
        EJackHitStopType__UN1 = 6,
        EJackHitStopType__UN2 = 7,
        EJackHitStopType__MAX = 8
    }


    // Enum JackGame.EJackPlayerAIActionCategory
    public enum EJackPlayerAIActionCategory : byte
    {
        EJackPlayerAIActionCategory__None = 0,
        EJackPlayerAIActionCategory__Attack = 1,
        EJackPlayerAIActionCategory__Spell = 2,
        EJackPlayerAIActionCategory__Skill = 3,
        EJackPlayerAIActionCategory__Renkei = 4,
        EJackPlayerAIActionCategory__Item = 5,
        EJackPlayerAIActionCategory__MAX = 6
    }


    // Enum JackGame.EJackPlayerAIActionControl
    public enum EJackPlayerAIActionControl : byte
    {
        EJackPlayerAIActionControl__None = 0,
        EJackPlayerAIActionControl__Defense = 1,
        EJackPlayerAIActionControl__Attack = 2,
        EJackPlayerAIActionControl__AttackMp0 = 3,
        EJackPlayerAIActionControl__AttackNormal = 4,
        EJackPlayerAIActionControl__Heal = 5,
        EJackPlayerAIActionControl__HealMP = 6,
        EJackPlayerAIActionControl__Revive = 7,
        EJackPlayerAIActionControl__Cure = 8,
        EJackPlayerAIActionControl__AttackDeath = 9,
        EJackPlayerAIActionControl__Confuse = 10,
        EJackPlayerAIActionControl__Sleep = 11,
        EJackPlayerAIActionControl__SkipTurn = 12,
        EJackPlayerAIActionControl__Bewitching = 13,
        EJackPlayerAIActionControl__Charm = 14,
        EJackPlayerAIActionControl__SurvivalHp1 = 15,
        EJackPlayerAIActionControl__Zone = 16,
        EJackPlayerAIActionControl__Counter = 17,
        EJackPlayerAIActionControl__LadyFirst = 18,
        EJackPlayerAIActionControl__IceWave = 19,
        EJackPlayerAIActionControl__Steal = 20,
        EJackPlayerAIActionControl__Nioudati = 21,
        EJackPlayerAIActionControl__Kabau = 22,
        EJackPlayerAIActionControl__RunawayRateUp = 23,
        EJackPlayerAIActionControl__Doku = 24,
        EJackPlayerAIActionControl__Mahoton = 25,
        EJackPlayerAIActionControl__Megazaru = 26,
        EJackPlayerAIActionControl__Asutoron = 27,
        EJackPlayerAIActionControl__Mahokanta = 28,
        EJackPlayerAIActionControl__Zibaria = 29,
        EJackPlayerAIActionControl__DefenseUp = 30,
        EJackPlayerAIActionControl__DefenseDown = 31,
        EJackPlayerAIActionControl__AttackUp = 32,
        EJackPlayerAIActionControl__AttackDown = 33,
        EJackPlayerAIActionControl__SpeedUp = 34,
        EJackPlayerAIActionControl__SpeedDown = 35,
        EJackPlayerAIActionControl__SpellResistUp = 36,
        EJackPlayerAIActionControl__SpellResistDown = 37,
        EJackPlayerAIActionControl__AttackSpellUp = 38,
        EJackPlayerAIActionControl__HealSpellUp = 39,
        EJackPlayerAIActionControl__BlessResistUp = 40,
        EJackPlayerAIActionControl__AttributeUp = 41,
        EJackPlayerAIActionControl__MAX = 42
    }


    // Enum JackGame.EJackHitCameraShakePresetType
    public enum EJackHitCameraShakePresetType : byte
    {
        EJackHitCameraShakePresetType__None = 0,
        EJackHitCameraShakePresetType__N_SS = 1,
        EJackHitCameraShakePresetType__N_S = 2,
        EJackHitCameraShakePresetType__N_M = 3,
        EJackHitCameraShakePresetType__N_L = 4,
        EJackHitCameraShakePresetType__N_LL = 5,
        EJackHitCameraShakePresetType__SS_SS = 6,
        EJackHitCameraShakePresetType__SS_S = 7,
        EJackHitCameraShakePresetType__SS_M = 8,
        EJackHitCameraShakePresetType__SS_L = 9,
        EJackHitCameraShakePresetType__SS_LL = 10,
        EJackHitCameraShakePresetType__S_S = 11,
        EJackHitCameraShakePresetType__S_M = 12,
        EJackHitCameraShakePresetType__S_L = 13,
        EJackHitCameraShakePresetType__S_LL = 14,
        EJackHitCameraShakePresetType__M_M = 15,
        EJackHitCameraShakePresetType__M_L = 16,
        EJackHitCameraShakePresetType__M_LL = 17,
        EJackHitCameraShakePresetType__L_L = 18,
        EJackHitCameraShakePresetType__L_LL = 19,
        EJackHitCameraShakePresetType__LL_LL = 20,
        EJackHitCameraShakePresetType__UN1 = 21,
        EJackHitCameraShakePresetType__UN2 = 22,
        EJackHitCameraShakePresetType__MAX = 23
    }


    // Enum JackGame.EJackPlayerAIFlowControl
    public enum EJackPlayerAIFlowControl : byte
    {
        EJackPlayerAIFlowControl__None = 0,
        EJackPlayerAIFlowControl__Action = 1,
        EJackPlayerAIFlowControl__Add = 2,
        EJackPlayerAIFlowControl__Select = 3,
        EJackPlayerAIFlowControl__End = 4,
        EJackPlayerAIFlowControl__MAX = 5
    }


    // Enum JackGame.EJackPlayerAIFlowJudge
    public enum EJackPlayerAIFlowJudge : byte
    {
        EJackPlayerAIFlowJudge__AlwaysTrue = 0,
        EJackPlayerAIFlowJudge__CaseP001 = 1,
        EJackPlayerAIFlowJudge__CaseP002 = 2,
        EJackPlayerAIFlowJudge__CaseP003 = 3,
        EJackPlayerAIFlowJudge__CaseP004 = 4,
        EJackPlayerAIFlowJudge__CaseP005 = 5,
        EJackPlayerAIFlowJudge__CaseP006 = 6,
        EJackPlayerAIFlowJudge__CaseP007 = 7,
        EJackPlayerAIFlowJudge__CaseP008 = 8,
        EJackPlayerAIFlowJudge__EventBattle = 9,
        EJackPlayerAIFlowJudge__MonsterM716_E001_S01 = 10,
        EJackPlayerAIFlowJudge__MonsterM601_E001_S01 = 11,
        EJackPlayerAIFlowJudge__MonsterM602_E001_S01 = 12,
        EJackPlayerAIFlowJudge__MonsterM603_E001_S01 = 13,
        EJackPlayerAIFlowJudge__MonsterM605_E001_S01 = 14,
        EJackPlayerAIFlowJudge__MonsterM606_E001_S01 = 15,
        EJackPlayerAIFlowJudge__MonsterM607_E001_S01 = 16,
        EJackPlayerAIFlowJudge__MonsterM611_E001_S01 = 17,
        EJackPlayerAIFlowJudge__MonsterM615_E001_S01 = 18,
        EJackPlayerAIFlowJudge__MonsterM616_E001_S01 = 19,
        EJackPlayerAIFlowJudge__PlayerDeadNum = 20,
        EJackPlayerAIFlowJudge__Dying10Percent = 21,
        EJackPlayerAIFlowJudge__Dying20Percent = 22,
        EJackPlayerAIFlowJudge__Dying30Percent = 23,
        EJackPlayerAIFlowJudge__Dying40Percent = 24,
        EJackPlayerAIFlowJudge__Dying50Percent = 25,
        EJackPlayerAIFlowJudge__Dying60Percent = 26,
        EJackPlayerAIFlowJudge__Dying70Percent = 27,
        EJackPlayerAIFlowJudge__Dying80Percent = 28,
        EJackPlayerAIFlowJudge__Dying90Percent = 29,
        EJackPlayerAIFlowJudge__AbnormalVarious = 30,
        EJackPlayerAIFlowJudge__AbnormalDazzle = 31,
        EJackPlayerAIFlowJudge__AbnormalPoison = 32,
        EJackPlayerAIFlowJudge__AbnormalVenom = 33,
        EJackPlayerAIFlowJudge__EnemyWeak = 34,
        EJackPlayerAIFlowJudge__EnemyWeakMaybe = 35,
        EJackPlayerAIFlowJudge__EnemyMany = 36,
        EJackPlayerAIFlowJudge__EnemyStrong = 37,
        EJackPlayerAIFlowJudge__EnemyVeryStrong = 38,
        EJackPlayerAIFlowJudge__EnemyMetalExist = 39,
        EJackPlayerAIFlowJudge__EnableFubaha = 40,
        EJackPlayerAIFlowJudge__EnableMahoton = 41,
        EJackPlayerAIFlowJudge__EnableManusa = 42,
        EJackPlayerAIFlowJudge__EnableRukani = 43,
        EJackPlayerAIFlowJudge__EnableMagicbarrier = 44,
        EJackPlayerAIFlowJudge__EnableBikiruto = 45,
        EJackPlayerAIFlowJudge__EnableHenatosu = 46,
        EJackPlayerAIFlowJudge__EnableStrengthenSpell = 47,
        EJackPlayerAIFlowJudge__EnableGiveAttribute = 48,
        EJackPlayerAIFlowJudge__EnableIceWave = 49,
        EJackPlayerAIFlowJudge__CheckBougyo = 50,
        EJackPlayerAIFlowJudge__CheckSukara = 51,
        EJackPlayerAIFlowJudge__CheckUseIceWave = 52,
        EJackPlayerAIFlowJudge__UseMegazaru = 53,
        EJackPlayerAIFlowJudge__Can50EnemyAct = 54,
        EJackPlayerAIFlowJudge__MAX = 55
    }


    // Enum JackGame.EJackNusumuResultType
    public enum EJackNusumuResultType : byte
    {
        EJackNusumuResultType__Failure = 0,
        EJackNusumuResultType__Success = 1,
        EJackNusumuResultType__Nothing = 2,
        EJackNusumuResultType__RemainingRare = 3,
        EJackNusumuResultType__MAX = 4
    }


    // Enum JackGame.EJackBattleFirstCameraTarget
    public enum EJackBattleFirstCameraTarget : byte
    {
        EJackBattleFirstCameraTarget__EnemyGroup = 0,
        EJackBattleFirstCameraTarget__FieldCenter = 1,
        EJackBattleFirstCameraTarget__EnemyCenter = 2,
        EJackBattleFirstCameraTarget__MAX = 3
    }


    // Enum JackGame.EJackMatineeRenkeiMonsterSize
    public enum EJackMatineeRenkeiMonsterSize : byte
    {
        EJackMatineeRenkeiMonsterSize__S = 0,
        EJackMatineeRenkeiMonsterSize__M = 1,
        EJackMatineeRenkeiMonsterSize__L = 2,
        EJackMatineeRenkeiMonsterSize__SP01 = 3,
        EJackMatineeRenkeiMonsterSize__SP02 = 4,
        EJackMatineeRenkeiMonsterSize__SP03 = 5,
        EJackMatineeRenkeiMonsterSize__SP04 = 6,
        EJackMatineeRenkeiMonsterSize__SP05 = 7,
        EJackMatineeRenkeiMonsterSize__SP06 = 8,
        EJackMatineeRenkeiMonsterSize__SP07 = 9,
        EJackMatineeRenkeiMonsterSize__SP08 = 10,
        EJackMatineeRenkeiMonsterSize__SP09 = 11,
        EJackMatineeRenkeiMonsterSize__SP10 = 12,
        EJackMatineeRenkeiMonsterSize__SP11 = 13,
        EJackMatineeRenkeiMonsterSize__SP12 = 14,
        EJackMatineeRenkeiMonsterSize__MAX = 15
    }


    // Enum JackGame.EJackBattleRenkeiFormationGroupDirection
    public enum EJackBattleRenkeiFormationGroupDirection : byte
    {
        EJackBattleRenkeiFormationGroupDirection__FieldCenter = 0,
        EJackBattleRenkeiFormationGroupDirection__GroupCenter = 1,
        EJackBattleRenkeiFormationGroupDirection__MAX = 2
    }


    // Enum JackGame.EJackBattleRenkeiFormationDirection
    public enum EJackBattleRenkeiFormationDirection : byte
    {
        EJackBattleRenkeiFormationDirection__Target = 0,
        EJackBattleRenkeiFormationDirection__TargetGroup = 1,
        EJackBattleRenkeiFormationDirection__FieldCenter = 2,
        EJackBattleRenkeiFormationDirection__Alignment = 3,
        EJackBattleRenkeiFormationDirection__VirtualTargetLocation = 4,
        EJackBattleRenkeiFormationDirection__MAX = 5
    }


    // Enum JackGame.EJackBattleRenkeiTiming
    public enum EJackBattleRenkeiTiming : byte
    {
        EJackBattleRenkeiTiming__RenkeiStart = 0,
        EJackBattleRenkeiTiming__RenkeiEnd = 1,
        EJackBattleRenkeiTiming__ActionStart = 2,
        EJackBattleRenkeiTiming__ActionEnd = 3,
        EJackBattleRenkeiTiming__ActionHit = 4,
        EJackBattleRenkeiTiming__ActionHitEnd = 5,
        EJackBattleRenkeiTiming__MAX = 6
    }


    // Enum JackGame.EJackBattleGroupConditionsBack
    public enum EJackBattleGroupConditionsBack : byte
    {
        EJackBattleGroupConditionsBack__Troop = 0,
        EJackBattleGroupConditionsBack__Group = 1,
        EJackBattleGroupConditionsBack__InitialPosition = 2,
        EJackBattleGroupConditionsBack__MAX = 3
    }


    // Enum JackGame.EJackBattleTurnDirection
    public enum EJackBattleTurnDirection : byte
    {
        EJackBattleTurnDirection__None = 0,
        EJackBattleTurnDirection__GroupAngle = 1,
        EJackBattleTurnDirection__TroopAngle = 2,
        EJackBattleTurnDirection__OpponentTroop = 3,
        EJackBattleTurnDirection__Target = 4,
        EJackBattleTurnDirection__Enemy = 5,
        EJackBattleTurnDirection__GoodVibes = 6,
        EJackBattleTurnDirection__MAX = 7
    }


    // Enum JackGame.EJackBattleMoveGroup
    public enum EJackBattleMoveGroup : byte
    {
        EJackBattleMoveGroup__None = 0,
        EJackBattleMoveGroup__Player = 1,
        EJackBattleMoveGroup__AvoidancePlayer = 2,
        EJackBattleMoveGroup__MAX = 3
    }


    // Enum JackGame.EJackBattleFreeMoveType
    public enum EJackBattleFreeMoveType : byte
    {
        EJackBattleFreeMoveType__None = 0,
        EJackBattleFreeMoveType__FreeMove = 1,
        EJackBattleFreeMoveType__ReturnToOriginLocation = 2,
        EJackBattleFreeMoveType__MAX = 3
    }


    // Enum JackGame.EJackOddEffectParameterDisplayType
    public enum EJackOddEffectParameterDisplayType : byte
    {
        EJackOddEffectParameterDisplayType__None = 0,
        EJackOddEffectParameterDisplayType__Default = 1,
        EJackOddEffectParameterDisplayType__Percent = 2,
        EJackOddEffectParameterDisplayType__MAX = 3
    }


    // Enum JackGame.EJackBattleGroupAlignmentSequence
    public enum EJackBattleGroupAlignmentSequence : byte
    {
        EJackBattleGroupAlignmentSequence__None = 0,
        EJackBattleGroupAlignmentSequence__SizeRatio = 1,
        EJackBattleGroupAlignmentSequence__SizeRatioMultiplier = 2,
        EJackBattleGroupAlignmentSequence__SizeRatioAndDummy = 3,
        EJackBattleGroupAlignmentSequence__MAX = 4
    }


    // Enum JackGame.EJackActionDamageKnockBackStatus
    public enum EJackActionDamageKnockBackStatus : byte
    {
        EJackActionDamageKnockBackStatus__DamageSS = 0,
        EJackActionDamageKnockBackStatus__DamageS = 1,
        EJackActionDamageKnockBackStatus__Blow = 2,
        EJackActionDamageKnockBackStatus__MAX = 3
    }


    // Enum JackGame.EJackActionDamageBlowState
    public enum EJackActionDamageBlowState : byte
    {
        EJackActionDamageBlowState__Small = 0,
        EJackActionDamageBlowState__Normal = 1,
        EJackActionDamageBlowState__Big = 2,
        EJackActionDamageBlowState__None = 3,
        EJackActionDamageBlowState__MAX = 4
    }


    // Enum JackGame.EJackReviveRequestType
    public enum EJackReviveRequestType : byte
    {
        EJackReviveRequestType__None = 0,
        EJackReviveRequestType__NormalRevive = 1,
        EJackReviveRequestType__TensiRevive = 2,
        EJackReviveRequestType__BunnyRevive = 3,
        EJackReviveRequestType__MAX = 4
    }


    // Enum JackGame.EJackDeadRequestType
    public enum EJackDeadRequestType : byte
    {
        EJackDeadRequestType__None = 0,
        EJackDeadRequestType__NormalDead = 1,
        EJackDeadRequestType__SelfDead = 2,
        EJackDeadRequestType__CoverDead = 3,
        EJackDeadRequestType__MAX = 4
    }


    // Enum JackGame.EJackBattleABPFlag
    public enum EJackBattleABPFlag : byte
    {
        EJackBattleABPFlag__None = 0,
        EJackBattleABPFlag__SkipAnimOpenWeapon = 1,
        EJackBattleABPFlag__EquipChange = 2,
        EJackBattleABPFlag__EquipChangeFlip = 3,
        EJackBattleABPFlag__WeaponStyleChange = 4,
        EJackBattleABPFlag__MAX = 5
    }


    // Enum JackGame.EJackBattleABPState
    public enum EJackBattleABPState : byte
    {
        EJackBattleABPState__None = 0,
        EJackBattleABPState__Unsheathe = 1,
        EJackBattleABPState__Sheathe = 2,
        EJackBattleABPState__Idle = 3,
        EJackBattleABPState__BougyoStart = 4,
        EJackBattleABPState__BougyoIdle = 5,
        EJackBattleABPState__MAX = 6
    }


    // Enum JackGame.EJackOddEffectTuyosaDisplayType
    public enum EJackOddEffectTuyosaDisplayType : byte
    {
        EJackOddEffectTuyosaDisplayType__None = 0,
        EJackOddEffectTuyosaDisplayType__Kobetu = 1,
        EJackOddEffectTuyosaDisplayType__Gassan = 2,
        EJackOddEffectTuyosaDisplayType__MAX = 3
    }


    // Enum JackGame.EJackBattleMemberChangeType
    public enum EJackBattleMemberChangeType : byte
    {
        EJackBattleMemberChangeType__Turn = 0,
        EJackBattleMemberChangeType__BattleStartMenu = 1,
        EJackBattleMemberChangeType__Zenmetu = 2,
        EJackBattleMemberChangeType__MAX = 3
    }


    // Enum JackGame.EJackBattlePrgCameraRect
    public enum EJackBattlePrgCameraRect : byte
    {
        EJackBattlePrgCameraRect__None = 0,
        EJackBattlePrgCameraRect__Face = 1,
        EJackBattlePrgCameraRect__Body = 2,
        EJackBattlePrgCameraRect__Motion = 3,
        EJackBattlePrgCameraRect__Low = 4,
        EJackBattlePrgCameraRect__MAX = 5
    }


    // Enum JackGame.EJackEventBattleAppearLine
    public enum EJackEventBattleAppearLine : byte
    {
        EJackEventBattleAppearLine__Default = 0,
        EJackEventBattleAppearLine__Line = 1,
        EJackEventBattleAppearLine__Line01 = 2,
        EJackEventBattleAppearLine__MAX = 3
    }


    // Enum JackGame.EJackBattleNigeruConditionType
    public enum EJackBattleNigeruConditionType : byte
    {
        EJackBattleNigeruConditionType__Default = 0,
        EJackBattleNigeruConditionType__Invalid = 1,
        EJackBattleNigeruConditionType__AlwaysSuccess = 2,
        EJackBattleNigeruConditionType__MAX = 3
    }


    // Enum JackGame.EJackEventBattleRaidState
    public enum EJackEventBattleRaidState : byte
    {
        EJackEventBattleRaidState__None = 0,
        EJackEventBattleRaidState__Monster = 1,
        EJackEventBattleRaidState__Player = 2,
        EJackEventBattleRaidState__Normal = 3,
        EJackEventBattleRaidState__MAX = 4
    }


    // Enum JackGame.EJackNakamaYobiSpawnLocationType
    public enum EJackNakamaYobiSpawnLocationType : byte
    {
        EJackNakamaYobiSpawnLocationType__None = 0,
        EJackNakamaYobiSpawnLocationType__Caster = 1,
        EJackNakamaYobiSpawnLocationType__BattleFieldCenter = 2,
        EJackNakamaYobiSpawnLocationType__Group = 3,
        EJackNakamaYobiSpawnLocationType__MAX = 4
    }


    // Enum JackGame.EJackHP1NokoriType
    public enum EJackHP1NokoriType : byte
    {
        EJackHP1NokoriType__None = 0,
        EJackHP1NokoriType__Seijonomamori = 1,
        EJackHP1NokoriType__Megaminosyukufuku = 2,
        EJackHP1NokoriType__MAX = 3
    }


    // Enum JackGame.EJackKonranKoudouType
    public enum EJackKonranKoudouType : byte
    {
        EJackKonranKoudouType__NanimoSinai = 0,
        EJackKonranKoudouType__KougekiEnemy = 1,
        EJackKonranKoudouType__KougekiSelf = 2,
        EJackKonranKoudouType__KougekiFriend = 3,
        EJackKonranKoudouType__MAX = 4
    }


    // Enum JackGame.EJackBattleMessageCompactSubType
    public enum EJackBattleMessageCompactSubType : byte
    {
        EJackBattleMessageCompactSubType__None = 0,
        EJackBattleMessageCompactSubType__Nioudati = 1,
        EJackBattleMessageCompactSubType__Kabau = 2,
        EJackBattleMessageCompactSubType__Mahokanta = 3,
        EJackBattleMessageCompactSubType__Ukenagasi = 4,
        EJackBattleMessageCompactSubType__Morobagiri = 5,
        EJackBattleMessageCompactSubType__Yaibanoyoroi = 6,
        EJackBattleMessageCompactSubType__MAX = 7
    }


    // Enum JackGame.EJackBattleMessageCompactType
    public enum EJackBattleMessageCompactType : byte
    {
        EJackBattleMessageCompactType__None = 0,
        EJackBattleMessageCompactType__HPDamage = 1,
        EJackBattleMessageCompactType__HPHeal = 2,
        EJackBattleMessageCompactType__MPDamage = 3,
        EJackBattleMessageCompactType__MPHeal = 4,
        EJackBattleMessageCompactType__HPMPHeal = 5,
        EJackBattleMessageCompactType__DamageMiss = 6,
        EJackBattleMessageCompactType__TaiseiDamageMiss = 7,
        EJackBattleMessageCompactType__KoudouMukou = 8,
        EJackBattleMessageCompactType__OddEffectSet = 9,
        EJackBattleMessageCompactType__OddEffectOverlap = 10,
        EJackBattleMessageCompactType__OddEffectClear = 11,
        EJackBattleMessageCompactType__OddEffectMiss = 12,
        EJackBattleMessageCompactType__Dead = 13,
        EJackBattleMessageCompactType__SlideUp = 14,
        EJackBattleMessageCompactType__SlideDown = 15,
        EJackBattleMessageCompactType__SlideKeepUp = 16,
        EJackBattleMessageCompactType__SlideKeepDown = 17,
        EJackBattleMessageCompactType__SlideClear = 18,
        EJackBattleMessageCompactType__SlideMiss = 19,
        EJackBattleMessageCompactType__SindoLimit = 20,
        EJackBattleMessageCompactType__SindoKeep = 21,
        EJackBattleMessageCompactType__Critical = 22,
        EJackBattleMessageCompactType__HazukasiiNoroi = 23,
        EJackBattleMessageCompactType__Zibaria = 24,
        EJackBattleMessageCompactType__Nakamayobi = 25,
        EJackBattleMessageCompactType__StackAll = 26,
        EJackBattleMessageCompactType__BluePrint = 27,
        EJackBattleMessageCompactType__JumonHansya = 28,
        EJackBattleMessageCompactType__OddEffectMukou = 29,
        EJackBattleMessageCompactType__MAX = 30
    }


    // Enum JackGame.EJackBattleMessageNoun
    public enum EJackBattleMessageNoun : byte
    {
        EJackBattleMessageNoun__None = 0,
        EJackBattleMessageNoun__Player = 1,
        EJackBattleMessageNoun__Monster = 2,
        EJackBattleMessageNoun__MAX = 3
    }


    // Enum JackGame.EJackActionFieldTextType
    public enum EJackActionFieldTextType : byte
    {
        EJackActionFieldTextType__None = 0,
        EJackActionFieldTextType__Koudou = 1,
        EJackActionFieldTextType__Yuukou = 2,
        EJackActionFieldTextType__YuukouMultiple = 3,
        EJackActionFieldTextType__YuukouOdd = 4,
        EJackActionFieldTextType__YuukouHpOdd = 5,
        EJackActionFieldTextType__Sippai = 6,
        EJackActionFieldTextType__Mukou = 7,
        EJackActionFieldTextType__YuukouHakai = 8,
        EJackActionFieldTextType__MAX = 9
    }


    // Enum JackGame.EJackActionMessageCategory
    public enum EJackActionMessageCategory : byte
    {
        EJackActionMessageCategory__None = 0,
        EJackActionMessageCategory__Default = 1,
        EJackActionMessageCategory__Koudou = 2,
        EJackActionMessageCategory__Hit = 3,
        EJackActionMessageCategory__MAX = 4
    }


    // Enum JackGame.EJackActionSoundType
    public enum EJackActionSoundType : byte
    {
        EJackActionSoundType__None = 0,
        EJackActionSoundType__Kougeki = 1,
        EJackActionSoundType__Jumon = 2,
        EJackActionSoundType__MAX = 3
    }


    // Enum JackGame.EJackActionMonsterRaceTokkouType
    public enum EJackActionMonsterRaceTokkouType : byte
    {
        EJackActionMonsterRaceTokkouType__None = 0,
        EJackActionMonsterRaceTokkouType__ActionAndWeapon = 1,
        EJackActionMonsterRaceTokkouType__ActionOnly = 2,
        EJackActionMonsterRaceTokkouType__MAX = 3
    }


    // Enum JackGame.EJackActionTuikaKoukaType
    public enum EJackActionTuikaKoukaType : byte
    {
        EJackActionTuikaKoukaType__None = 0,
        EJackActionTuikaKoukaType__First = 1,
        EJackActionTuikaKoukaType__All = 2,
        EJackActionTuikaKoukaType__MAX = 3
    }


    // Enum JackGame.EJackActionCriticalType
    public enum EJackActionCriticalType : byte
    {
        EJackActionCriticalType__None = 0,
        EJackActionCriticalType__KougekiTantai = 1,
        EJackActionCriticalType__KougekiHani = 2,
        EJackActionCriticalType__JumonTokugi = 3,
        EJackActionCriticalType__LargeDamage = 4,
        EJackActionCriticalType__Kaifuku = 5,
        EJackActionCriticalType__YuukouKakuritu = 6,
        EJackActionCriticalType__MAX = 7
    }


    // Enum JackGame.EJackActionDamageCalcType
    public enum EJackActionDamageCalcType : byte
    {
        EJackActionDamageCalcType__None = 0,
        EJackActionDamageCalcType__Kougeki = 1,
        EJackActionDamageCalcType__Standard = 2,
        EJackActionDamageCalcType__StandardPer = 3,
        EJackActionDamageCalcType__StandardCurrentPer = 4,
        EJackActionDamageCalcType__StandardHeal = 5,
        EJackActionDamageCalcType__StandardHealPer = 6,
        EJackActionDamageCalcType__Boo = 7,
        EJackActionDamageCalcType__Mahotora = 8,
        EJackActionDamageCalcType__HPPasser = 9,
        EJackActionDamageCalcType__Madante = 10,
        EJackActionDamageCalcType__CrossMadante = 11,
        EJackActionDamageCalcType__ReverseDamage = 12,
        EJackActionDamageCalcType__GoldShower = 13,
        EJackActionDamageCalcType__MAX = 14
    }


    // Enum JackGame.EJackActionDamageType
    public enum EJackActionDamageType : byte
    {
        EJackActionDamageType__None = 0,
        EJackActionDamageType__DamageHP = 1,
        EJackActionDamageType__DamageMP = 2,
        EJackActionDamageType__HealHP = 3,
        EJackActionDamageType__HealMP = 4,
        EJackActionDamageType__Revive = 5,
        EJackActionDamageType__ReviveHeal = 6,
        EJackActionDamageType__MAX = 7
    }


    // Enum JackGame.EJackDamageType
    public enum EJackDamageType : byte
    {
        EJackDamageType__Normal = 0,
        EJackDamageType__Critical = 1,
        EJackDamageType__Guard = 2,
        EJackDamageType__Miss = 3,
        EJackDamageType__MAX = 4
    }


    // Enum JackGame.EJackActionEffectBehaviorType
    public enum EJackActionEffectBehaviorType : byte
    {
        EJackActionEffectBehaviorType__None = 0,
        EJackActionEffectBehaviorType__BurstAroundSelf = 1,
        EJackActionEffectBehaviorType__BurstAroundTarget = 2,
        EJackActionEffectBehaviorType__Projectile = 3,
        EJackActionEffectBehaviorType__PenetratingProjectile = 4,
        EJackActionEffectBehaviorType__MAX = 5
    }


    // Enum JackGame.EJackActionConsumeCondition
    public enum EJackActionConsumeCondition : byte
    {
        EJackActionConsumeCondition__None = 0,
        EJackActionConsumeCondition__Always = 1,
        EJackActionConsumeCondition__HealHP = 2,
        EJackActionConsumeCondition__HealMP = 3,
        EJackActionConsumeCondition__Revive = 4,
        EJackActionConsumeCondition__Alive = 5,
        EJackActionConsumeCondition__ClearDoku = 6,
        EJackActionConsumeCondition__ClearMahi = 7,
        EJackActionConsumeCondition__ClearKonran = 8,
        EJackActionConsumeCondition__ClearNemuri = 9,
        EJackActionConsumeCondition__ClearNoroi = 10,
        EJackActionConsumeCondition__ClearGenwaku = 11,
        EJackActionConsumeCondition__ClearMiryou = 12,
        EJackActionConsumeCondition__InvokeZone = 13,
        EJackActionConsumeCondition__MAX = 14
    }


    // Enum JackGame.EJackActionTargetListType
    public enum EJackActionTargetListType : byte
    {
        EJackActionTargetListType__None = 0,
        EJackActionTargetListType__Enemy = 1,
        EJackActionTargetListType__Friend = 2,
        EJackActionTargetListType__FriendRevive = 3,
        EJackActionTargetListType__All = 4,
        EJackActionTargetListType__MAX = 5
    }


    // Enum JackGame.EJackActionTargetLayerType
    public enum EJackActionTargetLayerType : byte
    {
        EJackActionTargetLayerType__None = 0,
        EJackActionTargetLayerType__First = 1,
        EJackActionTargetLayerType__Second = 2,
        EJackActionTargetLayerType__MAX = 3
    }


    // Enum JackGame.EJackActionHitOrderType
    public enum EJackActionHitOrderType : byte
    {
        EJackActionHitOrderType__None = 0,
        EJackActionHitOrderType__Auto = 1,
        EJackActionHitOrderType__NearCaster = 2,
        EJackActionHitOrderType__NearTarget = 3,
        EJackActionHitOrderType__FarCaster = 4,
        EJackActionHitOrderType__FarTarget = 5,
        EJackActionHitOrderType__Clockwise = 6,
        EJackActionHitOrderType__Counterclockwise = 7,
        EJackActionHitOrderType__LeftToRight = 8,
        EJackActionHitOrderType__RightToLeft = 9,
        EJackActionHitOrderType__BackToFront = 10,
        EJackActionHitOrderType__FrontToBack = 11,
        EJackActionHitOrderType__Random = 12,
        EJackActionHitOrderType__RandomUniqueHit = 13,
        EJackActionHitOrderType__MAX = 14
    }


    // Enum JackGame.EJackActionExtentType
    public enum EJackActionExtentType : byte
    {
        EJackActionExtentType__None = 0,
        EJackActionExtentType__Single = 1,
        EJackActionExtentType__Group = 2,
        EJackActionExtentType__All = 3,
        EJackActionExtentType__AllWithStandby = 4,
        EJackActionExtentType__AllWithStandbyWithoutSelf = 5,
        EJackActionExtentType__AllWithoutFirstTarget = 6,
        EJackActionExtentType__Sphere = 7,
        EJackActionExtentType__Capsule = 8,
        EJackActionExtentType__Box = 9,
        EJackActionExtentType__Fan = 10,
        EJackActionExtentType__NumberByAliveOnly = 11,
        EJackActionExtentType__SingleWithParts = 12,
        EJackActionExtentType__SinglePartsOnly = 13,
        EJackActionExtentType__MAX = 14
    }


    // Enum JackGame.EJackActionExtentTargetType
    public enum EJackActionExtentTargetType : byte
    {
        EJackActionExtentTargetType__None = 0,
        EJackActionExtentTargetType__Self = 1,
        EJackActionExtentTargetType__Single = 2,
        EJackActionExtentTargetType__WithoutSelf = 3,
        EJackActionExtentTargetType__MAX = 4
    }


    // Enum JackGame.EJackActionTargetType
    public enum EJackActionTargetType : byte
    {
        EJackActionTargetType__None = 0,
        EJackActionTargetType__Friend = 1,
        EJackActionTargetType__Foe = 2,
        EJackActionTargetType__All = 3,
        EJackActionTargetType__AllWithoutSelf = 4,
        EJackActionTargetType__MAX = 5
    }


    // Enum JackGame.EJackActionModuleType
    public enum EJackActionModuleType : byte
    {
        EJackActionModuleType__None = 0,
        EJackActionModuleType__Damage = 1,
        EJackActionModuleType__DamageMP = 2,
        EJackActionModuleType__Recover = 3,
        EJackActionModuleType__RecoverMP = 4,
        EJackActionModuleType__Revive = 5,
        EJackActionModuleType__HPPasser = 6,
        EJackActionModuleType__SetOddEffect = 7,
        EJackActionModuleType__ClearOddEffect = 8,
        EJackActionModuleType__InvokeOddEffect = 9,
        EJackActionModuleType__Mikawasi = 10,
        EJackActionModuleType__TateGuard = 11,
        EJackActionModuleType__BukiGuard = 12,
        EJackActionModuleType__DamageKanzenGuard = 13,
        EJackActionModuleType__ButuriKanzenGuard = 14,
        EJackActionModuleType__KaisinKanzenGuard = 15,
        EJackActionModuleType__ImmediatelyCounter = 16,
        EJackActionModuleType__PoisonDamage = 17,
        EJackActionModuleType__Yasumi = 18,
        EJackActionModuleType__Nigeru = 19,
        EJackActionModuleType__Muda = 20,
        EJackActionModuleType__NakamaYobi = 21,
        EJackActionModuleType__Nusumu = 22,
        EJackActionModuleType__Zibaria = 23,
        EJackActionModuleType__AutoRecover = 24,
        EJackActionModuleType__AutoRecoverMP = 25,
        EJackActionModuleType__MPZero = 26,
        EJackActionModuleType__ActionExecDependent = 27,
        EJackActionModuleType__HandouDamage = 28,
        EJackActionModuleType__MeganteSokusi = 29,
        EJackActionModuleType__HP1Nokori = 30,
        EJackActionModuleType__SokusiMukou = 31,
        EJackActionModuleType__Voice = 32,
        EJackActionModuleType__Invalid = 33,
        EJackActionModuleType__MAX = 34
    }


    // Enum JackGame.EJackActionKyuusyuuType
    public enum EJackActionKyuusyuuType : byte
    {
        EJackActionKyuusyuuType__None = 0,
        EJackActionKyuusyuuType__HP = 1,
        EJackActionKyuusyuuType__MP = 2,
        EJackActionKyuusyuuType__MAX = 3
    }


    // Enum JackGame.EJackCalcDamageOperator
    public enum EJackCalcDamageOperator : byte
    {
        EJackCalcDamageOperator__Mul = 0,
        EJackCalcDamageOperator__Add = 1,
        EJackCalcDamageOperator__MAX = 2
    }


    // Enum JackGame.EJackRotationProcessType
    public enum EJackRotationProcessType : byte
    {
        EJackRotationProcessType__None = 0,
        EJackRotationProcessType__Linear = 1,
        EJackRotationProcessType__Smooth = 2,
        EJackRotationProcessType__Time = 3,
        EJackRotationProcessType__MAX = 4
    }


    // Enum JackGame.EJackRotationLayer
    public enum EJackRotationLayer : byte
    {
        EJackRotationLayer__None = 0,
        EJackRotationLayer__Move = 1,
        EJackRotationLayer__BattleAIStateMove = 2,
        EJackRotationLayer__ActionAssistMove = 3,
        EJackRotationLayer__AnimNotify = 4,
        EJackRotationLayer__Damage = 5,
        EJackRotationLayer__MAX = 6
    }


    // Enum JackGame.EJackMonsterBattleStyle
    public enum EJackMonsterBattleStyle : byte
    {
        EJackMonsterBattleStyle__None = 0,
        EJackMonsterBattleStyle__Ten = 1,
        EJackMonsterBattleStyle__Chi = 2,
        EJackMonsterBattleStyle__Ryu = 3,
        EJackMonsterBattleStyle__Dying = 4,
        EJackMonsterBattleStyle__MAX = 5
    }


    // Enum JackGame.EJackMonsterSibariParameterTarget
    public enum EJackMonsterSibariParameterTarget : byte
    {
        EJackMonsterSibariParameterTarget__None = 0,
        EJackMonsterSibariParameterTarget__HP = 1,
        EJackMonsterSibariParameterTarget__MP = 2,
        EJackMonsterSibariParameterTarget__Kougekiryoku = 3,
        EJackMonsterSibariParameterTarget__Syubiryoku = 4,
        EJackMonsterSibariParameterTarget__Subayasa = 5,
        EJackMonsterSibariParameterTarget__Kiyousa = 6,
        EJackMonsterSibariParameterTarget__InitialZonePointMin = 7,
        EJackMonsterSibariParameterTarget__InitialZonePointMax = 8,
        EJackMonsterSibariParameterTarget__MAX = 9
    }


    // Enum JackGame.EJackMonsterSibariParameterOperator
    public enum EJackMonsterSibariParameterOperator : byte
    {
        EJackMonsterSibariParameterOperator__None = 0,
        EJackMonsterSibariParameterOperator__Add = 1,
        EJackMonsterSibariParameterOperator__Mul = 2,
        EJackMonsterSibariParameterOperator__Overwrite = 3,
        EJackMonsterSibariParameterOperator__MAX = 4
    }


    // Enum JackGame.EJackMonsterTextType
    public enum EJackMonsterTextType : byte
    {
        EJackMonsterTextType__None = 0,
        EJackMonsterTextType__DisplayName = 1,
        EJackMonsterTextType__MAX = 2
    }


    // Enum JackGame.EJackMonsterMoveDir
    public enum EJackMonsterMoveDir : byte
    {
        EJackMonsterMoveDir__NearWalk = 0,
        EJackMonsterMoveDir__NearRun = 1,
        EJackMonsterMoveDir__FarWalk = 2,
        EJackMonsterMoveDir__FarRun = 3,
        EJackMonsterMoveDir__MAX = 4
    }


    // Enum JackGame.EJackMonsterMovement
    public enum EJackMonsterMovement : byte
    {
        EJackMonsterMovement__None = 0,
        EJackMonsterMovement__Move = 1,
        EJackMonsterMovement__Anim = 2,
        EJackMonsterMovement__Effect = 3,
        EJackMonsterMovement__Wait = 4,
        EJackMonsterMovement__Trun = 5,
        EJackMonsterMovement__Spread = 6,
        EJackMonsterMovement__MAX = 7
    }


    // Enum JackGame.EJackMonsterRelationship
    public enum EJackMonsterRelationship : byte
    {
        EJackMonsterRelationship__Strong = 0,
        EJackMonsterRelationship__Weak = 1,
        EJackMonsterRelationship__Amazing = 2,
        EJackMonsterRelationship__MAX = 3
    }


    // Enum JackGame.EJackMonsterState
    public enum EJackMonsterState : byte
    {
        EJackMonsterState__None = 0,
        EJackMonsterState__RunAway = 1,
        EJackMonsterState__Tracking = 2,
        EJackMonsterState__Idle = 3,
        EJackMonsterState__Battle = 4,
        EJackMonsterState__Rush = 5,
        EJackMonsterState__Eco = 6,
        EJackMonsterState__MAX = 7
    }


    // Enum JackGame.EJackMonsterTarget
    public enum EJackMonsterTarget : byte
    {
        EJackMonsterTarget__None = 0,
        EJackMonsterTarget__Player = 1,
        EJackMonsterTarget__Group = 2,
        EJackMonsterTarget__Other = 3,
        EJackMonsterTarget__EcoPoint = 4,
        EJackMonsterTarget__Periphery = 5,
        EJackMonsterTarget__PopLoc = 6,
        EJackMonsterTarget__WeakStop = 7,
        EJackMonsterTarget__WeakRunaway = 8,
        EJackMonsterTarget__StrongChase = 9,
        EJackMonsterTarget__StrongRush = 10,
        EJackMonsterTarget__Leader = 11,
        EJackMonsterTarget__StrongMonster = 12,
        EJackMonsterTarget__WeakMonster = 13,
        EJackMonsterTarget__AmazingMonster = 14,
        EJackMonsterTarget__EscapeMonster = 15,
        EJackMonsterTarget__MAX = 16
    }


    // Enum JackGame.EJackMonsterTerms
    public enum EJackMonsterTerms : byte
    {
        EJackMonsterTerms__Time = 0,
        EJackMonsterTerms__Near = 1,
        EJackMonsterTerms__Far = 2,
        EJackMonsterTerms__InSight = 3,
        EJackMonsterTerms__Attacked = 4,
        EJackMonsterTerms__None = 5,
        EJackMonsterTerms__Battle = 6,
        EJackMonsterTerms__BattleEnd = 7,
        EJackMonsterTerms__OutOfSight = 8,
        EJackMonsterTerms__Terminate = 9,
        EJackMonsterTerms__Active = 10,
        EJackMonsterTerms__Lounched = 11,
        EJackMonsterTerms__TerminateRandom = 12,
        EJackMonsterTerms__Transmitted = 13,
        EJackMonsterTerms__MAX = 14
    }


    // Enum JackGame.EJackMonsterTransmittedInfo
    public enum EJackMonsterTransmittedInfo : byte
    {
        EJackMonsterTransmittedInfo__FindPlayer = 0,
        EJackMonsterTransmittedInfo__Bark = 1,
        EJackMonsterTransmittedInfo__MAX = 2
    }


    // Enum JackGame.EJackBattleIntelligenceType
    public enum EJackBattleIntelligenceType : byte
    {
        EJackBattleIntelligenceType__None = 0,
        EJackBattleIntelligenceType__Baka = 1,
        EJackBattleIntelligenceType__Ningen = 2,
        EJackBattleIntelligenceType__Kami = 3,
        EJackBattleIntelligenceType__MAX = 4
    }


    // Enum JackGame.EJackMonsterPartyType
    public enum EJackMonsterPartyType : byte
    {
        EJackMonsterPartyType__None = 0,
        EJackMonsterPartyType__Normal = 1,
        EJackMonsterPartyType__Special = 2,
        EJackMonsterPartyType__Metal = 3,
        EJackMonsterPartyType__Reincarnation = 4,
        EJackMonsterPartyType__MAX = 5
    }


    // Enum JackGame.EJackMonsterBodyAttribute
    public enum EJackMonsterBodyAttribute : byte
    {
        EJackMonsterBodyAttribute__Monolithic = 0,
        EJackMonsterBodyAttribute__Body = 1,
        EJackMonsterBodyAttribute__Parts = 2,
        EJackMonsterBodyAttribute__NoEntityParts = 3,
        EJackMonsterBodyAttribute__ShadowCopy = 4,
        EJackMonsterBodyAttribute__MAX = 5
    }


    // Enum JackGame.EJackMonsterBowgunResonse
    public enum EJackMonsterBowgunResonse : byte
    {
        EJackMonsterBowgunResonse__Angry = 0,
        EJackMonsterBowgunResonse__Notice = 1,
        EJackMonsterBowgunResonse__Ignore = 2,
        EJackMonsterBowgunResonse__MAX = 3
    }


    // Enum JackGame.EJackMonsterMovementStrong
    public enum EJackMonsterMovementStrong : byte
    {
        EJackMonsterMovementStrong__Chase = 0,
        EJackMonsterMovementStrong__Rush = 1,
        EJackMonsterMovementStrong__Ignore = 2,
        EJackMonsterMovementStrong__MAX = 3
    }


    // Enum JackGame.EJackMonsterMovementWeak
    public enum EJackMonsterMovementWeak : byte
    {
        EJackMonsterMovementWeak__Stop = 0,
        EJackMonsterMovementWeak__Runaway = 1,
        EJackMonsterMovementWeak__Ignore = 2,
        EJackMonsterMovementWeak__MAX = 3
    }


    // Enum JackGame.EJackMonsterSearchType
    public enum EJackMonsterSearchType : byte
    {
        EJackMonsterSearchType__None = 0,
        EJackMonsterSearchType__EyeSight = 1,
        EJackMonsterSearchType__Hearing = 2,
        EJackMonsterSearchType__ESP = 3,
        EJackMonsterSearchType__MAX = 4
    }


    // Enum JackGame.EJackMonsterMoveSpeed
    public enum EJackMonsterMoveSpeed : byte
    {
        EJackMonsterMoveSpeed__SuperSlow = 0,
        EJackMonsterMoveSpeed__VerySlow = 1,
        EJackMonsterMoveSpeed__Slow = 2,
        EJackMonsterMoveSpeed__SlightlySlow = 3,
        EJackMonsterMoveSpeed__Normal = 4,
        EJackMonsterMoveSpeed__SlightlyFast = 5,
        EJackMonsterMoveSpeed__Fast = 6,
        EJackMonsterMoveSpeed__VeryFast = 7,
        EJackMonsterMoveSpeed__SuperFast = 8,
        EJackMonsterMoveSpeed__Original = 9,
        EJackMonsterMoveSpeed__MAX = 10
    }


    // Enum JackGame.EJackMonsterMoveMethod
    public enum EJackMonsterMoveMethod : byte
    {
        EJackMonsterMoveMethod__Walk = 0,
        EJackMonsterMoveMethod__Teleportaion = 1,
        EJackMonsterMoveMethod__MAX = 2
    }


    // Enum JackGame.EJackMonsterMoveType
    public enum EJackMonsterMoveType : byte
    {
        EJackMonsterMoveType__Stop = 0,
        EJackMonsterMoveType__Move = 1,
        EJackMonsterMoveType__MAX = 2
    }


    // Enum JackGame.EJackMonsterPopManagerUpdatePurpose
    public enum EJackMonsterPopManagerUpdatePurpose : byte
    {
        EJackMonsterPopManagerUpdatePurpose__Battle = 0,
        EJackMonsterPopManagerUpdatePurpose__Debug = 1,
        EJackMonsterPopManagerUpdatePurpose__CategoryHidden_A = 2,
        EJackMonsterPopManagerUpdatePurpose__CategoryHidden_M = 3,
        EJackMonsterPopManagerUpdatePurpose__CutScene = 4,
        EJackMonsterPopManagerUpdatePurpose__AllDead = 5,
        EJackMonsterPopManagerUpdatePurpose__MAX = 6
    }


    // Enum JackGame.EJackMonsterRace
    public enum EJackMonsterRace : byte
    {
        EJackMonsterRace__None = 0,
        EJackMonsterRace__Slime = 1,
        EJackMonsterRace__Dragon = 2,
        EJackMonsterRace__Akuma = 3,
        EJackMonsterRace__Bussitu = 4,
        EJackMonsterRace__Zombie = 5,
        EJackMonsterRace__Element = 6,
        EJackMonsterRace__Kaizin = 7,
        EJackMonsterRace__Machine = 8,
        EJackMonsterRace__Tori = 9,
        EJackMonsterRace__Sizen = 10,
        EJackMonsterRace__Kemono = 11,
        EJackMonsterRace__Maou = 12,
        EJackMonsterRace__MAX = 13
    }


    // Enum JackGame.EJackCharacterSaveGold
    public enum EJackCharacterSaveGold : byte
    {
        EJackCharacterSaveGold__P001 = 0,
        EJackCharacterSaveGold__P002 = 1,
        EJackCharacterSaveGold__P005 = 2,
        EJackCharacterSaveGold__P006 = 3,
        EJackCharacterSaveGold__P007 = 4,
        EJackCharacterSaveGold__MAX = 5
    }


    // Enum JackGame.EJackTwoLapReturnSave
    public enum EJackTwoLapReturnSave : byte
    {
        EJackTwoLapReturnSave__A180 = 0,
        EJackTwoLapReturnSave__B170 = 1,
        EJackTwoLapReturnSave__MAX = 2
    }


    // Enum JackGame.EJackUmayobiNoBeruFailPurpose
    public enum EJackUmayobiNoBeruFailPurpose : byte
    {
        EJackUmayobiNoBeruFailPurpose__FailSenario = 0,
        EJackUmayobiNoBeruFailPurpose__FailArea = 1,
        EJackUmayobiNoBeruFailPurpose__FailStrangePower = 2,
        EJackUmayobiNoBeruFailPurpose__MAX = 3
    }


    // Enum JackGame.EJackRuraFailPurpose
    public enum EJackRuraFailPurpose : byte
    {
        EJackRuraFailPurpose__Level = 0,
        EJackRuraFailPurpose__MAX = 1
    }


    // Enum JackGame.EJackRuraFail
    public enum EJackRuraFail : byte
    {
        EJackRuraFail__None = 0,
        EJackRuraFail__RiremitoNone = 1,
        EJackRuraFail__RuraRiremitoNone = 2,
        EJackRuraFail__RideVehicle = 3,
        EJackRuraFail__CannotUseArea = 4,
        EJackRuraFail__StrangePower = 5,
        EJackRuraFail__StrangePowerRiremito = 6,
        EJackRuraFail__Ceil = 7,
        EJackRuraFail__LowCeil = 8,
        EJackRuraFail__ForceNone = 9,
        EJackRuraFail__ForceRuraRiremitoNone = 10,
        EJackRuraFail__MAX = 11
    }


    // Enum JackGame.EJackAnimSMGraphPurpose
    public enum EJackAnimSMGraphPurpose : byte
    {
        EJackAnimSMGraphPurpose__Default = 0,
        EJackAnimSMGraphPurpose__Additive = 1,
        EJackAnimSMGraphPurpose__MAX = 2
    }


    // Enum JackGame.EJackCharacterRecover
    public enum EJackCharacterRecover : byte
    {
        EJackCharacterRecover__Full = 0,
        EJackCharacterRecover__HP = 1,
        EJackCharacterRecover__MP = 2,
        EJackCharacterRecover__MAX = 3
    }


    // Enum JackGame.EJackCharacterMugenPurpose
    public enum EJackCharacterMugenPurpose : byte
    {
        EJackCharacterMugenPurpose__System = 0,
        EJackCharacterMugenPurpose__Character = 1,
        EJackCharacterMugenPurpose__OddEffect = 2,
        EJackCharacterMugenPurpose__Debug = 3,
        EJackCharacterMugenPurpose__MAX = 4
    }


    // Enum JackGame.EJackCharacterAutoLookAtPurpose
    public enum EJackCharacterAutoLookAtPurpose : byte
    {
        EJackCharacterAutoLookAtPurpose__Normal = 0,
        EJackCharacterAutoLookAtPurpose__Parade = 1,
        EJackCharacterAutoLookAtPurpose__Gimmick = 2,
        EJackCharacterAutoLookAtPurpose__AfterMapJump = 3,
        EJackCharacterAutoLookAtPurpose__AnimNotifyState = 4,
        EJackCharacterAutoLookAtPurpose__PhotoMode = 5,
        EJackCharacterAutoLookAtPurpose__MAX = 6
    }


    // Enum JackGame.EJackCharacterFootstepType
    public enum EJackCharacterFootstepType : byte
    {
        EJackCharacterFootstepType__Walk = 0,
        EJackCharacterFootstepType__Run = 1,
        EJackCharacterFootstepType__Dash = 2,
        EJackCharacterFootstepType__Landing = 3,
        EJackCharacterFootstepType__Sliding = 4,
        EJackCharacterFootstepType__Rain = 5,
        EJackCharacterFootstepType__MAX = 6
    }


    // Enum JackGame.EJackGuestNpcHiddenPurpose
    public enum EJackGuestNpcHiddenPurpose : byte
    {
        EJackGuestNpcHiddenPurpose__Hidden = 0,
        EJackGuestNpcHiddenPurpose__Battle = 1,
        EJackGuestNpcHiddenPurpose__PartyTalk = 2,
        EJackGuestNpcHiddenPurpose__Vehicle = 3,
        EJackGuestNpcHiddenPurpose__Ship = 4,
        EJackGuestNpcHiddenPurpose__Whale = 5,
        EJackGuestNpcHiddenPurpose__Ruler = 6,
        EJackGuestNpcHiddenPurpose__Button = 7,
        EJackGuestNpcHiddenPurpose__CutScene = 8,
        EJackGuestNpcHiddenPurpose__Level = 9,
        EJackGuestNpcHiddenPurpose__InDoor = 10,
        EJackGuestNpcHiddenPurpose__Fish = 11,
        EJackGuestNpcHiddenPurpose__Map = 12,
        EJackGuestNpcHiddenPurpose__Teleport = 13,
        EJackGuestNpcHiddenPurpose__Cheat = 14,
        EJackGuestNpcHiddenPurpose__MAX = 15
    }


    // Enum JackGame.EJackCharacterRootMotionPurpose
    public enum EJackCharacterRootMotionPurpose : byte
    {
        EJackCharacterRootMotionPurpose__AutoNavigation = 0,
        EJackCharacterRootMotionPurpose__NoFloorSlip = 1,
        EJackCharacterRootMotionPurpose__MAX = 2
    }


    // Enum JackGame.EJackCharacterConstrainedOnNavMeshPurpose
    public enum EJackCharacterConstrainedOnNavMeshPurpose : byte
    {
        EJackCharacterConstrainedOnNavMeshPurpose__Battle = 0,
        EJackCharacterConstrainedOnNavMeshPurpose__DuringMove = 1,
        EJackCharacterConstrainedOnNavMeshPurpose__PushOut = 2,
        EJackCharacterConstrainedOnNavMeshPurpose__DebugCommand = 3,
        EJackCharacterConstrainedOnNavMeshPurpose__MAX = 4
    }


    // Enum JackGame.EJackCharacterMaxMoveSpeedPurpose
    public enum EJackCharacterMaxMoveSpeedPurpose : byte
    {
        EJackCharacterMaxMoveSpeedPurpose__Controller = 0,
        EJackCharacterMaxMoveSpeedPurpose__ActionExecutor = 1,
        EJackCharacterMaxMoveSpeedPurpose__DebugCommand = 2,
        EJackCharacterMaxMoveSpeedPurpose__Dash = 3,
        EJackCharacterMaxMoveSpeedPurpose__MAX = 4
    }


    // Enum JackGame.EJackCharacterMovementMaxSpeed
    public enum EJackCharacterMovementMaxSpeed : byte
    {
        EJackCharacterMovementMaxSpeed__NoLimit = 0,
        EJackCharacterMovementMaxSpeed__Run = 1,
        EJackCharacterMovementMaxSpeed__Walk = 2,
        EJackCharacterMovementMaxSpeed__MAX = 3
    }


    // Enum JackGame.EJackCharacterMovementMaxSpeedPurpose
    public enum EJackCharacterMovementMaxSpeedPurpose : byte
    {
        EJackCharacterMovementMaxSpeedPurpose__LVD = 0,
        EJackCharacterMovementMaxSpeedPurpose__PlayableMovementDefault = 1,
        EJackCharacterMovementMaxSpeedPurpose__Debug = 2,
        EJackCharacterMovementMaxSpeedPurpose__MAX = 3
    }


    // Enum JackGame.EJackAnimInstanceControlCategory
    public enum EJackAnimInstanceControlCategory : byte
    {
        EJackAnimInstanceControlCategory__MenuHUD = 0,
        EJackAnimInstanceControlCategory__ActionCursor = 1,
        EJackAnimInstanceControlCategory__ZeroDeltaSeconds = 2,
        EJackAnimInstanceControlCategory__DashRunCollide = 3,
        EJackAnimInstanceControlCategory__ActionGuideHelp = 4,
        EJackAnimInstanceControlCategory__MAX = 5
    }


    // Enum JackGame.EJackFacialControlDisablePurpose
    public enum EJackFacialControlDisablePurpose : byte
    {
        EJackFacialControlDisablePurpose__LOD = 0,
        EJackFacialControlDisablePurpose__Renkei = 1,
        EJackFacialControlDisablePurpose__NoAnimation = 2,
        EJackFacialControlDisablePurpose__MAX = 3
    }


    // Enum JackGame.EJackFacialControlPurpose
    public enum EJackFacialControlPurpose : byte
    {
        EJackFacialControlPurpose__CutScene = 0,
        EJackFacialControlPurpose__MAX = 1
    }


    // Enum JackGame.EJackFootIKControlPurpose
    public enum EJackFootIKControlPurpose : byte
    {
        EJackFootIKControlPurpose__CutScene = 0,
        EJackFootIKControlPurpose__LOD = 1,
        EJackFootIKControlPurpose__Gimmick = 2,
        EJackFootIKControlPurpose__AnimInstance = 3,
        EJackFootIKControlPurpose__BattleAction = 4,
        EJackFootIKControlPurpose__BattleActionAttach = 5,
        EJackFootIKControlPurpose__AnimNotifyState = 6,
        EJackFootIKControlPurpose__VehicleRide = 7,
        EJackFootIKControlPurpose__Reduction = 8,
        EJackFootIKControlPurpose__NPCSystem = 9,
        EJackFootIKControlPurpose__MAX = 10
    }


    // Enum JackGame.EJackTickComponentDisabledPurpose
    public enum EJackTickComponentDisabledPurpose : byte
    {
        EJackTickComponentDisabledPurpose__CutScene = 0,
        EJackTickComponentDisabledPurpose__LoadReduction = 1,
        EJackTickComponentDisabledPurpose__NPCSystem = 2,
        EJackTickComponentDisabledPurpose__Attach = 3,
        EJackTickComponentDisabledPurpose__MenuHUD = 4,
        EJackTickComponentDisabledPurpose__MonsterAI = 5,
        EJackTickComponentDisabledPurpose__Battle = 6,
        EJackTickComponentDisabledPurpose__GestNPC = 7,
        EJackTickComponentDisabledPurpose__DebugCommand = 8,
        EJackTickComponentDisabledPurpose__MAX = 9
    }


    // Enum JackGame.EJackParticleSystemControl
    public enum EJackParticleSystemControl : byte
    {
        EJackParticleSystemControl__Character = 0,
        EJackParticleSystemControl__WeaponSystem = 1,
        EJackParticleSystemControl__PropSystem = 2,
        EJackParticleSystemControl__MAX = 3
    }


    // Enum JackGame.EJackFriendCharacterQueryFilter
    public enum EJackFriendCharacterQueryFilter : byte
    {
        EJackFriendCharacterQueryFilter__FriendsWithMenuDisp = 0,
        EJackFriendCharacterQueryFilter__FriendsWithoutLeaving = 1,
        EJackFriendCharacterQueryFilter__Friends = 2,
        EJackFriendCharacterQueryFilter__MAX = 3
    }


    // Enum JackGame.EJackPlayerController
    public enum EJackPlayerController : byte
    {
        Player1 = 0,
        Player2 = 1,
        Battle = 2,
        MAX = 3
    }


    // Enum JackGame.EJackCollisionProfile
    public enum EJackCollisionProfile : byte
    {
        EJackCollisionProfile__Pawn = 0,
        EJackCollisionProfile__MAX = 1
    }


    // Enum JackGame.EJackDressupCoordinateLockReason
    public enum EJackDressupCoordinateLockReason : byte
    {
        EJackDressupCoordinateLockReason__Level = 0,
        EJackDressupCoordinateLockReason__Noroi = 1,
        EJackDressupCoordinateLockReason__Vehicle = 2,
        EJackDressupCoordinateLockReason__None = 3,
        EJackDressupCoordinateLockReason__MAX = 4
    }


    // Enum JackGame.EJackCharacterScope
    public enum EJackCharacterScope : byte
    {
        EJackCharacterScope__None = 0,
        EJackCharacterScope__All = 1,
        EJackCharacterScope__Players = 2,
        EJackCharacterScope__Friends = 3,
        EJackCharacterScope__Monsters = 4,
        EJackCharacterScope__NPCs = 5,
        EJackCharacterScope__Vehicles = 6,
        EJackCharacterScope__MAX = 7
    }


    // Enum JackGame.EJackCharacterEffectSizeLayer
    public enum EJackCharacterEffectSizeLayer : byte
    {
        EJackCharacterEffectSizeLayer__Default = 0,
        EJackCharacterEffectSizeLayer__ActionCast = 1,
        EJackCharacterEffectSizeLayer__ActionEffect = 2,
        EJackCharacterEffectSizeLayer__MAX = 3
    }


    // Enum JackGame.EJackCharacterEffectSize
    public enum EJackCharacterEffectSize : byte
    {
        EJackCharacterEffectSize__Human = 0,
        EJackCharacterEffectSize__S = 1,
        EJackCharacterEffectSize__M = 2,
        EJackCharacterEffectSize__L = 3,
        EJackCharacterEffectSize__LL = 4,
        EJackCharacterEffectSize__MAX = 5
    }


    // Enum JackGame.EJackOddEffectParam
    public enum EJackOddEffectParam : byte
    {
        EJackOddEffectParam__None = 0,
        EJackOddEffectParam__Kougekiryoku = 1,
        EJackOddEffectParam__Syubiryoku = 2,
        EJackOddEffectParam__MAX = 3
    }


    // Enum JackGame.EJackReferenceParamTarget
    public enum EJackReferenceParamTarget : byte
    {
        EJackReferenceParamTarget__None = 0,
        EJackReferenceParamTarget__CasterCharacter = 1,
        EJackReferenceParamTarget__TargetCharacter = 2,
        EJackReferenceParamTarget__MAX = 3
    }


    // Enum JackGame.EJackReferenceParam
    public enum EJackReferenceParam : byte
    {
        EJackReferenceParam__None = 0,
        EJackReferenceParam__MaxHP = 1,
        EJackReferenceParam__MaxMP = 2,
        EJackReferenceParam__HP = 3,
        EJackReferenceParam__MP = 4,
        EJackReferenceParam__Tikara = 5,
        EJackReferenceParam__Subayasa = 6,
        EJackReferenceParam__Minomamori = 7,
        EJackReferenceParam__Kiyousa = 8,
        EJackReferenceParam__Miryoku = 9,
        EJackReferenceParam__Kougekiryoku = 10,
        EJackReferenceParam__Syubiryoku = 11,
        EJackReferenceParam__KougekiMaryoku = 12,
        EJackReferenceParam__KaifukuMaryoku = 13,
        EJackReferenceParam__TakaihounoMaryoku = 14,
        EJackReferenceParam__Omosa = 15,
        EJackReferenceParam__CriticalRate = 16,
        EJackReferenceParam__MPKyuuSyuuRate = 17,
        EJackReferenceParam__TateGuardRate = 18,
        EJackReferenceParam__BukiGuardRate = 19,
        EJackReferenceParam__MikawasiRate = 20,
        EJackReferenceParam__ZibariaDamage = 21,
        EJackReferenceParam__RefAutoKaifuku = 22,
        EJackReferenceParam__Level = 23,
        EJackReferenceParam__RenkeiTikara = 24,
        EJackReferenceParam__RenkeiKougekiryoku = 25,
        EJackReferenceParam__RenkeiKougekiMaryoku = 26,
        EJackReferenceParam__RenkeiLevel = 27,
        EJackReferenceParam__Special = 28,
        EJackReferenceParam__MAX = 29
    }


    // Enum JackGame.EJackAttributeParam
    public enum EJackAttributeParam : byte
    {
        EJackAttributeParam__None = 0,
        EJackAttributeParam__Honoo = 1,
        EJackAttributeParam__Koori = 2,
        EJackAttributeParam__Kaze = 3,
        EJackAttributeParam__Kaminari = 4,
        EJackAttributeParam__Tuti = 5,
        EJackAttributeParam__Yami = 6,
        EJackAttributeParam__Hikari = 7,
        EJackAttributeParam__Doku = 8,
        EJackAttributeParam__Nemuri = 9,
        EJackAttributeParam__Konran = 10,
        EJackAttributeParam__Mahi = 11,
        EJackAttributeParam__Sokusi = 12,
        EJackAttributeParam__Miryou = 13,
        EJackAttributeParam__Genwaku = 14,
        EJackAttributeParam__Noroi = 15,
        EJackAttributeParam__Nifuramu = 16,
        EJackAttributeParam__Kyuusyuu = 17,
        EJackAttributeParam__Guntai = 18,
        EJackAttributeParam__Mitoreru = 19,
        EJackAttributeParam__HPWariaiDamage = 20,
        EJackAttributeParam__Fuuin_Jumon = 21,
        EJackAttributeParam__Fuuin_Tokugi = 22,
        EJackAttributeParam__Obie = 23,
        EJackAttributeParam__Korobi = 24,
        EJackAttributeParam__PafuPafu = 25,
        EJackAttributeParam__Warai = 26,
        EJackAttributeParam__Odori = 27,
        EJackAttributeParam__KougekiryokuDown = 28,
        EJackAttributeParam__SyubiryokuDown = 29,
        EJackAttributeParam__KougekiJumonDown = 30,
        EJackAttributeParam__KaifukuJumonDown = 31,
        EJackAttributeParam__SubayasaDown = 32,
        EJackAttributeParam__JumonTaiseiDown = 33,
        EJackAttributeParam__ZokuseiDown = 34,
        EJackAttributeParam__TaiseiDown = 35,
        EJackAttributeParam__Zone = 36,
        EJackAttributeParam__Mikawasi = 37,
        EJackAttributeParam__TateGuard = 38,
        EJackAttributeParam__BukiGuard = 39,
        EJackAttributeParam__Critical = 40,
        EJackAttributeParam__Mitoresase = 41,
        EJackAttributeParam__MAX = 42
    }


    // Enum JackGame.EJackStatusParam
    public enum EJackStatusParam : byte
    {
        EJackStatusParam__None = 0,
        EJackStatusParam__MaxHP = 1,
        EJackStatusParam__MaxMP = 2,
        EJackStatusParam__HP = 3,
        EJackStatusParam__MP = 4,
        EJackStatusParam__Tikara = 5,
        EJackStatusParam__Subayasa = 6,
        EJackStatusParam__Minomamori = 7,
        EJackStatusParam__Kiyousa = 8,
        EJackStatusParam__Miryoku = 9,
        EJackStatusParam__Kougekiryoku = 10,
        EJackStatusParam__Syubiryoku = 11,
        EJackStatusParam__KougekiMaryoku = 12,
        EJackStatusParam__KaifukuMaryoku = 13,
        EJackStatusParam__Omosa = 14,
        EJackStatusParam__CriticalRate = 15,
        EJackStatusParam__MPKyuuSyuuRate = 16,
        EJackStatusParam__TateGuardRate = 17,
        EJackStatusParam__BukiGuardRate = 18,
        EJackStatusParam__MikawasiRate = 19,
        EJackStatusParam__ZibariaDamage = 20,
        EJackStatusParam__RefAutoKaifuku = 21,
        EJackStatusParam__MAX = 22
    }


    // Enum JackGame.EJackAnimalReaction
    public enum EJackAnimalReaction : byte
    {
        EJackAnimalReaction__None = 0,
        EJackAnimalReaction__HorseType = 1,
        EJackAnimalReaction__CowType = 2,
        EJackAnimalReaction__MiddleDogType = 3,
        EJackAnimalReaction__SmallAnimalType = 4,
        EJackAnimalReaction__MAX = 5
    }


    // Enum JackGame.EJackAnimalRace
    public enum EJackAnimalRace : byte
    {
        EJackAnimalRace__None = 0,
        EJackAnimalRace__Beast = 1,
        EJackAnimalRace__Bird = 2,
        EJackAnimalRace__Fish = 3,
        EJackAnimalRace__MAX = 4
    }


    // Enum JackGame.EJackAnimal
    public enum EJackAnimal : byte
    {
        EJackAnimal__None = 0,
        EJackAnimal__Dog = 1,
        EJackAnimal__Mouse = 2,
        EJackAnimal__Chiken = 3,
        EJackAnimal__MAX = 4
    }


    // Enum JackGame.EJackScenarioWeather
    public enum EJackScenarioWeather : byte
    {
        EJackScenarioWeather__None = 0,
        EJackScenarioWeather__Sunny = 1,
        EJackScenarioWeather__Rain = 2,
        EJackScenarioWeather__Snow = 3,
        EJackScenarioWeather__Fog = 4,
        EJackScenarioWeather__MAX = 5
    }


    // Enum JackGame.EJackNounGender
    public enum EJackNounGender : byte
    {
        EJackNounGender__None = 0,
        EJackNounGender__M = 1,
        EJackNounGender__F = 2,
        EJackNounGender__N = 3,
        EJackNounGender__Num = 4,
        EJackNounGender__EJackNounGender_MAX = 5
    }


    // Enum JackGame.EJackCharacterMovementAnimationPlayRatePurpose
    public enum EJackCharacterMovementAnimationPlayRatePurpose : byte
    {
        EJackCharacterMovementAnimationPlayRatePurpose__Battle = 0,
        EJackCharacterMovementAnimationPlayRatePurpose__Follow = 1,
        EJackCharacterMovementAnimationPlayRatePurpose__DebugCommand = 2,
        EJackCharacterMovementAnimationPlayRatePurpose__MAX = 3
    }


    // Enum JackGame.EJackEdition
    public enum EJackEdition : byte
    {
        EJackEdition__None = 0,
        EJackEdition__Japanese = 1,
        EJackEdition__International = 2,
        EJackEdition__MAX = 3
    }


    // Enum JackGame.EJackGameViewportClientControlCategory
    public enum EJackGameViewportClientControlCategory : byte
    {
        EJackGameViewportClientControlCategory__SceneCapture = 0,
        EJackGameViewportClientControlCategory__SkillPanel = 1,
        EJackGameViewportClientControlCategory__Movie = 2,
        EJackGameViewportClientControlCategory__Renkei = 3,
        EJackGameViewportClientControlCategory__MAX = 4
    }


    // Enum JackGame.EJackSerializeArrayMode
    public enum EJackSerializeArrayMode : byte
    {
        EJackSerializeArrayMode__Default = 0,
        EJackSerializeArrayMode__ValidOnly = 1,
        EJackSerializeArrayMode__WithoutBackInvalid = 2,
        EJackSerializeArrayMode__MAX = 3
    }


    // Enum JackGame.EJackRegion
    public enum EJackRegion : byte
    {
        EJackRegion__NorthAmerica = 0,
        EJackRegion__Europe = 1,
        EJackRegion__Asia = 2,
        EJackRegion__MAX = 3
    }


    // Enum JackGame.EJackCategoryHiddenLayer
    public enum EJackCategoryHiddenLayer : byte
    {
        EJackCategoryHiddenLayer__Battle = 0,
        EJackCategoryHiddenLayer__NakamaKaiwa = 1,
        EJackCategoryHiddenLayer__Camp = 2,
        EJackCategoryHiddenLayer__CutScene = 3,
        EJackCategoryHiddenLayer__Debug = 4,
        EJackCategoryHiddenLayer__MAX = 5
    }


    // Enum JackGame.EJackCategoryHiddenType
    public enum EJackCategoryHiddenType : byte
    {
        EJackCategoryHiddenType__NPC = 0,
        EJackCategoryHiddenType__Monster = 1,
        EJackCategoryHiddenType__EventMonster = 2,
        EJackCategoryHiddenType__Animal = 3,
        EJackCategoryHiddenType__TokiNoKesin = 4,
        EJackCategoryHiddenType__Vehicle = 5,
        EJackCategoryHiddenType__Object = 6,
        EJackCategoryHiddenType__Object_Battle = 7,
        EJackCategoryHiddenType__Object_CutScene = 8,
        EJackCategoryHiddenType__ParadeNPC = 9,
        EJackCategoryHiddenType__MAX = 10
    }


    // Enum JackGame.EJackVoicePresetFlag
    public enum EJackVoicePresetFlag : byte
    {
        EJackVoicePresetFlag__InvalidLipSync = 0,
        EJackVoicePresetFlag__MAX = 1
    }


    // Enum JackGame.EJackCoordSound
    public enum EJackCoordSound : byte
    {
        EJackCoordSound__Walk = 0,
        EJackCoordSound__Run = 1,
        EJackCoordSound__Dash = 2,
        EJackCoordSound__ArmUp = 3,
        EJackCoordSound__ArmDown = 4,
        EJackCoordSound__Sit = 5,
        EJackCoordSound__Stand = 6,
        EJackCoordSound__Jump = 7,
        EJackCoordSound__Land = 8,
        EJackCoordSound__Turn = 9,
        EJackCoordSound__ArmHard = 10,
        EJackCoordSound__BodyHard = 11,
        EJackCoordSound__Down = 12,
        EJackCoordSound__CS1 = 13,
        EJackCoordSound__CS2 = 14,
        EJackCoordSound__CS3 = 15,
        EJackCoordSound__CS4 = 16,
        EJackCoordSound__CS5 = 17,
        EJackCoordSound__CS6 = 18,
        EJackCoordSound__CS7 = 19,
        EJackCoordSound__CS8 = 20,
        EJackCoordSound__MAX = 21
    }


    // Enum JackGame.EJackMEType
    public enum EJackMEType : byte
    {
        EJackMEType__Default = 0,
        EJackMEType__BattleWin = 1,
        EJackMEType__Minigame = 2,
        EJackMEType__Dokodemokazi = 3,
        EJackMEType__MAX = 4
    }


    // Enum JackGame.EJackSEADCategoryLayer
    public enum EJackSEADCategoryLayer : byte
    {
        EJackSEADCategoryLayer__Debug = 0,
        EJackSEADCategoryLayer__Game = 1,
        EJackSEADCategoryLayer__Config = 2,
        EJackSEADCategoryLayer__CutScene = 3,
        EJackSEADCategoryLayer__MAX = 4
    }


    // Enum JackGame.EJackCameraFadeZLayer
    public enum EJackCameraFadeZLayer : byte
    {
        EJackCameraFadeZLayer__UMGForeground = 0,
        EJackCameraFadeZLayer__UMGMessage = 1,
        EJackCameraFadeZLayer__UMGUiBackgound = 2,
        EJackCameraFadeZLayer__Camera = 3,
        EJackCameraFadeZLayer__MAX = 4
    }


    // Enum JackGame.EJackCameraFadeCategory
    public enum EJackCameraFadeCategory : byte
    {
        EJackCameraFadeCategory__Menu = 0,
        EJackCameraFadeCategory__MiniGame = 1,
        EJackCameraFadeCategory__CutSceneSkip = 2,
        EJackCameraFadeCategory__CutScene = 3,
        EJackCameraFadeCategory__CutSceneForeground = 4,
        EJackCameraFadeCategory__Level = 5,
        EJackCameraFadeCategory__Battle = 6,
        EJackCameraFadeCategory__Gimmick = 7,
        EJackCameraFadeCategory__Rura = 8,
        EJackCameraFadeCategory__Other = 9,
        EJackCameraFadeCategory__MAX = 10
    }


    // Enum JackGame.EJackCameraControlCategory
    public enum EJackCameraControlCategory : byte
    {
        EJackCameraControlCategory__Battle = 0,
        EJackCameraControlCategory__BattleActionCamera = 1,
        EJackCameraControlCategory__LockEyeViewPoint = 2,
        EJackCameraControlCategory__MAX = 3
    }


    // Enum JackGame.EJackWorldTimeDilation
    public enum EJackWorldTimeDilation : byte
    {
        EJackWorldTimeDilation__None = 0,
        EJackWorldTimeDilation__World = 1,
        EJackWorldTimeDilation__Matinee = 2,
        EJackWorldTimeDilation__DemoPlay = 3,
        EJackWorldTimeDilation__MAX = 4
    }


    // Enum JackGame.EJackVisibility
    public enum EJackVisibility : byte
    {
        EJackVisibility__Hidden = 0,
        EJackVisibility__Visible = 1,
        EJackVisibility__MAX = 2
    }


    // Enum JackGame.EJackUmaRaceGameState
    public enum EJackUmaRaceGameState : byte
    {
        EJackUmaRaceGameState__None = 0,
        EJackUmaRaceGameState__Init = 1,
        EJackUmaRaceGameState__Mount = 2,
        EJackUmaRaceGameState__FadeIn = 3,
        EJackUmaRaceGameState__StartDemo = 4,
        EJackUmaRaceGameState__StartDemo2 = 5,
        EJackUmaRaceGameState__StartDemo3 = 6,
        EJackUmaRaceGameState__Game = 7,
        EJackUmaRaceGameState__Result = 8,
        EJackUmaRaceGameState__ResultDemo = 9,
        EJackUmaRaceGameState__ResultRetire = 10,
        EJackUmaRaceGameState__Unmount = 11,
        EJackUmaRaceGameState__Finish = 12,
        EJackUmaRaceGameState__Max = 13
    }


    // Enum JackGame.EJackUmaRaceFarisFlagState
    public enum EJackUmaRaceFarisFlagState : byte
    {
        EJackUmaRaceFarisFlagState__Before = 0,
        EJackUmaRaceFarisFlagState__After = 1,
        EJackUmaRaceFarisFlagState__Max = 2
    }


    // Enum JackGame.EJackUmaRaceDash
    public enum EJackUmaRaceDash : byte
    {
        EJackUmaRaceDash__None = 0,
        EJackUmaRaceDash__Dash1st = 1,
        EJackUmaRaceDash__Dash2nd = 2,
        EJackUmaRaceDash__Dash3rd = 3,
        EJackUmaRaceDash__Max = 4
    }


    // Enum JackGame.EJackUmaRaceOrbit
    public enum EJackUmaRaceOrbit : byte
    {
        EJackUmaRaceOrbit__None = 0,
        EJackUmaRaceOrbit__Advanced = 1,
        EJackUmaRaceOrbit__Back = 2,
        EJackUmaRaceOrbit__Max = 3
    }


    // Enum JackGame.EJackUmaRaceDashGaugeState
    public enum EJackUmaRaceDashGaugeState : byte
    {
        EJackUmaRaceDashGaugeState__Full = 0,
        EJackUmaRaceDashGaugeState__Slightly = 1,
        EJackUmaRaceDashGaugeState__Nothing = 2,
        EJackUmaRaceDashGaugeState__RecoveryStart = 3,
        EJackUmaRaceDashGaugeState__Recovery = 4,
        EJackUmaRaceDashGaugeState__Max = 5
    }


    // Enum JackGame.EJackUmaRaceEntranceIcon
    public enum EJackUmaRaceEntranceIcon : byte
    {
        EJackUmaRaceEntranceIcon__FrameOnly = 0,
        EJackUmaRaceEntranceIcon__Start01 = 1,
        EJackUmaRaceEntranceIcon__Start02 = 2,
        EJackUmaRaceEntranceIcon__Start03 = 3,
        EJackUmaRaceEntranceIcon__Lock = 4,
        EJackUmaRaceEntranceIcon__CheckMark = 5,
        EJackUmaRaceEntranceIcon__Max = 6
    }


    // Enum JackGame.EJackUmaRaceHorseType
    public enum EJackUmaRaceHorseType : byte
    {
        EJackUmaRaceHorseType__Horse01 = 0,
        EJackUmaRaceHorseType__Horse02 = 1,
        EJackUmaRaceHorseType__Horse03 = 2,
        EJackUmaRaceHorseType__Horse04 = 3,
        EJackUmaRaceHorseType__Horse05 = 4,
        EJackUmaRaceHorseType__Horse06 = 5,
        EJackUmaRaceHorseType__Horse08 = 6,
        EJackUmaRaceHorseType__Random = 7,
        EJackUmaRaceHorseType__Max = 8
    }


    // Enum JackGame.EJackUmaRaceDifficulty
    public enum EJackUmaRaceDifficulty : byte
    {
        EJackUmaRaceDifficulty__Normal = 0,
        EJackUmaRaceDifficulty__Hard = 1,
        EJackUmaRaceDifficulty__Max = 2
    }


    // Enum JackGame.EJackUmaRaceRank
    public enum EJackUmaRaceRank : byte
    {
        EJackUmaRaceRank__None = 0,
        EJackUmaRaceRank__RankS = 1,
        EJackUmaRaceRank__RankA = 2,
        EJackUmaRaceRank__RankB = 3,
        EJackUmaRaceRank__RankC = 4,
        EJackUmaRaceRank__RankD = 5,
        EJackUmaRaceRank__RankFalice = 6,
        EJackUmaRaceRank__Max = 7
    }


    // Enum JackGame.EJackCameraMode
    public enum EJackCameraMode : byte
    {
        None = 0,
        PlayerView = 1,
        BattleView = 2,
        BattleSimpleView = 3,
        BattlePreparationView = 4,
        Rail = 5,
        Debug = 6,
        IndoorView = 7,
        BattleActionView = 8,
        BattleResultView = 9,
        TalkView = 10,
        IndoorTalkView = 11,
        BattleMonsterAppearance = 12,
        FirstPersonView = 13,
        SplinePath = 14,
        FixCameraView = 15,
        FriendTalkView = 16,
        JumpPlayerView = 17,
        BackPlayerView = 18,
        UmaRaceView = 19,
        ChangeTimeView = 20,
        UmaRaceResultView = 21,
        PhotoModeView = 22,
        MAX = 23
    }


    // Enum JackGame.EJackUMGSoubiScreenMode
    public enum EJackUMGSoubiScreenMode : byte
    {
        EJackUMGSoubiScreenMode__CharacterSelect = 0,
        EJackUMGSoubiScreenMode__RegionSelect = 1,
        EJackUMGSoubiScreenMode__ItemSelect = 2,
        EJackUMGSoubiScreenMode__MitameSelect = 3,
        EJackUMGSoubiScreenMode__MAX = 4
    }


    // Enum JackGame.EJackUMGOddEffectFlow
    public enum EJackUMGOddEffectFlow : byte
    {
        EJackUMGOddEffectFlow__None = 0,
        EJackUMGOddEffectFlow__Clear = 1,
        EJackUMGOddEffectFlow__Set = 2,
        EJackUMGOddEffectFlow__Temp = 3,
        EJackUMGOddEffectFlow__MAX = 4
    }


    // Enum JackGame.EJackUMGEquipmentResult
    public enum EJackUMGEquipmentResult : byte
    {
        EJackUMGEquipmentResult__Equipped = 0,
        EJackUMGEquipmentResult__BouguSibari = 1,
        EJackUMGEquipmentResult__DoubleHand = 2,
        EJackUMGEquipmentResult__Cancel = 3,
        EJackUMGEquipmentResult__MAX = 4
    }


    // Enum JackGame.EJackUMGDouguSeiriResult
    public enum EJackUMGDouguSeiriResult : byte
    {
        EJackUMGDouguSeiriResult__ExecutedOK = 0,
        EJackUMGDouguSeiriResult__ExecutedRemove = 1,
        EJackUMGDouguSeiriResult__CancelSeiri = 2,
        EJackUMGDouguSeiriResult__CancelRemove = 3,
        EJackUMGDouguSeiriResult__NoneItem = 4,
        EJackUMGDouguSeiriResult__MAX = 5
    }


    // Enum JackGame.EJackUMGCountBagItemType
    public enum EJackUMGCountBagItemType : byte
    {
        EJackUMGCountBagItemType__SpecifiedBag = 0,
        EJackUMGCountBagItemType__AllMembersBag = 1,
        EJackUMGCountBagItemType__CommonBag = 2,
        EJackUMGCountBagItemType__SpecifiedBagWithCommonBag = 3,
        EJackUMGCountBagItemType__AllBag = 4,
        EJackUMGCountBagItemType__MAX = 5
    }


    // Enum JackGame.EJackUMGShopCurrency
    public enum EJackUMGShopCurrency : byte
    {
        EJackUMGShopCurrency__Gold = 0,
        EJackUMGShopCurrency__Medal = 1,
        EJackUMGShopCurrency__CasinoCoin = 2,
        EJackUMGShopCurrency__MAX = 3
    }


    // Enum JackGame.EJackTuyosaPage
    public enum EJackTuyosaPage : byte
    {
        EJackTuyosaPage__Detail = 0,
        EJackTuyosaPage__Jumon = 1,
        EJackTuyosaPage__Tokugi = 2,
        EJackTuyosaPage__Skill = 3,
        EJackTuyosaPage__Renkei = 4,
        EJackTuyosaPage__Kazi = 5,
        EJackTuyosaPage__Tokusyu = 6,
        EJackTuyosaPage__MAX = 7
    }


    // Enum JackGame.EJackSaveDataSlotIndex
    public enum EJackSaveDataSlotIndex : byte
    {
        EJackSaveDataSlotIndex__Slot0 = 0,
        EJackSaveDataSlotIndex__Slot1 = 1,
        EJackSaveDataSlotIndex__Slot2 = 2,
        EJackSaveDataSlotIndex__Slot3 = 3,
        EJackSaveDataSlotIndex__Slot4 = 4,
        EJackSaveDataSlotIndex__Slot5 = 5,
        EJackSaveDataSlotIndex__Slot6 = 6,
        EJackSaveDataSlotIndex__Slot7 = 7,
        EJackSaveDataSlotIndex__Slot8 = 8,
        EJackSaveDataSlotIndex__AutoSave = 9,
        EJackSaveDataSlotIndex__MAX = 10
    }


    // Enum JackGame.EJackUMGSaveDataCheckResult
    public enum EJackUMGSaveDataCheckResult : byte
    {
        EJackUMGSaveDataCheckResult__Success = 0,
        EJackUMGSaveDataCheckResult__Restore = 1,
        EJackUMGSaveDataCheckResult__ReCreate = 2,
        EJackUMGSaveDataCheckResult__Failed = 3,
        EJackUMGSaveDataCheckResult__NoSpage = 4,
        EJackUMGSaveDataCheckResult__MAX = 5
    }


    // Enum JackGame.EJackUMGSaveDataCheckPoint
    public enum EJackUMGSaveDataCheckPoint : byte
    {
        EJackUMGSaveDataCheckPoint__StartGame = 0,
        EJackUMGSaveDataCheckPoint__OpenSaveDataList = 1,
        EJackUMGSaveDataCheckPoint__CreateSaveData = 2,
        EJackUMGSaveDataCheckPoint__LoadData = 3,
        EJackUMGSaveDataCheckPoint__BeforeSave = 4,
        EJackUMGSaveDataCheckPoint__SaveData = 5,
        EJackUMGSaveDataCheckPoint__AutoSave = 6,
        EJackUMGSaveDataCheckPoint__FusigiNaKaji = 7,
        EJackUMGSaveDataCheckPoint__OpenSaveDataTrial = 8,
        EJackUMGSaveDataCheckPoint__MAX = 9
    }


    // Enum JackGame.EJackUMGMitameSoubiState
    public enum EJackUMGMitameSoubiState : byte
    {
        EJackUMGMitameSoubiState__NotAcquired = 0,
        EJackUMGMitameSoubiState__Disable = 1,
        EJackUMGMitameSoubiState__Validity = 2,
        EJackUMGMitameSoubiState__New = 3,
        EJackUMGMitameSoubiState__None = 4,
        EJackUMGMitameSoubiState__MAX = 5
    }


    // Enum JackGame.EJackUMGSenrekiSortBamen
    public enum EJackUMGSenrekiSortBamen : byte
    {
        EJackUMGSenrekiSortBamen__Monster = 0,
        EJackUMGSenrekiSortBamen__Item = 1,
        EJackUMGSenrekiSortBamen__Syougou = 2,
        EJackUMGSenrekiSortBamen__MAX = 3
    }


    // Enum JackGame.EJackUMGSenrekiSortMode
    public enum EJackUMGSenrekiSortMode : byte
    {
        EJackUMGSenrekiSortMode__GojuuonJun = 0,
        EJackUMGSenrekiSortMode__SyuruiJun = 1,
        EJackUMGSenrekiSortMode__MAX = 2
    }


    // Enum JackGame.EJackUMGSenrekiMonsterMode
    public enum EJackUMGSenrekiMonsterMode : byte
    {
        EJackUMGSenrekiMonsterMode__NowField = 0,
        EJackUMGSenrekiMonsterMode__Seisokuti = 1,
        EJackUMGSenrekiMonsterMode__Keitou = 2,
        EJackUMGSenrekiMonsterMode__AllMonster = 3,
        EJackUMGSenrekiMonsterMode__MAX = 4
    }


    // Enum JackGame.EJackSyuurenjouMenuResult
    public enum EJackSyuurenjouMenuResult : byte
    {
        EJackSyuurenjouMenuResult__Cancel = 0,
        EJackSyuurenjouMenuResult__Ok = 1,
        EJackSyuurenjouMenuResult__MAX = 2
    }


    // Enum JackGame.EJackCameraMedeSelectStick
    public enum EJackCameraMedeSelectStick : byte
    {
        EJackCameraMedeSelectStick__Stick_Neutral = 0,
        EJackCameraMedeSelectStick__Stick_Up = 1,
        EJackCameraMedeSelectStick__Stick_Down = 2,
        EJackCameraMedeSelectStick__Stick_Right = 3,
        EJackCameraMedeSelectStick__Stick_Left = 4,
        EJackCameraMedeSelectStick__Arrow_Right = 5,
        EJackCameraMedeSelectStick__Arrow_Left = 6,
        EJackCameraMedeSelectStick__Arrow_Up = 7,
        EJackCameraMedeSelectStick__Arrow_Down = 8,
        EJackCameraMedeSelectStick__MAX = 9
    }


    // Enum JackGame.EJackUMGCameraModeSelectState
    public enum EJackUMGCameraModeSelectState : byte
    {
        EJackUMGCameraModeSelectState__Initial = 0,
        EJackUMGCameraModeSelectState__WaitRequest = 1,
        EJackUMGCameraModeSelectState__WaitOpen = 2,
        EJackUMGCameraModeSelectState__WaitAfterOpen = 3,
        EJackUMGCameraModeSelectState__WaitAfterPlay = 4,
        EJackUMGCameraModeSelectState__WaitClose = 5,
        EJackUMGCameraModeSelectState__WaitAfterClose = 6,
        EJackUMGCameraModeSelectState__WaitBeforeClose = 7,
        EJackUMGCameraModeSelectState__WaitBeforeReOpen = 8,
        EJackUMGCameraModeSelectState__MAX = 9
    }


    // Enum JackGame.EJackFukubikiLotteryResult
    public enum EJackFukubikiLotteryResult : byte
    {
        EJackFukubikiLotteryResult__ThreeSunMarks = 0,
        EJackFukubikiLotteryResult__ThreeStarMarks = 1,
        EJackFukubikiLotteryResult__ThreeMoonMarks = 2,
        EJackFukubikiLotteryResult__ThreeWaterMarks = 3,
        EJackFukubikiLotteryResult__ThreeHeartMarks = 4,
        EJackFukubikiLotteryResult__TwoSunMarks = 5,
        EJackFukubikiLotteryResult__TwoStarMarks = 6,
        EJackFukubikiLotteryResult__TwoMoonMarks = 7,
        EJackFukubikiLotteryResult__TwoWaterMarks = 8,
        EJackFukubikiLotteryResult__TwoHeartMarks = 9,
        EJackFukubikiLotteryResult__NoPear = 10,
        EJackFukubikiLotteryResult__MAX = 11
    }


    // Enum JackGame.EJackFukubikiMark
    public enum EJackFukubikiMark : byte
    {
        EJackFukubikiMark__Sun = 0,
        EJackFukubikiMark__Star = 1,
        EJackFukubikiMark__Moon = 2,
        EJackFukubikiMark__Water = 3,
        EJackFukubikiMark__Heart = 4,
        EJackFukubikiMark__MAX = 5
    }


    // Enum JackGame.EJackUMGTurnAction
    public enum EJackUMGTurnAction : byte
    {
        EJackUMGTurnAction__Normal = 0,
        EJackUMGTurnAction__Appear = 1,
        EJackUMGTurnAction__Disappear = 2,
        EJackUMGTurnAction__MAX = 3
    }


    // Enum JackGame.EJackUMGMapResourceType
    public enum EJackUMGMapResourceType : byte
    {
        EJackUMGMapResourceType__MapOpenTexture = 0,
        EJackUMGMapResourceType__MapMaskTexture = 1,
        EJackUMGMapResourceType__MiniMapTexture = 2,
        EJackUMGMapResourceType__JourneyTexture = 3,
        EJackUMGMapResourceType__MapTextWidget = 4,
        EJackUMGMapResourceType__MAX = 5
    }


    // Enum JackGame.EJackMedalStampAnimFlag
    public enum EJackMedalStampAnimFlag : byte
    {
        EJackMedalStampAnimFlag__None = 0,
        EJackMedalStampAnimFlag__Wait = 1,
        EJackMedalStampAnimFlag__Stamp = 2,
        EJackMedalStampAnimFlag__StampMiddle = 3,
        EJackMedalStampAnimFlag__StampLarge = 4,
        EJackMedalStampAnimFlag__ShowTreasureBox = 5,
        EJackMedalStampAnimFlag__ShowRareTreasureBox = 6,
        EJackMedalStampAnimFlag__HideTreasureBox = 7,
        EJackMedalStampAnimFlag__ShowItemGetMessage = 8,
        EJackMedalStampAnimFlag__UpdateItemInfo = 9,
        EJackMedalStampAnimFlag__ShowBottomInfo = 10,
        EJackMedalStampAnimFlag__HideBottomInfo = 11,
        EJackMedalStampAnimFlag__ShowCompleteMessage = 12,
        EJackMedalStampAnimFlag__ShowCompleteStamp = 13,
        EJackMedalStampAnimFlag__NextPageMessage = 14,
        EJackMedalStampAnimFlag__ShowPage = 15,
        EJackMedalStampAnimFlag__HidePage = 16,
        EJackMedalStampAnimFlag__FullComplete = 17,
        EJackMedalStampAnimFlag__MAX = 18
    }


    // Enum JackGame.EJackSaveSlotSearchType
    public enum EJackSaveSlotSearchType : byte
    {
        EJackSaveSlotSearchType__None = 0,
        EJackSaveSlotSearchType__Empty = 1,
        EJackSaveSlotSearchType__Latest = 2,
        EJackSaveSlotSearchType__SmallNumber = 3,
        EJackSaveSlotSearchType__MAX = 4
    }


    // Enum JackGame.EJackUMGModeSelectMovieState
    public enum EJackUMGModeSelectMovieState : byte
    {
        EJackUMGModeSelectMovieState__Initial = 0,
        EJackUMGModeSelectMovieState__WaitInitialize = 1,
        EJackUMGModeSelectMovieState__WaitReadyToPlay = 2,
        EJackUMGModeSelectMovieState__WaitEndFadeIn = 3,
        EJackUMGModeSelectMovieState__PlayMovie = 4,
        EJackUMGModeSelectMovieState__MAX = 5
    }


    // Enum JackGame.EJackSerifuWindowEmojiFlag
    public enum EJackSerifuWindowEmojiFlag : byte
    {
        EJackSerifuWindowEmojiFlag__Ignore = 0,
        EJackSerifuWindowEmojiFlag__Normal = 1,
        EJackSerifuWindowEmojiFlag__Reverse = 2,
        EJackSerifuWindowEmojiFlag__MAX = 3
    }


    // Enum JackGame.EJackSelectWindowType
    public enum EJackSelectWindowType : byte
    {
        EJackSelectWindowType__Default = 0,
        EJackSelectWindowType__YesOrNo = 1,
        EJackSelectWindowType__HotelRaiseTime = 2,
        EJackSelectWindowType__Custom = 3,
        EJackSelectWindowType__Blacksmith = 4,
        EJackSelectWindowType__MAX = 5
    }


    // Enum JackGame.EJackTokugiMatomeIconAnim
    public enum EJackTokugiMatomeIconAnim : byte
    {
        EJackTokugiMatomeIconAnim__None = 0,
        EJackTokugiMatomeIconAnim__Circle_On = 1,
        EJackTokugiMatomeIconAnim__Check_On = 2,
        EJackTokugiMatomeIconAnim__Lock_On = 3,
        EJackTokugiMatomeIconAnim__Star_On = 4,
        EJackTokugiMatomeIconAnim__Secret_On = 5,
        EJackTokugiMatomeIconAnim__Circle_In_Out = 6,
        EJackTokugiMatomeIconAnim__Check_In_Out = 7,
        EJackTokugiMatomeIconAnim__Secret_In_Out = 8,
        EJackTokugiMatomeIconAnim__Check_To_Lock = 9,
        EJackTokugiMatomeIconAnim__Check_To_Star = 10,
        EJackTokugiMatomeIconAnim__MAX = 11
    }


    // Enum JackGame.EJackTokugiPieceAnim
    public enum EJackTokugiPieceAnim : byte
    {
        EJackTokugiPieceAnim__None = 0,
        EJackTokugiPieceAnim__Close = 1,
        EJackTokugiPieceAnim__Open = 2,
        EJackTokugiPieceAnim__ProvMaster = 3,
        EJackTokugiPieceAnim__Master = 4,
        EJackTokugiPieceAnim__Change_Master = 5,
        EJackTokugiPieceAnim__Change_Master01 = 6,
        EJackTokugiPieceAnim__ChangeGrow_Open = 7,
        EJackTokugiPieceAnim__Change_ProvMaster = 8,
        EJackTokugiPieceAnim__ChangeGrow_ProvMasterFromClose = 9,
        EJackTokugiPieceAnim__ChangeGrow_MasterFromProvMaster = 10,
        EJackTokugiPieceAnim__ChangeRoll_Open = 11,
        EJackTokugiPieceAnim__ChangeRoll_ProvMasterFromClose = 12,
        EJackTokugiPieceAnim__ChangeRoll_MasterFromClose_Reset = 13,
        EJackTokugiPieceAnim__ChangeRoll_MasterFromOpen_Reset = 14,
        EJackTokugiPieceAnim__Roll_Close = 15,
        EJackTokugiPieceAnim__MAX = 16
    }


    // Enum JackGame.EJackTokugiQuestionAnim
    public enum EJackTokugiQuestionAnim : byte
    {
        EJackTokugiQuestionAnim__None = 0,
        EJackTokugiQuestionAnim__Dark = 1,
        EJackTokugiQuestionAnim__Bright = 2,
        EJackTokugiQuestionAnim__Change_Open = 3,
        EJackTokugiQuestionAnim__Change_Dark_Bright = 4,
        EJackTokugiQuestionAnim__Reset_Dark_Dark = 5,
        EJackTokugiQuestionAnim__Reset_Dark_Bright = 6,
        EJackTokugiQuestionAnim__Reset_Bright_Bright = 7,
        EJackTokugiQuestionAnim__Reset_Bright_Open = 8,
        EJackTokugiQuestionAnim__Reset_Dark_Open = 9,
        EJackTokugiQuestionAnim__Open_Dark = 10,
        EJackTokugiQuestionAnim__Open_Bright = 11,
        EJackTokugiQuestionAnim__Dark_Dark = 12,
        EJackTokugiQuestionAnim__Bright_Bright = 13,
        EJackTokugiQuestionAnim__Bright_Dark = 14,
        EJackTokugiQuestionAnim__Close_Old = 15,
        EJackTokugiQuestionAnim__Cracked_Old = 16,
        EJackTokugiQuestionAnim__Open_Crack_Old = 17,
        EJackTokugiQuestionAnim__Crack_Close_Old = 18,
        EJackTokugiQuestionAnim__Open_Close_Old = 19,
        EJackTokugiQuestionAnim__Crack_Crack_Old = 20,
        EJackTokugiQuestionAnim__Reset_Crack_Crack_Old = 21,
        EJackTokugiQuestionAnim__Reset_Crack_Open_Old = 22,
        EJackTokugiQuestionAnim__Reset_Close_Open_Old = 23,
        EJackTokugiQuestionAnim__Reset_Close_Crack_Old = 24,
        EJackTokugiQuestionAnim__MAX = 25
    }


    // Enum JackGame.EJackTokugiPanelMessageAnimFlag
    public enum EJackTokugiPanelMessageAnimFlag : byte
    {
        EJackTokugiPanelMessageAnimFlag__ReleaseLock = 0,
        EJackTokugiPanelMessageAnimFlag__Master = 1,
        EJackTokugiPanelMessageAnimFlag__ClosedOtherSkillLinePanel = 2,
        EJackTokugiPanelMessageAnimFlag__SkillResetSuccess = 3,
        EJackTokugiPanelMessageAnimFlag__ResetAndClosedOtherLine = 4,
        EJackTokugiPanelMessageAnimFlag__NotifyLearnedRenkei = 5,
        EJackTokugiPanelMessageAnimFlag__DisplayAchievement = 6,
        EJackTokugiPanelMessageAnimFlag__ShowAtariEffect = 7,
        EJackTokugiPanelMessageAnimFlag__MAX = 8
    }


    // Enum JackGame.EJackTokugiPanelAnimFlag
    public enum EJackTokugiPanelAnimFlag : byte
    {
        EJackTokugiPanelAnimFlag__None = 0,
        EJackTokugiPanelAnimFlag__Open = 1,
        EJackTokugiPanelAnimFlag__Master = 2,
        EJackTokugiPanelAnimFlag__Crack = 3,
        EJackTokugiPanelAnimFlag__HideSelectCursol = 4,
        EJackTokugiPanelAnimFlag__ShowSelectCursol = 5,
        EJackTokugiPanelAnimFlag__Wait = 6,
        EJackTokugiPanelAnimFlag__ProvMaster = 7,
        EJackTokugiPanelAnimFlag__CancelProvMaster = 8,
        EJackTokugiPanelAnimFlag__CancelOpen = 9,
        EJackTokugiPanelAnimFlag__CloseFromProvMater = 10,
        EJackTokugiPanelAnimFlag__CancelCrack = 11,
        EJackTokugiPanelAnimFlag__MasterFromProvMaster = 12,
        EJackTokugiPanelAnimFlag__HideSkillLineEffect = 13,
        EJackTokugiPanelAnimFlag__ShowSkillLineEffect = 14,
        EJackTokugiPanelAnimFlag__ProvMasterFromClose = 15,
        EJackTokugiPanelAnimFlag__ResetEffect = 16,
        EJackTokugiPanelAnimFlag__CancelMaster = 17,
        EJackTokugiPanelAnimFlag__CloseFromMater = 18,
        EJackTokugiPanelAnimFlag__PanelResetEffect = 19,
        EJackTokugiPanelAnimFlag__StateOpen = 20,
        EJackTokugiPanelAnimFlag__StateClose = 21,
        EJackTokugiPanelAnimFlag__ShowListUpdateEffect = 22,
        EJackTokugiPanelAnimFlag__DisplayMessage = 23,
        EJackTokugiPanelAnimFlag__MAX = 24
    }


    // Enum JackGame.EJackTokugiPanelAnimCategory
    public enum EJackTokugiPanelAnimCategory : byte
    {
        EJackTokugiPanelAnimCategory__None = 0,
        EJackTokugiPanelAnimCategory__ReleaseLockPanel = 1,
        EJackTokugiPanelAnimCategory__ExecuteMaster = 2,
        EJackTokugiPanelAnimCategory__ToggleProvMaster = 3,
        EJackTokugiPanelAnimCategory__ExecuteMultiMaster = 4,
        EJackTokugiPanelAnimCategory__CancelMultiMaster = 5,
        EJackTokugiPanelAnimCategory__ResumeMultiMaster = 6,
        EJackTokugiPanelAnimCategory__ExecuteSkillReset = 7,
        EJackTokugiPanelAnimCategory__EJackTokugiPanelAnimCategory_MAX = 8
    }


    // Enum JackGame.EJackTokugiPanelAdjoinPieceState
    public enum EJackTokugiPanelAdjoinPieceState : byte
    {
        EJackTokugiPanelAdjoinPieceState__NotExist = 0,
        EJackTokugiPanelAdjoinPieceState__Close = 1,
        EJackTokugiPanelAdjoinPieceState__Open = 2,
        EJackTokugiPanelAdjoinPieceState__ProvMaster = 3,
        EJackTokugiPanelAdjoinPieceState__Master = 4,
        EJackTokugiPanelAdjoinPieceState__MAX = 5
    }


    // Enum JackGame.EJackTokugiPanelPieceState
    public enum EJackTokugiPanelPieceState : byte
    {
        EJackTokugiPanelPieceState__Close = 0,
        EJackTokugiPanelPieceState__Open = 1,
        EJackTokugiPanelPieceState__Master = 2,
        EJackTokugiPanelPieceState__MAX = 3
    }


    // Enum JackGame.EJackTokugiPanelPageType
    public enum EJackTokugiPanelPageType : byte
    {
        EJackTokugiPanelPageType__CharacterSelect = 0,
        EJackTokugiPanelPageType__SkillLineSelect = 1,
        EJackTokugiPanelPageType__SkillList = 2,
        EJackTokugiPanelPageType__MultiMaster = 3,
        EJackTokugiPanelPageType__SkillDescription = 4,
        EJackTokugiPanelPageType__TokugiPanel = 5,
        EJackTokugiPanelPageType__SkillReset = 6,
        EJackTokugiPanelPageType__MAX = 7
    }


    // Enum JackGame.EJackTokugiPanelAdjoinPanelOpenTiming
    public enum EJackTokugiPanelAdjoinPanelOpenTiming : byte
    {
        EJackTokugiPanelAdjoinPanelOpenTiming__Learning = 0,
        EJackTokugiPanelAdjoinPanelOpenTiming__AfterLearnMessage = 1,
        EJackTokugiPanelAdjoinPanelOpenTiming__AfterOtherAnim = 2,
        EJackTokugiPanelAdjoinPanelOpenTiming__ShowSelectCursol = 3,
        EJackTokugiPanelAdjoinPanelOpenTiming__MAX = 4
    }


    // Enum JackGame.EJackUMGModeSelectGotoState
    public enum EJackUMGModeSelectGotoState : byte
    {
        EJackUMGModeSelectGotoState__GotoCameraMode = 0,
        EJackUMGModeSelectGotoState__Goto2dGameMode = 1,
        EJackUMGModeSelectGotoState__GotoPreviousMode = 2,
        EJackUMGModeSelectGotoState__MAX = 3
    }


    // Enum JackGame.EJackTokugiPanelWindowMode
    public enum EJackTokugiPanelWindowMode : byte
    {
        EJackTokugiPanelWindowMode__Normal = 0,
        EJackTokugiPanelWindowMode__BattleResult = 1,
        EJackTokugiPanelWindowMode__Reset = 2,
        EJackTokugiPanelWindowMode__MAX = 3
    }


    // Enum JackGame.EJackVoiceDramaTag
    public enum EJackVoiceDramaTag : byte
    {
        EJackVoiceDramaTag__End = 0,
        EJackVoiceDramaTag__Wait = 1,
        EJackVoiceDramaTag__WaitTag = 2,
        EJackVoiceDramaTag__PageFade = 3,
        EJackVoiceDramaTag__TextHide = 4,
        EJackVoiceDramaTag__TalkerShow = 5,
        EJackVoiceDramaTag__LogModeEnd = 6,
        EJackVoiceDramaTag__BG = 7,
        EJackVoiceDramaTag__BGHide = 8,
        EJackVoiceDramaTag__BGWait = 9,
        EJackVoiceDramaTag__Image = 10,
        EJackVoiceDramaTag__ImageHide = 11,
        EJackVoiceDramaTag__ImageWait = 12,
        EJackVoiceDramaTag__FadeOut = 13,
        EJackVoiceDramaTag__FadeIn = 14,
        EJackVoiceDramaTag__FadeWait = 15,
        EJackVoiceDramaTag__BGMPlay = 16,
        EJackVoiceDramaTag__BGMStop = 17,
        EJackVoiceDramaTag__BGMWait = 18,
        EJackVoiceDramaTag__EnvPlay = 19,
        EJackVoiceDramaTag__EnvStop = 20,
        EJackVoiceDramaTag__EnvWait = 21,
        EJackVoiceDramaTag__VoicePlay = 22,
        EJackVoiceDramaTag__VoiceWait = 23,
        EJackVoiceDramaTag__SEPlay = 24,
        EJackVoiceDramaTag__SEWait = 25,
        EJackVoiceDramaTag__MEPlay = 26,
        EJackVoiceDramaTag__Pafupafu = 27,
        EJackVoiceDramaTag__StaffRoll = 28,
        EJackVoiceDramaTag__MAX = 29
    }


    // Enum JackGame.EJackVoiceDramaSelectEShop
    public enum EJackVoiceDramaSelectEShop : byte
    {
        EJackVoiceDramaSelectEShop__InputDLCNumber = 0,
        EJackVoiceDramaSelectEShop__BuyAddContent = 1,
        EJackVoiceDramaSelectEShop__CancelDLC = 2,
        EJackVoiceDramaSelectEShop__MAX = 3
    }


    // Enum JackGame.EJackVoiceDramaHDPafuPafuSoundEffectTag
    public enum EJackVoiceDramaHDPafuPafuSoundEffectTag : byte
    {
        EJackVoiceDramaHDPafuPafuSoundEffectTag__PafuunLow = 0,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__PafuunHigh = 1,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__PafuunMostHigh = 2,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__Descent = 3,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__Rise = 4,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__CurtainOpen = 5,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__CurtainClose = 6,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__Knockout = 7,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__Whiteout = 8,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__Doon = 9,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__CountDown = 10,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__Start = 11,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__Finish = 12,
        EJackVoiceDramaHDPafuPafuSoundEffectTag__EJackVoiceDramaHDPafuPafuSoundEffectTag_MAX = 13
    }


    // Enum JackGame.EJackVoiceDramaSelectDLCCompleteMode
    public enum EJackVoiceDramaSelectDLCCompleteMode : byte
    {
        EJackVoiceDramaSelectDLCCompleteMode__FromTitle = 0,
        EJackVoiceDramaSelectDLCCompleteMode__FromVoiceDrama = 1,
        EJackVoiceDramaSelectDLCCompleteMode__RemainSelect = 2,
        EJackVoiceDramaSelectDLCCompleteMode__CompleteDLC = 3,
        EJackVoiceDramaSelectDLCCompleteMode__FromStaffList = 4,
        EJackVoiceDramaSelectDLCCompleteMode__InVoiceDrama = 5,
        EJackVoiceDramaSelectDLCCompleteMode__InEShop = 6,
        EJackVoiceDramaSelectDLCCompleteMode__MAX = 7
    }


    // Enum JackGame.EJackUMGBackgroundColor
    public enum EJackUMGBackgroundColor : byte
    {
        EJackUMGBackgroundColor__None = 0,
        EJackUMGBackgroundColor__BlackWindow = 1,
        EJackUMGBackgroundColor__PaleOrange = 2,
        EJackUMGBackgroundColor__Brown = 3,
        EJackUMGBackgroundColor__MAX = 4
    }


    // Enum JackGame.EJackUMGWindowCursorMoveDirection
    public enum EJackUMGWindowCursorMoveDirection : byte
    {
        EJackUMGWindowCursorMoveDirection__Left = 0,
        EJackUMGWindowCursorMoveDirection__Up = 1,
        EJackUMGWindowCursorMoveDirection__Right = 2,
        EJackUMGWindowCursorMoveDirection__Down = 3,
        EJackUMGWindowCursorMoveDirection__MAX = 4
    }


    // Enum JackGame.EJackUMGCheckValueInput
    public enum EJackUMGCheckValueInput : byte
    {
        EJackUMGCheckValueInput__CanDown = 0,
        EJackUMGCheckValueInput__CanUp = 1,
        EJackUMGCheckValueInput__MAX = 2
    }


    // Enum JackGame.EJackVehicleParameterStateMachineFlags
    public enum EJackVehicleParameterStateMachineFlags : byte
    {
        EJackVehicleParameterStateMachineFlags__WaitToWalkRun = 0,
        EJackVehicleParameterStateMachineFlags__WalkRunToEnterTurnBack1 = 1,
        EJackVehicleParameterStateMachineFlags__EnterTurnBack1ToTurnBackLeft1 = 2,
        EJackVehicleParameterStateMachineFlags__EnterTurnBack1ToTurnBackRight1 = 3,
        EJackVehicleParameterStateMachineFlags__WaitToEnterTurn1 = 4,
        EJackVehicleParameterStateMachineFlags__WalkRunToEnterTurn1 = 5,
        EJackVehicleParameterStateMachineFlags__EnterTurn1ToTurnRight1 = 6,
        EJackVehicleParameterStateMachineFlags__EnterTurn1ToTurnLeft1 = 7,
        EJackVehicleParameterStateMachineFlags__TurnRight1ToEnterTurnBack1 = 8,
        EJackVehicleParameterStateMachineFlags__TurnLeft1ToEnterTurnBack1 = 9,
        EJackVehicleParameterStateMachineFlags__TurnLeft1ToExitTurn1 = 10,
        EJackVehicleParameterStateMachineFlags__TurnRight1ToExitTurn1 = 11,
        EJackVehicleParameterStateMachineFlags__TurnLeft1InTurnLeft1_1ToTurnLeft1 = 12,
        EJackVehicleParameterStateMachineFlags__TurnLeft1InTurnLeft1_2ToTurnLeft1 = 13,
        EJackVehicleParameterStateMachineFlags__TurnRight1InTurnRight1_1ToTurnRight1 = 14,
        EJackVehicleParameterStateMachineFlags__TurnRight1InTurnRight1_2ToTurnRight1 = 15,
        EJackVehicleParameterStateMachineFlags__ExitTurn1ToWalkRun = 16,
        EJackVehicleParameterStateMachineFlags__ExitTurn1ToWait = 17,
        EJackVehicleParameterStateMachineFlags__TurnLeft1ToDashStart = 18,
        EJackVehicleParameterStateMachineFlags__TurnRight1ToDashStart = 19,
        EJackVehicleParameterStateMachineFlags__WalkRunToDashStart = 20,
        EJackVehicleParameterStateMachineFlags__DashStartToDash = 21,
        EJackVehicleParameterStateMachineFlags__DashToDashStart = 22,
        EJackVehicleParameterStateMachineFlags__DashStartWalkRun = 23,
        EJackVehicleParameterStateMachineFlags__DashToRunStop = 24,
        EJackVehicleParameterStateMachineFlags__WalkRunToRunStop = 25,
        EJackVehicleParameterStateMachineFlags__WalkRunToWait = 26,
        EJackVehicleParameterStateMachineFlags__WalkRunToJumpStart = 27,
        EJackVehicleParameterStateMachineFlags__DashToJumpStart = 28,
        EJackVehicleParameterStateMachineFlags__JumpLoopToJumpEnd = 29,
        EJackVehicleParameterStateMachineFlags__JumpLoopToWalkRun = 30,
        EJackVehicleParameterStateMachineFlags__JumpLoopToDash = 31,
        EJackVehicleParameterStateMachineFlags__JumpEndToWalkRun = 32,
        EJackVehicleParameterStateMachineFlags__JumpEndToDash = 33,
        EJackVehicleParameterStateMachineFlags__WalkRunToFall = 34,
        EJackVehicleParameterStateMachineFlags__FallToFallEnd = 35,
        EJackVehicleParameterStateMachineFlags__CanCancelTurnBackLeft1ToWalkRun = 36,
        EJackVehicleParameterStateMachineFlags__CanCancelTurnBackRight1ToWalkRun = 37,
        EJackVehicleParameterStateMachineFlags__WalkRunToGride = 38,
        EJackVehicleParameterStateMachineFlags__GrideToWalkRun = 39,
        EJackVehicleParameterStateMachineFlags__WaitToRunForward = 40,
        EJackVehicleParameterStateMachineFlags__WaitToRunBack = 41,
        EJackVehicleParameterStateMachineFlags__RunForwardToWait = 42,
        EJackVehicleParameterStateMachineFlags__RunBackToWait = 43,
        EJackVehicleParameterStateMachineFlags__WaitToClimbing = 44,
        EJackVehicleParameterStateMachineFlags__ClimbingToWait = 45,
        EJackVehicleParameterStateMachineFlags__ForceRunStopToWait = 46,
        EJackVehicleParameterStateMachineFlags__ForceStopToWait = 47,
        EJackVehicleParameterStateMachineFlags__MAX = 48
    }


    // Enum JackGame.EJackVehicleParameterBool
    public enum EJackVehicleParameterBool : byte
    {
        EJackVehicleParameterBool__IsEnableCancelJumpEnd = 0,
        EJackVehicleParameterBool__IsDashRequestEnable = 1,
        EJackVehicleParameterBool__IsDashRequest = 2,
        EJackVehicleParameterBool__IsInDash = 3,
        EJackVehicleParameterBool__IsDashEndRequest = 4,
        EJackVehicleParameterBool__IsRequestDashCancel = 5,
        EJackVehicleParameterBool__IsRequestStop = 6,
        EJackVehicleParameterBool__IsRequestJump = 7,
        EJackVehicleParameterBool__IsInJump = 8,
        EJackVehicleParameterBool__IsRequestJumpEnd = 9,
        EJackVehicleParameterBool__IsInAir = 10,
        EJackVehicleParameterBool__IsCancelTurnBack = 11,
        EJackVehicleParameterBool__IsUnmountEnable = 12,
        EJackVehicleParameterBool__IsGride = 13,
        EJackVehicleParameterBool__IsJumpUp = 14,
        EJackVehicleParameterBool__IsV104Climbing = 15,
        EJackVehicleParameterBool__IsV104ClimbingUp = 16,
        EJackVehicleParameterBool__IsV104ClimbingChanging = 17,
        EJackVehicleParameterBool__IsForceWalkDash = 18,
        EJackVehicleParameterBool__IsV102JumpStart = 19,
        EJackVehicleParameterBool__IsV105GridRun = 20,
        EJackVehicleParameterBool__IsMovementEnabled = 21,
        EJackVehicleParameterBool__ForceRunStopToWait = 22,
        EJackVehicleParameterBool__ForceStopToWait = 23,
        EJackVehicleParameterBool__IsInRoar = 24,
        EJackVehicleParameterBool__V203_WhaleRoar_Mode = 25,
        EJackVehicleParameterBool__V203_AdditiveOn = 26,
        EJackVehicleParameterBool__IsMount = 27,
        EJackVehicleParameterBool__MAX = 28
    }


    // Enum JackGame.EJackVehicleParameterFloat
    public enum EJackVehicleParameterFloat : byte
    {
        EJackVehicleParameterFloat__TurnAngle = 0,
        EJackVehicleParameterFloat__CrrectedRawInputRate = 1,
        EJackVehicleParameterFloat__ForwardingRate = 2,
        EJackVehicleParameterFloat__MoveMotionBlendRate = 3,
        EJackVehicleParameterFloat__MoveMotionBlendRateReverse = 4,
        EJackVehicleParameterFloat__MoveMotionBlendRateReverseRate = 5,
        EJackVehicleParameterFloat__MoveMotionTurnAngleRate = 6,
        EJackVehicleParameterFloat__TurnOutAngle = 7,
        EJackVehicleParameterFloat__TurnInAngle = 8,
        EJackVehicleParameterFloat__CanTurnMoveMotionBlendRate = 9,
        EJackVehicleParameterFloat__WalkForwardingRate = 10,
        EJackVehicleParameterFloat__RunForwardingRate = 11,
        EJackVehicleParameterFloat__TurnBackAngle = 12,
        EJackVehicleParameterFloat__MotionTurnAngleCalcRate = 13,
        EJackVehicleParameterFloat__WalkRunRootMotionMultiplier = 14,
        EJackVehicleParameterFloat__RunOutForwardingRate = 15,
        EJackVehicleParameterFloat__DashEndInterpolationRate = 16,
        EJackVehicleParameterFloat__ToDashInterpolationSpeed = 17,
        EJackVehicleParameterFloat__ToRunInterpolationSpeed = 18,
        EJackVehicleParameterFloat__ToWalkInterpolationSpeed = 19,
        EJackVehicleParameterFloat__ToStopInterpolationSpeed = 20,
        EJackVehicleParameterFloat__V104ClimbMoveRate = 21,
        EJackVehicleParameterFloat__JumpStartMotionAnimationRate = 22,
        EJackVehicleParameterFloat__GrideStateSecV105 = 23,
        EJackVehicleParameterFloat__GrideStateSecV105Gride = 24,
        EJackVehicleParameterFloat__GrideStateSecV105Run = 25,
        EJackVehicleParameterFloat__RoarV203Timer = 26,
        EJackVehicleParameterFloat__RoarV203RequestOffTimer = 27,
        EJackVehicleParameterFloat__AddUpAlphaRate = 28,
        EJackVehicleParameterFloat__AddDownAlphaRate = 29,
        EJackVehicleParameterFloat__MAX = 30
    }


    // Enum JackGame.EJackWeaponHiddenPurpose
    public enum EJackWeaponHiddenPurpose : byte
    {
        EJackWeaponHiddenPurpose__Engine = 0,
        EJackWeaponHiddenPurpose__Owner = 1,
        EJackWeaponHiddenPurpose__Matinee = 2,
        EJackWeaponHiddenPurpose__Renkei = 3,
        EJackWeaponHiddenPurpose__Field = 4,
        EJackWeaponHiddenPurpose__EquipmentControlComponent = 5,
        EJackWeaponHiddenPurpose__AttachSocket = 6,
        EJackWeaponHiddenPurpose__MAX = 7
    }


    // Enum JackGame.EJackVoiceDramaSelectAnimButton
    public enum EJackVoiceDramaSelectAnimButton : byte
    {
        EJackVoiceDramaSelectAnimButton__Plus = 0,
        EJackVoiceDramaSelectAnimButton__Minus = 1,
        EJackVoiceDramaSelectAnimButton__XButton = 2,
        EJackVoiceDramaSelectAnimButton__MAX = 3
    }

    // Enum JackAnimNodeRuntime.EJackAnimPhysSimSpaceType
    public enum EJackAnimPhysSimSpaceType : byte
    {
        EJackAnimPhysSimSpaceType__Component = 0,
        EJackAnimPhysSimSpaceType__Actor = 1,
        EJackAnimPhysSimSpaceType__World = 2,
        EJackAnimPhysSimSpaceType__RootRelative = 3,
        EJackAnimPhysSimSpaceType__BoneRelative = 4,
        EJackAnimPhysSimSpaceType__EJackAnimPhysSimSpaceType_MAX = 5
    }

    // Enum JackAnimNodeRuntime.EJackWindEffectDecayRate
    public enum EJackWindEffectDecayRate : byte
    {
        EJackWindEffectDecayRate__NoDecay = 0,
        EJackWindEffectDecayRate__Linear = 1,
        EJackWindEffectDecayRate__Square = 2,
        EJackWindEffectDecayRate__EJackWindEffectDecayRate_MAX = 3
    };

    // Enum JackAnimNodeRuntime.EJackAnimPhysLinearConstraintType
    public enum EJackAnimPhysLinearConstraintType : byte
    {
        EJackAnimPhysLinearConstraintType__Free = 0,
        EJackAnimPhysLinearConstraintType__Limited = 1,
        EJackAnimPhysLinearConstraintType__EJackAnimPhysLinearConstraintType_MAX = 2
    }

    // Enum JackAnimNodeRuntime.EJackAnimPhysAngularConstraintType
    public enum EJackAnimPhysAngularConstraintType : byte
    {
        EJackAnimPhysAngularConstraintType__Angular = 0,
        EJackAnimPhysAngularConstraintType__Cone = 1,
        EJackAnimPhysAngularConstraintType__EJackAnimPhysAngularConstraintType_MAX = 2
    }

    // Enum JackAnimNodeRuntime.EJackAnimDynamicsSphericalLimitType
    public enum EJackAnimDynamicsSphericalLimitType : byte
    {
        EJackAnimDynamicsSphericalLimitType__Inner = 0,
        EJackAnimDynamicsSphericalLimitType__Outer = 1,
        EJackAnimDynamicsSphericalLimitType__EJackAnimDynamicsSphericalLimitType_MAX = 2
    }

    // Enum JackAnimNodeRuntime.EJackMantleDynamicBoneState
    public enum EJackMantleDynamicBoneState : byte
    {
        EJackMantleDynamicBoneState__Default = 0,
        EJackMantleDynamicBoneState__Sim_CapeMantle = 1,
        EJackMantleDynamicBoneState__Sim_MantleC = 2,
        EJackMantleDynamicBoneState__Sim_MantleC_N013 = 3,
        EJackMantleDynamicBoneState__Sim_MantleB = 4,
        EJackMantleDynamicBoneState__Sim_CapeMantle_N002 = 5,
        EJackMantleDynamicBoneState__Sim_MantleC_N002 = 6,
        EJackMantleDynamicBoneState__Sim_MantleC_N014 = 7,
        EJackMantleDynamicBoneState__Sim_MantleC_P004 = 8,
        EJackMantleDynamicBoneState__Sim_MantleC_P008 = 9,
        EJackMantleDynamicBoneState__Sim_MantleC_P007 = 10,
        EJackMantleDynamicBoneState__Sim_MantleC_P002 = 11,
        EJackMantleDynamicBoneState__EJackMantleDynamicBoneState_MAX = 12
    }


    // Enum JackAnimNodeRuntime.EJackHairDynamicBoneState
    public enum EJackHairDynamicBoneState : byte
    {
        EJackHairDynamicBoneState__Default = 0,
        EJackHairDynamicBoneState__Pose_P008Hair = 1,
        EJackHairDynamicBoneState__Pose_P004Hair = 2,
        EJackHairDynamicBoneState__Pose_N101Hair = 3,
        EJackHairDynamicBoneState__Pose_N001Hair = 4,
        EJackHairDynamicBoneState__Pose_P003Hair = 5,
        EJackHairDynamicBoneState__Sim_P004ShortHair = 6,
        EJackHairDynamicBoneState__Sim_ShortHairUpMidLow = 7,
        EJackHairDynamicBoneState__Sim_C_RearHairH = 8,
        EJackHairDynamicBoneState__Sim_C_RearHairA = 9,
        EJackHairDynamicBoneState__Sim_PlayerHair = 10,
        EJackHairDynamicBoneState__Sim_LR_RearHairA = 11,
        EJackHairDynamicBoneState__Pose_LR_RearHairD1 = 12,
        EJackHairDynamicBoneState__Pose_C_RearHairB1 = 13,
        EJackHairDynamicBoneState__Pose_LR_SideHairI1 = 14,
        EJackHairDynamicBoneState__Pose_C_RearHairG1 = 15,
        EJackHairDynamicBoneState__Pose_LR_SideHairJ1 = 16,
        EJackHairDynamicBoneState__Pose_RearHairILL = 17,
        EJackHairDynamicBoneState__Pose_RearHairKPP = 18,
        EJackHairDynamicBoneState__Pose_SideHairF1 = 19,
        EJackHairDynamicBoneState__Pose_C_RearHairL1 = 20,
        EJackHairDynamicBoneState__Pose_LR_SideHairK1 = 21,
        EJackHairDynamicBoneState__Pose_R_FrontHairE1 = 22,
        EJackHairDynamicBoneState__Pose_ChestHairA1 = 23,
        EJackHairDynamicBoneState__Pose_NeckHoodA1 = 24,
        EJackHairDynamicBoneState__Pose_HeadVeilB1 = 25,
        EJackHairDynamicBoneState__Pose_C_RearHairN1 = 26,
        EJackHairDynamicBoneState__Pose_C_RearHairQ1 = 27,
        EJackHairDynamicBoneState__Sim_BeardD1 = 28,
        EJackHairDynamicBoneState__Pose_HeadVeilC1 = 29,
        EJackHairDynamicBoneState__Pose_RearHairP1 = 30,
        EJackHairDynamicBoneState__Sim_C_BeardB = 31,
        EJackHairDynamicBoneState__Sim_N104Hair = 32,
        EJackHairDynamicBoneState__Sim_C_HairTailA1 = 33,
        EJackHairDynamicBoneState__Sim_C_HairTailB1 = 34,
        EJackHairDynamicBoneState__Pose_LR_SideHairL1 = 35,
        EJackHairDynamicBoneState__EJackHairDynamicBoneState_MAX = 36
    }

    // Enum JackAnimNodeRuntime.EJackLowerDynamicBoneState
    public enum EJackLowerDynamicBoneState : byte
    {
        EJackLowerDynamicBoneState__Default = 0,
        EJackLowerDynamicBoneState__RtEx_Skirt_Length1 = 1,
        EJackLowerDynamicBoneState__RtEx_Skirt_Length2 = 2,
        EJackLowerDynamicBoneState__RtEx_Skirt_Length3 = 3,
        EJackLowerDynamicBoneState__RtEx_Skirt_Length4 = 4,
        EJackLowerDynamicBoneState__RtEx_SBSkirt = 5,
        EJackLowerDynamicBoneState__RtEx_FtSkirt_Length2 = 6,
        EJackLowerDynamicBoneState__RtEx_FtSkirt_Length3 = 7,
        EJackLowerDynamicBoneState__RtEx_FtSkirt_Length3_N008 = 8,
        EJackLowerDynamicBoneState__RtEx_FtSkirt_Length3_N010 = 9,
        EJackLowerDynamicBoneState__RtEx_FtSkirt_Length3_N013 = 10,
        EJackLowerDynamicBoneState__RtEx_HipsArmor = 11,
        EJackLowerDynamicBoneState__RtEx_HipsArmor_N001 = 12,
        EJackLowerDynamicBoneState__RtEx_HipsArmor_N004 = 13,
        EJackLowerDynamicBoneState__RtEx_SouthSkirtK1 = 14,
        EJackLowerDynamicBoneState__RtEx_P004Skirt = 15,
        EJackLowerDynamicBoneState__RtEx_HrSkirtA = 16,
        EJackLowerDynamicBoneState__Sim_KtAcce = 17,
        EJackLowerDynamicBoneState__RtEx_HipsSideArmor = 18,
        EJackLowerDynamicBoneState__RtEx_P001Skirt = 19,
        EJackLowerDynamicBoneState__Sim_LR_LoinclothA1 = 20,
        EJackLowerDynamicBoneState__Sim_TailSkirtA1 = 21,
        EJackLowerDynamicBoneState__Sim_LR_NpcPantsI3 = 22,
        EJackLowerDynamicBoneState__RtEx_FBSkirtA1 = 23,
        EJackLowerDynamicBoneState__RtEx_NmSkirtB1 = 24,
        EJackLowerDynamicBoneState__RtEx_NmSkirtA1 = 25,
        EJackLowerDynamicBoneState__RtEx_SlideSkirt = 26,
        EJackLowerDynamicBoneState__RtEx_FBSkirtB1 = 27,
        EJackLowerDynamicBoneState__RtEx_SouthSkirtQ1 = 28,
        EJackLowerDynamicBoneState__RtEx_NorthSkirtS1 = 29,
        EJackLowerDynamicBoneState__Sim_DancerSkirt = 30,
        EJackLowerDynamicBoneState__RtEx_P002_Skirt = 31,
        EJackLowerDynamicBoneState__RtEx_N008_SamaCoat = 32,
        EJackLowerDynamicBoneState__RtEx_FtSkirt_Length2_N013 = 33,
        EJackLowerDynamicBoneState__RtEx_SouthSkirtK1Long_P001 = 34,
        EJackLowerDynamicBoneState__RtEx_HipsArmor_P001 = 35,
        EJackLowerDynamicBoneState__RtEx_SouthSkirtK1Short_P001 = 36,
        EJackLowerDynamicBoneState__RtEx_HipsArmor_P004 = 37,
        EJackLowerDynamicBoneState__RtEx_SouthSkirtK1Short_P008 = 38,
        EJackLowerDynamicBoneState__RtEx_HipsArmor_P008 = 39,
        EJackLowerDynamicBoneState__RtEx_FBSkirtA1_P006 = 40,
        EJackLowerDynamicBoneState__RtEx_RCSkirt_Length3 = 41,
        EJackLowerDynamicBoneState__RtEx_RCSkirt_Length4 = 42,
        EJackLowerDynamicBoneState__RtEx_SouthSkirtK1Long_P006 = 43,
        EJackLowerDynamicBoneState__RtEx_NmSkirtD1 = 44,
        EJackLowerDynamicBoneState__RtEx_P002_DelayLegPants = 45,
        EJackLowerDynamicBoneState__RtEx_BunnySkirt_P006 = 46,
        EJackLowerDynamicBoneState__RtEx_SwimSkirt_P006 = 47,
        EJackLowerDynamicBoneState__RtEx_PrinSkirt_P006 = 48,
        EJackLowerDynamicBoneState__RtEx_HipsArmor_P002 = 49,
        EJackLowerDynamicBoneState__RtEx_Bt_NimaSkirt = 50,
        EJackLowerDynamicBoneState__EJackLowerDynamicBoneState_MAX = 51
    }

    // Enum JackAnimNodeRuntime.EJackUpperDynamicBoneState
    public enum EJackUpperDynamicBoneState : byte
    {
        EJackUpperDynamicBoneState__Default = 0,
        EJackUpperDynamicBoneState__Sim_CollarA = 1,
        EJackUpperDynamicBoneState__Sim_RearHood = 2,
        EJackUpperDynamicBoneState__RtEx_LR_ShoulderClothA1 = 3,
        EJackUpperDynamicBoneState__Sim_NPC_ParadeFar = 4,
        EJackUpperDynamicBoneState__Sim_P001_ParadeFeather = 5,
        EJackUpperDynamicBoneState__Sim_P005_ParadeFeatherBlack = 6,
        EJackUpperDynamicBoneState__Sim_CollarA_N008 = 7,
        EJackUpperDynamicBoneState__Sim_CollarE_P007 = 8,
        EJackUpperDynamicBoneState__EJackUpperDynamicBoneState_MAX = 9
    }

    // Enum JackAnimNodeRuntime.EJackBoneAxis
    public enum EJackBoneAxis : byte
    {
        EJackBoneAxis__X = 0,
        EJackBoneAxis__Y = 1,
        EJackBoneAxis__Z = 2,
        EJackBoneAxis__EJackBoneAxis_MAX = 3
    }
}
