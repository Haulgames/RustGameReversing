using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000A18 RID: 2584
[Token(Token = "0x2000742")]
public class CraftingNotice : MonoBehaviour
{
	// Token: 0x06003CFB RID: 15611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338D")]
	[Address(RVA = "0x6D7AD0", Offset = "0x6D68D0", VA = "0x1806D7AD0")]
	private void Update()
	{
	}

	// Token: 0x06003CFC RID: 15612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338E")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public CraftingNotice()
	{
	}

	// Token: 0x04003A26 RID: 14886
	[Token(Token = "0x4002CEE")]
	[FieldOffset(Offset = "0x18")]
	public CanvasGroup canvasGroup;

	// Token: 0x04003A27 RID: 14887
	[Token(Token = "0x4002CEF")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI itemName;

	// Token: 0x04003A28 RID: 14888
	[Token(Token = "0x4002CF0")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI craftSeconds;
}
