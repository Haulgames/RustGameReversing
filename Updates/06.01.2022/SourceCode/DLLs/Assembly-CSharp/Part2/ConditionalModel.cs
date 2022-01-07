using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F7 RID: 759
[Token(Token = "0x2000214")]
public class ConditionalModel : PrefabAttribute
{
	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0000D950 File Offset: 0x0000BB50
	// (set) Token: 0x06001BEA RID: 7146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D8")]
	public uint targetPrefabId
	{
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x717730", Offset = "0x716530", VA = "0x180717730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x717740", Offset = "0x716540", VA = "0x180717740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001651")]
	[Address(RVA = "0x717380", Offset = "0x716180", VA = "0x180717380", Slot = "6")]
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x0000D968 File Offset: 0x0000BB68
	[Token(Token = "0x6001652")]
	[Address(RVA = "0x717610", Offset = "0x716410", VA = "0x180717610")]
	public bool RunTests(BaseEntity parent)
	{
		return default(bool);
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001653")]
	[Address(RVA = "0x7174A0", Offset = "0x7162A0", VA = "0x1807174A0")]
	public GameObject InstantiateSkin(BaseEntity parent)
	{
		return null;
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001654")]
	[Address(RVA = "0x717440", Offset = "0x716240", VA = "0x180717440", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001655")]
	[Address(RVA = "0x7176D0", Offset = "0x7164D0", VA = "0x1807176D0")]
	public ConditionalModel()
	{
	}

	// Token: 0x040016BD RID: 5821
	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0x98")]
	public GameObjectRef prefab;

	// Token: 0x040016BE RID: 5822
	[Token(Token = "0x400129F")]
	[FieldOffset(Offset = "0xA0")]
	public bool onClient;

	// Token: 0x040016BF RID: 5823
	[Token(Token = "0x40012A0")]
	[FieldOffset(Offset = "0xA1")]
	public bool onServer;

	// Token: 0x040016C0 RID: 5824
	[Token(Token = "0x40012A1")]
	[FieldOffset(Offset = "0xA8")]
	[NonSerialized]
	public ModelConditionTest[] conditions;

	// Token: 0x040016C1 RID: 5825
	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private uint <targetPrefabId>k__BackingField;
}
