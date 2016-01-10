using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Metadata.Detection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='QuadrilateralDetectionMetadata']"
	[global::Android.Runtime.Register ("com/microblink/metadata/detection/QuadrilateralDetectionMetadata", DoNotGenerateAcw=true)]
	public partial class QuadrilateralDetectionMetadata : global::Com.Microblink.Metadata.Detection.DetectionMetadata {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/metadata/detection/QuadrilateralDetectionMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuadrilateralDetectionMetadata); }
		}

		protected QuadrilateralDetectionMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_Quadrilateral_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='QuadrilateralDetectionMetadata']/constructor[@name='QuadrilateralDetectionMetadata' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.DetectionStatus'] and parameter[2][@type='com.microblink.geometry.Quadrilateral']]"
		[Register (".ctor", "(Lcom/microblink/view/recognition/DetectionStatus;Lcom/microblink/geometry/Quadrilateral;)V", "")]
		public unsafe QuadrilateralDetectionMetadata (global::Com.Microblink.View.Recognition.DetectionStatus p0, global::Com.Microblink.Geometry.Quadrilateral p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (QuadrilateralDetectionMetadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/view/recognition/DetectionStatus;Lcom/microblink/geometry/Quadrilateral;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/view/recognition/DetectionStatus;Lcom/microblink/geometry/Quadrilateral;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_Quadrilateral_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_Quadrilateral_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/recognition/DetectionStatus;Lcom/microblink/geometry/Quadrilateral;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_Quadrilateral_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_Quadrilateral_, __args);
			} finally {
			}
		}

		static Delegate cb_getQuadrilateral;
#pragma warning disable 0169
		static Delegate GetGetQuadrilateralHandler ()
		{
			if (cb_getQuadrilateral == null)
				cb_getQuadrilateral = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuadrilateral);
			return cb_getQuadrilateral;
		}

		static IntPtr n_GetQuadrilateral (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.Detection.QuadrilateralDetectionMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.Detection.QuadrilateralDetectionMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Quadrilateral);
		}
#pragma warning restore 0169

		static IntPtr id_getQuadrilateral;
		public virtual unsafe global::Com.Microblink.Geometry.Quadrilateral Quadrilateral {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='QuadrilateralDetectionMetadata']/method[@name='getQuadrilateral' and count(parameter)=0]"
			[Register ("getQuadrilateral", "()Lcom/microblink/geometry/Quadrilateral;", "GetGetQuadrilateralHandler")]
			get {
				if (id_getQuadrilateral == IntPtr.Zero)
					id_getQuadrilateral = JNIEnv.GetMethodID (class_ref, "getQuadrilateral", "()Lcom/microblink/geometry/Quadrilateral;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallObjectMethod  (Handle, id_getQuadrilateral), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuadrilateral", "()Lcom/microblink/geometry/Quadrilateral;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
