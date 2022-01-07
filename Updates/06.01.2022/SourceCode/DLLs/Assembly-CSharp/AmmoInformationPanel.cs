using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000A11 RID: 2577
[Token(Token = "0x200073B")]
public class AmmoInformationPanel : ItemInformationPanel
{
	// Token: 0x06003CD3 RID: 15571 RVA: 0x00017EE0 File Offset: 0x000160E0
	[Token(Token = "0x6003365")]
	[Address(RVA = "0x82A890", Offset = "0x829690", VA = "0x18082A890", Slot = "4")]
	public override bool EligableForDisplay(ItemDefinition info)
	{
		return default(bool);
	}

	// Token: 0x06003CD4 RID: 15572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003366")]
	[Address(RVA = "0x82AA20", Offset = "0x829820", VA = "0x18082AA20", Slot = "5")]
	public override void SetupForItem(ItemDefinition info, [Optional] Item item)
	{
	}

	// Token: 0x06003CD5 RID: 15573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003367")]
	[Address(RVA = "0x2F6C50", Offset = "0x2F5A50", VA = "0x1802F6C50")]
	public AmmoInformationPanel()
	{
	}

	// Token: 0x040039F1 RID: 14833
	[Token(Token = "0x4002CB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ItemStatValue damageDisplay;

	// Token: 0x040039F2 RID: 14834
	[Token(Token = "0x4002CBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ItemStatValue velocityDisplay;

	// Token: 0x040039F3 RID: 14835
	[Token(Token = "0x4002CBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ItemStatValue spreadDisplay;

	// Token: 0x040039F4 RID: 14836
	[Token(Token = "0x4002CBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ItemTextValue pelletsDisplay;

	// Token: 0x040039F5 RID: 14837
	[Token(Token = "0x4002CBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ItemStatValue falloffRangeDisplay;

	// Token: 0x040039F6 RID: 14838
	[Token(Token = "0x4002CBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ItemTextValue thicknessDisplay;
}
