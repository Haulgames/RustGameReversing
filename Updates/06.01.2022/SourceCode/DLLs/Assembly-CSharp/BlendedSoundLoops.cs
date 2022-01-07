using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B5 RID: 693
[Token(Token = "0x20001E9")]
public class BlendedSoundLoops : MonoBehaviour, IClientComponent
{
	// Token: 0x06001A3C RID: 6716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x45CC70", Offset = "0x45BA70", VA = "0x18045CC70")]
	private void Update()
	{
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x45D3D0", Offset = "0x45C1D0", VA = "0x18045D3D0")]
	public BlendedSoundLoops()
	{
	}

	// Token: 0x040014C0 RID: 5312
	[Token(Token = "0x4001112")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6CE90", Offset = "0x6C290")]
	public float blend;

	// Token: 0x040014C1 RID: 5313
	[Token(Token = "0x4001113")]
	[FieldOffset(Offset = "0x1C")]
	public float blendSmoothing;

	// Token: 0x040014C2 RID: 5314
	[Token(Token = "0x4001114")]
	[FieldOffset(Offset = "0x20")]
	public float loopFadeOutTime;

	// Token: 0x040014C3 RID: 5315
	[Token(Token = "0x4001115")]
	[FieldOffset(Offset = "0x24")]
	public float loopFadeInTime;

	// Token: 0x040014C4 RID: 5316
	[Token(Token = "0x4001116")]
	[FieldOffset(Offset = "0x28")]
	public float gainModSmoothing;

	// Token: 0x040014C5 RID: 5317
	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x2C")]
	public float pitchModSmoothing;

	// Token: 0x040014C6 RID: 5318
	[Token(Token = "0x4001118")]
	[FieldOffset(Offset = "0x30")]
	public bool shouldPlay;

	// Token: 0x040014C7 RID: 5319
	[Token(Token = "0x4001119")]
	[FieldOffset(Offset = "0x34")]
	public float gain;

	// Token: 0x040014C8 RID: 5320
	[Token(Token = "0x400111A")]
	[FieldOffset(Offset = "0x38")]
	public List<BlendedSoundLoops.Loop> loops;

	// Token: 0x040014C9 RID: 5321
	[Token(Token = "0x400111B")]
	[FieldOffset(Offset = "0x40")]
	public float maxDistance;

	// Token: 0x040014CA RID: 5322
	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0x44")]
	private float smoothedBlend;

	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x2000B01")]
	[Serializable]
	public class Loop
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF1")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public Loop()
		{
		}

		// Token: 0x040014CB RID: 5323
		[Token(Token = "0x40040C4")]
		[FieldOffset(Offset = "0x10")]
		public SoundDefinition soundDef;

		// Token: 0x040014CC RID: 5324
		[Token(Token = "0x40040C5")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve gainCurve;

		// Token: 0x040014CD RID: 5325
		[Token(Token = "0x40040C6")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve pitchCurve;

		// Token: 0x040014CE RID: 5326
		[Token(Token = "0x40040C7")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Sound sound;

		// Token: 0x040014CF RID: 5327
		[Token(Token = "0x40040C8")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public SoundModulation.Modulator gainMod;

		// Token: 0x040014D0 RID: 5328
		[Token(Token = "0x40040C9")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public SoundModulation.Modulator pitchMod;
	}
}
