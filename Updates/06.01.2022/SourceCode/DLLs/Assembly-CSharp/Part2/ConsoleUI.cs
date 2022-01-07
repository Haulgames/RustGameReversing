using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000985 RID: 2437
[Token(Token = "0x20006D6")]
public class ConsoleUI : SingletonComponent<ConsoleUI>
{
	// Token: 0x060039D1 RID: 14801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030AF")]
	[Address(RVA = "0x6C59A0", Offset = "0x6C47A0", VA = "0x1806C59A0", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x060039D2 RID: 14802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B0")]
	[Address(RVA = "0x6C61F0", Offset = "0x6C4FF0", VA = "0x1806C61F0")]
	protected void OnEnable()
	{
	}

	// Token: 0x060039D3 RID: 14803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B1")]
	[Address(RVA = "0x6C60F0", Offset = "0x6C4EF0", VA = "0x1806C60F0")]
	protected void OnDisable()
	{
	}

	// Token: 0x060039D4 RID: 14804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B2")]
	[Address(RVA = "0x6C7480", Offset = "0x6C6280", VA = "0x1806C7480")]
	protected void Update()
	{
	}

	// Token: 0x060039D5 RID: 14805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B3")]
	[Address(RVA = "0x6C5C80", Offset = "0x6C4A80", VA = "0x1806C5C80")]
	public void CloseAutocomplete()
	{
	}

	// Token: 0x060039D6 RID: 14806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B4")]
	[Address(RVA = "0x6C6370", Offset = "0x6C5170", VA = "0x1806C6370")]
	public void OnTextTypes(string str)
	{
	}

	// Token: 0x060039D7 RID: 14807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B5")]
	[Address(RVA = "0x6C5940", Offset = "0x6C4740", VA = "0x1806C5940")]
	private void AutocompleteButtonClicked(Button button)
	{
	}

	// Token: 0x060039D8 RID: 14808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B6")]
	[Address(RVA = "0x6C6290", Offset = "0x6C5090", VA = "0x1806C6290")]
	private void OnOpenDevTools()
	{
	}

	// Token: 0x060039D9 RID: 14809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B7")]
	[Address(RVA = "0x6C6A60", Offset = "0x6C5860", VA = "0x1806C6A60")]
	private void OutputHandler_OnMessage(string message, string stack, LogType type = LogType.Error)
	{
	}

	// Token: 0x060039DA RID: 14810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B8")]
	[Address(RVA = "0x6C6060", Offset = "0x6C4E60", VA = "0x1806C6060")]
	private void Log(string message)
	{
	}

	// Token: 0x060039DB RID: 14811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030B9")]
	[Address(RVA = "0x6C6F30", Offset = "0x6C5D30", VA = "0x1806C6F30")]
	private void Refresh()
	{
	}

	// Token: 0x060039DC RID: 14812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x6C5F20", Offset = "0x6C4D20", VA = "0x1806C5F20")]
	private void LoadHistory(int delta)
	{
	}

	// Token: 0x060039DD RID: 14813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030BB")]
	[Address(RVA = "0x6C7080", Offset = "0x6C5E80", VA = "0x1806C7080")]
	public void SubmitCommand(string command)
	{
	}

	// Token: 0x060039DE RID: 14814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x6C6F80", Offset = "0x6C5D80", VA = "0x1806C6F80")]
	private void SelectInputField(bool updateAutoComplete = false)
	{
	}

	// Token: 0x060039DF RID: 14815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x6C7000", Offset = "0x6C5E00", VA = "0x1806C7000")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xC9A80", Offset = "0xC8E80")]
	private IEnumerator SetSelected(bool updateAutoComplete = false)
	{
		return null;
	}

	// Token: 0x060039E0 RID: 14816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030BE")]
	[Address(RVA = "0x6C5C20", Offset = "0x6C4A20", VA = "0x1806C5C20")]
	public void ClearContents()
	{
	}

	// Token: 0x060039E1 RID: 14817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x6C5D90", Offset = "0x6C4B90", VA = "0x1806C5D90")]
	public void Copy()
	{
	}

	// Token: 0x060039E2 RID: 14818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x6C69A0", Offset = "0x6C57A0", VA = "0x1806C69A0")]
	public void OpenLogFolder()
	{
	}

	// Token: 0x060039E3 RID: 14819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x6C68E0", Offset = "0x6C56E0", VA = "0x1806C68E0")]
	public void OpenLogFile()
	{
	}

	// Token: 0x060039E4 RID: 14820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x6C7910", Offset = "0x6C6710", VA = "0x1806C7910")]
	public ConsoleUI()
	{
	}

	// Token: 0x04003685 RID: 13957
	[Token(Token = "0x40029C7")]
	[FieldOffset(Offset = "0x18")]
	public RustText text;

	// Token: 0x04003686 RID: 13958
	[Token(Token = "0x40029C8")]
	[FieldOffset(Offset = "0x20")]
	public InputField outputField;

	// Token: 0x04003687 RID: 13959
	[Token(Token = "0x40029C9")]
	[FieldOffset(Offset = "0x28")]
	public InputField inputField;

	// Token: 0x04003688 RID: 13960
	[Token(Token = "0x40029CA")]
	[FieldOffset(Offset = "0x30")]
	public GameObject AutocompleteDropDown;

	// Token: 0x04003689 RID: 13961
	[Token(Token = "0x40029CB")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ItemTemplate;

	// Token: 0x0400368A RID: 13962
	[Token(Token = "0x40029CC")]
	[FieldOffset(Offset = "0x40")]
	public Color errorColor;

	// Token: 0x0400368B RID: 13963
	[Token(Token = "0x40029CD")]
	[FieldOffset(Offset = "0x50")]
	public Color warningColor;

	// Token: 0x0400368C RID: 13964
	[Token(Token = "0x40029CE")]
	[FieldOffset(Offset = "0x60")]
	public Color inputColor;

	// Token: 0x0400368D RID: 13965
	[Token(Token = "0x40029CF")]
	[FieldOffset(Offset = "0x70")]
	private TextBuffer buffer;

	// Token: 0x0400368E RID: 13966
	[Token(Token = "0x40029D0")]
	[FieldOffset(Offset = "0x78")]
	private TextBuffer history;

	// Token: 0x0400368F RID: 13967
	[Token(Token = "0x40029D1")]
	[FieldOffset(Offset = "0x80")]
	private string historyTemp;

	// Token: 0x04003690 RID: 13968
	[Token(Token = "0x40029D2")]
	[FieldOffset(Offset = "0x88")]
	private string historyText;

	// Token: 0x04003691 RID: 13969
	[Token(Token = "0x40029D3")]
	[FieldOffset(Offset = "0x90")]
	private int historyIndex;

	// Token: 0x04003692 RID: 13970
	[Token(Token = "0x40029D4")]
	[FieldOffset(Offset = "0x98")]
	private Button[] autocompleteButtons;

	// Token: 0x04003693 RID: 13971
	[Token(Token = "0x40029D5")]
	[FieldOffset(Offset = "0xA0")]
	private int autocompleteIndex;

	// Token: 0x04003694 RID: 13972
	[Token(Token = "0x40029D6")]
	[FieldOffset(Offset = "0xA4")]
	private bool dirty;

	// Token: 0x02000986 RID: 2438
	[Token(Token = "0x2000CDA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x060039E5 RID: 14821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005097")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005098")]
		[Address(RVA = "0x6E0050", Offset = "0x6DEE50", VA = "0x1806E0050")]
		internal void <Awake>b__0()
		{
		}

		// Token: 0x04003695 RID: 13973
		[Token(Token = "0x40049B0")]
		[FieldOffset(Offset = "0x10")]
		public Button btn;

		// Token: 0x04003696 RID: 13974
		[Token(Token = "0x40049B1")]
		[FieldOffset(Offset = "0x18")]
		public ConsoleUI <>4__this;
	}

	// Token: 0x02000987 RID: 2439
	[Token(Token = "0x2000CDB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass21_0
	{
		// Token: 0x060039E7 RID: 14823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005099")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass21_0()
		{
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x000178B0 File Offset: 0x00015AB0
		[Token(Token = "0x600509A")]
		[Address(RVA = "0x6E00B0", Offset = "0x6DEEB0", VA = "0x1806E00B0")]
		internal bool <OnTextTypes>b__0(ConsoleSystem.Command x)
		{
			return default(bool);
		}

		// Token: 0x04003697 RID: 13975
		[Token(Token = "0x40049B2")]
		[FieldOffset(Offset = "0x10")]
		public string str;
	}

	// Token: 0x02000988 RID: 2440
	[Token(Token = "0x2000CDC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <SetSelected>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060039E9 RID: 14825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509B")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <SetSelected>d__30(int <>1__state)
		{
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509C")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x000178C8 File Offset: 0x00015AC8
		[Token(Token = "0x600509D")]
		[Address(RVA = "0x6DFD70", Offset = "0x6DEB70", VA = "0x1806DFD70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077B")]
		private object Current
		{
			[Token(Token = "0x600509E")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600509F")]
		[Address(RVA = "0x6DFF50", Offset = "0x6DED50", VA = "0x1806DFF50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060039EE RID: 14830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077C")]
		private object Current
		{
			[Token(Token = "0x60050A0")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04003698 RID: 13976
		[Token(Token = "0x40049B3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003699 RID: 13977
		[Token(Token = "0x40049B4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400369A RID: 13978
		[Token(Token = "0x40049B5")]
		[FieldOffset(Offset = "0x20")]
		public ConsoleUI <>4__this;

		// Token: 0x0400369B RID: 13979
		[Token(Token = "0x40049B6")]
		[FieldOffset(Offset = "0x28")]
		public bool updateAutoComplete;
	}
}
