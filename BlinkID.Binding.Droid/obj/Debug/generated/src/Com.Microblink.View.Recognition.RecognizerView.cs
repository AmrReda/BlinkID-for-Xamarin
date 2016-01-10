using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Recognition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']"
	[global::Android.Runtime.Register ("com/microblink/view/recognition/RecognizerView", DoNotGenerateAcw=true)]
	public partial class RecognizerView : global::Com.Microblink.View.BaseCameraView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView.llIIlIlIIl']"
		[global::Android.Runtime.Register ("com/microblink/view/recognition/RecognizerView$llIIlIlIIl", DoNotGenerateAcw=true)]
		public partial class LlIIlIlIIl : global::Java.Lang.Object, global::Com.Microblink.Recognition.NativeRecognizerWrapper.IIlIllIlIIl, global::Com.Microblink.Recognition.NativeRecognizerWrapper.ILlIIlIlIIl {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/recognition/RecognizerView$llIIlIlIIl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LlIIlIlIIl); }
			}

			protected LlIIlIlIIl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView.llIIlIlIIl']/method[@name='onRecognitionDone' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.BaseRecognitionResult[]']]"
			[Register ("onRecognitionDone", "([Lcom/microblink/recognizers/BaseRecognitionResult;)V", "")]
			public unsafe void OnRecognitionDone (global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0)
			{
				if (id_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_ == IntPtr.Zero)
					id_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_ = JNIEnv.GetMethodID (class_ref, "onRecognitionDone", "([Lcom/microblink/recognizers/BaseRecognitionResult;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod  (Handle, id_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView.llIIlIlIIl']/method[@name='onRecognitionDoneWithTimeout' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.BaseRecognitionResult[]']]"
			[Register ("onRecognitionDoneWithTimeout", "([Lcom/microblink/recognizers/BaseRecognitionResult;)V", "")]
			public unsafe void OnRecognitionDoneWithTimeout (global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0)
			{
				if (id_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_ == IntPtr.Zero)
					id_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_ = JNIEnv.GetMethodID (class_ref, "onRecognitionDoneWithTimeout", "([Lcom/microblink/recognizers/BaseRecognitionResult;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod  (Handle, id_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_onRecognizerError_Lcom_microblink_recognition_RecognizerError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView.llIIlIlIIl']/method[@name='onRecognizerError' and count(parameter)=1 and parameter[1][@type='com.microblink.recognition.RecognizerError']]"
			[Register ("onRecognizerError", "(Lcom/microblink/recognition/RecognizerError;)V", "")]
			public unsafe void OnRecognizerError (global::Com.Microblink.Recognition.RecognizerError p0)
			{
				if (id_onRecognizerError_Lcom_microblink_recognition_RecognizerError_ == IntPtr.Zero)
					id_onRecognizerError_Lcom_microblink_recognition_RecognizerError_ = JNIEnv.GetMethodID (class_ref, "onRecognizerError", "(Lcom/microblink/recognition/RecognizerError;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod  (Handle, id_onRecognizerError_Lcom_microblink_recognition_RecognizerError_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/recognition/RecognizerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognizerView); }
		}

		protected RecognizerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/constructor[@name='RecognizerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe RecognizerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RecognizerView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/constructor[@name='RecognizerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RecognizerView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RecognizerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_isRecognitionPaused;
		public unsafe bool IsRecognitionPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='isRecognitionPaused' and count(parameter)=0]"
			[Register ("isRecognitionPaused", "()Z", "GetIsRecognitionPausedHandler")]
			get {
				if (id_isRecognitionPaused == IntPtr.Zero)
					id_isRecognitionPaused = JNIEnv.GetMethodID (class_ref, "isRecognitionPaused", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isRecognitionPaused);
				} finally {
				}
			}
		}

		static IntPtr id_getNativeLibraryVersionString;
		public static unsafe string NativeLibraryVersionString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='getNativeLibraryVersionString' and count(parameter)=0]"
			[Register ("getNativeLibraryVersionString", "()Ljava/lang/String;", "GetGetNativeLibraryVersionStringHandler")]
			get {
				if (id_getNativeLibraryVersionString == IntPtr.Zero)
					id_getNativeLibraryVersionString = JNIEnv.GetStaticMethodID (class_ref, "getNativeLibraryVersionString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNativeLibraryVersionString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRecognitionSettings;
#pragma warning disable 0169
		static Delegate GetGetRecognitionSettingsHandler ()
		{
			if (cb_getRecognitionSettings == null)
				cb_getRecognitionSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecognitionSettings);
			return cb_getRecognitionSettings;
		}

		static IntPtr n_GetRecognitionSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RecognitionSettings);
		}
#pragma warning restore 0169

		static Delegate cb_setRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_;
#pragma warning disable 0169
		static Delegate GetSetRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_Handler ()
		{
			if (cb_setRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_ == null)
				cb_setRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_);
			return cb_setRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_;
		}

		static void n_SetRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecognitionSettings = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRecognitionSettings;
		static IntPtr id_setRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_;
		public virtual unsafe global::Com.Microblink.Recognizers.Settings.RecognitionSettings RecognitionSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='getRecognitionSettings' and count(parameter)=0]"
			[Register ("getRecognitionSettings", "()Lcom/microblink/recognizers/settings/RecognitionSettings;", "GetGetRecognitionSettingsHandler")]
			get {
				if (id_getRecognitionSettings == IntPtr.Zero)
					id_getRecognitionSettings = JNIEnv.GetMethodID (class_ref, "getRecognitionSettings", "()Lcom/microblink/recognizers/settings/RecognitionSettings;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (JNIEnv.CallObjectMethod  (Handle, id_getRecognitionSettings), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecognitionSettings", "()Lcom/microblink/recognizers/settings/RecognitionSettings;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='setRecognitionSettings' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.settings.RecognitionSettings']]"
			[Register ("setRecognitionSettings", "(Lcom/microblink/recognizers/settings/RecognitionSettings;)V", "GetSetRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_Handler")]
			set {
				if (id_setRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_ == IntPtr.Zero)
					id_setRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_ = JNIEnv.GetMethodID (class_ref, "setRecognitionSettings", "(Lcom/microblink/recognizers/settings/RecognitionSettings;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRecognitionSettings_Lcom_microblink_recognizers_settings_RecognitionSettings_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecognitionSettings", "(Lcom/microblink/recognizers/settings/RecognitionSettings;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScanResultListener;
#pragma warning disable 0169
		static Delegate GetGetScanResultListenerHandler ()
		{
			if (cb_getScanResultListener == null)
				cb_getScanResultListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScanResultListener);
			return cb_getScanResultListener;
		}

		static IntPtr n_GetScanResultListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScanResultListener);
		}
#pragma warning restore 0169

		static Delegate cb_setScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_;
#pragma warning disable 0169
		static Delegate GetSetScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_Handler ()
		{
			if (cb_setScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_ == null)
				cb_setScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_);
			return cb_setScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_;
		}

		static void n_SetScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.Recognition.IScanResultListener p0 = (global::Com.Microblink.View.Recognition.IScanResultListener)global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.IScanResultListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScanResultListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScanResultListener;
		static IntPtr id_setScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_;
		public virtual unsafe global::Com.Microblink.View.Recognition.IScanResultListener ScanResultListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='getScanResultListener' and count(parameter)=0]"
			[Register ("getScanResultListener", "()Lcom/microblink/view/recognition/ScanResultListener;", "GetGetScanResultListenerHandler")]
			get {
				if (id_getScanResultListener == IntPtr.Zero)
					id_getScanResultListener = JNIEnv.GetMethodID (class_ref, "getScanResultListener", "()Lcom/microblink/view/recognition/ScanResultListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.IScanResultListener> (JNIEnv.CallObjectMethod  (Handle, id_getScanResultListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.IScanResultListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScanResultListener", "()Lcom/microblink/view/recognition/ScanResultListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='setScanResultListener' and count(parameter)=1 and parameter[1][@type='com.microblink.view.recognition.ScanResultListener']]"
			[Register ("setScanResultListener", "(Lcom/microblink/view/recognition/ScanResultListener;)V", "GetSetScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_Handler")]
			set {
				if (id_setScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_ == IntPtr.Zero)
					id_setScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_ = JNIEnv.GetMethodID (class_ref, "setScanResultListener", "(Lcom/microblink/view/recognition/ScanResultListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScanResultListener_Lcom_microblink_view_recognition_ScanResultListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanResultListener", "(Lcom/microblink/view/recognition/ScanResultListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScanningRegion;
#pragma warning disable 0169
		static Delegate GetGetScanningRegionHandler ()
		{
			if (cb_getScanningRegion == null)
				cb_getScanningRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScanningRegion);
			return cb_getScanningRegion;
		}

		static IntPtr n_GetScanningRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScanningRegion);
		}
#pragma warning restore 0169

		static IntPtr id_getScanningRegion;
		public virtual unsafe global::Com.Microblink.Geometry.Rectangle ScanningRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='getScanningRegion' and count(parameter)=0]"
			[Register ("getScanningRegion", "()Lcom/microblink/geometry/Rectangle;", "GetGetScanningRegionHandler")]
			get {
				if (id_getScanningRegion == IntPtr.Zero)
					id_getScanningRegion = JNIEnv.GetMethodID (class_ref, "getScanningRegion", "()Lcom/microblink/geometry/Rectangle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallObjectMethod  (Handle, id_getScanningRegion), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScanningRegion", "()Lcom/microblink/geometry/Rectangle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_changeConfigurationInternal_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='changeConfigurationInternal' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("changeConfigurationInternal", "(Landroid/content/res/Configuration;)V", "")]
		protected unsafe void ChangeConfigurationInternal (global::Android.Content.Res.Configuration p0)
		{
			if (id_changeConfigurationInternal_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_changeConfigurationInternal_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "changeConfigurationInternal", "(Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_changeConfigurationInternal_Landroid_content_res_Configuration_, __args);
			} finally {
			}
		}

		static IntPtr id_createOrientationChangeListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='createOrientationChangeListener' and count(parameter)=0]"
		[Register ("createOrientationChangeListener", "()Lcom/microblink/hardware/orientation/OrientationChangeListener;", "")]
		protected unsafe global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener CreateOrientationChangeListener ()
		{
			if (id_createOrientationChangeListener == IntPtr.Zero)
				id_createOrientationChangeListener = JNIEnv.GetMethodID (class_ref, "createOrientationChangeListener", "()Lcom/microblink/hardware/orientation/OrientationChangeListener;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener> (JNIEnv.CallObjectMethod  (Handle, id_createOrientationChangeListener), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public override sealed unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_destroy);
			} finally {
			}
		}

		static IntPtr id_onCameraPreviewStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='onCameraPreviewStarted' and count(parameter)=0]"
		[Register ("onCameraPreviewStarted", "()V", "")]
		protected unsafe void OnCameraPreviewStarted ()
		{
			if (id_onCameraPreviewStarted == IntPtr.Zero)
				id_onCameraPreviewStarted = JNIEnv.GetMethodID (class_ref, "onCameraPreviewStarted", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onCameraPreviewStarted);
			} finally {
			}
		}

		static IntPtr id_onCameraPreviewStopped;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='onCameraPreviewStopped' and count(parameter)=0]"
		[Register ("onCameraPreviewStopped", "()V", "")]
		protected unsafe void OnCameraPreviewStopped ()
		{
			if (id_onCameraPreviewStopped == IntPtr.Zero)
				id_onCameraPreviewStopped = JNIEnv.GetMethodID (class_ref, "onCameraPreviewStopped", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onCameraPreviewStopped);
			} finally {
			}
		}

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "")]
		public override sealed unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_pause);
			} finally {
			}
		}

		static IntPtr id_pauseScanning;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='pauseScanning' and count(parameter)=0]"
		[Register ("pauseScanning", "()V", "")]
		public unsafe void PauseScanning ()
		{
			if (id_pauseScanning == IntPtr.Zero)
				id_pauseScanning = JNIEnv.GetMethodID (class_ref, "pauseScanning", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_pauseScanning);
			} finally {
			}
		}

		static Delegate cb_reconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_;
#pragma warning disable 0169
		static Delegate GetReconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_Handler ()
		{
			if (cb_reconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_ == null)
				cb_reconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_);
			return cb_reconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_;
		}

		static void n_ReconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReconfigureRecognizers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='reconfigureRecognizers' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.settings.RecognitionSettings']]"
		[Register ("reconfigureRecognizers", "(Lcom/microblink/recognizers/settings/RecognitionSettings;)V", "GetReconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_Handler")]
		public virtual unsafe void ReconfigureRecognizers (global::Com.Microblink.Recognizers.Settings.RecognitionSettings p0)
		{
			if (id_reconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_ == IntPtr.Zero)
				id_reconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_ = JNIEnv.GetMethodID (class_ref, "reconfigureRecognizers", "(Lcom/microblink/recognizers/settings/RecognitionSettings;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reconfigureRecognizers_Lcom_microblink_recognizers_settings_RecognitionSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reconfigureRecognizers", "(Lcom/microblink/recognizers/settings/RecognitionSettings;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_requireAutofocusFeature;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='requireAutofocusFeature' and count(parameter)=0]"
		[Register ("requireAutofocusFeature", "()Z", "")]
		public override sealed unsafe bool RequireAutofocusFeature ()
		{
			if (id_requireAutofocusFeature == IntPtr.Zero)
				id_requireAutofocusFeature = JNIEnv.GetMethodID (class_ref, "requireAutofocusFeature", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_requireAutofocusFeature);
			} finally {
			}
		}

		static IntPtr id_resetRecognitionState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='resetRecognitionState' and count(parameter)=0]"
		[Register ("resetRecognitionState", "()V", "")]
		public unsafe void ResetRecognitionState ()
		{
			if (id_resetRecognitionState == IntPtr.Zero)
				id_resetRecognitionState = JNIEnv.GetMethodID (class_ref, "resetRecognitionState", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_resetRecognitionState);
			} finally {
			}
		}

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "")]
		public override sealed unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_resume);
			} finally {
			}
		}

		static IntPtr id_resumeScanning_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='resumeScanning' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("resumeScanning", "(Z)V", "")]
		public unsafe void ResumeScanning (bool p0)
		{
			if (id_resumeScanning_Z == IntPtr.Zero)
				id_resumeScanning_Z = JNIEnv.GetMethodID (class_ref, "resumeScanning", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_resumeScanning_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setInitialScanningPaused_Z;
#pragma warning disable 0169
		static Delegate GetSetInitialScanningPaused_ZHandler ()
		{
			if (cb_setInitialScanningPaused_Z == null)
				cb_setInitialScanningPaused_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInitialScanningPaused_Z);
			return cb_setInitialScanningPaused_Z;
		}

		static void n_SetInitialScanningPaused_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInitialScanningPaused (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInitialScanningPaused_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='setInitialScanningPaused' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInitialScanningPaused", "(Z)V", "GetSetInitialScanningPaused_ZHandler")]
		public virtual unsafe void SetInitialScanningPaused (bool p0)
		{
			if (id_setInitialScanningPaused_Z == IntPtr.Zero)
				id_setInitialScanningPaused_Z = JNIEnv.GetMethodID (class_ref, "setInitialScanningPaused", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInitialScanningPaused_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialScanningPaused", "(Z)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setLicenseKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='setLicenseKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLicenseKey", "(Ljava/lang/String;)V", "")]
		public unsafe void SetLicenseKey (string p0)
		{
			if (id_setLicenseKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setLicenseKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLicenseKey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_setLicenseKey_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setLicenseKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='setLicenseKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setLicenseKey", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetLicenseKey (string p0, string p1)
		{
			if (id_setLicenseKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setLicenseKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLicenseKey", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_setLicenseKey_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_;
#pragma warning disable 0169
		static Delegate GetSetMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_Handler ()
		{
			if (cb_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ == null)
				cb_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_);
			return cb_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_;
		}

		static void n_SetMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Metadata.IMetadataListener p0 = (global::Com.Microblink.Metadata.IMetadataListener)global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.IMetadataListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Metadata.MetadataSettings p1 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMetadataListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='setMetadataListener' and count(parameter)=2 and parameter[1][@type='com.microblink.metadata.MetadataListener'] and parameter[2][@type='com.microblink.metadata.MetadataSettings']]"
		[Register ("setMetadataListener", "(Lcom/microblink/metadata/MetadataListener;Lcom/microblink/metadata/MetadataSettings;)V", "GetSetMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_Handler")]
		public virtual unsafe void SetMetadataListener (global::Com.Microblink.Metadata.IMetadataListener p0, global::Com.Microblink.Metadata.MetadataSettings p1)
		{
			if (id_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ == IntPtr.Zero)
				id_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ = JNIEnv.GetMethodID (class_ref, "setMetadataListener", "(Lcom/microblink/metadata/MetadataListener;Lcom/microblink/metadata/MetadataSettings;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadataListener", "(Lcom/microblink/metadata/MetadataListener;Lcom/microblink/metadata/MetadataSettings;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setScanningRegion_Lcom_microblink_geometry_Rectangle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='setScanningRegion' and count(parameter)=2 and parameter[1][@type='com.microblink.geometry.Rectangle'] and parameter[2][@type='boolean']]"
		[Register ("setScanningRegion", "(Lcom/microblink/geometry/Rectangle;Z)V", "")]
		public unsafe void SetScanningRegion (global::Com.Microblink.Geometry.Rectangle p0, bool p1)
		{
			if (id_setScanningRegion_Lcom_microblink_geometry_Rectangle_Z == IntPtr.Zero)
				id_setScanningRegion_Lcom_microblink_geometry_Rectangle_Z = JNIEnv.GetMethodID (class_ref, "setScanningRegion", "(Lcom/microblink/geometry/Rectangle;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setScanningRegion_Lcom_microblink_geometry_Rectangle_Z, __args);
			} finally {
			}
		}

		static Delegate cb_shouldRotateScanningRegion;
#pragma warning disable 0169
		static Delegate GetShouldRotateScanningRegionHandler ()
		{
			if (cb_shouldRotateScanningRegion == null)
				cb_shouldRotateScanningRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldRotateScanningRegion);
			return cb_shouldRotateScanningRegion;
		}

		static bool n_ShouldRotateScanningRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.Recognition.RecognizerView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognizerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldRotateScanningRegion ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldRotateScanningRegion;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='shouldRotateScanningRegion' and count(parameter)=0]"
		[Register ("shouldRotateScanningRegion", "()Z", "GetShouldRotateScanningRegionHandler")]
		public virtual unsafe bool ShouldRotateScanningRegion ()
		{
			if (id_shouldRotateScanningRegion == IntPtr.Zero)
				id_shouldRotateScanningRegion = JNIEnv.GetMethodID (class_ref, "shouldRotateScanningRegion", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldRotateScanningRegion);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldRotateScanningRegion", "()Z"));
			} finally {
			}
		}

		static IntPtr id_shouldStartCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='shouldStartCamera' and count(parameter)=0]"
		[Register ("shouldStartCamera", "()Z", "")]
		protected unsafe bool ShouldStartCamera ()
		{
			if (id_shouldStartCamera == IntPtr.Zero)
				id_shouldStartCamera = JNIEnv.GetMethodID (class_ref, "shouldStartCamera", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_shouldStartCamera);
			} finally {
			}
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public override sealed unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_start);
			} finally {
			}
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognizerView']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public override sealed unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_stop);
			} finally {
			}
		}

#region "Event implementation for Com.Microblink.View.Recognition.IScanResultListener"
		public event EventHandler<global::Com.Microblink.View.Recognition.ScanResultEventArgs> ScanResult {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Microblink.View.Recognition.IScanResultListener, global::Com.Microblink.View.Recognition.IScanResultListenerImplementor>(
						ref weak_implementor___SetScanResultListener,
						__CreateIScanResultListenerImplementor,
						__v => ScanResultListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Microblink.View.Recognition.IScanResultListener, global::Com.Microblink.View.Recognition.IScanResultListenerImplementor>(
						ref weak_implementor___SetScanResultListener,
						global::Com.Microblink.View.Recognition.IScanResultListenerImplementor.__IsEmpty,
						__v => ScanResultListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetScanResultListener;

		global::Com.Microblink.View.Recognition.IScanResultListenerImplementor __CreateIScanResultListenerImplementor ()
		{
			return new global::Com.Microblink.View.Recognition.IScanResultListenerImplementor (this);
		}
#endregion
	}
}
