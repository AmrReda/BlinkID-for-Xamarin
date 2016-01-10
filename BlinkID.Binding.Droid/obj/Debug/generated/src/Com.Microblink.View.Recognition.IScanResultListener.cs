using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Recognition {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.view.recognition']/interface[@name='ScanResultListener']"
	[Register ("com/microblink/view/recognition/ScanResultListener", "", "Com.Microblink.View.Recognition.IScanResultListenerInvoker")]
	public partial interface IScanResultListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/interface[@name='ScanResultListener']/method[@name='onScanningDone' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.RecognitionResults']]"
		[Register ("onScanningDone", "(Lcom/microblink/recognizers/RecognitionResults;)V", "GetOnScanningDone_Lcom_microblink_recognizers_RecognitionResults_Handler:Com.Microblink.View.Recognition.IScanResultListenerInvoker, BlinkID.Binding.Droid")]
		void OnScanningDone (global::Com.Microblink.Recognizers.RecognitionResults p0);

	}

	[global::Android.Runtime.Register ("com/microblink/view/recognition/ScanResultListener", DoNotGenerateAcw=true)]
	internal class IScanResultListenerInvoker : global::Java.Lang.Object, IScanResultListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/view/recognition/ScanResultListener");
		IntPtr class_ref;

		public static IScanResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScanResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.view.recognition.ScanResultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScanResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IScanResultListenerInvoker); }
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
			global::Com.Microblink.View.Recognition.IScanResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.IScanResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.RecognitionResults p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.RecognitionResults> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScanningDone (p0);
		}
#pragma warning restore 0169

		IntPtr id_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_;
		public unsafe void OnScanningDone (global::Com.Microblink.Recognizers.RecognitionResults p0)
		{
			if (id_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_ == IntPtr.Zero)
				id_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_ = JNIEnv.GetMethodID (class_ref, "onScanningDone", "(Lcom/microblink/recognizers/RecognitionResults;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onScanningDone_Lcom_microblink_recognizers_RecognitionResults_, __args);
		}

	}

	public partial class ScanResultEventArgs : global::System.EventArgs {

		public ScanResultEventArgs (global::Com.Microblink.Recognizers.RecognitionResults p0)
		{
			this.p0 = p0;
		}

		global::Com.Microblink.Recognizers.RecognitionResults p0;
		public global::Com.Microblink.Recognizers.RecognitionResults P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/microblink/view/recognition/ScanResultListenerImplementor")]
	internal sealed partial class IScanResultListenerImplementor : global::Java.Lang.Object, IScanResultListener {

		object sender;

		public IScanResultListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microblink/view/recognition/ScanResultListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ScanResultEventArgs> Handler;
#pragma warning restore 0649

		public void OnScanningDone (global::Com.Microblink.Recognizers.RecognitionResults p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ScanResultEventArgs (p0));
		}

		internal static bool __IsEmpty (IScanResultListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
