using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using UnityEngine;

// Token: 0x0200004D RID: 77
[Token(Token = "0x2000036")]
public class BaseCombatEntity : global::BaseEntity
{
	// Token: 0x060005E1 RID: 1505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x84B3B0", Offset = "0x84A1B0", VA = "0x18084B3B0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x17000022")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x84C400", Offset = "0x84B200", VA = "0x18084C400", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002EE0 File Offset: 0x000010E0
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x84BB10", Offset = "0x84A910", VA = "0x18084BB10", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x84B740", Offset = "0x84A540", VA = "0x18084B740")]
	[global::BaseEntity.RPC_Client]
	public void HitNotify(global::BaseEntity.RPCMessage rpc)
	{
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x840EC0", Offset = "0x83FCC0", VA = "0x180840EC0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00002EF8 File Offset: 0x000010F8
	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x6A31F0", Offset = "0x6A1FF0", VA = "0x1806A31F0", Slot = "130")]
	public virtual bool DisplayHealthInfo(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x84B2F0", Offset = "0x84A0F0", VA = "0x18084B2F0", Slot = "71")]
	internal override Transform GetEyeTransform()
	{
		return null;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x84BAE0", Offset = "0x84A8E0", VA = "0x18084BAE0", Slot = "131")]
	protected virtual void OnLifeStateChanged()
	{
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00002F10 File Offset: 0x00001110
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x84B720", Offset = "0x84A520", VA = "0x18084B720", Slot = "132")]
	protected virtual int GetPickupCount()
	{
		return 0;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00002F28 File Offset: 0x00001128
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x84AEE0", Offset = "0x849CE0", VA = "0x18084AEE0", Slot = "133")]
	public virtual bool CanPickup(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "134")]
	public virtual void OnPickedUp(global::Item createdItem, global::BasePlayer player)
	{
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "135")]
	public virtual void OnPickedUpPreItemMove(global::Item createdItem, global::BasePlayer player)
	{
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x84B980", Offset = "0x84A780", VA = "0x18084B980")]
	[Attribute(Name = "Menu", RVA = "0xA4D10", Offset = "0xA4110")]
	[Attribute(Name = "Description", RVA = "0xA4D10", Offset = "0xA4110")]
	[Attribute(Name = "Icon", RVA = "0xA4D10", Offset = "0xA4110")]
	[Attribute(Name = "ShowIf", RVA = "0xA4D10", Offset = "0xA4110")]
	public void Menu_Pickup(global::BasePlayer player)
	{
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x84B930", Offset = "0x84A730", VA = "0x18084B930")]
	public void Menu_Pickup_TimeStart()
	{
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00002F40 File Offset: 0x00001140
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x84B910", Offset = "0x84A710", VA = "0x18084B910")]
	public bool Menu_Pickup_If(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x84AE10", Offset = "0x849C10", VA = "0x18084AE10", Slot = "136")]
	public virtual List<ItemAmount> BuildCost()
	{
		return null;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00002F58 File Offset: 0x00001158
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x84B860", Offset = "0x84A660", VA = "0x18084B860", Slot = "137")]
	public virtual bool IsDead()
	{
		return default(bool);
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x84B850", Offset = "0x84A650", VA = "0x18084B850", Slot = "138")]
	public virtual bool IsAlive()
	{
		return default(bool);
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x84B3A0", Offset = "0x84A1A0", VA = "0x18084B3A0")]
	public BaseCombatEntity.Faction GetFaction()
	{
		return BaseCombatEntity.Faction.Default;
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "139")]
	public virtual bool IsFriendly(BaseCombatEntity other)
	{
		return default(bool);
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x17000023")]
	public float SecondsSinceDeath
	{
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x84C4D0", Offset = "0x84B2D0", VA = "0x18084C4D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00002FD0 File Offset: 0x000011D0
	[Token(Token = "0x17000024")]
	public float healthFraction
	{
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x84C4F0", Offset = "0x84B2F0", VA = "0x18084C4F0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x84C0D0", Offset = "0x84AED0", VA = "0x18084C0D0", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x84AF80", Offset = "0x849D80", VA = "0x18084AF80", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00002FE8 File Offset: 0x000011E8
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "140")]
	public virtual float GetThreatLevel()
	{
		return 0f;
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00003000 File Offset: 0x00001200
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x84C040", Offset = "0x84AE40", VA = "0x18084C040", Slot = "113")]
	public override float PenetrationResistance(HitInfo info)
	{
		return 0f;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x84C180", Offset = "0x84AF80", VA = "0x18084C180", Slot = "141")]
	public virtual void ScaleDamage(HitInfo info)
	{
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00003018 File Offset: 0x00001218
	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x84C2C0", Offset = "0x84B0C0", VA = "0x18084C2C0")]
	public HitArea SkeletonLookup(uint boneID)
	{
		return (HitArea)0;
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x84B870", Offset = "0x84A670", VA = "0x18084B870", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060005FE RID: 1534 RVA: 0x00003030 File Offset: 0x00001230
	// (set) Token: 0x060005FF RID: 1535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000025")]
	public float health
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x84B730", Offset = "0x84A530", VA = "0x18084B730")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x84C540", Offset = "0x84B340", VA = "0x18084C540")]
		set
		{
		}
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00003048 File Offset: 0x00001248
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x84B730", Offset = "0x84A530", VA = "0x18084B730", Slot = "109")]
	public override float Health()
	{
		return 0f;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00003060 File Offset: 0x00001260
	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x3001B0", Offset = "0x2FEFB0", VA = "0x1803001B0", Slot = "110")]
	public override float MaxHealth()
	{
		return 0f;
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00003078 File Offset: 0x00001278
	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x300290", Offset = "0x2FF090", VA = "0x180300290", Slot = "142")]
	public virtual float StartHealth()
	{
		return 0f;
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00003090 File Offset: 0x00001290
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x84C370", Offset = "0x84B170", VA = "0x18084C370", Slot = "143")]
	public virtual float StartMaxHealth()
	{
		return 0f;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x84C230", Offset = "0x84B030", VA = "0x18084C230")]
	public void SetMaxHealth(float newMax)
	{
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x84AF90", Offset = "0x849D90", VA = "0x18084AF90")]
	public void DoHitNotify(HitInfo info)
	{
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x84B9C0", Offset = "0x84A7C0", VA = "0x18084B9C0", Slot = "115")]
	public override void OnAttacked(HitInfo info)
	{
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x84C390", Offset = "0x84B190", VA = "0x18084C390")]
	public BaseCombatEntity()
	{
	}

	// Token: 0x0400027D RID: 637
	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x160")]
	private Option __menuOption_Menu_Pickup;

	// Token: 0x0400027E RID: 638
	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x1B8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA4B50", Offset = "0xA3F50")]
	public SkeletonProperties skeletonProperties;

	// Token: 0x0400027F RID: 639
	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x1C0")]
	public ProtectionProperties baseProtection;

	// Token: 0x04000280 RID: 640
	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x1C8")]
	public float startHealth;

	// Token: 0x04000281 RID: 641
	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x1D0")]
	public BaseCombatEntity.Pickup pickup;

	// Token: 0x04000282 RID: 642
	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x1F0")]
	public BaseCombatEntity.Repair repair;

	// Token: 0x04000283 RID: 643
	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x218")]
	public bool ShowHealthInfo;

	// Token: 0x04000284 RID: 644
	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x21C")]
	public BaseCombatEntity.LifeState lifestate;

	// Token: 0x04000285 RID: 645
	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x220")]
	public bool sendsHitNotification;

	// Token: 0x04000286 RID: 646
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x221")]
	public bool sendsMeleeHitNotification;

	// Token: 0x04000287 RID: 647
	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x222")]
	public bool markAttackerHostile;

	// Token: 0x04000288 RID: 648
	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x224")]
	protected float _health;

	// Token: 0x04000289 RID: 649
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x228")]
	protected float _maxHealth;

	// Token: 0x0400028A RID: 650
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x22C")]
	public BaseCombatEntity.Faction faction;

	// Token: 0x0400028B RID: 651
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x230")]
	protected float deathTime;

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x234")]
	private int lastNotifyFrame;

	// Token: 0x0200004E RID: 78
	[Token(Token = "0x2000A59")]
	[Serializable]
	public struct Pickup
	{
		// Token: 0x0400028D RID: 653
		[Token(Token = "0x4003DA6")]
		[FieldOffset(Offset = "0x0")]
		public bool enabled;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x4003DA7")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "ItemSelector", RVA = "0x8D9E0", Offset = "0x8CDE0")]
		public ItemDefinition itemTarget;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x4003DA8")]
		[FieldOffset(Offset = "0x10")]
		public int itemCount;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4003DA9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xA5180", Offset = "0xA4580")]
		public bool setConditionFromHealth;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4003DAA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xA5220", Offset = "0xA4620")]
		public float subtractCondition;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4003DAB")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xA52B0", Offset = "0xA46B0")]
		public bool requireBuildingPrivilege;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4003DAC")]
		[FieldOffset(Offset = "0x1D")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xA5420", Offset = "0xA4820")]
		public bool requireHammer;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4003DAD")]
		[FieldOffset(Offset = "0x1E")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xA5510", Offset = "0xA4910")]
		public bool requireEmptyInv;
	}

	// Token: 0x0200004F RID: 79
	[Token(Token = "0x2000A5A")]
	[Serializable]
	public struct Repair
	{
		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4003DAE")]
		[FieldOffset(Offset = "0x0")]
		public bool enabled;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4003DAF")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "ItemSelector", RVA = "0x8D9E0", Offset = "0x8CDE0")]
		public ItemDefinition itemTarget;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4003DB0")]
		[FieldOffset(Offset = "0x10")]
		public GameObjectRef repairEffect;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4003DB1")]
		[FieldOffset(Offset = "0x18")]
		public GameObjectRef repairFullEffect;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4003DB2")]
		[FieldOffset(Offset = "0x20")]
		public GameObjectRef repairFailedEffect;
	}

	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000A5B")]
	public enum LifeState
	{
		// Token: 0x0400029B RID: 667
		[Token(Token = "0x4003DB4")]
		Alive,
		// Token: 0x0400029C RID: 668
		[Token(Token = "0x4003DB5")]
		Dead
	}

	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000A5C")]
	[Serializable]
	public enum Faction
	{
		// Token: 0x0400029E RID: 670
		[Token(Token = "0x4003DB7")]
		Default,
		// Token: 0x0400029F RID: 671
		[Token(Token = "0x4003DB8")]
		Player,
		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x4003DB9")]
		Bandit,
		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x4003DBA")]
		Scientist,
		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x4003DBB")]
		Horror
	}
}
