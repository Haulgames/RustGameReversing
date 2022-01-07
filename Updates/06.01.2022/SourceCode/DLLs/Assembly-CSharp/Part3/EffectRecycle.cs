using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005E6 RID: 1510
[Token(Token = "0x2000469")]
public class EffectRecycle : BaseMonoBehaviour, IClientComponent, IRagdollInhert, IEffectRecycle, IOnParentDestroying
{
	// Token: 0x06002A0A RID: 10762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002334")]
	[Address(RVA = "0x987FF0", Offset = "0x986DF0", VA = "0x180987FF0")]
	protected void Awake()
	{
	}

	// Token: 0x06002A0B RID: 10763 RVA: 0x000123F0 File Offset: 0x000105F0
	[Token(Token = "0x6002335")]
	[Address(RVA = "0x9881C0", Offset = "0x986FC0", VA = "0x1809881C0")]
	private float GetParticleSystemLength()
	{
		return 0f;
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x00012408 File Offset: 0x00010608
	[Token(Token = "0x6002336")]
	[Address(RVA = "0x988420", Offset = "0x987220", VA = "0x180988420")]
	private float GetSoundLength()
	{
		return 0f;
	}

	// Token: 0x06002A0D RID: 10765 RVA: 0x00012420 File Offset: 0x00010620
	[Token(Token = "0x6002337")]
	[Address(RVA = "0x988340", Offset = "0x987140", VA = "0x180988340")]
	private float GetScreenShakeLength()
	{
		return 0f;
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002338")]
	[Address(RVA = "0x9886F0", Offset = "0x9874F0", VA = "0x1809886F0", Slot = "9")]
	public virtual Transform RagdollInhertTransform()
	{
		return null;
	}

	// Token: 0x06002A0F RID: 10767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002339")]
	[Address(RVA = "0x988600", Offset = "0x987400", VA = "0x180988600", Slot = "10")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600233A")]
	[Address(RVA = "0x988700", Offset = "0x987500", VA = "0x180988700", Slot = "7")]
	public void Recycle()
	{
	}

	// Token: 0x06002A11 RID: 10769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600233B")]
	[Address(RVA = "0x9880A0", Offset = "0x986EA0", VA = "0x1809880A0")]
	private void DetachFromParent()
	{
	}

	// Token: 0x06002A12 RID: 10770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600233C")]
	[Address(RVA = "0x988170", Offset = "0x986F70", VA = "0x180988170")]
	private void DetachWaitRecycle()
	{
	}

	// Token: 0x06002A13 RID: 10771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600233D")]
	[Address(RVA = "0x9886A0", Offset = "0x9874A0", VA = "0x1809886A0", Slot = "8")]
	public void OnParentDestroying()
	{
	}

	// Token: 0x06002A14 RID: 10772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600233E")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public EffectRecycle()
	{
	}

	// Token: 0x04002552 RID: 9554
	[Token(Token = "0x4001E7B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x767D0", Offset = "0x75BD0")]
	[ReadOnly]
	public float detachTime;

	// Token: 0x04002553 RID: 9555
	[Token(Token = "0x4001E7C")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x767D0", Offset = "0x75BD0")]
	[ReadOnly]
	public float recycleTime;

	// Token: 0x04002554 RID: 9556
	[Token(Token = "0x4001E7D")]
	[FieldOffset(Offset = "0x20")]
	public EffectRecycle.PlayMode playMode;

	// Token: 0x04002555 RID: 9557
	[Token(Token = "0x4001E7E")]
	[FieldOffset(Offset = "0x24")]
	public EffectRecycle.ParentDestroyBehaviour onParentDestroyed;

	// Token: 0x04002556 RID: 9558
	[Token(Token = "0x4001E7F")]
	[FieldOffset(Offset = "0x28")]
	private Action recycleAction;

	// Token: 0x04002557 RID: 9559
	[Token(Token = "0x4001E80")]
	[FieldOffset(Offset = "0x30")]
	private Action detachWaitRecycleAction;

	// Token: 0x020005E7 RID: 1511
	[Token(Token = "0x2000BB0")]
	public enum PlayMode
	{
		// Token: 0x04002559 RID: 9561
		[Token(Token = "0x40043E2")]
		Once,
		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x40043E3")]
		Looped
	}

	// Token: 0x020005E8 RID: 1512
	[Token(Token = "0x2000BB1")]
	public enum ParentDestroyBehaviour
	{
		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x40043E5")]
		Detach,
		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x40043E6")]
		Destroy,
		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x40043E7")]
		DetachWaitDestroy
	}
}
