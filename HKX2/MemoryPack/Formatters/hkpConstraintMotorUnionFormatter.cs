// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkpConstraintMotorUnionFormatter : MemoryPackFormatter<hkpConstraintMotor>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkpConstraintMotor? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkpCallbackConstraintMotor v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkpPositionConstraintMotor v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkpSpringDamperConstraintMotor v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkpVelocityConstraintMotor v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case hkpLimitedForceConstraintMotor v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            default: throw new InvalidOperationException($"Unknown type for hkpConstraintMotor union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkpConstraintMotor? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkpCallbackConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkpPositionConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkpSpringDamperConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkpVelocityConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(hkpLimitedForceConstraintMotor); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkpConstraintMotor union");
        }
    }
}
