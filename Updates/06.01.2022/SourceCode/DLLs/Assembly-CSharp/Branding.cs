using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200097D RID: 2429
[Token(Token = "0x20006CF")]
public class Branding : BaseMonoBehaviour
{
	// Token: 0x0600399D RID: 14749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003081")]
	[Address(RVA = "0x46B4A0", Offset = "0x46A2A0", VA = "0x18046B4A0")]
	private void Update()
	{
	}

	// Token: 0x0600399E RID: 14750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003082")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public Branding()
	{
	}

	// Token: 0x04003661 RID: 13921
	[Token(Token = "0x40029A6")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI versionText;

	// Token: 0x04003662 RID: 13922
	[Token(Token = "0x40029A7")]
	[FieldOffset(Offset = "0x20")]
	public CanvasGroup canvasGroup;

	// Token: 0x04003663 RID: 13923
	[Token(Token = "0x40029A8")]
	[FieldOffset(Offset = "0x28")]
	private string oldChangeId;
}
