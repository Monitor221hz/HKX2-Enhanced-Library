// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkpPhantomUnionFormatter : MemoryPackFormatter<hkpPhantom>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkpPhantom? value)
    {
        if (value == null) { writer.WriteNullUnionHeader(); return; }
        switch (value)
        {
            case hkpCachingShapePhantom v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkpSimpleShapePhantom v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkpAabbPhantom v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkpShapePhantom v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            default: throw new InvalidOperationException($"Unknown type for hkpPhantom union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkpPhantom? value)
    {
        if (!reader.TryReadUnionHeader(out var tag)) { value = null; return; }
        switch (tag)
        {
            case 0: { var v = default(hkpCachingShapePhantom); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkpSimpleShapePhantom); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkpAabbPhantom); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkpShapePhantom); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkpPhantom union");
        }
    }
}
