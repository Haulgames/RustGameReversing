using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D5 RID: 981
[Token(Token = "0x20002BE")]
public class DrawArrow : MonoBehaviour
{
	// Token: 0x060020B5 RID: 8373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x97BCF0", Offset = "0x97AAF0", VA = "0x18097BCF0")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x97C230", Offset = "0x97B030", VA = "0x18097C230")]
	public DrawArrow()
	{
	}

	// Token: 0x04001B80 RID: 7040
	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0x18")]
	public Color color;

	// Token: 0x04001B81 RID: 7041
	[Token(Token = "0x4001665")]
	[FieldOffset(Offset = "0x28")]
	public float length;

	// Token: 0x04001B82 RID: 7042
	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0x2C")]
	public float arrowLength;
}
