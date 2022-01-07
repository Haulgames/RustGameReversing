using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200090E RID: 2318
[Token(Token = "0x2000686")]
public static class AssetNameCache
{
	// Token: 0x06003826 RID: 14374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F50")]
	[Address(RVA = "0x838C10", Offset = "0x837A10", VA = "0x180838C10")]
	private static string LookupName(UnityEngine.Object obj)
	{
		return null;
	}

	// Token: 0x06003827 RID: 14375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F51")]
	[Address(RVA = "0x838950", Offset = "0x837750", VA = "0x180838950")]
	private static string LookupNameLower(UnityEngine.Object obj)
	{
		return null;
	}

	// Token: 0x06003828 RID: 14376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F52")]
	[Address(RVA = "0x838AB0", Offset = "0x8378B0", VA = "0x180838AB0")]
	private static string LookupNameUpper(UnityEngine.Object obj)
	{
		return null;
	}

	// Token: 0x06003829 RID: 14377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F53")]
	[Address(RVA = "0x838890", Offset = "0x837690", VA = "0x180838890")]
	public static string GetName(this PhysicMaterial mat)
	{
		return null;
	}

	// Token: 0x0600382A RID: 14378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F54")]
	[Address(RVA = "0x838710", Offset = "0x837510", VA = "0x180838710")]
	public static string GetNameLower(this PhysicMaterial mat)
	{
		return null;
	}

	// Token: 0x0600382B RID: 14379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F55")]
	[Address(RVA = "0x8387D0", Offset = "0x8375D0", VA = "0x1808387D0")]
	public static string GetNameUpper(this PhysicMaterial mat)
	{
		return null;
	}

	// Token: 0x0600382C RID: 14380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F56")]
	[Address(RVA = "0x8388F0", Offset = "0x8376F0", VA = "0x1808388F0")]
	public static string GetName(this Material mat)
	{
		return null;
	}

	// Token: 0x0600382D RID: 14381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F57")]
	[Address(RVA = "0x838770", Offset = "0x837570", VA = "0x180838770")]
	public static string GetNameLower(this Material mat)
	{
		return null;
	}

	// Token: 0x0600382E RID: 14382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F58")]
	[Address(RVA = "0x838830", Offset = "0x837630", VA = "0x180838830")]
	public static string GetNameUpper(this Material mat)
	{
		return null;
	}

	// Token: 0x0400349F RID: 13471
	[Token(Token = "0x40028A3")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<UnityEngine.Object, string> mixed;

	// Token: 0x040034A0 RID: 13472
	[Token(Token = "0x40028A4")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<UnityEngine.Object, string> lower;

	// Token: 0x040034A1 RID: 13473
	[Token(Token = "0x40028A5")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<UnityEngine.Object, string> upper;
}
