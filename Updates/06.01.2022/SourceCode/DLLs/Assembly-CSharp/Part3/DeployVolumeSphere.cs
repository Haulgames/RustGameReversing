using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005E0 RID: 1504
[Token(Token = "0x2000463")]
public class DeployVolumeSphere : DeployVolume
{
	// Token: 0x060029F7 RID: 10743 RVA: 0x000123C0 File Offset: 0x000105C0
	[Token(Token = "0x6002321")]
	[Address(RVA = "0xB61EB0", Offset = "0xB60CB0", VA = "0x180B61EB0", Slot = "8")]
	protected override bool Check(Vector3 position, Quaternion rotation, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029F8 RID: 10744 RVA: 0x000123D8 File Offset: 0x000105D8
	[Token(Token = "0x6002322")]
	[Address(RVA = "0xB62190", Offset = "0xB60F90", VA = "0x180B62190", Slot = "9")]
	protected override bool Check(Vector3 position, Quaternion rotation, OBB obb, int mask = -1)
	{
		return default(bool);
	}

	// Token: 0x060029F9 RID: 10745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002323")]
	[Address(RVA = "0xB62430", Offset = "0xB61230", VA = "0x180B62430")]
	public DeployVolumeSphere()
	{
	}

	// Token: 0x04002544 RID: 9540
	[Token(Token = "0x4001E6D")]
	[FieldOffset(Offset = "0xB0")]
	public Vector3 center;

	// Token: 0x04002545 RID: 9541
	[Token(Token = "0x4001E6E")]
	[FieldOffset(Offset = "0xBC")]
	public float radius;
}
