using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.hardware']/interface[@name='SuccessCallback']"
	[Register ("com/microblink/hardware/SuccessCallback", "", "Com.Microblink.Hardware.ISuccessCallbackInvoker")]
	public partial interface ISuccessCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware']/interface[@name='SuccessCallback']/method[@name='onOperationDone' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onOperationDone", "(Z)V", "GetOnOperationDone_ZHandler:Com.Microblink.Hardware.ISuccessCallbackInvoker, BlinkID.Binding.Droid")]
		void OnOperationDone (bool p0);

	}

	[global::Android.Runtime.Register ("com/microblink/hardware/SuccessCallback", DoNotGenerateAcw=true)]
	internal class ISuccessCallbackInvoker : global::Java.Lang.Object, ISuccessCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/hardware/SuccessCallback");
		IntPtr class_ref;

		public static ISuccessCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISuccessCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.hardware.SuccessCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISuccessCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISuccessCallbackInvoker); }
		}

		static Delegate cb_onOperationDone_Z;
#pragma warning disable 0169
		static Delegate GetOnOperationDone_ZHandler ()
		{
			if (cb_onOperationDone_Z == null)
				cb_onOperationDone_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnOperationDone_Z);
			return cb_onOperationDone_Z;
		}

		static void n_OnOperationDone_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Hardware.ISuccessCallback __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.ISuccessCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOperationDone (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOperationDone_Z;
		public unsafe void OnOperationDone (bool p0)
		{
			if (id_onOperationDone_Z == IntPtr.Zero)
				id_onOperationDone_Z = JNIEnv.GetMethodID (class_ref, "onOperationDone", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onOperationDone_Z, __args);
		}

	}

}
