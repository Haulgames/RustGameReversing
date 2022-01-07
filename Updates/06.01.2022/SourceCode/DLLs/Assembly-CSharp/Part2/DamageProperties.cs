using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000660 RID: 1632
[Token(Token = "0x20004C5")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x84480", Offset = "0x83880")]
public class DamageProperties : ScriptableObject
{
	// Token: 0x06002CCD RID: 11469 RVA: 0x00013428 File Offset: 0x00011628
	[Token(Token = "0x60025A8")]
	[Address(RVA = "0x6DD840", Offset = "0x6DC640", VA = "0x1806DD840")]
	public float GetMultiplier(HitArea area)
	{
		return 0f;
	}

	// Token: 0x06002CCE RID: 11470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x6DD940", Offset = "0x6DC740", VA = "0x1806DD940")]
	public void ScaleDamage(HitInfo info)
	{
	}

	// Token: 0x06002CCF RID: 11471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025AA")]
	[Address(RVA = "0x484650", Offset = "0x483450", VA = "0x180484650")]
	public DamageProperties()
	{
	}

	// Token: 0x040027A7 RID: 10151
	[Token(Token = "0x400204C")]
	[FieldOffset(Offset = "0x18")]
	public DamageProperties fallback;

	// Token: 0x040027A8 RID: 10152
	[Token(Token = "0x400204D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HorizontalAttribute", RVA = "0x80EF0", Offset = "0x802F0")]
	public DamageProperties.HitAreaProperty[] bones;

	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x2000BCE")]
	[Serializable]
	public class HitAreaProperty
	{
		// Token: 0x06002CD0 RID: 11472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA1")]
		[Address(RVA = "0x6DF280", Offset = "0x6DE080", VA = "0x1806DF280")]
		public HitAreaProperty()
		{
		}

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x4004465")]
		[FieldOffset(Offset = "0x10")]
		public HitArea area;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x4004466")]
		[FieldOffset(Offset = "0x14")]
		public float damage;
	}
}
