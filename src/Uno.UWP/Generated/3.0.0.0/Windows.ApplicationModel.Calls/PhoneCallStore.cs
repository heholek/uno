#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PhoneCallStore 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<bool> IsEmergencyPhoneNumberAsync( string number)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> PhoneCallStore.IsEmergencyPhoneNumberAsync(string number) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Guid> GetDefaultLineAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Guid> PhoneCallStore.GetDefaultLineAsync() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Calls.PhoneLineWatcher RequestLineWatcher()
		{
			throw new global::System.NotImplementedException("The member PhoneLineWatcher PhoneCallStore.RequestLineWatcher() is not implemented in Uno.");
		}
		#endif
	}
}
