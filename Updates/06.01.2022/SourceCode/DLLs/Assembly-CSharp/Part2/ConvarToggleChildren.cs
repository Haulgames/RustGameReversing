using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200098B RID: 2443
[Token(Token = "0x20006D8")]
public class ConvarToggleChildren : MonoBehaviour
{
	// Token: 0x060039F8 RID: 14840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030CC")]
	[Address(RVA = "0x6D1830", Offset = "0x6D0630", VA = "0x1806D1830")]
	protected void Awake()
	{
	}

	// Token: 0x060039F9 RID: 14841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030CD")]
	[Address(RVA = "0x6D1B90", Offset = "0x6D0990", VA = "0x1806D1B90")]
	protected void Update()
	{
	}

	// Token: 0x060039FA RID: 14842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x6D1920", Offset = "0x6D0720", VA = "0x1806D1920")]
	private void SetState(bool newState)
	{
	}

	// Token: 0x060039FB RID: 14843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x6D1BE0", Offset = "0x6D09E0", VA = "0x1806D1BE0")]
	public ConvarToggleChildren()
	{
	}

	// Token: 0x040036A3 RID: 13987
	[Token(Token = "0x40029D8")]
	[FieldOffset(Offset = "0x18")]
	public string ConvarName;

	// Token: 0x040036A4 RID: 13988
	[Token(Token = "0x40029D9")]
	[FieldOffset(Offset = "0x20")]
	public string ConvarEnabled;

	// Token: 0x040036A5 RID: 13989
	[Token(Token = "0x40029DA")]
	[FieldOffset(Offset = "0x28")]
	private bool state;

	// Token: 0x040036A6 RID: 13990
	[Token(Token = "0x40029DB")]
	[FieldOffset(Offset = "0x30")]
	private ConsoleSystem.Command Command;
}
