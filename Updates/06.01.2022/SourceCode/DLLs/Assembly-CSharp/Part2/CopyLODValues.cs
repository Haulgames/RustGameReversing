using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200062C RID: 1580
[Token(Token = "0x200049D")]
public class CopyLODValues : MonoBehaviour
{
	// Token: 0x06002B99 RID: 11161 RVA: 0x00012D20 File Offset: 0x00010F20
	[Token(Token = "0x6002494")]
	[Address(RVA = "0x6D2F90", Offset = "0x6D1D90", VA = "0x1806D2F90")]
	public bool CanCopy()
	{
		return default(bool);
	}

	// Token: 0x06002B9A RID: 11162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002495")]
	[Address(RVA = "0x6D3030", Offset = "0x6D1E30", VA = "0x1806D3030")]
	public void Copy()
	{
	}

	// Token: 0x06002B9B RID: 11163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002496")]
	[Address(RVA = "0x6D32E0", Offset = "0x6D20E0", VA = "0x1806D32E0")]
	public CopyLODValues()
	{
	}

	// Token: 0x040026CD RID: 9933
	[Token(Token = "0x4001F9D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LODGroup source;

	// Token: 0x040026CE RID: 9934
	[Token(Token = "0x4001F9E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LODGroup destination;

	// Token: 0x040026CF RID: 9935
	[Token(Token = "0x4001F9F")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x7EB50", Offset = "0x7DF50")]
	[SerializeField]
	private bool scale;
}
