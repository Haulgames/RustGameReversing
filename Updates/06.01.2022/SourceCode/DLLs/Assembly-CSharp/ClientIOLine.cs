using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000255 RID: 597
[Token(Token = "0x2000199")]
public class ClientIOLine : BaseMonoBehaviour
{
	// Token: 0x060018AA RID: 6314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001350")]
	[Address(RVA = "0x480430", Offset = "0x47F230", VA = "0x180480430")]
	public void SetIOEntityOwner(IOEntity newOwner)
	{
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001351")]
	[Address(RVA = "0x4E10B0", Offset = "0x4DFEB0", VA = "0x1804E10B0")]
	public void OnEnable()
	{
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001352")]
	[Address(RVA = "0x4E1020", Offset = "0x4DFE20", VA = "0x1804E1020")]
	public void OnDisable()
	{
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001353")]
	[Address(RVA = "0x4E11B0", Offset = "0x4DFFB0", VA = "0x1804E11B0")]
	public static void SetDirectionVisibleAll(bool isVisible, IOEntity.IOType forType)
	{
	}

	// Token: 0x060018AE RID: 6318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001354")]
	[Address(RVA = "0x4E1310", Offset = "0x4E0110", VA = "0x1804E1310")]
	public static void SetDirectionVisibleSingle(bool isVisible, ClientIOLine line)
	{
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001355")]
	[Address(RVA = "0x4E0AF0", Offset = "0x4DF8F0", VA = "0x1804E0AF0")]
	public void Clear()
	{
	}

	// Token: 0x060018B0 RID: 6320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001356")]
	[Address(RVA = "0x4E0B20", Offset = "0x4DF920", VA = "0x1804E0B20")]
	public void DelayedDirectionTest()
	{
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001357")]
	[Address(RVA = "0x4E1490", Offset = "0x4E0290", VA = "0x1804E1490")]
	public void SetDirectionVisible(bool isVisible)
	{
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001358")]
	[Address(RVA = "0x4E17A0", Offset = "0x4E05A0", VA = "0x1804E17A0")]
	public void SetVisible(bool isVisible)
	{
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001359")]
	[Address(RVA = "0x4E1640", Offset = "0x4E0440", VA = "0x1804E1640")]
	public void SetLineCullDistance(float length)
	{
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135A")]
	[Address(RVA = "0x4E1690", Offset = "0x4E0490", VA = "0x1804E1690")]
	public void SetPositions(Vector3[] positions, float[] slackLevels)
	{
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x4E03E0", Offset = "0x4DF1E0", VA = "0x1804E03E0")]
	public static void ApplyLineSlack(ref Vector3[] positions, float[] slackLevels)
	{
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x4E0460", Offset = "0x4DF260", VA = "0x1804E0460")]
	public static void ApplyLineSlack(Vector3[] positions, float[] slackLevels, ref Vector3[] result)
	{
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x4E02F0", Offset = "0x4DF0F0", VA = "0x1804E02F0")]
	public void AddPosition(Vector3 worldPos)
	{
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135E")]
	[Address(RVA = "0x4E1570", Offset = "0x4E0370", VA = "0x1804E1570")]
	public void SetLastNodePosition(Vector3 worldPos)
	{
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135F")]
	[Address(RVA = "0x4E1140", Offset = "0x4DFF40", VA = "0x1804E1140")]
	public void RemoveLastPosition()
	{
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
	[Token(Token = "0x6001360")]
	[Address(RVA = "0x4E0E70", Offset = "0x4DFC70", VA = "0x1804E0E70")]
	public float GetLength()
	{
		return 0f;
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001361")]
	[Address(RVA = "0x4E1850", Offset = "0x4E0650", VA = "0x1804E1850")]
	public void UpdateBoundsAndPosition()
	{
	}

	// Token: 0x060018BC RID: 6332 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
	[Token(Token = "0x6001362")]
	[Address(RVA = "0x4E0D60", Offset = "0x4DFB60", VA = "0x1804E0D60")]
	public Vector3 GetLastPlacedNodePosition()
	{
		return default(Vector3);
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x060018BD RID: 6333 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
	[Token(Token = "0x17000194")]
	public int PositionCount
	{
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x4E18D0", Offset = "0x4E06D0", VA = "0x1804E18D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001364")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public ClientIOLine()
	{
	}

	// Token: 0x040012EA RID: 4842
	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x18")]
	public RendererLOD _lod;

	// Token: 0x040012EB RID: 4843
	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x20")]
	public LineRenderer _line;

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0x28")]
	public Material directionalMaterial;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x30")]
	public Material defaultMaterial;

	// Token: 0x040012EE RID: 4846
	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x38")]
	public IOEntity.IOType lineType;

	// Token: 0x040012EF RID: 4847
	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0x0")]
	public static List<ClientIOLine> _allLines;

	// Token: 0x040012F0 RID: 4848
	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x3C")]
	public WireTool.WireColour colour;

	// Token: 0x040012F1 RID: 4849
	[Token(Token = "0x4000F7D")]
	[FieldOffset(Offset = "0x40")]
	public IOEntity ownerIOEnt;
}
