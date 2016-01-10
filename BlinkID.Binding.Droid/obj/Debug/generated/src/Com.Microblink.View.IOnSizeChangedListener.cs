using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.view']/interface[@name='OnSizeChangedListener']"
	[Register ("com/microblink/view/OnSizeChangedListener", "", "Com.Microblink.View.IOnSizeChangedListenerInvoker")]
	public partial interface IOnSizeChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/interface[@name='OnSizeChangedListener']/method[@name='onSizeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSizeChanged", "(II)V", "GetOnSizeChanged_IIHandler:Com.Microblink.View.IOnSizeChangedListenerInvoker, BlinkID.Binding.Droid")]
		void OnSizeChanged (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/microblink/view/OnSizeChangedListener", DoNotGenerateAcw=true)]
	internal class IOnSizeChangedListenerInvoker : global::Java.Lang.Object, IOnSizeChangedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/view/OnSizeChangedListener");
		IntPtr class_ref;

		public static IOnSizeChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSizeChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.view.OnSizeChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSizeChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnSizeChangedListenerInvoker); }
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
			global::Com.Microblink.View.IOnSizeChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.IOnSizeChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSizeChanged (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSizeChanged_II;
		public unsafe void OnSizeChanged (int p0, int p1)
		{
			if (id_onSizeChanged_II == IntPtr.Zero)
				id_onSizeChanged_II = JNIEnv.GetMethodID (class_ref, "onSizeChanged", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onSizeChanged_II, __args);
		}

	}

	public partial class SizeChangedEventArgs : global::System.EventArgs {

		public SizeChangedEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/microblink/view/OnSizeChangedListenerImplementor")]
	internal sealed partial class IOnSizeChangedListenerImplementor : global::Java.Lang.Object, IOnSizeChangedListener {

		object sender;

		public IOnSizeChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microblink/view/OnSizeChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<SizeChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnSizeChanged (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new SizeChangedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnSizeChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
