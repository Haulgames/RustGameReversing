using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001C1 RID: 449
[Token(Token = "0x2000119")]
public class AddSellOrderManager : MonoBehaviour
{
	// Token: 0x060015EF RID: 5615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x81F320", Offset = "0x81E120", VA = "0x18081F320")]
	public void ItemSelectionMade(ItemDefinition info, bool asBP)
	{
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x81F8A0", Offset = "0x81E6A0", VA = "0x18081F8A0")]
	public void Search(string search)
	{
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x0000C180 File Offset: 0x0000A380
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x81F180", Offset = "0x81DF80", VA = "0x18081F180")]
	private bool IsValidSearchResult(string search, ItemDefinition target)
	{
		return default(bool);
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x0000C198 File Offset: 0x0000A398
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x81F610", Offset = "0x81E410", VA = "0x18081F610")]
	private float ScoreSearchResult(string search, ItemDefinition target)
	{
		return 0f;
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x81F510", Offset = "0x81E310", VA = "0x18081F510")]
	public void OnSellSearchChanged()
	{
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x81F480", Offset = "0x81E280", VA = "0x18081F480")]
	public void OnCurrencySearchChanged()
	{
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void OnSellSearchComplete()
	{
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x81EBC0", Offset = "0x81D9C0", VA = "0x18081EBC0")]
	public void AddSellOrder()
	{
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x81F5A0", Offset = "0x81E3A0", VA = "0x18081F5A0")]
	public void ResetSellOrderObjects()
	{
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x81F470", Offset = "0x81E270", VA = "0x18081F470")]
	public void OnAmountTextChanged()
	{
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x81EE50", Offset = "0x81DC50", VA = "0x18081EE50")]
	public void ClampAmountValues()
	{
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x81EFF0", Offset = "0x81DDF0", VA = "0x18081EFF0")]
	public int ClampedAmountValue(string amount, ItemDefinition itemDef, bool limitToStackable = true)
	{
		return 0;
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x81F150", Offset = "0x81DF50", VA = "0x18081F150")]
	public int GetIntAmount(string text)
	{
		return 0;
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x81F0D0", Offset = "0x81DED0", VA = "0x18081F0D0")]
	public void CurrencyPlusMinus(int delta)
	{
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x81FC30", Offset = "0x81EA30", VA = "0x18081FC30")]
	public void SellItemPlusMinus(int delta)
	{
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public AddSellOrderManager()
	{
	}

	// Token: 0x04000FAA RID: 4010
	[Token(Token = "0x4000C8B")]
	[FieldOffset(Offset = "0x18")]
	public VirtualItemIcon sellItemIcon;

	// Token: 0x04000FAB RID: 4011
	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0x20")]
	public VirtualItemIcon currencyItemIcon;

	// Token: 0x04000FAC RID: 4012
	[Token(Token = "0x4000C8D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject itemSearchParent;

	// Token: 0x04000FAD RID: 4013
	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0x30")]
	public ItemSearchEntry itemSearchEntryPrefab;

	// Token: 0x04000FAE RID: 4014
	[Token(Token = "0x4000C8F")]
	[FieldOffset(Offset = "0x38")]
	public InputField sellItemInput;

	// Token: 0x04000FAF RID: 4015
	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0x40")]
	public InputField sellItemAmount;

	// Token: 0x04000FB0 RID: 4016
	[Token(Token = "0x4000C91")]
	[FieldOffset(Offset = "0x48")]
	public InputField currencyItemInput;

	// Token: 0x04000FB1 RID: 4017
	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0x50")]
	public InputField currencyItemAmount;

	// Token: 0x04000FB2 RID: 4018
	[Token(Token = "0x4000C93")]
	[FieldOffset(Offset = "0x58")]
	public VendingPanelAdmin adminPanel;

	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x2000ADE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x060015FF RID: 5631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB7")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		[Token(Token = "0x6004CB8")]
		[Address(RVA = "0x82FE10", Offset = "0x82EC10", VA = "0x18082FE10")]
		internal bool <Search>b__0(ItemDefinition x)
		{
			return default(bool);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x6004CB9")]
		[Address(RVA = "0x82FFC0", Offset = "0x82EDC0", VA = "0x18082FFC0")]
		internal float <Search>b__1(ItemDefinition y)
		{
			return 0f;
		}

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x400403D")]
		[FieldOffset(Offset = "0x10")]
		public AddSellOrderManager <>4__this;

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x400403E")]
		[FieldOffset(Offset = "0x18")]
		public string search;
	}
}
