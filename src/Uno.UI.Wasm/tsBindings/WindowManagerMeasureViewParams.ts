/* TSBindingsGenerator Generated code -- this code is regenerated on each build */
class WindowManagerMeasureViewParams
{
	/* Pack=8 */
	HtmlId : number;
	AvailableWidth : number;
	AvailableHeight : number;
	public static unmarshal(pData:number) : WindowManagerMeasureViewParams
	{
		let ret = new WindowManagerMeasureViewParams();
		
		{
			ret.HtmlId = Number(Module.getValue(pData + 0, "*"));
		}
		
		{
			ret.AvailableWidth = Number(Module.getValue(pData + 8, "double"));
		}
		
		{
			ret.AvailableHeight = Number(Module.getValue(pData + 16, "double"));
		}
		return ret;
	}
}
