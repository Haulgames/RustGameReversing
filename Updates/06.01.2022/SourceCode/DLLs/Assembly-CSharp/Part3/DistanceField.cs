using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B77 RID: 2935
[Token(Token = "0x2000836")]
public class DistanceField
{
	// Token: 0x060043E3 RID: 17379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600394B")]
	[Address(RVA = "0xB75DD0", Offset = "0xB74BD0", VA = "0x180B75DD0")]
	public static void Generate(in int size, in byte threshold, in byte[] image, ref float[] distanceField)
	{
	}

	// Token: 0x060043E4 RID: 17380 RVA: 0x00019338 File Offset: 0x00017538
	[Token(Token = "0x600394C")]
	[Address(RVA = "0xB76CB0", Offset = "0xB75AB0", VA = "0x180B76CB0")]
	private static float SampleClamped(float[] data, int size, int x, int y)
	{
		return 0f;
	}

	// Token: 0x060043E5 RID: 17381 RVA: 0x00019350 File Offset: 0x00017550
	[Token(Token = "0x600394D")]
	[Address(RVA = "0xB76C30", Offset = "0xB75A30", VA = "0x180B76C30")]
	private static Vector3 SampleClamped(Vector3[] data, int size, int x, int y)
	{
		return default(Vector3);
	}

	// Token: 0x060043E6 RID: 17382 RVA: 0x00019368 File Offset: 0x00017568
	[Token(Token = "0x600394E")]
	[Address(RVA = "0xB76BD0", Offset = "0xB759D0", VA = "0x180B76BD0")]
	private static ushort SampleClamped(ushort[] data, int size, int x, int y)
	{
		return 0;
	}

	// Token: 0x060043E7 RID: 17383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600394F")]
	[Address(RVA = "0xB756A0", Offset = "0xB744A0", VA = "0x180B756A0")]
	public static void GenerateVectors(in int size, in float[] distanceField, ref Vector3[] vectorField)
	{
	}

	// Token: 0x060043E8 RID: 17384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003950")]
	[Address(RVA = "0xB752B0", Offset = "0xB740B0", VA = "0x180B752B0")]
	public static void ApplyGaussianBlur(int size, float[] distanceField, int steps = 1)
	{
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003951")]
	[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
	public DistanceField()
	{
	}

	// Token: 0x040040D0 RID: 16592
	[Token(Token = "0x40031F0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] GaussOffsets;

	// Token: 0x040040D1 RID: 16593
	[Token(Token = "0x40031F1")]
	[FieldOffset(Offset = "0x8")]
	private static readonly float[] GaussWeights;
}
