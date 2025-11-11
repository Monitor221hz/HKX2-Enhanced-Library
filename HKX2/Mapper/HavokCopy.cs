using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riok.Mapperly.Abstractions;

namespace HKX2E.Mapper
{
    /// <summary>
    /// C++ users: see aboutmapping.txt
    /// </summary>
    [Mapper(UseDeepCloning = true, UseReferenceHandling = true)]
    public partial class HavokCopy
    {
        #region CopySelf
        public static partial T Copy<T>(T source)
            where T : IHavokObject, new();

        public static partial BGSGamebryoSequenceGenerator Copy(BGSGamebryoSequenceGenerator obj);

        public static partial BSBoneSwitchGenerator Copy(BSBoneSwitchGenerator obj);

        public static partial BSBoneSwitchGeneratorBoneData Copy(BSBoneSwitchGeneratorBoneData obj);

        public static partial BSComputeAddBoneAnimModifier Copy(BSComputeAddBoneAnimModifier obj);

        public static partial BSCyclicBlendTransitionGenerator Copy(
            BSCyclicBlendTransitionGenerator obj
        );

        public static partial BSDecomposeVectorModifier Copy(BSDecomposeVectorModifier obj);

        public static partial BSDirectAtModifier Copy(BSDirectAtModifier obj);

        public static partial BSDistTriggerModifier Copy(BSDistTriggerModifier obj);

        public static partial BSEventEveryNEventsModifier Copy(BSEventEveryNEventsModifier obj);

        public static partial BSEventOnDeactivateModifier Copy(BSEventOnDeactivateModifier obj);

        public static partial BSEventOnFalseToTrueModifier Copy(BSEventOnFalseToTrueModifier obj);

        public static partial BSGetTimeStepModifier Copy(BSGetTimeStepModifier obj);

        public static partial BSInterpValueModifier Copy(BSInterpValueModifier obj);

        public static partial BSIsActiveModifier Copy(BSIsActiveModifier obj);

        public static partial BSIStateManagerModifier Copy(BSIStateManagerModifier obj);

        public static partial BSIStateManagerModifierBSiStateData Copy(
            BSIStateManagerModifierBSiStateData obj
        );

        public static partial BSIStateManagerModifierBSIStateManagerStateListener Copy(
            BSIStateManagerModifierBSIStateManagerStateListener obj
        );

        public static partial BSiStateTaggingGenerator Copy(BSiStateTaggingGenerator obj);

        public static partial BSLimbIKModifier Copy(BSLimbIKModifier obj);

        public static partial BSLookAtModifier Copy(BSLookAtModifier obj);

        public static partial BSLookAtModifierBoneData Copy(BSLookAtModifierBoneData obj);

        public static partial BSModifyOnceModifier Copy(BSModifyOnceModifier obj);

        public static partial BSOffsetAnimationGenerator Copy(BSOffsetAnimationGenerator obj);

        public static partial BSPassByTargetTriggerModifier Copy(BSPassByTargetTriggerModifier obj);

        public static partial BSRagdollContactListenerModifier Copy(
            BSRagdollContactListenerModifier obj
        );

        public static partial BSSpeedSamplerModifier Copy(BSSpeedSamplerModifier obj);

        public static partial BSSynchronizedClipGenerator Copy(BSSynchronizedClipGenerator obj);

        public static partial BSTimerModifier Copy(BSTimerModifier obj);

        public static partial BSTweenerModifier Copy(BSTweenerModifier obj);

        public static partial hkAabb Copy(hkAabb obj);

        public static partial hkAabbHalf Copy(hkAabbHalf obj);

        public static partial hkAabbUint32 Copy(hkAabbUint32 obj);

        public static partial hkaAnimatedReferenceFrame Copy(hkaAnimatedReferenceFrame obj);

        public static partial hkaAnimation Copy(hkaAnimation obj);

        public static partial hkaAnimationBinding Copy(hkaAnimationBinding obj);

        public static partial hkaAnimationContainer Copy(hkaAnimationContainer obj);

        public static partial hkaAnimationPreviewColorContainer Copy(
            hkaAnimationPreviewColorContainer obj
        );

        public static partial hkaAnnotationTrack Copy(hkaAnnotationTrack obj);

        public static partial hkaAnnotationTrackAnnotation Copy(hkaAnnotationTrackAnnotation obj);

        public static partial hkaBone Copy(hkaBone obj);

        public static partial hkaBoneAttachment Copy(hkaBoneAttachment obj);

        public static partial hkaDefaultAnimatedReferenceFrame Copy(
            hkaDefaultAnimatedReferenceFrame obj
        );

        public static partial hkaFootstepAnalysisInfo Copy(hkaFootstepAnalysisInfo obj);

        public static partial hkaFootstepAnalysisInfoContainer Copy(
            hkaFootstepAnalysisInfoContainer obj
        );

        public static partial hkaInterleavedUncompressedAnimation Copy(
            hkaInterleavedUncompressedAnimation obj
        );

        public static partial hkaKeyFrameHierarchyUtility Copy(hkaKeyFrameHierarchyUtility obj);

        public static partial hkaKeyFrameHierarchyUtilityControlData Copy(
            hkaKeyFrameHierarchyUtilityControlData obj
        );

        public static partial hkAlignSceneToNodeOptions Copy(hkAlignSceneToNodeOptions obj);

        public static partial hkaMeshBinding Copy(hkaMeshBinding obj);

        public static partial hkaMeshBindingMapping Copy(hkaMeshBindingMapping obj);

        public static partial hkaQuantizedAnimation Copy(hkaQuantizedAnimation obj);

        public static partial hkaQuantizedAnimationTrackCompressionParams Copy(
            hkaQuantizedAnimationTrackCompressionParams obj
        );

        public static partial hkaRagdollInstance Copy(hkaRagdollInstance obj);

        public static partial hkArrayTypeAttribute Copy(hkArrayTypeAttribute obj);

        public static partial hkaSkeleton Copy(hkaSkeleton obj);

        public static partial hkaSkeletonLocalFrameOnBone Copy(hkaSkeletonLocalFrameOnBone obj);

        public static partial hkaSkeletonMapper Copy(hkaSkeletonMapper obj);

        public static partial hkaSkeletonMapperData Copy(hkaSkeletonMapperData obj);

        public static partial hkaSkeletonMapperDataChainMapping Copy(
            hkaSkeletonMapperDataChainMapping obj
        );

        public static partial hkaSkeletonMapperDataSimpleMapping Copy(
            hkaSkeletonMapperDataSimpleMapping obj
        );

        public static partial hkaSplineCompressedAnimation Copy(hkaSplineCompressedAnimation obj);

        public static partial hkaSplineCompressedAnimationAnimationCompressionParams Copy(
            hkaSplineCompressedAnimationAnimationCompressionParams obj
        );

        public static partial hkaSplineCompressedAnimationTrackCompressionParams Copy(
            hkaSplineCompressedAnimationTrackCompressionParams obj
        );

        public static partial hkbAttachmentModifier Copy(hkbAttachmentModifier obj);

        public static partial hkbAttachmentSetup Copy(hkbAttachmentSetup obj);

        public static partial hkbAttributeModifier Copy(hkbAttributeModifier obj);

        public static partial hkbAttributeModifierAssignment Copy(
            hkbAttributeModifierAssignment obj
        );

        public static partial hkbAuxiliaryNodeInfo Copy(hkbAuxiliaryNodeInfo obj);

        public static partial hkbBehaviorEventsInfo Copy(hkbBehaviorEventsInfo obj);

        public static partial hkbBehaviorGraph Copy(hkbBehaviorGraph obj);

        public static partial hkbBehaviorGraphData Copy(hkbBehaviorGraphData obj);

        public static partial hkbBehaviorGraphInternalState Copy(hkbBehaviorGraphInternalState obj);

        public static partial hkbBehaviorGraphInternalStateInfo Copy(
            hkbBehaviorGraphInternalStateInfo obj
        );

        public static partial hkbBehaviorGraphStringData Copy(hkbBehaviorGraphStringData obj);

        public static partial hkbBehaviorInfo Copy(hkbBehaviorInfo obj);

        public static partial hkbBehaviorInfoIdToNamePair Copy(hkbBehaviorInfoIdToNamePair obj);

        public static partial hkbBehaviorReferenceGenerator Copy(hkbBehaviorReferenceGenerator obj);

        public static partial hkbBindable Copy(hkbBindable obj);

        public static partial hkbBlendCurveUtils Copy(hkbBlendCurveUtils obj);

        public static partial hkbBlenderGenerator Copy(hkbBlenderGenerator obj);

        public static partial hkbBlenderGeneratorChild Copy(hkbBlenderGeneratorChild obj);

        public static partial hkbBlenderGeneratorChildInternalState Copy(
            hkbBlenderGeneratorChildInternalState obj
        );

        public static partial hkbBlenderGeneratorInternalState Copy(
            hkbBlenderGeneratorInternalState obj
        );

        public static partial hkbBlendingTransitionEffect Copy(hkbBlendingTransitionEffect obj);

        public static partial hkbBlendingTransitionEffectInternalState Copy(
            hkbBlendingTransitionEffectInternalState obj
        );

        public static partial hkbBoneIndexArray Copy(hkbBoneIndexArray obj);

        public static partial hkbBoneWeightArray Copy(hkbBoneWeightArray obj);

        public static partial hkbBoolVariableSequencedData Copy(hkbBoolVariableSequencedData obj);

        public static partial hkbBoolVariableSequencedDataSample Copy(
            hkbBoolVariableSequencedDataSample obj
        );

        public static partial hkbCameraShakeEventPayload Copy(hkbCameraShakeEventPayload obj);

        public static partial hkbCharacter Copy(hkbCharacter obj);

        public static partial hkbCharacterAddedInfo Copy(hkbCharacterAddedInfo obj);

        public static partial hkbCharacterControlCommand Copy(hkbCharacterControlCommand obj);

        public static partial hkbCharacterControllerControlData Copy(
            hkbCharacterControllerControlData obj
        );

        public static partial hkbCharacterControllerModifier Copy(
            hkbCharacterControllerModifier obj
        );

        public static partial hkbCharacterControllerModifierInternalState Copy(
            hkbCharacterControllerModifierInternalState obj
        );

        public static partial hkbCharacterData Copy(hkbCharacterData obj);

        public static partial hkbCharacterDataCharacterControllerInfo Copy(
            hkbCharacterDataCharacterControllerInfo obj
        );

        public static partial hkbCharacterInfo Copy(hkbCharacterInfo obj);

        public static partial hkbCharacterSetup Copy(hkbCharacterSetup obj);

        public static partial hkbCharacterSkinInfo Copy(hkbCharacterSkinInfo obj);

        public static partial hkbCharacterSteppedInfo Copy(hkbCharacterSteppedInfo obj);

        public static partial hkbCharacterStringData Copy(hkbCharacterStringData obj);

        public static partial hkbClientCharacterState Copy(hkbClientCharacterState obj);

        public static partial hkbClipGenerator Copy(hkbClipGenerator obj);

        public static partial hkbClipGeneratorEcho Copy(hkbClipGeneratorEcho obj);

        public static partial hkbClipGeneratorInternalState Copy(hkbClipGeneratorInternalState obj);

        public static partial hkbClipTrigger Copy(hkbClipTrigger obj);

        public static partial hkbClipTriggerArray Copy(hkbClipTriggerArray obj);

        public static partial hkbCombineTransformsModifier Copy(hkbCombineTransformsModifier obj);

        public static partial hkbCombineTransformsModifierInternalState Copy(
            hkbCombineTransformsModifierInternalState obj
        );

        public static partial hkbCompiledExpressionSet Copy(hkbCompiledExpressionSet obj);

        public static partial hkbCompiledExpressionSetToken Copy(hkbCompiledExpressionSetToken obj);

        public static partial hkbComputeDirectionModifier Copy(hkbComputeDirectionModifier obj);

        public static partial hkbComputeDirectionModifierInternalState Copy(
            hkbComputeDirectionModifierInternalState obj
        );

        public static partial hkbComputeRotationFromAxisAngleModifier Copy(
            hkbComputeRotationFromAxisAngleModifier obj
        );

        public static partial hkbComputeRotationFromAxisAngleModifierInternalState Copy(
            hkbComputeRotationFromAxisAngleModifierInternalState obj
        );

        public static partial hkbComputeRotationToTargetModifier Copy(
            hkbComputeRotationToTargetModifier obj
        );

        public static partial hkbComputeRotationToTargetModifierInternalState Copy(
            hkbComputeRotationToTargetModifierInternalState obj
        );

        public static partial hkbCondition Copy(hkbCondition obj);

        public static partial hkbContext Copy(hkbContext obj);

        public static partial hkbDampingModifier Copy(hkbDampingModifier obj);

        public static partial hkbDampingModifierInternalState Copy(
            hkbDampingModifierInternalState obj
        );

        public static partial hkbDefaultMessageLog Copy(hkbDefaultMessageLog obj);

        public static partial hkbDelayedModifier Copy(hkbDelayedModifier obj);

        public static partial hkbDelayedModifierInternalState Copy(
            hkbDelayedModifierInternalState obj
        );

        public static partial hkbDetectCloseToGroundModifier Copy(
            hkbDetectCloseToGroundModifier obj
        );

        public static partial hkbDetectCloseToGroundModifierInternalState Copy(
            hkbDetectCloseToGroundModifierInternalState obj
        );

        public static partial hkbEvaluateExpressionModifier Copy(hkbEvaluateExpressionModifier obj);

        public static partial hkbEvaluateExpressionModifierInternalExpressionData Copy(
            hkbEvaluateExpressionModifierInternalExpressionData obj
        );

        public static partial hkbEvaluateExpressionModifierInternalState Copy(
            hkbEvaluateExpressionModifierInternalState obj
        );

        public static partial hkbEvaluateHandleModifier Copy(hkbEvaluateHandleModifier obj);

        public static partial hkbEvent Copy(hkbEvent obj);

        public static partial hkbEventBase Copy(hkbEventBase obj);

        public static partial hkbEventDrivenModifier Copy(hkbEventDrivenModifier obj);

        public static partial hkbEventDrivenModifierInternalState Copy(
            hkbEventDrivenModifierInternalState obj
        );

        public static partial hkbEventInfo Copy(hkbEventInfo obj);

        public static partial hkbEventPayload Copy(hkbEventPayload obj);

        public static partial hkbEventPayloadList Copy(hkbEventPayloadList obj);

        public static partial hkbEventProperty Copy(hkbEventProperty obj);

        public static partial hkbEventRaisedInfo Copy(hkbEventRaisedInfo obj);

        public static partial hkbEventRangeData Copy(hkbEventRangeData obj);

        public static partial hkbEventRangeDataArray Copy(hkbEventRangeDataArray obj);

        public static partial hkbEventSequencedData Copy(hkbEventSequencedData obj);

        public static partial hkbEventSequencedDataSequencedEvent Copy(
            hkbEventSequencedDataSequencedEvent obj
        );

        public static partial hkbEventsFromRangeModifier Copy(hkbEventsFromRangeModifier obj);

        public static partial hkbEventsFromRangeModifierInternalState Copy(
            hkbEventsFromRangeModifierInternalState obj
        );

        public static partial hkbExpressionCondition Copy(hkbExpressionCondition obj);

        public static partial hkbExpressionData Copy(hkbExpressionData obj);

        public static partial hkbExpressionDataArray Copy(hkbExpressionDataArray obj);

        public static partial hkbExtractRagdollPoseModifier Copy(hkbExtractRagdollPoseModifier obj);

        public static partial hkbFootIkControlData Copy(hkbFootIkControlData obj);

        public static partial hkbFootIkControlsModifier Copy(hkbFootIkControlsModifier obj);

        public static partial hkbFootIkControlsModifierLeg Copy(hkbFootIkControlsModifierLeg obj);

        public static partial hkbFootIkDriverInfo Copy(hkbFootIkDriverInfo obj);

        public static partial hkbFootIkDriverInfoLeg Copy(hkbFootIkDriverInfoLeg obj);

        public static partial hkbFootIkGains Copy(hkbFootIkGains obj);

        public static partial hkbFootIkModifier Copy(hkbFootIkModifier obj);

        public static partial hkbFootIkModifierInternalLegData Copy(
            hkbFootIkModifierInternalLegData obj
        );

        public static partial hkbFootIkModifierLeg Copy(hkbFootIkModifierLeg obj);

        public static partial hkbGenerator Copy(hkbGenerator obj);

        public static partial hkbGeneratorOutputListener Copy(hkbGeneratorOutputListener obj);

        public static partial hkbGeneratorSyncInfo Copy(hkbGeneratorSyncInfo obj);

        public static partial hkbGeneratorSyncInfoSyncPoint Copy(hkbGeneratorSyncInfoSyncPoint obj);

        public static partial hkbGeneratorTransitionEffect Copy(hkbGeneratorTransitionEffect obj);

        public static partial hkbGeneratorTransitionEffectInternalState Copy(
            hkbGeneratorTransitionEffectInternalState obj
        );

        public static partial hkbGetHandleOnBoneModifier Copy(hkbGetHandleOnBoneModifier obj);

        public static partial hkbGetUpModifier Copy(hkbGetUpModifier obj);

        public static partial hkbGetUpModifierInternalState Copy(hkbGetUpModifierInternalState obj);

        public static partial hkbGetWorldFromModelModifier Copy(hkbGetWorldFromModelModifier obj);

        public static partial hkbGetWorldFromModelModifierInternalState Copy(
            hkbGetWorldFromModelModifierInternalState obj
        );

        public static partial hkbHandIkControlData Copy(hkbHandIkControlData obj);

        public static partial hkbHandIkControlsModifier Copy(hkbHandIkControlsModifier obj);

        public static partial hkbHandIkControlsModifierHand Copy(hkbHandIkControlsModifierHand obj);

        public static partial hkbHandIkDriverInfo Copy(hkbHandIkDriverInfo obj);

        public static partial hkbHandIkDriverInfoHand Copy(hkbHandIkDriverInfoHand obj);

        public static partial hkbHandIkModifier Copy(hkbHandIkModifier obj);

        public static partial hkbHandIkModifierHand Copy(hkbHandIkModifierHand obj);

        public static partial hkbHandle Copy(hkbHandle obj);

        public static partial hkbIntEventPayload Copy(hkbIntEventPayload obj);

        public static partial hkbIntVariableSequencedData Copy(hkbIntVariableSequencedData obj);

        public static partial hkbIntVariableSequencedDataSample Copy(
            hkbIntVariableSequencedDataSample obj
        );

        public static partial hkBitField Copy(hkBitField obj);

        public static partial hkbKeyframeBonesModifier Copy(hkbKeyframeBonesModifier obj);

        public static partial hkbKeyframeBonesModifierKeyframeInfo Copy(
            hkbKeyframeBonesModifierKeyframeInfo obj
        );

        public static partial hkbLinkedSymbolInfo Copy(hkbLinkedSymbolInfo obj);

        public static partial hkbLookAtModifier Copy(hkbLookAtModifier obj);

        public static partial hkbLookAtModifierInternalState Copy(
            hkbLookAtModifierInternalState obj
        );

        public static partial hkbManualSelectorGenerator Copy(hkbManualSelectorGenerator obj);

        public static partial hkbManualSelectorGeneratorInternalState Copy(
            hkbManualSelectorGeneratorInternalState obj
        );

        public static partial hkbMessageLog Copy(hkbMessageLog obj);

        public static partial hkbMirroredSkeletonInfo Copy(hkbMirroredSkeletonInfo obj);

        public static partial hkbMirrorModifier Copy(hkbMirrorModifier obj);

        public static partial hkbModifier Copy(hkbModifier obj);

        public static partial hkbModifierGenerator Copy(hkbModifierGenerator obj);

        public static partial hkbModifierList Copy(hkbModifierList obj);

        public static partial hkbModifierWrapper Copy(hkbModifierWrapper obj);

        public static partial hkbMoveCharacterModifier Copy(hkbMoveCharacterModifier obj);

        public static partial hkbMoveCharacterModifierInternalState Copy(
            hkbMoveCharacterModifierInternalState obj
        );

        public static partial hkbNamedEventPayload Copy(hkbNamedEventPayload obj);

        public static partial hkbNamedIntEventPayload Copy(hkbNamedIntEventPayload obj);

        public static partial hkbNamedRealEventPayload Copy(hkbNamedRealEventPayload obj);

        public static partial hkbNamedStringEventPayload Copy(hkbNamedStringEventPayload obj);

        public static partial hkbNode Copy(hkbNode obj);

        public static partial hkbNodeInternalStateInfo Copy(hkbNodeInternalStateInfo obj);

        public static partial hkbParticleSystemEventPayload Copy(hkbParticleSystemEventPayload obj);

        public static partial hkbPoseMatchingGenerator Copy(hkbPoseMatchingGenerator obj);

        public static partial hkbPoseMatchingGeneratorInternalState Copy(
            hkbPoseMatchingGeneratorInternalState obj
        );

        public static partial hkbPoweredRagdollControlData Copy(hkbPoweredRagdollControlData obj);

        public static partial hkbPoweredRagdollControlsModifier Copy(
            hkbPoweredRagdollControlsModifier obj
        );

        public static partial hkbProjectData Copy(hkbProjectData obj);

        public static partial hkbProjectStringData Copy(hkbProjectStringData obj);

        public static partial hkbProxyModifier Copy(hkbProxyModifier obj);

        public static partial hkbProxyModifierProxyInfo Copy(hkbProxyModifierProxyInfo obj);

        public static partial hkbRaiseEventCommand Copy(hkbRaiseEventCommand obj);

        public static partial hkbRealEventPayload Copy(hkbRealEventPayload obj);

        public static partial hkbRealVariableSequencedData Copy(hkbRealVariableSequencedData obj);

        public static partial hkbRealVariableSequencedDataSample Copy(
            hkbRealVariableSequencedDataSample obj
        );

        public static partial hkbReferencePoseGenerator Copy(hkbReferencePoseGenerator obj);

        public static partial hkbRegisteredGenerator Copy(hkbRegisteredGenerator obj);

        public static partial hkbRigidBodyRagdollControlData Copy(
            hkbRigidBodyRagdollControlData obj
        );

        public static partial hkbRigidBodyRagdollControlsModifier Copy(
            hkbRigidBodyRagdollControlsModifier obj
        );

        public static partial hkbRotateCharacterModifier Copy(hkbRotateCharacterModifier obj);

        public static partial hkbRotateCharacterModifierInternalState Copy(
            hkbRotateCharacterModifierInternalState obj
        );

        public static partial hkbSenseHandleModifier Copy(hkbSenseHandleModifier obj);

        public static partial hkbSenseHandleModifierRange Copy(hkbSenseHandleModifierRange obj);

        public static partial hkbSequence Copy(hkbSequence obj);

        public static partial hkbSequencedData Copy(hkbSequencedData obj);

        public static partial hkbSequenceInternalState Copy(hkbSequenceInternalState obj);

        public static partial hkbSequenceStringData Copy(hkbSequenceStringData obj);

        public static partial hkbSetBehaviorCommand Copy(hkbSetBehaviorCommand obj);

        public static partial hkbSetLocalTimeOfClipGeneratorCommand Copy(
            hkbSetLocalTimeOfClipGeneratorCommand obj
        );

        public static partial hkbSetNodePropertyCommand Copy(hkbSetNodePropertyCommand obj);

        public static partial hkbSetWordVariableCommand Copy(hkbSetWordVariableCommand obj);

        public static partial hkbSetWorldFromModelModifier Copy(hkbSetWorldFromModelModifier obj);

        public static partial hkbSimulationControlCommand Copy(hkbSimulationControlCommand obj);

        public static partial hkbSimulationStateInfo Copy(hkbSimulationStateInfo obj);

        public static partial hkbStateChooser Copy(hkbStateChooser obj);

        public static partial hkbStateListener Copy(hkbStateListener obj);

        public static partial hkbStateMachine Copy(hkbStateMachine obj);

        public static partial hkbStateMachineActiveTransitionInfo Copy(
            hkbStateMachineActiveTransitionInfo obj
        );

        public static partial hkbStateMachineDelayedTransitionInfo Copy(
            hkbStateMachineDelayedTransitionInfo obj
        );

        public static partial hkbStateMachineEventPropertyArray Copy(
            hkbStateMachineEventPropertyArray obj
        );

        public static partial hkbStateMachineInternalState Copy(hkbStateMachineInternalState obj);

        public static partial hkbStateMachineNestedStateMachineData Copy(
            hkbStateMachineNestedStateMachineData obj
        );

        public static partial hkbStateMachineProspectiveTransitionInfo Copy(
            hkbStateMachineProspectiveTransitionInfo obj
        );

        public static partial hkbStateMachineStateInfo Copy(hkbStateMachineStateInfo obj);

        public static partial hkbStateMachineTimeInterval Copy(hkbStateMachineTimeInterval obj);

        public static partial hkbStateMachineTransitionInfo Copy(hkbStateMachineTransitionInfo obj);

        public static partial hkbStateMachineTransitionInfoArray Copy(
            hkbStateMachineTransitionInfoArray obj
        );

        public static partial hkbStateMachineTransitionInfoReference Copy(
            hkbStateMachineTransitionInfoReference obj
        );

        public static partial hkbStringCondition Copy(hkbStringCondition obj);

        public static partial hkbStringEventPayload Copy(hkbStringEventPayload obj);

        public static partial hkbTestStateChooser Copy(hkbTestStateChooser obj);

        public static partial hkbTimerModifier Copy(hkbTimerModifier obj);

        public static partial hkbTimerModifierInternalState Copy(hkbTimerModifierInternalState obj);

        public static partial hkbTransformVectorModifier Copy(hkbTransformVectorModifier obj);

        public static partial hkbTransformVectorModifierInternalState Copy(
            hkbTransformVectorModifierInternalState obj
        );

        public static partial hkbTransitionEffect Copy(hkbTransitionEffect obj);

        public static partial hkbTwistModifier Copy(hkbTwistModifier obj);

        public static partial hkbVariableBindingSet Copy(hkbVariableBindingSet obj);

        public static partial hkbVariableBindingSetBinding Copy(hkbVariableBindingSetBinding obj);

        public static partial hkbVariableValue Copy(hkbVariableValue obj);

        public static partial hkbVariableValueSet Copy(hkbVariableValueSet obj);

        public static partial hkbWorldEnums Copy(hkbWorldEnums obj);

        public static partial hkbWorldFromModelModeData Copy(hkbWorldFromModelModeData obj);

        public static partial hkClass Copy(hkClass obj);

        public static partial hkClassEnum Copy(hkClassEnum obj);

        public static partial hkClassEnumItem Copy(hkClassEnumItem obj);

        public static partial hkClassMember Copy(hkClassMember obj);

        public static partial hkColor Copy(hkColor obj);

        public static partial hkContactPoint Copy(hkContactPoint obj);

        public static partial hkContactPointMaterial Copy(hkContactPointMaterial obj);

        public static partial hkCustomAttributes Copy(hkCustomAttributes obj);

        public static partial hkCustomAttributesAttribute Copy(hkCustomAttributesAttribute obj);

        public static partial hkDataObjectTypeAttribute Copy(hkDataObjectTypeAttribute obj);

        public static partial hkDescriptionAttribute Copy(hkDescriptionAttribute obj);

        public static partial hkDocumentationAttribute Copy(hkDocumentationAttribute obj);

        public static partial hkGeometry Copy(hkGeometry obj);

        public static partial hkGeometryTriangle Copy(hkGeometryTriangle obj);

        public static partial hkGizmoAttribute Copy(hkGizmoAttribute obj);

        public static partial hkHalf8 Copy(hkHalf8 obj);

        public static partial hkLinkAttribute Copy(hkLinkAttribute obj);

        public static partial hkLocalFrame Copy(hkLocalFrame obj);

        public static partial hkLocalFrameGroup Copy(hkLocalFrameGroup obj);

        public static partial hkMemoryResourceContainer Copy(hkMemoryResourceContainer obj);

        public static partial hkMemoryResourceHandle Copy(hkMemoryResourceHandle obj);

        public static partial hkMemoryResourceHandleExternalLink Copy(
            hkMemoryResourceHandleExternalLink obj
        );

        public static partial hkMemoryTrackerAttribute Copy(hkMemoryTrackerAttribute obj);

        public static partial hkModelerNodeTypeAttribute Copy(hkModelerNodeTypeAttribute obj);

        public static partial hkMoppBvTreeShapeBase Copy(hkMoppBvTreeShapeBase obj);

        public static partial hkMotionState Copy(hkMotionState obj);

        public static partial hkMultiThreadCheck Copy(hkMultiThreadCheck obj);

        public static partial hkpAabbPhantom Copy(hkpAabbPhantom obj);

        public static partial hkPackedVector3 Copy(hkPackedVector3 obj);

        public static partial hkPackfileHeader Copy(hkPackfileHeader obj);

        public static partial hkPackfileSectionHeader Copy(hkPackfileSectionHeader obj);

        public static partial hkpAction Copy(hkpAction obj);

        public static partial hkpAgent1nSector Copy(hkpAgent1nSector obj);

        public static partial hkpAngConstraintAtom Copy(hkpAngConstraintAtom obj);

        public static partial hkpAngFrictionConstraintAtom Copy(hkpAngFrictionConstraintAtom obj);

        public static partial hkpAngLimitConstraintAtom Copy(hkpAngLimitConstraintAtom obj);

        public static partial hkpAngMotorConstraintAtom Copy(hkpAngMotorConstraintAtom obj);

        public static partial hkpAngularDashpotAction Copy(hkpAngularDashpotAction obj);

        public static partial hkpArrayAction Copy(hkpArrayAction obj);

        public static partial hkpBallAndSocketConstraintData Copy(
            hkpBallAndSocketConstraintData obj
        );

        public static partial hkpBallAndSocketConstraintDataAtoms Copy(
            hkpBallAndSocketConstraintDataAtoms obj
        );

        public static partial hkpBallGun Copy(hkpBallGun obj);

        public static partial hkpBallSocketChainData Copy(hkpBallSocketChainData obj);

        public static partial hkpBallSocketChainDataConstraintInfo Copy(
            hkpBallSocketChainDataConstraintInfo obj
        );

        public static partial hkpBallSocketConstraintAtom Copy(hkpBallSocketConstraintAtom obj);

        public static partial hkpBinaryAction Copy(hkpBinaryAction obj);

        public static partial hkpBoxMotion Copy(hkpBoxMotion obj);

        public static partial hkpBoxShape Copy(hkpBoxShape obj);

        public static partial hkpBreakableBody Copy(hkpBreakableBody obj);

        public static partial hkpBreakableConstraintData Copy(hkpBreakableConstraintData obj);

        public static partial hkpBridgeAtoms Copy(hkpBridgeAtoms obj);

        public static partial hkpBridgeConstraintAtom Copy(hkpBridgeConstraintAtom obj);

        public static partial hkpBroadPhaseHandle Copy(hkpBroadPhaseHandle obj);

        public static partial hkpBvShape Copy(hkpBvShape obj);

        public static partial hkpBvTreeShape Copy(hkpBvTreeShape obj);

        public static partial hkpCachingShapePhantom Copy(hkpCachingShapePhantom obj);

        public static partial hkpCallbackConstraintMotor Copy(hkpCallbackConstraintMotor obj);

        public static partial hkpCapsuleShape Copy(hkpCapsuleShape obj);

        public static partial hkpCdBody Copy(hkpCdBody obj);

        public static partial hkpCenterOfMassChangerModifierConstraintAtom Copy(
            hkpCenterOfMassChangerModifierConstraintAtom obj
        );

        public static partial hkpCharacterControllerCinfo Copy(hkpCharacterControllerCinfo obj);

        public static partial hkpCharacterMotion Copy(hkpCharacterMotion obj);

        public static partial hkpCharacterProxyCinfo Copy(hkpCharacterProxyCinfo obj);

        public static partial hkpCharacterRigidBodyCinfo Copy(hkpCharacterRigidBodyCinfo obj);

        public static partial hkpCogWheelConstraintAtom Copy(hkpCogWheelConstraintAtom obj);

        public static partial hkpCogWheelConstraintData Copy(hkpCogWheelConstraintData obj);

        public static partial hkpCogWheelConstraintDataAtoms Copy(
            hkpCogWheelConstraintDataAtoms obj
        );

        public static partial hkpCollidable Copy(hkpCollidable obj);

        public static partial hkpCollidableBoundingVolumeData Copy(
            hkpCollidableBoundingVolumeData obj
        );

        public static partial hkpCollidableCollidableFilter Copy(hkpCollidableCollidableFilter obj);

        public static partial hkpCollisionFilter Copy(hkpCollisionFilter obj);

        public static partial hkpCollisionFilterList Copy(hkpCollisionFilterList obj);

        public static partial hkpCompressedMeshShape Copy(hkpCompressedMeshShape obj);

        public static partial hkpCompressedMeshShapeBigTriangle Copy(
            hkpCompressedMeshShapeBigTriangle obj
        );

        public static partial hkpCompressedMeshShapeChunk Copy(hkpCompressedMeshShapeChunk obj);

        public static partial hkpCompressedMeshShapeConvexPiece Copy(
            hkpCompressedMeshShapeConvexPiece obj
        );

        public static partial hkpCompressedSampledHeightFieldShape Copy(
            hkpCompressedSampledHeightFieldShape obj
        );

        public static partial hkpConeLimitConstraintAtom Copy(hkpConeLimitConstraintAtom obj);

        public static partial hkpConstrainedSystemFilter Copy(hkpConstrainedSystemFilter obj);

        public static partial hkpConstraintAtom Copy(hkpConstraintAtom obj);

        public static partial hkpConstraintChainData Copy(hkpConstraintChainData obj);

        public static partial hkpConstraintChainInstance Copy(hkpConstraintChainInstance obj);

        public static partial hkpConstraintChainInstanceAction Copy(
            hkpConstraintChainInstanceAction obj
        );

        public static partial hkpConstraintCollisionFilter Copy(hkpConstraintCollisionFilter obj);

        public static partial hkpConstraintData Copy(hkpConstraintData obj);

        public static partial hkpConstraintInstance Copy(hkpConstraintInstance obj);

        public static partial hkpConstraintInstanceSmallArraySerializeOverrideType Copy(
            hkpConstraintInstanceSmallArraySerializeOverrideType obj
        );

        public static partial hkpConstraintMotor Copy(hkpConstraintMotor obj);

        public static partial hkpConvexListFilter Copy(hkpConvexListFilter obj);

        public static partial hkpConvexListShape Copy(hkpConvexListShape obj);

        public static partial hkpConvexPieceStreamData Copy(hkpConvexPieceStreamData obj);

        public static partial hkpConvexShape Copy(hkpConvexShape obj);

        public static partial hkpConvexTransformShape Copy(hkpConvexTransformShape obj);

        public static partial hkpConvexTransformShapeBase Copy(hkpConvexTransformShapeBase obj);

        public static partial hkpConvexTranslateShape Copy(hkpConvexTranslateShape obj);

        public static partial hkpConvexVerticesConnectivity Copy(hkpConvexVerticesConnectivity obj);

        public static partial hkpConvexVerticesShape Copy(hkpConvexVerticesShape obj);

        public static partial hkpConvexVerticesShapeFourVectors Copy(
            hkpConvexVerticesShapeFourVectors obj
        );

        public static partial hkpCylinderShape Copy(hkpCylinderShape obj);

        public static partial hkpDashpotAction Copy(hkpDashpotAction obj);

        public static partial hkpDefaultConvexListFilter Copy(hkpDefaultConvexListFilter obj);

        public static partial hkpDefaultWorldMemoryWatchDog Copy(hkpDefaultWorldMemoryWatchDog obj);

        public static partial hkpDisableEntityCollisionFilter Copy(
            hkpDisableEntityCollisionFilter obj
        );

        public static partial hkpDisplayBindingData Copy(hkpDisplayBindingData obj);

        public static partial hkpDisplayBindingDataPhysicsSystem Copy(
            hkpDisplayBindingDataPhysicsSystem obj
        );

        public static partial hkpDisplayBindingDataRigidBody Copy(
            hkpDisplayBindingDataRigidBody obj
        );

        public static partial hkpEntity Copy(hkpEntity obj);

        public static partial hkpEntityExtendedListeners Copy(hkpEntityExtendedListeners obj);

        public static partial hkpEntitySmallArraySerializeOverrideType Copy(
            hkpEntitySmallArraySerializeOverrideType obj
        );

        public static partial hkpEntitySpuCollisionCallback Copy(hkpEntitySpuCollisionCallback obj);

        public static partial hkpFastMeshShape Copy(hkpFastMeshShape obj);

        public static partial hkpFirstPersonGun Copy(hkpFirstPersonGun obj);

        public static partial hkpFixedRigidMotion Copy(hkpFixedRigidMotion obj);

        public static partial hkpGenericConstraintData Copy(hkpGenericConstraintData obj);

        public static partial hkpGenericConstraintDataScheme Copy(
            hkpGenericConstraintDataScheme obj
        );

        public static partial hkpGenericConstraintDataSchemeConstraintInfo Copy(
            hkpGenericConstraintDataSchemeConstraintInfo obj
        );

        public static partial hkpGravityGun Copy(hkpGravityGun obj);

        public static partial hkpGroupCollisionFilter Copy(hkpGroupCollisionFilter obj);

        public static partial hkpGroupFilter Copy(hkpGroupFilter obj);

        public static partial hkpHeightFieldShape Copy(hkpHeightFieldShape obj);

        public static partial hkpHingeConstraintData Copy(hkpHingeConstraintData obj);

        public static partial hkpHingeConstraintDataAtoms Copy(hkpHingeConstraintDataAtoms obj);

        public static partial hkpHingeLimitsData Copy(hkpHingeLimitsData obj);

        public static partial hkpHingeLimitsDataAtoms Copy(hkpHingeLimitsDataAtoms obj);

        public static partial hkpIgnoreModifierConstraintAtom Copy(
            hkpIgnoreModifierConstraintAtom obj
        );

        public static partial hkpKeyframedRigidMotion Copy(hkpKeyframedRigidMotion obj);

        public static partial hkpLimitedForceConstraintMotor Copy(
            hkpLimitedForceConstraintMotor obj
        );

        public static partial hkpLimitedHingeConstraintData Copy(hkpLimitedHingeConstraintData obj);

        public static partial hkpLimitedHingeConstraintDataAtoms Copy(
            hkpLimitedHingeConstraintDataAtoms obj
        );

        public static partial hkpLinConstraintAtom Copy(hkpLinConstraintAtom obj);

        public static partial hkpLinearParametricCurve Copy(hkpLinearParametricCurve obj);

        public static partial hkpLinFrictionConstraintAtom Copy(hkpLinFrictionConstraintAtom obj);

        public static partial hkpLinkedCollidable Copy(hkpLinkedCollidable obj);

        public static partial hkpLinLimitConstraintAtom Copy(hkpLinLimitConstraintAtom obj);

        public static partial hkpLinMotorConstraintAtom Copy(hkpLinMotorConstraintAtom obj);

        public static partial hkpLinSoftConstraintAtom Copy(hkpLinSoftConstraintAtom obj);

        public static partial hkpListShape Copy(hkpListShape obj);

        public static partial hkpListShapeChildInfo Copy(hkpListShapeChildInfo obj);

        public static partial hkpMalleableConstraintData Copy(hkpMalleableConstraintData obj);

        public static partial hkpMassChangerModifierConstraintAtom Copy(
            hkpMassChangerModifierConstraintAtom obj
        );

        public static partial hkpMaterial Copy(hkpMaterial obj);

        public static partial hkpMaxSizeMotion Copy(hkpMaxSizeMotion obj);

        public static partial hkpMeshMaterial Copy(hkpMeshMaterial obj);

        public static partial hkpMeshShape Copy(hkpMeshShape obj);

        public static partial hkpMeshShapeSubpart Copy(hkpMeshShapeSubpart obj);

        public static partial hkpModifierConstraintAtom Copy(hkpModifierConstraintAtom obj);

        public static partial hkpMoppBvTreeShape Copy(hkpMoppBvTreeShape obj);

        public static partial hkpMoppCode Copy(hkpMoppCode obj);

        public static partial hkpMoppCodeCodeInfo Copy(hkpMoppCodeCodeInfo obj);

        public static partial hkpMoppCodeReindexedTerminal Copy(hkpMoppCodeReindexedTerminal obj);

        public static partial hkpMotion Copy(hkpMotion obj);

        public static partial hkpMotorAction Copy(hkpMotorAction obj);

        public static partial hkpMountedBallGun Copy(hkpMountedBallGun obj);

        public static partial hkpMouseSpringAction Copy(hkpMouseSpringAction obj);

        public static partial hkpMovingSurfaceModifierConstraintAtom Copy(
            hkpMovingSurfaceModifierConstraintAtom obj
        );

        public static partial hkpMultiRayShape Copy(hkpMultiRayShape obj);

        public static partial hkpMultiRayShapeRay Copy(hkpMultiRayShapeRay obj);

        public static partial hkpMultiSphereShape Copy(hkpMultiSphereShape obj);

        public static partial hkpNamedMeshMaterial Copy(hkpNamedMeshMaterial obj);

        public static partial hkpNullCollisionFilter Copy(hkpNullCollisionFilter obj);

        public static partial hkPostFinishAttribute Copy(hkPostFinishAttribute obj);

        public static partial hkpOverwritePivotConstraintAtom Copy(
            hkpOverwritePivotConstraintAtom obj
        );

        public static partial hkpPairCollisionFilter Copy(hkpPairCollisionFilter obj);

        public static partial hkpPairCollisionFilterMapPairFilterKeyOverrideType Copy(
            hkpPairCollisionFilterMapPairFilterKeyOverrideType obj
        );

        public static partial hkpParametricCurve Copy(hkpParametricCurve obj);

        public static partial hkpPhantom Copy(hkpPhantom obj);

        public static partial hkpPhantomCallbackShape Copy(hkpPhantomCallbackShape obj);

        public static partial hkpPhysicsData Copy(hkpPhysicsData obj);

        public static partial hkpPhysicsSystem Copy(hkpPhysicsSystem obj);

        public static partial hkpPhysicsSystemWithContacts Copy(hkpPhysicsSystemWithContacts obj);

        public static partial hkpPlaneShape Copy(hkpPlaneShape obj);

        public static partial hkpPointToPathConstraintData Copy(hkpPointToPathConstraintData obj);

        public static partial hkpPointToPlaneConstraintData Copy(hkpPointToPlaneConstraintData obj);

        public static partial hkpPointToPlaneConstraintDataAtoms Copy(
            hkpPointToPlaneConstraintDataAtoms obj
        );

        public static partial hkpPositionConstraintMotor Copy(hkpPositionConstraintMotor obj);

        public static partial hkpPoweredChainData Copy(hkpPoweredChainData obj);

        public static partial hkpPoweredChainDataConstraintInfo Copy(
            hkpPoweredChainDataConstraintInfo obj
        );

        public static partial hkpPoweredChainMapper Copy(hkpPoweredChainMapper obj);

        public static partial hkpPoweredChainMapperLinkInfo Copy(hkpPoweredChainMapperLinkInfo obj);

        public static partial hkpPoweredChainMapperTarget Copy(hkpPoweredChainMapperTarget obj);

        public static partial hkpPrismaticConstraintData Copy(hkpPrismaticConstraintData obj);

        public static partial hkpPrismaticConstraintDataAtoms Copy(
            hkpPrismaticConstraintDataAtoms obj
        );

        public static partial hkpProjectileGun Copy(hkpProjectileGun obj);

        public static partial hkpProperty Copy(hkpProperty obj);

        public static partial hkpPropertyValue Copy(hkpPropertyValue obj);

        public static partial hkpPulleyConstraintAtom Copy(hkpPulleyConstraintAtom obj);

        public static partial hkpPulleyConstraintData Copy(hkpPulleyConstraintData obj);

        public static partial hkpPulleyConstraintDataAtoms Copy(hkpPulleyConstraintDataAtoms obj);

        public static partial hkpRackAndPinionConstraintAtom Copy(
            hkpRackAndPinionConstraintAtom obj
        );

        public static partial hkpRackAndPinionConstraintData Copy(
            hkpRackAndPinionConstraintData obj
        );

        public static partial hkpRackAndPinionConstraintDataAtoms Copy(
            hkpRackAndPinionConstraintDataAtoms obj
        );

        public static partial hkpRagdollConstraintData Copy(hkpRagdollConstraintData obj);

        public static partial hkpRagdollConstraintDataAtoms Copy(hkpRagdollConstraintDataAtoms obj);

        public static partial hkpRagdollLimitsData Copy(hkpRagdollLimitsData obj);

        public static partial hkpRagdollLimitsDataAtoms Copy(hkpRagdollLimitsDataAtoms obj);

        public static partial hkpRagdollMotorConstraintAtom Copy(hkpRagdollMotorConstraintAtom obj);

        public static partial hkpRayCollidableFilter Copy(hkpRayCollidableFilter obj);

        public static partial hkpRayShapeCollectionFilter Copy(hkpRayShapeCollectionFilter obj);

        public static partial hkpRemoveTerminalsMoppModifier Copy(
            hkpRemoveTerminalsMoppModifier obj
        );

        public static partial hkpReorientAction Copy(hkpReorientAction obj);

        public static partial hkpRigidBody Copy(hkpRigidBody obj);

        public static partial hkpRotationalConstraintData Copy(hkpRotationalConstraintData obj);

        public static partial hkpRotationalConstraintDataAtoms Copy(
            hkpRotationalConstraintDataAtoms obj
        );

        public static partial hkpSampledHeightFieldShape Copy(hkpSampledHeightFieldShape obj);

        public static partial hkpSerializedAgentNnEntry Copy(hkpSerializedAgentNnEntry obj);

        public static partial hkpSerializedDisplayMarker Copy(hkpSerializedDisplayMarker obj);

        public static partial hkpSerializedDisplayMarkerList Copy(
            hkpSerializedDisplayMarkerList obj
        );

        public static partial hkpSerializedDisplayRbTransforms Copy(
            hkpSerializedDisplayRbTransforms obj
        );

        public static partial hkpSerializedDisplayRbTransformsDisplayTransformPair Copy(
            hkpSerializedDisplayRbTransformsDisplayTransformPair obj
        );

        public static partial hkpSerializedSubTrack1nInfo Copy(hkpSerializedSubTrack1nInfo obj);

        public static partial hkpSerializedTrack1nInfo Copy(hkpSerializedTrack1nInfo obj);

        public static partial hkpSetLocalRotationsConstraintAtom Copy(
            hkpSetLocalRotationsConstraintAtom obj
        );

        public static partial hkpSetLocalTransformsConstraintAtom Copy(
            hkpSetLocalTransformsConstraintAtom obj
        );

        public static partial hkpSetLocalTranslationsConstraintAtom Copy(
            hkpSetLocalTranslationsConstraintAtom obj
        );

        public static partial hkpSetupStabilizationAtom Copy(hkpSetupStabilizationAtom obj);

        public static partial hkpShape Copy(hkpShape obj);

        public static partial hkpShapeCollection Copy(hkpShapeCollection obj);

        public static partial hkpShapeCollectionFilter Copy(hkpShapeCollectionFilter obj);

        public static partial hkpShapeContainer Copy(hkpShapeContainer obj);

        public static partial hkpShapeInfo Copy(hkpShapeInfo obj);

        public static partial hkpShapeModifier Copy(hkpShapeModifier obj);

        public static partial hkpShapePhantom Copy(hkpShapePhantom obj);

        public static partial hkpSimpleContactConstraintAtom Copy(
            hkpSimpleContactConstraintAtom obj
        );

        public static partial hkpSimpleContactConstraintDataInfo Copy(
            hkpSimpleContactConstraintDataInfo obj
        );

        public static partial hkpSimpleShapePhantom Copy(hkpSimpleShapePhantom obj);

        public static partial hkpSimpleShapePhantomCollisionDetail Copy(
            hkpSimpleShapePhantomCollisionDetail obj
        );

        public static partial hkpSimulation Copy(hkpSimulation obj);

        public static partial hkpSingleShapeContainer Copy(hkpSingleShapeContainer obj);

        public static partial hkpSoftContactModifierConstraintAtom Copy(
            hkpSoftContactModifierConstraintAtom obj
        );

        public static partial hkpSphereMotion Copy(hkpSphereMotion obj);

        public static partial hkpSphereRepShape Copy(hkpSphereRepShape obj);

        public static partial hkpSphereShape Copy(hkpSphereShape obj);

        public static partial hkpSpringAction Copy(hkpSpringAction obj);

        public static partial hkpSpringDamperConstraintMotor Copy(
            hkpSpringDamperConstraintMotor obj
        );

        public static partial hkpStiffSpringChainData Copy(hkpStiffSpringChainData obj);

        public static partial hkpStiffSpringChainDataConstraintInfo Copy(
            hkpStiffSpringChainDataConstraintInfo obj
        );

        public static partial hkpStiffSpringConstraintAtom Copy(hkpStiffSpringConstraintAtom obj);

        public static partial hkpStiffSpringConstraintData Copy(hkpStiffSpringConstraintData obj);

        public static partial hkpStiffSpringConstraintDataAtoms Copy(
            hkpStiffSpringConstraintDataAtoms obj
        );

        public static partial hkpStorageMeshShape Copy(hkpStorageMeshShape obj);

        public static partial hkpStorageMeshShapeSubpartStorage Copy(
            hkpStorageMeshShapeSubpartStorage obj
        );

        public static partial hkpStorageSampledHeightFieldShape Copy(
            hkpStorageSampledHeightFieldShape obj
        );

        public static partial hkpThinBoxMotion Copy(hkpThinBoxMotion obj);

        public static partial hkpTransformShape Copy(hkpTransformShape obj);

        public static partial hkpTriangleShape Copy(hkpTriangleShape obj);

        public static partial hkpTriggerVolume Copy(hkpTriggerVolume obj);

        public static partial hkpTriggerVolumeEventInfo Copy(hkpTriggerVolumeEventInfo obj);

        public static partial hkpTriSampledHeightFieldBvTreeShape Copy(
            hkpTriSampledHeightFieldBvTreeShape obj
        );

        public static partial hkpTriSampledHeightFieldCollection Copy(
            hkpTriSampledHeightFieldCollection obj
        );

        public static partial hkpTwistLimitConstraintAtom Copy(hkpTwistLimitConstraintAtom obj);

        public static partial hkpTypedBroadPhaseHandle Copy(hkpTypedBroadPhaseHandle obj);

        public static partial hkpUnaryAction Copy(hkpUnaryAction obj);

        public static partial hkpVelocityConstraintMotor Copy(hkpVelocityConstraintMotor obj);

        public static partial hkpViscousSurfaceModifierConstraintAtom Copy(
            hkpViscousSurfaceModifierConstraintAtom obj
        );

        public static partial hkpWeldingUtility Copy(hkpWeldingUtility obj);

        public static partial hkpWheelConstraintData Copy(hkpWheelConstraintData obj);

        public static partial hkpWheelConstraintDataAtoms Copy(hkpWheelConstraintDataAtoms obj);

        public static partial hkpWorld Copy(hkpWorld obj);

        public static partial hkpWorldCinfo Copy(hkpWorldCinfo obj);

        public static partial hkpWorldObject Copy(hkpWorldObject obj);

        public static partial hkQTransform Copy(hkQTransform obj);

        public static partial hkRangeInt32Attribute Copy(hkRangeInt32Attribute obj);

        public static partial hkRangeRealAttribute Copy(hkRangeRealAttribute obj);

        public static partial hkReflectedFileAttribute Copy(hkReflectedFileAttribute obj);

        public static partial hkResourceBase Copy(hkResourceBase obj);

        public static partial hkResourceContainer Copy(hkResourceContainer obj);

        public static partial hkResourceHandle Copy(hkResourceHandle obj);

        public static partial hkSemanticsAttribute Copy(hkSemanticsAttribute obj);

        public static partial hkSimpleLocalFrame Copy(hkSimpleLocalFrame obj);

        public static partial hkSphere Copy(hkSphere obj);

        public static partial hkSweptTransform Copy(hkSweptTransform obj);

        public static partial hkTraceStreamTitle Copy(hkTraceStreamTitle obj);

        public static partial hkTrackerSerializableScanSnapshot Copy(
            hkTrackerSerializableScanSnapshot obj
        );

        public static partial hkTrackerSerializableScanSnapshotAllocation Copy(
            hkTrackerSerializableScanSnapshotAllocation obj
        );

        public static partial hkTrackerSerializableScanSnapshotBlock Copy(
            hkTrackerSerializableScanSnapshotBlock obj
        );

        public static partial hkUiAttribute Copy(hkUiAttribute obj);

        public static partial hkWorldMemoryAvailableWatchDog Copy(
            hkWorldMemoryAvailableWatchDog obj
        );

        public static partial hkxAnimatedFloat Copy(hkxAnimatedFloat obj);

        public static partial hkxAnimatedMatrix Copy(hkxAnimatedMatrix obj);

        public static partial hkxAnimatedQuaternion Copy(hkxAnimatedQuaternion obj);

        public static partial hkxAnimatedVector Copy(hkxAnimatedVector obj);

        public static partial hkxAttribute Copy(hkxAttribute obj);

        public static partial hkxAttributeGroup Copy(hkxAttributeGroup obj);

        public static partial hkxAttributeHolder Copy(hkxAttributeHolder obj);

        public static partial hkxCamera Copy(hkxCamera obj);

        public static partial hkxEdgeSelectionChannel Copy(hkxEdgeSelectionChannel obj);

        public static partial hkxEnum Copy(hkxEnum obj);

        public static partial hkxEnumItem Copy(hkxEnumItem obj);

        public static partial hkxEnvironment Copy(hkxEnvironment obj);

        public static partial hkxEnvironmentVariable Copy(hkxEnvironmentVariable obj);

        public static partial hkxIndexBuffer Copy(hkxIndexBuffer obj);

        public static partial hkxLight Copy(hkxLight obj);

        public static partial hkxMaterial Copy(hkxMaterial obj);

        public static partial hkxMaterialEffect Copy(hkxMaterialEffect obj);

        public static partial hkxMaterialProperty Copy(hkxMaterialProperty obj);

        public static partial hkxMaterialShader Copy(hkxMaterialShader obj);

        public static partial hkxMaterialShaderSet Copy(hkxMaterialShaderSet obj);

        public static partial hkxMaterialTextureStage Copy(hkxMaterialTextureStage obj);

        public static partial hkxMesh Copy(hkxMesh obj);

        public static partial hkxMeshSection Copy(hkxMeshSection obj);

        public static partial hkxMeshUserChannelInfo Copy(hkxMeshUserChannelInfo obj);

        public static partial hkxNode Copy(hkxNode obj);

        public static partial hkxNodeAnnotationData Copy(hkxNodeAnnotationData obj);

        public static partial hkxNodeSelectionSet Copy(hkxNodeSelectionSet obj);

        public static partial hkxScene Copy(hkxScene obj);

        public static partial hkxSkinBinding Copy(hkxSkinBinding obj);

        public static partial hkxSparselyAnimatedBool Copy(hkxSparselyAnimatedBool obj);

        public static partial hkxSparselyAnimatedEnum Copy(hkxSparselyAnimatedEnum obj);

        public static partial hkxSparselyAnimatedInt Copy(hkxSparselyAnimatedInt obj);

        public static partial hkxSparselyAnimatedString Copy(hkxSparselyAnimatedString obj);

        public static partial hkxTextureFile Copy(hkxTextureFile obj);

        public static partial hkxTextureInplace Copy(hkxTextureInplace obj);

        public static partial hkxTriangleSelectionChannel Copy(hkxTriangleSelectionChannel obj);

        public static partial hkxVertexBuffer Copy(hkxVertexBuffer obj);

        public static partial hkxVertexBufferVertexData Copy(hkxVertexBufferVertexData obj);

        public static partial hkxVertexDescription Copy(hkxVertexDescription obj);

        public static partial hkxVertexDescriptionElementDecl Copy(
            hkxVertexDescriptionElementDecl obj
        );

        public static partial hkxVertexFloatDataChannel Copy(hkxVertexFloatDataChannel obj);

        public static partial hkxVertexIntDataChannel Copy(hkxVertexIntDataChannel obj);

        public static partial hkxVertexSelectionChannel Copy(hkxVertexSelectionChannel obj);

        public static partial hkxVertexVectorDataChannel Copy(hkxVertexVectorDataChannel obj);

        public static partial AlignMode Copy(AlignMode obj);

        public static partial AnimationType Copy(AnimationType obj);

        public static partial ArrayType Copy(ArrayType obj);

        public static partial AtomType Copy(AtomType obj);

        public static partial AttachmentType Copy(AttachmentType obj);

        public static partial BindingType Copy(BindingType obj);

        public static partial BlendCurve Copy(BlendCurve obj);

        public static partial BlendHint Copy(BlendHint obj);

        public static partial BlendModeFunction Copy(BlendModeFunction obj);

        public static partial BroadPhaseBorderBehaviour Copy(BroadPhaseBorderBehaviour obj);

        public static partial BuildType Copy(BuildType obj);

        public static partial BvTreeType Copy(BvTreeType obj);

        public static partial CallbackType Copy(CallbackType obj);

        public static partial CharacterControlCommand Copy(CharacterControlCommand obj);

        public static partial CollectionType Copy(CollectionType obj);

        public static partial ConstraintPriority Copy(ConstraintPriority obj);

        public static partial ContactPointGeneration Copy(ContactPointGeneration obj);

        public static partial DataType Copy(DataType obj);

        public static partial DataUsage Copy(DataUsage obj);

        public static partial EffectType Copy(EffectType obj);

        public static partial EndMode Copy(EndMode obj);

        public static partial Event Copy(Event obj);

        public static partial EventMode Copy(EventMode obj);

        public static partial EventRangeMode Copy(EventRangeMode obj);

        public static partial ExpressionEventMode Copy(ExpressionEventMode obj);

        public static partial FlagBits Copy(FlagBits obj);

        public static partial GizmoType Copy(GizmoType obj);

        public static partial HeightFieldType Copy(HeightFieldType obj);

        public static partial HideInModeler Copy(HideInModeler obj);

        public static partial Hint Copy(Hint obj);

        public static partial hkpFilterType Copy(hkpFilterType obj);

        public static partial IndexType Copy(IndexType obj);

        public static partial InitialVelocityCoordinates Copy(InitialVelocityCoordinates obj);

        public static partial KeyboardKey Copy(KeyboardKey obj);

        public static partial LastProcessingStep Copy(LastProcessingStep obj);

        public static partial LightType Copy(LightType obj);

        public static partial LinearVelocityMode Copy(LinearVelocityMode obj);

        public static partial Link Copy(Link obj);

        public static partial MappingType Copy(MappingType obj);

        public static partial MaterialType Copy(MaterialType obj);

        public static partial MeasurementMode Copy(MeasurementMode obj);

        public static partial MeshShapeIndexStridingType Copy(MeshShapeIndexStridingType obj);

        public static partial MeshShapeMaterialIndexStridingType Copy(
            MeshShapeMaterialIndexStridingType obj
        );

        public static partial Mode Copy(Mode obj);

        public static partial ModelerType Copy(ModelerType obj);

        public static partial MotionMode Copy(MotionMode obj);

        public static partial MotionType Copy(MotionType obj);

        public static partial MotorType Copy(MotorType obj);

        public static partial NodeType Copy(NodeType obj);

        public static partial OnDestructionRemapInfo Copy(OnDestructionRemapInfo obj);

        public static partial Operation Copy(Operation obj);

        public static partial Operator Copy(Operator obj);

        public static partial OrientationConstraintType Copy(OrientationConstraintType obj);

        public static partial PhantomType Copy(PhantomType obj);

        public static partial PlaybackMode Copy(PlaybackMode obj);

        public static partial ResponseType Copy(ResponseType obj);

        public static partial Role Copy(Role obj);

        public static partial RoleFlags Copy(RoleFlags obj);

        public static partial RotationAxisCoordinates Copy(RotationAxisCoordinates obj);

        public static partial RotationQuantization Copy(RotationQuantization obj);

        public static partial ScalarQuantization Copy(ScalarQuantization obj);

        public static partial SelfTransitionMode Copy(SelfTransitionMode obj);

        public static partial Semantics Copy(Semantics obj);

        public static partial SensingMode Copy(SensingMode obj);

        public static partial SerializedAgentType Copy(SerializedAgentType obj);

        public static partial SetAngleMethod Copy(SetAngleMethod obj);

        public static partial ShaderType Copy(ShaderType obj);

        public static partial SimulationControlCommand Copy(SimulationControlCommand obj);

        public static partial SimulationState Copy(SimulationState obj);

        public static partial SimulationType Copy(SimulationType obj);

        public static partial SolvingMethod Copy(SolvingMethod obj);

        public static partial Stage Copy(Stage obj);

        public static partial StartStateMode Copy(StartStateMode obj);

        public static partial StateMachineSelfTransitionMode Copy(
            StateMachineSelfTransitionMode obj
        );

        public static partial SystemType Copy(SystemType obj);

        public static partial TextureType Copy(TextureType obj);

        public static partial ToGeneratorState Copy(ToGeneratorState obj);

        public static partial TokenType Copy(TokenType obj);

        public static partial ToolNodeType Copy(ToolNodeType obj);

        public static partial TransitionFlags Copy(TransitionFlags obj);

        public static partial TreeUpdateType Copy(TreeUpdateType obj);

        public static partial Type Copy(Type obj);

        public static partial VariableMode Copy(VariableMode obj);

        public static partial VertexFloatDimensions Copy(VertexFloatDimensions obj);

        public static partial WeldingType Copy(WeldingType obj);

        public static partial WorldFromModelMode Copy(WorldFromModelMode obj);
        #endregion
    }
}
