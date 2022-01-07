using System;
using Il2CppDummyDll;
using Network;

// Token: 0x0200012D RID: 301
[Token(Token = "0x20000AF")]
public class CompoundBowWeapon : BowWeapon
{
	// Token: 0x060011B9 RID: 4537 RVA: 0x0000A4B8 File Offset: 0x000086B8
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x4A5A20", Offset = "0x4A4820", VA = "0x1804A5A20", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x4A61C0", Offset = "0x4A4FC0", VA = "0x1804A61C0")]
	public void UpdateMovementPenalty(float delta)
	{
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x4A5470", Offset = "0x4A4270", VA = "0x1804A5470", Slot = "164")]
	public override void DidAttackClientside()
	{
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x4A56E0", Offset = "0x4A44E0", VA = "0x1804A56E0", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0x4A5640", Offset = "0x4A4440", VA = "0x1804A5640", Slot = "142")]
	public override void OnHolstered()
	{
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x4A5C10", Offset = "0x4A4A10", VA = "0x1804A5C10")]
	public void SetStringHeld(bool isHeld)
	{
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x4A5B10", Offset = "0x4A4910", VA = "0x1804A5B10", Slot = "143")]
	public override void OnViewmodelEvent(string name)
	{
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x0000A4D0 File Offset: 0x000086D0
	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x4A5510", Offset = "0x4A4310", VA = "0x1804A5510")]
	public float GetLastPlayerMovementTime()
	{
		return 0f;
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x0000A4E8 File Offset: 0x000086E8
	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x4A5580", Offset = "0x4A4380", VA = "0x1804A5580")]
	public float GetStringBonusScale()
	{
		return 0f;
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x0000A500 File Offset: 0x00008700
	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x4A5490", Offset = "0x4A4290", VA = "0x1804A5490", Slot = "159")]
	public override float GetDamageScale(bool getMax = false)
	{
		return 0f;
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x0000A518 File Offset: 0x00008718
	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x4A54D0", Offset = "0x4A42D0", VA = "0x1804A54D0", Slot = "160")]
	public override float GetDistanceScale(bool getMax = false)
	{
		return 0f;
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x0000A530 File Offset: 0x00008730
	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x4A5540", Offset = "0x4A4340", VA = "0x1804A5540", Slot = "161")]
	public override float GetProjectileVelocityScale(bool getMax = false)
	{
		return 0f;
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x4A5C80", Offset = "0x4A4A80", VA = "0x1804A5C80")]
	private void StopDrawSounds()
	{
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x4A5DB0", Offset = "0x4A4BB0", VA = "0x1804A5DB0")]
	private void UpdateDrawSounds()
	{
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x4A6350", Offset = "0x4A5150", VA = "0x1804A6350")]
	public CompoundBowWeapon()
	{
	}

	// Token: 0x04000C23 RID: 3107
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x378")]
	public float stringHoldDurationMax;

	// Token: 0x04000C24 RID: 3108
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x37C")]
	public float stringBonusDamage;

	// Token: 0x04000C25 RID: 3109
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x380")]
	public float stringBonusDistance;

	// Token: 0x04000C26 RID: 3110
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x384")]
	public float stringBonusVelocity;

	// Token: 0x04000C27 RID: 3111
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x388")]
	public float movementPenaltyRampUpTime;

	// Token: 0x04000C28 RID: 3112
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x38C")]
	public float conditionLossPerSecondHeld;

	// Token: 0x04000C29 RID: 3113
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x390")]
	public float conditionLossHeldDelay;

	// Token: 0x04000C2A RID: 3114
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x398")]
	public SoundDefinition chargeUpSoundDef;

	// Token: 0x04000C2B RID: 3115
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x3A0")]
	public SoundDefinition stringHeldSoundDef;

	// Token: 0x04000C2C RID: 3116
	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0x3A8")]
	public SoundDefinition drawFinishSoundDef;

	// Token: 0x04000C2D RID: 3117
	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x3B0")]
	private Sound chargeUpSound;

	// Token: 0x04000C2E RID: 3118
	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0x3B8")]
	private Sound stringHeldSound;

	// Token: 0x04000C2F RID: 3119
	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x3C0")]
	protected float movementPenalty;

	// Token: 0x04000C30 RID: 3120
	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x3C4")]
	private float lastMoveTime;

	// Token: 0x04000C31 RID: 3121
	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x3C8")]
	private float currentHoldProgress;

	// Token: 0x04000C32 RID: 3122
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x3CC")]
	internal float stringHoldTimeStart;

	// Token: 0x04000C33 RID: 3123
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x3D0")]
	private bool drawFinishPlayed;
}
