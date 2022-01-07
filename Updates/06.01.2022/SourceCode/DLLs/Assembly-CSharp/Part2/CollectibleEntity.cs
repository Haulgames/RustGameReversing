using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000125 RID: 293
[Token(Token = "0x20000AD")]
public class CollectibleEntity : BaseEntity, IPrefabPreProcess
{
	// Token: 0x0600118D RID: 4493 RVA: 0x0000A458 File Offset: 0x00008658
	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x49F450", Offset = "0x49E250", VA = "0x18049F450", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x0000A470 File Offset: 0x00008670
	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "58")]
	public override bool ShouldLerp()
	{
		return default(bool);
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x49F2F0", Offset = "0x49E0F0", VA = "0x18049F2F0", Slot = "66")]
	public override List<Option> GetMenuItems(BasePlayer player)
	{
		return null;
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x49F540", Offset = "0x49E340", VA = "0x18049F540", Slot = "84")]
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x49F6B0", Offset = "0x49E4B0", VA = "0x18049F6B0")]
	public CollectibleEntity()
	{
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x49F670", Offset = "0x49E470", VA = "0x18049F670")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private void <GetMenuItems>b__6_0(BasePlayer ply)
	{
	}

	// Token: 0x04000C0A RID: 3082
	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x160")]
	public Translate.Phrase itemName;

	// Token: 0x04000C0B RID: 3083
	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x168")]
	public ItemAmount[] itemList;

	// Token: 0x04000C0C RID: 3084
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x170")]
	public GameObjectRef pickupEffect;

	// Token: 0x04000C0D RID: 3085
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x178")]
	public float xpScale;
}
