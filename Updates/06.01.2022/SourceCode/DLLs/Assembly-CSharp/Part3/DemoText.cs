using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x020009A0 RID: 2464
[Token(Token = "0x20006EC")]
public class DemoText : MonoBehaviour
{
	// Token: 0x06003A6B RID: 14955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003139")]
	[Address(RVA = "0x8D3C00", Offset = "0x8D2A00", VA = "0x1808D3C00")]
	private void Update()
	{
	}

	// Token: 0x06003A6C RID: 14956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600313A")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DemoText()
	{
	}

	// Token: 0x040036F5 RID: 14069
	[Token(Token = "0x4002A28")]
	[FieldOffset(Offset = "0x18")]
	public RustText TimeText;

	// Token: 0x040036F6 RID: 14070
	[Token(Token = "0x4002A29")]
	[FieldOffset(Offset = "0x20")]
	public RustText TotalSecondText;

	// Token: 0x040036F7 RID: 14071
	[Token(Token = "0x4002A2A")]
	[FieldOffset(Offset = "0x28")]
	public RustText TimeScaleText;

	// Token: 0x040036F8 RID: 14072
	[Token(Token = "0x4002A2B")]
	[FieldOffset(Offset = "0x30")]
	public RustText FilenameText;

	// Token: 0x040036F9 RID: 14073
	[Token(Token = "0x4002A2C")]
	[FieldOffset(Offset = "0x38")]
	public RustText DateTimeText;

	// Token: 0x040036FA RID: 14074
	[Token(Token = "0x4002A2D")]
	[FieldOffset(Offset = "0x40")]
	public RustText ParentText;

	// Token: 0x040036FB RID: 14075
	[Token(Token = "0x4002A2E")]
	[FieldOffset(Offset = "0x48")]
	public RustText DofText;

	// Token: 0x040036FC RID: 14076
	[Token(Token = "0x4002A2F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject InternalRoot;

	// Token: 0x040036FD RID: 14077
	[Token(Token = "0x4002A30")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ParentRoot;

	// Token: 0x040036FE RID: 14078
	[Token(Token = "0x4002A31")]
	[FieldOffset(Offset = "0x60")]
	public GameObject DofRoot;
}
