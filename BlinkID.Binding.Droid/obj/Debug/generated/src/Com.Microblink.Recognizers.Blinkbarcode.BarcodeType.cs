using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkbarcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkbarcode/BarcodeType", DoNotGenerateAcw=true)]
	public sealed partial class BarcodeType : global::Java.Lang.Enum {


		static IntPtr AZTEC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='AZTEC']"
		[Register ("AZTEC")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Aztec {
			get {
				if (AZTEC_jfieldId == IntPtr.Zero)
					AZTEC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AZTEC", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AZTEC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CODE128_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='CODE128']"
		[Register ("CODE128")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Code128 {
			get {
				if (CODE128_jfieldId == IntPtr.Zero)
					CODE128_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE128", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE128_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CODE39_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='CODE39']"
		[Register ("CODE39")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Code39 {
			get {
				if (CODE39_jfieldId == IntPtr.Zero)
					CODE39_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CODE39", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CODE39_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DATA_MATRIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='DATA_MATRIX']"
		[Register ("DATA_MATRIX")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType DataMatrix {
			get {
				if (DATA_MATRIX_jfieldId == IntPtr.Zero)
					DATA_MATRIX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_MATRIX", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_MATRIX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EAN13_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='EAN13']"
		[Register ("EAN13")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Ean13 {
			get {
				if (EAN13_jfieldId == IntPtr.Zero)
					EAN13_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EAN13", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EAN13_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EAN8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='EAN8']"
		[Register ("EAN8")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Ean8 {
			get {
				if (EAN8_jfieldId == IntPtr.Zero)
					EAN8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EAN8", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EAN8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ITF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='ITF']"
		[Register ("ITF")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Itf {
			get {
				if (ITF_jfieldId == IntPtr.Zero)
					ITF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ITF", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ITF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PDF417_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='PDF417']"
		[Register ("PDF417")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Pdf417 {
			get {
				if (PDF417_jfieldId == IntPtr.Zero)
					PDF417_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDF417", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDF417_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr QR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='QR']"
		[Register ("QR")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Qr {
			get {
				if (QR_jfieldId == IntPtr.Zero)
					QR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QR", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPCA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='UPCA']"
		[Register ("UPCA")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Upca {
			get {
				if (UPCA_jfieldId == IntPtr.Zero)
					UPCA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPCA", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPCA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/field[@name='UPCE']"
		[Register ("UPCE")]
		public static global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType Upce {
			get {
				if (UPCE_jfieldId == IntPtr.Zero)
					UPCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPCE", "Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkbarcode/BarcodeType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeType); }
		}

		internal BarcodeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/recognizers/blinkbarcode/BarcodeType;", "")]
		public static unsafe global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode']/class[@name='BarcodeType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/recognizers/blinkbarcode/BarcodeType;", "")]
		public static unsafe global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
			try {
				return (global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType));
			} finally {
			}
		}

	}
}
