using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x0200028D RID: 653
[Token(Token = "0x20001CB")]
public class BaseNavigator : BaseMonoBehaviour
{
	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06001987 RID: 6535 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001988 RID: 6536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A8")]
	public AIMovePointPath Path
	{
		[Token(Token = "0x6001426")]
		[Address(RVA = "0x2F9B40", Offset = "0x2F8940", VA = "0x1802F9B40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x2F9BC0", Offset = "0x2F89C0", VA = "0x1802F9BC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06001989 RID: 6537 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600198A RID: 6538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A9")]
	public BasePath AStarGraph
	{
		[Token(Token = "0x6001428")]
		[Address(RVA = "0x2F9A70", Offset = "0x2F8870", VA = "0x1802F9A70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x2F9B50", Offset = "0x2F8950", VA = "0x1802F9B50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x0000CF30 File Offset: 0x0000B130
	[Token(Token = "0x600142A")]
	[Address(RVA = "0x2F9900", Offset = "0x2F8700", VA = "0x1802F9900")]
	public int TopologyPreference()
	{
		return 0;
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x0600198C RID: 6540 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600198D RID: 6541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AA")]
	public NavMeshAgent Agent
	{
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x2F9A80", Offset = "0x2F8880", VA = "0x1802F9A80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x2F9B60", Offset = "0x2F8960", VA = "0x1802F9B60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x0600198E RID: 6542 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600198F RID: 6543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AB")]
	public BaseCombatEntity BaseEntity
	{
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x2F9A90", Offset = "0x2F8890", VA = "0x1802F9A90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x600142E")]
		[Address(RVA = "0x2F9B70", Offset = "0x2F8970", VA = "0x1802F9B70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06001990 RID: 6544 RVA: 0x0000CF48 File Offset: 0x0000B148
	// (set) Token: 0x06001991 RID: 6545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AC")]
	public Vector3 Destination
	{
		[Token(Token = "0x600142F")]
		[Address(RVA = "0x2F9AB0", Offset = "0x2F88B0", VA = "0x1802F9AB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x2F9B90", Offset = "0x2F8990", VA = "0x1802F9B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06001992 RID: 6546 RVA: 0x0000CF60 File Offset: 0x0000B160
	[Token(Token = "0x170001AD")]
	public virtual bool IsOnNavMeshLink
	{
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x2F9AD0", Offset = "0x2F88D0", VA = "0x1802F9AD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06001993 RID: 6547 RVA: 0x0000CF78 File Offset: 0x0000B178
	[Token(Token = "0x170001AE")]
	public bool Moving
	{
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x2F9B30", Offset = "0x2F8930", VA = "0x1802F9B30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06001994 RID: 6548 RVA: 0x0000CF90 File Offset: 0x0000B190
	// (set) Token: 0x06001995 RID: 6549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AF")]
	public BaseNavigator.NavigationType CurrentNavigationType
	{
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x2F9AA0", Offset = "0x2F88A0", VA = "0x1802F9AA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return BaseNavigator.NavigationType.None;
		}
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x2F9B80", Offset = "0x2F8980", VA = "0x1802F9B80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06001996 RID: 6550 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
	// (set) Token: 0x06001997 RID: 6551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B0")]
	public BaseNavigator.NavigationType LastUsedNavigationType
	{
		[Token(Token = "0x6001435")]
		[Address(RVA = "0x2F9B20", Offset = "0x2F8920", VA = "0x1802F9B20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return BaseNavigator.NavigationType.None;
		}
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x2F9BB0", Offset = "0x2F89B0", VA = "0x1802F9BB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001437")]
	[Address(RVA = "0x2F99A0", Offset = "0x2F87A0", VA = "0x1802F99A0")]
	public BaseNavigator()
	{
	}

	// Token: 0x040013B5 RID: 5045
	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x0")]
	[ServerVar]
	public static float maxStepUpDistance;

	// Token: 0x040013B6 RID: 5046
	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x4")]
	[ServerVar]
	public static int baseNavMovementFrameInterval;

	// Token: 0x040013B7 RID: 5047
	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x8")]
	[ServerVar]
	public static float stuckTriggerDuration;

	// Token: 0x040013B8 RID: 5048
	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0xC")]
	[ServerVar]
	public static float navTypeHeightOffset;

	// Token: 0x040013B9 RID: 5049
	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x10")]
	[ServerVar]
	public static float navTypeDistance;

	// Token: 0x040013BA RID: 5050
	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA3300", Offset = "0xA2700")]
	public bool CanNavigateMounted;

	// Token: 0x040013BB RID: 5051
	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0x19")]
	public bool CanUseNavMesh;

	// Token: 0x040013BC RID: 5052
	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x1A")]
	public bool CanUseAStar;

	// Token: 0x040013BD RID: 5053
	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0x1B")]
	public bool CanUseBaseNav;

	// Token: 0x040013BE RID: 5054
	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x1C")]
	public bool CanUseCustomNav;

	// Token: 0x040013BF RID: 5055
	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0x20")]
	public float StoppingDistance;

	// Token: 0x040013C0 RID: 5056
	[Token(Token = "0x400103E")]
	[FieldOffset(Offset = "0x28")]
	public string DefaultArea;

	// Token: 0x040013C1 RID: 5057
	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA3370", Offset = "0xA2770")]
	public bool TriggerStuckEvent;

	// Token: 0x040013C2 RID: 5058
	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0x34")]
	public float StuckDistance;

	// Token: 0x040013C3 RID: 5059
	[Token(Token = "0x4001041")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA3410", Offset = "0xA2810")]
	public float Speed;

	// Token: 0x040013C4 RID: 5060
	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0x3C")]
	public float Acceleration;

	// Token: 0x040013C5 RID: 5061
	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0x40")]
	public float TurnSpeed;

	// Token: 0x040013C6 RID: 5062
	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA3570", Offset = "0xA2970")]
	public float SlowestSpeedFraction;

	// Token: 0x040013C7 RID: 5063
	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0x48")]
	public float SlowSpeedFraction;

	// Token: 0x040013C8 RID: 5064
	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x4C")]
	public float NormalSpeedFraction;

	// Token: 0x040013C9 RID: 5065
	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x50")]
	public float FastSpeedFraction;

	// Token: 0x040013CA RID: 5066
	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x54")]
	public float LowHealthSpeedReductionTriggerFraction;

	// Token: 0x040013CB RID: 5067
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x58")]
	public float LowHealthMaxSpeedFraction;

	// Token: 0x040013CC RID: 5068
	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x5C")]
	public float SwimmingSpeedMultiplier;

	// Token: 0x040013CD RID: 5069
	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA36D0", Offset = "0xA2AD0")]
	public float BestMovementPointMaxDistance;

	// Token: 0x040013CE RID: 5070
	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x64")]
	public float BestCoverPointMaxDistance;

	// Token: 0x040013CF RID: 5071
	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x68")]
	public float BestRoamPointMaxDistance;

	// Token: 0x040013D0 RID: 5072
	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x6C")]
	public float MaxRoamDistanceFromHome;

	// Token: 0x040013D1 RID: 5073
	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8CF90", Offset = "0x8C390")]
	public float MaxWaterDepth;

	// Token: 0x040013D2 RID: 5074
	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x74")]
	public bool SpeedBasedAvoidancePriority;

	// Token: 0x040013D3 RID: 5075
	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x78")]
	private NavMeshPath path;

	// Token: 0x040013D4 RID: 5076
	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x80")]
	private NavMeshQueryFilter navMeshQueryFilter;

	// Token: 0x040013D5 RID: 5077
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AIMovePointPath <Path>k__BackingField;

	// Token: 0x040013D6 RID: 5078
	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BasePath <AStarGraph>k__BackingField;

	// Token: 0x040013D7 RID: 5079
	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0xA0")]
	private int defaultAreaMask;

	// Token: 0x040013D8 RID: 5080
	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0xA4")]
	[InspectorFlags]
	public TerrainTopology.Enum topologyPreference;

	// Token: 0x040013D9 RID: 5081
	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private NavMeshAgent <Agent>k__BackingField;

	// Token: 0x040013DA RID: 5082
	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BaseCombatEntity <BaseEntity>k__BackingField;

	// Token: 0x040013DB RID: 5083
	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private Vector3 <Destination>k__BackingField;

	// Token: 0x040013DC RID: 5084
	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0xC4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BaseNavigator.NavigationType <CurrentNavigationType>k__BackingField;

	// Token: 0x040013DD RID: 5085
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BaseNavigator.NavigationType <LastUsedNavigationType>k__BackingField;

	// Token: 0x0200028E RID: 654
	[Token(Token = "0x2000AF7")]
	public enum NavigationType
	{
		// Token: 0x040013DF RID: 5087
		[Token(Token = "0x4004099")]
		None,
		// Token: 0x040013E0 RID: 5088
		[Token(Token = "0x400409A")]
		NavMesh,
		// Token: 0x040013E1 RID: 5089
		[Token(Token = "0x400409B")]
		AStar,
		// Token: 0x040013E2 RID: 5090
		[Token(Token = "0x400409C")]
		Custom,
		// Token: 0x040013E3 RID: 5091
		[Token(Token = "0x400409D")]
		Base
	}

	// Token: 0x0200028F RID: 655
	[Token(Token = "0x2000AF8")]
	public enum NavigationSpeed
	{
		// Token: 0x040013E5 RID: 5093
		[Token(Token = "0x400409F")]
		Slowest,
		// Token: 0x040013E6 RID: 5094
		[Token(Token = "0x40040A0")]
		Slow,
		// Token: 0x040013E7 RID: 5095
		[Token(Token = "0x40040A1")]
		Normal,
		// Token: 0x040013E8 RID: 5096
		[Token(Token = "0x40040A2")]
		Fast
	}
}
