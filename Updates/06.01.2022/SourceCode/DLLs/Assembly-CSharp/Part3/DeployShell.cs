using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005D9 RID: 1497
[Token(Token = "0x200045D")]
public class DeployShell : PrefabAttribute
{
	// Token: 0x060029DA RID: 10714 RVA: 0x00012228 File Offset: 0x00010428
	[Token(Token = "0x6002304")]
	[Address(RVA = "0xB60010", Offset = "0xB5EE10", VA = "0x180B60010")]
	public OBB WorldSpaceBounds(Transform transform)
	{
		return default(OBB);
	}

	// Token: 0x060029DB RID: 10715 RVA: 0x00012240 File Offset: 0x00010440
	[Token(Token = "0x6002305")]
	[Address(RVA = "0xB60000", Offset = "0xB5EE00", VA = "0x180B60000")]
	public float LineOfSightPadding()
	{
		return 0f;
	}

	// Token: 0x060029DC RID: 10716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002306")]
	[Address(RVA = "0xB5FFA0", Offset = "0xB5EDA0", VA = "0x180B5FFA0", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x060029DD RID: 10717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002307")]
	[Address(RVA = "0xB60140", Offset = "0xB5EF40", VA = "0x180B60140")]
	public DeployShell()
	{
	}

	// Token: 0x04002535 RID: 9525
	[Token(Token = "0x4001E61")]
	[FieldOffset(Offset = "0x98")]
	public Bounds bounds;
}
