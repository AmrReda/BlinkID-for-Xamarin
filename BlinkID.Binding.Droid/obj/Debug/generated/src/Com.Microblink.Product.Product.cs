using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Product {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']"
	[global::Android.Runtime.Register ("com/microblink/product/Product", DoNotGenerateAcw=true)]
	public sealed partial class Product : global::Java.Lang.Enum {


		static IntPtr BlinkID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='BlinkID']"
		[Register ("BlinkID")]
		public static global::Com.Microblink.Product.Product BlinkID {
			get {
				if (BlinkID_jfieldId == IntPtr.Zero)
					BlinkID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BlinkID", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BlinkID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BlinkIDCore_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='BlinkIDCore']"
		[Register ("BlinkIDCore")]
		public static global::Com.Microblink.Product.Product BlinkIDCore {
			get {
				if (BlinkIDCore_jfieldId == IntPtr.Zero)
					BlinkIDCore_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BlinkIDCore", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BlinkIDCore_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BlinkOCR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='BlinkOCR']"
		[Register ("BlinkOCR")]
		public static global::Com.Microblink.Product.Product BlinkOCR {
			get {
				if (BlinkOCR_jfieldId == IntPtr.Zero)
					BlinkOCR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BlinkOCR", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BlinkOCR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BlinkOCRCore_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='BlinkOCRCore']"
		[Register ("BlinkOCRCore")]
		public static global::Com.Microblink.Product.Product BlinkOCRCore {
			get {
				if (BlinkOCRCore_jfieldId == IntPtr.Zero)
					BlinkOCRCore_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BlinkOCRCore", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BlinkOCRCore_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InvalidProduct_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='InvalidProduct']"
		[Register ("InvalidProduct")]
		public static global::Com.Microblink.Product.Product InvalidProduct {
			get {
				if (InvalidProduct_jfieldId == IntPtr.Zero)
					InvalidProduct_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InvalidProduct", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InvalidProduct_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Pdf417Mobi_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='Pdf417Mobi']"
		[Register ("Pdf417Mobi")]
		public static global::Com.Microblink.Product.Product Pdf417Mobi {
			get {
				if (Pdf417Mobi_jfieldId == IntPtr.Zero)
					Pdf417Mobi_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pdf417Mobi", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Pdf417Mobi_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Pdf417MobiCore_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='Pdf417MobiCore']"
		[Register ("Pdf417MobiCore")]
		public static global::Com.Microblink.Product.Product Pdf417MobiCore {
			get {
				if (Pdf417MobiCore_jfieldId == IntPtr.Zero)
					Pdf417MobiCore_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Pdf417MobiCore", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Pdf417MobiCore_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PhotoMath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='PhotoMath']"
		[Register ("PhotoMath")]
		public static global::Com.Microblink.Product.Product PhotoMath {
			get {
				if (PhotoMath_jfieldId == IntPtr.Zero)
					PhotoMath_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PhotoMath", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PhotoMath_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PhotoPay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='PhotoPay']"
		[Register ("PhotoPay")]
		public static global::Com.Microblink.Product.Product PhotoPay {
			get {
				if (PhotoPay_jfieldId == IntPtr.Zero)
					PhotoPay_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PhotoPay", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PhotoPay_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PhotoPayDrone_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/field[@name='PhotoPayDrone']"
		[Register ("PhotoPayDrone")]
		public static global::Com.Microblink.Product.Product PhotoPayDrone {
			get {
				if (PhotoPayDrone_jfieldId == IntPtr.Zero)
					PhotoPayDrone_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PhotoPayDrone", "Lcom/microblink/product/Product;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PhotoPayDrone_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/product/Product", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Product); }
		}

		internal Product (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/product/Product;", "")]
		public static unsafe global::Com.Microblink.Product.Product ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/product/Product;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Product.Product __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.product']/class[@name='Product']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/product/Product;", "")]
		public static unsafe global::Com.Microblink.Product.Product[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/product/Product;");
			try {
				return (global::Com.Microblink.Product.Product[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Product.Product));
			} finally {
			}
		}

	}
}
