using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200062A RID: 1578
[Token(Token = "0x200049B")]
public class CanvasLOD : LODComponent
{
	// Token: 0x06002B8B RID: 11147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002486")]
	[Address(RVA = "0x64E900", Offset = "0x64D700", VA = "0x18064E900", Slot = "8")]
	protected override void InitLOD()
	{
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002487")]
	[Address(RVA = "0x542D80", Offset = "0x541B80", VA = "0x180542D80", Slot = "9")]
	protected override void EnableLOD()
	{
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002488")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "10")]
	protected override void DisableLOD()
	{
	}

	// Token: 0x06002B8E RID: 11150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002489")]
	[Address(RVA = "0x64E950", Offset = "0x64D750", VA = "0x18064E950", Slot = "13")]
	protected override void Show()
	{
	}

	// Token: 0x06002B8F RID: 11151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600248A")]
	[Address(RVA = "0x64E870", Offset = "0x64D670", VA = "0x18064E870", Slot = "14")]
	protected override void Hide()
	{
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600248B")]
	[Address(RVA = "0x542E50", Offset = "0x541C50", VA = "0x180542E50", Slot = "12")]
	protected override void SetLOD(int newlod)
	{
	}

	// Token: 0x06002B91 RID: 11153 RVA: 0x00012D08 File Offset: 0x00010F08
	[Token(Token = "0x600248C")]
	[Address(RVA = "0x542D90", Offset = "0x541B90", VA = "0x180542D90", Slot = "11")]
	protected override int GetLOD(float distance)
	{
		return 0;
	}

	// Token: 0x06002B92 RID: 11154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600248D")]
	[Address(RVA = "0x64E9E0", Offset = "0x64D7E0", VA = "0x18064E9E0")]
	public CanvasLOD()
	{
	}

	// Token: 0x040026C6 RID: 9926
	[Token(Token = "0x4001F96")]
	[FieldOffset(Offset = "0x80")]
	public float Distance;

	// Token: 0x040026C7 RID: 9927
	[Token(Token = "0x4001F97")]
	[FieldOffset(Offset = "0x88")]
	private Canvas canvas;

	// Token: 0x040026C8 RID: 9928
	[Token(Token = "0x4001F98")]
	[FieldOffset(Offset = "0x90")]
	private int curlod;

	// Token: 0x040026C9 RID: 9929
	[Token(Token = "0x4001F99")]
	[FieldOffset(Offset = "0x94")]
	private bool force;
}
