using System;
using Il2CppDummyDll;

// Token: 0x02000358 RID: 856
[Token(Token = "0x2000260")]
public abstract class ComponentInfo<T> : ComponentInfo
{
	// Token: 0x06001DB5 RID: 7605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F5")]
	public void Initialize(T source)
	{
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F6")]
	protected ComponentInfo()
	{
	}

	// Token: 0x040018BA RID: 6330
	[Token(Token = "0x4001420")]
	[FieldOffset(Offset = "0x0")]
	public T component;
}
