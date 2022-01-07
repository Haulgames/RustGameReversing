using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B7D RID: 2941
[Token(Token = "0x200083C")]
public static class AssetStorage
{
	// Token: 0x06004408 RID: 17416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003970")]
	public static void Save<T>(ref T asset, string path) where T : UnityEngine.Object
	{
	}

	// Token: 0x06004409 RID: 17417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003971")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public static void Save(ref Texture2D asset)
	{
	}

	// Token: 0x0600440A RID: 17418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003972")]
	[Address(RVA = "0x838E30", Offset = "0x837C30", VA = "0x180838E30")]
	public static void Save(ref Texture2D asset, string path, bool linear, bool compress)
	{
	}

	// Token: 0x0600440B RID: 17419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003973")]
	public static void Load<T>(ref T asset, string path) where T : UnityEngine.Object
	{
	}

	// Token: 0x0600440C RID: 17420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003974")]
	public static void Delete<T>(ref T asset) where T : UnityEngine.Object
	{
	}
}
