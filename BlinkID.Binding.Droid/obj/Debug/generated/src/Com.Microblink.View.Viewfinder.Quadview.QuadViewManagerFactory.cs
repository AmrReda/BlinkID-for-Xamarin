using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Viewfinder.Quadview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManagerFactory']"
	[global::Android.Runtime.Register ("com/microblink/view/viewfinder/quadview/QuadViewManagerFactory", DoNotGenerateAcw=true)]
	public partial class QuadViewManagerFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/viewfinder/quadview/QuadViewManagerFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuadViewManagerFactory); }
		}

		protected QuadViewManagerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManagerFactory']/constructor[@name='QuadViewManagerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QuadViewManagerFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (QuadViewManagerFactory)) {
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

		static IntPtr id_createQuadViewFromPreset_Lcom_microblink_view_recognition_RecognizerView_Lcom_microblink_view_viewfinder_quadview_QuadViewPreset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewManagerFactory']/method[@name='createQuadViewFromPreset' and count(parameter)=2 and parameter[1][@type='com.microblink.view.recognition.RecognizerView'] and parameter[2][@type='com.microblink.view.viewfinder.quadview.QuadViewPreset']]"
		[Register ("createQuadViewFromPreset", "(Lcom/microblink/view/recognition/RecognizerView;Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;)Lcom/microblink/view/viewfinder/quadview/QuadViewManager;", "")]
		public static unsafe global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager CreateQuadViewFromPreset (global::Com.Microblink.View.Recognition.RecognizerView p0, global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset p1)
		{
			if (id_createQuadViewFromPreset_Lcom_microblink_view_recognition_RecognizerView_Lcom_microblink_view_viewfinder_quadview_QuadViewPreset_ == IntPtr.Zero)
				id_createQuadViewFromPreset_Lcom_microblink_view_recognition_RecognizerView_Lcom_microblink_view_viewfinder_quadview_QuadViewPreset_ = JNIEnv.GetStaticMethodID (class_ref, "createQuadViewFromPreset", "(Lcom/microblink/view/recognition/RecognizerView;Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;)Lcom/microblink/view/viewfinder/quadview/QuadViewManager;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createQuadViewFromPreset_Lcom_microblink_view_recognition_RecognizerView_Lcom_microblink_view_viewfinder_quadview_QuadViewPreset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
