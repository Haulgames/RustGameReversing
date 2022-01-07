using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200040C RID: 1036
[Token(Token = "0x20002E8")]
public static class EffectLibrary
{
	// Token: 0x06002180 RID: 8576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0x986160", Offset = "0x984F60", VA = "0x180986160")]
	private static void SetupEffect(this GameObject go, Effect effect)
	{
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3F")]
	[Address(RVA = "0x985DD0", Offset = "0x984BD0", VA = "0x180985DD0")]
	private static void GenericEffectSpawn(Effect effect)
	{
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B40")]
	[Address(RVA = "0x985E00", Offset = "0x984C00", VA = "0x180985E00")]
	private static void ProjectileEffectSpawn(Effect effect)
	{
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x986110", Offset = "0x984F10", VA = "0x180986110")]
	public static void Run(Effect fx)
	{
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B42")]
	[Address(RVA = "0x985C00", Offset = "0x984A00", VA = "0x180985C00")]
	public static GameObject CreateEffect(string strPrefab, [Optional] Transform parent, [Optional] Vector3 pos, [Optional] Quaternion rot)
	{
		return null;
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B43")]
	[Address(RVA = "0x985360", Offset = "0x984160", VA = "0x180985360")]
	public static GameObject CreateEffect(string strPrefab, Effect effect)
	{
		return null;
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B44")]
	[Address(RVA = "0x985A80", Offset = "0x984880", VA = "0x180985A80")]
	public static GameObject CreateEffect(string strPrefab, Vector3 vPos, Quaternion aAngle)
	{
		return null;
	}
}
