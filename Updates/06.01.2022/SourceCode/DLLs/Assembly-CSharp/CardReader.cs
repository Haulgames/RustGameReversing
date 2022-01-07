using System;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x0200011E RID: 286
[Token(Token = "0x20000A9")]
public class CardReader : IOEntity
{
	// Token: 0x0600114B RID: 4427 RVA: 0x0000A308 File Offset: 0x00008508
	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x64F090", Offset = "0x64DE90", VA = "0x18064F090", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x64F020", Offset = "0x64DE20", VA = "0x18064F020", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x64EED0", Offset = "0x64DCD0", VA = "0x18064EED0")]
	public void ClientCardSwiped(Keycard card)
	{
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x64F180", Offset = "0x64DF80", VA = "0x18064F180")]
	public CardReader()
	{
	}

	// Token: 0x04000BC7 RID: 3015
	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x268")]
	public float accessDuration;

	// Token: 0x04000BC8 RID: 3016
	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x26C")]
	public int accessLevel;

	// Token: 0x04000BC9 RID: 3017
	[Token(Token = "0x400096F")]
	[FieldOffset(Offset = "0x270")]
	public GameObjectRef accessGrantedEffect;

	// Token: 0x04000BCA RID: 3018
	[Token(Token = "0x4000970")]
	[FieldOffset(Offset = "0x278")]
	public GameObjectRef accessDeniedEffect;

	// Token: 0x04000BCB RID: 3019
	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x280")]
	public GameObjectRef swipeEffect;

	// Token: 0x04000BCC RID: 3020
	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x288")]
	public Transform audioPosition;

	// Token: 0x04000BCD RID: 3021
	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x290")]
	public BaseEntity.Flags AccessLevel1;

	// Token: 0x04000BCE RID: 3022
	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x294")]
	public BaseEntity.Flags AccessLevel2;

	// Token: 0x04000BCF RID: 3023
	[Token(Token = "0x4000975")]
	[FieldOffset(Offset = "0x298")]
	public BaseEntity.Flags AccessLevel3;
}
