using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007AE RID: 1966
[Token(Token = "0x20005B6")]
public class DecorSpawn : MonoBehaviour, IClientComponent
{
	// Token: 0x06003116 RID: 12566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002972")]
	[Address(RVA = "0x8BFD00", Offset = "0x8BEB00", VA = "0x1808BFD00")]
	public static void SetEnabled(bool b)
	{
	}

	// Token: 0x06003117 RID: 12567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002973")]
	[Address(RVA = "0x8BF890", Offset = "0x8BE690", VA = "0x1808BF890")]
	public static void RefreshAll(bool force = false)
	{
	}

	// Token: 0x06003118 RID: 12568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002974")]
	[Address(RVA = "0x8BFB60", Offset = "0x8BE960", VA = "0x1808BFB60")]
	public static void RemoveAll(bool force = false)
	{
	}

	// Token: 0x06003119 RID: 12569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002975")]
	[Address(RVA = "0x8BF440", Offset = "0x8BE240", VA = "0x1808BF440")]
	public void Remove(bool force = false)
	{
	}

	// Token: 0x0600311A RID: 12570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002976")]
	[Address(RVA = "0x8BFA00", Offset = "0x8BE800", VA = "0x1808BFA00")]
	public void Refresh(bool force = false)
	{
	}

	// Token: 0x0600311B RID: 12571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002977")]
	[Address(RVA = "0x8BF830", Offset = "0x8BE630", VA = "0x1808BF830")]
	[Attribute(Name = "ContextMenu", RVA = "0x996A0", Offset = "0x98AA0")]
	private void RefreshAll_ContextMenu()
	{
	}

	// Token: 0x0600311C RID: 12572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002978")]
	[Address(RVA = "0x8BF9D0", Offset = "0x8BE7D0", VA = "0x1808BF9D0")]
	[Attribute(Name = "ContextMenu", RVA = "0x99740", Offset = "0x98B40")]
	private void Refresh_ContextMenu()
	{
	}

	// Token: 0x0600311D RID: 12573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002979")]
	[Address(RVA = "0x8BF750", Offset = "0x8BE550", VA = "0x1808BF750")]
	protected void OnEnable()
	{
	}

	// Token: 0x0600311E RID: 12574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600297A")]
	[Address(RVA = "0x8BF6A0", Offset = "0x8BE4A0", VA = "0x1808BF6A0")]
	protected void OnDisable()
	{
	}

	// Token: 0x0600311F RID: 12575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600297B")]
	[Address(RVA = "0x8BF4C0", Offset = "0x8BE2C0", VA = "0x1808BF4C0")]
	private void InitPatches()
	{
	}

	// Token: 0x06003120 RID: 12576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600297C")]
	[Address(RVA = "0x8BF440", Offset = "0x8BE240", VA = "0x1808BF440")]
	private void FreePatches()
	{
	}

	// Token: 0x06003121 RID: 12577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600297D")]
	[Address(RVA = "0x8BFD70", Offset = "0x8BEB70", VA = "0x1808BFD70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x99870", Offset = "0x98C70")]
	private IEnumerator UpdateCoroutine()
	{
		return null;
	}

	// Token: 0x06003122 RID: 12578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600297E")]
	[Address(RVA = "0x8BFE50", Offset = "0x8BEC50", VA = "0x1808BFE50")]
	public DecorSpawn()
	{
	}

	// Token: 0x04002DEA RID: 11754
	[Token(Token = "0x4002442")]
	[FieldOffset(Offset = "0x0")]
	public static List<DecorSpawn> Instances;

	// Token: 0x04002DEB RID: 11755
	[Token(Token = "0x4002443")]
	[FieldOffset(Offset = "0x8")]
	private static bool Enabled;

	// Token: 0x04002DEC RID: 11756
	[Token(Token = "0x4002444")]
	[FieldOffset(Offset = "0x18")]
	public SpawnFilter Filter;

	// Token: 0x04002DED RID: 11757
	[Token(Token = "0x4002445")]
	[FieldOffset(Offset = "0x20")]
	public string ResourceFolder;

	// Token: 0x04002DEE RID: 11758
	[Token(Token = "0x4002446")]
	[FieldOffset(Offset = "0x28")]
	public uint Seed;

	// Token: 0x04002DEF RID: 11759
	[Token(Token = "0x4002447")]
	[FieldOffset(Offset = "0x2C")]
	public float ObjectCutoff;

	// Token: 0x04002DF0 RID: 11760
	[Token(Token = "0x4002448")]
	[FieldOffset(Offset = "0x30")]
	public float ObjectTapering;

	// Token: 0x04002DF1 RID: 11761
	[Token(Token = "0x4002449")]
	[FieldOffset(Offset = "0x34")]
	public int ObjectsPerPatch;

	// Token: 0x04002DF2 RID: 11762
	[Token(Token = "0x400244A")]
	[FieldOffset(Offset = "0x38")]
	public float ClusterRadius;

	// Token: 0x04002DF3 RID: 11763
	[Token(Token = "0x400244B")]
	[FieldOffset(Offset = "0x3C")]
	public int ClusterSizeMin;

	// Token: 0x04002DF4 RID: 11764
	[Token(Token = "0x400244C")]
	[FieldOffset(Offset = "0x40")]
	public int ClusterSizeMax;

	// Token: 0x04002DF5 RID: 11765
	[Token(Token = "0x400244D")]
	[FieldOffset(Offset = "0x44")]
	public int PatchCount;

	// Token: 0x04002DF6 RID: 11766
	[Token(Token = "0x400244E")]
	[FieldOffset(Offset = "0x48")]
	public int PatchSize;

	// Token: 0x04002DF7 RID: 11767
	[Token(Token = "0x400244F")]
	[FieldOffset(Offset = "0x4C")]
	public bool LOD;

	// Token: 0x04002DF8 RID: 11768
	[Token(Token = "0x4002450")]
	[FieldOffset(Offset = "0x50")]
	internal Transform Anchor;

	// Token: 0x04002DF9 RID: 11769
	[Token(Token = "0x4002451")]
	[FieldOffset(Offset = "0x58")]
	internal Prefab[] Prefabs;

	// Token: 0x04002DFA RID: 11770
	[Token(Token = "0x4002452")]
	[FieldOffset(Offset = "0x60")]
	private DecorPatch[] patches;

	// Token: 0x020007AF RID: 1967
	[Token(Token = "0x2000C27")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <UpdateCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003124 RID: 12580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F1E")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <UpdateCoroutine>d__28(int <>1__state)
		{
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F1F")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00015090 File Offset: 0x00013290
		[Token(Token = "0x6004F20")]
		[Address(RVA = "0x8D6830", Offset = "0x8D5630", VA = "0x1808D6830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000752")]
		private object Current
		{
			[Token(Token = "0x6004F21")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F22")]
		[Address(RVA = "0x8D6A00", Offset = "0x8D5800", VA = "0x1808D6A00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000753")]
		private object Current
		{
			[Token(Token = "0x6004F23")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04002DFB RID: 11771
		[Token(Token = "0x40046A5")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002DFC RID: 11772
		[Token(Token = "0x40046A6")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002DFD RID: 11773
		[Token(Token = "0x40046A7")]
		[FieldOffset(Offset = "0x20")]
		public DecorSpawn <>4__this;

		// Token: 0x04002DFE RID: 11774
		[Token(Token = "0x40046A8")]
		[FieldOffset(Offset = "0x28")]
		private int <i>5__2;
	}
}
