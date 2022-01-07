using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020002FD RID: 765
[Token(Token = "0x2000216")]
public class ConstructionGrade : PrefabAttribute
{
	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0000DA88 File Offset: 0x0000BC88
	[Token(Token = "0x170001DA")]
	public float maxHealth
	{
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x6C7D30", Offset = "0x6C6B30", VA = "0x1806C7D30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001DB")]
	public List<ItemAmount> costToBuild
	{
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x6C7AE0", Offset = "0x6C68E0", VA = "0x1806C7AE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001664")]
	[Address(RVA = "0x6C7A20", Offset = "0x6C6820", VA = "0x1806C7A20", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001665")]
	[Address(RVA = "0x6C7A80", Offset = "0x6C6880", VA = "0x1806C7A80")]
	public ConstructionGrade()
	{
	}

	// Token: 0x040016EC RID: 5868
	[Token(Token = "0x40012BB")]
	[FieldOffset(Offset = "0x98")]
	[NonSerialized]
	public Construction construction;

	// Token: 0x040016ED RID: 5869
	[Token(Token = "0x40012BC")]
	[FieldOffset(Offset = "0xA0")]
	public BuildingGrade gradeBase;

	// Token: 0x040016EE RID: 5870
	[Token(Token = "0x40012BD")]
	[FieldOffset(Offset = "0xA8")]
	public GameObjectRef skinObject;

	// Token: 0x040016EF RID: 5871
	[Token(Token = "0x40012BE")]
	[FieldOffset(Offset = "0xB0")]
	internal List<ItemAmount> _costToBuild;
}
