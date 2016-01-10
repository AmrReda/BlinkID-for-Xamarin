using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Results.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='ElementType']"
	[global::Android.Runtime.Register ("com/microblink/results/barcode/ElementType", DoNotGenerateAcw=true)]
	public sealed partial class ElementType : global::Java.Lang.Enum {


		static IntPtr BYTE_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='ElementType']/field[@name='BYTE_DATA']"
		[Register ("BYTE_DATA")]
		public static global::Com.Microblink.Results.Barcode.ElementType ByteData {
			get {
				if (BYTE_DATA_jfieldId == IntPtr.Zero)
					BYTE_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_DATA", "Lcom/microblink/results/barcode/ElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.ElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='ElementType']/field[@name='TEXT_DATA']"
		[Register ("TEXT_DATA")]
		public static global::Com.Microblink.Results.Barcode.ElementType TextData {
			get {
				if (TEXT_DATA_jfieldId == IntPtr.Zero)
					TEXT_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_DATA", "Lcom/microblink/results/barcode/ElementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.ElementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/results/barcode/ElementType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ElementType); }
		}

		internal ElementType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='ElementType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/results/barcode/ElementType;", "")]
		public static unsafe global::Com.Microblink.Results.Barcode.ElementType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/results/barcode/ElementType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Results.Barcode.ElementType __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.ElementType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='ElementType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/results/barcode/ElementType;", "")]
		public static unsafe global::Com.Microblink.Results.Barcode.ElementType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/results/barcode/ElementType;");
			try {
				return (global::Com.Microblink.Results.Barcode.ElementType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Results.Barcode.ElementType));
			} finally {
			}
		}

	}
}
