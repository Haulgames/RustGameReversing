using System;
using Il2CppDummyDll;

// Token: 0x020001ED RID: 493
[Token(Token = "0x200013D")]
public class DestroyArcadeEntity : BaseMonoBehaviour
{
	// Token: 0x06001714 RID: 5908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D2")]
	[Address(RVA = "0xB69510", Offset = "0xB68310", VA = "0x180B69510")]
	private void Start()
	{
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D3")]
	[Address(RVA = "0xB69460", Offset = "0xB68260", VA = "0x180B69460")]
	private void DestroyAction()
	{
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0xB695B0", Offset = "0xB683B0", VA = "0x180B695B0")]
	public DestroyArcadeEntity()
	{
	}

	// Token: 0x040010DD RID: 4317
	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0x18")]
	public ArcadeEntity ent;

	// Token: 0x040010DE RID: 4318
	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x20")]
	public float TimeToDie;

	// Token: 0x040010DF RID: 4319
	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x24")]
	public float TimeToDieVariance;
}
