using System;
using System.Collections.Generic;
using Facepunch.BurstCloth;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018D RID: 397
[Token(Token = "0x20000EE")]
public class BurstClothHitBoxCollision : BurstCloth, IClientComponent, IPrefabPreProcess
{
	// Token: 0x06001509 RID: 5385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x641480", Offset = "0x640280", VA = "0x180641480", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x642630", Offset = "0x641430", VA = "0x180642630")]
	public void PlayerPreviewVisibility(bool isVisible)
	{
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x641560", Offset = "0x640360", VA = "0x180641560", Slot = "7")]
	protected override void FrameUpdate()
	{
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x642720", Offset = "0x641520", VA = "0x180642720")]
	private void UpdateSimulationSpace()
	{
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x0000BD00 File Offset: 0x00009F00
	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x642530", Offset = "0x641330", VA = "0x180642530", Slot = "8")]
	protected override ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform()
	{
		return default(ValueTuple<Vector3, Quaternion, Vector3>);
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x0000BD18 File Offset: 0x00009F18
	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x642190", Offset = "0x640F90", VA = "0x180642190")]
	private ValueTuple<Quaternion, Vector3> GetOrientation()
	{
		return default(ValueTuple<Quaternion, Vector3>);
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x641840", Offset = "0x640640", VA = "0x180641840", Slot = "9")]
	protected override void GatherColliders(List<CapsuleParams> colliders)
	{
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x642640", Offset = "0x641440", VA = "0x180642640", Slot = "10")]
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling)
	{
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x642840", Offset = "0x641640", VA = "0x180642840")]
	public BurstClothHitBoxCollision()
	{
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x0000BD30 File Offset: 0x00009F30
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x642650", Offset = "0x641450", VA = "0x180642650")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private bool <GatherColliders>g__ShouldIgnore|15_0(string name)
	{
		return default(bool);
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	internal static void <GatherColliders>g__Swap|15_1<T>(ref T a, ref T b)
	{
	}

	// Token: 0x04000EC2 RID: 3778
	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x130")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x9C870", Offset = "0x9BC70")]
	public float GravityStrength;

	// Token: 0x04000EC3 RID: 3779
	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x134")]
	public float DefaultLength;

	// Token: 0x04000EC4 RID: 3780
	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x138")]
	public float MountedLengthMultiplier;

	// Token: 0x04000EC5 RID: 3781
	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x13C")]
	public float DuckedLengthMultiplier;

	// Token: 0x04000EC6 RID: 3782
	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x140")]
	public float CorpseLengthMultiplier;

	// Token: 0x04000EC7 RID: 3783
	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x148")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8C780", Offset = "0x8BB80")]
	public string[] IgnoreKeywords;

	// Token: 0x04000EC8 RID: 3784
	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x150")]
	private BasePlayer _player;

	// Token: 0x04000EC9 RID: 3785
	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x158")]
	private Ragdoll _ragdoll;

	// Token: 0x04000ECA RID: 3786
	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x160")]
	private HitboxSystem _hitboxSystem;
}
