#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Profile
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EducationSettings 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool IsEducationEnvironment
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool EducationSettings.IsEducationEnvironment is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.System.Profile.EducationSettings.IsEducationEnvironment.get
	}
}
