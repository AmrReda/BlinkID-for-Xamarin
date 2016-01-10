using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Locale {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.locale']/class[@name='LanguageUtils']"
	[global::Android.Runtime.Register ("com/microblink/locale/LanguageUtils", DoNotGenerateAcw=true)]
	public partial class LanguageUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/locale/LanguageUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LanguageUtils); }
		}

		protected LanguageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.locale']/class[@name='LanguageUtils']/constructor[@name='LanguageUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LanguageUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LanguageUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_setLanguage_Lcom_microblink_locale_Language_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.locale']/class[@name='LanguageUtils']/method[@name='setLanguage' and count(parameter)=2 and parameter[1][@type='com.microblink.locale.Language'] and parameter[2][@type='android.content.Context']]"
		[Register ("setLanguage", "(Lcom/microblink/locale/Language;Landroid/content/Context;)V", "")]
		public static unsafe void SetLanguage (global::Com.Microblink.Locale.Language p0, global::Android.Content.Context p1)
		{
			if (id_setLanguage_Lcom_microblink_locale_Language_Landroid_content_Context_ == IntPtr.Zero)
				id_setLanguage_Lcom_microblink_locale_Language_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setLanguage", "(Lcom/microblink/locale/Language;Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLanguage_Lcom_microblink_locale_Language_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_setLanguageAndCountry_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.locale']/class[@name='LanguageUtils']/method[@name='setLanguageAndCountry' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("setLanguageAndCountry", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void SetLanguageAndCountry (string p0, string p1, global::Android.Content.Context p2)
		{
			if (id_setLanguageAndCountry_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_setLanguageAndCountry_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setLanguageAndCountry", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLanguageAndCountry_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setLanguageConfiguration_Landroid_content_res_Resources_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.locale']/class[@name='LanguageUtils']/method[@name='setLanguageConfiguration' and count(parameter)=1 and parameter[1][@type='android.content.res.Resources']]"
		[Register ("setLanguageConfiguration", "(Landroid/content/res/Resources;)V", "")]
		public static unsafe void SetLanguageConfiguration (global::Android.Content.Res.Resources p0)
		{
			if (id_setLanguageConfiguration_Landroid_content_res_Resources_ == IntPtr.Zero)
				id_setLanguageConfiguration_Landroid_content_res_Resources_ = JNIEnv.GetStaticMethodID (class_ref, "setLanguageConfiguration", "(Landroid/content/res/Resources;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLanguageConfiguration_Landroid_content_res_Resources_, __args);
			} finally {
			}
		}

	}
}
