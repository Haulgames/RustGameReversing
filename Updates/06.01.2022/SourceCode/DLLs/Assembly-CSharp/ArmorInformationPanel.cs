using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000A12 RID: 2578
[Token(Token = "0x200073C")]
public class ArmorInformationPanel : ItemInformationPanel
{
	// Token: 0x06003CD6 RID: 15574 RVA: 0x00017EF8 File Offset: 0x000160F8
	[Token(Token = "0x6003368")]
	[Address(RVA = "0x836360", Offset = "0x835160", VA = "0x180836360", Slot = "4")]
	public override bool EligableForDisplay(ItemDefinition info)
	{
		return default(bool);
	}

	// Token: 0x06003CD7 RID: 15575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003369")]
	[Address(RVA = "0x836440", Offset = "0x835240", VA = "0x180836440")]
	public string ProtectionAreaText(ItemModWearable wearable)
	{
		return null;
	}

	// Token: 0x06003CD8 RID: 15576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336A")]
	[Address(RVA = "0x836550", Offset = "0x835350", VA = "0x180836550", Slot = "5")]
	public override void SetupForItem(ItemDefinition info, [Optional] Item item)
	{
	}

	// Token: 0x06003CD9 RID: 15577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336B")]
	[Address(RVA = "0x2F6C50", Offset = "0x2F5A50", VA = "0x1802F6C50")]
	public ArmorInformationPanel()
	{
	}

	// Token: 0x040039F7 RID: 14839
	[Token(Token = "0x4002CBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ItemTextValue projectileDisplay;

	// Token: 0x040039F8 RID: 14840
	[Token(Token = "0x4002CC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ItemTextValue meleeDisplay;

	// Token: 0x040039F9 RID: 14841
	[Token(Token = "0x4002CC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ItemTextValue coldDisplay;

	// Token: 0x040039FA RID: 14842
	[Token(Token = "0x4002CC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ItemTextValue explosionDisplay;

	// Token: 0x040039FB RID: 14843
	[Token(Token = "0x4002CC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ItemTextValue radiationDisplay;

	// Token: 0x040039FC RID: 14844
	[Token(Token = "0x4002CC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ItemTextValue biteDisplay;

	// Token: 0x040039FD RID: 14845
	[Token(Token = "0x4002CC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ItemTextValue spacer;

	// Token: 0x040039FE RID: 14846
	[Token(Token = "0x4002CC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text areaProtectionText;

	// Token: 0x040039FF RID: 14847
	[Token(Token = "0x4002CC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Translate.Phrase LegText;

	// Token: 0x04003A00 RID: 14848
	[Token(Token = "0x4002CC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Translate.Phrase ChestText;

	// Token: 0x04003A01 RID: 14849
	[Token(Token = "0x4002CC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Translate.Phrase HeadText;

	// Token: 0x04003A02 RID: 14850
	[Token(Token = "0x4002CCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Translate.Phrase ChestLegsText;

	// Token: 0x04003A03 RID: 14851
	[Token(Token = "0x4002CCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Translate.Phrase WholeBodyText;

	// Token: 0x04003A04 RID: 14852
	[Token(Token = "0x4002CCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ItemTextValue eggVision;
}
