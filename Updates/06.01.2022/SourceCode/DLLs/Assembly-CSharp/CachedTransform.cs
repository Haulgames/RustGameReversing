using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B3B RID: 2875
[Token(Token = "0x2000806")]
public struct CachedTransform<T> where T : Component
{
	// Token: 0x060042F2 RID: 17138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600387E")]
	public CachedTransform(T instance)
	{
	}

	// Token: 0x060042F3 RID: 17139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600387F")]
	public void Apply()
	{
	}

	// Token: 0x060042F4 RID: 17140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003880")]
	public void RotateAround(Vector3 center, Vector3 axis, float angle)
	{
	}

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x060042F5 RID: 17141 RVA: 0x00018FC0 File Offset: 0x000171C0
	[Token(Token = "0x17000475")]
	public Matrix4x4 localToWorldMatrix
	{
		[Token(Token = "0x6003881")]
		get
		{
			return default(Matrix4x4);
		}
	}

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x060042F6 RID: 17142 RVA: 0x00018FD8 File Offset: 0x000171D8
	[Token(Token = "0x17000476")]
	public Matrix4x4 worldToLocalMatrix
	{
		[Token(Token = "0x6003882")]
		get
		{
			return default(Matrix4x4);
		}
	}

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x060042F7 RID: 17143 RVA: 0x00018FF0 File Offset: 0x000171F0
	[Token(Token = "0x17000477")]
	public Vector3 forward
	{
		[Token(Token = "0x6003883")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x060042F8 RID: 17144 RVA: 0x00019008 File Offset: 0x00017208
	[Token(Token = "0x17000478")]
	public Vector3 up
	{
		[Token(Token = "0x6003884")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x060042F9 RID: 17145 RVA: 0x00019020 File Offset: 0x00017220
	[Token(Token = "0x17000479")]
	public Vector3 right
	{
		[Token(Token = "0x6003885")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x060042FA RID: 17146 RVA: 0x00019038 File Offset: 0x00017238
	[Token(Token = "0x6003886")]
	public static implicit operator bool(CachedTransform<T> instance)
	{
		return default(bool);
	}

	// Token: 0x0400401D RID: 16413
	[Token(Token = "0x400316E")]
	[FieldOffset(Offset = "0x0")]
	public T component;

	// Token: 0x0400401E RID: 16414
	[Token(Token = "0x400316F")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 position;

	// Token: 0x0400401F RID: 16415
	[Token(Token = "0x4003170")]
	[FieldOffset(Offset = "0x0")]
	public Quaternion rotation;

	// Token: 0x04004020 RID: 16416
	[Token(Token = "0x4003171")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 localScale;
}
