using System;
using Il2CppDummyDll;

// Token: 0x02000276 RID: 630
[Token(Token = "0x20001B5")]
public class Boar : BaseAnimalNPC
{
	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x0600194E RID: 6478 RVA: 0x0000CE10 File Offset: 0x0000B010
	[Token(Token = "0x1700019C")]
	public override float RealisticMass
	{
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x4607E0", Offset = "0x45F5E0", VA = "0x1804607E0", Slot = "76")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x0600194F RID: 6479 RVA: 0x0000CE28 File Offset: 0x0000B028
	[Token(Token = "0x1700019D")]
	public override BaseEntity.TraitFlag Traits
	{
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x4581D0", Offset = "0x456FD0", VA = "0x1804581D0", Slot = "86")]
		get
		{
			return BaseEntity.TraitFlag.None;
		}
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x460770", Offset = "0x45F570", VA = "0x180460770", Slot = "121")]
	public override string Categorize()
	{
		return null;
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x4581B0", Offset = "0x456FB0", VA = "0x1804581B0")]
	public Boar()
	{
	}

	// Token: 0x0400137F RID: 4991
	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0x29CE408")]
	[ServerVar]
	public static float Population;
}
