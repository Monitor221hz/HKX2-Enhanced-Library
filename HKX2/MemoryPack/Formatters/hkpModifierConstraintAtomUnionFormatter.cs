// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkpModifierConstraintAtomUnionFormatter : MemoryPackFormatter<hkpModifierConstraintAtom>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkpModifierConstraintAtom? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkpCenterOfMassChangerModifierConstraintAtom v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkpIgnoreModifierConstraintAtom v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkpMassChangerModifierConstraintAtom v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkpMovingSurfaceModifierConstraintAtom v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case hkpSoftContactModifierConstraintAtom v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case hkpViscousSurfaceModifierConstraintAtom v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            default: throw new InvalidOperationException($"Unknown type for hkpModifierConstraintAtom union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkpModifierConstraintAtom? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkpCenterOfMassChangerModifierConstraintAtom); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkpIgnoreModifierConstraintAtom); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkpMassChangerModifierConstraintAtom); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkpMovingSurfaceModifierConstraintAtom); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(hkpSoftContactModifierConstraintAtom); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(hkpViscousSurfaceModifierConstraintAtom); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkpModifierConstraintAtom union");
        }
    }
}
