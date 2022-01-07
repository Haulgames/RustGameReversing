using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000B")]
public class BenchmarkScene : MonoBehaviour
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600003B RID: 59 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x17000005")]
	public virtual bool SubmitsOwnResults
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x459180", Offset = "0x457F80", VA = "0x180459180", Slot = "5")]
	public virtual bool ShouldEnd()
	{
		return default(bool);
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x4591D0", Offset = "0x457FD0", VA = "0x1804591D0")]
	public void Start()
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x459110", Offset = "0x457F10", VA = "0x180459110")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x97CC0", Offset = "0x970C0")]
	public IEnumerator RunBenchmark()
	{
		return null;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x4590F0", Offset = "0x457EF0", VA = "0x1804590F0", Slot = "6")]
	public virtual float GetResult()
	{
		return 0f;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "7")]
	public virtual void StartBenchmark()
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "8")]
	public virtual void BenchmarkUpdate()
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "9")]
	public virtual void StopBenchmark()
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x4593D0", Offset = "0x4581D0", VA = "0x1804593D0")]
	public BenchmarkScene()
	{
	}

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x18")]
	public string BenchmarkTitle;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x20")]
	public string BenchmarkIdent;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x28")]
	public int MaxNumberOfFrames;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x2C")]
	public int MaxNumberOfSeconds;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x30")]
	protected int FrameCount;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x34")]
	protected TimeSince TimeSinceStarted;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x38")]
	protected TimeSince TimeSinceFrame;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x3C")]
	protected float FrameTimes;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x0")]
	public static bool IsRunningInEditor;

	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000A46")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <RunBenchmark>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <RunBenchmark>d__13(int <>1__state)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x60047AC")]
		[Address(RVA = "0x473A00", Offset = "0x472800", VA = "0x180473A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EF")]
		private object Current
		{
			[Token(Token = "0x60047AD")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AE")]
		[Address(RVA = "0x473EE0", Offset = "0x472CE0", VA = "0x180473EE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F0")]
		private object Current
		{
			[Token(Token = "0x60047AF")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4003D60")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4003D61")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4003D62")]
		[FieldOffset(Offset = "0x20")]
		public BenchmarkScene <>4__this;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x4003D63")]
		[FieldOffset(Offset = "0x28")]
		private Stopwatch <sw>5__2;
	}
}
