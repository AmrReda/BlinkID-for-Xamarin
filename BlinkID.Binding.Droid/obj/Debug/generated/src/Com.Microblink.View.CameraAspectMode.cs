using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view']/class[@name='CameraAspectMode']"
	[global::Android.Runtime.Register ("com/microblink/view/CameraAspectMode", DoNotGenerateAcw=true)]
	public sealed partial class CameraAspectMode : global::Java.Lang.Enum, global::Android.OS.IParcelable {


		static IntPtr ASPECT_FILL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='CameraAspectMode']/field[@name='ASPECT_FILL']"
		[Register ("ASPECT_FILL")]
		public static global::Com.Microblink.View.CameraAspectMode AspectFill {
			get {
				if (ASPECT_FILL_jfieldId == IntPtr.Zero)
					ASPECT_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASPECT_FILL", "Lcom/microblink/view/CameraAspectMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASPECT_FILL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.CameraAspectMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ASPECT_FIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='CameraAspectMode']/field[@name='ASPECT_FIT']"
		[Register ("ASPECT_FIT")]
		public static global::Com.Microblink.View.CameraAspectMode AspectFit {
			get {
				if (ASPECT_FIT_jfieldId == IntPtr.Zero)
					ASPECT_FIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASPECT_FIT", "Lcom/microblink/view/CameraAspectMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASPECT_FIT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.CameraAspectMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='CameraAspectMode']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/view/CameraAspectMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraAspectMode); }
		}

		internal CameraAspectMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='CameraAspectMode']/method[@name='describeContents' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='CameraAspectMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/view/CameraAspectMode;", "")]
		public static unsafe global::Com.Microblink.View.CameraAspectMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/view/CameraAspectMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.View.CameraAspectMode __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.CameraAspectMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='CameraAspectMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/view/CameraAspectMode;", "")]
		public static unsafe global::Com.Microblink.View.CameraAspectMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/view/CameraAspectMode;");
			try {
				return (global::Com.Microblink.View.CameraAspectMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.View.CameraAspectMode));
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='CameraAspectMode']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
