using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x0200008A RID: 138
[Token(Token = "0x2000051")]
public class Door : AnimatedBuildingBlock, INotifyTrigger
{
	// Token: 0x060009CC RID: 2508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000574")]
	[Address(RVA = "0xB784F0", Offset = "0xB772F0", VA = "0x180B784F0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x060009CD RID: 2509 RVA: 0x00005808 File Offset: 0x00003A08
	[Token(Token = "0x17000097")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000575")]
		[Address(RVA = "0xB79FD0", Offset = "0xB78DD0", VA = "0x180B79FD0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00005820 File Offset: 0x00003A20
	[Token(Token = "0x6000576")]
	[Address(RVA = "0xB79920", Offset = "0xB78720", VA = "0x180B79920", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000577")]
	[Address(RVA = "0xB79D70", Offset = "0xB78B70", VA = "0x180B79D70", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00005838 File Offset: 0x00003A38
	[Token(Token = "0x6000578")]
	[Address(RVA = "0xB790E0", Offset = "0xB77EE0", VA = "0x180B790E0", Slot = "85")]
	public override bool HasSlot(BaseEntity.Slot slot)
	{
		return default(bool);
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00005850 File Offset: 0x00003A50
	[Token(Token = "0x6000579")]
	[Address(RVA = "0xB78380", Offset = "0xB77180", VA = "0x180B78380", Slot = "133")]
	public override bool CanPickup(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057A")]
	[Address(RVA = "0xB794D0", Offset = "0xB782D0", VA = "0x180B794D0")]
	[Attribute(Name = "Menu", RVA = "0xC82D0", Offset = "0xC76D0")]
	[Attribute(Name = "Description", RVA = "0xC82D0", Offset = "0xC76D0")]
	[Attribute(Name = "Icon", RVA = "0xC82D0", Offset = "0xC76D0")]
	[Attribute(Name = "ShowIf", RVA = "0xC82D0", Offset = "0xC76D0")]
	[BaseEntity.Menu.UsableWhileWounded]
	public void Menu_OpenDoor(BasePlayer player)
	{
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057B")]
	[Address(RVA = "0xB793B0", Offset = "0xB781B0", VA = "0x180B793B0")]
	public void Menu_OpenDoor_Proxy(ref Option option)
	{
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057C")]
	[Address(RVA = "0xB79370", Offset = "0xB78170", VA = "0x180B79370")]
	public void Menu_OpenDoorStart()
	{
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00005868 File Offset: 0x00003A68
	[Token(Token = "0x600057D")]
	[Address(RVA = "0xB79490", Offset = "0xB78290", VA = "0x180B79490")]
	public bool Menu_OpenDoor_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057E")]
	[Address(RVA = "0xB79280", Offset = "0xB78080", VA = "0x180B79280")]
	[Attribute(Name = "Menu", RVA = "0xC87A0", Offset = "0xC7BA0")]
	[Attribute(Name = "Description", RVA = "0xC87A0", Offset = "0xC7BA0")]
	[Attribute(Name = "Icon", RVA = "0xC87A0", Offset = "0xC7BA0")]
	[Attribute(Name = "ShowIf", RVA = "0xC87A0", Offset = "0xC7BA0")]
	[BaseEntity.Menu.UsableWhileWounded]
	public void Menu_CloseDoor(BasePlayer player)
	{
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057F")]
	[Address(RVA = "0xB79160", Offset = "0xB77F60", VA = "0x180B79160")]
	public void Menu_CloseDoor_Proxy(ref Option option)
	{
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000580")]
	[Address(RVA = "0xB79120", Offset = "0xB77F20", VA = "0x180B79120")]
	public void Menu_CloseDoorStart()
	{
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00005880 File Offset: 0x00003A80
	[Token(Token = "0x6000581")]
	[Address(RVA = "0xB79240", Offset = "0xB78040", VA = "0x180B79240")]
	public bool Menu_CloseDoor_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000582")]
	[Address(RVA = "0xB79330", Offset = "0xB78130", VA = "0x180B79330")]
	[Attribute(Name = "Menu", RVA = "0xC8A80", Offset = "0xC7E80")]
	[Attribute(Name = "Description", RVA = "0xC8A80", Offset = "0xC7E80")]
	[Attribute(Name = "Icon", RVA = "0xC8A80", Offset = "0xC7E80")]
	[Attribute(Name = "ShowIf", RVA = "0xC8A80", Offset = "0xC7E80")]
	[BaseEntity.Menu.UsableWhileWounded]
	public void Menu_KnockDoor(BasePlayer player)
	{
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00005898 File Offset: 0x00003A98
	[Token(Token = "0x6000583")]
	[Address(RVA = "0xB792C0", Offset = "0xB780C0", VA = "0x180B792C0")]
	public bool Menu_KnockDoor_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000584")]
	[Address(RVA = "0xB79520", Offset = "0xB78320", VA = "0x180B79520")]
	[Attribute(Name = "Menu", RVA = "0xC8D40", Offset = "0xC8140")]
	[Attribute(Name = "Description", RVA = "0xC8D40", Offset = "0xC8140")]
	[Attribute(Name = "Icon", RVA = "0xC8D40", Offset = "0xC8140")]
	[Attribute(Name = "ShowIf", RVA = "0xC8D40", Offset = "0xC8140")]
	public void Menu_ToggleHatch(BasePlayer player)
	{
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x000058B0 File Offset: 0x00003AB0
	[Token(Token = "0x6000585")]
	[Address(RVA = "0xB79510", Offset = "0xB78310", VA = "0x180B79510")]
	public bool Menu_ToggleHatch_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x000058C8 File Offset: 0x00003AC8
	[Token(Token = "0x6000586")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "72")]
	public override bool NeedsCrosshair()
	{
		return default(bool);
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000587")]
	[Address(RVA = "0xB79560", Offset = "0xB78360", VA = "0x180B79560")]
	[BaseEntity.RPC_Client]
	private void OnDoorInterrupted(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000588")]
	[Address(RVA = "0xB79D80", Offset = "0xB78B80", VA = "0x180B79D80")]
	private void ReverseDoorAnimation(bool wasOpening)
	{
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x000058E0 File Offset: 0x00003AE0
	[Token(Token = "0x6000589")]
	[Address(RVA = "0x2F1590", Offset = "0x2F0390", VA = "0x1802F1590", Slot = "112")]
	public override float BoundsPadding()
	{
		return 0f;
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058A")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "145")]
	public void OnObjects(TriggerNotify trigger)
	{
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058B")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "146")]
	public void OnEmpty()
	{
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058C")]
	[Address(RVA = "0xB797F0", Offset = "0xB785F0", VA = "0x180B797F0", Slot = "80")]
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next)
	{
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058D")]
	[Address(RVA = "0xB79FB0", Offset = "0xB78DB0", VA = "0x180B79FB0")]
	public Door()
	{
	}

	// Token: 0x04000531 RID: 1329
	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x268")]
	private Option __menuOption_Menu_CloseDoor;

	// Token: 0x04000532 RID: 1330
	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x2C0")]
	private Option __menuOption_Menu_KnockDoor;

	// Token: 0x04000533 RID: 1331
	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x318")]
	private Option __menuOption_Menu_OpenDoor;

	// Token: 0x04000534 RID: 1332
	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x370")]
	private Option __menuOption_Menu_ToggleHatch;

	// Token: 0x04000535 RID: 1333
	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x3C8")]
	public GameObjectRef knockEffect;

	// Token: 0x04000536 RID: 1334
	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x3D0")]
	public bool canTakeLock;

	// Token: 0x04000537 RID: 1335
	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x3D1")]
	public bool hasHatch;

	// Token: 0x04000538 RID: 1336
	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x3D2")]
	public bool canTakeCloser;

	// Token: 0x04000539 RID: 1337
	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x3D3")]
	public bool canTakeKnocker;

	// Token: 0x0400053A RID: 1338
	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x3D4")]
	public bool canNpcOpen;

	// Token: 0x0400053B RID: 1339
	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x3D5")]
	public bool canHandOpen;

	// Token: 0x0400053C RID: 1340
	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x3D6")]
	public bool isSecurityDoor;

	// Token: 0x0400053D RID: 1341
	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x3D8")]
	public TriggerNotify[] vehiclePhysBoxes;

	// Token: 0x0400053E RID: 1342
	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x3E0")]
	public bool checkPhysBoxesOnOpen;

	// Token: 0x0400053F RID: 1343
	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x3E8")]
	public SoundDefinition vehicleCollisionSfx;

	// Token: 0x04000540 RID: 1344
	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x3F0")]
	public GameObject[] ClosedColliderRoots;

	// Token: 0x04000541 RID: 1345
	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x0")]
	private static int openHash;

	// Token: 0x04000542 RID: 1346
	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x4")]
	private static int closeHash;
}
