using System;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000373 RID: 883
[Token(Token = "0x2000276")]
public class DemoShotPlayback : MonoBehaviour
{
	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E04 RID: 7684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FA")]
	public DemoShot CurrentShot
	{
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x3A3360", Offset = "0x3A2160", VA = "0x1803A3360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x484E20", Offset = "0x483C20", VA = "0x180484E20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		private set
		{
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0000E520 File Offset: 0x0000C720
	[Token(Token = "0x170001FB")]
	public static bool IsPlayingShot
	{
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x8D0DA0", Offset = "0x8CFBA0", VA = "0x1808D0DA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06001E06 RID: 7686 RVA: 0x0000E538 File Offset: 0x0000C738
	[Token(Token = "0x170001FC")]
	public float CurrentShotTime
	{
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x8D0CB0", Offset = "0x8CFAB0", VA = "0x1808D0CB0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x8D0710", Offset = "0x8CF510", VA = "0x1808D0710")]
	public void Setup(DemoShot shot)
	{
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183D")]
	[Address(RVA = "0x8D05C0", Offset = "0x8CF3C0", VA = "0x1808D05C0")]
	public void PlayFromStart()
	{
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x8D0540", Offset = "0x8CF340", VA = "0x1808D0540")]
	public void PauseShot()
	{
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183F")]
	[Address(RVA = "0x8D0620", Offset = "0x8CF420", VA = "0x1808D0620")]
	public void ResumeShot()
	{
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001840")]
	[Address(RVA = "0x8D00B0", Offset = "0x8CEEB0", VA = "0x1808D00B0")]
	public void EndShot()
	{
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001841")]
	[Address(RVA = "0x8D08E0", Offset = "0x8CF6E0", VA = "0x1808D08E0")]
	private void Update()
	{
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x8D03C0", Offset = "0x8CF1C0", VA = "0x1808D03C0")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FD")]
	public string CurrentShotName
	{
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x8D0C90", Offset = "0x8CFA90", VA = "0x1808D0C90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0000E550 File Offset: 0x0000C750
	[Token(Token = "0x170001FE")]
	public float ShotPlaybackProgress
	{
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x8D0E80", Offset = "0x8CFC80", VA = "0x1808D0E80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06001E10 RID: 7696 RVA: 0x0000E568 File Offset: 0x0000C768
	[Token(Token = "0x170001FF")]
	public float ShotLength
	{
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x8D0E60", Offset = "0x8CFC60", VA = "0x1808D0E60")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0000E580 File Offset: 0x0000C780
	[Token(Token = "0x17000200")]
	public float ShotEndTime
	{
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x8D0E30", Offset = "0x8CFC30", VA = "0x1808D0E30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06001E12 RID: 7698 RVA: 0x0000E598 File Offset: 0x0000C798
	[Token(Token = "0x17000201")]
	public bool IsPaused
	{
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x8D0D50", Offset = "0x8CFB50", VA = "0x1808D0D50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000202")]
	public DemoShotVectorTrack CameraPositionTrack
	{
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x8D0C70", Offset = "0x8CFA70", VA = "0x1808D0C70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06001E14 RID: 7700 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
	[Token(Token = "0x17000203")]
	public float ShotStartTime
	{
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x8D0EB0", Offset = "0x8CFCB0", VA = "0x1808D0EB0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06001E15 RID: 7701 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
	[Token(Token = "0x17000204")]
	public bool HasDofData
	{
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x8D0D30", Offset = "0x8CFB30", VA = "0x1808D0D30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184B")]
	[Address(RVA = "0x8D0670", Offset = "0x8CF470", VA = "0x1808D0670")]
	public void SetShotTime(float newTime)
	{
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
	[Token(Token = "0x600184C")]
	[Address(RVA = "0x8D0000", Offset = "0x8CEE00", VA = "0x1808D0000")]
	public float ClampTimeToShotRange(float val)
	{
		return 0f;
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184D")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public DemoShotPlayback()
	{
	}

	// Token: 0x040018FF RID: 6399
	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private DemoShot <CurrentShot>k__BackingField;

	// Token: 0x04001900 RID: 6400
	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0x20")]
	private bool playing;

	// Token: 0x04001901 RID: 6401
	[Token(Token = "0x4001455")]
	[FieldOffset(Offset = "0x0")]
	public static DemoShotPlayback Instance;

	// Token: 0x04001902 RID: 6402
	[Token(Token = "0x4001456")]
	[FieldOffset(Offset = "0x21")]
	public bool ShouldLoop;
}
