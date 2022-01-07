using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200095D RID: 2397
[Token(Token = "0x20006B3")]
public class EnumListUI : MonoBehaviour
{
	// Token: 0x0600391E RID: 14622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003014")]
	[Address(RVA = "0x44C190", Offset = "0x44AF90", VA = "0x18044C190")]
	private void Awake()
	{
	}

	// Token: 0x0600391F RID: 14623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003015")]
	[Address(RVA = "0x851750", Offset = "0x850550", VA = "0x180851750")]
	public void Show(List<object> values, Action<object> clicked)
	{
	}

	// Token: 0x06003920 RID: 14624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003016")]
	[Address(RVA = "0x8516E0", Offset = "0x8504E0", VA = "0x1808516E0")]
	public void ItemClicked(object value)
	{
	}

	// Token: 0x06003921 RID: 14625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003017")]
	[Address(RVA = "0x44C190", Offset = "0x44AF90", VA = "0x18044C190")]
	public void Hide()
	{
	}

	// Token: 0x06003922 RID: 14626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003018")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public EnumListUI()
	{
	}

	// Token: 0x0400362A RID: 13866
	[Token(Token = "0x400297A")]
	[FieldOffset(Offset = "0x18")]
	public Transform PrefabItem;

	// Token: 0x0400362B RID: 13867
	[Token(Token = "0x400297B")]
	[FieldOffset(Offset = "0x20")]
	public Transform Container;

	// Token: 0x0400362C RID: 13868
	[Token(Token = "0x400297C")]
	[FieldOffset(Offset = "0x28")]
	private Action<object> clickedAction;

	// Token: 0x0400362D RID: 13869
	[Token(Token = "0x400297D")]
	[FieldOffset(Offset = "0x30")]
	private CanvasScaler canvasScaler;
}
