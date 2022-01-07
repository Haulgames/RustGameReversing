using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000426 RID: 1062
[Token(Token = "0x2000302")]
public abstract class BaseScreenShake : MonoBehaviour
{
	// Token: 0x060021EA RID: 8682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BA8")]
	[Address(RVA = "0x99F070", Offset = "0x99DE70", VA = "0x18099F070")]
	public static void Apply(Camera cam, BaseViewModel vm)
	{
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BA9")]
	[Address(RVA = "0x99F280", Offset = "0x99E080", VA = "0x18099F280")]
	protected void OnEnable()
	{
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAA")]
	[Address(RVA = "0x99F1D0", Offset = "0x99DFD0", VA = "0x18099F1D0")]
	protected void OnDisable()
	{
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAB")]
	[Address(RVA = "0x99F310", Offset = "0x99E110", VA = "0x18099F310")]
	public void Run(ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm)
	{
	}

	// Token: 0x060021EE RID: 8686
	[Token(Token = "0x6001BAC")]
	public abstract void Setup();

	// Token: 0x060021EF RID: 8687
	[Token(Token = "0x6001BAD")]
	public abstract void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm);

	// Token: 0x060021F0 RID: 8688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAE")]
	[Address(RVA = "0x99F460", Offset = "0x99E260", VA = "0x18099F460")]
	protected BaseScreenShake()
	{
	}

	// Token: 0x04001CA7 RID: 7335
	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x0")]
	public static List<BaseScreenShake> list;

	// Token: 0x04001CA8 RID: 7336
	[Token(Token = "0x400175B")]
	[FieldOffset(Offset = "0x18")]
	public float length;

	// Token: 0x04001CA9 RID: 7337
	[Token(Token = "0x400175C")]
	[FieldOffset(Offset = "0x1C")]
	internal float timeTaken;

	// Token: 0x04001CAA RID: 7338
	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x20")]
	private int currentFrame;
}
