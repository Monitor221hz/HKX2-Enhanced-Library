// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkpShapeUnionFormatter : MemoryPackFormatter<hkpShape>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkpShape? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkpConvexTransformShape v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkpConvexTranslateShape v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkpBoxShape v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkpCapsuleShape v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case hkpConvexListShape v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case hkpConvexTransformShapeBase v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            case hkpConvexVerticesShape v6: writer.WriteUnionHeader(6); writer.WritePackable(v6); break;
            case hkpCylinderShape v7: writer.WriteUnionHeader(7); writer.WritePackable(v7); break;
            case hkpFastMeshShape v8: writer.WriteUnionHeader(8); writer.WritePackable(v8); break;
            case hkpMoppBvTreeShape v9: writer.WriteUnionHeader(9); writer.WritePackable(v9); break;
            case hkpSphereShape v10: writer.WriteUnionHeader(10); writer.WritePackable(v10); break;
            case hkpStorageMeshShape v11: writer.WriteUnionHeader(11); writer.WritePackable(v11); break;
            case hkpTriangleShape v12: writer.WriteUnionHeader(12); writer.WritePackable(v12); break;
            case hkMoppBvTreeShapeBase v13: writer.WriteUnionHeader(13); writer.WritePackable(v13); break;
            case hkpConvexShape v14: writer.WriteUnionHeader(14); writer.WritePackable(v14); break;
            case hkpListShape v15: writer.WriteUnionHeader(15); writer.WritePackable(v15); break;
            case hkpMeshShape v16: writer.WriteUnionHeader(16); writer.WritePackable(v16); break;
            case hkpMultiSphereShape v17: writer.WriteUnionHeader(17); writer.WritePackable(v17); break;
            case hkpPlaneShape v18: writer.WriteUnionHeader(18); writer.WritePackable(v18); break;
            case hkpBvShape v19: writer.WriteUnionHeader(19); writer.WritePackable(v19); break;
            case hkpBvTreeShape v20: writer.WriteUnionHeader(20); writer.WritePackable(v20); break;
            case hkpHeightFieldShape v21: writer.WriteUnionHeader(21); writer.WritePackable(v21); break;
            case hkpMultiRayShape v22: writer.WriteUnionHeader(22); writer.WritePackable(v22); break;
            case hkpPhantomCallbackShape v23: writer.WriteUnionHeader(23); writer.WritePackable(v23); break;
            case hkpShapeCollection v24: writer.WriteUnionHeader(24); writer.WritePackable(v24); break;
            case hkpSphereRepShape v25: writer.WriteUnionHeader(25); writer.WritePackable(v25); break;
            case hkpTransformShape v26: writer.WriteUnionHeader(26); writer.WritePackable(v26); break;
            default: throw new InvalidOperationException($"Unknown type for hkpShape union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkpShape? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkpConvexTransformShape); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkpConvexTranslateShape); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkpBoxShape); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkpCapsuleShape); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(hkpConvexListShape); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(hkpConvexTransformShapeBase); reader.ReadPackable(ref v); value = v; break; }
            case 6: { var v = default(hkpConvexVerticesShape); reader.ReadPackable(ref v); value = v; break; }
            case 7: { var v = default(hkpCylinderShape); reader.ReadPackable(ref v); value = v; break; }
            case 8: { var v = default(hkpFastMeshShape); reader.ReadPackable(ref v); value = v; break; }
            case 9: { var v = default(hkpMoppBvTreeShape); reader.ReadPackable(ref v); value = v; break; }
            case 10: { var v = default(hkpSphereShape); reader.ReadPackable(ref v); value = v; break; }
            case 11: { var v = default(hkpStorageMeshShape); reader.ReadPackable(ref v); value = v; break; }
            case 12: { var v = default(hkpTriangleShape); reader.ReadPackable(ref v); value = v; break; }
            case 13: { var v = default(hkMoppBvTreeShapeBase); reader.ReadPackable(ref v); value = v; break; }
            case 14: { var v = default(hkpConvexShape); reader.ReadPackable(ref v); value = v; break; }
            case 15: { var v = default(hkpListShape); reader.ReadPackable(ref v); value = v; break; }
            case 16: { var v = default(hkpMeshShape); reader.ReadPackable(ref v); value = v; break; }
            case 17: { var v = default(hkpMultiSphereShape); reader.ReadPackable(ref v); value = v; break; }
            case 18: { var v = default(hkpPlaneShape); reader.ReadPackable(ref v); value = v; break; }
            case 19: { var v = default(hkpBvShape); reader.ReadPackable(ref v); value = v; break; }
            case 20: { var v = default(hkpBvTreeShape); reader.ReadPackable(ref v); value = v; break; }
            case 21: { var v = default(hkpHeightFieldShape); reader.ReadPackable(ref v); value = v; break; }
            case 22: { var v = default(hkpMultiRayShape); reader.ReadPackable(ref v); value = v; break; }
            case 23: { var v = default(hkpPhantomCallbackShape); reader.ReadPackable(ref v); value = v; break; }
            case 24: { var v = default(hkpShapeCollection); reader.ReadPackable(ref v); value = v; break; }
            case 25: { var v = default(hkpSphereRepShape); reader.ReadPackable(ref v); value = v; break; }
            case 26: { var v = default(hkpTransformShape); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkpShape union");
        }
    }
}
