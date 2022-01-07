using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x020001C5 RID: 453
[Token(Token = "0x200011C")]
public class CounterConfig : UIDialog
{
	// Token: 0x0600160E RID: 5646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x46B2A0", Offset = "0x46A0A0", VA = "0x18046B2A0", Slot = "8")]
	public override void OpenDialog()
	{
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x6D4150", Offset = "0x6D2F50", VA = "0x1806D4150")]
	public void SetCounter(PowerCounter newSwitch)
	{
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x6D3EB0", Offset = "0x6D2CB0", VA = "0x1806D3EB0")]
	public void Confirm()
	{
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x6D40B0", Offset = "0x6D2EB0", VA = "0x1806D40B0")]
	public void SelectTextField()
	{
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x0000C228 File Offset: 0x0000A428
	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x6D3F60", Offset = "0x6D2D60", VA = "0x1806D3F60")]
	public int GetIntValue()
	{
		return 0;
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x6D41F0", Offset = "0x6D2FF0", VA = "0x1806D41F0")]
	public void ValueChanged()
	{
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x46B080", Offset = "0x469E80", VA = "0x18046B080")]
	public void Cancel()
	{
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D9")]
	[Address(RVA = "0x6D3FF0", Offset = "0x6D2DF0", VA = "0x1806D3FF0")]
	public void OnTextFieldEnd()
	{
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x46B490", Offset = "0x46A290", VA = "0x18046B490")]
	public CounterConfig()
	{
	}

	// Token: 0x04000FBC RID: 4028
	[Token(Token = "0x4000C9B")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	private PowerCounter powerCounter;

	// Token: 0x04000FBD RID: 4029
	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0x38")]
	public InputField input;

	// Token: 0x04000FBE RID: 4030
	[Token(Token = "0x4000C9D")]
	[FieldOffset(Offset = "0x40")]
	public int target;
}
