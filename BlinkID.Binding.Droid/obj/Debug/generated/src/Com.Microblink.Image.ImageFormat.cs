using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageFormat']"
	[global::Android.Runtime.Register ("com/microblink/image/ImageFormat", DoNotGenerateAcw=true)]
	public sealed partial class ImageFormat : global::Java.Lang.Enum {


		static IntPtr ALPHA_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageFormat']/field[@name='ALPHA_8']"
		[Register ("ALPHA_8")]
		public static global::Com.Microblink.Image.ImageFormat Alpha8 {
			get {
				if (ALPHA_8_jfieldId == IntPtr.Zero)
					ALPHA_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALPHA_8", "Lcom/microblink/image/ImageFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALPHA_8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BGRA_8888_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageFormat']/field[@name='BGRA_8888']"
		[Register ("BGRA_8888")]
		public static global::Com.Microblink.Image.ImageFormat Bgra8888 {
			get {
				if (BGRA_8888_jfieldId == IntPtr.Zero)
					BGRA_8888_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BGRA_8888", "Lcom/microblink/image/ImageFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BGRA_8888_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YUV_NV21_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageFormat']/field[@name='YUV_NV21']"
		[Register ("YUV_NV21")]
		public static global::Com.Microblink.Image.ImageFormat YuvNv21 {
			get {
				if (YUV_NV21_jfieldId == IntPtr.Zero)
					YUV_NV21_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YUV_NV21", "Lcom/microblink/image/ImageFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YUV_NV21_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/image/ImageFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageFormat); }
		}

		internal ImageFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/image/ImageFormat;", "")]
		public static unsafe global::Com.Microblink.Image.ImageFormat ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/image/ImageFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Image.ImageFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/image/ImageFormat;", "")]
		public static unsafe global::Com.Microblink.Image.ImageFormat[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/image/ImageFormat;");
			try {
				return (global::Com.Microblink.Image.ImageFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Image.ImageFormat));
			} finally {
			}
		}

	}
}
