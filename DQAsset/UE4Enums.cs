using System;
using System.Collections.Generic;
using System.Text;

namespace DQAsset
{
    // Enum Engine.ETextGender
    public enum ETextGender : byte
    {
        ETextGender__Masculine = 0,
        ETextGender__Feminine = 1,
        ETextGender__Neuter = 2,
        ETextGender__ETextGender_MAX = 3
    }


    // Enum Engine.EFormatArgumentType
    public enum EFormatArgumentType : byte
    {
        EFormatArgumentType__Int = 0,
        EFormatArgumentType__UInt = 1,
        EFormatArgumentType__Float = 2,
        EFormatArgumentType__Double = 3,
        EFormatArgumentType__Text = 4,
        EFormatArgumentType__Gender = 5,
        EFormatArgumentType__EFormatArgumentType_MAX = 6
    }


    // Enum Engine.EEndPlayReason
    public enum EEndPlayReason : byte
    {
        EEndPlayReason__Destroyed = 0,
        EEndPlayReason__LevelTransition = 1,
        EEndPlayReason__EndPlayInEditor = 2,
        EEndPlayReason__RemovedFromWorld = 3,
        EEndPlayReason__Quit = 4,
        EEndPlayReason__EEndPlayReason_MAX = 5
    }


    // Enum Engine.ENavPathEvent
    public enum ENavPathEvent : byte
    {
        ENavPathEvent__Cleared = 0,
        ENavPathEvent__NewPath = 1,
        ENavPathEvent__UpdatedDueToGoalMoved = 2,
        ENavPathEvent__UpdatedDueToNavigationChanged = 3,
        ENavPathEvent__Invalidated = 4,
        ENavPathEvent__RePathFailed = 5,
        ENavPathEvent__MetaPathUpdate = 6,
        ENavPathEvent__Custom = 7,
        ENavPathEvent__ENavPathEvent_MAX = 8
    }


    // Enum Engine.ETickingGroup
    public enum ETickingGroup : byte
    {
        TG_PrePhysics = 0,
        TG_StartPhysics = 1,
        TG_DuringPhysics = 2,
        TG_EndPhysics = 3,
        TG_PostPhysics = 4,
        TG_PostUpdateWork = 5,
        TG_LastDemotable = 6,
        TG_NewlySpawned = 7,
        TG_MAX = 8
    }


    // Enum Engine.EComponentCreationMethod
    public enum EComponentCreationMethod : byte
    {
        EComponentCreationMethod__Native = 0,
        EComponentCreationMethod__SimpleConstructionScript = 1,
        EComponentCreationMethod__UserConstructionScript = 2,
        EComponentCreationMethod__Instance = 3,
        EComponentCreationMethod__EComponentCreationMethod_MAX = 4
    }


    // Enum Engine.EPlaneConstraintAxisSetting
    public enum EPlaneConstraintAxisSetting : byte
    {
        EPlaneConstraintAxisSetting__Custom = 0,
        EPlaneConstraintAxisSetting__X = 1,
        EPlaneConstraintAxisSetting__Y = 2,
        EPlaneConstraintAxisSetting__Z = 3,
        EPlaneConstraintAxisSetting__UseGlobalPhysicsSetting = 4,
        EPlaneConstraintAxisSetting__EPlaneConstraintAxisSetting_MAX = 5
    }


    // Enum Engine.EInterpToBehaviourType
    public enum EInterpToBehaviourType : byte
    {
        EInterpToBehaviourType__OneShot = 0,
        EInterpToBehaviourType__OneShot_Reverse = 1,
        EInterpToBehaviourType__Loop_Reset = 2,
        EInterpToBehaviourType__PingPong = 3,
        EInterpToBehaviourType__EInterpToBehaviourType_MAX = 4
    }


    // Enum Engine.EPlatformInterfaceDataType
    public enum EPlatformInterfaceDataType : byte
    {
        PIDT_None = 0,
        PIDT_Int = 1,
        PIDT_Float = 2,
        PIDT_String = 3,
        PIDT_Object = 4,
        PIDT_Custom = 5,
        PIDT_MAX = 6
    }


    // Enum Engine.EMovementMode
    public enum EMovementMode : byte
    {
        MOVE_None = 0,
        MOVE_Walking = 1,
        MOVE_NavWalking = 2,
        MOVE_Falling = 3,
        MOVE_Swimming = 4,
        MOVE_Flying = 5,
        MOVE_Custom = 6,
        MOVE_MAX = 7
    }


    // Enum Engine.ENetworkFailure
    public enum ENetworkFailure : byte
    {
        ENetworkFailure__NetDriverAlreadyExists = 0,
        ENetworkFailure__NetDriverCreateFailure = 1,
        ENetworkFailure__NetDriverListenFailure = 2,
        ENetworkFailure__ConnectionLost = 3,
        ENetworkFailure__ConnectionTimeout = 4,
        ENetworkFailure__FailureReceived = 5,
        ENetworkFailure__OutdatedClient = 6,
        ENetworkFailure__OutdatedServer = 7,
        ENetworkFailure__PendingConnectionFailure = 8,
        ENetworkFailure__NetGuidMismatch = 9,
        ENetworkFailure__NetChecksumMismatch = 10,
        ENetworkFailure__ENetworkFailure_MAX = 11
    }


    // Enum Engine.ETravelFailure
    public enum ETravelFailure : byte
    {
        ETravelFailure__NoLevel = 0,
        ETravelFailure__LoadMapFailure = 1,
        ETravelFailure__InvalidURL = 2,
        ETravelFailure__PackageMissing = 3,
        ETravelFailure__PackageVersion = 4,
        ETravelFailure__NoDownload = 5,
        ETravelFailure__TravelFailure = 6,
        ETravelFailure__CheatCommands = 7,
        ETravelFailure__PendingNetGameCreateFailure = 8,
        ETravelFailure__CloudSaveFailure = 9,
        ETravelFailure__ServerTravelFailure = 10,
        ETravelFailure__ClientTravelFailure = 11,
        ETravelFailure__ETravelFailure_MAX = 12
    }


    // Enum Engine.EScreenOrientation
    public enum EScreenOrientation : byte
    {
        EScreenOrientation__Unknown = 0,
        EScreenOrientation__Portrait = 1,
        EScreenOrientation__PortraitUpsideDown = 2,
        EScreenOrientation__LandscapeLeft = 3,
        EScreenOrientation__LandscapeRight = 4,
        EScreenOrientation__FaceUp = 5,
        EScreenOrientation__FaceDown = 6,
        EScreenOrientation__EScreenOrientation_MAX = 7
    }


    // Enum Engine.EApplicationState
    public enum EApplicationState : byte
    {
        EApplicationState__Unknown = 0,
        EApplicationState__Inactive = 1,
        EApplicationState__Background = 2,
        EApplicationState__Active = 3,
        EApplicationState__EApplicationState_MAX = 4
    }


    // Enum Engine.EObjectTypeQuery
    public enum EObjectTypeQuery : byte
    {
        ObjectTypeQuery1 = 0,
        ObjectTypeQuery2 = 1,
        ObjectTypeQuery3 = 2,
        ObjectTypeQuery4 = 3,
        ObjectTypeQuery5 = 4,
        ObjectTypeQuery6 = 5,
        ObjectTypeQuery7 = 6,
        ObjectTypeQuery8 = 7,
        ObjectTypeQuery9 = 8,
        ObjectTypeQuery10 = 9,
        ObjectTypeQuery11 = 10,
        ObjectTypeQuery12 = 11,
        ObjectTypeQuery13 = 12,
        ObjectTypeQuery14 = 13,
        ObjectTypeQuery15 = 14,
        ObjectTypeQuery16 = 15,
        ObjectTypeQuery17 = 16,
        ObjectTypeQuery18 = 17,
        ObjectTypeQuery19 = 18,
        ObjectTypeQuery20 = 19,
        ObjectTypeQuery21 = 20,
        ObjectTypeQuery22 = 21,
        ObjectTypeQuery23 = 22,
        ObjectTypeQuery24 = 23,
        ObjectTypeQuery25 = 24,
        ObjectTypeQuery26 = 25,
        ObjectTypeQuery27 = 26,
        ObjectTypeQuery28 = 27,
        ObjectTypeQuery29 = 28,
        ObjectTypeQuery30 = 29,
        ObjectTypeQuery31 = 30,
        ObjectTypeQuery32 = 31,
        ObjectTypeQuery_MAX = 32,
        EObjectTypeQuery_MAX = 33
    }


    // Enum Engine.EDrawDebugTrace
    public enum EDrawDebugTrace : byte
    {
        EDrawDebugTrace__None = 0,
        EDrawDebugTrace__ForOneFrame = 1,
        EDrawDebugTrace__ForDuration = 2,
        EDrawDebugTrace__Persistent = 3,
        EDrawDebugTrace__EDrawDebugTrace_MAX = 4
    }


    // Enum Engine.ETraceTypeQuery
    public enum ETraceTypeQuery : byte
    {
        TraceTypeQuery1 = 0,
        TraceTypeQuery2 = 1,
        TraceTypeQuery3 = 2,
        TraceTypeQuery4 = 3,
        TraceTypeQuery5 = 4,
        TraceTypeQuery6 = 5,
        TraceTypeQuery7 = 6,
        TraceTypeQuery8 = 7,
        TraceTypeQuery9 = 8,
        TraceTypeQuery10 = 9,
        TraceTypeQuery11 = 10,
        TraceTypeQuery12 = 11,
        TraceTypeQuery13 = 12,
        TraceTypeQuery14 = 13,
        TraceTypeQuery15 = 14,
        TraceTypeQuery16 = 15,
        TraceTypeQuery17 = 16,
        TraceTypeQuery18 = 17,
        TraceTypeQuery19 = 18,
        TraceTypeQuery20 = 19,
        TraceTypeQuery21 = 20,
        TraceTypeQuery22 = 21,
        TraceTypeQuery23 = 22,
        TraceTypeQuery24 = 23,
        TraceTypeQuery25 = 24,
        TraceTypeQuery26 = 25,
        TraceTypeQuery27 = 26,
        TraceTypeQuery28 = 27,
        TraceTypeQuery29 = 28,
        TraceTypeQuery30 = 29,
        TraceTypeQuery31 = 30,
        TraceTypeQuery32 = 31,
        TraceTypeQuery_MAX = 32,
        ETraceTypeQuery_MAX = 33
    }


    // Enum Engine.EMoveComponentAction
    public enum EMoveComponentAction : byte
    {
        EMoveComponentAction__Move = 0,
        EMoveComponentAction__Stop = 1,
        EMoveComponentAction__Return = 2,
        EMoveComponentAction__EMoveComponentAction_MAX = 3
    }


    // Enum Engine.EQuitPreference
    public enum EQuitPreference : byte
    {
        Quit = 0,
        Background = 1,
        MAX = 2
    }


    // Enum Engine.ENetRole
    public enum ENetRole : byte
    {
        ROLE_None = 0,
        ROLE_SimulatedProxy = 1,
        ROLE_AutonomousProxy = 2,
        ROLE_Authority = 3,
        ROLE_MAX = 4
    }


    // Enum Engine.EAttachLocation
    public enum EAttachLocation : byte
    {
        EAttachLocation__KeepRelativeOffset = 0,
        EAttachLocation__KeepWorldPosition = 1,
        EAttachLocation__SnapToTarget = 2,
        EAttachLocation__SnapToTargetIncludingScale = 3,
        EAttachLocation__EAttachLocation_MAX = 4
    }


    // Enum Engine.EAttachmentRule
    public enum EAttachmentRule : byte
    {
        EAttachmentRule__KeepRelative = 0,
        EAttachmentRule__KeepWorld = 1,
        EAttachmentRule__SnapToTarget = 2,
        EAttachmentRule__EAttachmentRule_MAX = 3
    }


    // Enum Engine.EDetachmentRule
    public enum EDetachmentRule : byte
    {
        EDetachmentRule__KeepRelative = 0,
        EDetachmentRule__KeepWorld = 1,
        EDetachmentRule__EDetachmentRule_MAX = 2
    }


    // Enum Engine.ENetDormancy
    public enum ENetDormancy : byte
    {
        DORM_Never = 0,
        DORM_Awake = 1,
        DORM_DormantAll = 2,
        DORM_DormantPartial = 3,
        DORM_Initial = 4,
        DORN_MAX = 5,
        ENetDormancy_MAX = 6
    }


    // Enum Engine.ESpawnActorCollisionHandlingMethod
    public enum ESpawnActorCollisionHandlingMethod : byte
    {
        ESpawnActorCollisionHandlingMethod__Undefined = 0,
        ESpawnActorCollisionHandlingMethod__AlwaysSpawn = 1,
        ESpawnActorCollisionHandlingMethod__AdjustIfPossibleButAlwaysSpawn = 2,
        ESpawnActorCollisionHandlingMethod__AdjustIfPossibleButDontSpawnIfColliding = 3,
        ESpawnActorCollisionHandlingMethod__DontSpawnIfColliding = 4,
        ESpawnActorCollisionHandlingMethod__ESpawnActorCollisionHandlingMethod_MAX = 5
    }


    // Enum Engine.EAutoReceiveInput
    public enum EAutoReceiveInput : byte
    {
        EAutoReceiveInput__Disabled = 0,
        EAutoReceiveInput__Player0 = 1,
        EAutoReceiveInput__Player1 = 2,
        EAutoReceiveInput__Player2 = 3,
        EAutoReceiveInput__Player3 = 4,
        EAutoReceiveInput__Player4 = 5,
        EAutoReceiveInput__Player5 = 6,
        EAutoReceiveInput__Player6 = 7,
        EAutoReceiveInput__Player7 = 8,
        EAutoReceiveInput__EAutoReceiveInput_MAX = 9
    }


    // Enum Engine.ERotatorQuantization
    public enum ERotatorQuantization : byte
    {
        ERotatorQuantization__ByteComponents = 0,
        ERotatorQuantization__ShortComponents = 1,
        ERotatorQuantization__ERotatorQuantization_MAX = 2
    }


    // Enum Engine.EVectorQuantization
    public enum EVectorQuantization : byte
    {
        EVectorQuantization__RoundWholeNumber = 0,
        EVectorQuantization__RoundOneDecimal = 1,
        EVectorQuantization__RoundTwoDecimals = 2,
        EVectorQuantization__EVectorQuantization_MAX = 3
    }


    // Enum Engine.ETimelineLengthMode
    public enum ETimelineLengthMode : byte
    {
        TL_TimelineLength = 0,
        TL_LastKeyFrame = 1,
        TL_MAX = 2
    }


    // Enum Engine.EAutoPossessAI
    public enum EAutoPossessAI : byte
    {
        EAutoPossessAI__Disabled = 0,
        EAutoPossessAI__PlacedInWorld = 1,
        EAutoPossessAI__Spawned = 2,
        EAutoPossessAI__PlacedInWorldOrSpawned = 3,
        EAutoPossessAI__EAutoPossessAI_MAX = 4
    }


    // Enum Engine.ERootMotionMode
    public enum ERootMotionMode : byte
    {
        ERootMotionMode__NoRootMotionExtraction = 0,
        ERootMotionMode__IgnoreRootMotion = 1,
        ERootMotionMode__RootMotionFromEverything = 2,
        ERootMotionMode__RootMotionFromMontagesOnly = 3,
        ERootMotionMode__ERootMotionMode_MAX = 4
    }


    // Enum Engine.EEasingFunc
    public enum EEasingFunc : byte
    {
        EEasingFunc__Linear = 0,
        EEasingFunc__Step = 1,
        EEasingFunc__SinusoidalIn = 2,
        EEasingFunc__SinusoidalOut = 3,
        EEasingFunc__SinusoidalInOut = 4,
        EEasingFunc__EaseIn = 5,
        EEasingFunc__EaseOut = 6,
        EEasingFunc__EaseInOut = 7,
        EEasingFunc__ExpoIn = 8,
        EEasingFunc__ExpoOut = 9,
        EEasingFunc__ExpoInOut = 10,
        EEasingFunc__CircularIn = 11,
        EEasingFunc__CircularOut = 12,
        EEasingFunc__CircularInOut = 13,
        EEasingFunc__EEasingFunc_MAX = 14
    }


    // Enum Engine.ERelativeTransformSpace
    public enum ERelativeTransformSpace : byte
    {
        RTS_World = 0,
        RTS_Actor = 1,
        RTS_Component = 2,
        RTS_ParentBoneSpace = 3,
        RTS_MAX = 4
    }


    // Enum Engine.EDetailMode
    public enum EDetailMode : byte
    {
        DM_Low = 0,
        DM_Medium = 1,
        DM_High = 2,
        DM_MAX = 3
    }


    // Enum Engine.EComponentMobility
    public enum EComponentMobility : byte
    {
        EComponentMobility__Static = 0,
        EComponentMobility__Stationary = 1,
        EComponentMobility__Movable = 2,
        EComponentMobility__EComponentMobility_MAX = 3
    }


    // Enum Engine.EInputEvent
    public enum EInputEvent : byte
    {
        IE_Pressed = 0,
        IE_Released = 1,
        IE_Repeat = 2,
        IE_DoubleClick = 3,
        IE_Axis = 4,
        IE_MAX = 5
    }


    // Enum Engine.EBlendMode
    public enum EBlendMode : byte
    {
        BLEND_Opaque = 0,
        BLEND_Masked = 1,
        BLEND_Translucent = 2,
        BLEND_Additive = 3,
        BLEND_Modulate = 4,
        BLEND_AlphaComposite = 5,
        BLEND_MAX = 6
    }


    // Enum Engine.EWindowMode
    public enum EWindowMode : byte
    {
        EWindowMode__Fullscreen = 0,
        EWindowMode__WindowedFullscreen = 1,
        EWindowMode__Windowed = 2,
        EWindowMode__EWindowMode_MAX = 3
    }


    // Enum Engine.EAlphaBlendOption
    public enum EAlphaBlendOption : byte
    {
        EAlphaBlendOption__Linear = 0,
        EAlphaBlendOption__Cubic = 1,
        EAlphaBlendOption__HermiteCubic = 2,
        EAlphaBlendOption__Sinusoidal = 3,
        EAlphaBlendOption__QuadraticInOut = 4,
        EAlphaBlendOption__CubicInOut = 5,
        EAlphaBlendOption__QuarticInOut = 6,
        EAlphaBlendOption__QuinticInOut = 7,
        EAlphaBlendOption__CircularIn = 8,
        EAlphaBlendOption__CircularOut = 9,
        EAlphaBlendOption__CircularInOut = 10,
        EAlphaBlendOption__ExpIn = 11,
        EAlphaBlendOption__ExpOut = 12,
        EAlphaBlendOption__ExpInOut = 13,
        EAlphaBlendOption__Custom = 14,
        EAlphaBlendOption__EAlphaBlendOption_MAX = 15
    }


    // Enum Engine.EAnimGroupRole
    public enum EAnimGroupRole : byte
    {
        EAnimGroupRole__CanBeLeader = 0,
        EAnimGroupRole__AlwaysFollower = 1,
        EAnimGroupRole__AlwaysLeader = 2,
        EAnimGroupRole__TransitionLeader = 3,
        EAnimGroupRole__TransitionFollower = 4,
        EAnimGroupRole__EAnimGroupRole_MAX = 5
    }


    // Enum Engine.ERawCurveTrackTypes
    public enum ERawCurveTrackTypes : byte
    {
        ERawCurveTrackTypes__RCT_Float = 0,
        ERawCurveTrackTypes__RCT_Vector = 1,
        ERawCurveTrackTypes__RCT_Transform = 2,
        ERawCurveTrackTypes__RCT_MAX = 3
    }


    // Enum Engine.EAnimAssetCurveFlags
    public enum EAnimAssetCurveFlags : byte
    {
        AACF_DriveMorphTarget_DEPRECATED = 0,
        AACF_DriveAttribute_DEPRECATED = 1,
        AACF_Editable = 2,
        AACF_DriveMaterial_DEPRECATED = 3,
        AACF_Metadata = 4,
        AACF_DriveTrack = 5,
        AACF_Disabled = 6,
        AACF_MAX = 7
    }


    // Enum Engine.AnimationCompressionFormat
    public enum EAnimationCompressionFormat : byte
    {
        ACF_None = 0,
        ACF_Float96NoW = 1,
        ACF_Fixed48NoW = 2,
        ACF_IntervalFixed32NoW = 3,
        ACF_Fixed32NoW = 4,
        ACF_Float32NoW = 5,
        ACF_Identity = 6,
        ACF_MAX = 7
    }


    // Enum Engine.EAdditiveBasePoseType
    public enum EAdditiveBasePoseType : byte
    {
        ABPT_None = 0,
        ABPT_RefPose = 1,
        ABPT_AnimScaled = 2,
        ABPT_AnimFrame = 3,
        ABPT_MAX = 4
    }


    // Enum Engine.ERootMotionRootLock
    public enum ERootMotionRootLock : byte
    {
        ERootMotionRootLock__RefPose = 0,
        ERootMotionRootLock__AnimFirstFrame = 1,
        ERootMotionRootLock__Zero = 2,
        ERootMotionRootLock__ERootMotionRootLock_MAX = 3
    }


    // Enum Engine.EMontagePlayReturnType
    public enum EMontagePlayReturnType : byte
    {
        EMontagePlayReturnType__MontageLength = 0,
        EMontagePlayReturnType__Duration = 1,
        EMontagePlayReturnType__EMontagePlayReturnType_MAX = 2
    }


    // Enum Engine.EAnimCurveType
    public enum EAnimCurveType : byte
    {
        EAnimCurveType__AttributeCurve = 0,
        EAnimCurveType__MaterialCurve = 1,
        EAnimCurveType__MorphTargetCurve = 2,
        EAnimCurveType__MaxAnimCurveType = 3,
        EAnimCurveType__EAnimCurveType_MAX = 4
    }


    // Enum Engine.EDrawDebugItemType
    public enum EDrawDebugItemType : byte
    {
        EDrawDebugItemType__DirectionalArrow = 0,
        EDrawDebugItemType__Sphere = 1,
        EDrawDebugItemType__Line = 2,
        EDrawDebugItemType__OnScreenMessage = 3,
        EDrawDebugItemType__CoordinateSystem = 4,
        EDrawDebugItemType__EDrawDebugItemType_MAX = 5
    }


    // Enum Engine.EMontageSubStepResult
    public enum EMontageSubStepResult : byte
    {
        EMontageSubStepResult__Moved = 0,
        EMontageSubStepResult__NotMoved = 1,
        EMontageSubStepResult__InvalidSection = 2,
        EMontageSubStepResult__InvalidMontage = 3,
        EMontageSubStepResult__EMontageSubStepResult_MAX = 4
    }


    // Enum Engine.EAnimNotifyEventType
    public enum EAnimNotifyEventType : byte
    {
        EAnimNotifyEventType__Begin = 0,
        EAnimNotifyEventType__End = 1,
        EAnimNotifyEventType__EAnimNotifyEventType_MAX = 2
    }


    // Enum Engine.EEvaluatorMode
    public enum EEvaluatorMode : byte
    {
        EEvaluatorMode__EM_Standard = 0,
        EEvaluatorMode__EM_Freeze = 1,
        EEvaluatorMode__EM_DelayedFreeze = 2,
        EEvaluatorMode__EM_MAX = 3
    }


    // Enum Engine.EEvaluatorDataSource
    public enum EEvaluatorDataSource : byte
    {
        EEvaluatorDataSource__EDS_SourcePose = 0,
        EEvaluatorDataSource__EDS_DestinationPose = 1,
        EEvaluatorDataSource__EDS_MAX = 2
    }


    // Enum Engine.EAnimLinkMethod
    public enum EAnimLinkMethod : byte
    {
        EAnimLinkMethod__Absolute = 0,
        EAnimLinkMethod__Relative = 1,
        EAnimLinkMethod__Proportional = 2,
        EAnimLinkMethod__EAnimLinkMethod_MAX = 3
    }


    // Enum Engine.EPostCopyOperation
    public enum EPostCopyOperation : byte
    {
        EPostCopyOperation__None = 0,
        EPostCopyOperation__LogicalNegateBool = 1,
        EPostCopyOperation__EPostCopyOperation_MAX = 2
    }


    // Enum Engine.EPinHidingMode
    public enum EPinHidingMode : byte
    {
        EPinHidingMode__NeverAsPin = 0,
        EPinHidingMode__PinHiddenByDefault = 1,
        EPinHidingMode__PinShownByDefault = 2,
        EPinHidingMode__AlwaysAsPin = 3,
        EPinHidingMode__EPinHidingMode_MAX = 4
    }


    // Enum Engine.AnimPhysCollisionType
    public enum EAnimPhysCollisionType : byte
    {
        AnimPhysCollisionType__CoM = 0,
        AnimPhysCollisionType__CustomSphere = 1,
        AnimPhysCollisionType__InnerSphere = 2,
        AnimPhysCollisionType__OuterSphere = 3,
        AnimPhysCollisionType__AnimPhysCollisionType_MAX = 4
    }


    // Enum Engine.AnimPhysTwistAxis
    public enum EAnimPhysTwistAxis : byte
    {
        AnimPhysTwistAxis__AxisX = 0,
        AnimPhysTwistAxis__AxisY = 1,
        AnimPhysTwistAxis__AxisZ = 2,
        AnimPhysTwistAxis__AnimPhysTwistAxis_MAX = 3
    }


    // Enum Engine.AnimationKeyFormat
    public enum EAnimationKeyFormat : byte
    {
        AKF_ConstantKeyLerp = 0,
        AKF_VariableKeyLerp = 1,
        AKF_PerTrackCompression = 2,
        AKF_MAX = 3
    }


    // Enum Engine.ETypeAdvanceAnim
    public enum ETypeAdvanceAnim : byte
    {
        ETAA_Default = 0,
        ETAA_Finished = 1,
        ETAA_Looped = 2,
        ETAA_MAX = 3
    }


    // Enum Engine.ETransitionBlendMode
    public enum ETransitionBlendMode : byte
    {
        ETransitionBlendMode__TBM_Linear = 0,
        ETransitionBlendMode__TBM_Cubic = 1,
        ETransitionBlendMode__TBM_MAX = 2
    }


    // Enum Engine.EAxisOption
    public enum EAxisOption : byte
    {
        EAxisOption__X = 0,
        EAxisOption__Y = 1,
        EAxisOption__Z = 2,
        EAxisOption__X_Neg = 3,
        EAxisOption__Y_Neg = 4,
        EAxisOption__Z_Neg = 5,
        EAxisOption__Custom = 6,
        EAxisOption__EAxisOption_MAX = 7
    }


    // Enum Engine.EAnimInterpolationType
    public enum EAnimInterpolationType : byte
    {
        EAnimInterpolationType__Linear = 0,
        EAnimInterpolationType__Step = 1,
        EAnimInterpolationType__EAnimInterpolationType_MAX = 2
    }


    // Enum Engine.ECurveBlendOption
    public enum ECurveBlendOption : byte
    {
        ECurveBlendOption__MaxWeight = 0,
        ECurveBlendOption__NormalizeByWeight = 1,
        ECurveBlendOption__BlendByWeight = 2,
        ECurveBlendOption__ECurveBlendOption_MAX = 3
    }


    // Enum Engine.ECopyType
    public enum ECopyType : byte
    {
        ECopyType__MemCopy = 0,
        ECopyType__BoolProperty = 1,
        ECopyType__StructProperty = 2,
        ECopyType__ObjectProperty = 3,
        ECopyType__ECopyType_MAX = 4
    }


    // Enum Engine.ETransitionLogicType
    public enum ETransitionLogicType : byte
    {
        ETransitionLogicType__TLT_StandardBlend = 0,
        ETransitionLogicType__TLT_Custom = 1,
        ETransitionLogicType__TLT_MAX = 2
    }


    // Enum Engine.ENotifyFilterType
    public enum ENotifyFilterType : byte
    {
        ENotifyFilterType__NoFiltering = 0,
        ENotifyFilterType__LOD = 1,
        ENotifyFilterType__ENotifyFilterType_MAX = 2
    }


    // Enum Engine.EMontageNotifyTickType
    public enum EMontageNotifyTickType : byte
    {
        EMontageNotifyTickType__Queued = 0,
        EMontageNotifyTickType__BranchingPoint = 1,
        EMontageNotifyTickType__EMontageNotifyTickType_MAX = 2
    }


    // Enum Engine.EBoneRotationSource
    public enum EBoneRotationSource : byte
    {
        BRS_KeepComponentSpaceRotation = 0,
        BRS_KeepLocalSpaceRotation = 1,
        BRS_CopyFromTarget = 2,
        BRS_MAX = 3
    }


    // Enum Engine.EBoneControlSpace
    public enum EBoneControlSpace : byte
    {
        BCS_WorldSpace = 0,
        BCS_ComponentSpace = 1,
        BCS_ParentBoneSpace = 2,
        BCS_BoneSpace = 3,
        BCS_MAX = 4
    }


    // Enum Engine.EBoneAxis
    public enum EBoneAxis : byte
    {
        BA_X = 0,
        BA_Y = 1,
        BA_Z = 2,
        BA_MAX = 3
    }


    // Enum Engine.EPrimaryAssetCookRule
    public enum EPrimaryAssetCookRule : byte
    {
        EPrimaryAssetCookRule__Unknown = 0,
        EPrimaryAssetCookRule__NeverCook = 1,
        EPrimaryAssetCookRule__DevelopmentCook = 2,
        EPrimaryAssetCookRule__AlwaysCook = 3,
        EPrimaryAssetCookRule__EPrimaryAssetCookRule_MAX = 4
    }


    // Enum Engine.EAttenuationShape
    public enum EAttenuationShape : byte
    {
        EAttenuationShape__Sphere = 0,
        EAttenuationShape__Capsule = 1,
        EAttenuationShape__Box = 2,
        EAttenuationShape__Cone = 3,
        EAttenuationShape__EAttenuationShape_MAX = 4
    }


    // Enum Engine.EAttenuationDistanceModel
    public enum EAttenuationDistanceModel : byte
    {
        EAttenuationDistanceModel__Linear = 0,
        EAttenuationDistanceModel__Logarithmic = 1,
        EAttenuationDistanceModel__Inverse = 2,
        EAttenuationDistanceModel__LogReverse = 3,
        EAttenuationDistanceModel__NaturalSound = 4,
        EAttenuationDistanceModel__Custom = 5,
        EAttenuationDistanceModel__EAttenuationDistanceModel_MAX = 6
    }


    // Enum Engine.ReverbPreset
    public enum EReverbPreset : byte
    {
        REVERB_Default = 0,
        REVERB_Bathroom = 1,
        REVERB_StoneRoom = 2,
        REVERB_Auditorium = 3,
        REVERB_ConcertHall = 4,
        REVERB_Cave = 5,
        REVERB_Hallway = 6,
        REVERB_StoneCorridor = 7,
        REVERB_Alley = 8,
        REVERB_Forest = 9,
        REVERB_City = 10,
        REVERB_Mountains = 11,
        REVERB_Quarry = 12,
        REVERB_Plain = 13,
        REVERB_ParkingLot = 14,
        REVERB_SewerPipe = 15,
        REVERB_Underwater = 16,
        REVERB_SmallRoom = 17,
        REVERB_MediumRoom = 18,
        REVERB_LargeRoom = 19,
        REVERB_MediumHall = 20,
        REVERB_LargeHall = 21,
        REVERB_Plate = 22,
        REVERB_MAX = 23
    }


    // Enum Engine.EAdditiveAnimationType
    public enum EAdditiveAnimationType : byte
    {
        AAT_None = 0,
        AAT_LocalSpaceBase = 1,
        AAT_RotationOffsetMeshSpace = 2,
        AAT_LocalLocalSpaceBase = 3,
        AAT_MAX = 4
    }


    // Enum Engine.EBlendableLocation
    public enum EBlendableLocation : byte
    {
        BL_AfterTonemapping = 0,
        BL_BeforeTonemapping = 1,
        BL_BeforeTranslucency = 2,
        BL_ReplacingTonemapper = 3,
        BL_MAX = 4
    }


    // Enum Engine.EBlendSpaceAxis
    public enum EBlendSpaceAxis : byte
    {
        BSA_None = 0,
        BSA_X = 1,
        BSA_Y = 2,
        BSA_Max = 3
    }


    // Enum Engine.EBlueprintNativizationFlag
    public enum EBlueprintNativizationFlag : byte
    {
        EBlueprintNativizationFlag__Disabled = 0,
        EBlueprintNativizationFlag__Dependency = 1,
        EBlueprintNativizationFlag__ExplicitlyEnabled = 2,
        EBlueprintNativizationFlag__EBlueprintNativizationFlag_MAX = 3
    }


    // Enum Engine.EBlueprintCompileMode
    public enum EBlueprintCompileMode : byte
    {
        EBlueprintCompileMode__Default = 0,
        EBlueprintCompileMode__Development = 1,
        EBlueprintCompileMode__FinalRelease = 2,
        EBlueprintCompileMode__EBlueprintCompileMode_MAX = 3
    }


    // Enum Engine.EBlueprintType
    public enum EBlueprintType : byte
    {
        BPTYPE_Normal = 0,
        BPTYPE_Const = 1,
        BPTYPE_MacroLibrary = 2,
        BPTYPE_Interface = 3,
        BPTYPE_LevelScript = 4,
        BPTYPE_FunctionLibrary = 5,
        BPTYPE_MAX = 6
    }


    // Enum Engine.ENotifyTriggerMode
    public enum ENotifyTriggerMode : byte
    {
        ENotifyTriggerMode__AllAnimations = 0,
        ENotifyTriggerMode__HighestWeightedAnimation = 1,
        ENotifyTriggerMode__None = 2,
        ENotifyTriggerMode__ENotifyTriggerMode_MAX = 3
    }


    // Enum Engine.EDynamicActorScene
    public enum EDynamicActorScene : byte
    {
        EDynamicActorScene__Default = 0,
        EDynamicActorScene__UseSyncScene = 1,
        EDynamicActorScene__UseAsyncScene = 2,
        EDynamicActorScene__EDynamicActorScene_MAX = 3
    }


    // Enum Engine.EDOFMode
    public enum EDOFMode : byte
    {
        EDOFMode__Default = 0,
        EDOFMode__SixDOF = 1,
        EDOFMode__YZPlane = 2,
        EDOFMode__XZPlane = 3,
        EDOFMode__XYPlane = 4,
        EDOFMode__CustomPlane = 5,
        EDOFMode__None = 6,
        EDOFMode__EDOFMode_MAX = 7
    }


    // Enum Engine.EBodyCollisionResponse
    public enum EBodyCollisionResponse : byte
    {
        EBodyCollisionResponse__BodyCollision_Enabled = 0,
        EBodyCollisionResponse__BodyCollision_Disabled = 1,
        EBodyCollisionResponse__BodyCollision_EnabledOnlyOwnObjectType = 2,
        EBodyCollisionResponse__BodyCollision_MAX = 3
    }


    // Enum Engine.EPhysicsType
    public enum EPhysicsType : byte
    {
        PhysType_Default = 0,
        PhysType_Kinematic = 1,
        PhysType_Simulated = 2,
        PhysType_MAX = 3
    }


    // Enum Engine.ECollisionTraceFlag
    public enum ECollisionTraceFlag : byte
    {
        CTF_UseDefault = 0,
        CTF_UseSimpleAndComplex = 1,
        CTF_UseSimpleAsComplex = 2,
        CTF_UseComplexAsSimple = 3,
        CTF_MAX = 4
    }


    // Enum Engine.EBrushType
    public enum EBrushType : byte
    {
        Brush_Default = 0,
        Brush_Add = 1,
        Brush_Subtract = 2,
        Brush_MAX = 3
    }


    // Enum Engine.ECsgOper
    public enum ECsgOper : byte
    {
        CSG_Active = 0,
        CSG_Add = 1,
        CSG_Subtract = 2,
        CSG_Intersect = 3,
        CSG_Deintersect = 4,
        CSG_None = 5,
        CSG_MAX = 6
    }


    // Enum Engine.EInitialOscillatorOffset
    public enum EInitialOscillatorOffset : byte
    {
        EOO_OffsetRandom = 0,
        EOO_OffsetZero = 1,
        EOO_MAX = 2
    }


    // Enum Engine.ECameraAlphaBlendMode
    public enum ECameraAlphaBlendMode : byte
    {
        ECameraAlphaBlendMode__CABM_Linear = 0,
        ECameraAlphaBlendMode__CABM_Cubic = 1,
        ECameraAlphaBlendMode__CABM_MAX = 2
    }


    // Enum Engine.ECameraAnimPlaySpace
    public enum ECameraAnimPlaySpace : byte
    {
        ECameraAnimPlaySpace__CameraLocal = 0,
        ECameraAnimPlaySpace__World = 1,
        ECameraAnimPlaySpace__UserDefined = 2,
        ECameraAnimPlaySpace__ECameraAnimPlaySpace_MAX = 3
    }


    // Enum Engine.ECameraProjectionMode
    public enum ECameraProjectionMode : byte
    {
        ECameraProjectionMode__Perspective = 0,
        ECameraProjectionMode__Orthographic = 1,
        ECameraProjectionMode__ECameraProjectionMode_MAX = 2
    }


    // Enum Engine.ECloudStorageDelegate
    public enum ECloudStorageDelegate : byte
    {
        CSD_KeyValueReadComplete = 0,
        CSD_KeyValueWriteComplete = 1,
        CSD_ValueChanged = 2,
        CSD_DocumentQueryComplete = 3,
        CSD_DocumentReadComplete = 4,
        CSD_DocumentWriteComplete = 5,
        CSD_DocumentConflictDetected = 6,
        CSD_MAX = 7
    }


    // Enum Engine.EAngularDriveMode
    public enum EAngularDriveMode : byte
    {
        EAngularDriveMode__SLERP = 0,
        EAngularDriveMode__TwistAndSwing = 1,
        EAngularDriveMode__EAngularDriveMode_MAX = 2
    }


    // Enum Engine.ELinearConstraintMotion
    public enum ELinearConstraintMotion : byte
    {
        LCM_Free = 0,
        LCM_Limited = 1,
        LCM_Locked = 2,
        LCM_MAX = 3
    }


    // Enum Engine.EEvaluateCurveTableResult
    public enum EEvaluateCurveTableResult : byte
    {
        EEvaluateCurveTableResult__RowFound = 0,
        EEvaluateCurveTableResult__RowNotFound = 1,
        EEvaluateCurveTableResult__EEvaluateCurveTableResult_MAX = 2
    }


    // Enum Engine.EGrammaticalNumber
    public enum EGrammaticalNumber : byte
    {
        EGrammaticalNumber__Singular = 0,
        EGrammaticalNumber__Plural = 1,
        EGrammaticalNumber__EGrammaticalNumber_MAX = 2
    }


    // Enum Engine.EGrammaticalGender
    public enum EGrammaticalGender : byte
    {
        EGrammaticalGender__Neuter = 0,
        EGrammaticalGender__Masculine = 1,
        EGrammaticalGender__Feminine = 2,
        EGrammaticalGender__Mixed = 3,
        EGrammaticalGender__EGrammaticalGender_MAX = 4
    }


    // Enum Engine.DistributionParamMode
    public enum EDistributionParamMode : byte
    {
        DPM_Normal = 0,
        DPM_Abs = 1,
        DPM_Direct = 2,
        DPM_MAX = 3
    }


    // Enum Engine.EDistributionVectorMirrorFlags
    public enum EDistributionVectorMirrorFlags : byte
    {
        EDVMF_Same = 0,
        EDVMF_Different = 1,
        EDVMF_Mirror = 2,
        EDVMF_MAX = 3
    }


    // Enum Engine.EDistributionVectorLockFlags
    public enum EDistributionVectorLockFlags : byte
    {
        EDVLF_None = 0,
        EDVLF_XY = 1,
        EDVLF_XZ = 2,
        EDVLF_YZ = 3,
        EDVLF_XYZ = 4,
        EDVLF_MAX = 5
    }


    // Enum Engine.ENodeEnabledState
    public enum ENodeEnabledState : byte
    {
        ENodeEnabledState__Enabled = 0,
        ENodeEnabledState__Disabled = 1,
        ENodeEnabledState__DevelopmentOnly = 2,
        ENodeEnabledState__ENodeEnabledState_MAX = 3
    }


    // Enum Engine.ENodeAdvancedPins
    public enum ENodeAdvancedPins : byte
    {
        ENodeAdvancedPins__NoPins = 0,
        ENodeAdvancedPins__Shown = 1,
        ENodeAdvancedPins__Hidden = 2,
        ENodeAdvancedPins__ENodeAdvancedPins_MAX = 3
    }


    // Enum Engine.ENodeTitleType
    public enum ENodeTitleType : byte
    {
        ENodeTitleType__FullTitle = 0,
        ENodeTitleType__ListView = 1,
        ENodeTitleType__EditableTitle = 2,
        ENodeTitleType__MenuTitle = 3,
        ENodeTitleType__MAX_TitleTypes = 4,
        ENodeTitleType__ENodeTitleType_MAX = 5
    }


    // Enum Engine.EPinContainerType
    public enum EPinContainerType : byte
    {
        EPinContainerType__None = 0,
        EPinContainerType__Array = 1,
        EPinContainerType__Set = 2,
        EPinContainerType__Map = 3,
        EPinContainerType__EPinContainerType_MAX = 4
    }


    // Enum Engine.EEdGraphPinDirection
    public enum EEdGraphPinDirection : byte
    {
        EGPD_Input = 0,
        EGPD_Output = 1,
        EGPD_MAX = 2
    }


    // Enum Engine.EBlueprintPinStyleType
    public enum EBlueprintPinStyleType : byte
    {
        BPST_Original = 0,
        BPST_VariantA = 1,
        BPST_MAX = 2
    }


    // Enum Engine.ECanCreateConnectionResponse
    public enum ECanCreateConnectionResponse : byte
    {
        CONNECT_RESPONSE_MAKE = 0,
        CONNECT_RESPONSE_DISALLOW = 1,
        CONNECT_RESPONSE_BREAK_OTHERS_A = 2,
        CONNECT_RESPONSE_BREAK_OTHERS_B = 3,
        CONNECT_RESPONSE_BREAK_OTHERS_AB = 4,
        CONNECT_RESPONSE_MAKE_WITH_CONVERSION_NODE = 5,
        CONNECT_RESPONSE_MAX = 6
    }


    // Enum Engine.EGraphType
    public enum EGraphType : byte
    {
        GT_Function = 0,
        GT_Ubergraph = 1,
        GT_Macro = 2,
        GT_Animation = 3,
        GT_StateMachine = 4,
        GT_MAX = 5
    }


    // Enum Engine.EConsoleType
    public enum EConsoleType : byte
    {
        CONSOLE_Any = 0,
        CONSOLE_Mobile = 1,
        CONSOLE_MAX = 2
    }


    // Enum Engine.ETransitionType
    public enum ETransitionType : byte
    {
        TT_None = 0,
        TT_Paused = 1,
        TT_Loading = 2,
        TT_Saving = 3,
        TT_Connecting = 4,
        TT_Precaching = 5,
        TT_WaitingToConnect = 6,
        TT_MAX = 7
    }


    // Enum Engine.EFullyLoadPackageType
    public enum EFullyLoadPackageType : byte
    {
        FULLYLOAD_Map = 0,
        FULLYLOAD_Game_PreLoadClass = 1,
        FULLYLOAD_Game_PostLoadClass = 2,
        FULLYLOAD_Always = 3,
        FULLYLOAD_Mutator = 4,
        FULLYLOAD_MAX = 5
    }


    // Enum Engine.EViewModeIndex
    public enum EViewModeIndex : byte
    {
        VMI_BrushWireframe = 0,
        VMI_Wireframe = 1,
        VMI_Unlit = 2,
        VMI_Lit = 3,
        VMI_Lit_DetailLighting = 4,
        VMI_LightingOnly = 5,
        VMI_LightComplexity = 6,
        VMI_ShaderComplexity = 7,
        VMI_LightmapDensity = 8,
        VMI_LitLightmapDensity = 9,
        VMI_ReflectionOverride = 10,
        VMI_VisualizeBuffer = 11,
        VMI_StationaryLightOverlap = 12,
        VMI_CollisionPawn = 13,
        VMI_CollisionVisibility = 14,
        VMI_LODColoration = 15,
        VMI_QuadOverdraw = 16,
        VMI_PrimitiveDistanceAccuracy = 17,
        VMI_MeshUVDensityAccuracy = 18,
        VMI_ShaderComplexityWithQuadOverdraw = 19,
        VMI_HLODColoration = 20,
        VMI_GroupLODColoration = 21,
        VMI_MaterialTextureScaleAccuracy = 22,
        VMI_RequiredTextureResolution = 23,
        VMI_Max = 24,
        VMI_Unknown = 25
    }


    // Enum Engine.EDemoPlayFailure
    public enum EDemoPlayFailure : byte
    {
        EDemoPlayFailure__Generic = 0,
        EDemoPlayFailure__DemoNotFound = 1,
        EDemoPlayFailure__Corrupt = 2,
        EDemoPlayFailure__InvalidVersion = 3,
        EDemoPlayFailure__EDemoPlayFailure_MAX = 4
    }


    // Enum Engine.ETravelType
    public enum ETravelType : byte
    {
        TRAVEL_Absolute = 0,
        TRAVEL_Partial = 1,
        TRAVEL_Relative = 2,
        TRAVEL_MAX = 3
    }


    // Enum Engine.ENetworkLagState
    public enum ENetworkLagState : byte
    {
        ENetworkLagState__NotLagging = 0,
        ENetworkLagState__Lagging = 1,
        ENetworkLagState__ENetworkLagState_MAX = 2
    }


    // Enum Engine.EMouseLockMode
    public enum EMouseLockMode : byte
    {
        EMouseLockMode__DoNotLock = 0,
        EMouseLockMode__LockOnCapture = 1,
        EMouseLockMode__LockAlways = 2,
        EMouseLockMode__EMouseLockMode_MAX = 3
    }


    // Enum Engine.EMouseCaptureMode
    public enum EMouseCaptureMode : byte
    {
        EMouseCaptureMode__NoCapture = 0,
        EMouseCaptureMode__CapturePermanently = 1,
        EMouseCaptureMode__CapturePermanently_IncludingInitialMouseDown = 2,
        EMouseCaptureMode__CaptureDuringMouseDown = 3,
        EMouseCaptureMode__CaptureDuringRightMouseDown = 4,
        EMouseCaptureMode__EMouseCaptureMode_MAX = 5
    }


    // Enum Engine.EMeshBufferAccess
    public enum EMeshBufferAccess : byte
    {
        EMeshBufferAccess__Default = 0,
        EMeshBufferAccess__ForceCPUAndGPU = 1,
        EMeshBufferAccess__EMeshBufferAccess_MAX = 2
    }


    // Enum Engine.EConstraintFrame
    public enum EConstraintFrame : byte
    {
        EConstraintFrame__Frame1 = 0,
        EConstraintFrame__Frame2 = 1,
        EConstraintFrame__EConstraintFrame_MAX = 2
    }


    // Enum Engine.EAngularConstraintMotion
    public enum EAngularConstraintMotion : byte
    {
        ACM_Free = 0,
        ACM_Limited = 1,
        ACM_Locked = 2,
        ACM_MAX = 3
    }


    // Enum Engine.EComponentSocketType
    public enum EComponentSocketType : byte
    {
        EComponentSocketType__Invalid = 0,
        EComponentSocketType__Bone = 1,
        EComponentSocketType__Socket = 2,
        EComponentSocketType__EComponentSocketType_MAX = 3
    }


    // Enum Engine.EPhysicalSurface
    public enum EPhysicalSurface : byte
    {
        SurfaceType_Default = 0,
        SurfaceType1 = 1,
        SurfaceType2 = 2,
        SurfaceType3 = 3,
        SurfaceType4 = 4,
        SurfaceType5 = 5,
        SurfaceType6 = 6,
        SurfaceType7 = 7,
        SurfaceType8 = 8,
        SurfaceType9 = 9,
        SurfaceType10 = 10,
        SurfaceType11 = 11,
        SurfaceType12 = 12,
        SurfaceType13 = 13,
        SurfaceType14 = 14,
        SurfaceType15 = 15,
        SurfaceType16 = 16,
        SurfaceType17 = 17,
        SurfaceType18 = 18,
        SurfaceType19 = 19,
        SurfaceType20 = 20,
        SurfaceType21 = 21,
        SurfaceType22 = 22,
        SurfaceType23 = 23,
        SurfaceType24 = 24,
        SurfaceType25 = 25,
        SurfaceType26 = 26,
        SurfaceType27 = 27,
        SurfaceType28 = 28,
        SurfaceType29 = 29,
        SurfaceType30 = 30,
        SurfaceType31 = 31,
        SurfaceType32 = 32,
        SurfaceType33 = 33,
        SurfaceType34 = 34,
        SurfaceType35 = 35,
        SurfaceType36 = 36,
        SurfaceType37 = 37,
        SurfaceType38 = 38,
        SurfaceType39 = 39,
        SurfaceType40 = 40,
        SurfaceType41 = 41,
        SurfaceType42 = 42,
        SurfaceType43 = 43,
        SurfaceType44 = 44,
        SurfaceType45 = 45,
        SurfaceType46 = 46,
        SurfaceType47 = 47,
        SurfaceType48 = 48,
        SurfaceType49 = 49,
        SurfaceType50 = 50,
        SurfaceType51 = 51,
        SurfaceType52 = 52,
        SurfaceType53 = 53,
        SurfaceType54 = 54,
        SurfaceType55 = 55,
        SurfaceType56 = 56,
        SurfaceType57 = 57,
        SurfaceType58 = 58,
        SurfaceType59 = 59,
        SurfaceType60 = 60,
        SurfaceType61 = 61,
        SurfaceType62 = 62,
        SurfaceType_Max = 63,
        EPhysicalSurface_MAX = 64
    }


    // Enum Engine.EWalkableSlopeBehavior
    public enum EWalkableSlopeBehavior : byte
    {
        WalkableSlope_Default = 0,
        WalkableSlope_Increase = 1,
        WalkableSlope_Decrease = 2,
        WalkableSlope_Unwalkable = 3,
        WalkableSlope_Max = 4
    }


    // Enum Engine.EUpdateRateShiftBucket
    public enum EUpdateRateShiftBucket : byte
    {
        EUpdateRateShiftBucket__ShiftBucket0 = 0,
        EUpdateRateShiftBucket__ShiftBucket1 = 1,
        EUpdateRateShiftBucket__ShiftBucket2 = 2,
        EUpdateRateShiftBucket__ShiftBucket3 = 3,
        EUpdateRateShiftBucket__ShiftBucket4 = 4,
        EUpdateRateShiftBucket__ShiftBucket5 = 5,
        EUpdateRateShiftBucket__ShiftBucketMax = 6,
        EUpdateRateShiftBucket__EUpdateRateShiftBucket_MAX = 7
    }


    // Enum Engine.EShadowMapFlags
    public enum EShadowMapFlags : byte
    {
        SMF_None = 0,
        SMF_Streamed = 1,
        SMF_MAX = 2
    }


    // Enum Engine.ELightMapPaddingType
    public enum ELightMapPaddingType : byte
    {
        LMPT_NormalPadding = 0,
        LMPT_PrePadding = 1,
        LMPT_NoPadding = 2,
        LMPT_MAX = 3
    }


    // Enum Engine.ECollisionEnabled
    public enum ECollisionEnabled : byte
    {
        ECollisionEnabled__NoCollision = 0,
        ECollisionEnabled__QueryOnly = 1,
        ECollisionEnabled__PhysicsOnly = 2,
        ECollisionEnabled__QueryAndPhysics = 3,
        ECollisionEnabled__ECollisionEnabled_MAX = 4
    }


    // Enum Engine.ETimelineSigType
    public enum ETimelineSigType : byte
    {
        ETS_EventSignature = 0,
        ETS_FloatSignature = 1,
        ETS_VectorSignature = 2,
        ETS_LinearColorSignature = 3,
        ETS_InvalidSignature = 4,
        ETS_MAX = 5
    }


    // Enum Engine.ESleepFamily
    public enum ESleepFamily : byte
    {
        ESleepFamily__Normal = 0,
        ESleepFamily__Sensitive = 1,
        ESleepFamily__Custom = 2,
        ESleepFamily__ESleepFamily_MAX = 3
    }


    // Enum Engine.ERadialImpulseFalloff
    public enum ERadialImpulseFalloff : byte
    {
        RIF_Constant = 0,
        RIF_Linear = 1,
        RIF_MAX = 2
    }


    // Enum Engine.EInputConsumeOptions
    public enum EInputConsumeOptions : byte
    {
        ICO_ConsumeAll = 0,
        ICO_ConsumeBoundKeys = 1,
        ICO_ConsumeNone = 2,
        ICO_MAX = 3
    }


    // Enum Engine.EFilterInterpolationType
    public enum EFilterInterpolationType : byte
    {
        BSIT_Average = 0,
        BSIT_Linear = 1,
        BSIT_Cubic = 2,
        BSIT_MAX = 3
    }


    // Enum Engine.ECollisionResponse
    public enum ECollisionResponse : byte
    {
        ECR_Ignore = 0,
        ECR_Overlap = 1,
        ECR_Block = 2,
        ECR_MAX = 3
    }


    // Enum Engine.EPhysicsSceneType
    public enum EPhysicsSceneType : byte
    {
        PST_Sync = 0,
        PST_Cloth = 1,
        PST_Async = 2,
        PST_MAX = 3
    }


    // Enum Engine.EOverlapFilterOption
    public enum EOverlapFilterOption : byte
    {
        OverlapFilter_All = 0,
        OverlapFilter_DynamicOnly = 1,
        OverlapFilter_StaticOnly = 2,
        OverlapFilter_MAX = 3
    }


    // Enum Engine.ECollisionChannel
    public enum ECollisionChannel : byte
    {
        ECC_WorldStatic = 0,
        ECC_WorldDynamic = 1,
        ECC_Pawn = 2,
        ECC_Visibility = 3,
        ECC_Camera = 4,
        ECC_PhysicsBody = 5,
        ECC_Vehicle = 6,
        ECC_Destructible = 7,
        ECC_EngineTraceChannel1 = 8,
        ECC_EngineTraceChannel2 = 9,
        ECC_EngineTraceChannel3 = 10,
        ECC_EngineTraceChannel4 = 11,
        ECC_EngineTraceChannel5 = 12,
        ECC_EngineTraceChannel6 = 13,
        ECC_GameTraceChannel1 = 14,
        ECC_GameTraceChannel2 = 15,
        ECC_GameTraceChannel3 = 16,
        ECC_GameTraceChannel4 = 17,
        ECC_GameTraceChannel5 = 18,
        ECC_GameTraceChannel6 = 19,
        ECC_GameTraceChannel7 = 20,
        ECC_GameTraceChannel8 = 21,
        ECC_GameTraceChannel9 = 22,
        ECC_GameTraceChannel10 = 23,
        ECC_GameTraceChannel11 = 24,
        ECC_GameTraceChannel12 = 25,
        ECC_GameTraceChannel13 = 26,
        ECC_GameTraceChannel14 = 27,
        ECC_GameTraceChannel15 = 28,
        ECC_GameTraceChannel16 = 29,
        ECC_GameTraceChannel17 = 30,
        ECC_GameTraceChannel18 = 31,
        ECC_OverlapAll_Deprecated = 32,
        ECC_MAX = 33
    }


    // Enum Engine.ENetworkSmoothingMode
    public enum ENetworkSmoothingMode : byte
    {
        ENetworkSmoothingMode__Disabled = 0,
        ENetworkSmoothingMode__Linear = 1,
        ENetworkSmoothingMode__Exponential = 2,
        ENetworkSmoothingMode__Replay = 3,
        ENetworkSmoothingMode__ENetworkSmoothingMode_MAX = 4
    }


    // Enum Engine.EBlueprintStatus
    public enum EBlueprintStatus : byte
    {
        BS_Unknown = 0,
        BS_Dirty = 1,
        BS_Error = 2,
        BS_UpToDate = 3,
        BS_BeingCreated = 4,
        BS_UpToDateWithWarnings = 5,
        BS_MAX = 6
    }


    // Enum Engine.ETriangleSortAxis
    public enum ETriangleSortAxis : byte
    {
        TSA_X_Axis = 0,
        TSA_Y_Axis = 1,
        TSA_Z_Axis = 2,
        TSA_MAX = 3
    }


    // Enum Engine.ETriangleSortOption
    public enum ETriangleSortOption : byte
    {
        TRISORT_None = 0,
        TRISORT_CenterRadialDistance = 1,
        TRISORT_Random = 2,
        TRISORT_MergeContiguous = 3,
        TRISORT_Custom = 4,
        TRISORT_CustomLeftRight = 5,
        TRISORT_MAX = 6
    }


    // Enum Engine.ELightingBuildQuality
    public enum ELightingBuildQuality : byte
    {
        Quality_Preview = 0,
        Quality_Medium = 1,
        Quality_High = 2,
        Quality_Production = 3,
        Quality_MAX = 4
    }


    // Enum Engine.EMaterialSamplerType
    public enum EMaterialSamplerType : byte
    {
        SAMPLERTYPE_Color = 0,
        SAMPLERTYPE_Grayscale = 1,
        SAMPLERTYPE_Alpha = 2,
        SAMPLERTYPE_Normal = 3,
        SAMPLERTYPE_Masks = 4,
        SAMPLERTYPE_DistanceFieldFont = 5,
        SAMPLERTYPE_LinearColor = 6,
        SAMPLERTYPE_LinearGrayscale = 7,
        SAMPLERTYPE_External = 8,
        SAMPLERTYPE_MAX = 9
    }


    // Enum Engine.EMaterialTessellationMode
    public enum EMaterialTessellationMode : byte
    {
        MTM_NoTessellation = 0,
        MTM_FlatTessellation = 1,
        MTM_PNTriangles = 2,
        MTM_MAX = 3
    }


    // Enum Engine.EMaterialShadingModel
    public enum EMaterialShadingModel : byte
    {
        MSM_Unlit = 0,
        MSM_DefaultLit = 1,
        MSM_Subsurface = 2,
        MSM_PreintegratedSkin = 3,
        MSM_ClearCoat = 4,
        MSM_SubsurfaceProfile = 5,
        MSM_TwoSidedFoliage = 6,
        MSM_Hair = 7,
        MSM_Cloth = 8,
        MSM_Eye = 9,
        MSM_MAX = 10
    }


    // Enum Engine.EParticleCollisionMode
    public enum EParticleCollisionMode : byte
    {
        EParticleCollisionMode__SceneDepth = 0,
        EParticleCollisionMode__DistanceField = 1,
        EParticleCollisionMode__EParticleCollisionMode_MAX = 2
    }


    // Enum Engine.ETrailWidthMode
    public enum ETrailWidthMode : byte
    {
        ETrailWidthMode_FromCentre = 0,
        ETrailWidthMode_FromFirst = 1,
        ETrailWidthMode_FromSecond = 2,
        ETrailWidthMode_MAX = 3
    }


    // Enum Engine.EGBufferFormat
    public enum EGBufferFormat : byte
    {
        EGBufferFormat__Force8BitsPerChannel = 0,
        EGBufferFormat__Default = 1,
        EGBufferFormat__HighPrecisionNormals = 2,
        EGBufferFormat__Force16BitsPerChannel = 3,
        EGBufferFormat__EGBufferFormat_MAX = 4
    }


    // Enum Engine.ESceneCaptureCompositeMode
    public enum ESceneCaptureCompositeMode : byte
    {
        SCCM_Overwrite = 0,
        SCCM_Additive = 1,
        SCCM_Composite = 2,
        SCCM_MAX = 3
    }


    // Enum Engine.ESceneCaptureSource
    public enum ESceneCaptureSource : byte
    {
        SCS_SceneColorHDR = 0,
        SCS_SceneColorHDRNoAlpha = 1,
        SCS_FinalColorLDR = 2,
        SCS_SceneColorSceneDepth = 3,
        SCS_SceneDepth = 4,
        SCS_DeviceDepth = 5,
        SCS_Normal = 6,
        SCS_BaseColor = 7,
        SCS_MAX = 8
    }


    // Enum Engine.ETranslucentSortPolicy
    public enum ETranslucentSortPolicy : byte
    {
        ETranslucentSortPolicy__SortByDistance = 0,
        ETranslucentSortPolicy__SortByProjectedZ = 1,
        ETranslucentSortPolicy__SortAlongAxis = 2,
        ETranslucentSortPolicy__ETranslucentSortPolicy_MAX = 3
    }


    // Enum Engine.ERefractionMode
    public enum ERefractionMode : byte
    {
        RM_IndexOfRefraction = 0,
        RM_PixelNormalOffset = 1,
        RM_MAX = 2
    }


    // Enum Engine.ETranslucencyLightingMode
    public enum ETranslucencyLightingMode : byte
    {
        TLM_VolumetricNonDirectional = 0,
        TLM_VolumetricDirectional = 1,
        TLM_VolumetricPerVertexNonDirectional = 2,
        TLM_VolumetricPerVertexDirectional = 3,
        TLM_Surface = 4,
        TLM_SurfacePerPixelLighting = 5,
        TLM_SingleNonDirectional = 6,
        TLM_SingleDirectional = 7,
        TLM_SurfaceSingle = 8,
        TLM_MAX = 9
    }


    // Enum Engine.ESamplerSourceMode
    public enum ESamplerSourceMode : byte
    {
        SSM_FromTextureAsset = 0,
        SSM_Wrap_WorldGroupSettings = 1,
        SSM_Clamp_WorldGroupSettings = 2,
        SSM_MAX = 3
    }


    // Enum Engine.EOcclusionCombineMode
    public enum EOcclusionCombineMode : byte
    {
        OCM_Minimum = 0,
        OCM_Multiply = 1,
        OCM_MAX = 2
    }


    // Enum Engine.EIndirectLightingCacheQuality
    public enum EIndirectLightingCacheQuality : byte
    {
        ILCQ_Off = 0,
        ILCQ_Point = 1,
        ILCQ_Volume = 2,
        ILCQ_MAX = 3
    }


    // Enum Engine.ESceneDepthPriorityGroup
    public enum ESceneDepthPriorityGroup : byte
    {
        SDPG_World = 0,
        SDPG_Foreground = 1,
        SDPG_MAX = 2
    }


    // Enum Engine.EActorMetricsType
    public enum EActorMetricsType : byte
    {
        METRICS_VERTS = 0,
        METRICS_TRIS = 1,
        METRICS_SECTIONS = 2,
        METRICS_MAX = 3
    }


    // Enum Engine.EAspectRatioAxisConstraint
    public enum EAspectRatioAxisConstraint : byte
    {
        AspectRatio_MaintainYFOV = 0,
        AspectRatio_MaintainXFOV = 1,
        AspectRatio_MajorAxisFOV = 2,
        AspectRatio_MAX = 3
    }


    // Enum Engine.EFontCacheType
    public enum EFontCacheType : byte
    {
        EFontCacheType__Offline = 0,
        EFontCacheType__Runtime = 1,
        EFontCacheType__EFontCacheType_MAX = 2
    }


    // Enum Engine.EFontImportCharacterSet
    public enum EFontImportCharacterSet : byte
    {
        FontICS_Default = 0,
        FontICS_Ansi = 1,
        FontICS_Symbol = 2,
        FontICS_MAX = 3
    }


    // Enum Engine.EStandbyType
    public enum EStandbyType : byte
    {
        STDBY_Rx = 0,
        STDBY_Tx = 1,
        STDBY_BadPing = 2,
        STDBY_MAX = 3
    }


    // Enum Engine.ESuggestProjVelocityTraceOption
    public enum ESuggestProjVelocityTraceOption : byte
    {
        ESuggestProjVelocityTraceOption__DoNotTrace = 0,
        ESuggestProjVelocityTraceOption__TraceFullPath = 1,
        ESuggestProjVelocityTraceOption__OnlyTraceWhileAscending = 2,
        ESuggestProjVelocityTraceOption__ESuggestProjVelocityTraceOption_MAX = 3
    }


    // Enum Engine.EImportanceWeight
    public enum EImportanceWeight : byte
    {
        EImportanceWeight__Luminance = 0,
        EImportanceWeight__Red = 1,
        EImportanceWeight__Green = 2,
        EImportanceWeight__Blue = 3,
        EImportanceWeight__Alpha = 4,
        EImportanceWeight__EImportanceWeight_MAX = 5
    }


    // Enum Engine.EAdManagerDelegate
    public enum EAdManagerDelegate : byte
    {
        AMD_ClickedBanner = 0,
        AMD_UserClosedAd = 1,
        AMD_MAX = 2
    }


    // Enum Engine.EControllerAnalogStick
    public enum EControllerAnalogStick : byte
    {
        EControllerAnalogStick__CAS_LeftStick = 0,
        EControllerAnalogStick__CAS_RightStick = 1,
        EControllerAnalogStick__CAS_MAX = 2
    }


    // Enum Engine.EMatineeTrackExecuteLayer
    public enum EMatineeTrackExecuteLayer : byte
    {
        EMTEL_Start = 0,
        EMTEL_PreAnimation = 1,
        EMTEL_PoseTransform = 2,
        EMTEL_PoseEvaluate = 3,
        EMTEL_PoseFixed = 4,
        EMTEL_MAX = 5
    }


    // Enum Engine.ETrackActiveCondition
    public enum ETrackActiveCondition : byte
    {
        ETAC_Always = 0,
        ETAC_GoreEnabled = 1,
        ETAC_GoreDisabled = 2,
        ETAC_MAX = 3
    }


    // Enum Engine.EInterpTrackMoveRotMode
    public enum EInterpTrackMoveRotMode : byte
    {
        IMR_Keyframed = 0,
        IMR_LookAtGroup = 1,
        IMR_Ignore = 2,
        IMR_MAX = 3
    }


    // Enum Engine.EInterpMoveAxis
    public enum EInterpMoveAxis : byte
    {
        AXIS_TranslationX = 0,
        AXIS_TranslationY = 1,
        AXIS_TranslationZ = 2,
        AXIS_RotationX = 3,
        AXIS_RotationY = 4,
        AXIS_RotationZ = 5,
        AXIS_MAX = 6
    }


    // Enum Engine.ETrackToggleAction
    public enum ETrackToggleAction : byte
    {
        ETTA_Off = 0,
        ETTA_On = 1,
        ETTA_Toggle = 2,
        ETTA_Trigger = 3,
        ETTA_MAX = 4
    }


    // Enum Engine.EVisibilityTrackCondition
    public enum EVisibilityTrackCondition : byte
    {
        EVTC_Always = 0,
        EVTC_GoreEnabled = 1,
        EVTC_GoreDisabled = 2,
        EVTC_MAX = 3
    }


    // Enum Engine.EVisibilityTrackAction
    public enum EVisibilityTrackAction : byte
    {
        EVTA_Hide = 0,
        EVTA_Show = 1,
        EVTA_Toggle = 2,
        EVTA_MAX = 3
    }


    // Enum Engine.ESlateGesture
    public enum ESlateGesture : byte
    {
        ESlateGesture__None = 0,
        ESlateGesture__Scroll = 1,
        ESlateGesture__Magnify = 2,
        ESlateGesture__Swipe = 3,
        ESlateGesture__Rotate = 4,
        ESlateGesture__LongPress = 5,
        ESlateGesture__ESlateGesture_MAX = 6
    }


    // Enum Engine.ELerpInterpolationMode
    public enum ELerpInterpolationMode : byte
    {
        ELerpInterpolationMode__QuatInterp = 0,
        ELerpInterpolationMode__EulerInterp = 1,
        ELerpInterpolationMode__DualQuatInterp = 2,
        ELerpInterpolationMode__ELerpInterpolationMode_MAX = 3
    }


    // Enum Engine.ERoundingMode
    public enum ERoundingMode : byte
    {
        HalfToEven = 0,
        HalfFromZero = 1,
        HalfToZero = 2,
        FromZero = 3,
        ToZero = 4,
        ToNegativeInfinity = 5,
        ToPositiveInfinity = 6,
        ERoundingMode_MAX = 7
    }


    // Enum Engine.EStreamingVolumeUsage
    public enum EStreamingVolumeUsage : byte
    {
        SVB_Loading = 0,
        SVB_LoadingAndVisibility = 1,
        SVB_VisibilityBlockingOnLoad = 2,
        SVB_BlockingOnLoad = 3,
        SVB_LoadingNotVisible = 4,
        SVB_MAX = 5
    }


    // Enum Engine.EMaterialDecalResponse
    public enum EMaterialDecalResponse : byte
    {
        MDR_None = 0,
        MDR_ColorNormalRoughness = 1,
        MDR_Color = 2,
        MDR_ColorNormal = 3,
        MDR_ColorRoughness = 4,
        MDR_Normal = 5,
        MDR_NormalRoughness = 6,
        MDR_Roughness = 7,
        MDR_MAX = 8
    }


    // Enum Engine.EDecalBlendMode
    public enum EDecalBlendMode : byte
    {
        DBM_Translucent = 0,
        DBM_Stain = 1,
        DBM_Normal = 2,
        DBM_Emissive = 3,
        DBM_DBuffer_ColorNormalRoughness = 4,
        DBM_DBuffer_Color = 5,
        DBM_DBuffer_ColorNormal = 6,
        DBM_DBuffer_ColorRoughness = 7,
        DBM_DBuffer_Normal = 8,
        DBM_DBuffer_NormalRoughness = 9,
        DBM_DBuffer_Roughness = 10,
        DBM_Volumetric_DistanceFunction = 11,
        DBM_MAX = 12
    }


    // Enum Engine.ETextureColorChannel
    public enum ETextureColorChannel : byte
    {
        TCC_Red = 0,
        TCC_Green = 1,
        TCC_Blue = 2,
        TCC_Alpha = 3,
        TCC_MAX = 4
    }


    // Enum Engine.EMaterialAttributeBlend
    public enum EMaterialAttributeBlend : byte
    {
        EMaterialAttributeBlend__Blend = 0,
        EMaterialAttributeBlend__UseA = 1,
        EMaterialAttributeBlend__UseB = 2,
        EMaterialAttributeBlend__EMaterialAttributeBlend_MAX = 3
    }


    // Enum Engine.EClampMode
    public enum EClampMode : byte
    {
        CMODE_Clamp = 0,
        CMODE_ClampMin = 1,
        CMODE_ClampMax = 2,
        CMODE_MAX = 3
    }


    // Enum Engine.ECustomMaterialOutputType
    public enum ECustomMaterialOutputType : byte
    {
        CMOT_Float1 = 0,
        CMOT_Float2 = 1,
        CMOT_Float3 = 2,
        CMOT_Float4 = 3,
        CMOT_MAX = 4
    }


    // Enum Engine.EDepthOfFieldFunctionValue
    public enum EDepthOfFieldFunctionValue : byte
    {
        TDOF_NearAndFarMask = 0,
        TDOF_NearMask = 1,
        TDOF_FarMask = 2,
        TDOF_CircleOfConfusionRadius = 3,
        TDOF_MAX = 4
    }


    // Enum Engine.EFunctionInputType
    public enum EFunctionInputType : byte
    {
        FunctionInput_Scalar = 0,
        FunctionInput_Vector2 = 1,
        FunctionInput_Vector3 = 2,
        FunctionInput_Vector4 = 3,
        FunctionInput_Texture2D = 4,
        FunctionInput_TextureCube = 5,
        FunctionInput_StaticBool = 6,
        FunctionInput_MaterialAttributes = 7,
        FunctionInput_MAX = 8
    }


    // Enum Engine.ENoiseFunction
    public enum ENoiseFunction : byte
    {
        NOISEFUNCTION_SimplexTex = 0,
        NOISEFUNCTION_GradientTex = 1,
        NOISEFUNCTION_GradientTex3D = 2,
        NOISEFUNCTION_GradientALU = 3,
        NOISEFUNCTION_ValueALU = 4,
        NOISEFUNCTION_VoronoiALU = 5,
        NOISEFUNCTION_MAX = 6
    }


    // Enum Engine.EMaterialSceneAttributeInputMode
    public enum EMaterialSceneAttributeInputMode : byte
    {
        EMaterialSceneAttributeInputMode__Coordinates = 0,
        EMaterialSceneAttributeInputMode__OffsetFraction = 1,
        EMaterialSceneAttributeInputMode__EMaterialSceneAttributeInputMode_MAX = 2
    }


    // Enum Engine.ESceneTextureId
    public enum ESceneTextureId : byte
    {
        PPI_SceneColor = 0,
        PPI_SceneDepth = 1,
        PPI_DiffuseColor = 2,
        PPI_SpecularColor = 3,
        PPI_SubsurfaceColor = 4,
        PPI_BaseColor = 5,
        PPI_Specular = 6,
        PPI_Metallic = 7,
        PPI_WorldNormal = 8,
        PPI_SeparateTranslucency = 9,
        PPI_Opacity = 10,
        PPI_Roughness = 11,
        PPI_MaterialAO = 12,
        PPI_CustomDepth = 13,
        PPI_PostProcessInput0 = 14,
        PPI_PostProcessInput1 = 15,
        PPI_PostProcessInput2 = 16,
        PPI_PostProcessInput3 = 17,
        PPI_PostProcessInput4 = 18,
        PPI_PostProcessInput5 = 19,
        PPI_PostProcessInput6 = 20,
        PPI_DecalMask = 21,
        PPI_ShadingModel = 22,
        PPI_AmbientOcclusion = 23,
        PPI_CustomStencil = 24,
        PPI_StoredBaseColor = 25,
        PPI_StoredSpecular = 26,
        PPI_PreviousFrame = 27,
        PPI_MAX = 28
    }


    // Enum Engine.EMaterialExpressionScreenPositionMapping
    public enum EMaterialExpressionScreenPositionMapping : byte
    {
        MESP_SceneTextureUV = 0,
        MESP_ViewportUV = 1,
        MESP_PreviousFrameUV = 2,
        MESP_Max = 3
    }


    // Enum Engine.ESpeedTreeLODType
    public enum ESpeedTreeLODType : byte
    {
        STLOD_Pop = 0,
        STLOD_Smooth = 1,
        STLOD_MAX = 2
    }


    // Enum Engine.ESpeedTreeWindType
    public enum ESpeedTreeWindType : byte
    {
        STW_None = 0,
        STW_Fastest = 1,
        STW_Fast = 2,
        STW_Better = 3,
        STW_Best = 4,
        STW_Palm = 5,
        STW_BestPlus = 6,
        STW_MAX = 7
    }


    // Enum Engine.ESpeedTreeGeometryType
    public enum ESpeedTreeGeometryType : byte
    {
        STG_Branch = 0,
        STG_Frond = 1,
        STG_Leaf = 2,
        STG_FacingLeaf = 3,
        STG_Billboard = 4,
        STG_MAX = 5
    }


    // Enum Engine.EMaterialExposedTextureProperty
    public enum EMaterialExposedTextureProperty : byte
    {
        TMTM_TextureSize = 0,
        TMTM_TexelSize = 1,
        TMTM_MAX = 2
    }


    // Enum Engine.ETextureMipValueMode
    public enum ETextureMipValueMode : byte
    {
        TMVM_None = 0,
        TMVM_MipLevel = 1,
        TMVM_MipBias = 2,
        TMVM_Derivative = 3,
        TMVM_MAX = 4
    }


    // Enum Engine.EMaterialVectorCoordTransform
    public enum EMaterialVectorCoordTransform : byte
    {
        TRANSFORM_Tangent = 0,
        TRANSFORM_Local = 1,
        TRANSFORM_World = 2,
        TRANSFORM_View = 3,
        TRANSFORM_Camera = 4,
        TRANSFORM_ParticleWorld = 5,
        TRANSFORM_MAX = 6
    }


    // Enum Engine.EMaterialVectorCoordTransformSource
    public enum EMaterialVectorCoordTransformSource : byte
    {
        TRANSFORMSOURCE_Tangent = 0,
        TRANSFORMSOURCE_Local = 1,
        TRANSFORMSOURCE_World = 2,
        TRANSFORMSOURCE_View = 3,
        TRANSFORMSOURCE_Camera = 4,
        TRANSFORMSOURCE_ParticleWorld = 5,
        TRANSFORMSOURCE_MAX = 6
    }


    // Enum Engine.EMaterialPositionTransformSource
    public enum EMaterialPositionTransformSource : byte
    {
        TRANSFORMPOSSOURCE_Local = 0,
        TRANSFORMPOSSOURCE_World = 1,
        TRANSFORMPOSSOURCE_TranslatedWorld = 2,
        TRANSFORMPOSSOURCE_View = 3,
        TRANSFORMPOSSOURCE_Camera = 4,
        TRANSFORMPOSSOURCE_Particle = 5,
        TRANSFORMPOSSOURCE_MAX = 6
    }


    // Enum Engine.EVectorNoiseFunction
    public enum EVectorNoiseFunction : byte
    {
        VNF_CellnoiseALU = 0,
        VNF_VectorALU = 1,
        VNF_GradientALU = 2,
        VNF_CurlALU = 3,
        VNF_VoronoiALU = 4,
        VNF_MAX = 5
    }


    // Enum Engine.EMaterialExposedViewProperty
    public enum EMaterialExposedViewProperty : byte
    {
        MEVP_BufferSize = 0,
        MEVP_FieldOfView = 1,
        MEVP_TanHalfFieldOfView = 2,
        MEVP_ViewSize = 3,
        MEVP_WorldSpaceViewPosition = 4,
        MEVP_WorldSpaceCameraPosition = 5,
        MEVP_ViewportOffset = 6,
        MEVP_MAX = 7
    }


    // Enum Engine.EWorldPositionIncludedOffsets
    public enum EWorldPositionIncludedOffsets : byte
    {
        WPT_Default = 0,
        WPT_ExcludeAllShaderOffsets = 1,
        WPT_CameraRelative = 2,
        WPT_CameraRelativeNoOffsets = 3,
        WPT_MAX = 4
    }


    // Enum Engine.EMaterialUsage
    public enum EMaterialUsage : byte
    {
        MATUSAGE_SkeletalMesh = 0,
        MATUSAGE_ParticleSprites = 1,
        MATUSAGE_BeamTrails = 2,
        MATUSAGE_MeshParticles = 3,
        MATUSAGE_StaticLighting = 4,
        MATUSAGE_MorphTargets = 5,
        MATUSAGE_SplineMesh = 6,
        MATUSAGE_InstancedStaticMeshes = 7,
        MATUSAGE_Clothing = 8,
        MATUSAGE_NiagaraSprites = 9,
        MATUSAGE_NiagaraRibbons = 10,
        MATUSAGE_NiagaraMeshParticles = 11,
        MATUSAGE_MAX = 12
    }


    // Enum Engine.EMaterialMergeType
    public enum EMaterialMergeType : byte
    {
        MaterialMergeType_Default = 0,
        MaterialMergeType_Simplygon = 1,
        MaterialMergeType_MAX = 2
    }


    // Enum Engine.ETextureSizingType
    public enum ETextureSizingType : byte
    {
        TextureSizingType_UseSingleTextureSize = 0,
        TextureSizingType_UseAutomaticBiasedSizes = 1,
        TextureSizingType_UseManualOverrideTextureSize = 2,
        TextureSizingType_UseSimplygonAutomaticSizing = 3,
        TextureSizingType_MAX = 4
    }


    // Enum Engine.EMaterialDomain
    public enum EMaterialDomain : byte
    {
        MD_Surface = 0,
        MD_DeferredDecal = 1,
        MD_LightFunction = 2,
        MD_Volume = 3,
        MD_PostProcess = 4,
        MD_UI = 5,
        MD_MAX = 6
    }


    // Enum Engine.EMeshMergeType
    public enum EMeshMergeType : byte
    {
        EMeshMergeType__MeshMergeType_Default = 0,
        EMeshMergeType__MeshMergeType_MergeActor = 1,
        EMeshMergeType__MeshMergeType_MAX = 2
    }


    // Enum Engine.EMeshLODSelectionType
    public enum EMeshLODSelectionType : byte
    {
        EMeshLODSelectionType__AllLODs = 0,
        EMeshLODSelectionType__SpecificLOD = 1,
        EMeshLODSelectionType__CalculateLOD = 2,
        EMeshLODSelectionType__EMeshLODSelectionType_MAX = 3
    }


    // Enum Engine.EMeshFeatureImportance
    public enum EMeshFeatureImportance : byte
    {
        EMeshFeatureImportance__Off = 0,
        EMeshFeatureImportance__Lowest = 1,
        EMeshFeatureImportance__Low = 2,
        EMeshFeatureImportance__Normal = 3,
        EMeshFeatureImportance__High = 4,
        EMeshFeatureImportance__Highest = 5,
        EMeshFeatureImportance__EMeshFeatureImportance_MAX = 6
    }


    // Enum Engine.EVertexPaintAxis
    public enum EVertexPaintAxis : byte
    {
        EVertexPaintAxis__X = 0,
        EVertexPaintAxis__Y = 1,
        EVertexPaintAxis__Z = 2,
        EVertexPaintAxis__EVertexPaintAxis_MAX = 3
    }


    // Enum Engine.EMicroTransactionResult
    public enum EMicroTransactionResult : byte
    {
        MTR_Succeeded = 0,
        MTR_Failed = 1,
        MTR_Canceled = 2,
        MTR_RestoredFromServer = 3,
        MTR_MAX = 4
    }


    // Enum Engine.EMicroTransactionDelegate
    public enum EMicroTransactionDelegate : byte
    {
        MTD_PurchaseQueryComplete = 0,
        MTD_PurchaseComplete = 1,
        MTD_MAX = 2
    }


    // Enum Engine.ERuntimeGenerationType
    public enum ERuntimeGenerationType : byte
    {
        ERuntimeGenerationType__Static = 0,
        ERuntimeGenerationType__DynamicModifiersOnly = 1,
        ERuntimeGenerationType__Dynamic = 2,
        ERuntimeGenerationType__LegacyGeneration = 3,
        ERuntimeGenerationType__ERuntimeGenerationType_MAX = 4
    }


    // Enum Engine.FNavigationSystemRunMode
    public enum EFNavigationSystemRunMode : byte
    {
        FNavigationSystemRunMode__InvalidMode = 0,
        FNavigationSystemRunMode__GameMode = 1,
        FNavigationSystemRunMode__EditorMode = 2,
        FNavigationSystemRunMode__SimulationMode = 3,
        FNavigationSystemRunMode__PIEMode = 4,
        FNavigationSystemRunMode__FNavigationSystemRunMode_MAX = 5
    }


    // Enum Engine.ENavCostDisplay
    public enum ENavCostDisplay : byte
    {
        ENavCostDisplay__TotalCost = 0,
        ENavCostDisplay__HeuristicOnly = 1,
        ENavCostDisplay__RealCostOnly = 2,
        ENavCostDisplay__ENavCostDisplay_MAX = 3
    }


    // Enum Engine.ENavigationQueryResult
    public enum ENavigationQueryResult : byte
    {
        ENavigationQueryResult__Invalid = 0,
        ENavigationQueryResult__Error = 1,
        ENavigationQueryResult__Fail = 2,
        ENavigationQueryResult__Success = 3,
        ENavigationQueryResult__ENavigationQueryResult_MAX = 4
    }


    // Enum Engine.ENavDataGatheringModeConfig
    public enum ENavDataGatheringModeConfig : byte
    {
        ENavDataGatheringModeConfig__Invalid = 0,
        ENavDataGatheringModeConfig__Instant = 1,
        ENavDataGatheringModeConfig__Lazy = 2,
        ENavDataGatheringModeConfig__ENavDataGatheringModeConfig_MAX = 3
    }


    // Enum Engine.ENavDataGatheringMode
    public enum ENavDataGatheringMode : byte
    {
        ENavDataGatheringMode__Default = 0,
        ENavDataGatheringMode__Instant = 1,
        ENavDataGatheringMode__Lazy = 2,
        ENavDataGatheringMode__ENavDataGatheringMode_MAX = 3
    }


    // Enum Engine.ENavigationOptionFlag
    public enum ENavigationOptionFlag : byte
    {
        ENavigationOptionFlag__Default = 0,
        ENavigationOptionFlag__Enable = 1,
        ENavigationOptionFlag__Disable = 2,
        ENavigationOptionFlag__MAX = 3
    }


    // Enum Engine.ENavLinkDirection
    public enum ENavLinkDirection : byte
    {
        ENavLinkDirection__BothWays = 0,
        ENavLinkDirection__LeftToRight = 1,
        ENavLinkDirection__RightToLeft = 2,
        ENavLinkDirection__ENavLinkDirection_MAX = 3
    }


    // Enum Engine.EEmitterRenderMode
    public enum EEmitterRenderMode : byte
    {
        ERM_Normal = 0,
        ERM_Point = 1,
        ERM_Cross = 2,
        ERM_LightsOnly = 3,
        ERM_None = 4,
        ERM_MAX = 5
    }


    // Enum Engine.EParticleSubUVInterpMethod
    public enum EParticleSubUVInterpMethod : byte
    {
        PSUVIM_None = 0,
        PSUVIM_Linear = 1,
        PSUVIM_Linear_Blend = 2,
        PSUVIM_Random = 3,
        PSUVIM_Random_Blend = 4,
        PSUVIM_MAX = 5
    }


    // Enum Engine.EParticleBurstMethod
    public enum EParticleBurstMethod : byte
    {
        EPBM_Instant = 0,
        EPBM_Interpolated = 1,
        EPBM_MAX = 2
    }


    // Enum Engine.ELandscapeCullingPrecision
    public enum ELandscapeCullingPrecision : byte
    {
        ELandscapeCullingPrecision__High = 0,
        ELandscapeCullingPrecision__Medium = 1,
        ELandscapeCullingPrecision__Low = 2,
        ELandscapeCullingPrecision__ELandscapeCullingPrecision_MAX = 3
    }


    // Enum Engine.EParticleSignificanceLevel
    public enum EParticleSignificanceLevel : byte
    {
        EParticleSignificanceLevel__Low = 0,
        EParticleSignificanceLevel__Medium = 1,
        EParticleSignificanceLevel__High = 2,
        EParticleSignificanceLevel__Critical = 3,
        EParticleSignificanceLevel__Num = 4,
        EParticleSignificanceLevel__EParticleSignificanceLevel_MAX = 5
    }


    // Enum Engine.EParticleSourceSelectionMethod
    public enum EParticleSourceSelectionMethod : byte
    {
        EPSSM_Random = 0,
        EPSSM_Sequential = 1,
        EPSSM_MAX = 2
    }


    // Enum Engine.EModuleType
    public enum EModuleType : byte
    {
        EPMT_General = 0,
        EPMT_TypeData = 1,
        EPMT_Beam = 2,
        EPMT_Trail = 3,
        EPMT_Spawn = 4,
        EPMT_Required = 5,
        EPMT_Event = 6,
        EPMT_Light = 7,
        EPMT_SubUV = 8,
        EPMT_MAX = 9
    }


    // Enum Engine.EParticleSystemInsignificanceReaction
    public enum EParticleSystemInsignificanceReaction : byte
    {
        EParticleSystemInsignificanceReaction__Auto = 0,
        EParticleSystemInsignificanceReaction__Complete = 1,
        EParticleSystemInsignificanceReaction__DisableTick = 2,
        EParticleSystemInsignificanceReaction__DisableTickAndKill = 3,
        EParticleSystemInsignificanceReaction__Num = 4,
        EParticleSystemInsignificanceReaction__EParticleSystemInsignificanceReaction_MAX = 5
    }


    // Enum Engine.EAttractorParticleSelectionMethod
    public enum EAttractorParticleSelectionMethod : byte
    {
        EAPSM_Random = 0,
        EAPSM_Sequential = 1,
        EAPSM_MAX = 2
    }


    // Enum Engine.Beam2SourceTargetTangentMethod
    public enum EBeam2SourceTargetTangentMethod : byte
    {
        PEB2STTM_Direct = 0,
        PEB2STTM_UserSet = 1,
        PEB2STTM_Distribution = 2,
        PEB2STTM_Emitter = 3,
        PEB2STTM_MAX = 4
    }


    // Enum Engine.Beam2SourceTargetMethod
    public enum EBeam2SourceTargetMethod : byte
    {
        PEB2STM_Default = 0,
        PEB2STM_UserSet = 1,
        PEB2STM_Emitter = 2,
        PEB2STM_Particle = 3,
        PEB2STM_Actor = 4,
        PEB2STM_MAX = 5
    }


    // Enum Engine.BeamModifierType
    public enum EBeamModifierType : byte
    {
        PEB2MT_Source = 0,
        PEB2MT_Target = 1,
        PEB2MT_MAX = 2
    }


    // Enum Engine.EParticleCameraOffsetUpdateMethod
    public enum EParticleCameraOffsetUpdateMethod : byte
    {
        EPCOUM_DirectSet = 0,
        EPCOUM_Additive = 1,
        EPCOUM_Scalar = 2,
        EPCOUM_MAX = 3
    }


    // Enum Engine.EParticleCollisionComplete
    public enum EParticleCollisionComplete : byte
    {
        EPCC_Kill = 0,
        EPCC_Freeze = 1,
        EPCC_HaltCollisions = 2,
        EPCC_FreezeTranslation = 3,
        EPCC_FreezeRotation = 4,
        EPCC_FreezeMovement = 5,
        EPCC_MAX = 6
    }


    // Enum Engine.EParticleCollisionResponse
    public enum EParticleCollisionResponse : byte
    {
        EParticleCollisionResponse__Bounce = 0,
        EParticleCollisionResponse__Stop = 1,
        EParticleCollisionResponse__Kill = 2,
        EParticleCollisionResponse__EParticleCollisionResponse_MAX = 3
    }


    // Enum Engine.ELocationBoneSocketSelectionMethod
    public enum ELocationBoneSocketSelectionMethod : byte
    {
        BONESOCKETSEL_Sequential = 0,
        BONESOCKETSEL_Random = 1,
        BONESOCKETSEL_MAX = 2
    }


    // Enum Engine.ELocationBoneSocketSource
    public enum ELocationBoneSocketSource : byte
    {
        BONESOCKETSOURCE_Bones = 0,
        BONESOCKETSOURCE_Sockets = 1,
        BONESOCKETSOURCE_MAX = 2
    }


    // Enum Engine.ELocationEmitterSelectionMethod
    public enum ELocationEmitterSelectionMethod : byte
    {
        ELESM_Random = 0,
        ELESM_Sequential = 1,
        ELESM_MAX = 2
    }


    // Enum Engine.CylinderHeightAxis
    public enum ECylinderHeightAxis : byte
    {
        PMLPC_HEIGHTAXIS_X = 0,
        PMLPC_HEIGHTAXIS_Y = 1,
        PMLPC_HEIGHTAXIS_Z = 2,
        PMLPC_HEIGHTAXIS_MAX = 3
    }


    // Enum Engine.ELocationSkelVertSurfaceSource
    public enum ELocationSkelVertSurfaceSource : byte
    {
        VERTSURFACESOURCE_Vert = 0,
        VERTSURFACESOURCE_Surface = 1,
        VERTSURFACESOURCE_MAX = 2
    }


    // Enum Engine.EOrbitChainMode
    public enum EOrbitChainMode : byte
    {
        EOChainMode_Add = 0,
        EOChainMode_Scale = 1,
        EOChainMode_Link = 2,
        EOChainMode_MAX = 3
    }


    // Enum Engine.EParticleAxisLock
    public enum EParticleAxisLock : byte
    {
        EPAL_NONE = 0,
        EPAL_X = 1,
        EPAL_Y = 2,
        EPAL_Z = 3,
        EPAL_NEGATIVE_X = 4,
        EPAL_NEGATIVE_Y = 5,
        EPAL_NEGATIVE_Z = 6,
        EPAL_ROTATE_X = 7,
        EPAL_ROTATE_Y = 8,
        EPAL_ROTATE_Z = 9,
        EPAL_MAX = 10
    }


    // Enum Engine.EEmitterDynamicParameterValue
    public enum EEmitterDynamicParameterValue : byte
    {
        EDPV_UserSet = 0,
        EDPV_AutoSet = 1,
        EDPV_VelocityX = 2,
        EDPV_VelocityY = 3,
        EDPV_VelocityZ = 4,
        EDPV_VelocityMag = 5,
        EDPV_MAX = 6
    }


    // Enum Engine.EEmitterNormalsMode
    public enum EEmitterNormalsMode : byte
    {
        ENM_CameraFacing = 0,
        ENM_Spherical = 1,
        ENM_Cylindrical = 2,
        ENM_MAX = 3
    }


    // Enum Engine.EParticleSortMode
    public enum EParticleSortMode : byte
    {
        PSORTMODE_None = 0,
        PSORTMODE_ViewProjDepth = 1,
        PSORTMODE_DistanceToView = 2,
        PSORTMODE_Age_OldestFirst = 3,
        PSORTMODE_Age_NewestFirst = 4,
        PSORTMODE_MAX = 5
    }


    // Enum Engine.EParticleUVFlipMode
    public enum EParticleUVFlipMode : byte
    {
        EParticleUVFlipMode__None = 0,
        EParticleUVFlipMode__FlipUV = 1,
        EParticleUVFlipMode__FlipUOnly = 2,
        EParticleUVFlipMode__FlipVOnly = 3,
        EParticleUVFlipMode__RandomFlipUV = 4,
        EParticleUVFlipMode__RandomFlipUOnly = 5,
        EParticleUVFlipMode__RandomFlipVOnly = 6,
        EParticleUVFlipMode__RandomFlipUVIndependent = 7,
        EParticleUVFlipMode__EParticleUVFlipMode_MAX = 8
    }


    // Enum Engine.ETrail2SourceMethod
    public enum ETrail2SourceMethod : byte
    {
        PET2SRCM_Default = 0,
        PET2SRCM_Particle = 1,
        PET2SRCM_Actor = 2,
        PET2SRCM_MAX = 3
    }


    // Enum Engine.EBeamTaperMethod
    public enum EBeamTaperMethod : byte
    {
        PEBTM_None = 0,
        PEBTM_Full = 1,
        PEBTM_Partial = 2,
        PEBTM_MAX = 3
    }


    // Enum Engine.EBeam2Method
    public enum EBeam2Method : byte
    {
        PEB2M_Distance = 0,
        PEB2M_Target = 1,
        PEB2M_Branch = 2,
        PEB2M_MAX = 3
    }


    // Enum Engine.EMeshCameraFacingOptions
    public enum EMeshCameraFacingOptions : byte
    {
        XAxisFacing_NoUp = 0,
        XAxisFacing_ZUp = 1,
        XAxisFacing_NegativeZUp = 2,
        XAxisFacing_YUp = 3,
        XAxisFacing_NegativeYUp = 4,
        LockedAxis_ZAxisFacing = 5,
        LockedAxis_NegativeZAxisFacing = 6,
        LockedAxis_YAxisFacing = 7,
        LockedAxis_NegativeYAxisFacing = 8,
        VelocityAligned_ZAxisFacing = 9,
        VelocityAligned_NegativeZAxisFacing = 10,
        VelocityAligned_YAxisFacing = 11,
        VelocityAligned_NegativeYAxisFacing = 12,
        EMeshCameraFacingOptions_MAX = 13
    }


    // Enum Engine.EMeshCameraFacingUpAxis
    public enum EMeshCameraFacingUpAxis : byte
    {
        CameraFacing_NoneUP = 0,
        CameraFacing_ZUp = 1,
        CameraFacing_NegativeZUp = 2,
        CameraFacing_YUp = 3,
        CameraFacing_NegativeYUp = 4,
        CameraFacing_MAX = 5
    }


    // Enum Engine.EMeshScreenAlignment
    public enum EMeshScreenAlignment : byte
    {
        PSMA_MeshFaceCameraWithRoll = 0,
        PSMA_MeshFaceCameraWithSpin = 1,
        PSMA_MeshFaceCameraWithLockedAxis = 2,
        PSMA_MAX = 3
    }


    // Enum Engine.ETrailsRenderAxisOption
    public enum ETrailsRenderAxisOption : byte
    {
        Trails_CameraUp = 0,
        Trails_SourceUp = 1,
        Trails_WorldUp = 2,
        Trails_MAX = 3
    }


    // Enum Engine.EParticleScreenAlignment
    public enum EParticleScreenAlignment : byte
    {
        PSA_FacingCameraPosition = 0,
        PSA_Square = 1,
        PSA_Rectangle = 2,
        PSA_Velocity = 3,
        PSA_AwayFromCenter = 4,
        PSA_TypeSpecific = 5,
        PSA_FacingCameraDistanceBlend = 6,
        PSA_MAX = 7
    }


    // Enum Engine.EParticleSystemOcclusionBoundsMethod
    public enum EParticleSystemOcclusionBoundsMethod : byte
    {
        EPSOBM_None = 0,
        EPSOBM_ParticleBounds = 1,
        EPSOBM_CustomBounds = 2,
        EPSOBM_MAX = 3
    }


    // Enum Engine.ParticleSystemLODMethod
    public enum EParticleSystemLODMethod : byte
    {
        PARTICLESYSTEMLODMETHOD_Automatic = 0,
        PARTICLESYSTEMLODMETHOD_DirectSet = 1,
        PARTICLESYSTEMLODMETHOD_ActivateAutomatic = 2,
        PARTICLESYSTEMLODMETHOD_MAX = 3
    }


    // Enum Engine.EParticleSystemUpdateMode
    public enum EParticleSystemUpdateMode : byte
    {
        EPSUM_RealTime = 0,
        EPSUM_FixedTime = 1,
        EPSUM_MAX = 2
    }


    // Enum Engine.EParticleEventType
    public enum EParticleEventType : byte
    {
        EPET_Any = 0,
        EPET_Spawn = 1,
        EPET_Death = 2,
        EPET_Collision = 3,
        EPET_Burst = 4,
        EPET_Blueprint = 5,
        EPET_MAX = 6
    }


    // Enum Engine.ParticleReplayState
    public enum EParticleReplayState : byte
    {
        PRS_Disabled = 0,
        PRS_Capturing = 1,
        PRS_Replaying = 2,
        PRS_MAX = 3
    }


    // Enum Engine.EParticleSysParamType
    public enum EParticleSysParamType : byte
    {
        PSPT_None = 0,
        PSPT_Scalar = 1,
        PSPT_ScalarRand = 2,
        PSPT_Vector = 3,
        PSPT_VectorRand = 4,
        PSPT_Color = 5,
        PSPT_Actor = 6,
        PSPT_Material = 7,
        PSPT_MAX = 8
    }


    // Enum Engine.ESettingsLockedAxis
    public enum ESettingsLockedAxis : byte
    {
        ESettingsLockedAxis__None = 0,
        ESettingsLockedAxis__X = 1,
        ESettingsLockedAxis__Y = 2,
        ESettingsLockedAxis__Z = 3,
        ESettingsLockedAxis__Invalid = 4,
        ESettingsLockedAxis__ESettingsLockedAxis_MAX = 5
    }


    // Enum Engine.ESettingsDOF
    public enum ESettingsDOF : byte
    {
        ESettingsDOF__Full3D = 0,
        ESettingsDOF__YZPlane = 1,
        ESettingsDOF__XZPlane = 2,
        ESettingsDOF__XYPlane = 3,
        ESettingsDOF__ESettingsDOF_MAX = 4
    }


    // Enum Engine.EFrictionCombineMode
    public enum EFrictionCombineMode : byte
    {
        EFrictionCombineMode__Average = 0,
        EFrictionCombineMode__Min = 1,
        EFrictionCombineMode__Multiply = 2,
        EFrictionCombineMode__Max = 3
    }


    // Enum Engine.EViewTargetBlendFunction
    public enum EViewTargetBlendFunction : byte
    {
        VTBlend_Linear = 0,
        VTBlend_Cubic = 1,
        VTBlend_EaseIn = 2,
        VTBlend_EaseOut = 3,
        VTBlend_EaseInOut = 4,
        VTBlend_MAX = 5
    }


    // Enum Engine.EDynamicForceFeedbackAction
    public enum EDynamicForceFeedbackAction : byte
    {
        EDynamicForceFeedbackAction__Start = 0,
        EDynamicForceFeedbackAction__Update = 1,
        EDynamicForceFeedbackAction__Stop = 2,
        EDynamicForceFeedbackAction__EDynamicForceFeedbackAction_MAX = 3
    }


    // Enum Engine.ERendererStencilMask
    public enum ERendererStencilMask : byte
    {
        ERendererStencilMask__ERSM_Default = 0,
        ERendererStencilMask__ERSM = 1,
        ERendererStencilMask__ERSM01 = 2,
        ERendererStencilMask__ERSM02 = 3,
        ERendererStencilMask__ERSM03 = 4,
        ERendererStencilMask__ERSM04 = 5,
        ERendererStencilMask__ERSM05 = 6,
        ERendererStencilMask__ERSM06 = 7,
        ERendererStencilMask__ERSM07 = 8,
        ERendererStencilMask__ERSM08 = 9,
        ERendererStencilMask__ERSM_MAX = 10
    }


    // Enum Engine.ECanBeCharacterBase
    public enum ECanBeCharacterBase : byte
    {
        ECB_No = 0,
        ECB_Yes = 1,
        ECB_Owner = 2,
        ECB_MAX = 3
    }


    // Enum Engine.ERecastPartitioning
    public enum ERecastPartitioning : byte
    {
        ERecastPartitioning__Monotone = 0,
        ERecastPartitioning__Watershed = 1,
        ERecastPartitioning__ChunkyMonotone = 2,
        ERecastPartitioning__ERecastPartitioning_MAX = 3
    }


    // Enum Engine.EReflectionSourceType
    public enum EReflectionSourceType : byte
    {
        EReflectionSourceType__CapturedScene = 0,
        EReflectionSourceType__SpecifiedCubemap = 1,
        EReflectionSourceType__EReflectionSourceType_MAX = 2
    }


    // Enum Engine.EAutoExposureMethodUI
    public enum EAutoExposureMethodUI : byte
    {
        EAutoExposureMethodUI__AEM_Histogram = 0,
        EAutoExposureMethodUI__AEM_Basic = 1,
        EAutoExposureMethodUI__AEM_MAX = 2
    }


    // Enum Engine.EEarlyZPass
    public enum EEarlyZPass : byte
    {
        EEarlyZPass__None = 0,
        EEarlyZPass__OpaqueOnly = 1,
        EEarlyZPass__OpaqueAndMasked = 2,
        EEarlyZPass__Auto = 3,
        EEarlyZPass__EEarlyZPass_MAX = 4
    }


    // Enum Engine.ECustomDepthStencil
    public enum ECustomDepthStencil : byte
    {
        ECustomDepthStencil__Disabled = 0,
        ECustomDepthStencil__Enabled = 1,
        ECustomDepthStencil__EnabledOnDemand = 2,
        ECustomDepthStencil__EnabledWithStencil = 3,
        ECustomDepthStencil__ECustomDepthStencil_MAX = 4
    }


    // Enum Engine.EMobileMSAASampleCount
    public enum EMobileMSAASampleCount : byte
    {
        EMobileMSAASampleCount__One = 0,
        EMobileMSAASampleCount__Two = 1,
        EMobileMSAASampleCount__Four = 2,
        EMobileMSAASampleCount__Eight = 3,
        EMobileMSAASampleCount__EMobileMSAASampleCount_MAX = 4
    }


    // Enum Engine.ECompositingSampleCount
    public enum ECompositingSampleCount : byte
    {
        ECompositingSampleCount__One = 0,
        ECompositingSampleCount__Two = 1,
        ECompositingSampleCount__Four = 2,
        ECompositingSampleCount__Eight = 3,
        ECompositingSampleCount__ECompositingSampleCount_MAX = 4
    }


    // Enum Engine.EClearSceneOptions
    public enum EClearSceneOptions : byte
    {
        EClearSceneOptions__NoClear = 0,
        EClearSceneOptions__HardwareClear = 1,
        EClearSceneOptions__QuadAtMaxZ = 2,
        EClearSceneOptions__EClearSceneOptions_MAX = 3
    }


    // Enum Engine.EReporterLineStyle
    public enum EReporterLineStyle : byte
    {
        EReporterLineStyle__Line = 0,
        EReporterLineStyle__Dash = 1,
        EReporterLineStyle__EReporterLineStyle_MAX = 2
    }


    // Enum Engine.ELegendPosition
    public enum ELegendPosition : byte
    {
        ELegendPosition__Outside = 0,
        ELegendPosition__Inside = 1,
        ELegendPosition__ELegendPosition_MAX = 2
    }


    // Enum Engine.EGraphDataStyle
    public enum EGraphDataStyle : byte
    {
        EGraphDataStyle__Lines = 0,
        EGraphDataStyle__Filled = 1,
        EGraphDataStyle__EGraphDataStyle_MAX = 2
    }


    // Enum Engine.EGraphAxisStyle
    public enum EGraphAxisStyle : byte
    {
        EGraphAxisStyle__Lines = 0,
        EGraphAxisStyle__Notches = 1,
        EGraphAxisStyle__Grid = 2,
        EGraphAxisStyle__EGraphAxisStyle_MAX = 3
    }


    // Enum Engine.ERichCurveExtrapolation
    public enum ERichCurveExtrapolation : byte
    {
        RCCE_Cycle = 0,
        RCCE_CycleWithOffset = 1,
        RCCE_Oscillate = 2,
        RCCE_Linear = 3,
        RCCE_Constant = 4,
        RCCE_None = 5,
        RCCE_MAX = 6
    }


    // Enum Engine.ERichCurveTangentWeightMode
    public enum ERichCurveTangentWeightMode : byte
    {
        RCTWM_WeightedNone = 0,
        RCTWM_WeightedArrive = 1,
        RCTWM_WeightedLeave = 2,
        RCTWM_WeightedBoth = 3,
        RCTWM_MAX = 4
    }


    // Enum Engine.EHasCustomNavigableGeometry
    public enum EHasCustomNavigableGeometry : byte
    {
        EHasCustomNavigableGeometry__No = 0,
        EHasCustomNavigableGeometry__Yes = 1,
        EHasCustomNavigableGeometry__EvenIfNotCollidable = 2,
        EHasCustomNavigableGeometry__DontExport = 3,
        EHasCustomNavigableGeometry__EHasCustomNavigableGeometry_MAX = 4
    }


    // Enum Engine.ERichCurveTangentMode
    public enum ERichCurveTangentMode : byte
    {
        RCTM_Auto = 0,
        RCTM_User = 1,
        RCTM_Break = 2,
        RCTM_None = 3,
        RCTM_MAX = 4
    }


    // Enum Engine.ERichCurveInterpMode
    public enum ERichCurveInterpMode : byte
    {
        RCIM_Linear = 0,
        RCIM_Constant = 1,
        RCIM_Cubic = 2,
        RCIM_None = 3,
        RCIM_MAX = 4
    }


    // Enum Engine.EConstraintTransform
    public enum EConstraintTransform : byte
    {
        EConstraintTransform__Absolute = 0,
        EConstraintTransform__Relative = 1,
        EConstraintTransform__EConstraintTransform_MAX = 2
    }


    // Enum Engine.EControlConstraint
    public enum EControlConstraint : byte
    {
        EControlConstraint__Orientation = 0,
        EControlConstraint__Translation = 1,
        EControlConstraint__MAX = 2
    }


    // Enum Engine.ERootMotionFinishVelocityMode
    public enum ERootMotionFinishVelocityMode : byte
    {
        ERootMotionFinishVelocityMode__MaintainLastRootMotionVelocity = 0,
        ERootMotionFinishVelocityMode__SetVelocity = 1,
        ERootMotionFinishVelocityMode__ClampVelocity = 2,
        ERootMotionFinishVelocityMode__ERootMotionFinishVelocityMode_MAX = 3
    }


    // Enum Engine.ERootMotionSourceSettingsFlags
    public enum ERootMotionSourceSettingsFlags : byte
    {
        ERootMotionSourceSettingsFlags__UseSensitiveLiftoffCheck = 0,
        ERootMotionSourceSettingsFlags__DisablePartialEndTick = 1,
        ERootMotionSourceSettingsFlags__ERootMotionSourceSettingsFlags_MAX = 2
    }


    // Enum Engine.ERootMotionSourceStatusFlags
    public enum ERootMotionSourceStatusFlags : byte
    {
        ERootMotionSourceStatusFlags__Prepared = 0,
        ERootMotionSourceStatusFlags__Finished = 1,
        ERootMotionSourceStatusFlags__MarkedForRemoval = 2,
        ERootMotionSourceStatusFlags__ERootMotionSourceStatusFlags_MAX = 3
    }


    // Enum Engine.ERootMotionAccumulateMode
    public enum ERootMotionAccumulateMode : byte
    {
        ERootMotionAccumulateMode__Override = 0,
        ERootMotionAccumulateMode__Additive = 1,
        ERootMotionAccumulateMode__ERootMotionAccumulateMode_MAX = 2
    }


    // Enum Engine.EBloomMethod
    public enum EBloomMethod : byte
    {
        BM_SOG = 0,
        BM_FFT = 1,
        BM_MAX = 2
    }


    // Enum Engine.EAutoExposureMethod
    public enum EAutoExposureMethod : byte
    {
        AEM_Histogram = 0,
        AEM_Basic = 1,
        AEM_MAX = 2
    }


    // Enum Engine.EAntiAliasingMethod
    public enum EAntiAliasingMethod : byte
    {
        AAM_None = 0,
        AAM_FXAA = 1,
        AAM_TemporalAA = 2,
        AAM_MSAA = 3,
        AAM_MAX = 4
    }


    // Enum Engine.EDepthOfFieldMethod
    public enum EDepthOfFieldMethod : byte
    {
        DOFM_BokehDOF = 0,
        DOFM_Gaussian = 1,
        DOFM_CircleDOF = 2,
        DOFM_MAX = 3
    }


    // Enum Engine.ESceneCapturePrimitiveRenderMode
    public enum ESceneCapturePrimitiveRenderMode : byte
    {
        ESceneCapturePrimitiveRenderMode__PRM_LegacySceneCapture = 0,
        ESceneCapturePrimitiveRenderMode__PRM_RenderScenePrimitives = 1,
        ESceneCapturePrimitiveRenderMode__PRM_UseShowOnlyList = 2,
        ESceneCapturePrimitiveRenderMode__PRM_MAX = 3
    }


    // Enum Engine.EMaterialProperty
    public enum EMaterialProperty : byte
    {
        MP_EmissiveColor = 0,
        MP_Opacity = 1,
        MP_OpacityMask = 2,
        MP_DiffuseColor = 3,
        MP_SpecularColor = 4,
        MP_BaseColor = 5,
        MP_Metallic = 6,
        MP_Specular = 7,
        MP_Roughness = 8,
        MP_Normal = 9,
        MP_WorldPositionOffset = 10,
        MP_WorldDisplacement = 11,
        MP_TessellationMultiplier = 12,
        MP_SubsurfaceColor = 13,
        MP_CustomData0 = 14,
        MP_CustomData1 = 15,
        MP_AmbientOcclusion = 16,
        MP_Refraction = 17,
        MP_CustomizedUVs0 = 18,
        MP_CustomizedUVs1 = 19,
        MP_CustomizedUVs2 = 20,
        MP_CustomizedUVs3 = 21,
        MP_CustomizedUVs4 = 22,
        MP_CustomizedUVs5 = 23,
        MP_CustomizedUVs6 = 24,
        MP_CustomizedUVs7 = 25,
        MP_PixelDepthOffset = 26,
        MP_MaterialAttributes = 27,
        MP_CustomOutput = 28,
        MP_MAX = 29
    }


    // Enum Engine.EWindowTitleBarMode
    public enum EWindowTitleBarMode : byte
    {
        EWindowTitleBarMode__Overlay = 0,
        EWindowTitleBarMode__VerticalBox = 1,
        EWindowTitleBarMode__EWindowTitleBarMode_MAX = 2
    }


    // Enum Engine.SkeletalMeshOptimizationImportance
    public enum ESkeletalMeshOptimizationImportance : byte
    {
        SMOI_Off = 0,
        SMOI_Lowest = 1,
        SMOI_Low = 2,
        SMOI_Normal = 3,
        SMOI_High = 4,
        SMOI_Highest = 5,
        SMOI_MAX = 6
    }


    // Enum Engine.EPhysicsTransformUpdateMode
    public enum EPhysicsTransformUpdateMode : byte
    {
        EPhysicsTransformUpdateMode__SimulationUpatesComponentTransform = 0,
        EPhysicsTransformUpdateMode__ComponentTransformIsKinematic = 1,
        EPhysicsTransformUpdateMode__EPhysicsTransformUpdateMode_MAX = 2
    }


    // Enum Engine.EAnimationMode
    public enum EAnimationMode : byte
    {
        EAnimationMode__AnimationBlueprint = 0,
        EAnimationMode__AnimationSingleNode = 1,
        EAnimationMode__AnimationCustomMode = 2,
        EAnimationMode__EAnimationMode_MAX = 3
    }


    // Enum Engine.EKinematicBonesUpdateToPhysics
    public enum EKinematicBonesUpdateToPhysics : byte
    {
        EKinematicBonesUpdateToPhysics__SkipSimulatingBones = 0,
        EKinematicBonesUpdateToPhysics__SkipAllBones = 1,
        EKinematicBonesUpdateToPhysics__EKinematicBonesUpdateToPhysics_MAX = 2
    }


    // Enum Engine.EBoneTranslationRetargetingMode
    public enum EBoneTranslationRetargetingMode : byte
    {
        EBoneTranslationRetargetingMode__Animation = 0,
        EBoneTranslationRetargetingMode__Skeleton = 1,
        EBoneTranslationRetargetingMode__AnimationScaled = 2,
        EBoneTranslationRetargetingMode__AnimationRelative = 3,
        EBoneTranslationRetargetingMode__EBoneTranslationRetargetingMode_MAX = 4
    }


    // Enum Engine.SkeletalMeshOptimizationType
    public enum ESkeletalMeshOptimizationType : byte
    {
        SMOT_NumOfTriangles = 0,
        SMOT_MaxDeviation = 1,
        SMOT_MAX = 2
    }


    // Enum Engine.EBoneSpaces
    public enum EBoneSpaces : byte
    {
        EBoneSpaces__WorldSpace = 0,
        EBoneSpaces__ComponentSpace = 1,
        EBoneSpaces__EBoneSpaces_MAX = 2
    }


    // Enum Engine.EMeshComponentUpdateFlag
    public enum EMeshComponentUpdateFlag : byte
    {
        EMeshComponentUpdateFlag__AlwaysTickPoseAndRefreshBones = 0,
        EMeshComponentUpdateFlag__AlwaysTickPoseAndRefreshBonesWhenViewFrustum = 1,
        EMeshComponentUpdateFlag__AlwaysTickPose = 2,
        EMeshComponentUpdateFlag__OnlyTickMontagesWhenNotRendered = 3,
        EMeshComponentUpdateFlag__OnlyTickPoseWhenRendered = 4,
        EMeshComponentUpdateFlag__EMeshComponentUpdateFlag_MAX = 5
    }


    // Enum Engine.EPhysBodyOp
    public enum EPhysBodyOp : byte
    {
        PBO_None = 0,
        PBO_Term = 1,
        PBO_MAX = 2
    }


    // Enum Engine.EBoneVisibilityStatus
    public enum EBoneVisibilityStatus : byte
    {
        BVS_HiddenByParent = 0,
        BVS_Visible = 1,
        BVS_ExplicitlyHidden = 2,
        BVS_MAX = 3
    }


    // Enum Engine.ESkyLightSourceType
    public enum ESkyLightSourceType : byte
    {
        SLS_CapturedScene = 0,
        SLS_SpecifiedCubemap = 1,
        SLS_MAX = 2
    }


    // Enum Engine.EReverbSendMethod
    public enum EReverbSendMethod : byte
    {
        EReverbSendMethod__Linear = 0,
        EReverbSendMethod__CustomCurve = 1,
        EReverbSendMethod__Manual = 2,
        EReverbSendMethod__EReverbSendMethod_MAX = 3
    }


    // Enum Engine.EAirAbsorptionMethod
    public enum EAirAbsorptionMethod : byte
    {
        EAirAbsorptionMethod__Linear = 0,
        EAirAbsorptionMethod__CustomCurve = 1,
        EAirAbsorptionMethod__EAirAbsorptionMethod_MAX = 2
    }


    // Enum Engine.ESoundSpatializationAlgorithm
    public enum ESoundSpatializationAlgorithm : byte
    {
        SPATIALIZATION_Default = 0,
        SPATIALIZATION_HRTF = 1,
        SPATIALIZATION_MAX = 2
    }


    // Enum Engine.ESoundDistanceCalc
    public enum ESoundDistanceCalc : byte
    {
        SOUNDDISTANCE_Normal = 0,
        SOUNDDISTANCE_InfiniteXYPlane = 1,
        SOUNDDISTANCE_InfiniteXZPlane = 2,
        SOUNDDISTANCE_InfiniteYZPlane = 3,
        SOUNDDISTANCE_MAX = 4
    }


    // Enum Engine.EAudioOutputTarget
    public enum EAudioOutputTarget : byte
    {
        EAudioOutputTarget__Speaker = 0,
        EAudioOutputTarget__Controller = 1,
        EAudioOutputTarget__ControllerFallbackToSpeaker = 2,
        EAudioOutputTarget__EAudioOutputTarget_MAX = 3
    }


    // Enum Engine.EMaxConcurrentResolutionRule
    public enum EMaxConcurrentResolutionRule : byte
    {
        EMaxConcurrentResolutionRule__PreventNew = 0,
        EMaxConcurrentResolutionRule__StopOldest = 1,
        EMaxConcurrentResolutionRule__StopFarthestThenPreventNew = 2,
        EMaxConcurrentResolutionRule__StopFarthestThenOldest = 3,
        EMaxConcurrentResolutionRule__StopLowestPriority = 4,
        EMaxConcurrentResolutionRule__StopQuietest = 5,
        EMaxConcurrentResolutionRule__StopLowestPriorityThenPreventNew = 6,
        EMaxConcurrentResolutionRule__EMaxConcurrentResolutionRule_MAX = 7
    }


    // Enum Engine.ESoundGroup
    public enum ESoundGroup : byte
    {
        SOUNDGROUP_Default = 0,
        SOUNDGROUP_Effects = 1,
        SOUNDGROUP_UI = 2,
        SOUNDGROUP_Music = 3,
        SOUNDGROUP_Voice = 4,
        SOUNDGROUP_GameSoundGroup1 = 5,
        SOUNDGROUP_GameSoundGroup2 = 6,
        SOUNDGROUP_GameSoundGroup3 = 7,
        SOUNDGROUP_GameSoundGroup4 = 8,
        SOUNDGROUP_GameSoundGroup5 = 9,
        SOUNDGROUP_GameSoundGroup6 = 10,
        SOUNDGROUP_GameSoundGroup7 = 11,
        SOUNDGROUP_GameSoundGroup8 = 12,
        SOUNDGROUP_GameSoundGroup9 = 13,
        SOUNDGROUP_GameSoundGroup10 = 14,
        SOUNDGROUP_GameSoundGroup11 = 15,
        SOUNDGROUP_GameSoundGroup12 = 16,
        SOUNDGROUP_GameSoundGroup13 = 17,
        SOUNDGROUP_GameSoundGroup14 = 18,
        SOUNDGROUP_GameSoundGroup15 = 19,
        SOUNDGROUP_GameSoundGroup16 = 20,
        SOUNDGROUP_GameSoundGroup17 = 21,
        SOUNDGROUP_GameSoundGroup18 = 22,
        SOUNDGROUP_GameSoundGroup19 = 23,
        SOUNDGROUP_GameSoundGroup20 = 24,
        SOUNDGROUP_MAX = 25
    }


    // Enum Engine.ESourceBusChannels
    public enum ESourceBusChannels : byte
    {
        ESourceBusChannels__Mono = 0,
        ESourceBusChannels__Stereo = 1,
        ESourceBusChannels__ESourceBusChannels_MAX = 2
    }


    // Enum Engine.EDecompressionType
    public enum EDecompressionType : byte
    {
        DTYPE_Setup = 0,
        DTYPE_Invalid = 1,
        DTYPE_Preview = 2,
        DTYPE_Native = 3,
        DTYPE_RealTime = 4,
        DTYPE_Procedural = 5,
        DTYPE_Xenon = 6,
        DTYPE_Streaming = 7,
        DTYPE_MAX = 8
    }


    // Enum Engine.ESplineCoordinateSpace
    public enum ESplineCoordinateSpace : byte
    {
        ESplineCoordinateSpace__Local = 0,
        ESplineCoordinateSpace__World = 1,
        ESplineCoordinateSpace__ESplineCoordinateSpace_MAX = 2
    }


    // Enum Engine.ESplinePointType
    public enum ESplinePointType : byte
    {
        ESplinePointType__Linear = 0,
        ESplinePointType__Curve = 1,
        ESplinePointType__Constant = 2,
        ESplinePointType__CurveClamped = 3,
        ESplinePointType__CurveCustomTangent = 4,
        ESplinePointType__ESplinePointType_MAX = 5
    }


    // Enum Engine.ModulationParamMode
    public enum EModulationParamMode : byte
    {
        MPM_Normal = 0,
        MPM_Abs = 1,
        MPM_Direct = 2,
        MPM_MAX = 3
    }


    // Enum Engine.EOptimizationType
    public enum EOptimizationType : byte
    {
        OT_NumOfTriangles = 0,
        OT_MaxDeviation = 1,
        OT_MAX = 2
    }


    // Enum Engine.EImportanceLevel
    public enum EImportanceLevel : byte
    {
        IL_Off = 0,
        IL_Lowest = 1,
        IL_Low = 2,
        IL_Normal = 3,
        IL_High = 4,
        IL_Highest = 5,
        TEMP_BROKEN2 = 6,
        EImportanceLevel_MAX = 7
    }


    // Enum Engine.ENormalMode
    public enum ENormalMode : byte
    {
        NM_PreserveSmoothingGroups = 0,
        NM_RecalculateNormals = 1,
        NM_RecalculateNormalsSmooth = 2,
        NM_RecalculateNormalsHard = 3,
        TEMP_BROKEN = 4,
        ENormalMode_MAX = 5
    }


    // Enum Engine.EStereoLayerShape
    public enum EStereoLayerShape : byte
    {
        SLSH_QuadLayer = 0,
        SLSH_CylinderLayer = 1,
        SLSH_CubemapLayer = 2,
        SLSH_MAX = 3
    }


    // Enum Engine.ESplineMeshAxis
    public enum ESplineMeshAxis : byte
    {
        ESplineMeshAxis__X = 0,
        ESplineMeshAxis__Y = 1,
        ESplineMeshAxis__Z = 2,
        ESplineMeshAxis__ESplineMeshAxis_MAX = 3
    }


    // Enum Engine.EStereoLayerType
    public enum EStereoLayerType : byte
    {
        SLT_WorldLocked = 0,
        SLT_TrackerLocked = 1,
        SLT_FaceLocked = 2,
        SLT_MAX = 3
    }


    // Enum Engine.EOpacitySourceMode
    public enum EOpacitySourceMode : byte
    {
        OSM_Alpha = 0,
        OSM_ColorBrightness = 1,
        OSM_RedChannel = 2,
        OSM_GreenChannel = 3,
        OSM_BlueChannel = 4,
        OSM_MAX = 5
    }


    // Enum Engine.ESubUVBoundingVertexCount
    public enum ESubUVBoundingVertexCount : byte
    {
        BVC_FourVertices = 0,
        BVC_EightVertices = 1,
        BVC_MAX = 2
    }


    // Enum Engine.EVerticalTextAligment
    public enum EVerticalTextAligment : byte
    {
        EVRTA_TextTop = 0,
        EVRTA_TextCenter = 1,
        EVRTA_TextBottom = 2,
        EVRTA_QuadTop = 3,
        EVRTA_MAX = 4
    }


    // Enum Engine.ETextureCompressionQuality
    public enum ETextureCompressionQuality : byte
    {
        TCQ_Default = 0,
        TCQ_Lowest = 1,
        TCQ_Low = 2,
        TCQ_Medium = 3,
        TCQ_High = 4,
        TCQ_Highest = 5,
        TCQ_MAX = 6
    }


    // Enum Engine.ETextureSourceAlpha
    public enum ETextureSourceAlpha : byte
    {
        ETextureSourceAlpha__Unknown = 0,
        ETextureSourceAlpha__NoAlpha = 1,
        ETextureSourceAlpha__WithAlpha = 2,
        ETextureSourceAlpha__ETextureSourceAlpha_MAX = 3
    }


    // Enum Engine.ETextureSourceArtType
    public enum ETextureSourceArtType : byte
    {
        TSAT_Uncompressed = 0,
        TSAT_PNGCompressed = 1,
        TSAT_DDSFile = 2,
        TSAT_MAX = 3
    }


    // Enum Engine.ETextureMipCount
    public enum ETextureMipCount : byte
    {
        TMC_ResidentMips = 0,
        TMC_AllMips = 1,
        TMC_AllMipsBiased = 2,
        TMC_MAX = 3
    }


    // Enum Engine.ECompositeTextureMode
    public enum ECompositeTextureMode : byte
    {
        CTM_Disabled = 0,
        CTM_NormalRoughnessToRed = 1,
        CTM_NormalRoughnessToGreen = 2,
        CTM_NormalRoughnessToBlue = 3,
        CTM_NormalRoughnessToAlpha = 4,
        CTM_MAX = 5
    }


    // Enum Engine.TextureAddress
    public enum ETextureAddress : byte
    {
        TA_Wrap = 0,
        TA_Clamp = 1,
        TA_Mirror = 2,
        TA_MAX = 3
    }


    // Enum Engine.TextureFilter
    public enum ETextureFilter : byte
    {
        TF_Nearest = 0,
        TF_Bilinear = 1,
        TF_Trilinear = 2,
        TF_Default = 3,
        TF_MAX = 4
    }


    // Enum Engine.ETextureSourceFormat
    public enum ETextureSourceFormat : byte
    {
        TSF_Invalid = 0,
        TSF_G8 = 1,
        TSF_BGRA8 = 2,
        TSF_BGRE8 = 3,
        TSF_RGBA16 = 4,
        TSF_RGBA16F = 5,
        TSF_RGBA8 = 6,
        TSF_RGBE8 = 7,
        TSF_MAX = 8
    }


    // Enum Engine.ETextureSamplerFilter
    public enum ETextureSamplerFilter : byte
    {
        ETextureSamplerFilter__Point = 0,
        ETextureSamplerFilter__Bilinear = 1,
        ETextureSamplerFilter__Trilinear = 2,
        ETextureSamplerFilter__AnisotropicPoint = 3,
        ETextureSamplerFilter__AnisotropicLinear = 4,
        ETextureSamplerFilter__ETextureSamplerFilter_MAX = 5
    }


    // Enum Engine.ETexturePowerOfTwoSetting
    public enum ETexturePowerOfTwoSetting : byte
    {
        ETexturePowerOfTwoSetting__None = 0,
        ETexturePowerOfTwoSetting__PadToPowerOfTwo = 1,
        ETexturePowerOfTwoSetting__PadToSquarePowerOfTwo = 2,
        ETexturePowerOfTwoSetting__ETexturePowerOfTwoSetting_MAX = 3
    }


    // Enum Engine.TextureCompressionSettings
    public enum ETextureCompressionSettings : byte
    {
        TC_Default = 0,
        TC_Normalmap = 1,
        TC_Masks = 2,
        TC_Grayscale = 3,
        TC_Displacementmap = 4,
        TC_VectorDisplacementmap = 5,
        TC_HDR = 6,
        TC_EditorIcon = 7,
        TC_Alpha = 8,
        TC_DistanceFieldFont = 9,
        TC_HDR_Compressed = 10,
        TC_BC7 = 11,
        TC_MAX = 12
    }


    // Enum Engine.TextureMipGenSettings
    public enum ETextureMipGenSettings : byte
    {
        TMGS_FromTextureGroup = 0,
        TMGS_SimpleAverage = 1,
        TMGS_Sharpen0 = 2,
        TMGS_Sharpen1 = 3,
        TMGS_Sharpen2 = 4,
        TMGS_Sharpen3 = 5,
        TMGS_Sharpen4 = 6,
        TMGS_Sharpen5 = 7,
        TMGS_Sharpen6 = 8,
        TMGS_Sharpen7 = 9,
        TMGS_Sharpen8 = 10,
        TMGS_Sharpen9 = 11,
        TMGS_Sharpen10 = 12,
        TMGS_NoMipmaps = 13,
        TMGS_LeaveExistingMips = 14,
        TMGS_Blur1 = 15,
        TMGS_Blur2 = 16,
        TMGS_Blur3 = 17,
        TMGS_Blur4 = 18,
        TMGS_Blur5 = 19,
        TMGS_MAX = 20
    }


    // Enum Engine.TextureGroup
    public enum ETextureGroup : byte
    {
        TEXTUREGROUP_World = 0,
        TEXTUREGROUP_WorldNormalMap = 1,
        TEXTUREGROUP_WorldSpecular = 2,
        TEXTUREGROUP_Character = 3,
        TEXTUREGROUP_CharacterNormalMap = 4,
        TEXTUREGROUP_CharacterSpecular = 5,
        TEXTUREGROUP_Weapon = 6,
        TEXTUREGROUP_WeaponNormalMap = 7,
        TEXTUREGROUP_WeaponSpecular = 8,
        TEXTUREGROUP_Vehicle = 9,
        TEXTUREGROUP_VehicleNormalMap = 10,
        TEXTUREGROUP_VehicleSpecular = 11,
        TEXTUREGROUP_Cinematic = 12,
        TEXTUREGROUP_Effects = 13,
        TEXTUREGROUP_EffectsNotFiltered = 14,
        TEXTUREGROUP_Skybox = 15,
        TEXTUREGROUP_UI = 16,
        TEXTUREGROUP_Lightmap = 17,
        TEXTUREGROUP_RenderTarget = 18,
        TEXTUREGROUP_MobileFlattened = 19,
        TEXTUREGROUP_ProcBuilding_Face = 20,
        TEXTUREGROUP_ProcBuilding_LightMap = 21,
        TEXTUREGROUP_Shadowmap = 22,
        TEXTUREGROUP_ColorLookupTable = 23,
        TEXTUREGROUP_Terrain_Heightmap = 24,
        TEXTUREGROUP_Terrain_Weightmap = 25,
        TEXTUREGROUP_Bokeh = 26,
        TEXTUREGROUP_IESLightProfile = 27,
        TEXTUREGROUP_Pixels2D = 28,
        TEXTUREGROUP_HierarchicalLOD = 29,
        TEXTUREGROUP_MAX = 30
    }


    // Enum Engine.ETextureRenderTargetFormat
    public enum ETextureRenderTargetFormat : byte
    {
        RTF_R8 = 0,
        RTF_RG8 = 1,
        RTF_RGBA8 = 2,
        RTF_R16f = 3,
        RTF_RG16f = 4,
        RTF_RGBA16f = 5,
        RTF_R32f = 6,
        RTF_RG32f = 7,
        RTF_RGBA32f = 8,
        RTF_MAX = 9
    }


    // Enum Engine.ETimelineDirection
    public enum ETimelineDirection : byte
    {
        ETimelineDirection__Forward = 0,
        ETimelineDirection__Backward = 1,
        ETimelineDirection__ETimelineDirection_MAX = 2
    }


    // Enum Engine.ETimeStretchCurveMapping
    public enum ETimeStretchCurveMapping : byte
    {
        ETimeStretchCurveMapping__T_Original = 0,
        ETimeStretchCurveMapping__T_TargetMin = 1,
        ETimeStretchCurveMapping__T_TargetMax = 2,
        ETimeStretchCurveMapping__MAX = 3
    }


    // Enum Engine.ETwitterIntegrationDelegate
    public enum ETwitterIntegrationDelegate : byte
    {
        TID_AuthorizeComplete = 0,
        TID_TweetUIComplete = 1,
        TID_RequestComplete = 2,
        TID_MAX = 3
    }


    // Enum Engine.ETwitterRequestMethod
    public enum ETwitterRequestMethod : byte
    {
        TRM_Get = 0,
        TRM_Post = 1,
        TRM_Delete = 2,
        TRM_MAX = 3
    }


    // Enum Engine.EUserDefinedStructureStatus
    public enum EUserDefinedStructureStatus : byte
    {
        UDSS_UpToDate = 0,
        UDSS_Dirty = 1,
        UDSS_Error = 2,
        UDSS_Duplicate = 3,
        UDSS_MAX = 4
    }


    // Enum Engine.EUIScalingRule
    public enum EUIScalingRule : byte
    {
        EUIScalingRule__ShortestSide = 0,
        EUIScalingRule__LongestSide = 1,
        EUIScalingRule__Horizontal = 2,
        EUIScalingRule__Vertical = 3,
        EUIScalingRule__Custom = 4,
        EUIScalingRule__EUIScalingRule_MAX = 5
    }


    // Enum Engine.ERenderFocusRule
    public enum ERenderFocusRule : byte
    {
        ERenderFocusRule__Always = 0,
        ERenderFocusRule__NonPointer = 1,
        ERenderFocusRule__NavigationOnly = 2,
        ERenderFocusRule__Never = 3,
        ERenderFocusRule__ERenderFocusRule_MAX = 4
    }


    // Enum Engine.EVectorFieldConstructionOp
    public enum EVectorFieldConstructionOp : byte
    {
        VFCO_Extrude = 0,
        VFCO_Revolve = 1,
        VFCO_MAX = 2
    }


    // Enum Engine.EWindSourceType
    public enum EWindSourceType : byte
    {
        EWindSourceType__Directional = 0,
        EWindSourceType__Point = 1,
        EWindSourceType__EWindSourceType_MAX = 2
    }


    // Enum Engine.EVolumeLightingMethod
    public enum EVolumeLightingMethod : byte
    {
        VLM_VolumetricLightmap = 0,
        VLM_SparseVolumeLightingSamples = 1,
        VLM_MAX = 2
    }


    // Enum Engine.EVisibilityAggressiveness
    public enum EVisibilityAggressiveness : byte
    {
        VIS_LeastAggressive = 0,
        VIS_ModeratelyAggressive = 1,
        VIS_MostAggressive = 2,
        VIS_Max = 3
    }


    // Enum Engine.EHorizTextAligment
    public enum EHorizTextAligment : byte
    {
        EHTA_Left = 0,
        EHTA_Center = 1,
        EHTA_Right = 2,
        EHTA_MAX = 3
    }
}
