using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200056A RID: 1386
[Token(Token = "0x2000405")]
public class BuoyancyPoint : MonoBehaviour
{
	// Token: 0x0600280A RID: 10250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600216F")]
	[Address(RVA = "0x641330", Offset = "0x640130", VA = "0x180641330")]
	public void Start()
	{
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002170")]
	[Address(RVA = "0x641260", Offset = "0x640060", VA = "0x180641260")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x0600280C RID: 10252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002171")]
	[Address(RVA = "0x6413E0", Offset = "0x6401E0", VA = "0x1806413E0")]
	public BuoyancyPoint()
	{
	}

	// Token: 0x0400233E RID: 9022
	[Token(Token = "0x4001CC3")]
	[FieldOffset(Offset = "0x18")]
	public float buoyancyForce;

	// Token: 0x0400233F RID: 9023
	[Token(Token = "0x4001CC4")]
	[FieldOffset(Offset = "0x1C")]
	public float size;

	// Token: 0x04002340 RID: 9024
	[Token(Token = "0x4001CC5")]
	[FieldOffset(Offset = "0x20")]
	public float waveScale;

	// Token: 0x04002341 RID: 9025
	[Token(Token = "0x4001CC6")]
	[FieldOffset(Offset = "0x24")]
	public float waveFrequency;

	// Token: 0x04002342 RID: 9026
	[Token(Token = "0x4001CC7")]
	[FieldOffset(Offset = "0x28")]
	public bool doSplashEffects;

	// Token: 0x04002343 RID: 9027
	[Token(Token = "0x4001CC8")]
	[FieldOffset(Offset = "0x2C")]
	[NonSerialized]
	public float randomOffset;

	// Token: 0x04002344 RID: 9028
	[Token(Token = "0x4001CC9")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	public bool wasSubmergedLastFrame;

	// Token: 0x04002345 RID: 9029
	[Token(Token = "0x4001CCA")]
	[FieldOffset(Offset = "0x34")]
	[NonSerialized]
	public float nexSplashTime;

	// Token: 0x04002346 RID: 9030
	[Token(Token = "0x4001CCB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color gizmoColour;
}
