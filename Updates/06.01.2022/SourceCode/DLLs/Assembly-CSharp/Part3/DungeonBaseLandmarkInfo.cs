using System;
using Il2CppDummyDll;

// Token: 0x020007B2 RID: 1970
[Token(Token = "0x20005B9")]
[Attribute(Name = "RequireComponent", RVA = "0x9B1B0", Offset = "0x9A5B0")]
public class DungeonBaseLandmarkInfo : LandmarkInfo
{
	// Token: 0x06003134 RID: 12596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600298A")]
	[Address(RVA = "0x97F7B0", Offset = "0x97E5B0", VA = "0x18097F7B0", Slot = "5")]
	protected override void Awake()
	{
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x06003135 RID: 12597 RVA: 0x00015120 File Offset: 0x00013320
	[Token(Token = "0x17000382")]
	public override MapLayer MapLayer
	{
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x97F810", Offset = "0x97E610", VA = "0x18097F810", Slot = "4")]
		get
		{
			return MapLayer.TrainTunnels;
		}
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600298C")]
	[Address(RVA = "0x2F6C50", Offset = "0x2F5A50", VA = "0x1802F6C50")]
	public DungeonBaseLandmarkInfo()
	{
	}

	// Token: 0x04002E02 RID: 11778
	[Token(Token = "0x4002456")]
	[FieldOffset(Offset = "0x30")]
	private DungeonBaseLink baseLink;

	// Token: 0x04002E03 RID: 11779
	[Token(Token = "0x4002457")]
	[FieldOffset(Offset = "0x38")]
	private MapLayer? layer;
}
