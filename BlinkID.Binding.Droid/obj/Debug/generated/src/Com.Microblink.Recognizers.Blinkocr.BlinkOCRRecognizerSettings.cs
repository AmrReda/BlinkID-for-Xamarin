using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkocr/BlinkOCRRecognizerSettings", DoNotGenerateAcw=true)]
	public partial class BlinkOCRRecognizerSettings : global::Com.Microblink.Recognizers.Settings.RecognizerSettings {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/field[@name='kDefaultParserGroup']"
		[Register ("kDefaultParserGroup")]
		public const string KDefaultParserGroup = (string) "defaultParserGroup";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkocr/BlinkOCRRecognizerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlinkOCRRecognizerSettings); }
		}

		protected BlinkOCRRecognizerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/constructor[@name='BlinkOCRRecognizerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlinkOCRRecognizerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BlinkOCRRecognizerSettings)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_addParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
#pragma warning disable 0169
		static Delegate GetAddParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_Handler ()
		{
			if (cb_addParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ == null)
				cb_addParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_);
			return cb_addParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
		}

		static void n_AddParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings p1 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddParser (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/method[@name='addParser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.microblink.recognizers.blinkocr.parser.OcrParserSettings']]"
		[Register ("addParser", "(Ljava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V", "GetAddParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_Handler")]
		public virtual unsafe void AddParser (string p0, global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings p1)
		{
			if (id_addParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ == IntPtr.Zero)
				id_addParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ = JNIEnv.GetMethodID (class_ref, "addParser", "(Ljava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addParser_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addParser", "(Ljava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
#pragma warning disable 0169
		static Delegate GetAddParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_Handler ()
		{
			if (cb_addParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ == null)
				cb_addParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_);
			return cb_addParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
		}

		static void n_AddParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings p2 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddParserToParserGroup (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/method[@name='addParserToParserGroup' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.microblink.recognizers.blinkocr.parser.OcrParserSettings']]"
		[Register ("addParserToParserGroup", "(Ljava/lang/String;Ljava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V", "GetAddParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_Handler")]
		public virtual unsafe void AddParserToParserGroup (string p0, string p1, global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings p2)
		{
			if (id_addParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ == IntPtr.Zero)
				id_addParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ = JNIEnv.GetMethodID (class_ref, "addParserToParserGroup", "(Ljava/lang/String;Ljava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addParserToParserGroup_Ljava_lang_String_Ljava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addParserToParserGroup", "(Ljava/lang/String;Ljava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeAllParsers;
#pragma warning disable 0169
		static Delegate GetRemoveAllParsersHandler ()
		{
			if (cb_removeAllParsers == null)
				cb_removeAllParsers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllParsers);
			return cb_removeAllParsers;
		}

		static void n_RemoveAllParsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllParsers ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllParsers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/method[@name='removeAllParsers' and count(parameter)=0]"
		[Register ("removeAllParsers", "()V", "GetRemoveAllParsersHandler")]
		public virtual unsafe void RemoveAllParsers ()
		{
			if (id_removeAllParsers == IntPtr.Zero)
				id_removeAllParsers = JNIEnv.GetMethodID (class_ref, "removeAllParsers", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeAllParsers);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllParsers", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAllParsersFromGroup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAllParsersFromGroup_Ljava_lang_String_Handler ()
		{
			if (cb_removeAllParsersFromGroup_Ljava_lang_String_ == null)
				cb_removeAllParsersFromGroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveAllParsersFromGroup_Ljava_lang_String_);
			return cb_removeAllParsersFromGroup_Ljava_lang_String_;
		}

		static void n_RemoveAllParsersFromGroup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllParsersFromGroup (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeAllParsersFromGroup_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/method[@name='removeAllParsersFromGroup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeAllParsersFromGroup", "(Ljava/lang/String;)V", "GetRemoveAllParsersFromGroup_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveAllParsersFromGroup (string p0)
		{
			if (id_removeAllParsersFromGroup_Ljava_lang_String_ == IntPtr.Zero)
				id_removeAllParsersFromGroup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAllParsersFromGroup", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeAllParsersFromGroup_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllParsersFromGroup", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeParser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveParser_Ljava_lang_String_Handler ()
		{
			if (cb_removeParser_Ljava_lang_String_ == null)
				cb_removeParser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveParser_Ljava_lang_String_);
			return cb_removeParser_Ljava_lang_String_;
		}

		static void n_RemoveParser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveParser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeParser_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/method[@name='removeParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeParser", "(Ljava/lang/String;)V", "GetRemoveParser_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveParser (string p0)
		{
			if (id_removeParser_Ljava_lang_String_ == IntPtr.Zero)
				id_removeParser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeParser", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeParser_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeParser", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveParserFromParserGroup (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/method[@name='removeParserFromParserGroup' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeParserFromParserGroup", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveParserFromParserGroup (string p0, string p1)
		{
			if (id_removeParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeParserFromParserGroup", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeParserFromParserGroup_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeParserFromParserGroup", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.BlinkOCRRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr']/class[@name='BlinkOCRRecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
