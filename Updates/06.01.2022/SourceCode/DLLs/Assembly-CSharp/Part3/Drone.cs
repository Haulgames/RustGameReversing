using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200019C RID: 412
[Token(Token = "0x20000FA")]
public class Drone : RemoteControlEntity
{
	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06001577 RID: 5495 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
	[Token(Token = "0x1700017E")]
	public override bool RequiresMouse
	{
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "156")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104E")]
	[Address(RVA = "0x97C3C0", Offset = "0x97B1C0", VA = "0x18097C3C0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104F")]
	[Address(RVA = "0x97C480", Offset = "0x97B280", VA = "0x18097C480", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001050")]
	[Address(RVA = "0x97C550", Offset = "0x97B350", VA = "0x18097C550")]
	private void PlayMovementStopSound()
	{
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001051")]
	[Address(RVA = "0x97C910", Offset = "0x97B710", VA = "0x18097C910")]
	private void UpdateSounds()
	{
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x97C6A0", Offset = "0x97B4A0", VA = "0x18097C6A0")]
	private void SetMovementLoopSound(SoundDefinition targetDef)
	{
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x97CAD0", Offset = "0x97B8D0", VA = "0x18097CAD0")]
	public Drone()
	{
	}

	// Token: 0x04000F13 RID: 3859
	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x2A8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x9D820", Offset = "0x9CC20")]
	public Rigidbody body;

	// Token: 0x04000F14 RID: 3860
	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0x2B0")]
	public bool killInWater;

	// Token: 0x04000F15 RID: 3861
	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x2B1")]
	public bool enableGrounding;

	// Token: 0x04000F16 RID: 3862
	[Token(Token = "0x4000C0F")]
	[FieldOffset(Offset = "0x2B2")]
	public bool keepAboveTerrain;

	// Token: 0x04000F17 RID: 3863
	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0x2B4")]
	public float groundTraceDist;

	// Token: 0x04000F18 RID: 3864
	[Token(Token = "0x4000C11")]
	[FieldOffset(Offset = "0x2B8")]
	public float altitudeAcceleration;

	// Token: 0x04000F19 RID: 3865
	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x2BC")]
	public float movementAcceleration;

	// Token: 0x04000F1A RID: 3866
	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x2C0")]
	public float yawSpeed;

	// Token: 0x04000F1B RID: 3867
	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0x2C4")]
	public float uprightSpeed;

	// Token: 0x04000F1C RID: 3868
	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x2C8")]
	public float uprightPrediction;

	// Token: 0x04000F1D RID: 3869
	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x2CC")]
	public float uprightDot;

	// Token: 0x04000F1E RID: 3870
	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0x2D0")]
	public float leanWeight;

	// Token: 0x04000F1F RID: 3871
	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0x2D4")]
	public float leanMaxVelocity;

	// Token: 0x04000F20 RID: 3872
	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0x2D8")]
	public float hurtVelocityThreshold;

	// Token: 0x04000F21 RID: 3873
	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0x2DC")]
	public float hurtDamagePower;

	// Token: 0x04000F22 RID: 3874
	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0x2E0")]
	public float collisionDisableTime;

	// Token: 0x04000F23 RID: 3875
	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0x2E8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x748A0", Offset = "0x73CA0")]
	public SoundDefinition movementLoopSoundDef;

	// Token: 0x04000F24 RID: 3876
	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0x2F0")]
	public SoundDefinition movementStartSoundDef;

	// Token: 0x04000F25 RID: 3877
	[Token(Token = "0x4000C1E")]
	[FieldOffset(Offset = "0x2F8")]
	public SoundDefinition movementStopSoundDef;

	// Token: 0x04000F26 RID: 3878
	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0x300")]
	public AnimationCurve movementLoopPitchCurve;

	// Token: 0x04000F27 RID: 3879
	[Token(Token = "0x4000C20")]
	[FieldOffset(Offset = "0x308")]
	private Sound movementLoopSound;

	// Token: 0x04000F28 RID: 3880
	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0x310")]
	private SoundModulation.Modulator movementLoopPitch;

	// Token: 0x0200019D RID: 413
	[Token(Token = "0x2000AD8")]
	private struct DroneInputState
	{
		// Token: 0x0600157E RID: 5502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0xF5B30", Offset = "0xF4F30", VA = "0x1800F5B30")]
		public void Reset()
		{
		}

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4004025")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 movement;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4004026")]
		[FieldOffset(Offset = "0xC")]
		public float throttle;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4004027")]
		[FieldOffset(Offset = "0x10")]
		public float pitch;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4004028")]
		[FieldOffset(Offset = "0x14")]
		public float yaw;
	}
}
