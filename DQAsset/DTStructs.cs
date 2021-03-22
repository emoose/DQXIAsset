using System;
using System.Collections.Generic;

namespace DQAsset
{
    public class FVector : FTableRowBase
    {
        public float X;
        public float Y;
        public float Z;
    }

    public class JackDataTableMonsterFieldMovingBounds : FTableRowBase
    {
        public float WanderringRadius;                                         // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float WanderringMoveDistance;                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float EscapeMoveDistance;                                       // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float RushMoveDistance;                                        // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
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
        public int ProductionCostTotalLimit6;
    }

    enum EJackMeosiSlotMonsterBehaviorPattern : byte
    {
        EJackMeosiSlotMonsterBehaviorPattern__FLAT,
        EJackMeosiSlotMonsterBehaviorPattern__SLOPE,
        EJackMeosiSlotMonsterBehaviorPattern__CLIFF
    }

    enum EJackMeosiSlotAttackClass : byte
    {
        EJackMeosiSlotAttackClass__PHYSICAL,
        EJackMeosiSlotAttackClass__MAGICAL
    }

    enum EJackMeosiSlotAttackEffect : byte
    {
        EJackMeosiSlotAttackEffect__NONE = 0,
        EJackMeosiSlotAttackEffect__MISS = 1,
        EJackMeosiSlotAttackEffect__SLASH = 2,
        EJackMeosiSlotAttackEffect__SLASH_CRITICAL = 3,
        EJackMeosiSlotAttackEffect__STRIKE = 4,
        EJackMeosiSlotAttackEffect__STRIKE_CRITICAL = 5,
        EJackMeosiSlotAttackEffect__MAGIC_WEAK = 6,
        EJackMeosiSlotAttackEffect__MAGIC_STRONG = 7,
    }

    enum EJackMeosiSlotMonsterRank : byte
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
    }

    enum EJackMeosiSlotMonsterSize : byte
    {
        EJackMeosiSlotMonsterSize__S,
        EJackMeosiSlotMonsterSize__M,
        EJackMeosiSlotMonsterSize__L
    }

    enum EJackMeosiSlotMonsterID : byte
    {
        EJackMeosiSlotMonsterID__IdSlime = 0,
        EJackMeosiSlotMonsterID__IdDrackey = 1,
        EJackMeosiSlotMonsterID__IdMomonjya = 2,
        EJackMeosiSlotMonsterID__IdMocoky = 3,
        EJackMeosiSlotMonsterID__IdTombrelo = 4,
        EJackMeosiSlotMonsterID__IdKarakuriEgg = 5,
        EJackMeosiSlotMonsterID__IdChimera = 6,
        EJackMeosiSlotMonsterID__IdRottenCadaver = 7,
        EJackMeosiSlotMonsterID__IdBeeREJackMeosiSlotMonsterID__Ider = 8,
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
        EJackMeosiSlotMonsterID__IdLiquEJackMeosiSlotMonsterID__IdMetalSlime = 24,
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
    }

    class JackDataTableMeosiSlotMonsterParam : FTableRowBase
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

    public enum EJackAchievementRarity : byte
    {
        EJackAchievementRarity__Legend = 0,
        EJackAchievementRarity__Platinum = 1,
        EJackAchievementRarity__Gold = 2
    }

    public enum EJackAchievementCategory : byte
    {
        EJackAchievementCategory__Scenario = 0,
        EJackAchievementCategory__Battle = 1,
        EJackAchievementCategory__Kazi = 2,
        EJackAchievementCategory__Casino = 3,
        EJackAchievementCategory__Item = 4,
        EJackAchievementCategory__Etc = 5,
        EJackAchievementCategory__All = 6,
    }

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
    }

    public enum EJackAchievementTiming : byte
    {
        EJackAchievementTiming__Playable = 0,
        EJackAchievementTiming__TokugiPanelOnly = 1,
    }

    public class JackDataTableAchievement : FTableRowBase
    {
        public FName                                       AchievementNameID;                                        // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       DescriptionID;                                            // 0x0010(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievementRarity                Rarity;                                                   // 0x0018(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievementCategory              Category;                                                 // 0x0019(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievementCondition             Condition;                                                // 0x001A(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public string                                     StringParameter;                                          // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
        public int                                                NumericalParameter;                                       // 0x0030(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackAchievementTiming                Timing;                                                   // 0x0034(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int                                                CategoryNo;                                               // 0x0038(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int                                                PhoneticNo;                                               // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int                                                TripleAchievementNo;                                      // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       UE4AchievementName;                                       // 0x0048(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bUE4AchievementOnly;                                      // 0x0050(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bUE4AchievementReload;                                    // 0x0051(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bDisabledInTrial;                                         // 0x0052(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

    public class JackDataTableCharacterLODBounds : FTableRowBase
    {
        public FName                                       OriginBoneName;                                           // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector                                     OriginOffsetInBoneSpace;                                  // 0x0010(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public float                                       Radius;                                                   // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                       CastShadowCullingBoundsScale;                             // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    };

    public enum EJackCharacterEffectSize : byte
    {
        EJackCharacterEffectSize__Human = 0,
        EJackCharacterEffectSize__S    = 1,
        EJackCharacterEffectSize__M    = 2,
        EJackCharacterEffectSize__L    = 3,
        EJackCharacterEffectSize__LL   = 4,
        EJackCharacterEffectSize__MAX  = 5
    };

    public enum EJackMonsterMoveSpeed : byte
    {
        EJackMonsterMoveSpeed__SuperSlow = 0,
        EJackMonsterMoveSpeed__VerySlow = 1,
        EJackMonsterMoveSpeed__Slow    = 2,
        EJackMonsterMoveSpeed__SlightlySlow = 3,
        EJackMonsterMoveSpeed__Normal  = 4,
        EJackMonsterMoveSpeed__SlightlyFast = 5,
        EJackMonsterMoveSpeed__Fast    = 6,
        EJackMonsterMoveSpeed__VeryFast = 7,
        EJackMonsterMoveSpeed__SuperFast = 8,
        EJackMonsterMoveSpeed__Original = 9,
        EJackMonsterMoveSpeed__MAX     = 10
    };

    public enum EJackMonsterBodyAttribute : byte
    {
        EJackMonsterBodyAttribute__Monolithic = 0,
        EJackMonsterBodyAttribute__Body = 1,
        EJackMonsterBodyAttribute__Parts = 2,
        EJackMonsterBodyAttribute__NoEntityParts = 3,
        EJackMonsterBodyAttribute__ShadowCopy = 4,
        EJackMonsterBodyAttribute__MAX = 5
    };

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
    };

    public class JackDataTableMonsterPhysicalProperty : FTableRowBase
    {
        public float                                              ScaleX;                                                   // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScaleY;                                                   // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScaleZ;                                                   // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacterEffectSize                           CharacterEffectSize;                                      // 0x0014(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacterEffectSize                           CharacterEffectSizeByActionCast;                          // 0x0015(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackCharacterEffectSize                           CharacterEffectSizeByActionEffect;                        // 0x0016(0x0001) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       LODBoundsID;                                              // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int                                                LODLimitInBattle;                                         // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       FacialPresetID;                                           // 0x0028(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       VoicePresetID;                                            // 0x0030(0x0008) (Edit, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bBlockCamera;                                             // 0x0038(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bVariantForm;                                             // 0x0039(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public int                                                ProductionCost;                                           // 0x003C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              BasicSpeed;                                               // 0x0040(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMoveSpeed                 RunSpeed;                                                 // 0x0044(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              BackBasicSpeed;                                           // 0x0048(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterMoveSpeed                 BackRunSpeed;                                             // 0x004C(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              AcceptanceRadius;                                         // 0x0050(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bIgnoreTakePosition;                                      // 0x0054(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bIgnoreTurnWhenLookAt;                                    // 0x0055(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bIgnoreDamageDirection;                                   // 0x0056(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bIgnoreActionDirection;                                   // 0x0057(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bUseBackWalk;                                             // 0x0058(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              BackWalkAngleThreshold;                                   // 0x005C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              BackWalkDistanceThreshold;                                // 0x0060(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              GroupRadius;                                              // 0x0064(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              DamageS_BlendRate;                                        // 0x0068(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              DamageS_BlendRate2;                                       // 0x006C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              IdleToRunDuration;                                        // 0x0070(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              RunningTurnRate;                                          // 0x0074(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              EscapeTurnSpeedMultiplier;                                // 0x0078(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       Motion_EncountByNakamaYobi;                               // 0x0080(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bAlwaysNavWalking;                                        // 0x0088(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              NavWalkingDistance;                                       // 0x008C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              FootIKDisableDistance;                                    // 0x0090(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              AttitudeDisableDistance;                                  // 0x0094(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              AnimDynamicsDisableDistance;                              // 0x0098(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              AlwaysUpdatePoseAndRefreshBoneDistance;                   // 0x009C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bLeaveMeshWhenDead;                                       // 0x00A0(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bLeaveCollisionWhenDead;                                  // 0x00A1(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              AppealStartTimeMin;                                       // 0x00A4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              AppealStartTimeMax;                                       // 0x00A8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMonsterBodyAttribute             BodyAttribute;                                            // 0x00AC(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       BodyMonsterId;                                            // 0x00B0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              OffsetLengthOf3dWidget;                                   // 0x00B8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bIgnoreAlphabetOrder;                                     // 0x00BC(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ActionCameraLengthAdjust;                                 // 0x00C0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public bool                                               bRelativePosition;                                        // 0x00C4(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMatineeRenkeiMonsterSize         MatineeRenkeiMonsterSize;                                 // 0x00C5(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              KnockBackSmallRate;                                       // 0x00C8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              KnockBackNormalRate;                                      // 0x00CC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       ScoreRectRedSocket;                                       // 0x00D0(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectRedW;                                            // 0x00D8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectRedH;                                            // 0x00DC(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectRedOffsetZ;                                      // 0x00E0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       ScoreRectBlueSocket;                                      // 0x00E8(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectBlueW;                                           // 0x00F0(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectBlueH;                                           // 0x00F4(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectBlueOffsetZ;                                     // 0x00F8(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       ScoreRectGreenSocket;                                     // 0x0100(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectGreenW;                                          // 0x0108(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectGreenH;                                          // 0x010C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectGreenOffsetZ;                                    // 0x0110(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FName                                       ScoreRectYellowSocket;                                    // 0x0118(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectYellowW;                                         // 0x0120(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectYellowH;                                         // 0x0124(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                              ScoreRectYellowOffsetZ;                                   // 0x0128(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }
}
