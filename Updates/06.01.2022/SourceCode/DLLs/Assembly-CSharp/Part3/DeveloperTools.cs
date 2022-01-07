using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009A7 RID: 2471
[Token(Token = "0x20006F1")]
public class DeveloperTools : SingletonComponent<DeveloperTools>
{
	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06003A88 RID: 14984 RVA: 0x000179A0 File Offset: 0x00015BA0
	[Token(Token = "0x1700042B")]
	public static bool isOpen
	{
		[Token(Token = "0x6003156")]
		[Address(RVA = "0xB6CBA0", Offset = "0xB6B9A0", VA = "0x180B6CBA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003157")]
	[Address(RVA = "0xB6C2B0", Offset = "0xB6B0B0", VA = "0x180B6C2B0")]
	public static void Close()
	{
	}

	// Token: 0x06003A8A RID: 14986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003158")]
	[Address(RVA = "0xB6C900", Offset = "0xB6B700", VA = "0x180B6C900")]
	private void Update()
	{
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003159")]
	[Address(RVA = "0xB6C390", Offset = "0xB6B190", VA = "0x180B6C390")]
	private void Start()
	{
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600315A")]
	[Address(RVA = "0xB6C760", Offset = "0xB6B560", VA = "0x180B6C760")]
	private void UnselectAll()
	{
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600315B")]
	[Address(RVA = "0xB6C6D0", Offset = "0xB6B4D0", VA = "0x180B6C6D0")]
	public void ToggleConsole()
	{
	}

	// Token: 0x06003A8E RID: 14990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600315C")]
	[Address(RVA = "0xB6CB40", Offset = "0xB6B940", VA = "0x180B6CB40")]
	public DeveloperTools()
	{
	}

	// Token: 0x04003718 RID: 14104
	[Token(Token = "0x4002A43")]
	[FieldOffset(Offset = "0x18")]
	public GameObject developerTools;

	// Token: 0x04003719 RID: 14105
	[Token(Token = "0x4002A44")]
	[FieldOffset(Offset = "0x20")]
	public GameObject navButton;

	// Token: 0x0400371A RID: 14106
	[Token(Token = "0x4002A45")]
	[FieldOffset(Offset = "0x28")]
	public GameObject panelContainer;

	// Token: 0x0400371B RID: 14107
	[Token(Token = "0x4002A46")]
	[FieldOffset(Offset = "0x30")]
	public Text ConsoleInput;

	// Token: 0x0400371C RID: 14108
	[Token(Token = "0x4002A47")]
	[FieldOffset(Offset = "0x0")]
	public static int LastSelected;

	// Token: 0x0400371D RID: 14109
	[Token(Token = "0x4002A48")]
	[FieldOffset(Offset = "0x4")]
	public static int CurrentlySelected;

	// Token: 0x020009A8 RID: 2472
	[Token(Token = "0x2000CE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06003A90 RID: 14992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A8")]
		[Address(RVA = "0xB7A990", Offset = "0xB79790", VA = "0x180B7A990")]
		internal void <Start>b__0()
		{
		}

		// Token: 0x0400371E RID: 14110
		[Token(Token = "0x40049C3")]
		[FieldOffset(Offset = "0x10")]
		public GameObject newButton;

		// Token: 0x0400371F RID: 14111
		[Token(Token = "0x40049C4")]
		[FieldOffset(Offset = "0x18")]
		public Transform child;

		// Token: 0x04003720 RID: 14112
		[Token(Token = "0x40049C5")]
		[FieldOffset(Offset = "0x20")]
		public DeveloperTools <>4__this;
	}
}
