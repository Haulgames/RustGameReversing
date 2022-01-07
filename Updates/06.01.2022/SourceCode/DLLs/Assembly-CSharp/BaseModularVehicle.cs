using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using ProtoBuf;
using Rust.Modular;
using UnityEngine;

// Token: 0x02000056 RID: 86
[Token(Token = "0x200003A")]
public abstract class BaseModularVehicle : global::BaseVehicle, IPrefabPreProcess
{
	// Token: 0x0600061E RID: 1566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x2F3C40", Offset = "0x2F2A40", VA = "0x1802F3C40", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x0600061F RID: 1567 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x17000029")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2F6030", Offset = "0x2F4E30", VA = "0x1802F6030", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x2F4250", Offset = "0x2F3050", VA = "0x1802F4250", Slot = "190")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x2F3A70", Offset = "0x2F2870", VA = "0x1802F3A70", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x2F5E00", Offset = "0x2F4C00", VA = "0x1802F5E00", Slot = "170")]
	public override void UpdatePlayerModel(global::BasePlayer player)
	{
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x2F4D70", Offset = "0x2F3B70", VA = "0x1802F4D70", Slot = "80")]
	public override void OnFlagsChanged(global::BaseEntity.Flags old, global::BaseEntity.Flags next)
	{
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x2F3B00", Offset = "0x2F2900", VA = "0x1802F3B00", Slot = "191")]
	public virtual void ClientLightsChanged(bool headlightsOn, bool brakesOn)
	{
	}

	// Token: 0x06000625 RID: 1573
	[Token(Token = "0x60001F9")]
	protected abstract bool BrakesAreOn();

	// Token: 0x06000626 RID: 1574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x2F4F80", Offset = "0x2F3D80", VA = "0x1802F4F80")]
	private void RefreshLODSets()
	{
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x2F43F0", Offset = "0x2F31F0", VA = "0x1802F43F0", Slot = "193")]
	[Attribute(Name = "Menu", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "Description", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "Icon", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "ShowIf", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	public virtual void Menu_Push(global::BasePlayer player)
	{
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000628 RID: 1576 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x1700002A")]
	public Vector3 CentreOfMass
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2F5F90", Offset = "0x2F4D90", VA = "0x1802F5F90")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000629 RID: 1577 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x1700002B")]
	public int NumAttachedModules
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2F6160", Offset = "0x2F4F60", VA = "0x1802F6160")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600062A RID: 1578 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x1700002C")]
	public bool HasAnyModules
	{
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2F5FD0", Offset = "0x2F4DD0", VA = "0x1802F5FD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002D")]
	public List<BaseVehicleModule> AttachedModuleEntities
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2F5F80", Offset = "0x2F4D80", VA = "0x1802F5F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x0600062C RID: 1580 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x1700002E")]
	public int TotalSockets
	{
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2F6290", Offset = "0x2F5090", VA = "0x1802F6290")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x0600062D RID: 1581 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x1700002F")]
	public int NumFreeSockets
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2F61A0", Offset = "0x2F4FA0", VA = "0x1802F61A0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x0600062E RID: 1582 RVA: 0x000031E0 File Offset: 0x000013E0
	// (set) Token: 0x0600062F RID: 1583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000030")]
	public float TotalMass
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2F6280", Offset = "0x2F5080", VA = "0x1802F6280")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2F6300", Offset = "0x2F5100", VA = "0x1802F6300")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000630 RID: 1584 RVA: 0x000031F8 File Offset: 0x000013F8
	// (set) Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000031")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2F62D0", Offset = "0x2F50D0", VA = "0x1802F62D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2F6310", Offset = "0x2F5110", VA = "0x1802F6310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000632 RID: 1586 RVA: 0x00003210 File Offset: 0x00001410
	[Token(Token = "0x17000032")]
	public bool LightsAreOn
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2F6150", Offset = "0x2F4F50", VA = "0x1802F6150")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000633 RID: 1587 RVA: 0x00003228 File Offset: 0x00001428
	[Token(Token = "0x17000033")]
	public bool IsKinematic
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2F6110", Offset = "0x2F4F10", VA = "0x1802F6110")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000634 RID: 1588 RVA: 0x00003240 File Offset: 0x00001440
	[Token(Token = "0x17000034")]
	public bool IsMovingOrOn
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2F6120", Offset = "0x2F4F20", VA = "0x1802F6120")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000635 RID: 1589 RVA: 0x00003258 File Offset: 0x00001458
	[Token(Token = "0x17000035")]
	public virtual bool IsLockable
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "194")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000636 RID: 1590 RVA: 0x00003270 File Offset: 0x00001470
	// (set) Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000036")]
	public bool HasInited
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2F6020", Offset = "0x2F4E20", VA = "0x1802F6020")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2F62F0", Offset = "0x2F50F0", VA = "0x1802F62F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000037")]
	private ItemDefinition AssociatedItemDef
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2F5F70", Offset = "0x2F4D70", VA = "0x1802F5F70")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000639 RID: 1593 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x17000038")]
	public bool IsEditableNow
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2F6100", Offset = "0x2F4F00", VA = "0x1802F6100")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x2F40C0", Offset = "0x2F2EC0", VA = "0x1802F40C0", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x2F4E90", Offset = "0x2F3C90", VA = "0x1802F4E90", Slot = "84")]
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x000032A0 File Offset: 0x000014A0
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x2F3FD0", Offset = "0x2F2DD0", VA = "0x1802F3FD0")]
	public float GetSpeed()
	{
		return 0f;
	}

	// Token: 0x0600063D RID: 1597
	[Token(Token = "0x6000211")]
	public abstract float GetMaxForwardSpeed();

	// Token: 0x0600063E RID: 1598 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "196")]
	public virtual bool PlayerCanUseThis(global::BasePlayer player, ModularCarLock.LockType lockType)
	{
		return default(bool);
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x000032D0 File Offset: 0x000014D0
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x2F5A30", Offset = "0x2F4830", VA = "0x1802F5A30")]
	public bool TryDeduceSocketIndex(BaseVehicleModule addedModule, out int index)
	{
		return default(bool);
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x2F3A10", Offset = "0x2F2810", VA = "0x1802F3A10")]
	public void AddMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos)
	{
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2F5A10", Offset = "0x2F4810", VA = "0x1802F5A10")]
	public void RemoveMass(float moduleMass, Vector3 moduleCOM, Vector3 moduleWorldPos)
	{
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x000032E8 File Offset: 0x000014E8
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2F5C40", Offset = "0x2F4A40", VA = "0x1802F5C40")]
	public bool TryGetModuleAt(int socketIndex, out BaseVehicleModule result)
	{
		return default(bool);
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2F3F60", Offset = "0x2F2D60", VA = "0x1802F3F60")]
	public ModularVehicleSocket GetSocket(int index)
	{
		return null;
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000218")]
	[Address(RVA = "0x2F4390", Offset = "0x2F3190", VA = "0x1802F4390", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x2F3A30", Offset = "0x2F2830", VA = "0x1802F3A30", Slot = "188")]
	protected override bool CanPushNow(global::BasePlayer pusher)
	{
		return default(bool);
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2F4B90", Offset = "0x2F3990", VA = "0x1802F4B90", Slot = "22")]
	protected override void OnChildAdded(global::BaseEntity childEntity)
	{
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2F4CD0", Offset = "0x2F3AD0", VA = "0x1802F4CD0", Slot = "23")]
	protected override void OnChildRemoved(global::BaseEntity childEntity)
	{
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x2F4430", Offset = "0x2F3230", VA = "0x1802F4430", Slot = "197")]
	protected virtual void ModuleEntityAdded(BaseVehicleModule addedModule)
	{
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x2F4A00", Offset = "0x2F3800", VA = "0x1802F4A00", Slot = "198")]
	protected virtual void ModuleEntityRemoved(BaseVehicleModule removedModule)
	{
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x2F58C0", Offset = "0x2F46C0", VA = "0x1802F58C0")]
	private void RefreshModulesExcept(BaseVehicleModule ignoredModule)
	{
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x2F5ED0", Offset = "0x2F4CD0", VA = "0x1802F5ED0")]
	protected BaseModularVehicle()
	{
	}

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x3A8")]
	private Option __menuOption_Menu_Push;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x400")]
	protected bool clientInEditMode;

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x408")]
	private LOD[] baseVehicleLODs;

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x410")]
	private LOD[] combinedLODs;

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x418")]
	private int[] maxRendererIndex;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x420")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA6230", Offset = "0xA5630")]
	[HideInInspector]
	public float mass;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x428")]
	[SerializeField]
	private List<ModularVehicleSocket> moduleSockets;

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x430")]
	[SerializeField]
	private Transform centreOfMassTransform;

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x438")]
	[SerializeField]
	protected Transform waterSample;

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x440")]
	[SerializeField]
	private LODGroup lodGroup;

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x448")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private readonly List<BaseVehicleModule> <AttachedModuleEntities>k__BackingField;

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x450")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <TotalMass>k__BackingField;

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x454")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private Vector3 <Velocity>k__BackingField;

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x460")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <HasInited>k__BackingField;

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x400025C")]
	public const global::BaseEntity.Flags FLAG_KINEMATIC = global::BaseEntity.Flags.Reserved6;

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x468")]
	private Dictionary<BaseVehicleModule, Action> moduleAddActions;

	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000A5E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private sealed class <>c__DisplayClass72_0
	{
		// Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c__DisplayClass72_0()
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x326A10", Offset = "0x325810", VA = "0x180326A10")]
		internal void <OnChildAdded>b__0()
		{
		}

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x4003DC1")]
		[FieldOffset(Offset = "0x10")]
		public BaseModularVehicle <>4__this;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x4003DC2")]
		[FieldOffset(Offset = "0x18")]
		public BaseVehicleModule module;
	}
}
