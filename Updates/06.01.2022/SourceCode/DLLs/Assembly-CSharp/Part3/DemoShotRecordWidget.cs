using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x0200099F RID: 2463
[Token(Token = "0x20006EB")]
public class DemoShotRecordWidget : MonoBehaviour
{
	// Token: 0x06003A62 RID: 14946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003130")]
	[Address(RVA = "0x8D1530", Offset = "0x8D0330", VA = "0x1808D1530")]
	private void Start()
	{
	}

	// Token: 0x06003A63 RID: 14947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003131")]
	[Address(RVA = "0x8D1210", Offset = "0x8D0010", VA = "0x1808D1210")]
	private void OnEnable()
	{
	}

	// Token: 0x06003A64 RID: 14948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003132")]
	[Address(RVA = "0x8D1720", Offset = "0x8D0520", VA = "0x1808D1720")]
	public void UpdateShotName()
	{
	}

	// Token: 0x06003A65 RID: 14949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003133")]
	[Address(RVA = "0x8D17B0", Offset = "0x8D05B0", VA = "0x1808D17B0")]
	private void Update()
	{
	}

	// Token: 0x06003A66 RID: 14950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003134")]
	[Address(RVA = "0x8D0F40", Offset = "0x8CFD40", VA = "0x1808D0F40")]
	public void OnClickedStartRecording()
	{
	}

	// Token: 0x06003A67 RID: 14951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003135")]
	[Address(RVA = "0x8D0ED0", Offset = "0x8CFCD0", VA = "0x1808D0ED0")]
	public void OnClickedFinish()
	{
	}

	// Token: 0x06003A68 RID: 14952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003136")]
	[Address(RVA = "0x8D1620", Offset = "0x8D0420", VA = "0x1808D1620")]
	public void Toggle(bool state)
	{
	}

	// Token: 0x06003A69 RID: 14953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003137")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DemoShotRecordWidget()
	{
	}

	// Token: 0x040036E2 RID: 14050
	[Token(Token = "0x4002A15")]
	[FieldOffset(Offset = "0x18")]
	public RustInput NameInput;

	// Token: 0x040036E3 RID: 14051
	[Token(Token = "0x4002A16")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RecordingRoot;

	// Token: 0x040036E4 RID: 14052
	[Token(Token = "0x4002A17")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PreRecordingRoot;

	// Token: 0x040036E5 RID: 14053
	[Token(Token = "0x4002A18")]
	[FieldOffset(Offset = "0x30")]
	public RustButton CountdownToggle;

	// Token: 0x040036E6 RID: 14054
	[Token(Token = "0x4002A19")]
	[FieldOffset(Offset = "0x38")]
	public RustButton PauseOnSaveToggle;

	// Token: 0x040036E7 RID: 14055
	[Token(Token = "0x4002A1A")]
	[FieldOffset(Offset = "0x40")]
	public RustButton ReturnToStartToggle;

	// Token: 0x040036E8 RID: 14056
	[Token(Token = "0x4002A1B")]
	[FieldOffset(Offset = "0x48")]
	public RustButton RecordDofToggle;

	// Token: 0x040036E9 RID: 14057
	[Token(Token = "0x4002A1C")]
	[FieldOffset(Offset = "0x50")]
	public RustOption FolderDropdown;

	// Token: 0x040036EA RID: 14058
	[Token(Token = "0x4002A1D")]
	[FieldOffset(Offset = "0x58")]
	public GameObject RecordingUnderlay;

	// Token: 0x040036EB RID: 14059
	[Token(Token = "0x4002A1E")]
	[FieldOffset(Offset = "0x60")]
	public AudioSource CountdownAudio;

	// Token: 0x040036EC RID: 14060
	[Token(Token = "0x4002A1F")]
	[FieldOffset(Offset = "0x68")]
	public GameObject ShotRecordTime;

	// Token: 0x040036ED RID: 14061
	[Token(Token = "0x4002A20")]
	[FieldOffset(Offset = "0x70")]
	public RustText ShotRecordTimeText;

	// Token: 0x040036EE RID: 14062
	[Token(Token = "0x4002A21")]
	[FieldOffset(Offset = "0x78")]
	public RustText ShotNameText;

	// Token: 0x040036EF RID: 14063
	[Token(Token = "0x4002A22")]
	[FieldOffset(Offset = "0x80")]
	public GameObject RecordingInProcessRoot;

	// Token: 0x040036F0 RID: 14064
	[Token(Token = "0x4002A23")]
	[FieldOffset(Offset = "0x88")]
	public GameObject CountdownActiveRoot;

	// Token: 0x040036F1 RID: 14065
	[Token(Token = "0x4002A24")]
	[FieldOffset(Offset = "0x90")]
	public GameObject CountdownActiveSliderRoot;

	// Token: 0x040036F2 RID: 14066
	[Token(Token = "0x4002A25")]
	[FieldOffset(Offset = "0x98")]
	public RustSlider CountdownActiveSlider;

	// Token: 0x040036F3 RID: 14067
	[Token(Token = "0x4002A26")]
	[FieldOffset(Offset = "0xA0")]
	public RustText CountdownActiveText;

	// Token: 0x040036F4 RID: 14068
	[Token(Token = "0x4002A27")]
	[FieldOffset(Offset = "0x0")]
	public static DemoShotRecordWidget Instance;
}
