using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000038")]
public class BaseHelicopterVehicle : global::BaseVehicle
{
	// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2EE140", Offset = "0x2ECF40", VA = "0x1802EE140", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600060E RID: 1550 RVA: 0x000030D8 File Offset: 0x000012D8
	[Token(Token = "0x17000027")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2EEE70", Offset = "0x2EDC70", VA = "0x1802EEE70", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2EE6F0", Offset = "0x2ED4F0", VA = "0x1802EE6F0", Slot = "190")]
	public virtual void UpdateEffects()
	{
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2EE0A0", Offset = "0x2ECEA0", VA = "0x1802EE0A0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2EE460", Offset = "0x2ED260", VA = "0x1802EE460")]
	public void InitializeClientsideEffects()
	{
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2EE6B0", Offset = "0x2ED4B0", VA = "0x1802EE6B0", Slot = "191")]
	[Attribute(Name = "Menu", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "Description", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "Icon", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "ShowIf", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	public virtual void Menu_Push(global::BasePlayer player)
	{
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2EEE00", Offset = "0x2EDC00", VA = "0x1802EEE00")]
	public BaseHelicopterVehicle()
	{
	}

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x3A8")]
	private Option __menuOption_Menu_Push;

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x400")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA56A0", Offset = "0xA4AA0")]
	public float engineThrustMax;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x404")]
	public Vector3 torqueScale;

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x410")]
	public Transform com;

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x418")]
	public GameObject[] killTriggers;

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x420")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x880D0", Offset = "0x874D0")]
	public Transform[] GroundPoints;

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x428")]
	public Transform[] GroundEffects;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x430")]
	public GameObjectRef serverGibs;

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x438")]
	public GameObjectRef explosionEffect;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x440")]
	public GameObjectRef fireBall;

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x448")]
	public GameObjectRef impactEffectSmall;

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x450")]
	public GameObjectRef impactEffectLarge;

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x458")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x7F1B0", Offset = "0x7E5B0")]
	public SoundDefinition flightEngineSoundDef;

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x460")]
	public SoundDefinition flightThwopsSoundDef;

	// Token: 0x040002B3 RID: 691
	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x468")]
	public float rotorGainModSmoothing;

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x46C")]
	public float engineGainMin;

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x470")]
	public float engineGainMax;

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x474")]
	public float thwopGainMin;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x478")]
	public float thwopGainMax;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x47C")]
	public float currentThrottle;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x480")]
	public float avgThrust;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x484")]
	public float liftDotMax;

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x488")]
	public float altForceDotMin;

	// Token: 0x040002BC RID: 700
	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x48C")]
	public float liftFraction;

	// Token: 0x040002BD RID: 701
	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x490")]
	public float thrustLerpSpeed;

	// Token: 0x040002BE RID: 702
	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x498")]
	private Sound flightEngineSound;

	// Token: 0x040002BF RID: 703
	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x4A0")]
	private Sound flightThwopsSound;

	// Token: 0x040002C0 RID: 704
	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x4A8")]
	private SoundModulation.Modulator flightEngineGainMod;

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x4B0")]
	private SoundModulation.Modulator flightThwopsGainMod;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x4B8")]
	private TimeSince timeSinceUpdatedGroundEffects;

	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000A5D")]
	public class HelicopterInputState
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBD")]
		[Address(RVA = "0x3265A0", Offset = "0x3253A0", VA = "0x1803265A0")]
		public void Reset()
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBE")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public HelicopterInputState()
		{
		}

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x4003DBC")]
		[FieldOffset(Offset = "0x10")]
		public float throttle;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x4003DBD")]
		[FieldOffset(Offset = "0x14")]
		public float roll;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x4003DBE")]
		[FieldOffset(Offset = "0x18")]
		public float yaw;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x4003DBF")]
		[FieldOffset(Offset = "0x1C")]
		public float pitch;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x4003DC0")]
		[FieldOffset(Offset = "0x20")]
		public bool groundControl;
	}
}
