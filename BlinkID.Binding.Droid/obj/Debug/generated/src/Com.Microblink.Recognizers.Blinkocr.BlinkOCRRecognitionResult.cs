using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognitionResult']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkocr/BlinkOCRRecognitionResult", DoNotGenerateAcw=true)]
	public partial class BlinkOCRRecognitionResult : global::Com.Microblink.Recognizers.BaseRecognitionResult, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognitionResult']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkocr/BlinkOCRRecognitionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlinkOCRRecognitionResult); }
		}

		protected BlinkOCRRecognitionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Bundle_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognitionResult']/constructor[@name='BlinkOCRRecognitionResult' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/os/Bundle;ZZ)V", "")]
		public unsafe BlinkOCRRecognitionResult (global::Android.OS.Bundle p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BlinkOCRRecognitionResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Bundle;ZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Bundle;ZZ)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Bundle_ZZ == IntPtr.Zero)
					id_ctor_Landroid_os_Bundle_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;ZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_ZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Bundle_ZZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognitionResult']/constructor[@name='BlinkOCRRecognitionResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JZZ)V", "")]
		public unsafe BlinkOCRRecognitionResult (long p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BlinkOCRRecognitionResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JZZ)V", __args);
					return;
				}

				if (id_ctor_JZZ == IntPtr.Zero)
					id_ctor_JZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JZZ, __args);
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
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OcrResult);
		}
#pragma warning restore 0169

		static IntPtr id_getOcrResult;
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrResult OcrResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognitionResult']/method[@name='getOcrResult' and count(parameter)=0]"
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

		static Delegate cb_getOcrResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOcrResult_Ljava_lang_String_Handler ()
		{
			if (cb_getOcrResult_Ljava_lang_String_ == null)
				cb_getOcrResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOcrResult_Ljava_lang_String_);
			return cb_getOcrResult_Ljava_lang_String_;
		}

		static IntPtr n_GetOcrResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOcrResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOcrResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognitionResult']/method[@name='getOcrResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOcrResult", "(Ljava/lang/String;)Lcom/microblink/results/ocr/OcrResult;", "GetGetOcrResult_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrResult GetOcrResult (string p0)
		{
			if (id_getOcrResult_Ljava_lang_String_ == IntPtr.Zero)
				id_getOcrResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getOcrResult", "(Ljava/lang/String;)Lcom/microblink/results/ocr/OcrResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Microblink.Results.Ocr.OcrResult __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (JNIEnv.CallObjectMethod  (Handle, id_getOcrResult_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOcrResult", "(Ljava/lang/String;)Lcom/microblink/results/ocr/OcrResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getParsedResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParsedResult_Ljava_lang_String_Handler ()
		{
			if (cb_getParsedResult_Ljava_lang_String_ == null)
				cb_getParsedResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParsedResult_Ljava_lang_String_);
			return cb_getParsedResult_Ljava_lang_String_;
		}

		static IntPtr n_GetParsedResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParsedResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getParsedResult_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognitionResult']/method[@name='getParsedResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParsedResult", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetParsedResult_Ljava_lang_String_Handler")]
		public virtual unsafe string GetParsedResult (string p0)
		{
			if (id_getParsedResult_Ljava_lang_String_ == IntPtr.Zero)
				id_getParsedResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParsedResult", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParsedResult_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParsedResult", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getParsedResult_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParsedResult_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getParsedResult_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getParsedResult_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParsedResult_Ljava_lang_String_Ljava_lang_String_);
			return cb_getParsedResult_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetParsedResult_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetParsedResult (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getParsedResult_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognitionResult']/method[@name='getParsedResult' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getParsedResult", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetParsedResult_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetParsedResult (string p0, string p1)
		{
			if (id_getParsedResult_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getParsedResult_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParsedResult", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParsedResult_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParsedResult", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
