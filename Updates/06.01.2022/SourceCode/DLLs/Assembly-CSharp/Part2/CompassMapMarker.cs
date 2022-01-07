using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000983 RID: 2435
[Token(Token = "0x20006D4")]
public class CompassMapMarker : MonoBehaviour
{
	// Token: 0x060039CD RID: 14797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030AB")]
	[Address(RVA = "0x4A5290", Offset = "0x4A4090", VA = "0x1804A5290")]
	public void PopulateMarker(bool isTeamLeaders)
	{
	}

	// Token: 0x060039CE RID: 14798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030AC")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public CompassMapMarker()
	{
	}

	// Token: 0x04003682 RID: 13954
	[Token(Token = "0x40029C4")]
	[FieldOffset(Offset = "0x18")]
	public Image MarkerImage;

	// Token: 0x04003683 RID: 13955
	[Token(Token = "0x40029C5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LeaderRoot;
}
