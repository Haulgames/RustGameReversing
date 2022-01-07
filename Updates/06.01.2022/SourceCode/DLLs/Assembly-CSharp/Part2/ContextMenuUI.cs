using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GameMenu;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000989 RID: 2441
[Token(Token = "0x20006D7")]
public static class ContextMenuUI
{
	// Token: 0x060039EF RID: 14831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C3")]
	[Address(RVA = "0x6D10B0", Offset = "0x6CFEB0", VA = "0x1806D10B0")]
	public static void Start(ContextMenuUI.MenuType menuType)
	{
	}

	// Token: 0x060039F0 RID: 14832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x6D02D0", Offset = "0x6CF0D0", VA = "0x1806D02D0")]
	public static void AddOption(string name, string desc, Sprite icon, Action<BasePlayer> action, int order = 0, bool disabled = false, bool selected = false, string requirements = "", bool allowMerge = false, [Optional] Color? spriteColor)
	{
	}

	// Token: 0x060039F1 RID: 14833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x6D0690", Offset = "0x6CF490", VA = "0x1806D0690")]
	public static void End()
	{
	}

	// Token: 0x060039F2 RID: 14834 RVA: 0x000178E0 File Offset: 0x00015AE0
	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x6D0CF0", Offset = "0x6CFAF0", VA = "0x1806D0CF0")]
	public static bool IsOpen()
	{
		return default(bool);
	}

	// Token: 0x060039F3 RID: 14835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x6D04D0", Offset = "0x6CF2D0", VA = "0x1806D04D0")]
	public static void Cancel()
	{
	}

	// Token: 0x060039F4 RID: 14836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x6D05D0", Offset = "0x6CF3D0", VA = "0x1806D05D0")]
	public static void DoSelect()
	{
	}

	// Token: 0x060039F5 RID: 14837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x6D0D60", Offset = "0x6CFB60", VA = "0x1806D0D60")]
	public static void Open(List<Option> options, ContextMenuUI.MenuType menuType)
	{
	}

	// Token: 0x060039F6 RID: 14838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x6D0700", Offset = "0x6CF500", VA = "0x1806D0700")]
	public static void FrameUpdate(BasePlayer player)
	{
	}

	// Token: 0x060039F7 RID: 14839 RVA: 0x000178F8 File Offset: 0x00015AF8
	[Token(Token = "0x60030CB")]
	[Address(RVA = "0x6D0B10", Offset = "0x6CF910", VA = "0x1806D0B10")]
	public static bool IsButtonDownRaw(string bind)
	{
		return default(bool);
	}

	// Token: 0x0400369C RID: 13980
	[Token(Token = "0x40029D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2467")]
	public static ContextMenuUI.MenuType type;

	// Token: 0x0200098A RID: 2442
	[Token(Token = "0x2000CDD")]
	public enum MenuType
	{
		// Token: 0x0400369E RID: 13982
		[Token(Token = "0x40049B8")]
		Use,
		// Token: 0x0400369F RID: 13983
		[Token(Token = "0x40049B9")]
		RightClick,
		// Token: 0x040036A0 RID: 13984
		[Token(Token = "0x40049BA")]
		Reload,
		// Token: 0x040036A1 RID: 13985
		[Token(Token = "0x40049BB")]
		Gesture,
		// Token: 0x040036A2 RID: 13986
		[Token(Token = "0x40049BC")]
		Pet
	}
}
