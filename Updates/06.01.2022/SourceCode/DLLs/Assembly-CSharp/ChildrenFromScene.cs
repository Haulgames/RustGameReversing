using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000981 RID: 2433
[Token(Token = "0x20006D3")]
public class ChildrenFromScene : MonoBehaviour
{
	// Token: 0x060039C5 RID: 14789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60030A9")]
	[Address(RVA = "0x4DAB10", Offset = "0x4D9910", VA = "0x1804DAB10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xC94E0", Offset = "0xC88E0")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x060039C6 RID: 14790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030AA")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public ChildrenFromScene()
	{
	}

	// Token: 0x0400367D RID: 13949
	[Token(Token = "0x40029C2")]
	[FieldOffset(Offset = "0x18")]
	public string SceneName;

	// Token: 0x0400367E RID: 13950
	[Token(Token = "0x40029C3")]
	[FieldOffset(Offset = "0x20")]
	public bool StartChildrenDisabled;

	// Token: 0x02000982 RID: 2434
	[Token(Token = "0x2000CD9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060039C7 RID: 14791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005091")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <Start>d__2(int <>1__state)
		{
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005092")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x00017898 File Offset: 0x00015A98
		[Token(Token = "0x6005093")]
		[Address(RVA = "0x4F2BC0", Offset = "0x4F19C0", VA = "0x1804F2BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000779")]
		private object Current
		{
			[Token(Token = "0x6005094")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005095")]
		[Address(RVA = "0x4F2F10", Offset = "0x4F1D10", VA = "0x1804F2F10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077A")]
		private object Current
		{
			[Token(Token = "0x6005096")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400367F RID: 13951
		[Token(Token = "0x40049AD")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003680 RID: 13952
		[Token(Token = "0x40049AE")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04003681 RID: 13953
		[Token(Token = "0x40049AF")]
		[FieldOffset(Offset = "0x20")]
		public ChildrenFromScene <>4__this;
	}
}
