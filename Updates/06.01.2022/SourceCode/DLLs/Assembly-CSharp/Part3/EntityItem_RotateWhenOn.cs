using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A6 RID: 1190
[Token(Token = "0x2000373")]
public class EntityItem_RotateWhenOn : EntityComponent<BaseEntity>, IOnPostNetworkUpdate
{
	// Token: 0x0600245A RID: 9306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x850510", Offset = "0x84F310", VA = "0x180850510")]
	private void OnEnable()
	{
	}

	// Token: 0x0600245B RID: 9307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0x850320", Offset = "0x84F120", VA = "0x180850320")]
	private void DoInitialize(BaseEntity entity)
	{
	}

	// Token: 0x0600245C RID: 9308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x8505B0", Offset = "0x84F3B0", VA = "0x1808505B0", Slot = "10")]
	public void OnPostNetworkUpdate(BaseEntity entity)
	{
	}

	// Token: 0x0600245D RID: 9309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E01")]
	[Address(RVA = "0x850430", Offset = "0x84F230", VA = "0x180850430")]
	public void DoOpen()
	{
	}

	// Token: 0x0600245E RID: 9310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E02")]
	[Address(RVA = "0x850240", Offset = "0x84F040", VA = "0x180850240")]
	public void DoClose()
	{
	}

	// Token: 0x0600245F RID: 9311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E03")]
	[Address(RVA = "0x850960", Offset = "0x84F760", VA = "0x180850960")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xD0980", Offset = "0xCFD80")]
	private IEnumerator RotateTo(EntityItem_RotateWhenOn.State state)
	{
		return null;
	}

	// Token: 0x06002460 RID: 9312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E04")]
	[Address(RVA = "0x8509F0", Offset = "0x84F7F0", VA = "0x1808509F0")]
	public EntityItem_RotateWhenOn()
	{
	}

	// Token: 0x04001E9B RID: 7835
	[Token(Token = "0x4001913")]
	[FieldOffset(Offset = "0x20")]
	public EntityItem_RotateWhenOn.State on;

	// Token: 0x04001E9C RID: 7836
	[Token(Token = "0x4001914")]
	[FieldOffset(Offset = "0x28")]
	public EntityItem_RotateWhenOn.State off;

	// Token: 0x04001E9D RID: 7837
	[Token(Token = "0x4001915")]
	[FieldOffset(Offset = "0x30")]
	internal bool currentlyOn;

	// Token: 0x04001E9E RID: 7838
	[Token(Token = "0x4001916")]
	[FieldOffset(Offset = "0x31")]
	internal bool stateInitialized;

	// Token: 0x04001E9F RID: 7839
	[Token(Token = "0x4001917")]
	[FieldOffset(Offset = "0x34")]
	public BaseEntity.Flags targetFlag;

	// Token: 0x04001EA0 RID: 7840
	[Token(Token = "0x4001918")]
	[FieldOffset(Offset = "0x38")]
	private Sound movementLoop;

	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x2000B68")]
	[Serializable]
	public class State
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DDA")]
		[Address(RVA = "0x864610", Offset = "0x863410", VA = "0x180864610")]
		public State()
		{
		}

		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x400429E")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 rotation;

		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x400429F")]
		[FieldOffset(Offset = "0x1C")]
		public float initialDelay;

		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x40042A0")]
		[FieldOffset(Offset = "0x20")]
		public float timeToTake;

		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x40042A1")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve animationCurve;

		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x40042A2")]
		[FieldOffset(Offset = "0x30")]
		public string effectOnStart;

		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x40042A3")]
		[FieldOffset(Offset = "0x38")]
		public string effectOnFinish;

		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x40042A4")]
		[FieldOffset(Offset = "0x40")]
		public SoundDefinition movementLoop;

		// Token: 0x04001EA8 RID: 7848
		[Token(Token = "0x40042A5")]
		[FieldOffset(Offset = "0x48")]
		public float movementLoopFadeOutTime;

		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x40042A6")]
		[FieldOffset(Offset = "0x50")]
		public SoundDefinition startSound;

		// Token: 0x04001EAA RID: 7850
		[Token(Token = "0x40042A7")]
		[FieldOffset(Offset = "0x58")]
		public SoundDefinition stopSound;
	}

	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x2000B69")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <RotateTo>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002462 RID: 9314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DDB")]
		[Address(RVA = "0x3A33C0", Offset = "0x3A21C0", VA = "0x1803A33C0")]
		[DebuggerHidden]
		public <RotateTo>d__12(int <>1__state)
		{
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DDC")]
		[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x6004DDD")]
		[Address(RVA = "0x866CF0", Offset = "0x865AF0", VA = "0x180866CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071E")]
		private object Current
		{
			[Token(Token = "0x6004DDE")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DDF")]
		[Address(RVA = "0x867450", Offset = "0x866250", VA = "0x180867450", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071F")]
		private object Current
		{
			[Token(Token = "0x6004DE0")]
			[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001EAB RID: 7851
		[Token(Token = "0x40042A8")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001EAC RID: 7852
		[Token(Token = "0x40042A9")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001EAD RID: 7853
		[Token(Token = "0x40042AA")]
		[FieldOffset(Offset = "0x20")]
		public EntityItem_RotateWhenOn <>4__this;

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x40042AB")]
		[FieldOffset(Offset = "0x28")]
		public EntityItem_RotateWhenOn.State state;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x40042AC")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion <start>5__2;

		// Token: 0x04001EB0 RID: 7856
		[Token(Token = "0x40042AD")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion <target>5__3;

		// Token: 0x04001EB1 RID: 7857
		[Token(Token = "0x40042AE")]
		[FieldOffset(Offset = "0x50")]
		private bool <effectsStarted>5__4;

		// Token: 0x04001EB2 RID: 7858
		[Token(Token = "0x40042AF")]
		[FieldOffset(Offset = "0x54")]
		private float <TimeTaken>5__5;
	}
}
