using System;
using Il2CppDummyDll;

// Token: 0x02000275 RID: 629
[Token(Token = "0x20001B4")]
public class Bear : BaseAnimalNPC
{
	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06001949 RID: 6473 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
	[Token(Token = "0x1700019A")]
	public override float RealisticMass
	{
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x4581C0", Offset = "0x456FC0", VA = "0x1804581C0", Slot = "76")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x0600194A RID: 6474 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
	[Token(Token = "0x1700019B")]
	public override BaseEntity.TraitFlag Traits
	{
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x4581D0", Offset = "0x456FD0", VA = "0x1804581D0", Slot = "86")]
		get
		{
			return BaseEntity.TraitFlag.None;
		}
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x458140", Offset = "0x456F40", VA = "0x180458140", Slot = "121")]
	public override string Categorize()
	{
		return null;
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x4581B0", Offset = "0x456FB0", VA = "0x1804581B0")]
	public Bear()
	{
	}

	// Token: 0x0400137E RID: 4990
	[Token(Token = "0x4001000")]
	[FieldOffset(Offset = "0x1700")]
	[ServerVar]
	public static float Population;
}
