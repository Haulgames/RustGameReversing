using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000256 RID: 598
[Token(Token = "0x200019A")]
public class CassettePanel : NotePanel
{
	// Token: 0x060018C0 RID: 6336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001366")]
	[Address(RVA = "0x4D3A80", Offset = "0x4D2880", VA = "0x1804D3A80", Slot = "4")]
	protected override void OnItem(Item item)
	{
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001367")]
	[Address(RVA = "0x4D3B70", Offset = "0x4D2970", VA = "0x1804D3B70")]
	public void SetCassetteType(int index)
	{
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001368")]
	[Address(RVA = "0x2F6C50", Offset = "0x2F5A50", VA = "0x1802F6C50")]
	public CassettePanel()
	{
	}

	// Token: 0x040012F2 RID: 4850
	[Token(Token = "0x4000F7E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] CassetteSprites;
}
