using System;
using Il2CppDummyDll;

// Token: 0x02000B65 RID: 2917
[Token(Token = "0x2000825")]
public static class ArrayEx
{
	// Token: 0x060043AD RID: 17325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003918")]
	public static T[] New<T>(int length)
	{
		return null;
	}

	// Token: 0x060043AE RID: 17326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003919")]
	public static T GetRandom<T>(this T[] array)
	{
		return null;
	}

	// Token: 0x060043AF RID: 17327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600391A")]
	public static T GetRandom<T>(this T[] array, uint seed)
	{
		return null;
	}

	// Token: 0x060043B0 RID: 17328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600391B")]
	public static T GetRandom<T>(this T[] array, ref uint seed)
	{
		return null;
	}

	// Token: 0x060043B1 RID: 17329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391C")]
	public static void Shuffle<T>(this T[] array, uint seed)
	{
	}

	// Token: 0x060043B2 RID: 17330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391D")]
	public static void Shuffle<T>(this T[] array, ref uint seed)
	{
	}

	// Token: 0x060043B3 RID: 17331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391E")]
	public static void BubbleSort<T>(this T[] array) where T : IComparable<T>
	{
	}
}
