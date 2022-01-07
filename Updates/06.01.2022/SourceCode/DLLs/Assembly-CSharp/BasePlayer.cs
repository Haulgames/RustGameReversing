using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200005E RID: 94
[Token(Token = "0x200003E")]
public class BasePlayer : BaseCombatEntity, LootPanel.IHasLootPanel
{
	// Token: 0x06000695 RID: 1685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x30C5D0", Offset = "0x30B3D0", VA = "0x18030C5D0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000696 RID: 1686 RVA: 0x000036F0 File Offset: 0x000018F0
	[Token(Token = "0x1700003F")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x325190", Offset = "0x323F90", VA = "0x180325190", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00003708 File Offset: 0x00001908
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x314040", Offset = "0x312E40", VA = "0x180314040", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00003720 File Offset: 0x00001920
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x3028E0", Offset = "0x3016E0", VA = "0x1803028E0", Slot = "119")]
	public override bool CanBeLooted(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000040")]
	public Translate.Phrase LootPanelTitle
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x3256B0", Offset = "0x3244B0", VA = "0x1803256B0", Slot = "144")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x313040", Offset = "0x311E40", VA = "0x180313040")]
	[Attribute(Name = "Menu", RVA = "0xAB800", Offset = "0xAAC00")]
	[Attribute(Name = "Description", RVA = "0xAB800", Offset = "0xAAC00")]
	[Attribute(Name = "Icon", RVA = "0xAB800", Offset = "0xAAC00")]
	[Attribute(Name = "ShowIf", RVA = "0xAB800", Offset = "0xAAC00")]
	public void Menu_LootPlayer(global::BasePlayer player)
	{
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00003738 File Offset: 0x00001938
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x313020", Offset = "0x311E20", VA = "0x180313020")]
	public bool Menu_LootPlayer_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x31D850", Offset = "0x31C650", VA = "0x18031D850")]
	[global::BaseEntity.RPC_Client]
	private void RPC_OpenLootPanel(global::BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x31BB80", Offset = "0x31A980", VA = "0x18031BB80")]
	private void PlayOpenSound()
	{
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00003750 File Offset: 0x00001950
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x30EE70", Offset = "0x30DC70", VA = "0x18030EE70")]
	public bool InFirstPersonMode()
	{
		return default(bool);
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x323730", Offset = "0x322530", VA = "0x180323730")]
	public void UpdateViewMode()
	{
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00003768 File Offset: 0x00001968
	[Token(Token = "0x17000041")]
	internal global::BasePlayer.CameraMode idealViewMode
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x325890", Offset = "0x324690", VA = "0x180325890")]
		get
		{
			return global::BasePlayer.CameraMode.FirstPerson;
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00003780 File Offset: 0x00001980
	[Token(Token = "0x17000042")]
	internal bool shouldDrawBody
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x325C10", Offset = "0x324A10", VA = "0x180325C10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x31B630", Offset = "0x31A430", VA = "0x18031B630", Slot = "145")]
	public virtual void OnViewModeChanged()
	{
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x3130B0", Offset = "0x311EB0", VA = "0x1803130B0")]
	public void ModifyCamera()
	{
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000276")]
	[Address(RVA = "0x312FE0", Offset = "0x311DE0", VA = "0x180312FE0")]
	[Attribute(Name = "Menu", RVA = "0xAB980", Offset = "0xAAD80")]
	[Attribute(Name = "Description", RVA = "0xAB980", Offset = "0xAAD80")]
	[Attribute(Name = "Icon", RVA = "0xAB980", Offset = "0xAAD80")]
	[Attribute(Name = "ShowIf", RVA = "0xAB980", Offset = "0xAAD80")]
	public void Menu_AssistPlayer(global::BasePlayer player)
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x312FA0", Offset = "0x311DA0", VA = "0x180312FA0")]
	public void Menu_AssistPlayer_TimeStart()
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x312D10", Offset = "0x311B10", VA = "0x180312D10")]
	public bool Menu_AssistPlayer_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000043")]
	public GameObject lookingAt
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x325BC0", Offset = "0x3249C0", VA = "0x180325BC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000044")]
	public global::BaseEntity lookingAtEntity
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x325B50", Offset = "0x324950", VA = "0x180325B50")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000045")]
	public Collider lookingAtCollider
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x325B00", Offset = "0x324900", VA = "0x180325B00")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060006AA RID: 1706 RVA: 0x000037B0 File Offset: 0x000019B0
	// (set) Token: 0x060006AB RID: 1707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000046")]
	public Vector3 lookingAtPoint
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x325BA0", Offset = "0x3249A0", VA = "0x180325BA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x325F10", Offset = "0x324D10", VA = "0x180325F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x600027E")]
	[Address(RVA = "0x30B930", Offset = "0x30A730", VA = "0x18030B930", Slot = "52")]
	public override float GetExtrapolationTime()
	{
		return 0f;
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x30C3D0", Offset = "0x30B1D0", VA = "0x18030C3D0", Slot = "57")]
	public override Vector3 GetLocalVelocityClient()
	{
		return default(Vector3);
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x3043F0", Offset = "0x3031F0", VA = "0x1803043F0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x308E20", Offset = "0x307C20", VA = "0x180308E20")]
	private void CreatePlayerModel()
	{
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x308C30", Offset = "0x307A30", VA = "0x180308C30")]
	private void CreatePlayerCollision()
	{
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x309380", Offset = "0x308180", VA = "0x180309380")]
	private void CreatePlayerMovement()
	{
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x30EEA0", Offset = "0x30DCA0", VA = "0x18030EEA0")]
	internal void InitLocalPlayer()
	{
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x30F180", Offset = "0x30DF80", VA = "0x18030F180")]
	internal void InitRemotePlayer()
	{
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x000037F8 File Offset: 0x000019F8
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x30E520", Offset = "0x30D320", VA = "0x18030E520")]
	public bool HasLocalControls()
	{
		return default(bool);
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x3204A0", Offset = "0x31F2A0", VA = "0x1803204A0", Slot = "59")]
	public override void SetNetworkPosition(Vector3 vPos)
	{
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x320550", Offset = "0x31F350", VA = "0x180320550", Slot = "60")]
	public override void SetNetworkRotation(Quaternion qRot)
	{
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x309800", Offset = "0x308600", VA = "0x180309800", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x31C370", Offset = "0x31B170", VA = "0x18031C370", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x313A60", Offset = "0x312860", VA = "0x180313A60")]
	private void OnFirstWakeUp()
	{
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060006BA RID: 1722 RVA: 0x00003810 File Offset: 0x00001A10
	[Token(Token = "0x17000047")]
	public float TimeAwake
	{
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x3256D0", Offset = "0x3244D0", VA = "0x1803256D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x301EC0", Offset = "0x300CC0", VA = "0x180301EC0")]
	public void CL_ClothingChanged()
	{
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028E")]
	[Address(RVA = "0x30AE80", Offset = "0x309C80", VA = "0x18030AE80")]
	public void ForceRebuild()
	{
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x31DCF0", Offset = "0x31CAF0", VA = "0x18031DCF0")]
	internal void RebuildWorldModel(PlayerModel playerModel)
	{
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x31FC20", Offset = "0x31EA20", VA = "0x18031FC20")]
	private void SetDefaultFootstepEffects()
	{
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x31B0B0", Offset = "0x319EB0", VA = "0x18031B0B0", Slot = "83")]
	public override void OnSignal(global::BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x30A520", Offset = "0x309320", VA = "0x18030A520", Slot = "123")]
	public override Transform FindBone(string strName)
	{
		return null;
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x30AEA0", Offset = "0x309CA0", VA = "0x18030AEA0", Slot = "122")]
	public override Transform[] GetBones()
	{
		return null;
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00003828 File Offset: 0x00001A28
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x320D60", Offset = "0x31FB60", VA = "0x180320D60", Slot = "58")]
	public override bool ShouldLerp()
	{
		return default(bool);
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000048")]
	public static BufferList<global::BasePlayer> VisiblePlayerList
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x325730", Offset = "0x324530", VA = "0x180325730")]
		get
		{
			return null;
		}
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x303F30", Offset = "0x302D30", VA = "0x180303F30")]
	public static void ClearVisibility()
	{
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x31E4B0", Offset = "0x31D2B0", VA = "0x18031E4B0")]
	public static void RegisterForVisibility(global::BasePlayer player)
	{
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x321490", Offset = "0x320290", VA = "0x180321490")]
	public static void UnregisterFromVisibility(ulong userID)
	{
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x30A620", Offset = "0x309420", VA = "0x18030A620")]
	public static global::BasePlayer FindByID_Clientside(ulong userID)
	{
		return null;
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x30A7F0", Offset = "0x3095F0", VA = "0x18030A7F0")]
	public static global::BasePlayer Find_Clientside(string strNameOrIDOrIP)
	{
		return null;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00003840 File Offset: 0x00001A40
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x30DD40", Offset = "0x30CB40", VA = "0x18030DD40")]
	public static float GetRandomFloatBasedOnUserID(ulong steamid, ulong seed)
	{
		return 0f;
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00003858 File Offset: 0x00001A58
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "130")]
	public override bool DisplayHealthInfo(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00003870 File Offset: 0x00001A70
	[Token(Token = "0x600029D")]
	[Address(RVA = "0x320D30", Offset = "0x31FB30", VA = "0x180320D30", Slot = "17")]
	public override bool ShouldDestroyWithGroup()
	{
		return default(bool);
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x3200F0", Offset = "0x31EEF0", VA = "0x1803200F0")]
	[global::BaseEntity.RPC_Client]
	public void SetInheritedVelocity(Vector3 velocity, uint entID)
	{
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x30DC30", Offset = "0x30CA30", VA = "0x18030DC30")]
	[global::BaseEntity.RPC_Client]
	public void GetPerformanceReport(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x3134B0", Offset = "0x3122B0", VA = "0x1803134B0", Slot = "63")]
	public override void OnBecameRagdoll(Ragdoll rdoll)
	{
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x31BB40", Offset = "0x31A940", VA = "0x18031BB40", Slot = "74")]
	public override void OnVoiceData(byte[] data)
	{
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x31E080", Offset = "0x31CE80", VA = "0x18031E080")]
	[global::BaseEntity.RPC_Client]
	public void RecieveAchievement(string name)
	{
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x3089C0", Offset = "0x3077C0", VA = "0x1803089C0")]
	[global::BaseEntity.RPC_Client]
	public void CraftMode(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x321040", Offset = "0x31FE40", VA = "0x180321040")]
	[global::BaseEntity.RPC_Client]
	public void StartDesigningAI(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x313820", Offset = "0x312620", VA = "0x180313820")]
	[global::BaseEntity.RPC_Client]
	public void OnDebugAIEventTriggeredStateChange(int previousStateContainerID, int newStateContainerID, int sourceEventID)
	{
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x305390", Offset = "0x304190", VA = "0x180305390", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00003888 File Offset: 0x00001A88
	// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000049")]
	public bool IsWearingDiveGoggles
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x3256A0", Offset = "0x3244A0", VA = "0x1803256A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x325DC0", Offset = "0x324BC0", VA = "0x180325DC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x3215E0", Offset = "0x3203E0", VA = "0x1803215E0")]
	protected void UpdateClothesIfNeeded()
	{
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x312A20", Offset = "0x311820", VA = "0x180312A20", Slot = "89")]
	public override void MakeVisible()
	{
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x306680", Offset = "0x305480", VA = "0x180306680")]
	protected void ClientUpdate_Sleeping()
	{
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x306A70", Offset = "0x305870", VA = "0x180306A70")]
	protected void ClientUpdate()
	{
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x31DAD0", Offset = "0x31C8D0", VA = "0x18031DAD0")]
	public void RebuildClothingItems()
	{
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x321AD0", Offset = "0x3208D0", VA = "0x180321AD0")]
	public void UpdateClothingItems(SkinnedMultiMesh multiMesh)
	{
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x322200", Offset = "0x321000", VA = "0x180322200")]
	public void UpdateHolsterOffsets()
	{
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x31C2B0", Offset = "0x31B0B0", VA = "0x18031C2B0")]
	public void PostLateClientCycle()
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x000038A0 File Offset: 0x00001AA0
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x310AB0", Offset = "0x30F8B0", VA = "0x180310AB0")]
	public bool IsLocalPlayer()
	{
		return default(bool);
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x3054F0", Offset = "0x3042F0", VA = "0x1803054F0")]
	public void ClientUpdateLocalPlayer()
	{
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x3235D0", Offset = "0x3223D0", VA = "0x1803235D0")]
	public void UpdateTopologyStats()
	{
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x305440", Offset = "0x304240", VA = "0x180305440")]
	private void ClientTick()
	{
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x309AF0", Offset = "0x3088F0", VA = "0x180309AF0")]
	public void DoMovement()
	{
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x3131A0", Offset = "0x311FA0", VA = "0x1803131A0")]
	private void MountableOverrideViewAngles()
	{
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x3013B0", Offset = "0x3001B0", VA = "0x1803013B0", Slot = "146")]
	public virtual void BlockSprint(float duration = 0.2f)
	{
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x301310", Offset = "0x300110", VA = "0x180301310", Slot = "147")]
	public virtual void BlockJump(float duration = 0.5f)
	{
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x3048E0", Offset = "0x3036E0", VA = "0x1803048E0", Slot = "148")]
	internal virtual void ClientInput(InputState state)
	{
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x323A90", Offset = "0x322890", VA = "0x180323A90")]
	internal void UseAction(InputState state)
	{
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x30BEC0", Offset = "0x30ACC0", VA = "0x18030BEC0")]
	internal global::BaseEntity GetInteractionEntity()
	{
		return null;
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x31D6B0", Offset = "0x31C4B0", VA = "0x18031D6B0")]
	internal void QuickUse()
	{
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x312960", Offset = "0x311760", VA = "0x180312960")]
	internal void LongUse()
	{
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x323D60", Offset = "0x322B60", VA = "0x180323D60")]
	internal void UseStop()
	{
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x000038B8 File Offset: 0x00001AB8
	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x322390", Offset = "0x321190", VA = "0x180322390")]
	internal bool UpdateLookingAt(float radius, bool includeSecondaryEntities)
	{
		return default(bool);
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x31E900", Offset = "0x31D700", VA = "0x18031E900")]
	private void ResetLookingAt()
	{
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x320280", Offset = "0x31F080", VA = "0x180320280")]
	private void SetLookingAt(HitTest lookingAtTest)
	{
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x000038D0 File Offset: 0x00001AD0
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x303730", Offset = "0x302530", VA = "0x180303730")]
	private bool CheckLookingAtVisible(HitTest test, TraceInfo trace)
	{
		return default(bool);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x30A6B0", Offset = "0x3094B0", VA = "0x18030A6B0")]
	private static global::BaseVehicle FindVehicleParentFor(global::BaseEntity entity)
	{
		return null;
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x313990", Offset = "0x312790", VA = "0x180313990")]
	[global::BaseEntity.RPC_Client]
	private void OnDied(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x313D90", Offset = "0x312B90", VA = "0x180313D90")]
	[global::BaseEntity.RPC_Client]
	private void OnRespawnInformation(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x31E7B0", Offset = "0x31D5B0", VA = "0x18031E7B0")]
	private void RequestRespawnUpdates()
	{
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x313BA0", Offset = "0x3129A0", VA = "0x180313BA0")]
	public void OnLand(float fVelocity)
	{
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x3211D0", Offset = "0x31FFD0", VA = "0x1803211D0")]
	[global::BaseEntity.RPC_Client]
	private void StartLoading()
	{
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x30AA80", Offset = "0x309880", VA = "0x18030AA80")]
	[global::BaseEntity.RPC_Client]
	private void FinishLoading()
	{
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x30AB50", Offset = "0x309950", VA = "0x18030AB50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xABE70", Offset = "0xAB270")]
	private IEnumerator FinishedLoadingRoutine()
	{
		return null;
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x309660", Offset = "0x308460", VA = "0x180309660")]
	[global::BaseEntity.RPC_Client]
	private void DirectionalDamage(Vector3 position, int damageType)
	{
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x321420", Offset = "0x320220", VA = "0x180321420")]
	[global::BaseEntity.RPC_Client]
	public void UnlockedBlueprint(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x3036C0", Offset = "0x3024C0", VA = "0x1803036C0")]
	private void CheckForRespawnInfo()
	{
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x323330", Offset = "0x322130", VA = "0x180323330")]
	[global::BaseEntity.RPC_Client]
	public void UpdateRichPresenceState(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x30E020", Offset = "0x30CE20", VA = "0x18030E020")]
	[global::BaseEntity.RPC_Client]
	public void HandleCompanionPairingResult(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x000038E8 File Offset: 0x00001AE8
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x323770", Offset = "0x322570", VA = "0x180323770")]
	public Vector3 UpdateWaterDrinkingPoint()
	{
		return default(Vector3);
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00003900 File Offset: 0x00001B00
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x30E000", Offset = "0x30CE00", VA = "0x18030E000")]
	private Vector3 GetWaterDrinkingPoint()
	{
		return default(Vector3);
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x309D80", Offset = "0x308B80", VA = "0x180309D80")]
	[Attribute(Name = "Menu", RVA = "0xAC480", Offset = "0xAB880")]
	[Attribute(Name = "Description", RVA = "0xAC480", Offset = "0xAB880")]
	[Attribute(Name = "Icon", RVA = "0xAC480", Offset = "0xAB880")]
	[Attribute(Name = "ShowIf", RVA = "0xAC480", Offset = "0xAB880")]
	public void Drink(global::BasePlayer player)
	{
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00003918 File Offset: 0x00001B18
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x309BB0", Offset = "0x3089B0", VA = "0x180309BB0")]
	public bool Drink_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	[Attribute(Name = "Menu", RVA = "0xAC9A0", Offset = "0xABDA0")]
	[Attribute(Name = "Description", RVA = "0xAC9A0", Offset = "0xABDA0")]
	[Attribute(Name = "Icon", RVA = "0xAC9A0", Offset = "0xABDA0")]
	[Attribute(Name = "ShowIf", RVA = "0xAC9A0", Offset = "0xABDA0")]
	public void SaltWater(global::BasePlayer player)
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00003930 File Offset: 0x00001B30
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x31EA80", Offset = "0x31D880", VA = "0x18031EA80")]
	public bool SaltWater_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x308160", Offset = "0x306F60", VA = "0x180308160")]
	[Attribute(Name = "Menu", RVA = "0xACC70", Offset = "0xAC070")]
	[Attribute(Name = "Description", RVA = "0xACC70", Offset = "0xAC070")]
	[Attribute(Name = "Icon", RVA = "0xACC70", Offset = "0xAC070")]
	[Attribute(Name = "ShowIf", RVA = "0xACC70", Offset = "0xAC070")]
	public void Climb(global::BasePlayer player)
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00003948 File Offset: 0x00001B48
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x307E90", Offset = "0x306C90", VA = "0x180307E90")]
	public bool Climb_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00003960 File Offset: 0x00001B60
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x30E590", Offset = "0x30D390", VA = "0x18030E590")]
	public bool HasPlayerFlag(global::BasePlayer.PlayerFlags f)
	{
		return default(bool);
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000707 RID: 1799 RVA: 0x00003978 File Offset: 0x00001B78
	[Token(Token = "0x1700004A")]
	public bool IsReceivingSnapshot
	{
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x325690", Offset = "0x324490", VA = "0x180325690")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000708 RID: 1800 RVA: 0x00003990 File Offset: 0x00001B90
	[Token(Token = "0x1700004B")]
	public bool IsAdmin
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x3255D0", Offset = "0x3243D0", VA = "0x1803255D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000709 RID: 1801 RVA: 0x000039A8 File Offset: 0x00001BA8
	[Token(Token = "0x1700004C")]
	public bool IsDeveloper
	{
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x325660", Offset = "0x324460", VA = "0x180325660")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x0600070A RID: 1802 RVA: 0x000039C0 File Offset: 0x00001BC0
	[Token(Token = "0x1700004D")]
	public bool IsAiming
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x3255E0", Offset = "0x3243E0", VA = "0x1803255E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600070B RID: 1803 RVA: 0x000039D8 File Offset: 0x00001BD8
	[Token(Token = "0x1700004E")]
	public bool IsFlying
	{
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x325670", Offset = "0x324470", VA = "0x180325670")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600070C RID: 1804 RVA: 0x000039F0 File Offset: 0x00001BF0
	[Token(Token = "0x1700004F")]
	public bool IsConnected
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x3255F0", Offset = "0x3243F0", VA = "0x1803255F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600070D RID: 1805 RVA: 0x00003A08 File Offset: 0x00001C08
	[Token(Token = "0x17000050")]
	public bool InGesture
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x325520", Offset = "0x324320", VA = "0x180325520")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600070E RID: 1806 RVA: 0x00003A20 File Offset: 0x00001C20
	[Token(Token = "0x17000051")]
	private bool CurrentGestureBlocksMovement
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x325070", Offset = "0x323E70", VA = "0x180325070")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600070F RID: 1807 RVA: 0x00003A38 File Offset: 0x00001C38
	[Token(Token = "0x17000052")]
	public bool CurrentGestureIsDance
	{
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x3250B0", Offset = "0x323EB0", VA = "0x1803250B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000710 RID: 1808 RVA: 0x00003A50 File Offset: 0x00001C50
	[Token(Token = "0x17000053")]
	public bool CurrentGestureIsFullBody
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x3250F0", Offset = "0x323EF0", VA = "0x1803250F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000711 RID: 1809 RVA: 0x00003A68 File Offset: 0x00001C68
	[Token(Token = "0x17000054")]
	private bool InGestureCancelCooldown
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x3254F0", Offset = "0x3242F0", VA = "0x1803254F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x31FCF0", Offset = "0x31EAF0", VA = "0x18031FCF0")]
	private void SetGestureMenuOpen(bool wantsOpen)
	{
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x31E850", Offset = "0x31D650", VA = "0x18031E850")]
	private void RequestStartGesture(GestureConfig g)
	{
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x307960", Offset = "0x306760", VA = "0x180307960")]
	[global::BaseEntity.RPC_Client]
	private void Client_StartGesture(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x3079C0", Offset = "0x3067C0", VA = "0x1803079C0")]
	public void Client_StartGesture(GestureConfig gesture)
	{
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x31CA40", Offset = "0x31B840", VA = "0x18031CA40")]
	private void ProcessDanceAction()
	{
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00003A80 File Offset: 0x00001C80
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x31ECF0", Offset = "0x31DAF0", VA = "0x18031ECF0")]
	public bool SayingHello()
	{
		return default(bool);
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x31CF30", Offset = "0x31BD30", VA = "0x18031CF30")]
	private void ProcessGestureStart()
	{
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x30A0A0", Offset = "0x308EA0", VA = "0x18030A0A0")]
	private void EndGesture()
	{
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x30A140", Offset = "0x308F40", VA = "0x18030A140")]
	private void EndLocalGesture()
	{
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x309F30", Offset = "0x308D30", VA = "0x180309F30")]
	private void EndGestureShared()
	{
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x30ED00", Offset = "0x30DB00", VA = "0x18030ED00")]
	private void HideHeldEntity(bool state)
	{
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x303400", Offset = "0x302200", VA = "0x180303400")]
	private void CancelGesture()
	{
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x31E5A0", Offset = "0x31D3A0", VA = "0x18031E5A0")]
	public void RemoteGestureCancel()
	{
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00003A98 File Offset: 0x00001C98
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x302FA0", Offset = "0x301DA0", VA = "0x180302FA0")]
	private bool CancelGestureInput()
	{
		return default(bool);
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x303DE0", Offset = "0x302BE0", VA = "0x180303DE0")]
	public void ClearGestureCooldown()
	{
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00003AB0 File Offset: 0x00001CB0
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x308760", Offset = "0x307560", VA = "0x180308760")]
	public bool ConVarRequestStartGesture(string gestureName)
	{
		return default(bool);
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x307910", Offset = "0x306710", VA = "0x180307910")]
	[global::BaseEntity.RPC_Client]
	private void Client_RemoteCancelledGesture()
	{
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00003AC8 File Offset: 0x00001CC8
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x310410", Offset = "0x30F210", VA = "0x180310410")]
	private bool IsGestureBlocked()
	{
		return default(bool);
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000724 RID: 1828 RVA: 0x00003AE0 File Offset: 0x00001CE0
	[Token(Token = "0x17000055")]
	public float clientTeamLifetime
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x3257A0", Offset = "0x3245A0", VA = "0x1803257A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x3019F0", Offset = "0x3007F0", VA = "0x1803019F0")]
	[global::BaseEntity.RPC_Client]
	public void CLIENT_ReceiveTeamInfo(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x323380", Offset = "0x322180", VA = "0x180323380")]
	private void UpdateSteamGroup(ulong teamId, int teamSize)
	{
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x303E10", Offset = "0x302C10", VA = "0x180303E10")]
	private void ClearSteamGroup()
	{
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x301450", Offset = "0x300250", VA = "0x180301450")]
	[global::BaseEntity.RPC_Client]
	public void CLIENT_ClearTeam(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x3015F0", Offset = "0x3003F0", VA = "0x1803015F0")]
	[global::BaseEntity.RPC_Client]
	public void CLIENT_PendingInvite(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x30F1F0", Offset = "0x30DFF0", VA = "0x18030F1F0")]
	[Attribute(Name = "Menu", RVA = "0xAD360", Offset = "0xAC760")]
	[Attribute(Name = "Description", RVA = "0xAD360", Offset = "0xAC760")]
	[Attribute(Name = "Icon", RVA = "0xAD360", Offset = "0xAC760")]
	[Attribute(Name = "ShowIf", RVA = "0xAD360", Offset = "0xAC760")]
	public void InviteToTeam(global::BasePlayer player)
	{
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x31D520", Offset = "0x31C320", VA = "0x18031D520")]
	[Attribute(Name = "Menu", RVA = "0xAD690", Offset = "0xACA90")]
	[Attribute(Name = "Description", RVA = "0xAD690", Offset = "0xACA90")]
	[Attribute(Name = "Icon", RVA = "0xAD690", Offset = "0xACA90")]
	[Attribute(Name = "ShowIf", RVA = "0xAD690", Offset = "0xACA90")]
	public void Promote(global::BasePlayer player)
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	public void Menu_Promote_Start()
	{
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00003AF8 File Offset: 0x00001CF8
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x31D150", Offset = "0x31BF50", VA = "0x18031D150")]
	public bool Promote_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00003B10 File Offset: 0x00001D10
	[Token(Token = "0x6000300")]
	[Address(RVA = "0x312470", Offset = "0x311270", VA = "0x180312470")]
	public static bool LocalPlayerIsLeader()
	{
		return default(bool);
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x30F740", Offset = "0x30E540", VA = "0x18030F740")]
	public bool Invite_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000302")]
	[Address(RVA = "0x30BA20", Offset = "0x30A820", VA = "0x18030BA20")]
	public global::HeldEntity GetHeldEntity()
	{
		return null;
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00003B40 File Offset: 0x00001D40
	[Token(Token = "0x6000303")]
	public bool IsHoldingEntity<T>()
	{
		return default(bool);
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x30BC50", Offset = "0x30AA50", VA = "0x18030BC50")]
	private global::Item GetHeldItem()
	{
		return null;
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00003B58 File Offset: 0x00001D58
	[Token(Token = "0x6000305")]
	[Address(RVA = "0x30BC00", Offset = "0x30AA00", VA = "0x18030BC00")]
	public uint GetHeldItemID()
	{
		return 0U;
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x30EAE0", Offset = "0x30D8E0", VA = "0x18030EAE0")]
	private void HeldEntityViewAngles()
	{
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x30E670", Offset = "0x30D470", VA = "0x18030E670")]
	private void HeldEntityFrame()
	{
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x30E840", Offset = "0x30D640", VA = "0x18030E840")]
	private void HeldEntityInput()
	{
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00003B70 File Offset: 0x00001D70
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x30EC00", Offset = "0x30DA00", VA = "0x18030EC00")]
	private bool HeldItemUse()
	{
		return default(bool);
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x30EA10", Offset = "0x30D810", VA = "0x18030EA10")]
	public void HeldEntityStart()
	{
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x30E5A0", Offset = "0x30D3A0", VA = "0x18030E5A0")]
	public void HeldEntityEnd()
	{
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00003B88 File Offset: 0x00001D88
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x3107C0", Offset = "0x30F5C0", VA = "0x1803107C0")]
	public bool IsHostileItem(global::Item item)
	{
		return default(bool);
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00003BA0 File Offset: 0x00001DA0
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x310920", Offset = "0x30F720", VA = "0x180310920")]
	public bool IsItemHoldRestricted(global::Item item)
	{
		return default(bool);
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x312AD0", Offset = "0x3118D0", VA = "0x180312AD0")]
	private void MapInfoOnEnable()
	{
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x3075D0", Offset = "0x3063D0", VA = "0x1803075D0")]
	[global::BaseEntity.RPC_Client]
	public void Client_ReceiveMarkers(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x307D60", Offset = "0x306B60", VA = "0x180307D60")]
	[global::BaseEntity.RPC_Client]
	public void Client_UpdateDeathMarker(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x307490", Offset = "0x306290", VA = "0x180307490")]
	[global::BaseEntity.RPC_Client]
	public void Client_AddNewDeathMarker(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x300590", Offset = "0x2FF390", VA = "0x180300590")]
	public void AddPointOfInterest(Vector3 position)
	{
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000313")]
	[Address(RVA = "0x303C90", Offset = "0x302A90", VA = "0x180303C90")]
	public void ClearAllPointsOfInterest()
	{
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x303B30", Offset = "0x302930", VA = "0x180303B30")]
	public void ClearAllMapMarkers()
	{
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00003BB8 File Offset: 0x00001DB8
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x30E0D0", Offset = "0x30CED0", VA = "0x18030E0D0")]
	public bool HasAttemptedMission(uint missionID)
	{
		return default(bool);
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00003BD0 File Offset: 0x00001DD0
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x302200", Offset = "0x301000", VA = "0x180302200")]
	public bool CanAcceptMission(uint missionID)
	{
		return default(bool);
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x310B90", Offset = "0x30F990", VA = "0x180310B90")]
	public bool IsMissionActive(uint missionID)
	{
		return default(bool);
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00003C00 File Offset: 0x00001E00
	[Token(Token = "0x6000318")]
	[Address(RVA = "0x30E240", Offset = "0x30D040", VA = "0x18030E240")]
	public bool HasCompletedMission(uint missionID)
	{
		return default(bool);
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00003C18 File Offset: 0x00001E18
	[Token(Token = "0x6000319")]
	[Address(RVA = "0x30E3B0", Offset = "0x30D1B0", VA = "0x18030E3B0")]
	public bool HasFailedMission(uint missionID)
	{
		return default(bool);
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031A")]
	[Address(RVA = "0x31FC00", Offset = "0x31EA00", VA = "0x18031FC00")]
	public void SetActiveMission(int index)
	{
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00003C30 File Offset: 0x00001E30
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x30AE90", Offset = "0x309C90", VA = "0x18030AE90")]
	public int GetActiveMission()
	{
		return 0;
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00003C48 File Offset: 0x00001E48
	[Token(Token = "0x600031C")]
	[Address(RVA = "0x30E0C0", Offset = "0x30CEC0", VA = "0x18030E0C0")]
	public bool HasActiveMission()
	{
		return default(bool);
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031D")]
	[Address(RVA = "0x311970", Offset = "0x310770", VA = "0x180311970")]
	private void LoadMissions(Missions loadedMissions)
	{
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031E")]
	[Address(RVA = "0x313D00", Offset = "0x312B00", VA = "0x180313D00")]
	[global::BaseEntity.RPC_Client]
	private void OnModelState(global::BaseEntity.RPCMessage data)
	{
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031F")]
	[Address(RVA = "0x313C60", Offset = "0x312A60", VA = "0x180313C60")]
	private void OnModelStateChanged()
	{
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600074E RID: 1870 RVA: 0x00003C60 File Offset: 0x00001E60
	[Token(Token = "0x17000056")]
	public bool isMounted
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x325A30", Offset = "0x324830", VA = "0x180325A30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x0600074F RID: 1871 RVA: 0x00003C78 File Offset: 0x00001E78
	[Token(Token = "0x17000057")]
	public bool isMountingHidingWeapon
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x325A50", Offset = "0x324850", VA = "0x180325A50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000322")]
	[Address(RVA = "0x30D740", Offset = "0x30C540", VA = "0x18030D740")]
	public BaseMountable GetMounted()
	{
		return null;
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000323")]
	[Address(RVA = "0x30D6F0", Offset = "0x30C4F0", VA = "0x18030D6F0")]
	public global::BaseVehicle GetMountedVehicle()
	{
		return null;
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000324")]
	[Address(RVA = "0x312B20", Offset = "0x311920", VA = "0x180312B20")]
	public void MarkSwapSeat()
	{
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00003C90 File Offset: 0x00001E90
	[Token(Token = "0x6000325")]
	[Address(RVA = "0x321250", Offset = "0x320050", VA = "0x180321250")]
	public bool SwapSeatCooldown()
	{
		return default(bool);
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000326")]
	[Address(RVA = "0x3062D0", Offset = "0x3050D0", VA = "0x1803062D0")]
	public void ClientUpdateMounted(uint id)
	{
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000327")]
	[Address(RVA = "0x301DF0", Offset = "0x300BF0", VA = "0x180301DF0")]
	[global::BaseEntity.RPC_Client]
	public void CLIENT_SetPetPrefabID(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000328")]
	[Address(RVA = "0x301C40", Offset = "0x300A40", VA = "0x180301C40")]
	[global::BaseEntity.RPC_Client]
	public void CLIENT_SetPetPetLoadedStateIndex(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000329")]
	[Address(RVA = "0x311820", Offset = "0x310620", VA = "0x180311820")]
	private void LinkPet()
	{
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032A")]
	[Address(RVA = "0x320660", Offset = "0x31F460", VA = "0x180320660")]
	private void SetPetMenuOpen(bool wantsOpen)
	{
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032B")]
	[Address(RVA = "0x3052A0", Offset = "0x3040A0", VA = "0x1803052A0")]
	private void ClientIssuePetCommand(int cmdType, int param, bool raycast)
	{
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00003CA8 File Offset: 0x00001EA8
	[Token(Token = "0x600032C")]
	[Address(RVA = "0x310E90", Offset = "0x30FC90", VA = "0x180310E90")]
	public bool IsSleeping()
	{
		return default(bool);
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x600032D")]
	[Address(RVA = "0x310EA0", Offset = "0x30FCA0", VA = "0x180310EA0")]
	public bool IsSpectating()
	{
		return default(bool);
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x600032E")]
	[Address(RVA = "0x310DB0", Offset = "0x30FBB0", VA = "0x180310DB0")]
	public bool IsRelaxed()
	{
		return default(bool);
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00003CF0 File Offset: 0x00001EF0
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x310E80", Offset = "0x30FC80", VA = "0x180310E80")]
	public bool IsServerFalling()
	{
		return default(bool);
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x30B2B0", Offset = "0x30A0B0", VA = "0x18030B2B0", Slot = "82")]
	public override BuildingPrivlidge GetBuildingPrivilege()
	{
		return null;
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00003D08 File Offset: 0x00001F08
	[Token(Token = "0x6000331")]
	[Address(RVA = "0x302BB0", Offset = "0x3019B0", VA = "0x180302BB0")]
	public bool CanBuild()
	{
		return default(bool);
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00003D20 File Offset: 0x00001F20
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x302A50", Offset = "0x301850", VA = "0x180302A50")]
	public bool CanBuild(Vector3 position, Quaternion rotation, Bounds bounds)
	{
		return default(bool);
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00003D38 File Offset: 0x00001F38
	[Token(Token = "0x6000333")]
	[Address(RVA = "0x302980", Offset = "0x301780", VA = "0x180302980")]
	public bool CanBuild(OBB obb)
	{
		return default(bool);
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00003D50 File Offset: 0x00001F50
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x310190", Offset = "0x30EF90", VA = "0x180310190")]
	public bool IsBuildingBlocked()
	{
		return default(bool);
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00003D68 File Offset: 0x00001F68
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x310030", Offset = "0x30EE30", VA = "0x180310030")]
	public bool IsBuildingBlocked(Vector3 position, Quaternion rotation, Bounds bounds)
	{
		return default(bool);
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00003D80 File Offset: 0x00001F80
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x30FF50", Offset = "0x30ED50", VA = "0x18030FF50")]
	public bool IsBuildingBlocked(OBB obb)
	{
		return default(bool);
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00003D98 File Offset: 0x00001F98
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x30FD50", Offset = "0x30EB50", VA = "0x18030FD50")]
	public bool IsBuildingAuthed()
	{
		return default(bool);
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00003DB0 File Offset: 0x00001FB0
	[Token(Token = "0x6000338")]
	[Address(RVA = "0x30FDF0", Offset = "0x30EBF0", VA = "0x18030FDF0")]
	public bool IsBuildingAuthed(Vector3 position, Quaternion rotation, Bounds bounds)
	{
		return default(bool);
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00003DC8 File Offset: 0x00001FC8
	[Token(Token = "0x6000339")]
	[Address(RVA = "0x30FC80", Offset = "0x30EA80", VA = "0x18030FC80")]
	public bool IsBuildingAuthed(OBB obb)
	{
		return default(bool);
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00003DE0 File Offset: 0x00001FE0
	[Token(Token = "0x600033A")]
	[Address(RVA = "0x302D40", Offset = "0x301B40", VA = "0x180302D40")]
	public bool CanPlaceBuildingPrivilege()
	{
		return default(bool);
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00003DF8 File Offset: 0x00001FF8
	[Token(Token = "0x600033B")]
	[Address(RVA = "0x302DB0", Offset = "0x301BB0", VA = "0x180302DB0")]
	public bool CanPlaceBuildingPrivilege(Vector3 position, Quaternion rotation, Bounds bounds)
	{
		return default(bool);
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00003E10 File Offset: 0x00002010
	[Token(Token = "0x600033C")]
	[Address(RVA = "0x302EF0", Offset = "0x301CF0", VA = "0x180302EF0")]
	public bool CanPlaceBuildingPrivilege(OBB obb)
	{
		return default(bool);
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00003E28 File Offset: 0x00002028
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x313230", Offset = "0x312030", VA = "0x180313230")]
	public int NewProjectileID()
	{
		return 0;
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00003E40 File Offset: 0x00002040
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x313240", Offset = "0x312040", VA = "0x180313240")]
	public int NewProjectileSeed()
	{
		return 0;
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033F")]
	[Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x18031F950")]
	public void SendProjectileAttack(PlayerProjectileAttack attack)
	{
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000340")]
	[Address(RVA = "0x31F9A0", Offset = "0x31E7A0", VA = "0x18031F9A0")]
	public void SendProjectileRicochet(PlayerProjectileRicochet ricochet)
	{
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000341")]
	[Address(RVA = "0x31F9F0", Offset = "0x31E7F0", VA = "0x18031F9F0")]
	public void SendProjectileUpdate(PlayerProjectileUpdate update)
	{
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000342")]
	[Address(RVA = "0x311F10", Offset = "0x310D10", VA = "0x180311F10", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000343")]
	[Address(RVA = "0x320FB0", Offset = "0x31FDB0", VA = "0x180320FB0")]
	[global::BaseEntity.RPC_Client]
	private void SpectatedPlayerHeadshot()
	{
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00003E58 File Offset: 0x00002058
	[Token(Token = "0x6000344")]
	[Address(RVA = "0x30DFE0", Offset = "0x30CDE0", VA = "0x18030DFE0", Slot = "140")]
	public override float GetThreatLevel()
	{
		return 0f;
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000345")]
	[Address(RVA = "0x30A290", Offset = "0x309090", VA = "0x18030A290")]
	public void EnsureUpdated()
	{
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000346")]
	[Address(RVA = "0x320040", Offset = "0x31EE40", VA = "0x180320040")]
	[global::BaseEntity.RPC_Client]
	public void SetHostileLength(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000347")]
	[Address(RVA = "0x320C90", Offset = "0x31FA90", VA = "0x180320C90")]
	[global::BaseEntity.RPC_Client]
	public void SetWeaponDrawnDuration(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "149")]
	protected virtual void ModifyInputState(ref InputState inputState)
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x30ABC0", Offset = "0x3099C0", VA = "0x18030ABC0")]
	[global::BaseEntity.RPC_Client]
	private void ForcePositionToParentOffset(Vector3 position, uint entID)
	{
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x321580", Offset = "0x320380", VA = "0x180321580")]
	[global::BaseEntity.RPC_Client]
	public void UpdateClientTickRate(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x30ACF0", Offset = "0x309AF0", VA = "0x18030ACF0")]
	[global::BaseEntity.RPC_Client]
	private void ForcePositionTo(Vector3 position)
	{
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x31FA40", Offset = "0x31E840", VA = "0x18031FA40")]
	internal void SendVoiceData(byte[] data, int len)
	{
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x31F290", Offset = "0x31E090", VA = "0x18031F290")]
	internal void SendClientTick()
	{
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x3132A0", Offset = "0x3120A0", VA = "0x1803132A0")]
	public void NotifyUnderwearChange()
	{
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x323030", Offset = "0x321E30", VA = "0x180323030")]
	public static void UpdatePlayerVisibilities()
	{
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00003E70 File Offset: 0x00002070
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x321280", Offset = "0x320080", VA = "0x180321280")]
	private float TimeSinceSeen()
	{
		return 0f;
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x320630", Offset = "0x31F430", VA = "0x180320630")]
	private void SetNextVisThink(float addTime)
	{
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00003E88 File Offset: 0x00002088
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x3248A0", Offset = "0x3236A0", VA = "0x1803248A0")]
	private bool WantsVisUpdate()
	{
		return default(bool);
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00003EA0 File Offset: 0x000020A0
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x30F980", Offset = "0x30E780", VA = "0x18030F980")]
	public static bool IsAimingAt(global::BasePlayer aimer, global::BasePlayer target, float cone = 0.95f)
	{
		return default(bool);
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x321F30", Offset = "0x320D30", VA = "0x180321F30", Slot = "90")]
	protected override void UpdateCullingSpheres()
	{
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x323EE0", Offset = "0x322CE0", VA = "0x180323EE0")]
	private void VisUpdateUsingCulling(float dist, bool visibility)
	{
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x323FF0", Offset = "0x322DF0", VA = "0x180323FF0")]
	private void VisUpdateUsingRays(float dist)
	{
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x312620", Offset = "0x311420", VA = "0x180312620")]
	private void LogDebugCull(float dist)
	{
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x31B840", Offset = "0x31A640", VA = "0x18031B840", Slot = "92")]
	protected override void OnVisibilityChanged(bool visible)
	{
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000359")]
	[Address(RVA = "0x324410", Offset = "0x323210", VA = "0x180324410")]
	private void VisUpdate()
	{
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00003EB8 File Offset: 0x000020B8
	[Token(Token = "0x600035A")]
	[Address(RVA = "0x323E20", Offset = "0x322C20", VA = "0x180323E20")]
	private bool VisPlayerArmed()
	{
		return default(bool);
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00003ED0 File Offset: 0x000020D0
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x300720", Offset = "0x2FF520", VA = "0x180300720")]
	private bool AnyPartVisible()
	{
		return default(bool);
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00003EE8 File Offset: 0x000020E8
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x3020C0", Offset = "0x300EC0", VA = "0x1803020C0")]
	private float CalcVisUpdateRate(float dist)
	{
		return 0f;
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00003F00 File Offset: 0x00002100
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x31BFE0", Offset = "0x31ADE0", VA = "0x18031BFE0")]
	private bool PointSeePoint(Vector3 target, Vector3 origin, float dist = 0f, bool useGameTrace = false)
	{
		return default(bool);
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00003F18 File Offset: 0x00002118
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x311180", Offset = "0x30FF80", VA = "0x180311180")]
	public bool IsWounded()
	{
		return default(bool);
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00003F30 File Offset: 0x00002130
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x310240", Offset = "0x30F040", VA = "0x180310240")]
	public bool IsCrawling()
	{
		return default(bool);
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00003F48 File Offset: 0x00002148
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x310910", Offset = "0x30F710", VA = "0x180310910")]
	public bool IsIncapacitated()
	{
		return default(bool);
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x3212A0", Offset = "0x3200A0", VA = "0x1803212A0", Slot = "97")]
	public override global::BasePlayer ToPlayer()
	{
		return null;
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000058")]
	public Connection Connection
	{
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x325060", Offset = "0x323E60", VA = "0x180325060")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000792 RID: 1938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000059")]
	public string displayName
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x3257F0", Offset = "0x3245F0", VA = "0x1803257F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x325DD0", Offset = "0x324BD0", VA = "0x180325DD0")]
		set
		{
		}
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000365")]
	[Address(RVA = "0x31EC50", Offset = "0x31DA50", VA = "0x18031EC50")]
	public static string SanitizePlayerNameString(string playerName, ulong userId)
	{
		return null;
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00003F60 File Offset: 0x00002160
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x3106F0", Offset = "0x30F4F0", VA = "0x1803106F0")]
	public bool IsGod()
	{
		return default(bool);
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x30D7D0", Offset = "0x30C5D0", VA = "0x18030D7D0", Slot = "25")]
	public override Quaternion GetNetworkRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00003F90 File Offset: 0x00002190
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x302CE0", Offset = "0x301AE0", VA = "0x180302CE0")]
	public bool CanInteract()
	{
		return default(bool);
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00003FA8 File Offset: 0x000021A8
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x302C50", Offset = "0x301A50", VA = "0x180302C50")]
	public bool CanInteract(bool usableWhileCrawling)
	{
		return default(bool);
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00003FC0 File Offset: 0x000021C0
	[Token(Token = "0x600036A")]
	[Address(RVA = "0x3211B0", Offset = "0x31FFB0", VA = "0x1803211B0", Slot = "142")]
	public override float StartHealth()
	{
		return 0f;
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00003FD8 File Offset: 0x000021D8
	[Token(Token = "0x600036B")]
	[Address(RVA = "0x31BB70", Offset = "0x31A970", VA = "0x18031BB70", Slot = "143")]
	public override float StartMaxHealth()
	{
		return 0f;
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00003FF0 File Offset: 0x000021F0
	[Token(Token = "0x600036C")]
	[Address(RVA = "0x312B60", Offset = "0x311960", VA = "0x180312B60", Slot = "110")]
	public override float MaxHealth()
	{
		return 0f;
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00004008 File Offset: 0x00002208
	[Token(Token = "0x600036D")]
	[Address(RVA = "0x312C10", Offset = "0x311A10", VA = "0x180312C10", Slot = "111")]
	public override float MaxVelocity()
	{
		return 0f;
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00004020 File Offset: 0x00002220
	[Token(Token = "0x600036E")]
	[Address(RVA = "0x30D620", Offset = "0x30C420", VA = "0x18030D620")]
	public Vector3 GetMountVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00004038 File Offset: 0x00002238
	[Token(Token = "0x600036F")]
	[Address(RVA = "0x30BD40", Offset = "0x30AB40", VA = "0x18030BD40", Slot = "100")]
	public override Vector3 GetInheritedProjectileVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00004050 File Offset: 0x00002250
	[Token(Token = "0x6000370")]
	[Address(RVA = "0x30BE00", Offset = "0x30AC00", VA = "0x18030BE00", Slot = "101")]
	public override Vector3 GetInheritedThrowVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00004068 File Offset: 0x00002268
	[Token(Token = "0x6000371")]
	[Address(RVA = "0x30BC80", Offset = "0x30AA80", VA = "0x18030BC80", Slot = "102")]
	public override Vector3 GetInheritedDropVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000372")]
	[Address(RVA = "0x31C5E0", Offset = "0x31B3E0", VA = "0x18031C5E0", Slot = "29")]
	public override void PreInitShared()
	{
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000373")]
	[Address(RVA = "0x3095E0", Offset = "0x3083E0", VA = "0x1803095E0", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00004080 File Offset: 0x00002280
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x30EE90", Offset = "0x30DC90", VA = "0x18030EE90")]
	public bool InSafeZone()
	{
		return default(bool);
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000375")]
	[Address(RVA = "0x311190", Offset = "0x30FF90", VA = "0x180311190")]
	public static void LateClientCycle()
	{
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000376")]
	[Address(RVA = "0x3040F0", Offset = "0x302EF0", VA = "0x1803040F0")]
	public static void ClientCycle(float deltaTime)
	{
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00004098 File Offset: 0x00002298
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x30AF30", Offset = "0x309D30", VA = "0x18030AF30")]
	public Bounds GetBounds(bool ducked)
	{
		return default(Bounds);
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x000040B0 File Offset: 0x000022B0
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x30B0C0", Offset = "0x309EC0", VA = "0x18030B0C0")]
	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x000040C8 File Offset: 0x000022C8
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x30B360", Offset = "0x30A160", VA = "0x18030B360")]
	public Vector3 GetCenter(bool ducked)
	{
		return default(Vector3);
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x000040E0 File Offset: 0x000022E0
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x30B480", Offset = "0x30A280", VA = "0x18030B480")]
	public Vector3 GetCenter()
	{
		return default(Vector3);
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x000040F8 File Offset: 0x000022F8
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x30D8B0", Offset = "0x30C6B0", VA = "0x18030D8B0")]
	public Vector3 GetOffset(bool ducked)
	{
		return default(Vector3);
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x30D830", Offset = "0x30C630", VA = "0x18030D830")]
	public Vector3 GetOffset()
	{
		return default(Vector3);
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x30DE40", Offset = "0x30CC40", VA = "0x18030DE40")]
	public Vector3 GetSize(bool ducked)
	{
		return default(Vector3);
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00004140 File Offset: 0x00002340
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x30DDC0", Offset = "0x30CBC0", VA = "0x18030DDC0")]
	public Vector3 GetSize()
	{
		return default(Vector3);
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00004158 File Offset: 0x00002358
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x30BA00", Offset = "0x30A800", VA = "0x18030BA00")]
	public float GetHeight(bool ducked)
	{
		return 0f;
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00004170 File Offset: 0x00002370
	[Token(Token = "0x6000380")]
	[Address(RVA = "0x30B9C0", Offset = "0x30A7C0", VA = "0x18030B9C0")]
	public float GetHeight()
	{
		return 0f;
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00004188 File Offset: 0x00002388
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x30DD30", Offset = "0x30CB30", VA = "0x18030DD30")]
	public float GetRadius()
	{
		return 0f;
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x000041A0 File Offset: 0x000023A0
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x30C3C0", Offset = "0x30B1C0", VA = "0x18030C3C0")]
	public float GetJumpHeight()
	{
		return 0f;
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x000041B8 File Offset: 0x000023B8
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x321320", Offset = "0x320120", VA = "0x180321320", Slot = "103")]
	public override Vector3 TriggerPoint()
	{
		return default(Vector3);
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x000041D0 File Offset: 0x000023D0
	[Token(Token = "0x6000384")]
	[Address(RVA = "0x313250", Offset = "0x312050", VA = "0x180313250")]
	public Vector3 NoClipOffset()
	{
		return default(Vector3);
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x000041E8 File Offset: 0x000023E8
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x313290", Offset = "0x312090", VA = "0x180313290")]
	public float NoClipRadius(float margin)
	{
		return 0f;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00004200 File Offset: 0x00002400
	[Token(Token = "0x6000386")]
	[Address(RVA = "0x312B50", Offset = "0x311950", VA = "0x180312B50")]
	public float MaxDeployDistance(global::Item item)
	{
		return 0f;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x306650", Offset = "0x305450", VA = "0x180306650")]
	public void ClientUpdatePersistantData(PersistantPlayer data)
	{
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00004218 File Offset: 0x00002418
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x30D5F0", Offset = "0x30C3F0", VA = "0x18030D5F0")]
	public float GetMinSpeed()
	{
		return 0f;
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00004230 File Offset: 0x00002430
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x30C5A0", Offset = "0x30B3A0", VA = "0x18030C5A0")]
	public float GetMaxSpeed()
	{
		return 0f;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00004248 File Offset: 0x00002448
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x30DEA0", Offset = "0x30CCA0", VA = "0x18030DEA0")]
	public float GetSpeed(float running, float ducking, float crawling)
	{
		return 0f;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x3132E0", Offset = "0x3120E0", VA = "0x1803132E0", Slot = "115")]
	public override void OnAttacked(HitInfo info)
	{
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x309ED0", Offset = "0x308CD0", VA = "0x180309ED0")]
	private void EnablePlayerCollider()
	{
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038D")]
	[Address(RVA = "0x3097A0", Offset = "0x3085A0", VA = "0x1803097A0")]
	private void DisablePlayerCollider()
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x31E1A0", Offset = "0x31CFA0", VA = "0x18031E1A0")]
	private void RefreshColliderSize(bool forced)
	{
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x320C70", Offset = "0x31FA70", VA = "0x180320C70")]
	private void SetPlayerRigidbodyState(bool isEnabled)
	{
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x300410", Offset = "0x2FF210", VA = "0x180300410")]
	private void AddPlayerRigidbody()
	{
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000391")]
	[Address(RVA = "0x31E680", Offset = "0x31D480", VA = "0x18031E680")]
	private void RemovePlayerRigidbody()
	{
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00004260 File Offset: 0x00002460
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x310320", Offset = "0x30F120", VA = "0x180310320")]
	public bool IsEnsnared()
	{
		return default(bool);
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00004278 File Offset: 0x00002478
	[Token(Token = "0x6000393")]
	[Address(RVA = "0x30FB50", Offset = "0x30E950", VA = "0x18030FB50")]
	public bool IsAttacking()
	{
		return default(bool);
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00004290 File Offset: 0x00002490
	[Token(Token = "0x6000394")]
	[Address(RVA = "0x302690", Offset = "0x301490", VA = "0x180302690")]
	public bool CanAttack()
	{
		return default(bool);
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x000042A8 File Offset: 0x000024A8
	[Token(Token = "0x6000395")]
	[Address(RVA = "0x313B10", Offset = "0x312910", VA = "0x180313B10")]
	public bool OnLadder()
	{
		return default(bool);
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x000042C0 File Offset: 0x000024C0
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x311130", Offset = "0x30FF30", VA = "0x180311130")]
	public bool IsSwimming()
	{
		return default(bool);
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x000042D8 File Offset: 0x000024D8
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x310770", Offset = "0x30F570", VA = "0x180310770")]
	public bool IsHeadUnderwater()
	{
		return default(bool);
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x000042F0 File Offset: 0x000024F0
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x310D00", Offset = "0x30FB00", VA = "0x180310D00", Slot = "150")]
	public virtual bool IsOnGround()
	{
		return default(bool);
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00004308 File Offset: 0x00002508
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x310DC0", Offset = "0x30FBC0", VA = "0x180310DC0")]
	public bool IsRunning()
	{
		return default(bool);
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00004320 File Offset: 0x00002520
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x310260", Offset = "0x30F060", VA = "0x180310260")]
	public bool IsDucked()
	{
		return default(bool);
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00004338 File Offset: 0x00002538
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x31DFE0", Offset = "0x31CDE0", VA = "0x18031DFE0")]
	public bool RecentlyTeleported()
	{
		return default(bool);
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x320DC0", Offset = "0x31FBC0", VA = "0x180320DC0")]
	public void ShowToast(int style, Translate.Phrase phrase)
	{
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039D")]
	[Address(RVA = "0x3034D0", Offset = "0x3022D0", VA = "0x1803034D0")]
	public void ChatMessage(string msg)
	{
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x308910", Offset = "0x307710", VA = "0x180308910")]
	public void ConsoleMessage(string msg)
	{
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x00004350 File Offset: 0x00002550
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x31BB70", Offset = "0x31A970", VA = "0x18031BB70", Slot = "113")]
	public override float PenetrationResistance(HitInfo info)
	{
		return 0f;
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x31F000", Offset = "0x31DE00", VA = "0x18031F000", Slot = "141")]
	public override void ScaleDamage(HitInfo info)
	{
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x322C60", Offset = "0x321A60", VA = "0x180322C60")]
	private void UpdateMoveSpeedFromClothing()
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x323210", Offset = "0x322010", VA = "0x180323210", Slot = "151")]
	public virtual void UpdateProtectionFromClothing()
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x3034A0", Offset = "0x3022A0", VA = "0x1803034A0", Slot = "121")]
	public override string Categorize()
	{
		return null;
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x3212B0", Offset = "0x3200B0", VA = "0x1803212B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x30B5F0", Offset = "0x30A3F0", VA = "0x18030B5F0")]
	public string GetDebugStatus()
	{
		return null;
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x30C310", Offset = "0x30B110", VA = "0x18030C310", Slot = "117")]
	public override global::Item GetItem(uint itemId)
	{
		return null;
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00004368 File Offset: 0x00002568
	[Token(Token = "0x1700005A")]
	public override global::BaseEntity.TraitFlag Traits
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x325710", Offset = "0x324510", VA = "0x180325710", Slot = "86")]
		get
		{
			return global::BaseEntity.TraitFlag.None;
		}
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00004380 File Offset: 0x00002580
	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x3248C0", Offset = "0x3236C0", VA = "0x1803248C0", Slot = "106")]
	public override float WaterFactor()
	{
		return 0f;
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00004398 File Offset: 0x00002598
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x300670", Offset = "0x2FF470", VA = "0x180300670", Slot = "107")]
	public override float AirFactor()
	{
		return 0f;
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x30D900", Offset = "0x30C700", VA = "0x18030D900")]
	public float GetOxygenTime(out ItemModGiveOxygen.AirSupplyType airSupplyType)
	{
		return 0f;
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x000043C8 File Offset: 0x000025C8
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x310EA0", Offset = "0x30FCA0", VA = "0x180310EA0", Slot = "127")]
	public override bool ShouldInheritNetworkGroup()
	{
		return default(bool);
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x000043E0 File Offset: 0x000025E0
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x300D60", Offset = "0x2FFB60", VA = "0x180300D60")]
	public static bool AnyPlayersVisibleToEntity(Vector3 pos, float radius, global::BaseEntity source, Vector3 entityEyePos, bool ignorePlayersWithPriv = false)
	{
		return default(bool);
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x310EB0", Offset = "0x30FCB0", VA = "0x180310EB0")]
	public bool IsStandingOnEntity(global::BaseEntity standingOn, int layerMask)
	{
		return default(bool);
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x31FC10", Offset = "0x31EA10", VA = "0x18031FC10")]
	public void SetActiveTelephone(PhoneController t)
	{
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060007DD RID: 2013 RVA: 0x00004410 File Offset: 0x00002610
	[Token(Token = "0x1700005B")]
	public bool HasActiveTelephone
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x325130", Offset = "0x323F30", VA = "0x180325130")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060007DE RID: 2014 RVA: 0x00004428 File Offset: 0x00002628
	[Token(Token = "0x1700005C")]
	public bool IsDesigningAI
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x325600", Offset = "0x324400", VA = "0x180325600")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x303DC0", Offset = "0x302BC0", VA = "0x180303DC0")]
	public void ClearDesigningAIEntity()
	{
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x324EE0", Offset = "0x323CE0", VA = "0x180324EE0")]
	public BasePlayer()
	{
	}

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x238")]
	private Option __menuOption_Climb;

	// Token: 0x0400031A RID: 794
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x290")]
	private Option __menuOption_Drink;

	// Token: 0x0400031B RID: 795
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x2E8")]
	private Option __menuOption_InviteToTeam;

	// Token: 0x0400031C RID: 796
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x340")]
	private Option __menuOption_Menu_AssistPlayer;

	// Token: 0x0400031D RID: 797
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x398")]
	private Option __menuOption_Menu_LootPlayer;

	// Token: 0x0400031E RID: 798
	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x3F0")]
	private Option __menuOption_Promote;

	// Token: 0x0400031F RID: 799
	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x448")]
	private Option __menuOption_SaltWater;

	// Token: 0x04000320 RID: 800
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x0")]
	[ClientVar]
	public static string lootPanelOverride;

	// Token: 0x04000321 RID: 801
	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x4A0")]
	[NonSerialized]
	public global::BasePlayer.CameraMode currentViewMode;

	// Token: 0x04000322 RID: 802
	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x4A4")]
	[NonSerialized]
	public global::BasePlayer.CameraMode selectedViewMode;

	// Token: 0x04000323 RID: 803
	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x4A8")]
	private Vector3 lastRevivePoint;

	// Token: 0x04000324 RID: 804
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x4B4")]
	private Vector3 lastReviveDirection;

	// Token: 0x04000325 RID: 805
	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x4C0")]
	[NonSerialized]
	public PlayerModel playerModel;

	// Token: 0x04000326 RID: 806
	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x4C8")]
	[NonSerialized]
	public bool Frozen;

	// Token: 0x04000327 RID: 807
	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x4D0")]
	[NonSerialized]
	public PlayerVoiceRecorder voiceRecorder;

	// Token: 0x04000328 RID: 808
	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x4D8")]
	[NonSerialized]
	public PlayerVoiceSpeaker voiceSpeaker;

	// Token: 0x04000329 RID: 809
	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x4E0")]
	[NonSerialized]
	public PlayerInput input;

	// Token: 0x0400032A RID: 810
	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x4E8")]
	[NonSerialized]
	public BaseMovement movement;

	// Token: 0x0400032B RID: 811
	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x4F0")]
	[NonSerialized]
	public BaseCollision collision;

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x8")]
	private static InputState emptyState;

	// Token: 0x0400032D RID: 813
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x4F8")]
	private GameObject _lookingAt;

	// Token: 0x0400032E RID: 814
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x500")]
	private global::BaseEntity _lookingAtEntity;

	// Token: 0x0400032F RID: 815
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x508")]
	private Collider _lookingAtCollider;

	// Token: 0x04000330 RID: 816
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x510")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private Vector3 <lookingAtPoint>k__BackingField;

	// Token: 0x04000331 RID: 817
	[Token(Token = "0x40002A5")]
	private const string playerModelPrefab = "assets/prefabs/player/player_model.prefab";

	// Token: 0x04000332 RID: 818
	[Token(Token = "0x40002A6")]
	private const string playerCollisionPrefab = "assets/prefabs/player/player_collision.prefab";

	// Token: 0x04000333 RID: 819
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x51C")]
	private float wakeTime;

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x520")]
	private bool needsClothesRebuild;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x521")]
	private bool wasSleeping;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x522")]
	private bool wokeUpBefore;

	// Token: 0x04000337 RID: 823
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x523")]
	private bool wasDead;

	// Token: 0x04000338 RID: 824
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x524")]
	private uint lastClothesHash;

	// Token: 0x04000339 RID: 825
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x10")]
	private static ListDictionary<ulong, global::BasePlayer> visiblePlayerList;

	// Token: 0x0400033A RID: 826
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x18")]
	public static int craftMode;

	// Token: 0x0400033B RID: 827
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x528")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <IsWearingDiveGoggles>k__BackingField;

	// Token: 0x0400033C RID: 828
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x530")]
	public ViewModel GestureViewModel;

	// Token: 0x0400033D RID: 829
	[Token(Token = "0x40002B1")]
	public const float INTERACTION_TICK_RATE = 0.1f;

	// Token: 0x0400033E RID: 830
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x538")]
	private RealTimeSince timeSinceUpdatedLookingAt;

	// Token: 0x0400033F RID: 831
	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x53C")]
	private float nextTopologyTestTime;

	// Token: 0x04000340 RID: 832
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x540")]
	private float usePressTime;

	// Token: 0x04000341 RID: 833
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x544")]
	private float useHeldTime;

	// Token: 0x04000342 RID: 834
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x548")]
	private HitTest lookingAtTest;

	// Token: 0x04000343 RID: 835
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x1C")]
	public static float lastDeathTimeClient;

	// Token: 0x04000344 RID: 836
	[Token(Token = "0x40002B8")]
	private const float drinkRange = 1.5f;

	// Token: 0x04000345 RID: 837
	[Token(Token = "0x40002B9")]
	private const float drinkMovementSpeed = 0.1f;

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x550")]
	private Vector3 cachedWaterDrinkingPoint;

	// Token: 0x04000347 RID: 839
	[Token(Token = "0x40002BB")]
	public const string GestureCancelString = "cancel";

	// Token: 0x04000348 RID: 840
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x560")]
	public GestureCollection gestureList;

	// Token: 0x04000349 RID: 841
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x568")]
	private TimeUntil gestureFinishedTime;

	// Token: 0x0400034A RID: 842
	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x56C")]
	private TimeSince blockHeldInputTimer;

	// Token: 0x0400034B RID: 843
	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x570")]
	private GestureConfig currentGesture;

	// Token: 0x0400034C RID: 844
	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x578")]
	private BaseViewModel preGestureVm;

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x580")]
	private global::HeldEntity disabledHeldEntity;

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x588")]
	private float nextGestureMenuOpenTime;

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x58C")]
	private TimeSince lastGestureCancel;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x590")]
	public float client_lastHelloTime;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x598")]
	public ulong currentTeam;

	// Token: 0x04000352 RID: 850
	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x20")]
	public static readonly Translate.Phrase MaxTeamSizeToast;

	// Token: 0x04000353 RID: 851
	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x5A0")]
	[NonSerialized]
	public PlayerTeam clientTeam;

	// Token: 0x04000354 RID: 852
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x5A8")]
	private float lastReceivedTeamTime;

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x5B0")]
	private ulong lastPresenceTeamId;

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x5B8")]
	private int lastPresenceTeamSize;

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x5C0")]
	private string playerGroupKey;

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x5C8")]
	private string playerGroupSizeKey;

	// Token: 0x04000359 RID: 857
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x5D0")]
	private uint clActiveItem;

	// Token: 0x0400035A RID: 858
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x5D8")]
	public MapNote ClientCurrentMapNote;

	// Token: 0x0400035B RID: 859
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x5E0")]
	public MapNote ClientCurrentDeathNote;

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x5E8")]
	public List<BaseMission.MissionInstance> missions;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x5F0")]
	private int _activeMission;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x5F8")]
	[NonSerialized]
	public ModelState modelState;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x600")]
	[NonSerialized]
	private EntityRef mounted;

	// Token: 0x04000360 RID: 864
	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x610")]
	private float nextSeatSwapTime;

	// Token: 0x04000361 RID: 865
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x618")]
	public global::BaseEntity PetEntity;

	// Token: 0x04000362 RID: 866
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x620")]
	private float lastPetCommandIssuedTime;

	// Token: 0x04000363 RID: 867
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x624")]
	public uint PetPrefabID;

	// Token: 0x04000364 RID: 868
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x628")]
	public uint PetID;

	// Token: 0x04000365 RID: 869
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x28")]
	public static bool PetWheelHasBeenOpened;

	// Token: 0x04000366 RID: 870
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x62C")]
	private float cachedBuildingPrivilegeTime;

	// Token: 0x04000367 RID: 871
	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x630")]
	private BuildingPrivlidge cachedBuildingPrivilege;

	// Token: 0x04000368 RID: 872
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x638")]
	private int maxProjectileID;

	// Token: 0x04000369 RID: 873
	[Token(Token = "0x40002DD")]
	private const int WILDERNESS = 1;

	// Token: 0x0400036A RID: 874
	[Token(Token = "0x40002DE")]
	private const int MONUMENT = 2;

	// Token: 0x0400036B RID: 875
	[Token(Token = "0x40002DF")]
	private const int BASE = 4;

	// Token: 0x0400036C RID: 876
	[Token(Token = "0x40002E0")]
	private const int FLYING = 8;

	// Token: 0x0400036D RID: 877
	[Token(Token = "0x40002E1")]
	private const int BOATING = 16;

	// Token: 0x0400036E RID: 878
	[Token(Token = "0x40002E2")]
	private const int SWIMMING = 32;

	// Token: 0x0400036F RID: 879
	[Token(Token = "0x40002E3")]
	private const int DRIVING = 64;

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x63C")]
	private float lastUpdateTime;

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x640")]
	private float cachedThreatLevel;

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x40002E6")]
	public const int serverTickRateDefault = 16;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x40002E7")]
	public const int clientTickRateDefault = 20;

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x644")]
	public int serverTickRate;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x648")]
	public int clientTickRate;

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x64C")]
	public float serverTickInterval;

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x650")]
	public float clientTickInterval;

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x654")]
	private float lastSentTickTime;

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x658")]
	private PlayerTick lastSentTick;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x660")]
	private float nextVisThink;

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x664")]
	private float lastTimeSeen;

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x668")]
	private bool debugPrevVisible;

	// Token: 0x0400037D RID: 893
	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x670")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xAA3B0", Offset = "0xA97B0")]
	public GameObjectRef fallDamageEffect;

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x678")]
	public GameObjectRef drownEffect;

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x680")]
	[InspectorFlags]
	public global::BasePlayer.PlayerFlags playerFlags;

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x688")]
	[NonSerialized]
	public PlayerEyes eyes;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x690")]
	[NonSerialized]
	public global::PlayerInventory inventory;

	// Token: 0x04000382 RID: 898
	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x698")]
	[NonSerialized]
	public PlayerBlueprints blueprints;

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x6A0")]
	[NonSerialized]
	public global::PlayerMetabolism metabolism;

	// Token: 0x04000384 RID: 900
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x6A8")]
	[NonSerialized]
	public global::PlayerModifiers modifiers;

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x6B0")]
	private CapsuleCollider playerCollider;

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x6B8")]
	public PlayerBelt Belt;

	// Token: 0x04000387 RID: 903
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x6C0")]
	private Rigidbody playerRigidbody;

	// Token: 0x04000388 RID: 904
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x6C8")]
	[NonSerialized]
	public ulong userID;

	// Token: 0x04000389 RID: 905
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x6D0")]
	[NonSerialized]
	public string UserIDString;

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x6D8")]
	[NonSerialized]
	public int gamemodeteam;

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x6DC")]
	[NonSerialized]
	public int reputation;

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x6E0")]
	protected string _displayName;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x6E8")]
	private string _lastSetName;

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x4000302")]
	public const float crouchSpeed = 1.7f;

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x4000303")]
	public const float walkSpeed = 2.8f;

	// Token: 0x04000390 RID: 912
	[Token(Token = "0x4000304")]
	public const float runSpeed = 5.5f;

	// Token: 0x04000391 RID: 913
	[Token(Token = "0x4000305")]
	public const float crawlSpeed = 0.72f;

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x6F0")]
	private global::BasePlayer.CapsuleColliderInfo playerColliderStanding;

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x704")]
	private global::BasePlayer.CapsuleColliderInfo playerColliderDucked;

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x718")]
	private global::BasePlayer.CapsuleColliderInfo playerColliderCrawling;

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x72C")]
	private global::BasePlayer.CapsuleColliderInfo playerColliderLyingDown;

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x740")]
	private ProtectionProperties cachedProtection;

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x29")]
	public static bool oldCameraFix;

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x748")]
	private float lastHeadshotSoundTime;

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x74C")]
	private float nextColliderRefreshTime;

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x750")]
	public bool clothingBlocksAiming;

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x754")]
	public float clothingMoveSpeedReduction;

	// Token: 0x0400039C RID: 924
	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x758")]
	public float clothingWaterSpeedBonus;

	// Token: 0x0400039D RID: 925
	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x75C")]
	public float clothingAccuracyBonus;

	// Token: 0x0400039E RID: 926
	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x760")]
	public bool equippingBlocked;

	// Token: 0x0400039F RID: 927
	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x764")]
	public float eggVision;

	// Token: 0x040003A0 RID: 928
	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x768")]
	private PhoneController activeTelephone;

	// Token: 0x040003A1 RID: 929
	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x770")]
	public global::BaseEntity designingAIEntity;

	// Token: 0x0200005F RID: 95
	[Token(Token = "0x2000A62")]
	public enum CameraMode
	{
		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x4003DD2")]
		FirstPerson,
		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x4003DD3")]
		ThirdPerson,
		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x4003DD4")]
		Eyes,
		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x4003DD5")]
		FirstPersonWithArms,
		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x4003DD6")]
		Last = 3
	}

	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000A63")]
	[Flags]
	public enum PlayerFlags
	{
		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x4003DD8")]
		Unused1 = 1,
		// Token: 0x040003AA RID: 938
		[Token(Token = "0x4003DD9")]
		Unused2 = 2,
		// Token: 0x040003AB RID: 939
		[Token(Token = "0x4003DDA")]
		IsAdmin = 4,
		// Token: 0x040003AC RID: 940
		[Token(Token = "0x4003DDB")]
		ReceivingSnapshot = 8,
		// Token: 0x040003AD RID: 941
		[Token(Token = "0x4003DDC")]
		Sleeping = 16,
		// Token: 0x040003AE RID: 942
		[Token(Token = "0x4003DDD")]
		Spectating = 32,
		// Token: 0x040003AF RID: 943
		[Token(Token = "0x4003DDE")]
		Wounded = 64,
		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x4003DDF")]
		IsDeveloper = 128,
		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x4003DE0")]
		Connected = 256,
		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x4003DE1")]
		ThirdPersonViewmode = 1024,
		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x4003DE2")]
		EyesViewmode = 2048,
		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x4003DE3")]
		ChatMute = 4096,
		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x4003DE4")]
		NoSprint = 8192,
		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x4003DE5")]
		Aiming = 16384,
		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x4003DE6")]
		DisplaySash = 32768,
		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x4003DE7")]
		Relaxed = 65536,
		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x4003DE8")]
		SafeZone = 131072,
		// Token: 0x040003BA RID: 954
		[Token(Token = "0x4003DE9")]
		ServerFall = 262144,
		// Token: 0x040003BB RID: 955
		[Token(Token = "0x4003DEA")]
		Incapacitated = 524288,
		// Token: 0x040003BC RID: 956
		[Token(Token = "0x4003DEB")]
		Workbench1 = 1048576,
		// Token: 0x040003BD RID: 957
		[Token(Token = "0x4003DEC")]
		Workbench2 = 2097152,
		// Token: 0x040003BE RID: 958
		[Token(Token = "0x4003DED")]
		Workbench3 = 4194304
	}

	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000A64")]
	public enum MapNoteType
	{
		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x4003DEF")]
		Death,
		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x4003DF0")]
		PointOfInterest
	}

	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000A65")]
	public enum TimeCategory
	{
		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x4003DF2")]
		Wilderness = 1,
		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x4003DF3")]
		Monument,
		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x4003DF4")]
		Base = 4,
		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x4003DF5")]
		Flying = 8,
		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x4003DF6")]
		Boating = 16,
		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x4003DF7")]
		Swimming = 32,
		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x4003DF8")]
		Driving = 64
	}

	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000A66")]
	[Serializable]
	public struct CapsuleColliderInfo
	{
		// Token: 0x060007E2 RID: 2018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0xF5C50", Offset = "0xF5050", VA = "0x1800F5C50")]
		public CapsuleColliderInfo(float height, float radius, Vector3 center)
		{
		}

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x4003DF9")]
		[FieldOffset(Offset = "0x0")]
		public float height;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x4003DFA")]
		[FieldOffset(Offset = "0x4")]
		public float radius;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x4003DFB")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 center;
	}

	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000A67")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x9AE5C0", Offset = "0x9AD3C0", VA = "0x1809AE5C0")]
		internal ulong <OnBecameRagdoll>b__101_0(PlayerTeam.TeamMember m)
		{
			return 0UL;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x556080", Offset = "0x554E80", VA = "0x180556080")]
		internal int <UpdateLookingAt>b__142_0(TraceInfo a, TraceInfo b)
		{
			return 0;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x9AE5E0", Offset = "0x9AD3E0", VA = "0x1809AE5E0")]
		internal bool <OnRespawnInformation>b__149_0(RespawnInformation.SpawnOptions p)
		{
			return default(bool);
		}

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x4003DFC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly global::BasePlayer.<>c <>9;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x4003DFD")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PlayerTeam.TeamMember, ulong> <>9__101_0;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x4003DFE")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<TraceInfo> <>9__142_0;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x4003DFF")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<RespawnInformation.SpawnOptions> <>9__149_0;
	}

	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000A68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <FinishedLoadingRoutine>d__154 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060007E8 RID: 2024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <FinishedLoadingRoutine>d__154(int <>1__state)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC8")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x6004BC9")]
		[Address(RVA = "0x9ADD90", Offset = "0x9ACB90", VA = "0x1809ADD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F1")]
		private object Current
		{
			[Token(Token = "0x6004BCA")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCB")]
		[Address(RVA = "0x9AE260", Offset = "0x9AD060", VA = "0x1809AE260", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F2")]
		private object Current
		{
			[Token(Token = "0x6004BCC")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x4003E00")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x4003E01")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x4003E02")]
		[FieldOffset(Offset = "0x20")]
		public global::BasePlayer <>4__this;
	}

	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000A69")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass204_0
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCD")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass204_0()
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCE")]
		[Address(RVA = "0x9AE690", Offset = "0x9AD490", VA = "0x1809AE690")]
		internal void <SetGestureMenuOpen>b__0(global::BasePlayer ply)
		{
		}

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x4003E03")]
		[FieldOffset(Offset = "0x10")]
		public GestureConfig g;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x4003E04")]
		[FieldOffset(Offset = "0x18")]
		public global::BasePlayer <>4__this;
	}

	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000A6A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass298_0
	{
		// Token: 0x060007F0 RID: 2032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCF")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass298_0()
		{
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x9AE6C0", Offset = "0x9AD4C0", VA = "0x1809AE6C0")]
		internal bool <CLIENT_SetPetPetLoadedStateIndex>b__0(PetCommandList.PetCommandDesc c)
		{
			return default(bool);
		}

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x4003E05")]
		[FieldOffset(Offset = "0x10")]
		public uint index;
	}

	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000A6B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass300_0
	{
		// Token: 0x060007F2 RID: 2034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass300_0()
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x9AE6E0", Offset = "0x9AD4E0", VA = "0x1809AE6E0")]
		internal void <SetPetMenuOpen>b__0(global::BasePlayer ply)
		{
		}

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x4003E06")]
		[FieldOffset(Offset = "0x10")]
		public PetCommandList.PetCommandDesc desc;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x4003E07")]
		[FieldOffset(Offset = "0x40")]
		public global::BasePlayer <>4__this;
	}
}
