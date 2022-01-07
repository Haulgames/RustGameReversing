using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using Rust;
using UnityEngine;

// Token: 0x0200010F RID: 271
[Token(Token = "0x20000A2")]
public class BaseProjectile : AttackEntity
{
	// Token: 0x0600106D RID: 4205 RVA: 0x000099C0 File Offset: 0x00007BC0
	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x99A5E0", Offset = "0x9993E0", VA = "0x18099A5E0", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x000099D8 File Offset: 0x00007BD8
	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x9831F0", Offset = "0x981FF0", VA = "0x1809831F0", Slot = "156")]
	public override Vector3 GetInheritedVelocity(global::BasePlayer player)
	{
		return default(Vector3);
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x000099F0 File Offset: 0x00007BF0
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x997CF0", Offset = "0x996AF0", VA = "0x180997CF0", Slot = "159")]
	public virtual float GetDamageScale(bool getMax = false)
	{
		return 0f;
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00009A08 File Offset: 0x00007C08
	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x997D00", Offset = "0x996B00", VA = "0x180997D00", Slot = "160")]
	public virtual float GetDistanceScale(bool getMax = false)
	{
		return 0f;
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x00009A20 File Offset: 0x00007C20
	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x2FC360", Offset = "0x2FB160", VA = "0x1802FC360", Slot = "161")]
	public virtual float GetProjectileVelocityScale(bool getMax = false)
	{
		return 0f;
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x99BD60", Offset = "0x99AB60", VA = "0x18099BD60")]
	protected void StartReloadCooldown(float cooldown)
	{
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x99B1E0", Offset = "0x999FE0", VA = "0x18099B1E0")]
	protected void ResetReloadCooldown()
	{
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00009A38 File Offset: 0x00007C38
	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x998BB0", Offset = "0x9979B0", VA = "0x180998BB0")]
	protected bool HasReloadCooldown()
	{
		return default(bool);
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x00009A50 File Offset: 0x00007C50
	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x9984B0", Offset = "0x9972B0", VA = "0x1809984B0")]
	protected float GetReloadCooldown()
	{
		return 0f;
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x00009A68 File Offset: 0x00007C68
	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x998610", Offset = "0x997410", VA = "0x180998610")]
	protected float GetReloadIdle()
	{
		return 0f;
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x999E20", Offset = "0x998C20", VA = "0x180999E20")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x9984A0", Offset = "0x9972A0", VA = "0x1809984A0", Slot = "162")]
	public virtual RecoilProperties GetRecoil()
	{
		return null;
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06001079 RID: 4217 RVA: 0x00009A80 File Offset: 0x00007C80
	[Token(Token = "0x1700015A")]
	public bool isSemiAuto
	{
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x99C0C0", Offset = "0x99AEC0", VA = "0x18099C0C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00009A98 File Offset: 0x00007C98
	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x997450", Offset = "0x996250", VA = "0x180997450", Slot = "163")]
	public virtual float GetAimCone()
	{
		return 0f;
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00009AB0 File Offset: 0x00007CB0
	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x99B1F0", Offset = "0x999FF0", VA = "0x18099B1F0")]
	public float ScaleRepeatDelay(float delay)
	{
		return 0f;
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00009AC8 File Offset: 0x00007CC8
	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0x997E60", Offset = "0x996C60", VA = "0x180997E60")]
	public Projectile.Modifier GetProjectileModifier()
	{
		return default(Projectile.Modifier);
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x995C00", Offset = "0x994A00", VA = "0x180995C00", Slot = "164")]
	public virtual void DidAttackClientside()
	{
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0x997D10", Offset = "0x996B10", VA = "0x180997D10", Slot = "51")]
	public override void GetItemOptions(List<Option> options)
	{
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0x996A50", Offset = "0x995850", VA = "0x180996A50", Slot = "134")]
	public override void EditViewAngles()
	{
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x99A1F0", Offset = "0x998FF0", VA = "0x18099A1F0", Slot = "136")]
	public override void OnFrame()
	{
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x99B520", Offset = "0x99A320", VA = "0x18099B520", Slot = "165")]
	public virtual void ShotFired()
	{
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x99B580", Offset = "0x99A380", VA = "0x18099B580", Slot = "166")]
	public virtual void SimulateAimcone()
	{
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00009AE0 File Offset: 0x00007CE0
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x995730", Offset = "0x994530", VA = "0x180995730", Slot = "167")]
	public virtual bool CanAttack()
	{
		return default(bool);
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x00009AF8 File Offset: 0x00007CF8
	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x995700", Offset = "0x994500", VA = "0x180995700", Slot = "168")]
	public virtual bool CanAim()
	{
		return default(bool);
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x99A200", Offset = "0x999000", VA = "0x18099A200", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00009B10 File Offset: 0x00007D10
	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x99B130", Offset = "0x999F30", VA = "0x18099B130")]
	public bool ReadyToAim()
	{
		return default(bool);
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00009B28 File Offset: 0x00007D28
	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x99B180", Offset = "0x999F80", VA = "0x18099B180")]
	public bool ReadyToFire()
	{
		return default(bool);
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x9955E0", Offset = "0x9943E0", VA = "0x1809955E0")]
	public void AmmoTypeClicked(ItemDefinition newAmmoType)
	{
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x995430", Offset = "0x994230", VA = "0x180995430")]
	private void AddAmmoOption(ItemDefinition ammo, List<Option> opts, int order = 0)
	{
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0x998690", Offset = "0x997490", VA = "0x180998690")]
	public List<Option> GetReloadMenu(global::BasePlayer player)
	{
		return null;
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C00")]
	[Address(RVA = "0x99AD90", Offset = "0x999B90", VA = "0x18099AD90")]
	private void PredictAmmoType()
	{
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00009B40 File Offset: 0x00007D40
	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x998900", Offset = "0x997700", VA = "0x180998900", Slot = "169")]
	public virtual bool HasMoreThanOneAmmoType(AmmoTypes ammoType)
	{
		return default(bool);
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x999DE0", Offset = "0x998BE0", VA = "0x180999DE0", Slot = "139")]
	public override void OnDeploy()
	{
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x9964D0", Offset = "0x9952D0", VA = "0x1809964D0")]
	private void DoReload()
	{
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C04")]
	[Address(RVA = "0x998BE0", Offset = "0x9979E0", VA = "0x180998BE0")]
	protected void InsertAmmoFraction()
	{
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x995750", Offset = "0x994550", VA = "0x180995750")]
	public void CancelFractionalReloading()
	{
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x9957F0", Offset = "0x9945F0", VA = "0x1809957F0")]
	protected void ClientFinishFractionalReload()
	{
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x995930", Offset = "0x994730", VA = "0x180995930")]
	protected void ClientSingleReload()
	{
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x995C10", Offset = "0x994A10", VA = "0x180995C10", Slot = "170")]
	public virtual void DoAttack()
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x995670", Offset = "0x994470", VA = "0x180995670")]
	public void BeginCycle()
	{
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x999BF0", Offset = "0x9989F0", VA = "0x180999BF0", Slot = "171")]
	public virtual void LaunchProjectile()
	{
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x996990", Offset = "0x995790", VA = "0x180996990")]
	public void DryFire()
	{
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x99B0D0", Offset = "0x999ED0", VA = "0x18099B0D0", Slot = "151")]
	public override void ProcessSpectatorViewmodel(ViewModel vm)
	{
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x99AFC0", Offset = "0x999DC0", VA = "0x18099AFC0", Slot = "152")]
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, global::BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x00009B58 File Offset: 0x00007D58
	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x998530", Offset = "0x997330", VA = "0x180998530")]
	public float GetReloadDuration()
	{
		return 0f;
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x00009B70 File Offset: 0x00007D70
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x997AE0", Offset = "0x9968E0", VA = "0x180997AE0")]
	public int GetAvailableAmmo()
	{
		return 0;
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00009B88 File Offset: 0x00007D88
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x998C40", Offset = "0x997A40", VA = "0x180998C40")]
	public bool IsSilenced()
	{
		return default(bool);
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00009BA0 File Offset: 0x00007DA0
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x9973C0", Offset = "0x9961C0", VA = "0x1809973C0")]
	public bool FiredUnderground()
	{
		return default(bool);
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x99A6D0", Offset = "0x9994D0", VA = "0x18099A6D0", Slot = "83")]
	public override void OnSignal(global::BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x998E20", Offset = "0x997C20", VA = "0x180998E20")]
	internal void LaunchProjectileClientside(ItemDefinition ammo, int projectileCount, float projSpreadaimCone)
	{
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x995A70", Offset = "0x994870", VA = "0x180995A70")]
	private Projectile CreateProjectile(string prefabPath, Vector3 pos, Vector3 forward, Vector3 velocity)
	{
		return null;
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x99BDB0", Offset = "0x99ABB0", VA = "0x18099BDB0", Slot = "172")]
	protected virtual void UpdateAmmoDisplay()
	{
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00009BB8 File Offset: 0x00007DB8
	[Token(Token = "0x1700015B")]
	private bool UsingInfiniteAmmoCheat
	{
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x999D40", Offset = "0x998B40", VA = "0x180999D40", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x99BE60", Offset = "0x99AC60", VA = "0x18099BE60")]
	public BaseProjectile()
	{
	}

	// Token: 0x04000AD0 RID: 2768
	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x278")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8D3C0", Offset = "0x8C7C0")]
	public float NoiseRadius;

	// Token: 0x04000AD1 RID: 2769
	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x27C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8D490", Offset = "0x8C890")]
	public float damageScale;

	// Token: 0x04000AD2 RID: 2770
	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x280")]
	public float distanceScale;

	// Token: 0x04000AD3 RID: 2771
	[Token(Token = "0x40008B3")]
	[FieldOffset(Offset = "0x284")]
	public float projectileVelocityScale;

	// Token: 0x04000AD4 RID: 2772
	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0x288")]
	public bool automatic;

	// Token: 0x04000AD5 RID: 2773
	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0x289")]
	public bool usableByTurret;

	// Token: 0x04000AD6 RID: 2774
	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x28C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x8D4F0", Offset = "0x8C8F0")]
	public float turretDamageScale;

	// Token: 0x04000AD7 RID: 2775
	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x290")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x880D0", Offset = "0x874D0")]
	public GameObjectRef attackFX;

	// Token: 0x04000AD8 RID: 2776
	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x298")]
	public GameObjectRef silencedAttack;

	// Token: 0x04000AD9 RID: 2777
	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x2A0")]
	public GameObjectRef muzzleBrakeAttack;

	// Token: 0x04000ADA RID: 2778
	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0x2A8")]
	public Transform MuzzlePoint;

	// Token: 0x04000ADB RID: 2779
	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0x2B0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8D6F0", Offset = "0x8CAF0")]
	public float reloadTime;

	// Token: 0x04000ADC RID: 2780
	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0x2B4")]
	public bool canUnloadAmmo;

	// Token: 0x04000ADD RID: 2781
	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0x2B8")]
	public global::BaseProjectile.Magazine primaryMagazine;

	// Token: 0x04000ADE RID: 2782
	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0x2C0")]
	public bool fractionalReload;

	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0x2C4")]
	public float reloadStartDuration;

	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0x2C8")]
	public float reloadFractionDuration;

	// Token: 0x04000AE1 RID: 2785
	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x2CC")]
	public float reloadEndDuration;

	// Token: 0x04000AE2 RID: 2786
	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0x2D0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8D780", Offset = "0x8CB80")]
	public float aimSway;

	// Token: 0x04000AE3 RID: 2787
	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0x2D4")]
	public float aimSwaySpeed;

	// Token: 0x04000AE4 RID: 2788
	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0x2D8")]
	public RecoilProperties recoil;

	// Token: 0x04000AE5 RID: 2789
	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0x2E0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8D7B0", Offset = "0x8CBB0")]
	public AnimationCurve aimconeCurve;

	// Token: 0x04000AE6 RID: 2790
	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x2E8")]
	public float aimCone;

	// Token: 0x04000AE7 RID: 2791
	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x2EC")]
	public float hipAimCone;

	// Token: 0x04000AE8 RID: 2792
	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x2F0")]
	public float aimconePenaltyPerShot;

	// Token: 0x04000AE9 RID: 2793
	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x2F4")]
	public float aimConePenaltyMax;

	// Token: 0x04000AEA RID: 2794
	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0x2F8")]
	public float aimconePenaltyRecoverTime;

	// Token: 0x04000AEB RID: 2795
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x2FC")]
	public float aimconePenaltyRecoverDelay;

	// Token: 0x04000AEC RID: 2796
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x300")]
	public float stancePenaltyScale;

	// Token: 0x04000AED RID: 2797
	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x304")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8D840", Offset = "0x8CC40")]
	public bool hasADS;

	// Token: 0x04000AEE RID: 2798
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x305")]
	public bool noAimingWhileCycling;

	// Token: 0x04000AEF RID: 2799
	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x306")]
	public bool manualCycle;

	// Token: 0x04000AF0 RID: 2800
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x307")]
	[NonSerialized]
	protected bool needsCycle;

	// Token: 0x04000AF1 RID: 2801
	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x308")]
	[NonSerialized]
	protected bool isCycling;

	// Token: 0x04000AF2 RID: 2802
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x309")]
	[NonSerialized]
	public bool aiming;

	// Token: 0x04000AF3 RID: 2803
	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x30C")]
	public float resetDuration;

	// Token: 0x04000AF4 RID: 2804
	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x310")]
	public int numShotsFired;

	// Token: 0x04000AF5 RID: 2805
	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x314")]
	[NonSerialized]
	private float nextReloadTime;

	// Token: 0x04000AF6 RID: 2806
	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x318")]
	[NonSerialized]
	private float startReloadTime;

	// Token: 0x04000AF7 RID: 2807
	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x31C")]
	private float stancePenalty;

	// Token: 0x04000AF8 RID: 2808
	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x320")]
	private float aimconePenalty;

	// Token: 0x04000AF9 RID: 2809
	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x324")]
	[NonSerialized]
	protected bool isReloading;

	// Token: 0x04000AFA RID: 2810
	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x328")]
	private float swaySampleTime;

	// Token: 0x04000AFB RID: 2811
	[Token(Token = "0x40008DB")]
	[FieldOffset(Offset = "0x32C")]
	private float lastShotTime;

	// Token: 0x04000AFC RID: 2812
	[Token(Token = "0x40008DC")]
	[FieldOffset(Offset = "0x330")]
	[NonSerialized]
	public float reloadPressTime;

	// Token: 0x04000AFD RID: 2813
	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x338")]
	private ItemDefinition ammoTypePreReload;

	// Token: 0x04000AFE RID: 2814
	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x340")]
	private int fractionalReloadDesiredCount;

	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0x344")]
	private int fractionalReloadNumAdded;

	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x348")]
	private bool triggerReady;

	// Token: 0x04000B01 RID: 2817
	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x34C")]
	private float nextHeightCheckTime;

	// Token: 0x04000B02 RID: 2818
	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x350")]
	private bool cachedUnderground;

	// Token: 0x04000B03 RID: 2819
	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x358")]
	private List<Projectile> createdProjectiles;

	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000AA6")]
	[Serializable]
	public class Magazine
	{
		// Token: 0x060010A4 RID: 4260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x9ADD30", Offset = "0x9ACB30", VA = "0x1809ADD30")]
		public void ServerInit()
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0A")]
		[Address(RVA = "0x9ADC60", Offset = "0x9ACA60", VA = "0x1809ADC60")]
		public ProtoBuf.Magazine Save()
		{
			return null;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C0B")]
		[Address(RVA = "0x9ADC10", Offset = "0x9ACA10", VA = "0x1809ADC10")]
		public void Load(ProtoBuf.Magazine mag)
		{
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[Token(Token = "0x6004C0C")]
		[Address(RVA = "0x9ADBD0", Offset = "0x9AC9D0", VA = "0x1809ADBD0")]
		public bool CanReload(global::BasePlayer owner)
		{
			return default(bool);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C0D")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public Magazine()
		{
		}

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4003F48")]
		[FieldOffset(Offset = "0x10")]
		public global::BaseProjectile.Magazine.Definition definition;

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4003F49")]
		[FieldOffset(Offset = "0x18")]
		public int capacity;

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4003F4A")]
		[FieldOffset(Offset = "0x1C")]
		public int contents;

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4003F4B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ItemSelector", RVA = "0x8D9E0", Offset = "0x8CDE0")]
		public ItemDefinition ammoType;

		// Token: 0x02000111 RID: 273
		[Token(Token = "0x2000E66")]
		[Serializable]
		public struct Definition
		{
			// Token: 0x04000B08 RID: 2824
			[Token(Token = "0x4004FFF")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x8DA60", Offset = "0x8CE60")]
			public int builtInSize;

			// Token: 0x04000B09 RID: 2825
			[Token(Token = "0x4005000")]
			[FieldOffset(Offset = "0x4")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x8DB20", Offset = "0x8CF20")]
			[InspectorFlags]
			public AmmoTypes ammoTypes;
		}
	}

	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000AA7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x6004C10")]
		[Address(RVA = "0x9AE4D0", Offset = "0x9AD2D0", VA = "0x1809AE4D0")]
		internal ProjectileWeaponMod.Modifier <GetAimCone>b__56_0(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <GetAimCone>b__56_1(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x6004C12")]
		[Address(RVA = "0x9AE4D0", Offset = "0x9AD2D0", VA = "0x1809AE4D0")]
		internal ProjectileWeaponMod.Modifier <GetAimCone>b__56_2(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6004C13")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <GetAimCone>b__56_3(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x9AE500", Offset = "0x9AD300", VA = "0x1809AE500")]
		internal ProjectileWeaponMod.Modifier <GetAimCone>b__56_4(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <GetAimCone>b__56_5(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x9AE500", Offset = "0x9AD300", VA = "0x1809AE500")]
		internal ProjectileWeaponMod.Modifier <GetAimCone>b__56_6(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <GetAimCone>b__56_7(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00009CA8 File Offset: 0x00007EA8
		[Token(Token = "0x6004C18")]
		[Address(RVA = "0x9AE660", Offset = "0x9AD460", VA = "0x1809AE660")]
		internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__57_0(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[Token(Token = "0x6004C19")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <ScaleRepeatDelay>b__57_1(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x9AE660", Offset = "0x9AD460", VA = "0x1809AE660")]
		internal ProjectileWeaponMod.Modifier <ScaleRepeatDelay>b__57_2(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <ScaleRepeatDelay>b__57_3(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x9AE530", Offset = "0x9AD330", VA = "0x1809AE530")]
		internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__58_0(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <GetProjectileModifier>b__58_1(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00009D38 File Offset: 0x00007F38
		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x9AE530", Offset = "0x9AD330", VA = "0x1809AE530")]
		internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__58_2(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x6004C1F")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <GetProjectileModifier>b__58_3(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6004C20")]
		[Address(RVA = "0x9AE560", Offset = "0x9AD360", VA = "0x1809AE560")]
		internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__58_4(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x6004C21")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <GetProjectileModifier>b__58_5(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x6004C22")]
		[Address(RVA = "0x9AE560", Offset = "0x9AD360", VA = "0x1809AE560")]
		internal ProjectileWeaponMod.Modifier <GetProjectileModifier>b__58_6(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x6004C23")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <GetProjectileModifier>b__58_7(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x6004C24")]
		[Address(RVA = "0x9AE470", Offset = "0x9AD270", VA = "0x1809AE470")]
		internal ProjectileWeaponMod.Modifier <EditViewAngles>b__63_0(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <EditViewAngles>b__63_1(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x9AE470", Offset = "0x9AD270", VA = "0x1809AE470")]
		internal ProjectileWeaponMod.Modifier <EditViewAngles>b__63_2(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00009E10 File Offset: 0x00008010
		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <EditViewAngles>b__63_3(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x9AE4A0", Offset = "0x9AD2A0", VA = "0x1809AE4A0")]
		internal ProjectileWeaponMod.Modifier <EditViewAngles>b__63_4(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <EditViewAngles>b__63_5(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x9AE4A0", Offset = "0x9AD2A0", VA = "0x1809AE4A0")]
		internal ProjectileWeaponMod.Modifier <EditViewAngles>b__63_6(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00009E70 File Offset: 0x00008070
		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <EditViewAngles>b__63_7(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00009E88 File Offset: 0x00008088
		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0x9AE410", Offset = "0x9AD210", VA = "0x1809AE410")]
		internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__67_0(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x6004C2D")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <SimulateAimcone>b__67_1(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x6004C2E")]
		[Address(RVA = "0x9AE410", Offset = "0x9AD210", VA = "0x1809AE410")]
		internal ProjectileWeaponMod.Modifier <SimulateAimcone>b__67_2(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x6004C2F")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <SimulateAimcone>b__67_3(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00009EE8 File Offset: 0x000080E8
		[Token(Token = "0x6004C30")]
		[Address(RVA = "0x9AE410", Offset = "0x9AD210", VA = "0x1809AE410")]
		internal ProjectileWeaponMod.Modifier <DoAttack>b__89_0(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <DoAttack>b__89_1(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00009F18 File Offset: 0x00008118
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x9AE410", Offset = "0x9AD210", VA = "0x1809AE410")]
		internal ProjectileWeaponMod.Modifier <DoAttack>b__89_2(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00009F30 File Offset: 0x00008130
		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <DoAttack>b__89_3(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x9AE600", Offset = "0x9AD400", VA = "0x1809AE600")]
		internal bool <OnSignal>b__101_0(ProjectileWeaponMod x)
		{
			return default(bool);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x6004C35")]
		[Address(RVA = "0x9AE590", Offset = "0x9AD390", VA = "0x1809AE590")]
		internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__103_0(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x6004C36")]
		[Address(RVA = "0x9AE440", Offset = "0x9AD240", VA = "0x1809AE440")]
		internal float <LaunchProjectileClientside>b__103_1(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x6004C37")]
		[Address(RVA = "0x9AE590", Offset = "0x9AD390", VA = "0x1809AE590")]
		internal ProjectileWeaponMod.Modifier <LaunchProjectileClientside>b__103_2(ProjectileWeaponMod x)
		{
			return default(ProjectileWeaponMod.Modifier);
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x9AE450", Offset = "0x9AD250", VA = "0x1809AE450")]
		internal float <LaunchProjectileClientside>b__103_3(ProjectileWeaponMod.Modifier y)
		{
			return 0f;
		}

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4003F4C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly global::BaseProjectile.<>c <>9;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4003F4D")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__56_0;

		// Token: 0x04000B0C RID: 2828
		[Token(Token = "0x4003F4E")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__56_1;

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4003F4F")]
		[FieldOffset(Offset = "0x18")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__56_2;

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4003F50")]
		[FieldOffset(Offset = "0x20")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__56_3;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4003F51")]
		[FieldOffset(Offset = "0x28")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__56_4;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4003F52")]
		[FieldOffset(Offset = "0x30")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__56_5;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4003F53")]
		[FieldOffset(Offset = "0x38")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__56_6;

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4003F54")]
		[FieldOffset(Offset = "0x40")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__56_7;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4003F55")]
		[FieldOffset(Offset = "0x48")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__57_0;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4003F56")]
		[FieldOffset(Offset = "0x50")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__57_1;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4003F57")]
		[FieldOffset(Offset = "0x58")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__57_2;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4003F58")]
		[FieldOffset(Offset = "0x60")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__57_3;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4003F59")]
		[FieldOffset(Offset = "0x68")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__58_0;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4003F5A")]
		[FieldOffset(Offset = "0x70")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__58_1;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4003F5B")]
		[FieldOffset(Offset = "0x78")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__58_2;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4003F5C")]
		[FieldOffset(Offset = "0x80")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__58_3;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4003F5D")]
		[FieldOffset(Offset = "0x88")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__58_4;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4003F5E")]
		[FieldOffset(Offset = "0x90")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__58_5;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4003F5F")]
		[FieldOffset(Offset = "0x98")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__58_6;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4003F60")]
		[FieldOffset(Offset = "0xA0")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__58_7;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4003F61")]
		[FieldOffset(Offset = "0xA8")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_0;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4003F62")]
		[FieldOffset(Offset = "0xB0")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_1;

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4003F63")]
		[FieldOffset(Offset = "0xB8")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_2;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4003F64")]
		[FieldOffset(Offset = "0xC0")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_3;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4003F65")]
		[FieldOffset(Offset = "0xC8")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_4;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4003F66")]
		[FieldOffset(Offset = "0xD0")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_5;

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4003F67")]
		[FieldOffset(Offset = "0xD8")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__63_6;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4003F68")]
		[FieldOffset(Offset = "0xE0")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__63_7;

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4003F69")]
		[FieldOffset(Offset = "0xE8")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__67_0;

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4003F6A")]
		[FieldOffset(Offset = "0xF0")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__67_1;

		// Token: 0x04000B29 RID: 2857
		[Token(Token = "0x4003F6B")]
		[FieldOffset(Offset = "0xF8")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__67_2;

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4003F6C")]
		[FieldOffset(Offset = "0x100")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__67_3;

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4003F6D")]
		[FieldOffset(Offset = "0x108")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__89_0;

		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4003F6E")]
		[FieldOffset(Offset = "0x110")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__89_1;

		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4003F6F")]
		[FieldOffset(Offset = "0x118")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__89_2;

		// Token: 0x04000B2E RID: 2862
		[Token(Token = "0x4003F70")]
		[FieldOffset(Offset = "0x120")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__89_3;

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4003F71")]
		[FieldOffset(Offset = "0x128")]
		public static Func<ProjectileWeaponMod, bool> <>9__101_0;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4003F72")]
		[FieldOffset(Offset = "0x130")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__103_0;

		// Token: 0x04000B31 RID: 2865
		[Token(Token = "0x4003F73")]
		[FieldOffset(Offset = "0x138")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__103_1;

		// Token: 0x04000B32 RID: 2866
		[Token(Token = "0x4003F74")]
		[FieldOffset(Offset = "0x140")]
		public static Func<ProjectileWeaponMod, ProjectileWeaponMod.Modifier> <>9__103_2;

		// Token: 0x04000B33 RID: 2867
		[Token(Token = "0x4003F75")]
		[FieldOffset(Offset = "0x148")]
		public static Func<ProjectileWeaponMod.Modifier, float> <>9__103_3;
	}

	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000AA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass75_0
	{
		// Token: 0x060010D4 RID: 4308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass75_0()
		{
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x9AE720", Offset = "0x9AD520", VA = "0x1809AE720")]
		internal void <AddAmmoOption>b__0(global::BasePlayer ply)
		{
		}

		// Token: 0x04000B34 RID: 2868
		[Token(Token = "0x4003F76")]
		[FieldOffset(Offset = "0x10")]
		public global::BaseProjectile <>4__this;

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4003F77")]
		[FieldOffset(Offset = "0x18")]
		public ItemDefinition ammoType;
	}
}
