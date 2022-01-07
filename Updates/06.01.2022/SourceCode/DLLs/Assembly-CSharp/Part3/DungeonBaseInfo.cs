using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007B0 RID: 1968
[Token(Token = "0x20005B7")]
public class DungeonBaseInfo : LandmarkInfo
{
	// Token: 0x0600312A RID: 12586 RVA: 0x000150A8 File Offset: 0x000132A8
	[Token(Token = "0x6002980")]
	[Address(RVA = "0x97F350", Offset = "0x97E150", VA = "0x18097F350")]
	public float Distance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x0600312B RID: 12587 RVA: 0x000150C0 File Offset: 0x000132C0
	[Token(Token = "0x6002981")]
	[Address(RVA = "0x97F430", Offset = "0x97E230", VA = "0x18097F430")]
	public float SqrDistance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x0600312C RID: 12588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002982")]
	[Address(RVA = "0x97EF20", Offset = "0x97DD20", VA = "0x18097EF20")]
	public void Add(DungeonBaseLink link)
	{
	}

	// Token: 0x0600312D RID: 12589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002983")]
	[Address(RVA = "0x97F260", Offset = "0x97E060", VA = "0x18097F260", Slot = "5")]
	protected override void Awake()
	{
	}

	// Token: 0x0600312E RID: 12590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002984")]
	[Address(RVA = "0x97F510", Offset = "0x97E310", VA = "0x18097F510")]
	protected void Start()
	{
	}

	// Token: 0x0600312F RID: 12591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002985")]
	[Address(RVA = "0x97F710", Offset = "0x97E510", VA = "0x18097F710")]
	public DungeonBaseInfo()
	{
	}

	// Token: 0x06003130 RID: 12592 RVA: 0x000150D8 File Offset: 0x000132D8
	[Token(Token = "0x6002986")]
	[Address(RVA = "0x97F570", Offset = "0x97E370", VA = "0x18097F570")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <Add>b__4_0(DungeonBaseFloor l, DungeonBaseFloor r)
	{
		return 0;
	}

	// Token: 0x04002DFF RID: 11775
	[Token(Token = "0x4002453")]
	[FieldOffset(Offset = "0x30")]
	internal List<GameObject> Links;

	// Token: 0x04002E00 RID: 11776
	[Token(Token = "0x4002454")]
	[FieldOffset(Offset = "0x38")]
	internal List<DungeonBaseFloor> Floors;
}
