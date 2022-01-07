using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A17 RID: 2583
[Token(Token = "0x2000741")]
public class BlueprintHeader : MonoBehaviour
{
	// Token: 0x06003CF9 RID: 15609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338B")]
	[Address(RVA = "0x45F550", Offset = "0x45E350", VA = "0x18045F550")]
	public void Setup(ItemCategory name, int unlocked, int total)
	{
	}

	// Token: 0x06003CFA RID: 15610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338C")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BlueprintHeader()
	{
	}

	// Token: 0x04003A24 RID: 14884
	[Token(Token = "0x4002CEC")]
	[FieldOffset(Offset = "0x18")]
	public Text categoryName;

	// Token: 0x04003A25 RID: 14885
	[Token(Token = "0x4002CED")]
	[FieldOffset(Offset = "0x20")]
	public Text unlockCount;
}
