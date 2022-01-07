using System;
using Il2CppDummyDll;
using Rust.UI;

// Token: 0x02000A86 RID: 2694
[Token(Token = "0x200078D")]
public class DemoItem : RustButton
{
	// Token: 0x06003F85 RID: 16261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C8")]
	[Address(RVA = "0x8C8B90", Offset = "0x8C7990", VA = "0x1808C8B90")]
	public void OnClicked()
	{
	}

	// Token: 0x06003F86 RID: 16262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C9")]
	[Address(RVA = "0x8C8A70", Offset = "0x8C7870", VA = "0x1808C8A70", Slot = "30")]
	protected override void ApplyStyle(StyleAsset.Group s)
	{
	}

	// Token: 0x06003F87 RID: 16263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CA")]
	[Address(RVA = "0x642CF0", Offset = "0x641AF0", VA = "0x180642CF0")]
	public DemoItem()
	{
	}

	// Token: 0x04003CE3 RID: 15587
	[Token(Token = "0x4002F23")]
	[FieldOffset(Offset = "0x98")]
	public Demos demos;

	// Token: 0x04003CE4 RID: 15588
	[Token(Token = "0x4002F24")]
	[FieldOffset(Offset = "0xA0")]
	public int itemId;

	// Token: 0x04003CE5 RID: 15589
	[Token(Token = "0x4002F25")]
	[FieldOffset(Offset = "0xA8")]
	public RustText nameText;

	// Token: 0x04003CE6 RID: 15590
	[Token(Token = "0x4002F26")]
	[FieldOffset(Offset = "0xB0")]
	public RustText dateText;

	// Token: 0x04003CE7 RID: 15591
	[Token(Token = "0x4002F27")]
	[FieldOffset(Offset = "0xB8")]
	public RustText lengthText;
}
