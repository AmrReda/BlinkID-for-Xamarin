using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Viewfinder.Quadview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManager']"
	[global::Android.Runtime.Register ("com/microblink/view/viewfinder/quadview/QuadViewManager", DoNotGenerateAcw=true)]
	public partial class QuadViewManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/viewfinder/quadview/QuadViewManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuadViewManager); }
		}

		protected QuadViewManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManager']/constructor[@name='QuadViewManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QuadViewManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (QuadViewManager)) {
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
			global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimationInProgress;
		}
#pragma warning restore 0169

		static IntPtr id_isAnimationInProgress;
		public virtual unsafe bool IsAnimationInProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManager']/method[@name='isAnimationInProgress' and count(parameter)=0]"
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

		static Delegate cb_animateQuadToDefaultPosition;
#pragma warning disable 0169
		static Delegate GetAnimateQuadToDefaultPositionHandler ()
		{
			if (cb_animateQuadToDefaultPosition == null)
				cb_animateQuadToDefaultPosition = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AnimateQuadToDefaultPosition);
			return cb_animateQuadToDefaultPosition;
		}

		static void n_AnimateQuadToDefaultPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateQuadToDefaultPosition ();
		}
#pragma warning restore 0169

		static IntPtr id_animateQuadToDefaultPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManager']/method[@name='animateQuadToDefaultPosition' and count(parameter)=0]"
		[Register ("animateQuadToDefaultPosition", "()V", "GetAnimateQuadToDefaultPositionHandler")]
		public virtual unsafe void AnimateQuadToDefaultPosition ()
		{
			if (id_animateQuadToDefaultPosition == IntPtr.Zero)
				id_animateQuadToDefaultPosition = JNIEnv.GetMethodID (class_ref, "animateQuadToDefaultPosition", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_animateQuadToDefaultPosition);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateQuadToDefaultPosition", "()V"));
			} finally {
			}
		}

		static Delegate cb_animateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_;
#pragma warning disable 0169
		static Delegate GetAnimateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_Handler ()
		{
			if (cb_animateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_ == null)
				cb_animateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AnimateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_);
			return cb_animateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_;
		}

		static void n_AnimateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.Recognition.DetectionStatus p1 = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AnimateQuadToDetectionPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_animateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManager']/method[@name='animateQuadToDetectionPosition' and count(parameter)=2 and parameter[1][@type='com.microblink.geometry.Quadrilateral'] and parameter[2][@type='com.microblink.view.recognition.DetectionStatus']]"
		[Register ("animateQuadToDetectionPosition", "(Lcom/microblink/geometry/Quadrilateral;Lcom/microblink/view/recognition/DetectionStatus;)V", "GetAnimateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_Handler")]
		public virtual unsafe void AnimateQuadToDetectionPosition (global::Com.Microblink.Geometry.Quadrilateral p0, global::Com.Microblink.View.Recognition.DetectionStatus p1)
		{
			if (id_animateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_ == IntPtr.Zero)
				id_animateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_ = JNIEnv.GetMethodID (class_ref, "animateQuadToDetectionPosition", "(Lcom/microblink/geometry/Quadrilateral;Lcom/microblink/view/recognition/DetectionStatus;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_animateQuadToDetectionPosition_Lcom_microblink_geometry_Quadrilateral_Lcom_microblink_view_recognition_DetectionStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateQuadToDetectionPosition", "(Lcom/microblink/geometry/Quadrilateral;Lcom/microblink/view/recognition/DetectionStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_configurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetConfigurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_configurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_ == null)
				cb_configurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConfigurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_);
			return cb_configurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_;
		}

		static void n_ConfigurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.Recognition.RecognizerView p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConfigurationChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_configurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManager']/method[@name='configurationChanged' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.RecognizerView'] and parameter[2][@type='android.content.res.Configuration']]"
		[Register ("configurationChanged", "(Lcom/microblink/view/recognition/RecognizerView;Landroid/content/res/Configuration;)V", "GetConfigurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void ConfigurationChanged (global::Com.Microblink.View.Recognition.RecognizerView p0, global::Android.Content.Res.Configuration p1)
		{
			if (id_configurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_configurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "configurationChanged", "(Lcom/microblink/view/recognition/RecognizerView;Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_configurationChanged_Lcom_microblink_view_recognition_RecognizerView_Landroid_content_res_Configuration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configurationChanged", "(Lcom/microblink/view/recognition/RecognizerView;Landroid/content/res/Configuration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAnimationDuration_J;
#pragma warning disable 0169
		static Delegate GetSetAnimationDuration_JHandler ()
		{
			if (cb_setAnimationDuration_J == null)
				cb_setAnimationDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAnimationDuration_J);
			return cb_setAnimationDuration_J;
		}

		static void n_SetAnimationDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimationDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManager']/method[@name='setAnimationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAnimationDuration", "(J)V", "GetSetAnimationDuration_JHandler")]
		public virtual unsafe void SetAnimationDuration (long p0)
		{
			if (id_setAnimationDuration_J == IntPtr.Zero)
				id_setAnimationDuration_J = JNIEnv.GetMethodID (class_ref, "setAnimationDuration", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAnimationDuration_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationDuration", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_;
#pragma warning disable 0169
		static Delegate GetSetAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_Handler ()
		{
			if (cb_setAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_ == null)
				cb_setAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_);
			return cb_setAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_;
		}

		static void n_SetAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener p0 = (global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener)global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManager']/method[@name='setAnimationListener' and count(parameter)=1 and parameter[1][@type='com.microblink.view.viewfinder.quadview.QuadViewAnimationListener']]"
		[Register ("setAnimationListener", "(Lcom/microblink/view/viewfinder/quadview/QuadViewAnimationListener;)V", "GetSetAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_Handler")]
		public virtual unsafe void SetAnimationListener (global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener p0)
		{
			if (id_setAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_ == IntPtr.Zero)
				id_setAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_ = JNIEnv.GetMethodID (class_ref, "setAnimationListener", "(Lcom/microblink/view/viewfinder/quadview/QuadViewAnimationListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAnimationListener_Lcom_microblink_view_viewfinder_quadview_QuadViewAnimationListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationListener", "(Lcom/microblink/view/viewfinder/quadview/QuadViewAnimationListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener"
		public event EventHandler AnimationEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener, global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						__CreateIQuadViewAnimationListenerImplementor,
						SetAnimationListener,
						__h => __h.OnAnimationEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener, global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListenerImplementor.__IsEmpty,
						__v => SetAnimationListener (null),
						__h => __h.OnAnimationEndHandler -= value);
			}
		}

		public event EventHandler AnimationStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener, global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						__CreateIQuadViewAnimationListenerImplementor,
						SetAnimationListener,
						__h => __h.OnAnimationStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListener, global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListenerImplementor.__IsEmpty,
						__v => SetAnimationListener (null),
						__h => __h.OnAnimationStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetAnimationListener;

		global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListenerImplementor __CreateIQuadViewAnimationListenerImplementor ()
		{
			return new global::Com.Microblink.View.Viewfinder.Quadview.IQuadViewAnimationListenerImplementor (this);
		}
#endregion
	}
}
