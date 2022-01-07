using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000572 RID: 1394
[Token(Token = "0x200040B")]
public class CH47DropZone : MonoBehaviour
{
	// Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002186")]
	[Address(RVA = "0x644D40", Offset = "0x643B40", VA = "0x180644D40")]
	public void Awake()
	{
	}

	// Token: 0x06002823 RID: 10275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002187")]
	[Address(RVA = "0x644E10", Offset = "0x643C10", VA = "0x180644E10")]
	public static CH47DropZone GetClosest(Vector3 pos)
	{
		return null;
	}

	// Token: 0x06002824 RID: 10276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002188")]
	[Address(RVA = "0x644FF0", Offset = "0x643DF0", VA = "0x180644FF0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06002825 RID: 10277 RVA: 0x000118F8 File Offset: 0x0000FAF8
	[Token(Token = "0x6002189")]
	[Address(RVA = "0x645140", Offset = "0x643F40", VA = "0x180645140")]
	public float TimeSinceLastDrop()
	{
		return 0f;
	}

	// Token: 0x06002826 RID: 10278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600218A")]
	[Address(RVA = "0x645160", Offset = "0x643F60", VA = "0x180645160")]
	public void Used()
	{
	}

	// Token: 0x06002827 RID: 10279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600218B")]
	[Address(RVA = "0x6450C0", Offset = "0x643EC0", VA = "0x1806450C0")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06002828 RID: 10280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600218C")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public CH47DropZone()
	{
	}

	// Token: 0x0400235A RID: 9050
	[Token(Token = "0x4001CDB")]
	[FieldOffset(Offset = "0x18")]
	public float lastDropTime;

	// Token: 0x0400235B RID: 9051
	[Token(Token = "0x4001CDC")]
	[FieldOffset(Offset = "0x0")]
	private static List<CH47DropZone> dropZones;
}
