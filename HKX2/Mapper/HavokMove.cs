using Riok.Mapperly.Abstractions;

namespace HKX2E.Mapper
{
    /// <summary>
    /// C++ users: see aboutmapping.txt
    /// </summary>
    [Mapper(UseReferenceHandling = false)]
    public partial class HavokMove
    {
        #region MoveSelf
        public static void Move<T>(T source, T dest) where T : IHavokObject
        {
            switch(source)
            {
                case BGSGamebryoSequenceGenerator x:
                    Move(x, (BGSGamebryoSequenceGenerator)(object)dest);
                    break;
                case BSBoneSwitchGenerator x:
                    Move(x, (BSBoneSwitchGenerator)(object)dest);
                    break;
                case BSBoneSwitchGeneratorBoneData x:
                    Move(x, (BSBoneSwitchGeneratorBoneData)(object)dest);
                    break;
                case BSComputeAddBoneAnimModifier x:
                    Move(x, (BSComputeAddBoneAnimModifier)(object)dest);
                    break;
                case BSCyclicBlendTransitionGenerator x:
                    Move(x, (BSCyclicBlendTransitionGenerator)(object)dest);
                    break;
                case BSDecomposeVectorModifier x:
                    Move(x, (BSDecomposeVectorModifier)(object)dest);
                    break;
                case BSDirectAtModifier x:
                    Move(x, (BSDirectAtModifier)(object)dest);
                    break;
                case BSDistTriggerModifier x:
                    Move(x, (BSDistTriggerModifier)(object)dest);
                    break;
                case BSEventEveryNEventsModifier x:
                    Move(x, (BSEventEveryNEventsModifier)(object)dest);
                    break;
                case BSEventOnDeactivateModifier x:
                    Move(x, (BSEventOnDeactivateModifier)(object)dest);
                    break;
                case BSEventOnFalseToTrueModifier x:
                    Move(x, (BSEventOnFalseToTrueModifier)(object)dest);
                    break;
                case BSGetTimeStepModifier x:
                    Move(x, (BSGetTimeStepModifier)(object)dest);
                    break;
                case BSInterpValueModifier x:
                    Move(x, (BSInterpValueModifier)(object)dest);
                    break;
                case BSIsActiveModifier x:
                    Move(x, (BSIsActiveModifier)(object)dest);
                    break;
                case BSIStateManagerModifier x:
                    Move(x, (BSIStateManagerModifier)(object)dest);
                    break;
                case BSIStateManagerModifierBSiStateData x:
                    Move(x, (BSIStateManagerModifierBSiStateData)(object)dest);
                    break;
                case BSIStateManagerModifierBSIStateManagerStateListener x:
                    Move(x, (BSIStateManagerModifierBSIStateManagerStateListener)(object)dest);
                    break;
                case BSiStateTaggingGenerator x:
                    Move(x, (BSiStateTaggingGenerator)(object)dest);
                    break;
                case BSLimbIKModifier x:
                    Move(x, (BSLimbIKModifier)(object)dest);
                    break;
                case BSLookAtModifier x:
                    Move(x, (BSLookAtModifier)(object)dest);
                    break;
                case BSLookAtModifierBoneData x:
                    Move(x, (BSLookAtModifierBoneData)(object)dest);
                    break;
                case BSModifyOnceModifier x:
                    Move(x, (BSModifyOnceModifier)(object)dest);
                    break;
                case BSOffsetAnimationGenerator x:
                    Move(x, (BSOffsetAnimationGenerator)(object)dest);
                    break;
                case BSPassByTargetTriggerModifier x:
                    Move(x, (BSPassByTargetTriggerModifier)(object)dest);
                    break;
                case BSRagdollContactListenerModifier x:
                    Move(x, (BSRagdollContactListenerModifier)(object)dest);
                    break;
                case BSSpeedSamplerModifier x:
                    Move(x, (BSSpeedSamplerModifier)(object)dest);
                    break;
                case BSSynchronizedClipGenerator x:
                    Move(x, (BSSynchronizedClipGenerator)(object)dest);
                    break;
                case BSTimerModifier x:
                    Move(x, (BSTimerModifier)(object)dest);
                    break;
                case BSTweenerModifier x:
                    Move(x, (BSTweenerModifier)(object)dest);
                    break;
                case hkAabb x:
                    Move(x, (hkAabb)(object)dest);
                    break;
                case hkAabbHalf x:
                    Move(x, (hkAabbHalf)(object)dest);
                    break;
                case hkAabbUint32 x:
                    Move(x, (hkAabbUint32)(object)dest);
                    break;
                case hkaInterleavedUncompressedAnimation x:
                    Move(x, (hkaInterleavedUncompressedAnimation)(object)dest);
                    break;
                case hkaAnimationBinding x:
                    Move(x, (hkaAnimationBinding)(object)dest);
                    break;
                case hkaAnimationContainer x:
                    Move(x, (hkaAnimationContainer)(object)dest);
                    break;
                case hkaAnimationPreviewColorContainer x:
                    Move(x, (hkaAnimationPreviewColorContainer)(object)dest);
                    break;
                case hkaAnnotationTrack x:
                    Move(x, (hkaAnnotationTrack)(object)dest);
                    break;
                case hkaAnnotationTrackAnnotation x:
                    Move(x, (hkaAnnotationTrackAnnotation)(object)dest);
                    break;
                case hkaBone x:
                    Move(x, (hkaBone)(object)dest);
                    break;
                case hkaBoneAttachment x:
                    Move(x, (hkaBoneAttachment)(object)dest);
                    break;
                case hkaDefaultAnimatedReferenceFrame x:
                    Move(x, (hkaDefaultAnimatedReferenceFrame)(object)dest);
                    break;
                case hkaFootstepAnalysisInfo x:
                    Move(x, (hkaFootstepAnalysisInfo)(object)dest);
                    break;
                case hkaFootstepAnalysisInfoContainer x:
                    Move(x, (hkaFootstepAnalysisInfoContainer)(object)dest);
                    break;
                case hkaKeyFrameHierarchyUtility x:
                    Move(x, (hkaKeyFrameHierarchyUtility)(object)dest);
                    break;
                case hkaKeyFrameHierarchyUtilityControlData x:
                    Move(x, (hkaKeyFrameHierarchyUtilityControlData)(object)dest);
                    break;
                case hkAlignSceneToNodeOptions x:
                    Move(x, (hkAlignSceneToNodeOptions)(object)dest);
                    break;
                case hkaMeshBinding x:
                    Move(x, (hkaMeshBinding)(object)dest);
                    break;
                case hkaMeshBindingMapping x:
                    Move(x, (hkaMeshBindingMapping)(object)dest);
                    break;
                case hkaQuantizedAnimation x:
                    Move(x, (hkaQuantizedAnimation)(object)dest);
                    break;
                case hkaQuantizedAnimationTrackCompressionParams x:
                    Move(x, (hkaQuantizedAnimationTrackCompressionParams)(object)dest);
                    break;
                case hkaRagdollInstance x:
                    Move(x, (hkaRagdollInstance)(object)dest);
                    break;
                case hkArrayTypeAttribute x:
                    Move(x, (hkArrayTypeAttribute)(object)dest);
                    break;
                case hkaSkeleton x:
                    Move(x, (hkaSkeleton)(object)dest);
                    break;
                case hkaSkeletonLocalFrameOnBone x:
                    Move(x, (hkaSkeletonLocalFrameOnBone)(object)dest);
                    break;
                case hkaSkeletonMapper x:
                    Move(x, (hkaSkeletonMapper)(object)dest);
                    break;
                case hkaSkeletonMapperData x:
                    Move(x, (hkaSkeletonMapperData)(object)dest);
                    break;
                case hkaSkeletonMapperDataChainMapping x:
                    Move(x, (hkaSkeletonMapperDataChainMapping)(object)dest);
                    break;
                case hkaSkeletonMapperDataSimpleMapping x:
                    Move(x, (hkaSkeletonMapperDataSimpleMapping)(object)dest);
                    break;
                case hkaSplineCompressedAnimation x:
                    Move(x, (hkaSplineCompressedAnimation)(object)dest);
                    break;
                case hkaSplineCompressedAnimationAnimationCompressionParams x:
                    Move(x, (hkaSplineCompressedAnimationAnimationCompressionParams)(object)dest);
                    break;
                case hkaSplineCompressedAnimationTrackCompressionParams x:
                    Move(x, (hkaSplineCompressedAnimationTrackCompressionParams)(object)dest);
                    break;
                case hkaAnimatedReferenceFrame x:
                    Move(x, (hkaAnimatedReferenceFrame)(object)dest);
                    break;
                case hkaAnimation x:
                    Move(x, (hkaAnimation)(object)dest);
                    break;
                case hkbAttachmentModifier x:
                    Move(x, (hkbAttachmentModifier)(object)dest);
                    break;
                case hkbAttachmentSetup x:
                    Move(x, (hkbAttachmentSetup)(object)dest);
                    break;
                case hkbAttributeModifier x:
                    Move(x, (hkbAttributeModifier)(object)dest);
                    break;
                case hkbAttributeModifierAssignment x:
                    Move(x, (hkbAttributeModifierAssignment)(object)dest);
                    break;
                case hkbAuxiliaryNodeInfo x:
                    Move(x, (hkbAuxiliaryNodeInfo)(object)dest);
                    break;
                case hkbBehaviorEventsInfo x:
                    Move(x, (hkbBehaviorEventsInfo)(object)dest);
                    break;
                case hkbBehaviorGraph x:
                    Move(x, (hkbBehaviorGraph)(object)dest);
                    break;
                case hkbBehaviorGraphData x:
                    Move(x, (hkbBehaviorGraphData)(object)dest);
                    break;
                case hkbBehaviorGraphInternalState x:
                    Move(x, (hkbBehaviorGraphInternalState)(object)dest);
                    break;
                case hkbBehaviorGraphInternalStateInfo x:
                    Move(x, (hkbBehaviorGraphInternalStateInfo)(object)dest);
                    break;
                case hkbBehaviorGraphStringData x:
                    Move(x, (hkbBehaviorGraphStringData)(object)dest);
                    break;
                case hkbBehaviorInfo x:
                    Move(x, (hkbBehaviorInfo)(object)dest);
                    break;
                case hkbBehaviorInfoIdToNamePair x:
                    Move(x, (hkbBehaviorInfoIdToNamePair)(object)dest);
                    break;
                case hkbBehaviorReferenceGenerator x:
                    Move(x, (hkbBehaviorReferenceGenerator)(object)dest);
                    break;
                case hkbBlendCurveUtils x:
                    Move(x, (hkbBlendCurveUtils)(object)dest);
                    break;
                case hkbBlenderGeneratorChild x:
                    Move(x, (hkbBlenderGeneratorChild)(object)dest);
                    break;
                case hkbBlenderGeneratorChildInternalState x:
                    Move(x, (hkbBlenderGeneratorChildInternalState)(object)dest);
                    break;
                case hkbBlenderGeneratorInternalState x:
                    Move(x, (hkbBlenderGeneratorInternalState)(object)dest);
                    break;
                case hkbBlendingTransitionEffect x:
                    Move(x, (hkbBlendingTransitionEffect)(object)dest);
                    break;
                case hkbBlendingTransitionEffectInternalState x:
                    Move(x, (hkbBlendingTransitionEffectInternalState)(object)dest);
                    break;
                case hkbBoneIndexArray x:
                    Move(x, (hkbBoneIndexArray)(object)dest);
                    break;
                case hkbBoneWeightArray x:
                    Move(x, (hkbBoneWeightArray)(object)dest);
                    break;
                case hkbBoolVariableSequencedData x:
                    Move(x, (hkbBoolVariableSequencedData)(object)dest);
                    break;
                case hkbBoolVariableSequencedDataSample x:
                    Move(x, (hkbBoolVariableSequencedDataSample)(object)dest);
                    break;
                case hkbCameraShakeEventPayload x:
                    Move(x, (hkbCameraShakeEventPayload)(object)dest);
                    break;
                case hkbCharacter x:
                    Move(x, (hkbCharacter)(object)dest);
                    break;
                case hkbCharacterAddedInfo x:
                    Move(x, (hkbCharacterAddedInfo)(object)dest);
                    break;
                case hkbCharacterControlCommand x:
                    Move(x, (hkbCharacterControlCommand)(object)dest);
                    break;
                case hkbCharacterControllerControlData x:
                    Move(x, (hkbCharacterControllerControlData)(object)dest);
                    break;
                case hkbCharacterControllerModifier x:
                    Move(x, (hkbCharacterControllerModifier)(object)dest);
                    break;
                case hkbCharacterControllerModifierInternalState x:
                    Move(x, (hkbCharacterControllerModifierInternalState)(object)dest);
                    break;
                case hkbCharacterData x:
                    Move(x, (hkbCharacterData)(object)dest);
                    break;
                case hkbCharacterDataCharacterControllerInfo x:
                    Move(x, (hkbCharacterDataCharacterControllerInfo)(object)dest);
                    break;
                case hkbCharacterInfo x:
                    Move(x, (hkbCharacterInfo)(object)dest);
                    break;
                case hkbCharacterSetup x:
                    Move(x, (hkbCharacterSetup)(object)dest);
                    break;
                case hkbCharacterSkinInfo x:
                    Move(x, (hkbCharacterSkinInfo)(object)dest);
                    break;
                case hkbCharacterSteppedInfo x:
                    Move(x, (hkbCharacterSteppedInfo)(object)dest);
                    break;
                case hkbCharacterStringData x:
                    Move(x, (hkbCharacterStringData)(object)dest);
                    break;
                case hkbClientCharacterState x:
                    Move(x, (hkbClientCharacterState)(object)dest);
                    break;
                case hkbClipGenerator x:
                    Move(x, (hkbClipGenerator)(object)dest);
                    break;
                case hkbClipGeneratorEcho x:
                    Move(x, (hkbClipGeneratorEcho)(object)dest);
                    break;
                case hkbClipGeneratorInternalState x:
                    Move(x, (hkbClipGeneratorInternalState)(object)dest);
                    break;
                case hkbClipTrigger x:
                    Move(x, (hkbClipTrigger)(object)dest);
                    break;
                case hkbClipTriggerArray x:
                    Move(x, (hkbClipTriggerArray)(object)dest);
                    break;
                case hkbCombineTransformsModifier x:
                    Move(x, (hkbCombineTransformsModifier)(object)dest);
                    break;
                case hkbCombineTransformsModifierInternalState x:
                    Move(x, (hkbCombineTransformsModifierInternalState)(object)dest);
                    break;
                case hkbCompiledExpressionSet x:
                    Move(x, (hkbCompiledExpressionSet)(object)dest);
                    break;
                case hkbCompiledExpressionSetToken x:
                    Move(x, (hkbCompiledExpressionSetToken)(object)dest);
                    break;
                case hkbComputeDirectionModifier x:
                    Move(x, (hkbComputeDirectionModifier)(object)dest);
                    break;
                case hkbComputeDirectionModifierInternalState x:
                    Move(x, (hkbComputeDirectionModifierInternalState)(object)dest);
                    break;
                case hkbComputeRotationFromAxisAngleModifier x:
                    Move(x, (hkbComputeRotationFromAxisAngleModifier)(object)dest);
                    break;
                case hkbComputeRotationFromAxisAngleModifierInternalState x:
                    Move(x, (hkbComputeRotationFromAxisAngleModifierInternalState)(object)dest);
                    break;
                case hkbComputeRotationToTargetModifier x:
                    Move(x, (hkbComputeRotationToTargetModifier)(object)dest);
                    break;
                case hkbComputeRotationToTargetModifierInternalState x:
                    Move(x, (hkbComputeRotationToTargetModifierInternalState)(object)dest);
                    break;
                case hkbContext x:
                    Move(x, (hkbContext)(object)dest);
                    break;
                case hkbDampingModifier x:
                    Move(x, (hkbDampingModifier)(object)dest);
                    break;
                case hkbDampingModifierInternalState x:
                    Move(x, (hkbDampingModifierInternalState)(object)dest);
                    break;
                case hkbDefaultMessageLog x:
                    Move(x, (hkbDefaultMessageLog)(object)dest);
                    break;
                case hkbDelayedModifier x:
                    Move(x, (hkbDelayedModifier)(object)dest);
                    break;
                case hkbDelayedModifierInternalState x:
                    Move(x, (hkbDelayedModifierInternalState)(object)dest);
                    break;
                case hkbDetectCloseToGroundModifier x:
                    Move(x, (hkbDetectCloseToGroundModifier)(object)dest);
                    break;
                case hkbDetectCloseToGroundModifierInternalState x:
                    Move(x, (hkbDetectCloseToGroundModifierInternalState)(object)dest);
                    break;
                case hkbEvaluateExpressionModifier x:
                    Move(x, (hkbEvaluateExpressionModifier)(object)dest);
                    break;
                case hkbEvaluateExpressionModifierInternalExpressionData x:
                    Move(x, (hkbEvaluateExpressionModifierInternalExpressionData)(object)dest);
                    break;
                case hkbEvaluateExpressionModifierInternalState x:
                    Move(x, (hkbEvaluateExpressionModifierInternalState)(object)dest);
                    break;
                case hkbEvaluateHandleModifier x:
                    Move(x, (hkbEvaluateHandleModifier)(object)dest);
                    break;
                case hkbEvent x:
                    Move(x, (hkbEvent)(object)dest);
                    break;

                case hkbEventDrivenModifier x:
                    Move(x, (hkbEventDrivenModifier)(object)dest);
                    break;
                case hkbEventDrivenModifierInternalState x:
                    Move(x, (hkbEventDrivenModifierInternalState)(object)dest);
                    break;
                case hkbEventInfo x:
                    Move(x, (hkbEventInfo)(object)dest);
                    break;
                case hkbEventPayloadList x:
                    Move(x, (hkbEventPayloadList)(object)dest);
                    break;
                case hkbEventProperty x:
                    Move(x, (hkbEventProperty)(object)dest);
                    break;
                case hkbEventBase x:
                    Move(x, (hkbEventBase)(object)dest);
                    break;
                case hkbEventRaisedInfo x:
                    Move(x, (hkbEventRaisedInfo)(object)dest);
                    break;
                case hkbEventRangeData x:
                    Move(x, (hkbEventRangeData)(object)dest);
                    break;
                case hkbEventRangeDataArray x:
                    Move(x, (hkbEventRangeDataArray)(object)dest);
                    break;
                case hkbEventSequencedData x:
                    Move(x, (hkbEventSequencedData)(object)dest);
                    break;
                case hkbEventSequencedDataSequencedEvent x:
                    Move(x, (hkbEventSequencedDataSequencedEvent)(object)dest);
                    break;
                case hkbEventsFromRangeModifier x:
                    Move(x, (hkbEventsFromRangeModifier)(object)dest);
                    break;
                case hkbEventsFromRangeModifierInternalState x:
                    Move(x, (hkbEventsFromRangeModifierInternalState)(object)dest);
                    break;
                case hkbExpressionCondition x:
                    Move(x, (hkbExpressionCondition)(object)dest);
                    break;
                case hkbExpressionData x:
                    Move(x, (hkbExpressionData)(object)dest);
                    break;
                case hkbExpressionDataArray x:
                    Move(x, (hkbExpressionDataArray)(object)dest);
                    break;
                case hkbExtractRagdollPoseModifier x:
                    Move(x, (hkbExtractRagdollPoseModifier)(object)dest);
                    break;
                case hkbFootIkControlData x:
                    Move(x, (hkbFootIkControlData)(object)dest);
                    break;
                case hkbFootIkControlsModifier x:
                    Move(x, (hkbFootIkControlsModifier)(object)dest);
                    break;
                case hkbFootIkControlsModifierLeg x:
                    Move(x, (hkbFootIkControlsModifierLeg)(object)dest);
                    break;
                case hkbFootIkDriverInfo x:
                    Move(x, (hkbFootIkDriverInfo)(object)dest);
                    break;
                case hkbFootIkDriverInfoLeg x:
                    Move(x, (hkbFootIkDriverInfoLeg)(object)dest);
                    break;
                case hkbFootIkGains x:
                    Move(x, (hkbFootIkGains)(object)dest);
                    break;
                case hkbFootIkModifier x:
                    Move(x, (hkbFootIkModifier)(object)dest);
                    break;
                case hkbFootIkModifierInternalLegData x:
                    Move(x, (hkbFootIkModifierInternalLegData)(object)dest);
                    break;
                case hkbFootIkModifierLeg x:
                    Move(x, (hkbFootIkModifierLeg)(object)dest);
                    break;
                case hkbGeneratorOutputListener x:
                    Move(x, (hkbGeneratorOutputListener)(object)dest);
                    break;
                case hkbGeneratorSyncInfo x:
                    Move(x, (hkbGeneratorSyncInfo)(object)dest);
                    break;
                case hkbGeneratorSyncInfoSyncPoint x:
                    Move(x, (hkbGeneratorSyncInfoSyncPoint)(object)dest);
                    break;
                case hkbGeneratorTransitionEffect x:
                    Move(x, (hkbGeneratorTransitionEffect)(object)dest);
                    break;
                case hkbGeneratorTransitionEffectInternalState x:
                    Move(x, (hkbGeneratorTransitionEffectInternalState)(object)dest);
                    break;
                case hkbGetHandleOnBoneModifier x:
                    Move(x, (hkbGetHandleOnBoneModifier)(object)dest);
                    break;
                case hkbGetUpModifier x:
                    Move(x, (hkbGetUpModifier)(object)dest);
                    break;
                case hkbGetUpModifierInternalState x:
                    Move(x, (hkbGetUpModifierInternalState)(object)dest);
                    break;
                case hkbGetWorldFromModelModifier x:
                    Move(x, (hkbGetWorldFromModelModifier)(object)dest);
                    break;
                case hkbGetWorldFromModelModifierInternalState x:
                    Move(x, (hkbGetWorldFromModelModifierInternalState)(object)dest);
                    break;
                case hkbHandIkControlData x:
                    Move(x, (hkbHandIkControlData)(object)dest);
                    break;
                case hkbHandIkControlsModifier x:
                    Move(x, (hkbHandIkControlsModifier)(object)dest);
                    break;
                case hkbHandIkControlsModifierHand x:
                    Move(x, (hkbHandIkControlsModifierHand)(object)dest);
                    break;
                case hkbHandIkDriverInfo x:
                    Move(x, (hkbHandIkDriverInfo)(object)dest);
                    break;
                case hkbHandIkDriverInfoHand x:
                    Move(x, (hkbHandIkDriverInfoHand)(object)dest);
                    break;
                case hkbHandIkModifier x:
                    Move(x, (hkbHandIkModifier)(object)dest);
                    break;
                case hkbHandIkModifierHand x:
                    Move(x, (hkbHandIkModifierHand)(object)dest);
                    break;
                case hkbHandle x:
                    Move(x, (hkbHandle)(object)dest);
                    break;
                case hkbIntEventPayload x:
                    Move(x, (hkbIntEventPayload)(object)dest);
                    break;
                case hkbIntVariableSequencedData x:
                    Move(x, (hkbIntVariableSequencedData)(object)dest);
                    break;
                case hkbIntVariableSequencedDataSample x:
                    Move(x, (hkbIntVariableSequencedDataSample)(object)dest);
                    break;
                case hkBitField x:
                    Move(x, (hkBitField)(object)dest);
                    break;
                case hkbKeyframeBonesModifier x:
                    Move(x, (hkbKeyframeBonesModifier)(object)dest);
                    break;
                case hkbKeyframeBonesModifierKeyframeInfo x:
                    Move(x, (hkbKeyframeBonesModifierKeyframeInfo)(object)dest);
                    break;
                case hkbLinkedSymbolInfo x:
                    Move(x, (hkbLinkedSymbolInfo)(object)dest);
                    break;
                case hkbLookAtModifier x:
                    Move(x, (hkbLookAtModifier)(object)dest);
                    break;
                case hkbLookAtModifierInternalState x:
                    Move(x, (hkbLookAtModifierInternalState)(object)dest);
                    break;
                case hkbManualSelectorGenerator x:
                    Move(x, (hkbManualSelectorGenerator)(object)dest);
                    break;
                case hkbManualSelectorGeneratorInternalState x:
                    Move(x, (hkbManualSelectorGeneratorInternalState)(object)dest);
                    break;
                case hkbMessageLog x:
                    Move(x, (hkbMessageLog)(object)dest);
                    break;
                case hkbMirroredSkeletonInfo x:
                    Move(x, (hkbMirroredSkeletonInfo)(object)dest);
                    break;
                case hkbMirrorModifier x:
                    Move(x, (hkbMirrorModifier)(object)dest);
                    break;
                case hkbModifierGenerator x:
                    Move(x, (hkbModifierGenerator)(object)dest);
                    break;
                case hkbModifierList x:
                    Move(x, (hkbModifierList)(object)dest);
                    break;
                case hkbModifierWrapper x:
                    Move(x, (hkbModifierWrapper)(object)dest);
                    break;
                case hkbMoveCharacterModifier x:
                    Move(x, (hkbMoveCharacterModifier)(object)dest);
                    break;
                case hkbMoveCharacterModifierInternalState x:
                    Move(x, (hkbMoveCharacterModifierInternalState)(object)dest);
                    break;
                case hkbNamedIntEventPayload x:
                    Move(x, (hkbNamedIntEventPayload)(object)dest);
                    break;
                case hkbNamedRealEventPayload x:
                    Move(x, (hkbNamedRealEventPayload)(object)dest);
                    break;
                case hkbNamedStringEventPayload x:
                    Move(x, (hkbNamedStringEventPayload)(object)dest);
                    break;
                case hkbNamedEventPayload x:
                    Move(x, (hkbNamedEventPayload)(object)dest);
                    break;
                case hkbNodeInternalStateInfo x:
                    Move(x, (hkbNodeInternalStateInfo)(object)dest);
                    break;
                case hkbParticleSystemEventPayload x:
                    Move(x, (hkbParticleSystemEventPayload)(object)dest);
                    break;
                case hkbPoseMatchingGenerator x:
                    Move(x, (hkbPoseMatchingGenerator)(object)dest);
                    break;
                case hkbPoseMatchingGeneratorInternalState x:
                    Move(x, (hkbPoseMatchingGeneratorInternalState)(object)dest);
                    break;
                case hkbPoweredRagdollControlData x:
                    Move(x, (hkbPoweredRagdollControlData)(object)dest);
                    break;
                case hkbPoweredRagdollControlsModifier x:
                    Move(x, (hkbPoweredRagdollControlsModifier)(object)dest);
                    break;
                case hkbProjectData x:
                    Move(x, (hkbProjectData)(object)dest);
                    break;
                case hkbProjectStringData x:
                    Move(x, (hkbProjectStringData)(object)dest);
                    break;
                case hkbProxyModifier x:
                    Move(x, (hkbProxyModifier)(object)dest);
                    break;
                case hkbProxyModifierProxyInfo x:
                    Move(x, (hkbProxyModifierProxyInfo)(object)dest);
                    break;
                case hkbRaiseEventCommand x:
                    Move(x, (hkbRaiseEventCommand)(object)dest);
                    break;
                case hkbRealEventPayload x:
                    Move(x, (hkbRealEventPayload)(object)dest);
                    break;
                case hkbRealVariableSequencedData x:
                    Move(x, (hkbRealVariableSequencedData)(object)dest);
                    break;
                case hkbRealVariableSequencedDataSample x:
                    Move(x, (hkbRealVariableSequencedDataSample)(object)dest);
                    break;
                case hkbReferencePoseGenerator x:
                    Move(x, (hkbReferencePoseGenerator)(object)dest);
                    break;
                case hkbRegisteredGenerator x:
                    Move(x, (hkbRegisteredGenerator)(object)dest);
                    break;
                case hkbRigidBodyRagdollControlData x:
                    Move(x, (hkbRigidBodyRagdollControlData)(object)dest);
                    break;
                case hkbRigidBodyRagdollControlsModifier x:
                    Move(x, (hkbRigidBodyRagdollControlsModifier)(object)dest);
                    break;
                case hkbRotateCharacterModifier x:
                    Move(x, (hkbRotateCharacterModifier)(object)dest);
                    break;
                case hkbRotateCharacterModifierInternalState x:
                    Move(x, (hkbRotateCharacterModifierInternalState)(object)dest);
                    break;
                case hkbSenseHandleModifier x:
                    Move(x, (hkbSenseHandleModifier)(object)dest);
                    break;
                case hkbSenseHandleModifierRange x:
                    Move(x, (hkbSenseHandleModifierRange)(object)dest);
                    break;
                case hkbSequence x:
                    Move(x, (hkbSequence)(object)dest);
                    break;
                case hkbSequencedData x:
                    Move(x, (hkbSequencedData)(object)dest);
                    break;
                case hkbSequenceInternalState x:
                    Move(x, (hkbSequenceInternalState)(object)dest);
                    break;
                case hkbSequenceStringData x:
                    Move(x, (hkbSequenceStringData)(object)dest);
                    break;
                case hkbSetBehaviorCommand x:
                    Move(x, (hkbSetBehaviorCommand)(object)dest);
                    break;
                case hkbSetLocalTimeOfClipGeneratorCommand x:
                    Move(x, (hkbSetLocalTimeOfClipGeneratorCommand)(object)dest);
                    break;
                case hkbSetNodePropertyCommand x:
                    Move(x, (hkbSetNodePropertyCommand)(object)dest);
                    break;
                case hkbSetWordVariableCommand x:
                    Move(x, (hkbSetWordVariableCommand)(object)dest);
                    break;
                case hkbSetWorldFromModelModifier x:
                    Move(x, (hkbSetWorldFromModelModifier)(object)dest);
                    break;
                case hkbSimulationControlCommand x:
                    Move(x, (hkbSimulationControlCommand)(object)dest);
                    break;
                case hkbSimulationStateInfo x:
                    Move(x, (hkbSimulationStateInfo)(object)dest);
                    break;

                case hkbStateListener x:
                    Move(x, (hkbStateListener)(object)dest);
                    break;
                case hkbStateMachine x:
                    Move(x, (hkbStateMachine)(object)dest);
                    break;
                case hkbStateMachineActiveTransitionInfo x:
                    Move(x, (hkbStateMachineActiveTransitionInfo)(object)dest);
                    break;
                case hkbStateMachineDelayedTransitionInfo x:
                    Move(x, (hkbStateMachineDelayedTransitionInfo)(object)dest);
                    break;
                case hkbStateMachineEventPropertyArray x:
                    Move(x, (hkbStateMachineEventPropertyArray)(object)dest);
                    break;
                case hkbStateMachineInternalState x:
                    Move(x, (hkbStateMachineInternalState)(object)dest);
                    break;
                case hkbStateMachineNestedStateMachineData x:
                    Move(x, (hkbStateMachineNestedStateMachineData)(object)dest);
                    break;
                case hkbStateMachineProspectiveTransitionInfo x:
                    Move(x, (hkbStateMachineProspectiveTransitionInfo)(object)dest);
                    break;
                case hkbStateMachineStateInfo x:
                    Move(x, (hkbStateMachineStateInfo)(object)dest);
                    break;
                case hkbStateMachineTimeInterval x:
                    Move(x, (hkbStateMachineTimeInterval)(object)dest);
                    break;
                case hkbStateMachineTransitionInfo x:
                    Move(x, (hkbStateMachineTransitionInfo)(object)dest);
                    break;
                case hkbStateMachineTransitionInfoArray x:
                    Move(x, (hkbStateMachineTransitionInfoArray)(object)dest);
                    break;
                case hkbStateMachineTransitionInfoReference x:
                    Move(x, (hkbStateMachineTransitionInfoReference)(object)dest);
                    break;
                case hkbStringCondition x:
                    Move(x, (hkbStringCondition)(object)dest);
                    break;
                case hkbStringEventPayload x:
                    Move(x, (hkbStringEventPayload)(object)dest);
                    break;
                case hkbTestStateChooser x:
                    Move(x, (hkbTestStateChooser)(object)dest);
                    break;
                case hkbTimerModifier x:
                    Move(x, (hkbTimerModifier)(object)dest);
                    break;
                case hkbTimerModifierInternalState x:
                    Move(x, (hkbTimerModifierInternalState)(object)dest);
                    break;
                case hkbTransformVectorModifier x:
                    Move(x, (hkbTransformVectorModifier)(object)dest);
                    break;
                case hkbTransformVectorModifierInternalState x:
                    Move(x, (hkbTransformVectorModifierInternalState)(object)dest);
                    break;
                case hkbTransitionEffect x:
                    Move(x, (hkbTransitionEffect)(object)dest);
                    break;
                case hkbTwistModifier x:
                    Move(x, (hkbTwistModifier)(object)dest);
                    break;
                case hkbVariableBindingSet x:
                    Move(x, (hkbVariableBindingSet)(object)dest);
                    break;
                case hkbVariableBindingSetBinding x:
                    Move(x, (hkbVariableBindingSetBinding)(object)dest);
                    break;
                case hkbVariableValue x:
                    Move(x, (hkbVariableValue)(object)dest);
                    break;
                case hkbVariableValueSet x:
                    Move(x, (hkbVariableValueSet)(object)dest);
                    break;
                case hkbWorldEnums x:
                    Move(x, (hkbWorldEnums)(object)dest);
                    break;
                case hkbWorldFromModelModeData x:
                    Move(x, (hkbWorldFromModelModeData)(object)dest);
                    break;
                case hkbStateChooser x:
                    Move(x, (hkbStateChooser)(object)dest);
                    break;
                case hkbModifier x:
                    Move(x, (hkbModifier)(object)dest);
                    break;
                case hkbBlenderGenerator x:
                    Move(x, (hkbBlenderGenerator)(object)dest);
                    break;
                case hkbGenerator x:
                    Move(x, (hkbGenerator)(object)dest);
                    break;
                case hkbNode x:
                    Move(x, (hkbNode)(object)dest);
                    break;
                case hkbBindable x:
                    Move(x, (hkbBindable)(object)dest);
                    break;
                case hkbCondition x:
                    Move(x, (hkbCondition)(object)dest);
                    break;
                case hkbEventPayload x:
                    Move(x, (hkbEventPayload)(object)dest);
                    break;
                case hkClass x:
                    Move(x, (hkClass)(object)dest);
                    break;
                case hkClassEnum x:
                    Move(x, (hkClassEnum)(object)dest);
                    break;
                case hkClassEnumItem x:
                    Move(x, (hkClassEnumItem)(object)dest);
                    break;
                case hkClassMember x:
                    Move(x, (hkClassMember)(object)dest);
                    break;
                case hkColor x:
                    Move(x, (hkColor)(object)dest);
                    break;
                case hkContactPoint x:
                    Move(x, (hkContactPoint)(object)dest);
                    break;
                case hkContactPointMaterial x:
                    Move(x, (hkContactPointMaterial)(object)dest);
                    break;
                case hkCustomAttributes x:
                    Move(x, (hkCustomAttributes)(object)dest);
                    break;
                case hkCustomAttributesAttribute x:
                    Move(x, (hkCustomAttributesAttribute)(object)dest);
                    break;
                case hkDataObjectTypeAttribute x:
                    Move(x, (hkDataObjectTypeAttribute)(object)dest);
                    break;
                case hkDescriptionAttribute x:
                    Move(x, (hkDescriptionAttribute)(object)dest);
                    break;
                case hkDocumentationAttribute x:
                    Move(x, (hkDocumentationAttribute)(object)dest);
                    break;
                case hkGeometry x:
                    Move(x, (hkGeometry)(object)dest);
                    break;
                case hkGeometryTriangle x:
                    Move(x, (hkGeometryTriangle)(object)dest);
                    break;
                case hkGizmoAttribute x:
                    Move(x, (hkGizmoAttribute)(object)dest);
                    break;
                case hkHalf8 x:
                    Move(x, (hkHalf8)(object)dest);
                    break;
                case hkLinkAttribute x:
                    Move(x, (hkLinkAttribute)(object)dest);
                    break;
                case hkSimpleLocalFrame x:
                    Move(x, (hkSimpleLocalFrame)(object)dest);
                    break;
                case hkLocalFrame x:
                    Move(x, (hkLocalFrame)(object)dest);
                    break;
                case hkLocalFrameGroup x:
                    Move(x, (hkLocalFrameGroup)(object)dest);
                    break;
                case hkMemoryResourceContainer x:
                    Move(x, (hkMemoryResourceContainer)(object)dest);
                    break;
                case hkMemoryResourceHandle x:
                    Move(x, (hkMemoryResourceHandle)(object)dest);
                    break;
                case hkMemoryResourceHandleExternalLink x:
                    Move(x, (hkMemoryResourceHandleExternalLink)(object)dest);
                    break;
                case hkMemoryTrackerAttribute x:
                    Move(x, (hkMemoryTrackerAttribute)(object)dest);
                    break;
                case hkModelerNodeTypeAttribute x:
                    Move(x, (hkModelerNodeTypeAttribute)(object)dest);
                    break;
                case hkMotionState x:
                    Move(x, (hkMotionState)(object)dest);
                    break;
                case hkMultiThreadCheck x:
                    Move(x, (hkMultiThreadCheck)(object)dest);
                    break;
                case hkpAabbPhantom x:
                    Move(x, (hkpAabbPhantom)(object)dest);
                    break;
                case hkPackedVector3 x:
                    Move(x, (hkPackedVector3)(object)dest);
                    break;
                case hkPackfileHeader x:
                    Move(x, (hkPackfileHeader)(object)dest);
                    break;
                case hkPackfileSectionHeader x:
                    Move(x, (hkPackfileSectionHeader)(object)dest);
                    break;
                case hkpAgent1nSector x:
                    Move(x, (hkpAgent1nSector)(object)dest);
                    break;
                case hkpAngConstraintAtom x:
                    Move(x, (hkpAngConstraintAtom)(object)dest);
                    break;
                case hkpAngFrictionConstraintAtom x:
                    Move(x, (hkpAngFrictionConstraintAtom)(object)dest);
                    break;
                case hkpAngLimitConstraintAtom x:
                    Move(x, (hkpAngLimitConstraintAtom)(object)dest);
                    break;
                case hkpAngMotorConstraintAtom x:
                    Move(x, (hkpAngMotorConstraintAtom)(object)dest);
                    break;
                case hkpAngularDashpotAction x:
                    Move(x, (hkpAngularDashpotAction)(object)dest);
                    break;
                case hkpArrayAction x:
                    Move(x, (hkpArrayAction)(object)dest);
                    break;
                case hkpBallAndSocketConstraintData x:
                    Move(x, (hkpBallAndSocketConstraintData)(object)dest);
                    break;
                case hkpBallAndSocketConstraintDataAtoms x:
                    Move(x, (hkpBallAndSocketConstraintDataAtoms)(object)dest);
                    break;
                case hkpMountedBallGun x:
                    Move(x, (hkpMountedBallGun)(object)dest);
                    break;
                case hkpBallGun x:
                    Move(x, (hkpBallGun)(object)dest);
                    break;
                case hkpBallSocketChainData x:
                    Move(x, (hkpBallSocketChainData)(object)dest);
                    break;
                case hkpBallSocketChainDataConstraintInfo x:
                    Move(x, (hkpBallSocketChainDataConstraintInfo)(object)dest);
                    break;
                case hkpBallSocketConstraintAtom x:
                    Move(x, (hkpBallSocketConstraintAtom)(object)dest);
                    break;
                case hkpThinBoxMotion x:
                    Move(x, (hkpThinBoxMotion)(object)dest);
                    break;
                case hkpBoxMotion x:
                    Move(x, (hkpBoxMotion)(object)dest);
                    break;
                case hkpBoxShape x:
                    Move(x, (hkpBoxShape)(object)dest);
                    break;
                case hkpBreakableBody x:
                    Move(x, (hkpBreakableBody)(object)dest);
                    break;
                case hkpBreakableConstraintData x:
                    Move(x, (hkpBreakableConstraintData)(object)dest);
                    break;
                case hkpBridgeAtoms x:
                    Move(x, (hkpBridgeAtoms)(object)dest);
                    break;
                case hkpBridgeConstraintAtom x:
                    Move(x, (hkpBridgeConstraintAtom)(object)dest);
                    break;
                case hkpTypedBroadPhaseHandle x:
                    Move(x, (hkpTypedBroadPhaseHandle)(object)dest);
                    break;
                case hkpBroadPhaseHandle x:
                    Move(x, (hkpBroadPhaseHandle)(object)dest);
                    break;
                case hkpMoppBvTreeShape x:
                    Move(x, (hkpMoppBvTreeShape)(object)dest);
                    break;
                case hkMoppBvTreeShapeBase x:
                    Move(x, (hkMoppBvTreeShapeBase)(object)dest);
                    break;
                case hkpBvShape x:
                    Move(x, (hkpBvShape)(object)dest);
                    break;
                case hkpTriSampledHeightFieldBvTreeShape x:
                    Move(x, (hkpTriSampledHeightFieldBvTreeShape)(object)dest);
                    break;
                case hkpBvTreeShape x:
                    Move(x, (hkpBvTreeShape)(object)dest);
                    break;
                case hkpCachingShapePhantom x:
                    Move(x, (hkpCachingShapePhantom)(object)dest);
                    break;
                case hkpCallbackConstraintMotor x:
                    Move(x, (hkpCallbackConstraintMotor)(object)dest);
                    break;
                case hkpCapsuleShape x:
                    Move(x, (hkpCapsuleShape)(object)dest);
                    break;
                case hkpCenterOfMassChangerModifierConstraintAtom x:
                    Move(x, (hkpCenterOfMassChangerModifierConstraintAtom)(object)dest);
                    break;
                case hkpCharacterMotion x:
                    Move(x, (hkpCharacterMotion)(object)dest);
                    break;
                case hkpCharacterProxyCinfo x:
                    Move(x, (hkpCharacterProxyCinfo)(object)dest);
                    break;
                case hkpCharacterRigidBodyCinfo x:
                    Move(x, (hkpCharacterRigidBodyCinfo)(object)dest);
                    break;
                case hkpCharacterControllerCinfo x:
                    Move(x, (hkpCharacterControllerCinfo)(object)dest);
                    break;
                case hkpCogWheelConstraintAtom x:
                    Move(x, (hkpCogWheelConstraintAtom)(object)dest);
                    break;
                case hkpCogWheelConstraintData x:
                    Move(x, (hkpCogWheelConstraintData)(object)dest);
                    break;
                case hkpCogWheelConstraintDataAtoms x:
                    Move(x, (hkpCogWheelConstraintDataAtoms)(object)dest);
                    break;
                case hkpLinkedCollidable x:
                    Move(x, (hkpLinkedCollidable)(object)dest);
                    break;
                case hkpCollidableBoundingVolumeData x:
                    Move(x, (hkpCollidableBoundingVolumeData)(object)dest);
                    break;
                case hkpCollidableCollidableFilter x:
                    Move(x, (hkpCollidableCollidableFilter)(object)dest);
                    break;
                case hkpCollidable x:
                    Move(x, (hkpCollidable)(object)dest);
                    break;
                case hkpCdBody x:
                    Move(x, (hkpCdBody)(object)dest);
                    break;
                case hkpCollisionFilterList x:
                    Move(x, (hkpCollisionFilterList)(object)dest);
                    break;
                case hkpCompressedMeshShape x:
                    Move(x, (hkpCompressedMeshShape)(object)dest);
                    break;
                case hkpCompressedMeshShapeBigTriangle x:
                    Move(x, (hkpCompressedMeshShapeBigTriangle)(object)dest);
                    break;
                case hkpCompressedMeshShapeChunk x:
                    Move(x, (hkpCompressedMeshShapeChunk)(object)dest);
                    break;
                case hkpCompressedMeshShapeConvexPiece x:
                    Move(x, (hkpCompressedMeshShapeConvexPiece)(object)dest);
                    break;
                case hkpCompressedSampledHeightFieldShape x:
                    Move(x, (hkpCompressedSampledHeightFieldShape)(object)dest);
                    break;
                case hkpConeLimitConstraintAtom x:
                    Move(x, (hkpConeLimitConstraintAtom)(object)dest);
                    break;
                case hkpConstrainedSystemFilter x:
                    Move(x, (hkpConstrainedSystemFilter)(object)dest);
                    break;
                case hkpPoweredChainData x:
                    Move(x, (hkpPoweredChainData)(object)dest);
                    break;
                case hkpStiffSpringChainData x:
                    Move(x, (hkpStiffSpringChainData)(object)dest);
                    break;
                case hkpConstraintChainData x:
                    Move(x, (hkpConstraintChainData)(object)dest);
                    break;
                case hkpConstraintChainInstance x:
                    Move(x, (hkpConstraintChainInstance)(object)dest);
                    break;
                case hkpConstraintChainInstanceAction x:
                    Move(x, (hkpConstraintChainInstanceAction)(object)dest);
                    break;
                case hkpConstraintCollisionFilter x:
                    Move(x, (hkpConstraintCollisionFilter)(object)dest);
                    break;
                case hkpConstraintInstance x:
                    Move(x, (hkpConstraintInstance)(object)dest);
                    break;
                case hkpConstraintInstanceSmallArraySerializeOverrideType x:
                    Move(x, (hkpConstraintInstanceSmallArraySerializeOverrideType)(object)dest);
                    break;
                case hkpConvexListShape x:
                    Move(x, (hkpConvexListShape)(object)dest);
                    break;
                case hkpConvexPieceStreamData x:
                    Move(x, (hkpConvexPieceStreamData)(object)dest);
                    break;
                case hkpConvexTranslateShape x:
                    Move(x, (hkpConvexTranslateShape)(object)dest);
                    break;
                case hkpConvexTransformShape x:
                    Move(x, (hkpConvexTransformShape)(object)dest);
                    break;
                case hkpConvexTransformShapeBase x:
                    Move(x, (hkpConvexTransformShapeBase)(object)dest);
                    break;
                case hkpConvexVerticesConnectivity x:
                    Move(x, (hkpConvexVerticesConnectivity)(object)dest);
                    break;
                case hkpConvexVerticesShape x:
                    Move(x, (hkpConvexVerticesShape)(object)dest);
                    break;
                case hkpConvexVerticesShapeFourVectors x:
                    Move(x, (hkpConvexVerticesShapeFourVectors)(object)dest);
                    break;
                case hkpCylinderShape x:
                    Move(x, (hkpCylinderShape)(object)dest);
                    break;
                case hkpSphereShape x:
                    Move(x, (hkpSphereShape)(object)dest);
                    break;
                case hkpTriangleShape x:
                    Move(x, (hkpTriangleShape)(object)dest);
                    break;
                case hkpConvexShape x:
                    Move(x, (hkpConvexShape)(object)dest);
                    break;
                case hkpDashpotAction x:
                    Move(x, (hkpDashpotAction)(object)dest);
                    break;
                case hkpDefaultConvexListFilter x:
                    Move(x, (hkpDefaultConvexListFilter)(object)dest);
                    break;
                case hkpDefaultWorldMemoryWatchDog x:
                    Move(x, (hkpDefaultWorldMemoryWatchDog)(object)dest);
                    break;
                case hkpDisableEntityCollisionFilter x:
                    Move(x, (hkpDisableEntityCollisionFilter)(object)dest);
                    break;
                case hkpDisplayBindingData x:
                    Move(x, (hkpDisplayBindingData)(object)dest);
                    break;
                case hkpDisplayBindingDataPhysicsSystem x:
                    Move(x, (hkpDisplayBindingDataPhysicsSystem)(object)dest);
                    break;
                case hkpDisplayBindingDataRigidBody x:
                    Move(x, (hkpDisplayBindingDataRigidBody)(object)dest);
                    break;
                case hkpRigidBody x:
                    Move(x, (hkpRigidBody)(object)dest);
                    break;
                case hkpEntity x:
                    Move(x, (hkpEntity)(object)dest);
                    break;
                case hkpEntityExtendedListeners x:
                    Move(x, (hkpEntityExtendedListeners)(object)dest);
                    break;
                case hkpEntitySmallArraySerializeOverrideType x:
                    Move(x, (hkpEntitySmallArraySerializeOverrideType)(object)dest);
                    break;
                case hkpEntitySpuCollisionCallback x:
                    Move(x, (hkpEntitySpuCollisionCallback)(object)dest);
                    break;
                case hkpFastMeshShape x:
                    Move(x, (hkpFastMeshShape)(object)dest);
                    break;
                case hkpFixedRigidMotion x:
                    Move(x, (hkpFixedRigidMotion)(object)dest);
                    break;
                case hkpGenericConstraintData x:
                    Move(x, (hkpGenericConstraintData)(object)dest);
                    break;
                case hkpGenericConstraintDataScheme x:
                    Move(x, (hkpGenericConstraintDataScheme)(object)dest);
                    break;
                case hkpGenericConstraintDataSchemeConstraintInfo x:
                    Move(x, (hkpGenericConstraintDataSchemeConstraintInfo)(object)dest);
                    break;
                case hkpGravityGun x:
                    Move(x, (hkpGravityGun)(object)dest);
                    break;
                case hkpGroupCollisionFilter x:
                    Move(x, (hkpGroupCollisionFilter)(object)dest);
                    break;
                case hkpGroupFilter x:
                    Move(x, (hkpGroupFilter)(object)dest);
                    break;
                case hkpPlaneShape x:
                    Move(x, (hkpPlaneShape)(object)dest);
                    break;
                case hkpStorageSampledHeightFieldShape x:
                    Move(x, (hkpStorageSampledHeightFieldShape)(object)dest);
                    break;
                case hkpSampledHeightFieldShape x:
                    Move(x, (hkpSampledHeightFieldShape)(object)dest);
                    break;
                case hkpHeightFieldShape x:
                    Move(x, (hkpHeightFieldShape)(object)dest);
                    break;
                case hkpHingeConstraintData x:
                    Move(x, (hkpHingeConstraintData)(object)dest);
                    break;
                case hkpHingeConstraintDataAtoms x:
                    Move(x, (hkpHingeConstraintDataAtoms)(object)dest);
                    break;
                case hkpConvexListFilter x:
                    Move(x, (hkpConvexListFilter)(object)dest);
                    break;
                case hkpHingeLimitsData x:
                    Move(x, (hkpHingeLimitsData)(object)dest);
                    break;
                case hkpHingeLimitsDataAtoms x:
                    Move(x, (hkpHingeLimitsDataAtoms)(object)dest);
                    break;
                case hkpIgnoreModifierConstraintAtom x:
                    Move(x, (hkpIgnoreModifierConstraintAtom)(object)dest);
                    break;
                case hkpMaxSizeMotion x:
                    Move(x, (hkpMaxSizeMotion)(object)dest);
                    break;
                case hkpKeyframedRigidMotion x:
                    Move(x, (hkpKeyframedRigidMotion)(object)dest);
                    break;
                case hkpPositionConstraintMotor x:
                    Move(x, (hkpPositionConstraintMotor)(object)dest);
                    break;
                case hkpVelocityConstraintMotor x:
                    Move(x, (hkpVelocityConstraintMotor)(object)dest);
                    break;
                case hkpSpringDamperConstraintMotor x:
                    Move(x, (hkpSpringDamperConstraintMotor)(object)dest);
                    break;
                case hkpLimitedForceConstraintMotor x:
                    Move(x, (hkpLimitedForceConstraintMotor)(object)dest);
                    break;
                case hkpLimitedHingeConstraintData x:
                    Move(x, (hkpLimitedHingeConstraintData)(object)dest);
                    break;
                case hkpLimitedHingeConstraintDataAtoms x:
                    Move(x, (hkpLimitedHingeConstraintDataAtoms)(object)dest);
                    break;
                case hkpLinConstraintAtom x:
                    Move(x, (hkpLinConstraintAtom)(object)dest);
                    break;
                case hkpLinearParametricCurve x:
                    Move(x, (hkpLinearParametricCurve)(object)dest);
                    break;
                case hkpLinFrictionConstraintAtom x:
                    Move(x, (hkpLinFrictionConstraintAtom)(object)dest);
                    break;
                case hkpLinLimitConstraintAtom x:
                    Move(x, (hkpLinLimitConstraintAtom)(object)dest);
                    break;
                case hkpLinMotorConstraintAtom x:
                    Move(x, (hkpLinMotorConstraintAtom)(object)dest);
                    break;
                case hkpLinSoftConstraintAtom x:
                    Move(x, (hkpLinSoftConstraintAtom)(object)dest);
                    break;
                case hkpListShape x:
                    Move(x, (hkpListShape)(object)dest);
                    break;
                case hkpListShapeChildInfo x:
                    Move(x, (hkpListShapeChildInfo)(object)dest);
                    break;
                case hkpMalleableConstraintData x:
                    Move(x, (hkpMalleableConstraintData)(object)dest);
                    break;
                case hkpMassChangerModifierConstraintAtom x:
                    Move(x, (hkpMassChangerModifierConstraintAtom)(object)dest);
                    break;
                case hkpMaterial x:
                    Move(x, (hkpMaterial)(object)dest);
                    break;
                case hkpNamedMeshMaterial x:
                    Move(x, (hkpNamedMeshMaterial)(object)dest);
                    break;
                case hkpMeshMaterial x:
                    Move(x, (hkpMeshMaterial)(object)dest);
                    break;
                case hkpStorageMeshShape x:
                    Move(x, (hkpStorageMeshShape)(object)dest);
                    break;
                case hkpMeshShape x:
                    Move(x, (hkpMeshShape)(object)dest);
                    break;
                case hkpMeshShapeSubpart x:
                    Move(x, (hkpMeshShapeSubpart)(object)dest);
                    break;
                case hkpMovingSurfaceModifierConstraintAtom x:
                    Move(x, (hkpMovingSurfaceModifierConstraintAtom)(object)dest);
                    break;

                case hkpMoppCode x:
                    Move(x, (hkpMoppCode)(object)dest);
                    break;
                case hkpMoppCodeCodeInfo x:
                    Move(x, (hkpMoppCodeCodeInfo)(object)dest);
                    break;
                case hkpMoppCodeReindexedTerminal x:
                    Move(x, (hkpMoppCodeReindexedTerminal)(object)dest);
                    break;
                case hkpMotorAction x:
                    Move(x, (hkpMotorAction)(object)dest);
                    break;
                case hkpMouseSpringAction x:
                    Move(x, (hkpMouseSpringAction)(object)dest);
                    break;
                case hkpMultiRayShape x:
                    Move(x, (hkpMultiRayShape)(object)dest);
                    break;
                case hkpMultiRayShapeRay x:
                    Move(x, (hkpMultiRayShapeRay)(object)dest);
                    break;
                case hkpMultiSphereShape x:
                    Move(x, (hkpMultiSphereShape)(object)dest);
                    break;
                case hkpNullCollisionFilter x:
                    Move(x, (hkpNullCollisionFilter)(object)dest);
                    break;
                case hkPostFinishAttribute x:
                    Move(x, (hkPostFinishAttribute)(object)dest);
                    break;
                case hkpOverwritePivotConstraintAtom x:
                    Move(x, (hkpOverwritePivotConstraintAtom)(object)dest);
                    break;
                case hkpPairCollisionFilter x:
                    Move(x, (hkpPairCollisionFilter)(object)dest);
                    break;
                case hkpPairCollisionFilterMapPairFilterKeyOverrideType x:
                    Move(x, (hkpPairCollisionFilterMapPairFilterKeyOverrideType)(object)dest);
                    break;
                case hkpParametricCurve x:
                    Move(x, (hkpParametricCurve)(object)dest);
                    break;
                case hkpPhantomCallbackShape x:
                    Move(x, (hkpPhantomCallbackShape)(object)dest);
                    break;
                case hkpPhysicsData x:
                    Move(x, (hkpPhysicsData)(object)dest);
                    break;
                case hkpPhysicsSystemWithContacts x:
                    Move(x, (hkpPhysicsSystemWithContacts)(object)dest);
                    break;
                case hkpPhysicsSystem x:
                    Move(x, (hkpPhysicsSystem)(object)dest);
                    break;
                case hkpPointToPathConstraintData x:
                    Move(x, (hkpPointToPathConstraintData)(object)dest);
                    break;
                case hkpPointToPlaneConstraintData x:
                    Move(x, (hkpPointToPlaneConstraintData)(object)dest);
                    break;
                case hkpPointToPlaneConstraintDataAtoms x:
                    Move(x, (hkpPointToPlaneConstraintDataAtoms)(object)dest);
                    break;
                case hkpPoweredChainDataConstraintInfo x:
                    Move(x, (hkpPoweredChainDataConstraintInfo)(object)dest);
                    break;
                case hkpPoweredChainMapper x:
                    Move(x, (hkpPoweredChainMapper)(object)dest);
                    break;
                case hkpPoweredChainMapperLinkInfo x:
                    Move(x, (hkpPoweredChainMapperLinkInfo)(object)dest);
                    break;
                case hkpPoweredChainMapperTarget x:
                    Move(x, (hkpPoweredChainMapperTarget)(object)dest);
                    break;
                case hkpPrismaticConstraintData x:
                    Move(x, (hkpPrismaticConstraintData)(object)dest);
                    break;
                case hkpPrismaticConstraintDataAtoms x:
                    Move(x, (hkpPrismaticConstraintDataAtoms)(object)dest);
                    break;
                case hkpProjectileGun x:
                    Move(x, (hkpProjectileGun)(object)dest);
                    break;
                case hkpProperty x:
                    Move(x, (hkpProperty)(object)dest);
                    break;
                case hkpPropertyValue x:
                    Move(x, (hkpPropertyValue)(object)dest);
                    break;
                case hkpPulleyConstraintAtom x:
                    Move(x, (hkpPulleyConstraintAtom)(object)dest);
                    break;
                case hkpPulleyConstraintData x:
                    Move(x, (hkpPulleyConstraintData)(object)dest);
                    break;
                case hkpPulleyConstraintDataAtoms x:
                    Move(x, (hkpPulleyConstraintDataAtoms)(object)dest);
                    break;
                case hkpRackAndPinionConstraintAtom x:
                    Move(x, (hkpRackAndPinionConstraintAtom)(object)dest);
                    break;
                case hkpRackAndPinionConstraintData x:
                    Move(x, (hkpRackAndPinionConstraintData)(object)dest);
                    break;
                case hkpRackAndPinionConstraintDataAtoms x:
                    Move(x, (hkpRackAndPinionConstraintDataAtoms)(object)dest);
                    break;
                case hkpRagdollConstraintData x:
                    Move(x, (hkpRagdollConstraintData)(object)dest);
                    break;
                case hkpRagdollConstraintDataAtoms x:
                    Move(x, (hkpRagdollConstraintDataAtoms)(object)dest);
                    break;
                case hkpRagdollLimitsData x:
                    Move(x, (hkpRagdollLimitsData)(object)dest);
                    break;
                case hkpRagdollLimitsDataAtoms x:
                    Move(x, (hkpRagdollLimitsDataAtoms)(object)dest);
                    break;
                case hkpRagdollMotorConstraintAtom x:
                    Move(x, (hkpRagdollMotorConstraintAtom)(object)dest);
                    break;
                case hkpRayCollidableFilter x:
                    Move(x, (hkpRayCollidableFilter)(object)dest);
                    break;
                case hkpRayShapeCollectionFilter x:
                    Move(x, (hkpRayShapeCollectionFilter)(object)dest);
                    break;
                case hkpRemoveTerminalsMoppModifier x:
                    Move(x, (hkpRemoveTerminalsMoppModifier)(object)dest);
                    break;
                case hkpReorientAction x:
                    Move(x, (hkpReorientAction)(object)dest);
                    break;
                case hkpRotationalConstraintData x:
                    Move(x, (hkpRotationalConstraintData)(object)dest);
                    break;
                case hkpRotationalConstraintDataAtoms x:
                    Move(x, (hkpRotationalConstraintDataAtoms)(object)dest);
                    break;
                case hkpSerializedAgentNnEntry x:
                    Move(x, (hkpSerializedAgentNnEntry)(object)dest);
                    break;
                case hkpSerializedDisplayMarker x:
                    Move(x, (hkpSerializedDisplayMarker)(object)dest);
                    break;
                case hkpSerializedDisplayMarkerList x:
                    Move(x, (hkpSerializedDisplayMarkerList)(object)dest);
                    break;
                case hkpSerializedDisplayRbTransforms x:
                    Move(x, (hkpSerializedDisplayRbTransforms)(object)dest);
                    break;
                case hkpSerializedDisplayRbTransformsDisplayTransformPair x:
                    Move(x, (hkpSerializedDisplayRbTransformsDisplayTransformPair)(object)dest);
                    break;
                case hkpSerializedSubTrack1nInfo x:
                    Move(x, (hkpSerializedSubTrack1nInfo)(object)dest);
                    break;
                case hkpSerializedTrack1nInfo x:
                    Move(x, (hkpSerializedTrack1nInfo)(object)dest);
                    break;
                case hkpSetLocalRotationsConstraintAtom x:
                    Move(x, (hkpSetLocalRotationsConstraintAtom)(object)dest);
                    break;
                case hkpSetLocalTransformsConstraintAtom x:
                    Move(x, (hkpSetLocalTransformsConstraintAtom)(object)dest);
                    break;
                case hkpSetLocalTranslationsConstraintAtom x:
                    Move(x, (hkpSetLocalTranslationsConstraintAtom)(object)dest);
                    break;
                case hkpSetupStabilizationAtom x:
                    Move(x, (hkpSetupStabilizationAtom)(object)dest);
                    break;
                case hkpTriSampledHeightFieldCollection x:
                    Move(x, (hkpTriSampledHeightFieldCollection)(object)dest);
                    break;
                case hkpShapeCollection x:
                    Move(x, (hkpShapeCollection)(object)dest);
                    break;
                case hkpShapeCollectionFilter x:
                    Move(x, (hkpShapeCollectionFilter)(object)dest);
                    break;

                case hkpShapeInfo x:
                    Move(x, (hkpShapeInfo)(object)dest);
                    break;
                case hkpShapeModifier x:
                    Move(x, (hkpShapeModifier)(object)dest);
                    break;
                case hkpSimpleContactConstraintAtom x:
                    Move(x, (hkpSimpleContactConstraintAtom)(object)dest);
                    break;
                case hkpSimpleContactConstraintDataInfo x:
                    Move(x, (hkpSimpleContactConstraintDataInfo)(object)dest);
                    break;
                case hkpSimpleShapePhantom x:
                    Move(x, (hkpSimpleShapePhantom)(object)dest);
                    break;
                case hkpShapePhantom x:
                    Move(x, (hkpShapePhantom)(object)dest);
                    break;
                case hkpSimpleShapePhantomCollisionDetail x:
                    Move(x, (hkpSimpleShapePhantomCollisionDetail)(object)dest);
                    break;
                case hkpPhantom x:
                    Move(x, (hkpPhantom)(object)dest);
                    break;
                case hkpSimulation x:
                    Move(x, (hkpSimulation)(object)dest);
                    break;
                case hkpSingleShapeContainer x:
                    Move(x, (hkpSingleShapeContainer)(object)dest);
                    break;
                case hkpShapeContainer x:
                    Move(x, (hkpShapeContainer)(object)dest);
                    break;
                case hkpSoftContactModifierConstraintAtom x:
                    Move(x, (hkpSoftContactModifierConstraintAtom)(object)dest);
                    break;
                case hkpSphereMotion x:
                    Move(x, (hkpSphereMotion)(object)dest);
                    break;
                case hkpMotion x:
                    Move(x, (hkpMotion)(object)dest);
                    break;
                case hkpSphereRepShape x:
                    Move(x, (hkpSphereRepShape)(object)dest);
                    break;

                case hkpSpringAction x:
                    Move(x, (hkpSpringAction)(object)dest);
                    break;
                case hkpStiffSpringChainDataConstraintInfo x:
                    Move(x, (hkpStiffSpringChainDataConstraintInfo)(object)dest);
                    break;
                case hkpStiffSpringConstraintAtom x:
                    Move(x, (hkpStiffSpringConstraintAtom)(object)dest);
                    break;
                case hkpStiffSpringConstraintData x:
                    Move(x, (hkpStiffSpringConstraintData)(object)dest);
                    break;
                case hkpStiffSpringConstraintDataAtoms x:
                    Move(x, (hkpStiffSpringConstraintDataAtoms)(object)dest);
                    break;
                case hkpStorageMeshShapeSubpartStorage x:
                    Move(x, (hkpStorageMeshShapeSubpartStorage)(object)dest);
                    break;
                case hkpTransformShape x:
                    Move(x, (hkpTransformShape)(object)dest);
                    break;
                case hkpTriggerVolume x:
                    Move(x, (hkpTriggerVolume)(object)dest);
                    break;
                case hkpTriggerVolumeEventInfo x:
                    Move(x, (hkpTriggerVolumeEventInfo)(object)dest);
                    break;
                case hkpTwistLimitConstraintAtom x:
                    Move(x, (hkpTwistLimitConstraintAtom)(object)dest);
                    break;
                case hkpUnaryAction x:
                    Move(x, (hkpUnaryAction)(object)dest);
                    break;
                case hkpViscousSurfaceModifierConstraintAtom x:
                    Move(x, (hkpViscousSurfaceModifierConstraintAtom)(object)dest);
                    break;
                case hkpWeldingUtility x:
                    Move(x, (hkpWeldingUtility)(object)dest);
                    break;
                case hkpWheelConstraintData x:
                    Move(x, (hkpWheelConstraintData)(object)dest);
                    break;
                case hkpWheelConstraintDataAtoms x:
                    Move(x, (hkpWheelConstraintDataAtoms)(object)dest);
                    break;
                case hkpWorld x:
                    Move(x, (hkpWorld)(object)dest);
                    break;
                case hkpWorldCinfo x:
                    Move(x, (hkpWorldCinfo)(object)dest);
                    break;
                case hkpWorldObject x:
                    Move(x, (hkpWorldObject)(object)dest);
                    break;
                case hkpModifierConstraintAtom x:
                    Move(x, (hkpModifierConstraintAtom)(object)dest);
                    break;
                case hkpShape x:
                    Move(x, (hkpShape)(object)dest);
                    break;
                case hkpBinaryAction x:
                    Move(x, (hkpBinaryAction)(object)dest);
                    break;
                case hkpAction x:
                    Move(x, (hkpAction)(object)dest);
                    break;
                case hkpCollisionFilter x:
                    Move(x, (hkpCollisionFilter)(object)dest);
                    break;
                case hkpConstraintMotor x:
                    Move(x, (hkpConstraintMotor)(object)dest);
                    break;
                case hkpConstraintData x:
                    Move(x, (hkpConstraintData)(object)dest);
                    break;
                case hkpConstraintAtom x:
                    Move(x, (hkpConstraintAtom)(object)dest);
                    break;
                case hkpFirstPersonGun x:
                    Move(x, (hkpFirstPersonGun)(object)dest);
                    break;
                case hkQTransform x:
                    Move(x, (hkQTransform)(object)dest);
                    break;
                case hkRangeInt32Attribute x:
                    Move(x, (hkRangeInt32Attribute)(object)dest);
                    break;
                case hkRangeRealAttribute x:
                    Move(x, (hkRangeRealAttribute)(object)dest);
                    break;
                case hkReflectedFileAttribute x:
                    Move(x, (hkReflectedFileAttribute)(object)dest);
                    break;
                case hkResourceContainer x:
                    Move(x, (hkResourceContainer)(object)dest);
                    break;
                case hkResourceHandle x:
                    Move(x, (hkResourceHandle)(object)dest);
                    break;
                case hkResourceBase x:
                    Move(x, (hkResourceBase)(object)dest);
                    break;
                case hkSemanticsAttribute x:
                    Move(x, (hkSemanticsAttribute)(object)dest);
                    break;
                case hkSphere x:
                    Move(x, (hkSphere)(object)dest);
                    break;
                case hkSweptTransform x:
                    Move(x, (hkSweptTransform)(object)dest);
                    break;
                case hkTraceStreamTitle x:
                    Move(x, (hkTraceStreamTitle)(object)dest);
                    break;
                case hkTrackerSerializableScanSnapshot x:
                    Move(x, (hkTrackerSerializableScanSnapshot)(object)dest);
                    break;
                case hkTrackerSerializableScanSnapshotAllocation x:
                    Move(x, (hkTrackerSerializableScanSnapshotAllocation)(object)dest);
                    break;
                case hkTrackerSerializableScanSnapshotBlock x:
                    Move(x, (hkTrackerSerializableScanSnapshotBlock)(object)dest);
                    break;
                case hkUiAttribute x:
                    Move(x, (hkUiAttribute)(object)dest);
                    break;
                case hkWorldMemoryAvailableWatchDog x:
                    Move(x, (hkWorldMemoryAvailableWatchDog)(object)dest);
                    break;
                case hkxAnimatedFloat x:
                    Move(x, (hkxAnimatedFloat)(object)dest);
                    break;
                case hkxAnimatedMatrix x:
                    Move(x, (hkxAnimatedMatrix)(object)dest);
                    break;
                case hkxAnimatedQuaternion x:
                    Move(x, (hkxAnimatedQuaternion)(object)dest);
                    break;
                case hkxAnimatedVector x:
                    Move(x, (hkxAnimatedVector)(object)dest);
                    break;
                case hkxAttribute x:
                    Move(x, (hkxAttribute)(object)dest);
                    break;
                case hkxAttributeGroup x:
                    Move(x, (hkxAttributeGroup)(object)dest);
                    break;
                case hkxMaterial x:
                    Move(x, (hkxMaterial)(object)dest);
                    break;
                case hkxMeshUserChannelInfo x:
                    Move(x, (hkxMeshUserChannelInfo)(object)dest);
                    break;
                case hkxNode x:
                    Move(x, (hkxNode)(object)dest);
                    break;
                case hkxNodeSelectionSet x:
                    Move(x, (hkxNodeSelectionSet)(object)dest);
                    break;
                case hkxAttributeHolder x:
                    Move(x, (hkxAttributeHolder)(object)dest);
                    break;
                case hkxCamera x:
                    Move(x, (hkxCamera)(object)dest);
                    break;
                case hkxEdgeSelectionChannel x:
                    Move(x, (hkxEdgeSelectionChannel)(object)dest);
                    break;
                case hkxEnum x:
                    Move(x, (hkxEnum)(object)dest);
                    break;
                case hkxEnumItem x:
                    Move(x, (hkxEnumItem)(object)dest);
                    break;
                case hkxEnvironment x:
                    Move(x, (hkxEnvironment)(object)dest);
                    break;
                case hkxEnvironmentVariable x:
                    Move(x, (hkxEnvironmentVariable)(object)dest);
                    break;
                case hkxIndexBuffer x:
                    Move(x, (hkxIndexBuffer)(object)dest);
                    break;
                case hkxLight x:
                    Move(x, (hkxLight)(object)dest);
                    break;

                case hkxMaterialEffect x:
                    Move(x, (hkxMaterialEffect)(object)dest);
                    break;
                case hkxMaterialProperty x:
                    Move(x, (hkxMaterialProperty)(object)dest);
                    break;
                case hkxMaterialShader x:
                    Move(x, (hkxMaterialShader)(object)dest);
                    break;
                case hkxMaterialShaderSet x:
                    Move(x, (hkxMaterialShaderSet)(object)dest);
                    break;
                case hkxMaterialTextureStage x:
                    Move(x, (hkxMaterialTextureStage)(object)dest);
                    break;
                case hkxMesh x:
                    Move(x, (hkxMesh)(object)dest);
                    break;
                case hkxMeshSection x:
                    Move(x, (hkxMeshSection)(object)dest);
                    break;
                case hkxNodeAnnotationData x:
                    Move(x, (hkxNodeAnnotationData)(object)dest);
                    break;
                case hkxScene x:
                    Move(x, (hkxScene)(object)dest);
                    break;
                case hkxSkinBinding x:
                    Move(x, (hkxSkinBinding)(object)dest);
                    break;
                case hkxSparselyAnimatedBool x:
                    Move(x, (hkxSparselyAnimatedBool)(object)dest);
                    break;
                case hkxSparselyAnimatedEnum x:
                    Move(x, (hkxSparselyAnimatedEnum)(object)dest);
                    break;
                case hkxSparselyAnimatedInt x:
                    Move(x, (hkxSparselyAnimatedInt)(object)dest);
                    break;
                case hkxSparselyAnimatedString x:
                    Move(x, (hkxSparselyAnimatedString)(object)dest);
                    break;
                case hkxTextureFile x:
                    Move(x, (hkxTextureFile)(object)dest);
                    break;
                case hkxTextureInplace x:
                    Move(x, (hkxTextureInplace)(object)dest);
                    break;
                case hkxTriangleSelectionChannel x:
                    Move(x, (hkxTriangleSelectionChannel)(object)dest);
                    break;
                case hkxVertexBuffer x:
                    Move(x, (hkxVertexBuffer)(object)dest);
                    break;
                case hkxVertexBufferVertexData x:
                    Move(x, (hkxVertexBufferVertexData)(object)dest);
                    break;
                case hkxVertexDescription x:
                    Move(x, (hkxVertexDescription)(object)dest);
                    break;
                case hkxVertexDescriptionElementDecl x:
                    Move(x, (hkxVertexDescriptionElementDecl)(object)dest);
                    break;
                case hkxVertexFloatDataChannel x:
                    Move(x, (hkxVertexFloatDataChannel)(object)dest);
                    break;
                case hkxVertexIntDataChannel x:
                    Move(x, (hkxVertexIntDataChannel)(object)dest);
                    break;
                case hkxVertexSelectionChannel x:
                    Move(x, (hkxVertexSelectionChannel)(object)dest);
                    break;
                case hkxVertexVectorDataChannel x:
                    Move(x, (hkxVertexVectorDataChannel)(object)dest);
                    break;
            }
        }
        public static partial void Move(BGSGamebryoSequenceGenerator source, BGSGamebryoSequenceGenerator dest);
        public static partial void Move(BSBoneSwitchGenerator source, BSBoneSwitchGenerator dest);
        public static partial void Move(BSBoneSwitchGeneratorBoneData source, BSBoneSwitchGeneratorBoneData dest);
        public static partial void Move(BSComputeAddBoneAnimModifier source, BSComputeAddBoneAnimModifier dest);
        public static partial void Move(BSCyclicBlendTransitionGenerator source, BSCyclicBlendTransitionGenerator dest);
        public static partial void Move(BSDecomposeVectorModifier source, BSDecomposeVectorModifier dest);
        public static partial void Move(BSDirectAtModifier source, BSDirectAtModifier dest);
        public static partial void Move(BSDistTriggerModifier source, BSDistTriggerModifier dest);
        public static partial void Move(BSEventEveryNEventsModifier source, BSEventEveryNEventsModifier dest);
        public static partial void Move(BSEventOnDeactivateModifier source, BSEventOnDeactivateModifier dest);
        public static partial void Move(BSEventOnFalseToTrueModifier source, BSEventOnFalseToTrueModifier dest);
        public static partial void Move(BSGetTimeStepModifier source, BSGetTimeStepModifier dest);
        public static partial void Move(BSInterpValueModifier source, BSInterpValueModifier dest);
        public static partial void Move(BSIsActiveModifier source, BSIsActiveModifier dest);
        public static partial void Move(BSIStateManagerModifier source, BSIStateManagerModifier dest);
        public static partial void Move(BSIStateManagerModifierBSiStateData source, BSIStateManagerModifierBSiStateData dest);
        public static partial void Move(BSIStateManagerModifierBSIStateManagerStateListener source, BSIStateManagerModifierBSIStateManagerStateListener dest);
        public static partial void Move(BSiStateTaggingGenerator source, BSiStateTaggingGenerator dest);
        public static partial void Move(BSLimbIKModifier source, BSLimbIKModifier dest);
        public static partial void Move(BSLookAtModifier source, BSLookAtModifier dest);
        public static partial void Move(BSLookAtModifierBoneData source, BSLookAtModifierBoneData dest);
        public static partial void Move(BSModifyOnceModifier source, BSModifyOnceModifier dest);
        public static partial void Move(BSOffsetAnimationGenerator source, BSOffsetAnimationGenerator dest);
        public static partial void Move(BSPassByTargetTriggerModifier source, BSPassByTargetTriggerModifier dest);
        public static partial void Move(BSRagdollContactListenerModifier source, BSRagdollContactListenerModifier dest);
        public static partial void Move(BSSpeedSamplerModifier source, BSSpeedSamplerModifier dest);
        public static partial void Move(BSSynchronizedClipGenerator source, BSSynchronizedClipGenerator dest);
        public static partial void Move(BSTimerModifier source, BSTimerModifier dest);
        public static partial void Move(BSTweenerModifier source, BSTweenerModifier dest);
        public static partial void Move(hkAabb source, hkAabb dest);
        public static partial void Move(hkAabbHalf source, hkAabbHalf dest);
        public static partial void Move(hkAabbUint32 source, hkAabbUint32 dest);
        public static partial void Move(hkaAnimatedReferenceFrame source, hkaAnimatedReferenceFrame dest);
        public static partial void Move(hkaAnimation source, hkaAnimation dest);
        public static partial void Move(hkaAnimationBinding source, hkaAnimationBinding dest);
        public static partial void Move(hkaAnimationContainer source, hkaAnimationContainer dest);
        public static partial void Move(hkaAnimationPreviewColorContainer source, hkaAnimationPreviewColorContainer dest);
        public static partial void Move(hkaAnnotationTrack source, hkaAnnotationTrack dest);
        public static partial void Move(hkaAnnotationTrackAnnotation source, hkaAnnotationTrackAnnotation dest);
        public static partial void Move(hkaBone source, hkaBone dest);
        public static partial void Move(hkaBoneAttachment source, hkaBoneAttachment dest);
        public static partial void Move(hkaDefaultAnimatedReferenceFrame source, hkaDefaultAnimatedReferenceFrame dest);
        public static partial void Move(hkaFootstepAnalysisInfo source, hkaFootstepAnalysisInfo dest);
        public static partial void Move(hkaFootstepAnalysisInfoContainer source, hkaFootstepAnalysisInfoContainer dest);
        public static partial void Move(hkaInterleavedUncompressedAnimation source, hkaInterleavedUncompressedAnimation dest);
        public static partial void Move(hkaKeyFrameHierarchyUtility source, hkaKeyFrameHierarchyUtility dest);
        public static partial void Move(hkaKeyFrameHierarchyUtilityControlData source, hkaKeyFrameHierarchyUtilityControlData dest);
        public static partial void Move(hkAlignSceneToNodeOptions source, hkAlignSceneToNodeOptions dest);
        public static partial void Move(hkaMeshBinding source, hkaMeshBinding dest);
        public static partial void Move(hkaMeshBindingMapping source, hkaMeshBindingMapping dest);
        public static partial void Move(hkaQuantizedAnimation source, hkaQuantizedAnimation dest);
        public static partial void Move(hkaQuantizedAnimationTrackCompressionParams source, hkaQuantizedAnimationTrackCompressionParams dest);
        public static partial void Move(hkaRagdollInstance source, hkaRagdollInstance dest);
        public static partial void Move(hkArrayTypeAttribute source, hkArrayTypeAttribute dest);
        public static partial void Move(hkaSkeleton source, hkaSkeleton dest);
        public static partial void Move(hkaSkeletonLocalFrameOnBone source, hkaSkeletonLocalFrameOnBone dest);
        public static partial void Move(hkaSkeletonMapper source, hkaSkeletonMapper dest);
        public static partial void Move(hkaSkeletonMapperData source, hkaSkeletonMapperData dest);
        public static partial void Move(hkaSkeletonMapperDataChainMapping source, hkaSkeletonMapperDataChainMapping dest);
        public static partial void Move(hkaSkeletonMapperDataSimpleMapping source, hkaSkeletonMapperDataSimpleMapping dest);
        public static partial void Move(hkaSplineCompressedAnimation source, hkaSplineCompressedAnimation dest);
        public static partial void Move(hkaSplineCompressedAnimationAnimationCompressionParams source, hkaSplineCompressedAnimationAnimationCompressionParams dest);
        public static partial void Move(hkaSplineCompressedAnimationTrackCompressionParams source, hkaSplineCompressedAnimationTrackCompressionParams dest);
        public static partial void Move(hkbAttachmentModifier source, hkbAttachmentModifier dest);
        public static partial void Move(hkbAttachmentSetup source, hkbAttachmentSetup dest);
        public static partial void Move(hkbAttributeModifier source, hkbAttributeModifier dest);
        public static partial void Move(hkbAttributeModifierAssignment source, hkbAttributeModifierAssignment dest);
        public static partial void Move(hkbAuxiliaryNodeInfo source, hkbAuxiliaryNodeInfo dest);
        public static partial void Move(hkbBehaviorEventsInfo source, hkbBehaviorEventsInfo dest);
        public static partial void Move(hkbBehaviorGraph source, hkbBehaviorGraph dest);
        public static partial void Move(hkbBehaviorGraphData source, hkbBehaviorGraphData dest);
        public static partial void Move(hkbBehaviorGraphInternalState source, hkbBehaviorGraphInternalState dest);
        public static partial void Move(hkbBehaviorGraphInternalStateInfo source, hkbBehaviorGraphInternalStateInfo dest);
        public static partial void Move(hkbBehaviorGraphStringData source, hkbBehaviorGraphStringData dest);
        public static partial void Move(hkbBehaviorInfo source, hkbBehaviorInfo dest);
        public static partial void Move(hkbBehaviorInfoIdToNamePair source, hkbBehaviorInfoIdToNamePair dest);
        public static partial void Move(hkbBehaviorReferenceGenerator source, hkbBehaviorReferenceGenerator dest);
        public static partial void Move(hkbBindable source, hkbBindable dest);
        public static partial void Move(hkbBlendCurveUtils source, hkbBlendCurveUtils dest);
        public static partial void Move(hkbBlenderGenerator source, hkbBlenderGenerator dest);
        public static partial void Move(hkbBlenderGeneratorChild source, hkbBlenderGeneratorChild dest);
        public static partial void Move(hkbBlenderGeneratorChildInternalState source, hkbBlenderGeneratorChildInternalState dest);
        public static partial void Move(hkbBlenderGeneratorInternalState source, hkbBlenderGeneratorInternalState dest);
        public static partial void Move(hkbBlendingTransitionEffect source, hkbBlendingTransitionEffect dest);
        public static partial void Move(hkbBlendingTransitionEffectInternalState source, hkbBlendingTransitionEffectInternalState dest);
        public static partial void Move(hkbBoneIndexArray source, hkbBoneIndexArray dest);
        public static partial void Move(hkbBoneWeightArray source, hkbBoneWeightArray dest);
        public static partial void Move(hkbBoolVariableSequencedData source, hkbBoolVariableSequencedData dest);
        public static partial void Move(hkbBoolVariableSequencedDataSample source, hkbBoolVariableSequencedDataSample dest);
        public static partial void Move(hkbCameraShakeEventPayload source, hkbCameraShakeEventPayload dest);
        public static partial void Move(hkbCharacter source, hkbCharacter dest);
        public static partial void Move(hkbCharacterAddedInfo source, hkbCharacterAddedInfo dest);
        public static partial void Move(hkbCharacterControlCommand source, hkbCharacterControlCommand dest);
        public static partial void Move(hkbCharacterControllerControlData source, hkbCharacterControllerControlData dest);
        public static partial void Move(hkbCharacterControllerModifier source, hkbCharacterControllerModifier dest);
        public static partial void Move(hkbCharacterControllerModifierInternalState source, hkbCharacterControllerModifierInternalState dest);
        public static partial void Move(hkbCharacterData source, hkbCharacterData dest);
        public static partial void Move(hkbCharacterDataCharacterControllerInfo source, hkbCharacterDataCharacterControllerInfo dest);
        public static partial void Move(hkbCharacterInfo source, hkbCharacterInfo dest);
        public static partial void Move(hkbCharacterSetup source, hkbCharacterSetup dest);
        public static partial void Move(hkbCharacterSkinInfo source, hkbCharacterSkinInfo dest);
        public static partial void Move(hkbCharacterSteppedInfo source, hkbCharacterSteppedInfo dest);
        public static partial void Move(hkbCharacterStringData source, hkbCharacterStringData dest);
        public static partial void Move(hkbClientCharacterState source, hkbClientCharacterState dest);
        public static partial void Move(hkbClipGenerator source, hkbClipGenerator dest);
        public static partial void Move(hkbClipGeneratorEcho source, hkbClipGeneratorEcho dest);
        public static partial void Move(hkbClipGeneratorInternalState source, hkbClipGeneratorInternalState dest);
        public static partial void Move(hkbClipTrigger source, hkbClipTrigger dest);
        public static partial void Move(hkbClipTriggerArray source, hkbClipTriggerArray dest);
        public static partial void Move(hkbCombineTransformsModifier source, hkbCombineTransformsModifier dest);
        public static partial void Move(hkbCombineTransformsModifierInternalState source, hkbCombineTransformsModifierInternalState dest);
        public static partial void Move(hkbCompiledExpressionSet source, hkbCompiledExpressionSet dest);
        public static partial void Move(hkbCompiledExpressionSetToken source, hkbCompiledExpressionSetToken dest);
        public static partial void Move(hkbComputeDirectionModifier source, hkbComputeDirectionModifier dest);
        public static partial void Move(hkbComputeDirectionModifierInternalState source, hkbComputeDirectionModifierInternalState dest);
        public static partial void Move(hkbComputeRotationFromAxisAngleModifier source, hkbComputeRotationFromAxisAngleModifier dest);
        public static partial void Move(hkbComputeRotationFromAxisAngleModifierInternalState source, hkbComputeRotationFromAxisAngleModifierInternalState dest);
        public static partial void Move(hkbComputeRotationToTargetModifier source, hkbComputeRotationToTargetModifier dest);
        public static partial void Move(hkbComputeRotationToTargetModifierInternalState source, hkbComputeRotationToTargetModifierInternalState dest);
        public static partial void Move(hkbCondition source, hkbCondition dest);
        public static partial void Move(hkbContext source, hkbContext dest);
        public static partial void Move(hkbDampingModifier source, hkbDampingModifier dest);
        public static partial void Move(hkbDampingModifierInternalState source, hkbDampingModifierInternalState dest);
        public static partial void Move(hkbDefaultMessageLog source, hkbDefaultMessageLog dest);
        public static partial void Move(hkbDelayedModifier source, hkbDelayedModifier dest);
        public static partial void Move(hkbDelayedModifierInternalState source, hkbDelayedModifierInternalState dest);
        public static partial void Move(hkbDetectCloseToGroundModifier source, hkbDetectCloseToGroundModifier dest);
        public static partial void Move(hkbDetectCloseToGroundModifierInternalState source, hkbDetectCloseToGroundModifierInternalState dest);
        public static partial void Move(hkbEvaluateExpressionModifier source, hkbEvaluateExpressionModifier dest);
        public static partial void Move(hkbEvaluateExpressionModifierInternalExpressionData source, hkbEvaluateExpressionModifierInternalExpressionData dest);
        public static partial void Move(hkbEvaluateExpressionModifierInternalState source, hkbEvaluateExpressionModifierInternalState dest);
        public static partial void Move(hkbEvaluateHandleModifier source, hkbEvaluateHandleModifier dest);
        public static partial void Move(hkbEvent source, hkbEvent dest);
        public static partial void Move(hkbEventBase source, hkbEventBase dest);
        public static partial void Move(hkbEventDrivenModifier source, hkbEventDrivenModifier dest);
        public static partial void Move(hkbEventDrivenModifierInternalState source, hkbEventDrivenModifierInternalState dest);
        public static partial void Move(hkbEventInfo source, hkbEventInfo dest);
        public static partial void Move(hkbEventPayload source, hkbEventPayload dest);
        public static partial void Move(hkbEventPayloadList source, hkbEventPayloadList dest);
        public static partial void Move(hkbEventProperty source, hkbEventProperty dest);
        public static partial void Move(hkbEventRaisedInfo source, hkbEventRaisedInfo dest);
        public static partial void Move(hkbEventRangeData source, hkbEventRangeData dest);
        public static partial void Move(hkbEventRangeDataArray source, hkbEventRangeDataArray dest);
        public static partial void Move(hkbEventSequencedData source, hkbEventSequencedData dest);
        public static partial void Move(hkbEventSequencedDataSequencedEvent source, hkbEventSequencedDataSequencedEvent dest);
        public static partial void Move(hkbEventsFromRangeModifier source, hkbEventsFromRangeModifier dest);
        public static partial void Move(hkbEventsFromRangeModifierInternalState source, hkbEventsFromRangeModifierInternalState dest);
        public static partial void Move(hkbExpressionCondition source, hkbExpressionCondition dest);
        public static partial void Move(hkbExpressionData source, hkbExpressionData dest);
        public static partial void Move(hkbExpressionDataArray source, hkbExpressionDataArray dest);
        public static partial void Move(hkbExtractRagdollPoseModifier source, hkbExtractRagdollPoseModifier dest);
        public static partial void Move(hkbFootIkControlData source, hkbFootIkControlData dest);
        public static partial void Move(hkbFootIkControlsModifier source, hkbFootIkControlsModifier dest);
        public static partial void Move(hkbFootIkControlsModifierLeg source, hkbFootIkControlsModifierLeg dest);
        public static partial void Move(hkbFootIkDriverInfo source, hkbFootIkDriverInfo dest);
        public static partial void Move(hkbFootIkDriverInfoLeg source, hkbFootIkDriverInfoLeg dest);
        public static partial void Move(hkbFootIkGains source, hkbFootIkGains dest);
        public static partial void Move(hkbFootIkModifier source, hkbFootIkModifier dest);
        public static partial void Move(hkbFootIkModifierInternalLegData source, hkbFootIkModifierInternalLegData dest);
        public static partial void Move(hkbFootIkModifierLeg source, hkbFootIkModifierLeg dest);
        public static partial void Move(hkbGenerator source, hkbGenerator dest);
        public static partial void Move(hkbGeneratorOutputListener source, hkbGeneratorOutputListener dest);
        public static partial void Move(hkbGeneratorSyncInfo source, hkbGeneratorSyncInfo dest);
        public static partial void Move(hkbGeneratorSyncInfoSyncPoint source, hkbGeneratorSyncInfoSyncPoint dest);
        public static partial void Move(hkbGeneratorTransitionEffect source, hkbGeneratorTransitionEffect dest);
        public static partial void Move(hkbGeneratorTransitionEffectInternalState source, hkbGeneratorTransitionEffectInternalState dest);
        public static partial void Move(hkbGetHandleOnBoneModifier source, hkbGetHandleOnBoneModifier dest);
        public static partial void Move(hkbGetUpModifier source, hkbGetUpModifier dest);
        public static partial void Move(hkbGetUpModifierInternalState source, hkbGetUpModifierInternalState dest);
        public static partial void Move(hkbGetWorldFromModelModifier source, hkbGetWorldFromModelModifier dest);
        public static partial void Move(hkbGetWorldFromModelModifierInternalState source, hkbGetWorldFromModelModifierInternalState dest);
        public static partial void Move(hkbHandIkControlData source, hkbHandIkControlData dest);
        public static partial void Move(hkbHandIkControlsModifier source, hkbHandIkControlsModifier dest);
        public static partial void Move(hkbHandIkControlsModifierHand source, hkbHandIkControlsModifierHand dest);
        public static partial void Move(hkbHandIkDriverInfo source, hkbHandIkDriverInfo dest);
        public static partial void Move(hkbHandIkDriverInfoHand source, hkbHandIkDriverInfoHand dest);
        public static partial void Move(hkbHandIkModifier source, hkbHandIkModifier dest);
        public static partial void Move(hkbHandIkModifierHand source, hkbHandIkModifierHand dest);
        public static partial void Move(hkbHandle source, hkbHandle dest);
        public static partial void Move(hkbIntEventPayload source, hkbIntEventPayload dest);
        public static partial void Move(hkbIntVariableSequencedData source, hkbIntVariableSequencedData dest);
        public static partial void Move(hkbIntVariableSequencedDataSample source, hkbIntVariableSequencedDataSample dest);
        public static partial void Move(hkBitField source, hkBitField dest);
        public static partial void Move(hkbKeyframeBonesModifier source, hkbKeyframeBonesModifier dest);
        public static partial void Move(hkbKeyframeBonesModifierKeyframeInfo source, hkbKeyframeBonesModifierKeyframeInfo dest);
        public static partial void Move(hkbLinkedSymbolInfo source, hkbLinkedSymbolInfo dest);
        public static partial void Move(hkbLookAtModifier source, hkbLookAtModifier dest);
        public static partial void Move(hkbLookAtModifierInternalState source, hkbLookAtModifierInternalState dest);
        public static partial void Move(hkbManualSelectorGenerator source, hkbManualSelectorGenerator dest);
        public static partial void Move(hkbManualSelectorGeneratorInternalState source, hkbManualSelectorGeneratorInternalState dest);
        public static partial void Move(hkbMessageLog source, hkbMessageLog dest);
        public static partial void Move(hkbMirroredSkeletonInfo source, hkbMirroredSkeletonInfo dest);
        public static partial void Move(hkbMirrorModifier source, hkbMirrorModifier dest);
        public static partial void Move(hkbModifier source, hkbModifier dest);
        public static partial void Move(hkbModifierGenerator source, hkbModifierGenerator dest);
        public static partial void Move(hkbModifierList source, hkbModifierList dest);
        public static partial void Move(hkbModifierWrapper source, hkbModifierWrapper dest);
        public static partial void Move(hkbMoveCharacterModifier source, hkbMoveCharacterModifier dest);
        public static partial void Move(hkbMoveCharacterModifierInternalState source, hkbMoveCharacterModifierInternalState dest);
        public static partial void Move(hkbNamedEventPayload source, hkbNamedEventPayload dest);
        public static partial void Move(hkbNamedIntEventPayload source, hkbNamedIntEventPayload dest);
        public static partial void Move(hkbNamedRealEventPayload source, hkbNamedRealEventPayload dest);
        public static partial void Move(hkbNamedStringEventPayload source, hkbNamedStringEventPayload dest);
        public static partial void Move(hkbNode source, hkbNode dest);
        public static partial void Move(hkbNodeInternalStateInfo source, hkbNodeInternalStateInfo dest);
        public static partial void Move(hkbParticleSystemEventPayload source, hkbParticleSystemEventPayload dest);
        public static partial void Move(hkbPoseMatchingGenerator source, hkbPoseMatchingGenerator dest);
        public static partial void Move(hkbPoseMatchingGeneratorInternalState source, hkbPoseMatchingGeneratorInternalState dest);
        public static partial void Move(hkbPoweredRagdollControlData source, hkbPoweredRagdollControlData dest);
        public static partial void Move(hkbPoweredRagdollControlsModifier source, hkbPoweredRagdollControlsModifier dest);
        public static partial void Move(hkbProjectData source, hkbProjectData dest);
        public static partial void Move(hkbProjectStringData source, hkbProjectStringData dest);
        public static partial void Move(hkbProxyModifier source, hkbProxyModifier dest);
        public static partial void Move(hkbProxyModifierProxyInfo source, hkbProxyModifierProxyInfo dest);
        public static partial void Move(hkbRaiseEventCommand source, hkbRaiseEventCommand dest);
        public static partial void Move(hkbRealEventPayload source, hkbRealEventPayload dest);
        public static partial void Move(hkbRealVariableSequencedData source, hkbRealVariableSequencedData dest);
        public static partial void Move(hkbRealVariableSequencedDataSample source, hkbRealVariableSequencedDataSample dest);
        public static partial void Move(hkbReferencePoseGenerator source, hkbReferencePoseGenerator dest);
        public static partial void Move(hkbRegisteredGenerator source, hkbRegisteredGenerator dest);
        public static partial void Move(hkbRigidBodyRagdollControlData source, hkbRigidBodyRagdollControlData dest);
        public static partial void Move(hkbRigidBodyRagdollControlsModifier source, hkbRigidBodyRagdollControlsModifier dest);
        public static partial void Move(hkbRotateCharacterModifier source, hkbRotateCharacterModifier dest);
        public static partial void Move(hkbRotateCharacterModifierInternalState source, hkbRotateCharacterModifierInternalState dest);
        public static partial void Move(hkbSenseHandleModifier source, hkbSenseHandleModifier dest);
        public static partial void Move(hkbSenseHandleModifierRange source, hkbSenseHandleModifierRange dest);
        public static partial void Move(hkbSequence source, hkbSequence dest);
        public static partial void Move(hkbSequencedData source, hkbSequencedData dest);
        public static partial void Move(hkbSequenceInternalState source, hkbSequenceInternalState dest);
        public static partial void Move(hkbSequenceStringData source, hkbSequenceStringData dest);
        public static partial void Move(hkbSetBehaviorCommand source, hkbSetBehaviorCommand dest);
        public static partial void Move(hkbSetLocalTimeOfClipGeneratorCommand source, hkbSetLocalTimeOfClipGeneratorCommand dest);
        public static partial void Move(hkbSetNodePropertyCommand source, hkbSetNodePropertyCommand dest);
        public static partial void Move(hkbSetWordVariableCommand source, hkbSetWordVariableCommand dest);
        public static partial void Move(hkbSetWorldFromModelModifier source, hkbSetWorldFromModelModifier dest);
        public static partial void Move(hkbSimulationControlCommand source, hkbSimulationControlCommand dest);
        public static partial void Move(hkbSimulationStateInfo source, hkbSimulationStateInfo dest);
        public static partial void Move(hkbStateChooser source, hkbStateChooser dest);
        public static partial void Move(hkbStateListener source, hkbStateListener dest);
        public static partial void Move(hkbStateMachine source, hkbStateMachine dest);
        public static partial void Move(hkbStateMachineActiveTransitionInfo source, hkbStateMachineActiveTransitionInfo dest);
        public static partial void Move(hkbStateMachineDelayedTransitionInfo source, hkbStateMachineDelayedTransitionInfo dest);
        public static partial void Move(hkbStateMachineEventPropertyArray source, hkbStateMachineEventPropertyArray dest);
        public static partial void Move(hkbStateMachineInternalState source, hkbStateMachineInternalState dest);
        public static partial void Move(hkbStateMachineNestedStateMachineData source, hkbStateMachineNestedStateMachineData dest);
        public static partial void Move(hkbStateMachineProspectiveTransitionInfo source, hkbStateMachineProspectiveTransitionInfo dest);
        public static partial void Move(hkbStateMachineStateInfo source, hkbStateMachineStateInfo dest);
        public static partial void Move(hkbStateMachineTimeInterval source, hkbStateMachineTimeInterval dest);
        public static partial void Move(hkbStateMachineTransitionInfo source, hkbStateMachineTransitionInfo dest);
        public static partial void Move(hkbStateMachineTransitionInfoArray source, hkbStateMachineTransitionInfoArray dest);
        public static partial void Move(hkbStateMachineTransitionInfoReference source, hkbStateMachineTransitionInfoReference dest);
        public static partial void Move(hkbStringCondition source, hkbStringCondition dest);
        public static partial void Move(hkbStringEventPayload source, hkbStringEventPayload dest);
        public static partial void Move(hkbTestStateChooser source, hkbTestStateChooser dest);
        public static partial void Move(hkbTimerModifier source, hkbTimerModifier dest);
        public static partial void Move(hkbTimerModifierInternalState source, hkbTimerModifierInternalState dest);
        public static partial void Move(hkbTransformVectorModifier source, hkbTransformVectorModifier dest);
        public static partial void Move(hkbTransformVectorModifierInternalState source, hkbTransformVectorModifierInternalState dest);
        public static partial void Move(hkbTransitionEffect source, hkbTransitionEffect dest);
        public static partial void Move(hkbTwistModifier source, hkbTwistModifier dest);
        public static partial void Move(hkbVariableBindingSet source, hkbVariableBindingSet dest);
        public static partial void Move(hkbVariableBindingSetBinding source, hkbVariableBindingSetBinding dest);
        public static partial void Move(hkbVariableValue source, hkbVariableValue dest);
        public static partial void Move(hkbVariableValueSet source, hkbVariableValueSet dest);
        public static partial void Move(hkbWorldEnums source, hkbWorldEnums dest);
        public static partial void Move(hkbWorldFromModelModeData source, hkbWorldFromModelModeData dest);
        public static partial void Move(hkClass source, hkClass dest);
        public static partial void Move(hkClassEnum source, hkClassEnum dest);
        public static partial void Move(hkClassEnumItem source, hkClassEnumItem dest);
        public static partial void Move(hkClassMember source, hkClassMember dest);
        public static partial void Move(hkColor source, hkColor dest);
        public static partial void Move(hkContactPoint source, hkContactPoint dest);
        public static partial void Move(hkContactPointMaterial source, hkContactPointMaterial dest);
        public static partial void Move(hkCustomAttributes source, hkCustomAttributes dest);
        public static partial void Move(hkCustomAttributesAttribute source, hkCustomAttributesAttribute dest);
        public static partial void Move(hkDataObjectTypeAttribute source, hkDataObjectTypeAttribute dest);
        public static partial void Move(hkDescriptionAttribute source, hkDescriptionAttribute dest);
        public static partial void Move(hkDocumentationAttribute source, hkDocumentationAttribute dest);
        public static partial void Move(hkGeometry source, hkGeometry dest);
        public static partial void Move(hkGeometryTriangle source, hkGeometryTriangle dest);
        public static partial void Move(hkGizmoAttribute source, hkGizmoAttribute dest);
        public static partial void Move(hkHalf8 source, hkHalf8 dest);
        public static partial void Move(hkLinkAttribute source, hkLinkAttribute dest);
        public static partial void Move(hkLocalFrame source, hkLocalFrame dest);
        public static partial void Move(hkLocalFrameGroup source, hkLocalFrameGroup dest);
        public static partial void Move(hkMemoryResourceContainer source, hkMemoryResourceContainer dest);
        public static partial void Move(hkMemoryResourceHandle source, hkMemoryResourceHandle dest);
        public static partial void Move(hkMemoryResourceHandleExternalLink source, hkMemoryResourceHandleExternalLink dest);
        public static partial void Move(hkMemoryTrackerAttribute source, hkMemoryTrackerAttribute dest);
        public static partial void Move(hkModelerNodeTypeAttribute source, hkModelerNodeTypeAttribute dest);
        public static partial void Move(hkMoppBvTreeShapeBase source, hkMoppBvTreeShapeBase dest);
        public static partial void Move(hkMotionState source, hkMotionState dest);
        public static partial void Move(hkMultiThreadCheck source, hkMultiThreadCheck dest);
        public static partial void Move(hkpAabbPhantom source, hkpAabbPhantom dest);
        public static partial void Move(hkPackedVector3 source, hkPackedVector3 dest);
        public static partial void Move(hkPackfileHeader source, hkPackfileHeader dest);
        public static partial void Move(hkPackfileSectionHeader source, hkPackfileSectionHeader dest);
        public static partial void Move(hkpAction source, hkpAction dest);
        public static partial void Move(hkpAgent1nSector source, hkpAgent1nSector dest);
        public static partial void Move(hkpAngConstraintAtom source, hkpAngConstraintAtom dest);
        public static partial void Move(hkpAngFrictionConstraintAtom source, hkpAngFrictionConstraintAtom dest);
        public static partial void Move(hkpAngLimitConstraintAtom source, hkpAngLimitConstraintAtom dest);
        public static partial void Move(hkpAngMotorConstraintAtom source, hkpAngMotorConstraintAtom dest);
        public static partial void Move(hkpAngularDashpotAction source, hkpAngularDashpotAction dest);
        public static partial void Move(hkpArrayAction source, hkpArrayAction dest);
        public static partial void Move(hkpBallAndSocketConstraintData source, hkpBallAndSocketConstraintData dest);
        public static partial void Move(hkpBallAndSocketConstraintDataAtoms source, hkpBallAndSocketConstraintDataAtoms dest);
        public static partial void Move(hkpBallGun source, hkpBallGun dest);
        public static partial void Move(hkpBallSocketChainData source, hkpBallSocketChainData dest);
        public static partial void Move(hkpBallSocketChainDataConstraintInfo source, hkpBallSocketChainDataConstraintInfo dest);
        public static partial void Move(hkpBallSocketConstraintAtom source, hkpBallSocketConstraintAtom dest);
        public static partial void Move(hkpBinaryAction source, hkpBinaryAction dest);
        public static partial void Move(hkpBoxMotion source, hkpBoxMotion dest);
        public static partial void Move(hkpBoxShape source, hkpBoxShape dest);
        public static partial void Move(hkpBreakableBody source, hkpBreakableBody dest);
        public static partial void Move(hkpBreakableConstraintData source, hkpBreakableConstraintData dest);
        public static partial void Move(hkpBridgeAtoms source, hkpBridgeAtoms dest);
        public static partial void Move(hkpBridgeConstraintAtom source, hkpBridgeConstraintAtom dest);
        public static partial void Move(hkpBroadPhaseHandle source, hkpBroadPhaseHandle dest);
        public static partial void Move(hkpBvShape source, hkpBvShape dest);
        public static partial void Move(hkpBvTreeShape source, hkpBvTreeShape dest);
        public static partial void Move(hkpCachingShapePhantom source, hkpCachingShapePhantom dest);
        public static partial void Move(hkpCallbackConstraintMotor source, hkpCallbackConstraintMotor dest);
        public static partial void Move(hkpCapsuleShape source, hkpCapsuleShape dest);
        public static partial void Move(hkpCdBody source, hkpCdBody dest);
        public static partial void Move(hkpCenterOfMassChangerModifierConstraintAtom source, hkpCenterOfMassChangerModifierConstraintAtom dest);
        public static partial void Move(hkpCharacterControllerCinfo source, hkpCharacterControllerCinfo dest);
        public static partial void Move(hkpCharacterMotion source, hkpCharacterMotion dest);
        public static partial void Move(hkpCharacterProxyCinfo source, hkpCharacterProxyCinfo dest);
        public static partial void Move(hkpCharacterRigidBodyCinfo source, hkpCharacterRigidBodyCinfo dest);
        public static partial void Move(hkpCogWheelConstraintAtom source, hkpCogWheelConstraintAtom dest);
        public static partial void Move(hkpCogWheelConstraintData source, hkpCogWheelConstraintData dest);
        public static partial void Move(hkpCogWheelConstraintDataAtoms source, hkpCogWheelConstraintDataAtoms dest);
        public static partial void Move(hkpCollidable source, hkpCollidable dest);
        public static partial void Move(hkpCollidableBoundingVolumeData source, hkpCollidableBoundingVolumeData dest);
        public static partial void Move(hkpCollidableCollidableFilter source, hkpCollidableCollidableFilter dest);
        public static partial void Move(hkpCollisionFilter source, hkpCollisionFilter dest);
        public static partial void Move(hkpCollisionFilterList source, hkpCollisionFilterList dest);
        public static partial void Move(hkpCompressedMeshShape source, hkpCompressedMeshShape dest);
        public static partial void Move(hkpCompressedMeshShapeBigTriangle source, hkpCompressedMeshShapeBigTriangle dest);
        public static partial void Move(hkpCompressedMeshShapeChunk source, hkpCompressedMeshShapeChunk dest);
        public static partial void Move(hkpCompressedMeshShapeConvexPiece source, hkpCompressedMeshShapeConvexPiece dest);
        public static partial void Move(hkpCompressedSampledHeightFieldShape source, hkpCompressedSampledHeightFieldShape dest);
        public static partial void Move(hkpConeLimitConstraintAtom source, hkpConeLimitConstraintAtom dest);
        public static partial void Move(hkpConstrainedSystemFilter source, hkpConstrainedSystemFilter dest);
        public static partial void Move(hkpConstraintAtom source, hkpConstraintAtom dest);
        public static partial void Move(hkpConstraintChainData source, hkpConstraintChainData dest);
        public static partial void Move(hkpConstraintChainInstance source, hkpConstraintChainInstance dest);
        public static partial void Move(hkpConstraintChainInstanceAction source, hkpConstraintChainInstanceAction dest);
        public static partial void Move(hkpConstraintCollisionFilter source, hkpConstraintCollisionFilter dest);
        public static partial void Move(hkpConstraintData source, hkpConstraintData dest);
        public static partial void Move(hkpConstraintInstance source, hkpConstraintInstance dest);
        public static partial void Move(hkpConstraintInstanceSmallArraySerializeOverrideType source, hkpConstraintInstanceSmallArraySerializeOverrideType dest);
        public static partial void Move(hkpConstraintMotor source, hkpConstraintMotor dest);
        public static partial void Move(hkpConvexListFilter source, hkpConvexListFilter dest);
        public static partial void Move(hkpConvexListShape source, hkpConvexListShape dest);
        public static partial void Move(hkpConvexPieceStreamData source, hkpConvexPieceStreamData dest);
        public static partial void Move(hkpConvexShape source, hkpConvexShape dest);
        public static partial void Move(hkpConvexTransformShape source, hkpConvexTransformShape dest);
        public static partial void Move(hkpConvexTransformShapeBase source, hkpConvexTransformShapeBase dest);
        public static partial void Move(hkpConvexTranslateShape source, hkpConvexTranslateShape dest);
        public static partial void Move(hkpConvexVerticesConnectivity source, hkpConvexVerticesConnectivity dest);
        public static partial void Move(hkpConvexVerticesShape source, hkpConvexVerticesShape dest);
        public static partial void Move(hkpConvexVerticesShapeFourVectors source, hkpConvexVerticesShapeFourVectors dest);
        public static partial void Move(hkpCylinderShape source, hkpCylinderShape dest);
        public static partial void Move(hkpDashpotAction source, hkpDashpotAction dest);
        public static partial void Move(hkpDefaultConvexListFilter source, hkpDefaultConvexListFilter dest);
        public static partial void Move(hkpDefaultWorldMemoryWatchDog source, hkpDefaultWorldMemoryWatchDog dest);
        public static partial void Move(hkpDisableEntityCollisionFilter source, hkpDisableEntityCollisionFilter dest);
        public static partial void Move(hkpDisplayBindingData source, hkpDisplayBindingData dest);
        public static partial void Move(hkpDisplayBindingDataPhysicsSystem source, hkpDisplayBindingDataPhysicsSystem dest);
        public static partial void Move(hkpDisplayBindingDataRigidBody source, hkpDisplayBindingDataRigidBody dest);
        public static partial void Move(hkpEntity source, hkpEntity dest);
        public static partial void Move(hkpEntityExtendedListeners source, hkpEntityExtendedListeners dest);
        public static partial void Move(hkpEntitySmallArraySerializeOverrideType source, hkpEntitySmallArraySerializeOverrideType dest);
        public static partial void Move(hkpEntitySpuCollisionCallback source, hkpEntitySpuCollisionCallback dest);
        public static partial void Move(hkpFastMeshShape source, hkpFastMeshShape dest);
        public static partial void Move(hkpFirstPersonGun source, hkpFirstPersonGun dest);
        public static partial void Move(hkpFixedRigidMotion source, hkpFixedRigidMotion dest);
        public static partial void Move(hkpGenericConstraintData source, hkpGenericConstraintData dest);
        public static partial void Move(hkpGenericConstraintDataScheme source, hkpGenericConstraintDataScheme dest);
        public static partial void Move(hkpGenericConstraintDataSchemeConstraintInfo source, hkpGenericConstraintDataSchemeConstraintInfo dest);
        public static partial void Move(hkpGravityGun source, hkpGravityGun dest);
        public static partial void Move(hkpGroupCollisionFilter source, hkpGroupCollisionFilter dest);
        public static partial void Move(hkpGroupFilter source, hkpGroupFilter dest);
        public static partial void Move(hkpHeightFieldShape source, hkpHeightFieldShape dest);
        public static partial void Move(hkpHingeConstraintData source, hkpHingeConstraintData dest);
        public static partial void Move(hkpHingeConstraintDataAtoms source, hkpHingeConstraintDataAtoms dest);
        public static partial void Move(hkpHingeLimitsData source, hkpHingeLimitsData dest);
        public static partial void Move(hkpHingeLimitsDataAtoms source, hkpHingeLimitsDataAtoms dest);
        public static partial void Move(hkpIgnoreModifierConstraintAtom source, hkpIgnoreModifierConstraintAtom dest);
        public static partial void Move(hkpKeyframedRigidMotion source, hkpKeyframedRigidMotion dest);
        public static partial void Move(hkpLimitedForceConstraintMotor source, hkpLimitedForceConstraintMotor dest);
        public static partial void Move(hkpLimitedHingeConstraintData source, hkpLimitedHingeConstraintData dest);
        public static partial void Move(hkpLimitedHingeConstraintDataAtoms source, hkpLimitedHingeConstraintDataAtoms dest);
        public static partial void Move(hkpLinConstraintAtom source, hkpLinConstraintAtom dest);
        public static partial void Move(hkpLinearParametricCurve source, hkpLinearParametricCurve dest);
        public static partial void Move(hkpLinFrictionConstraintAtom source, hkpLinFrictionConstraintAtom dest);
        public static partial void Move(hkpLinkedCollidable source, hkpLinkedCollidable dest);
        public static partial void Move(hkpLinLimitConstraintAtom source, hkpLinLimitConstraintAtom dest);
        public static partial void Move(hkpLinMotorConstraintAtom source, hkpLinMotorConstraintAtom dest);
        public static partial void Move(hkpLinSoftConstraintAtom source, hkpLinSoftConstraintAtom dest);
        public static partial void Move(hkpListShape source, hkpListShape dest);
        public static partial void Move(hkpListShapeChildInfo source, hkpListShapeChildInfo dest);
        public static partial void Move(hkpMalleableConstraintData source, hkpMalleableConstraintData dest);
        public static partial void Move(hkpMassChangerModifierConstraintAtom source, hkpMassChangerModifierConstraintAtom dest);
        public static partial void Move(hkpMaterial source, hkpMaterial dest);
        public static partial void Move(hkpMaxSizeMotion source, hkpMaxSizeMotion dest);
        public static partial void Move(hkpMeshMaterial source, hkpMeshMaterial dest);
        public static partial void Move(hkpMeshShape source, hkpMeshShape dest);
        public static partial void Move(hkpMeshShapeSubpart source, hkpMeshShapeSubpart dest);
        public static partial void Move(hkpModifierConstraintAtom source, hkpModifierConstraintAtom dest);
        public static partial void Move(hkpMoppBvTreeShape source, hkpMoppBvTreeShape dest);
        public static partial void Move(hkpMoppCode source, hkpMoppCode dest);
        public static partial void Move(hkpMoppCodeCodeInfo source, hkpMoppCodeCodeInfo dest);
        public static partial void Move(hkpMoppCodeReindexedTerminal source, hkpMoppCodeReindexedTerminal dest);
        public static partial void Move(hkpMotion source, hkpMotion dest);
        public static partial void Move(hkpMotorAction source, hkpMotorAction dest);
        public static partial void Move(hkpMountedBallGun source, hkpMountedBallGun dest);
        public static partial void Move(hkpMouseSpringAction source, hkpMouseSpringAction dest);
        public static partial void Move(hkpMovingSurfaceModifierConstraintAtom source, hkpMovingSurfaceModifierConstraintAtom dest);
        public static partial void Move(hkpMultiRayShape source, hkpMultiRayShape dest);
        public static partial void Move(hkpMultiRayShapeRay source, hkpMultiRayShapeRay dest);
        public static partial void Move(hkpMultiSphereShape source, hkpMultiSphereShape dest);
        public static partial void Move(hkpNamedMeshMaterial source, hkpNamedMeshMaterial dest);
        public static partial void Move(hkpNullCollisionFilter source, hkpNullCollisionFilter dest);
        public static partial void Move(hkPostFinishAttribute source, hkPostFinishAttribute dest);
        public static partial void Move(hkpOverwritePivotConstraintAtom source, hkpOverwritePivotConstraintAtom dest);
        public static partial void Move(hkpPairCollisionFilter source, hkpPairCollisionFilter dest);
        public static partial void Move(hkpPairCollisionFilterMapPairFilterKeyOverrideType source, hkpPairCollisionFilterMapPairFilterKeyOverrideType dest);
        public static partial void Move(hkpParametricCurve source, hkpParametricCurve dest);
        public static partial void Move(hkpPhantom source, hkpPhantom dest);
        public static partial void Move(hkpPhantomCallbackShape source, hkpPhantomCallbackShape dest);
        public static partial void Move(hkpPhysicsData source, hkpPhysicsData dest);
        public static partial void Move(hkpPhysicsSystem source, hkpPhysicsSystem dest);
        public static partial void Move(hkpPhysicsSystemWithContacts source, hkpPhysicsSystemWithContacts dest);
        public static partial void Move(hkpPlaneShape source, hkpPlaneShape dest);
        public static partial void Move(hkpPointToPathConstraintData source, hkpPointToPathConstraintData dest);
        public static partial void Move(hkpPointToPlaneConstraintData source, hkpPointToPlaneConstraintData dest);
        public static partial void Move(hkpPointToPlaneConstraintDataAtoms source, hkpPointToPlaneConstraintDataAtoms dest);
        public static partial void Move(hkpPositionConstraintMotor source, hkpPositionConstraintMotor dest);
        public static partial void Move(hkpPoweredChainData source, hkpPoweredChainData dest);
        public static partial void Move(hkpPoweredChainDataConstraintInfo source, hkpPoweredChainDataConstraintInfo dest);
        public static partial void Move(hkpPoweredChainMapper source, hkpPoweredChainMapper dest);
        public static partial void Move(hkpPoweredChainMapperLinkInfo source, hkpPoweredChainMapperLinkInfo dest);
        public static partial void Move(hkpPoweredChainMapperTarget source, hkpPoweredChainMapperTarget dest);
        public static partial void Move(hkpPrismaticConstraintData source, hkpPrismaticConstraintData dest);
        public static partial void Move(hkpPrismaticConstraintDataAtoms source, hkpPrismaticConstraintDataAtoms dest);
        public static partial void Move(hkpProjectileGun source, hkpProjectileGun dest);
        public static partial void Move(hkpProperty source, hkpProperty dest);
        public static partial void Move(hkpPropertyValue source, hkpPropertyValue dest);
        public static partial void Move(hkpPulleyConstraintAtom source, hkpPulleyConstraintAtom dest);
        public static partial void Move(hkpPulleyConstraintData source, hkpPulleyConstraintData dest);
        public static partial void Move(hkpPulleyConstraintDataAtoms source, hkpPulleyConstraintDataAtoms dest);
        public static partial void Move(hkpRackAndPinionConstraintAtom source, hkpRackAndPinionConstraintAtom dest);
        public static partial void Move(hkpRackAndPinionConstraintData source, hkpRackAndPinionConstraintData dest);
        public static partial void Move(hkpRackAndPinionConstraintDataAtoms source, hkpRackAndPinionConstraintDataAtoms dest);
        public static partial void Move(hkpRagdollConstraintData source, hkpRagdollConstraintData dest);
        public static partial void Move(hkpRagdollConstraintDataAtoms source, hkpRagdollConstraintDataAtoms dest);
        public static partial void Move(hkpRagdollLimitsData source, hkpRagdollLimitsData dest);
        public static partial void Move(hkpRagdollLimitsDataAtoms source, hkpRagdollLimitsDataAtoms dest);
        public static partial void Move(hkpRagdollMotorConstraintAtom source, hkpRagdollMotorConstraintAtom dest);
        public static partial void Move(hkpRayCollidableFilter source, hkpRayCollidableFilter dest);
        public static partial void Move(hkpRayShapeCollectionFilter source, hkpRayShapeCollectionFilter dest);
        public static partial void Move(hkpRemoveTerminalsMoppModifier source, hkpRemoveTerminalsMoppModifier dest);
        public static partial void Move(hkpReorientAction source, hkpReorientAction dest);
        public static partial void Move(hkpRigidBody source, hkpRigidBody dest);
        public static partial void Move(hkpRotationalConstraintData source, hkpRotationalConstraintData dest);
        public static partial void Move(hkpRotationalConstraintDataAtoms source, hkpRotationalConstraintDataAtoms dest);
        public static partial void Move(hkpSampledHeightFieldShape source, hkpSampledHeightFieldShape dest);
        public static partial void Move(hkpSerializedAgentNnEntry source, hkpSerializedAgentNnEntry dest);
        public static partial void Move(hkpSerializedDisplayMarker source, hkpSerializedDisplayMarker dest);
        public static partial void Move(hkpSerializedDisplayMarkerList source, hkpSerializedDisplayMarkerList dest);
        public static partial void Move(hkpSerializedDisplayRbTransforms source, hkpSerializedDisplayRbTransforms dest);
        public static partial void Move(hkpSerializedDisplayRbTransformsDisplayTransformPair source, hkpSerializedDisplayRbTransformsDisplayTransformPair dest);
        public static partial void Move(hkpSerializedSubTrack1nInfo source, hkpSerializedSubTrack1nInfo dest);
        public static partial void Move(hkpSerializedTrack1nInfo source, hkpSerializedTrack1nInfo dest);
        public static partial void Move(hkpSetLocalRotationsConstraintAtom source, hkpSetLocalRotationsConstraintAtom dest);
        public static partial void Move(hkpSetLocalTransformsConstraintAtom source, hkpSetLocalTransformsConstraintAtom dest);
        public static partial void Move(hkpSetLocalTranslationsConstraintAtom source, hkpSetLocalTranslationsConstraintAtom dest);
        public static partial void Move(hkpSetupStabilizationAtom source, hkpSetupStabilizationAtom dest);
        public static partial void Move(hkpShape source, hkpShape dest);
        public static partial void Move(hkpShapeCollection source, hkpShapeCollection dest);
        public static partial void Move(hkpShapeCollectionFilter source, hkpShapeCollectionFilter dest);
        public static partial void Move(hkpShapeContainer source, hkpShapeContainer dest);
        public static partial void Move(hkpShapeInfo source, hkpShapeInfo dest);
        public static partial void Move(hkpShapeModifier source, hkpShapeModifier dest);
        public static partial void Move(hkpShapePhantom source, hkpShapePhantom dest);
        public static partial void Move(hkpSimpleContactConstraintAtom source, hkpSimpleContactConstraintAtom dest);
        public static partial void Move(hkpSimpleContactConstraintDataInfo source, hkpSimpleContactConstraintDataInfo dest);
        public static partial void Move(hkpSimpleShapePhantom source, hkpSimpleShapePhantom dest);
        public static partial void Move(hkpSimpleShapePhantomCollisionDetail source, hkpSimpleShapePhantomCollisionDetail dest);
        public static partial void Move(hkpSimulation source, hkpSimulation dest);
        public static partial void Move(hkpSingleShapeContainer source, hkpSingleShapeContainer dest);
        public static partial void Move(hkpSoftContactModifierConstraintAtom source, hkpSoftContactModifierConstraintAtom dest);
        public static partial void Move(hkpSphereMotion source, hkpSphereMotion dest);
        public static partial void Move(hkpSphereRepShape source, hkpSphereRepShape dest);
        public static partial void Move(hkpSphereShape source, hkpSphereShape dest);
        public static partial void Move(hkpSpringAction source, hkpSpringAction dest);
        public static partial void Move(hkpSpringDamperConstraintMotor source, hkpSpringDamperConstraintMotor dest);
        public static partial void Move(hkpStiffSpringChainData source, hkpStiffSpringChainData dest);
        public static partial void Move(hkpStiffSpringChainDataConstraintInfo source, hkpStiffSpringChainDataConstraintInfo dest);
        public static partial void Move(hkpStiffSpringConstraintAtom source, hkpStiffSpringConstraintAtom dest);
        public static partial void Move(hkpStiffSpringConstraintData source, hkpStiffSpringConstraintData dest);
        public static partial void Move(hkpStiffSpringConstraintDataAtoms source, hkpStiffSpringConstraintDataAtoms dest);
        public static partial void Move(hkpStorageMeshShape source, hkpStorageMeshShape dest);
        public static partial void Move(hkpStorageMeshShapeSubpartStorage source, hkpStorageMeshShapeSubpartStorage dest);
        public static partial void Move(hkpStorageSampledHeightFieldShape source, hkpStorageSampledHeightFieldShape dest);
        public static partial void Move(hkpThinBoxMotion source, hkpThinBoxMotion dest);
        public static partial void Move(hkpTransformShape source, hkpTransformShape dest);
        public static partial void Move(hkpTriangleShape source, hkpTriangleShape dest);
        public static partial void Move(hkpTriggerVolume source, hkpTriggerVolume dest);
        public static partial void Move(hkpTriggerVolumeEventInfo source, hkpTriggerVolumeEventInfo dest);
        public static partial void Move(hkpTriSampledHeightFieldBvTreeShape source, hkpTriSampledHeightFieldBvTreeShape dest);
        public static partial void Move(hkpTriSampledHeightFieldCollection source, hkpTriSampledHeightFieldCollection dest);
        public static partial void Move(hkpTwistLimitConstraintAtom source, hkpTwistLimitConstraintAtom dest);
        public static partial void Move(hkpTypedBroadPhaseHandle source, hkpTypedBroadPhaseHandle dest);
        public static partial void Move(hkpUnaryAction source, hkpUnaryAction dest);
        public static partial void Move(hkpVelocityConstraintMotor source, hkpVelocityConstraintMotor dest);
        public static partial void Move(hkpViscousSurfaceModifierConstraintAtom source, hkpViscousSurfaceModifierConstraintAtom dest);
        public static partial void Move(hkpWeldingUtility source, hkpWeldingUtility dest);
        public static partial void Move(hkpWheelConstraintData source, hkpWheelConstraintData dest);
        public static partial void Move(hkpWheelConstraintDataAtoms source, hkpWheelConstraintDataAtoms dest);
        public static partial void Move(hkpWorld source, hkpWorld dest);
        public static partial void Move(hkpWorldCinfo source, hkpWorldCinfo dest);
        public static partial void Move(hkpWorldObject source, hkpWorldObject dest);
        public static partial void Move(hkQTransform source, hkQTransform dest);
        public static partial void Move(hkRangeInt32Attribute source, hkRangeInt32Attribute dest);
        public static partial void Move(hkRangeRealAttribute source, hkRangeRealAttribute dest);
        public static partial void Move(hkReflectedFileAttribute source, hkReflectedFileAttribute dest);
        public static partial void Move(hkResourceBase source, hkResourceBase dest);
        public static partial void Move(hkResourceContainer source, hkResourceContainer dest);
        public static partial void Move(hkResourceHandle source, hkResourceHandle dest);
        public static partial void Move(hkSemanticsAttribute source, hkSemanticsAttribute dest);
        public static partial void Move(hkSimpleLocalFrame source, hkSimpleLocalFrame dest);
        public static partial void Move(hkSphere source, hkSphere dest);
        public static partial void Move(hkSweptTransform source, hkSweptTransform dest);
        public static partial void Move(hkTraceStreamTitle source, hkTraceStreamTitle dest);
        public static partial void Move(hkTrackerSerializableScanSnapshot source, hkTrackerSerializableScanSnapshot dest);
        public static partial void Move(hkTrackerSerializableScanSnapshotAllocation source, hkTrackerSerializableScanSnapshotAllocation dest);
        public static partial void Move(hkTrackerSerializableScanSnapshotBlock source, hkTrackerSerializableScanSnapshotBlock dest);
        public static partial void Move(hkUiAttribute source, hkUiAttribute dest);
        public static partial void Move(hkWorldMemoryAvailableWatchDog source, hkWorldMemoryAvailableWatchDog dest);
        public static partial void Move(hkxAnimatedFloat source, hkxAnimatedFloat dest);
        public static partial void Move(hkxAnimatedMatrix source, hkxAnimatedMatrix dest);
        public static partial void Move(hkxAnimatedQuaternion source, hkxAnimatedQuaternion dest);
        public static partial void Move(hkxAnimatedVector source, hkxAnimatedVector dest);
        public static partial void Move(hkxAttribute source, hkxAttribute dest);
        public static partial void Move(hkxAttributeGroup source, hkxAttributeGroup dest);
        public static partial void Move(hkxAttributeHolder source, hkxAttributeHolder dest);
        public static partial void Move(hkxCamera source, hkxCamera dest);
        public static partial void Move(hkxEdgeSelectionChannel source, hkxEdgeSelectionChannel dest);
        public static partial void Move(hkxEnum source, hkxEnum dest);
        public static partial void Move(hkxEnumItem source, hkxEnumItem dest);
        public static partial void Move(hkxEnvironment source, hkxEnvironment dest);
        public static partial void Move(hkxEnvironmentVariable source, hkxEnvironmentVariable dest);
        public static partial void Move(hkxIndexBuffer source, hkxIndexBuffer dest);
        public static partial void Move(hkxLight source, hkxLight dest);
        public static partial void Move(hkxMaterial source, hkxMaterial dest);
        public static partial void Move(hkxMaterialEffect source, hkxMaterialEffect dest);
        public static partial void Move(hkxMaterialProperty source, hkxMaterialProperty dest);
        public static partial void Move(hkxMaterialShader source, hkxMaterialShader dest);
        public static partial void Move(hkxMaterialShaderSet source, hkxMaterialShaderSet dest);
        public static partial void Move(hkxMaterialTextureStage source, hkxMaterialTextureStage dest);
        public static partial void Move(hkxMesh source, hkxMesh dest);
        public static partial void Move(hkxMeshSection source, hkxMeshSection dest);
        public static partial void Move(hkxMeshUserChannelInfo source, hkxMeshUserChannelInfo dest);
        public static partial void Move(hkxNode source, hkxNode dest);
        public static partial void Move(hkxNodeAnnotationData source, hkxNodeAnnotationData dest);
        public static partial void Move(hkxNodeSelectionSet source, hkxNodeSelectionSet dest);
        public static partial void Move(hkxScene source, hkxScene dest);
        public static partial void Move(hkxSkinBinding source, hkxSkinBinding dest);
        public static partial void Move(hkxSparselyAnimatedBool source, hkxSparselyAnimatedBool dest);
        public static partial void Move(hkxSparselyAnimatedEnum source, hkxSparselyAnimatedEnum dest);
        public static partial void Move(hkxSparselyAnimatedInt source, hkxSparselyAnimatedInt dest);
        public static partial void Move(hkxSparselyAnimatedString source, hkxSparselyAnimatedString dest);
        public static partial void Move(hkxTextureFile source, hkxTextureFile dest);
        public static partial void Move(hkxTextureInplace source, hkxTextureInplace dest);
        public static partial void Move(hkxTriangleSelectionChannel source, hkxTriangleSelectionChannel dest);
        public static partial void Move(hkxVertexBuffer source, hkxVertexBuffer dest);
        public static partial void Move(hkxVertexBufferVertexData source, hkxVertexBufferVertexData dest);
        public static partial void Move(hkxVertexDescription source, hkxVertexDescription dest);
        public static partial void Move(hkxVertexDescriptionElementDecl source, hkxVertexDescriptionElementDecl dest);
        public static partial void Move(hkxVertexFloatDataChannel source, hkxVertexFloatDataChannel dest);
        public static partial void Move(hkxVertexIntDataChannel source, hkxVertexIntDataChannel dest);
        public static partial void Move(hkxVertexSelectionChannel source, hkxVertexSelectionChannel dest);
        public static partial void Move(hkxVertexVectorDataChannel source, hkxVertexVectorDataChannel dest);
        #endregion 
    }
}
