using System;
using System.Collections;
using System.Collections.Generic;
using Facepunch;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200006D RID: 109
[Token(Token = "0x2000041")]
public class BaseVehicle : BaseMountable
{
	// Token: 0x0600085F RID: 2143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041E")]
	[Address(RVA = "0x9A9690", Offset = "0x9A8490", VA = "0x1809A9690", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000860 RID: 2144 RVA: 0x00004A10 File Offset: 0x00002C10
	[Token(Token = "0x1700006E")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x9AA7E0", Offset = "0x9A95E0", VA = "0x1809AA7E0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00004A28 File Offset: 0x00002C28
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x9AA3D0", Offset = "0x9A91D0", VA = "0x1809AA3D0", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000421")]
	[Address(RVA = "0x9AA560", Offset = "0x9A9360", VA = "0x1809AA560", Slot = "170")]
	public override void UpdatePlayerModel(global::BasePlayer player)
	{
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000422")]
	[Address(RVA = "0x9A9620", Offset = "0x9A8420", VA = "0x1809A9620", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000423")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "183")]
	public virtual void InitializeClientEffects()
	{
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00004A40 File Offset: 0x00002C40
	[Token(Token = "0x6000424")]
	[Address(RVA = "0x9A9670", Offset = "0x9A8470", VA = "0x1809A9670", Slot = "184")]
	public virtual float GetHUDHealth()
	{
		return 0f;
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x6000425")]
	[Address(RVA = "0x9A8BF0", Offset = "0x9A79F0", VA = "0x1809A8BF0", Slot = "185")]
	public virtual float GetHUDMaxHealth()
	{
		return 0f;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00004A70 File Offset: 0x00002C70
	[Token(Token = "0x6000426")]
	[Address(RVA = "0x9A9FE0", Offset = "0x9A8DE0", VA = "0x1809A9FE0", Slot = "166")]
	public override bool LocalPlayerIsMounted()
	{
		return default(bool);
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00004A88 File Offset: 0x00002C88
	[Token(Token = "0x6000427")]
	[Address(RVA = "0x9AA1F0", Offset = "0x9A8FF0", VA = "0x1809AA1F0", Slot = "186")]
	public virtual bool Menu_Push_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000428")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	[Attribute(Name = "Menu", RVA = "0xB9600", Offset = "0xB8A00")]
	[Attribute(Name = "Description", RVA = "0xB9600", Offset = "0xB8A00")]
	[Attribute(Name = "Icon", RVA = "0xB9600", Offset = "0xB8A00")]
	[Attribute(Name = "ShowIf", RVA = "0xB9600", Offset = "0xB8A00")]
	private void Menu_Occupied(global::BasePlayer player)
	{
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00004AA0 File Offset: 0x00002CA0
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x9AA120", Offset = "0x9A8F20", VA = "0x1809AA120", Slot = "187")]
	protected virtual bool Menu_Occupied_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00004AB8 File Offset: 0x00002CB8
	[Token(Token = "0x600042A")]
	[Address(RVA = "0x9AA0A0", Offset = "0x9A8EA0", VA = "0x1809AA0A0", Slot = "180")]
	public override bool Menu_Mount_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00004AD0 File Offset: 0x00002CD0
	[Token(Token = "0x600042B")]
	[Address(RVA = "0x859C20", Offset = "0x858A20", VA = "0x180859C20")]
	public bool IsStationary()
	{
		return default(bool);
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Token(Token = "0x600042C")]
	[Address(RVA = "0x9A9FC0", Offset = "0x9A8DC0", VA = "0x1809A9FC0")]
	public bool IsMoving()
	{
		return default(bool);
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x0600086E RID: 2158 RVA: 0x00004B00 File Offset: 0x00002D00
	[Token(Token = "0x1700006F")]
	public override float RealisticMass
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x9AA8B0", Offset = "0x9A96B0", VA = "0x1809AA8B0", Slot = "76")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00004B18 File Offset: 0x00002D18
	[Token(Token = "0x600042E")]
	[Address(RVA = "0x9AA4C0", Offset = "0x9A92C0", VA = "0x1809AA4C0", Slot = "156")]
	public override bool PlayerIsMounted(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00004B30 File Offset: 0x00002D30
	[Token(Token = "0x600042F")]
	[Address(RVA = "0x53F9C0", Offset = "0x53E7C0", VA = "0x18053F9C0", Slot = "188")]
	protected virtual bool CanPushNow(global::BasePlayer pusher)
	{
		return default(bool);
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x00004B48 File Offset: 0x00002D48
	[Token(Token = "0x6000430")]
	[Address(RVA = "0x9A9CD0", Offset = "0x9A8AD0", VA = "0x1809A9CD0")]
	public bool HasMountPoints()
	{
		return default(bool);
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00004B60 File Offset: 0x00002D60
	[Token(Token = "0x6000431")]
	[Address(RVA = "0x9A9F60", Offset = "0x9A8D60", VA = "0x1809A9F60", Slot = "152")]
	public override bool IsMounted()
	{
		return default(bool);
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00004B78 File Offset: 0x00002D78
	[Token(Token = "0x6000432")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "128")]
	public override bool SupportsChildDeployables()
	{
		return default(bool);
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00004B90 File Offset: 0x00002D90
	[Token(Token = "0x6000433")]
	[Address(RVA = "0x9A9E90", Offset = "0x9A8C90", VA = "0x1809A9E90")]
	public bool IsFlipped()
	{
		return default(bool);
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00004BA8 File Offset: 0x00002DA8
	[Token(Token = "0x6000434")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "189")]
	public virtual bool IsVehicleRoot()
	{
		return default(bool);
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00004BC0 File Offset: 0x00002DC0
	[Token(Token = "0x6000435")]
	[Address(RVA = "0x9A9650", Offset = "0x9A8450", VA = "0x1809A9650", Slot = "146")]
	public override bool DirectlyMountable()
	{
		return default(bool);
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000436")]
	[Address(RVA = "0x9AA210", Offset = "0x9A9010", VA = "0x1809AA210", Slot = "22")]
	protected override void OnChildAdded(global::BaseEntity child)
	{
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000437")]
	[Address(RVA = "0x9AA300", Offset = "0x9A9100", VA = "0x1809AA300", Slot = "23")]
	protected override void OnChildRemoved(global::BaseEntity child)
	{
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000879 RID: 2169 RVA: 0x00004BD8 File Offset: 0x00002DD8
	[Token(Token = "0x17000070")]
	public global::BaseVehicle.Enumerable allMountPoints
	{
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x9AA8E0", Offset = "0x9A96E0", VA = "0x1809AA8E0")]
		get
		{
			return default(global::BaseVehicle.Enumerable);
		}
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000439")]
	[Address(RVA = "0x9A99A0", Offset = "0x9A87A0", VA = "0x1809A99A0")]
	public global::BaseVehicle.MountPointInfo GetMountPoint(int index)
	{
		return null;
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043A")]
	[Address(RVA = "0x9AA750", Offset = "0x9A9550", VA = "0x1809AA750")]
	public BaseVehicle()
	{
	}

	// Token: 0x0400046A RID: 1130
	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0x318")]
	private Option __menuOption_Menu_Occupied;

	// Token: 0x0400046B RID: 1131
	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0x370")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xB9180", Offset = "0xB8580")]
	public bool mountChaining;

	// Token: 0x0400046C RID: 1132
	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x371")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB9240", Offset = "0xB8640")]
	public bool continuousClippingCheck;

	// Token: 0x0400046D RID: 1133
	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x372")]
	public bool shouldShowHudHealth;

	// Token: 0x0400046E RID: 1134
	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x373")]
	public bool ignoreDamageFromOutside;

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x378")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB92B0", Offset = "0xB86B0")]
	public Rigidbody rigidBody;

	// Token: 0x04000470 RID: 1136
	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x380")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB9370", Offset = "0xB8770")]
	public List<global::BaseVehicle.MountPointInfo> mountPoints;

	// Token: 0x04000471 RID: 1137
	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x388")]
	public bool doClippingAndVisChecks;

	// Token: 0x04000472 RID: 1138
	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x390")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB76A0", Offset = "0xB6AA0")]
	public DamageRenderer damageRenderer;

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x398")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB9500", Offset = "0xB8900")]
	public float explosionForceMultiplier;

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x39C")]
	public float explosionForceMax;

	// Token: 0x04000475 RID: 1141
	[Token(Token = "0x40003AA")]
	public const global::BaseEntity.Flags Flag_OnlyOwnerEntry = global::BaseEntity.Flags.Locked;

	// Token: 0x04000476 RID: 1142
	[Token(Token = "0x40003AB")]
	public const global::BaseEntity.Flags Flag_Headlights = global::BaseEntity.Flags.Reserved5;

	// Token: 0x04000477 RID: 1143
	[Token(Token = "0x40003AC")]
	public const global::BaseEntity.Flags Flag_Stationary = global::BaseEntity.Flags.Reserved7;

	// Token: 0x04000478 RID: 1144
	[Token(Token = "0x40003AD")]
	public const global::BaseEntity.Flags Flag_SeatsFull = global::BaseEntity.Flags.Reserved11;

	// Token: 0x04000479 RID: 1145
	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x3A0")]
	private readonly List<global::BaseVehicle> childVehicles;

	// Token: 0x0200006E RID: 110
	[Token(Token = "0x2000A6E")]
	[Serializable]
	public class MountPointInfo
	{
		// Token: 0x0600087C RID: 2172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x9ADD40", Offset = "0x9ACB40", VA = "0x1809ADD40")]
		public MountPointInfo()
		{
		}

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x4003E10")]
		[FieldOffset(Offset = "0x10")]
		public bool isDriver;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x4003E11")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 pos;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x4003E12")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 rot;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x4003E13")]
		[FieldOffset(Offset = "0x30")]
		public string bone;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x4003E14")]
		[FieldOffset(Offset = "0x38")]
		public GameObjectRef prefab;
	}

	// Token: 0x0200006F RID: 111
	[Token(Token = "0x2000A6F")]
	public readonly struct Enumerable : IEnumerable<global::BaseVehicle.MountPointInfo>, IEnumerable
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0xF5DA0", Offset = "0xF51A0", VA = "0x1800F5DA0")]
		public Enumerable(global::BaseVehicle vehicle)
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0xF5C70", Offset = "0xF5070", VA = "0x1800F5C70")]
		public global::BaseVehicle.Enumerator GetEnumerator()
		{
			return default(global::BaseVehicle.Enumerator);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0xF5CA0", Offset = "0xF50A0", VA = "0x1800F5CA0", Slot = "4")]
		private IEnumerator<global::BaseVehicle.MountPointInfo> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0xF5D20", Offset = "0xF5120", VA = "0x1800F5D20", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x4003E15")]
		[FieldOffset(Offset = "0x0")]
		private readonly global::BaseVehicle _vehicle;
	}

	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000A70")]
	public struct Enumerator : IEnumerator<global::BaseVehicle.MountPointInfo>, IEnumerator, IDisposable
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F3")]
		public global::BaseVehicle.MountPointInfo Current
		{
			[Token(Token = "0x6004BD9")]
			[Address(RVA = "0xEDF00", Offset = "0xED300", VA = "0x1800EDF00", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BDA")]
			[Address(RVA = "0xED440", Offset = "0xEC840", VA = "0x1800ED440")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
			private set
			{
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDB")]
		[Address(RVA = "0xF5E00", Offset = "0xF5200", VA = "0x1800F5E00")]
		public Enumerator(global::BaseVehicle vehicle)
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x6004BDC")]
		[Address(RVA = "0xF5DE0", Offset = "0xF51E0", VA = "0x1800F5DE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F4")]
		private object Current
		{
			[Token(Token = "0x6004BDD")]
			[Address(RVA = "0xEDF00", Offset = "0xED300", VA = "0x1800EDF00", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDE")]
		[Address(RVA = "0xF5DD0", Offset = "0xF51D0", VA = "0x1800F5DD0", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0xF5DF0", Offset = "0xF51F0", VA = "0x1800F5DF0", Slot = "8")]
		public void Reset()
		{
		}

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4003E16")]
		[FieldOffset(Offset = "0x0")]
		private readonly global::BaseVehicle _vehicle;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4003E17")]
		[FieldOffset(Offset = "0x8")]
		private global::BaseVehicle.Enumerator.State _state;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4003E18")]
		[FieldOffset(Offset = "0xC")]
		private int _index;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4003E19")]
		[FieldOffset(Offset = "0x10")]
		private int _childIndex;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4003E1A")]
		[FieldOffset(Offset = "0x18")]
		private global::BaseVehicle.Enumerator.Box _enumerator;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4003E1B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private global::BaseVehicle.MountPointInfo <Current>k__BackingField;

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000E5D")]
		private enum State
		{
			// Token: 0x04000487 RID: 1159
			[Token(Token = "0x4004FE3")]
			Direct,
			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4004FE4")]
			EnterChild,
			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4004FE5")]
			EnumerateChild,
			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x4004FE6")]
			Finished
		}

		// Token: 0x02000072 RID: 114
		[Token(Token = "0x2000E5E")]
		private class Box : Pool.IPooled
		{
			// Token: 0x06000888 RID: 2184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053FB")]
			[Address(RVA = "0x9AD5F0", Offset = "0x9AC3F0", VA = "0x1809AD5F0", Slot = "4")]
			public void EnterPool()
			{
			}

			// Token: 0x06000889 RID: 2185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053FC")]
			[Address(RVA = "0x9AD5F0", Offset = "0x9AC3F0", VA = "0x1809AD5F0", Slot = "5")]
			public void LeavePool()
			{
			}

			// Token: 0x0600088A RID: 2186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053FD")]
			[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
			public Box()
			{
			}

			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x4004FE7")]
			[FieldOffset(Offset = "0x10")]
			public global::BaseVehicle.Enumerator Value;
		}
	}
}
