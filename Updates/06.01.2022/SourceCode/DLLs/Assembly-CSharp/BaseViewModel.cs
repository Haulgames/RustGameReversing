using System;
using System.Collections.Generic;
using Facepunch;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BBC RID: 3004
[Token(Token = "0x2000871")]
public class BaseViewModel : MonoBehaviour
{
	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x0600455F RID: 17759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004A2")]
	public static BaseViewModel ActiveModel
	{
		[Token(Token = "0x6003AA8")]
		[Address(RVA = "0x9AD3A0", Offset = "0x9AC1A0", VA = "0x1809AD3A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x06004560 RID: 17760 RVA: 0x00019D58 File Offset: 0x00017F58
	[Token(Token = "0x170004A3")]
	public static bool UsingViewModelCamera
	{
		[Token(Token = "0x6003AA9")]
		[Address(RVA = "0x9AD460", Offset = "0x9AC260", VA = "0x1809AD460")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06004561 RID: 17761 RVA: 0x00019D70 File Offset: 0x00017F70
	[Token(Token = "0x6003AAA")]
	[Address(RVA = "0x9AB6B0", Offset = "0x9AA4B0", VA = "0x1809AB6B0")]
	public bool IsOK()
	{
		return default(bool);
	}

	// Token: 0x06004562 RID: 17762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AAB")]
	[Address(RVA = "0x9AC4B0", Offset = "0x9AB2B0", VA = "0x1809AC4B0")]
	public void PreDestroy()
	{
	}

	// Token: 0x06004563 RID: 17763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AAC")]
	[Address(RVA = "0x9AC270", Offset = "0x9AB070", VA = "0x1809AC270")]
	private void OnEnable()
	{
	}

	// Token: 0x06004564 RID: 17764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AAD")]
	[Address(RVA = "0x9AC190", Offset = "0x9AAF90", VA = "0x1809AC190")]
	private void OnDisable()
	{
	}

	// Token: 0x06004565 RID: 17765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AAE")]
	[Address(RVA = "0x9AAA40", Offset = "0x9A9840", VA = "0x1809AAA40")]
	private void Awake()
	{
	}

	// Token: 0x06004566 RID: 17766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AAF")]
	[Address(RVA = "0x9AD080", Offset = "0x9ABE80", VA = "0x1809AD080")]
	public void UpdateRenderersAndSkin(BasePlayer forPlayer)
	{
	}

	// Token: 0x06004567 RID: 17767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB0")]
	[Address(RVA = "0x9AC180", Offset = "0x9AAF80", VA = "0x1809AC180")]
	public void OnClothingChanged(BasePlayer player)
	{
	}

	// Token: 0x06004568 RID: 17768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB1")]
	[Address(RVA = "0x9AD1C0", Offset = "0x9ABFC0", VA = "0x1809AD1C0")]
	private void UpdateRenderers(BasePlayer forPlayer)
	{
	}

	// Token: 0x06004569 RID: 17769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB2")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70")]
	private void AddHandsModel()
	{
	}

	// Token: 0x0600456A RID: 17770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB3")]
	[Address(RVA = "0x9ACDC0", Offset = "0x9ABBC0", VA = "0x1809ACDC0")]
	private void UpdateClothingModels(BasePlayer player)
	{
	}

	// Token: 0x0600456B RID: 17771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB4")]
	[Address(RVA = "0x9AA990", Offset = "0x9A9790", VA = "0x1809AA990")]
	private void AddClothing(ViewmodelClothing clothing, Item item)
	{
	}

	// Token: 0x0600456C RID: 17772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB5")]
	[Address(RVA = "0x9AC870", Offset = "0x9AB670", VA = "0x1809AC870")]
	private void SetSkinColor(Color skinColor)
	{
	}

	// Token: 0x0600456D RID: 17773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB6")]
	[Address(RVA = "0x9AB710", Offset = "0x9AA510", VA = "0x1809AB710")]
	public void OnCameraPositionChanged(Camera cam)
	{
	}

	// Token: 0x0600456E RID: 17774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB7")]
	[Address(RVA = "0x9AB720", Offset = "0x9AA520", VA = "0x1809AB720")]
	public void OnCameraPositionChanged(Camera cam, BasePlayer player)
	{
	}

	// Token: 0x0600456F RID: 17775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003AB8")]
	[Address(RVA = "0x9AB590", Offset = "0x9AA390", VA = "0x1809AB590")]
	public LazyAimProperties GetLazyAim()
	{
		return null;
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x00019D88 File Offset: 0x00017F88
	[Token(Token = "0x6003AB9")]
	[Address(RVA = "0x9AB0F0", Offset = "0x9A9EF0", VA = "0x1809AB0F0")]
	private Quaternion GetGestureRotationOffset(out Vector3 offset)
	{
		return default(Quaternion);
	}

	// Token: 0x06004571 RID: 17777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABA")]
	[Address(RVA = "0x9AC9B0", Offset = "0x9AB7B0", VA = "0x1809AC9B0")]
	public void ToggleGestureHide(bool state)
	{
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABB")]
	[Address(RVA = "0x9AC9F0", Offset = "0x9AB7F0", VA = "0x1809AC9F0")]
	public void TriggerAdmire()
	{
	}

	// Token: 0x06004573 RID: 17779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABC")]
	[Address(RVA = "0x9ACAE0", Offset = "0x9AB8E0", VA = "0x1809ACAE0")]
	public void TriggerAttack()
	{
	}

	// Token: 0x06004574 RID: 17780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABD")]
	[Address(RVA = "0x9ACAA0", Offset = "0x9AB8A0", VA = "0x1809ACAA0")]
	public void TriggerAttack2()
	{
	}

	// Token: 0x06004575 RID: 17781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABE")]
	[Address(RVA = "0x9ACC20", Offset = "0x9ABA20", VA = "0x1809ACC20")]
	public void TriggerReady()
	{
	}

	// Token: 0x06004576 RID: 17782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABF")]
	[Address(RVA = "0x9ACB20", Offset = "0x9AB920", VA = "0x1809ACB20")]
	public void TriggerCancel()
	{
	}

	// Token: 0x06004577 RID: 17783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC0")]
	[Address(RVA = "0x9ACB60", Offset = "0x9AB960", VA = "0x1809ACB60")]
	public void TriggerDeploy()
	{
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC1")]
	[Address(RVA = "0x9ACC60", Offset = "0x9ABA60", VA = "0x1809ACC60")]
	public void TriggerReload()
	{
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC2")]
	[Address(RVA = "0x9ACBE0", Offset = "0x9AB9E0", VA = "0x1809ACBE0")]
	public void TriggerHolster()
	{
	}

	// Token: 0x0600457A RID: 17786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC3")]
	[Address(RVA = "0x9ACBA0", Offset = "0x9AB9A0", VA = "0x1809ACBA0")]
	public void TriggerEmpty()
	{
	}

	// Token: 0x0600457B RID: 17787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC4")]
	[Address(RVA = "0x9ACCA0", Offset = "0x9ABAA0", VA = "0x1809ACCA0")]
	public void Trigger(string name)
	{
	}

	// Token: 0x0600457C RID: 17788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC5")]
	[Address(RVA = "0x9ACD30", Offset = "0x9ABB30", VA = "0x1809ACD30")]
	public void Trigger(int hash)
	{
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC6")]
	[Address(RVA = "0x9AC560", Offset = "0x9AB360", VA = "0x1809AC560")]
	public void ResetTrigger(string name)
	{
	}

	// Token: 0x0600457E RID: 17790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC7")]
	[Address(RVA = "0x9AC4D0", Offset = "0x9AB2D0", VA = "0x1809AC4D0")]
	public void ResetTrigger(int hash)
	{
	}

	// Token: 0x0600457F RID: 17791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC8")]
	[Address(RVA = "0x9AC690", Offset = "0x9AB490", VA = "0x1809AC690")]
	public void SetBool(string name, bool bState)
	{
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC9")]
	[Address(RVA = "0x9AC5F0", Offset = "0x9AB3F0", VA = "0x1809AC5F0")]
	public void SetBool(int hash, bool bState)
	{
	}

	// Token: 0x06004581 RID: 17793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACA")]
	[Address(RVA = "0x9AC730", Offset = "0x9AB530", VA = "0x1809AC730")]
	public void SetFloat(string name, float fAmount)
	{
	}

	// Token: 0x06004582 RID: 17794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACB")]
	[Address(RVA = "0x9AC7D0", Offset = "0x9AB5D0", VA = "0x1809AC7D0")]
	public void SetFloat(int hash, float fAmount)
	{
	}

	// Token: 0x06004583 RID: 17795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACC")]
	[Address(RVA = "0x9AC360", Offset = "0x9AB160", VA = "0x1809AC360")]
	public void Play(string anim, int layer = 0)
	{
	}

	// Token: 0x06004584 RID: 17796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACD")]
	[Address(RVA = "0x9AAF90", Offset = "0x9A9D90", VA = "0x1809AAF90")]
	public void CrossFade(string anim, float fade)
	{
	}

	// Token: 0x06004585 RID: 17797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACE")]
	[Address(RVA = "0x9AB630", Offset = "0x9AA430", VA = "0x1809AB630")]
	public void HideSightMeshes(bool bHide)
	{
	}

	// Token: 0x06004586 RID: 17798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACF")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "4")]
	public virtual void OnDeployedNoSkin()
	{
	}

	// Token: 0x06004587 RID: 17799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD0")]
	[Address(RVA = "0x668890", Offset = "0x667690", VA = "0x180668890")]
	public void WorkshopMode()
	{
	}

	// Token: 0x06004588 RID: 17800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD1")]
	[Address(RVA = "0x9AD390", Offset = "0x9AC190", VA = "0x1809AD390")]
	public BaseViewModel()
	{
	}

	// Token: 0x04004195 RID: 16789
	[Token(Token = "0x4003290")]
	[FieldOffset(Offset = "0x0")]
	public static bool HideViewmodel;

	// Token: 0x04004196 RID: 16790
	[Token(Token = "0x4003291")]
	[FieldOffset(Offset = "0x8")]
	public static List<BaseViewModel> ActiveModels;

	// Token: 0x04004197 RID: 16791
	[Token(Token = "0x4003292")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x7EC20", Offset = "0x7E020")]
	public LazyAimProperties lazyaimRegular;

	// Token: 0x04004198 RID: 16792
	[Token(Token = "0x4003293")]
	[FieldOffset(Offset = "0x20")]
	public LazyAimProperties lazyaimIronsights;

	// Token: 0x04004199 RID: 16793
	[Token(Token = "0x4003294")]
	[FieldOffset(Offset = "0x28")]
	public Transform pivot;

	// Token: 0x0400419A RID: 16794
	[Token(Token = "0x4003295")]
	[FieldOffset(Offset = "0x30")]
	public bool useViewModelCamera;

	// Token: 0x0400419B RID: 16795
	[Token(Token = "0x4003296")]
	[FieldOffset(Offset = "0x31")]
	public bool wantsHeldItemFlags;

	// Token: 0x0400419C RID: 16796
	[Token(Token = "0x4003297")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] hideSightMeshes;

	// Token: 0x0400419D RID: 16797
	[Token(Token = "0x4003298")]
	[FieldOffset(Offset = "0x40")]
	public Transform MuzzlePoint;

	// Token: 0x0400419E RID: 16798
	[Token(Token = "0x4003299")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x7EF40", Offset = "0x7E340")]
	public SubsurfaceProfile subsurfaceProfile;

	// Token: 0x0400419F RID: 16799
	[Token(Token = "0x400329A")]
	[FieldOffset(Offset = "0x50")]
	internal Animator animator;

	// Token: 0x040041A0 RID: 16800
	[Token(Token = "0x400329B")]
	[FieldOffset(Offset = "0x58")]
	internal AnimationEvents animationEvent;

	// Token: 0x040041A1 RID: 16801
	[Token(Token = "0x400329C")]
	[FieldOffset(Offset = "0x60")]
	internal IronSights ironSights;

	// Token: 0x040041A2 RID: 16802
	[Token(Token = "0x400329D")]
	[FieldOffset(Offset = "0x68")]
	internal ViewmodelSway sway;

	// Token: 0x040041A3 RID: 16803
	[Token(Token = "0x400329E")]
	[FieldOffset(Offset = "0x70")]
	internal ViewmodelLower lower;

	// Token: 0x040041A4 RID: 16804
	[Token(Token = "0x400329F")]
	[FieldOffset(Offset = "0x78")]
	internal ViewmodelBob bob;

	// Token: 0x040041A5 RID: 16805
	[Token(Token = "0x40032A0")]
	[FieldOffset(Offset = "0x80")]
	internal Model model;

	// Token: 0x040041A6 RID: 16806
	[Token(Token = "0x40032A1")]
	[FieldOffset(Offset = "0x88")]
	internal bool gestureHide;

	// Token: 0x040041A7 RID: 16807
	[Token(Token = "0x40032A2")]
	[FieldOffset(Offset = "0x8C")]
	internal TimeSince gestureHideTime;

	// Token: 0x040041A8 RID: 16808
	[Token(Token = "0x40032A3")]
	[FieldOffset(Offset = "0x10")]
	private static GestureCollection gestureCollection;

	// Token: 0x040041A9 RID: 16809
	[Token(Token = "0x40032A4")]
	[FieldOffset(Offset = "0x90")]
	private Skeleton Skeleton;

	// Token: 0x040041AA RID: 16810
	[Token(Token = "0x40032A5")]
	[FieldOffset(Offset = "0x98")]
	private GameObject Clothing;

	// Token: 0x040041AB RID: 16811
	[Token(Token = "0x40032A6")]
	[FieldOffset(Offset = "0xA0")]
	private bool workshopMode;
}
