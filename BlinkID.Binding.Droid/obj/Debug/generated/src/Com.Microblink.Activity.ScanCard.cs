using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanCard']"
	[global::Android.Runtime.Register ("com/microblink/activity/ScanCard", DoNotGenerateAcw=true)]
	public partial class ScanCard : global::Com.Microblink.Activity.ScanActivity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/activity/ScanCard", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScanCard); }
		}

		protected ScanCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanCard']/constructor[@name='ScanCard' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScanCard ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ScanCard)) {
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

		static IntPtr id_llIIlIlIIl_Lcom_microblink_view_recognition_RecognizerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='ScanCard']/method[@name='llIIlIlIIl' and count(parameter)=1 and parameter[1][@type='com.microblink.view.recognition.RecognizerView']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/view/recognition/RecognizerView;)V", "")]
		protected unsafe void LlIIlIlIIl (global::Com.Microblink.View.Recognition.RecognizerView p0)
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

	}
}
