using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware.Accelerometer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.hardware.accelerometer']/interface[@name='ShakeCallback']"
	[Register ("com/microblink/hardware/accelerometer/ShakeCallback", "", "Com.Microblink.Hardware.Accelerometer.IShakeCallbackInvoker")]
	public partial interface IShakeCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.accelerometer']/interface[@name='ShakeCallback']/method[@name='onShakingStarted' and count(parameter)=0]"
		[Register ("onShakingStarted", "()V", "GetOnShakingStartedHandler:Com.Microblink.Hardware.Accelerometer.IShakeCallbackInvoker, BlinkID.Binding.Droid")]
		void OnShakingStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.accelerometer']/interface[@name='ShakeCallback']/method[@name='onShakingStopped' and count(parameter)=0]"
		[Register ("onShakingStopped", "()V", "GetOnShakingStoppedHandler:Com.Microblink.Hardware.Accelerometer.IShakeCallbackInvoker, BlinkID.Binding.Droid")]
		void OnShakingStopped ();

	}

	[global::Android.Runtime.Register ("com/microblink/hardware/accelerometer/ShakeCallback", DoNotGenerateAcw=true)]
	internal class IShakeCallbackInvoker : global::Java.Lang.Object, IShakeCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/hardware/accelerometer/ShakeCallback");
		IntPtr class_ref;

		public static IShakeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShakeCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.hardware.accelerometer.ShakeCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShakeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IShakeCallbackInvoker); }
		}

		static Delegate cb_onShakingStarted;
#pragma warning disable 0169
		static Delegate GetOnShakingStartedHandler ()
		{
			if (cb_onShakingStarted == null)
				cb_onShakingStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnShakingStarted);
			return cb_onShakingStarted;
		}

		static void n_OnShakingStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Accelerometer.IShakeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Accelerometer.IShakeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnShakingStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onShakingStarted;
		public unsafe void OnShakingStarted ()
		{
			if (id_onShakingStarted == IntPtr.Zero)
				id_onShakingStarted = JNIEnv.GetMethodID (class_ref, "onShakingStarted", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onShakingStarted);
		}

		static Delegate cb_onShakingStopped;
#pragma warning disable 0169
		static Delegate GetOnShakingStoppedHandler ()
		{
			if (cb_onShakingStopped == null)
				cb_onShakingStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnShakingStopped);
			return cb_onShakingStopped;
		}

		static void n_OnShakingStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Accelerometer.IShakeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Accelerometer.IShakeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnShakingStopped ();
		}
#pragma warning restore 0169

		IntPtr id_onShakingStopped;
		public unsafe void OnShakingStopped ()
		{
			if (id_onShakingStopped == IntPtr.Zero)
				id_onShakingStopped = JNIEnv.GetMethodID (class_ref, "onShakingStopped", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onShakingStopped);
		}

	}

}
