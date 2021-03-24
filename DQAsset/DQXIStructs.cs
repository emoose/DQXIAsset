using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DQAsset
{
    // ScriptStruct JackGame.JackDataTableActionAIEvaluateScoreCheck
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableActionAIEvaluateScoreCheck : FTableRowBase
    {
        public FName FunctionName;                                             // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Param0;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Param1;                                                   // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Param2;                                                   // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Param3;                                                   // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Param4;                                                   // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Param5;                                                   // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Param6;                                                   // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Param7;                                                   // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableActionSecondCheck
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableActionSecondCheck : FTableRowBase
    {
        public FName FunctionName;                                             // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> SubSecondCheckIDs;                                        // 0x0010(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableAction
    // 0x01B0 (0x01B8 - 0x0008)
    public class FJackDataTableAction : FTableRowBase
    {
        public FName DisplayName;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionDamageID;                                           // 0x0010(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionOddEffectID;                                        // 0x0018(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionMultiAttackID;                                      // 0x0020(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionHitOrderID;                                         // 0x0028(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionNakamaYobiID;                                       // 0x0030(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionSecondCheckID_Baka;                                 // 0x0038(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionSecondCheckID_Ningen;                               // 0x0040(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionSecondCheckID_Kami;                                 // 0x0048(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionTextID;                                             // 0x0050(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SortNo;                                                   // 0x0058(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionCategory ActionCategory;                                           // 0x005C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteField;                                            // 0x005D(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteBattle;                                           // 0x005E(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponNot;                                        // 0x005F(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponSwd;                                        // 0x0060(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponDgr;                                        // 0x0061(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponAxe;                                        // 0x0062(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponStk;                                        // 0x0063(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponBoo;                                        // 0x0064(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponTsw;                                        // 0x0065(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponSpr;                                        // 0x0066(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponRod;                                        // 0x0067(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponClw;                                        // 0x0068(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponWhp;                                        // 0x0069(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponShi;                                        // 0x006A(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int UseMP;                                                    // 0x006C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AddZonePoint;                                             // 0x0070(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DistanceToTarget;                                         // 0x0074(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bAssistFowardJump;                                        // 0x0078(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bRotationToTarget;                                        // 0x0079(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float RotationDurationTimeByFreeCamera;                         // 0x007C(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ShotReservedMoveDistanceToTarget;                         // 0x0080(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bHiddenWeaponByActionCamera;                              // 0x0084(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidBackJumpBySimpleCamera;                           // 0x0085(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionTargetType Target;                                                   // 0x0086(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionExtentTargetType ExtentTarget;                                             // 0x0087(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionExtentType Extent;                                                   // 0x0088(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ExtentParam1;                                             // 0x008C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ExtentParam2;                                             // 0x0090(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bRandomHit;                                               // 0x0094(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bForceTargetSelect;                                       // 0x0095(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Motion_Cast;                                              // 0x0098(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Motion_Shot;                                              // 0x00A0(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Motion_Extensions;                                        // 0x00A8(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
        public float Motion_Cast_LoopTime;                                     // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Motion_Shot_LoopTime;                                     // 0x00BC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionWaitType ActionWaitType;                                           // 0x00C0(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ActionWaitTimeByFreeCamera;                               // 0x00C4(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ActionWaitTimeBySimpleCamera;                             // 0x00C8(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionCriticalType CriticalType;                                             // 0x00CC(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CriticalHosei;                                            // 0x00D0(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackHitStopPresetType HitStopPresetType;                                        // 0x00D4(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackHitCameraShakePresetType HitCameraShakePresetType;                                 // 0x00D5(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName HitEffectClass;
        public FName OverlapDamageSE;
        public FName ActionEffectClass;
        public FName ActionEffectClass2;
        public bool bAttributeEffectOff;                                      // 0x0138(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionCameraID_Player;                                    // 0x0140(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionCameraID_Monster;                                   // 0x0148(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionIconType ActionIconType;                                           // 0x0150(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionTargetIconID;                                       // 0x0158(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterRenkeiID;                                          // 0x0160(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidExecute_Miryou;                                   // 0x0168(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMPSyouhiZeroMukou;                                       // 0x0169(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMahosute;                                                // 0x016A(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bJumonHansya;                                             // 0x016B(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bYamabiko;                                                // 0x016C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bNitouDamage;                                             // 0x016D(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionSoundType ActionSoundType;                                          // 0x016E(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<EJackActionConsumeCondition> ActionConsumeConditions;                                  // 0x0170(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
        public List<FName> Tags;                                                     // 0x0180(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ReferenceClasses;
        public FName ActionExecClass;
    }

    // ScriptStruct JackGame.JackReferenceParamInfo
    // 0x001C
    public class FJackReferenceParamInfo : FTableRowBase
    {
        public int BaseMonster;                                              // 0x0000(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BaseMin;                                                  // 0x0004(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BaseMax;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackReferenceParam ReferenceParam;                                           // 0x000C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReferenceHoseiMin;                                        // 0x0010(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReferenceHoseiMax;                                        // 0x0014(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Random;                                                   // 0x0018(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableActionOddEffect
    // 0x0080 (0x0088 - 0x0008)
    public class FJackDataTableActionOddEffect : FTableRowBase
    {
        public List<FName> TempOddEffectIDs;                                         // 0x0008(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
        public FName SetSelfOddEffectID;                                       // 0x0018(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool SkipSuccessPerField;
        [Serializer(OnlyIfNotSet = "SkipSuccessPerField")]
        public FJackReferenceParamInfo SuccessPer;                                               // 0x0020(0x001C) (Edit, DisableEditOnInstance)
        public List<FName> SetOddEffectIDs;                                          // 0x0040(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
        public List<EJackOddEffectCategoryType> ClearOddEffectCategories;                                 // 0x0050(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ClearOddEffectStatusIDs;                                  // 0x0060(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ClearOddEffectIDs;                                        // 0x0070(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
        public bool bClearOddEffectConditionGood;                             // 0x0080(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClearOddEffectConditionBad;                              // 0x0081(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackActionMultiAttackInfo
    // 0x0020
    public class FJackActionMultiAttackInfo : FTableRowBase
    {
        public FName OverrideActionDamageID;                                   // 0x0000(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public float DamagePer;                                                // 0x0008(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bCriticalDisable;                                         // 0x000C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bMissDisable;                                             // 0x000D(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bMikawasiDisable;                                         // 0x000E(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bTateGuardDisable;                                        // 0x000F(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bBukiGuardDisable;                                        // 0x0010(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bKnockBackDisable;                                        // 0x0011(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bHitOnlyFirstTarget;                                      // 0x0012(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName OverrideActionHitOrderID;                                 // 0x0018(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableActionMultiAttack
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableActionMultiAttack : FTableRowBase
    {
        //public int MultiAttackNum;                                           // 0x0008(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackActionMultiAttackInfo> MultiAttackInfos;                                         // 0x0010(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableActionHitOrder
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableActionHitOrder : FTableRowBase
    {
        public EJackActionHitOrderType HitOrderType;                                             // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPriorityTarget;                                          // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Interval_01;                                              // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Interval_02;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Interval_03;                                              // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Interval_04;                                              // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Interval_05;                                              // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Interval_06;                                              // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Interval_07;                                              // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Interval_08;                                              // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableActionDamage
    // 0x0050 (0x0058 - 0x0008)
    public class FJackDataTableActionDamage : FTableRowBase
    {
        public EJackActionDamageType DamageType;                                               // 0x0008(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionDamageCalcType DamageCalcType;                                           // 0x0009(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageCalcParam;                                          // 0x000C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageCalcParamRandom;                                    // 0x0010(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDamageCalcHand;                                          // 0x0014(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DamageMonster;                                            // 0x0018(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DamageMin;                                                // 0x001C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DamageMax;                                                // 0x0020(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackReferenceParam DamageReferenceParam;                                     // 0x0024(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DamageReferenceParam_Min;                                 // 0x0028(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DamageReferenceParam_Max;                                 // 0x002C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DamageRandom;                                             // 0x0030(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageSibariHosei;                                        // 0x0034(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DamageLimit;                                              // 0x0038(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float HitPer;                                                   // 0x003C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bKabauEnable;                                             // 0x0040(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCounterEnable;                                           // 0x0041(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMikawasiEnable;                                          // 0x0042(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bTateGuardEnable;                                         // 0x0043(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBukiGuardEnable;                                         // 0x0044(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bKougekiAttributeEnable;                                  // 0x0045(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMetalEnable;                                             // 0x0046(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bButuriDamageKeigenEnable;                                // 0x0047(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBreathDamageKeigenEnable;                                // 0x0048(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOddEffectClearDamageEnable;                              // 0x0049(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bKantuYaminokoromo;                                       // 0x004A(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bGuardMukouEnable;                                        // 0x004B(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bFixDamageEnable;                                         // 0x004C(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionMonsterRaceTokkouType MonsterRaceTokkouType;                                    // 0x004D(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionTuikaKoukaType KougekiHPMPKyuusyuuEnable;                                // 0x004E(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bYoDamageEnable;                                          // 0x004F(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDamageSetOddEffectEnable;                                // 0x0050(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMetalTokkouEnable;                                       // 0x0051(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bKougekiJumonHenkaEnable;                                 // 0x0052(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bKaifukuJumonHenkaEnable;                                 // 0x0053(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDamageKeigenEnable;                                      // 0x0054(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionTuikaKoukaType WeaponTuikaKoukaType;                                     // 0x0055(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionTuikaKoukaType TuikaDamageType;                                          // 0x0056(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionDamageBlowState DamageBlowState;                                          // 0x0057(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackActionBattleTextInfo
    // 0x0010
    public class FJackActionBattleTextInfo : FTableRowBase
    {
        public FName TextPackID;                                               // 0x0000(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackActionTextType Timming;                                                  // 0x0008(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackBattleMessageNoun PorM;                                                     // 0x0009(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackBattleMessageCompactType MatomeType;                                               // 0x000A(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableAnimMontage
    // 0x0018 (0x0020 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableAnimMontage : FTableRowBase
    {
        public int AnimMontageClassIndex;
        //public class UAnimMontage*                                AnimMontage;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BlendInTime;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BlendOutTime;                                             // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float TranslationMultiplier;                                    // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackLookAtBoneDirectionalSetting
    // 0x0008
    public class FJackLookAtBoneDirectionalSetting : FTableRowBase
    {
        public float MaxAngle;                                                 // 0x0000(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AngleRate;                                                // 0x0004(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackLookAtBoneSetting
    // 0x0024
    public class FJackLookAtBoneSetting : FTableRowBase
    {
        public FJackLookAtBoneDirectionalSetting YawLeft;                                                  // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FJackLookAtBoneDirectionalSetting YawRight;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FJackLookAtBoneDirectionalSetting PitchUp;                                                  // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FJackLookAtBoneDirectionalSetting PitchDown;                                                // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public float RollRate;                                                 // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackMonsterBattleAIExceptionInfo
    // 0x0030
    public class FJackMonsterBattleAIExceptionInfo : FTableRowBase
    {
        public FName ActionID;                                                 // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Motion_Cast;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Motion_Shot;                                              // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionTargetType Target_Type;                                              // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionSelectType Select_Type;                                              // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Groupe_Check;                                             // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Invoke_Rate;                                              // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SecondCheckID;                                            // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterBattleAI
    // 0x00F0 (0x00F8 - 0x0008)
    public class FJackDataTableMonsterBattleAI : FTableRowBase
    {
        public EJackBattleIntelligenceType IntelligenceType;                                         // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionPatternType ActionPatternType;                                        // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleMoreActionType MoreActionType;                                           // 0x000A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DefaultActionSlotID;                                      // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_01_ActionID;                                       // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_01_Motion_Cast;                                    // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_01_Motion_Shot;                                    // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionTargetType Action_01_Target_Type;                                    // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionSelectType Action_01_Select_Type;                                    // 0x0029(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Action_01_Groupe_Check;                                   // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_02_ActionID;                                       // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_02_Motion_Cast;                                    // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_02_Motion_Shot;                                    // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionTargetType Action_02_Target_Type;                                    // 0x0048(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionSelectType Action_02_Select_Type;                                    // 0x0049(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Action_02_Groupe_Check;                                   // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_03_ActionID;                                       // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_03_Motion_Cast;                                    // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_03_Motion_Shot;                                    // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionTargetType Action_03_Target_Type;                                    // 0x0068(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionSelectType Action_03_Select_Type;                                    // 0x0069(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Action_03_Groupe_Check;                                   // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_04_ActionID;                                       // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_04_Motion_Cast;                                    // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_04_Motion_Shot;                                    // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionTargetType Action_04_Target_Type;                                    // 0x0088(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionSelectType Action_04_Select_Type;                                    // 0x0089(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Action_04_Groupe_Check;                                   // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_05_ActionID;                                       // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_05_Motion_Cast;                                    // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_05_Motion_Shot;                                    // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionTargetType Action_05_Target_Type;                                    // 0x00A8(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionSelectType Action_05_Select_Type;                                    // 0x00A9(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Action_05_Groupe_Check;                                   // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_06_ActionID;                                       // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_06_Motion_Cast;                                    // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Action_06_Motion_Shot;                                    // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionTargetType Action_06_Target_Type;                                    // 0x00C8(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionSelectType Action_06_Select_Type;                                    // 0x00C9(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Action_06_Groupe_Check;                                   // 0x00CC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackMonsterBattleAIExceptionInfo> ExceptionAction;                                          // 0x00D0(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName BattleCommandAIClass;
    }

    // ScriptStruct JackGame.JackBattleFukidasiTalkCondition
    // 0x0020
    public class FJackBattleFukidasiTalkCondition : FTableRowBase
    {
        public EJackBattleFukidasiTalkTarget Target;                                                   // 0x0000(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ValueTargetParam;                                         // 0x0004(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StringTargetParam;                                        // 0x0008(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiTalkCondChara TalkCondChara;                                            // 0x0010(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiTalkConditionType CaseType;                                                 // 0x0011(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ValueCaseParam;                                           // 0x0014(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StringCaseParam;                                          // 0x0018(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackZukanMotionDirectionalLightParameter
    // 0x0010
    public class FJackZukanMotionDirectionalLightParameter : FTableRowBase
    {
        public float Intensity;                                                // 0x0000(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FRotator Rotation;                                                 // 0x0004(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackZukanMotionPointLightParameter
    // 0x001C
    public class FJackZukanMotionPointLightParameter : FTableRowBase
    {
        public bool bEnable;                                                  // 0x0000(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Intensity;                                                // 0x0004(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector Position;                                                 // 0x0008(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public float AttenuationRadius;                                        // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float SourceRadius;                                             // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCoinShop
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableCoinShop : FTableRowBase
    {
        public string TalkTypeID;                                               // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int ExchangeGold;                                             // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCoinExchange
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableCoinExchange : FTableRowBase
    {
        public FName ItemID;                                                   // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ExchangeNumber;                                           // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackExchange ExchangeType;                                             // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName QuestionItemName;                                         // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName QuestionItemExplanation;                                  // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackEventBattleMonsterDeployInfo
    // 0x0010
    public class FJackEventBattleMonsterDeployInfo : FTableRowBase
    {
        public FName MonsterID;                                                // 0x0000(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsKeyMonster;                                            // 0x0008(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bTextureMipLevelsToBeResident;                            // 0x0009(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackBattleResultOverrideVoiceInfo
    // 0x0010
    public class FJackBattleResultOverrideVoiceInfo : FTableRowBase
    {
        public EJackCharacter CharacterType;                                            // 0x0000(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VoiceID;                                                  // 0x0008(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableEventBattle
    // 0x0140 (0x0148 - 0x0008)
    public class FJackDataTableEventBattle : FTableRowBase
    {
        public List<FJackEventBattleMonsterDeployInfo> MonsterDeployInfos;                                       // 0x0008(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public float BattleFieldRadius;                                        // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleNigeruConditionType NigeruConditionType;                                      // 0x001C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBattleFieldNigeruInvalid;                                // 0x001D(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackEventBattleRaidState RaidState;                                                // 0x001E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSkipCrashEffect;                                         // 0x001F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CrashEffectSe;
        public bool bSkipMonsterAppear;                                       // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSkipResult;                                              // 0x0039(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSkipResultZenmetu;                                       // 0x003A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFadeColor StartFadeColor;                                           // 0x003B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartFadeTime;                                            // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFadeColor EndFadeColor;                                             // 0x0040(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndFadeTime;                                              // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AppearDisplayName;                                        // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AppearDisplayName2;                                       // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AppearDisplayName3;                                       // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AppearDisplayName4;                                       // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AppearDisplayName5;                                       // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AppearOverwriteMessages;                                  // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AppearAddMessages;                                        // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackEventBattleAppearLine AppearLineState;                                          // 0x0080(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AppearCameraStartWaitTime;                                // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AppearPlayTime;                                           // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AppearAccompanyingAnimationDelayTime;                     // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PreparationCameraAngle_Roll;                              // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PreparationCameraAngle_Pitch;                             // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PreparationCameraAngle_Yaw;                               // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FirstCameraAngle_Roll;                                    // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FirstCameraAngle_Pitch;                                   // 0x00A0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FirstCameraAngle_Yaw;                                     // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int EndRoundCount;                                            // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bToubatuEffectEnable;                                     // 0x00AC(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideToubatuTextID;                                    // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NerusenActionCount;                                       // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackBattleResultOverrideVoiceInfo> BattleResultOverrideVoiceInfos;                           // 0x00C0(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public FName HiddenExclusionTag;                                       // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CameraDataClass;
        public FName CameraDataClass_Simple;
        public FName CameraDataClass_PreparationView;
        public float OverrideBattleFieldInfoRadius;                            // 0x0120(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIgnoreFastModeByMonsterAppear;                           // 0x0124(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string MapJumpInfo;                                              // 0x0128(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string StartEventInfo;                                           // 0x0138(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFacialAnimCurve
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTableFacialAnimCurve : FTableRowBase
    {
        public FName CurveName;                                                // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int RankingPriority;                                          // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int L_EyeFormIndex;                                           // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int R_EyeFormIndex;                                           // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> UnHideBones;                                              // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> HideBones;                                                // 0x0030(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableShop
    // 0x00F0 (0x00F8 - 0x0008)
    public class FJackDataTableShop : FTableRowBase
    {
        public FName MapId;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ShopName;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackShop ShopType;                                                 // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string TalkTypeID;                                               // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float SaleRate;                                                 // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ScenarioSequenceNo;                                       // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_001;                                               // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_002;                                               // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_003;                                               // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_004;                                               // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_005;                                               // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_006;                                               // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_007;                                               // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_008;                                               // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_009;                                               // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_010;                                               // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_011;                                               // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_012;                                               // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_013;                                               // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_014;                                               // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_015;                                               // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_016;                                               // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_017;                                               // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_018;                                               // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_019;                                               // 0x00C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_020;                                               // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_021;                                               // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_022;                                               // 0x00E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_023;                                               // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_024;                                               // 0x00F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableInn
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableInn : FTableRowBase
    {
        public string TalkTypeID;                                               // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int BasePrice;                                                // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableChurch
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableChurch : FTableRowBase
    {
        public EJackChurch ChurchType;                                               // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string TalkTypeID;                                               // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public EJackChurchFukkatunojumon FukkatunojumonType;                                       // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackChurchFukkatunojumon TenseiType;                                               // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RestartID;                                                // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBank
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableBank : FTableRowBase
    {
        public string TalkTypeID;                                               // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableKaziAction
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableKaziAction : FTableRowBase
    {
        public FName ActionName;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionComment;                                            // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionComment1;                                           // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int GetLV;                                                    // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Kaisin_Percentage;                                        // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SortIndex;                                                // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionType;                                               // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NeedCP;                                                   // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NumData_01;                                               // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NumData_02;                                               // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NumData_03;                                               // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName IconTexture;
    }

    // ScriptStruct JackGame.JackDataTableMonster
    // 0x0100 (0x0108 - 0x0008)
    public class FJackDataTableMonster : FTableRowBase
    {
        public FName DisplayName;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterPhysicalPropertyID;                                // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterDropID;                                            // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterFieldAIID;                                         // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SibariMonsterFieldAIID;                                   // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterBattleAIID;                                        // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SibariMonsterBattleAIID;                                  // 0x0038(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterAppearID;                                          // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterZukanID;                                           // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterZukanMemoID;                                       // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterRace MonsterRace;                                              // 0x0058(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Lv;                                                       // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SibariLv;                                                 // 0x0060(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SibariLvHosei;                                            // 0x0064(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaxHP;                                                    // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaxMP;                                                    // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Subayasa;                                                 // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Kiyousa;                                                  // 0x0074(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Miryoku;                                                  // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Kougekiryoku;                                             // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Syubiryoku;                                               // 0x0080(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KougekiMaryoku;                                           // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KaifukuMaryoku;                                           // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Omosa;                                                    // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SibariParameterID;                                        // 0x0090(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<float> AttributeParams;                                          // 0x0098(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName ZoneOddEffectID;                                          // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float InitialZonePointMin;                                      // 0x00B0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float InitialZonePointMax;                                      // 0x00B4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleInitOddEffectID;                                    // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBoss;                                                    // 0x00C0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMetal;                                                   // 0x00C1(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bFly;                                                     // 0x00C2(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMugenHP;                                                 // 0x00C3(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMugenMP;                                                 // 0x00C4(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCopyMonster;                                             // 0x00C5(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIgnoreCopyTarget;                                        // 0x00C6(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float HpRateMin;                                                // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float HpRateMax;                                                // 0x00CC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ReincarnationMonsterId;                                   // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ReincarnationRate;                                        // 0x00D8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterClass;
        public List<int> TripleMonsters;                                           // 0x00F8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMonsterDrop
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableMonsterDrop : FTableRowBase
    {
        public int Exp;                                                      // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float SibariExpHosei;                                           // 0x000C(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Gold;                                                     // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NormalItem;                                               // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NormalProbability;                                        // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RareItem;                                                 // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int RareProbability;                                          // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bNotSteal;                                                // 0x0034(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDisplayItemSyousai;                                      // 0x0035(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterDeploy
    // 0x0220 (0x0228 - 0x0008)
    public class FJackDataTableMonsterDeploy : FTableRowBase
    {
        public FName GeneratorId;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterID;                                                // 0x0010(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName DeployedInstanceName;                                     // 0x0018(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SubstituteEventBattleID;                                  // 0x0020(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public int DefaultCount;                                             // 0x0028(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public float DefaultDensity;                                           // 0x002C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public float LifeSpan;                                                 // 0x0030(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public float RandomDistanceMin;                                        // 0x0034(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public float RandomDistanceMax;                                        // 0x0038(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackBattleNigeruConditionType NigeruCondition;                                          // 0x003C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bRepop;                                                   // 0x003D(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public float RepopIntervalSeconds;                                     // 0x0040(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bSnapToGroundOnPop;                                       // 0x0044(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bDepopWhenBattleFinished;                                 // 0x0045(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackVehicleModelId DropVehicleType;                                          // 0x0046(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName MovingBounds;                                             // 0x0048(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public int ActiveTimeStart;                                          // 0x0050(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public int ActiveTimeEnd;                                            // 0x0054(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterActiveWeather ActiveWeather1;                                           // 0x0058(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterActiveWeather ActiveWeather2;                                           // 0x0059(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterActiveScenario ActiveScenario;                                           // 0x005A(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public int PartyMonsterTotalLimit;                                   // 0x005C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PartyMonsterId1;                                          // 0x0060(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)

        [Serializer(OnlyIfSet = "PartyMonsterId1")]
        public int PartyMonsterMin1;                                         // 0x0068(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId1")]
        public int PartyMonsterMax1;                                         // 0x006C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId1")]
        public float PartyMonsterLotteryRate1;                                 // 0x0070(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)

        public FName PartyMonsterId2;                                          // 0x0078(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId2")]
        public int PartyMonsterMin2;                                         // 0x0080(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId2")]
        public int PartyMonsterMax2;                                         // 0x0084(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId2")]
        public float PartyMonsterLotteryRate2;                                 // 0x0088(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PartyMonsterId3;                                          // 0x0090(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId3")]
        public int PartyMonsterMin3;                                         // 0x0098(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId3")]
        public int PartyMonsterMax3;                                         // 0x009C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId3")]
        public float PartyMonsterLotteryRate3;                                 // 0x00A0(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PartyMonsterId4;                                          // 0x00A8(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId4")]
        public int PartyMonsterMin4;                                         // 0x00B0(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId4")]
        public int PartyMonsterMax4;                                         // 0x00B4(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId4")]
        public float PartyMonsterLotteryRate4;                                 // 0x00B8(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PartyMonsterId5;                                          // 0x00C0(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId5")]
        public int PartyMonsterMin5;                                         // 0x00C8(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId5")]
        public int PartyMonsterMax5;                                         // 0x00CC(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId5")]
        public float PartyMonsterLotteryRate5;                                 // 0x00D0(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PartyMonsterId6;                                          // 0x00D8(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId6")]
        public int PartyMonsterMin6;                                         // 0x00E0(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId6")]
        public int PartyMonsterMax6;                                         // 0x00E4(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId6")]
        public float PartyMonsterLotteryRate6;                                 // 0x00E8(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PartyMonsterId7;                                          // 0x00F0(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId7")]
        public int PartyMonsterMin7;                                         // 0x00F8(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId7")]
        public int PartyMonsterMax7;                                         // 0x00FC(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId7")]
        public float PartyMonsterLotteryRate7;                                 // 0x0100(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PartyMonsterId8;                                          // 0x0108(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId8")]
        public int PartyMonsterMin8;                                         // 0x0110(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId8")]
        public int PartyMonsterMax8;                                         // 0x0114(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "PartyMonsterId8")]
        public float PartyMonsterLotteryRate8;                                 // 0x0118(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)

        public FName MetalEncountId;                                           // 0x0120(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public float SpPartyRate;                                              // 0x0128(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SpPartyMonsterId1;                                        // 0x0130(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId1")]
        public int SpPartyMonsterMin1;                                       // 0x0138(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId1")]
        public int SpPartyMonsterMax1;                                       // 0x013C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SpPartyMonsterId2;                                        // 0x0140(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId2")]
        public int SpPartyMonsterMin2;                                       // 0x0148(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId2")]
        public int SpPartyMonsterMax2;                                       // 0x014C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SpPartyMonsterId3;                                        // 0x0150(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId3")]
        public int SpPartyMonsterMin3;                                       // 0x0158(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId3")]
        public int SpPartyMonsterMax3;                                       // 0x015C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SpPartyMonsterId4;                                        // 0x0160(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId4")]
        public int SpPartyMonsterMin4;                                       // 0x0168(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId4")]
        public int SpPartyMonsterMax4;                                       // 0x016C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SpPartyMonsterId5;                                        // 0x0170(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId5")]
        public int SpPartyMonsterMin5;                                       // 0x0178(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId5")]
        public int SpPartyMonsterMax5;                                       // 0x017C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SpPartyMonsterId6;                                        // 0x0180(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId6")]
        public int SpPartyMonsterMin6;                                       // 0x0188(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId6")]
        public int SpPartyMonsterMax6;                                       // 0x018C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SpPartyMonsterId7;                                        // 0x0190(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId7")]
        public int SpPartyMonsterMin7;                                       // 0x0198(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId7")]
        public int SpPartyMonsterMax7;                                       // 0x019C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName SpPartyMonsterId8;                                        // 0x01A0(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId8")]
        public int SpPartyMonsterMin8;                                       // 0x01A8(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        [Serializer(OnlyIfSet = "SpPartyMonsterId8")]
        public int SpPartyMonsterMax8;                                       // 0x01AC(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterPopCondition PopCondition;                                             // 0x01B0(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PopConditionMontageKey;                                   // 0x01B8(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterPatrolMode PatrolMode;                                               // 0x01C0(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PatrolCourse;                                             // 0x01C8(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterPatrolMovingMethod PatrolMovingMethod;                                       // 0x01D0(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public float PatrolPointWaitTime;                                      // 0x01D4(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName PatrolPointMontageKey;                                    // 0x01D8(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterDepopBehavior DepopBehavior;                                            // 0x01E0(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName DepopLocatorKeyName;                                      // 0x01E8(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterReaction ReactionForMonster;                                       // 0x01F0(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName ReactionTargetName;                                       // 0x01F8(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName ReactionMontageKey;                                       // 0x0200(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public int ReactionFrequency;                                        // 0x0208(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterFollowerFormation FollowerFormation;                                        // 0x020C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterFollowerReactionMode FollowerReactionMode;                                     // 0x020D(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMonsterApproachAction ApproachActionType;                                       // 0x020E(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName ApproachTargetName;                                       // 0x0210(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName ApproachActionMontageKey;                                 // 0x0218(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public int ApproachActionFrequency;                                  // 0x0220(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUmaRaceMapData
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableUmaRaceMapData : FTableRowBase
    {
        public int Number;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Gold;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Gold_H;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LapNum;                                                   // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_N_01;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_N_02;                                              // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_H_01;                                              // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_H_02;                                              // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_N_Rank02;                                          // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_H_Rank02;                                          // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUsualRoute;                                              // 0x0048(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInnerCourse;                                             // 0x0049(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bNightRace;                                               // 0x004A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRenkei
    // 0x0138 (0x0140 - 0x0008)
    public class FJackDataTableRenkei : FTableRowBase
    {
        public FName RenkeiID;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AchievementID;                                            // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisplayName;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackActionIconType ActionIconType;                                           // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Description2;                                             // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Description4;                                             // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiCategory RenkeiCategory;                                           // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DoRenkeiID;                                               // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SelectActionID;                                           // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisplayFlag;                                              // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NeedFlag;                                                 // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NeedItemID;                                               // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OwnerCharacter;                                           // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember ActionCameraDefenderReference;                            // 0x0070(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CharacterA;                                               // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NeedActionID_A;                                           // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool NeedZone_A;                                               // 0x0088(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool RefreshZone_A;                                            // 0x0089(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CharacterB;                                               // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NeedActionID_B;                                           // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool NeedZone_B;                                               // 0x00A0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool RefreshZone_B;                                            // 0x00A1(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CharacterC;                                               // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NeedActionID_C;                                           // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool NeedZone_C;                                               // 0x00B8(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool RefreshZone_C;                                            // 0x00B9(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CharacterD;                                               // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NeedActionID_D;                                           // 0x00C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool NeedZone_D;                                               // 0x00D0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool RefreshZone_D;                                            // 0x00D1(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RenkeiCutInID;                                            // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorR_Cut;                                           // 0x00E0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorG_Cut;                                           // 0x00E4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorB_Cut;                                           // 0x00E8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeTime_Cut;                                             // 0x00EC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorR;                                               // 0x00F0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorG;                                               // 0x00F4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorB;                                               // 0x00F8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeTime;                                                 // 0x00FC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorR_Result;                                        // 0x0100(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorG_Result;                                        // 0x0104(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeColorB_Result;                                        // 0x0108(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeTime_Result;                                          // 0x010C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionCutIn_FormationID;                                  // 0x0110(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionCutIn_CameraID;                                     // 0x0118(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionCutIn_AnimMontage;                                  // 0x0120(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ActionCutIn_Time;                                         // 0x0128(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionCutIn_TextID;                                       // 0x0130(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TripleRenkeiNo;                                           // 0x0138(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableLevelUp
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableLevelUp : FTableRowBase
    {
        public int RequiredExp;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Tikara;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Minomamori;                                               // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Subayasa;                                                 // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Kiyousa;                                                  // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Miryoku;                                                  // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KougekiMaryoku;                                           // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KaifukuMaryoku;                                           // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaxHP;                                                    // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaxMP;                                                    // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TokugiPoint;                                              // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Jumon0;                                                   // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Jumon1;                                                   // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Jumon2;                                                   // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackQuestReward
    // 0x0020
    public class FJackQuestReward : FTableRowBase
    {
        public EJackQuestRewardType RewardType;                                               // 0x0000(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EventItemId;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Tokugi;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PowerUpText;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSyuurenjouRewardInfo
    // 0x0020
    public class FJackDataTableSyuurenjouRewardInfo : FTableRowBase
    {
        public FName AcquiredFlagName;                                         // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Conditions;                                               // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemEventGetId;                                           // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName HiddenName;                                               // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSyuurenjou
    // 0x0128 (0x0130 - 0x0008)
    public class FJackDataTableSyuurenjou : FTableRowBase
    {
        public FName Title;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Description;                                              // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScoreGameFlagName;                                        // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ClearedFlagName;                                          // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisplayConditions0;                                       // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisplayConditions1;                                       // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OpenConditions0;                                          // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OpenConditions1;                                          // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NeedMemberCount;                                          // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BattleCount;                                              // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleId0;                                                // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleName0;                                              // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BattleMemberCount0;                                       // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleId1;                                                // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleName1;                                              // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BattleMemberCount1;                                       // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleId2;                                                // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleName2;                                              // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BattleMemberCount2;                                       // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleId3;                                                // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleName3;                                              // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BattleMemberCount3;                                       // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FJackDataTableSyuurenjouRewardInfo RewardInfo0;                                              // 0x00B0(0x0020) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDataTableSyuurenjouRewardInfo RewardInfo1;                                              // 0x00D0(0x0020) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDataTableSyuurenjouRewardInfo RewardInfo2;                                              // 0x00F0(0x0020) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDataTableSyuurenjouRewardInfo RewardInfo3;                                              // 0x0110(0x0020) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackZukanMotionMonsterAnimData
    // 0x0018
    public class FJackZukanMotionMonsterAnimData : FTableRowBase
    {
        public FName AnimKey;                                                  // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLoop;                                                    // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bRepeat;                                                  // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector TargetPosOffset;                                          // 0x000C(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackZukanMotionWeaponAnimData
    // 0x0030
    public class FJackZukanMotionWeaponAnimData : FTableRowBase
    {
        public EJackEquippedWeaponStyle WeaponStyle;                                              // 0x0000(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackZukanMotionEquippedShieldFlag EquippedShieldFlag;                                       // 0x0001(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AnimSequenceAsset;
        public FName RightWeaponAnimMontageKey;                                // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LeftWeaponAnimMontageKey;                                 // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterZukanMotion
    // 0x00C0 (0x00C8 - 0x0008)
    public class FJackDataTableMonsterZukanMotion : FTableRowBase
    {
        public float InitCameraZoom;                                           // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ZoomOutCameraFovAngle;                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ZoomInCameraFovAngle;                                     // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ZoomSpeed;                                                // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FarCameraDist;                                            // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float NearCameraDist;                                           // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector2D FarCameraPos;                                             // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FVector2D NearCameraPos;                                            // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public float FarCameraPitch;                                           // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float NearCameraPitch;                                          // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FarCameraSlideSpeed;                                      // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float NearCameraSlideSpeed;                                     // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector TargetPos;                                                // 0x0040(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FRotator InitialRotation;                                          // 0x004C(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public bool bEnableLookAt;                                            // 0x0058(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector LookAtLocation;                                           // 0x005C(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FVector2D SlideTargetOrigin;                                        // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FVector2D FarSlideTargetSize;                                       // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FVector2D NearSlideTargetSize;                                      // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public bool bInBattle;                                                // 0x0080(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackZukanMotionMonsterAnimData> MonsterAnimDataList;                                      // 0x0088(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FJackZukanMotionWeaponAnimData> WeaponAnimList;                                           // 0x0098(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FJackZukanMotionDirectionalLightParameter> DirectionalLightParameterList;                            // 0x00A8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FJackZukanMotionPointLightParameter> PointLightParameterList;                                  // 0x00B8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableVoiceDrama
    // 0x0068 (0x0070 - 0x0008)
    public class FJackDataTableVoiceDrama : FTableRowBase
    {
        public string SceneTitle;                                               // 0x0008(0x0010) (Edit, ZeroConstructor, EditConst)
        public string TalkerName;                                               // 0x0018(0x0010) (Edit, ZeroConstructor, EditConst)
        public string Text;                                                     // 0x0028(0x0010) (Edit, ZeroConstructor, EditConst)
        public bool bPageSkip;                                                // 0x0038(0x0001) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public string ScenarioTag_Head;                                         // 0x0040(0x0010) (Edit, ZeroConstructor, EditConst)
        public string ScenarioTag_Foot;                                         // 0x0050(0x0010) (Edit, ZeroConstructor, EditConst)
        public uint SoundStartMSec;                                           // 0x0060(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public uint SoundEndMSec;                                             // 0x0064(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public int SoundMSec;                                                // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, EditConst, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackActionNakamaYobiInfo
    // 0x0018
    public class FJackActionNakamaYobiInfo : FTableRowBase
    {
        public FName ZouenMonsterID;                                           // 0x0000(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public int ZouenNumMin;                                              // 0x0008(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        public int ZouenNumMax;                                              // 0x000C(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        public int ZouenNumLimit;                                            // 0x0010(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackBattleFukidasiText
    // 0x0028
    public class FJackBattleFukidasiText : FTableRowBase
    {
        public FName CharacterID;                                              // 0x0000(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TextID;                                                   // 0x0008(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiTextVoiceType VoiceType;                                                // 0x0010(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiTextVoiceType VoiceTypeNE;                                              // 0x0011(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FaceIconID;                                               // 0x0018(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StringParam;                                              // 0x0020(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackBattleFukidasiTextContainer
    // 0x0010
    public class FJackBattleFukidasiTextContainer : FTableRowBase
    {
        public FName TextID;                                                   // 0x0000(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiTextEnableType EnableType;                                               // 0x0008(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableAchievement
    // 0x0050 (0x0058 - 0x0008)
    public class FJackDataTableAchievement : FTableRowBase
    {
        public FName AchievementNameID;                                        // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DescriptionID;                                            // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievementRarity Rarity;                                                   // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievementCategory Category;                                                 // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievementCondition Condition;                                                // 0x001A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string StringParameter;                                          // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int NumericalParameter;                                       // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievementTiming Timing;                                                   // 0x0034(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CategoryNo;                                               // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PhoneticNo;                                               // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TripleAchievementNo;                                      // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName UE4AchievementName;                                       // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUE4AchievementOnly;                                      // 0x0050(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUE4AchievementReload;                                    // 0x0051(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDisabledInTrial;                                         // 0x0052(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableActionTargetIcon
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableActionTargetIcon : FTableRowBase
    {
        public List<FName> OddEffectStatusList;                                      // 0x0008(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableActionBattleText
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableActionBattleText : FTableRowBase
    {
        public List<FJackActionBattleTextInfo> BattleTextInfos;                                          // 0x0008(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableActionAI
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableActionAI : FTableRowBase
    {
        public FName ActionID;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RenkeiID;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPlayerAIActionCategory CategoryType;                                             // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPlayerAIActionControl ControlType;                                              // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool StrategyFlagGangan;                                       // 0x001A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool StrategyFlagBattiri;                                      // 0x001B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool StrategyFlagIroiro;                                       // 0x001C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool StrategyFlagInoti;                                        // 0x001D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool StrategyFlagMPTukauna;                                    // 0x001E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreCorrectionFactor;                                    // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableActionCameraData
    // 0x00F0 (0x00F8 - 0x0008)
    public class FJackDataTableActionCameraData : FTableRowBase
    {
        public EJackBattleActionCameraAtCategory AttackerTarget;                                           // 0x0008(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionCameraAtCategory DefenderTarget;                                           // 0x0009(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionCameraTimingCategory TrackingStopCategory;                                     // 0x000A(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float TrackingStopTime;                                         // 0x000C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionCameraHiddenCharacterCategory HiddenCharacterCategory;                                  // 0x0010(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionCameraLengthAdjustCategory LengthAdjustCategory;                                     // 0x0011(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public float LimitSelection;                                           // 0x0014(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackCharacter SelectCharacter;                                          // 0x0018(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public FName SelectMonsterID;                                          // 0x0020(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public float SelectLengthAdjust;                                       // 0x0028(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackBattleActionCameraEyeLocationCategory EyeLocationCategory;                                      // 0x002C(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public FName AttackerSocketName;                                       // 0x0030(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DefenderSocketName;                                       // 0x0038(0x0008) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EyeInterpTime;                                            // 0x0040(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AtInterpTime;                                             // 0x0044(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float OtherInterpTime;                                          // 0x0048(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndTime;                                                  // 0x004C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleActionCameraLoopCategory LoopParam;                                                // 0x0050(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSystemUse;                                               // 0x0051(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> NextCamera1;                                              // 0x0058(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
        public EJackBattleActionCameraPlayConditions PlayConditions1;                                          // 0x0068(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float NextCameraStartTime1;                                     // 0x006C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float NextCameraInterpTime1;                                    // 0x0070(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> ActionCameraInfos1;                                       // 0x0078(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ActionCameraInfos2;                                       // 0x0088(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ActionCameraInfos3;                                       // 0x0098(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ActionCameraInfos4;                                       // 0x00A8(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ActionCameraInfos5;                                       // 0x00B8(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ActionCameraInfos6;                                       // 0x00C8(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ActionCameraInfos7;                                       // 0x00D8(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public List<FName> ActionCameraInfos8;                                       // 0x00E8(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableActionNakamaYobi
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableActionNakamaYobi : FTableRowBase
    {
        public EJackNakamaYobiSpawnLocationType SpawnLocationType;                                        // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SpawnLocationParameter;                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackActionNakamaYobiInfo> ZouenMonsterInfos;                                        // 0x0018(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableActionTag
    // 0x0008 (0x0010 - 0x0008)
    // TODO: DT_ActionTag doesn't contain any data, just FNames
    [Serializer(NoStructSize = true)]
    public class FJackDataTableActionTag : FTableRowBase
    {
        //public bool Dummy;                                                    // 0x0008(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableAdditiveAnimMontage
    // 0x0010 (0x0018 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableAdditiveAnimMontage : FTableRowBase
    {
        public int AdditiveAnimMontageClassIndex;
        //public class UAnimMontage*                                AdditiveAnimMontage;                                      // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AdditiveRate;                                             // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableAnimMontageDynamic
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableAnimMontageDynamic : FTableRowBase
    {
        public FName AnimMontage;
        public float BlendInTime;                                              // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BlendOutTime;                                             // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float TranslationMultiplier;                                    // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableArasuzi
    // 0x0138 (0x0140 - 0x0008)
    public class FJackDataTableArasuzi : FTableRowBase
    {
        public EJackScenarioID ScenarioID;                                               // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int No;                                                       // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioFlag;                                             // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGameFlagCategory SubFlagCategory;                                          // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SubFlagName;                                              // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID;                                                    // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Play1_Pages;                                              // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play1_Text1;                                              // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play1_BG1;
        public FName Play1_Text2;                                              // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play1_BG2;
        public FName Play1_Text3;                                              // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play1_BG3;
        public FName Play1_Text4;                                              // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play1_BG4;
        public int Play2_Pages;                                              // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play2_Text1;                                              // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play2_BG1;
        public FName Play2_Text2;                                              // 0x00E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play2_BG2;
        public FName Play2_Text3;                                              // 0x0100(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play2_BG3;
        public FName Play2_Text4;                                              // 0x0120(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Play2_BG4;
    }

    // ScriptStruct JackGame.JackArticleInfo
    // 0x0088
    public class FJackArticleInfo : FTableRowBase
    {
        public EJackNounGender Gender;                                                   // 0x0000(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DefSgl;                                                   // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName IndefSgl;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string SglM;                                                     // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string SglF;                                                     // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string SglN;                                                     // 0x0038(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName DefPlr;                                                   // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName IndefPlr;                                                 // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName IndefPlrIT;                                               // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string Plr;                                                      // 0x0060(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public byte Flags;
        // TODO: following are stored in byte above
        //public bool PlrNounFlag;                                              // 0x0070(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public bool ProNounFlag;                                              // 0x0071(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public bool VowelFlag;                                                // 0x0072(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public bool LastIsSFlag;                                              // 0x0073(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string List;                                                     // 0x0078(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableArticleInfo
    // 0x0088 (0x0090 - 0x0008)
    public class FJackDataTableArticleInfo : FTableRowBase
    {
        public FJackArticleInfo ArticleInfo;                                              // 0x0008(0x0088) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableItemArticleInfo
    // 0x0008 (0x0098 - 0x0090)
    public class FJackDataTableItemArticleInfo : FJackDataTableArticleInfo
    {
        public int PhoneticNo;                                               // 0x0090(0x0004) (Edit, BlueprintVisible, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    };

    // ScriptStruct JackGame.JackDataTableAttachedProps
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableAttachedProps : FTableRowBase
    {
        public FName Class;
        public FName SocketName;                                               // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBattleFukidasiPeculiarWords
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableBattleFukidasiPeculiarWords : FTableRowBase
    {
        public bool bMonsterGroupBig;                                         // 0x0008(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupSmall;                                       // 0x0009(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupMetal;                                       // 0x000A(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupDance;                                       // 0x000B(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupHorror;                                      // 0x000C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupInsect;                                      // 0x000D(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupCat;                                         // 0x000E(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupBird;                                        // 0x000F(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupMagic;                                       // 0x0010(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupWarrior;                                     // 0x0011(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupMimic;                                       // 0x0012(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupUru1;                                        // 0x0013(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupUru2;                                        // 0x0014(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupUru;                                         // 0x0015(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupNiz;                                         // 0x0016(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupHome;                                        // 0x0017(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupKira;                                        // 0x0018(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupYaruki;                                      // 0x0019(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupTyui;                                        // 0x001A(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupReisei;                                      // 0x001B(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupAseri;                                       // 0x001C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupIkari;                                       // 0x001D(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupKansya;                                      // 0x001E(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupYorokobi;                                    // 0x001F(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMonsterGroupKonran;                                      // 0x0020(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBattleFukidasiText
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableBattleFukidasiText : FTableRowBase
    {
        public List<FJackBattleFukidasiText> BattleFukidasiTexts;                                      // 0x0008(0x0010) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableBattleFukidasi
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableBattleFukidasi : FTableRowBase
    {
        public FName FukidasiRequirementID;                                    // 0x0008(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackBattleFukidasiTextContainer> TextContainer;                                            // 0x0010(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public EJackBattleFukidasiTalkTimming Timming;                                                  // 0x0020(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOnce;                                                    // 0x0021(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float InvokePer;                                                // 0x0024(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToCharacter;                                              // 0x0028(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiTalkTurn Turn;                                                     // 0x0030(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiSndCalcType SndCalcType;                                              // 0x0031(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float SndCalcParam;                                             // 0x0034(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Capacity;                                                 // 0x0038(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUseFree;                                                 // 0x003C(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Priority;                                                 // 0x0040(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiUIType UIType;                                                   // 0x0044(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleFukidasiCalcType SetCalcType;                                              // 0x0045(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DelayTime;                                                // 0x0048(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Time;                                                     // 0x004C(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bNoSilence;                                               // 0x0050(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidMoveTalk;                                         // 0x0051(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSlomo;                                                   // 0x0052(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackBattleFukidasiTalkCondition> SetConditions;                                            // 0x0058(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableBattleHazukasiiNoroiText
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableBattleHazukasiiNoroiText : FTableRowBase
    {
        public FName HazukasiiNoroiCharacterID;                                // 0x0008(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName HazukasiiNoroiText1;                                      // 0x0010(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName HazukasiiNoroiText2;                                      // 0x0018(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBattleResultMotion
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTableBattleResultMotion : FTableRowBase
    {
        public FName Start_Flg;                                                // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName End_Flg;                                                  // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Target;                                                   // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Who1;                                                     // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AnimMontage1;                                             // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Who2;                                                     // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AnimMontage2;                                             // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Who3;                                                     // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AnimMontage3;                                             // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBookShelf
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableBookShelf : FTableRowBase
    {
        public FName CommonGettableItemID;                                     // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TextID;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBoukenGuide
    // 0x0070 (0x0078 - 0x0008)
    public class FJackDataTableBoukenGuide : FTableRowBase
    {
        public EJackScenarioID ScenarioID;                                               // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int No;                                                       // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioFlag;                                             // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<EJackGameFlagCategory> SubFlagCategory;                                          // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> SubFlagName;                                              // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> Item;                                                     // 0x0038(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<EJackMapIDType> MapIDType;                                                // 0x0048(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> MapId;                                                    // 0x0058(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public EJackMapConditionType MapCondition;                                             // 0x0068(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCustomCondition;                                         // 0x0069(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName GuideText;                                                // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCharacterLODBounds
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableCharacterLODBounds : FTableRowBase
    {
        public FName OriginBoneName;                                           // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector OriginOffsetInBoneSpace;                                  // 0x0010(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public float Radius;                                                   // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CastShadowCullingBoundsScale;                             // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCharacterMaterialUpdater
    // 0x00C0 (0x00C8 - 0x0008)
    public class FJackDataTableCharacterMaterialUpdater : FTableRowBase
    {
        public FName CurveAsset;
        public float CurveTimeScale;                                           // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LoopCurveAsset;
        public float LoopCurveTimeScale;                                       // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EndCurveAsset;
        public float EndCurveTimeScale;                                        // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Priority;                                                 // 0x0064(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)

        public bool bOriginalEmissiveColorR;
        [Serializer(OnlyIfSet = "bOriginalEmissiveColorR")]
        public float OriginalEmissiveColorR;                                   // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOriginalEmissiveColorG;
        [Serializer(OnlyIfSet = "bOriginalEmissiveColorG")]
        public float OriginalEmissiveColorG;                                   // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOriginalEmissiveColorB;
        [Serializer(OnlyIfSet = "bOriginalEmissiveColorB")]
        public float OriginalEmissiveColorB;                                   // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)

        public bool bAdditiveEmissiveColorR;
        [Serializer(OnlyIfSet = "bAdditiveEmissiveColorR")]
        public float AdditiveEmissiveColorR;                                   // 0x0074(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bAdditiveEmissiveColorG;
        [Serializer(OnlyIfSet = "bAdditiveEmissiveColorG")]
        public float AdditiveEmissiveColorG;                                   // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bAdditiveEmissiveColorB;
        [Serializer(OnlyIfSet = "bAdditiveEmissiveColorB")]
        public float AdditiveEmissiveColorB;                                   // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bAdditiveEmissiveFalloff;
        [Serializer(OnlyIfSet = "bAdditiveEmissiveFalloff")]
        public float AdditiveEmissiveFalloff;                                  // 0x0080(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bAdditiveEmissiveScale;
        [Serializer(OnlyIfSet = "bAdditiveEmissiveScale")]
        public float AdditiveEmissiveScale;                                    // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBaseColorR;
        [Serializer(OnlyIfSet = "bBaseColorR")]
        public float BaseColorR;                                               // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBaseColorG;
        [Serializer(OnlyIfSet = "bBaseColorG")]
        public float BaseColorG;                                               // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBaseColorB;
        [Serializer(OnlyIfSet = "bBaseColorB")]
        public float BaseColorB;                                               // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLitColorR;
        [Serializer(OnlyIfSet = "bLitColorR")]
        public float LitColorR;                                                // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLitColorG;
        [Serializer(OnlyIfSet = "bLitColorG")]
        public float LitColorG;                                                // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLitColorB;
        [Serializer(OnlyIfSet = "bLitColorB")]
        public float LitColorB;                                                // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLitDirectionX;
        [Serializer(OnlyIfSet = "bLitDirectionX")]
        public float LitDirectionX;                                            // 0x00A0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLitDirectionY;
        [Serializer(OnlyIfSet = "bLitDirectionY")]
        public float LitDirectionY;                                            // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLitDirectionZ;
        [Serializer(OnlyIfSet = "bLitDirectionZ")]
        public float LitDirectionZ;                                            // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLitFalloff;
        [Serializer(OnlyIfSet = "bLitFalloff")]
        public float LitFalloff;                                               // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLitScale;
        [Serializer(OnlyIfSet = "bLitScale")]
        public float LitScale;                                                // 0x00B0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)

    }

    // ScriptStruct JackGame.JackDataTableCoinExchangeShop
    // 0x00D0 (0x00D8 - 0x0008)
    public class FJackDataTableCoinExchangeShop : FTableRowBase
    {
        public string TalkTypeID;                                               // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName PrizeId_01;                                               // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_02;                                               // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_03;                                               // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_04;                                               // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_05;                                               // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_06;                                               // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_07;                                               // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_08;                                               // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_09;                                               // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_11;                                               // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_12;                                               // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_13;                                               // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_14;                                               // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_15;                                               // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_16;                                               // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_17;                                               // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_18;                                               // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_19;                                               // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_20;                                               // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_21;                                               // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_22;                                               // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_23;                                               // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_24;                                               // 0x00C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PrizeId_25;                                               // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCollideEffectTable
    // 0x0360 (0x0368 - 0x0008)
    public class FJackDataTableCollideEffectTable : FTableRowBase
    {
        public FName Default;
        public FName Earth;
        public FName EarthDry;
        public FName Mud;
        public FName Stone;
        public FName Wood;
        public FName WoodBoard;
        public FName WoodDamaged;
        public FName WoodThick;
        public FName SuspensionBridge;
        public FName SandStone;
        public FName Sand;
        public FName Gravel;
        public FName BurntSand;
        public FName Water;
        public FName Shallow;
        public FName OceanFloor;
        public FName Snow;
        public FName Ice;
        public FName Grass;
        public FName Leaf;
        public FName Straw;
        public FName BrownGrass;
        public FName Cloth;
        public FName ClothThick;
        public FName Metal;
        public FName Coin;
        public FName Flesh;
        public FName Ladder;
        public FName Rope;
        public FName Poison;
        public FName Lava;
        public FName Ivy;
        public FName Barrier;
        public FName ColdLava;
        public FName CleftLava;
    }

    // ScriptStruct JackGame.JackDataTableCollideSoundTable
    // 0x0360 (0x0368 - 0x0008)
    public class FJackDataTableCollideSoundTable : FTableRowBase
    {
        public FName Default;
        public FName Earth;
        public FName EarthDry;
        public FName Mud;
        public FName Stone;
        public FName Wood;
        public FName WoodBoard;
        public FName WoodDamaged;
        public FName WoodThick;
        public FName SuspensionBridge;
        public FName SandStone;
        public FName Sand;
        public FName Gravel;
        public FName BurntSand;
        public FName Water;
        public FName Shallow;
        public FName OceanFloor;
        public FName Snow;
        public FName Ice;
        public FName Grass;
        public FName Leaf;
        public FName Straw;
        public FName BrownGrass;
        public FName Cloth;
        public FName ClothThick;
        public FName Metal;
        public FName Coin;
        public FName Flesh;
        public FName Ladder;
        public FName Rope;
        public FName Poison;
        public FName Lava;
        public FName Ivy;
        public FName Barrier;
        public FName ColdLava;
        public FName CleftLava;
    }

    // ScriptStruct JackGame.JackDataTableWidgetBlueprint
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableWidgetBlueprint : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UBlueprint*                                  WidgetBlueprint;                                          // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableTexture
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableTexture : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UTexture*                                    Texture;                                                  // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBlueprintClass
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableBlueprintClass : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UClass*                                      BlueprintClass;                                           // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMaterial
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableMaterial : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UMaterialInterface*                          Material;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSkeletalMesh
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableSkeletalMesh : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class USkeletalMesh*                               SkeletalMesh;                                             // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableStaticMesh
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableStaticMesh : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UStaticMesh*                                 StaticMesh;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCollideEffect
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableCollideEffect : UObject
    {
        // TODO: doesn't seem to follow FJackDataTableCollideEffect format at all..
    }

    // ScriptStruct JackGame.JackDataTableMaterialParameterCollection
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableMaterialParameterCollection : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UMaterialParameterCollection*                MaterialParameterCollection;                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCurve
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableCurve : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UCurveBase*                                  Curve;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCameraShake
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableCameraShake : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UClass*                                      CameraShakeClass;                                         // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCameraAnim
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableCameraAnim : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UCameraAnim*                                 CameraAnim;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableWeaponClass
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableWeaponClass : UObject
    {
        //public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UClass*                                      WeaponClass;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableProjectileClass
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableProjectileClass : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UClass*                                      ProjectileClass;                                          // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSound
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableSound : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class USoundBase*                                  Sound;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableParticle
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableParticle : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UParticleSystem*                             Particle;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackOverrideMaterial
    // 0x01B0
    public class FJackOverrideMaterial : FTableRowBase
    {
        public FName TargetMaterialName;                                       // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideMaterial;
        public FName OverrideTexture1_ParamName;                               // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideTexture1;
        public FName OverrideTexture2_ParamName;                               // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideTexture2;
        public FName OverrideTexture3_ParamName;                               // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideTexture3;
        public FName OverrideTexture4_ParamName;                               // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideTexture4;
        public FName OverrideTexture5_ParamName;                               // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideTexture5;
        public FName OverrideColor1_ParamName;                                 // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor1;                                           // 0x00C8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor2_ParamName;                                 // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor2;                                           // 0x00E0(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor3_ParamName;                                 // 0x00F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor3;                                           // 0x00F8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor4_ParamName;                                 // 0x0108(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor4;                                           // 0x0110(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor5_ParamName;                                 // 0x0120(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor5;                                           // 0x0128(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor6_ParamName;                                 // 0x0138(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor6;                                           // 0x0140(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor7_ParamName;                                 // 0x0150(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor7;                                           // 0x0158(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor8_ParamName;                                 // 0x0168(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor8;                                           // 0x0170(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor9_ParamName;                                 // 0x0180(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor9;                                           // 0x0188(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideColor10_ParamName;                                // 0x0198(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FLinearColor OverrideColor10;                                          // 0x01A0(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackCoordinateMeshInfo
    // 0x0888
    public class FJackCoordinateMeshInfo : FTableRowBase
    {
        public FName Mesh;
        public FJackOverrideMaterial OverrideMaterial1;                                        // 0x0018(0x01B0) (Edit, BlueprintVisi, BlueprintReadOnly, EditFixedSize, DisableEditOnInstance)
        public FJackOverrideMaterial OverrideMaterial2;                                        // 0x01C8(0x01B0) (Edit, BlueprintVisi, BlueprintReadOnly, EditFixedSize, DisableEditOnInstance)
        public FJackOverrideMaterial OverrideMaterial3;                                        // 0x0378(0x01B0) (Edit, BlueprintVisi, BlueprintReadOnly, EditFixedSize, DisableEditOnInstance)
        public FJackOverrideMaterial OverrideMaterial4;                                        // 0x0528(0x01B0) (Edit, BlueprintVisi, BlueprintReadOnly, EditFixedSize, DisableEditOnInstance)
        public FJackOverrideMaterial OverrideMaterial5;                                        // 0x06D8(0x01B0) (Edit, BlueprintVisi, BlueprintReadOnly, EditFixedSize, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableCoordinate
    // 0x4458 (0x4460 - 0x0008)
    public class FJackDataTableCoordinate : FTableRowBase
    {
        public FName MasterPoseMesh;
        public FJackCoordinateMeshInfo Body;                                                     // 0x0020(0x0888) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackCoordinateMeshInfo Face;                                                     // 0x08A8(0x0888) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackCoordinateMeshInfo Hair;                                                     // 0x1130(0x0888) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackCoordinateMeshInfo Beard;                                                    // 0x19B8(0x0888) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackCoordinateMeshInfo Accessory;                                                // 0x2240(0x0888) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackCoordinateMeshInfo Cloth1;                                                   // 0x2AC8(0x0888) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackCoordinateMeshInfo Cloth2;                                                   // 0x3350(0x0888) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackCoordinateMeshInfo Cloth3;                                                   // 0x3BD8(0x0888) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableForceFeedback
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableForceFeedback : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UForceFeedbackEffect*                        ForceFeedback;                                            // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCoordSoundTable
    // 0x01F8 (0x0200 - 0x0008)
    public class FJackDataTableCoordSoundTable : FTableRowBase
    {
        public FName Walk;
        public FName Run;
        public FName Dash;
        public FName ArmUp;
        public FName ArmDown;
        public FName Sit;
        public FName Stand;
        public FName Jump;
        public FName Land;
        public FName Turn;
        public FName ArmHard;
        public FName BodyHard;
        public FName Down;
        public FName CS1;
        public FName CS2;
        public FName CS3;
        public FName CS4;
        public FName CS5;
        public FName CS6;
        public FName CS7;
        public FName CS8;
    }

    // ScriptStruct JackGame.JackDataTableCutSceneAnimationInfo
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableCutSceneAnimationInfo : FTableRowBase
    {
        public float ApplyRate;                                                // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneAutomaticFeedOfSpeechInfo
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableCutSceneAutomaticFeedOfSpeechInfo : FTableRowBase
    {
        public float InVoice;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float InLoopVoice;                                              // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float InText;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float OneLetter;                                                // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneCoordinateAliasInfo
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableCutSceneCoordinateAliasInfo : FTableRowBase
    {
        public FName AliasCoordinateID;                                        // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneDuplicationTalkerInfo
    // 0x0080 (0x0088 - 0x0008)
    public class FJackDataTableCutSceneDuplicationTalkerInfo : FTableRowBase
    {
        public FName OriginalTalkerID0;                                        // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID1;                                        // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID2;                                        // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID3;                                        // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID4;                                        // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID5;                                        // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID6;                                        // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID7;                                        // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID8;                                        // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID9;                                        // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID10;                                       // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID11;                                       // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID12;                                       // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID13;                                       // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID14;                                       // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OriginalTalkerID15;                                       // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneDynamicResolutionInfo
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableCutSceneDynamicResolutionInfo : FTableRowBase
    {
        public FName CutSceneID;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CutID;                                                    // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScreenPercentage_Console;                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScreenPercentage_Handheld;                                // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneInfo
    // 0x0188 (0x0190 - 0x0008)
    public class FJackDataTableCutSceneInfo : FTableRowBase
    {
        public FName CSLevel;                                                  // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Title;                                                    // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlagName;                                                 // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FirstFlagName;                                            // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool NPCVisibility;                                            // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FogVisibility;                                            // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MeshVisibilityTag;                                        // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFadeColor StartFadeColor;                                           // 0x0040(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartFadeTime;                                            // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFadeColor EndFadeColor;                                             // 0x0048(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndFadeTime;                                              // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName JumpMapStartID;                                           // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName JumpStartCSID;                                            // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool EndTimeReturnFlag;                                        // 0x0060(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool EndWeatherReturnFlag;                                     // 0x0061(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool EndLocationTitleShowFlag;                                 // 0x0062(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EndEventBattleID;                                         // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool EndPlayableFlag;                                          // 0x0070(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool MemoriesShowFlag;                                         // 0x0071(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ChapterTitleID;                                           // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ChapterID;                                                // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StartMapStartID;                                          // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PlayerWeaponID;                                           // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID;                                                    // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ElevenCosID;                                              // 0x00A0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CamuCosID;                                                // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int VeronicaCosID;                                            // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SenaCosID;                                                // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SylviaCosID;                                              // 0x00B0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int RouCosID;                                                 // 0x00B4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MartinaCosID;                                             // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int GraigCosID;                                               // 0x00BC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ForceTime;                                                // 0x00C0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel ForceWeather;                                             // 0x00C4(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ForceWindControl;                                         // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PreLoadMapJumpTag;                                        // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGLODTag;                                                 // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool RefreshStatus;                                            // 0x00E0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool HiddenGuestNPC;                                           // 0x00E1(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisableCullDistanceVolume;                                // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisableCullDistanceVolumeForActor;                        // 0x00F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Achievement;                                              // 0x00F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool HiddenWeatherEffect;                                      // 0x0100(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeAfterWaitTime;                                        // 0x0104(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool PartyRecoverFlag;                                         // 0x0108(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EnvironmentLevelName;                                     // 0x0110(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ChangeDefaultCoordinate;                                  // 0x0118(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LoadingScreenType;                                        // 0x0120(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool InroomFlag;                                               // 0x0124(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName HiddenLightTag;                                           // 0x0128(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool CameraLightEnable;                                        // 0x0130(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool UseInGameReduction;                                       // 0x0131(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName HighQualityTextureTag;                                    // 0x0138(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName WaitLoadTextureTag;                                       // 0x0140(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LoadSoundType;                                            // 0x0148(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool EnableLensFlare;                                          // 0x014C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool HoukaiClearSky;                                           // 0x014D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool MemoriesSeqCSFlag;                                        // 0x014E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CSStartDelayTime;                                         // 0x0150(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CSStartDelayTimeForMemories;                              // 0x0154(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisableInactiveTag;                                       // 0x0158(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool SkipFlushStreamingForLoadingAfter;                        // 0x0160(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool EndEnvSoundReturnFlag;                                    // 0x0161(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool DisableDynamicResolution;                                 // 0x0162(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DynamicResolution_ScreenPercentage;                       // 0x0164(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DynamicResolution_DecreasesResolutionMaxCount_ConsoleMode;// 0x0168(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DynamicResolution_DecreasesResolutionMaxCount_HandheldMode;// 0x016C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DynamicResolution_WaitFramesToUpperResolution;            // 0x0170(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DynamicResolution_WaitFramesToLowerResolution;            // 0x0174(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DynamicResolution_DecreasesResolution;                    // 0x0178(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DynamicResolution_MaxTimeBudget;                          // 0x017C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DynamicResolution_MinTimeBudget;                          // 0x0180(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool WaitNPCLoadComplete;                                      // 0x0184(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool DisableHLOD;                                              // 0x0185(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ShowSkipFlag;                                             // 0x0188(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneLevelLoadInfo
    // 0x0080 (0x0088 - 0x0008)
    public class FJackDataTableCutSceneLevelLoadInfo : FTableRowBase
    {
        public FName LoadLevel0;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus LoadState0;                                               // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus UnLoadState0;                                             // 0x0011(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LoadLevel1;                                               // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus LoadState1;                                               // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus UnLoadState1;                                             // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LoadLevel2;                                               // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus LoadState2;                                               // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus UnLoadState2;                                             // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LoadLevel3;                                               // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus LoadState3;                                               // 0x0040(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus UnLoadState3;                                             // 0x0041(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LoadLevel4;                                               // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus LoadState4;                                               // 0x0050(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus UnLoadState4;                                             // 0x0051(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LoadLevel5;                                               // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus LoadState5;                                               // 0x0060(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus UnLoadState5;                                             // 0x0061(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LoadLevel6;                                               // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus LoadState6;                                               // 0x0070(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus UnLoadState6;                                             // 0x0071(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LoadLevel7;                                               // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus LoadState7;                                               // 0x0080(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCSMapLevelStatus UnLoadState7;                                             // 0x0081(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneLipInfo
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableCutSceneLipInfo : FTableRowBase
    {
        public FName SerifuID;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartTime;                                                // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Lip_aa;                                                   // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Lip_ln;                                                   // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Lip_fv;                                                   // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Lip_ee;                                                   // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Lip_oo;                                                   // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Lip_sh;                                                   // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Lip_bmp;                                                  // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BlendInTime;                                              // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BlendOutTime;                                             // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneSerifuInfo
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableCutSceneSerifuInfo : FTableRowBase
    {
        public FName OverrideCloseFlag;                                        // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideNPCID;                                            // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableCutSceneVoiceTimelineInfo
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTableCutSceneVoiceTimelineInfo : FTableRowBase
    {
        public FName SerifuID;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TargetCharacterName;                                      // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionName;                                               // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartTime;                                                // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Parameter1;                                               // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Parameter2;                                               // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Parameter3;                                               // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Parameter4;                                               // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableDamageAttributeEffect
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableDamageAttributeEffect : FTableRowBase
    {
        public FName EffectBP;
    }

    // ScriptStruct JackGame.JackDamageEffect
    // 0x0060
    public class FJackDamageEffect : FTableRowBase
    {
        public FName DamageNormal;
        public FName DamageCritical;
        public FName DamageGuard;
        public FName DamageMiss;
    }

    // ScriptStruct JackGame.JackDataTableDamageEffectTable
    // 0x0600 (0x0608 - 0x0008)
    public class FJackDataTableDamageEffectTable : FTableRowBase
    {
        public FJackDamageEffect NOT;                                                      // 0x0008(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect SWD;                                                      // 0x0068(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect DGR;                                                      // 0x00C8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect AXE;                                                      // 0x0128(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect STK;                                                      // 0x0188(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect BOO;                                                      // 0x01E8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect TSW;                                                      // 0x0248(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect SPR;                                                      // 0x02A8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect ROD;                                                      // 0x0308(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect CLW;                                                      // 0x0368(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect WHP;                                                      // 0x03C8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect DSW;                                                      // 0x0428(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect DDG;                                                      // 0x0488(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect DAX;                                                      // 0x04E8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect DST;                                                      // 0x0548(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageEffect DBO;                                                      // 0x05A8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableDamageMaterialAnimation
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableDamageMaterialAnimation : FTableRowBase
    {
        public FName CurveAsset;
        public float CurveTimeScale;                                           // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageEmissiveScale;                                      // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDamageSound
    // 0x0060
    public class FJackDamageSound : FTableRowBase
    {
        public FName DamageNormal;
        public FName DamageCritical;
        public FName DamageGuard;
        public FName DamageMiss;
    }

    // ScriptStruct JackGame.JackDataTableDamageSoundTable
    // 0x0F00 (0x0F08 - 0x0008)
    public class FJackDataTableDamageSoundTable : FTableRowBase
    {
        public FJackDamageSound NOT;                                                      // 0x0008(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound SWD;                                                      // 0x0068(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound DGR;                                                      // 0x00C8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound AXE;                                                      // 0x0128(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound STK;                                                      // 0x0188(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound BOO;                                                      // 0x01E8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound TSW;                                                      // 0x0248(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound SPR;                                                      // 0x02A8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound ROD;                                                      // 0x0308(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound CLW;                                                      // 0x0368(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound WHP;                                                      // 0x03C8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound DSW;                                                      // 0x0428(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound DDG;                                                      // 0x0488(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound DAX;                                                      // 0x04E8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound DST;                                                      // 0x0548(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound DBO;                                                      // 0x05A8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Fng_S;                                                    // 0x0608(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Fng_M;                                                    // 0x0668(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Fng_L;                                                    // 0x06C8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Bek_S;                                                    // 0x0728(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Bek_M;                                                    // 0x0788(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Bek_L;                                                    // 0x07E8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Pnc_S;                                                    // 0x0848(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Pnc_M;                                                    // 0x08A8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Pnc_L;                                                    // 0x0908(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Don_S;                                                    // 0x0968(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Don_M;                                                    // 0x09C8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Don_L;                                                    // 0x0A28(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Spr_S;                                                    // 0x0A88(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Spr_M;                                                    // 0x0AE8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Spr_L;                                                    // 0x0B48(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Clw_S;                                                    // 0x0BA8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Clw_M;                                                    // 0x0C08(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Clw_L;                                                    // 0x0C68(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Swd_S;                                                    // 0x0CC8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Swd_M;                                                    // 0x0D28(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Swd_L;                                                    // 0x0D88(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Arw_S;                                                    // 0x0DE8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Arw_M;                                                    // 0x0E48(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public FJackDamageSound Arw_L;                                                    // 0x0EA8(0x0060) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableDebugCommandMacro
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableDebugCommandMacro : FTableRowBase
    {
        public FName BasePath;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Category;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SubCategory;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string CommandList;                                              // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        [Serializer(Size = 1)]
        public bool bAddMenu;                                                 // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisplayName;                                              // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ShortCut;                                                 // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CategoryEnglish;                                          // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SubCategoryEnglish;                                       // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisplayNameEnglish;                                       // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableDebugConsoleCommand
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableDebugConsoleCommand : FTableRowBase
    {
        public string Command;                                                  // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string Category;                                                 // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string SubCategory;                                              // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public bool JackCommandFlag;                                          // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string CommentarySentence;                                       // 0x0040(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableEnvSoundTable
    // 0x0840 (0x0848 - 0x0008)
    public class FJackDataTableEnvSoundTable : FTableRowBase
    {
        public FName ClearAndSunnyDayW1;
        public FName ClearAndSunnyDayW2;
        public FName ClearAndSunnyDayW3;
        public FName ClearAndSunnyDayW4;
        public FName ClearAndSunnyNightW1;
        public FName ClearAndSunnyNightW2;
        public FName ClearAndSunnyNightW3;
        public FName ClearAndSunnyNightW4;
        public FName SunnyDayW1;
        public FName SunnyDayW2;
        public FName SunnyDayW3;
        public FName SunnyDayW4;
        public FName SunnyNightW1;
        public FName SunnyNightW2;
        public FName SunnyNightW3;
        public FName SunnyNightW4;
        public FName CloudyDayW1;
        public FName CloudyDayW2;
        public FName CloudyDayW3;
        public FName CloudyDayW4;
        public FName CloudyNightW1;
        public FName CloudyNightW2;
        public FName CloudyNightW3;
        public FName CloudyNightW4;
        public FName LightRainDayW1;
        public FName LightRainDayW2;
        public FName LightRainDayW3;
        public FName LightRainDayW4;
        public FName LightRainNightW1;
        public FName LightRainNightW2;
        public FName LightRainNightW3;
        public FName LightRainNightW4;
        public FName RainDayW1;
        public FName RainDayW2;
        public FName RainDayW3;
        public FName RainDayW4;
        public FName RainNightW1;
        public FName RainNightW2;
        public FName RainNightW3;
        public FName RainNightW4;
        public FName HeavyRainDayW1;
        public FName HeavyRainDayW2;
        public FName HeavyRainDayW3;
        public FName HeavyRainDayW4;
        public FName HeavyRainNightW1;
        public FName HeavyRainNightW2;
        public FName HeavyRainNightW3;
        public FName HeavyRainNightW4;
        public FName ThunderstormDayW1;
        public FName ThunderstormDayW2;
        public FName ThunderstormDayW3;
        public FName ThunderstormDayW4;
        public FName ThunderstormNightW1;
        public FName ThunderstormNightW2;
        public FName ThunderstormNightW3;
        public FName ThunderstormNightW4;
        public FName SnowDayW1;
        public FName SnowDayW2;
        public FName SnowDayW3;
        public FName SnowDayW4;
        public FName SnowNightW1;
        public FName SnowNightW2;
        public FName SnowNightW3;
        public FName SnowNightW4;
        public FName SnowstormDayW1;
        public FName SnowstormDayW2;
        public FName SnowstormDayW3;
        public FName SnowstormDayW4;
        public FName SnowstormNightW1;
        public FName SnowstormNightW2;
        public FName SnowstormNightW3;
        public FName SnowstormNightW4;
        public FName FogDayW1;
        public FName FogDayW2;
        public FName FogDayW3;
        public FName FogDayW4;
        public FName FogNightW1;
        public FName FogNightW2;
        public FName FogNightW3;
        public FName FogNightW4;
        public FName HeavyFogDayW1;
        public FName HeavyFogDayW2;
        public FName HeavyFogDayW3;
        public FName HeavyFogDayW4;
        public FName HeavyFogNightW1;
        public FName HeavyFogNightW2;
        public FName HeavyFogNightW3;
        public FName HeavyFogNightW4;
    }

    // ScriptStruct JackGame.JackDataTableParameter
    // 0x0018 (0x0020 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableParameter : FTableRowBase
    {
        public float X;                                                        // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Y;                                                        // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Z;                                                        // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Text;                                                     // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableEquipmentCoordinate
    // 0x0088 (0x0090 - 0x0008)
    public class FJackDataTableEquipmentCoordinate : FTableRowBase
    {
        public FName Equipment_Body;                                           // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Equipment_Head;                                           // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Equipment_Accessory1;                                     // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Equipment_Accessory2;                                     // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Equipment_OptionalAccessory1;                             // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P001;                                        // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P002;                                        // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P003;                                        // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P004;                                        // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P004_ShortHair;                              // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P005;                                        // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P006;                                        // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P007;                                        // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID_P008;                                        // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUseAsEquipmentCoordinate;                                // 0x0078(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUseAsDressupCoordinate;                                  // 0x0079(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DisplayPriority;                                          // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TextID_DisplayName;                                       // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TextID_DisplayDescription;                                // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFacePoseSequence
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableFacePoseSequence : FTableRowBase
    {
        public FName PoseName;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Frame;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFacialAnimCategory Category;                                                 // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bForbiddenRandomBlink;                                    // 0x0015(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFacialReferencedAnimSequence ReferencedAnimSequenceType;                               // 0x0016(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFacialAnimation
    // 0x0098 (0x00A0 - 0x0008)
    public class FJackDataTableFacialAnimation : FTableRowBase
    {
        public FName FaceSkeletalMesh;
        public FName FacePoses;
        public FName AdditionalFacePoses;
        public FName CutSceneFacePoses;
        public FName CutSceneAdditionalFacePoses;
        public float EyeLookAtAngle_Up;                                        // 0x0080(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EyeLookAtAngle_Down;                                      // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EyeLookAtAngle_Left;                                      // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EyeLookAtAngle_Right;                                     // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> ExcludeFacePoseForEyeLookAt;                              // 0x0090(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFacialPreset
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableFacialPreset : FTableRowBase
    {
        public FName UpperFacePose;                                            // 0x0008(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LowerFacePose;                                            // 0x0010(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFootIKSetting
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableFootIKSetting : FTableRowBase
    {
        public FName MasterPoseMesh;
        public bool bSeparateRotationRangeElements;                           // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FRotator MinSeparateRotation;                                      // 0x0024(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FRotator MaxSeparateRotation;                                      // 0x0030(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public float SeparateRotationApplyHeight;                              // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EEasingFunc SeparateRotationApplyEasingFunc;                          // 0x0040(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CalcAdjustHeightBlendWeight_MovementSpeedMax;             // 0x0044(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CalcAdjustHeigthBlendWeight_MovementSpeedBlendWeightMax;  // 0x0048(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EEasingFunc CalcAdjustHeightBlendWeight_MovementSpeedBlendCurve;      // 0x004C(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CalcAdjustHeightBlendWeight_GroundDegreeMax;              // 0x0050(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CalcAdjustHeigthBlendWeight_GroundDegreeBlendWeightMax;   // 0x0054(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EEasingFunc CalcAdjustHeightBlendWeight_GroundDegreeBlendCurve;       // 0x0058(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackWeaponStyleAnimMontageTableInfo
    // 0x0020
    public class FJackWeaponStyleAnimMontageTableInfo : FTableRowBase
    {
        public EJackEquippedWeaponStyle WeaponStyle;                                              // 0x0000(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AnimMontageTable;
    }

    // ScriptStruct JackGame.JackDataTableFriendCharacter
    // 0x00B0 (0x00B8 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFriendCharacter : FTableRowBase
    {
        public EJackCharacter CharacterType;                                            // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGender Gender;                                                   // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackJob Job;                                                      // 0x000A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGambit DefaultGambit;                                            // 0x000B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLeftHandedness;                                          // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackItem_Bag Bag;                                                      // 0x000D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CharacterBPClass;
        public FName ControlledCharacterBPClass;
        public FName BattleCharacterBPClass;
        public List<FJackWeaponStyleAnimMontageTableInfo> WeaponStyleAnimMontageTableInfos;                         // 0x0058(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
        public int DT_LevelUp_ClassIndex;
        public int DT_ExtraLevelUp_ClassIndex;
        //public class UDataTable*                                  DT_LevelUp;                                               // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public class UDataTable*                                  DT_ExtraLevelUp;                                          // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DT_ExtraLevelUp_ReferenceFlagName;                        // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName InitialCoordinateID;                                      // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FacialPresetID;                                           // 0x0088(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VoicePresetID;                                            // 0x0090(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<float> AttributeParams;                                          // 0x0098(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName ZoneOddEffectID;                                          // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ZoneUpOddEffectID;                                        // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFriendCharacterPreset
    // 0x00D8 (0x00E0 - 0x0008)
    public class FJackDataTableFriendCharacterPreset : FTableRowBase
    {
        public EJackCharacter CharacterType;                                            // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bRejoin;                                                  // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIgnorePresetItems;                                       // 0x0011(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSkipRevive;                                              // 0x0012(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSkipClearZoneInfo;                                       // 0x0013(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSkipClearOddEffect;                                      // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSkipFullRecoverHP;                                       // 0x0015(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSkipFullRecoverMP;                                       // 0x0016(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOverrideGambit;                                          // 0x0017(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGambit OverrideGambit;                                           // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CoordinateID;                                             // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Handedness;                                               // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Hand;                                                     // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Head;                                                     // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Body;                                                     // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Accessory1;                                               // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Accessory2;                                               // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item1;                                                    // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item2;                                                    // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item3;                                                    // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item4;                                                    // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item5;                                                    // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item6;                                                    // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> TokugiPanelNames;                                         // 0x0088(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> TokugiNames;                                              // 0x0098(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public bool bSScenarioSettings;                                       // 0x00A8(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSScenario_OverrideGold;                                  // 0x00A9(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SScenario_Gold;                                           // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> SScenario_Items;                                          // 0x00B0(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> SScenario_Soubis;                                         // 0x00C0(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> SScenario_Daizis;                                         // 0x00D0(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableText
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableText : FTableRowBase
    {
        public string Text;                                                     // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public EJackTextType Type;                                                     // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TalkerID;                                                 // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)

        public int Flags;

        public bool bNoTurn
        {
            get
            {
                return (Flags & 1) != 0;
            }
            set
            {
                Flags = (byte)((Flags & ~1) | (value ? 1 : 0));
            }
        }

        public bool bNoTalkStartEvent
        {
            get
            {
                return (Flags & 2) != 0;
            }
            set
            {
                Flags = (byte)((Flags & ~2) | (value ? 2 : 0));
            }
        }

        public bool bResetByMapJump
        {
            get
            {
                return (Flags & 4) != 0;
            }
            set
            {
                Flags = (byte)((Flags & ~4) | (value ? 4 : 0));
            }
        }

        public bool bScenarioGuide
        {
            get
            {
                return (Flags & 8) != 0;
            }
            set
            {
                Flags = (byte)((Flags & ~8) | (value ? 8 : 0));
            }
        }

        public bool bQuestGuide
        {
            get
            {
                return (Flags & 0x10) != 0;
            }
            set
            {
                Flags = (byte)((Flags & ~0x10) | (value ? 0x10 : 0));
            }
        }

        //public byte bNoTurn : 1;                                              // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        //public byte bNoTalkStartEvent : 1;                                    // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        //public byte bResetByMapJump : 1;                                      // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        //public byte bScenarioGuide : 1;                                       // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        //public byte bQuestGuide : 1;                                          // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFukidasi
    // 0x0008 (0x0038 - 0x0030)
    public class FJackDataTableFukidasi : FJackDataTableText
    {
        public EJackFukidasiType FukidasiType;                                             // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFukidasiDuration FukidasiDuration;                                         // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonGameResumeSettingItemZukan
    // 0x0028 (0x0030 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonGameResumeSettingItemZukan : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value1;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value2;                                                   // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonGameResumeSettingMonsterZukan
    // 0x0028 (0x0030 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonGameResumeSettingMonsterZukan : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value1;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value2;                                                   // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackGrantCommand
    // 0x0018
    public class FJackGrantCommand : FTableRowBase
    {
        public FName Cmd0;                                                     // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Cmd1;                                                     // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Cmd2;                                                     // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonGameResumeSettingItem
    // 0x0028 (0x0030 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonGameResumeSettingItem : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value1;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value2;                                                   // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackGrantCommand> Cmds;                                                     // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonGameResumeSettingParty
    // 0x0028 (0x0030 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonGameResumeSettingParty : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value1;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value2;                                                   // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonGameResumeSettingFlag
    // 0x0028 (0x0030 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonGameResumeSettingFlag : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value1;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value2;                                                   // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonLevelUpTable
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonLevelUpTable : FTableRowBase
    {
        public int DQ1_RequiredExp;                                          // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DQ2_RequiredExp;                                          // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonItemTable
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonItemTable : FTableRowBase
    {
        public FName ItemID;                                                   // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonRestartPointTable
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableFukkatunojumonRestartPointTable : FTableRowBase
    {
        public FName ChurchId;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapStart;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumon
    // 0x0018 (0x0020 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumon : FTableRowBase
    {
        public string SpellResurrection;                                        // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int ScenarioProgress;                                         // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFukkatunojumonSpecial SpecialType;                                              // 0x001C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonScenarioProgress
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableFukkatunojumonScenarioProgress : FTableRowBase
    {
        public int ScenarioProgress;                                         // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReturnScenarioProgress;                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlagCategory;                                             // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlagId;                                                   // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int RestartPoint;                                             // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool ScenarioStartFlag;                                        // 0x0024(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioTitleNameId;                                      // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioDescriptionId;                                    // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioTexture;
        public List<bool> RestartPoints;                                            // 0x0050(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int TripleReturnScenarioProgress;                             // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonSettingTable2D
    // 0x0020 (0x0028 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonSettingTable2D : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value1;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value2;                                                   // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFukkatunojumonRestartTable2D
    // 0x0018 (0x0020 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableFukkatunojumonRestartTable2D : FTableRowBase
    {
        public int EmbarkationMapId;                                         // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte EmbarkationLocatorId;                                     // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte EmbarkationAnchorageId;                                   // 0x000D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte RespawnShipPointId;                                       // 0x000E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int RespawnMapId;                                             // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte RespawnMapJumpLocatorId;                                  // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte RespawnEventType;                                         // 0x0015(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte PrevScenarioId;                                           // 0x0016(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte PrevScenarioFlag;                                         // 0x0017(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PrevCutSceneId;                                           // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableGameFlag
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableGameFlag : FTableRowBase
    {
        public EJackGameFlagCategory Category;                                                 // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlagNo;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGameFlagDataType DataType;                                                 // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string DefaultValue;                                             // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)

        public byte Flags;
        // TODO public byte bReadOnly : 1;                                            // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        // TODO public byte bCarryOver : 1;                                           // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        // TODO public byte bResistLoad : 1;                                          // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableGameFlagScenario
    // 0x0008 (0x0040 - 0x0038)
    public class FJackDataTableGameFlagScenario : FJackDataTableGameFlag
    {
        public byte ScenarioFlags;
        //TODO public bool bScenarioFlag;                                            // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //TODO public bool bScenarioFlagLVD;                                         // 0x0039(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //TODO public bool bUpdatesLatestFlag;                                       // 0x003A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackScenarioID ScenarioID;                                               // 0x003B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ScenarioFlagIndex;                                        // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableGuestNPCList
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableGuestNPCList : FTableRowBase
    {
        public EJackCharacter JackCharacter;                                            // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter NormalizedJackCharacter;                                  // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCID;                                                    // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Height;                                                   // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableHiddenBonesDef
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableHiddenBonesDef : FTableRowBase
    {
        public List<FName> TargetBones;                                              // 0x0008(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableItem
    // 0x01E0 (0x01E8 - 0x0008)
    public class FJackDataTableItem : FTableRowBase
    {
        public FName ItemNameID;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SortNo;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int StrengthNo;                                               // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PhoneticNo;                                               // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PictorialBookNo;                                          // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LapNo;                                                    // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ClassificationID;                                         // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeBookID;                                             // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Rarity;                                                   // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PlusValue;                                                // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Price_Buying;                                             // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Price_Selling;                                            // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string GetMEType;                                                // 0x0048(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName GetSEID;                                                  // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackItemGetIcon GetIconType;                                              // 0x0060(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName UnitNameID;                                               // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DescriptionID;                                            // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SpecificAbilityDescriptionID;                             // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName UsingActionID;                                            // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName UsingEvent;                                               // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName UsingEventParameter;                                      // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Kougekiryoku;                         // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Syubiryoku;                           // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ParameterCorrection_MPKyuuSyuuRate;                       // 0x00A0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ParameterCorrection_BukiGuardRate;                        // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ParameterCorrection_TateGuardRate;                        // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ParameterCorrection_MikawasiRate;                         // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ParameterCorrection_CriticalRate;                         // 0x00B0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ParameterCorrection_ZoneOnRate;                           // 0x00B4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Tikara;                               // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Minomamori;                           // 0x00BC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Kiyousa;                              // 0x00C0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Subayasa;                             // 0x00C4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_KougekiMaryoku;                       // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_KaifukuMaryoku;                       // 0x00CC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_MaxHP;                                // 0x00D0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_MaxMP;                                // 0x00D4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Miryoku;                              // 0x00D8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackItem_ParameterType MajorParameter1;                                          // 0x00DC(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackItem_ParameterType MajorParameter2;                                          // 0x00DD(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackItem_ParameterType MajorParameter3;                                          // 0x00DE(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackItem_ParameterType MajorParameter4;                                          // 0x00DF(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectID_01;                                           // 0x00E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectID_02;                                           // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectID_03;                                           // 0x00F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectID_04;                                           // 0x00F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P001;                                  // 0x0100(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P002;                                  // 0x0101(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P003;                                  // 0x0102(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P004_2;                                // 0x0103(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P004_3;                                // 0x0104(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P005;                                  // 0x0105(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P006;                                  // 0x0106(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P007;                                  // 0x0107(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEquipmentPossible_P008;                                  // 0x0108(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int EquipmentLevel;                                           // 0x010C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCanConsume;                                              // 0x0110(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCanBuy;                                                  // 0x0111(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackItem_SellType SellType;                                                 // 0x0112(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackItem_DiscardType DiscardType;                                              // 0x0113(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLeaveAtSort;                                             // 0x0114(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bStoreCommonBag;                                          // 0x0115(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LimitedNumber;                                            // 0x0118(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MenuIconTexture;
        public FName PictureBookIconTexture;
        public FName PopIconTexture;
        public FName EquipmentStaticMesh_Main;
        public FName EquipmentStaticMesh_Main_L;
        public FName EquipmentStaticMesh_Sub;
        public FName EquipmentSkeletalMesh_Main;
        public FName EquipmentSkeletalMesh_Sub;
        public EJackItem_EquipmentSE EquipmentSE;                                              // 0x01E0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TripleItemNo;                                             // 0x01E4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableGameFlagCutScene
    // 0x0008 (0x0040 - 0x0038) JackDataTableGameFlagCutScene
    public class FJackDataTableGameFlagCutScene : FJackDataTableGameFlag
    {
        [Serializer(Size = 1)]
        public bool                                               bCutSceneFlag;                                            // 0x0038(0x0001) (Edit, BlueprintVisible, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableItem_Equipment
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableItem_Equipment : FTableRowBase
    {
        public EJackItem_Classification Classification;                                           // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackEquipmentMultiple EquipmentMultiple;                                        // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackEquipmentRegion EquipmentRegion;                                          // 0x000A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackEquipmentRegion MultipleEquipmentRegion;                                  // 0x000B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackEquipmentRegion ReleaseRegion;                                            // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bStoreEquipmentBag;                                       // 0x000D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableItem_EventGet
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableItem_EventGet : FTableRowBase
    {
        public int Gold;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNumber;                                               // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TextID;                                                   // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string MeId;                                                     // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName SeAsset;
    }

    // ScriptStruct JackGame.JackDataTable_MultiVoice
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTable_MultiVoice : FTableRowBase
    {
        public bool bFlag;                                                    // 0x0008(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableItem_Present
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableItem_Present : FTableRowBase
    {
        public int Gold;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemId_01;                                                // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemCount_01;                                             // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemId_02;                                                // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemCount_02;                                             // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemId_03;                                                // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemCount_03;                                             // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemId_04;                                                // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemCount_04;                                             // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TripleDlcNo;                                              // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableItem_Seed
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableItem_Seed : FTableRowBase
    {
        public int ParameterCorrection_Tikara;                               // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Minomamori;                           // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Subayasa;                             // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Kiyousa;                              // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_Miryoku;                              // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_KougekiMaryoku;                       // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_KaifukuMaryoku;                       // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_MaxHP;                                // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_MaxMP;                                // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ParameterCorrection_TokugiPoint;                          // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableItemGettable_Common
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableItemGettable_Common : FTableRowBase
    {
        public FName GetFlag;                                                  // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGettableCommonPurpose Purpose;                                                  // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapVolumeID_001;                                          // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapVolumeID_002;                                          // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapVolumeID_003;                                          // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Gold;                                                     // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_001;                                               // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_001;                                              // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_002;                                               // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_002;                                              // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_003;                                               // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_003;                                              // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableItemGettable_GmmickDrop
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableItemGettable_GmmickDrop : FTableRowBase
    {
        public FName GetFlag;                                                  // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapId;                                                    // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ScenarioSequenceNo;                                       // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Minitue;                                                  // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_001;                                               // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_001;                                              // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_002;                                               // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_002;                                              // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_003;                                               // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_003;                                              // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableKaziCategory
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableKaziCategory : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PartsIndex;                                               // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableKaziUnderCorrection
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableKaziUnderCorrection : FTableRowBase
    {
        public int PlayerLv_Min;                                             // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PlayerLv_Max;                                             // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_11;                                            // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_10;                                            // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_9;                                             // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_8;                                             // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_7;                                             // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_6;                                             // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_5;                                             // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_4;                                             // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_3;                                             // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Correction_2;                                             // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableItemGettable_TreasureBox
    // 0x0070 (0x0078 - 0x0008)
    public class FJackDataTableItemGettable_TreasureBox : FTableRowBase
    {
        public FName GetFlag;                                                  // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapVolumeID_001;                                          // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapVolumeID_002;                                          // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapVolumeID_003;                                          // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackTreasureBoxPlacementCondition PlacementConditionType;                                   // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PlacementConditionParameter;                              // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Gold;                                                     // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_001;                                               // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_001;                                              // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_002;                                               // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_002;                                              // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_003;                                               // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_003;                                              // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MimicEventBattleID;                                       // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableKaziLv
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableKaziLv : FTableRowBase
    {
        public int PlayerLv;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaxCP;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ForgedPower_Min;                                          // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ForgedPower_Max;                                          // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Kaisin_Percentage;                                        // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int UnderRank;                                                // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableKaziQuality
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableKaziQuality : FTableRowBase
    {
        public FName PartsKind;                                                // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TotalRange_Fail;                                          // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TotalRange_1;                                             // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TotalRange_2;                                             // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TotalRange_3;                                             // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TotalRange_4;                                             // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DaiseikouBonusValue;                                      // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableKaziSafetyArea
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTableKaziSafetyArea : FTableRowBase
    {
        public int SafetyArea_1_L_Min;                                       // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_1_L_Max;                                       // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_1_R_Min;                                       // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_1_R_Max;                                       // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_2_L_Min;                                       // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_2_L_Max;                                       // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_2_R_Min;                                       // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_2_R_Max;                                       // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_3_L_Min;                                       // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_3_L_Max;                                       // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_3_R_Min;                                       // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_3_R_Max;                                       // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_4_L_Min;                                       // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_4_L_Max;                                       // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_4_R_Min;                                       // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SafetyArea_4_R_Max;                                       // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableLetterList
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableLetterList : FTableRowBase
    {
        public int Unicode;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int AlternativeLetter;                                        // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPatchimType PatchimType;                                              // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackSubLevelStatus
    // 0x0018
    public class FJackSubLevelStatus : FTableRowBase
    {
        public FName LevelPackageName;                                         // 0x0000(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackStreamingStatus StreamingStatus;                                          // 0x0008(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public int LODIndex;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bPlayerInside;                                            // 0x0010(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bCharaData;                                               // 0x0011(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bMonsterData;                                             // 0x0012(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public bool bResidentData;                                            // 0x0013(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableLevelStreamingStatus
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableLevelStreamingStatus : FTableRowBase
    {
        public List<FJackSubLevelStatus> LevelStreamingStatus;                                     // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableLoading
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTableLoading : FTableRowBase
    {
        public FName Type;                                                     // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName If;                                                       // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName IfNum;                                                    // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName IfNum2;                                                   // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string Title;                                                    // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string Text;                                                     // 0x0038(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableLookAtBoneSetting
    // 0x0090 (0x0098 - 0x0008)
    public class FJackDataTableLookAtBoneSetting : FTableRowBase
    {
        public FJackLookAtBoneSetting Spine1;                                                   // 0x0008(0x0024) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FJackLookAtBoneSetting Spine2;                                                   // 0x002C(0x0024) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FJackLookAtBoneSetting Neck;                                                     // 0x0050(0x0024) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FJackLookAtBoneSetting Head;                                                     // 0x0074(0x0024) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMap
    // 0x0050 (0x0058 - 0x0008)
    public class FJackDataTableMap : FTableRowBase
    {
        public FName ClassificationID;                                         // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID;                                                    // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RespawnPointID;                                           // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMapVisitEnabled;                                         // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMapVisitAchievement;                                     // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bHorseCallEnabled;                                        // 0x0022(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather;                                                  // 0x0023(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel;                                                // 0x0024(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle;                                                // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute;                                    // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RegisterRuraID;                                           // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ShipMoveTag;                                              // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID;                                                   // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int FollowingCharactersMode;                                  // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDataListUpBeforeCollapse;                                // 0x004C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDataListUpAfterTheFall;                                  // 0x004D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDataListUpTwoLap;                                        // 0x004E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDataListUpNewStory;                                      // 0x004F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DataListSortNo;                                           // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TripleAreaNo;                                             // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMapStart
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMapStart : FTableRowBase
    {
        public FName MapId;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LevelStreamingStatusID;                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CameraNo;                                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackMaterialCoordinate
    // 0x0020
    public class FJackMaterialCoordinate : FTableRowBase
    {
        public FName TypeName;                                                 // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OverrideMaterial;
    }

    // ScriptStruct JackGame.JackDataTableMaterialCoordinate
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableMaterialCoordinate : FTableRowBase
    {
        public FName TargetMaterial;
        public List<FJackMaterialCoordinate> MaterialCoordinates;                                      // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMaterialCoordinateType
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMaterialCoordinateType : FTableRowBase
    {
        public FName VariableName;                                             // 0x0008(0x0008) (ZeroConstructor, IsPlainOldData)
        public EJackMaterialParameterControlMethod Method;                                                   // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ApplyRateMaterialParameterName;                           // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bResidentMaterials;                                       // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMedalExchange
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMedalExchange : FTableRowBase
    {
        public FName ItemID;                                                   // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ExchangeNumber;                                           // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackExchange ExchangeType;                                             // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMedalStamp
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableMedalStamp : FTableRowBase
    {
        public FName ItemID;                                                   // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int StampNumber;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName IconTexture;
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotBarChance
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotBarChance : FTableRowBase
    {
        public int BlueBack;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int RedBack;                                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int GoldBack;                                                 // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MeatBack;                                                 // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotBGM
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotBGM : FTableRowBase
    {
        public FName BGMID;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotBGMProbability
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotBGMProbability : FTableRowBase
    {
        public int NormalBGM;                                                // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int StockBgm;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotBonusMonsterEncounterProbability
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotBonusMonsterEncounterProbability : FTableRowBase
    {
        public int Level1;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level2;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level3;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level4;                                                   // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level5;                                                   // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotBossMonsterSelectProbability
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotBossMonsterSelectProbability : FTableRowBase
    {
        public int Stock;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int No_Stock;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BGMProb_Stock;                                            // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BGMProb_No_Stock;                                         // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BattlePeriodRange;                                        // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotConfigurationMain
    // 0x00D8 (0x00E0 - 0x0008)
    public class FJackDataTableMeosiSlotConfigurationMain : FTableRowBase
    {
        public FName HandProb_Def;                                             // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName HandProb_CZ;                                              // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BonusProb_Def_Def;                                        // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BonusProb_Def_High;                                       // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BonusProb_Def_Heven;                                      // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BonusProb_CZ_Def;                                         // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BonusProb_CZ_High;                                        // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BonusProb_CZ_Heven;                                       // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BonusRising;                                              // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TransStProb1_Def_Def;                                     // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TransStProb1_Def_High;                                    // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TransStProb1_Def_Heven;                                   // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TransStProb1_CZ_Def;                                      // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TransStProb1_CZ_High;                                     // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TransStProb1_CZ_Heven;                                    // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TransStProb2;                                             // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TransStProb3;                                             // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Ceiling_Def;                                              // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Ceiling_High;                                             // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Ceiling_Heven;                                            // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CeilingAT_Def;                                            // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CeilingAT_High;                                           // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CeilingAT_Heven;                                          // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BonusStock;                                               // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ExtraEffect;                                              // 0x00C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EncountMonsterCnt;                                        // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterRecruitCor;                                        // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotEncounteredMonsterCount
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableMeosiSlotEncounteredMonsterCount : FTableRowBase
    {
        public int Count1;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count2;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count3;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count4;                                                   // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count5;                                                   // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count6;                                                   // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count7;                                                   // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count8;                                                   // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count9;                                                   // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count10;                                                  // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Count99;                                                  // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotPseudoContinuation
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotPseudoContinuation : FTableRowBase
    {
        public int Game0;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game1;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game2;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game3;                                                    // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game4;                                                    // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotDrakeeEffect
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTableMeosiSlotDrakeeEffect : FTableRowBase
    {
        public int Nothing;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Single;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Gust;                                                     // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Calm;                                                     // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Double_A;                                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Double_B;                                                 // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Double_C;                                                 // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Tripple;                                                  // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Square;                                                   // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DogLeg;                                                   // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int V_Shaped;                                                 // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Back_Slash;                                               // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Minus;                                                    // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Flock;                                                    // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotShimofuriChance
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotShimofuriChance : FTableRowBase
    {
        public float Probability;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotExtraEffect
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotExtraEffect : FTableRowBase
    {
        public int ReelLightOff;                                             // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceCutin_Default;                                      // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Door;                                                     // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceCutin_StepUp;                                       // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int FireLamp;                                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotLongFreeze
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotLongFreeze : FTableRowBase
    {
        public float Probability;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotFlavorItemKindSelectProbability
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotFlavorItemKindSelectProbability : FTableRowBase
    {
        public int Probability;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotFlavorItemRankSelectProbability
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotFlavorItemRankSelectProbability : FTableRowBase
    {
        public int Rank1;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Rank2;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Rank3;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Rank4;                                                    // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Rank5;                                                    // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotHandStopRange
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotHandStopRange : FTableRowBase
    {
        public List<float> StopRange;                                                // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotHandStopType
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotHandStopType : FTableRowBase
    {
        public EJackMeosiSlotReelPattern StopType;                                                 // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotHandsOrder
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotHandsOrder : FTableRowBase
    {
        public int Num;                                                      // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotReelPattern HandName;                                                 // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotItemList
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotItemList : FTableRowBase
    {
        public FName Key;                                                      // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotItemParam
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTableMeosiSlotItemParam : FTableRowBase
    {
        public string NameText;                                                 // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public EJackMeosiSlotItemKind Kind;                                                     // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Texture;
        public EJackMeosiSlotItemSpec ItemID;                                                   // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotItemProbability
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMeosiSlotItemProbability : FTableRowBase
    {
        public int Orb_Default;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_Default;                                             // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Mimic_Default;                                            // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int FlavorText_Default;                                       // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Orb_CZ;                                                   // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_CZ;                                                  // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Mimic_CZ;                                                 // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int FlavorText_CZ;                                            // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotTextures
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotTextures : FTableRowBase
    {
        public List<FName> Textures;
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotShimohuriResultME
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotShimohuriResultME : FTableRowBase
    {
        public int Nums;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string MeId;                                                     // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotShimohuriAppearRate
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotShimohuriAppearRate : FTableRowBase
    {
        public int AppRate;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterID MonsterID;                                                // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotShimohuriRefundSetting
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotShimohuriRefundSetting : FTableRowBase
    {
        public int UperRefundRate;                                           // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LowerRefundRate;                                          // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int UperMonsterCnt;                                           // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LowerMonsterCnt;                                          // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AdjustRate;                                               // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotBreakOffRefundSetting
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotBreakOffRefundSetting : FTableRowBase
    {
        public float EachGameRate;                                             // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float UperRate;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float LowerRate;                                                // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotRefundRate
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotRefundRate : FTableRowBase
    {
        public float ShimohuriRate;                                            // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ClearanceRate;                                            // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotEtcConf
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTableMeosiSlotEtcConf : FTableRowBase
    {
        public int HighProbMin;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BonusGames;                                               // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WinFixed;                                                 // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int HintHighSet;                                              // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int HintOddEven;                                              // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ForceExactly;                                             // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int FeedPat;                                                  // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ComeBack;                                                 // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NumEndedGame;                                             // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float SimRpm;                                                   // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SettingAskGames;                                          // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int AutoPlayGames;                                            // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AutoPlayInterval;                                         // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float SimCountLowerRate;                                        // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float SimCountUperRate;                                         // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMissHit
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotMissHit : FTableRowBase
    {
        public int Miss;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Hit;                                                      // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotHandHsToNm
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotHandHsToNm : FTableRowBase
    {
        public EJackMeosiSlotHand NmHand;                                                   // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotHandNmToHs
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotHandNmToHs : FTableRowBase
    {
        public EJackMeosiSlotHsHand HsHand;                                                   // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotPercentLottery
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotPercentLottery : FTableRowBase
    {
        public int Percent;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotSptContinueProb
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotSptContinueProb : FTableRowBase
    {
        public int ContProb;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotSptAuraPoint
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotSptAuraPoint : FTableRowBase
    {
        public int LastSucceedProb;                                          // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotSpTrainingAuraColor AuraColor;                                                // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotSptHandsPoint
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotSptHandsPoint : FTableRowBase
    {
        public int MinPoint;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaxPoint;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int AtAddChgProb;                                             // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NoAddChgProb;                                             // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotUnionScenarioBlock
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotUnionScenarioBlock : FTableRowBase
    {
        public EJackMeosiSlotUnionScenarioBranch Branch;                                                   // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MinNum;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaxNum;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cont;                                                     // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotUnionScenario
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMeosiSlotUnionScenario : FTableRowBase
    {
        public int Group;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Ratio;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int FirstNum;                                                 // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackDataTableMeosiSlotUnionScenarioBlock> GameStructArray;                                          // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotActNoBase
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotActNoBase : FTableRowBase
    {
        public EJackMeosiSlotScenarioActNo ActBase;                                                  // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotRouteNum
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotRouteNum : FTableRowBase
    {
        public int RouteNum;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotActControl
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMeosiSlotActControl : FTableRowBase
    {
        public List<bool> RandomTorFArray;                                          // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<bool> TorFArray;                                                // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotScenarioRandom
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMeosiSlotScenarioRandom : FTableRowBase
    {
        public List<EJackMeosiSlotScenarioActNo>   ActNoArray;                                               // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<int> RatioArray;                                               // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotScenarioPatternBlock
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotScenarioPatternBlock : FTableRowBase
    {
        public EJackMeosiSlotScenarioActNo ActNo;                                                    // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int GameNum;                                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotScenarioHint Hint;                                                     // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotScenarioStage Stage;                                                    // 0x0011(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotScenarioSPTraining Training;                                                 // 0x0012(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotScenarioPattern
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTableMeosiSlotScenarioPattern : FTableRowBase
    {
        public int Route;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Group;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Ratio;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int OrderInPattern;                                           // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int OrderInGroup;                                             // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<bool> HandTorFArray;                                            // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FJackDataTableMeosiSlotScenarioPatternBlock> ActStructArray;                                           // 0x0030(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotScenarioSlime
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMeosiSlotScenarioSlime : FTableRowBase
    {
        public int Slime;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Peach;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Metal;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotScenarioSubAct SubAct;                                                   // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Probability;                                              // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotKeySeType KeySeType;                                                // 0x001C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KeySeProb;                                                // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotScenarioHazure
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotScenarioHazure : FTableRowBase
    {
        public EJackMeosiSlotScenarioHazureKind ScenarioKind;                                             // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotScenarioSubAct SubAct;                                                   // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Probability;                                              // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotKeySeType KeySeType;                                                // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KeySeProb;                                                // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotScenarioTBox
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotScenarioTBox : FTableRowBase
    {
        public EJackMeosiSlotScenarioTBoxKind ScenarioKind;                                             // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotScenarioSubAct SubAct;                                                   // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Probability;                                              // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotKeySeType KeySeType;                                                // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KeySeProb;                                                // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotScenarioTBoxOpenTiming OpenTiming;                                               // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotScenarioMamono
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotScenarioMamono : FTableRowBase
    {
        public EJackMeosiSlotScenarioMamonoKind ScenarioKind;                                             // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotScenarioSubAct SubAct;                                                   // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Probability;                                              // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotKeySeType KeySeType;                                                // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KeySeProb;                                                // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotScenario
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotScenario : FTableRowBase
    {
        public int ScenarioKind;                                             // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SubAct;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Probability;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotLottery
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotLottery : FTableRowBase
    {
        public List<int> EventLottery;                                             // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotRareHandBonusLottery
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotRareHandBonusLottery : FTableRowBase
    {
        public List<int> EventProbability;                                         // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotRareHandLottery
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotRareHandLottery : FTableRowBase
    {
        public List<int> EventProbability;                                         // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotHsHandLottery
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotHsHandLottery : FTableRowBase
    {
        public List<int> HsHandProbability;                                        // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotLowestFeedNumberProbability
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTableMeosiSlotLowestFeedNumberProbability : FTableRowBase
    {
        public int Feed_Stock_1;                                             // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_Stock_2;                                             // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_Stock_3;                                             // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_Stock_4;                                             // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_Stock_5;                                             // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_Stock_6;                                             // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_Stock_7;                                             // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_Stock_8;                                             // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_NoStock_1;                                           // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_NoStock_2;                                           // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_NoStock_3;                                           // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_NoStock_4;                                           // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_NoStock_5;                                           // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_NoStock_6;                                           // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_NoStock_7;                                           // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Feed_NoStock_8;                                           // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotSettingValueProbability
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMeosiSlotSettingValueProbability : FTableRowBase
    {
        public int SettingValue1;                                            // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SettingValue2;                                            // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SettingValue3;                                            // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SettingValue4;                                            // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SettingValue5;                                            // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SettingValue6;                                            // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SettingValue7;                                            // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMachine
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotMachine : FTableRowBase
    {
        public EJackMeosiSlotMachineGroup Group;                                                    // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMachineCondition
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotMachineCondition : FTableRowBase
    {
        public int Level_2;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level_3;                                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level_4;                                                  // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level_5;                                                  // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Level_6;                                                  // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMachineConditionMessage
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotMachineConditionMessage : FTableRowBase
    {
        public int Percent;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TextID;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMonsterBehaviorProbability
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotMonsterBehaviorProbability : FTableRowBase
    {
        public int Attack_2;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Attack_3;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Attack_4;                                                 // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMonsterEncounterProbability
    // 0x0050 (0x0058 - 0x0008)
    public class FJackDataTableMeosiSlotMonsterEncounterProbability : FTableRowBase
    {
        public int Game_2;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_3;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_4;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_5;                                                   // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_6;                                                   // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_7;                                                   // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_8;                                                   // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_9;                                                   // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_10;                                                  // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_11;                                                  // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_12;                                                  // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_13;                                                  // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_14;                                                  // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_15;                                                  // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_16;                                                  // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_17;                                                  // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_18;                                                  // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_19;                                                  // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_20;                                                  // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Game_21;                                                  // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMonsterList
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotMonsterList : FTableRowBase
    {
        public FName Key;                                                      // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Probability;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMonsterParam
    // 0x00D0 (0x00D8 - 0x0008)
    public class FJackDataTableMeosiSlotMonsterParam : FTableRowBase
    {
        public string NameText;                                                 // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public bool RareFlag;                                                 // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterBehaviorPattern Pattern;                                                  // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Attack1_Damage;                                           // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotAttackClass Attack1_Class;                                            // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotAttackEffect Attack1_Effect;                                           // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Attack1_TextID;                                           // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Attack2_Damage;                                           // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotAttackClass Attack2_Class;                                            // 0x0034(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotAttackEffect Attack2_Effect;                                           // 0x0035(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Attack2_TextID;                                           // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Attack3_Damage;                                           // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotAttackClass Attack3_Class;                                            // 0x0044(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotAttackEffect Attack3_Effect;                                           // 0x0045(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Attack3_TextID;                                           // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Attack4_Damage;                                           // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotAttackClass Attack4_Class;                                            // 0x0054(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotAttackEffect Attack4_Effect;                                           // 0x0055(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Attack4_TextID;                                           // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Avoidance;                                                // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Avoidance_TextID;                                         // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BaseHp;                                                   // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int HpRange;                                                  // 0x0074(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPhysicalResistance;                                      // 0x0078(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMagicalResistance;                                       // 0x0079(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Rank;                                                     // 0x007A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LvUp;                                                     // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterSize Size;                                                     // 0x0080(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PartyTexture;
        public FName EnemyTexture;
        public FName IconTexture;
        public EJackMeosiSlotMonsterID MonsterID;                                                // 0x00D0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMonsterRankMap
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotMonsterRankMap : FTableRowBase
    {
        public EJackMeosiSlotMonsterRank Lv1_6;                                                    // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv6_11;                                                   // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv11_16;                                                  // 0x000A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv16_21;                                                  // 0x000B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv21_26;                                                  // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv26_31;                                                  // 0x000D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv31_36;                                                  // 0x000E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv36_41;                                                  // 0x000F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv41_46;                                                  // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv46_51;                                                  // 0x0011(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv51_56;                                                  // 0x0012(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv56_61;                                                  // 0x0013(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv61_66;                                                  // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv66_71;                                                  // 0x0015(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv71_76;                                                  // 0x0016(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv76_81;                                                  // 0x0017(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv81_86;                                                  // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv86_91;                                                  // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv91_96;                                                  // 0x001A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterRank Lv96_100;                                                 // 0x001B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMonsterRankSelectProbability
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotMonsterRankSelectProbability : FTableRowBase
    {
        public int Probability;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMonsterRecruitProbability
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableMeosiSlotMonsterRecruitProbability : FTableRowBase
    {
        public float PartyNum_1;                                               // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_2;                                               // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_3;                                               // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_4;                                               // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_5;                                               // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_6;                                               // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_7;                                               // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_8;                                               // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_9;                                               // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_10;                                              // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_11;                                              // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PartyNum_Over;                                            // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotMonsterResource
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableMeosiSlotMonsterResource : FTableRowBase
    {
        public FName PanelTexture;
        public FName BattleTexture;
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotPamphlet
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotPamphlet : FTableRowBase
    {
        public FName Texture;
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotPayingOut
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotPayingOut : FTableRowBase
    {
        public int Rate001;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Rate010;                                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Rate100;                                                  // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotFireLampColor LampColor;                                                // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotProbability
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableMeosiSlotProbability : FTableRowBase
    {
        public int Replay;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Plum_Weak;                                                // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Plum_Strong;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Weak;                                          // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Strong;                                        // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Weak;                                              // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Strong;                                            // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Triple;                                            // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Center;                                            // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Bel;                                                      // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Weak;                                              // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Strong;                                            // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Most_Strong;                                       // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Weak;                                          // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Strong;                                        // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Reach;                                                    // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BigBonus;                                                 // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SpecialBonus;                                             // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotReelArray
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotReelArray : FTableRowBase
    {
        public List<EJackMeosiSlotPicture>         Elements;                                                 // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
}

    // ScriptStruct JackGame.JackDataTableMeosiSlotReelLamp
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotReelLamp : FTableRowBase
    {
        public bool LT;                                                       // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool CT;                                                       // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool RT;                                                       // 0x000A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool LM;                                                       // 0x000B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool CM;                                                       // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool RM;                                                       // 0x000D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool LB;                                                       // 0x000E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool CB;                                                       // 0x000F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool RB;                                                       // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Time;                                                     // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotReelTexture
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableMeosiSlotReelTexture : FTableRowBase
    {
        public FName BaseTexture;
        public FName MaskTexture;
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotSE
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableMeosiSlotSE : FTableRowBase
    {
        public FName SeJapan;
        public FName SeAsia;
        public FName SeOthers;
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotSimulation
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotSimulation : FTableRowBase
    {
        public float WinningProbability;                                       // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ExactlyPressProbability;                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotSpecialBonusRisingProbability
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMeosiSlotSpecialBonusRisingProbability : FTableRowBase
    {
        public int Bonus;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ExactlyPress;                                             // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotStockNumber
    // 0x0090 (0x0098 - 0x0008)
    public class FJackDataTableMeosiSlotStockNumber : FTableRowBase
    {
        public int WaterMelon_Weak_2;                                        // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Weak_3;                                        // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Weak_4;                                        // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Strong_2;                                      // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Strong_3;                                      // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Strong_4;                                      // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Weak_2;                                            // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Weak_3;                                            // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Weak_4;                                            // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Strong_2;                                          // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Strong_3;                                          // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Strong_4;                                          // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Triple_2;                                          // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Triple_3;                                          // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Triple_4;                                          // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Center_2;                                          // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Center_3;                                          // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Center_4;                                          // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Weak_2;                                            // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Weak_3;                                            // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Weak_4;                                            // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Strong_2;                                          // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Strong_3;                                          // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Strong_4;                                          // 0x0064(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Most_Strong_2;                                     // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Most_Strong_3;                                     // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Most_Strong_4;                                     // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Weak_2;                                        // 0x0074(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Weak_3;                                        // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Weak_4;                                        // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Strong_2;                                      // 0x0080(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Strong_3;                                      // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Strong_4;                                      // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Reach_2;                                                  // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Reach_3;                                                  // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Reach_4;                                                  // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotTransitionProbability_CZ
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotTransitionProbability_CZ : FTableRowBase
    {
        public int Default;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int High;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Heaven;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotTransitionProbability_Hand
    // 0x00E8 (0x00F0 - 0x0008)
    public class FJackDataTableMeosiSlotTransitionProbability_Hand : FTableRowBase
    {
        public int Miss_Default;                                             // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Miss_High;                                                // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Miss_Heaven;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Replay_Default;                                           // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Replay_High;                                              // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Replay_Heaven;                                            // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Plum_Weak_Default;                                        // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Plum_Weak_High;                                           // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Plum_Weak_Heaven;                                         // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Plum_Strong_Default;                                      // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Plum_Strong_High;                                         // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Plum_Strong_Heaven;                                       // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Weak_Default;                                  // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Weak_High;                                     // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Weak_Heaven;                                   // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Strong_Default;                                // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Strong_High;                                   // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WaterMelon_Strong_Heaven;                                 // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Weak_Default;                                      // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Weak_High;                                         // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Weak_Heaven;                                       // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Strong_Default;                                    // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Strong_High;                                       // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Strong_Heaven;                                     // 0x0064(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Triple_Default;                                    // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Triple_High;                                       // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Triple_Heaven;                                     // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Center_Default;                                    // 0x0074(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Center_High;                                       // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Cherry_Center_Heaven;                                     // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Bel_Default;                                              // 0x0080(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Bel_High;                                                 // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Bel_Heaven;                                               // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Weak_Default;                                      // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Weak_High;                                         // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Weak_Heaven;                                       // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Strong_Default;                                    // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Strong_High;                                       // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Strong_Heaven;                                     // 0x00A0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Most_Strong_Default;                               // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Most_Strong_High;                                  // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Chance_Most_Strong_Heaven;                                // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Weak_Default;                                  // 0x00B0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Weak_High;                                     // 0x00B4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Weak_Heaven;                                   // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Strong_Default;                                // 0x00BC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Strong_High;                                   // 0x00C0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ChanceSpot_Strong_Heaven;                                 // 0x00C4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Reach_Default;                                            // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Reach_High;                                               // 0x00CC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Reach_Heaven;                                             // 0x00D0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BigBonus_Default;                                         // 0x00D4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BigBonus_High;                                            // 0x00D8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int BigBonus_Heaven;                                          // 0x00DC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SpecialBonus_Default;                                     // 0x00E0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SpecialBonus_High;                                        // 0x00E4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SpecialBonus_Heaven;                                      // 0x00E8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotTransitionProbability_SettingValue
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMeosiSlotTransitionProbability_SettingValue : FTableRowBase
    {
        public int Default;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int High;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Heaven;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotTreasureBoxSelectProbability
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMeosiSlotTreasureBoxSelectProbability : FTableRowBase
    {
        public int Pot;                                                      // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Wood;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Red;                                                      // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Black;                                                    // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Gold;                                                     // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMeosiSlotVariableCeiling
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableMeosiSlotVariableCeiling : FTableRowBase
    {
        public int Val10;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val20;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val30;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val40;                                                    // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val50;                                                    // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val60;                                                    // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val70;                                                    // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val80;                                                    // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val90;                                                    // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Val99;                                                    // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotTowerSelectRate
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotTowerSelectRate : FTableRowBase
    {
        public int Slot;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Roulette;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotTowerRate
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMiniGameJackPotTowerRate : FTableRowBase
    {
        public int OneCoin;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TenCoin;                                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int HandredCoin;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotNPC
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotNPC : FTableRowBase
    {
        public float Percent;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotTowerAdditional
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMiniGameJackPotTowerAdditional : FTableRowBase
    {
        public int AdditionalBase;                                           // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FractionMin01;                                            // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FractionMax01;                                            // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FractionMin02;                                            // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FractionMax02;                                            // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotTowerCoin
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotTowerCoin : FTableRowBase
    {
        public int Coin;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotRouletteBetFraction
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotRouletteBetFraction : FTableRowBase
    {
        public float BetFraction;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Coin;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotFluctuations
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotFluctuations : FTableRowBase
    {
        public float Lower;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Upper;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotRate
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMiniGameJackPotRate : FTableRowBase
    {
        public float BetFraction;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float MachineFraction;                                          // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DividendMax;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DividendMin;                                              // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotProbability2
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotProbability2 : FTableRowBase
    {
        public float Percent;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotState
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMiniGameJackPotState : FTableRowBase
    {
        public float SlotFraction;                                             // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float RouletteFraction;                                         // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int JPLevel1;                                                 // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int JPLevel2;                                                 // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int JPLevel3;                                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int JPLevel4;                                                 // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int JPLevel5;                                                 // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotComp
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotComp : FTableRowBase
    {
        public int Coin;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotProbability
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotProbability : FTableRowBase
    {
        public int BasePercent;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Fraction;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMiniGameJackPotPayoutData
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMiniGameJackPotPayoutData : FTableRowBase
    {
        public int MinimumCoin;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaxCoin;                                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableModeChangeType
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableModeChangeType : FTableRowBase
    {
        public FName JumpPointID;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bChangeTo2D;                                              // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackLoadingScreen LoadingScreenType;                                        // 0x0011(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterAppear
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableMonsterAppear : FTableRowBase
    {
        public float VerticalWidth;                                            // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float VerticalWidth_Sleep;                                      // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Width;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DepthAdjustment;                                          // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CameraFOV;                                                // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartLength;                                              // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartHeight;                                              // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartHeight_Sleep;                                        // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndHeight;                                                // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndHeight_Sleep;                                          // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PointOfGazeDepth;                                         // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartPointOfGazeHeight;                                   // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartPointOfGazeHeight_Sleep;                             // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndPointOfGazeHeight;                                     // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndPointOfGazeHeight_Sleep;                               // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bException_arrangement;                                   // 0x0044(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ExceptionLocationX;                                       // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ExceptionLocationY;                                       // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ExceptionLocationZ;                                       // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ExceptionRotateYaw;                                       // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ExceptionCameraRotateYaw;                                 // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterDeploySerialize
    // 0x0000 (0x0228 - 0x0228)
    public class FJackDataTableMonsterDeploySerialize : FJackDataTableMonsterDeploy
    {

    }

    // ScriptStruct JackGame.JackDataTableMonsterFieldAI
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableMonsterFieldAI : FTableRowBase
    {
        public EJackMonsterMoveType MoveType;                                                 // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMoveMethod MoveMethod;                                               // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FieldBasicSpeed;                                          // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMoveSpeed ChaseSpeed;                                               // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMoveSpeed EscapeSpeed;                                              // 0x0011(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMoveSpeed RageSpeed;                                                // 0x0012(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterSearchType SearchType;                                               // 0x0013(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SearchRadius;                                             // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SearchAngle;                                              // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SpreadDistance;                                           // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSearchStandingPlayer;                                    // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bTakeWarnning;                                            // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMovementWeak MovementWeak;                                             // 0x0022(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMovementStrong MovementStrong;                                           // 0x0023(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterBowgunResonse BowgunResponse;                                           // 0x0024(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WeakMovementThreshold;                                    // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int AppealFrequency;                                          // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WakeUpRate;                                               // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterFieldMovingBounds
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTableMonsterFieldMovingBounds : FTableRowBase
    {
        public float WanderringRadius;                                         // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float WanderringMoveDistance;                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EscapeMoveDistance;                                       // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float RushMoveDistance;                                         // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ChaseRadiusFromFindLocation;                              // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ChaseRadiusFromPopLocation;                               // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ChaseRadiusFromFindTargetLocation;                        // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float MakikomiCylinderRadius;                                   // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float MakikomiCylinderHeight;                                   // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ProductionCostTotalLimit1;                                // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ProductionCostTotalLimit2;                                // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ProductionCostTotalLimit3;                                // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ProductionCostTotalLimit4;                                // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ProductionCostTotalLimit5;                                // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ProductionCostTotalLimit6;                                // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackMonsterMetalEncountInfo
    // 0x0010
    public class FJackMonsterMetalEncountInfo : FTableRowBase
    {
        public FName PartyMonsterId;                                           // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PartyMonsterMin;                                          // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PartyMonsterMax;                                          // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterMetalEncount
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMonsterMetalEncount : FTableRowBase
    {
        public float EncountRate;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackMonsterMetalEncountInfo> PartyMonsters;                                            // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMonsterPhysicalProperty
    // 0x0128 (0x0130 - 0x0008)
    public class FJackDataTableMonsterPhysicalProperty : FTableRowBase
    {
        public float ScaleX;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScaleY;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScaleZ;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacterEffectSize CharacterEffectSize;                                      // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacterEffectSize CharacterEffectSizeByActionCast;                          // 0x0015(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacterEffectSize CharacterEffectSizeByActionEffect;                        // 0x0016(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LODBoundsID;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LODLimitInBattle;                                         // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FacialPresetID;                                           // 0x0028(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VoicePresetID;                                            // 0x0030(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBlockCamera;                                             // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bVariantForm;                                             // 0x0039(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ProductionCost;                                           // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BasicSpeed;                                               // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMoveSpeed RunSpeed;                                                 // 0x0044(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BackBasicSpeed;                                           // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMoveSpeed BackRunSpeed;                                             // 0x004C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AcceptanceRadius;                                         // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIgnoreTakePosition;                                      // 0x0054(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIgnoreTurnWhenLookAt;                                    // 0x0055(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIgnoreDamageDirection;                                   // 0x0056(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIgnoreActionDirection;                                   // 0x0057(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUseBackWalk;                                             // 0x0058(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BackWalkAngleThreshold;                                   // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float BackWalkDistanceThreshold;                                // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float GroupRadius;                                              // 0x0064(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageS_BlendRate;                                        // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageS_BlendRate2;                                       // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float IdleToRunDuration;                                        // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float RunningTurnRate;                                          // 0x0074(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EscapeTurnSpeedMultiplier;                                // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Motion_EncountByNakamaYobi;                               // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bAlwaysNavWalking;                                        // 0x0088(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float NavWalkingDistance;                                       // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FootIKDisableDistance;                                    // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AttitudeDisableDistance;                                  // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AnimDynamicsDisableDistance;                              // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AlwaysUpdatePoseAndRefreshBoneDistance;                   // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLeaveMeshWhenDead;                                       // 0x00A0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLeaveCollisionWhenDead;                                  // 0x00A1(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AppealStartTimeMin;                                       // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float AppealStartTimeMax;                                       // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterBodyAttribute BodyAttribute;                                            // 0x00AC(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BodyMonsterId;                                            // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float OffsetLengthOf3dWidget;                                   // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIgnoreAlphabetOrder;                                     // 0x00BC(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ActionCameraLengthAdjust;                                 // 0x00C0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bRelativePosition;                                        // 0x00C4(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMatineeRenkeiMonsterSize MatineeRenkeiMonsterSize;                                 // 0x00C5(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float KnockBackSmallRate;                                       // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float KnockBackNormalRate;                                      // 0x00CC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScoreRectRedSocket;                                       // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectRedW;                                            // 0x00D8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectRedH;                                            // 0x00DC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectRedOffsetZ;                                      // 0x00E0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScoreRectBlueSocket;                                      // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectBlueW;                                           // 0x00F0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectBlueH;                                           // 0x00F4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectBlueOffsetZ;                                     // 0x00F8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScoreRectGreenSocket;                                     // 0x0100(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectGreenW;                                          // 0x0108(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectGreenH;                                          // 0x010C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectGreenOffsetZ;                                    // 0x0110(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScoreRectYellowSocket;                                    // 0x0118(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectYellowW;                                         // 0x0120(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectYellowH;                                         // 0x0124(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ScoreRectYellowOffsetZ;                                   // 0x0128(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackMonsterSibariChangeParameterInfo
    // 0x0008
    public class FJackMonsterSibariChangeParameterInfo : FTableRowBase
    {
        public EJackMonsterSibariParameterTarget Target;                                                   // 0x0000(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterSibariParameterOperator Operator;                                                 // 0x0001(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Value;                                                    // 0x0004(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterSibariParameter
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableMonsterSibariParameter : FTableRowBase
    {
        public List<FJackMonsterSibariChangeParameterInfo> ChangeParameters;                                         // 0x0008(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMonsterZukan
    // 0x0238 (0x0240 - 0x0008)
    public class FJackDataTableMonsterZukan : FTableRowBase
    {
        public FName Name;                                                     // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SyuukaiID;                                                // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SortTsuyosa;                                              // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Sort50on;                                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterIDA;                                               // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterIDB;                                               // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MonsterIDC;                                               // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouID1;                                                // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouID2;                                                // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouID3;                                                // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouID4;                                                // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouID5;                                                // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouID6;                                                // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouMonsterID1;                                         // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouMonsterID2;                                         // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouMonsterID3;                                         // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouMonsterID4;                                         // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouMonsterID5;                                         // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RendouMonsterID6;                                         // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku1A;                                                // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku2A;                                                // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku3A;                                                // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku4A;                                                // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku5A;                                                // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku6A;                                                // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku7A;                                                // 0x00C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku8A;                                                // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku9A;                                                // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku10A;                                               // 0x00E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku1S;                                                // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku2S;                                                // 0x00F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku3S;                                                // 0x00F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku4S;                                                // 0x0100(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku5S;                                                // 0x0108(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku6S;                                                // 0x0110(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku7S;                                                // 0x0118(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku8S;                                                // 0x0120(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku9S;                                                // 0x0128(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku10S;                                               // 0x0130(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku1B;                                                // 0x0138(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku2B;                                                // 0x0140(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku3B;                                                // 0x0148(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku4B;                                                // 0x0150(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku5B;                                                // 0x0158(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku6B;                                                // 0x0160(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku7B;                                                // 0x0168(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku8B;                                                // 0x0170(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku9B;                                                // 0x0178(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku10B;                                               // 0x0180(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku1C;                                                // 0x0188(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku2C;                                                // 0x0190(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku3C;                                                // 0x0198(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku4C;                                                // 0x01A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku5C;                                                // 0x01A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku6C;                                                // 0x01B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku7C;                                                // 0x01B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku8C;                                                // 0x01C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku9C;                                                // 0x01C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Seisoku10C;                                               // 0x01D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID1;                                         // 0x01D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID2;                                         // 0x01E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID3;                                         // 0x01E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID4;                                         // 0x01F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID5;                                         // 0x01F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID6;                                         // 0x0200(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID7;                                         // 0x0208(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID8;                                         // 0x0210(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID9;                                         // 0x0218(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ToubatuRendouID10;                                        // 0x0220(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Zukan2DTexture;
    }

    // ScriptStruct JackGame.JackDataTableMonsterZukanMemo
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableMonsterZukanMemo : FTableRowBase
    {
        public FName Memo;                                                     // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMonsterZukanSeisokuti
    // 0x0640 (0x0648 - 0x0008)
    public class FJackDataTableMonsterZukanSeisokuti : FTableRowBase
    {
        public FName Mon_A_01;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_02;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_03;                                                 // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_04;                                                 // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_05;                                                 // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_06;                                                 // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_07;                                                 // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_08;                                                 // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_09;                                                 // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_11;                                                 // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_12;                                                 // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_13;                                                 // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_14;                                                 // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_15;                                                 // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_16;                                                 // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_17;                                                 // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_18;                                                 // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_19;                                                 // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_20;                                                 // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_21;                                                 // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_22;                                                 // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_23;                                                 // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_24;                                                 // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_25;                                                 // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_26;                                                 // 0x00C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_27;                                                 // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_28;                                                 // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_29;                                                 // 0x00E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_30;                                                 // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_31;                                                 // 0x00F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_32;                                                 // 0x00F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_33;                                                 // 0x0100(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_34;                                                 // 0x0108(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_35;                                                 // 0x0110(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_36;                                                 // 0x0118(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_37;                                                 // 0x0120(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_38;                                                 // 0x0128(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_39;                                                 // 0x0130(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_40;                                                 // 0x0138(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_A_41;                                                 // 0x0140(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_01;                                                 // 0x0148(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_02;                                                 // 0x0150(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_03;                                                 // 0x0158(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_04;                                                 // 0x0160(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_05;                                                 // 0x0168(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_06;                                                 // 0x0170(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_07;                                                 // 0x0178(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_08;                                                 // 0x0180(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_09;                                                 // 0x0188(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_11;                                                 // 0x0190(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_12;                                                 // 0x0198(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_13;                                                 // 0x01A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_14;                                                 // 0x01A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_15;                                                 // 0x01B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_16;                                                 // 0x01B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_17;                                                 // 0x01C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_18;                                                 // 0x01C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_19;                                                 // 0x01D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_20;                                                 // 0x01D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_21;                                                 // 0x01E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_22;                                                 // 0x01E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_23;                                                 // 0x01F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_24;                                                 // 0x01F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_25;                                                 // 0x0200(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_26;                                                 // 0x0208(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_27;                                                 // 0x0210(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_28;                                                 // 0x0218(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_29;                                                 // 0x0220(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_30;                                                 // 0x0228(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_31;                                                 // 0x0230(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_32;                                                 // 0x0238(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_33;                                                 // 0x0240(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_34;                                                 // 0x0248(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_35;                                                 // 0x0250(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_36;                                                 // 0x0258(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_37;                                                 // 0x0260(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_38;                                                 // 0x0268(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_39;                                                 // 0x0270(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_40;                                                 // 0x0278(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_S_41;                                                 // 0x0280(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_01;                                                 // 0x0288(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_02;                                                 // 0x0290(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_03;                                                 // 0x0298(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_04;                                                 // 0x02A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_05;                                                 // 0x02A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_06;                                                 // 0x02B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_07;                                                 // 0x02B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_08;                                                 // 0x02C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_09;                                                 // 0x02C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_11;                                                 // 0x02D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_12;                                                 // 0x02D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_13;                                                 // 0x02E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_14;                                                 // 0x02E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_15;                                                 // 0x02F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_16;                                                 // 0x02F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_17;                                                 // 0x0300(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_18;                                                 // 0x0308(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_19;                                                 // 0x0310(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_20;                                                 // 0x0318(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_21;                                                 // 0x0320(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_22;                                                 // 0x0328(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_23;                                                 // 0x0330(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_24;                                                 // 0x0338(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_25;                                                 // 0x0340(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_26;                                                 // 0x0348(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_27;                                                 // 0x0350(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_28;                                                 // 0x0358(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_29;                                                 // 0x0360(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_30;                                                 // 0x0368(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_31;                                                 // 0x0370(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_32;                                                 // 0x0378(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_33;                                                 // 0x0380(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_34;                                                 // 0x0388(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_35;                                                 // 0x0390(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_36;                                                 // 0x0398(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_37;                                                 // 0x03A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_38;                                                 // 0x03A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_39;                                                 // 0x03B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_40;                                                 // 0x03B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_B_41;                                                 // 0x03C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_01;                                                 // 0x03C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_02;                                                 // 0x03D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_03;                                                 // 0x03D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_04;                                                 // 0x03E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_05;                                                 // 0x03E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_06;                                                 // 0x03F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_07;                                                 // 0x03F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_08;                                                 // 0x0400(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_09;                                                 // 0x0408(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_11;                                                 // 0x0410(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_12;                                                 // 0x0418(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_13;                                                 // 0x0420(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_14;                                                 // 0x0428(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_15;                                                 // 0x0430(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_16;                                                 // 0x0438(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_17;                                                 // 0x0440(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_18;                                                 // 0x0448(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_19;                                                 // 0x0450(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_20;                                                 // 0x0458(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_21;                                                 // 0x0460(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_22;                                                 // 0x0468(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_23;                                                 // 0x0470(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_24;                                                 // 0x0478(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_25;                                                 // 0x0480(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_26;                                                 // 0x0488(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_27;                                                 // 0x0490(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_28;                                                 // 0x0498(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_29;                                                 // 0x04A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_30;                                                 // 0x04A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_31;                                                 // 0x04B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_32;                                                 // 0x04B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_33;                                                 // 0x04C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_34;                                                 // 0x04C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_35;                                                 // 0x04D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_36;                                                 // 0x04D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_37;                                                 // 0x04E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_38;                                                 // 0x04E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_39;                                                 // 0x04F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_40;                                                 // 0x04F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_41;                                                 // 0x0500(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_42;                                                 // 0x0508(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_43;                                                 // 0x0510(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_44;                                                 // 0x0518(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_45;                                                 // 0x0520(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_46;                                                 // 0x0528(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_47;                                                 // 0x0530(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_48;                                                 // 0x0538(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_49;                                                 // 0x0540(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_50;                                                 // 0x0548(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_51;                                                 // 0x0550(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_52;                                                 // 0x0558(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_53;                                                 // 0x0560(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_54;                                                 // 0x0568(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_55;                                                 // 0x0570(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_56;                                                 // 0x0578(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_57;                                                 // 0x0580(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_58;                                                 // 0x0588(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_59;                                                 // 0x0590(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_60;                                                 // 0x0598(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_61;                                                 // 0x05A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_62;                                                 // 0x05A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_63;                                                 // 0x05B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_64;                                                 // 0x05B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_65;                                                 // 0x05C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_66;                                                 // 0x05C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_67;                                                 // 0x05D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_68;                                                 // 0x05D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_69;                                                 // 0x05E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_70;                                                 // 0x05E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_71;                                                 // 0x05F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_72;                                                 // 0x05F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_73;                                                 // 0x0600(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_74;                                                 // 0x0608(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_75;                                                 // 0x0610(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_76;                                                 // 0x0618(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_77;                                                 // 0x0620(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_78;                                                 // 0x0628(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_79;                                                 // 0x0630(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_80;                                                 // 0x0638(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Mon_C_81;                                                 // 0x0640(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableNPCImportanceScenari
    // 0x0078 (0x0080 - 0x0008)
    public class FJackDataTableNPCImportanceScenari : FTableRowBase
    {
        public FName NpcId_01;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NpcId_02;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NpcId_03;                                                 // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NpcId_04;                                                 // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NpcId_05;                                                 // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NpcId_06;                                                 // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NpcId_07;                                                 // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NpcId_08;                                                 // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NpcId_09;                                                 // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCID_11;                                                 // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCID_12;                                                 // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCID_13;                                                 // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCID_14;                                                 // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCID_15;                                                 // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCID_16;                                                 // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableNPCInterruptControl
    // 0x0050 (0x0058 - 0x0008)
    public class FJackDataTableNPCInterruptControl : FTableRowBase
    {
        public bool bPermitToTalk;                                            // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPermitToTalkAnimation;                                   // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPermitToReaction;                                        // 0x000A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPermitUso;                                               // 0x000B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackNPCTalkGazeMode TalkGazeMode;                                             // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TalkAnimation;
        public FName TalkEndAnimation;
        public FName TalkEndWaitAnimation;
    }

    // ScriptStruct JackGame.JackDataTableNPCList
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableNPCList : FTableRowBase
    {
        public FName DisplayName;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Scale;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPipipiType PipipiTypeOverride;                                       // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName UsoType;                                                  // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AttachmentID1;                                            // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackNPCAttachmentType AttachmentType1;                                          // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AttachmentID2;                                            // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackNPCAttachmentType AttachmentType2;                                          // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AttachmentID3;                                            // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackNPCAttachmentType AttachmentType3;                                          // 0x0048(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AttachmentID4;                                            // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackNPCAttachmentType AttachmentType4;                                          // 0x0058(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableNPCReactionAnimation
    // 0x0010 (0x0018 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableNPCReactionAnimation : FTableRowBase
    {
        public int ClassImport; // TODO: seems to refer to something in the UAsset
        //public class UAnimMontage*                                AnimMontage;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float RotateSpeed;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableNPCReaction
    // 0x0150 (0x0158 - 0x0008)
    public class FJackDataTableNPCReaction : FTableRowBase
    {
        public bool bOnlyNormalAnimation;                                     // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEscapePlayer;                                            // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string EscapePlayerFukidasi;                                     // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public bool bEscapeObject;                                            // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string EscapeObjectFukidasi;                                     // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public bool bAvoidPlayer;                                             // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string AvoidFukidasi;                                            // 0x0040(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float Distance;                                                 // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Angle;                                                    // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Animation;                                                // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string Fukidasi;                                                 // 0x0060(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float LowHP_Distance;                                           // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float LowHP_Angle;                                              // 0x0074(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LowHP_Animation;                                          // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string LowHP_Fukidasi;                                           // 0x0080(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float LowHP_Rate;                                               // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Doku_Distance;                                            // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Doku_Angle;                                               // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Doku_Animation;                                           // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string Doku_Fukidasi;                                            // 0x00A8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float Noroi_Distance;                                           // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Noroi_Angle;                                              // 0x00BC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Noroi_Animation;                                          // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string Noroi_Fukidasi;                                           // 0x00C8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float ShyCurse_Distance;                                        // 0x00D8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ShyCurse_Angle;                                           // 0x00DC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ShyCurse_Animation;                                       // 0x00E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string ShyCurse_Fukidasi;                                        // 0x00E8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float CrushObject_Distance;                                     // 0x00F8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float CrushObject_Angle;                                        // 0x00FC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CrushObject_Animation;                                    // 0x0100(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string CrushObject_Fukidasi;                                     // 0x0108(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float OpenCloset_Distance;                                      // 0x0118(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float OpenCloset_Angle;                                         // 0x011C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OpenCloset_Animation;                                     // 0x0120(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string OpenCloset_Fukidasi;                                      // 0x0128(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float OpenTreasureBox_Distance;                                 // 0x0138(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float OpenTreasureBox_Angle;                                    // 0x013C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OpenTreasureBox_Animation;                                // 0x0140(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string OpenTreasureBox_Fukidasi;                                 // 0x0148(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableNPCUsoTalk
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableNPCUsoTalk : FTableRowBase
    {
        public int UsoRate;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> UsoTalkTexts;                                             // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableOddEffectClearDamagePer
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableOddEffectClearDamagePer : FTableRowBase
    {
        public List<float> ClearDamagePerPC;                                         // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<float> ClearDamagePerMonster;                                    // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<float> ClearDamagePerBoss;                                       // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableOddEffectBattleText
    // 0x0000 (0x0018 - 0x0018)
    public class FJackDataTableOddEffectBattleText : FJackDataTableActionBattleText
    {

    }

    // ScriptStruct JackGame.JackDataTableOddEffectStatus
    // 0x00A0 (0x00A8 - 0x0008)
    public class FJackDataTableOddEffectStatus : FTableRowBase
    {
        public FName OddEffectSlideID;                                         // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectMotionID;                                        // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectFacialID;                                        // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectEffectID;                                        // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ClearDamagePerID;                                         // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VoiceID;                                                  // 0x0030(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ClearVoiceID;                                             // 0x0038(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidMove;                                             // 0x0040(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidCommand;                                          // 0x0041(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidMemberChange;                                     // 0x0042(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidCounter;                                          // 0x0043(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidMikawasi;                                         // 0x0044(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidTateGuard;                                        // 0x0045(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidBukiGuard;                                        // 0x0046(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidKnockBack;                                        // 0x0047(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidFirstTarget;                                      // 0x0048(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalidSecondTarget;                                     // 0x0049(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bKougekiFriendsFirstTarget;                               // 0x004A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bFriendsSecondTarget;                                     // 0x004B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_BattleEnd;                                         // 0x004C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_RoundEnd;                                          // 0x004D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Standby;                                           // 0x004E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_NextFirstAttack;                                   // 0x004F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Dead;                                              // 0x0050(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Zone;                                              // 0x0051(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Nemuri;                                            // 0x0052(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Mahi;                                              // 0x0053(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Konran;                                            // 0x0054(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Miryou;                                            // 0x0055(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_MouDoku;                                           // 0x0056(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Yasumi;                                            // 0x0057(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Asutoron;                                          // 0x0058(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Fuzai;                                             // 0x0059(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Fuuin_Jumon;                                       // 0x005A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_Fuuin_Tokugi;                                      // 0x005B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalid_Nemuri;                                          // 0x005C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalid_Mahi;                                            // 0x005D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalid_Konran;                                          // 0x005E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalid_Miryou;                                          // 0x005F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalid_Yasumi;                                          // 0x0060(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalid_Asutoron;                                        // 0x0061(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInvalid_Kirapon;                                         // 0x0062(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bShareFromBody;                                           // 0x0063(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_ConditionGood;                                     // 0x0064(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bClear_ConditionBad;                                      // 0x0065(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackOddEffectConditionType ConditionType;                                            // 0x0066(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteClearFlag;                                        // 0x0067(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUseCameraWhenExecute;                                    // 0x0068(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectIcon;
        public int OddEffectIconDisplayPriority;                             // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectExecClass;
    }

    // ScriptStruct JackGame.JackDataTableOddEffect
    // 0x00C8 (0x00D0 - 0x0008)
    public class FJackDataTableOddEffect : FTableRowBase
    {
        public FName DisplayName;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleTextName;                                           // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> SubOddEffectIDs;                                          // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName OddEffectTextID;                                          // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackOddEffectCategoryType CategoryType;                                             // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CategoryPriority;                                         // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackOddEffectOverwriteType OverwriteType;                                            // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackOddEffectCalcType CalcType;                                                 // 0x0039(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OddEffectStatusID;                                        // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAttributeParam AttributeParamType;                                       // 0x0048(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAttributeParam KougekiAttributeParamType;                                // 0x0049(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int KougekiAttributePriority;                                 // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackOddEffectApply ApplyType;                                                // 0x0050(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackStatusParam ApplyStatusParamType;                                     // 0x0051(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ApplyValue;                                               // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float InvokeParameter_01;                                       // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float InvokeParameter_02;                                       // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName InvokeParameter_String;                                   // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterRace InvokeMonsterRace;                                        // 0x0068(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackOddEffectInvokeTiming InvokeTiming;                                             // 0x0069(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName InvokeOddEffectID;                                        // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DisplayInvokeParameter;                                   // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackReferenceParamTarget ReferenceParam_Target;                                    // 0x007C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReferenceParam_BaseMonster;                               // 0x0080(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReferenceParam_BaseMin;                                   // 0x0084(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReferenceParam_BaseMax;                                   // 0x0088(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackReferenceParam ReferenceParam_Reference;                                 // 0x008C(0x0001) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReferenceParam_ReferenceHoseiMin;                         // 0x0090(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReferenceParam_ReferenceHoseiMax;                         // 0x0094(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReferenceParam_Random;                                    // 0x0098(0x0004) (Edit, BlueprintVisi, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SlideChangeTargetOddEffectSlideID;                        // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SlideChangeRank;                                          // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DurationTurn_Min;                                         // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DurationTurn_Max;                                         // 0x00B0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDurationTurn_ClearTurnStart;                             // 0x00B4(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDurationTurn_ClearTurnStart_SkipTurn;                    // 0x00B5(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bRootTurnOnly;                                            // 0x00B6(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ExecPriority;                                             // 0x00B8(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bWeaponTuikaKouka;                                        // 0x00BC(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bMultipleEnable;                                          // 0x00BD(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackOddEffectTuyosaDisplayType TuyosaDisplayType;                                        // 0x00BE(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackOddEffectParameterDisplayType InvokeParameterDisplayType;                               // 0x00BF(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Tags;                                                     // 0x00C0(0x0010) (Edit, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableOddEffectEffect
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTableOddEffectEffect : FTableRowBase
    {
        public bool bResidentResource;                                        // 0x0008(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MaterialUpdaterID;                                        // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PcPowerupMaterialID;                                      // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName GeneralNameParameter;                                     // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float GeneralValueParameter;                                    // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> EffectClasses;
    }

    // ScriptStruct JackGame.JackDataTableOddEffectFacial
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableOddEffectFacial : FTableRowBase
    {
        public int Priority;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FacialStatusID;                                           // 0x0010(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<bool> Flags;                                                    // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableOddEffectMotion
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableOddEffectMotion : FTableRowBase
    {
        public int Priority;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Motion;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<bool> Flags;                                                    // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableOddEffectSlide
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableOddEffectSlide : FTableRowBase
    {
        public FName SlideControlOddEffectID;                                  // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<float> RankValues;                                               // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName PlusEffectID;                                             // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MinusEffectID;                                            // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableOddEffectTag
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableOddEffectTag : FTableRowBase
    {
        //public bool Dummy;                                                    // 0x0008(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableOverrideTranslationText
    // 0x0088 (0x0090 - 0x0008)
    public class FJackDataTableOverrideTranslationText : FTableRowBase
    {
        public FJackArticleInfo ArticleInfo;                                              // 0x0008(0x0088) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableParticleSlotEffect
    // 0x0150 (0x0158 - 0x0008)
    public class FJackDataTableParticleSlotEffect : FTableRowBase
    {
        public FName DefaultDamageEffect;
        public FName DefaultDamageEffect2;
        public FName OverlapDamageSE;
        public FName OverlapDamageSE2;
        public FName Slot01;
        public FName Slot02;
        public FName Slot03;
        public FName Slot04;
        public FName Slot05;
        public FName Slot06;
        public FName Slot07;
        public FName Slot08;
        public FName Slot09;
        public FName Slot10;
    }

    // ScriptStruct JackGame.JackDataTableOverrideText
    // 0x0008 (0x0038 - 0x0030)
    public class FJackDataTableOverrideText : FJackDataTableText
    {
        public bool bOverridesText;                                           // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOverridesType;                                           // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOverridesTalkerID;                                       // 0x0032(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOverridesNoTurn;                                         // 0x0033(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOverridesNoTalkStartEvent;                               // 0x0034(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOverridesResetByMapJump;                                 // 0x0035(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOverridesScenarioGuide;                                  // 0x0036(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bOverridesQuestGuide;                                     // 0x0037(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePartyTalk
    // 0x0248 (0x0250 - 0x0008)
    public class FJackDataTablePartyTalk : FTableRowBase
    {
        public EJackScenarioID ScenarioID;                                               // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapId;                                                    // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioFlag;                                             // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGameFlagCategory SubFlagCategory;                                          // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SubFlagName;                                              // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackScenarioWeather Flag_Weather;                                             // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackScenarioTimeZone Flag_TimeZone;                                            // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Flag_Item;                                                // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Flag_TalkCount;                                           // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter PriorityCharacter;                                        // 0x0044(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member1_Serifu;                                           // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Member1_IdleMotion;                                       // 0x0050(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member1_Serifu_Camp;                                      // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member2_Serifu;                                           // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Member2_IdleMotion;                                       // 0x0068(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member2_Serifu_Camp;                                      // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member3_Serifu;                                           // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Member3_IdleMotion;                                       // 0x0080(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member3_Serifu_Camp;                                      // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member4_Serifu;                                           // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Member4_IdleMotion;                                       // 0x0098(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member4_Serifu_Camp;                                      // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member5_Serifu;                                           // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Member5_IdleMotion;                                       // 0x00B0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member5_Serifu_Camp;                                      // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member6_Serifu;                                           // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Member6_IdleMotion;                                       // 0x00C8(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member6_Serifu_Camp;                                      // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member7_Serifu;                                           // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Member7_IdleMotion;                                       // 0x00E0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Member7_Serifu_Camp;                                      // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest1_Character;                                         // 0x00F0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest1_Serifu;                                            // 0x00F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest1_IdleMotion;                                        // 0x0100(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest1_Serifu_Camp;                                       // 0x0108(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest2_Character;                                         // 0x0110(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest2_Serifu;                                            // 0x0118(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest2_IdleMotion;                                        // 0x0120(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest2_Serifu_Camp;                                       // 0x0128(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest3_Character;                                         // 0x0130(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest3_Serifu;                                            // 0x0138(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest3_IdleMotion;                                        // 0x0140(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest3_Serifu_Camp;                                       // 0x0148(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest4_Character;                                         // 0x0150(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest4_Serifu;                                            // 0x0158(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest4_IdleMotion;                                        // 0x0160(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest4_Serifu_Camp;                                       // 0x0168(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest5_Character;                                         // 0x0170(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest5_Serifu;                                            // 0x0178(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest5_IdleMotion;                                        // 0x0180(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest5_Serifu_Camp;                                       // 0x0188(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest6_Character;                                         // 0x0190(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest6_Serifu;                                            // 0x0198(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest6_IdleMotion;                                        // 0x01A0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest6_Serifu_Camp;                                       // 0x01A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest7_Character;                                         // 0x01B0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest7_Serifu;                                            // 0x01B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest7_IdleMotion;                                        // 0x01C0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest7_Serifu_Camp;                                       // 0x01C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest8_Character;                                         // 0x01D0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest8_Serifu;                                            // 0x01D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest8_IdleMotion;                                        // 0x01E0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest8_Serifu_Camp;                                       // 0x01E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest9_Character;                                         // 0x01F0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest9_Serifu;                                            // 0x01F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest9_IdleMotion;                                        // 0x0200(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest9_Serifu_Camp;                                       // 0x0208(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest10_Character;                                        // 0x0210(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest10_Serifu;                                           // 0x0218(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest10_IdleMotion;                                       // 0x0220(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest10_Serifu_Camp;                                      // 0x0228(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter Guest11_Character;                                        // 0x0230(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest11_Serifu;                                           // 0x0238(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPartyTalkIdleMotion Guest11_IdleMotion;                                       // 0x0240(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Guest11_Serifu_Camp;                                      // 0x0248(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePartyTalkBehaviorState
    // 0x0050 (0x0058 - 0x0008)
    public class FJackDataTablePartyTalkBehaviorState : FTableRowBase
    {
        public FName BranchID;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Behavior;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SC_Start;                                                 // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SC_End;                                                   // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PreLoadMapID;                                             // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsFieldDisp;                                             // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsSubjectOfAttack;                                       // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsGetExp;                                                // 0x0032(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsMenuDisp;                                              // 0x0033(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsPartyTalk;                                             // 0x0034(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsReturnToBag;                                           // 0x0035(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsReturnToBagExceptEquip;                                // 0x0036(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsNotGuestDisp;                                          // 0x0037(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleAI_ID;                                              // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int GambitRate;                                               // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGambit Gambit;                                                   // 0x0044(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BaseParameterID;                                          // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TalkSituation;                                            // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePartyTalkCharacter
    // 0x0158 (0x0160 - 0x0008)
    public class FJackDataTablePartyTalkCharacter : FTableRowBase
    {
        public EJackCharacter CharacterType;                                            // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacter PlayerType;                                               // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CharaHeight;                                              // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CharacterBP;
        public FName BattleCharacterBP;
        public FName TalkCharacterBP;
        public FName CoffinCharacterBP;
        public FName CoffinPartyTalkCharacterBP;
        public FName DefaultCoordinate;                                        // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FacialPresetID;                                           // 0x0090(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VoicePresetID;                                            // 0x0098(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Handedness;                                               // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Hand;                                                     // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Head;                                                     // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Body;                                                     // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Accessory1;                                               // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Accessory2;                                               // 0x00C8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item1;                                                    // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item2;                                                    // 0x00D8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item3;                                                    // 0x00E0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item4;                                                    // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item5;                                                    // 0x00F0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Item6;                                                    // 0x00F8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsNoTalk;                                                // 0x0100(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsBattle;                                                // 0x0101(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsFixedArea;                                             // 0x0102(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsSubjectOfAttack;                                       // 0x0103(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BaseParameterID;                                          // 0x0108(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BattleAI_ID;                                              // 0x0110(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int GambitRate;                                               // 0x0118(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGambit Gambit;                                                   // 0x011C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PoseIdleMin;                                              // 0x0120(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PoseIdleMax;                                              // 0x0124(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PoseNormal01;                                             // 0x0128(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PoseSerious01;                                            // 0x0130(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PoseBlackout01;                                           // 0x0138(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PoseHappy01;                                              // 0x0140(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PoseAngry01;                                              // 0x0148(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PoseThinking01;                                           // 0x0150(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PoseSpecial01;                                            // 0x0158(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePartyTalkCutSceneFlags
    // 0x0050 (0x0058 - 0x0008)
    public class FJackDataTablePartyTalkCutSceneFlags : FTableRowBase
    {
        public List<float> DT_TARGETDISTANCE;                                        // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<float> DT_WIDEDISTANCE;                                          // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float DT_AccBase;                                               // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_MinSpeed;                                              // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_MinWalkSpeed;                                          // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_SLen;                                                  // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_RLen;                                                  // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_AccMul;                                                // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_BrakeMul;                                              // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_FollowMargin;                                          // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_TrackSamplingDistanceMax;                              // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_TrackStraightLength;                                   // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DT_TrackStraightMargin;                                   // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePartyTalkMotionTag
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTablePartyTalkMotionTag : FTableRowBase
    {
        public FName DT_Motion;                                                // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DT_FacialUpper;                                           // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DT_FacialLower;                                           // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DT_VoiceType;                                             // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackPartyTalkRelativePosition
    // 0x000C
    public class FJackPartyTalkRelativePosition : FTableRowBase
    {
        public float X;                                                        // 0x0000(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Y;                                                        // 0x0004(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Yaw;                                                      // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePartyTalkPositionInfo
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTablePartyTalkPositionInfo : FTableRowBase
    {
        public int DT_SeatMax;                                               // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackPartyTalkRelativePosition> DT_CharacterPos;                                          // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FJackPartyTalkRelativePosition> DT_CoffinPos;                                             // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTablePartyTalkVoice
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTablePartyTalkVoice : FTableRowBase
    {
        public List<FName> VoiceAsset;
    }

    // ScriptStruct JackGame.JackDataTablePassiveTokugi
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTablePassiveTokugi : FTableRowBase
    {
        public FName PassiveNameID;                                            // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPassiveTokugiType EffectType;                                               // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EffectParameter;                                          // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EffectOddEffectID;                                        // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponBareHands;                                  // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponSword;                                      // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponDagger;                                     // 0x0022(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponAx;                                         // 0x0023(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponStick;                                      // 0x0024(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponBoomerang;                                  // 0x0025(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponDoubleSword;                                // 0x0026(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponSpear;                                      // 0x0027(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponStaff;                                      // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponClaw;                                       // 0x0029(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteWeaponWhip;                                       // 0x002A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bExecuteShield;                                           // 0x002B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DescriptionID1;                                           // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DescriptionID2;                                           // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DescriptionID3;                                           // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePhoneticNo
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTablePhoneticNo : FTableRowBase
    {
        public int PhoneticNo;                                               // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePlayerBattleAI
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTablePlayerBattleAI : FTableRowBase
    {
        public EJackPlayerAIFlowJudge FlowJudgeType;                                            // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlowActionRate;                                           // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPlayerAIFlowControl FlowControlType;                                          // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackPlayerAIActionControl ActionControlType;                                        // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SuccessNextFlowId;                                        // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FailNextFlowId;                                           // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EvaluateScoreCheckId;                                     // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EvaluateScore;                                            // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerCardTexture
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTablePokerCardTexture : FTableRowBase
    {
        public FName Texture1;
    }

    // ScriptStruct JackGame.JackDataTablePokerPayoutProbability
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTablePokerPayoutProbability : FTableRowBase
    {
        public float Win;                                                      // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Draw;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Lose;                                                     // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerDoublieUpBaseCardRate
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTablePokerDoublieUpBaseCardRate : FTableRowBase
    {
        public float Two;                                                      // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Three;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Four;                                                     // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Five;                                                     // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Six;                                                      // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Seven;                                                    // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Eight;                                                    // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Nine;                                                     // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Ten;                                                      // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Jack;                                                     // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Queen;                                                    // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float King;                                                     // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Ace;                                                      // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerTakaraBakoProbability
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTablePokerTakaraBakoProbability : FTableRowBase
    {
        public float ProbabilityOne;                                           // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ProbabilityTen;                                           // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ProbabilityHundred;                                       // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerInexpensiveCoin
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTablePokerInexpensiveCoin : FTableRowBase
    {
        public int Fraction;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Range;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerTakaraBakoCoin
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTablePokerTakaraBakoCoin : FTableRowBase
    {
        public float ProbabilityOne;                                           // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ProbabilityTen;                                           // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ProbabilityHundred;                                       // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Fraction;                                                 // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Range;                                                    // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerDoubleUp
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTablePokerDoubleUp : FTableRowBase
    {
        public int Win;                                                      // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Draw;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Lose;                                                     // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerHand
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTablePokerHand : FTableRowBase
    {
        public int Dividend;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Probability;                                              // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerWinningRate
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTablePokerWinningRate : FTableRowBase
    {
        public int WinningRate;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTablePokerWBP
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTablePokerWBP : FTableRowBase
    {
        public FName Japanese;
        public FName TraditionalChinese;
        public FName Others;
    }

    // ScriptStruct JackGame.JackDataTableQuest
    // 0x00C8 (0x00D0 - 0x0008)
    public class FJackDataTableQuest : FTableRowBase
    {
        public FName Title;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName QuestFlag;                                                // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName QuestDisplayFlag;                                         // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName QuestUiDisplayFlag;                                       // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Order;                                                    // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievement AchievementType;                                          // 0x002C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> AchievementConditions;                                    // 0x0030(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName StartDescription;                                         // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> StartMapVolumeIDs;                                        // 0x0048(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName OrderDescription;                                         // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ProgressDescription;                                      // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ProgressDescriptionK1;                                    // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ProgressDescriptionK2;                                    // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ProgressDescriptionK3;                                    // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> ProgressMapVolumeIDs;                                     // 0x0068(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName CompleteDescription;                                      // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> CompleteMapVolumeIDs;                                     // 0x0098(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName EndDescription;                                           // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCID;                                                    // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackQuestReward> Reward;                                                   // 0x00B8(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int TripleQuestNo;                                            // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRecipe
    // 0x00A0 (0x00A8 - 0x0008)
    public class FJackDataTableRecipe : FTableRowBase
    {
        public FName CreateItemID;                                             // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SortIndex;                                                // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CategoryKind;                                             // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MaterialSpecial;                                          // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ResultType;                                               // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MetalKind;                                                // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MaterialID_01;                                            // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaterialNum_01;                                           // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MaterialID_02;                                            // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaterialNum_02;                                           // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MaterialID_03;                                            // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaterialNum_03;                                           // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MaterialID_04;                                            // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaterialNum_04;                                           // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MaterialID_05;                                            // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MaterialNum_05;                                           // 0x0080(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TakeRetryBall_1;                                          // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TakeRetryBall_2;                                          // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TakeRetryBall_3;                                          // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TakeRetryBall_4;                                          // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TakeRetryBall_Fail;                                       // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NeedRetryBall_1;                                          // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NeedRetryBall_2;                                          // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int NeedRetryBall_3;                                          // 0x00A0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int DifficultyRank;                                           // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRecipeBook
    // 0x0050 (0x0058 - 0x0008)
    public class FJackDataTableRecipeBook : FTableRowBase
    {
        public FName RecipeId_01;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_02;                                              // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_03;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_04;                                              // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_05;                                              // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_06;                                              // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_07;                                              // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_08;                                              // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_09;                                              // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RecipeId_11;                                              // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackGameFlagKeyValueSet
    // 0x0020
    public class FJackGameFlagKeyValueSet : FTableRowBase
    {
        public EJackGameFlagCategory Category;                                                 // 0x0000(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Name;                                                     // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string Value;                                                    // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableRelationalGameFlagConfig
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableRelationalGameFlagConfig : FTableRowBase
    {
        public List<FJackGameFlagKeyValueSet> ConfigFlagList;                                           // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMonsterRenkei
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableMonsterRenkei : FTableRowBase
    {
        public FName RenkeiID;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Member;                                                   // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableMatineeRenkei
    // 0x0150 (0x0158 - 0x0008)
    public class FJackDataTableMatineeRenkei : FTableRowBase
    {
        public FName MachineLevelName;                                         // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MachineLevelPass;                                         // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MachineName;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DamageEffect;
        public FName DoActionID_A;                                             // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember Target_A;                                                 // 0x0040(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DoActionID_B;                                             // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember Target_B;                                                 // 0x0050(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DoActionID_C;                                             // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember Target_C;                                                 // 0x0060(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DoActionID_D;                                             // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember Target_D;                                                 // 0x0070(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bLOD_ON;                                                  // 0x0071(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DamageCameraID;                                           // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DamageFormationID;                                        // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageTime;                                               // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DamageCameraShake;
        public float DamageCameraShakeTime;                                    // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Damage_Particle1;
        public float Damage_ParticleTime1;                                     // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Damage_Particle2;
        public float Damage_ParticleTime2;                                     // 0x00E8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Damage_Sound;
        public float Damage_SoundTime;                                         // 0x0108(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Target_ActionEffect;
        public float DamageBalloonTimeA;                                       // 0x0128(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageHitCountA;                                          // 0x012C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageHitIntervalA;                                       // 0x0130(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageBalloonTimeB;                                       // 0x0134(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageHitCountB;                                          // 0x0138(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageHitIntervalB;                                       // 0x013C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageBalloonTimeC;                                       // 0x0140(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageHitCountC;                                          // 0x0144(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageHitIntervalC;                                       // 0x0148(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageBalloonTimeD;                                       // 0x014C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageHitCountD;                                          // 0x0150(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DamageHitIntervalD;                                       // 0x0154(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMatineelevelRenkeiDivision
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMatineelevelRenkeiDivision : FTableRowBase
    {
        public FName LevelName;                                                // 0x0008(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public FName LevelNamePass;                                            // 0x0010(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public FName MatineeName;                                              // 0x0018(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public int GroupNumber;                                              // 0x0020(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackCharacter CharacterType;                                            // 0x0024(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableProgRenkei
    // 0x0088 (0x0090 - 0x0008)
    public class FJackDataTableProgRenkei : FTableRowBase
    {
        public FName FormationID;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DoActionID_A;                                             // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPendingDead_A;                                           // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember Target_A;                                                 // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleRenkeiTiming ActionStartTiming_A;                                      // 0x001A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember ActionStartTimingLookChara_A;                             // 0x001B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ActionStartTime_A;                                        // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DoActionID_B;                                             // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPendingDead_B;                                           // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember Target_B;                                                 // 0x0029(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleRenkeiTiming ActionStartTiming_B;                                      // 0x002A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember ActionStartTimingLookChara_B;                             // 0x002B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float ActionStartTime_B;                                        // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ActionCameraID;                                           // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> TextID;                                                   // 0x0038(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<EJackBattleRenkeiTiming>       TextID_StartTiming;                                       // 0x0048(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<EJackRenkeiMember>             TextID_StartTimingLookChara;                              // 0x0058(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<float> TextID_StartTime;                                         // 0x0068(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName PlayAnimMontage;                                          // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember PlayAnimMontage_Target;                                   // 0x0080(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleRenkeiTiming PlayAnimMontage_StartTiming;                              // 0x0081(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember PlayAnimMontage_LookChara;                                // 0x0082(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PlayAnimMontage_StartTime;                                // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBattleRenkeiTiming RenkeiEndTiming;                                          // 0x0088(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRenkeiMember RenkeiEndTimingLookChara;                                 // 0x0089(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float RenkeiEndTimingTime;                                      // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableProgRenkeiFormation
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableProgRenkeiFormation : FTableRowBase
    {
        public List<FVector> AttackerLocations;                                        // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<EJackBattleRenkeiFormationDirection> AttackerDirections;                                       // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public EJackBattleRenkeiFormationGroupDirection DefenderDirections;                                       // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector DefenderCenterLocation;                                   // 0x002C(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRestart
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableRestart : FTableRowBase
    {
        public FName MapId;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string MapName;                                                  // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string DisplayLocationName;                                      // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName NPCTag;                                                   // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MessageID;                                                // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MessageIDFromLoad;                                        // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float LostGoldRate;                                             // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bResetRestartChurch;                                      // 0x004C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bResetRestartTown;                                        // 0x004D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bResetRestartEvent;                                       // 0x004E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackRestartProcessType RestartProcessType;                                       // 0x004F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRouletteTextureAsset
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableRouletteTextureAsset : FTableRowBase
    {
        public FName TextureBg;
        public FName TextureLine;
    }

    // ScriptStruct JackGame.JackDataTableRouletteNPCDistribution
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTableRouletteNPCDistribution : FTableRowBase
    {
        public int Bet1Coin;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Bet10Coin;                                                // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Bet100Coin;                                               // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum1;                                                 // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum2;                                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum3;                                                 // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum4;                                                 // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum5;                                                 // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum6;                                                 // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum7;                                                 // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum8;                                                 // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum9;                                                 // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int CoinNum10;                                                // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRouletteTreasureCoin
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableRouletteTreasureCoin : FTableRowBase
    {
        public int Fraction;                                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Range;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Probability;                                              // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRouletteJackPotProbability
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableRouletteJackPotProbability : FTableRowBase
    {
        public int BasePercent;                                              // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Fraction;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRouletteData
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableRouletteData : FTableRowBase
    {
        public int ZOrder;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ListNo;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Num;                                                      // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int X;                                                        // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Y;                                                        // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value1;                                                   // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value2;                                                   // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value3;                                                   // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value4;                                                   // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value5;                                                   // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value6;                                                   // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value7;                                                   // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value8;                                                   // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value9;                                                   // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value10;                                                  // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value11;                                                  // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value12;                                                  // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value13;                                                  // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value14;                                                  // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value15;                                                  // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value16;                                                  // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value17;                                                  // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Value18;                                                  // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackRubyTagData
    // 0x0018
    public class FJackRubyTagData : FTableRowBase
    {
        public string Ruby;                                                     // 0x0000(0x0010) (Edit, ZeroConstructor, EditConst)
        public int Start;                                                    // 0x0010(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public int Count;                                                    // 0x0014(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRura
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableRura : FTableRowBase
    {
        public FName SelectNameID;                                             // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName JumpTag;                                                  // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName IdoJumpTag;                                               // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DescriptionID;                                            // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TouchFlag;                                                // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OpenFlag;                                                 // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName WorldMapPoint;                                            // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName WorldMapArea;                                             // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBukiShopFlag;                                            // 0x0048(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBouguShopFlag;                                           // 0x0049(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bInnFlag;                                                 // 0x004A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDouguShopFlag;                                           // 0x004B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bYorozuShopFlag;                                          // 0x004C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bChurchFlag;                                              // 0x004D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBankFlag;                                                // 0x004E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bBlacksmithFlag;                                          // 0x004F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCasinoFlag;                                              // 0x0050(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bUmaRaceFlag;                                             // 0x0051(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ShipMoveTag;                                              // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableRuby
    // 0x0040 (0x0048 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableRuby : FTableRowBase
    {
        public string Word;                                                     // 0x0008(0x0010) (Edit, ZeroConstructor, EditConst)
        public string Ruby;                                                     // 0x0018(0x0010) (Edit, ZeroConstructor, EditConst)
        public int WordLength;                                               // 0x0028(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public int RubyLength;                                               // 0x002C(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public bool IsRubyTag;                                                // 0x0030(0x0001) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public List<FJackRubyTagData> RubyTagData;                                              // 0x0038(0x0010) (Edit, ZeroConstructor, EditConst)
    }

    // ScriptStruct JackGame.JackDataTableRuraRestriction
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableRuraRestriction : FTableRowBase
    {
        public FName BanStartFlag;                                             // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BanEndFlag;                                               // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableScenarioFlagInfo
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableScenarioFlagInfo : FTableRowBase
    {
        public EJackScenarioID ScenarioID;                                               // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public int Order;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlagNameOfLatestScenarioFlag;                             // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlagNameOfArasuziFlag;                                    // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableScheduledKira
    // 0x00C8 (0x00D0 - 0x0008)
    public class FJackDataTableScheduledKira : FTableRowBase
    {
        public FName MapId;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackTreasureBoxPlacementCondition PlacementConditionType;                                   // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName PlacementConditionParameter;                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PlacementNum_Min;                                         // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PlacementNum_Max;                                         // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ReplacementMin;                                           // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementTimeZone_Morning;                               // 0x002C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementTimeZone_Daytime;                               // 0x002D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementTimeZone_Evening;                               // 0x002E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementTimeZone_Night;                                 // 0x002F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_ClearAndSunny;                          // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_Sunny;                                  // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_Cloudy;                                 // 0x0032(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_LightRain;                              // 0x0033(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_Rain;                                   // 0x0034(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_HeavyRain;                              // 0x0035(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_Thunderstorm;                           // 0x0036(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_Snow;                                   // 0x0037(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_Snowstorm;                              // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_Fog;                                    // 0x0039(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlacementWeather_HeavyFog;                               // 0x003A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName RespawnInformationFlag;                                   // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ScenarioSequenceNo;                                       // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_001;                                               // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_001;                                              // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemWeight_001;                                           // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_002;                                               // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_002;                                              // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemWeight_002;                                           // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_003;                                               // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_003;                                              // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemWeight_003;                                           // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_004;                                               // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_004;                                              // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemWeight_004;                                           // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_005;                                               // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_005;                                              // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemWeight_005;                                           // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_006;                                               // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_006;                                              // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemWeight_006;                                           // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_007;                                               // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_007;                                              // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemWeight_007;                                           // 0x00BC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ItemID_008;                                               // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemNum_008;                                              // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ItemWeight_008;                                           // 0x00CC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotME
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableSlotME : FTableRowBase
    {
        public FName ME_FiveLine;                                              // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ME_FourLine;                                              // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ME_ThreeLine;                                             // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotJackPotFractionRange
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableSlotJackPotFractionRange : FTableRowBase
    {
        public float Fraction05;                                               // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Fraction06;                                               // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Fraction07;                                               // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Fraction08;                                               // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Fraction09;                                               // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotAnimAsset
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableSlotAnimAsset : FTableRowBase
    {
        public FName Stand;
        public FName Reach;
        public FName Win;
        public FName WinIn;
    }

    // ScriptStruct JackGame.JackDataTableSlotAsset
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableSlotAsset : FTableRowBase
    {
        public FName MeshClass;
    }

    // ScriptStruct JackGame.JackDataTableSlotWild
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableSlotWild : FTableRowBase
    {
        public int Percent;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotRole
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableSlotRole : FTableRowBase
    {
        public int Five;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Four;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Three;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotPaymentsPercent
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableSlotPaymentsPercent : FTableRowBase
    {
        public int PayPercent;                                               // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WinPercent;                                               // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotReach
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableSlotReach : FTableRowBase
    {
        public int Percent;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotPayout
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableSlotPayout : FTableRowBase
    {
        public int Five;                                                     // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Four;                                                     // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Three;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotHitLine
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableSlotHitLine : FTableRowBase
    {
        public int Percent;                                                  // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotHitProbability
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableSlotHitProbability : FTableRowBase
    {
        public float Normal;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Metal;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Range;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableSlotReel
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableSlotReel : FTableRowBase
    {
        public FName R1;                                                       // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName R2;                                                       // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName R3;                                                       // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName R4;                                                       // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName R5;                                                       // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableParticleSound
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableParticleSound : FTableRowBase
    {
        public FName Sound0;
        public FName Sound1;
        public FName Sound2;
    }

    // ScriptStruct JackGame.JackDataTableME
    // 0x0040 (0x0048 - 0x0008)
    public class FJackDataTableME : FTableRowBase
    {
        public FName ME;
        public FName OrcheME;
        public float FadeOutTime;                                              // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeInTime;                                               // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDontResumeBGM;                                           // 0x0040(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bPlayAtPrintEnd;                                          // 0x0041(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBGMVolume
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableBGMVolume : FTableRowBase
    {
        public string Title;                                                    // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float JP3DGold;                                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float JP3DOrche;                                                // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float NE3DGold;                                                 // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float NE3DOrche;                                                // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bNoOrche;                                                 // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBGMScenario
    // 0x00C0 (0x00C8 - 0x0008)
    public class FJackDataTableBGMScenario : FTableRowBase
    {
        public FName StartFlag1;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EndFlag1;                                                 // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CSFlag1;                                                  // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID1;                                                   // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StartFlag2;                                               // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EndFlag2;                                                 // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CSFlag2;                                                  // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID2;                                                   // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StartFlag3;                                               // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EndFlag3;                                                 // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CSFlag3;                                                  // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID3;                                                   // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StartFlag4;                                               // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EndFlag4;                                                 // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CSFlag4;                                                  // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID4;                                                   // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StartFlag5;                                               // 0x0088(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EndFlag5;                                                 // 0x0090(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CSFlag5;                                                  // 0x0098(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID5;                                                   // 0x00A0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName StartFlag6;                                               // 0x00A8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName EndFlag6;                                                 // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CSFlag6;                                                  // 0x00B8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BGMID6;                                                   // 0x00C0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableBGM
    // 0x0078 (0x0080 - 0x0008)
    public class FJackDataTableBGM : FTableRowBase
    {
        public FName DayBGM;
        public FName NightBGM;
        public FName OrcheDayBGM;
        public FName OrcheNightBGM;
        public EJackBGMControl DayBGMControl;                                            // 0x0068(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBGMControl NightBGMControl;                                          // 0x0069(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBGMControl BeginCS_BGMControl;                                       // 0x006A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackBGMControl EndCS_BGMControl;                                         // 0x006B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NextSceneBGMID;                                           // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeoutTimePreviousBGM;                                   // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableTemporaryMaterialCoordinate
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableTemporaryMaterialCoordinate : FTableRowBase
    {
        public bool bEvilOriginalColorFalloff;
        [Serializer(OnlyIfSet = "bEvilOriginalColorFalloff")]
        public float EvilOriginalColorFalloff;                                 // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilOriginalColorScale;
        [Serializer(OnlyIfSet = "bEvilOriginalColorScale")]
        public float EvilOriginalColorScale;                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilMaterialLightScale;
        [Serializer(OnlyIfSet = "bEvilMaterialLightScale")]
        public float EvilMaterialLightScale;                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilRimColorR;
        [Serializer(OnlyIfSet = "bEvilRimColorR")]
        public float EvilRimColorR;                                            // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilRimColorG;
        [Serializer(OnlyIfSet = "bEvilRimColorG")]
        public float EvilRimColorG;                                            // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilRimColorB;
        [Serializer(OnlyIfSet = "bEvilRimColorB")]
        public float EvilRimColorB;                                            // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilRimColorScale;
        [Serializer(OnlyIfSet = "bEvilRimColorScale")]
        public float EvilRimColorScale;                                        // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilRimFalloff;
        [Serializer(OnlyIfSet = "bEvilRimFalloff")]
        public float EvilRimFalloff;                                           // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilOutlineColorR;
        [Serializer(OnlyIfSet = "bEvilOutlineColorR")]
        public float EvilOutlineColorR;                                        // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilOutlineColorG;
        [Serializer(OnlyIfSet = "bEvilOutlineColorG")]
        public float EvilOutlineColorG;                                        // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilOutlineColorB;
        [Serializer(OnlyIfSet = "bEvilOutlineColorB")]
        public float EvilOutlineColorB;                                        // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilOutlineColorScale;
        [Serializer(OnlyIfSet = "bEvilOutlineColorScale")]
        public float EvilOutlineColorScale;                                    // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilColorR;
        [Serializer(OnlyIfSet = "bEvilColorR")]
        public float EvilColorR;                                               // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilColorG;
        [Serializer(OnlyIfSet = "bEvilColorG")]
        public float EvilColorG;                                               // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilColorB;
        [Serializer(OnlyIfSet = "bEvilColorB")]
        public float EvilColorB;                                               // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilColorScale;
        [Serializer(OnlyIfSet = "bEvilColorScale")]
        public float EvilColorScale;                                           // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bEvilMapScale;
        [Serializer(OnlyIfSet = "bEvilMapScale")]
        public float EvilMapScale;                                             // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeInTime;                                               // 0x004C(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeOutTime;                                              // 0x0050(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableTenseiCSWatch
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableTenseiCSWatch : FTableRowBase
    {
        public FName JackCSFlag;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TripleCSID;                                               // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableTenseiScenarioFlags
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableTenseiScenarioFlags : FTableRowBase
    {
        public int ScenarioNo;                                               // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> ScenarioFlags;                                            // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableTenseiFlags
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableTenseiFlags : FTableRowBase
    {
        public EJackGameFlagCategory Category;                                                 // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlagId;                                                   // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Arg1;                                                     // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Arg2;                                                     // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableTenseiParams
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableTenseiParams : FTableRowBase
    {
        public EJackTenseiOperationType Type;                                                     // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Value;                                                    // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Arg1;                                                     // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Arg2;                                                     // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackTenseiDisplayCondition
    // 0x0010
    public class FJackTenseiDisplayCondition : FTableRowBase
    {
        public EJackGameFlagCategory FlagCategory;                                             // 0x0000(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FlagId;                                                   // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableTenseiSelect
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableTenseiSelect : FTableRowBase
    {
        public EJackScenarioGroup ScenarioGroup;                                            // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioTitleNameId;                                      // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapStart;                                                 // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ProgressNo;                                               // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackTenseiDisplayCondition> DisplayCondition;                                         // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName ScenarioDescriptionId;                                    // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioTexture;
        public FName TripleMapStart;                                           // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableTenseiParams2D
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableTenseiParams2D : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int FlagId;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SubFlagId;                                                // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Arg1;                                                     // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Arg2;                                                     // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Arg3;                                                     // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableTenseiFlags2D
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableTenseiFlags2D : FTableRowBase
    {
        public FName Category;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int FlagId;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int SubFlagId;                                                // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Arg1;                                                     // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Arg2;                                                     // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Arg3;                                                     // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Cmds;                                                     // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackTenseiRespawnData2D
    // 0x0008
    public class FJackTenseiRespawnData2D : FTableRowBase
    {
        public int MapId;                                                    // 0x0000(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte ShipPointId;                                              // 0x0004(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte MapJumpLocatorId;                                         // 0x0005(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte EventType;                                                // 0x0006(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackTenseiDisplayCondition2D
    // 0x0010
    public class FJackTenseiDisplayCondition2D : FTableRowBase
    {
        public FName FlagCategory;                                             // 0x0000(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte ScenarioID;                                               // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte FlagId;                                                   // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableTenseiSelect2D
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableTenseiSelect2D : FTableRowBase
    {
        public byte ScenarioGroup;                                            // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string ScenarioTitleNameId;                                      // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int ProgressNo;                                               // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int MapId;                                                    // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte ScenarioJump;                                             // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte RiremitoPointId;                                          // 0x0029(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int EmbarkationMapId;                                         // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte EmbarkationLocatorId;                                     // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte EmbarkationAnchorageId;                                   // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FJackTenseiRespawnData2D RespawnData;                                              // 0x0034(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public byte PrevScenarioId;                                           // 0x003C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte PrevScenarioFlag;                                         // 0x003D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PrevCutSceneId;                                           // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FJackTenseiDisplayCondition2D> DisplayCondition;                                         // 0x0048(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string ScenarioDescriptionId;                                    // 0x0058(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableDebugLongestValue
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableDebugLongestValue : FTableRowBase
    {
        public int Value;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackTagCategory TagCategory;                                              // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableDebugLongestArticleInfo
    // 0x0090 (0x0098 - 0x0008)
    public class FJackDataTableDebugLongestArticleInfo : FTableRowBase
    {
        public FJackArticleInfo ArticleInfo;                                              // 0x0008(0x0088) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance)
        public EJackTagCategory TagCategory;                                              // 0x0090(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableGermanCheckLastIsS
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableGermanCheckLastIsS : FTableRowBase
    {
        public string LastIsS;                                                  // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableGermanRating
    // 0x0040
    public class FJackDataTableGermanRating : FTableRowBase
    {
        public string NOM_Name;                                                 // 0x0000(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string GEN_Name;                                                 // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string DAT_Name;                                                 // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string ACC_Name;                                                 // 0x0030(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableGermanCaseChangeTable
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableGermanCaseChangeTable : FTableRowBase
    {
        public EJackGermanSectionType Section;                                                  // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string DefName;                                                  // 0x0010(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FJackDataTableGermanRating> Ratings;                                                  // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableFrenchCheckVowel
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableFrenchCheckVowel : FTableRowBase
    {
        public string UpStr;                                                    // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string LowStr;                                                   // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public string CheckStr;                                                 // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableTagInfo
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableTagInfo : FTableRowBase
    {
        public string TagName;                                                  // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public EJackTagReferType Refer;                                                    // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackTagCategory Category;                                                 // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableMacroInfo
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableMacroInfo : FTableRowBase
    {
        public string DefName;                                                  // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public EJackProcessType Process;                                                  // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackHangType Hang;                                                     // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackTagReferType Refer;                                                    // 0x001A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ArgumentNum;                                              // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bAttachTagName;                                           // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableTokugiPanelInfo
    // 0x0078 (0x0080 - 0x0008)
    public class FJackDataTableTokugiPanelInfo : FTableRowBase
    {
        public EJackCharacter TargetCharacter;                                          // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Order;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackTokugiType Type;                                                     // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ID;                                                       // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ConfirmMessage;                                           // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LearnedMessage;                                           // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SingleLearnedMessage;                                     // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int ConsumePoint;                                             // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector2D PanelPos;                                                 // 0x003C(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public bool bLockPanel;                                               // 0x0044(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bAtariPanel;                                              // 0x0045(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bFuuinPanel;                                              // 0x0046(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int IconType;                                                 // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<EJackSkillLine>                SkillLineTypeList;                                        // 0x0050(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public EJackItem_Classification ConfirmWeaponType;                                        // 0x0060(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<EJackTokugiPanelScenario>      ScenarioFlagList;                                         // 0x0068(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public float ResetAnimTiming;                                          // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int TripleTokugiPanelNo;                                      // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackActionFieldTextInfo
    // 0x0010
    public class FJackActionFieldTextInfo : FTableRowBase
    {
        public FName Message;                                                  // 0x0000(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackActionFieldTextType Timming;                                                  // 0x0008(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUIActionFieldText
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableUIActionFieldText : FTableRowBase
    {
        public List<FJackActionFieldTextInfo> TextInfoList;                                             // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableUIActionSort
    // 0x0068 (0x0070 - 0x0008)
    public class FJackDataTableUIActionSort : FTableRowBase
    {
       // public string DisplayName;                                              // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int P001Field_2;                                              // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P001Battle_2;                                             // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P002Field_2;                                              // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P002Battle_2;                                             // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P002Field_3;                                              // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P002Battle_3;                                             // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P003Field_2;                                              // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P003Battle_2;                                             // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P004Field_2;                                              // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P004Battle_2;                                             // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P004Field_3;                                              // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P004Battle_3;                                             // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P005Field_2;                                              // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P005Battle_2;                                             // 0x004C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P006Field_2;                                              // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P006Battle_2;                                             // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P007Field_2;                                              // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P007Battle_2;                                             // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P008Field_2;                                              // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int P008Battle_2;                                             // 0x0064(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackUMGFieldActionSoundType FieldActionSE;                                            // 0x0068(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUICurrentPlaceInfo
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableUICurrentPlaceInfo : FTableRowBase
    {
        public FVector2D Position;                                                 // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUIFaceIcon
    // 0x0098 (0x00A0 - 0x0008)
    public class FJackDataTableUIFaceIcon : FTableRowBase
    {
        public EJackCharacter CharType;                                                 // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName AliveTexture;
        public FName DeadTexture;
        public FName ZoneTexture;
        public FName BustTexture;
        public FName EyeTexture;
        public FName FaceTexture;
    }

    // ScriptStruct JackGame.JackDataTableUIFukidasiFaceIcon
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableUIFukidasiFaceIcon : FTableRowBase
    {
        public FName FaceIconAsset;
    }

    // ScriptStruct JackGame.JackDataTableUIKatagaki
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableUIKatagaki : FTableRowBase
    {
        public EJackScenarioPlaythrough Playthrough;                                              // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackScenarioID ScenarioID;                                               // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ScenarioFlag;                                             // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CutSceneFlag;                                             // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName P001;                                                     // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName P002;                                                     // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName P003;                                                     // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName P004;                                                     // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName P005;                                                     // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName P006;                                                     // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName P007;                                                     // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName P008;                                                     // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUIMapInfo
    // 0x00C0 (0x00C8 - 0x0008)
    public class FJackDataTableUIMapInfo : FTableRowBase
    {
        public FName MapId;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ParentVolumeID;                                           // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public bool bMiniMapEnabled;                                          // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public bool bJourney;                                                 // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public bool bClearFootmark;                                           // 0x001A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        //public bool bUseMapChangeEffect;                                      // 0x001B(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte Flags; // TODO: all the above are stored in here?
        public EJackMapPCMarkerDisplayMethod PCMarkerDisplayMethod;                                    // 0x001C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMapFieldType FieldType;                                                // 0x001D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFloorLevel FloorLevel;                                               // 0x001E(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFloorArea FloorArea;                                                // 0x001F(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackFloorGroup FloorGroup;                                               // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapOpenFlag;                                              // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName WorldMapTitleTextID;                                      // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName WorldMapTitleTextOpenFlag;                                // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MLocationTextID;                                          // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MLocationTextOpenFlag;                                    // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SLocationTextID;                                          // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SLocationTextOpenFlag;                                    // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float MiniMapDisplayDiameter;                                   // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float WorldMapZoomFactorMax;                                    // 0x0064(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapTextWBP;
        public FName MapOpenTexture;
        public FName MapMaskTexture;
        public FName MiniMapTexture;
    }

    // ScriptStruct JackGame.JackDataTableUIMapTextConfig
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableUIMapTextConfig : FTableRowBase
    {
        public FName MapId;                                                    // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LocationNameTextID;                                       // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OpenMapTextCondition_VisitFlag;                           // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGameFlagCategory OpenMapTextCondition_FlagCategory;                        // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName OpenMapTextCondition_FlagName;                            // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackLocationNameDisplayMethod LocationNameDisplayMethod;                                // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUIMessageSpeed
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableUIMessageSpeed : FTableRowBase
    {
        public EJackSpeed Type;                                                     // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float WaitSecondsPerCharacter;                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FastModeMultiplier;                                       // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUINeighborMapInfo
    // 0x0070 (0x0078 - 0x0008)
    public class FJackDataTableUINeighborMapInfo : FTableRowBase
    {
        public List<FName> SameAreaMapVolumeIDList;                                  // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName OverrideLocationNameTextID;                               // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackLocationNameDisplayMethod DefaultDisplayMethod;                                     // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGameFlagCategory DisplayControlFlagCategory;                               // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisplayControlFlagName;                                   // 0x0028(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackGameFlagOperator DisplayControlFlagCondition;                              // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackLocationNameDisplayMethod DisplayControlMethod;                                     // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> NeighborMapVolumeIDListA;                                 // 0x0038(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> NeighborMapVolumeIDListS;                                 // 0x0048(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> NeighborMapVolumeIDListB;                                 // 0x0058(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> NeighborMapVolumeIDListC;                                 // 0x0068(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableUIPlatformSpecificText
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableUIPlatformSpecificText : FTableRowBase
    {
        public string Text;                                                     // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public FName ExchangeTag;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUIStaffRoll
    // 0x00A0 (0x00A8 - 0x0008)
    public class FJackDataTableUIStaffRoll : FTableRowBase
    {
        public EJackStaffRollEventType EventType;                                                // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartTime;                                                // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartTime2;                                               // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndTime;                                                  // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EndTime2;                                                 // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeInTime;                                               // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DisplayTime;                                              // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeOutTime;                                              // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeInTime2;                                              // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DisplayTime2;                                             // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float FadeOutTime2;                                             // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FontTypeKey;                                              // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float TextPosY;                                                 // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float TextPosX;                                                 // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TextMain;                                                 // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ThreeRowsTextLeft;                                        // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ThreeRowsTextCenter;                                      // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName ThreeRowsTextRight;                                       // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TwoRowsTextLeft;                                          // 0x0068(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TwoRowsTextRight;                                         // 0x0070(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TextCompany;                                              // 0x0078(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public List<FName> Image;
        public List<FVector2D> ImageOffset;                                              // 0x0090(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public bool bDontUseFirst;                                            // 0x00A0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUITabiNoKokoroe
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableUITabiNoKokoroe : FTableRowBase
    {
        public FName TitleText;                                                // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName FullTitleText;                                            // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MainText;                                                 // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bShowInTabiNoKokoroe;                                     // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackTutorialCategory Category;                                                 // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bDisplayTexture;                                          // 0x0022(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TopTexture;
        public FName SubPageKey1;                                              // 0x0040(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SubPageKey2;                                              // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SubPageKey3;                                              // 0x0050(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName SubPageKey4;                                              // 0x0058(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName GameFlag;                                                 // 0x0060(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUITokugiPanelScenario
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTableUITokugiPanelScenario : FTableRowBase
    {
        public EJackCharacter TargetCharacter;                                          // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int Index;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackTokugiPanelScenario TokugiPanelScenario;                                      // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName BackgroundTexture;
        public FVector2D PanelPosOffset;                                           // 0x0030(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FVector2D SkillLineEffectPosOffset;                                 // 0x0038(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUITokugiPanelSkillLine
    // 0x0030 (0x0038 - 0x0008)
    public class FJackDataTableUITokugiPanelSkillLine : FTableRowBase
    {
        public EJackCharacter TargetCharacter;                                          // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackSkillLine SkillLineType;                                            // 0x0009(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Description;                                              // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector2D StartPoint;                                               // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public FVector2D FlashEffectPos;                                           // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public List<EJackTokugiPanelScenario>      ScenarioFlagList;                                         // 0x0028(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
}

    // ScriptStruct JackGame.JackDataTableUmaRaceVehicleEntry
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableUmaRaceVehicleEntry : FTableRowBase
    {
        public FName VehicleClass;
        public EJackUmaRaceHorseType HorseType;                                                // 0x0020(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsRandomEntry;                                           // 0x0021(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUmaRaceEntryData
    // 0x0058 (0x0060 - 0x0008)
    public class FJackDataTableUmaRaceEntryData : FTableRowBase
    {
        public FName PlayerName;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackUmaRaceHorseType HorseType;                                                // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName NPCBlueprintClass;
        public int SpecifyPaddockNumber;                                     // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsModelScale;                                            // 0x0034(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int PathNo;                                                   // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName TimeScheduleDataTable;
        public int ImpactPriority;                                           // 0x0058(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUmaRaceResultCamera
    // 0x0028 (0x0030 - 0x0008)
    public class FJackDataTableUmaRaceResultCamera : FTableRowBase
    {
        public FName CameraAnim;
        public float PlayTime;                                                 // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float PlayRate;                                                 // 0x0024(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bIsOrbitRotation;                                         // 0x0028(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float StartTime;                                                // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUmaRaceTimeSchedule
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableUmaRaceTimeSchedule : FTableRowBase
    {
        public bool bIsEnable;                                                // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int LapCount;                                                 // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Ratio;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Time;                                                     // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float TimeRange;                                                // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableUserDefinedTag
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableUserDefinedTag : FTableRowBase
    {
        public bool bInUse;                                                   // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableVehicleList
    // 0x0038 (0x0040 - 0x0008)
    public class FJackDataTableVehicleList : FTableRowBase
    {
        public FName MonsterID;                                                // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName DisplayName;                                              // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName LODBoundsName;                                            // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WeakActionMonsterAddLevel;                                // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VehicleAsset;
    }

    // ScriptStruct JackGame.JackDataTableVehicleRiderSyncAnimationTable
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableVehicleRiderSyncAnimationTable : FTableRowBase
    {
        public FName RiderAnimation;                                           // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VehicleAnimation;                                         // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableVoiceDramaDLCInfo
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableVoiceDramaDLCInfo : FTableRowBase
    {
        public string ScenarioMinute;                                           // 0x0008(0x0010) (Edit, ZeroConstructor, EditConst)
        public string ScenarioSecond;                                           // 0x0018(0x0010) (Edit, ZeroConstructor, EditConst)
    }

    // ScriptStruct JackGame.JackDataTableVoiceDramaHDPafuPafu
    // 0x0160 (0x0168 - 0x0008)
    public class FJackDataTableVoiceDramaHDPafuPafu : FTableRowBase
    {
        public int RoundNum;                                                 // 0x0008(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public string LeftRight;                                                // 0x0010(0x0010) (Edit, ZeroConstructor, EditConst)
        public int Health;                                                   // 0x0020(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public int FacialChange1;                                            // 0x0024(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public int FacialChange2;                                            // 0x0028(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public int FacialChange3;                                            // 0x002C(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public FName FacialAsset1;
        public FName FacialAsset2;
        public FName FacialAsset3;
        public FName FacialAsset4;
        public FName FacialAsset5;
        public FName BackgroundAsset;
        public FName VoiceDramaBackgroundAsset;
        public FName StartVoice;
        public FName PafuPafuVoice1;
        public FName PafuPafuVoice2;
        public FName PafuPafuVoice3;
        public FName KnockoutVoice;
        public FName WaitVoice;
    }

    // ScriptStruct JackGame.JackDataTableVoiceDramaHDPafuPafuSoundEffect
    // 0x0018 (0x0020 - 0x0008)
    public class FJackDataTableVoiceDramaHDPafuPafuSoundEffect : FTableRowBase
    {
        public FName SoundAsset;
    }

    // ScriptStruct JackGame.JackDataTableVoiceDramaInfo
    // 0x0060 (0x0068 - 0x0008)
    public class FJackDataTableVoiceDramaInfo : FTableRowBase
    {
        public int ScenarioNo;                                               // 0x0008(0x0004) (Edit, ZeroConstructor, EditConst, IsPlainOldData)
        public string ScenarioTitle;                                            // 0x0010(0x0010) (Edit, ZeroConstructor, EditConst)
        public string OverviewText;                                             // 0x0020(0x0010) (Edit, ZeroConstructor, EditConst)
        public FName OverviewTexture;
        public string ScenarioMinute;                                           // 0x0048(0x0010) (Edit, ZeroConstructor, EditConst)
        public string ScenarioSecond;                                           // 0x0058(0x0010) (Edit, ZeroConstructor, EditConst)
    }

    // ScriptStruct JackGame.JackDataTableVoiceLabel
    // 0x0008 (0x0010 - 0x0008)
    public class FJackDataTableVoiceLabel : FTableRowBase
    {
        public bool bResidentResource;                                        // 0x0008(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCondition_Nemuri;                                        // 0x0009(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCondition_Mahi;                                          // 0x000A(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCondition_Konran;                                        // 0x000B(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bCondition_Miryou;                                        // 0x000C(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableVoicePreset
    // 0x0048 (0x0050 - 0x0008)
    public class FJackDataTableVoicePreset : FTableRowBase
    {
        public int Priority;                                                 // 0x0008(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float DelayTime;                                                // 0x000C(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte Flags;                                                    // 0x0010(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VoiceAsset;
        public float DelayTimeEN;                                              // 0x0030(0x0004) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public byte FlagsEN;                                                  // 0x0034(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName VoiceAssetEN;
    }

    // ScriptStruct JackGame.JackDataTableWeaponHiddenCoordinate
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableWeaponHiddenCoordinate : FTableRowBase
    {
        public List<FName> WeaponHiddenSocketNames;                                  // 0x0008(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public List<FName> WeaponHiddenSocketNamesForBattle;                         // 0x0018(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }

    // ScriptStruct JackGame.JackDataTableWeather
    // 0x0138 (0x0140 - 0x0008)
    public class FJackDataTableWeather : FTableRowBase
    {
        public float Probability0;                                             // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather0_Morning;                                         // 0x000C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel0_Morning;                                       // 0x000D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle0_Morning;                                       // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute0_Morning;                           // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather0_Daytime;                                         // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel0_Daytime;                                       // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle0_Daytime;                                       // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute0_Daytime;                           // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather0_Evening;                                         // 0x0024(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel0_Evening;                                       // 0x0025(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle0_Evening;                                       // 0x0028(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute0_Evening;                           // 0x002C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather0_Night;                                           // 0x0030(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel0_Night;                                         // 0x0031(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle0_Night;                                         // 0x0034(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute0_Night;                             // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Probability1;                                             // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather1_Morning;                                         // 0x0040(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel1_Morning;                                       // 0x0041(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle1_Morning;                                       // 0x0044(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute1_Morning;                           // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather1_Daytime;                                         // 0x004C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel1_Daytime;                                       // 0x004D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle1_Daytime;                                       // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute1_Daytime;                           // 0x0054(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather1_Evening;                                         // 0x0058(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel1_Evening;                                       // 0x0059(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle1_Evening;                                       // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute1_Evening;                           // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather1_Night;                                           // 0x0064(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel1_Night;                                         // 0x0065(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle1_Night;                                         // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute1_Night;                             // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Probability2;                                             // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather2_Morning;                                         // 0x0074(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel2_Morning;                                       // 0x0075(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle2_Morning;                                       // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute2_Morning;                           // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather2_Daytime;                                         // 0x0080(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel2_Daytime;                                       // 0x0081(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle2_Daytime;                                       // 0x0084(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute2_Daytime;                           // 0x0088(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather2_Evening;                                         // 0x008C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel2_Evening;                                       // 0x008D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle2_Evening;                                       // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute2_Evening;                           // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather2_Night;                                           // 0x0098(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel2_Night;                                         // 0x0099(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle2_Night;                                         // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute2_Night;                             // 0x00A0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Probability3;                                             // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather3_Morning;                                         // 0x00A8(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel3_Morning;                                       // 0x00A9(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle3_Morning;                                       // 0x00AC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute3_Morning;                           // 0x00B0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather3_Daytime;                                         // 0x00B4(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel3_Daytime;                                       // 0x00B5(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle3_Daytime;                                       // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute3_Daytime;                           // 0x00BC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather3_Evening;                                         // 0x00C0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel3_Evening;                                       // 0x00C1(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle3_Evening;                                       // 0x00C4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute3_Evening;                           // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather3_Night;                                           // 0x00CC(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel3_Night;                                         // 0x00CD(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle3_Night;                                         // 0x00D0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute3_Night;                             // 0x00D4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Probability4;                                             // 0x00D8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather4_Morning;                                         // 0x00DC(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel4_Morning;                                       // 0x00DD(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle4_Morning;                                       // 0x00E0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute4_Morning;                           // 0x00E4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather4_Daytime;                                         // 0x00E8(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel4_Daytime;                                       // 0x00E9(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle4_Daytime;                                       // 0x00EC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute4_Daytime;                           // 0x00F0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather4_Evening;                                         // 0x00F4(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel4_Evening;                                       // 0x00F5(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle4_Evening;                                       // 0x00F8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute4_Evening;                           // 0x00FC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather4_Night;                                           // 0x0100(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel4_Night;                                         // 0x0101(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle4_Night;                                         // 0x0104(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute4_Night;                             // 0x0108(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Probability5;                                             // 0x010C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather5_Morning;                                         // 0x0110(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel5_Morning;                                       // 0x0111(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle5_Morning;                                       // 0x0114(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute5_Morning;                           // 0x0118(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather5_Daytime;                                         // 0x011C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel5_Daytime;                                       // 0x011D(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle5_Daytime;                                       // 0x0120(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute5_Daytime;                           // 0x0124(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather5_Evening;                                         // 0x0128(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel5_Evening;                                       // 0x0129(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle5_Evening;                                       // 0x012C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute5_Evening;                           // 0x0130(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWeather Weather5_Night;                                           // 0x0134(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackWorldWindLevel WindLevel5_Night;                                         // 0x0135(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngle5_Night;                                         // 0x0138(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int WindAngleChangeMinute5_Night;                             // 0x013C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableYochiList
    // 0x0020 (0x0028 - 0x0008)
    public class FJackDataTableYochiList : FTableRowBase
    {
        public FName MapVisitID;                                               // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName MapNameID;                                                // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool bSpecialFlag;                                             // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName CheckMarkFlag;                                            // 0x0020(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableFacialPresetInfo
    // 0x0010 (0x0018 - 0x0008)
    public class FJackDataTableFacialPresetInfo : FTableRowBase
    {
        public FName UpperFaceName;                                            // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, IsPlainOldData)
        public FName LowerFaceName;                                            // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackGame.JackDataTableNativizationAssetPath
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableNativizationAssetPath : FTableRowBase
    {
        // TODO: doesn't seem to follow FJackDataTableNativizationAssetPath format at all..
        // seems closer to FJackDataTableNativizationAsset's serialized UObject
        public FName NativizationAsset;                                        // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName Unknown0x8;
        public byte Unknown0x10;
        public FName Unknown0x11;
        public FName Unknown0x19;
        public FName Unknown0x21;
    }

    // ScriptStruct JackGame.JackDataTableNativizationAsset
    // 0x0008 (0x0010 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableNativizationAsset : UObject
    {
    }

    // ScriptStruct JackAnimNodeRuntime.JackAnimDynamicsConstraintSetup
    // 0x005C
    public class FJackAnimDynamicsConstraintSetup : FTableRowBase
    {
        public EJackAnimPhysLinearConstraintType LinearXLimitType;                                         // 0x0000(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackAnimPhysLinearConstraintType LinearYLimitType;                                         // 0x0001(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackAnimPhysLinearConstraintType LinearZLimitType;                                         // 0x0002(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public FVector LinearAxesMin;                                            // 0x0004(0x000C) (Edit, IsPlainOldData)
        public FVector LinearAxesMax;                                            // 0x0010(0x000C) (Edit, IsPlainOldData)
        public EJackAnimPhysAngularConstraintType AngularConstraintType;                                    // 0x001C(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public EAnimPhysTwistAxis TwistAxis;                                                // 0x001D(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public float ConeAngle;                                                // 0x0020(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        //public float AngularXAngle;                                            // 0x0024(0x0004) (ZeroConstructor, Deprecated, IsPlainOldData)
        //public float AngularYAngle;                                            // 0x0028(0x0004) (ZeroConstructor, Deprecated, IsPlainOldData)
        //public float AngularZAngle;                                            // 0x002C(0x0004) (ZeroConstructor, Deprecated, IsPlainOldData)
        public FVector AngularLimitsMin;                                         // 0x0030(0x000C) (Edit, IsPlainOldData)
        public FVector AngularLimitsMax;                                         // 0x003C(0x000C) (Edit, IsPlainOldData)
        public EAnimPhysTwistAxis AngularTargetAxis;                                        // 0x0048(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public FVector AngularTarget;                                            // 0x004C(0x000C) (Edit, IsPlainOldData)
        public bool bLinearFullyLocked;                                       // 0x0058(0x0001) (ZeroConstructor, IsPlainOldData)
    }

    // ScriptStruct JackAnimNodeRuntime.JackAnimDynamicsPlanarLimit
    // 0x0060
    public class FJackAnimDynamicsPlanarLimit : FTableRowBase
    {
        public FName                                       DrivingBoneName;                                          // 0x0018(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public FTransform                                  PlaneTransform;                                           // 0x0020(0x0030) (Edit, IsPlainOldData)
        public bool                                               bUseFinitePlane;                                          // 0x0050(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public FVector2D                                   PlaneExtend;                                              // 0x0054(0x0008) (Edit, IsPlainOldData)
        public bool                                               bSkipDrivingBoneValidation;                               // 0x005C(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
    };

    // ScriptStruct JackAnimNodeRuntime.JackAnimDynamicsSphericalLimit
    // 0x0038
    public class FJackAnimDynamicsSphericalLimit : FTableRowBase
    {
        public FName                                       DrivingBoneName;                                          // 0x0018(0x0008) (Edit, ZeroConstructor, IsPlainOldData)
        public FVector                                     SphereLocalOffset;                                        // 0x0020(0x000C) (Edit, IsPlainOldData)
        public float                                              LimitRadius;                                              // 0x002C(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        public EJackAnimDynamicsSphericalLimitType                LimitType;                                                // 0x0030(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public bool                                               bSkipDrivingBoneValidation;                               // 0x0031(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
    };

    // ScriptStruct JackAnimNodeRuntime.JackAnimDynamicsProperties
    // 0x02C8
    public class FJackAnimDynamicsProperties : FTableRowBase
    {
        public FName MasterPose;                                      // 0x0000(0x0018) UNKNOWN PROPERTY: SoftObjectProperty JackAnimNodeRuntime.JackAnimDynamicsProperties.MasterPose
        public List<FName> ExcludeMasterPose;
        public EJackAnimPhysSimSpaceType SimulationSpace;                                          // 0x0030(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public FName RelativeSpaceBone;                                        // 0x0038(0x0018) (Edit, BlueprintVisible)
        public bool bChain;                                                   // 0x0050(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public FName BoundBone;                                                // 0x0058(0x0018) (Edit, BlueprintVisible)
        public FName ChainEnd;                                                 // 0x0070(0x0018) (Edit, BlueprintVisible)
        public FVector BoxExtents;                                               // 0x0088(0x000C) (Edit, BlueprintVisible, IsPlainOldData)
        public FVector LocalJointOffset;                                         // 0x0094(0x000C) (Edit, BlueprintVisible, IsPlainOldData)
        public float GravityScale;                                             // 0x00A0(0x0004) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public bool bEnableWind;                                              // 0x00B0(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public float WindScale;                                                // 0x00B4(0x0004) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public EJackWindEffectDecayRate WindEffectDecayRate;                                      // 0x00B8(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public bool bReverseWindEffectDecay;                                  // 0x00B9(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public float WindEffectMaxClamp;                                       // 0x00BC(0x0004) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public float WindEffectThreshold;                                      // 0x00C0(0x0004) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public bool bUseVehicleFakeForce;                                     // 0x00C4(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public bool bUseKeepBoneLength;                                       // 0x00C5(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public bool bOverrideLinearDamping;                                   // 0x00C6(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public float LinearDampingOverride;                                    // 0x00C8(0x0004) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public bool bOverrideAngularDamping;                                  // 0x00CC(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public float AngularDampingOverride;                                   // 0x00D0(0x0004) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public bool bOverrideAngularBias;                                     // 0x00D4(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public float AngularBiasOverride;                                      // 0x00D8(0x0004) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public FJackAnimDynamicsConstraintSetup ConstraintSetup;                                          // 0x00E8(0x005C) (Edit, BlueprintVisible)

        public bool bUsePlanarLimit;                                          // 0x0144(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public bool bUseSphericalLimits;                                      // 0x0158(0x0001) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)

        // TODO: only one of these lists should be active, with 4-byte filler if none are
        [Serializer(OnlyIfSet = "bUsePlanarLimit")]
        public List<FJackAnimDynamicsPlanarLimit> PlanarLimits;                                             // 0x0148(0x0010) (Edit, BlueprintVisible, ZeroConstructor)
        
       // [Serializer(OnlyIfSet = "bUseSphericalLimits")]
        public List<FJackAnimDynamicsSphericalLimit> SphericalLimits;                                          // 0x0160(0x0010) (Edit, BlueprintVisible, ZeroConstructor)

        public EAnimPhysCollisionType CollisionType;                                            // 0x0170(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public float SphereCollisionRadius;                                    // 0x0174(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        public FVector ExternalForce;                                            // 0x0178(0x000C) (Edit, IsPlainOldData)
        public bool bUseBoneSpaceGravityMode;                                 // 0x0184(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public FVector BoneSpaceGravityDirection;                                // 0x0188(0x000C) (Edit, IsPlainOldData)
        public bool bUseConvertVelocityToExternalForce;                       // 0x0194(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public float VelocityMulRatio;                                         // 0x0198(0x0004) (Edit, ZeroConstructor, IsPlainOldData)
        public FVector MinClampVelocity;                                         // 0x019C(0x000C) (Edit, IsPlainOldData)
        public FVector MaxClampVelocity;                                         // 0x01A8(0x000C) (Edit, IsPlainOldData)
        public EJackAnimPhysSimSpaceType ExternalForceSpace;                                       // 0x01B4(0x0001) (Edit, ZeroConstructor, IsPlainOldData)
        public FName ExternalForceRelativeBone;                                // 0x01B8(0x0018) (Edit)
        public FName ModifyGroupName;                                          // 0x01D8(0x0008) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
    };

    // ScriptStruct JackAnimNodeRuntime.JackDataTableAnimDynamicsTableProperties
    // 0x02E8 (0x02F0 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableAnimDynamicsTableProperties : FTableRowBase
    {
        public FName BoundBoneName;                                            // 0x0008(0x0008) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public FName ChainEndName;                                             // 0x0010(0x0008) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public FName RelativeBoneName;                                         // 0x0018(0x0008) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public FName ExternalForceRelativeBoneName;                            // 0x0020(0x0008) (Edit, BlueprintVisible, ZeroConstructor, IsPlainOldData)
        public FJackAnimDynamicsProperties AnimDynamicsSettings;                                     // 0x0028(0x02C8) (Edit, BlueprintVisible)
    }

    // ScriptStruct JackAnimNodeRuntime.JackDataTableAnimExp_DynamicBoneStateDef
    // 0x0040 (0x0048 - 0x0008)
    [Serializer(NoStructSize = true)]
    public class FJackDataTableAnimExp_DynamicBoneStateDef : FTableRowBase
    {
        public FName IncludeBoneName;                                          // 0x0008(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName ExcludeBoneName;                                          // 0x0010(0x0008) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public FName MasterPose;                                      // 0x0018(0x0018) UNKNOWN PROPERTY: SoftObjectProperty JackAnimNodeRuntime.JackDataTableAnimExp_DynamicBoneStateDef.MasterPose
        public List<FName> ExcludeMasterPose;                                      // 0x0030(0x0010) UNKNOWN PROPERTY: ArrayProperty JackAnimNodeRuntime.JackDataTableAnimExp_DynamicBoneStateDef.ExcludeMasterPose
        public EJackUpperDynamicBoneState UpperState;                                               // 0x0040(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackLowerDynamicBoneState LowerState;                                               // 0x0041(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackHairDynamicBoneState HairState;                                                // 0x0042(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
        public EJackMantleDynamicBoneState MantleState;                                              // 0x0043(0x0001) (Edit, BlueprintVisi, ZeroConstructor, IsPlainOldData)
    }
}
