using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanActivity']"
	[global::Android.Runtime.Register ("com/microblink/activity/ScanActivity", DoNotGenerateAcw=true)]
	public partial class ScanActivity : global::Com.Microblink.Activity.BaseScanActivity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanActivity']/field[@name='EXTRAS_SHOW_OCR_RESULT']"
		[Register ("EXTRAS_SHOW_OCR_RESULT")]
		public const string ExtrasShowOcrResult = (string) "EXTRAS_SHOW_OCR_RESULT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanActivity']/field[@name='EXTRAS_SHOW_OCR_RESULT_MODE']"
		[Register ("EXTRAS_SHOW_OCR_RESULT_MODE")]
		public const string ExtrasShowOcrResultMode = (string) "EXTRAS_SHOW_OCR_RESULT_MODE";

		static IntPtr IllIIIIllI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanActivity']/field[@name='IllIIIIllI']"
		[Register ("IllIIIIllI")]
		protected bool IllIIIIllI {
			get {
				if (IllIIIIllI_jfieldId == IntPtr.Zero)
					IllIIIIllI_jfieldId = JNIEnv.GetFieldID (class_ref, "IllIIIIllI", "Z");
				return JNIEnv.GetBooleanField (Handle, IllIIIIllI_jfieldId);
			}
			set {
				if (IllIIIIllI_jfieldId == IntPtr.Zero)
					IllIIIIllI_jfieldId = JNIEnv.GetFieldID (class_ref, "IllIIIIllI", "Z");
				try {
					JNIEnv.SetField (Handle, IllIIIIllI_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/activity/ScanActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScanActivity); }
		}

		protected ScanActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanActivity']/constructor[@name='ScanActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScanActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ScanActivity)) {
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

		static IntPtr id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanActivity']/method[@name='llIIlIlIIl' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.RecognizerView'] and parameter[2][@type='android.os.Bundle']]"
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
