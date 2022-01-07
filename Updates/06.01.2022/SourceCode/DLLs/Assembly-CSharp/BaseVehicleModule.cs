using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using Rust.Modular;
using UnityEngine;

// Token: 0x02000073 RID: 115
[Token(Token = "0x2000042")]
public class BaseVehicleModule : global::BaseVehicle, IPrefabPreProcess
{
	// Token: 0x0600088B RID: 2187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043B")]
	[Address(RVA = "0x9A6480", Offset = "0x9A5280", VA = "0x1809A6480", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x0600088C RID: 2188 RVA: 0x00004C20 File Offset: 0x00002E20
	[Token(Token = "0x17000071")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x9A8EA0", Offset = "0x9A7CA0", VA = "0x1809A8EA0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00004C38 File Offset: 0x00002E38
	[Token(Token = "0x600043D")]
	[Address(RVA = "0x9A7A60", Offset = "0x9A6860", VA = "0x1809A7A60", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x9A5DC0", Offset = "0x9A4BC0", VA = "0x1809A5DC0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043F")]
	[Address(RVA = "0x9A5E40", Offset = "0x9A4C40", VA = "0x1809A5E40", Slot = "190")]
	public virtual void ClientVehicleLateUpdate(bool vehicleIsActive)
	{
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00004C50 File Offset: 0x00002E50
	[Token(Token = "0x6000440")]
	[Address(RVA = "0x9A6140", Offset = "0x9A4F40", VA = "0x1809A6140", Slot = "130")]
	public override bool DisplayHealthInfo(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000441")]
	[Address(RVA = "0x9A8B70", Offset = "0x9A7970", VA = "0x1809A8B70")]
	public void SetLightState(bool headlightsOn, bool brakesOn)
	{
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000442")]
	[Address(RVA = "0x9A5BD0", Offset = "0x9A49D0", VA = "0x1809A5BD0")]
	public void ClearDecals(BaseVehicleModule.DecalType decalType)
	{
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000443")]
	[Address(RVA = "0x9A61B0", Offset = "0x9A4FB0", VA = "0x1809A61B0")]
	public void DrawHighlight()
	{
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000444")]
	[Address(RVA = "0x9A7310", Offset = "0x9A6110", VA = "0x1809A7310", Slot = "179")]
	[Attribute(Name = "Menu", RVA = "0xBB9F0", Offset = "0xBADF0")]
	[Attribute(Name = "Description", RVA = "0xBB9F0", Offset = "0xBADF0")]
	[Attribute(Name = "Icon", RVA = "0xBB9F0", Offset = "0xBADF0")]
	[Attribute(Name = "ShowIf", RVA = "0xBB9F0", Offset = "0xBADF0")]
	public override void Menu_Mount(global::BasePlayer player)
	{
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00004C68 File Offset: 0x00002E68
	[Token(Token = "0x6000445")]
	[Address(RVA = "0x9A7240", Offset = "0x9A6040", VA = "0x1809A7240", Slot = "180")]
	public override bool Menu_Mount_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000446")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "170")]
	public override void UpdatePlayerModel(global::BasePlayer player)
	{
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000447")]
	[Address(RVA = "0x9A7460", Offset = "0x9A6260", VA = "0x1809A7460")]
	[Attribute(Name = "Menu", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "Description", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "Icon", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	[Attribute(Name = "ShowIf", RVA = "0xA5AB0", Offset = "0xA4EB0")]
	public void Menu_Push(global::BasePlayer player)
	{
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00004C80 File Offset: 0x00002E80
	[Token(Token = "0x6000448")]
	[Address(RVA = "0x9A73B0", Offset = "0x9A61B0", VA = "0x1809A73B0", Slot = "186")]
	public override bool Menu_Push_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000449")]
	[Address(RVA = "0x9A7800", Offset = "0x9A6600", VA = "0x1809A7800")]
	[Attribute(Name = "Menu", RVA = "0xBD410", Offset = "0xBC810")]
	[Attribute(Name = "Description", RVA = "0xBD410", Offset = "0xBC810")]
	[Attribute(Name = "Icon", RVA = "0xBD410", Offset = "0xBC810")]
	[Attribute(Name = "ShowIf", RVA = "0xBD410", Offset = "0xBC810")]
	public void Menu_Use(global::BasePlayer player)
	{
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00004C98 File Offset: 0x00002E98
	[Token(Token = "0x600044A")]
	[Address(RVA = "0x9A7500", Offset = "0x9A6300", VA = "0x1809A7500")]
	public bool Menu_Use_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600044B")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	[Attribute(Name = "Menu", RVA = "0xBD620", Offset = "0xBCA20")]
	[Attribute(Name = "Description", RVA = "0xBD620", Offset = "0xBCA20")]
	[Attribute(Name = "Icon", RVA = "0xBD620", Offset = "0xBCA20")]
	[Attribute(Name = "ShowIf", RVA = "0xBD620", Offset = "0xBCA20")]
	public void Menu_Locked(global::BasePlayer player)
	{
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00004CB0 File Offset: 0x00002EB0
	[Token(Token = "0x600044C")]
	[Address(RVA = "0x9A70F0", Offset = "0x9A5EF0", VA = "0x1809A70F0", Slot = "191")]
	public virtual bool Menu_Locked_ShowIf(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600089E RID: 2206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000072")]
	public BaseModularVehicle Vehicle
	{
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x9A90F0", Offset = "0x9A7EF0", VA = "0x1809A90F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x9A9110", Offset = "0x9A7F10", VA = "0x1809A9110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x0600089F RID: 2207 RVA: 0x00004CC8 File Offset: 0x00002EC8
	// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000073")]
	public int FirstSocketIndex
	{
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x9A8E90", Offset = "0x9A7C90", VA = "0x1809A8E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x9A9100", Offset = "0x9A7F00", VA = "0x1809A9100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00004CE0 File Offset: 0x00002EE0
	[Token(Token = "0x17000074")]
	public Vector3 CentreOfMass
	{
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x9A8E50", Offset = "0x9A7C50", VA = "0x1809A8E50")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00004CF8 File Offset: 0x00002EF8
	[Token(Token = "0x17000075")]
	public float Mass
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x9A90E0", Offset = "0x9A7EE0", VA = "0x1809A90E0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00004D10 File Offset: 0x00002F10
	[Token(Token = "0x17000076")]
	public uint ID
	{
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x611A70", Offset = "0x610870", VA = "0x180611A70")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00004D28 File Offset: 0x00002F28
	[Token(Token = "0x17000077")]
	public bool IsOnAVehicle
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x9A9080", Offset = "0x9A7E80", VA = "0x1809A9080")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000078")]
	public ItemDefinition AssociatedItemDef
	{
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2F5F70", Offset = "0x2F4D70", VA = "0x1802F5F70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00004D40 File Offset: 0x00002F40
	[Token(Token = "0x17000079")]
	public virtual bool HasSeating
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "192")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00004D58 File Offset: 0x00002F58
	[Token(Token = "0x1700007A")]
	public virtual bool HasAnEngine
	{
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "193")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x9A7B90", Offset = "0x9A6990", VA = "0x1809A7B90", Slot = "84")]
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000459")]
	[Address(RVA = "0x9A8970", Offset = "0x9A7770", VA = "0x1809A8970")]
	public void RefreshParameters()
	{
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045A")]
	[Address(RVA = "0x9A79A0", Offset = "0x9A67A0", VA = "0x1809A79A0", Slot = "194")]
	public virtual void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex)
	{
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045B")]
	[Address(RVA = "0x9A7A30", Offset = "0x9A6830", VA = "0x1809A7A30", Slot = "195")]
	public virtual void ModuleRemoved()
	{
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x9A7B50", Offset = "0x9A6950", VA = "0x1809A7B50")]
	public void OtherVehicleModulesChanged()
	{
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045D")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "196")]
	public virtual void OnEngineStateChanged(VehicleEngineController<global::ModularCar>.EngineState oldState, VehicleEngineController<global::ModularCar>.EngineState newState)
	{
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00004D70 File Offset: 0x00002F70
	[Token(Token = "0x600045E")]
	[Address(RVA = "0x9A7050", Offset = "0x9A5E50", VA = "0x1809A7050", Slot = "110")]
	public override float MaxHealth()
	{
		return 0f;
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x00004D88 File Offset: 0x00002F88
	[Token(Token = "0x600045F")]
	[Address(RVA = "0x9A8BF0", Offset = "0x9A79F0", VA = "0x1809A8BF0", Slot = "142")]
	public override float StartHealth()
	{
		return 0f;
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x00004DA0 File Offset: 0x00002FA0
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x9A6E40", Offset = "0x9A5C40", VA = "0x1809A6E40")]
	public int GetNumSocketsTaken()
	{
		return 0;
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000461")]
	[Address(RVA = "0x9A62E0", Offset = "0x9A50E0", VA = "0x1809A62E0")]
	public List<ConditionalObject> GetConditionals()
	{
		return null;
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x00004DB8 File Offset: 0x00002FB8
	[Token(Token = "0x6000462")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "197")]
	public virtual float GetMaxDriveForce()
	{
		return 0f;
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000463")]
	[Address(RVA = "0x9A8750", Offset = "0x9A7550", VA = "0x1809A8750")]
	public void RefreshConditionals(bool canGib)
	{
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000464")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "198")]
	protected virtual void PostConditionalRefresh()
	{
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000465")]
	[Address(RVA = "0x9A7C70", Offset = "0x9A6A70", VA = "0x1809A7C70")]
	private void RefreshConditional(ConditionalObject conditional, bool canGib)
	{
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00004DD0 File Offset: 0x00002FD0
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x9A8D60", Offset = "0x9A7B60", VA = "0x1809A8D60")]
	private bool TryGetAdjacentModuleInFront(out BaseVehicleModule result)
	{
		return default(bool);
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00004DE8 File Offset: 0x00002FE8
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x9A8C10", Offset = "0x9A7A10", VA = "0x1809A8C10")]
	private bool TryGetAdjacentModuleBehind(out BaseVehicleModule result)
	{
		return default(bool);
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00004E00 File Offset: 0x00003000
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x9A6EE0", Offset = "0x9A5CE0", VA = "0x1809A6EE0")]
	private bool InSameVisualGroupAs(BaseVehicleModule moduleEntity, ConditionalObject.AdjacentMatchType matchType)
	{
		return default(bool);
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00004E18 File Offset: 0x00003018
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x9A5A70", Offset = "0x9A4870", VA = "0x1809A5A70")]
	private bool CanBeUsedNowBy(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00004E30 File Offset: 0x00003030
	[Token(Token = "0x600046A")]
	[Address(RVA = "0x9A7B60", Offset = "0x9A6960", VA = "0x1809A7B60")]
	public bool PlayerIsLookingAtUsable(string lookingAtColldierName, string usableColliderName)
	{
		return default(bool);
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x9A6FE0", Offset = "0x9A5DE0", VA = "0x1809A6FE0", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00004E48 File Offset: 0x00003048
	[Token(Token = "0x600046C")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "189")]
	public override bool IsVehicleRoot()
	{
		return default(bool);
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x9A8E20", Offset = "0x9A7C20", VA = "0x1809A8E20")]
	public BaseVehicleModule()
	{
	}

	// Token: 0x0400048C RID: 1164
	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0x3A8")]
	private Option __menuOption_Menu_Locked;

	// Token: 0x0400048D RID: 1165
	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0x400")]
	private Option __menuOption_Menu_Mount;

	// Token: 0x0400048E RID: 1166
	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x458")]
	private Option __menuOption_Menu_Push;

	// Token: 0x0400048F RID: 1167
	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x4B0")]
	private Option __menuOption_Menu_Use;

	// Token: 0x04000490 RID: 1168
	[Token(Token = "0x40003B3")]
	public const string CAR_LOCKED_ACTION_NAME = "car_locked";

	// Token: 0x04000491 RID: 1169
	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x508")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xB9AF0", Offset = "0xB8EF0")]
	[SerializeField]
	private Transform centreOfMassTransform;

	// Token: 0x04000492 RID: 1170
	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x510")]
	[SerializeField]
	private float mass;

	// Token: 0x04000493 RID: 1171
	[Token(Token = "0x40003B6")]
	[FieldOffset(Offset = "0x514")]
	public BaseVehicleModule.VisualGroup visualGroup;

	// Token: 0x04000494 RID: 1172
	[Token(Token = "0x40003B7")]
	[FieldOffset(Offset = "0x518")]
	[SerializeField]
	[HideInInspector]
	private VehicleLight[] lights;

	// Token: 0x04000495 RID: 1173
	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0x520")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private BaseModularVehicle <Vehicle>k__BackingField;

	// Token: 0x04000496 RID: 1174
	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0x528")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private int <FirstSocketIndex>k__BackingField;

	// Token: 0x04000497 RID: 1175
	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x530")]
	public BaseVehicleModule.LODLevel[] lodRenderers;

	// Token: 0x04000498 RID: 1176
	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x538")]
	[SerializeField]
	[HideInInspector]
	private List<ConditionalObject> conditionals;

	// Token: 0x04000499 RID: 1177
	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x540")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xBB610", Offset = "0xBAA10")]
	[SerializeField]
	private TriggerParent[] triggerParents;

	// Token: 0x0400049A RID: 1178
	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x548")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xBB7C0", Offset = "0xBABC0")]
	[SerializeField]
	private VehicleModuleSlidingComponent[] slidingComponents;

	// Token: 0x0400049B RID: 1179
	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x550")]
	[SerializeField]
	private VehicleModuleButtonComponent[] buttonComponents;

	// Token: 0x0400049C RID: 1180
	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x558")]
	private TimeSince TimeSinceAddedToVehicle;

	// Token: 0x0400049D RID: 1181
	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x55C")]
	private float prevRefreshHealth;

	// Token: 0x0400049E RID: 1182
	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x560")]
	private bool prevRefreshVehicleIsDead;

	// Token: 0x0400049F RID: 1183
	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x561")]
	private bool prevRefreshVehicleIsLockable;

	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000A71")]
	public enum DecalType
	{
		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x4003E1D")]
		All,
		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x4003E1E")]
		Glass
	}

	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000A72")]
	public enum VisualGroup
	{
		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x4003E20")]
		None,
		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x4003E21")]
		Engine,
		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x4003E22")]
		Cabin,
		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x4003E23")]
		Flatbed
	}

	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000A73")]
	[Serializable]
	public class LODLevel
	{
		// Token: 0x060008BE RID: 2238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public LODLevel()
		{
		}

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x4003E24")]
		[FieldOffset(Offset = "0x10")]
		public Renderer[] renderers;
	}
}
