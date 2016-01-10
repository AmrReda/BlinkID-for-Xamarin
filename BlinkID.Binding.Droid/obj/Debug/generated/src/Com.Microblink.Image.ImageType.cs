using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']"
	[global::Android.Runtime.Register ("com/microblink/image/ImageType", DoNotGenerateAcw=true)]
	public sealed partial class ImageType : global::Java.Lang.Enum {


		static IntPtr BEST_QUALITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/field[@name='BEST_QUALITY']"
		[Register ("BEST_QUALITY")]
		public static global::Com.Microblink.Image.ImageType BestQuality {
			get {
				if (BEST_QUALITY_jfieldId == IntPtr.Zero)
					BEST_QUALITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BEST_QUALITY", "Lcom/microblink/image/ImageType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BEST_QUALITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COLOR_DROP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/field[@name='COLOR_DROP']"
		[Register ("COLOR_DROP")]
		public static global::Com.Microblink.Image.ImageType ColorDrop {
			get {
				if (COLOR_DROP_jfieldId == IntPtr.Zero)
					COLOR_DROP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COLOR_DROP", "Lcom/microblink/image/ImageType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COLOR_DROP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DETECTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/field[@name='DETECTION']"
		[Register ("DETECTION")]
		public static global::Com.Microblink.Image.ImageType Detection {
			get {
				if (DETECTION_jfieldId == IntPtr.Zero)
					DETECTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DETECTION", "Lcom/microblink/image/ImageType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DETECTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEWARPED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/field[@name='DEWARPED']"
		[Register ("DEWARPED")]
		public static global::Com.Microblink.Image.ImageType Dewarped {
			get {
				if (DEWARPED_jfieldId == IntPtr.Zero)
					DEWARPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEWARPED", "Lcom/microblink/image/ImageType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEWARPED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GRAYSCALE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/field[@name='GRAYSCALE']"
		[Register ("GRAYSCALE")]
		public static global::Com.Microblink.Image.ImageType Grayscale {
			get {
				if (GRAYSCALE_jfieldId == IntPtr.Zero)
					GRAYSCALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GRAYSCALE", "Lcom/microblink/image/ImageType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GRAYSCALE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OCR_PREPROCESSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/field[@name='OCR_PREPROCESSED']"
		[Register ("OCR_PREPROCESSED")]
		public static global::Com.Microblink.Image.ImageType OcrPreprocessed {
			get {
				if (OCR_PREPROCESSED_jfieldId == IntPtr.Zero)
					OCR_PREPROCESSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OCR_PREPROCESSED", "Lcom/microblink/image/ImageType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OCR_PREPROCESSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ORIGINAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/field[@name='ORIGINAL']"
		[Register ("ORIGINAL")]
		public static global::Com.Microblink.Image.ImageType Original {
			get {
				if (ORIGINAL_jfieldId == IntPtr.Zero)
					ORIGINAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORIGINAL", "Lcom/microblink/image/ImageType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORIGINAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUCCESSFUL_SCAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/field[@name='SUCCESSFUL_SCAN']"
		[Register ("SUCCESSFUL_SCAN")]
		public static global::Com.Microblink.Image.ImageType SuccessfulScan {
			get {
				if (SUCCESSFUL_SCAN_jfieldId == IntPtr.Zero)
					SUCCESSFUL_SCAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESSFUL_SCAN", "Lcom/microblink/image/ImageType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESSFUL_SCAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/image/ImageType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageType); }
		}

		internal ImageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/image/ImageType;", "")]
		public static unsafe global::Com.Microblink.Image.ImageType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/image/ImageType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Image.ImageType __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='ImageType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/image/ImageType;", "")]
		public static unsafe global::Com.Microblink.Image.ImageType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/image/ImageType;");
			try {
				return (global::Com.Microblink.Image.ImageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Image.ImageType));
			} finally {
			}
		}

	}
}
