using System;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x02000440 RID: 1088
[Token(Token = "0x200031A")]
public class BaseAIEvent
{
	// Token: 0x17000265 RID: 613
	// (get) Token: 0x0600223E RID: 8766 RVA: 0x0000F780 File Offset: 0x0000D980
	// (set) Token: 0x0600223F RID: 8767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000235")]
	public AIEventType EventType
	{
		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x451780", Offset = "0x450580", VA = "0x180451780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return AIEventType.Timer;
		}
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x49F890", Offset = "0x49E690", VA = "0x18049F890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x06002240 RID: 8768 RVA: 0x0000F798 File Offset: 0x0000D998
	// (set) Token: 0x06002241 RID: 8769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000236")]
	public int TriggerStateContainerID
	{
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x49F880", Offset = "0x49E680", VA = "0x18049F880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x49F8A0", Offset = "0x49E6A0", VA = "0x18049F8A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000267 RID: 615
	// (get) Token: 0x06002242 RID: 8770 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
	// (set) Token: 0x06002243 RID: 8771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000237")]
	public BaseAIEvent.ExecuteRate Rate
	{
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x67F4E0", Offset = "0x67E2E0", VA = "0x18067F4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return BaseAIEvent.ExecuteRate.Slow;
		}
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x813B90", Offset = "0x812990", VA = "0x180813B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x06002244 RID: 8772 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
	[Token(Token = "0x17000238")]
	public float ExecutionRate
	{
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x844EF0", Offset = "0x843CF0", VA = "0x180844EF0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x06002245 RID: 8773 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
	// (set) Token: 0x06002246 RID: 8774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000239")]
	public bool ShouldExecute
	{
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x844F60", Offset = "0x843D60", VA = "0x180844F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x844FB0", Offset = "0x843DB0", VA = "0x180844FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x06002247 RID: 8775 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
	// (set) Token: 0x06002248 RID: 8776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023A")]
	public bool Result
	{
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x844F50", Offset = "0x843D50", VA = "0x180844F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x844FA0", Offset = "0x843DA0", VA = "0x180844FA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x06002249 RID: 8777 RVA: 0x0000F810 File Offset: 0x0000DA10
	// (set) Token: 0x0600224A RID: 8778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023B")]
	public bool Inverted
	{
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x844F40", Offset = "0x843D40", VA = "0x180844F40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x844F90", Offset = "0x843D90", VA = "0x180844F90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x0600224B RID: 8779 RVA: 0x0000F828 File Offset: 0x0000DA28
	// (set) Token: 0x0600224C RID: 8780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023C")]
	public int OutputEntityMemorySlot
	{
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x4FFD00", Offset = "0x4FEB00", VA = "0x1804FFD00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x4FFD20", Offset = "0x4FEB20", VA = "0x1804FFD20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x0600224D RID: 8781 RVA: 0x0000F840 File Offset: 0x0000DA40
	[Token(Token = "0x1700023D")]
	public bool ShouldSetOutputEntityMemory
	{
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x844F70", Offset = "0x843D70", VA = "0x180844F70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x0600224E RID: 8782 RVA: 0x0000F858 File Offset: 0x0000DA58
	// (set) Token: 0x0600224F RID: 8783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023E")]
	public int InputEntityMemorySlot
	{
		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x799D80", Offset = "0x798B80", VA = "0x180799D80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x799DA0", Offset = "0x798BA0", VA = "0x180799DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x06002250 RID: 8784 RVA: 0x0000F870 File Offset: 0x0000DA70
	// (set) Token: 0x06002251 RID: 8785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023F")]
	public int ID
	{
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x679AC0", Offset = "0x6788C0", VA = "0x180679AC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x844F80", Offset = "0x843D80", VA = "0x180844F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x06002252 RID: 8786 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002253 RID: 8787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000240")]
	public global::BaseEntity Owner
	{
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x326940", Offset = "0x325740", VA = "0x180326940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x442C90", Offset = "0x441A90", VA = "0x180442C90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x06002254 RID: 8788 RVA: 0x0000F888 File Offset: 0x0000DA88
	[Token(Token = "0x17000241")]
	public bool HasValidTriggerState
	{
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x844F30", Offset = "0x843D30", VA = "0x180844F30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C09")]
	[Address(RVA = "0x844EB0", Offset = "0x843CB0", VA = "0x180844EB0")]
	public BaseAIEvent(AIEventType type)
	{
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C0A")]
	[Address(RVA = "0x844C50", Offset = "0x843A50", VA = "0x180844C50", Slot = "4")]
	public virtual void Init(AIEventData data, global::BaseEntity owner)
	{
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0x844CA0", Offset = "0x843AA0", VA = "0x180844CA0", Slot = "5")]
	public virtual void Init(int triggerStateContainer, int id, global::BaseEntity owner, int inputMemorySlot, int outputMemorySlot, bool inverted)
	{
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C0C")]
	[Address(RVA = "0x844D70", Offset = "0x843B70", VA = "0x180844D70", Slot = "6")]
	public virtual AIEventData ToProto()
	{
		return null;
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C0D")]
	[Address(RVA = "0x844CF0", Offset = "0x843AF0", VA = "0x180844CF0", Slot = "7")]
	public virtual void Reset()
	{
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C0E")]
	[Address(RVA = "0x844D00", Offset = "0x843B00", VA = "0x180844D00")]
	public void Tick(float deltaTime, IAIEventListener listener)
	{
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C0F")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "8")]
	public virtual void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus)
	{
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C10")]
	[Address(RVA = "0x844CE0", Offset = "0x843AE0", VA = "0x180844CE0", Slot = "9")]
	public virtual void PostExecute()
	{
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C11")]
	[Address(RVA = "0x844DF0", Offset = "0x843BF0", VA = "0x180844DF0")]
	public void TriggerStateChange(IAIEventListener listener, int sourceEventID)
	{
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C12")]
	[Address(RVA = "0x844760", Offset = "0x843560", VA = "0x180844760")]
	public static BaseAIEvent CreateEvent(AIEventType eventType)
	{
		return null;
	}

	// Token: 0x04001D13 RID: 7443
	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AIEventType <EventType>k__BackingField;

	// Token: 0x04001D14 RID: 7444
	[Token(Token = "0x40017BC")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <TriggerStateContainerID>k__BackingField;

	// Token: 0x04001D15 RID: 7445
	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BaseAIEvent.ExecuteRate <Rate>k__BackingField;

	// Token: 0x04001D16 RID: 7446
	[Token(Token = "0x40017BE")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <ShouldExecute>k__BackingField;

	// Token: 0x04001D17 RID: 7447
	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0x1D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <Result>k__BackingField;

	// Token: 0x04001D18 RID: 7448
	[Token(Token = "0x40017C0")]
	[FieldOffset(Offset = "0x1E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <Inverted>k__BackingField;

	// Token: 0x04001D19 RID: 7449
	[Token(Token = "0x40017C1")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <OutputEntityMemorySlot>k__BackingField;

	// Token: 0x04001D1A RID: 7450
	[Token(Token = "0x40017C2")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <InputEntityMemorySlot>k__BackingField;

	// Token: 0x04001D1B RID: 7451
	[Token(Token = "0x40017C3")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <ID>k__BackingField;

	// Token: 0x04001D1C RID: 7452
	[Token(Token = "0x40017C4")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private global::BaseEntity <Owner>k__BackingField;

	// Token: 0x04001D1D RID: 7453
	[Token(Token = "0x40017C5")]
	[FieldOffset(Offset = "0x38")]
	private float executeTimer;

	// Token: 0x04001D1E RID: 7454
	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x3C")]
	protected float deltaTime;

	// Token: 0x02000441 RID: 1089
	[Token(Token = "0x2000B5B")]
	public enum ExecuteRate
	{
		// Token: 0x04001D20 RID: 7456
		[Token(Token = "0x400426F")]
		Slow,
		// Token: 0x04001D21 RID: 7457
		[Token(Token = "0x4004270")]
		Normal,
		// Token: 0x04001D22 RID: 7458
		[Token(Token = "0x4004271")]
		Fast,
		// Token: 0x04001D23 RID: 7459
		[Token(Token = "0x4004272")]
		VeryFast
	}
}
