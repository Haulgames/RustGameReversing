using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003FF RID: 1023
[Token(Token = "0x20002DF")]
public class DoorAnimEvents : MonoBehaviour, IClientComponent
{
	// Token: 0x1700025E RID: 606
	// (get) Token: 0x06002135 RID: 8501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000230")]
	public Animator animator
	{
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0xB78340", Offset = "0xB77140", VA = "0x180B78340")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B04")]
	[Address(RVA = "0xB78160", Offset = "0xB76F60", VA = "0x180B78160")]
	private void DoorOpenStart()
	{
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B05")]
	[Address(RVA = "0xB77F70", Offset = "0xB76D70", VA = "0x180B77F70")]
	private void DoorOpenEnd()
	{
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B06")]
	[Address(RVA = "0xB77D90", Offset = "0xB76B90", VA = "0x180B77D90")]
	private void DoorCloseStart()
	{
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B07")]
	[Address(RVA = "0xB77BA0", Offset = "0xB769A0", VA = "0x180B77BA0")]
	private void DoorCloseEnd()
	{
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B08")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DoorAnimEvents()
	{
	}

	// Token: 0x04001BED RID: 7149
	[Token(Token = "0x40016A7")]
	[FieldOffset(Offset = "0x18")]
	public GameObjectRef openStart;

	// Token: 0x04001BEE RID: 7150
	[Token(Token = "0x40016A8")]
	[FieldOffset(Offset = "0x20")]
	public GameObjectRef openEnd;

	// Token: 0x04001BEF RID: 7151
	[Token(Token = "0x40016A9")]
	[FieldOffset(Offset = "0x28")]
	public GameObjectRef closeStart;

	// Token: 0x04001BF0 RID: 7152
	[Token(Token = "0x40016AA")]
	[FieldOffset(Offset = "0x30")]
	public GameObjectRef closeEnd;

	// Token: 0x04001BF1 RID: 7153
	[Token(Token = "0x40016AB")]
	[FieldOffset(Offset = "0x38")]
	public bool checkAnimSpeed;
}
