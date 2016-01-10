using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.OcrResult {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultCharsView']"
	[global::Android.Runtime.Register ("com/microblink/view/ocrResult/OcrResultCharsView", DoNotGenerateAcw=true)]
	public partial class OcrResultCharsView : global::Android.Views.View, global::Com.Microblink.View.OcrResult.IOcrResultView {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/ocrResult/OcrResultCharsView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrResultCharsView); }
		}

		protected OcrResultCharsView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultCharsView']/constructor[@name='OcrResultCharsView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe OcrResultCharsView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (OcrResultCharsView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
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
			global::Com.Microblink.View.OcrResult.OcrResultCharsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultCharsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultCharsView']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Microblink.View.OcrResult.OcrResultCharsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultCharsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrResult p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOcrResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultCharsView']/method[@name='addOcrResult' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrResult']]"
		[Register ("addOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V", "GetAddOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler")]
		public virtual unsafe void AddOcrResult (global::Com.Microblink.Results.Ocr.OcrResult p0)
		{
			if (id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ == IntPtr.Zero)
				id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNIEnv.GetMethodID (class_ref, "addOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V"), __args);
			} finally {
			}
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
			global::Com.Microblink.View.OcrResult.OcrResultCharsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultCharsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearOcrResults ();
		}
#pragma warning restore 0169

		static IntPtr id_clearOcrResults;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultCharsView']/method[@name='clearOcrResults' and count(parameter)=0]"
		[Register ("clearOcrResults", "()V", "GetClearOcrResultsHandler")]
		public virtual unsafe void ClearOcrResults ()
		{
			if (id_clearOcrResults == IntPtr.Zero)
				id_clearOcrResults = JNIEnv.GetMethodID (class_ref, "clearOcrResults", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearOcrResults);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearOcrResults", "()V"));
			} finally {
			}
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
			global::Com.Microblink.View.OcrResult.OcrResultCharsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultCharsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHostActivityOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHostActivityOrientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultCharsView']/method[@name='setHostActivityOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHostActivityOrientation", "(I)V", "GetSetHostActivityOrientation_IHandler")]
		public virtual unsafe void SetHostActivityOrientation (int p0)
		{
			if (id_setHostActivityOrientation_I == IntPtr.Zero)
				id_setHostActivityOrientation_I = JNIEnv.GetMethodID (class_ref, "setHostActivityOrientation", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHostActivityOrientation_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostActivityOrientation", "(I)V"), __args);
			} finally {
			}
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
			global::Com.Microblink.View.OcrResult.OcrResultCharsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultCharsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrResult p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOcrResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultCharsView']/method[@name='setOcrResult' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrResult']]"
		[Register ("setOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V", "GetSetOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler")]
		public virtual unsafe void SetOcrResult (global::Com.Microblink.Results.Ocr.OcrResult p0)
		{
			if (id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ == IntPtr.Zero)
				id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNIEnv.GetMethodID (class_ref, "setOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V"), __args);
			} finally {
			}
		}

	}
}
