using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200054D RID: 1357
[Token(Token = "0x20003EF")]
public class BushEntity : global::BaseEntity, IPrefabPreProcess
{
	// Token: 0x060027BD RID: 10173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002125")]
	[Address(RVA = "0x6429D0", Offset = "0x6417D0", VA = "0x1806429D0", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x000116B8 File Offset: 0x0000F8B8
	[Token(Token = "0x6002126")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "58")]
	public override bool ShouldLerp()
	{
		return default(bool);
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002127")]
	[Address(RVA = "0x6428C0", Offset = "0x6416C0", VA = "0x1806428C0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002128")]
	[Address(RVA = "0x642950", Offset = "0x641750", VA = "0x180642950", Slot = "20")]
	internal override void DoNetworkDestroy()
	{
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002129")]
	[Address(RVA = "0x642A90", Offset = "0x641890", VA = "0x180642A90", Slot = "84")]
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600212A")]
	[Address(RVA = "0x642BD0", Offset = "0x6419D0", VA = "0x180642BD0")]
	public BushEntity()
	{
	}

	// Token: 0x040022C2 RID: 8898
	[Token(Token = "0x4001C5E")]
	[FieldOffset(Offset = "0x160")]
	public GameObjectRef prefab;

	// Token: 0x040022C3 RID: 8899
	[Token(Token = "0x4001C5F")]
	[FieldOffset(Offset = "0x168")]
	public bool globalBillboard;
}
