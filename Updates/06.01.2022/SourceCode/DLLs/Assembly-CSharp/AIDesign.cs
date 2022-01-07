using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x02000432 RID: 1074
[Token(Token = "0x200030C")]
public class AIDesign
{
	// Token: 0x17000261 RID: 609
	// (get) Token: 0x06002218 RID: 8728 RVA: 0x0000F708 File Offset: 0x0000D908
	// (set) Token: 0x06002219 RID: 8729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000231")]
	public AIDesignScope Scope
	{
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x451780", Offset = "0x450580", VA = "0x180451780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return AIDesignScope.Default;
		}
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x49F890", Offset = "0x49E690", VA = "0x18049F890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x0600221A RID: 8730 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600221B RID: 8731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000232")]
	public string Description
	{
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x484E20", Offset = "0x483C20", VA = "0x180484E20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x8129C0", Offset = "0x8117C0", VA = "0x1808129C0")]
	public void SetAvailableStates(List<AIState> states)
	{
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x812960", Offset = "0x811760", VA = "0x180812960")]
	public void Load(ProtoBuf.AIDesign design, global::BaseEntity owner)
	{
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x8127B0", Offset = "0x8115B0", VA = "0x1808127B0")]
	private void InitStateContainers(ProtoBuf.AIDesign design, global::BaseEntity owner)
	{
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD3")]
	[Address(RVA = "0x8126B0", Offset = "0x8114B0", VA = "0x1808126B0")]
	public global::AIStateContainer GetDefaultStateContainer()
	{
		return null;
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x812730", Offset = "0x811530", VA = "0x180812730")]
	public global::AIStateContainer GetStateContainerByID(int id)
	{
		return null;
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x812A50", Offset = "0x811850", VA = "0x180812A50")]
	public ProtoBuf.AIDesign ToProto(int currentStateID)
	{
		return null;
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0x812D80", Offset = "0x811B80", VA = "0x180812D80")]
	public AIDesign()
	{
	}

	// Token: 0x04001CD2 RID: 7378
	[Token(Token = "0x400177A")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private AIDesignScope <Scope>k__BackingField;

	// Token: 0x04001CD3 RID: 7379
	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private string <Description>k__BackingField;

	// Token: 0x04001CD4 RID: 7380
	[Token(Token = "0x400177C")]
	[FieldOffset(Offset = "0x20")]
	public List<AIState> AvailableStates;

	// Token: 0x04001CD5 RID: 7381
	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0x28")]
	public int DefaultStateContainerID;

	// Token: 0x04001CD6 RID: 7382
	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, global::AIStateContainer> stateContainers;
}
