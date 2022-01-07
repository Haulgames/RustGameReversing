using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000029 RID: 41
[Token(Token = "0x200001D")]
public class CargoShipSounds : MonoBehaviour, IClientComponent
{
	// Token: 0x060000D4 RID: 212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x656C50", Offset = "0x655A50", VA = "0x180656C50")]
	public void UpdateSounds()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void InitSounds()
	{
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x656B90", Offset = "0x655990", VA = "0x180656B90")]
	public void InteriorTriggerEntered(CargoShipInteriorSoundTrigger trigger)
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x656BF0", Offset = "0x6559F0", VA = "0x180656BF0")]
	public void InteriorTriggerExited(CargoShipInteriorSoundTrigger trigger)
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x658160", Offset = "0x656F60", VA = "0x180658160")]
	public CargoShipSounds()
	{
	}

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x18")]
	public SoundDefinition waveSoundDef;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve waveSoundYGainCurve;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve waveSoundEdgeDistanceGainCurve;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x30")]
	private Sound waveSoundL;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x38")]
	private Sound waveSoundR;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x40")]
	private SoundModulation.Modulator waveSoundLGainMod;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x48")]
	private SoundModulation.Modulator waveSoundRGainMod;

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x50")]
	public SoundDefinition sternWakeSoundDef;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x58")]
	private Sound sternWakeSound;

	// Token: 0x040000F2 RID: 242
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x60")]
	private SoundModulation.Modulator sternWakeSoundGainMod;

	// Token: 0x040000F3 RID: 243
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x68")]
	public SoundDefinition engineHumSoundDef;

	// Token: 0x040000F4 RID: 244
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x70")]
	private Sound engineHumSound;

	// Token: 0x040000F5 RID: 245
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x78")]
	public GameObject engineHumTarget;

	// Token: 0x040000F6 RID: 246
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x80")]
	public SoundDefinition hugeRumbleSoundDef;

	// Token: 0x040000F7 RID: 247
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x88")]
	public AnimationCurve hugeRumbleYDiffCurve;

	// Token: 0x040000F8 RID: 248
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve hugeRumbleRelativeSpeedCurve;

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x98")]
	private Sound hugeRumbleSound;

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0xA0")]
	private SoundModulation.Modulator hugeRumbleGainMod;

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 lastCameraPos;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 lastRumblePos;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 lastRumbleLocalPos;

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0xD0")]
	public Collider soundFollowCollider;

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0xD8")]
	public Collider soundFollowColliderL;

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0xE0")]
	public Collider soundFollowColliderR;

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0xE8")]
	public Collider sternSoundFollowCollider;

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0xF0")]
	private HashSet<CargoShipInteriorSoundTrigger> interiorSoundTriggers;
}
