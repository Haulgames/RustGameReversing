using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B3 RID: 691
[Token(Token = "0x20001E8")]
public class BlendedLoopEngineSound : MonoBehaviour, IClientComponent
{
	// Token: 0x06001A31 RID: 6705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x326940", Offset = "0x325740", VA = "0x180326940")]
	public BlendedLoopEngineSound.EngineLoop[] GetEngineLoops()
	{
		return null;
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x45C720", Offset = "0x45B520", VA = "0x18045C720")]
	public float GetLoopGain(int idx)
	{
		return 0f;
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x45C770", Offset = "0x45B570", VA = "0x18045C770")]
	public float GetLoopPitch(int idx)
	{
		return 0f;
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
	[Token(Token = "0x170001B4")]
	public float maxDistance
	{
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x45CC20", Offset = "0x45BA20", VA = "0x18045CC20")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001A35 RID: 6709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x45C7C0", Offset = "0x45B5C0", VA = "0x18045C7C0")]
	public void Init([Optional] BlendedEngineLoopDefinition definition)
	{
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C7")]
	[Address(RVA = "0x45CA00", Offset = "0x45B800", VA = "0x18045CA00")]
	private void Update()
	{
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C8")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BlendedLoopEngineSound()
	{
	}

	// Token: 0x040014B6 RID: 5302
	[Token(Token = "0x400110D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BlendedEngineLoopDefinition loopDefinition;

	// Token: 0x040014B7 RID: 5303
	[Token(Token = "0x400110E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool engineOn;

	// Token: 0x040014B8 RID: 5304
	[Token(Token = "0x400110F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
	public float RPMControl;

	// Token: 0x040014B9 RID: 5305
	[Token(Token = "0x4001110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float smoothedRPMControl;

	// Token: 0x040014BA RID: 5306
	[Token(Token = "0x4001111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BlendedLoopEngineSound.EngineLoop[] engineLoops;

	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x2000B00")]
	public class EngineLoop
	{
		// Token: 0x06001A38 RID: 6712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x470420", Offset = "0x46F220", VA = "0x180470420")]
		public EngineLoop(BlendedEngineLoopDefinition.EngineLoopDefinition definition, BlendedLoopEngineSound parent)
		{
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0x470060", Offset = "0x46EE60", VA = "0x180470060")]
		public void Update(float RPM, float cameraDistance)
		{
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEF")]
		[Address(RVA = "0x46FE30", Offset = "0x46EC30", VA = "0x18046FE30")]
		public void CreateSound()
		{
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF0")]
		[Address(RVA = "0x46FF80", Offset = "0x46ED80", VA = "0x18046FF80")]
		public void RecycleSound()
		{
		}

		// Token: 0x040014BB RID: 5307
		[Token(Token = "0x40040BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BlendedEngineLoopDefinition.EngineLoopDefinition definition;

		// Token: 0x040014BC RID: 5308
		[Token(Token = "0x40040C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BlendedLoopEngineSound parent;

		// Token: 0x040014BD RID: 5309
		[Token(Token = "0x40040C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sound sound;

		// Token: 0x040014BE RID: 5310
		[Token(Token = "0x40040C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SoundModulation.Modulator gainMod;

		// Token: 0x040014BF RID: 5311
		[Token(Token = "0x40040C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundModulation.Modulator pitchMod;
	}
}
