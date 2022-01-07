using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D1 RID: 977
[Token(Token = "0x20002BB")]
public class CinematicEntity : BaseEntity
{
	// Token: 0x0600207D RID: 8317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A74")]
	[Address(RVA = "0x4DF740", Offset = "0x4DE540", VA = "0x1804DF740", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A75")]
	[Address(RVA = "0x4DF880", Offset = "0x4DE680", VA = "0x1804DF880")]
	[ClientVar]
	public static void DemoHideObjects(ConsoleSystem.Arg args)
	{
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A76")]
	[Address(RVA = "0x4DFD10", Offset = "0x4DEB10", VA = "0x1804DFD10")]
	[ClientVar]
	public static void RemoveDemoOverride()
	{
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A77")]
	[Address(RVA = "0x4DFA70", Offset = "0x4DE870", VA = "0x1804DFA70", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x4DFBC0", Offset = "0x4DE9C0", VA = "0x1804DFBC0", Slot = "80")]
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next)
	{
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x4DFEE0", Offset = "0x4DECE0", VA = "0x1804DFEE0")]
	private void ToggleObjects(bool state)
	{
	}

	// Token: 0x06002083 RID: 8323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x4E0040", Offset = "0x4DEE40", VA = "0x1804E0040")]
	public CinematicEntity()
	{
	}

	// Token: 0x04001B5B RID: 7003
	[Token(Token = "0x400165D")]
	private const BaseEntity.Flags HideMesh = BaseEntity.Flags.Reserved1;

	// Token: 0x04001B5C RID: 7004
	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0x160")]
	public GameObject[] DisableObjects;

	// Token: 0x04001B5D RID: 7005
	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0x0")]
	private static List<CinematicEntity> clientList;

	// Token: 0x04001B5E RID: 7006
	[Token(Token = "0x4001660")]
	[FieldOffset(Offset = "0x8")]
	public static bool? demoOverride;
}
