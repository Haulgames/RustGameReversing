using System;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000115 RID: 277
[Token(Token = "0x20000A4")]
public class BigWheelBettingTerminal : StorageContainer
{
	// Token: 0x060010DF RID: 4319 RVA: 0x0000A008 File Offset: 0x00008208
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x45A220", Offset = "0x459020", VA = "0x18045A220", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x45A170", Offset = "0x458F70", VA = "0x18045A170")]
	public new void OnDrawGizmos()
	{
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0000A020 File Offset: 0x00008220
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x459F90", Offset = "0x458D90", VA = "0x180459F90")]
	public bool IsPlayerValid(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x0000A038 File Offset: 0x00008238
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x45AAD0", Offset = "0x4598D0", VA = "0x18045AAD0", Slot = "150")]
	public override bool ShouldShowLootMenus()
	{
		return default(bool);
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x0000A050 File Offset: 0x00008250
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x45ACD0", Offset = "0x459AD0", VA = "0x18045ACD0")]
	private Vector3 SoundPosition()
	{
		return default(Vector3);
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x45AEA0", Offset = "0x459CA0", VA = "0x18045AEA0")]
	public void WinSound()
	{
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x45A100", Offset = "0x458F00", VA = "0x18045A100")]
	public void LoseSound()
	{
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x45AA70", Offset = "0x459870", VA = "0x18045AA70")]
	[BaseEntity.RPC_Client]
	public void SetTimeUntilNextSpin(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x45ADE0", Offset = "0x459BE0", VA = "0x18045ADE0")]
	[BaseEntity.RPC_Client]
	public void WinOrLoseSound(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x45AF10", Offset = "0x459D10", VA = "0x18045AF10")]
	public BigWheelBettingTerminal()
	{
	}

	// Token: 0x04000B46 RID: 2886
	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x3C8")]
	public BigWheelGame bigWheel;

	// Token: 0x04000B47 RID: 2887
	[Token(Token = "0x40008F5")]
	[FieldOffset(Offset = "0x3D0")]
	public Vector3 seatedPlayerOffset;

	// Token: 0x04000B48 RID: 2888
	[Token(Token = "0x40008F6")]
	[FieldOffset(Offset = "0x3DC")]
	public float offsetCheckRadius;

	// Token: 0x04000B49 RID: 2889
	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x3E0")]
	public SoundDefinition winSound;

	// Token: 0x04000B4A RID: 2890
	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x3E8")]
	public SoundDefinition loseSound;

	// Token: 0x04000B4B RID: 2891
	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x3F0")]
	[NonSerialized]
	public float nextSpinTime;
}
