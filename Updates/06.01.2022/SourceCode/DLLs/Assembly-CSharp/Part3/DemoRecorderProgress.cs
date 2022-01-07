using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x020009A6 RID: 2470
[Token(Token = "0x20006F0")]
public class DemoRecorderProgress : SingletonComponent<DemoRecorderProgress>
{
	// Token: 0x06003A81 RID: 14977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600314F")]
	[Address(RVA = "0x8CA720", Offset = "0x8C9520", VA = "0x1808CA720", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x06003A82 RID: 14978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003150")]
	[Address(RVA = "0x8CA8C0", Offset = "0x8C96C0", VA = "0x1808CA8C0")]
	public void Open(string recordingName)
	{
	}

	// Token: 0x06003A83 RID: 14979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003151")]
	[Address(RVA = "0x8CAB10", Offset = "0x8C9910", VA = "0x1808CAB10")]
	public void Update()
	{
	}

	// Token: 0x06003A84 RID: 14980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003152")]
	[Address(RVA = "0x8CA7D0", Offset = "0x8C95D0", VA = "0x1808CA7D0")]
	public void Close()
	{
	}

	// Token: 0x06003A85 RID: 14981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003153")]
	[Address(RVA = "0x8CA840", Offset = "0x8C9640", VA = "0x1808CA840")]
	public void EnableCursor(bool enable)
	{
	}

	// Token: 0x06003A86 RID: 14982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003154")]
	[Address(RVA = "0x8CAA60", Offset = "0x8C9860", VA = "0x1808CAA60")]
	public void Stop()
	{
	}

	// Token: 0x06003A87 RID: 14983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003155")]
	[Address(RVA = "0x8CAF00", Offset = "0x8C9D00", VA = "0x1808CAF00")]
	public DemoRecorderProgress()
	{
	}

	// Token: 0x04003713 RID: 14099
	[Token(Token = "0x4002A3E")]
	[FieldOffset(Offset = "0x18")]
	public RustText RecordingLabel;

	// Token: 0x04003714 RID: 14100
	[Token(Token = "0x4002A3F")]
	[FieldOffset(Offset = "0x20")]
	public RustText ProgressLabel;

	// Token: 0x04003715 RID: 14101
	[Token(Token = "0x4002A40")]
	[FieldOffset(Offset = "0x28")]
	public GameObject RecordingUnderlay;

	// Token: 0x04003716 RID: 14102
	[Token(Token = "0x4002A41")]
	[FieldOffset(Offset = "0x30")]
	private CanvasGroup canvasGroup;

	// Token: 0x04003717 RID: 14103
	[Token(Token = "0x4002A42")]
	[FieldOffset(Offset = "0x38")]
	private NeedsCursor needsCursor;
}
