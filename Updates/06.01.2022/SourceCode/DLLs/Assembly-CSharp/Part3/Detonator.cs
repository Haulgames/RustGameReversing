using System;
using Il2CppDummyDll;
using Network;

// Token: 0x02000131 RID: 305
[Token(Token = "0x20000B3")]
public class Detonator : HeldEntity, IRFObject
{
	// Token: 0x060011FB RID: 4603 RVA: 0x0000A6C8 File Offset: 0x000088C8
	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0xB69B10", Offset = "0xB68910", VA = "0x180B69B10", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x0000A6E0 File Offset: 0x000088E0
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0xB69650", Offset = "0xB68450", VA = "0x180B69650", Slot = "158")]
	public virtual bool IsFullyDeployed()
	{
		return default(bool);
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0xB69DB0", Offset = "0xB68BB0", VA = "0x180B69DB0")]
	protected void ProcessInputTime()
	{
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0xB696D0", Offset = "0xB684D0", VA = "0x180B696D0", Slot = "139")]
	public override void OnDeploy()
	{
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0xB696F0", Offset = "0xB684F0", VA = "0x180B696F0", Slot = "142")]
	public override void OnHolstered()
	{
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D20")]
	[Address(RVA = "0xB69CD0", Offset = "0xB68AD0", VA = "0x180B69CD0")]
	private void OpenConfigPanel()
	{
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0xB69750", Offset = "0xB68550", VA = "0x180B69750", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void BeginSounds()
	{
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D23")]
	[Address(RVA = "0xB69C00", Offset = "0xB68A00", VA = "0x180B69C00", Slot = "143")]
	public override void OnViewmodelEvent(string name)
	{
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D24")]
	[Address(RVA = "0xB69670", Offset = "0xB68470", VA = "0x180B69670", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x0000A6F8 File Offset: 0x000088F8
	[Token(Token = "0x6000D25")]
	[Address(RVA = "0xB69640", Offset = "0xB68440", VA = "0x180B69640", Slot = "157")]
	public int GetFrequency()
	{
		return 0;
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D26")]
	[Address(RVA = "0xB695F0", Offset = "0xB683F0", VA = "0x180B695F0", Slot = "156")]
	public void ClientSetFrequency(int newFreq)
	{
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D27")]
	[Address(RVA = "0xB69DF0", Offset = "0xB68BF0", VA = "0x180B69DF0")]
	public Detonator()
	{
	}

	// Token: 0x04000C48 RID: 3144
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x1F0")]
	public int frequency;

	// Token: 0x04000C49 RID: 3145
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x1F4")]
	private float timeSinceDeploy;

	// Token: 0x04000C4A RID: 3146
	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObjectRef frequencyPanelPrefab;

	// Token: 0x04000C4B RID: 3147
	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x200")]
	public GameObjectRef attackEffect;

	// Token: 0x04000C4C RID: 3148
	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x208")]
	public GameObjectRef unAttackEffect;

	// Token: 0x04000C4D RID: 3149
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x210")]
	private float deployDelay;

	// Token: 0x04000C4E RID: 3150
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x214")]
	private bool wasAttacking;

	// Token: 0x04000C4F RID: 3151
	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x218")]
	private float configProgress;

	// Token: 0x04000C50 RID: 3152
	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x21C")]
	private float attackHeldTime;

	// Token: 0x04000C51 RID: 3153
	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x220")]
	private float attackReleasedTime;
}
