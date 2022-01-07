using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000305 RID: 773
[Token(Token = "0x200021D")]
public class DirectionProperties : PrefabAttribute
{
	// Token: 0x06001C27 RID: 7207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001683")]
	[Address(RVA = "0xB72840", Offset = "0xB71640", VA = "0x180B72840", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x0000DB90 File Offset: 0x0000BD90
	[Token(Token = "0x6001684")]
	[Address(RVA = "0xB728A0", Offset = "0xB716A0", VA = "0x180B728A0")]
	public bool IsWeakspot(Transform tx, HitInfo info)
	{
		return default(bool);
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001685")]
	[Address(RVA = "0xB72EF0", Offset = "0xB71CF0", VA = "0x180B72EF0")]
	public DirectionProperties()
	{
	}

	// Token: 0x04001716 RID: 5910
	[Token(Token = "0x40012D1")]
	private const float radius = 200f;

	// Token: 0x04001717 RID: 5911
	[Token(Token = "0x40012D2")]
	[FieldOffset(Offset = "0x98")]
	public Bounds bounds;

	// Token: 0x04001718 RID: 5912
	[Token(Token = "0x40012D3")]
	[FieldOffset(Offset = "0xB0")]
	public ProtectionProperties extraProtection;
}
