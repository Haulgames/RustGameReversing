using System;
using Il2CppDummyDll;
using ProtoBuf;
using Rust.UI;
using UnityEngine;

// Token: 0x02000956 RID: 2390
[Token(Token = "0x20006AD")]
public class BaseEventUI : MonoBehaviour
{
	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x060038ED RID: 14573 RVA: 0x00017700 File Offset: 0x00015900
	// (set) Token: 0x060038EE RID: 14574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000422")]
	public int ID
	{
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x4EED10", Offset = "0x4EDB10", VA = "0x1804EED10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x4EEDA0", Offset = "0x4EDBA0", VA = "0x1804EEDA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x060038EF RID: 14575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x893A00", Offset = "0x892800", VA = "0x180893A00", Slot = "4")]
	public virtual void Init(AIEventType eventType, BaseStateUI stateUI)
	{
	}

	// Token: 0x060038F0 RID: 14576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x893D10", Offset = "0x892B10", VA = "0x180893D10", Slot = "5")]
	public virtual AIEventData Save()
	{
		return null;
	}

	// Token: 0x060038F1 RID: 14577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x893B00", Offset = "0x892900", VA = "0x180893B00", Slot = "6")]
	public virtual void Load(AIEventData data)
	{
	}

	// Token: 0x060038F2 RID: 14578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x893EA0", Offset = "0x892CA0", VA = "0x180893EA0")]
	public void SetOutputStateContainer(int id)
	{
	}

	// Token: 0x060038F3 RID: 14579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x8936D0", Offset = "0x8924D0", VA = "0x1808936D0")]
	public void ClearOutputStateContainer()
	{
	}

	// Token: 0x060038F4 RID: 14580 RVA: 0x00017718 File Offset: 0x00015918
	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x8939B0", Offset = "0x8927B0", VA = "0x1808939B0")]
	public int GetOutputStateContainer()
	{
		return 0;
	}

	// Token: 0x060038F5 RID: 14581 RVA: 0x00017730 File Offset: 0x00015930
	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x893CE0", Offset = "0x892AE0", VA = "0x180893CE0")]
	public float ParseFloat(string input)
	{
		return 0f;
	}

	// Token: 0x060038F6 RID: 14582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x893720", Offset = "0x892520", VA = "0x180893720")]
	public void Clicked()
	{
	}

	// Token: 0x060038F7 RID: 14583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF3")]
	[Address(RVA = "0x893C40", Offset = "0x892A40", VA = "0x180893C40")]
	public void OutputClicked(object value)
	{
	}

	// Token: 0x060038F8 RID: 14584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF4")]
	[Address(RVA = "0x893980", Offset = "0x892780", VA = "0x180893980")]
	public void DeleteClicked()
	{
	}

	// Token: 0x060038F9 RID: 14585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF5")]
	[Address(RVA = "0x893C10", Offset = "0x892A10", VA = "0x180893C10")]
	public void MoveUpClicked()
	{
	}

	// Token: 0x060038FA RID: 14586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF6")]
	[Address(RVA = "0x893BE0", Offset = "0x8929E0", VA = "0x180893BE0")]
	public void MoveDownClicked()
	{
	}

	// Token: 0x060038FB RID: 14587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF7")]
	[Address(RVA = "0x893EE0", Offset = "0x892CE0", VA = "0x180893EE0")]
	public void SetTriggered(bool flag)
	{
	}

	// Token: 0x060038FC RID: 14588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FF8")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BaseEventUI()
	{
	}

	// Token: 0x040035F5 RID: 13813
	[Token(Token = "0x4002948")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public AIEventType EventType;

	// Token: 0x040035F6 RID: 13814
	[Token(Token = "0x4002949")]
	[FieldOffset(Offset = "0x20")]
	public RustText TextEventType;

	// Token: 0x040035F7 RID: 13815
	[Token(Token = "0x400294A")]
	[FieldOffset(Offset = "0x28")]
	public RustText TextOutput;

	// Token: 0x040035F8 RID: 13816
	[Token(Token = "0x400294B")]
	[FieldOffset(Offset = "0x30")]
	public RustButton ToggleInvert;

	// Token: 0x040035F9 RID: 13817
	[Token(Token = "0x400294C")]
	[FieldOffset(Offset = "0x38")]
	public Dropdown DropdownInputMemorySlot;

	// Token: 0x040035FA RID: 13818
	[Token(Token = "0x400294D")]
	[FieldOffset(Offset = "0x40")]
	public Dropdown DropdownOutputMemorySlot;

	// Token: 0x040035FB RID: 13819
	[Token(Token = "0x400294E")]
	[FieldOffset(Offset = "0x48")]
	public RustInput InputFloatValue;

	// Token: 0x040035FC RID: 13820
	[Token(Token = "0x400294F")]
	[FieldOffset(Offset = "0x50")]
	public RustInput InputFloatValue2;

	// Token: 0x040035FD RID: 13821
	[Token(Token = "0x4002950")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public BaseStateUI Output;

	// Token: 0x040035FE RID: 13822
	[Token(Token = "0x4002951")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <ID>k__BackingField;

	// Token: 0x040035FF RID: 13823
	[Token(Token = "0x4002952")]
	[FieldOffset(Offset = "0x68")]
	private BaseStateUI stateUI;

	// Token: 0x04003600 RID: 13824
	[Token(Token = "0x4002953")]
	[FieldOffset(Offset = "0x70")]
	private Color outputColor;
}
