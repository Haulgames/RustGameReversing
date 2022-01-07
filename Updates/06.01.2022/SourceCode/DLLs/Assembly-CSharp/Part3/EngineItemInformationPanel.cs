using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A27 RID: 2599
[Token(Token = "0x2000749")]
public class EngineItemInformationPanel : ItemInformationPanel
{
	// Token: 0x06003D60 RID: 15712 RVA: 0x00018120 File Offset: 0x00016320
	[Token(Token = "0x60033DA")]
	[Address(RVA = "0x992830", Offset = "0x991630", VA = "0x180992830", Slot = "4")]
	public override bool EligableForDisplay(ItemDefinition info)
	{
		return default(bool);
	}

	// Token: 0x06003D61 RID: 15713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033DB")]
	[Address(RVA = "0x9928B0", Offset = "0x9916B0", VA = "0x1809928B0", Slot = "5")]
	public override void SetupForItem(ItemDefinition info, [Optional] Item item)
	{
	}

	// Token: 0x06003D62 RID: 15714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033DC")]
	[Address(RVA = "0x2F6C50", Offset = "0x2F5A50", VA = "0x1802F6C50")]
	public EngineItemInformationPanel()
	{
	}

	// Token: 0x04003A75 RID: 14965
	[Token(Token = "0x4002D2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text tier;

	// Token: 0x04003A76 RID: 14966
	[Token(Token = "0x4002D2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Translate.Phrase low;

	// Token: 0x04003A77 RID: 14967
	[Token(Token = "0x4002D2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Translate.Phrase medium;

	// Token: 0x04003A78 RID: 14968
	[Token(Token = "0x4002D2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Translate.Phrase high;

	// Token: 0x04003A79 RID: 14969
	[Token(Token = "0x4002D30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject accelerationRoot;

	// Token: 0x04003A7A RID: 14970
	[Token(Token = "0x4002D31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject topSpeedRoot;

	// Token: 0x04003A7B RID: 14971
	[Token(Token = "0x4002D32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject fuelEconomyRoot;
}
