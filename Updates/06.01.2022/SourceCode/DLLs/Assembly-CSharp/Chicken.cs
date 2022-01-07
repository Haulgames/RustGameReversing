using System;
using Il2CppDummyDll;

// Token: 0x02000277 RID: 631
[Token(Token = "0x20001B6")]
public class Chicken : BaseAnimalNPC
{
	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06001953 RID: 6483 RVA: 0x0000CE40 File Offset: 0x0000B040
	[Token(Token = "0x1700019E")]
	public override float RealisticMass
	{
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x4DAB00", Offset = "0x4D9900", VA = "0x1804DAB00", Slot = "76")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06001954 RID: 6484 RVA: 0x0000CE58 File Offset: 0x0000B058
	[Token(Token = "0x1700019F")]
	public override BaseEntity.TraitFlag Traits
	{
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x4581D0", Offset = "0x456FD0", VA = "0x1804581D0", Slot = "86")]
		get
		{
			return BaseEntity.TraitFlag.None;
		}
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F4")]
	[Address(RVA = "0x4DAA90", Offset = "0x4D9890", VA = "0x1804DAA90", Slot = "121")]
	public override string Categorize()
	{
		return null;
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x4581B0", Offset = "0x456FB0", VA = "0x1804581B0")]
	public Chicken()
	{
	}

	// Token: 0x04001380 RID: 4992
	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0x1710")]
	[ServerVar]
	public static float Population;
}
