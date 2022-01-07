using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x020000EA RID: 234
[Token(Token = "0x200009A")]
public class BaseAIBrain<T> : EntityComponent<T>, IPet, IAISleepable, IAIDesign, IAIGroupable, IAIEventListener where T : global::BaseEntity
{
	// Token: 0x06000EC1 RID: 3777 RVA: 0x00008B98 File Offset: 0x00006D98
	[Token(Token = "0x6000A5B")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00008BB0 File Offset: 0x00006DB0
	[Token(Token = "0x6000A5C")]
	public bool IsPet()
	{
		return default(bool);
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5D")]
	public void SetPetOwner(global::BasePlayer player)
	{
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00008BC8 File Offset: 0x00006DC8
	[Token(Token = "0x6000A5E")]
	public bool IsOwnedBy(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00008BE0 File Offset: 0x00006DE0
	[Token(Token = "0x6000A5F")]
	public bool IssuePetCommand(PetCommandType cmd, int param, Ray? ray)
	{
		return default(bool);
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700013E")]
	public BaseAIBrain<T>.BasicAIState CurrentState
	{
		[Token(Token = "0x6000A60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A61")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00008BF8 File Offset: 0x00006DF8
	// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700013F")]
	public AIThinkMode ThinkMode
	{
		[Token(Token = "0x6000A62")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return AIThinkMode.FixedUpdate;
		}
		[Token(Token = "0x6000A63")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00008C10 File Offset: 0x00006E10
	// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000140")]
	public float Age
	{
		[Token(Token = "0x6000A64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000A65")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A66")]
	public void ForceSetAge(float age)
	{
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ECE RID: 3790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000141")]
	public AIBrainSenses Senses
	{
		[Token(Token = "0x6000A67")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000142")]
	public BasePathFinder PathFinder
	{
		[Token(Token = "0x6000A69")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A6A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000143")]
	public AIEvents Events
	{
		[Token(Token = "0x6000A6B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000144")]
	public global::AIDesign AIDesign
	{
		[Token(Token = "0x6000A6D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A6E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000145")]
	public global::BasePlayer DesigningPlayer
	{
		[Token(Token = "0x6000A6F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000146")]
	public global::BasePlayer OwningPlayer
	{
		[Token(Token = "0x6000A71")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A72")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00008C28 File Offset: 0x00006E28
	// (set) Token: 0x06000EDA RID: 3802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000147")]
	public bool IsGroupLeader
	{
		[Token(Token = "0x6000A73")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00008C40 File Offset: 0x00006E40
	// (set) Token: 0x06000EDC RID: 3804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000148")]
	public bool IsGrouped
	{
		[Token(Token = "0x6000A75")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A76")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000149")]
	public IAIGroupable GroupLeader
	{
		[Token(Token = "0x6000A77")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00008C58 File Offset: 0x00006E58
	[Token(Token = "0x6000A79")]
	private bool CanPlayerDesignAI(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00008C70 File Offset: 0x00006E70
	[Token(Token = "0x6000A7A")]
	private bool PlayerCanDesignAI(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7B")]
	public void EventTriggeredStateChange(int newStateContainerID, int sourceEventID)
	{
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7C")]
	public BaseAIBrain()
	{
	}

	// Token: 0x0400093A RID: 2362
	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x0")]
	public bool UseQueuedMovementUpdates;

	// Token: 0x0400093B RID: 2363
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x0")]
	public bool AllowedToSleep;

	// Token: 0x0400093C RID: 2364
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x0")]
	public AIDesignSO DefaultDesignSO;

	// Token: 0x0400093D RID: 2365
	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x0")]
	public List<AIDesignSO> Designs;

	// Token: 0x0400093E RID: 2366
	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x0")]
	public ProtoBuf.AIDesign InstanceSpecificDesign;

	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x0")]
	public float SenseRange;

	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x0")]
	public float AttackRangeMultiplier;

	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x0")]
	public float TargetLostRange;

	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x0")]
	public float VisionCone;

	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x0")]
	public bool CheckVisionCone;

	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x0")]
	public bool CheckLOS;

	// Token: 0x04000945 RID: 2373
	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x0")]
	public bool IgnoreNonVisionSneakers;

	// Token: 0x04000946 RID: 2374
	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x0")]
	public float ListenRange;

	// Token: 0x04000947 RID: 2375
	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x0")]
	public EntityType SenseTypes;

	// Token: 0x04000948 RID: 2376
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x0")]
	public bool HostileTargetsOnly;

	// Token: 0x04000949 RID: 2377
	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x0")]
	public bool IgnoreSafeZonePlayers;

	// Token: 0x0400094A RID: 2378
	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x0")]
	public int MaxGroupSize;

	// Token: 0x0400094B RID: 2379
	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x0")]
	public float MemoryDuration;

	// Token: 0x0400094C RID: 2380
	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x0")]
	public bool RefreshKnownLOS;

	// Token: 0x0400094D RID: 2381
	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BaseAIBrain<T>.BasicAIState <CurrentState>k__BackingField;

	// Token: 0x0400094E RID: 2382
	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 mainInterestPoint;

	// Token: 0x0400094F RID: 2383
	[Token(Token = "0x40007E8")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AIThinkMode <ThinkMode>k__BackingField;

	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x40007E9")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <Age>k__BackingField;

	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AIBrainSenses <Senses>k__BackingField;

	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BasePathFinder <PathFinder>k__BackingField;

	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0x0")]
	public bool UseAIDesign;

	// Token: 0x04000954 RID: 2388
	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AIEvents <Events>k__BackingField;

	// Token: 0x04000955 RID: 2389
	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private global::AIDesign <AIDesign>k__BackingField;

	// Token: 0x04000956 RID: 2390
	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private global::BasePlayer <DesigningPlayer>k__BackingField;

	// Token: 0x04000957 RID: 2391
	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private global::BasePlayer <OwningPlayer>k__BackingField;

	// Token: 0x04000958 RID: 2392
	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <IsGroupLeader>k__BackingField;

	// Token: 0x04000959 RID: 2393
	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <IsGrouped>k__BackingField;

	// Token: 0x0400095A RID: 2394
	[Token(Token = "0x40007F3")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private IAIGroupable <GroupLeader>k__BackingField;

	// Token: 0x0400095B RID: 2395
	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x0")]
	public bool Pet;

	// Token: 0x0400095C RID: 2396
	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x0")]
	private List<IAIGroupable> groupMembers;

	// Token: 0x020000EB RID: 235
	[Token(Token = "0x2000A90")]
	public class BasicAIState
	{
		// Token: 0x06000EE3 RID: 3811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF6")]
		public BasicAIState()
		{
		}
	}
}
