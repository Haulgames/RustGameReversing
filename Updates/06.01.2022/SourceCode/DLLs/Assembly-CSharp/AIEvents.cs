using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000435 RID: 1077
[Token(Token = "0x200030F")]
public class AIEvents
{
	// Token: 0x17000263 RID: 611
	// (get) Token: 0x06002227 RID: 8743 RVA: 0x0000F720 File Offset: 0x0000D920
	// (set) Token: 0x06002228 RID: 8744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000233")]
	public int CurrentInputMemorySlot
	{
		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x67F4E0", Offset = "0x67E2E0", VA = "0x18067F4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x813B90", Offset = "0x812990", VA = "0x180813B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x813630", Offset = "0x812430", VA = "0x180813630")]
	public void Init(IAIEventListener listener, AIStateContainer stateContainer, BaseEntity owner, AIBrainSenses senses)
	{
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x813720", Offset = "0x812520", VA = "0x180813720")]
	private void RemoveAll()
	{
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDF")]
	[Address(RVA = "0x813240", Offset = "0x812040", VA = "0x180813240")]
	private void AddStateEvents(List<BaseAIEvent> events, BaseEntity owner)
	{
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x813440", Offset = "0x812240", VA = "0x180813440")]
	private void Add(BaseAIEvent aiEvent)
	{
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x813770", Offset = "0x812570", VA = "0x180813770")]
	public void Tick(float deltaTime, StateStatus stateStatus)
	{
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x0000F738 File Offset: 0x0000D938
	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x813540", Offset = "0x812340", VA = "0x180813540")]
	private int FindNextEventBlock()
	{
		return 0;
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x813A30", Offset = "0x812830", VA = "0x180813A30")]
	public AIEvents()
	{
	}

	// Token: 0x04001CF4 RID: 7412
	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x10")]
	public AIMemory Memory;

	// Token: 0x04001CF5 RID: 7413
	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <CurrentInputMemorySlot>k__BackingField;

	// Token: 0x04001CF6 RID: 7414
	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x20")]
	private List<BaseAIEvent> events;

	// Token: 0x04001CF7 RID: 7415
	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x28")]
	private IAIEventListener eventListener;

	// Token: 0x04001CF8 RID: 7416
	[Token(Token = "0x40017A0")]
	[FieldOffset(Offset = "0x30")]
	private AIBrainSenses senses;

	// Token: 0x04001CF9 RID: 7417
	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x38")]
	private int currentEventIndex;

	// Token: 0x04001CFA RID: 7418
	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x3C")]
	private bool inBlock;
}
