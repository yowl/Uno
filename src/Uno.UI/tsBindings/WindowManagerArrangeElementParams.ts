/* TSBindingsGenerator Generated code -- this code is regenerated on each build */
class WindowManagerArrangeElementParams
{
	/* Pack=4 */
	public Top : number;
	public Left : number;
	public Width : number;
	public Height : number;
	public ClipTop : number;
	public ClipLeft : number;
	public ClipBottom : number;
	public ClipRight : number;
	public HtmlId : number;
	public Clip : boolean;
	public ClipToBounds : boolean;
	public static unmarshal(pData:number) : WindowManagerArrangeElementParams
	{
		const ret = new WindowManagerArrangeElementParams();
		
		{
			ret.Top = Number(Module.getValue(pData + 0, "double"));
		}
		
		{
			ret.Left = Number(Module.getValue(pData + 8, "double"));
		}
		
		{
			ret.Width = Number(Module.getValue(pData + 16, "double"));
		}
		
		{
			ret.Height = Number(Module.getValue(pData + 24, "double"));
		}
		
		{
			ret.ClipTop = Number(Module.getValue(pData + 32, "double"));
		}
		
		{
			ret.ClipLeft = Number(Module.getValue(pData + 40, "double"));
		}
		
		{
			ret.ClipBottom = Number(Module.getValue(pData + 48, "double"));
		}
		
		{
			ret.ClipRight = Number(Module.getValue(pData + 56, "double"));
		}
		
		{
			ret.HtmlId = Number(Module.getValue(pData + 64, "*"));
		}
		
		{
			ret.Clip = Boolean(Module.getValue(pData + 68, "i32"));
		}
		
		{
			ret.ClipToBounds = Boolean(Module.getValue(pData + 72, "i32"));
		}
		return ret;
	}
}
