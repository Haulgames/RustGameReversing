using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000268 RID: 616
[Token(Token = "0x20001AA")]
public class AIInformationCellContents<T> where T : AIPoint
{
	// Token: 0x170001AF RID: 431
	// (get) Token: 0x0600190B RID: 6411 RVA: 0x0000CCD8 File Offset: 0x0000AED8
	[Token(Token = "0x17000198")]
	public int Count
	{
		[Token(Token = "0x60013AB")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x0600190C RID: 6412 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
	[Token(Token = "0x17000199")]
	public bool Empty
	{
		[Token(Token = "0x60013AC")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AD")]
	public void Init(Bounds cellBounds, GameObject root)
	{
	}

	// Token: 0x0600190E RID: 6414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AE")]
	public void Clear()
	{
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AF")]
	public void Add(T item)
	{
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B0")]
	public void Remove(T item)
	{
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B1")]
	public AIInformationCellContents()
	{
	}

	// Token: 0x0400134C RID: 4940
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x0")]
	public HashSet<T> Items;
}
