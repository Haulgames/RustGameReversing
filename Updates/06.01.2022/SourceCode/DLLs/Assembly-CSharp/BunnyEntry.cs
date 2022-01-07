using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001FD RID: 509
[Token(Token = "0x200014C")]
public class BunnyEntry : MonoBehaviour
{
	// Token: 0x0600175A RID: 5978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x641020", Offset = "0x63FE20", VA = "0x180641020")]
	public void UpdateText(string newName, int amount, bool isLocalPlayer = false)
	{
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x640F80", Offset = "0x63FD80", VA = "0x180640F80")]
	public void Clear()
	{
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001219")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BunnyEntry()
	{
	}

	// Token: 0x0400111F RID: 4383
	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x18")]
	public Text nameText;

	// Token: 0x04001120 RID: 4384
	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x20")]
	public Text amountText;

	// Token: 0x04001121 RID: 4385
	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0x28")]
	public RawImage starImage;

	// Token: 0x04001122 RID: 4386
	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x30")]
	public RawImage selfImage;
}
