using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A24 RID: 2596
[Token(Token = "0x2000747")]
public class ConsumableInformationPanel : ItemInformationPanel
{
	// Token: 0x06003D58 RID: 15704 RVA: 0x00018108 File Offset: 0x00016308
	[Token(Token = "0x60033D3")]
	[Address(RVA = "0x6CDBF0", Offset = "0x6CC9F0", VA = "0x1806CDBF0", Slot = "4")]
	public override bool EligableForDisplay(ItemDefinition info)
	{
		return default(bool);
	}

	// Token: 0x06003D59 RID: 15705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D4")]
	[Address(RVA = "0x6CDDA0", Offset = "0x6CCBA0", VA = "0x1806CDDA0")]
	private void GetValues()
	{
	}

	// Token: 0x06003D5A RID: 15706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D5")]
	[Address(RVA = "0x6CDE10", Offset = "0x6CCC10", VA = "0x1806CDE10", Slot = "5")]
	public override void SetupForItem(ItemDefinition info, [Optional] Item item)
	{
	}

	// Token: 0x06003D5B RID: 15707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D6")]
	[Address(RVA = "0x6CE770", Offset = "0x6CD570", VA = "0x1806CE770")]
	private void SetupGenes(Item item)
	{
	}

	// Token: 0x06003D5C RID: 15708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D7")]
	[Address(RVA = "0x6CE7F0", Offset = "0x6CD5F0", VA = "0x1806CE7F0")]
	public ConsumableInformationPanel()
	{
	}

	// Token: 0x04003A6C RID: 14956
	[Token(Token = "0x4002D23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ItemTextValue[] values;

	// Token: 0x04003A6D RID: 14957
	[Token(Token = "0x4002D24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UIGenesDisplay Genes;

	// Token: 0x04003A6E RID: 14958
	[Token(Token = "0x4002D25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text TextUnknownGenetics;

	// Token: 0x04003A6F RID: 14959
	[Token(Token = "0x4002D26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text LabelGenetics;

	// Token: 0x04003A70 RID: 14960
	[Token(Token = "0x4002D27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject GeneticsGameObject;

	// Token: 0x04003A71 RID: 14961
	[Token(Token = "0x4002D28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ItemTextValue durationValue;

	// Token: 0x04003A72 RID: 14962
	[Token(Token = "0x4002D29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ItemTextValue baitValue;

	// Token: 0x04003A73 RID: 14963
	[Token(Token = "0x4002D2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrowableGenes genes;
}
