using System;
using Il2CppDummyDll;

// Token: 0x0200043F RID: 1087
[Token(Token = "0x2000319")]
public class AttackedAIEvent : BaseAIEvent
{
	// Token: 0x0600223D RID: 8765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x83D6B0", Offset = "0x83C4B0", VA = "0x18083D6B0")]
	public AttackedAIEvent()
	{
	}

	// Token: 0x04001D11 RID: 7441
	[Token(Token = "0x40017B9")]
	[FieldOffset(Offset = "0x40")]
	protected float lastExecuteTime;

	// Token: 0x04001D12 RID: 7442
	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0x48")]
	private BaseCombatEntity combatEntity;
}
