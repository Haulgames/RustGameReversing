using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000045 RID: 69
[Token(Token = "0x2000032")]
public class AutoTurret : ContainerIOEntity, IRemoteControllable
{
	// Token: 0x06000577 RID: 1399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x841140", Offset = "0x83FF40", VA = "0x180841140", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000578 RID: 1400 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x1700001D")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x8442A0", Offset = "0x8430A0", VA = "0x1808442A0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00002A78 File Offset: 0x00000C78
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x842E20", Offset = "0x841C20", VA = "0x180842E20", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x843630", Offset = "0x842430", VA = "0x180843630", Slot = "161")]
	public override bool ShouldShowLootMenus()
	{
		return default(bool);
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x840EC0", Offset = "0x83FCC0", VA = "0x180840EC0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void InitializeClientsideEffects()
	{
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x841020", Offset = "0x83FE20", VA = "0x180841020", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x840F00", Offset = "0x83FD00", VA = "0x180840F00")]
	public void ClientTick()
	{
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x843C30", Offset = "0x842A30", VA = "0x180843C30")]
	private void UpdateSounds(bool didTurn)
	{
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "162")]
	public override int GetMoveToContainerIndex(global::BasePlayer player, global::Item item)
	{
		return 0;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x842370", Offset = "0x841170", VA = "0x180842370", Slot = "163")]
	public override int GetMoveToSlotIndex(global::BasePlayer player, global::Item item)
	{
		return 0;
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x840D50", Offset = "0x83FB50", VA = "0x180840D50")]
	[global::BaseEntity.RPC_Client]
	public void CLIENT_ReceiveAimDir(global::BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x840890", Offset = "0x83F690", VA = "0x180840890")]
	[global::BaseEntity.RPC_Client]
	public void CLIENT_FireGun(global::BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	[Attribute(Name = "Menu", RVA = "0xA1820", Offset = "0xA0C20")]
	[Attribute(Name = "Description", RVA = "0xA1820", Offset = "0xA0C20")]
	[Attribute(Name = "Icon", RVA = "0xA1820", Offset = "0xA0C20")]
	[Attribute(Name = "ShowIf", RVA = "0xA1820", Offset = "0xA0C20")]
	public void Menu_MaxAuth(global::BasePlayer player)
	{
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x842B60", Offset = "0x841960", VA = "0x180842B60")]
	public bool MenuMaxAuth_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x842A80", Offset = "0x841880", VA = "0x180842A80")]
	[Attribute(Name = "Menu", RVA = "0xA1990", Offset = "0xA0D90")]
	[Attribute(Name = "Description", RVA = "0xA1990", Offset = "0xA0D90")]
	[Attribute(Name = "Icon", RVA = "0xA1990", Offset = "0xA0D90")]
	[Attribute(Name = "ShowIf", RVA = "0xA1990", Offset = "0xA0D90")]
	public void MenuAuthorize(global::BasePlayer player)
	{
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00002AF0 File Offset: 0x00000CF0
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x842A20", Offset = "0x841820", VA = "0x180842A20")]
	public bool MenuAuthorize_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x842B20", Offset = "0x841920", VA = "0x180842B20")]
	[Attribute(Name = "Menu", RVA = "0xA1C10", Offset = "0xA1010")]
	[Attribute(Name = "Description", RVA = "0xA1C10", Offset = "0xA1010")]
	[Attribute(Name = "Icon", RVA = "0xA1C10", Offset = "0xA1010")]
	[Attribute(Name = "ShowIf", RVA = "0xA1C10", Offset = "0xA1010")]
	public void MenuDeauthorize(global::BasePlayer player)
	{
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00002B08 File Offset: 0x00000D08
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x842AC0", Offset = "0x8418C0", VA = "0x180842AC0")]
	public bool MenuDeauthorize_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x842AE0", Offset = "0x8418E0", VA = "0x180842AE0")]
	[Attribute(Name = "Menu", RVA = "0xA31C0", Offset = "0xA25C0")]
	[Attribute(Name = "Description", RVA = "0xA31C0", Offset = "0xA25C0")]
	[Attribute(Name = "Icon", RVA = "0xA31C0", Offset = "0xA25C0")]
	[Attribute(Name = "ShowIf", RVA = "0xA31C0", Offset = "0xA25C0")]
	public void MenuClearList(global::BasePlayer player)
	{
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x842AC0", Offset = "0x8418C0", VA = "0x180842AC0")]
	public bool MenuClearList_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x842CB0", Offset = "0x841AB0", VA = "0x180842CB0")]
	[Attribute(Name = "Menu", RVA = "0xA3440", Offset = "0xA2840")]
	[Attribute(Name = "Description", RVA = "0xA3440", Offset = "0xA2840")]
	[Attribute(Name = "Icon", RVA = "0xA3440", Offset = "0xA2840")]
	[Attribute(Name = "ShowIf", RVA = "0xA3440", Offset = "0xA2840")]
	public void MenuTurretRotate(global::BasePlayer player)
	{
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x842AC0", Offset = "0x8418C0", VA = "0x180842AC0")]
	public bool MenuTurretRotate_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x842C70", Offset = "0x841A70", VA = "0x180842C70")]
	[Attribute(Name = "Menu", RVA = "0xA3750", Offset = "0xA2B50")]
	[Attribute(Name = "Description", RVA = "0xA3750", Offset = "0xA2B50")]
	[Attribute(Name = "Icon", RVA = "0xA3750", Offset = "0xA2B50")]
	[Attribute(Name = "ShowIf", RVA = "0xA3750", Offset = "0xA2B50")]
	public void MenuTurretPeacekeeper(global::BasePlayer player)
	{
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x842C30", Offset = "0x841A30", VA = "0x180842C30")]
	public bool MenuTurretPeacekeeper_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x842BF0", Offset = "0x8419F0", VA = "0x180842BF0")]
	[Attribute(Name = "Menu", RVA = "0xA3980", Offset = "0xA2D80")]
	[Attribute(Name = "Description", RVA = "0xA3980", Offset = "0xA2D80")]
	[Attribute(Name = "Icon", RVA = "0xA3980", Offset = "0xA2D80")]
	[Attribute(Name = "ShowIf", RVA = "0xA3980", Offset = "0xA2D80")]
	public void MenuTurretAttackAll(global::BasePlayer player)
	{
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x842BB0", Offset = "0x8419B0", VA = "0x180842BB0")]
	public bool MenuTurretAttackAll_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x842CF0", Offset = "0x841AF0", VA = "0x180842CF0")]
	[Attribute(Name = "Menu", RVA = "0xA3B80", Offset = "0xA2F80")]
	[Attribute(Name = "Icon", RVA = "0xA3B80", Offset = "0xA2F80")]
	[Attribute(Name = "Description", RVA = "0xA3B80", Offset = "0xA2F80")]
	[Attribute(Name = "ShowIf", RVA = "0xA3B80", Offset = "0xA2F80")]
	public void Menu_AssignToFriend(global::BasePlayer player)
	{
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x842AC0", Offset = "0x8418C0", VA = "0x180842AC0", Slot = "173")]
	public virtual bool Menu_AssignToFriend_Test(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00002B98 File Offset: 0x00000D98
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x4396F0", Offset = "0x4384F0", VA = "0x1804396F0")]
	public bool PeacekeeperMode()
	{
		return default(bool);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00002BB0 File Offset: 0x00000DB0
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x842820", Offset = "0x841620", VA = "0x180842820")]
	public bool IsBeingRemoteControlled()
	{
		return default(bool);
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x841120", Offset = "0x83FF20", VA = "0x180841120", Slot = "164")]
	public Transform GetEyes()
	{
		return null;
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00002BC8 File Offset: 0x00000DC8
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "166")]
	public bool Occupied()
	{
		return default(bool);
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x3212A0", Offset = "0x3200A0", VA = "0x1803212A0", Slot = "165")]
	public global::BaseEntity GetEnt()
	{
		return null;
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00002BE0 File Offset: 0x00000DE0
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "174")]
	public virtual bool CanControl()
	{
		return default(bool);
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600059A RID: 1434 RVA: 0x00002BF8 File Offset: 0x00000DF8
	[Token(Token = "0x1700001E")]
	public virtual bool RequiresMouse
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "175")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "169")]
	public void RCSetup()
	{
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "170")]
	public void RCShutdown()
	{
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x843C20", Offset = "0x842A20", VA = "0x180843C20", Slot = "167")]
	public void UpdateIdentifier(string newID, bool clientSend = false)
	{
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x841130", Offset = "0x83FF30", VA = "0x180841130", Slot = "168")]
	public string GetIdentifier()
	{
		return null;
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00002C10 File Offset: 0x00000E10
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x442CA0", Offset = "0x441AA0", VA = "0x180442CA0", Slot = "149")]
	public override int ConsumptionAmount()
	{
		return 0;
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00002C28 File Offset: 0x00000E28
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x53F9B0", Offset = "0x53E7B0", VA = "0x18053F9B0")]
	public bool IsOnline()
	{
		return default(bool);
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x53F9C0", Offset = "0x53E7C0", VA = "0x18053F9C0")]
	public bool IsOffline()
	{
		return default(bool);
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x8435A0", Offset = "0x8423A0", VA = "0x1808435A0", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x841110", Offset = "0x83FF10", VA = "0x180841110", Slot = "176")]
	public virtual Transform GetCenterMuzzle()
	{
		return null;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00002C58 File Offset: 0x00000E58
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x840680", Offset = "0x83F480", VA = "0x180840680")]
	public float AngleToTarget(BaseCombatEntity potentialtarget, bool use2D = false)
	{
		return 0f;
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00002C70 File Offset: 0x00000E70
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x8424A0", Offset = "0x8412A0", VA = "0x1808424A0", Slot = "177")]
	public virtual bool InFiringArc(BaseCombatEntity potentialtarget)
	{
		return default(bool);
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00002C88 File Offset: 0x00000E88
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x840E10", Offset = "0x83FC10", VA = "0x180840E10", Slot = "133")]
	public override bool CanPickup(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x842980", Offset = "0x841780", VA = "0x180842980", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x844070", Offset = "0x842E70", VA = "0x180844070")]
	public void Update()
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00002CA0 File Offset: 0x00000EA0
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x8403F0", Offset = "0x83F1F0", VA = "0x1808403F0")]
	public Vector3 AimOffset(BaseCombatEntity aimat)
	{
		return default(Vector3);
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00002CB8 File Offset: 0x00000EB8
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x8410E0", Offset = "0x83FEE0", VA = "0x1808410E0")]
	public float GetAimSpeed()
	{
		return 0f;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x843780", Offset = "0x842580", VA = "0x180843780")]
	public void UpdateAiming()
	{
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x842880", Offset = "0x841680", VA = "0x180842880")]
	private static Quaternion Lerp(Quaternion from, Quaternion to, float speed)
	{
		return default(Quaternion);
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x00002CE8 File Offset: 0x00000EE8
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x8426B0", Offset = "0x8414B0", VA = "0x1808426B0")]
	public bool IsAuthed(ulong id)
	{
		return default(bool);
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x00002D00 File Offset: 0x00000F00
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x842760", Offset = "0x841560", VA = "0x180842760")]
	public bool IsAuthed(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x840840", Offset = "0x83F640", VA = "0x180840840")]
	public bool AnyAuthed()
	{
		return default(bool);
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00002D30 File Offset: 0x00000F30
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x840DB0", Offset = "0x83FBB0", VA = "0x180840DB0", Slot = "178")]
	public virtual bool CanChangeSettings(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x8441B0", Offset = "0x842FB0", VA = "0x1808441B0")]
	public AutoTurret()
	{
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x843660", Offset = "0x842460", VA = "0x180843660")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <Menu_AssignToFriend>b__46_0(ulong id)
	{
		return default(bool);
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x843710", Offset = "0x842510", VA = "0x180843710")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private void <Menu_AssignToFriend>b__46_1(ulong id, string steamName)
	{
	}

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x348")]
	private Option __menuOption_Menu_AssignToFriend;

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x3A0")]
	private Option __menuOption_Menu_MaxAuth;

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x3F8")]
	private Option __menuOption_MenuAuthorize;

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x450")]
	private Option __menuOption_MenuClearList;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x4A8")]
	private Option __menuOption_MenuDeauthorize;

	// Token: 0x04000230 RID: 560
	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x500")]
	private Option __menuOption_MenuTurretAttackAll;

	// Token: 0x04000231 RID: 561
	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x558")]
	private Option __menuOption_MenuTurretPeacekeeper;

	// Token: 0x04000232 RID: 562
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x5B0")]
	private Option __menuOption_MenuTurretRotate;

	// Token: 0x04000233 RID: 563
	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x608")]
	public GameObjectRef gun_fire_effect;

	// Token: 0x04000234 RID: 564
	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x610")]
	public GameObjectRef bulletEffect;

	// Token: 0x04000235 RID: 565
	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x618")]
	public float bulletSpeed;

	// Token: 0x04000236 RID: 566
	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x620")]
	public AmbienceEmitter ambienceEmitter;

	// Token: 0x04000237 RID: 567
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x628")]
	public GameObject assignDialog;

	// Token: 0x04000238 RID: 568
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x630")]
	private SoundModulation.Modulator turnSoundModulator;

	// Token: 0x04000239 RID: 569
	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x638")]
	private Sound turnLoop;

	// Token: 0x0400023A RID: 570
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x640")]
	private float nextFocusSound;

	// Token: 0x0400023B RID: 571
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x644")]
	private bool wasTurning;

	// Token: 0x0400023C RID: 572
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x648")]
	private Quaternion lastYaw;

	// Token: 0x0400023D RID: 573
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x658")]
	private global::BasePlayer playerController;

	// Token: 0x0400023E RID: 574
	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x660")]
	private string rcIdentifier;

	// Token: 0x0400023F RID: 575
	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x668")]
	private Vector3 initialAimDir;

	// Token: 0x04000240 RID: 576
	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x674")]
	public float rcTurnSensitivity;

	// Token: 0x04000241 RID: 577
	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x678")]
	public Transform RCEyes;

	// Token: 0x04000242 RID: 578
	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x680")]
	public TargetTrigger targetTrigger;

	// Token: 0x04000243 RID: 579
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x688")]
	public Transform socketTransform;

	// Token: 0x04000244 RID: 580
	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x690")]
	public BaseCombatEntity target;

	// Token: 0x04000245 RID: 581
	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x698")]
	public Transform eyePos;

	// Token: 0x04000246 RID: 582
	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x6A0")]
	public Transform muzzlePos;

	// Token: 0x04000247 RID: 583
	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x6A8")]
	public Vector3 aimDir;

	// Token: 0x04000248 RID: 584
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x6B8")]
	public Transform gun_yaw;

	// Token: 0x04000249 RID: 585
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x6C0")]
	public Transform gun_pitch;

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x6C8")]
	public float sightRange;

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x6D0")]
	public SoundDefinition turnLoopDef;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x6D8")]
	public SoundDefinition movementChangeDef;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x6E0")]
	public SoundDefinition ambientLoopDef;

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x6E8")]
	public SoundDefinition focusCameraDef;

	// Token: 0x0400024F RID: 591
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x6F0")]
	public float focusSoundFreqMin;

	// Token: 0x04000250 RID: 592
	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x6F4")]
	public float focusSoundFreqMax;

	// Token: 0x04000251 RID: 593
	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x6F8")]
	public GameObjectRef peacekeeperToggleSound;

	// Token: 0x04000252 RID: 594
	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x700")]
	public GameObjectRef onlineSound;

	// Token: 0x04000253 RID: 595
	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x708")]
	public GameObjectRef offlineSound;

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x710")]
	public GameObjectRef targetAcquiredEffect;

	// Token: 0x04000255 RID: 597
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x718")]
	public GameObjectRef targetLostEffect;

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x720")]
	public GameObjectRef reloadEffect;

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x728")]
	public float aimCone;

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x40001FD")]
	public const global::BaseEntity.Flags Flag_Equipped = global::BaseEntity.Flags.Reserved3;

	// Token: 0x04000259 RID: 601
	[Token(Token = "0x40001FE")]
	public const global::BaseEntity.Flags Flag_MaxAuths = global::BaseEntity.Flags.Reserved4;

	// Token: 0x0400025A RID: 602
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x730")]
	[NonSerialized]
	public List<PlayerNameID> authorizedPlayers;

	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000A55")]
	public static class TurretFlags
	{
		// Token: 0x0400025B RID: 603
		[Token(Token = "0x4003DA0")]
		public const global::BaseEntity.Flags Peacekeeper = global::BaseEntity.Flags.Reserved1;
	}

	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000A56")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass105_0
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB8")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass105_0()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x65BF80", Offset = "0x65AD80", VA = "0x18065BF80")]
		internal bool <IsAuthed>b__0(PlayerNameID x)
		{
			return default(bool);
		}

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x4003DA1")]
		[FieldOffset(Offset = "0x10")]
		public ulong id;
	}

	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000A57")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass106_0
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass106_0()
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x65BF50", Offset = "0x65AD50", VA = "0x18065BF50")]
		internal bool <IsAuthed>b__0(PlayerNameID x)
		{
			return default(bool);
		}

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x4003DA2")]
		[FieldOffset(Offset = "0x10")]
		public global::BasePlayer player;
	}
}
