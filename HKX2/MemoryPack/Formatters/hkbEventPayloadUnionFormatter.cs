// SPDX-License-Identifier: GPL-3.0-or-later
using System;
using MemoryPack;

namespace HKX2E;

public sealed class hkbEventPayloadUnionFormatter : MemoryPackFormatter<hkbEventPayload>
{
    public override void Serialize<TBufferWriter>(
        ref MemoryPackWriter<TBufferWriter> writer, scoped ref hkbEventPayload? value)
    {
        if (value == null)
        {
            writer.WriteNullUnionHeader();
            return;
        }
        switch (value)
        {
            case hkbCameraShakeEventPayload v0: writer.WriteUnionHeader(0); writer.WritePackable(v0); break;
            case hkbEventPayloadList v1: writer.WriteUnionHeader(1); writer.WritePackable(v1); break;
            case hkbIntEventPayload v2: writer.WriteUnionHeader(2); writer.WritePackable(v2); break;
            case hkbNamedEventPayload v3: writer.WriteUnionHeader(3); writer.WritePackable(v3); break;
            case hkbParticleSystemEventPayload v4: writer.WriteUnionHeader(4); writer.WritePackable(v4); break;
            case hkbRealEventPayload v5: writer.WriteUnionHeader(5); writer.WritePackable(v5); break;
            case hkbStringEventPayload v6: writer.WriteUnionHeader(6); writer.WritePackable(v6); break;
            default: throw new InvalidOperationException($"Unknown type for hkbEventPayload union: {value.GetType().Name}");
        }
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref hkbEventPayload? value)
    {
        if (!reader.TryReadUnionHeader(out var tag))
        {
            value = null;
            return;
        }
        switch (tag)
        {
            case 0: { var v = default(hkbCameraShakeEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 1: { var v = default(hkbEventPayloadList); reader.ReadPackable(ref v); value = v; break; }
            case 2: { var v = default(hkbIntEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 3: { var v = default(hkbNamedEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 4: { var v = default(hkbParticleSystemEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 5: { var v = default(hkbRealEventPayload); reader.ReadPackable(ref v); value = v; break; }
            case 6: { var v = default(hkbStringEventPayload); reader.ReadPackable(ref v); value = v; break; }
            default: throw new InvalidOperationException($"Unknown tag {tag} for hkbEventPayload union");
        }
    }
}
