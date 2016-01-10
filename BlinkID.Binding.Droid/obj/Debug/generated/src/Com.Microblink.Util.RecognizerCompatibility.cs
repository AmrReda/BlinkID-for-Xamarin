using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibility']"
	[global::Android.Runtime.Register ("com/microblink/util/RecognizerCompatibility", DoNotGenerateAcw=true)]
	public partial class RecognizerCompatibility : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/util/RecognizerCompatibility", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognizerCompatibility); }
		}

		protected RecognizerCompatibility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibility']/constructor[@name='RecognizerCompatibility' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecognizerCompatibility ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecognizerCompatibility)) {
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

		static IntPtr id_cameraHasAutofocus_Lcom_microblink_hardware_camera_CameraType_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibility']/method[@name='cameraHasAutofocus' and count(parameter)=2 and parameter[1][@type='com.microblink.hardware.camera.CameraType'] and parameter[2][@type='android.content.Context']]"
		[Register ("cameraHasAutofocus", "(Lcom/microblink/hardware/camera/CameraType;Landroid/content/Context;)Z", "")]
		public static unsafe bool CameraHasAutofocus (global::Com.Microblink.Hardware.Camera.CameraType p0, global::Android.Content.Context p1)
		{
			if (id_cameraHasAutofocus_Lcom_microblink_hardware_camera_CameraType_Landroid_content_Context_ == IntPtr.Zero)
				id_cameraHasAutofocus_Lcom_microblink_hardware_camera_CameraType_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "cameraHasAutofocus", "(Lcom/microblink/hardware/camera/CameraType;Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_cameraHasAutofocus_Lcom_microblink_hardware_camera_CameraType_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRecognizerCompatibilityStatus_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='RecognizerCompatibility']/method[@name='getRecognizerCompatibilityStatus' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRecognizerCompatibilityStatus", "(Landroid/content/Context;)Lcom/microblink/util/RecognizerCompatibilityStatus;", "")]
		public static unsafe global::Com.Microblink.Util.RecognizerCompatibilityStatus GetRecognizerCompatibilityStatus (global::Android.Content.Context p0)
		{
			if (id_getRecognizerCompatibilityStatus_Landroid_content_Context_ == IntPtr.Zero)
				id_getRecognizerCompatibilityStatus_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRecognizerCompatibilityStatus", "(Landroid/content/Context;)Lcom/microblink/util/RecognizerCompatibilityStatus;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Microblink.Util.RecognizerCompatibilityStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.RecognizerCompatibilityStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRecognizerCompatibilityStatus_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
