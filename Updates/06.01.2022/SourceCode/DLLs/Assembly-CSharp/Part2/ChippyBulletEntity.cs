using System;
using Il2CppDummyDll;

// Token: 0x020001EA RID: 490
[Token(Token = "0x200013A")]
public class ChippyBulletEntity : SpriteArcadeEntity
{
	// Token: 0x0600170C RID: 5900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x4DED20", Offset = "0x4DDB20", VA = "0x1804DED20")]
	public void FixedUpdate()
	{
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x4DE310", Offset = "0x4DD110", VA = "0x1804DE310", Slot = "9")]
	public override void AuthorativeThink(float delta)
	{
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x4DED60", Offset = "0x4DDB60", VA = "0x1804DED60")]
	public ChippyBulletEntity()
	{
	}

	// Token: 0x040010D0 RID: 4304
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0x98")]
	public float speed;

	// Token: 0x040010D1 RID: 4305
	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x9C")]
	public float maxSpeed;

	// Token: 0x040010D2 RID: 4306
	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0xA0")]
	public float radius;

	// Token: 0x040010D3 RID: 4307
	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0xA4")]
	public float damage;

	// Token: 0x040010D4 RID: 4308
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0xA8")]
	public ArcadeEntity bulletImpact;
}
