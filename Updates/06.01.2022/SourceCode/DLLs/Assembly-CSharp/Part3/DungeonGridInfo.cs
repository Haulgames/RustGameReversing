using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007BC RID: 1980
[Token(Token = "0x20005C3")]
public class DungeonGridInfo : LandmarkInfo
{
	// Token: 0x06003141 RID: 12609 RVA: 0x00015168 File Offset: 0x00013368
	[Token(Token = "0x6002997")]
	[Address(RVA = "0x9800C0", Offset = "0x97EEC0", VA = "0x1809800C0")]
	public float Distance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x06003142 RID: 12610 RVA: 0x00015180 File Offset: 0x00013380
	[Token(Token = "0x6002998")]
	[Address(RVA = "0x980500", Offset = "0x97F300", VA = "0x180980500")]
	public float SqrDistance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x06003143 RID: 12611 RVA: 0x00015198 File Offset: 0x00013398
	[Token(Token = "0x6002999")]
	[Address(RVA = "0x9801A0", Offset = "0x97EFA0", VA = "0x1809801A0")]
	public bool IsValidSpawnPosition(Vector3 position)
	{
		return default(bool);
	}

	// Token: 0x06003144 RID: 12612 RVA: 0x000151B0 File Offset: 0x000133B0
	[Token(Token = "0x600299A")]
	[Address(RVA = "0x9803E0", Offset = "0x97F1E0", VA = "0x1809803E0")]
	public Vector3 SnapPosition(Vector3 pos)
	{
		return default(Vector3);
	}

	// Token: 0x06003145 RID: 12613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299B")]
	[Address(RVA = "0x97FFD0", Offset = "0x97EDD0", VA = "0x18097FFD0", Slot = "5")]
	protected override void Awake()
	{
	}

	// Token: 0x06003146 RID: 12614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299C")]
	[Address(RVA = "0x9805E0", Offset = "0x97F3E0", VA = "0x1809805E0")]
	protected void Start()
	{
	}

	// Token: 0x06003147 RID: 12615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600299D")]
	[Address(RVA = "0x980640", Offset = "0x97F440", VA = "0x180980640")]
	public DungeonGridInfo()
	{
	}

	// Token: 0x04002E30 RID: 11824
	[Token(Token = "0x4002484")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x9C600", Offset = "0x9BA00")]
	public int CellSize;

	// Token: 0x04002E31 RID: 11825
	[Token(Token = "0x4002485")]
	[FieldOffset(Offset = "0x34")]
	public float LinkHeight;

	// Token: 0x04002E32 RID: 11826
	[Token(Token = "0x4002486")]
	[FieldOffset(Offset = "0x38")]
	public float LinkRadius;

	// Token: 0x04002E33 RID: 11827
	[Token(Token = "0x4002487")]
	[FieldOffset(Offset = "0x40")]
	internal List<GameObject> Links;
}
