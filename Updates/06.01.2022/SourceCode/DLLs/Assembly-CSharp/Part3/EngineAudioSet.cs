using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000582 RID: 1410
[Token(Token = "0x200041B")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xE58E0", Offset = "0xE4CE0")]
public class EngineAudioSet : ScriptableObject
{
	// Token: 0x06002860 RID: 10336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x992100", Offset = "0x990F00", VA = "0x180992100")]
	public BlendedEngineLoopDefinition GetEngineLoopDef(byte numEngines)
	{
		return null;
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60021C5")]
	[Address(RVA = "0x992140", Offset = "0x990F40", VA = "0x180992140")]
	public EngineAudioSet()
	{
	}

	// Token: 0x040023AF RID: 9135
	[Token(Token = "0x4001D30")]
	[FieldOffset(Offset = "0x18")]
	public BlendedEngineLoopDefinition[] engineAudioLoops;

	// Token: 0x040023B0 RID: 9136
	[Token(Token = "0x4001D31")]
	[FieldOffset(Offset = "0x20")]
	public int priority;

	// Token: 0x040023B1 RID: 9137
	[Token(Token = "0x4001D32")]
	[FieldOffset(Offset = "0x24")]
	public float idleVolume;

	// Token: 0x040023B2 RID: 9138
	[Token(Token = "0x4001D33")]
	[FieldOffset(Offset = "0x28")]
	public float maxVolume;

	// Token: 0x040023B3 RID: 9139
	[Token(Token = "0x4001D34")]
	[FieldOffset(Offset = "0x2C")]
	public float volumeChangeRateUp;

	// Token: 0x040023B4 RID: 9140
	[Token(Token = "0x4001D35")]
	[FieldOffset(Offset = "0x30")]
	public float volumeChangeRateDown;

	// Token: 0x040023B5 RID: 9141
	[Token(Token = "0x4001D36")]
	[FieldOffset(Offset = "0x34")]
	public float idlePitch;

	// Token: 0x040023B6 RID: 9142
	[Token(Token = "0x4001D37")]
	[FieldOffset(Offset = "0x38")]
	public float maxPitch;

	// Token: 0x040023B7 RID: 9143
	[Token(Token = "0x4001D38")]
	[FieldOffset(Offset = "0x3C")]
	public float idleRpm;

	// Token: 0x040023B8 RID: 9144
	[Token(Token = "0x4001D39")]
	[FieldOffset(Offset = "0x40")]
	public float gearUpRpm;

	// Token: 0x040023B9 RID: 9145
	[Token(Token = "0x4001D3A")]
	[FieldOffset(Offset = "0x44")]
	public float gearDownRpm;

	// Token: 0x040023BA RID: 9146
	[Token(Token = "0x4001D3B")]
	[FieldOffset(Offset = "0x48")]
	public int numGears;

	// Token: 0x040023BB RID: 9147
	[Token(Token = "0x4001D3C")]
	[FieldOffset(Offset = "0x4C")]
	public float maxRpm;

	// Token: 0x040023BC RID: 9148
	[Token(Token = "0x4001D3D")]
	[FieldOffset(Offset = "0x50")]
	public float gearUpRpmRate;

	// Token: 0x040023BD RID: 9149
	[Token(Token = "0x4001D3E")]
	[FieldOffset(Offset = "0x54")]
	public float gearDownRpmRate;

	// Token: 0x040023BE RID: 9150
	[Token(Token = "0x4001D3F")]
	[FieldOffset(Offset = "0x58")]
	public SoundDefinition badPerformanceLoop;
}
