using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000335 RID: 821
[Token(Token = "0x2000248")]
public class AnimalAnimation : MonoBehaviour, IClientComponent
{
	// Token: 0x06001CC3 RID: 7363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171D")]
	[Address(RVA = "0x830F50", Offset = "0x82FD50", VA = "0x180830F50")]
	private void Update()
	{
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
	[Token(Token = "0x600171E")]
	[Address(RVA = "0x830E50", Offset = "0x82FC50", VA = "0x180830E50")]
	public bool ShouldPlayFootstep(AnimationEvent evt)
	{
		return default(bool);
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171F")]
	[Address(RVA = "0x830860", Offset = "0x82F660", VA = "0x180830860")]
	private void FrontLeftFootstep(AnimationEvent evt)
	{
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001720")]
	[Address(RVA = "0x8308C0", Offset = "0x82F6C0", VA = "0x1808308C0")]
	private void FrontRightFootstep(AnimationEvent evt)
	{
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001721")]
	[Address(RVA = "0x830540", Offset = "0x82F340", VA = "0x180830540")]
	private void BackLeftFootstep(AnimationEvent evt)
	{
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001722")]
	[Address(RVA = "0x8305A0", Offset = "0x82F3A0", VA = "0x1808305A0")]
	private void BackRightFootstep(AnimationEvent evt)
	{
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001723")]
	[Address(RVA = "0x830600", Offset = "0x82F400", VA = "0x180830600")]
	private void Footstep(Transform tx)
	{
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001724")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	private void DoEffect(string effect)
	{
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001725")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	private void PlayEffect(string effect)
	{
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001726")]
	[Address(RVA = "0x830C60", Offset = "0x82FA60", VA = "0x180830C60")]
	public void PlaySound(string soundName)
	{
	}

	// Token: 0x06001CCD RID: 7373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001727")]
	[Address(RVA = "0x830C10", Offset = "0x82FA10", VA = "0x180830C10")]
	public void PlaySoundDef(SoundDefinition def)
	{
	}

	// Token: 0x06001CCE RID: 7374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001728")]
	[Address(RVA = "0x830920", Offset = "0x82F720", VA = "0x180830920")]
	private void PlaySaddleMovementSound()
	{
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001729")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public AnimalAnimation()
	{
	}

	// Token: 0x040017C4 RID: 6084
	[Token(Token = "0x4001362")]
	[FieldOffset(Offset = "0x18")]
	public BaseEntity Entity;

	// Token: 0x040017C5 RID: 6085
	[Token(Token = "0x4001363")]
	[FieldOffset(Offset = "0x20")]
	public BaseNpc Target;

	// Token: 0x040017C6 RID: 6086
	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0x28")]
	public Animator Animator;

	// Token: 0x040017C7 RID: 6087
	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0x30")]
	public MaterialEffect FootstepEffects;

	// Token: 0x040017C8 RID: 6088
	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0x38")]
	public Transform[] Feet;

	// Token: 0x040017C9 RID: 6089
	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x40")]
	public SoundDefinition saddleMovementSoundDef;

	// Token: 0x040017CA RID: 6090
	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0x48")]
	public SoundDefinition saddleMovementSoundDefWood;

	// Token: 0x040017CB RID: 6091
	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0x50")]
	public SoundDefinition saddleMovementSoundDefRoadsign;

	// Token: 0x040017CC RID: 6092
	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve saddleMovementGainCurve;

	// Token: 0x040017CD RID: 6093
	[Token(Token = "0x400136B")]
	[FieldOffset(Offset = "0x60")]
	[ReadOnly]
	public string BaseFolder;

	// Token: 0x040017CE RID: 6094
	[Token(Token = "0x400136C")]
	public const BaseEntity.Flags Flag_WoodArmor = BaseEntity.Flags.Reserved5;

	// Token: 0x040017CF RID: 6095
	[Token(Token = "0x400136D")]
	public const BaseEntity.Flags Flag_RoadsignArmor = BaseEntity.Flags.Reserved6;

	// Token: 0x040017D0 RID: 6096
	[Token(Token = "0x400136E")]
	[FieldOffset(Offset = "0x68")]
	private float lastThinkTime;

	// Token: 0x040017D1 RID: 6097
	[Token(Token = "0x400136F")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 previousPosition;

	// Token: 0x040017D2 RID: 6098
	[Token(Token = "0x4001370")]
	[FieldOffset(Offset = "0x78")]
	private float previousRotationYaw;

	// Token: 0x040017D3 RID: 6099
	[Token(Token = "0x4001371")]
	[FieldOffset(Offset = "0x7C")]
	private bool wasSleeping;

	// Token: 0x02000336 RID: 822
	[Token(Token = "0x2000B22")]
	protected static class Params
	{
		// Token: 0x040017D4 RID: 6100
		[Token(Token = "0x4004178")]
		[FieldOffset(Offset = "0x0")]
		public static int WalkSpeed;

		// Token: 0x040017D5 RID: 6101
		[Token(Token = "0x4004179")]
		[FieldOffset(Offset = "0x4")]
		public static int Sleeping;
	}
}
