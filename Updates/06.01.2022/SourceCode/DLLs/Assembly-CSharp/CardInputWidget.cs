using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x020009A9 RID: 2473
[Token(Token = "0x20006F2")]
public class CardInputWidget : MonoBehaviour
{
	// Token: 0x06003A92 RID: 14994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600315E")]
	[Address(RVA = "0x64ED80", Offset = "0x64DB80", VA = "0x18064ED80")]
	public void Populate(KeyCode key, Translate.Phrase display, string extra)
	{
	}

	// Token: 0x06003A93 RID: 14995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600315F")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public CardInputWidget()
	{
	}

	// Token: 0x04003721 RID: 14113
	[Token(Token = "0x4002A49")]
	[FieldOffset(Offset = "0x18")]
	public RustText InputText;

	// Token: 0x04003722 RID: 14114
	[Token(Token = "0x4002A4A")]
	[FieldOffset(Offset = "0x20")]
	public RustText ActionText;

	// Token: 0x04003723 RID: 14115
	[Token(Token = "0x4002A4B")]
	[FieldOffset(Offset = "0x28")]
	public RustText ExtraText;

	// Token: 0x04003724 RID: 14116
	[Token(Token = "0x4002A4C")]
	[FieldOffset(Offset = "0x30")]
	private KeyCode lastKey;
}
