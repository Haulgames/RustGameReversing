using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x020005BD RID: 1469
[Token(Token = "0x200044E")]
public class BaseHuntEvent : global::BaseEntity
{
	// Token: 0x06002930 RID: 10544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002291")]
	[Address(RVA = "0x2EEF40", Offset = "0x2EDD40", VA = "0x1802EEF40", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002292")]
	[Address(RVA = "0x2EEFA0", Offset = "0x2EDDA0", VA = "0x1802EEFA0")]
	public void PlayMusic()
	{
	}

	// Token: 0x06002932 RID: 10546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002293")]
	[Address(RVA = "0x2EEFD0", Offset = "0x2EDDD0", VA = "0x1802EEFD0")]
	public BaseHuntEvent()
	{
	}

	// Token: 0x040024BE RID: 9406
	[Token(Token = "0x4001E1A")]
	[FieldOffset(Offset = "0x160")]
	public GameObjectRef[] HuntablePrefab;

	// Token: 0x040024BF RID: 9407
	[Token(Token = "0x4001E1B")]
	[FieldOffset(Offset = "0x168")]
	public AudioSource huntStartSound;
}
