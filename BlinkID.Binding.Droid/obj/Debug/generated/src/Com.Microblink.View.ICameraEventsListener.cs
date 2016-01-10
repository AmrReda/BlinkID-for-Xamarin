using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.view']/interface[@name='CameraEventsListener']"
	[Register ("com/microblink/view/CameraEventsListener", "", "Com.Microblink.View.ICameraEventsListenerInvoker")]
	public partial interface ICameraEventsListener : global::Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/interface[@name='CameraEventsListener']/method[@name='onCameraPermissionDenied' and count(parameter)=0]"
		[Register ("onCameraPermissionDenied", "()V", "GetOnCameraPermissionDeniedHandler:Com.Microblink.View.ICameraEventsListenerInvoker, BlinkID.Binding.Droid")]
		void OnCameraPermissionDenied ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/interface[@name='CameraEventsListener']/method[@name='onCameraPreviewStarted' and count(parameter)=0]"
		[Register ("onCameraPreviewStarted", "()V", "GetOnCameraPreviewStartedHandler:Com.Microblink.View.ICameraEventsListenerInvoker, BlinkID.Binding.Droid")]
		void OnCameraPreviewStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/interface[@name='CameraEventsListener']/method[@name='onCameraPreviewStopped' and count(parameter)=0]"
		[Register ("onCameraPreviewStopped", "()V", "GetOnCameraPreviewStoppedHandler:Com.Microblink.View.ICameraEventsListenerInvoker, BlinkID.Binding.Droid")]
		void OnCameraPreviewStopped ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/interface[@name='CameraEventsListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.Microblink.View.ICameraEventsListenerInvoker, BlinkID.Binding.Droid")]
		void OnError (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("com/microblink/view/CameraEventsListener", DoNotGenerateAcw=true)]
	internal class ICameraEventsListenerInvoker : global::Java.Lang.Object, ICameraEventsListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/view/CameraEventsListener");
		IntPtr class_ref;

		public static ICameraEventsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraEventsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.view.CameraEventsListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraEventsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICameraEventsListenerInvoker); }
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
			global::Com.Microblink.View.ICameraEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraPermissionDenied ();
		}
#pragma warning restore 0169

		IntPtr id_onCameraPermissionDenied;
		public unsafe void OnCameraPermissionDenied ()
		{
			if (id_onCameraPermissionDenied == IntPtr.Zero)
				id_onCameraPermissionDenied = JNIEnv.GetMethodID (class_ref, "onCameraPermissionDenied", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onCameraPermissionDenied);
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
			global::Com.Microblink.View.ICameraEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraPreviewStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onCameraPreviewStarted;
		public unsafe void OnCameraPreviewStarted ()
		{
			if (id_onCameraPreviewStarted == IntPtr.Zero)
				id_onCameraPreviewStarted = JNIEnv.GetMethodID (class_ref, "onCameraPreviewStarted", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onCameraPreviewStarted);
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
			global::Com.Microblink.View.ICameraEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraPreviewStopped ();
		}
#pragma warning restore 0169

		IntPtr id_onCameraPreviewStopped;
		public unsafe void OnCameraPreviewStopped ()
		{
			if (id_onCameraPreviewStopped == IntPtr.Zero)
				id_onCameraPreviewStopped = JNIEnv.GetMethodID (class_ref, "onCameraPreviewStopped", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onCameraPreviewStopped);
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
			global::Com.Microblink.View.ICameraEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onError_Ljava_lang_Throwable_, __args);
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
			global::Com.Microblink.View.ICameraEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAutofocusFailed ();
		}
#pragma warning restore 0169

		IntPtr id_onAutofocusFailed;
		public unsafe void OnAutofocusFailed ()
		{
			if (id_onAutofocusFailed == IntPtr.Zero)
				id_onAutofocusFailed = JNIEnv.GetMethodID (class_ref, "onAutofocusFailed", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onAutofocusFailed);
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
			global::Com.Microblink.View.ICameraEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect[] p0 = (global::Android.Graphics.Rect[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.Rect));
			__this.OnAutofocusStarted (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onAutofocusStarted_arrayLandroid_graphics_Rect_;
		public unsafe void OnAutofocusStarted (global::Android.Graphics.Rect[] p0)
		{
			if (id_onAutofocusStarted_arrayLandroid_graphics_Rect_ == IntPtr.Zero)
				id_onAutofocusStarted_arrayLandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onAutofocusStarted", "([Landroid/graphics/Rect;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onAutofocusStarted_arrayLandroid_graphics_Rect_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Microblink.View.ICameraEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect[] p0 = (global::Android.Graphics.Rect[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.Rect));
			__this.OnAutofocusStopped (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onAutofocusStopped_arrayLandroid_graphics_Rect_;
		public unsafe void OnAutofocusStopped (global::Android.Graphics.Rect[] p0)
		{
			if (id_onAutofocusStopped_arrayLandroid_graphics_Rect_ == IntPtr.Zero)
				id_onAutofocusStopped_arrayLandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onAutofocusStopped", "([Landroid/graphics/Rect;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onAutofocusStopped_arrayLandroid_graphics_Rect_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
