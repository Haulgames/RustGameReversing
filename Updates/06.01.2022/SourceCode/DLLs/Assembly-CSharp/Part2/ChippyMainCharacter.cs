using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EB RID: 491
[Token(Token = "0x200013B")]
public class ChippyMainCharacter : SpriteArcadeEntity
{
	// Token: 0x0600170F RID: 5903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x4DF130", Offset = "0x4DDF30", VA = "0x1804DF130", Slot = "8")]
	public override void OnKilled()
	{
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x4DED90", Offset = "0x4DDB90", VA = "0x1804DED90", Slot = "9")]
	public override void AuthorativeThink(float delta)
	{
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x4DF190", Offset = "0x4DDF90", VA = "0x1804DF190")]
	public ChippyMainCharacter()
	{
	}

	// Token: 0x040010D5 RID: 4309
	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x98")]
	public float speed;

	// Token: 0x040010D6 RID: 4310
	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0x9C")]
	public float maxSpeed;

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0xA0")]
	public ChippyBulletEntity bulletPrefab;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x4000D97")]
	[FieldOffset(Offset = "0xA8")]
	public float fireRate;

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 aimDir;
}
