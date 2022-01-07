using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000124 RID: 292
[Token(Token = "0x20000AC")]
public class Chainsaw : BaseMelee
{
	// Token: 0x0600116F RID: 4463 RVA: 0x0000A3E0 File Offset: 0x000085E0
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x4D7B40", Offset = "0x4D6940", VA = "0x1804D7B40", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x4D6E40", Offset = "0x4D5C40", VA = "0x1804D6E40")]
	public void DelayedAttackLoop()
	{
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x4D6E70", Offset = "0x4D5C70", VA = "0x1804D6E70")]
	public void DelayedIdleLoop()
	{
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x4D8030", Offset = "0x4D6E30", VA = "0x1804D8030")]
	public void UpdateAudio()
	{
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x4D7E80", Offset = "0x4D6C80", VA = "0x1804D7E80")]
	public void SetupVisuals()
	{
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x4D8450", Offset = "0x4D7250", VA = "0x1804D8450")]
	private void UpdateChain(bool on, bool attacking)
	{
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x0000A3F8 File Offset: 0x000085F8
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x457A30", Offset = "0x456830", VA = "0x180457A30")]
	public bool EngineOn()
	{
		return default(bool);
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x0000A410 File Offset: 0x00008610
	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x4D7460", Offset = "0x4D6260", VA = "0x1804D7460")]
	public bool IsAttacking()
	{
		return default(bool);
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x4D6D10", Offset = "0x4D5B10", VA = "0x1804D6D10", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x4D8690", Offset = "0x4D7490", VA = "0x1804D8690")]
	public void Update()
	{
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x0000A428 File Offset: 0x00008628
	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x4D7470", Offset = "0x4D6270", VA = "0x1804D7470")]
	private bool IsReloading()
	{
		return default(bool);
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x4D7310", Offset = "0x4D6110", VA = "0x1804D7310", Slot = "51")]
	public override void GetItemOptions(List<Option> options)
	{
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x4D6EB0", Offset = "0x4D5CB0", VA = "0x1804D6EB0", Slot = "164")]
	protected override void DoAttack()
	{
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x4D7E40", Offset = "0x4D6C40", VA = "0x1804D7E40")]
	public void SendServerReload()
	{
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x4D7C30", Offset = "0x4D6A30", VA = "0x1804D7C30", Slot = "143")]
	public override void OnViewmodelEvent(string name)
	{
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x4D7680", Offset = "0x4D6480", VA = "0x1804D7680", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x4D7CE0", Offset = "0x4D6AE0", VA = "0x1804D7CE0", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x4D7230", Offset = "0x4D6030", VA = "0x1804D7230")]
	public v_chainsaw GetChainsawViewmodel()
	{
		return null;
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x4D7530", Offset = "0x4D6330", VA = "0x1804D7530", Slot = "136")]
	public override void OnFrame()
	{
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x4D6C90", Offset = "0x4D5A90", VA = "0x1804D6C90")]
	public void CleanupViewmodel()
	{
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x4D7660", Offset = "0x4D6460", VA = "0x1804D7660", Slot = "141")]
	public override void OnHolster()
	{
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x4D7510", Offset = "0x4D6310", VA = "0x1804D7510", Slot = "139")]
	public override void OnDeploy()
	{
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x4D7F90", Offset = "0x4D6D90", VA = "0x1804D7F90", Slot = "167")]
	protected virtual void UpdateAmmoDisplay()
	{
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x4D7D90", Offset = "0x4D6B90", VA = "0x1804D7D90", Slot = "151")]
	public override void ProcessSpectatorViewmodel(ViewModel vm)
	{
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x4D7D00", Offset = "0x4D6B00", VA = "0x1804D7D00", Slot = "152")]
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, global::BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x4D6EA0", Offset = "0x4D5CA0", VA = "0x1804D6EA0", Slot = "159")]
	public override void DoAttackShared(HitInfo info)
	{
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x4D74A0", Offset = "0x4D62A0", VA = "0x1804D74A0", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x0000A440 File Offset: 0x00008640
	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x4D7440", Offset = "0x4D6240", VA = "0x1804D7440")]
	public bool HasAmmo()
	{
		return default(bool);
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x4D7140", Offset = "0x4D5F40", VA = "0x1804D7140")]
	public global::Item GetAmmo()
	{
		return null;
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x4D86F0", Offset = "0x4D74F0", VA = "0x1804D86F0")]
	public Chainsaw()
	{
	}

	// Token: 0x04000BEA RID: 3050
	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0x2D8")]
	public float attackFadeInTime;

	// Token: 0x04000BEB RID: 3051
	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0x2DC")]
	public float attackFadeInDelay;

	// Token: 0x04000BEC RID: 3052
	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x2E0")]
	public float attackFadeOutTime;

	// Token: 0x04000BED RID: 3053
	[Token(Token = "0x400098B")]
	[FieldOffset(Offset = "0x2E4")]
	public float idleFadeInTimeFromOff;

	// Token: 0x04000BEE RID: 3054
	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0x2E8")]
	public float idleFadeInTimeFromAttack;

	// Token: 0x04000BEF RID: 3055
	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0x2EC")]
	public float idleFadeInDelay;

	// Token: 0x04000BF0 RID: 3056
	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x2F0")]
	public float idleFadeOutTime;

	// Token: 0x04000BF1 RID: 3057
	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x2F4")]
	private bool wasEngineOn;

	// Token: 0x04000BF2 RID: 3058
	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x2F5")]
	private bool wasAttackingAudio;

	// Token: 0x04000BF3 RID: 3059
	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x2F8")]
	public Renderer chainRenderer;

	// Token: 0x04000BF4 RID: 3060
	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0x300")]
	private MaterialPropertyBlock block;

	// Token: 0x04000BF5 RID: 3061
	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x308")]
	private Vector2 saveST;

	// Token: 0x04000BF6 RID: 3062
	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x310")]
	private float chainSpeed;

	// Token: 0x04000BF7 RID: 3063
	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x314")]
	private float chainAmount;

	// Token: 0x04000BF8 RID: 3064
	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x318")]
	private float chainSpinUpRate;

	// Token: 0x04000BF9 RID: 3065
	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x31C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x90760", Offset = "0x8FB60")]
	public float fuelPerSec;

	// Token: 0x04000BFA RID: 3066
	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x320")]
	public int maxAmmo;

	// Token: 0x04000BFB RID: 3067
	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x324")]
	public int ammo;

	// Token: 0x04000BFC RID: 3068
	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x328")]
	public ItemDefinition fuelType;

	// Token: 0x04000BFD RID: 3069
	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x330")]
	public float reloadDuration;

	// Token: 0x04000BFE RID: 3070
	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x338")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x7F1B0", Offset = "0x7E5B0")]
	public SoundPlayer idleLoop;

	// Token: 0x04000BFF RID: 3071
	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x340")]
	public SoundPlayer attackLoopAir;

	// Token: 0x04000C00 RID: 3072
	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x348")]
	public SoundPlayer revUp;

	// Token: 0x04000C01 RID: 3073
	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x350")]
	public SoundPlayer revDown;

	// Token: 0x04000C02 RID: 3074
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x358")]
	public SoundPlayer offSound;

	// Token: 0x04000C03 RID: 3075
	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x360")]
	private string lastHitMaterial;

	// Token: 0x04000C04 RID: 3076
	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x368")]
	private float lastHitTime;

	// Token: 0x04000C05 RID: 3077
	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x36C")]
	private float nextReleaseTime;

	// Token: 0x04000C06 RID: 3078
	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x370")]
	private float nextPressTime;

	// Token: 0x04000C07 RID: 3079
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x374")]
	private bool wasAttacking;

	// Token: 0x04000C08 RID: 3080
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x378")]
	private float reloadFinishedTime;

	// Token: 0x04000C09 RID: 3081
	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x37C")]
	public float engineStartChance;
}
