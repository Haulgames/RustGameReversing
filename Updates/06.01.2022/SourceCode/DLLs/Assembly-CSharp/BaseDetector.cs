using System;
using Il2CppDummyDll;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x2000102")]
public class BaseDetector : IOEntity
{
	// Token: 0x060015B4 RID: 5556 RVA: 0x0000C000 File Offset: 0x0000A200
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x886710", Offset = "0x885510", VA = "0x180886710", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001080")]
	[Address(RVA = "0x886720", Offset = "0x885520", VA = "0x180886720")]
	public BaseDetector()
	{
	}

	// Token: 0x04000F5D RID: 3933
	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x268")]
	public PlayerDetectionTrigger myTrigger;

	// Token: 0x04000F5E RID: 3934
	[Token(Token = "0x4000C4A")]
	public const BaseEntity.Flags Flag_HasContents = BaseEntity.Flags.Reserved1;
}
