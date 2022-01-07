using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F5 RID: 757
[Token(Token = "0x2000213")]
public class BuildingProximity : PrefabAttribute
{
	// Token: 0x06001BE4 RID: 7140 RVA: 0x0000D908 File Offset: 0x0000BB08
	[Token(Token = "0x600164A")]
	[Address(RVA = "0x63F350", Offset = "0x63E150", VA = "0x18063F350")]
	public static bool Check(BasePlayer player, Construction construction, Vector3 position, Quaternion rotation)
	{
		return default(bool);
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x0000D920 File Offset: 0x0000BB20
	[Token(Token = "0x600164B")]
	[Address(RVA = "0x63FB40", Offset = "0x63E940", VA = "0x18063FB40")]
	private static BuildingProximity.ProximityInfo GetProximity(Construction construction1, Vector3 position1, Quaternion rotation1, Construction construction2, Vector3 position2, Quaternion rotation2)
	{
		return default(BuildingProximity.ProximityInfo);
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x0000D938 File Offset: 0x0000BB38
	[Token(Token = "0x600164C")]
	[Address(RVA = "0x6400D0", Offset = "0x63EED0", VA = "0x1806400D0")]
	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation)
	{
		return default(Vector3);
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600164D")]
	[Address(RVA = "0x63FAE0", Offset = "0x63E8E0", VA = "0x18063FAE0", Slot = "7")]
	protected override Type GetIndexedType()
	{
		return null;
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164E")]
	[Address(RVA = "0x6401F0", Offset = "0x63EFF0", VA = "0x1806401F0")]
	public BuildingProximity()
	{
	}

	// Token: 0x040016B5 RID: 5813
	[Token(Token = "0x400129A")]
	private const float check_radius = 2f;

	// Token: 0x040016B6 RID: 5814
	[Token(Token = "0x400129B")]
	private const float check_forgiveness = 0.01f;

	// Token: 0x040016B7 RID: 5815
	[Token(Token = "0x400129C")]
	private const float foundation_width = 3f;

	// Token: 0x040016B8 RID: 5816
	[Token(Token = "0x400129D")]
	private const float foundation_extents = 1.5f;

	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x2000B17")]
	private struct ProximityInfo
	{
		// Token: 0x040016B9 RID: 5817
		[Token(Token = "0x4004131")]
		[FieldOffset(Offset = "0x0")]
		public bool hit;

		// Token: 0x040016BA RID: 5818
		[Token(Token = "0x4004132")]
		[FieldOffset(Offset = "0x1")]
		public bool connection;

		// Token: 0x040016BB RID: 5819
		[Token(Token = "0x4004133")]
		[FieldOffset(Offset = "0x4")]
		public Line line;

		// Token: 0x040016BC RID: 5820
		[Token(Token = "0x4004134")]
		[FieldOffset(Offset = "0x1C")]
		public float sqrDist;
	}
}
