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
        [Serializer(Size = 3, Hidden = true)]
        public byte[] Pad;
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
        [Serializer(Size = 1)]
        public byte[] UnknownData06;                                       // 0x007B(0x0001) MISSED OFFSET
        public int LvUp;                                                     // 0x007C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public EJackMeosiSlotMonsterSize Size;                                                     // 0x0080(0x0001) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        [Serializer(Size = 0x5, Hidden = true)]
        public byte[] UnknownData07;  // note: contains 1 unknown byte?                                     // 0x0081(0x0007) MISSED OFFSET
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
        [Serializer(Size = 9)]
        public byte[]                                      UnknownData03;    // maybe contains FName?                                   // 0x0053(0x0005) MISSED OFFSET
    }

    public class JackDataTableCharacterLODBounds : FTableRowBase
    {
        public FName                                       OriginBoneName;                                           // 0x0008(0x0008) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public FVector                                     OriginOffsetInBoneSpace;                                  // 0x0010(0x000C) (Edit, BlueprintVisi, BlueprintReadOnly, DisableEditOnInstance, IsPlainOldData)
        public float                                       Radius;                                                   // 0x001C(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
        public float                                       CastShadowCullingBoundsScale;                             // 0x0020(0x0004) (Edit, BlueprintVisi, BlueprintReadOnly, ZeroConstructor, DisableEditOnInstance, IsPlainOldData)
    };
}
