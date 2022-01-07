using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Network;
using Network.Visibility;
using ProtoBuf;
using Rust;
using UnityEngine;

// Token: 0x02000491 RID: 1169
[Token(Token = "0x2000364")]
public abstract class BaseNetworkable : BaseMonoBehaviour, IPrefabPostProcess, IEntity, NetworkHandler
{
	// Token: 0x170002AE RID: 686
	// (get) Token: 0x060023ED RID: 9197 RVA: 0x000100E0 File Offset: 0x0000E2E0
	// (set) Token: 0x060023EE RID: 9198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700027E")]
	protected bool JustCreated
	{
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x2FB990", Offset = "0x2FA790", VA = "0x1802FB990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x2FBB80", Offset = "0x2FA980", VA = "0x1802FBB80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x2FA0F0", Offset = "0x2F8EF0", VA = "0x1802FA0F0")]
	public void ClientSpawn(Entity info)
	{
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0x2FA070", Offset = "0x2F8E70", VA = "0x1802FA070", Slot = "13")]
	public virtual void ClientOnEnable()
	{
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0x2F9E80", Offset = "0x2F8C80", VA = "0x1802F9E80", Slot = "14")]
	protected virtual void ClientInit(Entity info)
	{
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x2FB460", Offset = "0x2FA260", VA = "0x1802FB460")]
	public void OnNetworkUpdate(Entity entity)
	{
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "15")]
	public virtual void PreNetworkUpdate()
	{
	}

	// Token: 0x060023F4 RID: 9204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "16")]
	public virtual void PostNetworkUpdate()
	{
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x000100F8 File Offset: 0x0000E2F8
	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "17")]
	public virtual bool ShouldDestroyWithGroup()
	{
		return default(bool);
	}

	// Token: 0x060023F6 RID: 9206 RVA: 0x00010110 File Offset: 0x0000E310
	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "18")]
	public virtual bool ShouldDestroyImmediately()
	{
		return default(bool);
	}

	// Token: 0x060023F7 RID: 9207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x2FAFF0", Offset = "0x2F9DF0", VA = "0x1802FAFF0")]
	public void NetworkDestroy(bool immediately)
	{
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAC")]
	[Address(RVA = "0x2FA4C0", Offset = "0x2F92C0", VA = "0x1802FA4C0", Slot = "19")]
	protected virtual void DoClientDestroy()
	{
	}

	// Token: 0x060023F9 RID: 9209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "20")]
	internal virtual void DoNetworkDestroy()
	{
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAE")]
	[Address(RVA = "0x2F9C60", Offset = "0x2F8A60", VA = "0x1802F9C60")]
	public void BroadcastOnPostNetworkUpdate(global::BaseEntity entity)
	{
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DAF")]
	[Address(RVA = "0x2FB5E0", Offset = "0x2FA3E0", VA = "0x1802FB5E0", Slot = "21")]
	public virtual void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x060023FC RID: 9212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x2FA920", Offset = "0x2F9720", VA = "0x1802FA920")]
	public global::BaseEntity GetParentEntity()
	{
		return null;
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x00010128 File Offset: 0x0000E328
	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x2FA930", Offset = "0x2F9730", VA = "0x1802FA930")]
	public bool HasParent()
	{
		return default(bool);
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0x2F9BD0", Offset = "0x2F89D0", VA = "0x1802F9BD0")]
	public void AddChild(global::BaseEntity child)
	{
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "22")]
	protected virtual void OnChildAdded(global::BaseEntity child)
	{
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x2FB660", Offset = "0x2FA460", VA = "0x1802FB660")]
	public void RemoveChild(global::BaseEntity child)
	{
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "23")]
	protected virtual void OnChildRemoved(global::BaseEntity child)
	{
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x06002402 RID: 9218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700027F")]
	public GameManager gameManager
	{
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x2FBAB0", Offset = "0x2FA8B0", VA = "0x1802FBAB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x06002403 RID: 9219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000280")]
	public PrefabAttribute.Library prefabAttribute
	{
		[Token(Token = "0x6001DB7")]
		[Address(RVA = "0x2FBB10", Offset = "0x2FA910", VA = "0x1802FBB10")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x06002404 RID: 9220 RVA: 0x00010140 File Offset: 0x0000E340
	// (set) Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000281")]
	public bool IsDestroyed
	{
		[Token(Token = "0x6001DB8")]
		[Address(RVA = "0x2FB980", Offset = "0x2FA780", VA = "0x1802FB980", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001DB9")]
		[Address(RVA = "0x2FBB70", Offset = "0x2FA970", VA = "0x1802FBB70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x06002406 RID: 9222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000282")]
	public string PrefabName
	{
		[Token(Token = "0x6001DBA")]
		[Address(RVA = "0x2FB9A0", Offset = "0x2FA7A0", VA = "0x1802FB9A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x06002407 RID: 9223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000283")]
	public string ShortPrefabName
	{
		[Token(Token = "0x6001DBB")]
		[Address(RVA = "0x2FBA20", Offset = "0x2FA820", VA = "0x1802FBA20")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x00010158 File Offset: 0x0000E358
	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x2FA890", Offset = "0x2F9690", VA = "0x1802FA890", Slot = "24")]
	public virtual Vector3 GetNetworkPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x00010170 File Offset: 0x0000E370
	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0x2FA8E0", Offset = "0x2F96E0", VA = "0x1802FA8E0", Slot = "25")]
	public virtual Quaternion GetNetworkRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x2FA940", Offset = "0x2F9740", VA = "0x1802FA940")]
	public string InvokeString()
	{
		return null;
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x2FAF50", Offset = "0x2F9D50", VA = "0x1802FAF50")]
	public global::BaseEntity LookupPrefab()
	{
		return null;
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x00010188 File Offset: 0x0000E388
	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x2FA7D0", Offset = "0x2F95D0", VA = "0x1802FA7D0", Slot = "26")]
	public bool EqualNetID(global::BaseNetworkable other)
	{
		return default(bool);
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000101A0 File Offset: 0x0000E3A0
	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0x2FA870", Offset = "0x2F9670", VA = "0x1802FA870")]
	public bool EqualNetID(uint otherID)
	{
		return default(bool);
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0x2FB6D0", Offset = "0x2FA4D0", VA = "0x1802FB6D0", Slot = "27")]
	public virtual void ResetState()
	{
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "28")]
	public virtual void InitShared()
	{
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "29")]
	public virtual void PreInitShared()
	{
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "30")]
	public virtual void PostInitShared()
	{
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC6")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "31")]
	public virtual void DestroyShared()
	{
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "32")]
	public virtual void OnNetworkGroupEnter(Group group)
	{
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "33")]
	public virtual void OnNetworkGroupLeave(Group group)
	{
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC9")]
	[Address(RVA = "0x2FB320", Offset = "0x2FA120", VA = "0x1802FB320", Slot = "10")]
	public void OnNetworkGroupChange()
	{
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCA")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "8")]
	public void OnNetworkSubscribersEnter(List<Connection> connections)
	{
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "9")]
	public void OnNetworkSubscribersLeave(List<Connection> connections)
	{
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x2FA6E0", Offset = "0x2F94E0", VA = "0x1802FA6E0")]
	private void EntityDestroy()
	{
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x2FA580", Offset = "0x2F9380", VA = "0x1802FA580")]
	private void DoEntityDestroy()
	{
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x2FB720", Offset = "0x2FA520", VA = "0x1802FB720")]
	private void SpawnShared()
	{
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DCF")]
	[Address(RVA = "0x2FAB90", Offset = "0x2F9990", VA = "0x1802FAB90", Slot = "34")]
	public virtual void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x0600241C RID: 9244 RVA: 0x000101B8 File Offset: 0x0000E3B8
	[Token(Token = "0x17000284")]
	public bool isServer
	{
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x0600241D RID: 9245 RVA: 0x000101D0 File Offset: 0x0000E3D0
	[Token(Token = "0x17000285")]
	public bool isClient
	{
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DD2")]
	public T ToClient<T>() where T : global::BaseNetworkable
	{
		return null;
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x000101E8 File Offset: 0x0000E3E8
	[Token(Token = "0x6001DD3")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "35")]
	public virtual bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0x2FB8E0", Offset = "0x2FA6E0", VA = "0x1802FB8E0")]
	protected BaseNetworkable()
	{
	}

	// Token: 0x04001E67 RID: 7783
	[Token(Token = "0x40018ED")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <JustCreated>k__BackingField;

	// Token: 0x04001E68 RID: 7784
	[Token(Token = "0x40018EE")]
	[FieldOffset(Offset = "0x20")]
	private DeferredAction entityDestroy;

	// Token: 0x04001E69 RID: 7785
	[Token(Token = "0x40018EF")]
	[FieldOffset(Offset = "0x28")]
	public List<Component> postNetworkUpdateComponents;

	// Token: 0x04001E6A RID: 7786
	[Token(Token = "0x40018F0")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	public EntityRef parentEntity;

	// Token: 0x04001E6B RID: 7787
	[Token(Token = "0x40018F1")]
	[FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public readonly List<global::BaseEntity> children;

	// Token: 0x04001E6C RID: 7788
	[Token(Token = "0x40018F2")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xD0280", Offset = "0xCF680")]
	[ReadOnly]
	public uint prefabID;

	// Token: 0x04001E6D RID: 7789
	[Token(Token = "0x40018F3")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xD0430", Offset = "0xCF830")]
	public bool globalBroadcast;

	// Token: 0x04001E6E RID: 7790
	[Token(Token = "0x40018F4")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public Networkable net;

	// Token: 0x04001E6F RID: 7791
	[Token(Token = "0x40018F5")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <IsDestroyed>k__BackingField;

	// Token: 0x04001E70 RID: 7792
	[Token(Token = "0x40018F6")]
	[FieldOffset(Offset = "0x60")]
	private string _prefabName;

	// Token: 0x04001E71 RID: 7793
	[Token(Token = "0x40018F7")]
	[FieldOffset(Offset = "0x68")]
	private string _prefabNameWithoutExtension;

	// Token: 0x04001E72 RID: 7794
	[Token(Token = "0x40018F8")]
	[FieldOffset(Offset = "0x0")]
	public static global::BaseNetworkable.EntityRealm clientEntities;

	// Token: 0x04001E73 RID: 7795
	[Token(Token = "0x40018F9")]
	private const bool isServersideEntity = false;

	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000B62")]
	public struct SaveInfo
	{
		// Token: 0x06002422 RID: 9250 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0xECED0", Offset = "0xEC2D0", VA = "0x1800ECED0")]
		internal bool SendingTo(Connection ownerConnection)
		{
			return default(bool);
		}

		// Token: 0x04001E74 RID: 7796
		[Token(Token = "0x4004290")]
		[FieldOffset(Offset = "0x0")]
		public Entity msg;

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4004291")]
		[FieldOffset(Offset = "0x8")]
		public bool forDisk;

		// Token: 0x04001E76 RID: 7798
		[Token(Token = "0x4004292")]
		[FieldOffset(Offset = "0x10")]
		public Connection forConnection;
	}

	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000B63")]
	public struct LoadInfo
	{
		// Token: 0x04001E77 RID: 7799
		[Token(Token = "0x4004293")]
		[FieldOffset(Offset = "0x0")]
		public Entity msg;

		// Token: 0x04001E78 RID: 7800
		[Token(Token = "0x4004294")]
		[FieldOffset(Offset = "0x8")]
		public bool fromDisk;
	}

	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x2000B64")]
	public class EntityRealmClient : global::BaseNetworkable.EntityRealm
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071B")]
		protected override Manager visibilityManager
		{
			[Token(Token = "0x6004DCB")]
			[Address(RVA = "0x325FA0", Offset = "0x324DA0", VA = "0x180325FA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x325F30", Offset = "0x324D30", VA = "0x180325F30")]
		public EntityRealmClient()
		{
		}
	}

	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000B65")]
	public abstract class EntityRealm : IEnumerable<global::BaseNetworkable>, IEnumerable
	{
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x1700071C")]
		public int Count
		{
			[Token(Token = "0x6004DCD")]
			[Address(RVA = "0x326550", Offset = "0x325350", VA = "0x180326550")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06002426 RID: 9254
		[Token(Token = "0x1700071D")]
		protected abstract Manager visibilityManager { [Token(Token = "0x6004DCE")] get; }

		// Token: 0x06002427 RID: 9255 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x6004DCF")]
		[Address(RVA = "0x326070", Offset = "0x324E70", VA = "0x180326070")]
		public bool Contains(uint uid)
		{
			return default(bool);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD0")]
		[Address(RVA = "0x3262F0", Offset = "0x3250F0", VA = "0x1803262F0")]
		public global::BaseNetworkable Find(uint uid)
		{
			return null;
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD1")]
		[Address(RVA = "0x3263E0", Offset = "0x3251E0", VA = "0x1803263E0")]
		public void RegisterID(global::BaseNetworkable ent)
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x3264E0", Offset = "0x3252E0", VA = "0x1803264E0")]
		public void UnregisterID(global::BaseNetworkable ent)
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x3260D0", Offset = "0x324ED0", VA = "0x1803260D0")]
		public Group FindGroup(uint uid)
		{
			return null;
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD4")]
		[Address(RVA = "0x3264A0", Offset = "0x3252A0", VA = "0x1803264A0")]
		public Group TryFindGroup(uint uid)
		{
			return null;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD5")]
		[Address(RVA = "0x326110", Offset = "0x324F10", VA = "0x180326110")]
		public void FindInGroup(uint uid, List<global::BaseNetworkable> list)
		{
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x326370", Offset = "0x325170", VA = "0x180326370", Slot = "4")]
		public IEnumerator<global::BaseNetworkable> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD7")]
		[Address(RVA = "0x326370", Offset = "0x325170", VA = "0x180326370", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD8")]
		[Address(RVA = "0x326020", Offset = "0x324E20", VA = "0x180326020")]
		public void Clear()
		{
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD9")]
		[Address(RVA = "0x325F30", Offset = "0x324D30", VA = "0x180325F30")]
		protected EntityRealm()
		{
		}

		// Token: 0x04001E79 RID: 7801
		[Token(Token = "0x4004295")]
		[FieldOffset(Offset = "0x10")]
		private ListDictionary<uint, global::BaseNetworkable> entityList;
	}

	// Token: 0x02000496 RID: 1174
	[Token(Token = "0x2000B66")]
	public enum DestroyMode : byte
	{
		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4004297")]
		None,
		// Token: 0x04001E7C RID: 7804
		[Token(Token = "0x4004298")]
		Gib
	}
}
