using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007AD RID: 1965
[Token(Token = "0x20005B5")]
public class DecorPatch
{
	// Token: 0x06003112 RID: 12562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600296E")]
	[Address(RVA = "0x8BDEC0", Offset = "0x8BCCC0", VA = "0x1808BDEC0")]
	public void DestroyInstances()
	{
	}

	// Token: 0x06003113 RID: 12563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600296F")]
	[Address(RVA = "0x8BEAF0", Offset = "0x8BD8F0", VA = "0x1808BEAF0")]
	public DecorPatch(DecorSpawn decorSpawn, int i, int j)
	{
	}

	// Token: 0x06003114 RID: 12564 RVA: 0x00015078 File Offset: 0x00013278
	[Token(Token = "0x6002970")]
	[Address(RVA = "0x8BDFE0", Offset = "0x8BCDE0", VA = "0x1808BDFE0")]
	public bool Shift()
	{
		return default(bool);
	}

	// Token: 0x06003115 RID: 12565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002971")]
	[Address(RVA = "0x8BE2F0", Offset = "0x8BD0F0", VA = "0x1808BE2F0")]
	public void Spawn()
	{
	}

	// Token: 0x04002DE2 RID: 11746
	[Token(Token = "0x400243A")]
	[FieldOffset(Offset = "0x10")]
	private bool initialized;

	// Token: 0x04002DE3 RID: 11747
	[Token(Token = "0x400243B")]
	[FieldOffset(Offset = "0x14")]
	private float LOD;

	// Token: 0x04002DE4 RID: 11748
	[Token(Token = "0x400243C")]
	[FieldOffset(Offset = "0x18")]
	private float shift;

	// Token: 0x04002DE5 RID: 11749
	[Token(Token = "0x400243D")]
	[FieldOffset(Offset = "0x1C")]
	private float extent;

	// Token: 0x04002DE6 RID: 11750
	[Token(Token = "0x400243E")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 offset;

	// Token: 0x04002DE7 RID: 11751
	[Token(Token = "0x400243F")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 position;

	// Token: 0x04002DE8 RID: 11752
	[Token(Token = "0x4002440")]
	[FieldOffset(Offset = "0x38")]
	private DecorSpawn decorSpawn;

	// Token: 0x04002DE9 RID: 11753
	[Token(Token = "0x4002441")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> spawns;
}
