using System;
using Il2CppDummyDll;

// Token: 0x02000577 RID: 1399
[Token(Token = "0x2000410")]
public class CH47ReinforcementListener : BaseEntity
{
	// Token: 0x0600283A RID: 10298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600219E")]
	[Address(RVA = "0x647780", Offset = "0x646580", VA = "0x180647780")]
	public CH47ReinforcementListener()
	{
	}

	// Token: 0x0400236C RID: 9068
	[Token(Token = "0x4001CED")]
	[FieldOffset(Offset = "0x160")]
	public string listenString;

	// Token: 0x0400236D RID: 9069
	[Token(Token = "0x4001CEE")]
	[FieldOffset(Offset = "0x168")]
	public GameObjectRef heliPrefab;

	// Token: 0x0400236E RID: 9070
	[Token(Token = "0x4001CEF")]
	[FieldOffset(Offset = "0x170")]
	public float startDist;
}
