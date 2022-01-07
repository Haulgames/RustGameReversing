using System;
using Il2CppDummyDll;

// Token: 0x020006B0 RID: 1712
[Token(Token = "0x2000505")]
public class AuroraEffect : WeatherEffect
{
	// Token: 0x06002DA2 RID: 11682 RVA: 0x00013878 File Offset: 0x00011A78
	[Token(Token = "0x6002668")]
	[Address(RVA = "0x8402B0", Offset = "0x83F0B0", VA = "0x1808402B0", Slot = "6")]
	protected override float GetCurrentIntensity()
	{
		return 0f;
	}

	// Token: 0x06002DA3 RID: 11683 RVA: 0x00013890 File Offset: 0x00011A90
	[Token(Token = "0x6002669")]
	[Address(RVA = "0x509360", Offset = "0x508160", VA = "0x180509360", Slot = "7")]
	protected override float GetUpdateInterval(float intensity)
	{
		return 0f;
	}

	// Token: 0x06002DA4 RID: 11684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600266A")]
	[Address(RVA = "0x840360", Offset = "0x83F160", VA = "0x180840360", Slot = "8")]
	protected override void UpdatePosition(float intensity)
	{
	}

	// Token: 0x06002DA5 RID: 11685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600266B")]
	[Address(RVA = "0x509410", Offset = "0x508210", VA = "0x180509410")]
	public AuroraEffect()
	{
	}
}
