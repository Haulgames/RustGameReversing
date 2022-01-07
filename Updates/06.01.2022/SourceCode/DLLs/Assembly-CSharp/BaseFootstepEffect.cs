using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000401 RID: 1025
[Token(Token = "0x20002E1")]
public abstract class BaseFootstepEffect : MonoBehaviour, IClientComponent
{
	// Token: 0x0600214D RID: 8525 RVA: 0x0000F600 File Offset: 0x0000D800
	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x899A70", Offset = "0x898870", VA = "0x180899A70")]
	protected BaseFootstepEffect.GroundInfo GetGroundInfo(Vector3 position, Vector3 forward, bool bIgnoreDistanceCheck = false)
	{
		return default(BaseFootstepEffect.GroundInfo);
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x899EA0", Offset = "0x898CA0", VA = "0x180899EA0")]
	protected BaseFootstepEffect()
	{
	}

	// Token: 0x04001BF9 RID: 7161
	[Token(Token = "0x40016B3")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask validImpactLayers;

	// Token: 0x04001BFA RID: 7162
	[Token(Token = "0x40016B4")]
	private const float minTimeBetweenSteps = 0.05f;

	// Token: 0x04001BFB RID: 7163
	[Token(Token = "0x40016B5")]
	[FieldOffset(Offset = "0x1C")]
	private float lastFootstepTime;

	// Token: 0x04001BFC RID: 7164
	[Token(Token = "0x40016B6")]
	private const float minDistanceBetweenSteps = 0.5f;

	// Token: 0x04001BFD RID: 7165
	[Token(Token = "0x40016B7")]
	private const float minDistanceBetweenStepsSqr = 0.25f;

	// Token: 0x04001BFE RID: 7166
	[Token(Token = "0x40016B8")]
	[FieldOffset(Offset = "0x20")]
	protected Vector3 lastFootstepPos;

	// Token: 0x04001BFF RID: 7167
	[Token(Token = "0x40016B9")]
	private const float maxDistanceToCamera = 75f;

	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000B55")]
	protected struct GroundInfo
	{
		// Token: 0x0600214F RID: 8527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB0")]
		[Address(RVA = "0xF48A0", Offset = "0xF3CA0", VA = "0x1800F48A0")]
		public GameObject SpawnDecal(string effectType)
		{
			return null;
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0xF4A80", Offset = "0xF3E80", VA = "0x1800F4A80")]
		public GameObject SpawnEffect(string effectType)
		{
			return null;
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB2")]
		[Address(RVA = "0xF4990", Offset = "0xF3D90", VA = "0x1800F4990")]
		public GameObject SpawnDisplacement(string effectType)
		{
			return null;
		}

		// Token: 0x04001C00 RID: 7168
		[Token(Token = "0x400425C")]
		[FieldOffset(Offset = "0x0")]
		public string surface;

		// Token: 0x04001C01 RID: 7169
		[Token(Token = "0x400425D")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 position;

		// Token: 0x04001C02 RID: 7170
		[Token(Token = "0x400425E")]
		[FieldOffset(Offset = "0x14")]
		public Quaternion rotation;
	}
}
