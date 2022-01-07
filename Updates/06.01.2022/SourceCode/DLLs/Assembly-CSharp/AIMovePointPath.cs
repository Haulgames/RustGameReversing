using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026E RID: 622
[Token(Token = "0x20001AF")]
public class AIMovePointPath : MonoBehaviour
{
	// Token: 0x06001928 RID: 6440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x815660", Offset = "0x814460", VA = "0x180815660")]
	public void Clear()
	{
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x815600", Offset = "0x814400", VA = "0x180815600")]
	public void AddPoint(AIMovePoint point)
	{
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x8156B0", Offset = "0x8144B0", VA = "0x1808156B0")]
	public AIMovePoint FindNearestPoint(Vector3 position)
	{
		return null;
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x8159B0", Offset = "0x8147B0", VA = "0x1808159B0")]
	public AIMovePoint GetNextPoint(AIMovePoint current, ref AIMovePointPath.PathDirection pathDirection)
	{
		return null;
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x8158E0", Offset = "0x8146E0", VA = "0x1808158E0")]
	private AIMovePoint GetNextPoint(int currentPointIndex, ref AIMovePointPath.PathDirection pathDirection)
	{
		return null;
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x815C50", Offset = "0x814A50", VA = "0x180815C50")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x815B50", Offset = "0x814950", VA = "0x180815B50")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x0600192F RID: 6447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x815FC0", Offset = "0x814DC0", VA = "0x180815FC0")]
	public AIMovePointPath()
	{
	}

	// Token: 0x0400136D RID: 4973
	[Token(Token = "0x4000FF5")]
	[FieldOffset(Offset = "0x18")]
	public Color DebugPathColor;

	// Token: 0x0400136E RID: 4974
	[Token(Token = "0x4000FF6")]
	[FieldOffset(Offset = "0x28")]
	public AIMovePointPath.Mode LoopMode;

	// Token: 0x0400136F RID: 4975
	[Token(Token = "0x4000FF7")]
	[FieldOffset(Offset = "0x30")]
	public List<AIMovePoint> Points;

	// Token: 0x0200026F RID: 623
	[Token(Token = "0x2000AF4")]
	public enum Mode
	{
		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x400408F")]
		Loop,
		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4004090")]
		Reverse
	}

	// Token: 0x02000270 RID: 624
	[Token(Token = "0x2000AF5")]
	public enum PathDirection
	{
		// Token: 0x04001374 RID: 4980
		[Token(Token = "0x4004092")]
		Forwards,
		// Token: 0x04001375 RID: 4981
		[Token(Token = "0x4004093")]
		Backwards
	}
}
