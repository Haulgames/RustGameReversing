using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009B7 RID: 2487
[Token(Token = "0x20006F6")]
public class ChangeSignText : UIDialog
{
	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700042F")]
	public MeshPaintableSource[] currentSources
	{
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x4DA580", Offset = "0x4D9380", VA = "0x1804DA580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x4DA590", Offset = "0x4D9390", VA = "0x1804DA590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
		set
		{
		}
	}

	// Token: 0x06003AC5 RID: 15045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003187")]
	[Address(RVA = "0x4D9C30", Offset = "0x4D8A30", VA = "0x1804D9C30")]
	public void Setup(MeshPaintableSource[] sources)
	{
	}

	// Token: 0x06003AC6 RID: 15046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003188")]
	[Address(RVA = "0x4D8E70", Offset = "0x4D7C70", VA = "0x1804D8E70")]
	private void DisableLODs(GameObject go)
	{
	}

	// Token: 0x06003AC7 RID: 15047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003189")]
	[Address(RVA = "0x4DA420", Offset = "0x4D9220", VA = "0x1804DA420")]
	public void UpdateSign()
	{
	}

	// Token: 0x06003AC8 RID: 15048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318A")]
	[Address(RVA = "0x4D9810", Offset = "0x4D8610", VA = "0x1804D9810")]
	public void RegisterChange(MeshPaintable paintable)
	{
	}

	// Token: 0x06003AC9 RID: 15049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318B")]
	[Address(RVA = "0x4D9740", Offset = "0x4D8540", VA = "0x1804D9740")]
	public void ProcessUndo(MeshPaintable paintable)
	{
	}

	// Token: 0x06003ACA RID: 15050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318C")]
	[Address(RVA = "0x4D9560", Offset = "0x4D8360", VA = "0x1804D9560")]
	public void ProcessRedo(MeshPaintable paintable)
	{
	}

	// Token: 0x06003ACB RID: 15051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318D")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "8")]
	public override void OpenDialog()
	{
	}

	// Token: 0x06003ACC RID: 15052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318E")]
	[Address(RVA = "0x46B080", Offset = "0x469E80", VA = "0x18046B080")]
	public void Cancel()
	{
	}

	// Token: 0x06003ACD RID: 15053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600318F")]
	[Address(RVA = "0x4D8B00", Offset = "0x4D7900", VA = "0x1804D8B00", Slot = "9")]
	public override void CloseDialog()
	{
	}

	// Token: 0x06003ACE RID: 15054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003190")]
	[Address(RVA = "0x4D99F0", Offset = "0x4D87F0", VA = "0x1804D99F0")]
	public void SelectFrame(int n)
	{
	}

	// Token: 0x06003ACF RID: 15055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003191")]
	[Address(RVA = "0x4D89F0", Offset = "0x4D77F0", VA = "0x1804D89F0")]
	public void ClearCurrentFrame()
	{
	}

	// Token: 0x06003AD0 RID: 15056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003192")]
	[Address(RVA = "0x4D8D50", Offset = "0x4D7B50", VA = "0x1804D8D50")]
	public void CopyPreviousFrame()
	{
	}

	// Token: 0x06003AD1 RID: 15057 RVA: 0x00017A00 File Offset: 0x00015C00
	[Token(Token = "0x6003193")]
	[Address(RVA = "0x4D9450", Offset = "0x4D8250", VA = "0x1804D9450")]
	public bool IsUndoAvailable(MeshPaintable paintable)
	{
		return default(bool);
	}

	// Token: 0x06003AD2 RID: 15058 RVA: 0x00017A18 File Offset: 0x00015C18
	[Token(Token = "0x6003194")]
	[Address(RVA = "0x4D9340", Offset = "0x4D8140", VA = "0x1804D9340")]
	public bool IsRedoAvailable(MeshPaintable paintable)
	{
		return default(bool);
	}

	// Token: 0x06003AD3 RID: 15059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003195")]
	[Address(RVA = "0x46B490", Offset = "0x46A290", VA = "0x18046B490")]
	public ChangeSignText()
	{
	}

	// Token: 0x040037AF RID: 14255
	[Token(Token = "0x4002AAE")]
	[FieldOffset(Offset = "0x30")]
	public Action<int, Texture2D> onUpdateTexture;

	// Token: 0x040037B0 RID: 14256
	[Token(Token = "0x4002AAF")]
	[FieldOffset(Offset = "0x38")]
	public GameObject objectContainer;

	// Token: 0x040037B1 RID: 14257
	[Token(Token = "0x4002AB0")]
	[FieldOffset(Offset = "0x40")]
	public GameObject currentFrameSection;

	// Token: 0x040037B2 RID: 14258
	[Token(Token = "0x4002AB1")]
	[FieldOffset(Offset = "0x48")]
	public GameObject[] frameOptions;

	// Token: 0x040037B3 RID: 14259
	[Token(Token = "0x4002AB2")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CD50", Offset = "0x6C150")]
	private MeshPaintableSource[] <currentSources>k__BackingField;

	// Token: 0x040037B4 RID: 14260
	[Token(Token = "0x4002AB3")]
	[FieldOffset(Offset = "0x58")]
	private List<GameObject> copiedObjects;

	// Token: 0x040037B5 RID: 14261
	[Token(Token = "0x4002AB4")]
	[FieldOffset(Offset = "0x60")]
	private int currentFrame;

	// Token: 0x040037B6 RID: 14262
	[Token(Token = "0x4002AB5")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<MeshPaintable, ChangeSignText.UndoBuffer> undoBuffer;

	// Token: 0x040037B7 RID: 14263
	[Token(Token = "0x4002AB6")]
	[FieldOffset(Offset = "0x0")]
	private static string savedContainerName;

	// Token: 0x040037B8 RID: 14264
	[Token(Token = "0x4002AB7")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3 savedContainerEuler;

	// Token: 0x020009B8 RID: 2488
	[Token(Token = "0x2000CEA")]
	private class UndoBuffer : IDisposable
	{
		// Token: 0x06003AD4 RID: 15060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x4F3330", Offset = "0x4F2130", VA = "0x1804F3330")]
		public void Initialise(Texture2D forTexture, int bufferLength)
		{
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B4")]
		[Address(RVA = "0x4F3710", Offset = "0x4F2510", VA = "0x1804F3710")]
		public void RegisterChange(Texture2D forTexture)
		{
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x4F3590", Offset = "0x4F2390", VA = "0x1804F3590")]
		public void ProcessUndo(Texture2D targetTexture)
		{
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x4F3460", Offset = "0x4F2260", VA = "0x1804F3460")]
		public void ProcessRedo(Texture2D targetTexture)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x00017A30 File Offset: 0x00015C30
		[Token(Token = "0x17000780")]
		private int CurrentSlot
		{
			[Token(Token = "0x60050B7")]
			[Address(RVA = "0x4F3830", Offset = "0x4F2630", VA = "0x1804F3830")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x00017A48 File Offset: 0x00015C48
		[Token(Token = "0x17000781")]
		public bool IsUndoAvailable
		{
			[Token(Token = "0x60050B8")]
			[Address(RVA = "0x4F38E0", Offset = "0x4F26E0", VA = "0x1804F38E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x00017A60 File Offset: 0x00015C60
		[Token(Token = "0x17000782")]
		public bool IsRedoAvailable
		{
			[Token(Token = "0x60050B9")]
			[Address(RVA = "0x4F38C0", Offset = "0x4F26C0", VA = "0x1804F38C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x4F3240", Offset = "0x4F2040", VA = "0x1804F3240", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x2FEDD0", Offset = "0x2FDBD0", VA = "0x1802FEDD0")]
		public UndoBuffer()
		{
		}

		// Token: 0x040037B9 RID: 14265
		[Token(Token = "0x40049EB")]
		[FieldOffset(Offset = "0x10")]
		private List<Texture2D> buffer;

		// Token: 0x040037BA RID: 14266
		[Token(Token = "0x40049EC")]
		[FieldOffset(Offset = "0x18")]
		private Texture2D startFrame;

		// Token: 0x040037BB RID: 14267
		[Token(Token = "0x40049ED")]
		[FieldOffset(Offset = "0x20")]
		private int undoIndex;

		// Token: 0x040037BC RID: 14268
		[Token(Token = "0x40049EE")]
		[FieldOffset(Offset = "0x24")]
		private int undoSteps;
	}
}
