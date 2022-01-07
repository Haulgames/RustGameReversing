using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using Rust;
using Sonar;
using UnityEngine;
using VLB;

// Token: 0x0200006B RID: 107
[Token(Token = "0x2000040")]
public class BaseSubmarine : global::BaseVehicle, IEngineControllerUser, IEntity, IAirSupply
{
	// Token: 0x0600081D RID: 2077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x9A1350", Offset = "0x9A0150", VA = "0x1809A1350", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600081E RID: 2078 RVA: 0x000046F8 File Offset: 0x000028F8
	[Token(Token = "0x1700005F")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x9A4E50", Offset = "0x9A3C50", VA = "0x1809A4E50", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00004710 File Offset: 0x00002910
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x9A2A40", Offset = "0x9A1840", VA = "0x1809A2A40", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000820 RID: 2080 RVA: 0x00004728 File Offset: 0x00002928
	// (set) Token: 0x06000821 RID: 2081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000060")]
	public float PropPercentVelocity
	{
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x9A5130", Offset = "0x9A3F30", VA = "0x1809A5130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x9A5260", Offset = "0x9A4060", VA = "0x1809A5260")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x9A10D0", Offset = "0x99FED0", VA = "0x1809A10D0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x9A0F70", Offset = "0x99FD70", VA = "0x1809A0F70")]
	private void ClientFlagsChanged(global::BaseEntity.Flags old, global::BaseEntity.Flags next)
	{
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00004740 File Offset: 0x00002940
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x9A11E0", Offset = "0x99FFE0", VA = "0x1809A11E0", Slot = "130")]
	public override bool DisplayHealthInfo(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00004758 File Offset: 0x00002958
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x9A2780", Offset = "0x9A1580", VA = "0x1809A2780", Slot = "181")]
	public override bool MountMenuVisible(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x9A3910", Offset = "0x9A2710", VA = "0x1809A3910")]
	private void StartClientTick()
	{
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x9A39A0", Offset = "0x9A27A0", VA = "0x1809A39A0")]
	private void StopClientTick()
	{
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x9A3A80", Offset = "0x9A2880", VA = "0x1809A3A80")]
	protected void SubmarineClientTick()
	{
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x9A3890", Offset = "0x9A2690", VA = "0x1809A3890", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00004770 File Offset: 0x00002970
	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x9A4610", Offset = "0x9A3410", VA = "0x1809A4610", Slot = "193")]
	protected virtual bool UpdateInteriorVisuals(bool playerIsInside, float speed)
	{
		return default(bool);
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00004788 File Offset: 0x00002988
	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x9A3F90", Offset = "0x9A2D90", VA = "0x1809A3F90", Slot = "194")]
	protected virtual bool UpdateExteriorVisuals(bool playerIsInside, float speed)
	{
		return default(bool);
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x9A0D10", Offset = "0x99FB10", VA = "0x1809A0D10")]
	private void AmbientLoopBubbles(ParticleSystem particleSystem)
	{
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x9A21A0", Offset = "0x9A0FA0", VA = "0x1809A21A0")]
	private void InitialDiveBubbles(ParticleSystem particleSystem)
	{
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x9A3F60", Offset = "0x9A2D60", VA = "0x1809A3F60", Slot = "195")]
	protected virtual void TorpedoFired()
	{
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x9A24C0", Offset = "0x9A12C0", VA = "0x1809A24C0")]
	[Attribute(Name = "Menu", RVA = "0x7B3C0", Offset = "0x7A7C0")]
	[Attribute(Name = "Description", RVA = "0x7B3C0", Offset = "0x7A7C0")]
	[Attribute(Name = "Icon", RVA = "0x7B3C0", Offset = "0x7A7C0")]
	[Attribute(Name = "ShowIf", RVA = "0x7B3C0", Offset = "0x7A7C0")]
	public void Menu_FuelStorage(global::BasePlayer player)
	{
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x000047A0 File Offset: 0x000029A0
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x9A23F0", Offset = "0x9A11F0", VA = "0x1809A23F0")]
	public bool Menu_FuelStorage_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x9A2740", Offset = "0x9A1540", VA = "0x1809A2740")]
	[Attribute(Name = "Menu", RVA = "0xB7400", Offset = "0xB6800")]
	[Attribute(Name = "Description", RVA = "0xB7400", Offset = "0xB6800")]
	[Attribute(Name = "Icon", RVA = "0xB7400", Offset = "0xB6800")]
	[Attribute(Name = "ShowIf", RVA = "0xB7400", Offset = "0xB6800")]
	public void Menu_TorpedoStorage(global::BasePlayer player)
	{
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x000047B8 File Offset: 0x000029B8
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x9A2650", Offset = "0x9A1450", VA = "0x1809A2650")]
	public bool Menu_TorpedoStorage_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x9A25D0", Offset = "0x9A13D0", VA = "0x1809A25D0")]
	[Attribute(Name = "Menu", RVA = "0xB75C0", Offset = "0xB69C0")]
	[Attribute(Name = "Description", RVA = "0xB75C0", Offset = "0xB69C0")]
	[Attribute(Name = "Icon", RVA = "0xB75C0", Offset = "0xB69C0")]
	[Attribute(Name = "ShowIf", RVA = "0xB75C0", Offset = "0xB69C0")]
	public void Menu_ItemStorage(global::BasePlayer player)
	{
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x000047D0 File Offset: 0x000029D0
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x9A2500", Offset = "0x9A1300", VA = "0x1809A2500")]
	public bool Menu_ItemStorage_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x9A2610", Offset = "0x9A1410", VA = "0x1809A2610", Slot = "196")]
	[Attribute(Name = "Menu", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "Description", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "Icon", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "ShowIf", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	public virtual void Menu_Push(global::BasePlayer player)
	{
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x9A3E00", Offset = "0x9A2C00", VA = "0x1809A3E00")]
	[global::BaseEntity.RPC_Client]
	private void SubmarineUpdate(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x9A1230", Offset = "0x9A0030", VA = "0x1809A1230")]
	[global::BaseEntity.RPC_Client]
	private void EngineStartFailed(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x7AA3F0", Offset = "0x7A91F0", VA = "0x1807AA3F0")]
	[global::BaseEntity.RPC_Client]
	private void TorpedoFired(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x9A3F30", Offset = "0x9A2D30", VA = "0x1809A3F30")]
	[global::BaseEntity.RPC_Client]
	private void TorpedoFireFailed(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x0600083A RID: 2106 RVA: 0x000047E8 File Offset: 0x000029E8
	[Token(Token = "0x17000061")]
	public ItemModGiveOxygen.AirSupplyType AirType
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x4D6500", Offset = "0x4D5300", VA = "0x1804D6500", Slot = "191")]
		get
		{
			return ItemModGiveOxygen.AirSupplyType.Lungs;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x0600083B RID: 2107 RVA: 0x00004800 File Offset: 0x00002A00
	[Token(Token = "0x17000062")]
	public bool IsMovingOrOn
	{
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x9A5080", Offset = "0x9A3E80", VA = "0x1809A5080")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600083C RID: 2108 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x17000063")]
	public VehicleEngineController<BaseSubmarine>.EngineState EngineState
	{
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x9A4E00", Offset = "0x9A3C00", VA = "0x1809A4E00")]
		get
		{
			return VehicleEngineController.EngineState.Off;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600083D RID: 2109 RVA: 0x00004830 File Offset: 0x00002A30
	// (set) Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000064")]
	public Vector3 Velocity
	{
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x9A51C0", Offset = "0x9A3FC0", VA = "0x1809A51C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x9A53F0", Offset = "0x9A41F0", VA = "0x1809A53F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x0600083F RID: 2111 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x17000065")]
	public bool LightsAreOn
	{
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2F6150", Offset = "0x2F4F50", VA = "0x1802F6150")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000840 RID: 2112 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x17000066")]
	public bool HasAmmo
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2F6110", Offset = "0x2F4F10", VA = "0x1802F6110")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000841 RID: 2113 RVA: 0x00004878 File Offset: 0x00002A78
	// (set) Token: 0x06000842 RID: 2114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000067")]
	public float ThrottleInput
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x9A5150", Offset = "0x9A3F50", VA = "0x1809A5150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x9A52F0", Offset = "0x9A40F0", VA = "0x1809A52F0")]
		set
		{
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000843 RID: 2115 RVA: 0x00004890 File Offset: 0x00002A90
	// (set) Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000068")]
	public float RudderInput
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x9A5140", Offset = "0x9A3F40", VA = "0x1809A5140")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x9A5270", Offset = "0x9A4070", VA = "0x1809A5270")]
		set
		{
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000845 RID: 2117 RVA: 0x000048A8 File Offset: 0x00002AA8
	// (set) Token: 0x06000846 RID: 2118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000069")]
	public float UpDownInput
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x9A51B0", Offset = "0x9A3FB0", VA = "0x1809A51B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x9A5370", Offset = "0x9A4170", VA = "0x1809A5370")]
		set
		{
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000847 RID: 2119 RVA: 0x000048C0 File Offset: 0x00002AC0
	// (set) Token: 0x06000848 RID: 2120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006A")]
	public float Oxygen
	{
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x9A0D00", Offset = "0x99FB00", VA = "0x1809A0D00")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x9A51E0", Offset = "0x9A3FE0", VA = "0x1809A51E0")]
		set
		{
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000849 RID: 2121 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x1700006B")]
	protected float PhysicalRudderAngle
	{
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x9A50E0", Offset = "0x9A3EE0", VA = "0x1809A50E0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x0600084A RID: 2122 RVA: 0x000048F0 File Offset: 0x00002AF0
	[Token(Token = "0x1700006C")]
	protected bool IsInWater
	{
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x9A5060", Offset = "0x9A3E60", VA = "0x1809A5060")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x0600084B RID: 2123 RVA: 0x00004908 File Offset: 0x00002B08
	[Token(Token = "0x1700006D")]
	protected bool IsSurfaced
	{
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x9A50C0", Offset = "0x9A3EC0", VA = "0x1809A50C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x9A2030", Offset = "0x9A0E30", VA = "0x1809A2030", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x9A2260", Offset = "0x9A1060", VA = "0x1809A2260", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x9A28B0", Offset = "0x9A16B0", VA = "0x1809A28B0", Slot = "80")]
	public override void OnFlagsChanged(global::BaseEntity.Flags old, global::BaseEntity.Flags next)
	{
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00004920 File Offset: 0x00002B20
	[Token(Token = "0x600040F")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "155")]
	public override float WaterFactorForPlayer(global::BasePlayer player)
	{
		return 0f;
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00004938 File Offset: 0x00002B38
	[Token(Token = "0x6000410")]
	[Address(RVA = "0x9A0D00", Offset = "0x99FB00", VA = "0x1809A0D00", Slot = "107")]
	public override float AirFactor()
	{
		return 0f;
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00004950 File Offset: 0x00002B50
	[Token(Token = "0x6000411")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "108")]
	public override bool BlocksWaterFor(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00004968 File Offset: 0x00002B68
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x9A1340", Offset = "0x9A0140", VA = "0x1809A1340")]
	public float GetFuelAmount()
	{
		return 0f;
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00004980 File Offset: 0x00002B80
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x9A1D00", Offset = "0x9A0B00", VA = "0x1809A1D00")]
	public float GetSpeed()
	{
		return 0f;
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00004998 File Offset: 0x00002B98
	[Token(Token = "0x6000414")]
	[Address(RVA = "0x9A0DE0", Offset = "0x99FBE0", VA = "0x1809A0DE0", Slot = "119")]
	public override bool CanBeLooted(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x000049B0 File Offset: 0x00002BB0
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x9A1260", Offset = "0x9A0060", VA = "0x1809A1260", Slot = "192")]
	public float GetAirTimeRemaining()
	{
		return 0f;
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x000049C8 File Offset: 0x00002BC8
	[Token(Token = "0x6000416")]
	[Address(RVA = "0x9A0EE0", Offset = "0x99FCE0", VA = "0x1809A0EE0", Slot = "188")]
	protected override bool CanPushNow(global::BasePlayer pusher)
	{
		return default(bool);
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000417")]
	[Address(RVA = "0x9A4B10", Offset = "0x9A3910", VA = "0x1809A4B10")]
	private void UpdatePhysicalRudder(float turnInput, float deltaTime)
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000418")]
	[Address(RVA = "0x9A38D0", Offset = "0x9A26D0", VA = "0x1809A38D0")]
	private void ResetInputs()
	{
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x000049E0 File Offset: 0x00002BE0
	[Token(Token = "0x6000419")]
	[Address(RVA = "0x9A0EB0", Offset = "0x99FCB0", VA = "0x1809A0EB0")]
	private bool CanMount(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041A")]
	[Address(RVA = "0x9A4CB0", Offset = "0x9A3AB0", VA = "0x1809A4CB0")]
	private void UpdateWaterInfo()
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x000049F8 File Offset: 0x00002BF8
	[Token(Token = "0x600041B")]
	[Address(RVA = "0x9A1DF0", Offset = "0x9A0BF0", VA = "0x1809A1DF0")]
	private float GetWaterSurfaceY()
	{
		return 0f;
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041C")]
	[Address(RVA = "0x9A4D70", Offset = "0x9A3B70", VA = "0x1809A4D70")]
	public BaseSubmarine()
	{
	}

	// Token: 0x0400041C RID: 1052
	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x3A8")]
	private Option __menuOption_Menu_FuelStorage;

	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x400")]
	private Option __menuOption_Menu_ItemStorage;

	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x458")]
	private Option __menuOption_Menu_Push;

	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x4B0")]
	private Option __menuOption_Menu_TorpedoStorage;

	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x508")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <PropPercentVelocity>k__BackingField;

	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x50C")]
	private bool runningClientTick;

	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x50D")]
	private bool playedDiveBubbles;

	// Token: 0x04000423 RID: 1059
	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x50E")]
	private bool playedWindowFilm;

	// Token: 0x04000424 RID: 1060
	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x510")]
	private float baseAlphaInside;

	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x514")]
	private float baseAlphaOutside;

	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x518")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB2720", Offset = "0xB1B20")]
	[SerializeField]
	private Transform centreOfMassTransform;

	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x520")]
	[SerializeField]
	private Buoyancy buoyancy;

	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x528")]
	[SerializeField]
	protected float maxRudderAngle;

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x530")]
	[SerializeField]
	private Transform rudderVisualTransform;

	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x538")]
	[SerializeField]
	private Transform rudderDetailedColliderTransform;

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x540")]
	[SerializeField]
	private Transform propellerTransform;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x548")]
	[SerializeField]
	private float timeUntilAutoSurface;

	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x550")]
	[SerializeField]
	private Renderer[] interiorRenderers;

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x558")]
	[SerializeField]
	private SonarObject sonarObject;

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x560")]
	[SerializeField]
	private BaseSubmarine.ParentTriggerInfo[] parentTriggers;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x568")]
	[SerializeField]
	private GameObjectRef fuelStoragePrefab;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x570")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB4230", Offset = "0xB3630")]
	[SerializeField]
	private float engineKW;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x574")]
	[SerializeField]
	private float turnPower;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x578")]
	[SerializeField]
	private float engineStartupTime;

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x580")]
	[SerializeField]
	private GameObjectRef itemStoragePrefab;

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x588")]
	[SerializeField]
	private float depthChangeTargetSpeed;

	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x58C")]
	[SerializeField]
	private float idleFuelPerSec;

	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x590")]
	[SerializeField]
	private float maxFuelPerSec;

	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x594")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB47B0", Offset = "0xB3BB0")]
	[SerializeField]
	private bool internalAccessStorage;

	// Token: 0x04000439 RID: 1081
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x598")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB4800", Offset = "0xB3C00")]
	[SerializeField]
	private GameObjectRef torpedoStoragePrefab;

	// Token: 0x0400043A RID: 1082
	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x5A0")]
	[SerializeField]
	private Transform torpedoFiringPoint;

	// Token: 0x0400043B RID: 1083
	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x5A8")]
	[SerializeField]
	private float maxFireRate;

	// Token: 0x0400043C RID: 1084
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x5B0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB4A90", Offset = "0xB3E90")]
	[SerializeField]
	protected SubmarineAudio submarineAudio;

	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x5B8")]
	[SerializeField]
	private ParticleSystem fxTorpedoFire;

	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x5C0")]
	[SerializeField]
	private GameObject internalFXContainer;

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x5C8")]
	[SerializeField]
	private GameObject internalOnFXContainer;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x5D0")]
	[SerializeField]
	private ParticleSystem fxIntAmbientBubbleLoop;

	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x5D8")]
	[SerializeField]
	private ParticleSystem fxIntInitialDiveBubbles;

	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x5E0")]
	[SerializeField]
	private ParticleSystem fxIntWaterDropSpray;

	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x5E8")]
	[SerializeField]
	private ParticleSystem fxIntWindowFilm;

	// Token: 0x04000444 RID: 1092
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x5F0")]
	[SerializeField]
	private ParticleSystemContainer fxIntMediumDamage;

	// Token: 0x04000445 RID: 1093
	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x5F8")]
	[SerializeField]
	private ParticleSystemContainer fxIntHeavyDamage;

	// Token: 0x04000446 RID: 1094
	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x600")]
	[SerializeField]
	private GameObject externalFXContainer;

	// Token: 0x04000447 RID: 1095
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x608")]
	[SerializeField]
	private GameObject externalOnFXContainer;

	// Token: 0x04000448 RID: 1096
	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x610")]
	[SerializeField]
	private ParticleSystem fxExtAmbientBubbleLoop;

	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x618")]
	[SerializeField]
	private ParticleSystem fxExtInitialDiveBubbles;

	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x620")]
	[SerializeField]
	private ParticleSystem fxExtAboveWaterEngineThrustForward;

	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x628")]
	[SerializeField]
	private ParticleSystem fxExtAboveWaterEngineThrustReverse;

	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x630")]
	[SerializeField]
	private ParticleSystem fxExtUnderWaterEngineThrustForward;

	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x638")]
	[SerializeField]
	private ParticleSystem[] fxExtUnderWaterEngineThrustForwardSubs;

	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x640")]
	[SerializeField]
	private ParticleSystem fxExtUnderWaterEngineThrustReverse;

	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x648")]
	[SerializeField]
	private ParticleSystem[] fxExtUnderWaterEngineThrustReverseSubs;

	// Token: 0x04000450 RID: 1104
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x650")]
	[SerializeField]
	private ParticleSystem fxExtBowWave;

	// Token: 0x04000451 RID: 1105
	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x658")]
	[SerializeField]
	private ParticleSystem fxExtWakeEffect;

	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x660")]
	[SerializeField]
	private GameObjectRef aboveWatercollisionEffect;

	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x668")]
	[SerializeField]
	private GameObjectRef underWatercollisionEffect;

	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x670")]
	[SerializeField]
	private VolumetricLightBeam spotlightVolumetrics;

	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x678")]
	[SerializeField]
	private float mountedAlphaInside;

	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x67C")]
	[SerializeField]
	private float mountedAlphaOutside;

	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x0")]
	[ServerVar]
	public static float outsidedecayminutes;

	// Token: 0x04000458 RID: 1112
	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x4")]
	[ServerVar]
	public static float deepwaterdecayminutes;

	// Token: 0x04000459 RID: 1113
	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x8")]
	[ServerVar]
	public static float oxygenminutes;

	// Token: 0x0400045A RID: 1114
	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x680")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private Vector3 <Velocity>k__BackingField;

	// Token: 0x0400045B RID: 1115
	[Token(Token = "0x4000392")]
	public const global::BaseEntity.Flags Flag_Ammo = global::BaseEntity.Flags.Reserved6;

	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x68C")]
	private float _throttle;

	// Token: 0x0400045D RID: 1117
	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x690")]
	private float _rudder;

	// Token: 0x0400045E RID: 1118
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x694")]
	private float _upDown;

	// Token: 0x0400045F RID: 1119
	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x698")]
	private float _oxygen;

	// Token: 0x04000460 RID: 1120
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x6A0")]
	protected VehicleEngineController<BaseSubmarine> engineController;

	// Token: 0x04000461 RID: 1121
	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x6A8")]
	protected float cachedFuelAmount;

	// Token: 0x04000462 RID: 1122
	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x6AC")]
	protected Vector3 steerAngle;

	// Token: 0x04000463 RID: 1123
	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x6B8")]
	protected float waterSurfaceY;

	// Token: 0x04000464 RID: 1124
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x6BC")]
	protected float curSubDepthY;

	// Token: 0x04000465 RID: 1125
	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x6C0")]
	private EntityRef<StorageContainer> torpedoStorageInstance;

	// Token: 0x04000466 RID: 1126
	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x6D0")]
	private EntityRef<StorageContainer> itemStorageInstance;

	// Token: 0x04000467 RID: 1127
	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x6E0")]
	private int waterLayerMask;

	// Token: 0x0200006C RID: 108
	[Token(Token = "0x2000A6D")]
	[Serializable]
	public class ParentTriggerInfo
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD3")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public ParentTriggerInfo()
		{
		}

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4003E0E")]
		[FieldOffset(Offset = "0x10")]
		public TriggerParent trigger;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4003E0F")]
		[FieldOffset(Offset = "0x18")]
		public Transform triggerWaterLevel;
	}
}
