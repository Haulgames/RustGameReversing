using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;
using UnityEngine;

// Token: 0x02000377 RID: 887
[Token(Token = "0x2000278")]
public static class DemoShotHelpers
{
	// Token: 0x06001E39 RID: 7737 RVA: 0x0000E688 File Offset: 0x0000C888
	[Token(Token = "0x6001868")]
	[Address(RVA = "0x8CCFD0", Offset = "0x8CBDD0", VA = "0x1808CCFD0")]
	public static Vector3 GetVectorFromTrack(this DemoShotVectorTrack track, float time)
	{
		return default(Vector3);
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
	[Token(Token = "0x6001869")]
	[Address(RVA = "0x8CCC20", Offset = "0x8CBA20", VA = "0x1808CCC20")]
	public static Quaternion GetQuaternionFromTrack(this DemoShotQuaternionTrack track, float time)
	{
		return default(Quaternion);
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
	[Token(Token = "0x600186A")]
	[Address(RVA = "0x8CC240", Offset = "0x8CB040", VA = "0x1808CC240")]
	public static float GetFloatFromTrack(this DemoShotFloatTrack track, float time)
	{
		return 0f;
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600186B")]
	[Address(RVA = "0x8CC500", Offset = "0x8CB300", VA = "0x1808CC500")]
	public static void GetKeyframesInRange(this DemoShotVectorTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results)
	{
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600186C")]
	[Address(RVA = "0x8CC790", Offset = "0x8CB590", VA = "0x1808CC790")]
	public static void GetKeyframesInRange(this DemoShotQuaternionTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results)
	{
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600186D")]
	[Address(RVA = "0x8CCA00", Offset = "0x8CB800", VA = "0x1808CCA00")]
	public static void GetKeyframesInRange(this DemoShotFloatTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results)
	{
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
	[Token(Token = "0x600186E")]
	[Address(RVA = "0x8CD420", Offset = "0x8CC220", VA = "0x1808CD420")]
	public static Quaternion ToQuaternion(this DemoShotQuaternionKeyframe keyframe)
	{
		return default(Quaternion);
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
	[Token(Token = "0x600186F")]
	[Address(RVA = "0x8CD3F0", Offset = "0x8CC1F0", VA = "0x1808CD3F0")]
	public static DemoShotQuaternionKeyframe ToKeyframe(this Quaternion value, float time)
	{
		return default(DemoShotQuaternionKeyframe);
	}
}
