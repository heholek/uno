#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Globalization
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Language 
	{
		// Skipping already declared property DisplayName
		// Skipping already declared property LanguageTag
		// Skipping already declared property NativeName
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Script
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Language.Script is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Globalization.LanguageLayoutDirection LayoutDirection
		{
			get
			{
				throw new global::System.NotImplementedException("The member LanguageLayoutDirection Language.LayoutDirection is not implemented in Uno.");
			}
		}
		#endif
		#if false || false || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public static string CurrentInputMethodLanguageTag
		{
			get
			{
				throw new global::System.NotImplementedException("The member string Language.CurrentInputMethodLanguageTag is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared method Windows.Globalization.Language.Language(string)
		// Forced skipping of method Windows.Globalization.Language.Language(string)
		// Forced skipping of method Windows.Globalization.Language.LanguageTag.get
		// Forced skipping of method Windows.Globalization.Language.DisplayName.get
		// Forced skipping of method Windows.Globalization.Language.NativeName.get
		// Forced skipping of method Windows.Globalization.Language.Script.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<string> GetExtensionSubtags( string singleton)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<string> Language.GetExtensionSubtags(string singleton) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Globalization.Language.LayoutDirection.get
		#if false || false || NET461 || false || __MACOS__
		[global::Uno.NotImplemented]
		public static bool TrySetInputMethodLanguageTag( string languageTag)
		{
			throw new global::System.NotImplementedException("The member bool Language.TrySetInputMethodLanguageTag(string languageTag) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static bool IsWellFormed( string languageTag)
		{
			throw new global::System.NotImplementedException("The member bool Language.IsWellFormed(string languageTag) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.Globalization.Language.CurrentInputMethodLanguageTag.get
	}
}
