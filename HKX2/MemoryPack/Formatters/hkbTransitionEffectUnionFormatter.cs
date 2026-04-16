// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkbTransitionEffectUnionFormatter : MemoryPackFormatter<hkbTransitionEffect>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkbTransitionEffect? value)
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
            default: throw new InvalidOperationException($"Unknown type for hkbTransitionEffect union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkbTransitionEffect? value)
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
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkbTransitionEffect union");
        }
    }
}
