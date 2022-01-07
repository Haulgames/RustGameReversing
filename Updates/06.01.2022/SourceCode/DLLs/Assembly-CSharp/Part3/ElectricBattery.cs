using System;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x2000101")]
public class ElectricBattery : global::IOEntity, IInstanceDataReceiver
{
	// Token: 0x060015AC RID: 5548 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "144")]
	public override bool IsRootEntity()
	{
		return default(bool);
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x98B2F0", Offset = "0x98A0F0", VA = "0x18098B2F0", Slot = "150")]
	public override int MaximalPowerOutput()
	{
		return 0;
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x98B260", Offset = "0x98A060", VA = "0x18098B260")]
	public int GetActiveDrain()
	{
		return 0;
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x98B300", Offset = "0x98A100", VA = "0x18098B300", Slot = "154")]
	public override void ProcessAdditionalData(int first, int second, float third, float fourth)
	{
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "158")]
	public void ReceiveInstanceData(ProtoBuf.Item.InstanceData data)
	{
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x98B290", Offset = "0x98A090", VA = "0x18098B290", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x98B360", Offset = "0x98A160", VA = "0x18098B360")]
	public ElectricBattery()
	{
	}

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000C3F")]
	[FieldOffset(Offset = "0x268")]
	public int maxOutput;

	// Token: 0x04000F54 RID: 3924
	[Token(Token = "0x4000C40")]
	[FieldOffset(Offset = "0x26C")]
	public float maxCapactiySeconds;

	// Token: 0x04000F55 RID: 3925
	[Token(Token = "0x4000C41")]
	[FieldOffset(Offset = "0x270")]
	public float rustWattSeconds;

	// Token: 0x04000F56 RID: 3926
	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x274")]
	private int activeDrain;

	// Token: 0x04000F57 RID: 3927
	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x278")]
	public bool rechargable;

	// Token: 0x04000F58 RID: 3928
	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x27C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x9DEC0", Offset = "0x9D2C0")]
	public float maximumInboundEnergyRatio;

	// Token: 0x04000F59 RID: 3929
	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x280")]
	public float chargeRatio;

	// Token: 0x04000F5A RID: 3930
	[Token(Token = "0x4000C46")]
	private const float tickRateSeconds = 1f;

	// Token: 0x04000F5B RID: 3931
	[Token(Token = "0x4000C47")]
	public const global::BaseEntity.Flags Flag_HalfFull = global::BaseEntity.Flags.Reserved5;

	// Token: 0x04000F5C RID: 3932
	[Token(Token = "0x4000C48")]
	public const global::BaseEntity.Flags Flag_VeryFull = global::BaseEntity.Flags.Reserved6;
}
