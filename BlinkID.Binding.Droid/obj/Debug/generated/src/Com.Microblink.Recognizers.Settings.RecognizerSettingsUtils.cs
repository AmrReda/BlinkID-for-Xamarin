using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettingsUtils']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/settings/RecognizerSettingsUtils", DoNotGenerateAcw=true)]
	public partial class RecognizerSettingsUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/settings/RecognizerSettingsUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognizerSettingsUtils); }
		}

		protected RecognizerSettingsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettingsUtils']/constructor[@name='RecognizerSettingsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecognizerSettingsUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecognizerSettingsUtils)) {
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

		static IntPtr id_filterOutRecognizersThatRequireAutofocus_arrayLcom_microblink_recognizers_settings_RecognizerSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettingsUtils']/method[@name='filterOutRecognizersThatRequireAutofocus' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.settings.RecognizerSettings[]']]"
		[Register ("filterOutRecognizersThatRequireAutofocus", "([Lcom/microblink/recognizers/settings/RecognizerSettings;)[Lcom/microblink/recognizers/settings/RecognizerSettings;", "")]
		public static unsafe global::Com.Microblink.Recognizers.Settings.RecognizerSettings[] FilterOutRecognizersThatRequireAutofocus (global::Com.Microblink.Recognizers.Settings.RecognizerSettings[] p0)
		{
			if (id_filterOutRecognizersThatRequireAutofocus_arrayLcom_microblink_recognizers_settings_RecognizerSettings_ == IntPtr.Zero)
				id_filterOutRecognizersThatRequireAutofocus_arrayLcom_microblink_recognizers_settings_RecognizerSettings_ = JNIEnv.GetStaticMethodID (class_ref, "filterOutRecognizersThatRequireAutofocus", "([Lcom/microblink/recognizers/settings/RecognizerSettings;)[Lcom/microblink/recognizers/settings/RecognizerSettings;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Recognizers.Settings.RecognizerSettings[] __ret = (global::Com.Microblink.Recognizers.Settings.RecognizerSettings[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterOutRecognizersThatRequireAutofocus_arrayLcom_microblink_recognizers_settings_RecognizerSettings_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognizers.Settings.RecognizerSettings));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
