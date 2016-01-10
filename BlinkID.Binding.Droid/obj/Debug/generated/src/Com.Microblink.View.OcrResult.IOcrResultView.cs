using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.OcrResult {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.view.ocrResult']/interface[@name='IOcrResultView']"
	[Register ("com/microblink/view/ocrResult/IOcrResultView", "", "Com.Microblink.View.OcrResult.IOcrResultViewInvoker")]
	public partial interface IOcrResultView : IJavaObject {

		global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/interface[@name='IOcrResultView']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler:Com.Microblink.View.OcrResult.IOcrResultViewInvoker, BlinkID.Binding.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/interface[@name='IOcrResultView']/method[@name='addOcrResult' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrResult']]"
		[Register ("addOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V", "GetAddOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler:Com.Microblink.View.OcrResult.IOcrResultViewInvoker, BlinkID.Binding.Droid")]
		void AddOcrResult (global::Com.Microblink.Results.Ocr.OcrResult p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/interface[@name='IOcrResultView']/method[@name='clearOcrResults' and count(parameter)=0]"
		[Register ("clearOcrResults", "()V", "GetClearOcrResultsHandler:Com.Microblink.View.OcrResult.IOcrResultViewInvoker, BlinkID.Binding.Droid")]
		void ClearOcrResults ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/interface[@name='IOcrResultView']/method[@name='setHostActivityOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHostActivityOrientation", "(I)V", "GetSetHostActivityOrientation_IHandler:Com.Microblink.View.OcrResult.IOcrResultViewInvoker, BlinkID.Binding.Droid")]
		void SetHostActivityOrientation (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/interface[@name='IOcrResultView']/method[@name='setOcrResult' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrResult']]"
		[Register ("setOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V", "GetSetOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler:Com.Microblink.View.OcrResult.IOcrResultViewInvoker, BlinkID.Binding.Droid")]
		void SetOcrResult (global::Com.Microblink.Results.Ocr.OcrResult p0);

	}

	[global::Android.Runtime.Register ("com/microblink/view/ocrResult/IOcrResultView", DoNotGenerateAcw=true)]
	internal class IOcrResultViewInvoker : global::Java.Lang.Object, IOcrResultView {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/view/ocrResult/IOcrResultView");
		IntPtr class_ref;

		public static IOcrResultView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOcrResultView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.view.ocrResult.IOcrResultView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOcrResultViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOcrResultViewInvoker); }
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.OcrResult.IOcrResultView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.IOcrResultView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		IntPtr id_getView;
		public unsafe global::Android.Views.View View {
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addOcrResult_Lcom_microblink_results_ocr_OcrResult_;
#pragma warning disable 0169
		static Delegate GetAddOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler ()
		{
			if (cb_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ == null)
				cb_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOcrResult_Lcom_microblink_results_ocr_OcrResult_);
			return cb_addOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		}

		static void n_AddOcrResult_Lcom_microblink_results_ocr_OcrResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.OcrResult.IOcrResultView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.IOcrResultView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrResult p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOcrResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		public unsafe void AddOcrResult (global::Com.Microblink.Results.Ocr.OcrResult p0)
		{
			if (id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ == IntPtr.Zero)
				id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNIEnv.GetMethodID (class_ref, "addOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_, __args);
		}

		static Delegate cb_clearOcrResults;
#pragma warning disable 0169
		static Delegate GetClearOcrResultsHandler ()
		{
			if (cb_clearOcrResults == null)
				cb_clearOcrResults = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearOcrResults);
			return cb_clearOcrResults;
		}

		static void n_ClearOcrResults (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.OcrResult.IOcrResultView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.IOcrResultView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearOcrResults ();
		}
#pragma warning restore 0169

		IntPtr id_clearOcrResults;
		public unsafe void ClearOcrResults ()
		{
			if (id_clearOcrResults == IntPtr.Zero)
				id_clearOcrResults = JNIEnv.GetMethodID (class_ref, "clearOcrResults", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clearOcrResults);
		}

		static Delegate cb_setHostActivityOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetHostActivityOrientation_IHandler ()
		{
			if (cb_setHostActivityOrientation_I == null)
				cb_setHostActivityOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHostActivityOrientation_I);
			return cb_setHostActivityOrientation_I;
		}

		static void n_SetHostActivityOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.View.OcrResult.IOcrResultView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.IOcrResultView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHostActivityOrientation (p0);
		}
#pragma warning restore 0169

		IntPtr id_setHostActivityOrientation_I;
		public unsafe void SetHostActivityOrientation (int p0)
		{
			if (id_setHostActivityOrientation_I == IntPtr.Zero)
				id_setHostActivityOrientation_I = JNIEnv.GetMethodID (class_ref, "setHostActivityOrientation", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setHostActivityOrientation_I, __args);
		}

		static Delegate cb_setOcrResult_Lcom_microblink_results_ocr_OcrResult_;
#pragma warning disable 0169
		static Delegate GetSetOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler ()
		{
			if (cb_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ == null)
				cb_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOcrResult_Lcom_microblink_results_ocr_OcrResult_);
			return cb_setOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		}

		static void n_SetOcrResult_Lcom_microblink_results_ocr_OcrResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.OcrResult.IOcrResultView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.IOcrResultView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrResult p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOcrResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		public unsafe void SetOcrResult (global::Com.Microblink.Results.Ocr.OcrResult p0)
		{
			if (id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ == IntPtr.Zero)
				id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNIEnv.GetMethodID (class_ref, "setOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_, __args);
		}

	}

}
