// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkbModifierUnionFormatter : MemoryPackFormatter<hkbModifier>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkbModifier? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkbDelayedModifier v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkbEventDrivenModifier v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case BSComputeAddBoneAnimModifier v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case BSDecomposeVectorModifier v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case BSDirectAtModifier v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case BSDistTriggerModifier v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            case BSEventEveryNEventsModifier v6: writer.WriteUnionHeader(6); writer.WritePackable(v6); break;
            case BSEventOnDeactivateModifier v7: writer.WriteUnionHeader(7); writer.WritePackable(v7); break;
            case BSEventOnFalseToTrueModifier v8: writer.WriteUnionHeader(8); writer.WritePackable(v8); break;
            case BSGetTimeStepModifier v9: writer.WriteUnionHeader(9); writer.WritePackable(v9); break;
            case BSIStateManagerModifier v10: writer.WriteUnionHeader(10); writer.WritePackable(v10); break;
            case BSInterpValueModifier v11: writer.WriteUnionHeader(11); writer.WritePackable(v11); break;
            case BSIsActiveModifier v12: writer.WriteUnionHeader(12); writer.WritePackable(v12); break;
            case BSLimbIKModifier v13: writer.WriteUnionHeader(13); writer.WritePackable(v13); break;
            case BSLookAtModifier v14: writer.WriteUnionHeader(14); writer.WritePackable(v14); break;
            case BSModifyOnceModifier v15: writer.WriteUnionHeader(15); writer.WritePackable(v15); break;
            case BSPassByTargetTriggerModifier v16: writer.WriteUnionHeader(16); writer.WritePackable(v16); break;
            case BSRagdollContactListenerModifier v17: writer.WriteUnionHeader(17); writer.WritePackable(v17); break;
            case BSSpeedSamplerModifier v18: writer.WriteUnionHeader(18); writer.WritePackable(v18); break;
            case BSTimerModifier v19: writer.WriteUnionHeader(19); writer.WritePackable(v19); break;
            case BSTweenerModifier v20: writer.WriteUnionHeader(20); writer.WritePackable(v20); break;
            case hkbAttachmentModifier v21: writer.WriteUnionHeader(21); writer.WritePackable(v21); break;
            case hkbAttributeModifier v22: writer.WriteUnionHeader(22); writer.WritePackable(v22); break;
            case hkbCharacterControllerModifier v23: writer.WriteUnionHeader(23); writer.WritePackable(v23); break;
            case hkbCombineTransformsModifier v24: writer.WriteUnionHeader(24); writer.WritePackable(v24); break;
            case hkbComputeDirectionModifier v25: writer.WriteUnionHeader(25); writer.WritePackable(v25); break;
            case hkbComputeRotationFromAxisAngleModifier v26: writer.WriteUnionHeader(26); writer.WritePackable(v26); break;
            case hkbComputeRotationToTargetModifier v27: writer.WriteUnionHeader(27); writer.WritePackable(v27); break;
            case hkbDampingModifier v28: writer.WriteUnionHeader(28); writer.WritePackable(v28); break;
            case hkbDetectCloseToGroundModifier v29: writer.WriteUnionHeader(29); writer.WritePackable(v29); break;
            case hkbEvaluateExpressionModifier v30: writer.WriteUnionHeader(30); writer.WritePackable(v30); break;
            case hkbEvaluateHandleModifier v31: writer.WriteUnionHeader(31); writer.WritePackable(v31); break;
            case hkbEventsFromRangeModifier v32: writer.WriteUnionHeader(32); writer.WritePackable(v32); break;
            case hkbExtractRagdollPoseModifier v33: writer.WriteUnionHeader(33); writer.WritePackable(v33); break;
            case hkbFootIkControlsModifier v34: writer.WriteUnionHeader(34); writer.WritePackable(v34); break;
            case hkbFootIkModifier v35: writer.WriteUnionHeader(35); writer.WritePackable(v35); break;
            case hkbGetHandleOnBoneModifier v36: writer.WriteUnionHeader(36); writer.WritePackable(v36); break;
            case hkbGetUpModifier v37: writer.WriteUnionHeader(37); writer.WritePackable(v37); break;
            case hkbGetWorldFromModelModifier v38: writer.WriteUnionHeader(38); writer.WritePackable(v38); break;
            case hkbHandIkControlsModifier v39: writer.WriteUnionHeader(39); writer.WritePackable(v39); break;
            case hkbHandIkModifier v40: writer.WriteUnionHeader(40); writer.WritePackable(v40); break;
            case hkbKeyframeBonesModifier v41: writer.WriteUnionHeader(41); writer.WritePackable(v41); break;
            case hkbLookAtModifier v42: writer.WriteUnionHeader(42); writer.WritePackable(v42); break;
            case hkbMirrorModifier v43: writer.WriteUnionHeader(43); writer.WritePackable(v43); break;
            case hkbModifierList v44: writer.WriteUnionHeader(44); writer.WritePackable(v44); break;
            case hkbModifierWrapper v45: writer.WriteUnionHeader(45); writer.WritePackable(v45); break;
            case hkbMoveCharacterModifier v46: writer.WriteUnionHeader(46); writer.WritePackable(v46); break;
            case hkbPoweredRagdollControlsModifier v47: writer.WriteUnionHeader(47); writer.WritePackable(v47); break;
            case hkbProxyModifier v48: writer.WriteUnionHeader(48); writer.WritePackable(v48); break;
            case hkbRigidBodyRagdollControlsModifier v49: writer.WriteUnionHeader(49); writer.WritePackable(v49); break;
            case hkbRotateCharacterModifier v50: writer.WriteUnionHeader(50); writer.WritePackable(v50); break;
            case hkbSenseHandleModifier v51: writer.WriteUnionHeader(51); writer.WritePackable(v51); break;
            case hkbSequence v52: writer.WriteUnionHeader(52); writer.WritePackable(v52); break;
            case hkbSetWorldFromModelModifier v53: writer.WriteUnionHeader(53); writer.WritePackable(v53); break;
            case hkbTimerModifier v54: writer.WriteUnionHeader(54); writer.WritePackable(v54); break;
            case hkbTransformVectorModifier v55: writer.WriteUnionHeader(55); writer.WritePackable(v55); break;
            case hkbTwistModifier v56: writer.WriteUnionHeader(56); writer.WritePackable(v56); break;
            default: throw new InvalidOperationException($"Unknown type for hkbModifier union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkbModifier? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkbDelayedModifier); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkbEventDrivenModifier); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(BSComputeAddBoneAnimModifier); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(BSDecomposeVectorModifier); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(BSDirectAtModifier); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(BSDistTriggerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 6: { var v = default(BSEventEveryNEventsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 7: { var v = default(BSEventOnDeactivateModifier); reader.ReadPackable(ref v); value = v; break; }
            case 8: { var v = default(BSEventOnFalseToTrueModifier); reader.ReadPackable(ref v); value = v; break; }
            case 9: { var v = default(BSGetTimeStepModifier); reader.ReadPackable(ref v); value = v; break; }
            case 10: { var v = default(BSIStateManagerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 11: { var v = default(BSInterpValueModifier); reader.ReadPackable(ref v); value = v; break; }
            case 12: { var v = default(BSIsActiveModifier); reader.ReadPackable(ref v); value = v; break; }
            case 13: { var v = default(BSLimbIKModifier); reader.ReadPackable(ref v); value = v; break; }
            case 14: { var v = default(BSLookAtModifier); reader.ReadPackable(ref v); value = v; break; }
            case 15: { var v = default(BSModifyOnceModifier); reader.ReadPackable(ref v); value = v; break; }
            case 16: { var v = default(BSPassByTargetTriggerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 17: { var v = default(BSRagdollContactListenerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 18: { var v = default(BSSpeedSamplerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 19: { var v = default(BSTimerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 20: { var v = default(BSTweenerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 21: { var v = default(hkbAttachmentModifier); reader.ReadPackable(ref v); value = v; break; }
            case 22: { var v = default(hkbAttributeModifier); reader.ReadPackable(ref v); value = v; break; }
            case 23: { var v = default(hkbCharacterControllerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 24: { var v = default(hkbCombineTransformsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 25: { var v = default(hkbComputeDirectionModifier); reader.ReadPackable(ref v); value = v; break; }
            case 26: { var v = default(hkbComputeRotationFromAxisAngleModifier); reader.ReadPackable(ref v); value = v; break; }
            case 27: { var v = default(hkbComputeRotationToTargetModifier); reader.ReadPackable(ref v); value = v; break; }
            case 28: { var v = default(hkbDampingModifier); reader.ReadPackable(ref v); value = v; break; }
            case 29: { var v = default(hkbDetectCloseToGroundModifier); reader.ReadPackable(ref v); value = v; break; }
            case 30: { var v = default(hkbEvaluateExpressionModifier); reader.ReadPackable(ref v); value = v; break; }
            case 31: { var v = default(hkbEvaluateHandleModifier); reader.ReadPackable(ref v); value = v; break; }
            case 32: { var v = default(hkbEventsFromRangeModifier); reader.ReadPackable(ref v); value = v; break; }
            case 33: { var v = default(hkbExtractRagdollPoseModifier); reader.ReadPackable(ref v); value = v; break; }
            case 34: { var v = default(hkbFootIkControlsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 35: { var v = default(hkbFootIkModifier); reader.ReadPackable(ref v); value = v; break; }
            case 36: { var v = default(hkbGetHandleOnBoneModifier); reader.ReadPackable(ref v); value = v; break; }
            case 37: { var v = default(hkbGetUpModifier); reader.ReadPackable(ref v); value = v; break; }
            case 38: { var v = default(hkbGetWorldFromModelModifier); reader.ReadPackable(ref v); value = v; break; }
            case 39: { var v = default(hkbHandIkControlsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 40: { var v = default(hkbHandIkModifier); reader.ReadPackable(ref v); value = v; break; }
            case 41: { var v = default(hkbKeyframeBonesModifier); reader.ReadPackable(ref v); value = v; break; }
            case 42: { var v = default(hkbLookAtModifier); reader.ReadPackable(ref v); value = v; break; }
            case 43: { var v = default(hkbMirrorModifier); reader.ReadPackable(ref v); value = v; break; }
            case 44: { var v = default(hkbModifierList); reader.ReadPackable(ref v); value = v; break; }
            case 45: { var v = default(hkbModifierWrapper); reader.ReadPackable(ref v); value = v; break; }
            case 46: { var v = default(hkbMoveCharacterModifier); reader.ReadPackable(ref v); value = v; break; }
            case 47: { var v = default(hkbPoweredRagdollControlsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 48: { var v = default(hkbProxyModifier); reader.ReadPackable(ref v); value = v; break; }
            case 49: { var v = default(hkbRigidBodyRagdollControlsModifier); reader.ReadPackable(ref v); value = v; break; }
            case 50: { var v = default(hkbRotateCharacterModifier); reader.ReadPackable(ref v); value = v; break; }
            case 51: { var v = default(hkbSenseHandleModifier); reader.ReadPackable(ref v); value = v; break; }
            case 52: { var v = default(hkbSequence); reader.ReadPackable(ref v); value = v; break; }
            case 53: { var v = default(hkbSetWorldFromModelModifier); reader.ReadPackable(ref v); value = v; break; }
            case 54: { var v = default(hkbTimerModifier); reader.ReadPackable(ref v); value = v; break; }
            case 55: { var v = default(hkbTransformVectorModifier); reader.ReadPackable(ref v); value = v; break; }
            case 56: { var v = default(hkbTwistModifier); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkbModifier union");
        }
    }
}
