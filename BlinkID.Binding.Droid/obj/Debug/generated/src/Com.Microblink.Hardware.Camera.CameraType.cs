using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']"
	[global::Android.Runtime.Register ("com/microblink/hardware/camera/CameraType", DoNotGenerateAcw=true)]
	public sealed partial class CameraType : global::Java.Lang.Enum, global::Android.OS.IParcelable {


		static IntPtr CAMERA_BACKFACE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']/field[@name='CAMERA_BACKFACE']"
		[Register ("CAMERA_BACKFACE")]
		public static global::Com.Microblink.Hardware.Camera.CameraType CameraBackface {
			get {
				if (CAMERA_BACKFACE_jfieldId == IntPtr.Zero)
					CAMERA_BACKFACE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_BACKFACE", "Lcom/microblink/hardware/camera/CameraType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMERA_BACKFACE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.CameraType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CAMERA_DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']/field[@name='CAMERA_DEFAULT']"
		[Register ("CAMERA_DEFAULT")]
		public static global::Com.Microblink.Hardware.Camera.CameraType CameraDefault {
			get {
				if (CAMERA_DEFAULT_jfieldId == IntPtr.Zero)
					CAMERA_DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_DEFAULT", "Lcom/microblink/hardware/camera/CameraType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMERA_DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.CameraType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CAMERA_FRONTFACE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']/field[@name='CAMERA_FRONTFACE']"
		[Register ("CAMERA_FRONTFACE")]
		public static global::Com.Microblink.Hardware.Camera.CameraType CameraFrontface {
			get {
				if (CAMERA_FRONTFACE_jfieldId == IntPtr.Zero)
					CAMERA_FRONTFACE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA_FRONTFACE", "Lcom/microblink/hardware/camera/CameraType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMERA_FRONTFACE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.CameraType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/hardware/camera/CameraType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraType); }
		}

		internal CameraType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/hardware/camera/CameraType;", "")]
		public static unsafe global::Com.Microblink.Hardware.Camera.CameraType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/hardware/camera/CameraType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Hardware.Camera.CameraType __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.CameraType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/hardware/camera/CameraType;", "")]
		public static unsafe global::Com.Microblink.Hardware.Camera.CameraType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/hardware/camera/CameraType;");
			try {
				return (global::Com.Microblink.Hardware.Camera.CameraType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Hardware.Camera.CameraType));
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='CameraType']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
