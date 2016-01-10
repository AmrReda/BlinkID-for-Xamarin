using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Viewfinder.Quadview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewPreset']"
	[global::Android.Runtime.Register ("com/microblink/view/viewfinder/quadview/QuadViewPreset", DoNotGenerateAcw=true)]
	public sealed partial class QuadViewPreset : global::Java.Lang.Enum {


		static IntPtr DEFAULT_CORNERS_FROM_PDF417_SCAN_ACTIVITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewPreset']/field[@name='DEFAULT_CORNERS_FROM_PDF417_SCAN_ACTIVITY']"
		[Register ("DEFAULT_CORNERS_FROM_PDF417_SCAN_ACTIVITY")]
		public static global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset DefaultCornersFromPdf417ScanActivity {
			get {
				if (DEFAULT_CORNERS_FROM_PDF417_SCAN_ACTIVITY_jfieldId == IntPtr.Zero)
					DEFAULT_CORNERS_FROM_PDF417_SCAN_ACTIVITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_CORNERS_FROM_PDF417_SCAN_ACTIVITY", "Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_CORNERS_FROM_PDF417_SCAN_ACTIVITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEFAULT_CORNERS_FROM_SCAN_ACTIVITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewPreset']/field[@name='DEFAULT_CORNERS_FROM_SCAN_ACTIVITY']"
		[Register ("DEFAULT_CORNERS_FROM_SCAN_ACTIVITY")]
		public static global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset DefaultCornersFromScanActivity {
			get {
				if (DEFAULT_CORNERS_FROM_SCAN_ACTIVITY_jfieldId == IntPtr.Zero)
					DEFAULT_CORNERS_FROM_SCAN_ACTIVITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_CORNERS_FROM_SCAN_ACTIVITY", "Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_CORNERS_FROM_SCAN_ACTIVITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEFAULT_FROM_SCAN_CARD_ACTIVITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewPreset']/field[@name='DEFAULT_FROM_SCAN_CARD_ACTIVITY']"
		[Register ("DEFAULT_FROM_SCAN_CARD_ACTIVITY")]
		public static global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset DefaultFromScanCardActivity {
			get {
				if (DEFAULT_FROM_SCAN_CARD_ACTIVITY_jfieldId == IntPtr.Zero)
					DEFAULT_FROM_SCAN_CARD_ACTIVITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_FROM_SCAN_CARD_ACTIVITY", "Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_FROM_SCAN_CARD_ACTIVITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEFAULT_FROM_SCAN_FOV_ACTIVITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewPreset']/field[@name='DEFAULT_FROM_SCAN_FOV_ACTIVITY']"
		[Register ("DEFAULT_FROM_SCAN_FOV_ACTIVITY")]
		public static global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset DefaultFromScanFovActivity {
			get {
				if (DEFAULT_FROM_SCAN_FOV_ACTIVITY_jfieldId == IntPtr.Zero)
					DEFAULT_FROM_SCAN_FOV_ACTIVITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_FROM_SCAN_FOV_ACTIVITY", "Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_FROM_SCAN_FOV_ACTIVITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/viewfinder/quadview/QuadViewPreset", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuadViewPreset); }
		}

		internal QuadViewPreset (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewPreset']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;", "")]
		public static unsafe global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder.quadview']/class[@name='QuadViewPreset']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;", "")]
		public static unsafe global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/view/viewfinder/quadview/QuadViewPreset;");
			try {
				return (global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.View.Viewfinder.Quadview.QuadViewPreset));
			} finally {
			}
		}

	}
}
