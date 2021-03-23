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
        EJackCharacterEffectSize__LL   = 4
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
        EJackMonsterMoveSpeed__Original = 9
    };

    public enum EJackMonsterBodyAttribute : byte
    {
        EJackMonsterBodyAttribute__Monolithic = 0,
        EJackMonsterBodyAttribute__Body = 1,
        EJackMonsterBodyAttribute__Parts = 2,
        EJackMonsterBodyAttribute__NoEntityParts = 3,
        EJackMonsterBodyAttribute__ShadowCopy = 4
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
        EJackMatineeRenkeiMonsterSize__SP12 = 14
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

    // DT_GameParameter doesn't contain any structSize field before the struct itself, wtf?
    [Serializer(NoStructSize = true)]
    public class JackDataTableParameter : FTableRowBase
    {
	    public float                                              X;                                                        // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Y;                                                        // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float Z;                                                        // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public FName                                       Text;                                                     // 0x0018(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    }

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
        EJackMeosiSlotScenarioActNo__ActNo_Slime40 = 251
    }

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
        EJackMeosiSlotScenarioHint__Hint_Reach_Stock = 11
    }

    public enum EJackMeosiSlotScenarioStage : byte
    {
        EJackMeosiSlotScenarioStage__Stage_None = 0,
        EJackMeosiSlotScenarioStage__Stage_Daytime = 1,
        EJackMeosiSlotScenarioStage__Stage_Twilight = 2,
        EJackMeosiSlotScenarioStage__Stage_Night = 3,
        EJackMeosiSlotScenarioStage__Stage_Union = 4,
        EJackMeosiSlotScenarioStage__Stage_SP_Traning = 5,
        EJackMeosiSlotScenarioStage__Stage_BonusFixing = 6
    }

    public enum EJackMeosiSlotScenarioSPTraining : byte
    {
        EJackMeosiSlotScenarioSPTraining__Training_False = 0,
        EJackMeosiSlotScenarioSPTraining__Training_True = 1
    }

    class JackDataTableMeosiSlotScenarioPatternBlock : FTableRowBase
    {
	    public EJackMeosiSlotScenarioActNo           ActNo;                                                    // 0x0008(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public int                                                GameNum;                                                  // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public EJackMeosiSlotScenarioHint            Hint;                                                     // 0x0010(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public EJackMeosiSlotScenarioStage           Stage;                                                    // 0x0011(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public EJackMeosiSlotScenarioSPTraining      Training;                                                 // 0x0012(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	}

    class JackDataTableMeosiSlotScenarioPattern : FTableRowBase
    {
	    public int                                                Route;                                                    // 0x0008(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public int                                                Group;                                                    // 0x000C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public int                                                Ratio;                                                    // 0x0010(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public int                                                OrderInPattern;                                           // 0x0014(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public int                                                OrderInGroup;                                             // 0x0018(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
	    public List<bool>                                       HandTorFArray;                                            // 0x0020(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
	    public List<JackDataTableMeosiSlotScenarioPatternBlock> ActStructArray;                                           // 0x0030(0x0010) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance)
    }
}
