// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkpActionUnionFormatter : MemoryPackFormatter<hkpAction>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkpAction? value)
    {
        if (value == null) { writer.WriteNullUnionHeader(); return; }
        switch (value)
        {
            case hkpAngularDashpotAction v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkpDashpotAction v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkpSpringAction v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkpMotorAction v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case hkpMouseSpringAction v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case hkpReorientAction v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            case hkpArrayAction v6: writer.WriteUnionHeader(6); writer.WritePackable(v6); break;
            case hkpBinaryAction v7: writer.WriteUnionHeader(7); writer.WritePackable(v7); break;
            case hkpConstraintChainInstanceAction v8: writer.WriteUnionHeader(8); writer.WritePackable(v8); break;
            case hkpUnaryAction v9: writer.WriteUnionHeader(9); writer.WritePackable(v9); break;
            default: throw new InvalidOperationException($"Unknown type for hkpAction union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkpAction? value)
    {
        if (!reader.TryReadUnionHeader(out var tag)) { value = null; return; }
        switch (tag)
        {
            case 0: { var v = default(hkpAngularDashpotAction); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkpDashpotAction); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkpSpringAction); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkpMotorAction); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(hkpMouseSpringAction); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(hkpReorientAction); reader.ReadPackable(ref v); value = v; break; }
            case 6: { var v = default(hkpArrayAction); reader.ReadPackable(ref v); value = v; break; }
            case 7: { var v = default(hkpBinaryAction); reader.ReadPackable(ref v); value = v; break; }
            case 8: { var v = default(hkpConstraintChainInstanceAction); reader.ReadPackable(ref v); value = v; break; }
            case 9: { var v = default(hkpUnaryAction); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkpAction union");
        }
    }
}
