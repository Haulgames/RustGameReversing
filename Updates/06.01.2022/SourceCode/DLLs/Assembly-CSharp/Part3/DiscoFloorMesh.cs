using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000470 RID: 1136
[Token(Token = "0x2000347")]
public class DiscoFloorMesh : MonoBehaviour, IClientComponent
{
	// Token: 0x060022FD RID: 8957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0xB73EF0", Offset = "0xB72CF0", VA = "0x180B73EF0")]
	public void BuildMesh()
	{
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x060022FE RID: 8958 RVA: 0x0000FC30 File Offset: 0x0000DE30
	[Token(Token = "0x17000261")]
	public int NumTiles
	{
		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0xB74770", Offset = "0xB73570", VA = "0x180B74770")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0xB73EF0", Offset = "0xB72CF0", VA = "0x180B73EF0")]
	private void SetupRuntimeMesh()
	{
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0xB73E30", Offset = "0xB72C30", VA = "0x180B73E30")]
	public void ApplyColourGradient(Gradient gradient, float offset, DiscoFloorMesh.PatternType pattern, DiscoFloorColourLookups lookups)
	{
	}

	// Token: 0x06002301 RID: 8961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0xB73C20", Offset = "0xB72A20", VA = "0x180B73C20")]
	private void ApplyColourGradient(Gradient gradient, float offset, float[] colourLookup)
	{
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0xB744A0", Offset = "0xB732A0", VA = "0x180B744A0")]
	public void SetColour(Color c)
	{
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x0000FC48 File Offset: 0x0000DE48
	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0xB74220", Offset = "0xB73020", VA = "0x180B74220")]
	public Color SampleColor(DiscoFloorMesh.Corner corner)
	{
		return default(Color);
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x0000FC60 File Offset: 0x0000DE60
	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0xB740E0", Offset = "0xB72EE0", VA = "0x180B740E0")]
	private Color SampleColor(int index1, int index2, int index3)
	{
		return default(Color);
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0xB73FC0", Offset = "0xB72DC0", VA = "0x180B73FC0")]
	private void GetCornerTileIndexes(DiscoFloorMesh.Corner corner, out int index1, out int index2, out int index3)
	{
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0xB74590", Offset = "0xB73390", VA = "0x180B74590")]
	public void ToggleEmission(bool state)
	{
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0xB746C0", Offset = "0xB734C0", VA = "0x180B746C0")]
	public DiscoFloorMesh()
	{
	}

	// Token: 0x04001D85 RID: 7557
	[Token(Token = "0x400181E")]
	[FieldOffset(Offset = "0x18")]
	public int GridRows;

	// Token: 0x04001D86 RID: 7558
	[Token(Token = "0x400181F")]
	[FieldOffset(Offset = "0x1C")]
	public int GridColumns;

	// Token: 0x04001D87 RID: 7559
	[Token(Token = "0x4001820")]
	[FieldOffset(Offset = "0x20")]
	public float GridSize;

	// Token: 0x04001D88 RID: 7560
	[Token(Token = "0x4001821")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x846B0", Offset = "0x83AB0")]
	public float TestOffset;

	// Token: 0x04001D89 RID: 7561
	[Token(Token = "0x4001822")]
	[FieldOffset(Offset = "0x28")]
	public Color OffColor;

	// Token: 0x04001D8A RID: 7562
	[Token(Token = "0x4001823")]
	[FieldOffset(Offset = "0x38")]
	public MeshRenderer Renderer;

	// Token: 0x04001D8B RID: 7563
	[Token(Token = "0x4001824")]
	[FieldOffset(Offset = "0x40")]
	public bool DrawInEditor;

	// Token: 0x04001D8C RID: 7564
	[Token(Token = "0x4001825")]
	[FieldOffset(Offset = "0x48")]
	public MeshFilter Filter;

	// Token: 0x04001D8D RID: 7565
	[Token(Token = "0x4001826")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve customCurveX;

	// Token: 0x04001D8E RID: 7566
	[Token(Token = "0x4001827")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve customCurveY;

	// Token: 0x04001D8F RID: 7567
	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0x0")]
	private static int powerId;

	// Token: 0x04001D90 RID: 7568
	[Token(Token = "0x4001829")]
	[FieldOffset(Offset = "0x60")]
	private Mesh builtMesh;

	// Token: 0x04001D91 RID: 7569
	[Token(Token = "0x400182A")]
	[FieldOffset(Offset = "0x68")]
	private Color[] colourArray;

	// Token: 0x02000471 RID: 1137
	[Token(Token = "0x2000B5E")]
	public enum PatternType
	{
		// Token: 0x04001D93 RID: 7571
		[Token(Token = "0x400427E")]
		InOut,
		// Token: 0x04001D94 RID: 7572
		[Token(Token = "0x400427F")]
		Radial,
		// Token: 0x04001D95 RID: 7573
		[Token(Token = "0x4004280")]
		Ripple,
		// Token: 0x04001D96 RID: 7574
		[Token(Token = "0x4004281")]
		Checker,
		// Token: 0x04001D97 RID: 7575
		[Token(Token = "0x4004282")]
		Block
	}

	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x2000B5F")]
	public enum Corner
	{
		// Token: 0x04001D99 RID: 7577
		[Token(Token = "0x4004284")]
		TopLeft,
		// Token: 0x04001D9A RID: 7578
		[Token(Token = "0x4004285")]
		TopRight,
		// Token: 0x04001D9B RID: 7579
		[Token(Token = "0x4004286")]
		BottomLeft,
		// Token: 0x04001D9C RID: 7580
		[Token(Token = "0x4004287")]
		BottomRight
	}
}
