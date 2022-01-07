using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000058 RID: 88
[Token(Token = "0x200003B")]
public class BaseMountable : BaseCombatEntity
{
	// Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000220")]
	[Address(RVA = "0x2F74D0", Offset = "0x2F62D0", VA = "0x1802F74D0", Slot = "49")]
	public override void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600064F RID: 1615 RVA: 0x00003318 File Offset: 0x00001518
	[Token(Token = "0x17000039")]
	public override bool HasMenuOptions
	{
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2F9340", Offset = "0x2F8140", VA = "0x1802F9340", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00003330 File Offset: 0x00001530
	[Token(Token = "0x6000222")]
	[Address(RVA = "0x2F8100", Offset = "0x2F6F00", VA = "0x1802F8100", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00003348 File Offset: 0x00001548
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x2F6C60", Offset = "0x2F5A60", VA = "0x1802F6C60", Slot = "144")]
	public virtual bool CanHoldItems()
	{
		return default(bool);
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00003360 File Offset: 0x00001560
	[Token(Token = "0x6000224")]
	[Address(RVA = "0x2F7850", Offset = "0x2F6650", VA = "0x1802F7850", Slot = "145")]
	public virtual BasePlayer.CameraMode GetMountedCameraMode()
	{
		return BasePlayer.CameraMode.FirstPerson;
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00003378 File Offset: 0x00001578
	[Token(Token = "0x6000225")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "146")]
	public virtual bool DirectlyMountable()
	{
		return default(bool);
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000226")]
	[Address(RVA = "0x2F7440", Offset = "0x2F6240", VA = "0x1802F7440", Slot = "147")]
	public virtual Transform GetEyeOverride()
	{
		return null;
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00003390 File Offset: 0x00001590
	[Token(Token = "0x6000227")]
	[Address(RVA = "0x2F7800", Offset = "0x2F6600", VA = "0x1802F7800", Slot = "148")]
	public virtual Quaternion GetMountedBodyAngles()
	{
		return default(Quaternion);
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "149")]
	public virtual bool ModifiesThirdPersonCamera()
	{
		return default(bool);
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x2F7A30", Offset = "0x2F6830", VA = "0x1802F7A30", Slot = "150")]
	public virtual Vector2 GetPitchClamp()
	{
		return default(Vector2);
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x600022A")]
	[Address(RVA = "0x2F7A60", Offset = "0x2F6860", VA = "0x1802F7A60", Slot = "151")]
	public virtual Vector2 GetYawClamp()
	{
		return default(Vector2);
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x000033F0 File Offset: 0x000015F0
	[Token(Token = "0x600022B")]
	[Address(RVA = "0x2F7A80", Offset = "0x2F6880", VA = "0x1802F7A80", Slot = "152")]
	public virtual bool IsMounted()
	{
		return default(bool);
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x600022C")]
	[Address(RVA = "0x2F70C0", Offset = "0x2F5EC0", VA = "0x1802F70C0", Slot = "153")]
	public virtual Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot)
	{
		return default(Vector3);
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00003420 File Offset: 0x00001620
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x2F6FC0", Offset = "0x2F5DC0", VA = "0x1802F6FC0", Slot = "154")]
	public virtual Vector3 EyeCenterForPlayer(BasePlayer player, Quaternion lookRot)
	{
		return default(Vector3);
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00003438 File Offset: 0x00001638
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x2F91F0", Offset = "0x2F7FF0", VA = "0x1802F91F0", Slot = "155")]
	public virtual float WaterFactorForPlayer(BasePlayer player)
	{
		return 0f;
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00003450 File Offset: 0x00001650
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x2F7BC0", Offset = "0x2F69C0", VA = "0x1802F7BC0", Slot = "111")]
	public override float MaxVelocity()
	{
		return 0f;
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00003468 File Offset: 0x00001668
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x2F8700", Offset = "0x2F7500", VA = "0x1802F8700", Slot = "156")]
	public virtual bool PlayerIsMounted(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "157")]
	public virtual void OnClientInput(BasePlayer player)
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00003480 File Offset: 0x00001680
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "158")]
	public virtual bool ForceUpdatePlayerModel(BasePlayer p)
	{
		return default(bool);
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x2F8C00", Offset = "0x2F7A00", VA = "0x1802F8C00")]
	internal void UpdatePlayerModel(PlayerModel playerModel, bool playerHasHeldEntity)
	{
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "159")]
	protected virtual void ProcessPlayerModel(PlayerModel playerModel)
	{
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00003498 File Offset: 0x00001698
	[Token(Token = "0x6000235")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "160")]
	protected virtual bool SuppressHandsAnimationLayer()
	{
		return default(bool);
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "161")]
	protected virtual AnimatorOverrideController GetAnimationOverride()
	{
		return null;
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x2F7A50", Offset = "0x2F6850", VA = "0x1802F7A50", Slot = "162")]
	protected virtual float GetSpineLookAtWeight()
	{
		return 0f;
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x000034C8 File Offset: 0x000016C8
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "163")]
	protected virtual float GetMountedAnimationSpeed()
	{
		return 0f;
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x000034E0 File Offset: 0x000016E0
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x2F7D80", Offset = "0x2F6B80", VA = "0x1802F7D80", Slot = "164")]
	public virtual Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset)
	{
		return default(Vector3);
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x2F7B50", Offset = "0x2F6950", VA = "0x1802F7B50", Slot = "165")]
	public virtual bool LockThirdPersonOffset(out Vector3 offset)
	{
		return default(bool);
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00003510 File Offset: 0x00001710
	[Token(Token = "0x600023B")]
	[Address(RVA = "0x2F7A90", Offset = "0x2F6890", VA = "0x1802F7A90", Slot = "166")]
	public virtual bool LocalPlayerIsMounted()
	{
		return default(bool);
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x2F9160", Offset = "0x2F7F60", VA = "0x1802F9160", Slot = "167")]
	public virtual BaseVehicle VehicleParent()
	{
		return null;
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600066B RID: 1643 RVA: 0x00003528 File Offset: 0x00001728
	[Token(Token = "0x1700003A")]
	public virtual bool IsSummerDlcVehicle
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "168")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00003540 File Offset: 0x00001740
	[Token(Token = "0x600023E")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "169")]
	public virtual bool IsInstrument()
	{
		return default(bool);
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023F")]
	[Address(RVA = "0x2F8CE0", Offset = "0x2F7AE0", VA = "0x1802F8CE0", Slot = "170")]
	public virtual void UpdatePlayerModel(BasePlayer player)
	{
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000240")]
	[Address(RVA = "0x2F90B0", Offset = "0x2F7EB0", VA = "0x1802F90B0", Slot = "171")]
	public virtual void UpdatePlayerRotation(BasePlayer player)
	{
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x2F8BD0", Offset = "0x2F79D0", VA = "0x1802F8BD0", Slot = "59")]
	public override void SetNetworkPosition(Vector3 vPos)
	{
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x2F8F40", Offset = "0x2F7D40", VA = "0x1802F8F40")]
	public void UpdatePlayerPosition(BasePlayer player)
	{
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00003558 File Offset: 0x00001758
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x2F7920", Offset = "0x2F6720", VA = "0x1802F7920", Slot = "172")]
	public virtual Quaternion GetMountedRotation()
	{
		return default(Quaternion);
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x2F7860", Offset = "0x2F6660", VA = "0x1802F7860")]
	public Vector3 GetMountedPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x2F87A0", Offset = "0x2F75A0", VA = "0x1802F87A0", Slot = "173")]
	public virtual void PlayerMounted(BasePlayer player, bool wasSwap)
	{
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x2F8220", Offset = "0x2F7020", VA = "0x1802F8220", Slot = "174")]
	public virtual void PlayerDismounted(BasePlayer player, bool wasSwap)
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x2F6C70", Offset = "0x2F5A70", VA = "0x1802F6C70", Slot = "175")]
	protected virtual void ClientOnPlayerDismounted(BasePlayer player)
	{
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000248")]
	[Address(RVA = "0x2F6D10", Offset = "0x2F5B10", VA = "0x1802F6D10", Slot = "176")]
	protected virtual void ClientOnPlayerMounted(BasePlayer player)
	{
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000249")]
	[Address(RVA = "0x2F81F0", Offset = "0x2F6FF0", VA = "0x1802F81F0", Slot = "177")]
	public virtual void OverrideViewAngles(BasePlayer player)
	{
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024A")]
	[Address(RVA = "0x2F6EF0", Offset = "0x2F5CF0", VA = "0x1802F6EF0", Slot = "178")]
	public virtual void DoPlayerMovement(BasePlayer player, InputState input, ModelState modelState)
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024B")]
	[Address(RVA = "0x2F6DE0", Offset = "0x2F5BE0", VA = "0x1802F6DE0")]
	public void ClientRequestDismount()
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x2F7D10", Offset = "0x2F6B10", VA = "0x1802F7D10", Slot = "179")]
	[Attribute(Name = "Menu", RVA = "0xA9A80", Offset = "0xA8E80")]
	[Attribute(Name = "Description", RVA = "0xA9A80", Offset = "0xA8E80")]
	[Attribute(Name = "Icon", RVA = "0xA9A80", Offset = "0xA8E80")]
	[Attribute(Name = "ShowIf", RVA = "0xA9A80", Offset = "0xA8E80")]
	public virtual void Menu_Mount(BasePlayer player)
	{
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00003588 File Offset: 0x00001788
	[Token(Token = "0x600024D")]
	[Address(RVA = "0x2F7C70", Offset = "0x2F6A70", VA = "0x1802F7C70", Slot = "180")]
	public virtual bool Menu_Mount_ShowIf(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x000035A0 File Offset: 0x000017A0
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "181")]
	public virtual bool MountMenuVisible(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x000035B8 File Offset: 0x000017B8
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x2F7DA0", Offset = "0x2F6BA0", VA = "0x1802F7DA0")]
	public bool NearMountPoint(BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x000035D0 File Offset: 0x000017D0
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x2F6E20", Offset = "0x2F5C20", VA = "0x1802F6E20")]
	public static Vector3 ConvertVector(Vector3 vec)
	{
		return default(Vector3);
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600067F RID: 1663 RVA: 0x000035E8 File Offset: 0x000017E8
	[Token(Token = "0x1700003B")]
	public virtual bool BlocksDoors
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "182")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x2F9290", Offset = "0x2F8090", VA = "0x1802F9290")]
	public BaseMountable()
	{
	}

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x238")]
	private Option __menuOption_Menu_Mount;

	// Token: 0x040002DD RID: 733
	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x290")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA82E0", Offset = "0xA76E0")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA82E0", Offset = "0xA76E0")]
	public Transform eyePositionOverride;

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x298")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA9710", Offset = "0xA8B10")]
	public Transform eyeCenterOverride;

	// Token: 0x040002DF RID: 735
	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x2A0")]
	public Vector2 pitchClamp;

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x2A8")]
	public Vector2 yawClamp;

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x2B0")]
	public bool canWieldItems;

	// Token: 0x040002E2 RID: 738
	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x2B1")]
	public bool relativeViewAngles;

	// Token: 0x040002E3 RID: 739
	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x2B8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xA9770", Offset = "0xA8B70")]
	public Transform mountAnchor;

	// Token: 0x040002E4 RID: 740
	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x2C0")]
	public PlayerModel.MountPoses mountPose;

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x2C4")]
	public float maxMountDistance;

	// Token: 0x040002E6 RID: 742
	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x2C8")]
	public Transform[] dismountPositions;

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x2D0")]
	public bool checkPlayerLosOnMount;

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x2D1")]
	public bool disableMeshCullingForPlayers;

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x2D2")]
	public bool allowHeadLook;

	// Token: 0x040002EA RID: 746
	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x2D3")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA9830", Offset = "0xA8C30")]
	public bool modifiesPlayerCollider;

	// Token: 0x040002EB RID: 747
	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x2D4")]
	public BasePlayer.CapsuleColliderInfo customPlayerCollider;

	// Token: 0x040002EC RID: 748
	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x2E8")]
	public SoundDefinition mountSoundDef;

	// Token: 0x040002ED RID: 749
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x2F0")]
	public SoundDefinition swapSoundDef;

	// Token: 0x040002EE RID: 750
	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x2F8")]
	public SoundDefinition dismountSoundDef;

	// Token: 0x040002EF RID: 751
	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x300")]
	public BaseMountable.MountStatType mountTimeStatType;

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x304")]
	public BaseMountable.MountGestureType allowedGestures;

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x308")]
	public bool canDrinkWhileMounted;

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x309")]
	public bool allowSleeperMounting;

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x30A")]
	[Attribute(Name = "HelpAttribute", RVA = "0xA9910", Offset = "0xA8D10")]
	public bool animateClothInLocalSpace;

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x30C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x92CA0", Offset = "0x920A0")]
	public BasePlayer.CameraMode MountedCameraMode;

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x310")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA9A00", Offset = "0xA8E00")]
	public bool isMobile;

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x314")]
	public float SideLeanAmount;

	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000A5F")]
	public enum MountStatType
	{
		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x4003DC4")]
		None,
		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x4003DC5")]
		Boating,
		// Token: 0x040002FA RID: 762
		[Token(Token = "0x4003DC6")]
		Flying,
		// Token: 0x040002FB RID: 763
		[Token(Token = "0x4003DC7")]
		Driving
	}

	// Token: 0x0200005A RID: 90
	[Token(Token = "0x2000A60")]
	public enum MountGestureType
	{
		// Token: 0x040002FD RID: 765
		[Token(Token = "0x4003DC9")]
		None,
		// Token: 0x040002FE RID: 766
		[Token(Token = "0x4003DCA")]
		UpperBody
	}
}
