using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CF RID: 463
[Token(Token = "0x2000124")]
public class ElectricWindmill : IOEntity
{
	// Token: 0x06001658 RID: 5720 RVA: 0x0000C360 File Offset: 0x0000A560
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x98C070", Offset = "0x98AE70", VA = "0x18098C070", Slot = "150")]
	public override int MaximalPowerOutput()
	{
		return 0;
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x0000C378 File Offset: 0x0000A578
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x2F1C10", Offset = "0x2F0A10", VA = "0x1802F1C10", Slot = "144")]
	public override bool IsRootEntity()
	{
		return default(bool);
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x0000C390 File Offset: 0x0000A590
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x98BDC0", Offset = "0x98ABC0", VA = "0x18098BDC0")]
	public float GetWindSpeedScale()
	{
		return 0f;
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x98BFE0", Offset = "0x98ADE0", VA = "0x18098BFE0", Slot = "34")]
	public override void Load(BaseNetworkable.LoadInfo info)
	{
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x98BCD0", Offset = "0x98AAD0", VA = "0x18098BCD0")]
	public Vector3 GetWindAimDir(float time)
	{
		return default(Vector3);
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x98C360", Offset = "0x98B160", VA = "0x18098C360")]
	public void Woosh()
	{
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111E")]
	[Address(RVA = "0x98C080", Offset = "0x98AE80", VA = "0x18098C080")]
	public void Update()
	{
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x98C410", Offset = "0x98B210", VA = "0x18098C410")]
	public ElectricWindmill()
	{
	}

	// Token: 0x04000FFF RID: 4095
	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x268")]
	public Animator animator;

	// Token: 0x04001000 RID: 4096
	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x270")]
	public int maxPowerGeneration;

	// Token: 0x04001001 RID: 4097
	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x278")]
	public Transform vaneRot;

	// Token: 0x04001002 RID: 4098
	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0x280")]
	public SoundDefinition wooshSound;

	// Token: 0x04001003 RID: 4099
	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x288")]
	public Transform wooshOrigin;

	// Token: 0x04001004 RID: 4100
	[Token(Token = "0x4000CDA")]
	[FieldOffset(Offset = "0x290")]
	public float targetSpeed;

	// Token: 0x04001005 RID: 4101
	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0x294")]
	private float serverWindSpeed;

	// Token: 0x04001006 RID: 4102
	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0x298")]
	private float lastServerTime;

	// Token: 0x04001007 RID: 4103
	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x0")]
	protected static int speedIndex;
}
