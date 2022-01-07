using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x020001C4 RID: 452
[Token(Token = "0x200011B")]
public class BranchConfig : UIDialog
{
	// Token: 0x06001605 RID: 5637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x46B2A0", Offset = "0x46A0A0", VA = "0x18046B2A0", Slot = "8")]
	public override void OpenDialog()
	{
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x46B380", Offset = "0x46A180", VA = "0x18046B380")]
	public void SetBranch(ElectricalBranch newSwitch)
	{
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x46B0A0", Offset = "0x469EA0", VA = "0x18046B0A0")]
	public void Confirm()
	{
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x46B2E0", Offset = "0x46A0E0", VA = "0x18046B2E0")]
	public void SelectTextField()
	{
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x0000C210 File Offset: 0x0000A410
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x46B150", Offset = "0x469F50", VA = "0x18046B150")]
	public int GetIntValue()
	{
		return 0;
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x46B420", Offset = "0x46A220", VA = "0x18046B420")]
	public void ValueChanged()
	{
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x46B080", Offset = "0x469E80", VA = "0x18046B080")]
	public void Cancel()
	{
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x46B1E0", Offset = "0x469FE0", VA = "0x18046B1E0")]
	public void OnTextFieldEnd()
	{
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x46B490", Offset = "0x46A290", VA = "0x18046B490")]
	public BranchConfig()
	{
	}

	// Token: 0x04000FB9 RID: 4025
	[Token(Token = "0x4000C98")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	private ElectricalBranch branch;

	// Token: 0x04000FBA RID: 4026
	[Token(Token = "0x4000C99")]
	[FieldOffset(Offset = "0x38")]
	public InputField input;

	// Token: 0x04000FBB RID: 4027
	[Token(Token = "0x4000C9A")]
	[FieldOffset(Offset = "0x40")]
	public int target;
}
