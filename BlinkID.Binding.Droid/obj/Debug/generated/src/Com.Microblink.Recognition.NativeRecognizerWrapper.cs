using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']"
	[global::Android.Runtime.Register ("com/microblink/recognition/NativeRecognizerWrapper", DoNotGenerateAcw=true)]
	public sealed partial class NativeRecognizerWrapper : global::Java.Lang.Enum {


		static IntPtr IlIllIlIIl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/field[@name='IlIllIlIIl']"
		[Register ("IlIllIlIIl")]
		public static global::Com.Microblink.Recognition.NativeRecognizerWrapper IlIllIlIIl {
			get {
				if (IlIllIlIIl_jfieldId == IntPtr.Zero)
					IlIllIlIIl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IlIllIlIIl", "Lcom/microblink/recognition/NativeRecognizerWrapper;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IlIllIlIIl_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognition.NativeRecognizerWrapper> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr llIllllIIl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/field[@name='llIllllIIl']"
		[Register ("llIllllIIl")]
		public bool LlIllllIIl {
			get {
				if (llIllllIIl_jfieldId == IntPtr.Zero)
					llIllllIIl_jfieldId = JNIEnv.GetFieldID (class_ref, "llIllllIIl", "Z");
				return JNIEnv.GetBooleanField (Handle, llIllllIIl_jfieldId);
			}
			set {
				if (llIllllIIl_jfieldId == IntPtr.Zero)
					llIllllIIl_jfieldId = JNIEnv.GetFieldID (class_ref, "llIllllIIl", "Z");
				try {
					JNIEnv.SetField (Handle, llIllllIIl_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.recognition']/interface[@name='NativeRecognizerWrapper.IlIllIlIIl']"
		[Register ("com/microblink/recognition/NativeRecognizerWrapper$IlIllIlIIl", "", "Com.Microblink.Recognition.NativeRecognizerWrapper/IIlIllIlIIlInvoker")]
		public partial interface IIlIllIlIIl : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/interface[@name='NativeRecognizerWrapper.IlIllIlIIl']/method[@name='onRecognitionDone' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.BaseRecognitionResult[]']]"
			[Register ("onRecognitionDone", "([Lcom/microblink/recognizers/BaseRecognitionResult;)V", "GetOnRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_Handler:Com.Microblink.Recognition.NativeRecognizerWrapper/IIlIllIlIIlInvoker, BlinkID.Binding.Droid")]
			void OnRecognitionDone (global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/interface[@name='NativeRecognizerWrapper.IlIllIlIIl']/method[@name='onRecognitionDoneWithTimeout' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.BaseRecognitionResult[]']]"
			[Register ("onRecognitionDoneWithTimeout", "([Lcom/microblink/recognizers/BaseRecognitionResult;)V", "GetOnRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_Handler:Com.Microblink.Recognition.NativeRecognizerWrapper/IIlIllIlIIlInvoker, BlinkID.Binding.Droid")]
			void OnRecognitionDoneWithTimeout (global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0);

		}

		[global::Android.Runtime.Register ("com/microblink/recognition/NativeRecognizerWrapper$IlIllIlIIl", DoNotGenerateAcw=true)]
		internal class IIlIllIlIIlInvoker : global::Java.Lang.Object, IIlIllIlIIl {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/recognition/NativeRecognizerWrapper$IlIllIlIIl");
			IntPtr class_ref;

			public static IIlIllIlIIl GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IIlIllIlIIl> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.microblink.recognition.NativeRecognizerWrapper.IlIllIlIIl"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IIlIllIlIIlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IIlIllIlIIlInvoker); }
			}

			static Delegate cb_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_;
#pragma warning disable 0169
			static Delegate GetOnRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_Handler ()
			{
				if (cb_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_ == null)
					cb_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_);
				return cb_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_;
			}

			static void n_OnRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Microblink.Recognition.NativeRecognizerWrapper.IIlIllIlIIl __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognition.NativeRecognizerWrapper.IIlIllIlIIl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0 = (global::Com.Microblink.Recognizers.BaseRecognitionResult[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Microblink.Recognizers.BaseRecognitionResult));
				__this.OnRecognitionDone (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_;
			public unsafe void OnRecognitionDone (global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0)
			{
				if (id_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_ == IntPtr.Zero)
					id_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_ = JNIEnv.GetMethodID (class_ref, "onRecognitionDone", "([Lcom/microblink/recognizers/BaseRecognitionResult;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onRecognitionDone_arrayLcom_microblink_recognizers_BaseRecognitionResult_, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_;
#pragma warning disable 0169
			static Delegate GetOnRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_Handler ()
			{
				if (cb_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_ == null)
					cb_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_);
				return cb_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_;
			}

			static void n_OnRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Microblink.Recognition.NativeRecognizerWrapper.IIlIllIlIIl __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognition.NativeRecognizerWrapper.IIlIllIlIIl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0 = (global::Com.Microblink.Recognizers.BaseRecognitionResult[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Microblink.Recognizers.BaseRecognitionResult));
				__this.OnRecognitionDoneWithTimeout (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_;
			public unsafe void OnRecognitionDoneWithTimeout (global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0)
			{
				if (id_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_ == IntPtr.Zero)
					id_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_ = JNIEnv.GetMethodID (class_ref, "onRecognitionDoneWithTimeout", "([Lcom/microblink/recognizers/BaseRecognitionResult;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onRecognitionDoneWithTimeout_arrayLcom_microblink_recognizers_BaseRecognitionResult_, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.recognition']/interface[@name='NativeRecognizerWrapper.llIIlIlIIl']"
		[Register ("com/microblink/recognition/NativeRecognizerWrapper$llIIlIlIIl", "", "Com.Microblink.Recognition.NativeRecognizerWrapper/ILlIIlIlIIlInvoker")]
		public partial interface ILlIIlIlIIl : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/interface[@name='NativeRecognizerWrapper.llIIlIlIIl']/method[@name='onRecognizerError' and count(parameter)=1 and parameter[1][@type='com.microblink.recognition.RecognizerError']]"
			[Register ("onRecognizerError", "(Lcom/microblink/recognition/RecognizerError;)V", "GetOnRecognizerError_Lcom_microblink_recognition_RecognizerError_Handler:Com.Microblink.Recognition.NativeRecognizerWrapper/ILlIIlIlIIlInvoker, BlinkID.Binding.Droid")]
			void OnRecognizerError (global::Com.Microblink.Recognition.RecognizerError p0);

		}

		[global::Android.Runtime.Register ("com/microblink/recognition/NativeRecognizerWrapper$llIIlIlIIl", DoNotGenerateAcw=true)]
		internal class ILlIIlIlIIlInvoker : global::Java.Lang.Object, ILlIIlIlIIl {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/recognition/NativeRecognizerWrapper$llIIlIlIIl");
			IntPtr class_ref;

			public static ILlIIlIlIIl GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILlIIlIlIIl> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.microblink.recognition.NativeRecognizerWrapper.llIIlIlIIl"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILlIIlIlIIlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILlIIlIlIIlInvoker); }
			}

			static Delegate cb_onRecognizerError_Lcom_microblink_recognition_RecognizerError_;
#pragma warning disable 0169
			static Delegate GetOnRecognizerError_Lcom_microblink_recognition_RecognizerError_Handler ()
			{
				if (cb_onRecognizerError_Lcom_microblink_recognition_RecognizerError_ == null)
					cb_onRecognizerError_Lcom_microblink_recognition_RecognizerError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRecognizerError_Lcom_microblink_recognition_RecognizerError_);
				return cb_onRecognizerError_Lcom_microblink_recognition_RecognizerError_;
			}

			static void n_OnRecognizerError_Lcom_microblink_recognition_RecognizerError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Microblink.Recognition.NativeRecognizerWrapper.ILlIIlIlIIl __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognition.NativeRecognizerWrapper.ILlIIlIlIIl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Microblink.Recognition.RecognizerError p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognition.RecognizerError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRecognizerError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRecognizerError_Lcom_microblink_recognition_RecognizerError_;
			public unsafe void OnRecognizerError (global::Com.Microblink.Recognition.RecognizerError p0)
			{
				if (id_onRecognizerError_Lcom_microblink_recognition_RecognizerError_ == IntPtr.Zero)
					id_onRecognizerError_Lcom_microblink_recognition_RecognizerError_ = JNIEnv.GetMethodID (class_ref, "onRecognizerError", "(Lcom/microblink/recognition/RecognizerError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onRecognizerError_Lcom_microblink_recognition_RecognizerError_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognition/NativeRecognizerWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeRecognizerWrapper); }
		}

		internal NativeRecognizerWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_IIIIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/method[@name='IIIIIIIIII' and count(parameter)=0]"
		[Register ("IIIIIIIIII", "()V", "")]
		public unsafe void IIIIIIIIII ()
		{
			if (id_IIIIIIIIII == IntPtr.Zero)
				id_IIIIIIIIII = JNIEnv.GetMethodID (class_ref, "IIIIIIIIII", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_IIIIIIIIII);
			} finally {
			}
		}

		static IntPtr id_IlIIIIIlll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/method[@name='IlIIIIIlll' and count(parameter)=0]"
		[Register ("IlIIIIIlll", "()V", "")]
		public unsafe void IlIIIIIlll ()
		{
			if (id_IlIIIIIlll == IntPtr.Zero)
				id_IlIIIIIlll = JNIEnv.GetMethodID (class_ref, "IlIIIIIlll", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_IlIIIIIlll);
			} finally {
			}
		}

		static IntPtr id_llIIlIlIIl_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/method[@name='llIIlIlIIl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("llIIlIlIIl", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe string LlIIlIlIIl (string p0, global::Android.Content.Context p1)
		{
			if (id_llIIlIlIIl_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_llIIlIlIIl_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_llIIlIlIIl_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_llIIlIlIIl_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/method[@name='llIIlIlIIl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("llIIlIlIIl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string LlIIlIlIIl (string p0, string p1)
		{
			if (id_llIIlIlIIl_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_llIIlIlIIl_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "llIIlIlIIl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_llIIlIlIIl_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_reset);
			} finally {
			}
		}

		static IntPtr id_terminate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/method[@name='terminate' and count(parameter)=0]"
		[Register ("terminate", "()V", "")]
		public unsafe void Terminate ()
		{
			if (id_terminate == IntPtr.Zero)
				id_terminate = JNIEnv.GetMethodID (class_ref, "terminate", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_terminate);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/recognition/NativeRecognizerWrapper;", "")]
		public static unsafe global::Com.Microblink.Recognition.NativeRecognizerWrapper ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/recognition/NativeRecognizerWrapper;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Recognition.NativeRecognizerWrapper __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognition.NativeRecognizerWrapper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='NativeRecognizerWrapper']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/recognition/NativeRecognizerWrapper;", "")]
		public static unsafe global::Com.Microblink.Recognition.NativeRecognizerWrapper[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/recognition/NativeRecognizerWrapper;");
			try {
				return (global::Com.Microblink.Recognition.NativeRecognizerWrapper[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognition.NativeRecognizerWrapper));
			} finally {
			}
		}

	}
}
