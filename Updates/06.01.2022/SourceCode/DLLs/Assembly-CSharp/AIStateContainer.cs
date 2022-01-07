using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x0200045D RID: 1117
[Token(Token = "0x2000336")]
public class AIStateContainer
{
	// Token: 0x1700027F RID: 639
	// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
	// (set) Token: 0x060022A2 RID: 8866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700024F")]
	public int ID
	{
		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x451780", Offset = "0x450580", VA = "0x180451780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x49F890", Offset = "0x49E690", VA = "0x18049F890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
	// (set) Token: 0x060022A4 RID: 8868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000250")]
	public AIState State
	{
		[Token(Token = "0x6001C57")]
		[Address(RVA = "0x49F880", Offset = "0x49E680", VA = "0x18049F880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return AIState.None;
		}
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0x49F8A0", Offset = "0x49E6A0", VA = "0x18049F8A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0000FA08 File Offset: 0x0000DC08
	// (set) Token: 0x060022A6 RID: 8870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000251")]
	public int InputMemorySlot
	{
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x4FFD00", Offset = "0x4FEB00", VA = "0x1804FFD00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001C5A")]
		[Address(RVA = "0x4FFD20", Offset = "0x4FEB20", VA = "0x1804FFD20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x816950", Offset = "0x815750", VA = "0x180816950")]
	public void Init(ProtoBuf.AIStateContainer container, global::BaseEntity owner)
	{
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x816B40", Offset = "0x815940", VA = "0x180816B40")]
	public ProtoBuf.AIStateContainer ToProto()
	{
		return null;
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x816D00", Offset = "0x815B00", VA = "0x180816D00")]
	public AIStateContainer()
	{
	}

	// Token: 0x04001D36 RID: 7478
	[Token(Token = "0x40017D9")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <ID>k__BackingField;

	// Token: 0x04001D37 RID: 7479
	[Token(Token = "0x40017DA")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AIState <State>k__BackingField;

	// Token: 0x04001D38 RID: 7480
	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0x18")]
	public List<BaseAIEvent> Events;

	// Token: 0x04001D39 RID: 7481
	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <InputMemorySlot>k__BackingField;
}
