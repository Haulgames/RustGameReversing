using System;
using Il2CppDummyDll;

// Token: 0x020005AD RID: 1453
[Token(Token = "0x200043E")]
public class ElectricGenerator : IOEntity
{
	// Token: 0x06002906 RID: 10502 RVA: 0x00011DF0 File Offset: 0x0000FFF0
	[Token(Token = "0x6002267")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "144")]
	public override bool IsRootEntity()
	{
		return default(bool);
	}

	// Token: 0x06002907 RID: 10503 RVA: 0x00011E08 File Offset: 0x00010008
	[Token(Token = "0x6002268")]
	[Address(RVA = "0x98B3D0", Offset = "0x98A1D0", VA = "0x18098B3D0", Slot = "150")]
	public override int MaximalPowerOutput()
	{
		return 0;
	}

	// Token: 0x06002908 RID: 10504 RVA: 0x00011E20 File Offset: 0x00010020
	[Token(Token = "0x6002269")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x06002909 RID: 10505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600226A")]
	[Address(RVA = "0x6CFC60", Offset = "0x6CEA60", VA = "0x1806CFC60", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x0600290A RID: 10506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600226B")]
	[Address(RVA = "0x98B440", Offset = "0x98A240", VA = "0x18098B440")]
	public ElectricGenerator()
	{
	}

	// Token: 0x04002499 RID: 9369
	[Token(Token = "0x4001DF5")]
	[FieldOffset(Offset = "0x268")]
	public float electricAmount;
}
