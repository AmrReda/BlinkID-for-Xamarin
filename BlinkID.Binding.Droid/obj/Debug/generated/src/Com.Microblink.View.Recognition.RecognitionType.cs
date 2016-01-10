using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Recognition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognitionType']"
	[global::Android.Runtime.Register ("com/microblink/view/recognition/RecognitionType", DoNotGenerateAcw=true)]
	public sealed partial class RecognitionType : global::Java.Lang.Enum {


		static IntPtr PARTIAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognitionType']/field[@name='PARTIAL']"
		[Register ("PARTIAL")]
		public static global::Com.Microblink.View.Recognition.RecognitionType Partial {
			get {
				if (PARTIAL_jfieldId == IntPtr.Zero)
					PARTIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARTIAL", "Lcom/microblink/view/recognition/RecognitionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARTIAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognitionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUCCESSFUL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognitionType']/field[@name='SUCCESSFUL']"
		[Register ("SUCCESSFUL")]
		public static global::Com.Microblink.View.Recognition.RecognitionType Successful {
			get {
				if (SUCCESSFUL_jfieldId == IntPtr.Zero)
					SUCCESSFUL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESSFUL", "Lcom/microblink/view/recognition/RecognitionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESSFUL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognitionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNSUCCESSFUL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognitionType']/field[@name='UNSUCCESSFUL']"
		[Register ("UNSUCCESSFUL")]
		public static global::Com.Microblink.View.Recognition.RecognitionType Unsuccessful {
			get {
				if (UNSUCCESSFUL_jfieldId == IntPtr.Zero)
					UNSUCCESSFUL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUCCESSFUL", "Lcom/microblink/view/recognition/RecognitionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSUCCESSFUL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognitionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/recognition/RecognitionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognitionType); }
		}

		internal RecognitionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognitionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/view/recognition/RecognitionType;", "")]
		public static unsafe global::Com.Microblink.View.Recognition.RecognitionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/view/recognition/RecognitionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.View.Recognition.RecognitionType __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognitionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.recognition']/class[@name='RecognitionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/view/recognition/RecognitionType;", "")]
		public static unsafe global::Com.Microblink.View.Recognition.RecognitionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/view/recognition/RecognitionType;");
			try {
				return (global::Com.Microblink.View.Recognition.RecognitionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.View.Recognition.RecognitionType));
			} finally {
			}
		}

	}
}
