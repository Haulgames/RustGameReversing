using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E3 RID: 995
[Token(Token = "0x20002CA")]
public class DevBotSpawner : FacepunchBehaviour
{
	// Token: 0x060020E8 RID: 8424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0xB69E60", Offset = "0xB68C60", VA = "0x180B69E60")]
	public DevBotSpawner()
	{
	}

	// Token: 0x04001BA2 RID: 7074
	[Token(Token = "0x400167E")]
	[FieldOffset(Offset = "0x18")]
	public GameObjectRef bot;

	// Token: 0x04001BA3 RID: 7075
	[Token(Token = "0x400167F")]
	[FieldOffset(Offset = "0x20")]
	public Transform waypointParent;

	// Token: 0x04001BA4 RID: 7076
	[Token(Token = "0x4001680")]
	[FieldOffset(Offset = "0x28")]
	public bool autoSelectLatestSpawnedGameObject;

	// Token: 0x04001BA5 RID: 7077
	[Token(Token = "0x4001681")]
	[FieldOffset(Offset = "0x2C")]
	public float spawnRate;

	// Token: 0x04001BA6 RID: 7078
	[Token(Token = "0x4001682")]
	[FieldOffset(Offset = "0x30")]
	public int maxPopulation;
}
