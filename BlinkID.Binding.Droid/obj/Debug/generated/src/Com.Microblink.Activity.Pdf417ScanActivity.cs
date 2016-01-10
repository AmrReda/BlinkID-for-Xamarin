using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']"
	[global::Android.Runtime.Register ("com/microblink/activity/Pdf417ScanActivity", DoNotGenerateAcw=true)]
	public partial class Pdf417ScanActivity : global::Com.Microblink.Activity.BaseScanActivity, global::Com.Microblink.View.Recognition.IScanResultListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']/field[@name='EXTRAS_SHOW_DIALOG_AFTER_SCAN']"
		[Register ("EXTRAS_SHOW_DIALOG_AFTER_SCAN")]
		public const string ExtrasShowDialogAfterScan = (string) "EXTRAS_SHOW_DIALOG_AFTER_SCAN";

		static IntPtr IIlIIIllIl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']/field[@name='IIlIIIllIl']"
		[Register ("IIlIIIllIl")]
		protected bool IIlIIIllIl {
			get {
				if (IIlIIIllIl_jfieldId == IntPtr.Zero)
					IIlIIIllIl_jfieldId = JNIEnv.GetFieldID (class_ref, "IIlIIIllIl", "Z");
				return JNIEnv.GetBooleanField (Handle, IIlIIIllIl_jfieldId);
			}
			set {
				if (IIlIIIllIl_jfieldId == IntPtr.Zero)
					IIlIIIllIl_jfieldId = JNIEnv.GetFieldID (class_ref, "IIlIIIllIl", "Z");
				try {
					JNIEnv.SetField (Handle, IIlIIIllIl_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']/field[@name='RESULT_OK']"
		[Register ("RESULT_OK")]
		public const int ResultOk = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']/field[@name='RESULT_OK_DATA_COPIED']"
		[Register ("RESULT_OK_DATA_COPIED")]
		public const int ResultOkDataCopied = (int) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/activity/Pdf417ScanActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pdf417ScanActivity); }
		}

		protected Pdf417ScanActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']/constructor[@name='Pdf417ScanActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Pdf417ScanActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Pdf417ScanActivity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_llIIlIlIIl_Lcom_microblink_recognizers_RecognitionResults_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']/method[@name='llIIlIlIIl' and count(parameter)=2 and parameter[1][@type='com.microblink.recognizers.RecognitionResults'] and parameter[2][@type='int']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/recognizers/RecognitionResults;I)V", "")]
		protected unsafe void LlIIlIlIIl (global::Com.Microblink.Recognizers.RecognitionResults p0, int p1)
		{
			if (id_llIIlIlIIl_Lcom_microblink_recognizers_RecognitionResults_I == IntPtr.Zero)
				id_llIIlIlIIl_Lcom_microblink_recognizers_RecognitionResults_I = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Lcom/microblink/recognizers/RecognitionResults;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_llIIlIlIIl_Lcom_microblink_recognizers_RecognitionResults_I, __args);
			} finally {
			}
		}

		static IntPtr id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']/method[@name='llIIlIlIIl' and count(parameter)=1 and parameter[1][@type='com.microblink.view.recognition.RecognizerView']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;)V", "")]
		protected override sealed unsafe void LlIIlIlIIl (global::Com.Microblink.View.Recognition.RecognizerView p0)
		{
			if (id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_ == IntPtr.Zero)
				id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_ = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_, __args);
			} finally {
			}
		}

		static IntPtr id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='Pdf417ScanActivity']/method[@name='llIIlIlIIl' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.RecognizerView'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;Landroid/os/Bundle;)V", "")]
		protected override sealed unsafe void LlIIlIlIIl (global::Com.Microblink.View.Recognition.RecognizerView p0, global::Android.OS.Bundle p1)
		{
			if (id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_ == IntPtr.Zero)
				id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}
}
