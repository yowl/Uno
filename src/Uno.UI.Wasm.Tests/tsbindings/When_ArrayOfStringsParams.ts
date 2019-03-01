/* TSBindingsGenerator Generated code -- this code is regenerated on each build */
class When_ArrayOfStringsParams
{
	/* Pack=4 */
	MyArray_Length : number;
	MyArray : Array<string>;
	public static unmarshal(pData:number) : When_ArrayOfStringsParams
	{
		let ret = new When_ArrayOfStringsParams();
		
		{
			ret.MyArray_Length = Number(Module.getValue(pData + 0, "i32"));
		}
		
		{
			var pArray = Module.getValue(pData + 4, "*");
			if(pArray !== 0)
			{
				ret.MyArray = new Array<string>();
				for(var i=0; i<ret.MyArray_Length; i++)
				{
					var value = Module.getValue(pArray + i * 4, "*");
					if(value !== 0)
					{
						ret.MyArray.push(String(MonoRuntime.conv_string(value)));
					}
					else
					
					{
						ret.MyArray.push(null);
					}
				}
			}
			else
			
			{
				ret.MyArray = null;
			}
		}
		return ret;
	}
}
