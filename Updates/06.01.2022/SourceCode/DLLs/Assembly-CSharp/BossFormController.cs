using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E5 RID: 485
[Token(Token = "0x2000137")]
public class BossFormController : ArcadeEntityController
{
	// Token: 0x060016E5 RID: 5861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x465B70", Offset = "0x464970", VA = "0x180465B70", Slot = "6")]
	public override void Initialize()
	{
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x465BF0", Offset = "0x4649F0", VA = "0x180465BF0")]
	public bool MainCoreVulnerable()
	{
		return default(bool);
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x4657D0", Offset = "0x4645D0", VA = "0x1804657D0")]
	public BossFormController.BossDamagePoint GetDamagePointFromCollider(Collider collider)
	{
		return null;
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x4658B0", Offset = "0x4646B0", VA = "0x1804658B0")]
	public void Hurt(float damage, Vector3 hitPos, Collider collider)
	{
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x465C60", Offset = "0x464A60", VA = "0x180465C60")]
	public void RemoveMe()
	{
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x465420", Offset = "0x464220", VA = "0x180465420")]
	public void Animate()
	{
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x465DE0", Offset = "0x464BE0", VA = "0x180465DE0")]
	public void UpdateDamagePositions()
	{
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x465CC0", Offset = "0x464AC0", VA = "0x180465CC0", Slot = "7")]
	public override void Shutdown()
	{
	}

	// Token: 0x060016ED RID: 5869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x4654B0", Offset = "0x4642B0", VA = "0x1804654B0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x465F50", Offset = "0x464D50", VA = "0x180465F50")]
	public BossFormController()
	{
	}

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x4000D65")]
	[FieldOffset(Offset = "0x38")]
	public float animationSpeed;

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0x40")]
	public Sprite[] animationFrames;

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x4000D67")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 roamDistance;

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x4000D68")]
	[FieldOffset(Offset = "0x50")]
	public Transform colliderParent;

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x4000D69")]
	[FieldOffset(Offset = "0x58")]
	public BossFormController.BossDamagePoint[] damagePoints;

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x4000D6A")]
	[FieldOffset(Offset = "0x60")]
	public ArcadeEntityController flashController;

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0x68")]
	public float health;

	// Token: 0x040010A3 RID: 4259
	[Token(Token = "0x4000D6C")]
	[FieldOffset(Offset = "0x6C")]
	private int currentFrame;

	// Token: 0x040010A4 RID: 4260
	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x70")]
	private int animDirection;

	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x2000AE4")]
	[Serializable]
	public class BossDamagePoint
	{
		// Token: 0x060016EF RID: 5871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBE")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public BossDamagePoint()
		{
		}

		// Token: 0x040010A5 RID: 4261
		[Token(Token = "0x4004055")]
		[FieldOffset(Offset = "0x10")]
		public BoxCollider hitBox;

		// Token: 0x040010A6 RID: 4262
		[Token(Token = "0x4004056")]
		[FieldOffset(Offset = "0x18")]
		public float health;

		// Token: 0x040010A7 RID: 4263
		[Token(Token = "0x4004057")]
		[FieldOffset(Offset = "0x20")]
		public ArcadeEntityController damagePrefab;

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x4004058")]
		[FieldOffset(Offset = "0x28")]
		public ArcadeEntityController damageInstance;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x4004059")]
		[FieldOffset(Offset = "0x30")]
		public bool destroyed;
	}
}
