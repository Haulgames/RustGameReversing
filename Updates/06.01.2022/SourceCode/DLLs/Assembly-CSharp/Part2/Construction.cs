using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F8 RID: 760
[Token(Token = "0x2000215")]
public class Construction : PrefabAttribute
{
	// Token: 0x06001BF0 RID: 7152 RVA: 0x0000D980 File Offset: 0x0000BB80
	[Token(Token = "0x6001656")]
	[Address(RVA = "0x6CC9D0", Offset = "0x6CB7D0", VA = "0x1806CC9D0")]
	public bool UpdatePlacement(Transform transform, Construction common, ref Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x0000D998 File Offset: 0x0000BB98
	[Token(Token = "0x6001657")]
	[Address(RVA = "0x6CBFF0", Offset = "0x6CADF0", VA = "0x1806CBFF0")]
	private bool TestPlacingThroughRock(ref Construction.Placement placement, Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
	[Token(Token = "0x6001658")]
	[Address(RVA = "0x6CC2B0", Offset = "0x6CB0B0", VA = "0x1806CC2B0")]
	private static bool TestPlacingThroughWall(ref Construction.Placement placement, Transform transform, Construction common, Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
	[Token(Token = "0x6001659")]
	[Address(RVA = "0x6CBB40", Offset = "0x6CA940", VA = "0x1806CBB40")]
	private bool TestPlacingCloseToRoad(ref Construction.Placement placement, Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
	[Token(Token = "0x600165A")]
	[Address(RVA = "0x6CB750", Offset = "0x6CA550", VA = "0x1806CB750", Slot = "8")]
	public virtual bool ShowAsNeutral(Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
	[Token(Token = "0x170001D9")]
	public static bool DebugDraw
	{
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x6CDA40", Offset = "0x6CC840", VA = "0x1806CDA40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x0000DA10 File Offset: 0x0000BC10
	[Token(Token = "0x600165C")]
	[Address(RVA = "0x6CB650", Offset = "0x6CA450", VA = "0x1806CB650")]
	public bool HasMaleSockets(Construction.Target target)
	{
		return default(bool);
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165D")]
	[Address(RVA = "0x6CB490", Offset = "0x6CA290", VA = "0x1806CB490")]
	public void FindMaleSockets(Construction.Target target, List<Socket_Base> sockets)
	{
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600165E")]
	[Address(RVA = "0x6CAA40", Offset = "0x6C9840", VA = "0x1806CAA40")]
	public GameObject CreateGuideSkin()
	{
		return null;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165F")]
	[Address(RVA = "0x6CA680", Offset = "0x6C9480", VA = "0x1806CA680", Slot = "6")]
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001660")]
	[Address(RVA = "0x6CB5F0", Offset = "0x6CA3F0", VA = "0x1806CB5F0", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001661")]
	[Address(RVA = "0x6CBA50", Offset = "0x6CA850", VA = "0x1806CBA50")]
	public Construction()
	{
	}

	// Token: 0x040016C2 RID: 5826
	[Token(Token = "0x40012A3")]
	[FieldOffset(Offset = "0x0")]
	public static string lastPlacementError;

	// Token: 0x040016C3 RID: 5827
	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0x98")]
	public BaseEntity.Menu.Option info;

	// Token: 0x040016C4 RID: 5828
	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0xB8")]
	public bool canBypassBuildingPermission;

	// Token: 0x040016C5 RID: 5829
	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0xB9")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAD5B0", Offset = "0xAC9B0")]
	public bool canRotateBeforePlacement;

	// Token: 0x040016C6 RID: 5830
	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0xBA")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAD5B0", Offset = "0xAC9B0")]
	public bool canRotateAfterPlacement;

	// Token: 0x040016C7 RID: 5831
	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0xBB")]
	public bool checkVolumeOnRotate;

	// Token: 0x040016C8 RID: 5832
	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0xBC")]
	public bool checkVolumeOnUpgrade;

	// Token: 0x040016C9 RID: 5833
	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0xBD")]
	public bool canPlaceAtMaxDistance;

	// Token: 0x040016CA RID: 5834
	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0xBE")]
	public bool placeOnWater;

	// Token: 0x040016CB RID: 5835
	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0xC0")]
	public Vector3 rotationAmount;

	// Token: 0x040016CC RID: 5836
	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0xCC")]
	public Vector3 applyStartingRotation;

	// Token: 0x040016CD RID: 5837
	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "RangeAttribute", RVA = "0x846B0", Offset = "0x83AB0")]
	public float healthMultiplier;

	// Token: 0x040016CE RID: 5838
	[Token(Token = "0x40012AF")]
	[FieldOffset(Offset = "0xDC")]
	[Attribute(Name = "RangeAttribute", RVA = "0x846B0", Offset = "0x83AB0")]
	public float costMultiplier;

	// Token: 0x040016CF RID: 5839
	[Token(Token = "0x40012B0")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAD8B0", Offset = "0xACCB0")]
	public float maxplaceDistance;

	// Token: 0x040016D0 RID: 5840
	[Token(Token = "0x40012B1")]
	[FieldOffset(Offset = "0xE8")]
	public Mesh guideMesh;

	// Token: 0x040016D1 RID: 5841
	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0xF0")]
	[NonSerialized]
	public Socket_Base[] allSockets;

	// Token: 0x040016D2 RID: 5842
	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0xF8")]
	[NonSerialized]
	public BuildingProximity[] allProximities;

	// Token: 0x040016D3 RID: 5843
	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x100")]
	[NonSerialized]
	public ConstructionGrade defaultGrade;

	// Token: 0x040016D4 RID: 5844
	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0x108")]
	[NonSerialized]
	public SocketHandle socketHandle;

	// Token: 0x040016D5 RID: 5845
	[Token(Token = "0x40012B6")]
	[FieldOffset(Offset = "0x110")]
	[NonSerialized]
	public Bounds bounds;

	// Token: 0x040016D6 RID: 5846
	[Token(Token = "0x40012B7")]
	[FieldOffset(Offset = "0x128")]
	[NonSerialized]
	public bool isBuildingPrivilege;

	// Token: 0x040016D7 RID: 5847
	[Token(Token = "0x40012B8")]
	[FieldOffset(Offset = "0x130")]
	[NonSerialized]
	public ConstructionGrade[] grades;

	// Token: 0x040016D8 RID: 5848
	[Token(Token = "0x40012B9")]
	[FieldOffset(Offset = "0x138")]
	[NonSerialized]
	public Deployable deployable;

	// Token: 0x040016D9 RID: 5849
	[Token(Token = "0x40012BA")]
	[FieldOffset(Offset = "0x140")]
	[NonSerialized]
	public ConstructionPlaceholder placeholder;

	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x2000B18")]
	public struct Target
	{
		// Token: 0x06001BFC RID: 7164 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[Token(Token = "0x6004D18")]
		[Address(RVA = "0xF0F30", Offset = "0xF0330", VA = "0x1800F0F30")]
		public Quaternion GetWorldRotation(bool female)
		{
			return default(Quaternion);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0000DA40 File Offset: 0x0000BC40
		[Token(Token = "0x6004D19")]
		[Address(RVA = "0xF0F10", Offset = "0xF0310", VA = "0x1800F0F10")]
		public Vector3 GetWorldPosition()
		{
			return default(Vector3);
		}

		// Token: 0x040016DA RID: 5850
		[Token(Token = "0x4004135")]
		[FieldOffset(Offset = "0x0")]
		public bool valid;

		// Token: 0x040016DB RID: 5851
		[Token(Token = "0x4004136")]
		[FieldOffset(Offset = "0x4")]
		public Ray ray;

		// Token: 0x040016DC RID: 5852
		[Token(Token = "0x4004137")]
		[FieldOffset(Offset = "0x20")]
		public BaseEntity entity;

		// Token: 0x040016DD RID: 5853
		[Token(Token = "0x4004138")]
		[FieldOffset(Offset = "0x28")]
		public Socket_Base socket;

		// Token: 0x040016DE RID: 5854
		[Token(Token = "0x4004139")]
		[FieldOffset(Offset = "0x30")]
		public bool onTerrain;

		// Token: 0x040016DF RID: 5855
		[Token(Token = "0x400413A")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 position;

		// Token: 0x040016E0 RID: 5856
		[Token(Token = "0x400413B")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 normal;

		// Token: 0x040016E1 RID: 5857
		[Token(Token = "0x400413C")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 rotation;

		// Token: 0x040016E2 RID: 5858
		[Token(Token = "0x400413D")]
		[FieldOffset(Offset = "0x58")]
		public BasePlayer player;

		// Token: 0x040016E3 RID: 5859
		[Token(Token = "0x400413E")]
		[FieldOffset(Offset = "0x60")]
		public bool inBuildingPrivilege;
	}

	// Token: 0x020002FA RID: 762
	[Token(Token = "0x2000B19")]
	public class Placement
	{
		// Token: 0x06001BFE RID: 7166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public Placement()
		{
		}

		// Token: 0x040016E4 RID: 5860
		[Token(Token = "0x400413F")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		// Token: 0x040016E5 RID: 5861
		[Token(Token = "0x4004140")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;
	}

	// Token: 0x020002FB RID: 763
	[Token(Token = "0x2000B1A")]
	public class Grade
	{
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000707")]
		public PhysicMaterial physicMaterial
		{
			[Token(Token = "0x6004D1B")]
			[Address(RVA = "0x6DF260", Offset = "0x6DE060", VA = "0x1806DF260")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000708")]
		public ProtectionProperties damageProtecton
		{
			[Token(Token = "0x6004D1C")]
			[Address(RVA = "0x6DF240", Offset = "0x6DE040", VA = "0x1806DF240")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1D")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public Grade()
		{
		}

		// Token: 0x040016E6 RID: 5862
		[Token(Token = "0x4004141")]
		[FieldOffset(Offset = "0x10")]
		public BuildingGrade grade;

		// Token: 0x040016E7 RID: 5863
		[Token(Token = "0x4004142")]
		[FieldOffset(Offset = "0x18")]
		public float maxHealth;

		// Token: 0x040016E8 RID: 5864
		[Token(Token = "0x4004143")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemAmount> costToBuild;
	}

	// Token: 0x020002FC RID: 764
	[Token(Token = "0x2000B1B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1F")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[Token(Token = "0x6004D20")]
		[Address(RVA = "0x6DFFA0", Offset = "0x6DEDA0", VA = "0x1806DFFA0")]
		internal bool <CreateGuideSkin>b__33_0(ConstructionGrade x)
		{
			return default(bool);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0000DA70 File Offset: 0x0000BC70
		[Token(Token = "0x6004D21")]
		[Address(RVA = "0x6E0000", Offset = "0x6DEE00", VA = "0x1806E0000")]
		internal BuildingGrade.Enum <CreateGuideSkin>b__33_1(ConstructionGrade x)
		{
			return BuildingGrade.Enum.Twigs;
		}

		// Token: 0x040016E9 RID: 5865
		[Token(Token = "0x4004144")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Construction.<>c <>9;

		// Token: 0x040016EA RID: 5866
		[Token(Token = "0x4004145")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ConstructionGrade, bool> <>9__33_0;

		// Token: 0x040016EB RID: 5867
		[Token(Token = "0x4004146")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ConstructionGrade, BuildingGrade.Enum> <>9__33_1;
	}
}
