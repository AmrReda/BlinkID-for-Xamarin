using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.view']/interface[@name='OrientationAllowedListener']"
	[Register ("com/microblink/view/OrientationAllowedListener", "", "Com.Microblink.View.IOrientationAllowedListenerInvoker")]
	public partial interface IOrientationAllowedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/interface[@name='OrientationAllowedListener']/method[@name='isOrientationAllowed' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
		[Register ("isOrientationAllowed", "(Lcom/microblink/hardware/orientation/Orientation;)Z", "GetIsOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_Handler:Com.Microblink.View.IOrientationAllowedListenerInvoker, BlinkID.Binding.Droid")]
		bool IsOrientationAllowed (global::Com.Microblink.Hardware.Orientation.Orientation p0);

	}

	[global::Android.Runtime.Register ("com/microblink/view/OrientationAllowedListener", DoNotGenerateAcw=true)]
	internal class IOrientationAllowedListenerInvoker : global::Java.Lang.Object, IOrientationAllowedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/view/OrientationAllowedListener");
		IntPtr class_ref;

		public static IOrientationAllowedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOrientationAllowedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.view.OrientationAllowedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOrientationAllowedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOrientationAllowedListenerInvoker); }
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
			global::Com.Microblink.View.IOrientationAllowedListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.IOrientationAllowedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Orientation.Orientation p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsOrientationAllowed (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_;
		public unsafe bool IsOrientationAllowed (global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			if (id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
				id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "isOrientationAllowed", "(Lcom/microblink/hardware/orientation/Orientation;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_, __args);
			return __ret;
		}

	}

	public partial class OrientationAllowedEventArgs : global::System.EventArgs {

		public OrientationAllowedEventArgs (bool handled, global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			this.handled = handled;
			this.p0 = p0;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::Com.Microblink.Hardware.Orientation.Orientation p0;
		public global::Com.Microblink.Hardware.Orientation.Orientation P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/microblink/view/OrientationAllowedListenerImplementor")]
	internal sealed partial class IOrientationAllowedListenerImplementor : global::Java.Lang.Object, IOrientationAllowedListener {

		object sender;

		public IOrientationAllowedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microblink/view/OrientationAllowedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<OrientationAllowedEventArgs> Handler;
#pragma warning restore 0649

		public bool IsOrientationAllowed (global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new OrientationAllowedEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IOrientationAllowedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
