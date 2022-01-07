using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000575 RID: 1397
[Token(Token = "0x200040E")]
public class CH47LandingZone : MonoBehaviour
{
	// Token: 0x0600282F RID: 10287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002193")]
	[Address(RVA = "0x646730", Offset = "0x645530", VA = "0x180646730")]
	public void Awake()
	{
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002194")]
	[Address(RVA = "0x646800", Offset = "0x645600", VA = "0x180646800")]
	public static CH47LandingZone GetClosest(Vector3 pos)
	{
		return null;
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002195")]
	[Address(RVA = "0x6469E0", Offset = "0x6457E0", VA = "0x1806469E0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06002832 RID: 10290 RVA: 0x00011940 File Offset: 0x0000FB40
	[Token(Token = "0x6002196")]
	[Address(RVA = "0x645140", Offset = "0x643F40", VA = "0x180645140")]
	public float TimeSinceLastDrop()
	{
		return 0f;
	}

	// Token: 0x06002833 RID: 10291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002197")]
	[Address(RVA = "0x645160", Offset = "0x643F60", VA = "0x180645160")]
	public void Used()
	{
	}

	// Token: 0x06002834 RID: 10292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002198")]
	[Address(RVA = "0x646AB0", Offset = "0x6458B0", VA = "0x180646AB0")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06002835 RID: 10293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002199")]
	[Address(RVA = "0x2F9790", Offset = "0x2F8590", VA = "0x1802F9790")]
	public CH47LandingZone()
	{
	}

	// Token: 0x04002368 RID: 9064
	[Token(Token = "0x4001CE9")]
	[FieldOffset(Offset = "0x18")]
	public float lastDropTime;

	// Token: 0x04002369 RID: 9065
	[Token(Token = "0x4001CEA")]
	[FieldOffset(Offset = "0x0")]
	private static List<CH47LandingZone> landingZones;

	// Token: 0x0400236A RID: 9066
	[Token(Token = "0x4001CEB")]
	[FieldOffset(Offset = "0x1C")]
	public float dropoffScale;
}
