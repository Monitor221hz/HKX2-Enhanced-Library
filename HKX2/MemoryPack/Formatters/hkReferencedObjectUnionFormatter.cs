// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkReferencedObjectUnionFormatter : MemoryPackFormatter<hkReferencedObject>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkReferencedObject? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkAlignSceneToNodeOptions v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkLocalFrameGroup v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkMemoryResourceContainer v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkResourceContainer v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case hkMemoryResourceHandle v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case hkResourceHandle v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            case hkResourceBase v6: writer.WriteUnionHeader(6); writer.WritePackable(v6); break;
            case hkSimpleLocalFrame v7: writer.WriteUnionHeader(7); writer.WritePackable(v7); break;
            case hkTrackerSerializableScanSnapshot v8: writer.WriteUnionHeader(8); writer.WritePackable(v8); break;
            case hkpDefaultWorldMemoryWatchDog v9: writer.WriteUnionHeader(9); writer.WritePackable(v9); break;
            case hkWorldMemoryAvailableWatchDog v10: writer.WriteUnionHeader(10); writer.WritePackable(v10); break;
            case hkaAnimationBinding v11: writer.WriteUnionHeader(11); writer.WritePackable(v11); break;
            case hkaAnimationContainer v12: writer.WriteUnionHeader(12); writer.WritePackable(v12); break;
            case hkaAnimationPreviewColorContainer v13: writer.WriteUnionHeader(13); writer.WritePackable(v13); break;
            case hkaBoneAttachment v14: writer.WriteUnionHeader(14); writer.WritePackable(v14); break;
            case hkaDefaultAnimatedReferenceFrame v15: writer.WriteUnionHeader(15); writer.WritePackable(v15); break;
            case hkaFootstepAnalysisInfo v16: writer.WriteUnionHeader(16); writer.WritePackable(v16); break;
            case hkaFootstepAnalysisInfoContainer v17: writer.WriteUnionHeader(17); writer.WritePackable(v17); break;
            case hkaInterleavedUncompressedAnimation v18: writer.WriteUnionHeader(18); writer.WritePackable(v18); break;
            case hkaMeshBinding v19: writer.WriteUnionHeader(19); writer.WritePackable(v19); break;
            case hkaQuantizedAnimation v20: writer.WriteUnionHeader(20); writer.WritePackable(v20); break;
            case hkaRagdollInstance v21: writer.WriteUnionHeader(21); writer.WritePackable(v21); break;
            case hkaSkeleton v22: writer.WriteUnionHeader(22); writer.WritePackable(v22); break;
            case hkaSkeletonMapper v23: writer.WriteUnionHeader(23); writer.WritePackable(v23); break;
            case hkaSplineCompressedAnimation v24: writer.WriteUnionHeader(24); writer.WritePackable(v24); break;
            case hkbAttachmentSetup v25: writer.WriteUnionHeader(25); writer.WritePackable(v25); break;
            case hkbAuxiliaryNodeInfo v26: writer.WriteUnionHeader(26); writer.WritePackable(v26); break;
            case hkbBehaviorEventsInfo v27: writer.WriteUnionHeader(27); writer.WritePackable(v27); break;
            case hkbBehaviorGraphData v28: writer.WriteUnionHeader(28); writer.WritePackable(v28); break;
            case hkbBehaviorGraphInternalState v29: writer.WriteUnionHeader(29); writer.WritePackable(v29); break;
            case hkbBehaviorGraphInternalStateInfo v30: writer.WriteUnionHeader(30); writer.WritePackable(v30); break;
            case hkbBehaviorGraphStringData v31: writer.WriteUnionHeader(31); writer.WritePackable(v31); break;
            case hkbBehaviorInfo v32: writer.WriteUnionHeader(32); writer.WritePackable(v32); break;
            case BSBoneSwitchGeneratorBoneData v33: writer.WriteUnionHeader(33); writer.WritePackable(v33); break;
            case hkbBlenderGeneratorChild v34: writer.WriteUnionHeader(34); writer.WritePackable(v34); break;
            case hkbBoneIndexArray v35: writer.WriteUnionHeader(35); writer.WritePackable(v35); break;
            case hkbBoneWeightArray v36: writer.WriteUnionHeader(36); writer.WritePackable(v36); break;
            case BGSGamebryoSequenceGenerator v37: writer.WriteUnionHeader(37); writer.WritePackable(v37); break;
            case BSBoneSwitchGenerator v38: writer.WriteUnionHeader(38); writer.WritePackable(v38); break;
            case BSComputeAddBoneAnimModifier v39: writer.WriteUnionHeader(39); writer.WritePackable(v39); break;
            case BSCyclicBlendTransitionGenerator v40: writer.WriteUnionHeader(40); writer.WritePackable(v40); break;
            case BSDecomposeVectorModifier v41: writer.WriteUnionHeader(41); writer.WritePackable(v41); break;
            case BSDirectAtModifier v42: writer.WriteUnionHeader(42); writer.WritePackable(v42); break;
            case BSDistTriggerModifier v43: writer.WriteUnionHeader(43); writer.WritePackable(v43); break;
            case BSEventEveryNEventsModifier v44: writer.WriteUnionHeader(44); writer.WritePackable(v44); break;
            case BSEventOnDeactivateModifier v45: writer.WriteUnionHeader(45); writer.WritePackable(v45); break;
            case BSEventOnFalseToTrueModifier v46: writer.WriteUnionHeader(46); writer.WritePackable(v46); break;
            case BSGetTimeStepModifier v47: writer.WriteUnionHeader(47); writer.WritePackable(v47); break;
            case BSIStateManagerModifier v48: writer.WriteUnionHeader(48); writer.WritePackable(v48); break;
            case BSInterpValueModifier v49: writer.WriteUnionHeader(49); writer.WritePackable(v49); break;
            case BSIsActiveModifier v50: writer.WriteUnionHeader(50); writer.WritePackable(v50); break;
            case BSLimbIKModifier v51: writer.WriteUnionHeader(51); writer.WritePackable(v51); break;
            case BSLookAtModifier v52: writer.WriteUnionHeader(52); writer.WritePackable(v52); break;
            case BSModifyOnceModifier v53: writer.WriteUnionHeader(53); writer.WritePackable(v53); break;
            case BSOffsetAnimationGenerator v54: writer.WriteUnionHeader(54); writer.WritePackable(v54); break;
            case BSPassByTargetTriggerModifier v55: writer.WriteUnionHeader(55); writer.WritePackable(v55); break;
            case BSRagdollContactListenerModifier v56: writer.WriteUnionHeader(56); writer.WritePackable(v56); break;
            case BSSpeedSamplerModifier v57: writer.WriteUnionHeader(57); writer.WritePackable(v57); break;
            case BSSynchronizedClipGenerator v58: writer.WriteUnionHeader(58); writer.WritePackable(v58); break;
            case BSTimerModifier v59: writer.WriteUnionHeader(59); writer.WritePackable(v59); break;
            case BSTweenerModifier v60: writer.WriteUnionHeader(60); writer.WritePackable(v60); break;
            case BSiStateTaggingGenerator v61: writer.WriteUnionHeader(61); writer.WritePackable(v61); break;
            case hkbAttachmentModifier v62: writer.WriteUnionHeader(62); writer.WritePackable(v62); break;
            case hkbAttributeModifier v63: writer.WriteUnionHeader(63); writer.WritePackable(v63); break;
            case hkbBehaviorGraph v64: writer.WriteUnionHeader(64); writer.WritePackable(v64); break;
            case hkbBehaviorReferenceGenerator v65: writer.WriteUnionHeader(65); writer.WritePackable(v65); break;
            case hkbPoseMatchingGenerator v66: writer.WriteUnionHeader(66); writer.WritePackable(v66); break;
            case hkbBlenderGenerator v67: writer.WriteUnionHeader(67); writer.WritePackable(v67); break;
            case hkbBlendingTransitionEffect v68: writer.WriteUnionHeader(68); writer.WritePackable(v68); break;
            case hkbCharacterControllerModifier v69: writer.WriteUnionHeader(69); writer.WritePackable(v69); break;
            case hkbClipGenerator v70: writer.WriteUnionHeader(70); writer.WritePackable(v70); break;
            case hkbCombineTransformsModifier v71: writer.WriteUnionHeader(71); writer.WritePackable(v71); break;
            case hkbComputeDirectionModifier v72: writer.WriteUnionHeader(72); writer.WritePackable(v72); break;
            case hkbComputeRotationFromAxisAngleModifier v73: writer.WriteUnionHeader(73); writer.WritePackable(v73); break;
            case hkbComputeRotationToTargetModifier v74: writer.WriteUnionHeader(74); writer.WritePackable(v74); break;
            case hkbDampingModifier v75: writer.WriteUnionHeader(75); writer.WritePackable(v75); break;
            case hkbDetectCloseToGroundModifier v76: writer.WriteUnionHeader(76); writer.WritePackable(v76); break;
            case hkbEvaluateExpressionModifier v77: writer.WriteUnionHeader(77); writer.WritePackable(v77); break;
            case hkbEvaluateHandleModifier v78: writer.WriteUnionHeader(78); writer.WritePackable(v78); break;
            case hkbEventsFromRangeModifier v79: writer.WriteUnionHeader(79); writer.WritePackable(v79); break;
            case hkbExtractRagdollPoseModifier v80: writer.WriteUnionHeader(80); writer.WritePackable(v80); break;
            case hkbFootIkControlsModifier v81: writer.WriteUnionHeader(81); writer.WritePackable(v81); break;
            case hkbFootIkModifier v82: writer.WriteUnionHeader(82); writer.WritePackable(v82); break;
            case hkbGeneratorTransitionEffect v83: writer.WriteUnionHeader(83); writer.WritePackable(v83); break;
            case hkbGetHandleOnBoneModifier v84: writer.WriteUnionHeader(84); writer.WritePackable(v84); break;
            case hkbGetUpModifier v85: writer.WriteUnionHeader(85); writer.WritePackable(v85); break;
            case hkbGetWorldFromModelModifier v86: writer.WriteUnionHeader(86); writer.WritePackable(v86); break;
            case hkbHandIkControlsModifier v87: writer.WriteUnionHeader(87); writer.WritePackable(v87); break;
            case hkbHandIkModifier v88: writer.WriteUnionHeader(88); writer.WritePackable(v88); break;
            case hkbKeyframeBonesModifier v89: writer.WriteUnionHeader(89); writer.WritePackable(v89); break;
            case hkbLookAtModifier v90: writer.WriteUnionHeader(90); writer.WritePackable(v90); break;
            case hkbManualSelectorGenerator v91: writer.WriteUnionHeader(91); writer.WritePackable(v91); break;
            case hkbMirrorModifier v92: writer.WriteUnionHeader(92); writer.WritePackable(v92); break;
            case hkbModifierGenerator v93: writer.WriteUnionHeader(93); writer.WritePackable(v93); break;
            case hkbModifierList v94: writer.WriteUnionHeader(94); writer.WritePackable(v94); break;
            case hkbDelayedModifier v95: writer.WriteUnionHeader(95); writer.WritePackable(v95); break;
            case hkbEventDrivenModifier v96: writer.WriteUnionHeader(96); writer.WritePackable(v96); break;
            case hkbModifierWrapper v97: writer.WriteUnionHeader(97); writer.WritePackable(v97); break;
            case hkbMoveCharacterModifier v98: writer.WriteUnionHeader(98); writer.WritePackable(v98); break;
            case hkbPoweredRagdollControlsModifier v99: writer.WriteUnionHeader(99); writer.WritePackable(v99); break;
            case hkbProxyModifier v100: writer.WriteUnionHeader(100); writer.WritePackable(v100); break;
            case hkbReferencePoseGenerator v101: writer.WriteUnionHeader(101); writer.WritePackable(v101); break;
            case hkbRigidBodyRagdollControlsModifier v102: writer.WriteUnionHeader(102); writer.WritePackable(v102); break;
            case hkbRotateCharacterModifier v103: writer.WriteUnionHeader(103); writer.WritePackable(v103); break;
            case hkbSenseHandleModifier v104: writer.WriteUnionHeader(104); writer.WritePackable(v104); break;
            case hkbSequence v105: writer.WriteUnionHeader(105); writer.WritePackable(v105); break;
            case hkbSetWorldFromModelModifier v106: writer.WriteUnionHeader(106); writer.WritePackable(v106); break;
            case hkbStateMachine v107: writer.WriteUnionHeader(107); writer.WritePackable(v107); break;
            case hkbTimerModifier v108: writer.WriteUnionHeader(108); writer.WritePackable(v108); break;
            case hkbTransformVectorModifier v109: writer.WriteUnionHeader(109); writer.WritePackable(v109); break;
            case hkbTwistModifier v110: writer.WriteUnionHeader(110); writer.WritePackable(v110); break;
            case hkbNode v111: writer.WriteUnionHeader(111); writer.WritePackable(v111); break;
            case hkbRegisteredGenerator v112: writer.WriteUnionHeader(112); writer.WritePackable(v112); break;
            case hkbStateMachineStateInfo v113: writer.WriteUnionHeader(113); writer.WritePackable(v113); break;
            case hkbBindable v114: writer.WriteUnionHeader(114); writer.WritePackable(v114); break;
            case hkbBlenderGeneratorInternalState v115: writer.WriteUnionHeader(115); writer.WritePackable(v115); break;
            case hkbBlendingTransitionEffectInternalState v116: writer.WriteUnionHeader(116); writer.WritePackable(v116); break;
            case hkbCameraShakeEventPayload v117: writer.WriteUnionHeader(117); writer.WritePackable(v117); break;
            case hkbCharacter v118: writer.WriteUnionHeader(118); writer.WritePackable(v118); break;
            case hkbCharacterAddedInfo v119: writer.WriteUnionHeader(119); writer.WritePackable(v119); break;
            case hkbCharacterControlCommand v120: writer.WriteUnionHeader(120); writer.WritePackable(v120); break;
            case hkbCharacterControllerModifierInternalState v121: writer.WriteUnionHeader(121); writer.WritePackable(v121); break;
            case hkbCharacterData v122: writer.WriteUnionHeader(122); writer.WritePackable(v122); break;
            case hkbCharacterInfo v123: writer.WriteUnionHeader(123); writer.WritePackable(v123); break;
            case hkbCharacterSetup v124: writer.WriteUnionHeader(124); writer.WritePackable(v124); break;
            case hkbCharacterSkinInfo v125: writer.WriteUnionHeader(125); writer.WritePackable(v125); break;
            case hkbCharacterSteppedInfo v126: writer.WriteUnionHeader(126); writer.WritePackable(v126); break;
            case hkbCharacterStringData v127: writer.WriteUnionHeader(127); writer.WritePackable(v127); break;
            case hkbClientCharacterState v128: writer.WriteUnionHeader(128); writer.WritePackable(v128); break;
            case hkbClipGeneratorInternalState v129: writer.WriteUnionHeader(129); writer.WritePackable(v129); break;
            case hkbClipTriggerArray v130: writer.WriteUnionHeader(130); writer.WritePackable(v130); break;
            case hkbCombineTransformsModifierInternalState v131: writer.WriteUnionHeader(131); writer.WritePackable(v131); break;
            case hkbCompiledExpressionSet v132: writer.WriteUnionHeader(132); writer.WritePackable(v132); break;
            case hkbComputeDirectionModifierInternalState v133: writer.WriteUnionHeader(133); writer.WritePackable(v133); break;
            case hkbComputeRotationFromAxisAngleModifierInternalState v134: writer.WriteUnionHeader(134); writer.WritePackable(v134); break;
            case hkbComputeRotationToTargetModifierInternalState v135: writer.WriteUnionHeader(135); writer.WritePackable(v135); break;
            case hkbDampingModifierInternalState v136: writer.WriteUnionHeader(136); writer.WritePackable(v136); break;
            case hkbDelayedModifierInternalState v137: writer.WriteUnionHeader(137); writer.WritePackable(v137); break;
            case hkbDetectCloseToGroundModifierInternalState v138: writer.WriteUnionHeader(138); writer.WritePackable(v138); break;
            case hkbEvaluateExpressionModifierInternalState v139: writer.WriteUnionHeader(139); writer.WritePackable(v139); break;
            case hkbEventDrivenModifierInternalState v140: writer.WriteUnionHeader(140); writer.WritePackable(v140); break;
            case hkbEventPayloadList v141: writer.WriteUnionHeader(141); writer.WritePackable(v141); break;
            case hkbEventRaisedInfo v142: writer.WriteUnionHeader(142); writer.WritePackable(v142); break;
            case hkbEventRangeDataArray v143: writer.WriteUnionHeader(143); writer.WritePackable(v143); break;
            case hkbEventsFromRangeModifierInternalState v144: writer.WriteUnionHeader(144); writer.WritePackable(v144); break;
            case hkbExpressionCondition v145: writer.WriteUnionHeader(145); writer.WritePackable(v145); break;
            case hkbExpressionDataArray v146: writer.WriteUnionHeader(146); writer.WritePackable(v146); break;
            case hkbFootIkDriverInfo v147: writer.WriteUnionHeader(147); writer.WritePackable(v147); break;
            case hkbGeneratorOutputListener v148: writer.WriteUnionHeader(148); writer.WritePackable(v148); break;
            case hkbGeneratorTransitionEffectInternalState v149: writer.WriteUnionHeader(149); writer.WritePackable(v149); break;
            case hkbGetUpModifierInternalState v150: writer.WriteUnionHeader(150); writer.WritePackable(v150); break;
            case hkbGetWorldFromModelModifierInternalState v151: writer.WriteUnionHeader(151); writer.WritePackable(v151); break;
            case hkbHandIkDriverInfo v152: writer.WriteUnionHeader(152); writer.WritePackable(v152); break;
            case hkbHandle v153: writer.WriteUnionHeader(153); writer.WritePackable(v153); break;
            case hkbIntEventPayload v154: writer.WriteUnionHeader(154); writer.WritePackable(v154); break;
            case hkbLinkedSymbolInfo v155: writer.WriteUnionHeader(155); writer.WritePackable(v155); break;
            case hkbLookAtModifierInternalState v156: writer.WriteUnionHeader(156); writer.WritePackable(v156); break;
            case hkbManualSelectorGeneratorInternalState v157: writer.WriteUnionHeader(157); writer.WritePackable(v157); break;
            case hkbMirroredSkeletonInfo v158: writer.WriteUnionHeader(158); writer.WritePackable(v158); break;
            case hkbMoveCharacterModifierInternalState v159: writer.WriteUnionHeader(159); writer.WritePackable(v159); break;
            case hkbNamedIntEventPayload v160: writer.WriteUnionHeader(160); writer.WritePackable(v160); break;
            case hkbNamedRealEventPayload v161: writer.WriteUnionHeader(161); writer.WritePackable(v161); break;
            case hkbNamedStringEventPayload v162: writer.WriteUnionHeader(162); writer.WritePackable(v162); break;
            case hkbNamedEventPayload v163: writer.WriteUnionHeader(163); writer.WritePackable(v163); break;
            case hkbNodeInternalStateInfo v164: writer.WriteUnionHeader(164); writer.WritePackable(v164); break;
            case hkbParticleSystemEventPayload v165: writer.WriteUnionHeader(165); writer.WritePackable(v165); break;
            case hkbPoseMatchingGeneratorInternalState v166: writer.WriteUnionHeader(166); writer.WritePackable(v166); break;
            case hkbProjectData v167: writer.WriteUnionHeader(167); writer.WritePackable(v167); break;
            case hkbProjectStringData v168: writer.WriteUnionHeader(168); writer.WritePackable(v168); break;
            case hkbRaiseEventCommand v169: writer.WriteUnionHeader(169); writer.WritePackable(v169); break;
            case hkbRealEventPayload v170: writer.WriteUnionHeader(170); writer.WritePackable(v170); break;
            case hkbRotateCharacterModifierInternalState v171: writer.WriteUnionHeader(171); writer.WritePackable(v171); break;
            case hkbSequenceInternalState v172: writer.WriteUnionHeader(172); writer.WritePackable(v172); break;
            case hkbSequenceStringData v173: writer.WriteUnionHeader(173); writer.WritePackable(v173); break;
            case hkbBoolVariableSequencedData v174: writer.WriteUnionHeader(174); writer.WritePackable(v174); break;
            case hkbEventSequencedData v175: writer.WriteUnionHeader(175); writer.WritePackable(v175); break;
            case hkbIntVariableSequencedData v176: writer.WriteUnionHeader(176); writer.WritePackable(v176); break;
            case hkbRealVariableSequencedData v177: writer.WriteUnionHeader(177); writer.WritePackable(v177); break;
            case hkbSequencedData v178: writer.WriteUnionHeader(178); writer.WritePackable(v178); break;
            case hkbSetBehaviorCommand v179: writer.WriteUnionHeader(179); writer.WritePackable(v179); break;
            case hkbSetLocalTimeOfClipGeneratorCommand v180: writer.WriteUnionHeader(180); writer.WritePackable(v180); break;
            case hkbSetNodePropertyCommand v181: writer.WriteUnionHeader(181); writer.WritePackable(v181); break;
            case hkbSetWordVariableCommand v182: writer.WriteUnionHeader(182); writer.WritePackable(v182); break;
            case hkbSimulationControlCommand v183: writer.WriteUnionHeader(183); writer.WritePackable(v183); break;
            case hkbSimulationStateInfo v184: writer.WriteUnionHeader(184); writer.WritePackable(v184); break;
            case BSIStateManagerModifierBSIStateManagerStateListener v185: writer.WriteUnionHeader(185); writer.WritePackable(v185); break;
            case hkbStateListener v186: writer.WriteUnionHeader(186); writer.WritePackable(v186); break;
            case hkbStateMachineEventPropertyArray v187: writer.WriteUnionHeader(187); writer.WritePackable(v187); break;
            case hkbStateMachineInternalState v188: writer.WriteUnionHeader(188); writer.WritePackable(v188); break;
            case hkbStateMachineTransitionInfoArray v189: writer.WriteUnionHeader(189); writer.WritePackable(v189); break;
            case hkbStringCondition v190: writer.WriteUnionHeader(190); writer.WritePackable(v190); break;
            case hkbStringEventPayload v191: writer.WriteUnionHeader(191); writer.WritePackable(v191); break;
            case hkbTestStateChooser v192: writer.WriteUnionHeader(192); writer.WritePackable(v192); break;
            case hkbTimerModifierInternalState v193: writer.WriteUnionHeader(193); writer.WritePackable(v193); break;
            case hkbTransformVectorModifierInternalState v194: writer.WriteUnionHeader(194); writer.WritePackable(v194); break;
            case hkbVariableBindingSet v195: writer.WriteUnionHeader(195); writer.WritePackable(v195); break;
            case hkbVariableValueSet v196: writer.WriteUnionHeader(196); writer.WritePackable(v196); break;
            case hkpArrayAction v197: writer.WriteUnionHeader(197); writer.WritePackable(v197); break;
            case hkpBallAndSocketConstraintData v198: writer.WriteUnionHeader(198); writer.WritePackable(v198); break;
            case hkpAngularDashpotAction v199: writer.WriteUnionHeader(199); writer.WritePackable(v199); break;
            case hkpDashpotAction v200: writer.WriteUnionHeader(200); writer.WritePackable(v200); break;
            case hkpSpringAction v201: writer.WriteUnionHeader(201); writer.WritePackable(v201); break;
            case hkpBinaryAction v202: writer.WriteUnionHeader(202); writer.WritePackable(v202); break;
            case hkpBreakableBody v203: writer.WriteUnionHeader(203); writer.WritePackable(v203); break;
            case hkpBreakableConstraintData v204: writer.WriteUnionHeader(204); writer.WritePackable(v204); break;
            case hkpBvShape v205: writer.WriteUnionHeader(205); writer.WritePackable(v205); break;
            case hkpMoppBvTreeShape v206: writer.WriteUnionHeader(206); writer.WritePackable(v206); break;
            case hkMoppBvTreeShapeBase v207: writer.WriteUnionHeader(207); writer.WritePackable(v207); break;
            case hkpTriSampledHeightFieldBvTreeShape v208: writer.WriteUnionHeader(208); writer.WritePackable(v208); break;
            case hkpBvTreeShape v209: writer.WriteUnionHeader(209); writer.WritePackable(v209); break;
            case hkpCharacterProxyCinfo v210: writer.WriteUnionHeader(210); writer.WritePackable(v210); break;
            case hkpCharacterRigidBodyCinfo v211: writer.WriteUnionHeader(211); writer.WritePackable(v211); break;
            case hkpCharacterControllerCinfo v212: writer.WriteUnionHeader(212); writer.WritePackable(v212); break;
            case hkpCogWheelConstraintData v213: writer.WriteUnionHeader(213); writer.WritePackable(v213); break;
            case hkpCollisionFilterList v214: writer.WriteUnionHeader(214); writer.WritePackable(v214); break;
            case hkpConstrainedSystemFilter v215: writer.WriteUnionHeader(215); writer.WritePackable(v215); break;
            case hkpBallSocketChainData v216: writer.WriteUnionHeader(216); writer.WritePackable(v216); break;
            case hkpPoweredChainData v217: writer.WriteUnionHeader(217); writer.WritePackable(v217); break;
            case hkpStiffSpringChainData v218: writer.WriteUnionHeader(218); writer.WritePackable(v218); break;
            case hkpConstraintChainData v219: writer.WriteUnionHeader(219); writer.WritePackable(v219); break;
            case hkpConstraintChainInstanceAction v220: writer.WriteUnionHeader(220); writer.WritePackable(v220); break;
            case hkpConstraintChainInstance v221: writer.WriteUnionHeader(221); writer.WritePackable(v221); break;
            case hkpConstraintInstance v222: writer.WriteUnionHeader(222); writer.WritePackable(v222); break;
            case hkpConvexPieceStreamData v223: writer.WriteUnionHeader(223); writer.WritePackable(v223); break;
            case hkpConvexVerticesConnectivity v224: writer.WriteUnionHeader(224); writer.WritePackable(v224); break;
            case hkpDefaultConvexListFilter v225: writer.WriteUnionHeader(225); writer.WritePackable(v225); break;
            case hkpDisableEntityCollisionFilter v226: writer.WriteUnionHeader(226); writer.WritePackable(v226); break;
            case hkpDisplayBindingData v227: writer.WriteUnionHeader(227); writer.WritePackable(v227); break;
            case hkpDisplayBindingDataPhysicsSystem v228: writer.WriteUnionHeader(228); writer.WritePackable(v228); break;
            case hkpDisplayBindingDataRigidBody v229: writer.WriteUnionHeader(229); writer.WritePackable(v229); break;
            case hkpMountedBallGun v230: writer.WriteUnionHeader(230); writer.WritePackable(v230); break;
            case hkpBallGun v231: writer.WriteUnionHeader(231); writer.WritePackable(v231); break;
            case hkpGravityGun v232: writer.WriteUnionHeader(232); writer.WritePackable(v232); break;
            case hkpProjectileGun v233: writer.WriteUnionHeader(233); writer.WritePackable(v233); break;
            case hkpFirstPersonGun v234: writer.WriteUnionHeader(234); writer.WritePackable(v234); break;
            case hkpGenericConstraintData v235: writer.WriteUnionHeader(235); writer.WritePackable(v235); break;
            case hkpGroupCollisionFilter v236: writer.WriteUnionHeader(236); writer.WritePackable(v236); break;
            case hkpGroupFilter v237: writer.WriteUnionHeader(237); writer.WritePackable(v237); break;
            case hkpPlaneShape v238: writer.WriteUnionHeader(238); writer.WritePackable(v238); break;
            case hkpCompressedSampledHeightFieldShape v239: writer.WriteUnionHeader(239); writer.WritePackable(v239); break;
            case hkpStorageSampledHeightFieldShape v240: writer.WriteUnionHeader(240); writer.WritePackable(v240); break;
            case hkpSampledHeightFieldShape v241: writer.WriteUnionHeader(241); writer.WritePackable(v241); break;
            case hkpHeightFieldShape v242: writer.WriteUnionHeader(242); writer.WritePackable(v242); break;
            case hkpHingeConstraintData v243: writer.WriteUnionHeader(243); writer.WritePackable(v243); break;
            case hkpHingeLimitsData v244: writer.WriteUnionHeader(244); writer.WritePackable(v244); break;
            case hkpCallbackConstraintMotor v245: writer.WriteUnionHeader(245); writer.WritePackable(v245); break;
            case hkpPositionConstraintMotor v246: writer.WriteUnionHeader(246); writer.WritePackable(v246); break;
            case hkpSpringDamperConstraintMotor v247: writer.WriteUnionHeader(247); writer.WritePackable(v247); break;
            case hkpVelocityConstraintMotor v248: writer.WriteUnionHeader(248); writer.WritePackable(v248); break;
            case hkpLimitedForceConstraintMotor v249: writer.WriteUnionHeader(249); writer.WritePackable(v249); break;
            case hkpLimitedHingeConstraintData v250: writer.WriteUnionHeader(250); writer.WritePackable(v250); break;
            case hkpMalleableConstraintData v251: writer.WriteUnionHeader(251); writer.WritePackable(v251); break;
            case hkpMoppCode v252: writer.WriteUnionHeader(252); writer.WritePackable(v252); break;
            case hkpThinBoxMotion v253: writer.WriteUnionHeader(253); writer.WritePackable(v253); break;
            case hkpBoxMotion v254: writer.WriteUnionHeader(254); writer.WritePackable(v254); break;
            case hkpCharacterMotion v255: writer.WriteUnionHeader(255); writer.WritePackable(v255); break;
            case hkpFixedRigidMotion v256: writer.WriteUnionHeader(256); writer.WritePackable(v256); break;
            case hkpMaxSizeMotion v257: writer.WriteUnionHeader(257); writer.WritePackable(v257); break;
            case hkpKeyframedRigidMotion v258: writer.WriteUnionHeader(258); writer.WritePackable(v258); break;
            case hkpSphereMotion v259: writer.WriteUnionHeader(259); writer.WritePackable(v259); break;
            case hkpMotion v260: writer.WriteUnionHeader(260); writer.WritePackable(v260); break;
            case hkpMultiRayShape v261: writer.WriteUnionHeader(261); writer.WritePackable(v261); break;
            case hkpNullCollisionFilter v262: writer.WriteUnionHeader(262); writer.WritePackable(v262); break;
            case hkpConstraintCollisionFilter v263: writer.WriteUnionHeader(263); writer.WritePackable(v263); break;
            case hkpPairCollisionFilter v264: writer.WriteUnionHeader(264); writer.WritePackable(v264); break;
            case hkpLinearParametricCurve v265: writer.WriteUnionHeader(265); writer.WritePackable(v265); break;
            case hkpParametricCurve v266: writer.WriteUnionHeader(266); writer.WritePackable(v266); break;
            case hkpPhantomCallbackShape v267: writer.WriteUnionHeader(267); writer.WritePackable(v267); break;
            case hkpPhysicsData v268: writer.WriteUnionHeader(268); writer.WritePackable(v268); break;
            case hkpPhysicsSystemWithContacts v269: writer.WriteUnionHeader(269); writer.WritePackable(v269); break;
            case hkpPhysicsSystem v270: writer.WriteUnionHeader(270); writer.WritePackable(v270); break;
            case hkpPointToPathConstraintData v271: writer.WriteUnionHeader(271); writer.WritePackable(v271); break;
            case hkpPointToPlaneConstraintData v272: writer.WriteUnionHeader(272); writer.WritePackable(v272); break;
            case hkpPoweredChainMapper v273: writer.WriteUnionHeader(273); writer.WritePackable(v273); break;
            case hkpPrismaticConstraintData v274: writer.WriteUnionHeader(274); writer.WritePackable(v274); break;
            case hkpPulleyConstraintData v275: writer.WriteUnionHeader(275); writer.WritePackable(v275); break;
            case hkpRackAndPinionConstraintData v276: writer.WriteUnionHeader(276); writer.WritePackable(v276); break;
            case hkpRagdollConstraintData v277: writer.WriteUnionHeader(277); writer.WritePackable(v277); break;
            case hkpRagdollLimitsData v278: writer.WriteUnionHeader(278); writer.WritePackable(v278); break;
            case hkpRemoveTerminalsMoppModifier v279: writer.WriteUnionHeader(279); writer.WritePackable(v279); break;
            case hkpRotationalConstraintData v280: writer.WriteUnionHeader(280); writer.WritePackable(v280); break;
            case hkpSerializedAgentNnEntry v281: writer.WriteUnionHeader(281); writer.WritePackable(v281); break;
            case hkpSerializedDisplayMarker v282: writer.WriteUnionHeader(282); writer.WritePackable(v282); break;
            case hkpSerializedDisplayMarkerList v283: writer.WriteUnionHeader(283); writer.WritePackable(v283); break;
            case hkpSerializedDisplayRbTransforms v284: writer.WriteUnionHeader(284); writer.WritePackable(v284); break;
            case hkpCompressedMeshShape v285: writer.WriteUnionHeader(285); writer.WritePackable(v285); break;
            case hkpListShape v286: writer.WriteUnionHeader(286); writer.WritePackable(v286); break;
            case hkpFastMeshShape v287: writer.WriteUnionHeader(287); writer.WritePackable(v287); break;
            case hkpStorageMeshShape v288: writer.WriteUnionHeader(288); writer.WritePackable(v288); break;
            case hkpMeshShape v289: writer.WriteUnionHeader(289); writer.WritePackable(v289); break;
            case hkpTriSampledHeightFieldCollection v290: writer.WriteUnionHeader(290); writer.WritePackable(v290); break;
            case hkpShapeCollection v291: writer.WriteUnionHeader(291); writer.WritePackable(v291); break;
            case hkpShapeInfo v292: writer.WriteUnionHeader(292); writer.WritePackable(v292); break;
            case hkpShapeModifier v293: writer.WriteUnionHeader(293); writer.WritePackable(v293); break;
            case hkpSimulation v294: writer.WriteUnionHeader(294); writer.WritePackable(v294); break;
            case hkpBoxShape v295: writer.WriteUnionHeader(295); writer.WritePackable(v295); break;
            case hkpCapsuleShape v296: writer.WriteUnionHeader(296); writer.WritePackable(v296); break;
            case hkpConvexListShape v297: writer.WriteUnionHeader(297); writer.WritePackable(v297); break;
            case hkpConvexTransformShape v298: writer.WriteUnionHeader(298); writer.WritePackable(v298); break;
            case hkpConvexTranslateShape v299: writer.WriteUnionHeader(299); writer.WritePackable(v299); break;
            case hkpConvexTransformShapeBase v300: writer.WriteUnionHeader(300); writer.WritePackable(v300); break;
            case hkpConvexVerticesShape v301: writer.WriteUnionHeader(301); writer.WritePackable(v301); break;
            case hkpCylinderShape v302: writer.WriteUnionHeader(302); writer.WritePackable(v302); break;
            case hkpSphereShape v303: writer.WriteUnionHeader(303); writer.WritePackable(v303); break;
            case hkpTriangleShape v304: writer.WriteUnionHeader(304); writer.WritePackable(v304); break;
            case hkpConvexShape v305: writer.WriteUnionHeader(305); writer.WritePackable(v305); break;
            case hkpMultiSphereShape v306: writer.WriteUnionHeader(306); writer.WritePackable(v306); break;
            case hkpSphereRepShape v307: writer.WriteUnionHeader(307); writer.WritePackable(v307); break;
            case hkpStiffSpringConstraintData v308: writer.WriteUnionHeader(308); writer.WritePackable(v308); break;
            case hkpStorageMeshShapeSubpartStorage v309: writer.WriteUnionHeader(309); writer.WritePackable(v309); break;
            case hkpTransformShape v310: writer.WriteUnionHeader(310); writer.WritePackable(v310); break;
            case hkpTriggerVolume v311: writer.WriteUnionHeader(311); writer.WritePackable(v311); break;
            case hkpMotorAction v312: writer.WriteUnionHeader(312); writer.WritePackable(v312); break;
            case hkpMouseSpringAction v313: writer.WriteUnionHeader(313); writer.WritePackable(v313); break;
            case hkpReorientAction v314: writer.WriteUnionHeader(314); writer.WritePackable(v314); break;
            case hkpUnaryAction v315: writer.WriteUnionHeader(315); writer.WritePackable(v315); break;
            case hkpWheelConstraintData v316: writer.WriteUnionHeader(316); writer.WritePackable(v316); break;
            case hkpWorld v317: writer.WriteUnionHeader(317); writer.WritePackable(v317); break;
            case hkpWorldCinfo v318: writer.WriteUnionHeader(318); writer.WritePackable(v318); break;
            case hkpAabbPhantom v319: writer.WriteUnionHeader(319); writer.WritePackable(v319); break;
            case hkpRigidBody v320: writer.WriteUnionHeader(320); writer.WritePackable(v320); break;
            case hkpCachingShapePhantom v321: writer.WriteUnionHeader(321); writer.WritePackable(v321); break;
            case hkpSimpleShapePhantom v322: writer.WriteUnionHeader(322); writer.WritePackable(v322); break;
            case hkpShapePhantom v323: writer.WriteUnionHeader(323); writer.WritePackable(v323); break;
            case hkpWorldObject v324: writer.WriteUnionHeader(324); writer.WritePackable(v324); break;
            case hkxAnimatedFloat v325: writer.WriteUnionHeader(325); writer.WritePackable(v325); break;
            case hkxAnimatedMatrix v326: writer.WriteUnionHeader(326); writer.WritePackable(v326); break;
            case hkxAnimatedQuaternion v327: writer.WriteUnionHeader(327); writer.WritePackable(v327); break;
            case hkxAnimatedVector v328: writer.WriteUnionHeader(328); writer.WritePackable(v328); break;
            case hkxMaterial v329: writer.WriteUnionHeader(329); writer.WritePackable(v329); break;
            case hkxMeshUserChannelInfo v330: writer.WriteUnionHeader(330); writer.WritePackable(v330); break;
            case hkxNode v331: writer.WriteUnionHeader(331); writer.WritePackable(v331); break;
            case hkxNodeSelectionSet v332: writer.WriteUnionHeader(332); writer.WritePackable(v332); break;
            case hkxAttributeHolder v333: writer.WriteUnionHeader(333); writer.WritePackable(v333); break;
            case hkxCamera v334: writer.WriteUnionHeader(334); writer.WritePackable(v334); break;
            case hkxEdgeSelectionChannel v335: writer.WriteUnionHeader(335); writer.WritePackable(v335); break;
            case hkxEnum v336: writer.WriteUnionHeader(336); writer.WritePackable(v336); break;
            case hkxEnvironment v337: writer.WriteUnionHeader(337); writer.WritePackable(v337); break;
            case hkxIndexBuffer v338: writer.WriteUnionHeader(338); writer.WritePackable(v338); break;
            case hkxLight v339: writer.WriteUnionHeader(339); writer.WritePackable(v339); break;
            case hkxMaterialEffect v340: writer.WriteUnionHeader(340); writer.WritePackable(v340); break;
            case hkxMaterialShader v341: writer.WriteUnionHeader(341); writer.WritePackable(v341); break;
            case hkxMaterialShaderSet v342: writer.WriteUnionHeader(342); writer.WritePackable(v342); break;
            case hkxMesh v343: writer.WriteUnionHeader(343); writer.WritePackable(v343); break;
            case hkxMeshSection v344: writer.WriteUnionHeader(344); writer.WritePackable(v344); break;
            case hkxScene v345: writer.WriteUnionHeader(345); writer.WritePackable(v345); break;
            case hkxSkinBinding v346: writer.WriteUnionHeader(346); writer.WritePackable(v346); break;
            case hkxSparselyAnimatedBool v347: writer.WriteUnionHeader(347); writer.WritePackable(v347); break;
            case hkxSparselyAnimatedEnum v348: writer.WriteUnionHeader(348); writer.WritePackable(v348); break;
            case hkxSparselyAnimatedInt v349: writer.WriteUnionHeader(349); writer.WritePackable(v349); break;
            case hkxSparselyAnimatedString v350: writer.WriteUnionHeader(350); writer.WritePackable(v350); break;
            case hkxTextureFile v351: writer.WriteUnionHeader(351); writer.WritePackable(v351); break;
            case hkxTextureInplace v352: writer.WriteUnionHeader(352); writer.WritePackable(v352); break;
            case hkxTriangleSelectionChannel v353: writer.WriteUnionHeader(353); writer.WritePackable(v353); break;
            case hkxVertexBuffer v354: writer.WriteUnionHeader(354); writer.WritePackable(v354); break;
            case hkxVertexFloatDataChannel v355: writer.WriteUnionHeader(355); writer.WritePackable(v355); break;
            case hkxVertexIntDataChannel v356: writer.WriteUnionHeader(356); writer.WritePackable(v356); break;
            case hkxVertexSelectionChannel v357: writer.WriteUnionHeader(357); writer.WritePackable(v357); break;
            case hkxVertexVectorDataChannel v358: writer.WriteUnionHeader(358); writer.WritePackable(v358); break;
            default: throw new InvalidOperationException($"Unknown type for hkReferencedObject union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkReferencedObject? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkAlignSceneToNodeOptions); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkLocalFrameGroup); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkMemoryResourceContainer); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkResourceContainer); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(hkMemoryResourceHandle); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(hkResourceHandle); reader.ReadPackable(ref v); value = v; break; }
            case 6: { var v = default(hkResourceBase); reader.ReadPackable(ref v); value = v; break; }
            case 7: { var v = default(hkSimpleLocalFrame); reader.ReadPackable(ref v); value = v; break; }
            case 8: { var v = default(hkTrackerSerializableScanSnapshot); reader.ReadPackable(ref v); value = v; break; }
            case 9: { var v = default(hkpDefaultWorldMemoryWatchDog); reader.ReadPackable(ref v); value = v; break; }
            case 10: { var v = default(hkWorldMemoryAvailableWatchDog); reader.ReadPackable(ref v); value = v; break; }
            case 11: { var v = default(hkaAnimationBinding); reader.ReadPackable(ref v); value = v; break; }
            case 12: { var v = default(hkaAnimationContainer); reader.ReadPackable(ref v); value = v; break; }
            case 13: { var v = default(hkaAnimationPreviewColorContainer); reader.ReadPackable(ref v); value = v; break; }
            case 14: { var v = default(hkaBoneAttachment); reader.ReadPackable(ref v); value = v; break; }
            case 15: { var v = default(hkaDefaultAnimatedReferenceFrame); reader.ReadPackable(ref v); value = v; break; }
            case 16: { var v = default(hkaFootstepAnalysisInfo); reader.ReadPackable(ref v); value = v; break; }
            case 17: { var v = default(hkaFootstepAnalysisInfoContainer); reader.ReadPackable(ref v); value = v; break; }
            case 18: { var v = default(hkaInterleavedUncompressedAnimation); reader.ReadPackable(ref v); value = v; break; }
            case 19: { var v = default(hkaMeshBinding); reader.ReadPackable(ref v); value = v; break; }
            case 20: { var v = default(hkaQuantizedAnimation); reader.ReadPackable(ref v); value = v; break; }
            case 21: { var v = default(hkaRagdollInstance); reader.ReadPackable(ref v); value = v; break; }
            case 22: { var v = default(hkaSkeleton); reader.ReadPackable(ref v); value = v; break; }
            case 23: { var v = default(hkaSkeletonMapper); reader.ReadPackable(ref v); value = v; break; }
            case 24: { var v = default(hkaSplineCompressedAnimation); reader.ReadPackable(ref v); value = v; break; }
            case 25: { var v = default(hkbAttachmentSetup); reader.ReadPackable(ref v); value = v; break; }
            case 26: { var v = default(hkbAuxiliaryNodeInfo); reader.ReadPackable(ref v); value = v; break; }
            case 27: { var v = default(hkbBehaviorEventsInfo); reader.ReadPackable(ref v); value = v; break; }
            case 28: { var v = default(hkbBehaviorGraphData); reader.ReadPackable(ref v); value = v; break; }
            case 29: { var v = default(hkbBehaviorGraphInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 30: { var v = default(hkbBehaviorGraphInternalStateInfo); reader.ReadPackable(ref v); value = v; break; }
            case 31: { var v = default(hkbBehaviorGraphStringData); reader.ReadPackable(ref v); value = v; break; }
            case 32: { var v = default(hkbBehaviorInfo); reader.ReadPackable(ref v); value = v; break; }
            case 33: { var v = default(BSBoneSwitchGeneratorBoneData); reader.ReadPackable(ref v); value = v; break; }
            case 34: { var v = default(hkbBlenderGeneratorChild); reader.ReadPackable(ref v); value = v; break; }
            case 35: { var v = default(hkbBoneIndexArray); reader.ReadPackable(ref v); value = v; break; }
            case 36: { var v = default(hkbBoneWeightArray); reader.ReadPackable(ref v); value = v; break; }
            case 37: { var v = default(BGSGamebryoSequenceGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 38: { var v = default(BSBoneSwitchGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 39: { var v = default(BSComputeAddBoneAnimModifier); reader.ReadPackable(ref v); value = v; break; }
            case 40: { var v = default(BSCyclicBlendTransitionGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 41: { var v = default(BSDecomposeVectorModifier); reader.ReadPackable(ref v); value = v; break; }
            case 42: { var v = default(BSDirectAtModifier); reader.ReadPackable(ref v); value = v; break; }
            case 43: { var v = default(BSDistTriggerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 44: { var v = default(BSEventEveryNEventsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 45: { var v = default(BSEventOnDeactivateModifier); reader.ReadPackable(ref v); value = v; break; }
            case 46: { var v = default(BSEventOnFalseToTrueModifier); reader.ReadPackable(ref v); value = v; break; }
            case 47: { var v = default(BSGetTimeStepModifier); reader.ReadPackable(ref v); value = v; break; }
            case 48: { var v = default(BSIStateManagerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 49: { var v = default(BSInterpValueModifier); reader.ReadPackable(ref v); value = v; break; }
            case 50: { var v = default(BSIsActiveModifier); reader.ReadPackable(ref v); value = v; break; }
            case 51: { var v = default(BSLimbIKModifier); reader.ReadPackable(ref v); value = v; break; }
            case 52: { var v = default(BSLookAtModifier); reader.ReadPackable(ref v); value = v; break; }
            case 53: { var v = default(BSModifyOnceModifier); reader.ReadPackable(ref v); value = v; break; }
            case 54: { var v = default(BSOffsetAnimationGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 55: { var v = default(BSPassByTargetTriggerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 56: { var v = default(BSRagdollContactListenerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 57: { var v = default(BSSpeedSamplerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 58: { var v = default(BSSynchronizedClipGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 59: { var v = default(BSTimerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 60: { var v = default(BSTweenerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 61: { var v = default(BSiStateTaggingGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 62: { var v = default(hkbAttachmentModifier); reader.ReadPackable(ref v); value = v; break; }
            case 63: { var v = default(hkbAttributeModifier); reader.ReadPackable(ref v); value = v; break; }
            case 64: { var v = default(hkbBehaviorGraph); reader.ReadPackable(ref v); value = v; break; }
            case 65: { var v = default(hkbBehaviorReferenceGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 66: { var v = default(hkbPoseMatchingGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 67: { var v = default(hkbBlenderGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 68: { var v = default(hkbBlendingTransitionEffect); reader.ReadPackable(ref v); value = v; break; }
            case 69: { var v = default(hkbCharacterControllerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 70: { var v = default(hkbClipGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 71: { var v = default(hkbCombineTransformsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 72: { var v = default(hkbComputeDirectionModifier); reader.ReadPackable(ref v); value = v; break; }
            case 73: { var v = default(hkbComputeRotationFromAxisAngleModifier); reader.ReadPackable(ref v); value = v; break; }
            case 74: { var v = default(hkbComputeRotationToTargetModifier); reader.ReadPackable(ref v); value = v; break; }
            case 75: { var v = default(hkbDampingModifier); reader.ReadPackable(ref v); value = v; break; }
            case 76: { var v = default(hkbDetectCloseToGroundModifier); reader.ReadPackable(ref v); value = v; break; }
            case 77: { var v = default(hkbEvaluateExpressionModifier); reader.ReadPackable(ref v); value = v; break; }
            case 78: { var v = default(hkbEvaluateHandleModifier); reader.ReadPackable(ref v); value = v; break; }
            case 79: { var v = default(hkbEventsFromRangeModifier); reader.ReadPackable(ref v); value = v; break; }
            case 80: { var v = default(hkbExtractRagdollPoseModifier); reader.ReadPackable(ref v); value = v; break; }
            case 81: { var v = default(hkbFootIkControlsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 82: { var v = default(hkbFootIkModifier); reader.ReadPackable(ref v); value = v; break; }
            case 83: { var v = default(hkbGeneratorTransitionEffect); reader.ReadPackable(ref v); value = v; break; }
            case 84: { var v = default(hkbGetHandleOnBoneModifier); reader.ReadPackable(ref v); value = v; break; }
            case 85: { var v = default(hkbGetUpModifier); reader.ReadPackable(ref v); value = v; break; }
            case 86: { var v = default(hkbGetWorldFromModelModifier); reader.ReadPackable(ref v); value = v; break; }
            case 87: { var v = default(hkbHandIkControlsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 88: { var v = default(hkbHandIkModifier); reader.ReadPackable(ref v); value = v; break; }
            case 89: { var v = default(hkbKeyframeBonesModifier); reader.ReadPackable(ref v); value = v; break; }
            case 90: { var v = default(hkbLookAtModifier); reader.ReadPackable(ref v); value = v; break; }
            case 91: { var v = default(hkbManualSelectorGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 92: { var v = default(hkbMirrorModifier); reader.ReadPackable(ref v); value = v; break; }
            case 93: { var v = default(hkbModifierGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 94: { var v = default(hkbModifierList); reader.ReadPackable(ref v); value = v; break; }
            case 95: { var v = default(hkbDelayedModifier); reader.ReadPackable(ref v); value = v; break; }
            case 96: { var v = default(hkbEventDrivenModifier); reader.ReadPackable(ref v); value = v; break; }
            case 97: { var v = default(hkbModifierWrapper); reader.ReadPackable(ref v); value = v; break; }
            case 98: { var v = default(hkbMoveCharacterModifier); reader.ReadPackable(ref v); value = v; break; }
            case 99: { var v = default(hkbPoweredRagdollControlsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 100: { var v = default(hkbProxyModifier); reader.ReadPackable(ref v); value = v; break; }
            case 101: { var v = default(hkbReferencePoseGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 102: { var v = default(hkbRigidBodyRagdollControlsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 103: { var v = default(hkbRotateCharacterModifier); reader.ReadPackable(ref v); value = v; break; }
            case 104: { var v = default(hkbSenseHandleModifier); reader.ReadPackable(ref v); value = v; break; }
            case 105: { var v = default(hkbSequence); reader.ReadPackable(ref v); value = v; break; }
            case 106: { var v = default(hkbSetWorldFromModelModifier); reader.ReadPackable(ref v); value = v; break; }
            case 107: { var v = default(hkbStateMachine); reader.ReadPackable(ref v); value = v; break; }
            case 108: { var v = default(hkbTimerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 109: { var v = default(hkbTransformVectorModifier); reader.ReadPackable(ref v); value = v; break; }
            case 110: { var v = default(hkbTwistModifier); reader.ReadPackable(ref v); value = v; break; }
            case 111: { var v = default(hkbNode); reader.ReadPackable(ref v); value = v; break; }
            case 112: { var v = default(hkbRegisteredGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 113: { var v = default(hkbStateMachineStateInfo); reader.ReadPackable(ref v); value = v; break; }
            case 114: { var v = default(hkbBindable); reader.ReadPackable(ref v); value = v; break; }
            case 115: { var v = default(hkbBlenderGeneratorInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 116: { var v = default(hkbBlendingTransitionEffectInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 117: { var v = default(hkbCameraShakeEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 118: { var v = default(hkbCharacter); reader.ReadPackable(ref v); value = v; break; }
            case 119: { var v = default(hkbCharacterAddedInfo); reader.ReadPackable(ref v); value = v; break; }
            case 120: { var v = default(hkbCharacterControlCommand); reader.ReadPackable(ref v); value = v; break; }
            case 121: { var v = default(hkbCharacterControllerModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 122: { var v = default(hkbCharacterData); reader.ReadPackable(ref v); value = v; break; }
            case 123: { var v = default(hkbCharacterInfo); reader.ReadPackable(ref v); value = v; break; }
            case 124: { var v = default(hkbCharacterSetup); reader.ReadPackable(ref v); value = v; break; }
            case 125: { var v = default(hkbCharacterSkinInfo); reader.ReadPackable(ref v); value = v; break; }
            case 126: { var v = default(hkbCharacterSteppedInfo); reader.ReadPackable(ref v); value = v; break; }
            case 127: { var v = default(hkbCharacterStringData); reader.ReadPackable(ref v); value = v; break; }
            case 128: { var v = default(hkbClientCharacterState); reader.ReadPackable(ref v); value = v; break; }
            case 129: { var v = default(hkbClipGeneratorInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 130: { var v = default(hkbClipTriggerArray); reader.ReadPackable(ref v); value = v; break; }
            case 131: { var v = default(hkbCombineTransformsModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 132: { var v = default(hkbCompiledExpressionSet); reader.ReadPackable(ref v); value = v; break; }
            case 133: { var v = default(hkbComputeDirectionModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 134: { var v = default(hkbComputeRotationFromAxisAngleModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 135: { var v = default(hkbComputeRotationToTargetModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 136: { var v = default(hkbDampingModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 137: { var v = default(hkbDelayedModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 138: { var v = default(hkbDetectCloseToGroundModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 139: { var v = default(hkbEvaluateExpressionModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 140: { var v = default(hkbEventDrivenModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 141: { var v = default(hkbEventPayloadList); reader.ReadPackable(ref v); value = v; break; }
            case 142: { var v = default(hkbEventRaisedInfo); reader.ReadPackable(ref v); value = v; break; }
            case 143: { var v = default(hkbEventRangeDataArray); reader.ReadPackable(ref v); value = v; break; }
            case 144: { var v = default(hkbEventsFromRangeModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 145: { var v = default(hkbExpressionCondition); reader.ReadPackable(ref v); value = v; break; }
            case 146: { var v = default(hkbExpressionDataArray); reader.ReadPackable(ref v); value = v; break; }
            case 147: { var v = default(hkbFootIkDriverInfo); reader.ReadPackable(ref v); value = v; break; }
            case 148: { var v = default(hkbGeneratorOutputListener); reader.ReadPackable(ref v); value = v; break; }
            case 149: { var v = default(hkbGeneratorTransitionEffectInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 150: { var v = default(hkbGetUpModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 151: { var v = default(hkbGetWorldFromModelModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 152: { var v = default(hkbHandIkDriverInfo); reader.ReadPackable(ref v); value = v; break; }
            case 153: { var v = default(hkbHandle); reader.ReadPackable(ref v); value = v; break; }
            case 154: { var v = default(hkbIntEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 155: { var v = default(hkbLinkedSymbolInfo); reader.ReadPackable(ref v); value = v; break; }
            case 156: { var v = default(hkbLookAtModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 157: { var v = default(hkbManualSelectorGeneratorInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 158: { var v = default(hkbMirroredSkeletonInfo); reader.ReadPackable(ref v); value = v; break; }
            case 159: { var v = default(hkbMoveCharacterModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 160: { var v = default(hkbNamedIntEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 161: { var v = default(hkbNamedRealEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 162: { var v = default(hkbNamedStringEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 163: { var v = default(hkbNamedEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 164: { var v = default(hkbNodeInternalStateInfo); reader.ReadPackable(ref v); value = v; break; }
            case 165: { var v = default(hkbParticleSystemEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 166: { var v = default(hkbPoseMatchingGeneratorInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 167: { var v = default(hkbProjectData); reader.ReadPackable(ref v); value = v; break; }
            case 168: { var v = default(hkbProjectStringData); reader.ReadPackable(ref v); value = v; break; }
            case 169: { var v = default(hkbRaiseEventCommand); reader.ReadPackable(ref v); value = v; break; }
            case 170: { var v = default(hkbRealEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 171: { var v = default(hkbRotateCharacterModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 172: { var v = default(hkbSequenceInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 173: { var v = default(hkbSequenceStringData); reader.ReadPackable(ref v); value = v; break; }
            case 174: { var v = default(hkbBoolVariableSequencedData); reader.ReadPackable(ref v); value = v; break; }
            case 175: { var v = default(hkbEventSequencedData); reader.ReadPackable(ref v); value = v; break; }
            case 176: { var v = default(hkbIntVariableSequencedData); reader.ReadPackable(ref v); value = v; break; }
            case 177: { var v = default(hkbRealVariableSequencedData); reader.ReadPackable(ref v); value = v; break; }
            case 178: { var v = default(hkbSequencedData); reader.ReadPackable(ref v); value = v; break; }
            case 179: { var v = default(hkbSetBehaviorCommand); reader.ReadPackable(ref v); value = v; break; }
            case 180: { var v = default(hkbSetLocalTimeOfClipGeneratorCommand); reader.ReadPackable(ref v); value = v; break; }
            case 181: { var v = default(hkbSetNodePropertyCommand); reader.ReadPackable(ref v); value = v; break; }
            case 182: { var v = default(hkbSetWordVariableCommand); reader.ReadPackable(ref v); value = v; break; }
            case 183: { var v = default(hkbSimulationControlCommand); reader.ReadPackable(ref v); value = v; break; }
            case 184: { var v = default(hkbSimulationStateInfo); reader.ReadPackable(ref v); value = v; break; }
            case 185: { var v = default(BSIStateManagerModifierBSIStateManagerStateListener); reader.ReadPackable(ref v); value = v; break; }
            case 186: { var v = default(hkbStateListener); reader.ReadPackable(ref v); value = v; break; }
            case 187: { var v = default(hkbStateMachineEventPropertyArray); reader.ReadPackable(ref v); value = v; break; }
            case 188: { var v = default(hkbStateMachineInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 189: { var v = default(hkbStateMachineTransitionInfoArray); reader.ReadPackable(ref v); value = v; break; }
            case 190: { var v = default(hkbStringCondition); reader.ReadPackable(ref v); value = v; break; }
            case 191: { var v = default(hkbStringEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 192: { var v = default(hkbTestStateChooser); reader.ReadPackable(ref v); value = v; break; }
            case 193: { var v = default(hkbTimerModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 194: { var v = default(hkbTransformVectorModifierInternalState); reader.ReadPackable(ref v); value = v; break; }
            case 195: { var v = default(hkbVariableBindingSet); reader.ReadPackable(ref v); value = v; break; }
            case 196: { var v = default(hkbVariableValueSet); reader.ReadPackable(ref v); value = v; break; }
            case 197: { var v = default(hkpArrayAction); reader.ReadPackable(ref v); value = v; break; }
            case 198: { var v = default(hkpBallAndSocketConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 199: { var v = default(hkpAngularDashpotAction); reader.ReadPackable(ref v); value = v; break; }
            case 200: { var v = default(hkpDashpotAction); reader.ReadPackable(ref v); value = v; break; }
            case 201: { var v = default(hkpSpringAction); reader.ReadPackable(ref v); value = v; break; }
            case 202: { var v = default(hkpBinaryAction); reader.ReadPackable(ref v); value = v; break; }
            case 203: { var v = default(hkpBreakableBody); reader.ReadPackable(ref v); value = v; break; }
            case 204: { var v = default(hkpBreakableConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 205: { var v = default(hkpBvShape); reader.ReadPackable(ref v); value = v; break; }
            case 206: { var v = default(hkpMoppBvTreeShape); reader.ReadPackable(ref v); value = v; break; }
            case 207: { var v = default(hkMoppBvTreeShapeBase); reader.ReadPackable(ref v); value = v; break; }
            case 208: { var v = default(hkpTriSampledHeightFieldBvTreeShape); reader.ReadPackable(ref v); value = v; break; }
            case 209: { var v = default(hkpBvTreeShape); reader.ReadPackable(ref v); value = v; break; }
            case 210: { var v = default(hkpCharacterProxyCinfo); reader.ReadPackable(ref v); value = v; break; }
            case 211: { var v = default(hkpCharacterRigidBodyCinfo); reader.ReadPackable(ref v); value = v; break; }
            case 212: { var v = default(hkpCharacterControllerCinfo); reader.ReadPackable(ref v); value = v; break; }
            case 213: { var v = default(hkpCogWheelConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 214: { var v = default(hkpCollisionFilterList); reader.ReadPackable(ref v); value = v; break; }
            case 215: { var v = default(hkpConstrainedSystemFilter); reader.ReadPackable(ref v); value = v; break; }
            case 216: { var v = default(hkpBallSocketChainData); reader.ReadPackable(ref v); value = v; break; }
            case 217: { var v = default(hkpPoweredChainData); reader.ReadPackable(ref v); value = v; break; }
            case 218: { var v = default(hkpStiffSpringChainData); reader.ReadPackable(ref v); value = v; break; }
            case 219: { var v = default(hkpConstraintChainData); reader.ReadPackable(ref v); value = v; break; }
            case 220: { var v = default(hkpConstraintChainInstanceAction); reader.ReadPackable(ref v); value = v; break; }
            case 221: { var v = default(hkpConstraintChainInstance); reader.ReadPackable(ref v); value = v; break; }
            case 222: { var v = default(hkpConstraintInstance); reader.ReadPackable(ref v); value = v; break; }
            case 223: { var v = default(hkpConvexPieceStreamData); reader.ReadPackable(ref v); value = v; break; }
            case 224: { var v = default(hkpConvexVerticesConnectivity); reader.ReadPackable(ref v); value = v; break; }
            case 225: { var v = default(hkpDefaultConvexListFilter); reader.ReadPackable(ref v); value = v; break; }
            case 226: { var v = default(hkpDisableEntityCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            case 227: { var v = default(hkpDisplayBindingData); reader.ReadPackable(ref v); value = v; break; }
            case 228: { var v = default(hkpDisplayBindingDataPhysicsSystem); reader.ReadPackable(ref v); value = v; break; }
            case 229: { var v = default(hkpDisplayBindingDataRigidBody); reader.ReadPackable(ref v); value = v; break; }
            case 230: { var v = default(hkpMountedBallGun); reader.ReadPackable(ref v); value = v; break; }
            case 231: { var v = default(hkpBallGun); reader.ReadPackable(ref v); value = v; break; }
            case 232: { var v = default(hkpGravityGun); reader.ReadPackable(ref v); value = v; break; }
            case 233: { var v = default(hkpProjectileGun); reader.ReadPackable(ref v); value = v; break; }
            case 234: { var v = default(hkpFirstPersonGun); reader.ReadPackable(ref v); value = v; break; }
            case 235: { var v = default(hkpGenericConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 236: { var v = default(hkpGroupCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            case 237: { var v = default(hkpGroupFilter); reader.ReadPackable(ref v); value = v; break; }
            case 238: { var v = default(hkpPlaneShape); reader.ReadPackable(ref v); value = v; break; }
            case 239: { var v = default(hkpCompressedSampledHeightFieldShape); reader.ReadPackable(ref v); value = v; break; }
            case 240: { var v = default(hkpStorageSampledHeightFieldShape); reader.ReadPackable(ref v); value = v; break; }
            case 241: { var v = default(hkpSampledHeightFieldShape); reader.ReadPackable(ref v); value = v; break; }
            case 242: { var v = default(hkpHeightFieldShape); reader.ReadPackable(ref v); value = v; break; }
            case 243: { var v = default(hkpHingeConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 244: { var v = default(hkpHingeLimitsData); reader.ReadPackable(ref v); value = v; break; }
            case 245: { var v = default(hkpCallbackConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 246: { var v = default(hkpPositionConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 247: { var v = default(hkpSpringDamperConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 248: { var v = default(hkpVelocityConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 249: { var v = default(hkpLimitedForceConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 250: { var v = default(hkpLimitedHingeConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 251: { var v = default(hkpMalleableConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 252: { var v = default(hkpMoppCode); reader.ReadPackable(ref v); value = v; break; }
            case 253: { var v = default(hkpThinBoxMotion); reader.ReadPackable(ref v); value = v; break; }
            case 254: { var v = default(hkpBoxMotion); reader.ReadPackable(ref v); value = v; break; }
            case 255: { var v = default(hkpCharacterMotion); reader.ReadPackable(ref v); value = v; break; }
            case 256: { var v = default(hkpFixedRigidMotion); reader.ReadPackable(ref v); value = v; break; }
            case 257: { var v = default(hkpMaxSizeMotion); reader.ReadPackable(ref v); value = v; break; }
            case 258: { var v = default(hkpKeyframedRigidMotion); reader.ReadPackable(ref v); value = v; break; }
            case 259: { var v = default(hkpSphereMotion); reader.ReadPackable(ref v); value = v; break; }
            case 260: { var v = default(hkpMotion); reader.ReadPackable(ref v); value = v; break; }
            case 261: { var v = default(hkpMultiRayShape); reader.ReadPackable(ref v); value = v; break; }
            case 262: { var v = default(hkpNullCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            case 263: { var v = default(hkpConstraintCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            case 264: { var v = default(hkpPairCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            case 265: { var v = default(hkpLinearParametricCurve); reader.ReadPackable(ref v); value = v; break; }
            case 266: { var v = default(hkpParametricCurve); reader.ReadPackable(ref v); value = v; break; }
            case 267: { var v = default(hkpPhantomCallbackShape); reader.ReadPackable(ref v); value = v; break; }
            case 268: { var v = default(hkpPhysicsData); reader.ReadPackable(ref v); value = v; break; }
            case 269: { var v = default(hkpPhysicsSystemWithContacts); reader.ReadPackable(ref v); value = v; break; }
            case 270: { var v = default(hkpPhysicsSystem); reader.ReadPackable(ref v); value = v; break; }
            case 271: { var v = default(hkpPointToPathConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 272: { var v = default(hkpPointToPlaneConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 273: { var v = default(hkpPoweredChainMapper); reader.ReadPackable(ref v); value = v; break; }
            case 274: { var v = default(hkpPrismaticConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 275: { var v = default(hkpPulleyConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 276: { var v = default(hkpRackAndPinionConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 277: { var v = default(hkpRagdollConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 278: { var v = default(hkpRagdollLimitsData); reader.ReadPackable(ref v); value = v; break; }
            case 279: { var v = default(hkpRemoveTerminalsMoppModifier); reader.ReadPackable(ref v); value = v; break; }
            case 280: { var v = default(hkpRotationalConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 281: { var v = default(hkpSerializedAgentNnEntry); reader.ReadPackable(ref v); value = v; break; }
            case 282: { var v = default(hkpSerializedDisplayMarker); reader.ReadPackable(ref v); value = v; break; }
            case 283: { var v = default(hkpSerializedDisplayMarkerList); reader.ReadPackable(ref v); value = v; break; }
            case 284: { var v = default(hkpSerializedDisplayRbTransforms); reader.ReadPackable(ref v); value = v; break; }
            case 285: { var v = default(hkpCompressedMeshShape); reader.ReadPackable(ref v); value = v; break; }
            case 286: { var v = default(hkpListShape); reader.ReadPackable(ref v); value = v; break; }
            case 287: { var v = default(hkpFastMeshShape); reader.ReadPackable(ref v); value = v; break; }
            case 288: { var v = default(hkpStorageMeshShape); reader.ReadPackable(ref v); value = v; break; }
            case 289: { var v = default(hkpMeshShape); reader.ReadPackable(ref v); value = v; break; }
            case 290: { var v = default(hkpTriSampledHeightFieldCollection); reader.ReadPackable(ref v); value = v; break; }
            case 291: { var v = default(hkpShapeCollection); reader.ReadPackable(ref v); value = v; break; }
            case 292: { var v = default(hkpShapeInfo); reader.ReadPackable(ref v); value = v; break; }
            case 293: { var v = default(hkpShapeModifier); reader.ReadPackable(ref v); value = v; break; }
            case 294: { var v = default(hkpSimulation); reader.ReadPackable(ref v); value = v; break; }
            case 295: { var v = default(hkpBoxShape); reader.ReadPackable(ref v); value = v; break; }
            case 296: { var v = default(hkpCapsuleShape); reader.ReadPackable(ref v); value = v; break; }
            case 297: { var v = default(hkpConvexListShape); reader.ReadPackable(ref v); value = v; break; }
            case 298: { var v = default(hkpConvexTransformShape); reader.ReadPackable(ref v); value = v; break; }
            case 299: { var v = default(hkpConvexTranslateShape); reader.ReadPackable(ref v); value = v; break; }
            case 300: { var v = default(hkpConvexTransformShapeBase); reader.ReadPackable(ref v); value = v; break; }
            case 301: { var v = default(hkpConvexVerticesShape); reader.ReadPackable(ref v); value = v; break; }
            case 302: { var v = default(hkpCylinderShape); reader.ReadPackable(ref v); value = v; break; }
            case 303: { var v = default(hkpSphereShape); reader.ReadPackable(ref v); value = v; break; }
            case 304: { var v = default(hkpTriangleShape); reader.ReadPackable(ref v); value = v; break; }
            case 305: { var v = default(hkpConvexShape); reader.ReadPackable(ref v); value = v; break; }
            case 306: { var v = default(hkpMultiSphereShape); reader.ReadPackable(ref v); value = v; break; }
            case 307: { var v = default(hkpSphereRepShape); reader.ReadPackable(ref v); value = v; break; }
            case 308: { var v = default(hkpStiffSpringConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 309: { var v = default(hkpStorageMeshShapeSubpartStorage); reader.ReadPackable(ref v); value = v; break; }
            case 310: { var v = default(hkpTransformShape); reader.ReadPackable(ref v); value = v; break; }
            case 311: { var v = default(hkpTriggerVolume); reader.ReadPackable(ref v); value = v; break; }
            case 312: { var v = default(hkpMotorAction); reader.ReadPackable(ref v); value = v; break; }
            case 313: { var v = default(hkpMouseSpringAction); reader.ReadPackable(ref v); value = v; break; }
            case 314: { var v = default(hkpReorientAction); reader.ReadPackable(ref v); value = v; break; }
            case 315: { var v = default(hkpUnaryAction); reader.ReadPackable(ref v); value = v; break; }
            case 316: { var v = default(hkpWheelConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 317: { var v = default(hkpWorld); reader.ReadPackable(ref v); value = v; break; }
            case 318: { var v = default(hkpWorldCinfo); reader.ReadPackable(ref v); value = v; break; }
            case 319: { var v = default(hkpAabbPhantom); reader.ReadPackable(ref v); value = v; break; }
            case 320: { var v = default(hkpRigidBody); reader.ReadPackable(ref v); value = v; break; }
            case 321: { var v = default(hkpCachingShapePhantom); reader.ReadPackable(ref v); value = v; break; }
            case 322: { var v = default(hkpSimpleShapePhantom); reader.ReadPackable(ref v); value = v; break; }
            case 323: { var v = default(hkpShapePhantom); reader.ReadPackable(ref v); value = v; break; }
            case 324: { var v = default(hkpWorldObject); reader.ReadPackable(ref v); value = v; break; }
            case 325: { var v = default(hkxAnimatedFloat); reader.ReadPackable(ref v); value = v; break; }
            case 326: { var v = default(hkxAnimatedMatrix); reader.ReadPackable(ref v); value = v; break; }
            case 327: { var v = default(hkxAnimatedQuaternion); reader.ReadPackable(ref v); value = v; break; }
            case 328: { var v = default(hkxAnimatedVector); reader.ReadPackable(ref v); value = v; break; }
            case 329: { var v = default(hkxMaterial); reader.ReadPackable(ref v); value = v; break; }
            case 330: { var v = default(hkxMeshUserChannelInfo); reader.ReadPackable(ref v); value = v; break; }
            case 331: { var v = default(hkxNode); reader.ReadPackable(ref v); value = v; break; }
            case 332: { var v = default(hkxNodeSelectionSet); reader.ReadPackable(ref v); value = v; break; }
            case 333: { var v = default(hkxAttributeHolder); reader.ReadPackable(ref v); value = v; break; }
            case 334: { var v = default(hkxCamera); reader.ReadPackable(ref v); value = v; break; }
            case 335: { var v = default(hkxEdgeSelectionChannel); reader.ReadPackable(ref v); value = v; break; }
            case 336: { var v = default(hkxEnum); reader.ReadPackable(ref v); value = v; break; }
            case 337: { var v = default(hkxEnvironment); reader.ReadPackable(ref v); value = v; break; }
            case 338: { var v = default(hkxIndexBuffer); reader.ReadPackable(ref v); value = v; break; }
            case 339: { var v = default(hkxLight); reader.ReadPackable(ref v); value = v; break; }
            case 340: { var v = default(hkxMaterialEffect); reader.ReadPackable(ref v); value = v; break; }
            case 341: { var v = default(hkxMaterialShader); reader.ReadPackable(ref v); value = v; break; }
            case 342: { var v = default(hkxMaterialShaderSet); reader.ReadPackable(ref v); value = v; break; }
            case 343: { var v = default(hkxMesh); reader.ReadPackable(ref v); value = v; break; }
            case 344: { var v = default(hkxMeshSection); reader.ReadPackable(ref v); value = v; break; }
            case 345: { var v = default(hkxScene); reader.ReadPackable(ref v); value = v; break; }
            case 346: { var v = default(hkxSkinBinding); reader.ReadPackable(ref v); value = v; break; }
            case 347: { var v = default(hkxSparselyAnimatedBool); reader.ReadPackable(ref v); value = v; break; }
            case 348: { var v = default(hkxSparselyAnimatedEnum); reader.ReadPackable(ref v); value = v; break; }
            case 349: { var v = default(hkxSparselyAnimatedInt); reader.ReadPackable(ref v); value = v; break; }
            case 350: { var v = default(hkxSparselyAnimatedString); reader.ReadPackable(ref v); value = v; break; }
            case 351: { var v = default(hkxTextureFile); reader.ReadPackable(ref v); value = v; break; }
            case 352: { var v = default(hkxTextureInplace); reader.ReadPackable(ref v); value = v; break; }
            case 353: { var v = default(hkxTriangleSelectionChannel); reader.ReadPackable(ref v); value = v; break; }
            case 354: { var v = default(hkxVertexBuffer); reader.ReadPackable(ref v); value = v; break; }
            case 355: { var v = default(hkxVertexFloatDataChannel); reader.ReadPackable(ref v); value = v; break; }
            case 356: { var v = default(hkxVertexIntDataChannel); reader.ReadPackable(ref v); value = v; break; }
            case 357: { var v = default(hkxVertexSelectionChannel); reader.ReadPackable(ref v); value = v; break; }
            case 358: { var v = default(hkxVertexVectorDataChannel); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkReferencedObject union");
        }
    }
}
