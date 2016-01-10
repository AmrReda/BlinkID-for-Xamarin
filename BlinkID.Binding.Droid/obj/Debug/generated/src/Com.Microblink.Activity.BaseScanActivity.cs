using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']"
	[global::Android.Runtime.Register ("com/microblink/activity/BaseScanActivity", DoNotGenerateAcw=true)]
	public abstract partial class BaseScanActivity : global::Android.App.Activity, global::Com.Microblink.Metadata.IMetadataListener, global::Com.Microblink.View.ICameraEventsListener, global::Com.Microblink.View.IOnSizeChangedListener, global::Com.Microblink.View.IOrientationAllowedListener, global::Com.Microblink.View.Recognition.IScanResultListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_ALLOW_PINCH_TO_ZOOM']"
		[Register ("EXTRAS_ALLOW_PINCH_TO_ZOOM")]
		public const string ExtrasAllowPinchToZoom = (string) "EXTRAS_ALLOW_PINCH_TO_ZOOM";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_BEEP_RESOURCE']"
		[Register ("EXTRAS_BEEP_RESOURCE")]
		public const string ExtrasBeepResource = (string) "EXTRAS_BEEP_RESOURCE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_CAMERA_ASPECT_MODE']"
		[Register ("EXTRAS_CAMERA_ASPECT_MODE")]
		public const string ExtrasCameraAspectMode = (string) "EXTRAS_CAMERA_ASPECT_MODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_CAMERA_TYPE']"
		[Register ("EXTRAS_CAMERA_TYPE")]
		public const string ExtrasCameraType = (string) "EXTRAS_CAMERA_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_CAMERA_VIDEO_PRESET']"
		[Register ("EXTRAS_CAMERA_VIDEO_PRESET")]
		public const string ExtrasCameraVideoPreset = (string) "EXTRAS_CAMERA_VIDEO_PRESET";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_HELP_INTENT']"
		[Register ("EXTRAS_HELP_INTENT")]
		public const string ExtrasHelpIntent = (string) "EXTRAS_HELP_INTENT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_IMAGE_LISTENER']"
		[Register ("EXTRAS_IMAGE_LISTENER")]
		public const string ExtrasImageListener = (string) "EXTRAS_IMAGE_LISTENER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_LICENSEE']"
		[Register ("EXTRAS_LICENSEE")]
		public const string ExtrasLicensee = (string) "EXTRAS_LICENSEE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_LICENSE_KEY']"
		[Register ("EXTRAS_LICENSE_KEY")]
		public const string ExtrasLicenseKey = (string) "EXTRAS_LICENSE_KEY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_OPTIMIZE_CAMERA_FOR_NEAR_SCANNING']"
		[Register ("EXTRAS_OPTIMIZE_CAMERA_FOR_NEAR_SCANNING")]
		public const string ExtrasOptimizeCameraForNearScanning = (string) "EXTRAS_OPTIMIZE_CAMERA_FOR_NEAR_SCANNING";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_RECOGNITION_RESULTS']"
		[Register ("EXTRAS_RECOGNITION_RESULTS")]
		public const string ExtrasRecognitionResults = (string) "EXTRAS_RECOGNITION_RESULTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_RECOGNITION_SETTINGS']"
		[Register ("EXTRAS_RECOGNITION_SETTINGS")]
		public const string ExtrasRecognitionSettings = (string) "EXTRAS_RECOGNITION_SETTINGS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_ROI']"
		[Register ("EXTRAS_ROI")]
		public const string ExtrasRoi = (string) "EXTRAS_ROI";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_ROTATE_ROI']"
		[Register ("EXTRAS_ROTATE_ROI")]
		public const string ExtrasRotateRoi = (string) "EXTRAS_ROTATE_ROI";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_SHOW_FOCUS_RECTANGLE']"
		[Register ("EXTRAS_SHOW_FOCUS_RECTANGLE")]
		public const string ExtrasShowFocusRectangle = (string) "EXTRAS_SHOW_FOCUS_RECTANGLE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_SPLASH_SCREEN_LAYOUT_RESOURCE']"
		[Register ("EXTRAS_SPLASH_SCREEN_LAYOUT_RESOURCE")]
		public const string ExtrasSplashScreenLayoutResource = (string) "EXTRAS_SPLASH_SCREEN_LAYOUT_RESOURCE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='EXTRAS_USE_LEGACY_CAMERA_API']"
		[Register ("EXTRAS_USE_LEGACY_CAMERA_API")]
		public const string ExtrasUseLegacyCameraApi = (string) "EXTRAS_USE_LEGACY_CAMERA_API";

		static IntPtr mHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/field[@name='mHandler']"
		[Register ("mHandler")]
		protected global::Android.OS.Handler MHandler {
			get {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity.ActivityState']"
		[global::Android.Runtime.Register ("com/microblink/activity/BaseScanActivity$ActivityState", DoNotGenerateAcw=true)]
		public sealed partial class ActivityState : global::Java.Lang.Enum {


			static IntPtr CREATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity.ActivityState']/field[@name='CREATED']"
			[Register ("CREATED")]
			public static global::Com.Microblink.Activity.BaseScanActivity.ActivityState Created {
				get {
					if (CREATED_jfieldId == IntPtr.Zero)
						CREATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED", "Lcom/microblink/activity/BaseScanActivity$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DESTROYED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity.ActivityState']/field[@name='DESTROYED']"
			[Register ("DESTROYED")]
			public static global::Com.Microblink.Activity.BaseScanActivity.ActivityState Destroyed {
				get {
					if (DESTROYED_jfieldId == IntPtr.Zero)
						DESTROYED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DESTROYED", "Lcom/microblink/activity/BaseScanActivity$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DESTROYED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RESUMED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity.ActivityState']/field[@name='RESUMED']"
			[Register ("RESUMED")]
			public static global::Com.Microblink.Activity.BaseScanActivity.ActivityState Resumed {
				get {
					if (RESUMED_jfieldId == IntPtr.Zero)
						RESUMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESUMED", "Lcom/microblink/activity/BaseScanActivity$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESUMED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity.ActivityState']/field[@name='STARTED']"
			[Register ("STARTED")]
			public static global::Com.Microblink.Activity.BaseScanActivity.ActivityState Started {
				get {
					if (STARTED_jfieldId == IntPtr.Zero)
						STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/microblink/activity/BaseScanActivity$ActivityState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity.ActivityState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/activity/BaseScanActivity$ActivityState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ActivityState); }
			}

			internal ActivityState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/activity/BaseScanActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseScanActivity); }
		}

		protected BaseScanActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/constructor[@name='BaseScanActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseScanActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseScanActivity)) {
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

		static IntPtr id_IlIllIlIIl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='IlIllIlIIl' and count(parameter)=0]"
		[Register ("IlIllIlIIl", "()V", "")]
		protected unsafe void IlIllIlIIl ()
		{
			if (id_IlIllIlIIl == IntPtr.Zero)
				id_IlIllIlIIl = JNIEnv.GetMethodID (class_ref, "IlIllIlIIl", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_IlIllIlIIl);
			} finally {
			}
		}

		static IntPtr id_IlIllIlIIl_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='IlIllIlIIl' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("IlIllIlIIl", "(Ljava/lang/CharSequence;)V", "")]
		protected unsafe void IlIllIlIIl (global::Java.Lang.ICharSequence p0)
		{
			if (id_IlIllIlIIl_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_IlIllIlIIl_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "IlIllIlIIl", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_IlIllIlIIl_Ljava_lang_CharSequence_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		protected void IlIllIlIIl (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			IlIllIlIIl (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static IntPtr id_IllIIIllII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='IllIIIllII' and count(parameter)=0]"
		[Register ("IllIIIllII", "()V", "")]
		protected unsafe void IllIIIllII ()
		{
			if (id_IllIIIllII == IntPtr.Zero)
				id_IllIIIllII = JNIEnv.GetMethodID (class_ref, "IllIIIllII", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_IllIIIllII);
			} finally {
			}
		}

		static Delegate cb_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_;
#pragma warning disable 0169
		static Delegate GetIsOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_Handler ()
		{
			if (cb_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ == null)
				cb_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_);
			return cb_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_;
		}

		static bool n_IsOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Orientation.Orientation p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsOrientationAllowed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='isOrientationAllowed' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
		[Register ("isOrientationAllowed", "(Lcom/microblink/hardware/orientation/Orientation;)Z", "GetIsOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_Handler")]
		public virtual unsafe bool IsOrientationAllowed (global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			if (id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
				id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "isOrientationAllowed", "(Lcom/microblink/hardware/orientation/Orientation;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOrientationAllowed", "(Lcom/microblink/hardware/orientation/Orientation;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_;
#pragma warning disable 0169
		static Delegate GetLlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Handler ()
		{
			if (cb_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_ == null)
				cb_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_);
			return cb_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_;
		}

		static IntPtr n_LlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.Recognition.RecognizerView p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LlIIlIlIIl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='llIIlIlIIl' and count(parameter)=1 and parameter[1][@type='com.microblink.view.recognition.RecognizerView']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;)Lcom/microblink/view/viewfinder/quadview/QuadViewManager;", "GetLlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Handler")]
		protected virtual unsafe global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager LlIIlIlIIl (global::Com.Microblink.View.Recognition.RecognizerView p0)
		{
			if (id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_ == IntPtr.Zero)
				id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_ = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;)Lcom/microblink/view/viewfinder/quadview/QuadViewManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (JNIEnv.CallObjectMethod  (Handle, id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;)Lcom/microblink/view/viewfinder/quadview/QuadViewManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetLlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_Handler ()
		{
			if (cb_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_ == null)
				cb_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_);
			return cb_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_;
		}

		static void n_LlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.Recognition.RecognizerView p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LlIIlIlIIl (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='llIIlIlIIl' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.RecognizerView'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;Landroid/os/Bundle;)V", "GetLlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_Handler")]
		protected abstract void LlIIlIlIIl (global::Com.Microblink.View.Recognition.RecognizerView p0, global::Android.OS.Bundle p1);

		static IntPtr id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='llIIlIlIIl' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.RecognizerView'] and parameter[2][@type='int']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;I)V", "")]
		protected unsafe void LlIIlIlIIl (global::Com.Microblink.View.Recognition.RecognizerView p0, int p1)
		{
			if (id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_I == IntPtr.Zero)
				id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_I = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_I, __args);
			} finally {
			}
		}

		static Delegate cb_onAutofocusFailed;
#pragma warning disable 0169
		static Delegate GetOnAutofocusFailedHandler ()
		{
			if (cb_onAutofocusFailed == null)
				cb_onAutofocusFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAutofocusFailed);
			return cb_onAutofocusFailed;
		}

		static void n_OnAutofocusFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAutofocusFailed ();
		}
#pragma warning restore 0169

		static IntPtr id_onAutofocusFailed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onAutofocusFailed' and count(parameter)=0]"
		[Register ("onAutofocusFailed", "()V", "GetOnAutofocusFailedHandler")]
		public virtual unsafe void OnAutofocusFailed ()
		{
			if (id_onAutofocusFailed == IntPtr.Zero)
				id_onAutofocusFailed = JNIEnv.GetMethodID (class_ref, "onAutofocusFailed", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAutofocusFailed);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAutofocusFailed", "()V"));
			} finally {
			}
		}

		static Delegate cb_onAutofocusStarted_arrayLandroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetOnAutofocusStarted_arrayLandroid_graphics_Rect_Handler ()
		{
			if (cb_onAutofocusStarted_arrayLandroid_graphics_Rect_ == null)
				cb_onAutofocusStarted_arrayLandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAutofocusStarted_arrayLandroid_graphics_Rect_);
			return cb_onAutofocusStarted_arrayLandroid_graphics_Rect_;
		}

		static void n_OnAutofocusStarted_arrayLandroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect[] p0 = (global::Android.Graphics.Rect[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.Rect));
			__this.OnAutofocusStarted (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAutofocusStarted_arrayLandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onAutofocusStarted' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect[]']]"
		[Register ("onAutofocusStarted", "([Landroid/graphics/Rect;)V", "GetOnAutofocusStarted_arrayLandroid_graphics_Rect_Handler")]
		public virtual unsafe void OnAutofocusStarted (global::Android.Graphics.Rect[] p0)
		{
			if (id_onAutofocusStarted_arrayLandroid_graphics_Rect_ == IntPtr.Zero)
				id_onAutofocusStarted_arrayLandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onAutofocusStarted", "([Landroid/graphics/Rect;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAutofocusStarted_arrayLandroid_graphics_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAutofocusStarted", "([Landroid/graphics/Rect;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onAutofocusStopped_arrayLandroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetOnAutofocusStopped_arrayLandroid_graphics_Rect_Handler ()
		{
			if (cb_onAutofocusStopped_arrayLandroid_graphics_Rect_ == null)
				cb_onAutofocusStopped_arrayLandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAutofocusStopped_arrayLandroid_graphics_Rect_);
			return cb_onAutofocusStopped_arrayLandroid_graphics_Rect_;
		}

		static void n_OnAutofocusStopped_arrayLandroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect[] p0 = (global::Android.Graphics.Rect[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.Rect));
			__this.OnAutofocusStopped (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAutofocusStopped_arrayLandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onAutofocusStopped' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect[]']]"
		[Register ("onAutofocusStopped", "([Landroid/graphics/Rect;)V", "GetOnAutofocusStopped_arrayLandroid_graphics_Rect_Handler")]
		public virtual unsafe void OnAutofocusStopped (global::Android.Graphics.Rect[] p0)
		{
			if (id_onAutofocusStopped_arrayLandroid_graphics_Rect_ == IntPtr.Zero)
				id_onAutofocusStopped_arrayLandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onAutofocusStopped", "([Landroid/graphics/Rect;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAutofocusStopped_arrayLandroid_graphics_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAutofocusStopped", "([Landroid/graphics/Rect;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onCameraPermissionDenied;
#pragma warning disable 0169
		static Delegate GetOnCameraPermissionDeniedHandler ()
		{
			if (cb_onCameraPermissionDenied == null)
				cb_onCameraPermissionDenied = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraPermissionDenied);
			return cb_onCameraPermissionDenied;
		}

		static void n_OnCameraPermissionDenied (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraPermissionDenied ();
		}
#pragma warning restore 0169

		static IntPtr id_onCameraPermissionDenied;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onCameraPermissionDenied' and count(parameter)=0]"
		[Register ("onCameraPermissionDenied", "()V", "GetOnCameraPermissionDeniedHandler")]
		public virtual unsafe void OnCameraPermissionDenied ()
		{
			if (id_onCameraPermissionDenied == IntPtr.Zero)
				id_onCameraPermissionDenied = JNIEnv.GetMethodID (class_ref, "onCameraPermissionDenied", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCameraPermissionDenied);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraPermissionDenied", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCameraPreviewStarted;
#pragma warning disable 0169
		static Delegate GetOnCameraPreviewStartedHandler ()
		{
			if (cb_onCameraPreviewStarted == null)
				cb_onCameraPreviewStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraPreviewStarted);
			return cb_onCameraPreviewStarted;
		}

		static void n_OnCameraPreviewStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraPreviewStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_onCameraPreviewStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onCameraPreviewStarted' and count(parameter)=0]"
		[Register ("onCameraPreviewStarted", "()V", "GetOnCameraPreviewStartedHandler")]
		public virtual unsafe void OnCameraPreviewStarted ()
		{
			if (id_onCameraPreviewStarted == IntPtr.Zero)
				id_onCameraPreviewStarted = JNIEnv.GetMethodID (class_ref, "onCameraPreviewStarted", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCameraPreviewStarted);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraPreviewStarted", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCameraPreviewStopped;
#pragma warning disable 0169
		static Delegate GetOnCameraPreviewStoppedHandler ()
		{
			if (cb_onCameraPreviewStopped == null)
				cb_onCameraPreviewStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraPreviewStopped);
			return cb_onCameraPreviewStopped;
		}

		static void n_OnCameraPreviewStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraPreviewStopped ();
		}
#pragma warning restore 0169

		static IntPtr id_onCameraPreviewStopped;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onCameraPreviewStopped' and count(parameter)=0]"
		[Register ("onCameraPreviewStopped", "()V", "GetOnCameraPreviewStoppedHandler")]
		public virtual unsafe void OnCameraPreviewStopped ()
		{
			if (id_onCameraPreviewStopped == IntPtr.Zero)
				id_onCameraPreviewStopped = JNIEnv.GetMethodID (class_ref, "onCameraPreviewStopped", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCameraPreviewStopped);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraPreviewStopped", "()V"));
			} finally {
			}
		}

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "")]
		protected override sealed unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		protected override sealed unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
			} finally {
			}
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onError_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMetadataAvailable_Lcom_microblink_metadata_Metadata_;
#pragma warning disable 0169
		static Delegate GetOnMetadataAvailable_Lcom_microblink_metadata_Metadata_Handler ()
		{
			if (cb_onMetadataAvailable_Lcom_microblink_metadata_Metadata_ == null)
				cb_onMetadataAvailable_Lcom_microblink_metadata_Metadata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMetadataAvailable_Lcom_microblink_metadata_Metadata_);
			return cb_onMetadataAvailable_Lcom_microblink_metadata_Metadata_;
		}

		static void n_OnMetadataAvailable_Lcom_microblink_metadata_Metadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Metadata.Metadata p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.Metadata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMetadataAvailable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMetadataAvailable_Lcom_microblink_metadata_Metadata_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onMetadataAvailable' and count(parameter)=1 and parameter[1][@type='com.microblink.metadata.Metadata']]"
		[Register ("onMetadataAvailable", "(Lcom/microblink/metadata/Metadata;)V", "GetOnMetadataAvailable_Lcom_microblink_metadata_Metadata_Handler")]
		public virtual unsafe void OnMetadataAvailable (global::Com.Microblink.Metadata.Metadata p0)
		{
			if (id_onMetadataAvailable_Lcom_microblink_metadata_Metadata_ == IntPtr.Zero)
				id_onMetadataAvailable_Lcom_microblink_metadata_Metadata_ = JNIEnv.GetMethodID (class_ref, "onMetadataAvailable", "(Lcom/microblink/metadata/Metadata;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onMetadataAvailable_Lcom_microblink_metadata_Metadata_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMetadataAvailable", "(Lcom/microblink/metadata/Metadata;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "")]
		protected override sealed unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onPause);
			} finally {
			}
		}

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "")]
		protected override sealed unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onResume);
			} finally {
			}
		}

		static Delegate cb_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_;
#pragma warning disable 0169
		static Delegate GetOnScanningDone_Lcom_microblink_recognizers_RecognitionResults_Handler ()
		{
			if (cb_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_ == null)
				cb_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnScanningDone_Lcom_microblink_recognizers_RecognitionResults_);
			return cb_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_;
		}

		static void n_OnScanningDone_Lcom_microblink_recognizers_RecognitionResults_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.RecognitionResults p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.RecognitionResults> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScanningDone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onScanningDone' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.RecognitionResults']]"
		[Register ("onScanningDone", "(Lcom/microblink/recognizers/RecognitionResults;)V", "GetOnScanningDone_Lcom_microblink_recognizers_RecognitionResults_Handler")]
		public virtual unsafe void OnScanningDone (global::Com.Microblink.Recognizers.RecognitionResults p0)
		{
			if (id_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_ == IntPtr.Zero)
				id_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_ = JNIEnv.GetMethodID (class_ref, "onScanningDone", "(Lcom/microblink/recognizers/RecognitionResults;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScanningDone", "(Lcom/microblink/recognizers/RecognitionResults;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSizeChanged_II;
#pragma warning disable 0169
		static Delegate GetOnSizeChanged_IIHandler ()
		{
			if (cb_onSizeChanged_II == null)
				cb_onSizeChanged_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnSizeChanged_II);
			return cb_onSizeChanged_II;
		}

		static void n_OnSizeChanged_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Microblink.Activity.BaseScanActivity __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.BaseScanActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSizeChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSizeChanged_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onSizeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSizeChanged", "(II)V", "GetOnSizeChanged_IIHandler")]
		public virtual unsafe void OnSizeChanged (int p0, int p1)
		{
			if (id_onSizeChanged_II == IntPtr.Zero)
				id_onSizeChanged_II = JNIEnv.GetMethodID (class_ref, "onSizeChanged", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSizeChanged_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSizeChanged", "(II)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "")]
		protected override sealed unsafe void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onStart);
			} finally {
			}
		}

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "")]
		protected override sealed unsafe void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onStop);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/microblink/activity/BaseScanActivity", DoNotGenerateAcw=true)]
	internal partial class BaseScanActivityInvoker : BaseScanActivity {

		public BaseScanActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseScanActivityInvoker); }
		}

		static IntPtr id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='BaseScanActivity']/method[@name='llIIlIlIIl' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.RecognizerView'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;Landroid/os/Bundle;)V", "GetLlIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_Handler")]
		protected override unsafe void LlIIlIlIIl (global::Com.Microblink.View.Recognition.RecognizerView p0, global::Android.OS.Bundle p1)
		{
			if (id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_ == IntPtr.Zero)
				id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}

}
