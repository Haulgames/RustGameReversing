using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000069 RID: 105
[Token(Token = "0x200003F")]
public class BaseRidableAnimal : BaseVehicle
{
	// Token: 0x060007F4 RID: 2036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x99C5B0", Offset = "0x99B3B0", VA = "0x18099C5B0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000044B8 File Offset: 0x000026B8
	[Token(Token = "0x1700005D")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x99ECF0", Offset = "0x99DAF0", VA = "0x18099ECF0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x000044D0 File Offset: 0x000026D0
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x99DBF0", Offset = "0x99C9F0", VA = "0x18099DBF0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x000044E8 File Offset: 0x000026E8
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x61EB70", Offset = "0x61D970", VA = "0x18061EB70")]
	public bool IsForSale()
	{
		return default(bool);
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x00004500 File Offset: 0x00002700
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x99C0E0", Offset = "0x99AEE0", VA = "0x18099C0E0", Slot = "190")]
	public virtual bool CanOpenStorage(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x99D480", Offset = "0x99C280", VA = "0x18099D480")]
	public void LoadContainer(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x99D9B0", Offset = "0x99C7B0", VA = "0x18099D9B0")]
	[Attribute(Name = "Menu", RVA = "0xB1410", Offset = "0xB0810")]
	[Attribute(Name = "Description", RVA = "0xB1410", Offset = "0xB0810")]
	[Attribute(Name = "Icon", RVA = "0xB1410", Offset = "0xB0810")]
	[Attribute(Name = "ShowIf", RVA = "0xB1410", Offset = "0xB0810")]
	public void Menu_Open(BasePlayer player)
	{
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x00004518 File Offset: 0x00002718
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x99D890", Offset = "0x99C690", VA = "0x18099D890")]
	public bool Menu_Open_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x00004530 File Offset: 0x00002730
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x99E5E0", Offset = "0x99D3E0", VA = "0x18099E5E0", Slot = "191")]
	public virtual bool ShouldShowLootMenus()
	{
		return default(bool);
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00004548 File Offset: 0x00002748
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x99C570", Offset = "0x99B370", VA = "0x18099C570")]
	public float GetBreathingDelay()
	{
		return 0f;
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00004560 File Offset: 0x00002760
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x859C20", Offset = "0x858A20", VA = "0x180859C20")]
	public bool IsLeading()
	{
		return default(bool);
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00004578 File Offset: 0x00002778
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x99E730", Offset = "0x99D530", VA = "0x18099E730")]
	public static float UnitsToKPH(float unitsPerSecond)
	{
		return 0f;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000800 RID: 2048 RVA: 0x00004590 File Offset: 0x00002790
	[Token(Token = "0x1700005E")]
	public override bool IsNpc
	{
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "98")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x99D570", Offset = "0x99C370", VA = "0x18099D570", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x99E750", Offset = "0x99D550", VA = "0x18099E750")]
	public void UpdateBreathingRate()
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x99E470", Offset = "0x99D270", VA = "0x18099E470", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x99E670", Offset = "0x99D470", VA = "0x18099E670")]
	public void SprintSoundPlay()
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x99E6A0", Offset = "0x99D4A0", VA = "0x18099E6A0")]
	[BaseEntity.RPC_Client]
	public void Stand(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x99C4F0", Offset = "0x99B2F0", VA = "0x18099C4F0")]
	[BaseEntity.RPC_Client]
	public void Eat(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x000045A8 File Offset: 0x000027A8
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x99C3B0", Offset = "0x99B1B0", VA = "0x18099C3B0", Slot = "130")]
	public override bool DisplayHealthInfo(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	[Attribute(Name = "Menu", RVA = "0xB1850", Offset = "0xB0C50")]
	[Attribute(Name = "Description", RVA = "0xB1850", Offset = "0xB0C50")]
	[Attribute(Name = "Icon", RVA = "0xB1850", Offset = "0xB0C50")]
	[Attribute(Name = "ShowIf", RVA = "0xB1850", Offset = "0xB0C50")]
	public void Menu_TooHeavy(BasePlayer player)
	{
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x000045C0 File Offset: 0x000027C0
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x99D450", Offset = "0x99C250", VA = "0x18099D450")]
	public bool Menu_TooHeavy_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x99DAC0", Offset = "0x99C8C0", VA = "0x18099DAC0")]
	[Attribute(Name = "Menu", RVA = "0xB1C10", Offset = "0xB1010")]
	[Attribute(Name = "Description", RVA = "0xB1C10", Offset = "0xB1010")]
	[Attribute(Name = "Icon", RVA = "0xB1C10", Offset = "0xB1010")]
	[Attribute(Name = "ShowIf", RVA = "0xB1C10", Offset = "0xB1010")]
	public void Menu_Ride(BasePlayer player)
	{
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x000045D8 File Offset: 0x000027D8
	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x99D9F0", Offset = "0x99C7F0", VA = "0x18099D9F0")]
	public bool Menu_Ride_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x000045F0 File Offset: 0x000027F0
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x99C140", Offset = "0x99AF40", VA = "0x18099C140")]
	private bool CanPlayerSeeSaddlePoint(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x99D840", Offset = "0x99C640", VA = "0x18099D840")]
	[Attribute(Name = "Menu", RVA = "0xB1EA0", Offset = "0xB12A0")]
	[Attribute(Name = "Description", RVA = "0xB1EA0", Offset = "0xB12A0")]
	[Attribute(Name = "Icon", RVA = "0xB1EA0", Offset = "0xB12A0")]
	[Attribute(Name = "ShowIf", RVA = "0xB1EA0", Offset = "0xB12A0")]
	public void Menu_Lead(BasePlayer player)
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00004608 File Offset: 0x00002808
	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x99D7A0", Offset = "0x99C5A0", VA = "0x18099D7A0")]
	public bool Menu_Lead_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x99DBA0", Offset = "0x99C9A0", VA = "0x18099DBA0")]
	[Attribute(Name = "Menu", RVA = "0xB2050", Offset = "0xB1450")]
	[Attribute(Name = "Description", RVA = "0xB2050", Offset = "0xB1450")]
	[Attribute(Name = "Icon", RVA = "0xB2050", Offset = "0xB1450")]
	[Attribute(Name = "ShowIf", RVA = "0xB2050", Offset = "0xB1450")]
	public void Menu_StopLead(BasePlayer player)
	{
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00004620 File Offset: 0x00002820
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x99DB00", Offset = "0x99C900", VA = "0x18099DB00")]
	public bool Menu_StopLead_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00004638 File Offset: 0x00002838
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "192")]
	public virtual bool RideMenuVisible()
	{
		return default(bool);
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x00004650 File Offset: 0x00002850
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "181")]
	public override bool MountMenuVisible(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x99D760", Offset = "0x99C560", VA = "0x18099D760")]
	[Attribute(Name = "Menu", RVA = "0xB2390", Offset = "0xB1790")]
	[Attribute(Name = "Description", RVA = "0xB2390", Offset = "0xB1790")]
	[Attribute(Name = "Icon", RVA = "0xB2390", Offset = "0xB1790")]
	[Attribute(Name = "ShowIf", RVA = "0xB2390", Offset = "0xB1790")]
	public void Menu_Claim(BasePlayer player)
	{
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x00004668 File Offset: 0x00002868
	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x99D680", Offset = "0x99C480", VA = "0x18099D680")]
	public bool Menu_Claim_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00004680 File Offset: 0x00002880
	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x99E430", Offset = "0x99D230", VA = "0x18099E430")]
	public bool PlayerHasToken(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x99D3E0", Offset = "0x99C1E0", VA = "0x18099D3E0")]
	public Item GetPurchaseToken(BasePlayer player)
	{
		return null;
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x00004698 File Offset: 0x00002898
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x99D440", Offset = "0x99C240", VA = "0x18099D440", Slot = "193")]
	public virtual float GetWalkSpeed()
	{
		return 0f;
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x000046B0 File Offset: 0x000028B0
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x99D430", Offset = "0x99C230", VA = "0x18099D430", Slot = "194")]
	public virtual float GetTrotSpeed()
	{
		return 0f;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x000046C8 File Offset: 0x000028C8
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x99D420", Offset = "0x99C220", VA = "0x18099D420", Slot = "195")]
	public virtual float GetRunSpeed()
	{
		return 0f;
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x000046E0 File Offset: 0x000028E0
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x99D450", Offset = "0x99C250", VA = "0x18099D450")]
	public bool IsPlayerTooHeavy(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x99E900", Offset = "0x99D700", VA = "0x18099E900")]
	public BaseRidableAnimal()
	{
	}

	// Token: 0x040003D9 RID: 985
	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x3A8")]
	private Option __menuOption_Menu_Claim;

	// Token: 0x040003DA RID: 986
	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x400")]
	private Option __menuOption_Menu_Lead;

	// Token: 0x040003DB RID: 987
	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x458")]
	private Option __menuOption_Menu_Open;

	// Token: 0x040003DC RID: 988
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x4B0")]
	private Option __menuOption_Menu_Ride;

	// Token: 0x040003DD RID: 989
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x508")]
	private Option __menuOption_Menu_StopLead;

	// Token: 0x040003DE RID: 990
	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x560")]
	private Option __menuOption_Menu_TooHeavy;

	// Token: 0x040003DF RID: 991
	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x5B8")]
	public ItemDefinition onlyAllowedItem;

	// Token: 0x040003E0 RID: 992
	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x5C0")]
	public ItemContainer.ContentsType allowedContents;

	// Token: 0x040003E1 RID: 993
	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x5C4")]
	public int maxStackSize;

	// Token: 0x040003E2 RID: 994
	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x5C8")]
	public int numSlots;

	// Token: 0x040003E3 RID: 995
	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x5D0")]
	public string lootPanelName;

	// Token: 0x040003E4 RID: 996
	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x5D8")]
	public bool needsBuildingPrivilegeToUse;

	// Token: 0x040003E5 RID: 997
	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x5D9")]
	public bool isLootable;

	// Token: 0x040003E6 RID: 998
	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x5E0")]
	protected ItemContainer inventory;

	// Token: 0x040003E7 RID: 999
	[Token(Token = "0x4000324")]
	public const BaseEntity.Flags Flag_ForSale = BaseEntity.Flags.Reserved2;

	// Token: 0x040003E8 RID: 1000
	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x5E8")]
	private Vector3 lastMoveDirection;

	// Token: 0x040003E9 RID: 1001
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x5F8")]
	public GameObjectRef saddlePrefab;

	// Token: 0x040003EA RID: 1002
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x600")]
	public EntityRef saddleRef;

	// Token: 0x040003EB RID: 1003
	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x610")]
	public Transform movementLOSOrigin;

	// Token: 0x040003EC RID: 1004
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x618")]
	public SoundPlayer sprintSounds;

	// Token: 0x040003ED RID: 1005
	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x620")]
	public SoundPlayer largeWhinny;

	// Token: 0x040003EE RID: 1006
	[Token(Token = "0x400032B")]
	public const BaseEntity.Flags Flag_Lead = BaseEntity.Flags.Reserved7;

	// Token: 0x040003EF RID: 1007
	[Token(Token = "0x400032C")]
	public const BaseEntity.Flags Flag_HasRider = BaseEntity.Flags.On;

	// Token: 0x040003F0 RID: 1008
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x628")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB0CE0", Offset = "0xB00E0")]
	public ItemDefinition purchaseToken;

	// Token: 0x040003F1 RID: 1009
	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x630")]
	public GameObjectRef eatEffect;

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x638")]
	public GameObjectRef CorpsePrefab;

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x640")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB0E00", Offset = "0xB0200")]
	public Transform animalFront;

	// Token: 0x040003F4 RID: 1012
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x648")]
	public float obstacleDetectionRadius;

	// Token: 0x040003F5 RID: 1013
	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x64C")]
	public float maxWaterDepth;

	// Token: 0x040003F6 RID: 1014
	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x650")]
	public float roadSpeedBonus;

	// Token: 0x040003F7 RID: 1015
	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x654")]
	public float maxWallClimbSlope;

	// Token: 0x040003F8 RID: 1016
	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x658")]
	public float maxStepHeight;

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x65C")]
	public float maxStepDownHeight;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x660")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB0E60", Offset = "0xB0260")]
	public BaseRidableAnimal.RunState currentRunState;

	// Token: 0x040003FB RID: 1019
	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x664")]
	public float walkSpeed;

	// Token: 0x040003FC RID: 1020
	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x668")]
	public float trotSpeed;

	// Token: 0x040003FD RID: 1021
	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x66C")]
	public float runSpeed;

	// Token: 0x040003FE RID: 1022
	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x670")]
	public float turnSpeed;

	// Token: 0x040003FF RID: 1023
	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x674")]
	public float maxSpeed;

	// Token: 0x04000400 RID: 1024
	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x678")]
	public Transform[] groundSampleOffsets;

	// Token: 0x04000401 RID: 1025
	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x680")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB1110", Offset = "0xB0510")]
	public float staminaSeconds;

	// Token: 0x04000402 RID: 1026
	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x684")]
	public float currentMaxStaminaSeconds;

	// Token: 0x04000403 RID: 1027
	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x688")]
	public float maxStaminaSeconds;

	// Token: 0x04000404 RID: 1028
	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x68C")]
	public float staminaCoreLossRatio;

	// Token: 0x04000405 RID: 1029
	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x690")]
	public float staminaCoreSpeedBonus;

	// Token: 0x04000406 RID: 1030
	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x694")]
	public float staminaReplenishRatioMoving;

	// Token: 0x04000407 RID: 1031
	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x698")]
	public float staminaReplenishRatioStanding;

	// Token: 0x04000408 RID: 1032
	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x69C")]
	public float calorieToStaminaRatio;

	// Token: 0x04000409 RID: 1033
	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x6A0")]
	public float hydrationToStaminaRatio;

	// Token: 0x0400040A RID: 1034
	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x6A4")]
	public float maxStaminaCoreFromWater;

	// Token: 0x0400040B RID: 1035
	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x6A8")]
	public bool debugMovement;

	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x4000349")]
	private const float normalOffsetDist = 0.15f;

	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0x6B0")]
	private Vector3[] normalOffsets;

	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0x0")]
	[ServerVar]
	public static float decayminutes;

	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0x6B8")]
	public float currentSpeed;

	// Token: 0x04000410 RID: 1040
	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x6BC")]
	public float desiredRotation;

	// Token: 0x04000411 RID: 1041
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x6C0")]
	public float animalPitchClamp;

	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x6C4")]
	public float animalRollClamp;

	// Token: 0x04000413 RID: 1043
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x6C8")]
	private float lastBreathingRate;

	// Token: 0x04000414 RID: 1044
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x6CC")]
	private float nextTokenCheckTime;

	// Token: 0x04000415 RID: 1045
	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x6D0")]
	private bool lastTokenCheckResult;

	// Token: 0x0200006A RID: 106
	[Token(Token = "0x2000A6C")]
	public enum RunState
	{
		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4003E09")]
		stopped = 1,
		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4003E0A")]
		walk,
		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4003E0B")]
		run,
		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x4003E0C")]
		sprint,
		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x4003E0D")]
		LAST
	}
}
