using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rust;

// Token: 0x020005E5 RID: 1509
[Token(Token = "0x2000468")]
public class EffectDictionary
{
	// Token: 0x06002A02 RID: 10754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600232C")]
	[Address(RVA = "0x985090", Offset = "0x983E90", VA = "0x180985090")]
	public static string GetParticle(string impactType, string materialName)
	{
		return null;
	}

	// Token: 0x06002A03 RID: 10755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600232D")]
	[Address(RVA = "0x984F70", Offset = "0x983D70", VA = "0x180984F70")]
	public static string GetParticle(DamageType damageType, string materialName)
	{
		return null;
	}

	// Token: 0x06002A04 RID: 10756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600232E")]
	[Address(RVA = "0x984D70", Offset = "0x983B70", VA = "0x180984D70")]
	public static string GetDecal(string impactType, string materialName)
	{
		return null;
	}

	// Token: 0x06002A05 RID: 10757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600232F")]
	[Address(RVA = "0x984DE0", Offset = "0x983BE0", VA = "0x180984DE0")]
	public static string GetDecal(DamageType damageType, string materialName)
	{
		return null;
	}

	// Token: 0x06002A06 RID: 10758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002330")]
	[Address(RVA = "0x984F00", Offset = "0x983D00", VA = "0x180984F00")]
	public static string GetDisplacement(string impactType, string materialName)
	{
		return null;
	}

	// Token: 0x06002A07 RID: 10759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002331")]
	[Address(RVA = "0x985100", Offset = "0x983F00", VA = "0x180985100")]
	private static string LookupEffect(string category, string effect, string material)
	{
		return null;
	}

	// Token: 0x06002A08 RID: 10760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002332")]
	[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
	public EffectDictionary()
	{
	}

	// Token: 0x04002551 RID: 9553
	[Token(Token = "0x4001E7A")]
	[FieldOffset(Offset = "0x18DC")]
	private static Dictionary<string, string[]> effectDictionary;
}
