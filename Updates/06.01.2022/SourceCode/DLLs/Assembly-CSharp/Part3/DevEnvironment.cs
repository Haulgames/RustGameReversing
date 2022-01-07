using System;
using Il2CppDummyDll;

// Token: 0x020003E9 RID: 1001
[Token(Token = "0x20002D0")]
public class DevEnvironment : DevControlsTab
{
	// Token: 0x060020FA RID: 8442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0xB6AFC0", Offset = "0xB69DC0", VA = "0x180B6AFC0")]
	private void OnEnable()
	{
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0xB6AF90", Offset = "0xB69D90", VA = "0x180B6AF90", Slot = "6")]
	public override string GetTabName()
	{
		return null;
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0xB6B050", Offset = "0xB69E50", VA = "0x180B6B050", Slot = "7")]
	public override void OnTabContents()
	{
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public DevEnvironment()
	{
	}

	// Token: 0x04001BB2 RID: 7090
	[Token(Token = "0x400168E")]
	[FieldOffset(Offset = "0x18")]
	public TOD_Sky sky;
}
