using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B3A RID: 2874
[Token(Token = "0x2000805")]
public class BasePrefab : BaseMonoBehaviour, IPrefabPreProcess
{
	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x060042EF RID: 17135 RVA: 0x00018FA8 File Offset: 0x000171A8
	[Token(Token = "0x17000474")]
	public bool isServer
	{
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x995420", Offset = "0x994220", VA = "0x180995420")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060042F0 RID: 17136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600387C")]
	[Address(RVA = "0x9953B0", Offset = "0x9941B0", VA = "0x1809953B0", Slot = "7")]
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x060042F1 RID: 17137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600387D")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public BasePrefab()
	{
	}

	// Token: 0x0400401B RID: 16411
	[Token(Token = "0x400316C")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public uint prefabID;

	// Token: 0x0400401C RID: 16412
	[Token(Token = "0x400316D")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public bool isClient;
}
