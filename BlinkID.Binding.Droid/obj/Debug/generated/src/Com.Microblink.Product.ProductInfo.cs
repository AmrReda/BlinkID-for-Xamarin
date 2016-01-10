using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Product {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.product']/class[@name='ProductInfo']"
	[global::Android.Runtime.Register ("com/microblink/product/ProductInfo", DoNotGenerateAcw=true)]
	public partial class ProductInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/product/ProductInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProductInfo); }
		}

		protected ProductInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_product_Product_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.product']/class[@name='ProductInfo']/constructor[@name='ProductInfo' and count(parameter)=2 and parameter[1][@type='com.microblink.product.Product'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/microblink/product/Product;Ljava/lang/String;)V", "")]
		public unsafe ProductInfo (global::Com.Microblink.Product.Product p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (ProductInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/product/Product;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/product/Product;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_product_Product_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_product_Product_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/product/Product;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_product_Product_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_product_Product_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getProduct;
#pragma warning disable 0169
		static Delegate GetGetProductHandler ()
		{
			if (cb_getProduct == null)
				cb_getProduct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProduct);
			return cb_getProduct;
		}

		static IntPtr n_GetProduct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Product.ProductInfo __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.ProductInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Product);
		}
#pragma warning restore 0169

		static IntPtr id_getProduct;
		public virtual unsafe global::Com.Microblink.Product.Product Product {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.product']/class[@name='ProductInfo']/method[@name='getProduct' and count(parameter)=0]"
			[Register ("getProduct", "()Lcom/microblink/product/Product;", "GetGetProductHandler")]
			get {
				if (id_getProduct == IntPtr.Zero)
					id_getProduct = JNIEnv.GetMethodID (class_ref, "getProduct", "()Lcom/microblink/product/Product;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (JNIEnv.CallObjectMethod  (Handle, id_getProduct), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.Product> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProduct", "()Lcom/microblink/product/Product;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProductVersion;
#pragma warning disable 0169
		static Delegate GetGetProductVersionHandler ()
		{
			if (cb_getProductVersion == null)
				cb_getProductVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductVersion);
			return cb_getProductVersion;
		}

		static IntPtr n_GetProductVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Product.ProductInfo __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.ProductInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getProductVersion;
		public virtual unsafe string ProductVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.product']/class[@name='ProductInfo']/method[@name='getProductVersion' and count(parameter)=0]"
			[Register ("getProductVersion", "()Ljava/lang/String;", "GetGetProductVersionHandler")]
			get {
				if (id_getProductVersion == IntPtr.Zero)
					id_getProductVersion = JNIEnv.GetMethodID (class_ref, "getProductVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProductVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProductVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
