// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkbGeneratorUnionFormatter : MemoryPackFormatter<hkbGenerator>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkbGenerator? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkbBlendingTransitionEffect v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkbGeneratorTransitionEffect v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkbPoseMatchingGenerator v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case BGSGamebryoSequenceGenerator v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case BSBoneSwitchGenerator v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case BSCyclicBlendTransitionGenerator v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            case BSOffsetAnimationGenerator v6: writer.WriteUnionHeader(6); writer.WritePackable(v6); break;
            case BSSynchronizedClipGenerator v7: writer.WriteUnionHeader(7); writer.WritePackable(v7); break;
            case BSiStateTaggingGenerator v8: writer.WriteUnionHeader(8); writer.WritePackable(v8); break;
            case hkbBehaviorGraph v9: writer.WriteUnionHeader(9); writer.WritePackable(v9); break;
            case hkbBehaviorReferenceGenerator v10: writer.WriteUnionHeader(10); writer.WritePackable(v10); break;
            case hkbBlenderGenerator v11: writer.WriteUnionHeader(11); writer.WritePackable(v11); break;
            case hkbClipGenerator v12: writer.WriteUnionHeader(12); writer.WritePackable(v12); break;
            case hkbManualSelectorGenerator v13: writer.WriteUnionHeader(13); writer.WritePackable(v13); break;
            case hkbModifierGenerator v14: writer.WriteUnionHeader(14); writer.WritePackable(v14); break;
            case hkbReferencePoseGenerator v15: writer.WriteUnionHeader(15); writer.WritePackable(v15); break;
            case hkbStateMachine v16: writer.WriteUnionHeader(16); writer.WritePackable(v16); break;
            default: throw new InvalidOperationException($"Unknown type for hkbGenerator union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkbGenerator? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkbBlendingTransitionEffect); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkbGeneratorTransitionEffect); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkbPoseMatchingGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(BGSGamebryoSequenceGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(BSBoneSwitchGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(BSCyclicBlendTransitionGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 6: { var v = default(BSOffsetAnimationGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 7: { var v = default(BSSynchronizedClipGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 8: { var v = default(BSiStateTaggingGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 9: { var v = default(hkbBehaviorGraph); reader.ReadPackable(ref v); value = v; break; }
            case 10: { var v = default(hkbBehaviorReferenceGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 11: { var v = default(hkbBlenderGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 12: { var v = default(hkbClipGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 13: { var v = default(hkbManualSelectorGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 14: { var v = default(hkbModifierGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 15: { var v = default(hkbReferencePoseGenerator); reader.ReadPackable(ref v); value = v; break; }
            case 16: { var v = default(hkbStateMachine); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkbGenerator union");
        }
    }
}
