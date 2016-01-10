using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Metadata.Detection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='DetectionMetadata']"
	[global::Android.Runtime.Register ("com/microblink/metadata/detection/DetectionMetadata", DoNotGenerateAcw=true)]
	public partial class DetectionMetadata : global::Com.Microblink.Metadata.Metadata {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/metadata/detection/DetectionMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetectionMetadata); }
		}

		protected DetectionMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_view_recognition_DetectionStatus_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='DetectionMetadata']/constructor[@name='DetectionMetadata' and count(parameter)=1 and parameter[1][@type='com.microblink.view.recognition.DetectionStatus']]"
		[Register (".ctor", "(Lcom/microblink/view/recognition/DetectionStatus;)V", "")]
		public unsafe DetectionMetadata (global::Com.Microblink.View.Recognition.DetectionStatus p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DetectionMetadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/view/recognition/DetectionStatus;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/view/recognition/DetectionStatus;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_view_recognition_DetectionStatus_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_view_recognition_DetectionStatus_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/recognition/DetectionStatus;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_recognition_DetectionStatus_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_recognition_DetectionStatus_, __args);
			} finally {
			}
		}

		static Delegate cb_getDetectionStatus;
#pragma warning disable 0169
		static Delegate GetGetDetectionStatusHandler ()
		{
			if (cb_getDetectionStatus == null)
				cb_getDetectionStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDetectionStatus);
			return cb_getDetectionStatus;
		}

		static IntPtr n_GetDetectionStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.Detection.DetectionMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.Detection.DetectionMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DetectionStatus);
		}
#pragma warning restore 0169

		static IntPtr id_getDetectionStatus;
		public virtual unsafe global::Com.Microblink.View.Recognition.DetectionStatus DetectionStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='DetectionMetadata']/method[@name='getDetectionStatus' and count(parameter)=0]"
			[Register ("getDetectionStatus", "()Lcom/microblink/view/recognition/DetectionStatus;", "GetGetDetectionStatusHandler")]
			get {
				if (id_getDetectionStatus == IntPtr.Zero)
					id_getDetectionStatus = JNIEnv.GetMethodID (class_ref, "getDetectionStatus", "()Lcom/microblink/view/recognition/DetectionStatus;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (JNIEnv.CallObjectMethod  (Handle, id_getDetectionStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDetectionStatus", "()Lcom/microblink/view/recognition/DetectionStatus;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
