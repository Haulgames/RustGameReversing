using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D0 RID: 976
[Token(Token = "0x20002BA")]
public class ArticulatedOccludee : BaseMonoBehaviour
{
	// Token: 0x1700025A RID: 602
	// (get) Token: 0x0600206E RID: 8302 RVA: 0x0000F228 File Offset: 0x0000D428
	[Token(Token = "0x1700022C")]
	public bool IsVisible
	{
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x7D8A90", Offset = "0x7D7890", VA = "0x1807D8A90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A66")]
	[Address(RVA = "0x836DE0", Offset = "0x835BE0", VA = "0x180836DE0", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A67")]
	[Address(RVA = "0x836C90", Offset = "0x835A90", VA = "0x180836C90")]
	private void ClearVisibility()
	{
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A68")]
	[Address(RVA = "0x8371F0", Offset = "0x835FF0", VA = "0x1808371F0")]
	public void ProcessVisibility(LODGroup lod)
	{
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A69")]
	[Address(RVA = "0x8373C0", Offset = "0x8361C0", VA = "0x1808373C0")]
	private void RegisterForCulling(OcclusionCulling.Sphere sphere, bool visible)
	{
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0x837860", Offset = "0x836660", VA = "0x180837860")]
	private void UnregisterFromCulling()
	{
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0x8378E0", Offset = "0x8366E0", VA = "0x1808378E0")]
	public void UpdateCullingBounds()
	{
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x0000F240 File Offset: 0x0000D440
	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0x836C70", Offset = "0x835A70", VA = "0x180836C70", Slot = "7")]
	protected virtual bool CheckVisibility()
	{
		return default(bool);
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0x836B60", Offset = "0x835960", VA = "0x180836B60")]
	private void ApplyVisibility(bool vis)
	{
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A6E")]
	[Address(RVA = "0x837050", Offset = "0x835E50", VA = "0x180837050", Slot = "8")]
	protected virtual void OnVisibilityChanged(bool visible)
	{
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0x838140", Offset = "0x836F40", VA = "0x180838140")]
	private void UpdateVisibility(float delay)
	{
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A70")]
	[Address(RVA = "0x838410", Offset = "0x837210", VA = "0x180838410")]
	private void VisUpdateUsingCulling(float dist, bool visibility)
	{
	}

	// Token: 0x0600207A RID: 8314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A71")]
	[Address(RVA = "0x837610", Offset = "0x836410", VA = "0x180837610", Slot = "9")]
	public virtual void TriggerUpdateVisibilityBounds()
	{
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A72")]
	[Address(RVA = "0x836F80", Offset = "0x835D80", VA = "0x180836F80", Slot = "10")]
	protected virtual void OnDrawGizmos()
	{
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A73")]
	[Address(RVA = "0x8384C0", Offset = "0x8372C0", VA = "0x1808384C0")]
	public ArticulatedOccludee()
	{
	}

	// Token: 0x04001B51 RID: 6993
	[Token(Token = "0x4001653")]
	private const float UpdateBoundsFadeStart = 20f;

	// Token: 0x04001B52 RID: 6994
	[Token(Token = "0x4001654")]
	private const float UpdateBoundsFadeLength = 1000f;

	// Token: 0x04001B53 RID: 6995
	[Token(Token = "0x4001655")]
	private const float UpdateBoundsMaxFrequency = 15f;

	// Token: 0x04001B54 RID: 6996
	[Token(Token = "0x4001656")]
	private const float UpdateBoundsMinFrequency = 0.5f;

	// Token: 0x04001B55 RID: 6997
	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0x18")]
	private LODGroup lodGroup;

	// Token: 0x04001B56 RID: 6998
	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0x20")]
	public List<Collider> colliders;

	// Token: 0x04001B57 RID: 6999
	[Token(Token = "0x4001659")]
	[FieldOffset(Offset = "0x28")]
	private OccludeeSphere localOccludee;

	// Token: 0x04001B58 RID: 7000
	[Token(Token = "0x400165A")]
	[FieldOffset(Offset = "0x48")]
	private List<Renderer> renderers;

	// Token: 0x04001B59 RID: 7001
	[Token(Token = "0x400165B")]
	[FieldOffset(Offset = "0x50")]
	private bool isVisible;

	// Token: 0x04001B5A RID: 7002
	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0x58")]
	private Action TriggerUpdateVisibilityBoundsDelegate;
}
