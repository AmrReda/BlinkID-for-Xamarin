using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware.Orientation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.hardware.orientation']/interface[@name='OrientationChangeListener']"
	[Register ("com/microblink/hardware/orientation/OrientationChangeListener", "", "Com.Microblink.Hardware.Orientation.IOrientationChangeListenerInvoker")]
	public partial interface IOrientationChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/interface[@name='OrientationChangeListener']/method[@name='onOrientationChange' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
		[Register ("onOrientationChange", "(Lcom/microblink/hardware/orientation/Orientation;)V", "GetOnOrientationChange_Lcom_microblink_hardware_orientation_Orientation_Handler:Com.Microblink.Hardware.Orientation.IOrientationChangeListenerInvoker, BlinkID.Binding.Droid")]
		void OnOrientationChange (global::Com.Microblink.Hardware.Orientation.Orientation p0);

	}

	[global::Android.Runtime.Register ("com/microblink/hardware/orientation/OrientationChangeListener", DoNotGenerateAcw=true)]
	internal class IOrientationChangeListenerInvoker : global::Java.Lang.Object, IOrientationChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/hardware/orientation/OrientationChangeListener");
		IntPtr class_ref;

		public static IOrientationChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOrientationChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.hardware.orientation.OrientationChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOrientationChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOrientationChangeListenerInvoker); }
		}

		static Delegate cb_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_;
#pragma warning disable 0169
		static Delegate GetOnOrientationChange_Lcom_microblink_hardware_orientation_Orientation_Handler ()
		{
			if (cb_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ == null)
				cb_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOrientationChange_Lcom_microblink_hardware_orientation_Orientation_);
			return cb_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_;
		}

		static void n_OnOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Orientation.Orientation p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOrientationChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_;
		public unsafe void OnOrientationChange (global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			if (id_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
				id_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "onOrientationChange", "(Lcom/microblink/hardware/orientation/Orientation;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_, __args);
		}

	}

	public partial class OrientationChangeEventArgs : global::System.EventArgs {

		public OrientationChangeEventArgs (global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			this.p0 = p0;
		}

		global::Com.Microblink.Hardware.Orientation.Orientation p0;
		public global::Com.Microblink.Hardware.Orientation.Orientation P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/microblink/hardware/orientation/OrientationChangeListenerImplementor")]
	internal sealed partial class IOrientationChangeListenerImplementor : global::Java.Lang.Object, IOrientationChangeListener {

		object sender;

		public IOrientationChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microblink/hardware/orientation/OrientationChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<OrientationChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnOrientationChange (global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new OrientationChangeEventArgs (p0));
		}

		internal static bool __IsEmpty (IOrientationChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
