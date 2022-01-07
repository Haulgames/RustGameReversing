using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GameMenu;
using Il2CppDummyDll;
using Network;
using ProtoBuf;
using Spatial;
using UnityEngine;

// Token: 0x020000EC RID: 236
[Token(Token = "0x200009B")]
public class BaseEntity : global::BaseNetworkable, IProvider, ILerpTarget, IPrefabPreProcess
{
	// Token: 0x06000EE4 RID: 3812 RVA: 0x00008C88 File Offset: 0x00006E88
	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x88EDE0", Offset = "0x88DBE0", VA = "0x18088EDE0", Slot = "35")]
	public override bool OnRpcMessage(global::BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x88A350", Offset = "0x889150", VA = "0x18088A350")]
	public void GetEntityMenu(global::BasePlayer player, List<Option> optionList)
	{
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "49")]
	public virtual void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00008CA0 File Offset: 0x00006EA0
	[Token(Token = "0x1700014A")]
	public virtual bool HasMenuOptions
	{
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x88AA00", Offset = "0x889800", VA = "0x18088AA00", Slot = "51")]
	public virtual void GetItemOptions(List<Option> options)
	{
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00008CB8 File Offset: 0x00006EB8
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x88B460", Offset = "0x88A260", VA = "0x18088B460")]
	public global::BaseEntity.MovementModify GetMovementModify()
	{
		return default(global::BaseEntity.MovementModify);
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00008CD0 File Offset: 0x00006ED0
	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x88A490", Offset = "0x889290", VA = "0x18088A490", Slot = "52")]
	public virtual float GetExtrapolationTime()
	{
		return 0f;
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00008CE8 File Offset: 0x00006EE8
	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x88A850", Offset = "0x889650", VA = "0x18088A850", Slot = "53")]
	public virtual float GetInterpolationDelay()
	{
		return 0f;
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00008D00 File Offset: 0x00006F00
	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x88A8E0", Offset = "0x8896E0", VA = "0x18088A8E0", Slot = "54")]
	public virtual float GetInterpolationInertia()
	{
		return 0f;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00008D18 File Offset: 0x00006F18
	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x88A970", Offset = "0x889770", VA = "0x18088A970", Slot = "55")]
	public virtual float GetInterpolationSmoothing()
	{
		return 0f;
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00008D30 File Offset: 0x00006F30
	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x889DF0", Offset = "0x888BF0", VA = "0x180889DF0", Slot = "56")]
	public virtual Quaternion GetAngularVelocityClient()
	{
		return default(Quaternion);
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00008D48 File Offset: 0x00006F48
	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x88AC50", Offset = "0x889A50", VA = "0x18088AC50", Slot = "57")]
	public virtual Vector3 GetLocalVelocityClient()
	{
		return default(Vector3);
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x8882E0", Offset = "0x8870E0", VA = "0x1808882E0", Slot = "46")]
	public void DrawInterpolationState(TransformInterpolator.Segment segment, List<TransformInterpolator.Entry> entries)
	{
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x88D770", Offset = "0x88C570", VA = "0x18088D770", Slot = "47")]
	public void LerpIdleDisable()
	{
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x8874D0", Offset = "0x8862D0", VA = "0x1808874D0", Slot = "14")]
	protected override void ClientInit(Entity info)
	{
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x887580", Offset = "0x886380", VA = "0x180887580", Slot = "13")]
	public override void ClientOnEnable()
	{
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x88EA80", Offset = "0x88D880", VA = "0x18088EA80")]
	public void OnPositionalFromNetwork(Vector3 vPos, Vector3 vAng, float time)
	{
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x891D30", Offset = "0x890B30", VA = "0x180891D30")]
	public void StartLerping(float time)
	{
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x891EB0", Offset = "0x890CB0", VA = "0x180891EB0")]
	public void StopLerping()
	{
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00008D60 File Offset: 0x00006F60
	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x891930", Offset = "0x890730", VA = "0x180891930", Slot = "58")]
	public virtual bool ShouldLerp()
	{
		return default(bool);
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x891420", Offset = "0x890220", VA = "0x180891420", Slot = "59")]
	public virtual void SetNetworkPosition(Vector3 vPos)
	{
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x891590", Offset = "0x890390", VA = "0x180891590", Slot = "60")]
	public virtual void SetNetworkRotation(Quaternion qRot)
	{
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x8882C0", Offset = "0x8870C0", VA = "0x1808882C0", Slot = "61")]
	public virtual void DoDestroyEffects(global::BaseNetworkable.DestroyMode mode, Message msg)
	{
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x891A30", Offset = "0x890830", VA = "0x180891A30", Slot = "62")]
	protected virtual void SpawnGibs()
	{
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0", Slot = "20")]
	internal override void DoNetworkDestroy()
	{
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x8900B0", Offset = "0x88EEB0", VA = "0x1808900B0", Slot = "16")]
	public override void PostNetworkUpdate()
	{
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x88E7C0", Offset = "0x88D5C0", VA = "0x18088E7C0", Slot = "63")]
	public virtual void OnBecameRagdoll(Ragdoll rdoll)
	{
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00008D78 File Offset: 0x00006F78
	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x88ADD0", Offset = "0x889BD0", VA = "0x18088ADD0", Slot = "64")]
	public virtual Info GetMenuInformation(GameObject primaryObject, global::BasePlayer player)
	{
		return default(Info);
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x00008D90 File Offset: 0x00006F90
	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x88C1B0", Offset = "0x88AFB0", VA = "0x18088C1B0", Slot = "65")]
	protected virtual bool HideMenuItems(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x88B0C0", Offset = "0x889EC0", VA = "0x18088B0C0", Slot = "66")]
	public virtual List<Option> GetMenuItems(global::BasePlayer player)
	{
		return null;
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x88FEA0", Offset = "0x88ECA0", VA = "0x18088FEA0", Slot = "67")]
	public virtual void OnUse(global::BasePlayer player)
	{
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x88FD10", Offset = "0x88EB10", VA = "0x18088FD10", Slot = "68")]
	public virtual void OnUseHeld(global::BasePlayer player)
	{
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "69")]
	public virtual void OnUseStopped(global::BasePlayer player)
	{
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "70")]
	public virtual void OnRendered()
	{
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x887F80", Offset = "0x886D80", VA = "0x180887F80", Slot = "19")]
	protected override void DoClientDestroy()
	{
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x88A520", Offset = "0x889320", VA = "0x18088A520", Slot = "71")]
	internal virtual Transform GetEyeTransform()
	{
		return null;
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x00008DA8 File Offset: 0x00006FA8
	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x88E6B0", Offset = "0x88D4B0", VA = "0x18088E6B0", Slot = "72")]
	public virtual bool NeedsCrosshair()
	{
		return default(bool);
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00008DC0 File Offset: 0x00006FC0
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "73")]
	public virtual bool AlwaysShowCrosshair()
	{
		return default(bool);
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00008DD8 File Offset: 0x00006FD8
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x891880", Offset = "0x890680", VA = "0x180891880", Slot = "17")]
	public override bool ShouldDestroyWithGroup()
	{
		return default(bool);
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x887B80", Offset = "0x886980", VA = "0x180887B80")]
	public void DetachEffects()
	{
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "74")]
	public virtual void OnVoiceData(byte[] data)
	{
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "75")]
	public virtual void LookingAtTick()
	{
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00008DF0 File Offset: 0x00006FF0
	[Token(Token = "0x1700014B")]
	public virtual float RealisticMass
	{
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x31BB70", Offset = "0x31A970", VA = "0x18031BB70", Slot = "76")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x88E870", Offset = "0x88D670", VA = "0x18088E870", Slot = "77")]
	public virtual void OnCollision(Collision collision, global::BaseEntity hitEntity)
	{
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x8901A0", Offset = "0x88EFA0", VA = "0x1808901A0")]
	protected void ReceiveCollisionMessages(bool b)
	{
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "78")]
	public virtual void DebugClient(int rep, float time)
	{
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0x88E8C0", Offset = "0x88D6C0", VA = "0x18088E8C0")]
	public void OnDebugStart()
	{
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x887AA0", Offset = "0x8868A0", VA = "0x180887AA0")]
	protected void DebugText(Vector3 pos, string str, Color color, float time)
	{
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00008E08 File Offset: 0x00007008
	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x88C170", Offset = "0x88AF70", VA = "0x18088C170", Slot = "79")]
	public bool HasFlag(global::BaseEntity.Flags f)
	{
		return default(bool);
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00008E20 File Offset: 0x00007020
	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x890010", Offset = "0x88EE10", VA = "0x180890010")]
	public bool ParentHasFlag(global::BaseEntity.Flags f)
	{
		return default(bool);
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x891250", Offset = "0x890050", VA = "0x180891250")]
	public void SetFlag(global::BaseEntity.Flags f, bool b, bool recursive = false, bool networkupdate = true)
	{
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00008E38 File Offset: 0x00007038
	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x885F20", Offset = "0x884D20", VA = "0x180885F20")]
	public bool IsOn()
	{
		return default(bool);
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00008E50 File Offset: 0x00007050
	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x88C7E0", Offset = "0x88B5E0", VA = "0x18088C7E0")]
	public bool IsOpen()
	{
		return default(bool);
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00008E68 File Offset: 0x00007068
	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x88C7D0", Offset = "0x88B5D0", VA = "0x18088C7D0")]
	public bool IsOnFire()
	{
		return default(bool);
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00008E80 File Offset: 0x00007080
	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x88C520", Offset = "0x88B320", VA = "0x18088C520")]
	public bool IsLocked()
	{
		return default(bool);
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00008E98 File Offset: 0x00007098
	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x88C330", Offset = "0x88B130", VA = "0x18088C330", Slot = "4")]
	public override bool IsDebugging()
	{
		return default(bool);
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00008EB0 File Offset: 0x000070B0
	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x88C340", Offset = "0x88B140", VA = "0x18088C340")]
	public bool IsDisabled()
	{
		return default(bool);
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00008EC8 File Offset: 0x000070C8
	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x88C320", Offset = "0x88B120", VA = "0x18088C320")]
	public bool IsBroken()
	{
		return default(bool);
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x00008EE0 File Offset: 0x000070E0
	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x88C1B0", Offset = "0x88AFB0", VA = "0x18088C1B0")]
	public bool IsBusy()
	{
		return default(bool);
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x88AD80", Offset = "0x889B80", VA = "0x18088AD80", Slot = "5")]
	public override string GetLogColor()
	{
		return null;
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x88E980", Offset = "0x88D780", VA = "0x18088E980", Slot = "80")]
	public virtual void OnFlagsChanged(global::BaseEntity.Flags old, global::BaseEntity.Flags next)
	{
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00008EF8 File Offset: 0x000070F8
	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x88C620", Offset = "0x88B420", VA = "0x18088C620")]
	public bool IsOccupied(Socket_Base socket)
	{
		return default(bool);
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00008F10 File Offset: 0x00007110
	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x88C530", Offset = "0x88B330", VA = "0x18088C530")]
	public bool IsOccupied(string socketName)
	{
		return default(bool);
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0x888FB0", Offset = "0x887DB0", VA = "0x180888FB0")]
	public EntityLink FindLink(Socket_Base socket)
	{
		return null;
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x8890B0", Offset = "0x887EB0", VA = "0x1808890B0")]
	public EntityLink FindLink(string socketName)
	{
		return null;
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x889190", Offset = "0x887F90", VA = "0x180889190")]
	public EntityLink FindLink(string[] socketNames)
	{
		return null;
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABF")]
	public T FindLinkedEntity<T>() where T : global::BaseEntity
	{
		return null;
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC0")]
	public void EntityLinkMessage<T>(Action<T> action) where T : global::BaseEntity
	{
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC1")]
	public void EntityLinkBroadcast<T, S>(Action<T> action, Func<S, bool> canTraverseSocket) where T : global::BaseEntity where S : Socket_Base
	{
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC2")]
	public void EntityLinkBroadcast<T>(Action<T> action) where T : global::BaseEntity
	{
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x888A90", Offset = "0x887890", VA = "0x180888A90")]
	public void EntityLinkBroadcast()
	{
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00008F28 File Offset: 0x00007128
	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x890230", Offset = "0x88F030", VA = "0x180890230")]
	public bool ReceivedEntityLinkBroadcast()
	{
		return default(bool);
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x88A310", Offset = "0x889110", VA = "0x18088A310")]
	public List<EntityLink> GetEntityLinks(bool linkToNeighbours = true)
	{
		return null;
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x88D7A0", Offset = "0x88C5A0", VA = "0x18088D7A0")]
	private void LinkToEntity(global::BaseEntity other)
	{
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x88DA00", Offset = "0x88C800", VA = "0x18088DA00")]
	private void LinkToNeighbours()
	{
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x88C1C0", Offset = "0x88AFC0", VA = "0x18088C1C0")]
	private void InitEntityLinks()
	{
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x889D10", Offset = "0x888B10", VA = "0x180889D10")]
	private void FreeEntityLinks()
	{
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x8902A0", Offset = "0x88F0A0", VA = "0x1808902A0")]
	public void RefreshEntityLinks()
	{
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x890B20", Offset = "0x88F920", VA = "0x180890B20")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x867B0", Offset = "0x85BB0")]
	public void RequestFileFromServer(uint crc, FileStorage.Type type, string responseFunction, uint part = 0U)
	{
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x8907E0", Offset = "0x88F5E0", VA = "0x1808907E0")]
	public void RequestFileFromServer(IServerFileReceiver receiver, FileStorage.Type type, uint crc, uint part = 0U)
	{
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x8871E0", Offset = "0x885FE0", VA = "0x1808871E0")]
	[global::BaseEntity.RPC_Client]
	public void CL_ReceiveFileRequest(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0x887770", Offset = "0x886570", VA = "0x180887770")]
	private void CompletePendingFileRequests(FileStorage.Type type, uint crc, uint part, byte[] data)
	{
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACF")]
	[Address(RVA = "0x892070", Offset = "0x890E70", VA = "0x180892070")]
	public void UpdateChildren()
	{
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0x892EC0", Offset = "0x891CC0", VA = "0x180892EC0")]
	public void UpdateParenting()
	{
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0x8927A0", Offset = "0x8915A0", VA = "0x1808927A0")]
	public void UpdateParenting(bool worldPositionStays)
	{
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD2")]
	[Address(RVA = "0x891660", Offset = "0x890460", VA = "0x180891660")]
	private void SetParentTransform(Transform parent, bool worldPositionStays = true)
	{
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD3")]
	[Address(RVA = "0x892420", Offset = "0x891220", VA = "0x180892420")]
	protected void UpdateDisableState()
	{
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x00008F40 File Offset: 0x00007140
	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0x88BFD0", Offset = "0x88ADD0", VA = "0x18088BFD0")]
	private bool HasClientTransformOffset()
	{
		return default(bool);
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD5")]
	[Address(RVA = "0x8905B0", Offset = "0x88F3B0", VA = "0x1808905B0")]
	private void RemoveClientTransformOffset()
	{
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD6")]
	[Address(RVA = "0x886BA0", Offset = "0x8859A0", VA = "0x180886BA0")]
	private void AddClientTransformOffset()
	{
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD7")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "81")]
	public virtual void OnParentChangingClient(Transform oldParent, Transform newParent)
	{
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x88A2A0", Offset = "0x8890A0", VA = "0x18088A2A0", Slot = "82")]
	public virtual BuildingPrivlidge GetBuildingPrivilege()
	{
		return null;
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x889FB0", Offset = "0x888DB0", VA = "0x180889FB0")]
	public BuildingPrivlidge GetBuildingPrivilege(OBB obb)
	{
		return null;
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADA")]
	public void ServerRPC<T1, T2, T3, T4, T5>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADB")]
	public void ServerRPC<T1, T2, T3, T4>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADC")]
	public void ServerRPC<T1, T2, T3>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3)
	{
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADD")]
	public void ServerRPC<T1, T2>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2)
	{
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADE")]
	public void ServerRPC<T1>(SendMethod sendMethod, string funcName, T1 arg1)
	{
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x890F10", Offset = "0x88FD10", VA = "0x180890F10")]
	public void ServerRPC(SendMethod sendMethod, string funcName)
	{
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE0")]
	public void ServerRPC<T1, T2, T3, T4, T5>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE1")]
	public void ServerRPC<T1, T2, T3, T4>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE2")]
	public void ServerRPC<T1, T2, T3>(string funcName, T1 arg1, T2 arg2, T3 arg3)
	{
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE3")]
	public void ServerRPC<T1, T2>(string funcName, T1 arg1, T2 arg2)
	{
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE4")]
	public void ServerRPC<T1>(string funcName, T1 arg1)
	{
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x891240", Offset = "0x890040", VA = "0x180891240")]
	public void ServerRPC(string funcName)
	{
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00008F58 File Offset: 0x00007158
	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x890D60", Offset = "0x88FB60", VA = "0x180890D60")]
	private bool ServerRPCStart(string funcName)
	{
		return default(bool);
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE7")]
	private void ServerRPCWrite<T>(T arg)
	{
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0x890CF0", Offset = "0x88FAF0", VA = "0x180890CF0")]
	private void ServerRPCSend(SendInfo sendInfo)
	{
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AE9")]
	public void ServerRPCList<T1, T2, T3, T4, T5>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEA")]
	public void ServerRPCList<T1, T2, T3, T4, T5, T6>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
	{
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x886EF0", Offset = "0x885CF0", VA = "0x180886EF0")]
	public void CL_RPCMessage(uint nameID, ulong sourceConnection, Message message)
	{
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x890C40", Offset = "0x88FA40", VA = "0x180890C40")]
	public void SendSignalBroadcast(global::BaseEntity.Signal signal, string arg = "")
	{
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x891950", Offset = "0x890750", VA = "0x180891950")]
	[global::BaseEntity.RPC_Client]
	private void SignalFromServerEx(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x8919E0", Offset = "0x8907E0", VA = "0x1808919E0")]
	[global::BaseEntity.RPC_Client]
	private void SignalFromServer(global::BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "83")]
	public virtual void OnSignal(global::BaseEntity.Signal signal, string arg)
	{
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x88F9E0", Offset = "0x88E7E0", VA = "0x18088F9E0")]
	private void OnSkinChanged(ulong oldSkinID, ulong newSkinID)
	{
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x88FCF0", Offset = "0x88EAF0", VA = "0x18088FCF0")]
	private void OnSkinRefreshStart()
	{
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x88FCD0", Offset = "0x88EAD0", VA = "0x18088FCD0")]
	private void OnSkinRefreshEnd()
	{
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x8900D0", Offset = "0x88EED0", VA = "0x1808900D0", Slot = "84")]
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00008F70 File Offset: 0x00007170
	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x88BEF0", Offset = "0x88ACF0", VA = "0x18088BEF0")]
	public bool HasAnySlot()
	{
		return default(bool);
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x88BA70", Offset = "0x88A870", VA = "0x18088BA70")]
	public global::BaseEntity GetSlot(global::BaseEntity.Slot slot)
	{
		return null;
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x88B930", Offset = "0x88A730", VA = "0x18088B930")]
	public string GetSlotAnchorName(global::BaseEntity.Slot slot)
	{
		return null;
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x88B9C0", Offset = "0x88A7C0", VA = "0x18088B9C0")]
	public Transform GetSlotAnchor(global::BaseEntity.Slot slot)
	{
		return null;
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00008F88 File Offset: 0x00007188
	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "85")]
	public virtual bool HasSlot(global::BaseEntity.Slot slot)
	{
		return default(bool);
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00008FA0 File Offset: 0x000071A0
	[Token(Token = "0x1700014C")]
	public virtual global::BaseEntity.TraitFlag Traits
	{
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "86")]
		get
		{
			return global::BaseEntity.TraitFlag.None;
		}
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00008FB8 File Offset: 0x000071B8
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x88C180", Offset = "0x88AF80", VA = "0x18088C180")]
	public bool HasTrait(global::BaseEntity.TraitFlag f)
	{
		return default(bool);
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00008FD0 File Offset: 0x000071D0
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x88BFA0", Offset = "0x88ADA0", VA = "0x18088BFA0")]
	public bool HasAnyTrait(global::BaseEntity.TraitFlag f)
	{
		return default(bool);
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00008FE8 File Offset: 0x000071E8
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x8889E0", Offset = "0x8877E0", VA = "0x1808889E0", Slot = "87")]
	public virtual bool EnterTrigger(TriggerBase trigger)
	{
		return default(bool);
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x88D6D0", Offset = "0x88C4D0", VA = "0x18088D6D0", Slot = "88")]
	public virtual void LeaveTrigger(TriggerBase trigger)
	{
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x890610", Offset = "0x88F410", VA = "0x180890610")]
	public void RemoveFromTriggers()
	{
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFF")]
	public T FindTrigger<T>() where T : TriggerBase
	{
		return null;
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00009000 File Offset: 0x00007200
	[Token(Token = "0x6000B00")]
	public bool FindTrigger<T>(out T result) where T : TriggerBase
	{
		return default(bool);
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x889290", Offset = "0x888090", VA = "0x180889290")]
	private void ForceUpdateTriggersAction()
	{
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x8892C0", Offset = "0x8880C0", VA = "0x1808892C0")]
	public void ForceUpdateTriggers(bool enter = true, bool exit = true, bool invoke = true)
	{
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x88E690", Offset = "0x88D490", VA = "0x18088E690", Slot = "89")]
	public virtual void MakeVisible()
	{
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x8922A0", Offset = "0x8910A0", VA = "0x1808922A0", Slot = "90")]
	protected virtual void UpdateCullingSpheres()
	{
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x890380", Offset = "0x88F180", VA = "0x180890380", Slot = "91")]
	protected virtual void RegisterForCulling()
	{
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "92")]
	protected virtual void OnVisibilityChanged(bool visible)
	{
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x891FF0", Offset = "0x890DF0", VA = "0x180891FF0", Slot = "93")]
	protected virtual void UnregisterFromCulling()
	{
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x8921D0", Offset = "0x890FD0", VA = "0x1808921D0", Slot = "94")]
	protected virtual void UpdateCullingBounds()
	{
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00009018 File Offset: 0x00007218
	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x8874B0", Offset = "0x8862B0", VA = "0x1808874B0", Slot = "95")]
	protected virtual bool CheckVisibility()
	{
		return default(bool);
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00009030 File Offset: 0x00007230
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x887390", Offset = "0x886190", VA = "0x180887390")]
	protected float CalcEntityVisUpdateRate()
	{
		return 0f;
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x8879D0", Offset = "0x8867D0", VA = "0x1808879D0", Slot = "96")]
	protected virtual void DebugDrawCullingBounds()
	{
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00009048 File Offset: 0x00007248
	// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700014D")]
	public float Weight
	{
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x8936A0", Offset = "0x8924A0", VA = "0x1808936A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x8936C0", Offset = "0x8924C0", VA = "0x1808936C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		protected set
		{
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014E")]
	public EntityComponentBase[] Components
	{
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x893620", Offset = "0x892420", VA = "0x180893620")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "97")]
	public virtual global::BasePlayer ToPlayer()
	{
		return null;
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00009060 File Offset: 0x00007260
	[Token(Token = "0x1700014F")]
	public virtual bool IsNpc
	{
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "98")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x88C300", Offset = "0x88B100", VA = "0x18088C300", Slot = "28")]
	public override void InitShared()
	{
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x887B60", Offset = "0x886960", VA = "0x180887B60", Slot = "31")]
	public override void DestroyShared()
	{
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x890BD0", Offset = "0x88F9D0", VA = "0x180890BD0", Slot = "27")]
	public override void ResetState()
	{
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00009078 File Offset: 0x00007278
	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "99")]
	public virtual float InheritedVelocityScale()
	{
		return 0f;
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x00009090 File Offset: 0x00007290
	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x88A6A0", Offset = "0x8894A0", VA = "0x18088A6A0", Slot = "100")]
	public virtual Vector3 GetInheritedProjectileVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x000090A8 File Offset: 0x000072A8
	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x88A820", Offset = "0x889620", VA = "0x18088A820", Slot = "101")]
	public virtual Vector3 GetInheritedThrowVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x000090C0 File Offset: 0x000072C0
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x88A5C0", Offset = "0x8893C0", VA = "0x18088A5C0", Slot = "102")]
	public virtual Vector3 GetInheritedDropVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x000090D8 File Offset: 0x000072D8
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x88B670", Offset = "0x88A470", VA = "0x18088B670")]
	public Vector3 GetParentVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x000090F0 File Offset: 0x000072F0
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x88BAD0", Offset = "0x88A8D0", VA = "0x18088BAD0")]
	public Vector3 GetWorldVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x00009108 File Offset: 0x00007308
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x88ACE0", Offset = "0x889AE0", VA = "0x18088ACE0")]
	public Vector3 GetLocalVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00009120 File Offset: 0x00007320
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x889E80", Offset = "0x888C80", VA = "0x180889E80")]
	public Quaternion GetAngularVelocity()
	{
		return default(Quaternion);
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00009138 File Offset: 0x00007338
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x893350", Offset = "0x892150", VA = "0x180893350")]
	public OBB WorldSpaceBounds()
	{
		return default(OBB);
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00009150 File Offset: 0x00007350
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x4B1A60", Offset = "0x4B0860", VA = "0x1804B1A60")]
	public Vector3 PivotPoint()
	{
		return default(Vector3);
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x00009168 File Offset: 0x00007368
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x887470", Offset = "0x886270", VA = "0x180887470")]
	public Vector3 CenterPoint()
	{
		return default(Vector3);
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00009180 File Offset: 0x00007380
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x8876D0", Offset = "0x8864D0", VA = "0x1808876D0")]
	public Vector3 ClosestPoint(Vector3 position)
	{
		return default(Vector3);
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00009198 File Offset: 0x00007398
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x887470", Offset = "0x886270", VA = "0x180887470", Slot = "103")]
	public virtual Vector3 TriggerPoint()
	{
		return default(Vector3);
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x000091B0 File Offset: 0x000073B0
	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x887E40", Offset = "0x886C40", VA = "0x180887E40", Slot = "104")]
	public float Distance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x000091C8 File Offset: 0x000073C8
	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x891BF0", Offset = "0x8909F0", VA = "0x180891BF0")]
	public float SqrDistance(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x000091E0 File Offset: 0x000073E0
	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x887DE0", Offset = "0x886BE0", VA = "0x180887DE0")]
	public float Distance(global::BaseEntity other)
	{
		return 0f;
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x000091F8 File Offset: 0x000073F8
	[Token(Token = "0x6000B24")]
	[Address(RVA = "0x891B90", Offset = "0x890990", VA = "0x180891B90")]
	public float SqrDistance(global::BaseEntity other)
	{
		return 0f;
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00009210 File Offset: 0x00007410
	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x887CB0", Offset = "0x886AB0", VA = "0x180887CB0")]
	public float Distance2D(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00009228 File Offset: 0x00007428
	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x891A60", Offset = "0x890860", VA = "0x180891A60")]
	public float SqrDistance2D(Vector3 position)
	{
		return 0f;
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00009240 File Offset: 0x00007440
	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x887DE0", Offset = "0x886BE0", VA = "0x180887DE0")]
	public float Distance2D(global::BaseEntity other)
	{
		return 0f;
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00009258 File Offset: 0x00007458
	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x891B90", Offset = "0x890990", VA = "0x180891B90")]
	public float SqrDistance2D(global::BaseEntity other)
	{
		return 0f;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00009270 File Offset: 0x00007470
	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x88D310", Offset = "0x88C110", VA = "0x18088D310")]
	public bool IsVisible(Ray ray, int layerMask, float maxDistance)
	{
		return default(bool);
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00009288 File Offset: 0x00007488
	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x88CCD0", Offset = "0x88BAD0", VA = "0x18088CCD0")]
	public bool IsVisibleSpecificLayers(Vector3 position, Vector3 target, int layerMask, float maxDistance = float.PositiveInfinity)
	{
		return default(bool);
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x000092A0 File Offset: 0x000074A0
	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x88CF40", Offset = "0x88BD40", VA = "0x18088CF40")]
	public bool IsVisible(Vector3 position, Vector3 target, float maxDistance = float.PositiveInfinity)
	{
		return default(bool);
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x000092B8 File Offset: 0x000074B8
	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x88D1C0", Offset = "0x88BFC0", VA = "0x18088D1C0")]
	public bool IsVisible(Vector3 position, float maxDistance = float.PositiveInfinity)
	{
		return default(bool);
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x000092D0 File Offset: 0x000074D0
	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0x88CAD0", Offset = "0x88B8D0", VA = "0x18088CAD0")]
	public bool IsVisibleAndCanSee(Vector3 position, float maxDistance = float.PositiveInfinity)
	{
		return default(bool);
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x000092E8 File Offset: 0x000074E8
	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0x88C730", Offset = "0x88B530", VA = "0x18088C730")]
	public bool IsOlderThan(global::BaseEntity other)
	{
		return default(bool);
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00009300 File Offset: 0x00007500
	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0x88C7F0", Offset = "0x88B5F0", VA = "0x18088C7F0", Slot = "105")]
	public virtual bool IsOutside()
	{
		return default(bool);
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00009318 File Offset: 0x00007518
	[Token(Token = "0x6000B30")]
	[Address(RVA = "0x88C840", Offset = "0x88B640", VA = "0x18088C840")]
	public bool IsOutside(Vector3 position)
	{
		return default(bool);
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00009330 File Offset: 0x00007530
	[Token(Token = "0x6000B31")]
	[Address(RVA = "0x892ED0", Offset = "0x891CD0", VA = "0x180892ED0", Slot = "106")]
	public virtual float WaterFactor()
	{
		return 0f;
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00009348 File Offset: 0x00007548
	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x886C40", Offset = "0x885A40", VA = "0x180886C40", Slot = "107")]
	public virtual float AirFactor()
	{
		return 0f;
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00009360 File Offset: 0x00007560
	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x893090", Offset = "0x891E90", VA = "0x180893090")]
	public bool WaterTestFromVolumes(Vector3 pos, out WaterLevel.WaterInfo info)
	{
		return default(bool);
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00009378 File Offset: 0x00007578
	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x88C3E0", Offset = "0x88B1E0", VA = "0x18088C3E0")]
	public bool IsInWaterVolume(Vector3 pos)
	{
		return default(bool);
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00009390 File Offset: 0x00007590
	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x892F60", Offset = "0x891D60", VA = "0x180892F60")]
	public bool WaterTestFromVolumes(Bounds bounds, out WaterLevel.WaterInfo info)
	{
		return default(bool);
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x000093A8 File Offset: 0x000075A8
	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x8931C0", Offset = "0x891FC0", VA = "0x1808931C0")]
	public bool WaterTestFromVolumes(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info)
	{
		return default(bool);
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x000093C0 File Offset: 0x000075C0
	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "108")]
	public virtual bool BlocksWaterFor(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x000093D8 File Offset: 0x000075D8
	[Token(Token = "0x6000B38")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "109")]
	public virtual float Health()
	{
		return 0f;
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x000093F0 File Offset: 0x000075F0
	[Token(Token = "0x6000B39")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "110")]
	public virtual float MaxHealth()
	{
		return 0f;
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00009408 File Offset: 0x00007608
	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x2F77F0", Offset = "0x2F65F0", VA = "0x1802F77F0", Slot = "111")]
	public virtual float MaxVelocity()
	{
		return 0f;
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x00009420 File Offset: 0x00007620
	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x886C80", Offset = "0x885A80", VA = "0x180886C80", Slot = "112")]
	public virtual float BoundsPadding()
	{
		return 0f;
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00009438 File Offset: 0x00007638
	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x31BB70", Offset = "0x31A970", VA = "0x18031BB70", Slot = "113")]
	public virtual float PenetrationResistance(HitInfo info)
	{
		return 0f;
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x88A5B0", Offset = "0x8893B0", VA = "0x18088A5B0", Slot = "114")]
	public virtual GameObjectRef GetImpactEffect(HitInfo info)
	{
		return null;
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "115")]
	public virtual void OnAttacked(HitInfo info)
	{
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "116")]
	public virtual global::Item GetItem()
	{
		return null;
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "117")]
	public virtual global::Item GetItem(uint itemId)
	{
		return null;
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B41")]
	[Address(RVA = "0x88BEC0", Offset = "0x88ACC0", VA = "0x18088BEC0", Slot = "118")]
	public virtual void GiveItem(global::Item item, global::BaseEntity.GiveItemReason reason = global::BaseEntity.GiveItemReason.Generic)
	{
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x00009450 File Offset: 0x00007650
	[Token(Token = "0x6000B42")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "119")]
	public virtual bool CanBeLooted(global::BasePlayer player)
	{
		return default(bool);
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x3212A0", Offset = "0x3200A0", VA = "0x1803212A0", Slot = "120")]
	public virtual global::BaseEntity GetEntity()
	{
		return null;
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x891F00", Offset = "0x890D00", VA = "0x180891F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x887440", Offset = "0x886240", VA = "0x180887440", Slot = "121")]
	public virtual string Categorize()
	{
		return null;
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x88E1E0", Offset = "0x88CFE0", VA = "0x18088E1E0")]
	public void Log(string str)
	{
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x891370", Offset = "0x890170", VA = "0x180891370")]
	public void SetModel(Model mdl)
	{
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x88B450", Offset = "0x88A250", VA = "0x18088B450")]
	public Model GetModel()
	{
		return null;
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x889F20", Offset = "0x888D20", VA = "0x180889F20", Slot = "122")]
	public virtual Transform[] GetBones()
	{
		return null;
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x888E40", Offset = "0x887C40", VA = "0x180888E40", Slot = "123")]
	public virtual Transform FindBone(string strName)
	{
		return null;
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00009468 File Offset: 0x00007668
	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x888D60", Offset = "0x887B60", VA = "0x180888D60", Slot = "124")]
	public virtual uint FindBoneID(Transform boneTransform)
	{
		return 0U;
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x888EF0", Offset = "0x887CF0", VA = "0x180888EF0", Slot = "125")]
	public virtual Transform FindClosestBone(Vector3 worldPos)
	{
		return null;
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00009480 File Offset: 0x00007680
	// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000150")]
	public ulong OwnerID
	{
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x893690", Offset = "0x892490", VA = "0x180893690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return 0UL;
		}
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x8936B0", Offset = "0x8924B0", VA = "0x1808936B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00009498 File Offset: 0x00007698
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "126")]
	public virtual bool ShouldBlockProjectiles()
	{
		return default(bool);
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x000094B0 File Offset: 0x000076B0
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "127")]
	public virtual bool ShouldInheritNetworkGroup()
	{
		return default(bool);
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x000094C8 File Offset: 0x000076C8
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "128")]
	public virtual bool SupportsChildDeployables()
	{
		return default(bool);
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x886C90", Offset = "0x885A90", VA = "0x180886C90")]
	public void BroadcastEntityMessage(string msg, float radius = 20f, int layerMask = 1218652417)
	{
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "129")]
	public virtual void OnEntityMessage(global::BaseEntity from, string msg)
	{
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x88DCE0", Offset = "0x88CAE0", VA = "0x18088DCE0", Slot = "34")]
	public override void Load(global::BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x893510", Offset = "0x892310", VA = "0x180893510")]
	public BaseEntity()
	{
	}

	// Token: 0x0400095D RID: 2397
	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Ragdoll ragdoll;

	// Token: 0x0400095E RID: 2398
	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal PositionLerp positionLerp;

	// Token: 0x0400095F RID: 2399
	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Option> menuOptions;

	// Token: 0x04000960 RID: 2400
	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Queue<global::BaseEntity> globalBroadcastQueue;

	// Token: 0x04000961 RID: 2401
	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static uint globalBroadcastProtocol;

	// Token: 0x04000962 RID: 2402
	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private uint broadcastProtocol;

	// Token: 0x04000963 RID: 2403
	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<EntityLink> links;

	// Token: 0x04000964 RID: 2404
	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool linkedToNeighbours;

	// Token: 0x04000965 RID: 2405
	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<global::BaseEntity.ServerFileRequest> _pendingFileRequests;

	// Token: 0x04000966 RID: 2406
	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Action updateParentingAction;

	// Token: 0x04000967 RID: 2407
	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private global::BaseEntity addedToParentEntity;

	// Token: 0x04000968 RID: 2408
	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[NonSerialized]
	public ItemSkin itemSkin;

	// Token: 0x04000969 RID: 2409
	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private EntityRef[] entitySlots;

	// Token: 0x0400096A RID: 2410
	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected List<TriggerBase> triggers;

	// Token: 0x0400096B RID: 2411
	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected bool isVisible;

	// Token: 0x0400096C RID: 2412
	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	protected bool isAnimatorVisible;

	// Token: 0x0400096D RID: 2413
	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
	protected bool isShadowVisible;

	// Token: 0x0400096E RID: 2414
	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected OccludeeSphere localOccludee;

	// Token: 0x0400096F RID: 2415
	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private float <Weight>k__BackingField;

	// Token: 0x04000970 RID: 2416
	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x864A0", Offset = "0x858A0")]
	public Bounds bounds;

	// Token: 0x04000971 RID: 2417
	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObjectRef impactEffect;

	// Token: 0x04000972 RID: 2418
	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public bool enableSaving;

	// Token: 0x04000973 RID: 2419
	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	public bool syncPosition;

	// Token: 0x04000974 RID: 2420
	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Model model;

	// Token: 0x04000975 RID: 2421
	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[InspectorFlags]
	public global::BaseEntity.Flags flags;

	// Token: 0x04000976 RID: 2422
	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	[NonSerialized]
	public uint parentBone;

	// Token: 0x04000977 RID: 2423
	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[NonSerialized]
	public ulong skinID;

	// Token: 0x04000978 RID: 2424
	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private EntityComponentBase[] _components;

	// Token: 0x04000979 RID: 2425
	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[HideInInspector]
	public bool HasBrain;

	// Token: 0x0400097A RID: 2426
	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[NonSerialized]
	protected string _name;

	// Token: 0x0400097B RID: 2427
	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private ulong <OwnerID>k__BackingField;

	// Token: 0x020000ED RID: 237
	[Token(Token = "0x2000A91")]
	public class Menu : Attribute
	{
		// Token: 0x06000FBE RID: 4030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x639940", Offset = "0x638740", VA = "0x180639940")]
		public Menu()
		{
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF8")]
		[Address(RVA = "0x89EEB0", Offset = "0x89DCB0", VA = "0x18089EEB0")]
		public Menu(string menuTitleToken, string menuTitleEnglish)
		{
		}

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x4003EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string TitleToken;

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x4003EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string TitleEnglish;

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x4003EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string UseVariable;

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x4003EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Order;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4003EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string ProxyFunction;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4003EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Time;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4003EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string OnStart;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4003EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string OnProgress;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4003EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool LongUseOnly;

		// Token: 0x020000EE RID: 238
		[Token(Token = "0x2000E5F")]
		[Serializable]
		public struct Option
		{
			// Token: 0x06000FC0 RID: 4032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053FE")]
			[Address(RVA = "0xF4C00", Offset = "0xF4000", VA = "0x1800F4C00")]
			public void CopyTo(ref GameMenu.Option option)
			{
			}

			// Token: 0x04000985 RID: 2437
			[Token(Token = "0x4004FE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Translate.Phrase name;

			// Token: 0x04000986 RID: 2438
			[Token(Token = "0x4004FE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Translate.Phrase description;

			// Token: 0x04000987 RID: 2439
			[Token(Token = "0x4004FEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Sprite icon;

			// Token: 0x04000988 RID: 2440
			[Token(Token = "0x4004FEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int order;

			// Token: 0x04000989 RID: 2441
			[Token(Token = "0x4004FEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool usableWhileWounded;
		}

		// Token: 0x020000EF RID: 239
		[Token(Token = "0x2000E60")]
		public class Description : Attribute
		{
			// Token: 0x06000FC1 RID: 4033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053FF")]
			[Address(RVA = "0x89EEB0", Offset = "0x89DCB0", VA = "0x18089EEB0")]
			public Description(string t, string e)
			{
			}

			// Token: 0x0400098A RID: 2442
			[Token(Token = "0x4004FED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string token;

			// Token: 0x0400098B RID: 2443
			[Token(Token = "0x4004FEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string english;
		}

		// Token: 0x020000F0 RID: 240
		[Token(Token = "0x2000E61")]
		public class Icon : Attribute
		{
			// Token: 0x06000FC2 RID: 4034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005400")]
			[Address(RVA = "0x89FBB0", Offset = "0x89E9B0", VA = "0x18089FBB0")]
			public Icon(string i)
			{
			}

			// Token: 0x0400098C RID: 2444
			[Token(Token = "0x4004FEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string icon;
		}

		// Token: 0x020000F1 RID: 241
		[Token(Token = "0x2000E62")]
		public class ShowIf : Attribute
		{
			// Token: 0x06000FC3 RID: 4035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005401")]
			[Address(RVA = "0x89FBB0", Offset = "0x89E9B0", VA = "0x18089FBB0")]
			public ShowIf(string testFunc)
			{
			}

			// Token: 0x0400098D RID: 2445
			[Token(Token = "0x4004FF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string functionName;
		}

		// Token: 0x020000F2 RID: 242
		[Token(Token = "0x2000E63")]
		public class UsableWhileWounded : Attribute
		{
			// Token: 0x06000FC4 RID: 4036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005402")]
			[Address(RVA = "0x639940", Offset = "0x638740", VA = "0x180639940")]
			public UsableWhileWounded()
			{
			}
		}
	}

	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x2000A92")]
	[Serializable]
	public struct MovementModify
	{
		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x4003EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float drag;
	}

	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x2000A93")]
	[Flags]
	public enum Flags
	{
		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4003EB1")]
		Placeholder = 1,
		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4003EB2")]
		On = 2,
		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4003EB3")]
		OnFire = 4,
		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4003EB4")]
		Open = 8,
		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4003EB5")]
		Locked = 16,
		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4003EB6")]
		Debugging = 32,
		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4003EB7")]
		Disabled = 64,
		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4003EB8")]
		Reserved1 = 128,
		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4003EB9")]
		Reserved2 = 256,
		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4003EBA")]
		Reserved3 = 512,
		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x4003EBB")]
		Reserved4 = 1024,
		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x4003EBC")]
		Reserved5 = 2048,
		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x4003EBD")]
		Broken = 4096,
		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x4003EBE")]
		Busy = 8192,
		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x4003EBF")]
		Reserved6 = 16384,
		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x4003EC0")]
		Reserved7 = 32768,
		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x4003EC1")]
		Reserved8 = 65536,
		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x4003EC2")]
		Reserved9 = 131072,
		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x4003EC3")]
		Reserved10 = 262144,
		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x4003EC4")]
		Reserved11 = 524288
	}

	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x2000A94")]
	private readonly struct ServerFileRequest : IEquatable<global::BaseEntity.ServerFileRequest>
	{
		// Token: 0x06000FC5 RID: 4037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF9")]
		[Address(RVA = "0xF4E50", Offset = "0xF4250", VA = "0x1800F4E50")]
		public ServerFileRequest(FileStorage.Type type, uint numId, uint crc, IServerFileReceiver receiver)
		{
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0xF4DA0", Offset = "0xF41A0", VA = "0x1800F4DA0", Slot = "4")]
		public bool Equals(global::BaseEntity.ServerFileRequest other)
		{
			return default(bool);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0xF4CF0", Offset = "0xF40F0", VA = "0x1800F4CF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0xF4DF0", Offset = "0xF41F0", VA = "0x1800F4DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x89FD00", Offset = "0x89EB00", VA = "0x18089FD00")]
		public static bool operator ==(global::BaseEntity.ServerFileRequest left, global::BaseEntity.ServerFileRequest right)
		{
			return default(bool);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x89FDB0", Offset = "0x89EBB0", VA = "0x18089FDB0")]
		public static bool operator !=(global::BaseEntity.ServerFileRequest left, global::BaseEntity.ServerFileRequest right)
		{
			return default(bool);
		}

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x4003EC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly FileStorage.Type Type;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x4003EC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly uint NumId;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x4003EC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly uint Crc;

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x4003EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly IServerFileReceiver Receiver;

		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x4003EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float Time;
	}

	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x2000A95")]
	public static class Query
	{
		// Token: 0x020000F7 RID: 247
		[Token(Token = "0x2000E64")]
		public class EntityTree
		{
			// Token: 0x06000FCB RID: 4043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005403")]
			[Address(RVA = "0x89F820", Offset = "0x89E620", VA = "0x18089F820")]
			public EntityTree(float worldSize)
			{
			}

			// Token: 0x06000FCC RID: 4044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005404")]
			[Address(RVA = "0x89F040", Offset = "0x89DE40", VA = "0x18089F040")]
			public void Add(global::BaseEntity ent)
			{
			}

			// Token: 0x06000FCD RID: 4045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005405")]
			[Address(RVA = "0x89EFA0", Offset = "0x89DDA0", VA = "0x18089EFA0")]
			public void AddPlayer(global::BasePlayer player)
			{
			}

			// Token: 0x06000FCE RID: 4046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005406")]
			[Address(RVA = "0x89EF00", Offset = "0x89DD00", VA = "0x18089EF00")]
			public void AddBrain(global::BaseEntity entity)
			{
			}

			// Token: 0x06000FCF RID: 4047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005407")]
			[Address(RVA = "0x89F720", Offset = "0x89E520", VA = "0x18089F720")]
			public void Remove(global::BaseEntity ent, bool isPlayer = false)
			{
			}

			// Token: 0x06000FD0 RID: 4048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005408")]
			[Address(RVA = "0x89F6C0", Offset = "0x89E4C0", VA = "0x18089F6C0")]
			public void RemovePlayer(global::BasePlayer player)
			{
			}

			// Token: 0x06000FD1 RID: 4049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005409")]
			[Address(RVA = "0x89F630", Offset = "0x89E430", VA = "0x18089F630")]
			public void RemoveBrain(global::BaseEntity entity)
			{
			}

			// Token: 0x06000FD2 RID: 4050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600540A")]
			[Address(RVA = "0x89F400", Offset = "0x89E200", VA = "0x18089F400")]
			public void Move(global::BaseEntity ent)
			{
			}

			// Token: 0x06000FD3 RID: 4051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600540B")]
			[Address(RVA = "0x89F360", Offset = "0x89E160", VA = "0x18089F360")]
			public void MovePlayer(global::BasePlayer player)
			{
			}

			// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600540C")]
			[Address(RVA = "0x89F2C0", Offset = "0x89E0C0", VA = "0x18089F2C0")]
			public void MoveBrain(global::BaseEntity entity)
			{
			}

			// Token: 0x06000FD5 RID: 4053 RVA: 0x00009558 File Offset: 0x00007758
			[Token(Token = "0x600540D")]
			[Address(RVA = "0x89F180", Offset = "0x89DF80", VA = "0x18089F180")]
			public int GetInSphere(Vector3 position, float distance, global::BaseEntity[] results, [Optional] Func<global::BaseEntity, bool> filter)
			{
				return 0;
			}

			// Token: 0x06000FD6 RID: 4054 RVA: 0x00009570 File Offset: 0x00007770
			[Token(Token = "0x600540E")]
			[Address(RVA = "0x89F220", Offset = "0x89E020", VA = "0x18089F220")]
			public int GetPlayersInSphere(Vector3 position, float distance, global::BasePlayer[] results, [Optional] Func<global::BasePlayer, bool> filter)
			{
				return 0;
			}

			// Token: 0x06000FD7 RID: 4055 RVA: 0x00009588 File Offset: 0x00007788
			[Token(Token = "0x600540F")]
			[Address(RVA = "0x89F0E0", Offset = "0x89DEE0", VA = "0x18089F0E0")]
			public int GetBrainsInSphere(Vector3 position, float distance, global::BaseEntity[] results, [Optional] Func<global::BaseEntity, bool> filter)
			{
				return 0;
			}

			// Token: 0x040009A9 RID: 2473
			[Token(Token = "0x4004FF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Grid<global::BaseEntity> Grid;

			// Token: 0x040009AA RID: 2474
			[Token(Token = "0x4004FF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Grid<global::BasePlayer> PlayerGrid;

			// Token: 0x040009AB RID: 2475
			[Token(Token = "0x4004FF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grid<global::BaseEntity> BrainGrid;
		}
	}

	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x2000A96")]
	public class RPC_Shared : Attribute
	{
		// Token: 0x06000FD8 RID: 4056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x639940", Offset = "0x638740", VA = "0x180639940")]
		public RPC_Shared()
		{
		}
	}

	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x2000A97")]
	public struct RPCMessage
	{
		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x4003ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Connection connection;

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x4003ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public global::BasePlayer player;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x4003ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NetRead read;
	}

	// Token: 0x020000FA RID: 250
	[Token(Token = "0x2000A98")]
	public class RPC_Client : global::BaseEntity.RPC_Shared
	{
		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x639940", Offset = "0x638740", VA = "0x180639940")]
		public RPC_Client()
		{
		}
	}

	// Token: 0x020000FB RID: 251
	[Token(Token = "0x2000A99")]
	public enum Signal
	{
		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x4003ECE")]
		Attack,
		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x4003ECF")]
		Alt_Attack,
		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x4003ED0")]
		DryFire,
		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x4003ED1")]
		Reload,
		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x4003ED2")]
		Deploy,
		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x4003ED3")]
		Flinch_Head,
		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x4003ED4")]
		Flinch_Chest,
		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x4003ED5")]
		Flinch_Stomach,
		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x4003ED6")]
		Flinch_RearHead,
		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x4003ED7")]
		Flinch_RearTorso,
		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x4003ED8")]
		Throw,
		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x4003ED9")]
		Relax,
		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x4003EDA")]
		Gesture,
		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x4003EDB")]
		PhysImpact,
		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x4003EDC")]
		Eat,
		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x4003EDD")]
		Startled,
		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x4003EDE")]
		Admire
	}

	// Token: 0x020000FC RID: 252
	[Token(Token = "0x2000A9A")]
	public enum Slot
	{
		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x4003EE0")]
		Lock,
		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x4003EE1")]
		FireMod,
		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x4003EE2")]
		UpperModifier,
		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x4003EE3")]
		MiddleModifier,
		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x4003EE4")]
		LowerModifier,
		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x4003EE5")]
		CenterDecoration,
		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x4003EE6")]
		LowerCenterDecoration,
		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x4003EE7")]
		StorageMonitor,
		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x4003EE8")]
		Count
	}

	// Token: 0x020000FD RID: 253
	[Token(Token = "0x2000A9B")]
	[Flags]
	public enum TraitFlag
	{
		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x4003EEA")]
		None = 0,
		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x4003EEB")]
		Alive = 1,
		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x4003EEC")]
		Animal = 2,
		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x4003EED")]
		Human = 4,
		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x4003EEE")]
		Interesting = 8,
		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x4003EEF")]
		Food = 16,
		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x4003EF0")]
		Meat = 32,
		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x4003EF1")]
		Water = 32
	}

	// Token: 0x020000FE RID: 254
	[Token(Token = "0x2000A9C")]
	public static class Util
	{
	}

	// Token: 0x020000FF RID: 255
	[Token(Token = "0x2000A9D")]
	public enum GiveItemReason
	{
		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x4003EF3")]
		Generic,
		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x4003EF4")]
		ResourceHarvested,
		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x4003EF5")]
		PickedUp,
		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x4003EF6")]
		Crafted
	}

	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000A9E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000FDB RID: 4059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public <>c()
		{
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x89FE00", Offset = "0x89EC00", VA = "0x18089FE00")]
		internal int <GetMenuItems>b__35_0(GameMenu.Option x, GameMenu.Option y)
		{
			return 0;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x89FE30", Offset = "0x89EC30", VA = "0x18089FE30")]
		internal bool <RequestFileFromServer>b__93_0(global::BaseEntity.ServerFileRequest r)
		{
			return default(bool);
		}

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x4003EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly global::BaseEntity.<>c <>9;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x4003EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<GameMenu.Option> <>9__35_0;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x4003EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<global::BaseEntity.ServerFileRequest> <>9__93_0;
	}
}
