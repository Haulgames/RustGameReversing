using System;
using ConVar;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200097E RID: 2430
[Token(Token = "0x20006D0")]
public class ChatEntry : MonoBehaviour
{
	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x0600399F RID: 14751 RVA: 0x00017868 File Offset: 0x00015A68
	[Token(Token = "0x17000426")]
	public float age
	{
		[Token(Token = "0x6003083")]
		[Address(RVA = "0x4DAA70", Offset = "0x4D9870", VA = "0x1804DAA70")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060039A0 RID: 14752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003084")]
	[Address(RVA = "0x4DA690", Offset = "0x4D9490", VA = "0x1804DA690")]
	public void Setup(Chat.ChatChannel channel, ulong steamid, string message, float volume, Action<ChatEntry> clickedAction)
	{
	}

	// Token: 0x060039A1 RID: 14753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003085")]
	[Address(RVA = "0x4DA5F0", Offset = "0x4D93F0", VA = "0x1804DA5F0")]
	private void SetMessageText(Chat.ChatChannel channel, string message)
	{
	}

	// Token: 0x060039A2 RID: 14754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003086")]
	[Address(RVA = "0x4DA8D0", Offset = "0x4D96D0", VA = "0x1804DA8D0")]
	protected void Update()
	{
	}

	// Token: 0x060039A3 RID: 14755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003087")]
	[Address(RVA = "0x4DA5A0", Offset = "0x4D93A0", VA = "0x1804DA5A0")]
	public void OnClicked()
	{
	}

	// Token: 0x060039A4 RID: 14756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003088")]
	[Address(RVA = "0x2F1C00", Offset = "0x2F0A00", VA = "0x1802F1C00")]
	public ChatEntry()
	{
	}

	// Token: 0x04003664 RID: 13924
	[Token(Token = "0x40029A9")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI text;

	// Token: 0x04003665 RID: 13925
	[Token(Token = "0x40029AA")]
	[FieldOffset(Offset = "0x20")]
	public RawImage avatar;

	// Token: 0x04003666 RID: 13926
	[Token(Token = "0x40029AB")]
	[FieldOffset(Offset = "0x28")]
	public CanvasGroup canvasGroup;

	// Token: 0x04003667 RID: 13927
	[Token(Token = "0x40029AC")]
	[FieldOffset(Offset = "0x30")]
	public float lifeStarted;

	// Token: 0x04003668 RID: 13928
	[Token(Token = "0x40029AD")]
	[FieldOffset(Offset = "0x38")]
	public ulong steamid;

	// Token: 0x04003669 RID: 13929
	[Token(Token = "0x40029AE")]
	[FieldOffset(Offset = "0x40")]
	private UnityEngine.Texture defaultTexture;

	// Token: 0x0400366A RID: 13930
	[Token(Token = "0x40029AF")]
	[FieldOffset(Offset = "0x48")]
	private Action<ChatEntry> clickedAction;
}
