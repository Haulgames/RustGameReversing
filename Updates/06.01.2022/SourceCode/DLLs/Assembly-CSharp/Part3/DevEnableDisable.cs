using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E8 RID: 1000
[Token(Token = "0x20002CF")]
public class DevEnableDisable : DevControlsTab
{
	// Token: 0x060020F5 RID: 8437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0xB6AEC0", Offset = "0xB69CC0", VA = "0x180B6AEC0")]
	private void Start()
	{
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0xB6AC00", Offset = "0xB69A00", VA = "0x180B6AC00")]
	private void ApplyLastSettings()
	{
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x84E740", Offset = "0x84D540", VA = "0x18084E740", Slot = "6")]
	public override string GetTabName()
	{
		return null;
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0xB6AD30", Offset = "0xB69B30", VA = "0x180B6AD30", Slot = "7")]
	public override void OnTabContents()
	{
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0xB6AF30", Offset = "0xB69D30", VA = "0x180B6AF30")]
	public DevEnableDisable()
	{
	}

	// Token: 0x04001BAF RID: 7087
	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] Objects;

	// Token: 0x04001BB0 RID: 7088
	[Token(Token = "0x400168C")]
	[FieldOffset(Offset = "0x20")]
	public string CookieName;

	// Token: 0x04001BB1 RID: 7089
	[Token(Token = "0x400168D")]
	[FieldOffset(Offset = "0x28")]
	public string TabName;
}
