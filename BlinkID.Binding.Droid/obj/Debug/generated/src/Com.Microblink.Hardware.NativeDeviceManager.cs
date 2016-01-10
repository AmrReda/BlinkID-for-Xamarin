using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.hardware']/class[@name='NativeDeviceManager']"
	[global::Android.Runtime.Register ("com/microblink/hardware/NativeDeviceManager", DoNotGenerateAcw=true)]
	public partial class NativeDeviceManager : global::Java.Lang.Object {


		static IntPtr mNativeContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware']/class[@name='NativeDeviceManager']/field[@name='mNativeContext']"
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
				return JNIEnv.FindClass ("com/microblink/hardware/NativeDeviceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeDeviceManager); }
		}

		protected NativeDeviceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
