using System;
using Il2CppDummyDll;
using Rust.UI;
using UnityEngine;

// Token: 0x02000A79 RID: 2681
[Token(Token = "0x200078A")]
public class CompanionSetupScreen : SingletonComponent<CompanionSetupScreen>
{
	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x06003F58 RID: 16216 RVA: 0x00018690 File Offset: 0x00016890
	// (set) Token: 0x06003F59 RID: 16217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000458")]
	public CompanionSetupScreen.ScreenState State
	{
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x4A4DA0", Offset = "0x4A3BA0", VA = "0x1804A4DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return CompanionSetupScreen.ScreenState.Loading;
		}
		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x4A4DB0", Offset = "0x4A3BB0", VA = "0x1804A4DB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AD")]
	[Address(RVA = "0x4A4670", Offset = "0x4A3470", VA = "0x1804A4670")]
	public void OnEnable()
	{
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AE")]
	[Address(RVA = "0x4A4880", Offset = "0x4A3680", VA = "0x1804A4880")]
	public void Refresh()
	{
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AF")]
	[Address(RVA = "0x4A47B0", Offset = "0x4A35B0", VA = "0x1804A47B0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE2A20", Offset = "0xE1E20")]
	public void RefreshImpl()
	{
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B0")]
	[Address(RVA = "0x4A4450", Offset = "0x4A3250", VA = "0x1804A4450")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE3EF0", Offset = "0xE32F0")]
	public void Enable()
	{
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B1")]
	[Address(RVA = "0x4A4380", Offset = "0x4A3180", VA = "0x1804A4380")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE3FD0", Offset = "0xE33D0")]
	public void Disable()
	{
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B2")]
	[Address(RVA = "0x4A46C0", Offset = "0x4A34C0", VA = "0x1804A46C0")]
	public void Pair()
	{
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B3")]
	[Address(RVA = "0x4A4D10", Offset = "0x4A3B10", VA = "0x1804A4D10")]
	private void ResetPair()
	{
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B4")]
	[Address(RVA = "0x4A4680", Offset = "0x4A3480", VA = "0x1804A4680")]
	public void OpenVideo()
	{
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B5")]
	[Address(RVA = "0x4A4520", Offset = "0x4A3320", VA = "0x1804A4520")]
	public void HelpPressed()
	{
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B6")]
	[Address(RVA = "0x4A4670", Offset = "0x4A3470", VA = "0x1804A4670")]
	public void HelpReleased()
	{
	}

	// Token: 0x06003F64 RID: 16228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B7")]
	[Address(RVA = "0x4A4D30", Offset = "0x4A3B30", VA = "0x1804A4D30")]
	private void UpdateUI()
	{
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B8")]
	[Address(RVA = "0x4A4140", Offset = "0x4A2F40", VA = "0x1804A4140")]
	public void ChangeState(CompanionSetupScreen.ScreenState state)
	{
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B9")]
	[Address(RVA = "0x4A4D40", Offset = "0x4A3B40", VA = "0x1804A4D40")]
	public CompanionSetupScreen()
	{
	}

	// Token: 0x04003C97 RID: 15511
	[Token(Token = "0x4002F07")]
	public const string PairedKey = "companionPaired";

	// Token: 0x04003C98 RID: 15512
	[Token(Token = "0x4002F08")]
	[FieldOffset(Offset = "0x18")]
	public GameObject instructionsBody;

	// Token: 0x04003C99 RID: 15513
	[Token(Token = "0x4002F09")]
	[FieldOffset(Offset = "0x20")]
	public GameObject detailsPanel;

	// Token: 0x04003C9A RID: 15514
	[Token(Token = "0x4002F0A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject loadingMessage;

	// Token: 0x04003C9B RID: 15515
	[Token(Token = "0x4002F0B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject errorMessage;

	// Token: 0x04003C9C RID: 15516
	[Token(Token = "0x4002F0C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject notSupportedMessage;

	// Token: 0x04003C9D RID: 15517
	[Token(Token = "0x4002F0D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject disabledMessage;

	// Token: 0x04003C9E RID: 15518
	[Token(Token = "0x4002F0E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject enabledMessage;

	// Token: 0x04003C9F RID: 15519
	[Token(Token = "0x4002F0F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject refreshButton;

	// Token: 0x04003CA0 RID: 15520
	[Token(Token = "0x4002F10")]
	[FieldOffset(Offset = "0x58")]
	public GameObject enableButton;

	// Token: 0x04003CA1 RID: 15521
	[Token(Token = "0x4002F11")]
	[FieldOffset(Offset = "0x60")]
	public GameObject disableButton;

	// Token: 0x04003CA2 RID: 15522
	[Token(Token = "0x4002F12")]
	[FieldOffset(Offset = "0x68")]
	public GameObject pairButton;

	// Token: 0x04003CA3 RID: 15523
	[Token(Token = "0x4002F13")]
	[FieldOffset(Offset = "0x70")]
	public RustText serverName;

	// Token: 0x04003CA4 RID: 15524
	[Token(Token = "0x4002F14")]
	[FieldOffset(Offset = "0x78")]
	public RustButton helpButton;

	// Token: 0x04003CA5 RID: 15525
	[Token(Token = "0x4002F15")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private CompanionSetupScreen.ScreenState <State>k__BackingField;

	// Token: 0x04003CA6 RID: 15526
	[Token(Token = "0x4002F16")]
	[FieldOffset(Offset = "0x84")]
	private bool _isLoading;

	// Token: 0x04003CA7 RID: 15527
	[Token(Token = "0x4002F17")]
	[FieldOffset(Offset = "0x85")]
	private bool? _enabled;

	// Token: 0x04003CA8 RID: 15528
	[Token(Token = "0x4002F18")]
	[FieldOffset(Offset = "0x87")]
	private bool _hidePair;

	// Token: 0x02000A7A RID: 2682
	[Token(Token = "0x2000D18")]
	public enum ScreenState
	{
		// Token: 0x04003CAA RID: 15530
		[Token(Token = "0x4004A7B")]
		Loading,
		// Token: 0x04003CAB RID: 15531
		[Token(Token = "0x4004A7C")]
		Error,
		// Token: 0x04003CAC RID: 15532
		[Token(Token = "0x4004A7D")]
		NoServer,
		// Token: 0x04003CAD RID: 15533
		[Token(Token = "0x4004A7E")]
		NotSupported,
		// Token: 0x04003CAE RID: 15534
		[Token(Token = "0x4004A7F")]
		NotInstalled,
		// Token: 0x04003CAF RID: 15535
		[Token(Token = "0x4004A80")]
		Disabled,
		// Token: 0x04003CB0 RID: 15536
		[Token(Token = "0x4004A81")]
		Enabled,
		// Token: 0x04003CB1 RID: 15537
		[Token(Token = "0x4004A82")]
		ShowHelp
	}
}
