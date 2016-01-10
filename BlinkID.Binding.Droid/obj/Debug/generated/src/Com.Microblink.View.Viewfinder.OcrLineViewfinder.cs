using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Viewfinder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='OcrLineViewfinder']"
	[global::Android.Runtime.Register ("com/microblink/view/viewfinder/OcrLineViewfinder", DoNotGenerateAcw=true)]
	public partial class OcrLineViewfinder : global::Android.Views.View {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/viewfinder/OcrLineViewfinder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrLineViewfinder); }
		}

		protected OcrLineViewfinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='OcrLineViewfinder']/constructor[@name='OcrLineViewfinder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe OcrLineViewfinder (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (OcrLineViewfinder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static Delegate cb_isAnimationInProgress;
#pragma warning disable 0169
		static Delegate GetIsAnimationInProgressHandler ()
		{
			if (cb_isAnimationInProgress == null)
				cb_isAnimationInProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimationInProgress);
			return cb_isAnimationInProgress;
		}

		static bool n_IsAnimationInProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.Viewfinder.OcrLineViewfinder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.OcrLineViewfinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimationInProgress;
		}
#pragma warning restore 0169

		static IntPtr id_isAnimationInProgress;
		public virtual unsafe bool IsAnimationInProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='OcrLineViewfinder']/method[@name='isAnimationInProgress' and count(parameter)=0]"
			[Register ("isAnimationInProgress", "()Z", "GetIsAnimationInProgressHandler")]
			get {
				if (id_isAnimationInProgress == IntPtr.Zero)
					id_isAnimationInProgress = JNIEnv.GetMethodID (class_ref, "isAnimationInProgress", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAnimationInProgress);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnimationInProgress", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_publishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_;
#pragma warning disable 0169
		static Delegate GetPublishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_Handler ()
		{
			if (cb_publishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_ == null)
				cb_publishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PublishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_);
			return cb_publishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_;
		}

		static void n_PublishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.Viewfinder.OcrLineViewfinder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.OcrLineViewfinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.Recognition.DetectionStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PublishDetectionStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_publishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='OcrLineViewfinder']/method[@name='publishDetectionStatus' and count(parameter)=1 and parameter[1][@type='com.microblink.view.recognition.DetectionStatus']]"
		[Register ("publishDetectionStatus", "(Lcom/microblink/view/recognition/DetectionStatus;)V", "GetPublishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_Handler")]
		public virtual unsafe void PublishDetectionStatus (global::Com.Microblink.View.Recognition.DetectionStatus p0)
		{
			if (id_publishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_ == IntPtr.Zero)
				id_publishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_ = JNIEnv.GetMethodID (class_ref, "publishDetectionStatus", "(Lcom/microblink/view/recognition/DetectionStatus;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_publishDetectionStatus_Lcom_microblink_view_recognition_DetectionStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publishDetectionStatus", "(Lcom/microblink/view/recognition/DetectionStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultTarget;
#pragma warning disable 0169
		static Delegate GetSetDefaultTargetHandler ()
		{
			if (cb_setDefaultTarget == null)
				cb_setDefaultTarget = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetDefaultTarget);
			return cb_setDefaultTarget;
		}

		static void n_SetDefaultTarget (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.Viewfinder.OcrLineViewfinder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.OcrLineViewfinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultTarget ();
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultTarget;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='OcrLineViewfinder']/method[@name='setDefaultTarget' and count(parameter)=0]"
		[Register ("setDefaultTarget", "()V", "GetSetDefaultTargetHandler")]
		public virtual unsafe void SetDefaultTarget ()
		{
			if (id_setDefaultTarget == IntPtr.Zero)
				id_setDefaultTarget = JNIEnv.GetMethodID (class_ref, "setDefaultTarget", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDefaultTarget);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultTarget", "()V"));
			} finally {
			}
		}

		static Delegate cb_setHostActivityOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetHostActivityOrientation_IHandler ()
		{
			if (cb_setHostActivityOrientation_I == null)
				cb_setHostActivityOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHostActivityOrientation_I);
			return cb_setHostActivityOrientation_I;
		}

		static void n_SetHostActivityOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.View.Viewfinder.OcrLineViewfinder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.OcrLineViewfinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHostActivityOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHostActivityOrientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='OcrLineViewfinder']/method[@name='setHostActivityOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHostActivityOrientation", "(I)V", "GetSetHostActivityOrientation_IHandler")]
		public virtual unsafe void SetHostActivityOrientation (int p0)
		{
			if (id_setHostActivityOrientation_I == IntPtr.Zero)
				id_setHostActivityOrientation_I = JNIEnv.GetMethodID (class_ref, "setHostActivityOrientation", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHostActivityOrientation_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostActivityOrientation", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setNewTarget_Lcom_microblink_geometry_Quadrilateral_;
#pragma warning disable 0169
		static Delegate GetSetNewTarget_Lcom_microblink_geometry_Quadrilateral_Handler ()
		{
			if (cb_setNewTarget_Lcom_microblink_geometry_Quadrilateral_ == null)
				cb_setNewTarget_Lcom_microblink_geometry_Quadrilateral_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNewTarget_Lcom_microblink_geometry_Quadrilateral_);
			return cb_setNewTarget_Lcom_microblink_geometry_Quadrilateral_;
		}

		static void n_SetNewTarget_Lcom_microblink_geometry_Quadrilateral_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.Viewfinder.OcrLineViewfinder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.OcrLineViewfinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNewTarget (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNewTarget_Lcom_microblink_geometry_Quadrilateral_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='OcrLineViewfinder']/method[@name='setNewTarget' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Quadrilateral']]"
		[Register ("setNewTarget", "(Lcom/microblink/geometry/Quadrilateral;)V", "GetSetNewTarget_Lcom_microblink_geometry_Quadrilateral_Handler")]
		public virtual unsafe void SetNewTarget (global::Com.Microblink.Geometry.Quadrilateral p0)
		{
			if (id_setNewTarget_Lcom_microblink_geometry_Quadrilateral_ == IntPtr.Zero)
				id_setNewTarget_Lcom_microblink_geometry_Quadrilateral_ = JNIEnv.GetMethodID (class_ref, "setNewTarget", "(Lcom/microblink/geometry/Quadrilateral;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNewTarget_Lcom_microblink_geometry_Quadrilateral_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewTarget", "(Lcom/microblink/geometry/Quadrilateral;)V"), __args);
			} finally {
			}
		}

	}
}
