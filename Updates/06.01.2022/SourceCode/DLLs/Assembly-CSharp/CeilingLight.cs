using System;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000123 RID: 291
[Token(Token = "0x20000AB")]
public class CeilingLight : global::IOEntity
{
	// Token: 0x06001168 RID: 4456 RVA: 0x0000A3B0 File Offset: 0x000085B0
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x4D6670", Offset = "0x4D5470", VA = "0x1804D6670", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x0000A3C8 File Offset: 0x000085C8
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x4D6500", Offset = "0x4D5300", VA = "0x1804D6500", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x4D6510", Offset = "0x4D5310", VA = "0x1804D6510", Slot = "115")]
	public override void OnAttacked(HitInfo info)
	{
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x4D62B0", Offset = "0x4D50B0", VA = "0x1804D62B0")]
	[global::BaseEntity.RPC_Client]
	public void ClientPhysPush(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x4D6AC0", Offset = "0x4D58C0", VA = "0x1804D6AC0")]
	public void PhysPush(Vector3 attackNormal, Vector3 hitPositionWorld)
	{
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x4D6200", Offset = "0x4D5000", VA = "0x1804D6200", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x4D6C30", Offset = "0x4D5A30", VA = "0x1804D6C30")]
	public CeilingLight()
	{
	}

	// Token: 0x04000BE9 RID: 3049
	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x268")]
	public float pushScale;
}
