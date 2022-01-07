using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200019F RID: 415
[Token(Token = "0x20000FC")]
public class Elevator : IOEntity, IFlagNotify
{
	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06001583 RID: 5507 RVA: 0x0000BF10 File Offset: 0x0000A110
	[Token(Token = "0x1700017F")]
	protected virtual bool IsStatic
	{
		[Token(Token = "0x6001058")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "159")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06001584 RID: 5508 RVA: 0x0000BF28 File Offset: 0x0000A128
	// (set) Token: 0x06001585 RID: 5509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000180")]
	public int Floor
	{
		[Token(Token = "0x6001059")]
		[Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600105A")]
		[Address(RVA = "0x9906F0", Offset = "0x98F4F0", VA = "0x1809906F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06001586 RID: 5510 RVA: 0x0000BF40 File Offset: 0x0000A140
	[Token(Token = "0x17000181")]
	protected bool IsTop
	{
		[Token(Token = "0x600105B")]
		[Address(RVA = "0x4396F0", Offset = "0x4384F0", VA = "0x1804396F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x98F560", Offset = "0x98E360", VA = "0x18098F560", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06001588 RID: 5512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x990300", Offset = "0x98F100", VA = "0x180990300")]
	private void UpdateCable()
	{
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105E")]
	[Address(RVA = "0x98FF90", Offset = "0x98ED90", VA = "0x18098FF90")]
	private void SetCableBounds(float height)
	{
	}

	// Token: 0x0600158A RID: 5514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105F")]
	[Address(RVA = "0x98F3A0", Offset = "0x98E1A0", VA = "0x18098F3A0")]
	private void DisableUpdate()
	{
	}

	// Token: 0x0600158B RID: 5515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x98F2D0", Offset = "0x98E0D0", VA = "0x18098F2D0", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001061")]
	[Address(RVA = "0x990160", Offset = "0x98EF60", VA = "0x180990160", Slot = "62")]
	protected override void SpawnGibs()
	{
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x98F7B0", Offset = "0x98E5B0", VA = "0x18098F7B0", Slot = "80")]
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next)
	{
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x98F410", Offset = "0x98E210", VA = "0x18098F410")]
	private void FindExistingLiftChild()
	{
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x98F630", Offset = "0x98E430", VA = "0x18098F630", Slot = "158")]
	public void OnFlagToggled(bool state)
	{
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x98F270", Offset = "0x98E070", VA = "0x18098F270")]
	public Elevator()
	{
	}

	// Token: 0x04000F2E RID: 3886
	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0x268")]
	public Transform LiftRoot;

	// Token: 0x04000F2F RID: 3887
	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0x270")]
	public GameObjectRef LiftEntityPrefab;

	// Token: 0x04000F30 RID: 3888
	[Token(Token = "0x4000C25")]
	[FieldOffset(Offset = "0x278")]
	public GameObjectRef IoEntityPrefab;

	// Token: 0x04000F31 RID: 3889
	[Token(Token = "0x4000C26")]
	[FieldOffset(Offset = "0x280")]
	public Transform IoEntitySpawnPoint;

	// Token: 0x04000F32 RID: 3890
	[Token(Token = "0x4000C27")]
	[FieldOffset(Offset = "0x288")]
	public GameObject FloorBlockerVolume;

	// Token: 0x04000F33 RID: 3891
	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x290")]
	public float LiftSpeedPerMetre;

	// Token: 0x04000F34 RID: 3892
	[Token(Token = "0x4000C29")]
	[FieldOffset(Offset = "0x298")]
	public GameObject[] PoweredObjects;

	// Token: 0x04000F35 RID: 3893
	[Token(Token = "0x4000C2A")]
	[FieldOffset(Offset = "0x2A0")]
	public MeshRenderer PoweredMesh;

	// Token: 0x04000F36 RID: 3894
	[Token(Token = "0x4000C2B")]
	[FieldOffset(Offset = "0x2A8")]
	[Attribute(Name = "ColorUsageAttribute", RVA = "0x71990", Offset = "0x70D90")]
	public Color PoweredLightColour;

	// Token: 0x04000F37 RID: 3895
	[Token(Token = "0x4000C2C")]
	[FieldOffset(Offset = "0x2B8")]
	[Attribute(Name = "ColorUsageAttribute", RVA = "0x71990", Offset = "0x70D90")]
	public Color UnpoweredLightColour;

	// Token: 0x04000F38 RID: 3896
	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x2C8")]
	public SkinnedMeshRenderer[] CableRenderers;

	// Token: 0x04000F39 RID: 3897
	[Token(Token = "0x4000C2E")]
	[FieldOffset(Offset = "0x2D0")]
	public LODGroup CableLod;

	// Token: 0x04000F3A RID: 3898
	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x2D8")]
	public Transform CableRoot;

	// Token: 0x04000F3B RID: 3899
	[Token(Token = "0x4000C30")]
	[FieldOffset(Offset = "0x2E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <Floor>k__BackingField;

	// Token: 0x04000F3C RID: 3900
	[Token(Token = "0x4000C31")]
	protected const BaseEntity.Flags TopFloorFlag = BaseEntity.Flags.Reserved1;

	// Token: 0x04000F3D RID: 3901
	[Token(Token = "0x4000C32")]
	public const BaseEntity.Flags ElevatorPowered = BaseEntity.Flags.Reserved2;

	// Token: 0x04000F3E RID: 3902
	[Token(Token = "0x4000C33")]
	[FieldOffset(Offset = "0x2E8")]
	private ElevatorLift liftEntity;

	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x2000AD9")]
	public enum Direction
	{
		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x400402A")]
		Up,
		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x400402B")]
		Down
	}
}
