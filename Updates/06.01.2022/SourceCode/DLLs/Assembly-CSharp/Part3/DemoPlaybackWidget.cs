using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x02000997 RID: 2455
[Token(Token = "0x20006E4")]
public class DemoPlaybackWidget : MonoBehaviour
{
	// Token: 0x06003A1A RID: 14874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030EE")]
	[Address(RVA = "0x8C9C90", Offset = "0x8C8A90", VA = "0x1808C9C90")]
	private void Update()
	{
	}

	// Token: 0x06003A1B RID: 14875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030EF")]
	[Address(RVA = "0x8C9BE0", Offset = "0x8C89E0", VA = "0x1808C9BE0")]
	private void SetRectTransformAnchoredX(float xPos, RectTransform t)
	{
	}

	// Token: 0x06003A1C RID: 14876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F0")]
	[Address(RVA = "0x8C9780", Offset = "0x8C8580", VA = "0x1808C9780")]
	public void OnClickedSlider(float value)
	{
	}

	// Token: 0x06003A1D RID: 14877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F1")]
	[Address(RVA = "0x8C9C40", Offset = "0x8C8A40", VA = "0x1808C9C40")]
	private void TimelineScrubCheck()
	{
	}

	// Token: 0x06003A1E RID: 14878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F2")]
	[Address(RVA = "0x8C9210", Offset = "0x8C8010", VA = "0x1808C9210")]
	public void OnClickedPlay()
	{
	}

	// Token: 0x06003A1F RID: 14879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F3")]
	[Address(RVA = "0x8C9180", Offset = "0x8C7F80", VA = "0x1808C9180")]
	public void OnClickedPause()
	{
	}

	// Token: 0x06003A20 RID: 14880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F4")]
	[Address(RVA = "0x8C8ED0", Offset = "0x8C7CD0", VA = "0x1808C8ED0")]
	public void OnClickedBackToStart()
	{
	}

	// Token: 0x06003A21 RID: 14881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F5")]
	[Address(RVA = "0x8C9A80", Offset = "0x8C8880", VA = "0x1808C9A80")]
	public void OnClickedToEnd()
	{
	}

	// Token: 0x06003A22 RID: 14882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F6")]
	[Address(RVA = "0x8C9050", Offset = "0x8C7E50", VA = "0x1808C9050")]
	public void OnClickedLoop()
	{
	}

	// Token: 0x06003A23 RID: 14883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F7")]
	[Address(RVA = "0x8C8FD0", Offset = "0x8C7DD0", VA = "0x1808C8FD0")]
	public void OnClickedCancelShot()
	{
	}

	// Token: 0x06003A24 RID: 14884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F8")]
	[Address(RVA = "0x8C90E0", Offset = "0x8C7EE0", VA = "0x1808C90E0")]
	public void OnClickedNextFrame()
	{
	}

	// Token: 0x06003A25 RID: 14885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x8CA6D0", Offset = "0x8C94D0", VA = "0x1808CA6D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xCA190", Offset = "0xC9590")]
	private IEnumerator WaitAndPause()
	{
		return null;
	}

	// Token: 0x06003A26 RID: 14886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030FA")]
	[Address(RVA = "0x8C95A0", Offset = "0x8C83A0", VA = "0x1808C95A0")]
	public void OnClickedPreviousFrame()
	{
	}

	// Token: 0x06003A27 RID: 14887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030FB")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DemoPlaybackWidget()
	{
	}

	// Token: 0x040036B1 RID: 14001
	[Token(Token = "0x40029E6")]
	[FieldOffset(Offset = "0x18")]
	public RustSlider DemoProgress;

	// Token: 0x040036B2 RID: 14002
	[Token(Token = "0x40029E7")]
	[FieldOffset(Offset = "0x20")]
	public RustText DemoName;

	// Token: 0x040036B3 RID: 14003
	[Token(Token = "0x40029E8")]
	[FieldOffset(Offset = "0x28")]
	public RustText DemoDuration;

	// Token: 0x040036B4 RID: 14004
	[Token(Token = "0x40029E9")]
	[FieldOffset(Offset = "0x30")]
	public RustText DemoCurrentTime;

	// Token: 0x040036B5 RID: 14005
	[Token(Token = "0x40029EA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PausedRoot;

	// Token: 0x040036B6 RID: 14006
	[Token(Token = "0x40029EB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject PlayingRoot;

	// Token: 0x040036B7 RID: 14007
	[Token(Token = "0x40029EC")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform DemoPlaybackHandle;

	// Token: 0x040036B8 RID: 14008
	[Token(Token = "0x40029ED")]
	[FieldOffset(Offset = "0x50")]
	public RectTransform ShotPlaybackWindow;

	// Token: 0x040036B9 RID: 14009
	[Token(Token = "0x40029EE")]
	[FieldOffset(Offset = "0x58")]
	public RustButton LoopButton;

	// Token: 0x040036BA RID: 14010
	[Token(Token = "0x40029EF")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ShotButtonRoot;

	// Token: 0x040036BB RID: 14011
	[Token(Token = "0x40029F0")]
	[FieldOffset(Offset = "0x68")]
	public RustText ShotNameText;

	// Token: 0x040036BC RID: 14012
	[Token(Token = "0x40029F1")]
	[FieldOffset(Offset = "0x70")]
	public GameObject ShotNameRoot;

	// Token: 0x040036BD RID: 14013
	[Token(Token = "0x40029F2")]
	[FieldOffset(Offset = "0x78")]
	public RectTransform ShotRecordWindow;

	// Token: 0x040036BE RID: 14014
	[Token(Token = "0x40029F3")]
	[FieldOffset(Offset = "0x80")]
	private bool blockProgressInput;

	// Token: 0x040036BF RID: 14015
	[Token(Token = "0x40029F4")]
	[FieldOffset(Offset = "0x81")]
	private bool isDraggingSlider;

	// Token: 0x040036C0 RID: 14016
	[Token(Token = "0x40029F5")]
	[FieldOffset(Offset = "0x84")]
	private RealTimeSince lastDrag;

	// Token: 0x040036C1 RID: 14017
	[Token(Token = "0x40029F6")]
	[FieldOffset(Offset = "0x88")]
	private bool pausedAtStartOfDrag;

	// Token: 0x02000998 RID: 2456
	[Token(Token = "0x2000CDE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <WaitAndPause>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003A28 RID: 14888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A1")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <WaitAndPause>d__28(int <>1__state)
		{
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A2")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x00017940 File Offset: 0x00015B40
		[Token(Token = "0x60050A3")]
		[Address(RVA = "0x8D6A50", Offset = "0x8D5850", VA = "0x1808D6A50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077D")]
		private object Current
		{
			[Token(Token = "0x60050A4")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A5")]
		[Address(RVA = "0x8D6B10", Offset = "0x8D5910", VA = "0x1808D6B10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077E")]
		private object Current
		{
			[Token(Token = "0x60050A6")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040036C2 RID: 14018
		[Token(Token = "0x40049BD")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040036C3 RID: 14019
		[Token(Token = "0x40049BE")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}
}
