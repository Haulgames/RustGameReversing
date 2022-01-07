using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E7 RID: 999
[Token(Token = "0x20002CE")]
public class DevDressPlayer : MonoBehaviour
{
	// Token: 0x060020F4 RID: 8436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DevDressPlayer()
	{
	}

	// Token: 0x04001BAD RID: 7085
	[Token(Token = "0x4001689")]
	[FieldOffset(Offset = "0x18")]
	public bool DressRandomly;

	// Token: 0x04001BAE RID: 7086
	[Token(Token = "0x400168A")]
	[FieldOffset(Offset = "0x20")]
	public List<ItemAmount> clothesToWear;
}
