using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000620 RID: 1568
[Token(Token = "0x2000493")]
public class AnimatorLOD : LODComponent
{
	// Token: 0x06002B28 RID: 11048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600242F")]
	[Address(RVA = "0x832C00", Offset = "0x831A00", VA = "0x180832C00", Slot = "8")]
	protected override void InitLOD()
	{
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002430")]
	[Address(RVA = "0x542D80", Offset = "0x541B80", VA = "0x180542D80", Slot = "9")]
	protected override void EnableLOD()
	{
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002431")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "10")]
	protected override void DisableLOD()
	{
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002432")]
	[Address(RVA = "0x832C50", Offset = "0x831A50", VA = "0x180832C50", Slot = "13")]
	protected override void Show()
	{
	}

	// Token: 0x06002B2C RID: 11052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002433")]
	[Address(RVA = "0x832B70", Offset = "0x831970", VA = "0x180832B70", Slot = "14")]
	protected override void Hide()
	{
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002434")]
	[Address(RVA = "0x542E50", Offset = "0x541C50", VA = "0x180542E50", Slot = "12")]
	protected override void SetLOD(int newlod)
	{
	}

	// Token: 0x06002B2E RID: 11054 RVA: 0x00012B10 File Offset: 0x00010D10
	[Token(Token = "0x6002435")]
	[Address(RVA = "0x542D90", Offset = "0x541B90", VA = "0x180542D90", Slot = "11")]
	protected override int GetLOD(float distance)
	{
		return 0;
	}

	// Token: 0x06002B2F RID: 11055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002436")]
	[Address(RVA = "0x832CE0", Offset = "0x831AE0", VA = "0x180832CE0")]
	public AnimatorLOD()
	{
	}

	// Token: 0x04002691 RID: 9873
	[Token(Token = "0x4001F70")]
	[FieldOffset(Offset = "0x80")]
	public float Distance;

	// Token: 0x04002692 RID: 9874
	[Token(Token = "0x4001F71")]
	[FieldOffset(Offset = "0x88")]
	private Animator animator;

	// Token: 0x04002693 RID: 9875
	[Token(Token = "0x4001F72")]
	[FieldOffset(Offset = "0x90")]
	private int curlod;

	// Token: 0x04002694 RID: 9876
	[Token(Token = "0x4001F73")]
	[FieldOffset(Offset = "0x94")]
	private bool force;
}
