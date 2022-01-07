using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200065F RID: 1631
[Token(Token = "0x20004C4")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x84300", Offset = "0x83700")]
public class ClothingMovementProperties : ScriptableObject
{
	// Token: 0x06002CCC RID: 11468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A7")]
	[Address(RVA = "0x484650", Offset = "0x483450", VA = "0x180484650")]
	public ClothingMovementProperties()
	{
	}

	// Token: 0x040027A4 RID: 10148
	[Token(Token = "0x4002049")]
	[FieldOffset(Offset = "0x18")]
	public float speedReduction;

	// Token: 0x040027A5 RID: 10149
	[Token(Token = "0x400204A")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x843B0", Offset = "0x837B0")]
	public float minSpeedReduction;

	// Token: 0x040027A6 RID: 10150
	[Token(Token = "0x400204B")]
	[FieldOffset(Offset = "0x20")]
	public float waterSpeedBonus;
}
