using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020004A3 RID: 1187
[Token(Token = "0x2000370")]
public class EntityFlag_Toggle : EntityComponent<BaseEntity>, IOnPostNetworkUpdate, IOnSendNetworkUpdate, IPrefabPreProcess
{
	// Token: 0x06002450 RID: 9296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x84FB90", Offset = "0x84E990", VA = "0x18084FB90")]
	protected void OnDisable()
	{
	}

	// Token: 0x06002451 RID: 9297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x84FB10", Offset = "0x84E910", VA = "0x18084FB10")]
	public void DoUpdate(BaseEntity entity)
	{
	}

	// Token: 0x06002452 RID: 9298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF6")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "13")]
	protected virtual void OnStateToggled(bool state)
	{
	}

	// Token: 0x06002453 RID: 9299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF7")]
	[Address(RVA = "0x84FBA0", Offset = "0x84E9A0", VA = "0x18084FBA0", Slot = "10")]
	public void OnPostNetworkUpdate(BaseEntity entity)
	{
	}

	// Token: 0x06002454 RID: 9300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0x84FC90", Offset = "0x84EA90", VA = "0x18084FC90", Slot = "11")]
	public void OnSendNetworkUpdate(BaseEntity entity)
	{
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0x84FD20", Offset = "0x84EB20", VA = "0x18084FD20", Slot = "12")]
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DFA")]
	[Address(RVA = "0x84FDF0", Offset = "0x84EBF0", VA = "0x18084FDF0")]
	public EntityFlag_Toggle()
	{
	}

	// Token: 0x04001E93 RID: 7827
	[Token(Token = "0x400190B")]
	[FieldOffset(Offset = "0x20")]
	public bool runClientside;

	// Token: 0x04001E94 RID: 7828
	[Token(Token = "0x400190C")]
	[FieldOffset(Offset = "0x21")]
	public bool runServerside;

	// Token: 0x04001E95 RID: 7829
	[Token(Token = "0x400190D")]
	[FieldOffset(Offset = "0x24")]
	public BaseEntity.Flags flag;

	// Token: 0x04001E96 RID: 7830
	[Token(Token = "0x400190E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvent onFlagEnabled;

	// Token: 0x04001E97 RID: 7831
	[Token(Token = "0x400190F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UnityEvent onFlagDisabled;

	// Token: 0x04001E98 RID: 7832
	[Token(Token = "0x4001910")]
	[FieldOffset(Offset = "0x38")]
	internal bool hasRunOnce;

	// Token: 0x04001E99 RID: 7833
	[Token(Token = "0x4001911")]
	[FieldOffset(Offset = "0x39")]
	internal bool lastHasFlag;
}
