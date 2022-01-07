using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007BF RID: 1983
[Token(Token = "0x20005C6")]
public class DungeonVolume : MonoBehaviour
{
	// Token: 0x0600314A RID: 12618 RVA: 0x000151C8 File Offset: 0x000133C8
	[Token(Token = "0x60029A0")]
	[Address(RVA = "0x980940", Offset = "0x97F740", VA = "0x180980940")]
	public OBB GetBounds(Vector3 position, Quaternion rotation)
	{
		return default(OBB);
	}

	// Token: 0x0600314B RID: 12619 RVA: 0x000151E0 File Offset: 0x000133E0
	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x980BE0", Offset = "0x97F9E0", VA = "0x180980BE0")]
	public OBB GetBounds(Vector3 position, Quaternion rotation, Vector3 extrude)
	{
		return default(OBB);
	}

	// Token: 0x0600314C RID: 12620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029A2")]
	[Address(RVA = "0x980EB0", Offset = "0x97FCB0", VA = "0x180980EB0")]
	public DungeonVolume()
	{
	}

	// Token: 0x04002E3E RID: 11838
	[Token(Token = "0x4002492")]
	[FieldOffset(Offset = "0x18")]
	public Bounds bounds;
}
