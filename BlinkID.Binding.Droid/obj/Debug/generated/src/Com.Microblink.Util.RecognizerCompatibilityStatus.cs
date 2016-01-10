using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']"
	[global::Android.Runtime.Register ("com/microblink/util/RecognizerCompatibilityStatus", DoNotGenerateAcw=true)]
	public sealed partial class RecognizerCompatibilityStatus : global::Java.Lang.Enum {


		static IntPtr DEVICE_BLACKLISTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']/field[@name='DEVICE_BLACKLISTED']"
		[Register ("DEVICE_BLACKLISTED")]
		public static global::Com.Microblink.Util.RecognizerCompatibilityStatus DeviceBlacklisted {
			get {
				if (DEVICE_BLACKLISTED_jfieldId == IntPtr.Zero)
					DEVICE_BLACKLISTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_BLACKLISTED", "Lcom/microblink/util/RecognizerCompatibilityStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_BLACKLISTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.RecognizerCompatibilityStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_CAMERA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']/field[@name='NO_CAMERA']"
		[Register ("NO_CAMERA")]
		public static global::Com.Microblink.Util.RecognizerCompatibilityStatus NoCamera {
			get {
				if (NO_CAMERA_jfieldId == IntPtr.Zero)
					NO_CAMERA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_CAMERA", "Lcom/microblink/util/RecognizerCompatibilityStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_CAMERA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.RecognizerCompatibilityStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PROCESSOR_ARCHITECTURE_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']/field[@name='PROCESSOR_ARCHITECTURE_NOT_SUPPORTED']"
		[Register ("PROCESSOR_ARCHITECTURE_NOT_SUPPORTED")]
		public static global::Com.Microblink.Util.RecognizerCompatibilityStatus ProcessorArchitectureNotSupported {
			get {
				if (PROCESSOR_ARCHITECTURE_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					PROCESSOR_ARCHITECTURE_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROCESSOR_ARCHITECTURE_NOT_SUPPORTED", "Lcom/microblink/util/RecognizerCompatibilityStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROCESSOR_ARCHITECTURE_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.RecognizerCompatibilityStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RECOGNIZER_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']/field[@name='RECOGNIZER_NOT_SUPPORTED']"
		[Register ("RECOGNIZER_NOT_SUPPORTED")]
		public static global::Com.Microblink.Util.RecognizerCompatibilityStatus RecognizerNotSupported {
			get {
				if (RECOGNIZER_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					RECOGNIZER_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECOGNIZER_NOT_SUPPORTED", "Lcom/microblink/util/RecognizerCompatibilityStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECOGNIZER_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.RecognizerCompatibilityStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RECOGNIZER_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']/field[@name='RECOGNIZER_SUPPORTED']"
		[Register ("RECOGNIZER_SUPPORTED")]
		public static global::Com.Microblink.Util.RecognizerCompatibilityStatus RecognizerSupported {
			get {
				if (RECOGNIZER_SUPPORTED_jfieldId == IntPtr.Zero)
					RECOGNIZER_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECOGNIZER_SUPPORTED", "Lcom/microblink/util/RecognizerCompatibilityStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECOGNIZER_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.RecognizerCompatibilityStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNSUPPORTED_ANDROID_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']/field[@name='UNSUPPORTED_ANDROID_VERSION']"
		[Register ("UNSUPPORTED_ANDROID_VERSION")]
		public static global::Com.Microblink.Util.RecognizerCompatibilityStatus UnsupportedAndroidVersion {
			get {
				if (UNSUPPORTED_ANDROID_VERSION_jfieldId == IntPtr.Zero)
					UNSUPPORTED_ANDROID_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPPORTED_ANDROID_VERSION", "Lcom/microblink/util/RecognizerCompatibilityStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSUPPORTED_ANDROID_VERSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.RecognizerCompatibilityStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/util/RecognizerCompatibilityStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognizerCompatibilityStatus); }
		}

		internal RecognizerCompatibilityStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/util/RecognizerCompatibilityStatus;", "")]
		public static unsafe global::Com.Microblink.Util.RecognizerCompatibilityStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/util/RecognizerCompatibilityStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Util.RecognizerCompatibilityStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.RecognizerCompatibilityStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibilityStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/util/RecognizerCompatibilityStatus;", "")]
		public static unsafe global::Com.Microblink.Util.RecognizerCompatibilityStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/util/RecognizerCompatibilityStatus;");
			try {
				return (global::Com.Microblink.Util.RecognizerCompatibilityStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Util.RecognizerCompatibilityStatus));
			} finally {
			}
		}

	}
}
