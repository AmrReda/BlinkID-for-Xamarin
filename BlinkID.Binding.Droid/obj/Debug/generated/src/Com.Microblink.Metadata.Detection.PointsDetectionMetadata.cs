using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Metadata.Detection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='PointsDetectionMetadata']"
	[global::Android.Runtime.Register ("com/microblink/metadata/detection/PointsDetectionMetadata", DoNotGenerateAcw=true)]
	public partial class PointsDetectionMetadata : global::Com.Microblink.Metadata.Detection.DetectionMetadata {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/metadata/detection/PointsDetectionMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PointsDetectionMetadata); }
		}

		protected PointsDetectionMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_PointSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='PointsDetectionMetadata']/constructor[@name='PointsDetectionMetadata' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.DetectionStatus'] and parameter[2][@type='com.microblink.geometry.PointSet']]"
		[Register (".ctor", "(Lcom/microblink/view/recognition/DetectionStatus;Lcom/microblink/geometry/PointSet;)V", "")]
		public unsafe PointsDetectionMetadata (global::Com.Microblink.View.Recognition.DetectionStatus p0, global::Com.Microblink.Geometry.PointSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PointsDetectionMetadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/view/recognition/DetectionStatus;Lcom/microblink/geometry/PointSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/view/recognition/DetectionStatus;Lcom/microblink/geometry/PointSet;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_PointSet_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_PointSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/recognition/DetectionStatus;Lcom/microblink/geometry/PointSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_PointSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_recognition_DetectionStatus_Lcom_microblink_geometry_PointSet_, __args);
			} finally {
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.Detection.PointsDetectionMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.Detection.PointsDetectionMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		static IntPtr id_getPoints;
		public virtual unsafe global::Com.Microblink.Geometry.PointSet Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata.detection']/class[@name='PointsDetectionMetadata']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Lcom/microblink/geometry/PointSet;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Lcom/microblink/geometry/PointSet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.PointSet> (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.PointSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoints", "()Lcom/microblink/geometry/PointSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
