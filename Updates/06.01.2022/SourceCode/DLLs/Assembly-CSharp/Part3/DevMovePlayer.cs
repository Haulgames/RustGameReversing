using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003EB RID: 1003
[Token(Token = "0x20002D2")]
public class DevMovePlayer : BaseMonoBehaviour
{
	// Token: 0x06002103 RID: 8451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0xB6B8F0", Offset = "0xB6A6F0", VA = "0x180B6B8F0")]
	public DevMovePlayer()
	{
	}

	// Token: 0x04001BB5 RID: 7093
	[Token(Token = "0x4001691")]
	[FieldOffset(Offset = "0x18")]
	public BasePlayer player;

	// Token: 0x04001BB6 RID: 7094
	[Token(Token = "0x4001692")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] Waypoints;

	// Token: 0x04001BB7 RID: 7095
	[Token(Token = "0x4001693")]
	[FieldOffset(Offset = "0x28")]
	public bool moveRandomly;

	// Token: 0x04001BB8 RID: 7096
	[Token(Token = "0x4001694")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 destination;

	// Token: 0x04001BB9 RID: 7097
	[Token(Token = "0x4001695")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 lookPoint;
}
