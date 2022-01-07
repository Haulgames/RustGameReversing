using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000006")]
public class EffectsBenchmarkScene : BenchmarkScene
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x98A240", Offset = "0x989040", VA = "0x18098A240", Slot = "7")]
	public override void StartBenchmark()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x98A1C0", Offset = "0x988FC0", VA = "0x18098A1C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x972D0", Offset = "0x966D0")]
	private IEnumerator DoEffectBenchmark()
	{
		return null;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x98A230", Offset = "0x989030", VA = "0x18098A230", Slot = "5")]
	public override bool ShouldEnd()
	{
		return default(bool);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x98A2B0", Offset = "0x9890B0", VA = "0x18098A2B0")]
	public EffectsBenchmarkScene()
	{
	}

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	public GameObjectRef[] effectPrefabs;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x48")]
	private int effectCountPerFrame;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x4C")]
	private float timeBetweenRuns;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x50")]
	private int totalRuns;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x54")]
	private bool isFinished;

	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000A43")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <DoEffectBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004799")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <DoEffectBenchmark>d__6(int <>1__state)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479A")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600479B")]
		[Address(RVA = "0x993440", Offset = "0x992240", VA = "0x180993440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EB")]
		private object Current
		{
			[Token(Token = "0x600479C")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479D")]
		[Address(RVA = "0x993700", Offset = "0x992500", VA = "0x180993700", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EC")]
		private object Current
		{
			[Token(Token = "0x600479E")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4003D4A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4003D4B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4003D4C")]
		[FieldOffset(Offset = "0x20")]
		public EffectsBenchmarkScene <>4__this;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4003D4D")]
		[FieldOffset(Offset = "0x28")]
		private int <i>5__2;
	}
}
