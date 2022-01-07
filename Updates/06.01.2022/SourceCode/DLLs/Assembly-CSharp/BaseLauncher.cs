using System;
using Il2CppDummyDll;
using Network;

// Token: 0x02000107 RID: 263
[Token(Token = "0x200009E")]
public class BaseLauncher : BaseProjectile
{
	// Token: 0x0600100F RID: 4111 RVA: 0x00009720 File Offset: 0x00007920
	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x2EF4F0", Offset = "0x2EE2F0", VA = "0x1802EF4F0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x2EF050", Offset = "0x2EDE50", VA = "0x1802EF050", Slot = "171")]
	public override void LaunchProjectile()
	{
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x2EF3C0", Offset = "0x2EE1C0", VA = "0x1802EF3C0", Slot = "136")]
	public override void OnFrame()
	{
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x2EF5E0", Offset = "0x2EE3E0", VA = "0x1802EF5E0")]
	public BaseLauncher()
	{
	}
}
