using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognition']/class[@name='ResourceManager']"
	[global::Android.Runtime.Register ("com/microblink/recognition/ResourceManager", DoNotGenerateAcw=true)]
	public sealed partial class ResourceManager : global::Java.Lang.Enum {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognition/ResourceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceManager); }
		}

		internal ResourceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_IIlIlllIIl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='ResourceManager']/method[@name='IIlIlllIIl' and count(parameter)=0]"
		[Register ("IIlIlllIIl", "()V", "")]
		public unsafe void IIlIlllIIl ()
		{
			if (id_IIlIlllIIl == IntPtr.Zero)
				id_IIlIlllIIl = JNIEnv.GetMethodID (class_ref, "IIlIlllIIl", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_IIlIlllIIl);
			} finally {
			}
		}

		static IntPtr id_llIIlIlIIl_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='ResourceManager']/method[@name='llIIlIlIIl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("llIIlIlIIl", "(Landroid/content/Context;)V", "")]
		public unsafe void LlIIlIlIIl (global::Android.Content.Context p0)
		{
			if (id_llIIlIlIIl_Landroid_content_Context_ == IntPtr.Zero)
				id_llIIlIlIIl_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_llIIlIlIIl_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='ResourceManager']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/recognition/ResourceManager;", "")]
		public static unsafe global::Com.Microblink.Recognition.ResourceManager ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/recognition/ResourceManager;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Recognition.ResourceManager __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognition.ResourceManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='ResourceManager']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/recognition/ResourceManager;", "")]
		public static unsafe global::Com.Microblink.Recognition.ResourceManager[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/recognition/ResourceManager;");
			try {
				return (global::Com.Microblink.Recognition.ResourceManager[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognition.ResourceManager));
			} finally {
			}
		}

	}
}
