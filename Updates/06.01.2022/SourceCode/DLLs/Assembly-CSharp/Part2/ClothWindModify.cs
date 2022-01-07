using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008FD RID: 2301
[Token(Token = "0x2000679")]
public class ClothWindModify : FacepunchBehaviour
{
	// Token: 0x060037EB RID: 14315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F19")]
	[Address(RVA = "0x49BA50", Offset = "0x49A850", VA = "0x18049BA50")]
	public void Awake()
	{
	}

	// Token: 0x060037EC RID: 14316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x49BB00", Offset = "0x49A900", VA = "0x18049BB00")]
	public void DoWind()
	{
	}

	// Token: 0x060037ED RID: 14317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x49BE40", Offset = "0x49AC40", VA = "0x18049BE40")]
	public ClothWindModify()
	{
	}

	// Token: 0x04003453 RID: 13395
	[Token(Token = "0x4002861")]
	[FieldOffset(Offset = "0x18")]
	public Cloth cloth;

	// Token: 0x04003454 RID: 13396
	[Token(Token = "0x4002862")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 initialClothForce;

	// Token: 0x04003455 RID: 13397
	[Token(Token = "0x4002863")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 worldWindScale;

	// Token: 0x04003456 RID: 13398
	[Token(Token = "0x4002864")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 turbulenceScale;
}
