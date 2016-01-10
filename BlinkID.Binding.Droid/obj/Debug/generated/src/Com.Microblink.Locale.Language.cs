using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Locale {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.locale']/class[@name='Language']"
	[global::Android.Runtime.Register ("com/microblink/locale/Language", DoNotGenerateAcw=true)]
	public sealed partial class Language : global::Java.Lang.Enum {


		static IntPtr Croatian_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.locale']/class[@name='Language']/field[@name='Croatian']"
		[Register ("Croatian")]
		public static global::Com.Microblink.Locale.Language Croatian {
			get {
				if (Croatian_jfieldId == IntPtr.Zero)
					Croatian_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Croatian", "Lcom/microblink/locale/Language;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Croatian_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Locale.Language> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr English_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.locale']/class[@name='Language']/field[@name='English']"
		[Register ("English")]
		public static global::Com.Microblink.Locale.Language English {
			get {
				if (English_jfieldId == IntPtr.Zero)
					English_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "English", "Lcom/microblink/locale/Language;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, English_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Locale.Language> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr German_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.locale']/class[@name='Language']/field[@name='German']"
		[Register ("German")]
		public static global::Com.Microblink.Locale.Language German {
			get {
				if (German_jfieldId == IntPtr.Zero)
					German_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "German", "Lcom/microblink/locale/Language;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, German_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Locale.Language> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/locale/Language", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Language); }
		}

		internal Language (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCountry;
		public unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.locale']/class[@name='Language']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				if (id_getCountry == IntPtr.Zero)
					id_getCountry = JNIEnv.GetMethodID (class_ref, "getCountry", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCountry), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLanguage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.locale']/class[@name='Language']/method[@name='getLanguage' and count(parameter)=0]"
		[Register ("getLanguage", "()Ljava/lang/String;", "")]
		public unsafe string GetLanguage ()
		{
			if (id_getLanguage == IntPtr.Zero)
				id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.locale']/class[@name='Language']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/locale/Language;", "")]
		public static unsafe global::Com.Microblink.Locale.Language ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/locale/Language;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Locale.Language __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Locale.Language> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.locale']/class[@name='Language']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/locale/Language;", "")]
		public static unsafe global::Com.Microblink.Locale.Language[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/locale/Language;");
			try {
				return (global::Com.Microblink.Locale.Language[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Locale.Language));
			} finally {
			}
		}

	}
}
