using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using Rust;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x0200010B RID: 267
[Token(Token = "0x20000A1")]
public class BaseNpc : BaseCombatEntity
{
	// Token: 0x06001047 RID: 4167 RVA: 0x000098A0 File Offset: 0x00007AA0
	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x2FC370", Offset = "0x2FB170", VA = "0x1802FC370", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x000098B8 File Offset: 0x00007AB8
	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x2FD2E0", Offset = "0x2FC0E0", VA = "0x1802FD2E0")]
	public int TopologyPreference()
	{
		return 0;
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x000098D0 File Offset: 0x00007AD0
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x2FC1C0", Offset = "0x2FAFC0", VA = "0x1802FC1C0", Slot = "52")]
	public override float GetExtrapolationTime()
	{
		return 0f;
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x2FCD80", Offset = "0x2FBB80", VA = "0x1802FCD80", Slot = "83")]
	public override void OnSignal(global::BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x2FBF00", Offset = "0x2FAD00", VA = "0x1802FBF00", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x2FC090", Offset = "0x2FAE90", VA = "0x1802FC090", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x2FBD10", Offset = "0x2FAB10", VA = "0x1802FBD10")]
	public static void ClientCycle(float deltaTime)
	{
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x2FC2B0", Offset = "0x2FB0B0", VA = "0x1802FC2B0", Slot = "89")]
	public override void MakeVisible()
	{
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x2FBFF0", Offset = "0x2FADF0", VA = "0x1802FBFF0")]
	protected void ClientUpdate()
	{
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06001050 RID: 4176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000155")]
	public static List<BaseNpc> VisibleNpcList
	{
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x2FDE80", Offset = "0x2FCC80", VA = "0x1802FDE80")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x2FBBF0", Offset = "0x2FA9F0", VA = "0x1802FBBF0")]
	public static void ClearVisibility()
	{
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x2FD170", Offset = "0x2FBF70", VA = "0x1802FD170")]
	public static void RegisterForVisibility(BaseNpc npc)
	{
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x2FD2F0", Offset = "0x2FC0F0", VA = "0x1802FD2F0")]
	public static void UnregisterFromVisibility(BaseNpc npc)
	{
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x2FD220", Offset = "0x2FC020", VA = "0x1802FD220", Slot = "60")]
	public override void SetNetworkRotation(Quaternion rot)
	{
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x000098E8 File Offset: 0x00007AE8
	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x2FC250", Offset = "0x2FB050", VA = "0x1802FC250", Slot = "25")]
	public override Quaternion GetNetworkRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x2FC160", Offset = "0x2FAF60", VA = "0x1802FC160", Slot = "144")]
	[global::BaseEntity.RPC_Client]
	public virtual void Eat(Vector3 position)
	{
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x2FBB90", Offset = "0x2FA990", VA = "0x1802FBB90", Slot = "145")]
	[global::BaseEntity.RPC_Client]
	public virtual void Attack(Vector3 position)
	{
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x2FD260", Offset = "0x2FC060", VA = "0x1802FD260", Slot = "146")]
	[global::BaseEntity.RPC_Client]
	public virtual void Startled(Vector3 position)
	{
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x00009900 File Offset: 0x00007B00
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x2FC2A0", Offset = "0x2FB0A0", VA = "0x1802FC2A0")]
	public bool HasAiFlag(BaseNpc.AiFlags f)
	{
		return default(bool);
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x2FD200", Offset = "0x2FC000", VA = "0x1802FD200")]
	public void SetAiFlag(BaseNpc.AiFlags f, bool set)
	{
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x0600105B RID: 4187 RVA: 0x00009918 File Offset: 0x00007B18
	// (set) Token: 0x0600105C RID: 4188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000156")]
	public bool IsSitting
	{
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x2FDE60", Offset = "0x2FCC60", VA = "0x1802FDE60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x2FDF00", Offset = "0x2FCD00", VA = "0x1802FDF00")]
		set
		{
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x0600105D RID: 4189 RVA: 0x00009930 File Offset: 0x00007B30
	// (set) Token: 0x0600105E RID: 4190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000157")]
	public bool IsChasing
	{
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x2FDE50", Offset = "0x2FCC50", VA = "0x1802FDE50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x2FDEE0", Offset = "0x2FCCE0", VA = "0x1802FDEE0")]
		set
		{
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x0600105F RID: 4191 RVA: 0x00009948 File Offset: 0x00007B48
	// (set) Token: 0x06001060 RID: 4192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000158")]
	public bool IsSleeping
	{
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x2FDE70", Offset = "0x2FCC70", VA = "0x1802FDE70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x2FDF20", Offset = "0x2FCD20", VA = "0x1802FDF20")]
		set
		{
		}
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x2FD740", Offset = "0x2FC540", VA = "0x1802FD740")]
	public static void UpdateNpcVisibilities()
	{
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00009960 File Offset: 0x00007B60
	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x2FD2C0", Offset = "0x2FC0C0", VA = "0x1802FD2C0")]
	private float TimeSinceSeen()
	{
		return 0f;
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x2FD230", Offset = "0x2FC030", VA = "0x1802FD230")]
	private void SetNextVisThink(float addTime)
	{
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00009978 File Offset: 0x00007B78
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x2FDD50", Offset = "0x2FCB50", VA = "0x1802FDD50")]
	private bool WantsVisUpdate()
	{
		return default(bool);
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x2FD380", Offset = "0x2FC180", VA = "0x1802FD380", Slot = "90")]
	protected override void UpdateCullingSpheres()
	{
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x2FD860", Offset = "0x2FC660", VA = "0x1802FD860")]
	private void VisUpdateUsingCulling(float dist, bool visibility)
	{
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x2FCE80", Offset = "0x2FBC80", VA = "0x1802FCE80", Slot = "92")]
	protected override void OnVisibilityChanged(bool visible)
	{
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x2FD960", Offset = "0x2FC760", VA = "0x1802FD960")]
	private void VisUpdate()
	{
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06001069 RID: 4201 RVA: 0x00009990 File Offset: 0x00007B90
	[Token(Token = "0x17000159")]
	public override bool IsNpc
	{
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "98")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x000099A8 File Offset: 0x00007BA8
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x2FC360", Offset = "0x2FB160", VA = "0x1802FC360", Slot = "111")]
	public override float MaxVelocity()
	{
		return 0f;
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x2FDDD0", Offset = "0x2FCBD0", VA = "0x1802FDDD0")]
	public BaseNpc()
	{
	}

	// Token: 0x04000A83 RID: 2691
	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x238")]
	public int agentTypeIndex;

	// Token: 0x04000A84 RID: 2692
	[Token(Token = "0x4000899")]
	[FieldOffset(Offset = "0x23C")]
	public bool NewAI;

	// Token: 0x04000A85 RID: 2693
	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	[InspectorFlags]
	public TerrainTopology.Enum topologyPreference;

	// Token: 0x04000A86 RID: 2694
	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x244")]
	[NonSerialized]
	public Quaternion NetworkRotation;

	// Token: 0x04000A87 RID: 2695
	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x0")]
	private static List<BaseNpc> visibleNpcList;

	// Token: 0x04000A88 RID: 2696
	[Token(Token = "0x400089D")]
	[FieldOffset(Offset = "0x254")]
	[InspectorFlags]
	public BaseNpc.AiFlags aiFlags;

	// Token: 0x04000A89 RID: 2697
	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x258")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x88760", Offset = "0x87B60")]
	public int ForgetUnseenEntityTime;

	// Token: 0x04000A8A RID: 2698
	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x25C")]
	public float SensesTickRate;

	// Token: 0x04000A8B RID: 2699
	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x260")]
	private float nextVisThink;

	// Token: 0x04000A8C RID: 2700
	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x264")]
	private float lastTimeSeen;

	// Token: 0x04000A8D RID: 2701
	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x268")]
	private Vector3 lastPosition;

	// Token: 0x04000A8E RID: 2702
	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x278")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x88830", Offset = "0x87C30")]
	public GameObjectRef CorpsePrefab;

	// Token: 0x04000A8F RID: 2703
	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x280")]
	public BaseNpc.AiStatistics Stats;

	// Token: 0x04000A90 RID: 2704
	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0x330")]
	public Vector3 AttackOffset;

	// Token: 0x04000A91 RID: 2705
	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x33C")]
	public float AttackDamage;

	// Token: 0x04000A92 RID: 2706
	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x340")]
	public DamageType AttackDamageType;

	// Token: 0x04000A93 RID: 2707
	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x344")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x88A40", Offset = "0x87E40")]
	public float AttackCost;

	// Token: 0x04000A94 RID: 2708
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x348")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x88B70", Offset = "0x87F70")]
	public float AttackRate;

	// Token: 0x04000A95 RID: 2709
	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x34C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x88CD0", Offset = "0x880D0")]
	public float AttackRange;

	// Token: 0x04000A96 RID: 2710
	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x350")]
	public NavMeshAgent NavAgent;

	// Token: 0x04000A97 RID: 2711
	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x358")]
	public LayerMask movementMask;

	// Token: 0x04000A98 RID: 2712
	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x35C")]
	public float stuckDuration;

	// Token: 0x04000A99 RID: 2713
	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x360")]
	public float lastStuckTime;

	// Token: 0x04000A9A RID: 2714
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x364")]
	public float idleDuration;

	// Token: 0x0200010C RID: 268
	[Token(Token = "0x2000AA4")]
	[Flags]
	public enum AiFlags
	{
		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4003F1F")]
		Sitting = 2,
		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4003F20")]
		Chasing = 4,
		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4003F21")]
		Sleeping = 8
	}

	// Token: 0x0200010D RID: 269
	[Token(Token = "0x2000AA5")]
	[Serializable]
	public struct AiStatistics
	{
		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4003F22")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89050", Offset = "0x88450")]
		[Attribute(Name = "RangeAttribute", RVA = "0x89050", Offset = "0x88450")]
		public float Size;

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4003F23")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x893B0", Offset = "0x887B0")]
		public float Speed;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4003F24")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89440", Offset = "0x88840")]
		public float Acceleration;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4003F25")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89560", Offset = "0x88960")]
		public float TurnSpeed;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4003F26")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89670", Offset = "0x88A70")]
		[Attribute(Name = "RangeAttribute", RVA = "0x89670", Offset = "0x88A70")]
		public float Tolerance;

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4003F27")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x897D0", Offset = "0x88BD0")]
		public float VisionRange;

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4003F28")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x899A0", Offset = "0x88DA0")]
		public float VisionCone;

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4003F29")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89A60", Offset = "0x88E60")]
		public AnimationCurve DistanceVisibility;

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4003F2A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89B20", Offset = "0x88F20")]
		public float Hostility;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4003F2B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89C10", Offset = "0x89010")]
		public float Defensiveness;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4003F2C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89E70", Offset = "0x89270")]
		public float AggressionRange;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4003F2D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x89F40", Offset = "0x89340")]
		public float DeaggroRange;

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4003F2E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8A100", Offset = "0x89500")]
		public float DeaggroChaseTime;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4003F2F")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8A1C0", Offset = "0x895C0")]
		public float DeaggroCooldown;

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4003F30")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8A390", Offset = "0x89790")]
		public float HealthThresholdForFleeing;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4003F31")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8A4A0", Offset = "0x898A0")]
		public float HealthThresholdFleeChance;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4003F32")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8A620", Offset = "0x89A20")]
		public float MinFleeRange;

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4003F33")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8A760", Offset = "0x89B60")]
		public float MaxFleeRange;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4003F34")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8A8C0", Offset = "0x89CC0")]
		public float MaxFleeTime;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4003F35")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8A990", Offset = "0x89D90")]
		public float AfraidRange;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4003F36")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8AA40", Offset = "0x89E40")]
		public BaseNpc.AiStatistics.FamilyEnum Family;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4003F37")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8AB90", Offset = "0x89F90")]
		public BaseNpc.AiStatistics.FamilyEnum[] IsAfraidOf;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4003F38")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8ACB0", Offset = "0x8A0B0")]
		public float MinRoamRange;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4003F39")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8AE30", Offset = "0x8A230")]
		public float MaxRoamRange;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4003F3A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8AFB0", Offset = "0x8A3B0")]
		public float MinRoamDelay;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4003F3B")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8B160", Offset = "0x8A560")]
		public float MaxRoamDelay;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4003F3C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8B380", Offset = "0x8A780")]
		public bool IsMobile;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4003F3D")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8C7E0", Offset = "0x8BBE0")]
		public AnimationCurve RoamDelayDistribution;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4003F3E")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8C8E0", Offset = "0x8BCE0")]
		public float AttackedMemoryTime;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4003F3F")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8CAC0", Offset = "0x8BEC0")]
		public float WakeupBlockMoveTime;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4003F40")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8CC10", Offset = "0x8C010")]
		public float MaxWaterDepth;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4003F41")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8CE10", Offset = "0x8C210")]
		public float WaterLevelNeck;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4003F42")]
		[FieldOffset(Offset = "0x98")]
		public float WaterLevelNeckOffset;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4003F43")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8CE70", Offset = "0x8C270")]
		public float CloseRange;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4003F44")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8CFC0", Offset = "0x8C3C0")]
		public float MediumRange;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4003F45")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8D090", Offset = "0x8C490")]
		public float LongRange;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4003F46")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8D240", Offset = "0x8C640")]
		public float OutOfRangeOfSpawnPointTimeout;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4003F47")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x8D2D0", Offset = "0x8C6D0")]
		public bool OnlyAggroMarkedTargets;

		// Token: 0x0200010E RID: 270
		[Token(Token = "0x2000E65")]
		public enum FamilyEnum
		{
			// Token: 0x04000AC6 RID: 2758
			[Token(Token = "0x4004FF5")]
			Bear,
			// Token: 0x04000AC7 RID: 2759
			[Token(Token = "0x4004FF6")]
			Wolf,
			// Token: 0x04000AC8 RID: 2760
			[Token(Token = "0x4004FF7")]
			Deer,
			// Token: 0x04000AC9 RID: 2761
			[Token(Token = "0x4004FF8")]
			Boar,
			// Token: 0x04000ACA RID: 2762
			[Token(Token = "0x4004FF9")]
			Chicken,
			// Token: 0x04000ACB RID: 2763
			[Token(Token = "0x4004FFA")]
			Horse,
			// Token: 0x04000ACC RID: 2764
			[Token(Token = "0x4004FFB")]
			Zombie,
			// Token: 0x04000ACD RID: 2765
			[Token(Token = "0x4004FFC")]
			Scientist,
			// Token: 0x04000ACE RID: 2766
			[Token(Token = "0x4004FFD")]
			Murderer,
			// Token: 0x04000ACF RID: 2767
			[Token(Token = "0x4004FFE")]
			Player
		}
	}
}
