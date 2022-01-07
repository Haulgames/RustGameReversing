using System;
using Il2CppDummyDll;
using Network;
using UnityEngine;

// Token: 0x02000114 RID: 276
[Token(Token = "0x20000A3")]
public class BaseTrain : BaseVehicle, ITrainCollidable
{
	// Token: 0x060010D6 RID: 4310 RVA: 0x00009FC0 File Offset: 0x000081C0
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x9A5410", Offset = "0x9A4210", VA = "0x1809A5410", Slot = "35")]
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x9A5870", Offset = "0x9A4670", VA = "0x1809A5870")]
	protected void PlaySparks()
	{
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x9A5A10", Offset = "0x9A4810", VA = "0x1809A5A10")]
	protected void StopSparks()
	{
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x9A5880", Offset = "0x9A4680", VA = "0x1809A5880")]
	protected void SetSparks(bool play)
	{
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x9A59B0", Offset = "0x9A47B0", VA = "0x1809A59B0")]
	[BaseEntity.RPC_Client]
	private void SetTrackSelection(BaseEntity.RPCMessage msg)
	{
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00009FD8 File Offset: 0x000081D8
	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "190")]
	public bool CustomCollision(BaseTrain train, TriggerTrainCollisions trainTrigger)
	{
		return default(bool);
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00009FF0 File Offset: 0x000081F0
	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x30DD30", Offset = "0x30CB30", VA = "0x18030DD30", Slot = "99")]
	public override float InheritedVelocityScale()
	{
		return 0f;
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x9A5A00", Offset = "0x9A4800", VA = "0x1809A5A00", Slot = "192")]
	protected virtual void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection)
	{
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x9A5A20", Offset = "0x9A4820", VA = "0x1809A5A20")]
	public BaseTrain()
	{
	}

	// Token: 0x04000B36 RID: 2870
	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x3A8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x8DDB0", Offset = "0x8D1B0")]
	[SerializeField]
	private float corpseSeconds;

	// Token: 0x04000B37 RID: 2871
	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x3B0")]
	[SerializeField]
	private TriggerTrainCollisions frontCollisionTrigger;

	// Token: 0x04000B38 RID: 2872
	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x3B8")]
	[SerializeField]
	private TriggerTrainCollisions rearCollisionTrigger;

	// Token: 0x04000B39 RID: 2873
	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x3C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x8DFE0", Offset = "0x8D3E0")]
	[SerializeField]
	private float impactEnergyFraction;

	// Token: 0x04000B3A RID: 2874
	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x3C4")]
	[SerializeField]
	private float collisionDamageDivide;

	// Token: 0x04000B3B RID: 2875
	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x3C8")]
	[SerializeField]
	private float derailCollisionForce;

	// Token: 0x04000B3C RID: 2876
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x3D0")]
	[SerializeField]
	private GameObjectRef collisionEffect;

	// Token: 0x04000B3D RID: 2877
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x3D8")]
	[SerializeField]
	private TriggerHurtNotChild hurtTriggerFront;

	// Token: 0x04000B3E RID: 2878
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x3E0")]
	[SerializeField]
	private TriggerHurtNotChild hurtTriggerRear;

	// Token: 0x04000B3F RID: 2879
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x3E8")]
	[SerializeField]
	private float hurtTriggerMinSpeed;

	// Token: 0x04000B40 RID: 2880
	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x3F0")]
	[SerializeField]
	private CapsuleCollider frontWheelWorldCol;

	// Token: 0x04000B41 RID: 2881
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x3F8")]
	[SerializeField]
	private CapsuleCollider rearWheelWorldCol;

	// Token: 0x04000B42 RID: 2882
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x400")]
	[SerializeField]
	private Transform centreOfMassTransform;

	// Token: 0x04000B43 RID: 2883
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x408")]
	[SerializeField]
	private ParticleSystemContainer[] sparks;

	// Token: 0x04000B44 RID: 2884
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x410")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8E890", Offset = "0x8DC90")]
	[SerializeField]
	private Light[] sparkLights;

	// Token: 0x04000B45 RID: 2885
	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x418")]
	protected TrainTrackSpline.TrackSelection curTrackSelection;
}
