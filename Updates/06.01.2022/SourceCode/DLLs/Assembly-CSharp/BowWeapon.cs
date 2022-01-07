using System;
using Il2CppDummyDll;
using Network;
using ProtoBuf;

// Token: 0x02000116 RID: 278
[Token(Token = "0x20000A5")]
public class BowWeapon : global::BaseProjectile
{
	// Token: 0x060010E9 RID: 4329 RVA: 0x0000A068 File Offset: 0x00008268
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x467AB0", Offset = "0x4668B0", VA = "0x180467AB0", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x467210", Offset = "0x466010", VA = "0x180467210", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x467BA0", Offset = "0x4669A0", VA = "0x180467BA0", Slot = "83")]
	public override void OnSignal(global::BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x467FF0", Offset = "0x466DF0", VA = "0x180467FF0")]
	public void UpdatePullbackThink()
	{
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x4671A0", Offset = "0x465FA0", VA = "0x1804671A0")]
	public void CancelPullbackThink()
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x467EB0", Offset = "0x466CB0", VA = "0x180467EB0")]
	public void PullbackThink()
	{
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x467730", Offset = "0x466530", VA = "0x180467730", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x4676F0", Offset = "0x4664F0", VA = "0x1804676F0", Slot = "142")]
	public override void OnHolstered()
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C34")]
	[Address(RVA = "0x467280", Offset = "0x466080", VA = "0x180467280", Slot = "170")]
	public override void DoAttack()
	{
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x0000A080 File Offset: 0x00008280
	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x467520", Offset = "0x466320", VA = "0x180467520")]
	public bool IsAiming()
	{
		return default(bool);
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x467D10", Offset = "0x466B10", VA = "0x180467D10", Slot = "143")]
	public override void OnViewmodelEvent(string name)
	{
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x4675C0", Offset = "0x4663C0", VA = "0x1804675C0", Slot = "136")]
	public override void OnFrame()
	{
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x467D80", Offset = "0x466B80", VA = "0x180467D80", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x467F80", Offset = "0x466D80", VA = "0x180467F80")]
	private void TryReload()
	{
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0x467E20", Offset = "0x466C20", VA = "0x180467E20", Slot = "151")]
	public override void ProcessSpectatorViewmodel(ViewModel vm)
	{
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x2EF5E0", Offset = "0x2EE3E0", VA = "0x1802EF5E0")]
	public BowWeapon()
	{
	}

	// Token: 0x04000B4C RID: 2892
	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x360")]
	protected bool attackReady;

	// Token: 0x04000B4D RID: 2893
	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0x364")]
	private float arrowBack;

	// Token: 0x04000B4E RID: 2894
	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x368")]
	private SwapArrows swapArrows;

	// Token: 0x04000B4F RID: 2895
	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x370")]
	private bool wasAiming;
}
