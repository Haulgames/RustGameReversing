using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000AE0 RID: 2784
[Token(Token = "0x20007C0")]
[ExecuteInEditMode]
public class CameraEx : MonoBehaviour
{
	// Token: 0x06004162 RID: 16738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003718")]
	[Address(RVA = "0x6478D0", Offset = "0x6466D0", VA = "0x1806478D0")]
	private void OnPreRender()
	{
	}

	// Token: 0x06004163 RID: 16739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003719")]
	[Address(RVA = "0x647840", Offset = "0x646640", VA = "0x180647840")]
	private void OnPostRender()
	{
	}

	// Token: 0x06004164 RID: 16740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600371A")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public CameraEx()
	{
	}

	// Token: 0x04003E9F RID: 16031
	[Token(Token = "0x4003044")]
	[FieldOffset(Offset = "0x18")]
	public bool overrideAmbientLight;

	// Token: 0x04003EA0 RID: 16032
	[Token(Token = "0x4003045")]
	[FieldOffset(Offset = "0x1C")]
	public AmbientMode ambientMode;

	// Token: 0x04003EA1 RID: 16033
	[Token(Token = "0x4003046")]
	[FieldOffset(Offset = "0x20")]
	public Color ambientGroundColor;

	// Token: 0x04003EA2 RID: 16034
	[Token(Token = "0x4003047")]
	[FieldOffset(Offset = "0x30")]
	public Color ambientEquatorColor;

	// Token: 0x04003EA3 RID: 16035
	[Token(Token = "0x4003048")]
	[FieldOffset(Offset = "0x40")]
	public Color ambientLight;

	// Token: 0x04003EA4 RID: 16036
	[Token(Token = "0x4003049")]
	[FieldOffset(Offset = "0x50")]
	public float ambientIntensity;

	// Token: 0x04003EA5 RID: 16037
	[Token(Token = "0x400304A")]
	[FieldOffset(Offset = "0x54")]
	internal Color old_ambientLight;

	// Token: 0x04003EA6 RID: 16038
	[Token(Token = "0x400304B")]
	[FieldOffset(Offset = "0x64")]
	internal Color old_ambientGroundColor;

	// Token: 0x04003EA7 RID: 16039
	[Token(Token = "0x400304C")]
	[FieldOffset(Offset = "0x74")]
	internal Color old_ambientEquatorColor;

	// Token: 0x04003EA8 RID: 16040
	[Token(Token = "0x400304D")]
	[FieldOffset(Offset = "0x84")]
	internal float old_ambientIntensity;

	// Token: 0x04003EA9 RID: 16041
	[Token(Token = "0x400304E")]
	[FieldOffset(Offset = "0x88")]
	internal AmbientMode old_ambientMode;

	// Token: 0x04003EAA RID: 16042
	[Token(Token = "0x400304F")]
	[FieldOffset(Offset = "0x8C")]
	public float aspect;
}
