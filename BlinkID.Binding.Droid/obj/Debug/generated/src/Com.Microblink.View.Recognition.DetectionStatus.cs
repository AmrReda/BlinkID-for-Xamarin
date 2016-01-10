using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Recognition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']"
	[global::Android.Runtime.Register ("com/microblink/view/recognition/DetectionStatus", DoNotGenerateAcw=true)]
	public sealed partial class DetectionStatus : global::Java.Lang.Enum {


		static IntPtr CAMERA_AT_ANGLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']/field[@name='CAMERA_AT_ANGLE']"
		[Register ("CAMERA_AT_ANGLE")]
		public static global::Com.Microblink.View.Recognition.DetectionStatus CameraAtAngle {
			get {
				if (CAMERA_AT_ANGLE_jfieldId == IntPtr.Zero)
					CAMERA_AT_ANGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_AT_ANGLE", "Lcom/microblink/view/recognition/DetectionStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMERA_AT_ANGLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CAMERA_TOO_HIGH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']/field[@name='CAMERA_TOO_HIGH']"
		[Register ("CAMERA_TOO_HIGH")]
		public static global::Com.Microblink.View.Recognition.DetectionStatus CameraTooHigh {
			get {
				if (CAMERA_TOO_HIGH_jfieldId == IntPtr.Zero)
					CAMERA_TOO_HIGH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_TOO_HIGH", "Lcom/microblink/view/recognition/DetectionStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMERA_TOO_HIGH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']/field[@name='FAIL']"
		[Register ("FAIL")]
		public static global::Com.Microblink.View.Recognition.DetectionStatus Fail {
			get {
				if (FAIL_jfieldId == IntPtr.Zero)
					FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAIL", "Lcom/microblink/view/recognition/DetectionStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PARTIAL_OBJECT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']/field[@name='PARTIAL_OBJECT']"
		[Register ("PARTIAL_OBJECT")]
		public static global::Com.Microblink.View.Recognition.DetectionStatus PartialObject {
			get {
				if (PARTIAL_OBJECT_jfieldId == IntPtr.Zero)
					PARTIAL_OBJECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARTIAL_OBJECT", "Lcom/microblink/view/recognition/DetectionStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARTIAL_OBJECT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static global::Com.Microblink.View.Recognition.DetectionStatus Success {
			get {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/microblink/view/recognition/DetectionStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/recognition/DetectionStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetectionStatus); }
		}

		internal DetectionStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromNativeDetectionStatus_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']/method[@name='fromNativeDetectionStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromNativeDetectionStatus", "(I)Lcom/microblink/view/recognition/DetectionStatus;", "")]
		public static unsafe global::Com.Microblink.View.Recognition.DetectionStatus FromNativeDetectionStatus (int p0)
		{
			if (id_fromNativeDetectionStatus_I == IntPtr.Zero)
				id_fromNativeDetectionStatus_I = JNIEnv.GetStaticMethodID (class_ref, "fromNativeDetectionStatus", "(I)Lcom/microblink/view/recognition/DetectionStatus;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromNativeDetectionStatus_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/view/recognition/DetectionStatus;", "")]
		public static unsafe global::Com.Microblink.View.Recognition.DetectionStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/view/recognition/DetectionStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.View.Recognition.DetectionStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.DetectionStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='DetectionStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/view/recognition/DetectionStatus;", "")]
		public static unsafe global::Com.Microblink.View.Recognition.DetectionStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/view/recognition/DetectionStatus;");
			try {
				return (global::Com.Microblink.View.Recognition.DetectionStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.View.Recognition.DetectionStatus));
			} finally {
			}
		}

	}
}
