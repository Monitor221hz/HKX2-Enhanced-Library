// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkbConditionUnionFormatter : MemoryPackFormatter<hkbCondition>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkbCondition? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkbExpressionCondition v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkbStringCondition v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            default: throw new InvalidOperationException($"Unknown type for hkbCondition union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkbCondition? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkbExpressionCondition); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkbStringCondition); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkbCondition union");
        }
    }
}
