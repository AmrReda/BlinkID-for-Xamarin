using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Metadata.Detection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='FailedDetectionMetadata']"
	[global::Android.Runtime.Register ("com/microblink/metadata/detection/FailedDetectionMetadata", DoNotGenerateAcw=true)]
	public partial class FailedDetectionMetadata : global::Com.Microblink.Metadata.Detection.DetectionMetadata {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/metadata/detection/FailedDetectionMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FailedDetectionMetadata); }
		}

		protected FailedDetectionMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='FailedDetectionMetadata']/constructor[@name='FailedDetectionMetadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FailedDetectionMetadata ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FailedDetectionMetadata)) {
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

	}
}
