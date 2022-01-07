using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AD RID: 685
[Token(Token = "0x20001E4")]
public class AmbienceSpawnEmitters : MonoBehaviour, IClientComponent
{
	// Token: 0x06001A1E RID: 6686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x829910", Offset = "0x828710", VA = "0x180829910")]
	private void Start()
	{
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x829550", Offset = "0x828350", VA = "0x180829550")]
	private void CreateBaseEmitters()
	{
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x829920", Offset = "0x828720", VA = "0x180829920")]
	public AmbienceSpawnEmitters()
	{
	}

	// Token: 0x0400149D RID: 5277
	[Token(Token = "0x40010FC")]
	[FieldOffset(Offset = "0x18")]
	public int baseEmitterCount;

	// Token: 0x0400149E RID: 5278
	[Token(Token = "0x40010FD")]
	[FieldOffset(Offset = "0x1C")]
	public int baseEmitterDistance;

	// Token: 0x0400149F RID: 5279
	[Token(Token = "0x40010FE")]
	[FieldOffset(Offset = "0x20")]
	public GameObjectRef emitterPrefab;
}
