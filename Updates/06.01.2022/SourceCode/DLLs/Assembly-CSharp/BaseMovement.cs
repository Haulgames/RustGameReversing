using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000548 RID: 1352
[Token(Token = "0x20003EA")]
public class BaseMovement : MonoBehaviour
{
	// Token: 0x17000316 RID: 790
	// (get) Token: 0x06002767 RID: 10087 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002768 RID: 10088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DB")]
	public BasePlayer Owner
	{
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x2F9830", Offset = "0x2F8630", VA = "0x1802F9830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x2F96E0", Offset = "0x2F84E0", VA = "0x1802F96E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x06002769 RID: 10089 RVA: 0x000114C0 File Offset: 0x0000F6C0
	// (set) Token: 0x0600276A RID: 10090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DC")]
	public Vector3 InheritedVelocity
	{
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x2F97D0", Offset = "0x2F85D0", VA = "0x1802F97D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x2F98D0", Offset = "0x2F86D0", VA = "0x1802F98D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x0600276B RID: 10091 RVA: 0x000114D8 File Offset: 0x0000F6D8
	// (set) Token: 0x0600276C RID: 10092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DD")]
	public Vector3 TargetMovement
	{
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x2F9880", Offset = "0x2F8680", VA = "0x1802F9880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x2F98F0", Offset = "0x2F86F0", VA = "0x1802F98F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x0600276D RID: 10093 RVA: 0x000114F0 File Offset: 0x0000F6F0
	// (set) Token: 0x0600276E RID: 10094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DE")]
	public float Running
	{
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x2F9870", Offset = "0x2F8670", VA = "0x1802F9870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x2F98E0", Offset = "0x2F86E0", VA = "0x1802F98E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x0600276F RID: 10095 RVA: 0x00011508 File Offset: 0x0000F708
	// (set) Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DF")]
	public float Ducking
	{
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x2F97B0", Offset = "0x2F85B0", VA = "0x1802F97B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x2F98B0", Offset = "0x2F86B0", VA = "0x1802F98B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x06002771 RID: 10097 RVA: 0x00011520 File Offset: 0x0000F720
	// (set) Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E0")]
	public float Crawling
	{
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x2F97A0", Offset = "0x2F85A0", VA = "0x1802F97A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x2F98A0", Offset = "0x2F86A0", VA = "0x1802F98A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x06002773 RID: 10099 RVA: 0x00011538 File Offset: 0x0000F738
	// (set) Token: 0x06002774 RID: 10100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E1")]
	public float Grounded
	{
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x2F97C0", Offset = "0x2F85C0", VA = "0x1802F97C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x2F98C0", Offset = "0x2F86C0", VA = "0x1802F98C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x06002775 RID: 10101 RVA: 0x00011550 File Offset: 0x0000F750
	[Token(Token = "0x170002E2")]
	public bool IsRunning
	{
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x2F9820", Offset = "0x2F8620", VA = "0x1802F9820")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x06002776 RID: 10102 RVA: 0x00011568 File Offset: 0x0000F768
	[Token(Token = "0x170002E3")]
	public bool IsDucked
	{
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x2F9800", Offset = "0x2F8600", VA = "0x1802F9800")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x06002777 RID: 10103 RVA: 0x00011580 File Offset: 0x0000F780
	[Token(Token = "0x170002E4")]
	public bool IsCrawling
	{
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x2F97F0", Offset = "0x2F85F0", VA = "0x1802F97F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x06002778 RID: 10104 RVA: 0x00011598 File Offset: 0x0000F798
	[Token(Token = "0x170002E5")]
	public bool IsGrounded
	{
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x2F9810", Offset = "0x2F8610", VA = "0x1802F9810")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x000115B0 File Offset: 0x0000F7B0
	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x2F9410", Offset = "0x2F8210", VA = "0x1802F9410", Slot = "4")]
	public virtual Vector3 CurrentVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x0600277A RID: 10106 RVA: 0x000115C8 File Offset: 0x0000F7C8
	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "5")]
	public virtual float CurrentMoveSpeed()
	{
		return 0f;
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "6")]
	public virtual Collider GetCollider()
	{
		return null;
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x2F96E0", Offset = "0x2F84E0", VA = "0x1802F96E0", Slot = "7")]
	public virtual void Init(BasePlayer player)
	{
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "8")]
	public virtual void BlockJump(float duration)
	{
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "9")]
	public virtual void BlockSprint(float duration)
	{
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x0600277F RID: 10111 RVA: 0x000115E0 File Offset: 0x0000F7E0
	[Token(Token = "0x170002E6")]
	public bool RecentlyTeleported
	{
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x2F9840", Offset = "0x2F8640", VA = "0x1802F9840")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E8")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "10")]
	public virtual void ClientInput(InputState state, ModelState modelState)
	{
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E9")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "11")]
	public virtual void DoFixedUpdate(ModelState modelState)
	{
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020EA")]
	[Address(RVA = "0x2F9590", Offset = "0x2F8390", VA = "0x1802F9590", Slot = "12")]
	public virtual void FrameUpdate(BasePlayer player, ModelState modelState)
	{
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x2F96F0", Offset = "0x2F84F0", VA = "0x1802F96F0", Slot = "13")]
	public virtual void TeleportTo(Vector3 position, BasePlayer player)
	{
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "14")]
	public virtual void Push(Vector3 velocity)
	{
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "15")]
	public virtual void SetParent(Transform parent)
	{
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x2F9480", Offset = "0x2F8280", VA = "0x1802F9480")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "16")]
	public virtual void PlayerAttemptedMount()
	{
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "17")]
	public virtual void PlayerCompletedMount()
	{
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x2F9790", Offset = "0x2F8590", VA = "0x1802F9790")]
	public BaseMovement()
	{
	}

	// Token: 0x04002277 RID: 8823
	[Token(Token = "0x4001C13")]
	[FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public bool adminCheat;

	// Token: 0x04002278 RID: 8824
	[Token(Token = "0x4001C14")]
	[FieldOffset(Offset = "0x1C")]
	[NonSerialized]
	public float adminSpeed;

	// Token: 0x04002279 RID: 8825
	[Token(Token = "0x4001C15")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BasePlayer <Owner>k__BackingField;

	// Token: 0x0400227A RID: 8826
	[Token(Token = "0x4001C16")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private Vector3 <InheritedVelocity>k__BackingField;

	// Token: 0x0400227B RID: 8827
	[Token(Token = "0x4001C17")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private Vector3 <TargetMovement>k__BackingField;

	// Token: 0x0400227C RID: 8828
	[Token(Token = "0x4001C18")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <Running>k__BackingField;

	// Token: 0x0400227D RID: 8829
	[Token(Token = "0x4001C19")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <Ducking>k__BackingField;

	// Token: 0x0400227E RID: 8830
	[Token(Token = "0x4001C1A")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <Crawling>k__BackingField;

	// Token: 0x0400227F RID: 8831
	[Token(Token = "0x4001C1B")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <Grounded>k__BackingField;

	// Token: 0x04002280 RID: 8832
	[Token(Token = "0x4001C1C")]
	private const float RECENTLY_TELEPORTED_TIME = 1f;

	// Token: 0x04002281 RID: 8833
	[Token(Token = "0x4001C1D")]
	[FieldOffset(Offset = "0x50")]
	private float lastTeleportedTime;
}
