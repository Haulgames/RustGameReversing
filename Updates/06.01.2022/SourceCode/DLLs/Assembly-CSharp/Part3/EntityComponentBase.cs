using System;
using System.Collections.Generic;
using GameMenu;
using Il2CppDummyDll;
using Network;

// Token: 0x0200049E RID: 1182
[Token(Token = "0x200036C")]
public class EntityComponentBase : BaseMonoBehaviour
{
	// Token: 0x06002445 RID: 9285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0x2F7430", Offset = "0x2F6230", VA = "0x1802F7430", Slot = "6")]
	protected virtual BaseEntity GetBaseEntity()
	{
		return null;
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x2EFE70", Offset = "0x2EEC70", VA = "0x1802EFE70", Slot = "7")]
	public virtual void GetMenuOptions(List<Option> list)
	{
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x06002447 RID: 9287 RVA: 0x00010260 File Offset: 0x0000E460
	[Token(Token = "0x17000287")]
	public virtual bool HasMenuOptions
	{
		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x00010278 File Offset: 0x0000E478
	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x2EF030", Offset = "0x2EDE30", VA = "0x1802EF030", Slot = "9")]
	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg)
	{
		return default(bool);
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x46B5C0", Offset = "0x46A3C0", VA = "0x18046B5C0")]
	public EntityComponentBase()
	{
	}
}
