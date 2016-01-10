using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware.Camera.Camera1.Focus {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.hardware.camera.camera1.focus']/interface[@name='AutofocusListener']"
	[Register ("com/microblink/hardware/camera/camera1/focus/AutofocusListener", "", "Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker")]
	public partial interface IAutofocusListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera1.focus']/interface[@name='AutofocusListener']/method[@name='onAutofocusFailed' and count(parameter)=0]"
		[Register ("onAutofocusFailed", "()V", "GetOnAutofocusFailedHandler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid")]
		void OnAutofocusFailed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera1.focus']/interface[@name='AutofocusListener']/method[@name='onAutofocusStarted' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect[]']]"
		[Register ("onAutofocusStarted", "([Landroid/graphics/Rect;)V", "GetOnAutofocusStarted_arrayLandroid_graphics_Rect_Handler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid")]
		void OnAutofocusStarted (global::Android.Graphics.Rect[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera1.focus']/interface[@name='AutofocusListener']/method[@name='onAutofocusStopped' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect[]']]"
		[Register ("onAutofocusStopped", "([Landroid/graphics/Rect;)V", "GetOnAutofocusStopped_arrayLandroid_graphics_Rect_Handler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid")]
		void OnAutofocusStopped (global::Android.Graphics.Rect[] p0);

	}

	[global::Android.Runtime.Register ("com/microblink/hardware/camera/camera1/focus/AutofocusListener", DoNotGenerateAcw=true)]
	internal class IAutofocusListenerInvoker : global::Java.Lang.Object, IAutofocusListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/hardware/camera/camera1/focus/AutofocusListener");
		IntPtr class_ref;

		public static IAutofocusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAutofocusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.hardware.camera.camera1.focus.AutofocusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAutofocusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAutofocusListenerInvoker); }
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
			global::Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	public partial class AutofocusStartedEventArgs : global::System.EventArgs {

		public AutofocusStartedEventArgs (global::Android.Graphics.Rect[] p0)
		{
			this.p0 = p0;
		}

		global::Android.Graphics.Rect[] p0;
		public global::Android.Graphics.Rect[] P0 {
			get { return p0; }
		}
	}

	public partial class AutofocusStoppedEventArgs : global::System.EventArgs {

		public AutofocusStoppedEventArgs (global::Android.Graphics.Rect[] p0)
		{
			this.p0 = p0;
		}

		global::Android.Graphics.Rect[] p0;
		public global::Android.Graphics.Rect[] P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/microblink/hardware/camera/camera1/focus/AutofocusListenerImplementor")]
	internal sealed partial class IAutofocusListenerImplementor : global::Java.Lang.Object, IAutofocusListener {

		object sender;

		public IAutofocusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microblink/hardware/camera/camera1/focus/AutofocusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnAutofocusFailedHandler;
#pragma warning restore 0649

		public void OnAutofocusFailed ()
		{
			var __h = OnAutofocusFailedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<AutofocusStartedEventArgs> OnAutofocusStartedHandler;
#pragma warning restore 0649

		public void OnAutofocusStarted (global::Android.Graphics.Rect[] p0)
		{
			var __h = OnAutofocusStartedHandler;
			if (__h != null)
				__h (sender, new AutofocusStartedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AutofocusStoppedEventArgs> OnAutofocusStoppedHandler;
#pragma warning restore 0649

		public void OnAutofocusStopped (global::Android.Graphics.Rect[] p0)
		{
			var __h = OnAutofocusStoppedHandler;
			if (__h != null)
				__h (sender, new AutofocusStoppedEventArgs (p0));
		}

		internal static bool __IsEmpty (IAutofocusListenerImplementor value)
		{
			return value.OnAutofocusFailedHandler == null && value.OnAutofocusStartedHandler == null && value.OnAutofocusStoppedHandler == null;
		}
	}

}
