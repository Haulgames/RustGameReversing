using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200046F RID: 1135
[Token(Token = "0x2000346")]
public class DiscoFloorColourLookups : PrefabAttribute, IClientComponent
{
	// Token: 0x060022F9 RID: 8953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0xB73B80", Offset = "0xB72980", VA = "0x180B73B80")]
	public float[] GetLookup(DiscoFloorMesh.PatternType pattern)
	{
		return null;
	}

	// Token: 0x060022FA RID: 8954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0xB73A80", Offset = "0xB72880", VA = "0x180B73A80")]
	public Gradient GetColourGradient(int index)
	{
		return null;
	}

	// Token: 0x060022FB RID: 8955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0xB73B20", Offset = "0xB72920", VA = "0x180B73B20", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x060022FC RID: 8956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0xB73BC0", Offset = "0xB729C0", VA = "0x180B73BC0")]
	public DiscoFloorColourLookups()
	{
	}

	// Token: 0x04001D7F RID: 7551
	[Token(Token = "0x4001818")]
	[FieldOffset(Offset = "0x98")]
	public float[] InOutLookup;

	// Token: 0x04001D80 RID: 7552
	[Token(Token = "0x4001819")]
	[FieldOffset(Offset = "0xA0")]
	public float[] RadialLookup;

	// Token: 0x04001D81 RID: 7553
	[Token(Token = "0x400181A")]
	[FieldOffset(Offset = "0xA8")]
	public float[] RippleLookup;

	// Token: 0x04001D82 RID: 7554
	[Token(Token = "0x400181B")]
	[FieldOffset(Offset = "0xB0")]
	public float[] CheckerLookup;

	// Token: 0x04001D83 RID: 7555
	[Token(Token = "0x400181C")]
	[FieldOffset(Offset = "0xB8")]
	public float[] BlockLookup;

	// Token: 0x04001D84 RID: 7556
	[Token(Token = "0x400181D")]
	[FieldOffset(Offset = "0xC0")]
	public Gradient[] ColourGradients;
}
