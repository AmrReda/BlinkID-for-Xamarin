using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Metadata {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.metadata']/class[@name='OcrMetadata']"
	[global::Android.Runtime.Register ("com/microblink/metadata/OcrMetadata", DoNotGenerateAcw=true)]
	public partial class OcrMetadata : global::Com.Microblink.Metadata.Metadata {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/metadata/OcrMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrMetadata); }
		}

		protected OcrMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_results_ocr_OcrResult_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.metadata']/class[@name='OcrMetadata']/constructor[@name='OcrMetadata' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrResult']]"
		[Register (".ctor", "(Lcom/microblink/results/ocr/OcrResult;)V", "")]
		public unsafe OcrMetadata (global::Com.Microblink.Results.Ocr.OcrResult p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (OcrMetadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/results/ocr/OcrResult;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/results/ocr/OcrResult;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_results_ocr_OcrResult_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_results_ocr_OcrResult_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/results/ocr/OcrResult;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_results_ocr_OcrResult_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_results_ocr_OcrResult_, __args);
			} finally {
			}
		}

		static Delegate cb_getOcrResult;
#pragma warning disable 0169
		static Delegate GetGetOcrResultHandler ()
		{
			if (cb_getOcrResult == null)
				cb_getOcrResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOcrResult);
			return cb_getOcrResult;
		}

		static IntPtr n_GetOcrResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.OcrMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.OcrMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OcrResult);
		}
#pragma warning restore 0169

		static IntPtr id_getOcrResult;
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrResult OcrResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='OcrMetadata']/method[@name='getOcrResult' and count(parameter)=0]"
			[Register ("getOcrResult", "()Lcom/microblink/results/ocr/OcrResult;", "GetGetOcrResultHandler")]
			get {
				if (id_getOcrResult == IntPtr.Zero)
					id_getOcrResult = JNIEnv.GetMethodID (class_ref, "getOcrResult", "()Lcom/microblink/results/ocr/OcrResult;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (JNIEnv.CallObjectMethod  (Handle, id_getOcrResult), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOcrResult", "()Lcom/microblink/results/ocr/OcrResult;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
