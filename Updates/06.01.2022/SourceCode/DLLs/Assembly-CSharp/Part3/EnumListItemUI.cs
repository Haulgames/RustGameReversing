using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x0200095C RID: 2396
[Token(Token = "0x20006B2")]
public class EnumListItemUI : MonoBehaviour
{
	// Token: 0x0600391B RID: 14619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003011")]
	[Address(RVA = "0x851680", Offset = "0x850480", VA = "0x180851680")]
	public void Init(object value, string valueText, EnumListUI list)
	{
	}

	// Token: 0x0600391C RID: 14620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003012")]
	[Address(RVA = "0x851600", Offset = "0x850400", VA = "0x180851600")]
	public void Clicked()
	{
	}

	// Token: 0x0600391D RID: 14621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003013")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public EnumListItemUI()
	{
	}

	// Token: 0x04003627 RID: 13863
	[Token(Token = "0x4002977")]
	[FieldOffset(Offset = "0x18")]
	public object Value;

	// Token: 0x04003628 RID: 13864
	[Token(Token = "0x4002978")]
	[FieldOffset(Offset = "0x20")]
	public RustText TextValue;

	// Token: 0x04003629 RID: 13865
	[Token(Token = "0x4002979")]
	[FieldOffset(Offset = "0x28")]
	private EnumListUI list;
}
