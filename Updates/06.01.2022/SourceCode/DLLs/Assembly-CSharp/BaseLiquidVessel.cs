using System;
using Il2CppDummyDll;
using Network;

// Token: 0x02000108 RID: 264
[Token(Token = "0x200009F")]
public class BaseLiquidVessel : AttackEntity
{
	// Token: 0x06001013 RID: 4115 RVA: 0x00009738 File Offset: 0x00007938
	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x2F05F0", Offset = "0x2EF3F0", VA = "0x1802F05F0", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x00009750 File Offset: 0x00007950
	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x2EF5F0", Offset = "0x2EE3F0", VA = "0x1802EF5F0")]
	public int AmountHeld()
	{
		return 0;
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00009768 File Offset: 0x00007968
	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x2EFD10", Offset = "0x2EEB10", VA = "0x1802EFD10")]
	public float HeldFraction()
	{
		return 0f;
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00009780 File Offset: 0x00007980
	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x2EFDE0", Offset = "0x2EEBE0", VA = "0x1802EFDE0")]
	public int MaxHoldable()
	{
		return 0;
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00009798 File Offset: 0x00007998
	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x2EF820", Offset = "0x2EE620", VA = "0x1802EF820")]
	public bool CanDrink()
	{
		return default(bool);
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x000097B0 File Offset: 0x000079B0
	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0x2EFDB0", Offset = "0x2EEBB0", VA = "0x1802EFDB0")]
	private bool IsWeaponBusy()
	{
		return default(bool);
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8F")]
	[Address(RVA = "0x2F1210", Offset = "0x2F0010", VA = "0x1802F1210")]
	private void SetBusyFor(float dur)
	{
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x2EFA10", Offset = "0x2EE810", VA = "0x1802EFA10")]
	private void ClearBusy()
	{
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B91")]
	[Address(RVA = "0x2EF700", Offset = "0x2EE500", VA = "0x1802EF700", Slot = "159")]
	public virtual void CLThrow()
	{
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x2EFE80", Offset = "0x2EEC80", VA = "0x1802EFE80", Slot = "137")]
	public override void OnInput()
	{
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B93")]
	[Address(RVA = "0x2EFA40", Offset = "0x2EE840", VA = "0x1802EFA40", Slot = "160")]
	public virtual void DoSendFilling(bool flag)
	{
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "161")]
	public virtual void OnPrimaryAttackPressed()
	{
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "162")]
	public virtual void OnEmptyPrimaryAttackPressed()
	{
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B96")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "163")]
	public virtual void OnPrimaryAttackReleased()
	{
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B97")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "164")]
	public virtual void OnReloadPressed()
	{
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B98")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "165")]
	public virtual void OnReloadHeld()
	{
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B99")]
	[Address(RVA = "0x2F03F0", Offset = "0x2EF1F0", VA = "0x1802F03F0", Slot = "166")]
	public virtual void OnPrimaryAttackHeld(Item ammo, BasePlayer player)
	{
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9A")]
	[Address(RVA = "0x2F10C0", Offset = "0x2EFEC0", VA = "0x1802F10C0", Slot = "143")]
	public override void OnViewmodelEvent(string name)
	{
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9B")]
	[Address(RVA = "0x2EF630", Offset = "0x2EE430", VA = "0x1802EF630")]
	[BaseEntity.RPC_Client]
	public void CLIENT_StartFillingSoundsContainer(BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0x2EF640", Offset = "0x2EE440", VA = "0x1802EF640")]
	[BaseEntity.RPC_Client]
	public void CLIENT_StartFillingSoundsWorld(BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0x2F1240", Offset = "0x2F0040", VA = "0x1802F1240")]
	private void StartFillingSounds(bool fromContainer = true)
	{
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0x2EF650", Offset = "0x2EE450", VA = "0x1802EF650")]
	[BaseEntity.RPC_Client]
	public void CLIENT_StopFillingSounds(BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9F")]
	[Address(RVA = "0x2EF650", Offset = "0x2EE450", VA = "0x1802EF650")]
	private void StopFillingSounds()
	{
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x2F1160", Offset = "0x2EFF60", VA = "0x1802F1160", Slot = "152")]
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x000097C8 File Offset: 0x000079C8
	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x2EF900", Offset = "0x2EE700", VA = "0x1802EF900")]
	public bool CanFillFromWorld()
	{
		return default(bool);
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x000097E0 File Offset: 0x000079E0
	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0x2EF9F0", Offset = "0x2EE7F0", VA = "0x1802EF9F0")]
	public bool CanThrow()
	{
		return default(bool);
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x2EFA90", Offset = "0x2EE890", VA = "0x1802EFA90")]
	public LiquidContainer GetFacingLiquidContainer()
	{
		return null;
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x2F1520", Offset = "0x2F0320", VA = "0x1802F1520")]
	public BaseLiquidVessel()
	{
	}

	// Token: 0x04000A5C RID: 2652
	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x278")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x87A10", Offset = "0x86E10")]
	public GameObjectRef thrownWaterObject;

	// Token: 0x04000A5D RID: 2653
	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x280")]
	public GameObjectRef ThrowEffect3P;

	// Token: 0x04000A5E RID: 2654
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x288")]
	public SoundDefinition throwSound3P;

	// Token: 0x04000A5F RID: 2655
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0x290")]
	public GameObjectRef fillFromContainer;

	// Token: 0x04000A60 RID: 2656
	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x298")]
	public GameObjectRef fillFromWorld;

	// Token: 0x04000A61 RID: 2657
	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x2A0")]
	public SoundDefinition fillFromContainerStartSoundDef;

	// Token: 0x04000A62 RID: 2658
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x2A8")]
	public SoundDefinition fillFromContainerSoundDef;

	// Token: 0x04000A63 RID: 2659
	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x2B0")]
	public SoundDefinition fillFromWorldStartSoundDef;

	// Token: 0x04000A64 RID: 2660
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x2B8")]
	public SoundDefinition fillFromWorldSoundDef;

	// Token: 0x04000A65 RID: 2661
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x2C0")]
	public bool hasLid;

	// Token: 0x04000A66 RID: 2662
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x2C4")]
	public float throwScale;

	// Token: 0x04000A67 RID: 2663
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x2C8")]
	public bool canDrinkFrom;

	// Token: 0x04000A68 RID: 2664
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x2C9")]
	public bool updateVMWater;

	// Token: 0x04000A69 RID: 2665
	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x2CC")]
	public float minThrowFrac;

	// Token: 0x04000A6A RID: 2666
	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x2D0")]
	public bool useThrowAnim;

	// Token: 0x04000A6B RID: 2667
	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x2D4")]
	public float fillMlPerSec;

	// Token: 0x04000A6C RID: 2668
	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x2D8")]
	private Sound fillSound;

	// Token: 0x04000A6D RID: 2669
	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x2E0")]
	private float timeSinceLastAttack;

	// Token: 0x04000A6E RID: 2670
	[Token(Token = "0x4000885")]
	[FieldOffset(Offset = "0x2E4")]
	private bool wasFilling;

	// Token: 0x04000A6F RID: 2671
	[Token(Token = "0x4000886")]
	[FieldOffset(Offset = "0x2E8")]
	private float nextFreeTime;
}
