using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002D RID: 45
[Token(Token = "0x2000021")]
public class BaseMagnet : MonoBehaviour
{
	// Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BaseMagnet()
	{
	}

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x18")]
	public TriggerMagnet magnetTrigger;

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x20")]
	public FixedJoint fixedJoint;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody kinematicAttachmentBody;

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x30")]
	public float magnetForce;

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x38")]
	public Transform attachDepthPoint;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x40")]
	public GameObjectRef attachEffect;

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x48")]
	public bool isMagnetOn;

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x50")]
	public GameObject colliderSource;
}
