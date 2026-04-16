// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkpCollisionFilterUnionFormatter : MemoryPackFormatter<hkpCollisionFilter>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkpCollisionFilter? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkpCollisionFilterList v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkpConstrainedSystemFilter v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkpDisableEntityCollisionFilter v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkpGroupCollisionFilter v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case hkpGroupFilter v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case hkpNullCollisionFilter v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            case hkpPairCollisionFilter v6: writer.WriteUnionHeader(6); writer.WritePackable(v6); break;
            default: throw new InvalidOperationException($"Unknown type for hkpCollisionFilter union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkpCollisionFilter? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkpCollisionFilterList); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkpConstrainedSystemFilter); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkpDisableEntityCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkpGroupCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(hkpGroupFilter); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(hkpNullCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            case 6: { var v = default(hkpPairCollisionFilter); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkpCollisionFilter union");
        }
    }
}
