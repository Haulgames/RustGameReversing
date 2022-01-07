using System;
using Il2CppDummyDll;

// Token: 0x02000497 RID: 1175
[Token(Token = "0x2000365")]
public class AnimatedBuildingBlock : StabilityEntity
{
	// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DD6")]
	[Address(RVA = "0x831A10", Offset = "0x830810", VA = "0x180831A10", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x831C60", Offset = "0x830A60", VA = "0x180831C60")]
	private void SetBatching(bool state)
	{
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x831A80", Offset = "0x830880", VA = "0x180831A80", Slot = "80")]
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next)
	{
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x831CA0", Offset = "0x830AA0", VA = "0x180831CA0")]
	protected void UpdateAnimationParameters(bool init)
	{
	}

	// Token: 0x06002436 RID: 9270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x831A40", Offset = "0x830840", VA = "0x180831A40")]
	protected void OnAnimatorFinished()
	{
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x831AB0", Offset = "0x8308B0", VA = "0x180831AB0")]
	private void PutAnimatorToSleep()
	{
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "144")]
	protected virtual void OnAnimatorDisabled()
	{
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x00010248 File Offset: 0x0000E448
	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "128")]
	public override bool SupportsChildDeployables()
	{
		return default(bool);
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x831F50", Offset = "0x830D50", VA = "0x180831F50")]
	public AnimatedBuildingBlock()
	{
	}

	// Token: 0x04001E7D RID: 7805
	[Token(Token = "0x40018FA")]
	[FieldOffset(Offset = "0x260")]
	private bool animatorNeedsInitializing;

	// Token: 0x04001E7E RID: 7806
	[Token(Token = "0x40018FB")]
	[FieldOffset(Offset = "0x261")]
	private bool animatorIsOpen;

	// Token: 0x04001E7F RID: 7807
	[Token(Token = "0x40018FC")]
	[FieldOffset(Offset = "0x262")]
	private bool isAnimating;
}
