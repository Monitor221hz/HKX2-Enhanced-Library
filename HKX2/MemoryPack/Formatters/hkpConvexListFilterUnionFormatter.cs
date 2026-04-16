// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkpConvexListFilterUnionFormatter : MemoryPackFormatter<hkpConvexListFilter>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkpConvexListFilter? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkpDefaultConvexListFilter v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            default: throw new InvalidOperationException($"Unknown type for hkpConvexListFilter union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkpConvexListFilter? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkpDefaultConvexListFilter); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkpConvexListFilter union");
        }
    }
}
