using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036D RID: 877
[Token(Token = "0x2000270")]
public abstract class DecalComponent : PrefabAttribute
{
	// Token: 0x06001DF3 RID: 7667
	[Token(Token = "0x6001828")]
	public abstract void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale);

	// Token: 0x06001DF4 RID: 7668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001829")]
	[Address(RVA = "0x8BB670", Offset = "0x8BA470", VA = "0x1808BB670", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600182A")]
	[Address(RVA = "0x8BB6D0", Offset = "0x8BA4D0", VA = "0x1808BB6D0")]
	protected DecalComponent()
	{
	}
}
