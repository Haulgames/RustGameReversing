using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20001E2")]
public class AmbienceLocalStings : MonoBehaviour
{
	// Token: 0x060019FC RID: 6652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001493")]
	[Address(RVA = "0x8269E0", Offset = "0x8257E0", VA = "0x1808269E0")]
	private void PlaySting(uint seed)
	{
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001494")]
	[Address(RVA = "0x826C70", Offset = "0x825A70", VA = "0x180826C70")]
	private void Start()
	{
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001495")]
	[Address(RVA = "0x826D20", Offset = "0x825B20", VA = "0x180826D20")]
	private void Update()
	{
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001496")]
	[Address(RVA = "0x826D40", Offset = "0x825B40", VA = "0x180826D40")]
	public AmbienceLocalStings()
	{
	}

	// Token: 0x0400147F RID: 5247
	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x18")]
	public float maxDistance;

	// Token: 0x04001480 RID: 5248
	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0x1C")]
	public float stingRadius;

	// Token: 0x04001481 RID: 5249
	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x20")]
	public float stingFrequency;

	// Token: 0x04001482 RID: 5250
	[Token(Token = "0x40010EA")]
	[FieldOffset(Offset = "0x24")]
	public float stingFrequencyVariance;

	// Token: 0x04001483 RID: 5251
	[Token(Token = "0x40010EB")]
	[FieldOffset(Offset = "0x28")]
	public SoundDefinition[] stingSounds;

	// Token: 0x04001484 RID: 5252
	[Token(Token = "0x40010EC")]
	[FieldOffset(Offset = "0x30")]
	private SynchronizedClock stingClock;
}
