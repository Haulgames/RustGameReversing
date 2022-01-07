using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200062B RID: 1579
[Token(Token = "0x200049C")]
public class ClothLOD : FacepunchBehaviour
{
	// Token: 0x06002B93 RID: 11155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600248E")]
	[Address(RVA = "0x49B770", Offset = "0x49A570", VA = "0x18049B770")]
	public void Awake()
	{
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600248F")]
	[Address(RVA = "0x49B860", Offset = "0x49A660", VA = "0x18049B860")]
	public void LODCheck()
	{
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002490")]
	[Address(RVA = "0x49B830", Offset = "0x49A630", VA = "0x18049B830")]
	public void EnableCloth()
	{
	}

	// Token: 0x06002B96 RID: 11158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002491")]
	[Address(RVA = "0x49B800", Offset = "0x49A600", VA = "0x18049B800")]
	public void DisableCloth()
	{
	}

	// Token: 0x06002B97 RID: 11159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002492")]
	[Address(RVA = "0x49BA40", Offset = "0x49A840", VA = "0x18049BA40")]
	public ClothLOD()
	{
	}

	// Token: 0x040026CA RID: 9930
	[Token(Token = "0x4001F9A")]
	[FieldOffset(Offset = "0x0")]
	[ServerVar]
	public static float clothLODDist;

	// Token: 0x040026CB RID: 9931
	[Token(Token = "0x4001F9B")]
	[FieldOffset(Offset = "0x18")]
	public Cloth cloth;

	// Token: 0x040026CC RID: 9932
	[Token(Token = "0x4001F9C")]
	[FieldOffset(Offset = "0x20")]
	private bool lastWantsEnabled;
}
