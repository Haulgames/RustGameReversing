using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;
using Rust.UI;
using UnityEngine;

// Token: 0x0200099E RID: 2462
[Token(Token = "0x20006EA")]
public class DemoShotListWidget : SingletonComponent<DemoShotListWidget>
{
	// Token: 0x06003A53 RID: 14931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003121")]
	[Address(RVA = "0x8CE840", Offset = "0x8CD640", VA = "0x1808CE840")]
	private void OnEnable()
	{
	}

	// Token: 0x06003A54 RID: 14932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003122")]
	[Address(RVA = "0x8CEDE0", Offset = "0x8CDBE0", VA = "0x1808CEDE0")]
	public void UpdateAvailableShots()
	{
	}

	// Token: 0x06003A55 RID: 14933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003123")]
	[Address(RVA = "0x8CEB70", Offset = "0x8CD970", VA = "0x1808CEB70")]
	public void SetCurrentlyPlaying(DemoShot shot)
	{
	}

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x06003A56 RID: 14934 RVA: 0x00017970 File Offset: 0x00015B70
	[Token(Token = "0x1700042A")]
	private int TotalShotCount
	{
		[Token(Token = "0x6003124")]
		[Address(RVA = "0x8CFED0", Offset = "0x8CECD0", VA = "0x1808CFED0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06003A57 RID: 14935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003125")]
	[Address(RVA = "0x8CE450", Offset = "0x8CD250", VA = "0x1808CE450")]
	public string GetDefaultNewShotName()
	{
		return null;
	}

	// Token: 0x06003A58 RID: 14936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003126")]
	[Address(RVA = "0x8CE1B0", Offset = "0x8CCFB0", VA = "0x1808CE1B0")]
	public void DeleteShot(DemoShot shotName)
	{
	}

	// Token: 0x06003A59 RID: 14937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003127")]
	[Address(RVA = "0x8CE9A0", Offset = "0x8CD7A0", VA = "0x1808CE9A0")]
	public void RenameShot(DemoShot shotToRename, string newName)
	{
	}

	// Token: 0x06003A5A RID: 14938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003128")]
	[Address(RVA = "0x8CDFB0", Offset = "0x8CCDB0", VA = "0x1808CDFB0")]
	public void CreateFolder()
	{
	}

	// Token: 0x06003A5B RID: 14939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003129")]
	[Address(RVA = "0x8CECD0", Offset = "0x8CDAD0", VA = "0x1808CECD0")]
	public void ToggleOpen(bool state)
	{
	}

	// Token: 0x06003A5C RID: 14940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600312A")]
	[Address(RVA = "0x8CECC0", Offset = "0x8CDAC0", VA = "0x1808CECC0")]
	public void ToggleOpen()
	{
	}

	// Token: 0x06003A5D RID: 14941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600312B")]
	[Address(RVA = "0x8CE300", Offset = "0x8CD100", VA = "0x1808CE300")]
	public List<string> GetCurrentFolders()
	{
		return null;
	}

	// Token: 0x06003A5E RID: 14942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600312C")]
	[Address(RVA = "0x8CE690", Offset = "0x8CD490", VA = "0x1808CE690")]
	public void MoveShotToFolder(DemoShot shot, string targetFolder)
	{
	}

	// Token: 0x06003A5F RID: 14943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600312D")]
	[Address(RVA = "0x8CE850", Offset = "0x8CD650", VA = "0x1808CE850")]
	public void RenameFolder(string oldName, string newName)
	{
	}

	// Token: 0x06003A60 RID: 14944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600312E")]
	[Address(RVA = "0x8CE0B0", Offset = "0x8CCEB0", VA = "0x1808CE0B0")]
	public void DeleteFolder(string folderName)
	{
	}

	// Token: 0x06003A61 RID: 14945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600312F")]
	[Address(RVA = "0x8CFDE0", Offset = "0x8CEBE0", VA = "0x1808CFDE0")]
	public DemoShotListWidget()
	{
	}

	// Token: 0x040036D5 RID: 14037
	[Token(Token = "0x4002A08")]
	[FieldOffset(Offset = "0x18")]
	public GameObjectRef ShotListEntry;

	// Token: 0x040036D6 RID: 14038
	[Token(Token = "0x4002A09")]
	[FieldOffset(Offset = "0x20")]
	public GameObjectRef FolderEntry;

	// Token: 0x040036D7 RID: 14039
	[Token(Token = "0x4002A0A")]
	[FieldOffset(Offset = "0x28")]
	public Transform ShotListParent;

	// Token: 0x040036D8 RID: 14040
	[Token(Token = "0x4002A0B")]
	[FieldOffset(Offset = "0x30")]
	public RustInput FolderNameInput;

	// Token: 0x040036D9 RID: 14041
	[Token(Token = "0x4002A0C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ShotsRoot;

	// Token: 0x040036DA RID: 14042
	[Token(Token = "0x4002A0D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject NoShotsRoot;

	// Token: 0x040036DB RID: 14043
	[Token(Token = "0x4002A0E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject TopUpArrow;

	// Token: 0x040036DC RID: 14044
	[Token(Token = "0x4002A0F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject TopDownArrow;

	// Token: 0x040036DD RID: 14045
	[Token(Token = "0x4002A10")]
	[FieldOffset(Offset = "0x58")]
	public Canvas DragCanvas;

	// Token: 0x040036DE RID: 14046
	[Token(Token = "0x4002A11")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, List<DemoShot>> foundShots;

	// Token: 0x040036DF RID: 14047
	[Token(Token = "0x4002A12")]
	[FieldOffset(Offset = "0x68")]
	private List<DemoShotEntry> spawnedEntries;

	// Token: 0x040036E0 RID: 14048
	[Token(Token = "0x4002A13")]
	[FieldOffset(Offset = "0x70")]
	private List<DemoShotListFolderWidget> spawnedFolders;

	// Token: 0x040036E1 RID: 14049
	[Token(Token = "0x4002A14")]
	[FieldOffset(Offset = "0x78")]
	private bool isOpen;
}
