using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000483 RID: 1155
[Token(Token = "0x2000356")]
public class AttackEntity : HeldEntity
{
	// Token: 0x06002388 RID: 9096 RVA: 0x0000FF18 File Offset: 0x0000E118
	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0x83D180", Offset = "0x83BF80", VA = "0x18083D180", Slot = "156")]
	public virtual Vector3 GetInheritedVelocity(BasePlayer player)
	{
		return default(Vector3);
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06002389 RID: 9097 RVA: 0x0000FF30 File Offset: 0x0000E130
	[Token(Token = "0x1700027A")]
	public float NextAttackTime
	{
		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x83D660", Offset = "0x83C460", VA = "0x18083D660")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600238A RID: 9098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "157")]
	public virtual void GetAttackStats(HitInfo info)
	{
	}

	// Token: 0x0600238B RID: 9099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D3F")]
	[Address(RVA = "0x83D3A0", Offset = "0x83C1A0", VA = "0x18083D3A0")]
	protected void StartAttackCooldownRaw(float cooldown)
	{
	}

	// Token: 0x0600238C RID: 9100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D40")]
	[Address(RVA = "0x83D3D0", Offset = "0x83C1D0", VA = "0x18083D3D0")]
	protected void StartAttackCooldown(float cooldown)
	{
	}

	// Token: 0x0600238D RID: 9101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D41")]
	[Address(RVA = "0x83D390", Offset = "0x83C190", VA = "0x18083D390")]
	protected void ResetAttackCooldown()
	{
	}

	// Token: 0x0600238E RID: 9102 RVA: 0x0000FF48 File Offset: 0x0000E148
	[Token(Token = "0x6001D42")]
	[Address(RVA = "0x83D1F0", Offset = "0x83BFF0", VA = "0x18083D1F0")]
	public bool HasAttackCooldown()
	{
		return default(bool);
	}

	// Token: 0x0600238F RID: 9103 RVA: 0x0000FF60 File Offset: 0x0000E160
	[Token(Token = "0x6001D43")]
	[Address(RVA = "0x83D080", Offset = "0x83BE80", VA = "0x18083D080")]
	protected float GetAttackCooldown()
	{
		return 0f;
	}

	// Token: 0x06002390 RID: 9104 RVA: 0x0000FF78 File Offset: 0x0000E178
	[Token(Token = "0x6001D44")]
	[Address(RVA = "0x83D100", Offset = "0x83BF00", VA = "0x18083D100")]
	protected float GetAttackIdle()
	{
		return 0f;
	}

	// Token: 0x06002391 RID: 9105 RVA: 0x0000FF90 File Offset: 0x0000E190
	[Token(Token = "0x6001D45")]
	[Address(RVA = "0x83C630", Offset = "0x83B430", VA = "0x18083C630")]
	protected float CalculateCooldownTime(float nextTime, float cooldown, bool catchup)
	{
		return 0f;
	}

	// Token: 0x06002392 RID: 9106 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
	[Token(Token = "0x6001D46")]
	[Address(RVA = "0x83D220", Offset = "0x83C020", VA = "0x18083D220", Slot = "158")]
	public virtual bool IsFullyDeployed()
	{
		return default(bool);
	}

	// Token: 0x06002393 RID: 9107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D47")]
	[Address(RVA = "0x83D2C0", Offset = "0x83C0C0", VA = "0x18083D2C0")]
	protected void ProcessInputTime()
	{
	}

	// Token: 0x06002394 RID: 9108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D48")]
	[Address(RVA = "0x83D260", Offset = "0x83C060", VA = "0x18083D260", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x06002395 RID: 9109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D49")]
	[Address(RVA = "0x83D240", Offset = "0x83C040", VA = "0x18083D240", Slot = "139")]
	public override void OnDeploy()
	{
	}

	// Token: 0x06002396 RID: 9110 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0x83D310", Offset = "0x83C110", VA = "0x18083D310")]
	public bool RecoilCompReady()
	{
		return default(bool);
	}

	// Token: 0x06002397 RID: 9111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0x83C480", Offset = "0x83B280", VA = "0x18083C480", Slot = "130")]
	public override void AddPunch(Vector3 amount, float duration)
	{
	}

	// Token: 0x06002398 RID: 9112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x83C770", Offset = "0x83B570", VA = "0x18083C770", Slot = "131")]
	public override void DoRecoilCompensation()
	{
	}

	// Token: 0x06002399 RID: 9113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D4D")]
	[Address(RVA = "0x83D570", Offset = "0x83C370", VA = "0x18083D570")]
	public AttackEntity()
	{
	}

	// Token: 0x04001E05 RID: 7685
	[Token(Token = "0x400188B")]
	[FieldOffset(Offset = "0x1F0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xCFBC0", Offset = "0xCEFC0")]
	public float deployDelay;

	// Token: 0x04001E06 RID: 7686
	[Token(Token = "0x400188C")]
	[FieldOffset(Offset = "0x1F4")]
	public float repeatDelay;

	// Token: 0x04001E07 RID: 7687
	[Token(Token = "0x400188D")]
	[FieldOffset(Offset = "0x1F8")]
	public float animationDelay;

	// Token: 0x04001E08 RID: 7688
	[Token(Token = "0x400188E")]
	[FieldOffset(Offset = "0x1FC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x881A0", Offset = "0x875A0")]
	public float effectiveRange;

	// Token: 0x04001E09 RID: 7689
	[Token(Token = "0x400188F")]
	[FieldOffset(Offset = "0x200")]
	public float npcDamageScale;

	// Token: 0x04001E0A RID: 7690
	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x204")]
	public float attackLengthMin;

	// Token: 0x04001E0B RID: 7691
	[Token(Token = "0x4001891")]
	[FieldOffset(Offset = "0x208")]
	public float attackLengthMax;

	// Token: 0x04001E0C RID: 7692
	[Token(Token = "0x4001892")]
	[FieldOffset(Offset = "0x20C")]
	public float attackSpacing;

	// Token: 0x04001E0D RID: 7693
	[Token(Token = "0x4001893")]
	[FieldOffset(Offset = "0x210")]
	public float aiAimSwayOffset;

	// Token: 0x04001E0E RID: 7694
	[Token(Token = "0x4001894")]
	[FieldOffset(Offset = "0x214")]
	public float aiAimCone;

	// Token: 0x04001E0F RID: 7695
	[Token(Token = "0x4001895")]
	[FieldOffset(Offset = "0x218")]
	public bool aiOnlyInRange;

	// Token: 0x04001E10 RID: 7696
	[Token(Token = "0x4001896")]
	[FieldOffset(Offset = "0x21C")]
	public float CloseRangeAddition;

	// Token: 0x04001E11 RID: 7697
	[Token(Token = "0x4001897")]
	[FieldOffset(Offset = "0x220")]
	public float MediumRangeAddition;

	// Token: 0x04001E12 RID: 7698
	[Token(Token = "0x4001898")]
	[FieldOffset(Offset = "0x224")]
	public float LongRangeAddition;

	// Token: 0x04001E13 RID: 7699
	[Token(Token = "0x4001899")]
	[FieldOffset(Offset = "0x228")]
	public bool CanUseAtMediumRange;

	// Token: 0x04001E14 RID: 7700
	[Token(Token = "0x400189A")]
	[FieldOffset(Offset = "0x229")]
	public bool CanUseAtLongRange;

	// Token: 0x04001E15 RID: 7701
	[Token(Token = "0x400189B")]
	[FieldOffset(Offset = "0x230")]
	public SoundDefinition[] reloadSounds;

	// Token: 0x04001E16 RID: 7702
	[Token(Token = "0x400189C")]
	[FieldOffset(Offset = "0x238")]
	public SoundDefinition thirdPersonMeleeSound;

	// Token: 0x04001E17 RID: 7703
	[Token(Token = "0x400189D")]
	[FieldOffset(Offset = "0x240")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xCFD90", Offset = "0xCF190")]
	public float recoilCompDelayOverride;

	// Token: 0x04001E18 RID: 7704
	[Token(Token = "0x400189E")]
	[FieldOffset(Offset = "0x244")]
	public bool wantsRecoilComp;

	// Token: 0x04001E19 RID: 7705
	[Token(Token = "0x400189F")]
	[FieldOffset(Offset = "0x248")]
	private float nextAttackTime;

	// Token: 0x04001E1A RID: 7706
	[Token(Token = "0x40018A0")]
	[FieldOffset(Offset = "0x24C")]
	private float lastTickTime;

	// Token: 0x04001E1B RID: 7707
	[Token(Token = "0x40018A1")]
	[FieldOffset(Offset = "0x250")]
	private float nextTickTime;

	// Token: 0x04001E1C RID: 7708
	[Token(Token = "0x40018A2")]
	[FieldOffset(Offset = "0x254")]
	private float timeSinceDeploy;

	// Token: 0x04001E1D RID: 7709
	[Token(Token = "0x40018A3")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 reductionSpeedScalars;

	// Token: 0x04001E1E RID: 7710
	[Token(Token = "0x40018A4")]
	[FieldOffset(Offset = "0x258")]
	private float lastRecoilCompTime;

	// Token: 0x04001E1F RID: 7711
	[Token(Token = "0x40018A5")]
	[FieldOffset(Offset = "0x25C")]
	private Vector3 startAimingDirection;

	// Token: 0x04001E20 RID: 7712
	[Token(Token = "0x40018A6")]
	[FieldOffset(Offset = "0x268")]
	private bool wasDoingRecoilComp;

	// Token: 0x04001E21 RID: 7713
	[Token(Token = "0x40018A7")]
	[FieldOffset(Offset = "0x26C")]
	private Vector3 reductionSpeed;
}
