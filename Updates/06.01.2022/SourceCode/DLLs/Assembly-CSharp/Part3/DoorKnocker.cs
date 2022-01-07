using System;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x20000B4")]
public class DoorKnocker : BaseCombatEntity
{
	// Token: 0x06001208 RID: 4616 RVA: 0x0000A710 File Offset: 0x00008910
	[Token(Token = "0x6000D28")]
	[Address(RVA = "0x97A0D0", Offset = "0x978ED0", VA = "0x18097A0D0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x979F30", Offset = "0x978D30", VA = "0x180979F30")]
	[BaseEntity.RPC_Client]
	public void ClientKnock(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x2EF040", Offset = "0x2EDE40", VA = "0x1802EF040")]
	public DoorKnocker()
	{
	}

	// Token: 0x04000C52 RID: 3154
	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x238")]
	public Animator knocker1;

	// Token: 0x04000C53 RID: 3155
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x240")]
	public Animator knocker2;
}
