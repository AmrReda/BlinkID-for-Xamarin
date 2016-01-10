using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognition']/class[@name='RightsManager']"
	[global::Android.Runtime.Register ("com/microblink/recognition/RightsManager", DoNotGenerateAcw=true)]
	public partial class RightsManager : global::Java.Lang.Object {


		static IntPtr mNativeContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognition']/class[@name='RightsManager']/field[@name='mNativeContext']"
		[Register ("mNativeContext")]
		public long MNativeContext {
			get {
				if (mNativeContext_jfieldId == IntPtr.Zero)
					mNativeContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mNativeContext", "J");
				return JNIEnv.GetLongField (Handle, mNativeContext_jfieldId);
			}
			set {
				if (mNativeContext_jfieldId == IntPtr.Zero)
					mNativeContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mNativeContext", "J");
				try {
					JNIEnv.SetField (Handle, mNativeContext_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognition/RightsManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RightsManager); }
		}

		protected RightsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognition']/class[@name='RightsManager']/constructor[@name='RightsManager' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe RightsManager (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RightsManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_nativeGetPingInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='RightsManager']/method[@name='nativeGetPingInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("nativeGetPingInterval", "(J)I", "")]
		public static unsafe int NativeGetPingInterval (long p0)
		{
			if (id_nativeGetPingInterval_J == IntPtr.Zero)
				id_nativeGetPingInterval_J = JNIEnv.GetStaticMethodID (class_ref, "nativeGetPingInterval", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_nativeGetPingInterval_J, __args);
			} finally {
			}
		}

		static IntPtr id_nativeIsLicenseOk_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='RightsManager']/method[@name='nativeIsLicenseOk' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("nativeIsLicenseOk", "(J)Z", "")]
		public static unsafe bool NativeIsLicenseOk (long p0)
		{
			if (id_nativeIsLicenseOk_J == IntPtr.Zero)
				id_nativeIsLicenseOk_J = JNIEnv.GetStaticMethodID (class_ref, "nativeIsLicenseOk", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_nativeIsLicenseOk_J, __args);
			} finally {
			}
		}

	}
}
