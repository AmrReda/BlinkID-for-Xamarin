using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']"
	[global::Android.Runtime.Register ("com/microblink/view/NotSupportedReason", DoNotGenerateAcw=true)]
	public sealed partial class NotSupportedReason : global::Java.Lang.Enum {


		static IntPtr BLACKLISTED_DEVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/field[@name='BLACKLISTED_DEVICE']"
		[Register ("BLACKLISTED_DEVICE")]
		public static global::Com.Microblink.View.NotSupportedReason BlacklistedDevice {
			get {
				if (BLACKLISTED_DEVICE_jfieldId == IntPtr.Zero)
					BLACKLISTED_DEVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLACKLISTED_DEVICE", "Lcom/microblink/view/NotSupportedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BLACKLISTED_DEVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CUSTOM_UI_FORBIDDEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/field[@name='CUSTOM_UI_FORBIDDEN']"
		[Register ("CUSTOM_UI_FORBIDDEN")]
		public static global::Com.Microblink.View.NotSupportedReason CustomUiForbidden {
			get {
				if (CUSTOM_UI_FORBIDDEN_jfieldId == IntPtr.Zero)
					CUSTOM_UI_FORBIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_UI_FORBIDDEN", "Lcom/microblink/view/NotSupportedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_UI_FORBIDDEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_LICENSE_KEY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/field[@name='INVALID_LICENSE_KEY']"
		[Register ("INVALID_LICENSE_KEY")]
		public static global::Com.Microblink.View.NotSupportedReason InvalidLicenseKey {
			get {
				if (INVALID_LICENSE_KEY_jfieldId == IntPtr.Zero)
					INVALID_LICENSE_KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_LICENSE_KEY", "Lcom/microblink/view/NotSupportedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_LICENSE_KEY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_AUTOFOCUS_CAMERA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/field[@name='NO_AUTOFOCUS_CAMERA']"
		[Register ("NO_AUTOFOCUS_CAMERA")]
		public static global::Com.Microblink.View.NotSupportedReason NoAutofocusCamera {
			get {
				if (NO_AUTOFOCUS_CAMERA_jfieldId == IntPtr.Zero)
					NO_AUTOFOCUS_CAMERA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_AUTOFOCUS_CAMERA", "Lcom/microblink/view/NotSupportedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_AUTOFOCUS_CAMERA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_CAMERA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/field[@name='NO_CAMERA']"
		[Register ("NO_CAMERA")]
		public static global::Com.Microblink.View.NotSupportedReason NoCamera {
			get {
				if (NO_CAMERA_jfieldId == IntPtr.Zero)
					NO_CAMERA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_CAMERA", "Lcom/microblink/view/NotSupportedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_CAMERA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNSUPPORTED_ANDROID_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/field[@name='UNSUPPORTED_ANDROID_VERSION']"
		[Register ("UNSUPPORTED_ANDROID_VERSION")]
		public static global::Com.Microblink.View.NotSupportedReason UnsupportedAndroidVersion {
			get {
				if (UNSUPPORTED_ANDROID_VERSION_jfieldId == IntPtr.Zero)
					UNSUPPORTED_ANDROID_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPPORTED_ANDROID_VERSION", "Lcom/microblink/view/NotSupportedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSUPPORTED_ANDROID_VERSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNSUPPORTED_PROCESSOR_ARCHITECTURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/field[@name='UNSUPPORTED_PROCESSOR_ARCHITECTURE']"
		[Register ("UNSUPPORTED_PROCESSOR_ARCHITECTURE")]
		public static global::Com.Microblink.View.NotSupportedReason UnsupportedProcessorArchitecture {
			get {
				if (UNSUPPORTED_PROCESSOR_ARCHITECTURE_jfieldId == IntPtr.Zero)
					UNSUPPORTED_PROCESSOR_ARCHITECTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPPORTED_PROCESSOR_ARCHITECTURE", "Lcom/microblink/view/NotSupportedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSUPPORTED_PROCESSOR_ARCHITECTURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/NotSupportedReason", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotSupportedReason); }
		}

		internal NotSupportedReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDescription;
		public unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/view/NotSupportedReason;", "")]
		public static unsafe global::Com.Microblink.View.NotSupportedReason ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/view/NotSupportedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.View.NotSupportedReason __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='NotSupportedReason']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/view/NotSupportedReason;", "")]
		public static unsafe global::Com.Microblink.View.NotSupportedReason[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/view/NotSupportedReason;");
			try {
				return (global::Com.Microblink.View.NotSupportedReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.View.NotSupportedReason));
			} finally {
			}
		}

	}
}
