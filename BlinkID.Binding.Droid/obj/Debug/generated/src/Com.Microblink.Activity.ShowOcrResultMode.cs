using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.activity']/class[@name='ShowOcrResultMode']"
	[global::Android.Runtime.Register ("com/microblink/activity/ShowOcrResultMode", DoNotGenerateAcw=true)]
	public sealed partial class ShowOcrResultMode : global::Java.Lang.Enum, global::Android.OS.IParcelable {


		static IntPtr ANIMATED_DOTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='ShowOcrResultMode']/field[@name='ANIMATED_DOTS']"
		[Register ("ANIMATED_DOTS")]
		public static global::Com.Microblink.Activity.ShowOcrResultMode AnimatedDots {
			get {
				if (ANIMATED_DOTS_jfieldId == IntPtr.Zero)
					ANIMATED_DOTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANIMATED_DOTS", "Lcom/microblink/activity/ShowOcrResultMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANIMATED_DOTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.ShowOcrResultMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='ShowOcrResultMode']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STATIC_CHARS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.activity']/class[@name='ShowOcrResultMode']/field[@name='STATIC_CHARS']"
		[Register ("STATIC_CHARS")]
		public static global::Com.Microblink.Activity.ShowOcrResultMode StaticChars {
			get {
				if (STATIC_CHARS_jfieldId == IntPtr.Zero)
					STATIC_CHARS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STATIC_CHARS", "Lcom/microblink/activity/ShowOcrResultMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STATIC_CHARS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.ShowOcrResultMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/activity/ShowOcrResultMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShowOcrResultMode); }
		}

		internal ShowOcrResultMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='ShowOcrResultMode']/method[@name='describeContents' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='ShowOcrResultMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/activity/ShowOcrResultMode;", "")]
		public static unsafe global::Com.Microblink.Activity.ShowOcrResultMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/activity/ShowOcrResultMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Activity.ShowOcrResultMode __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Activity.ShowOcrResultMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='ShowOcrResultMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/activity/ShowOcrResultMode;", "")]
		public static unsafe global::Com.Microblink.Activity.ShowOcrResultMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/activity/ShowOcrResultMode;");
			try {
				return (global::Com.Microblink.Activity.ShowOcrResultMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Activity.ShowOcrResultMode));
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.activity']/class[@name='ShowOcrResultMode']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
