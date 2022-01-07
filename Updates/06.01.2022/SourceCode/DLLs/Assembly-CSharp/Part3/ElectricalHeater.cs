using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x020001AC RID: 428
[Token(Token = "0x2000106")]
public class ElectricalHeater : global::IOEntity
{
	// Token: 0x060015BA RID: 5562 RVA: 0x0000C030 File Offset: 0x0000A230
	[Token(Token = "0x6001085")]
	[Address(RVA = "0x98CE10", Offset = "0x98BC10", VA = "0x18098CE10", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x98D060", Offset = "0x98BE60", VA = "0x18098D060", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x98CDC0", Offset = "0x98BBC0", VA = "0x18098CDC0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001088")]
	[Address(RVA = "0x98CFB0", Offset = "0x98BDB0", VA = "0x18098CFB0", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x98CE20", Offset = "0x98BC20", VA = "0x18098CE20")]
	public void LightLerp()
	{
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108A")]
	[Address(RVA = "0x98D120", Offset = "0x98BF20", VA = "0x18098D120")]
	public ElectricalHeater()
	{
	}

	// Token: 0x04000F63 RID: 3939
	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x268")]
	public float fadeDuration;

	// Token: 0x04000F64 RID: 3940
	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x270")]
	public Light sourceLight;

	// Token: 0x04000F65 RID: 3941
	[Token(Token = "0x4000C51")]
	[FieldOffset(Offset = "0x278")]
	public GrowableHeatSource growableHeatSource;

	// Token: 0x04000F66 RID: 3942
	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0x280")]
	private float initialIntensity;

	// Token: 0x04000F67 RID: 3943
	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0x284")]
	private float currentScale;

	// Token: 0x04000F68 RID: 3944
	[Token(Token = "0x4000C54")]
	[FieldOffset(Offset = "0x288")]
	private bool wasOn;
}
