using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027A RID: 634
[Token(Token = "0x20001B9")]
public class AnimalRagdoll : Ragdoll
{
	// Token: 0x0600195D RID: 6493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x831700", Offset = "0x830500", VA = "0x180831700")]
	public AnimalRagdoll()
	{
	}

	// Token: 0x04001390 RID: 5008
	[Token(Token = "0x4001012")]
	[FieldOffset(Offset = "0x98")]
	public SkinnedMeshRenderer[] bodyRenderers;

	// Token: 0x04001391 RID: 5009
	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0xA0")]
	public SkinnedMeshRenderer[] hairRenderers;
}
