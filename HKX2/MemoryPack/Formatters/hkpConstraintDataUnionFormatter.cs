// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkpConstraintDataUnionFormatter : MemoryPackFormatter<hkpConstraintData>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkpConstraintData? value)
    {
        if (value == null) { writer.WriteNullUnionHeader(); return; }
        switch (value)
        {
            case hkpBallSocketChainData v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkpPoweredChainData v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkpStiffSpringChainData v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkpBallAndSocketConstraintData v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case hkpBreakableConstraintData v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case hkpCogWheelConstraintData v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            case hkpConstraintChainData v6: writer.WriteUnionHeader(6); writer.WritePackable(v6); break;
            case hkpGenericConstraintData v7: writer.WriteUnionHeader(7); writer.WritePackable(v7); break;
            case hkpHingeConstraintData v8: writer.WriteUnionHeader(8); writer.WritePackable(v8); break;
            case hkpHingeLimitsData v9: writer.WriteUnionHeader(9); writer.WritePackable(v9); break;
            case hkpLimitedHingeConstraintData v10: writer.WriteUnionHeader(10); writer.WritePackable(v10); break;
            case hkpMalleableConstraintData v11: writer.WriteUnionHeader(11); writer.WritePackable(v11); break;
            case hkpPointToPathConstraintData v12: writer.WriteUnionHeader(12); writer.WritePackable(v12); break;
            case hkpPointToPlaneConstraintData v13: writer.WriteUnionHeader(13); writer.WritePackable(v13); break;
            case hkpPrismaticConstraintData v14: writer.WriteUnionHeader(14); writer.WritePackable(v14); break;
            case hkpPulleyConstraintData v15: writer.WriteUnionHeader(15); writer.WritePackable(v15); break;
            case hkpRackAndPinionConstraintData v16: writer.WriteUnionHeader(16); writer.WritePackable(v16); break;
            case hkpRagdollConstraintData v17: writer.WriteUnionHeader(17); writer.WritePackable(v17); break;
            case hkpRagdollLimitsData v18: writer.WriteUnionHeader(18); writer.WritePackable(v18); break;
            case hkpRotationalConstraintData v19: writer.WriteUnionHeader(19); writer.WritePackable(v19); break;
            case hkpStiffSpringConstraintData v20: writer.WriteUnionHeader(20); writer.WritePackable(v20); break;
            case hkpWheelConstraintData v21: writer.WriteUnionHeader(21); writer.WritePackable(v21); break;
            default: throw new InvalidOperationException($"Unknown type for hkpConstraintData union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkpConstraintData? value)
    {
        if (!reader.TryReadUnionHeader(out var tag)) { value = null; return; }
        switch (tag)
        {
            case 0: { var v = default(hkpBallSocketChainData); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkpPoweredChainData); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkpStiffSpringChainData); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkpBallAndSocketConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(hkpBreakableConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(hkpCogWheelConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 6: { var v = default(hkpConstraintChainData); reader.ReadPackable(ref v); value = v; break; }
            case 7: { var v = default(hkpGenericConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 8: { var v = default(hkpHingeConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 9: { var v = default(hkpHingeLimitsData); reader.ReadPackable(ref v); value = v; break; }
            case 10: { var v = default(hkpLimitedHingeConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 11: { var v = default(hkpMalleableConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 12: { var v = default(hkpPointToPathConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 13: { var v = default(hkpPointToPlaneConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 14: { var v = default(hkpPrismaticConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 15: { var v = default(hkpPulleyConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 16: { var v = default(hkpRackAndPinionConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 17: { var v = default(hkpRagdollConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 18: { var v = default(hkpRagdollLimitsData); reader.ReadPackable(ref v); value = v; break; }
            case 19: { var v = default(hkpRotationalConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 20: { var v = default(hkpStiffSpringConstraintData); reader.ReadPackable(ref v); value = v; break; }
            case 21: { var v = default(hkpWheelConstraintData); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkpConstraintData union");
        }
    }
}
