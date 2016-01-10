using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Ocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']"
	[global::Android.Runtime.Register ("com/microblink/ocr/ScanConfiguration", DoNotGenerateAcw=true)]
	public partial class ScanConfiguration : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/ocr/ScanConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScanConfiguration); }
		}

		protected ScanConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILjava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/constructor[@name='ScanConfiguration' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.microblink.recognizers.blinkocr.parser.OcrParserSettings']]"
		[Register (".ctor", "(IILjava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V", "")]
		public unsafe ScanConfiguration (int p0, int p1, string p2, global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ScanConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILjava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILjava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V", __args);
					return;
				}

				if (id_ctor_IILjava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILjava_lang_String_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getParserName;
#pragma warning disable 0169
		static Delegate GetGetParserNameHandler ()
		{
			if (cb_getParserName == null)
				cb_getParserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParserName);
			return cb_getParserName;
		}

		static IntPtr n_GetParserName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParserName);
		}
#pragma warning restore 0169

		static Delegate cb_setParserName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParserName_Ljava_lang_String_Handler ()
		{
			if (cb_setParserName_Ljava_lang_String_ == null)
				cb_setParserName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParserName_Ljava_lang_String_);
			return cb_setParserName_Ljava_lang_String_;
		}

		static void n_SetParserName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParserName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParserName;
		static IntPtr id_setParserName_Ljava_lang_String_;
		public virtual unsafe string ParserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='getParserName' and count(parameter)=0]"
			[Register ("getParserName", "()Ljava/lang/String;", "GetGetParserNameHandler")]
			get {
				if (id_getParserName == IntPtr.Zero)
					id_getParserName = JNIEnv.GetMethodID (class_ref, "getParserName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParserName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParserName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='setParserName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setParserName", "(Ljava/lang/String;)V", "GetSetParserName_Ljava_lang_String_Handler")]
			set {
				if (id_setParserName_Ljava_lang_String_ == IntPtr.Zero)
					id_setParserName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setParserName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setParserName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParserName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getParserSettings;
#pragma warning disable 0169
		static Delegate GetGetParserSettingsHandler ()
		{
			if (cb_getParserSettings == null)
				cb_getParserSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParserSettings);
			return cb_getParserSettings;
		}

		static IntPtr n_GetParserSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParserSettings);
		}
#pragma warning restore 0169

		static Delegate cb_setParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
#pragma warning disable 0169
		static Delegate GetSetParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_Handler ()
		{
			if (cb_setParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ == null)
				cb_setParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_);
			return cb_setParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
		}

		static void n_SetParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParserSettings = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParserSettings;
		static IntPtr id_setParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_;
		public virtual unsafe global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings ParserSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='getParserSettings' and count(parameter)=0]"
			[Register ("getParserSettings", "()Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;", "GetGetParserSettingsHandler")]
			get {
				if (id_getParserSettings == IntPtr.Zero)
					id_getParserSettings = JNIEnv.GetMethodID (class_ref, "getParserSettings", "()Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings> (JNIEnv.CallObjectMethod  (Handle, id_getParserSettings), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParserSettings", "()Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='setParserSettings' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.blinkocr.parser.OcrParserSettings']]"
			[Register ("setParserSettings", "(Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V", "GetSetParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_Handler")]
			set {
				if (id_setParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ == IntPtr.Zero)
					id_setParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_ = JNIEnv.GetMethodID (class_ref, "setParserSettings", "(Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setParserSettings_Lcom_microblink_recognizers_blinkocr_parser_OcrParserSettings_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParserSettings", "(Lcom/microblink/recognizers/blinkocr/parser/OcrParserSettings;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextResource;
#pragma warning disable 0169
		static Delegate GetGetTextResourceHandler ()
		{
			if (cb_getTextResource == null)
				cb_getTextResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextResource);
			return cb_getTextResource;
		}

		static int n_GetTextResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextResource;
		}
#pragma warning restore 0169

		static Delegate cb_setTextResource_I;
#pragma warning disable 0169
		static Delegate GetSetTextResource_IHandler ()
		{
			if (cb_setTextResource_I == null)
				cb_setTextResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextResource_I);
			return cb_setTextResource_I;
		}

		static void n_SetTextResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextResource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextResource;
		static IntPtr id_setTextResource_I;
		public virtual unsafe int TextResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='getTextResource' and count(parameter)=0]"
			[Register ("getTextResource", "()I", "GetGetTextResourceHandler")]
			get {
				if (id_getTextResource == IntPtr.Zero)
					id_getTextResource = JNIEnv.GetMethodID (class_ref, "getTextResource", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTextResource);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextResource", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='setTextResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextResource", "(I)V", "GetSetTextResource_IHandler")]
			set {
				if (id_setTextResource_I == IntPtr.Zero)
					id_setTextResource_I = JNIEnv.GetMethodID (class_ref, "setTextResource", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTextResource_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextResource", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitleResource;
#pragma warning disable 0169
		static Delegate GetGetTitleResourceHandler ()
		{
			if (cb_getTitleResource == null)
				cb_getTitleResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTitleResource);
			return cb_getTitleResource;
		}

		static int n_GetTitleResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TitleResource;
		}
#pragma warning restore 0169

		static Delegate cb_setTitleResource_I;
#pragma warning disable 0169
		static Delegate GetSetTitleResource_IHandler ()
		{
			if (cb_setTitleResource_I == null)
				cb_setTitleResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTitleResource_I);
			return cb_setTitleResource_I;
		}

		static void n_SetTitleResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TitleResource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitleResource;
		static IntPtr id_setTitleResource_I;
		public virtual unsafe int TitleResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='getTitleResource' and count(parameter)=0]"
			[Register ("getTitleResource", "()I", "GetGetTitleResourceHandler")]
			get {
				if (id_getTitleResource == IntPtr.Zero)
					id_getTitleResource = JNIEnv.GetMethodID (class_ref, "getTitleResource", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTitleResource);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleResource", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='setTitleResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTitleResource", "(I)V", "GetSetTitleResource_IHandler")]
			set {
				if (id_setTitleResource_I == IntPtr.Zero)
					id_setTitleResource_I = JNIEnv.GetMethodID (class_ref, "setTitleResource", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTitleResource_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitleResource", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_loadTitle_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetLoadTitle_Landroid_content_Context_Handler ()
		{
			if (cb_loadTitle_Landroid_content_Context_ == null)
				cb_loadTitle_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadTitle_Landroid_content_Context_);
			return cb_loadTitle_Landroid_content_Context_;
		}

		static void n_LoadTitle_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadTitle_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='loadTitle' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("loadTitle", "(Landroid/content/Context;)V", "GetLoadTitle_Landroid_content_Context_Handler")]
		public virtual unsafe void LoadTitle (global::Android.Content.Context p0)
		{
			if (id_loadTitle_Landroid_content_Context_ == IntPtr.Zero)
				id_loadTitle_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "loadTitle", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadTitle_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadTitle", "(Landroid/content/Context;)V"), __args);
			} finally {
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
			global::Com.Microblink.Ocr.ScanConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Ocr.ScanConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.ocr']/class[@name='ScanConfiguration']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
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
