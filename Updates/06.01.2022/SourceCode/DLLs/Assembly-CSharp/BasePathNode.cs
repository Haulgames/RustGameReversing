using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000245 RID: 581
[Token(Token = "0x2000189")]
public class BasePathNode : MonoBehaviour
{
	// Token: 0x0600186B RID: 6251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001311")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void OnDrawGizmosSelected()
	{
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x2FEDE0", Offset = "0x2FDBE0", VA = "0x1802FEDE0")]
	public BasePathNode()
	{
	}

	// Token: 0x0400127B RID: 4731
	[Token(Token = "0x4000F07")]
	[FieldOffset(Offset = "0x18")]
	public BasePath Path;

	// Token: 0x0400127C RID: 4732
	[Token(Token = "0x4000F08")]
	[FieldOffset(Offset = "0x20")]
	public List<BasePathNode> linked;

	// Token: 0x0400127D RID: 4733
	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x28")]
	public float maxVelocityOnApproach;

	// Token: 0x0400127E RID: 4734
	[Token(Token = "0x4000F0A")]
	[FieldOffset(Offset = "0x2C")]
	public bool straightaway;
}
