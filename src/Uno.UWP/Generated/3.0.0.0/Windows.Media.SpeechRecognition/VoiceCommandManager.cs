#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.SpeechRecognition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VoiceCommandManager 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.Media.SpeechRecognition.VoiceCommandSet> InstalledCommandSets
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, VoiceCommandSet> VoiceCommandManager.InstalledCommandSets is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncAction InstallCommandSetsFromStorageFileAsync( global::Windows.Storage.StorageFile file)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction VoiceCommandManager.InstallCommandSetsFromStorageFileAsync(StorageFile file) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Media.SpeechRecognition.VoiceCommandManager.InstalledCommandSets.get
	}
}
