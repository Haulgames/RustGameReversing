using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005DC RID: 1500
[Token(Token = "0x200045F")]
public class DeployVolumeCapsule : DeployVolume
{
	// Token: 0x060029E9 RID: 10729 RVA: 0x00012300 File Offset: 0x00010500
	[Token(Token = "0x6002313")]
	[Address(RVA = "0xB60240", Offset = "0xB5F040", VA = "0x180B60240", Slot = "8")]
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029EA RID: 10730 RVA: 0x00012318 File Offset: 0x00010518
	[Token(Token = "0x6002314")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "9")]
	protected override bool Check(Vector3 position, Quaternion rotation, OBB obb, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029EB RID: 10731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002315")]
	[Address(RVA = "0xB60750", Offset = "0xB5F550", VA = "0x180B60750")]
	public DeployVolumeCapsule()
	{
	}

	// Token: 0x0400253D RID: 9533
	[Token(Token = "0x4001E66")]
	[FieldOffset(Offset = "0xB0")]
	public Vector3 center;

	// Token: 0x0400253E RID: 9534
	[Token(Token = "0x4001E67")]
	[FieldOffset(Offset = "0xBC")]
	public float radius;

	// Token: 0x0400253F RID: 9535
	[Token(Token = "0x4001E68")]
	[FieldOffset(Offset = "0xC0")]
	public float height;
}
