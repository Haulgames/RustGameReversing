using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A1 RID: 1953
[Token(Token = "0x20005AA")]
public abstract class DecorComponent : PrefabAttribute
{
	// Token: 0x060030F7 RID: 12535
	[Token(Token = "0x6002953")]
	public abstract void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale);

	// Token: 0x060030F8 RID: 12536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002954")]
	[Address(RVA = "0x8BD900", Offset = "0x8BC700", VA = "0x1808BD900", Slot = "6")]
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x060030F9 RID: 12537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002955")]
	[Address(RVA = "0x8BD9C0", Offset = "0x8BC7C0", VA = "0x1808BD9C0", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x060030FA RID: 12538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002956")]
	[Address(RVA = "0x8BDA20", Offset = "0x8BC820", VA = "0x1808BDA20")]
	protected DecorComponent()
	{
	}

	// Token: 0x04002DCF RID: 11727
	[Token(Token = "0x400242B")]
	[FieldOffset(Offset = "0x98")]
	internal bool isRoot;
}
