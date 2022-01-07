using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200065E RID: 1630
[Token(Token = "0x20004C3")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x83FA0", Offset = "0x833A0")]
public class ArmorProperties : ScriptableObject
{
	// Token: 0x06002CCA RID: 11466 RVA: 0x00013410 File Offset: 0x00011610
	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x836B50", Offset = "0x835950", VA = "0x180836B50")]
	public bool Contains(HitArea hitArea)
	{
		return default(bool);
	}

	// Token: 0x06002CCB RID: 11467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A6")]
	[Address(RVA = "0x484650", Offset = "0x483450", VA = "0x180484650")]
	public ArmorProperties()
	{
	}

	// Token: 0x040027A3 RID: 10147
	[Token(Token = "0x4002048")]
	[FieldOffset(Offset = "0x18")]
	[InspectorFlags]
	public HitArea area;
}
