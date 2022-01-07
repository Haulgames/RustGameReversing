using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000247 RID: 583
[Token(Token = "0x200018B")]
public class BradleySpawner : MonoBehaviour, IServerComponent
{
	// Token: 0x06001877 RID: 6263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x46B060", Offset = "0x469E60", VA = "0x18046B060")]
	public BradleySpawner()
	{
	}

	// Token: 0x0400128E RID: 4750
	[Token(Token = "0x4000F1A")]
	[FieldOffset(Offset = "0x18")]
	public BasePath path;

	// Token: 0x0400128F RID: 4751
	[Token(Token = "0x4000F1B")]
	[FieldOffset(Offset = "0x20")]
	public GameObjectRef bradleyPrefab;

	// Token: 0x04001290 RID: 4752
	[Token(Token = "0x4000F1C")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public BradleyAPC spawned;

	// Token: 0x04001291 RID: 4753
	[Token(Token = "0x4000F1D")]
	[FieldOffset(Offset = "0x30")]
	public bool initialSpawn;

	// Token: 0x04001292 RID: 4754
	[Token(Token = "0x4000F1E")]
	[FieldOffset(Offset = "0x34")]
	public float minRespawnTimeMinutes;

	// Token: 0x04001293 RID: 4755
	[Token(Token = "0x4000F1F")]
	[FieldOffset(Offset = "0x38")]
	public float maxRespawnTimeMinutes;

	// Token: 0x04001294 RID: 4756
	[Token(Token = "0x4000F20")]
	[FieldOffset(Offset = "0x0")]
	public static BradleySpawner singleton;
}
