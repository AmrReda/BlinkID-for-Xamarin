using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.DirectApi {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.directApi']/interface[@name='DirectApiErrorListener']"
	[Register ("com/microblink/directApi/DirectApiErrorListener", "", "Com.Microblink.DirectApi.IDirectApiErrorListenerInvoker")]
	public partial interface IDirectApiErrorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/interface[@name='DirectApiErrorListener']/method[@name='onRecognizerError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onRecognizerError", "(Ljava/lang/Throwable;)V", "GetOnRecognizerError_Ljava_lang_Throwable_Handler:Com.Microblink.DirectApi.IDirectApiErrorListenerInvoker, BlinkID.Binding.Droid")]
		void OnRecognizerError (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("com/microblink/directApi/DirectApiErrorListener", DoNotGenerateAcw=true)]
	internal class IDirectApiErrorListenerInvoker : global::Java.Lang.Object, IDirectApiErrorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/directApi/DirectApiErrorListener");
		IntPtr class_ref;

		public static IDirectApiErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDirectApiErrorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.directApi.DirectApiErrorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDirectApiErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDirectApiErrorListenerInvoker); }
		}

		static Delegate cb_onRecognizerError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnRecognizerError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onRecognizerError_Ljava_lang_Throwable_ == null)
				cb_onRecognizerError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRecognizerError_Ljava_lang_Throwable_);
			return cb_onRecognizerError_Ljava_lang_Throwable_;
		}

		static void n_OnRecognizerError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.DirectApi.IDirectApiErrorListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.IDirectApiErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRecognizerError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRecognizerError_Ljava_lang_Throwable_;
		public unsafe void OnRecognizerError (global::Java.Lang.Throwable p0)
		{
			if (id_onRecognizerError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onRecognizerError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onRecognizerError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onRecognizerError_Ljava_lang_Throwable_, __args);
		}

	}

	public partial class DirectApiErrorEventArgs : global::System.EventArgs {

		public DirectApiErrorEventArgs (global::Java.Lang.Throwable p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Throwable p0;
		public global::Java.Lang.Throwable P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/microblink/directApi/DirectApiErrorListenerImplementor")]
	internal sealed partial class IDirectApiErrorListenerImplementor : global::Java.Lang.Object, IDirectApiErrorListener {

		object sender;

		public IDirectApiErrorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microblink/directApi/DirectApiErrorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DirectApiErrorEventArgs> Handler;
#pragma warning restore 0649

		public void OnRecognizerError (global::Java.Lang.Throwable p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DirectApiErrorEventArgs (p0));
		}

		internal static bool __IsEmpty (IDirectApiErrorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
