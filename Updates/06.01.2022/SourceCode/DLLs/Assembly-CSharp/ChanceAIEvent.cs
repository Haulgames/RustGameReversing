using System;
using Il2CppDummyDll;
using ProtoBuf;

// Token: 0x02000443 RID: 1091
[Token(Token = "0x200031C")]
public class ChanceAIEvent : BaseAIEvent
{
	// Token: 0x17000272 RID: 626
	// (get) Token: 0x06002260 RID: 8800 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
	// (set) Token: 0x06002261 RID: 8801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000242")]
	public float Chance
	{
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x2F9870", Offset = "0x2F8670", VA = "0x1802F9870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x2F98E0", Offset = "0x2F86E0", VA = "0x1802F98E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x4D88A0", Offset = "0x4D76A0", VA = "0x1804D88A0")]
	public ChanceAIEvent()
	{
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x4D87C0", Offset = "0x4D75C0", VA = "0x1804D87C0", Slot = "4")]
	public override void Init(AIEventData data, global::BaseEntity owner)
	{
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x4D8800", Offset = "0x4D7600", VA = "0x1804D8800", Slot = "6")]
	public override AIEventData ToProto()
	{
		return null;
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C19")]
	[Address(RVA = "0x4D8780", Offset = "0x4D7580", VA = "0x1804D8780", Slot = "8")]
	public override void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus)
	{
	}

	// Token: 0x04001D24 RID: 7460
	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <Chance>k__BackingField;
}
