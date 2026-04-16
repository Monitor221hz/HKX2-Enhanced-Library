// SPDX-License-Identifier: GPL-3.0-or-later
using System.Runtime.CompilerServices;
using MemoryPack;

namespace HKX2E;

internal static class HavokFormatterRegistration
{
	[ModuleInitializer]
	public static void Register()
	{
		MemoryPackFormatterProvider.Register(new hkReferencedObjectUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkLocalFrameUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkaAnimatedReferenceFrameUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkaAnimationUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkbConditionUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkbEventPayloadUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkbGeneratorUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkbModifierUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkbStateChooserUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkbTransitionEffectUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpActionUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpCollisionFilterUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpConstraintAtomUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpConstraintDataUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpConstraintMotorUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpConvexListFilterUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpEntityUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpModifierConstraintAtomUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpPhantomUnionFormatter());
		MemoryPackFormatterProvider.Register(new hkpShapeUnionFormatter());
	}
}
