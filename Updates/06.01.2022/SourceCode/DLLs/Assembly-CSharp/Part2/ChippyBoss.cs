using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E8 RID: 488
[Token(Token = "0x2000139")]
public class ChippyBoss : SpriteArcadeEntity
{
	// Token: 0x06001701 RID: 5889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x4DE1E0", Offset = "0x4DCFE0", VA = "0x1804DE1E0")]
	public void SetLevel(int newLevel)
	{
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x4DDFF0", Offset = "0x4DCDF0", VA = "0x1804DDFF0", Slot = "6")]
	public override bool OnEntityMessage(string msg, bool predicted = false)
	{
		return default(bool);
	}

	// Token: 0x06001703 RID: 5891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x4DDE80", Offset = "0x4DCC80", VA = "0x1804DDE80")]
	public void Flash()
	{
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x4DDF70", Offset = "0x4DCD70", VA = "0x1804DDF70", Slot = "11")]
	public override void Initialize()
	{
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x4DE180", Offset = "0x4DCF80", VA = "0x1804DE180")]
	public void RemoveMe()
	{
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x4DD9E0", Offset = "0x4DC7E0", VA = "0x1804DD9E0")]
	public void Animate()
	{
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x4DDED0", Offset = "0x4DCCD0", VA = "0x1804DDED0", Slot = "7")]
	public override void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider)
	{
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x4DE0B0", Offset = "0x4DCEB0", VA = "0x1804DE0B0", Slot = "8")]
	public override void OnKilled()
	{
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x4DDAB0", Offset = "0x4DC8B0", VA = "0x1804DDAB0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x4DE2E0", Offset = "0x4DD0E0", VA = "0x1804DE2E0")]
	public ChippyBoss()
	{
	}

	// Token: 0x040010BF RID: 4287
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x98")]
	public Vector2 roamDistance;

	// Token: 0x040010C0 RID: 4288
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0xA0")]
	public float animationSpeed;

	// Token: 0x040010C1 RID: 4289
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0xA8")]
	public Sprite[] animationFrames;

	// Token: 0x040010C2 RID: 4290
	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0xB0")]
	public ArcadeEntity bulletTest;

	// Token: 0x040010C3 RID: 4291
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0xB8")]
	public SpriteRenderer flashRenderer;

	// Token: 0x040010C4 RID: 4292
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0xC0")]
	public ChippyBoss.BossDamagePoint[] damagePoints;

	// Token: 0x040010C5 RID: 4293
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0xC8")]
	private float moveSpeed;

	// Token: 0x040010C6 RID: 4294
	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0xCC")]
	private int bossLevel;

	// Token: 0x040010C7 RID: 4295
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0xD0")]
	private float fireRate;

	// Token: 0x040010C8 RID: 4296
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0xD4")]
	private int currentFrame;

	// Token: 0x040010C9 RID: 4297
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0xD8")]
	private int animDirection;

	// Token: 0x040010CA RID: 4298
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0xDC")]
	private float nextBulletTime;

	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x2000AE5")]
	[Serializable]
	public class BossDamagePoint
	{
		// Token: 0x0600170B RID: 5899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBF")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public BossDamagePoint()
		{
		}

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x400405A")]
		[FieldOffset(Offset = "0x10")]
		public BoxCollider hitBox;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x400405B")]
		[FieldOffset(Offset = "0x18")]
		public float health;

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x400405C")]
		[FieldOffset(Offset = "0x20")]
		public ArcadeEntityController damagePrefab;

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x400405D")]
		[FieldOffset(Offset = "0x28")]
		public ArcadeEntityController damageInstance;

		// Token: 0x040010CF RID: 4303
		[Token(Token = "0x400405E")]
		[FieldOffset(Offset = "0x30")]
		public bool destroyed;
	}
}
