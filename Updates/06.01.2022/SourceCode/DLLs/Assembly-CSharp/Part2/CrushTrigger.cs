using System;
using Il2CppDummyDll;

// Token: 0x0200056D RID: 1389
[Token(Token = "0x2000408")]
public class CrushTrigger : TriggerHurt
{
	// Token: 0x06002815 RID: 10261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600217A")]
	[Address(RVA = "0x6DAB50", Offset = "0x6D9950", VA = "0x1806DAB50")]
	public CrushTrigger()
	{
	}

	// Token: 0x04002349 RID: 9033
	[Token(Token = "0x4001CCE")]
	[FieldOffset(Offset = "0x40")]
	public bool includeNPCs;

	// Token: 0x0400234A RID: 9034
	[Token(Token = "0x4001CCF")]
	[FieldOffset(Offset = "0x41")]
	public bool requireCentreBelowPosition;
}
