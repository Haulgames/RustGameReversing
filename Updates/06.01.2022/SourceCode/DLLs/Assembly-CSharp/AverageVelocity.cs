using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000338 RID: 824
[Token(Token = "0x200024A")]
public class AverageVelocity
{
	// Token: 0x06001CD6 RID: 7382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172F")]
	[Address(RVA = "0x8445C0", Offset = "0x8433C0", VA = "0x1808445C0")]
	public void Record(Vector3 newPos)
	{
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x0000E118 File Offset: 0x0000C318
	[Token(Token = "0x170001E0")]
	public float Speed
	{
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x844730", Offset = "0x843530", VA = "0x180844730")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0000E130 File Offset: 0x0000C330
	[Token(Token = "0x170001E1")]
	public Vector3 Average
	{
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x2F97D0", Offset = "0x2F85D0", VA = "0x1802F97D0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06001CD9 RID: 7385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001732")]
	[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
	public AverageVelocity()
	{
	}

	// Token: 0x040017DB RID: 6107
	[Token(Token = "0x4001377")]
	[FieldOffset(Offset = "0x10")]
	private Vector3 pos;

	// Token: 0x040017DC RID: 6108
	[Token(Token = "0x4001378")]
	[FieldOffset(Offset = "0x1C")]
	private float time;

	// Token: 0x040017DD RID: 6109
	[Token(Token = "0x4001379")]
	[FieldOffset(Offset = "0x20")]
	private float lastEntry;

	// Token: 0x040017DE RID: 6110
	[Token(Token = "0x400137A")]
	[FieldOffset(Offset = "0x24")]
	private float averageSpeed;

	// Token: 0x040017DF RID: 6111
	[Token(Token = "0x400137B")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 averageVelocity;
}
