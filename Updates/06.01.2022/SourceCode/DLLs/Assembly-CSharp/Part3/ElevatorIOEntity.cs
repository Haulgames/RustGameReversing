using System;
using Il2CppDummyDll;

// Token: 0x020005AE RID: 1454
[Token(Token = "0x200043F")]
public class ElevatorIOEntity : IOEntity
{
	// Token: 0x0600290B RID: 10507 RVA: 0x00011E38 File Offset: 0x00010038
	[Token(Token = "0x600226C")]
	[Address(RVA = "0x98B2F0", Offset = "0x98A0F0", VA = "0x18098B2F0", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x0600290C RID: 10508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600226D")]
	[Address(RVA = "0x98D180", Offset = "0x98BF80", VA = "0x18098D180")]
	public ElevatorIOEntity()
	{
	}

	// Token: 0x0400249A RID: 9370
	[Token(Token = "0x4001DF6")]
	[FieldOffset(Offset = "0x268")]
	public int Consumption;
}
