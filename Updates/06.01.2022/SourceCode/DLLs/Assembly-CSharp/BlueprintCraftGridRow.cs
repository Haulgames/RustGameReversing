using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A16 RID: 2582
[Token(Token = "0x2000740")]
public class BlueprintCraftGridRow : MonoBehaviour
{
	// Token: 0x06003CF5 RID: 15605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003387")]
	[Address(RVA = "0x45ED60", Offset = "0x45DB60", VA = "0x18045ED60")]
	public void Clear()
	{
	}

	// Token: 0x06003CF6 RID: 15606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003388")]
	[Address(RVA = "0x45F0A0", Offset = "0x45DEA0", VA = "0x18045F0A0")]
	private void SetText(GameObject obj, string text, Color color)
	{
	}

	// Token: 0x06003CF7 RID: 15607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003389")]
	[Address(RVA = "0x45F170", Offset = "0x45DF70", VA = "0x18045F170")]
	public void Setup(ItemDefinition itemdef, int amountNeeded, int amountToCraft)
	{
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338A")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public BlueprintCraftGridRow()
	{
	}

	// Token: 0x04003A1E RID: 14878
	[Token(Token = "0x4002CE6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject amount;

	// Token: 0x04003A1F RID: 14879
	[Token(Token = "0x4002CE7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject itemName;

	// Token: 0x04003A20 RID: 14880
	[Token(Token = "0x4002CE8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject total;

	// Token: 0x04003A21 RID: 14881
	[Token(Token = "0x4002CE9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject have;

	// Token: 0x04003A22 RID: 14882
	[Token(Token = "0x4002CEA")]
	[FieldOffset(Offset = "0x38")]
	public Color colorOK;

	// Token: 0x04003A23 RID: 14883
	[Token(Token = "0x4002CEB")]
	[FieldOffset(Offset = "0x48")]
	public Color colorBad;
}
