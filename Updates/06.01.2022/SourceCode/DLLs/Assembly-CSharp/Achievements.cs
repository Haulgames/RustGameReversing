using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000978 RID: 2424
[Token(Token = "0x20006CB")]
public class Achievements : SingletonComponent<Achievements>
{
	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x0600397D RID: 14717 RVA: 0x000177F0 File Offset: 0x000159F0
	[Token(Token = "0x17000425")]
	public bool IsOpen
	{
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x7AE220", Offset = "0x7AD020", VA = "0x1807AE220")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600397E RID: 14718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003068")]
	[Address(RVA = "0x81B210", Offset = "0x81A010", VA = "0x18081B210")]
	public void OnEnable()
	{
	}

	// Token: 0x0600397F RID: 14719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003069")]
	[Address(RVA = "0x81AE50", Offset = "0x819C50", VA = "0x18081AE50")]
	private void ClientConnected()
	{
	}

	// Token: 0x06003980 RID: 14720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306A")]
	[Address(RVA = "0x81B310", Offset = "0x81A110", VA = "0x18081B310")]
	public void Reset()
	{
	}

	// Token: 0x06003981 RID: 14721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600306B")]
	[Address(RVA = "0x81B8C0", Offset = "0x81A6C0", VA = "0x18081B8C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xC8CF0", Offset = "0xC80F0")]
	private IEnumerator Think()
	{
		return null;
	}

	// Token: 0x06003982 RID: 14722 RVA: 0x00017808 File Offset: 0x00015A08
	[Token(Token = "0x600306C")]
	[Address(RVA = "0x81B390", Offset = "0x81A190", VA = "0x18081B390")]
	public bool ShouldShow()
	{
		return default(bool);
	}

	// Token: 0x06003983 RID: 14723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306D")]
	[Address(RVA = "0x81AE60", Offset = "0x819C60", VA = "0x18081AE60")]
	public void Hide()
	{
	}

	// Token: 0x06003984 RID: 14724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306E")]
	[Address(RVA = "0x81B540", Offset = "0x81A340", VA = "0x18081B540")]
	private void Show()
	{
	}

	// Token: 0x06003985 RID: 14725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600306F")]
	[Address(RVA = "0x81AFE0", Offset = "0x819DE0", VA = "0x18081AFE0")]
	public void Initialize()
	{
	}

	// Token: 0x06003986 RID: 14726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003070")]
	[Address(RVA = "0x81B710", Offset = "0x81A510", VA = "0x18081B710")]
	private void SwitchToGroup(AchievementGroup group)
	{
	}

	// Token: 0x06003987 RID: 14727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003071")]
	[Address(RVA = "0x81B270", Offset = "0x81A070", VA = "0x18081B270")]
	public void OnItemComplete()
	{
	}

	// Token: 0x06003988 RID: 14728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003072")]
	[Address(RVA = "0x81AAF0", Offset = "0x8198F0", VA = "0x18081AAF0")]
	public void CheckForListComplete()
	{
	}

	// Token: 0x06003989 RID: 14729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003073")]
	[Address(RVA = "0x7ACBD0", Offset = "0x7AB9D0", VA = "0x1807ACBD0")]
	public void BlockNextOpenSound()
	{
	}

	// Token: 0x0600398A RID: 14730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003074")]
	[Address(RVA = "0x81B930", Offset = "0x81A730", VA = "0x18081B930")]
	public Achievements()
	{
	}

	// Token: 0x04003651 RID: 13905
	[Token(Token = "0x4002999")]
	[FieldOffset(Offset = "0x18")]
	public SoundDefinition listComplete;

	// Token: 0x04003652 RID: 13906
	[Token(Token = "0x400299A")]
	[FieldOffset(Offset = "0x20")]
	public SoundDefinition itemComplete;

	// Token: 0x04003653 RID: 13907
	[Token(Token = "0x400299B")]
	[FieldOffset(Offset = "0x28")]
	public SoundDefinition popup;

	// Token: 0x04003654 RID: 13908
	[Token(Token = "0x400299C")]
	[FieldOffset(Offset = "0x30")]
	public Canvas Canvas;

	// Token: 0x04003655 RID: 13909
	[Token(Token = "0x400299D")]
	[FieldOffset(Offset = "0x38")]
	public Text titleText;

	// Token: 0x04003656 RID: 13910
	[Token(Token = "0x400299E")]
	[FieldOffset(Offset = "0x40")]
	private AchievementTodo[] items;

	// Token: 0x04003657 RID: 13911
	[Token(Token = "0x400299F")]
	[FieldOffset(Offset = "0x48")]
	private bool blockOpenSound;

	// Token: 0x02000979 RID: 2425
	[Token(Token = "0x2000CD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <Think>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600398B RID: 14731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508B")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <Think>d__12(int <>1__state)
		{
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508C")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x00017820 File Offset: 0x00015A20
		[Token(Token = "0x600508D")]
		[Address(RVA = "0x82FA40", Offset = "0x82E840", VA = "0x18082FA40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600398E RID: 14734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000777")]
		private object Current
		{
			[Token(Token = "0x600508E")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508F")]
		[Address(RVA = "0x82FCC0", Offset = "0x82EAC0", VA = "0x18082FCC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06003990 RID: 14736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000778")]
		private object Current
		{
			[Token(Token = "0x6005090")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04003658 RID: 13912
		[Token(Token = "0x40049AA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003659 RID: 13913
		[Token(Token = "0x40049AB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400365A RID: 13914
		[Token(Token = "0x40049AC")]
		[FieldOffset(Offset = "0x20")]
		public Achievements <>4__this;
	}
}
