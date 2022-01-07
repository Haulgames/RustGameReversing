using System;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000130 RID: 304
[Token(Token = "0x20000B2")]
public class Deployer : HeldEntity
{
	// Token: 0x060011ED RID: 4589 RVA: 0x0000A668 File Offset: 0x00008868
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0xB67B70", Offset = "0xB66970", VA = "0x180B67B70", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0xB67630", Offset = "0xB66430", VA = "0x180B67630")]
	public ItemModDeployable GetModDeployable()
	{
		return null;
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0xB67430", Offset = "0xB66230", VA = "0x180B67430")]
	public Deployable GetDeployable()
	{
		return null;
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0xB677F0", Offset = "0xB665F0", VA = "0x180B677F0", Slot = "139")]
	public override void OnDeploy()
	{
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D11")]
	[Address(RVA = "0xB68270", Offset = "0xB67070", VA = "0x180B68270")]
	private void UpdateGuide()
	{
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D12")]
	[Address(RVA = "0xB68060", Offset = "0xB66E60", VA = "0x180B68060")]
	private void UpdateGuide_Slot(BasePlayer player, Deployable deployable)
	{
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D13")]
	[Address(RVA = "0xB67C60", Offset = "0xB66A60", VA = "0x180B67C60")]
	private void UpdateGuide_Regular(BasePlayer player, Deployable deployable)
	{
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0xB678C0", Offset = "0xB666C0", VA = "0x180B678C0", Slot = "142")]
	public override void OnHolstered()
	{
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0xB678A0", Offset = "0xB666A0", VA = "0x180B678A0", Slot = "136")]
	public override void OnFrame()
	{
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0xB678E0", Offset = "0xB666E0", VA = "0x180B678E0", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x0000A680 File Offset: 0x00008880
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0xB67530", Offset = "0xB66330", VA = "0x180B67530")]
	public Quaternion GetDeployedRotation(Vector3 normal, Vector3 placeDir)
	{
		return default(Quaternion);
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x0000A698 File Offset: 0x00008898
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0xB676C0", Offset = "0xB664C0", VA = "0x180B676C0")]
	public bool IsPlacementAngleAcceptable(Vector3 pos, Quaternion rot)
	{
		return default(bool);
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x0000A6B0 File Offset: 0x000088B0
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0xB66F00", Offset = "0xB65D00", VA = "0x180B66F00")]
	public bool CheckPlacement(Deployable deployable, Ray ray, float fDistance)
	{
		return default(bool);
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0xB683D0", Offset = "0xB671D0", VA = "0x180B683D0")]
	public Deployer()
	{
	}

	// Token: 0x04000C47 RID: 3143
	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x1F0")]
	private string placementError;
}
