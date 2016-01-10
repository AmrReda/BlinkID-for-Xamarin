using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']"
	[global::Android.Runtime.Register ("com/microblink/hardware/camera/VideoResolutionPreset", DoNotGenerateAcw=true)]
	public sealed partial class VideoResolutionPreset : global::Java.Lang.Enum, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_RESOLUTION_1080p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/field[@name='VIDEO_RESOLUTION_1080p']"
		[Register ("VIDEO_RESOLUTION_1080p")]
		public static global::Com.Microblink.Hardware.Camera.VideoResolutionPreset VIDEORESOLUTION1080p {
			get {
				if (VIDEO_RESOLUTION_1080p_jfieldId == IntPtr.Zero)
					VIDEO_RESOLUTION_1080p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_RESOLUTION_1080p", "Lcom/microblink/hardware/camera/VideoResolutionPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_RESOLUTION_1080p_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.VideoResolutionPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_RESOLUTION_2160p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/field[@name='VIDEO_RESOLUTION_2160p']"
		[Register ("VIDEO_RESOLUTION_2160p")]
		public static global::Com.Microblink.Hardware.Camera.VideoResolutionPreset VIDEORESOLUTION2160p {
			get {
				if (VIDEO_RESOLUTION_2160p_jfieldId == IntPtr.Zero)
					VIDEO_RESOLUTION_2160p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_RESOLUTION_2160p", "Lcom/microblink/hardware/camera/VideoResolutionPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_RESOLUTION_2160p_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.VideoResolutionPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_RESOLUTION_480p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/field[@name='VIDEO_RESOLUTION_480p']"
		[Register ("VIDEO_RESOLUTION_480p")]
		public static global::Com.Microblink.Hardware.Camera.VideoResolutionPreset VIDEORESOLUTION480p {
			get {
				if (VIDEO_RESOLUTION_480p_jfieldId == IntPtr.Zero)
					VIDEO_RESOLUTION_480p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_RESOLUTION_480p", "Lcom/microblink/hardware/camera/VideoResolutionPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_RESOLUTION_480p_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.VideoResolutionPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_RESOLUTION_720p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/field[@name='VIDEO_RESOLUTION_720p']"
		[Register ("VIDEO_RESOLUTION_720p")]
		public static global::Com.Microblink.Hardware.Camera.VideoResolutionPreset VIDEORESOLUTION720p {
			get {
				if (VIDEO_RESOLUTION_720p_jfieldId == IntPtr.Zero)
					VIDEO_RESOLUTION_720p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_RESOLUTION_720p", "Lcom/microblink/hardware/camera/VideoResolutionPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_RESOLUTION_720p_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.VideoResolutionPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_RESOLUTION_DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/field[@name='VIDEO_RESOLUTION_DEFAULT']"
		[Register ("VIDEO_RESOLUTION_DEFAULT")]
		public static global::Com.Microblink.Hardware.Camera.VideoResolutionPreset VideoResolutionDefault {
			get {
				if (VIDEO_RESOLUTION_DEFAULT_jfieldId == IntPtr.Zero)
					VIDEO_RESOLUTION_DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_RESOLUTION_DEFAULT", "Lcom/microblink/hardware/camera/VideoResolutionPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_RESOLUTION_DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.VideoResolutionPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_RESOLUTION_MAX_AVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/field[@name='VIDEO_RESOLUTION_MAX_AVAILABLE']"
		[Register ("VIDEO_RESOLUTION_MAX_AVAILABLE")]
		public static global::Com.Microblink.Hardware.Camera.VideoResolutionPreset VideoResolutionMaxAvailable {
			get {
				if (VIDEO_RESOLUTION_MAX_AVAILABLE_jfieldId == IntPtr.Zero)
					VIDEO_RESOLUTION_MAX_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_RESOLUTION_MAX_AVAILABLE", "Lcom/microblink/hardware/camera/VideoResolutionPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_RESOLUTION_MAX_AVAILABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.VideoResolutionPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/hardware/camera/VideoResolutionPreset", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoResolutionPreset); }
		}

		internal VideoResolutionPreset (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getIdealHeight;
		public unsafe int IdealHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/method[@name='getIdealHeight' and count(parameter)=0]"
			[Register ("getIdealHeight", "()I", "GetGetIdealHeightHandler")]
			get {
				if (id_getIdealHeight == IntPtr.Zero)
					id_getIdealHeight = JNIEnv.GetMethodID (class_ref, "getIdealHeight", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getIdealHeight);
				} finally {
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/method[@name='describeContents' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/hardware/camera/VideoResolutionPreset;", "")]
		public static unsafe global::Com.Microblink.Hardware.Camera.VideoResolutionPreset ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/hardware/camera/VideoResolutionPreset;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Hardware.Camera.VideoResolutionPreset __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.VideoResolutionPreset> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/hardware/camera/VideoResolutionPreset;", "")]
		public static unsafe global::Com.Microblink.Hardware.Camera.VideoResolutionPreset[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/hardware/camera/VideoResolutionPreset;");
			try {
				return (global::Com.Microblink.Hardware.Camera.VideoResolutionPreset[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Hardware.Camera.VideoResolutionPreset));
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera']/class[@name='VideoResolutionPreset']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
