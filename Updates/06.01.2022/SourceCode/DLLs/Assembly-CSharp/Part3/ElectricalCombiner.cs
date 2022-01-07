using System;
using Il2CppDummyDll;

// Token: 0x020001AF RID: 431
[Token(Token = "0x2000109")]
public class ElectricalCombiner : IOEntity
{
	// Token: 0x060015C2 RID: 5570 RVA: 0x0000C048 File Offset: 0x0000A248
	[Token(Token = "0x600108D")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "144")]
	public override bool IsRootEntity()
	{
		return default(bool);
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108E")]
	[Address(RVA = "0x98CD00", Offset = "0x98BB00", VA = "0x18098CD00")]
	public ElectricalCombiner()
	{
	}

	// Token: 0x04000F6A RID: 3946
	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0x268")]
	public int input1Amount;

	// Token: 0x04000F6B RID: 3947
	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0x26C")]
	public int input2Amount;

	// Token: 0x04000F6C RID: 3948
	[Token(Token = "0x4000C58")]
	[FieldOffset(Offset = "0x270")]
	public int input3Amount;
}
