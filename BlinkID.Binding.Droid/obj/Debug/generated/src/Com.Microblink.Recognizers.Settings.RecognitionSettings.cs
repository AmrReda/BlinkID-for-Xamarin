using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/settings/RecognitionSettings", DoNotGenerateAcw=true)]
	public partial class RecognitionSettings : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/field[@name='DETECTION_TEST_MODE']"
		[Register ("DETECTION_TEST_MODE")]
		public const int DetectionTestMode = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/field[@name='RECOGNITION_TEST_MODE']"
		[Register ("RECOGNITION_TEST_MODE")]
		public const int RecognitionTestMode = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings.FrameQualityEstimationMode']"
		[global::Android.Runtime.Register ("com/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode", DoNotGenerateAcw=true)]
		public sealed partial class FrameQualityEstimationMode : global::Java.Lang.Enum {


			static IntPtr ALWAYS_OFF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings.FrameQualityEstimationMode']/field[@name='ALWAYS_OFF']"
			[Register ("ALWAYS_OFF")]
			public static global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode AlwaysOff {
				get {
					if (ALWAYS_OFF_jfieldId == IntPtr.Zero)
						ALWAYS_OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_OFF", "Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALWAYS_OFF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ALWAYS_ON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings.FrameQualityEstimationMode']/field[@name='ALWAYS_ON']"
			[Register ("ALWAYS_ON")]
			public static global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode AlwaysOn {
				get {
					if (ALWAYS_ON_jfieldId == IntPtr.Zero)
						ALWAYS_ON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALWAYS_ON", "Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALWAYS_ON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTOMATIC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings.FrameQualityEstimationMode']/field[@name='AUTOMATIC']"
			[Register ("AUTOMATIC")]
			public static global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode Automatic {
				get {
					if (AUTOMATIC_jfieldId == IntPtr.Zero)
						AUTOMATIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTOMATIC", "Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTOMATIC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FrameQualityEstimationMode); }
			}

			internal FrameQualityEstimationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings.FrameQualityEstimationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;", "")]
			public static unsafe global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings.FrameQualityEstimationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;", "")]
			public static unsafe global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;");
				try {
					return (global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/settings/RecognitionSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognitionSettings); }
		}

		protected RecognitionSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/constructor[@name='RecognitionSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecognitionSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecognitionSettings)) {
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

		static Delegate cb_getNumMsBeforeTimeout;
#pragma warning disable 0169
		static Delegate GetGetNumMsBeforeTimeoutHandler ()
		{
			if (cb_getNumMsBeforeTimeout == null)
				cb_getNumMsBeforeTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumMsBeforeTimeout);
			return cb_getNumMsBeforeTimeout;
		}

		static int n_GetNumMsBeforeTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumMsBeforeTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setNumMsBeforeTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetNumMsBeforeTimeout_IHandler ()
		{
			if (cb_setNumMsBeforeTimeout_I == null)
				cb_setNumMsBeforeTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumMsBeforeTimeout_I);
			return cb_setNumMsBeforeTimeout_I;
		}

		static void n_SetNumMsBeforeTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumMsBeforeTimeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNumMsBeforeTimeout;
		static IntPtr id_setNumMsBeforeTimeout_I;
		public virtual unsafe int NumMsBeforeTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='getNumMsBeforeTimeout' and count(parameter)=0]"
			[Register ("getNumMsBeforeTimeout", "()I", "GetGetNumMsBeforeTimeoutHandler")]
			get {
				if (id_getNumMsBeforeTimeout == IntPtr.Zero)
					id_getNumMsBeforeTimeout = JNIEnv.GetMethodID (class_ref, "getNumMsBeforeTimeout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumMsBeforeTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumMsBeforeTimeout", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='setNumMsBeforeTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumMsBeforeTimeout", "(I)V", "GetSetNumMsBeforeTimeout_IHandler")]
			set {
				if (id_setNumMsBeforeTimeout_I == IntPtr.Zero)
					id_setNumMsBeforeTimeout_I = JNIEnv.GetMethodID (class_ref, "setNumMsBeforeTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNumMsBeforeTimeout_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumMsBeforeTimeout", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecognitionMode;
#pragma warning disable 0169
		static Delegate GetGetRecognitionModeHandler ()
		{
			if (cb_getRecognitionMode == null)
				cb_getRecognitionMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRecognitionMode);
			return cb_getRecognitionMode;
		}

		static int n_GetRecognitionMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecognitionMode;
		}
#pragma warning restore 0169

		static Delegate cb_setRecognitionMode_I;
#pragma warning disable 0169
		static Delegate GetSetRecognitionMode_IHandler ()
		{
			if (cb_setRecognitionMode_I == null)
				cb_setRecognitionMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRecognitionMode_I);
			return cb_setRecognitionMode_I;
		}

		static void n_SetRecognitionMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecognitionMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRecognitionMode;
		static IntPtr id_setRecognitionMode_I;
		public virtual unsafe int RecognitionMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='getRecognitionMode' and count(parameter)=0]"
			[Register ("getRecognitionMode", "()I", "GetGetRecognitionModeHandler")]
			get {
				if (id_getRecognitionMode == IntPtr.Zero)
					id_getRecognitionMode = JNIEnv.GetMethodID (class_ref, "getRecognitionMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRecognitionMode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecognitionMode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='setRecognitionMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecognitionMode", "(I)V", "GetSetRecognitionMode_IHandler")]
			set {
				if (id_setRecognitionMode_I == IntPtr.Zero)
					id_setRecognitionMode_I = JNIEnv.GetMethodID (class_ref, "setRecognitionMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRecognitionMode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecognitionMode", "(I)V"), __args);
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
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getFrameQualityEstimationMode;
#pragma warning disable 0169
		static Delegate GetGetFrameQualityEstimationModeHandler ()
		{
			if (cb_getFrameQualityEstimationMode == null)
				cb_getFrameQualityEstimationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrameQualityEstimationMode);
			return cb_getFrameQualityEstimationMode;
		}

		static IntPtr n_GetFrameQualityEstimationMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFrameQualityEstimationMode ());
		}
#pragma warning restore 0169

		static IntPtr id_getFrameQualityEstimationMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='getFrameQualityEstimationMode' and count(parameter)=0]"
		[Register ("getFrameQualityEstimationMode", "()Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;", "GetGetFrameQualityEstimationModeHandler")]
		public virtual unsafe global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode GetFrameQualityEstimationMode ()
		{
			if (id_getFrameQualityEstimationMode == IntPtr.Zero)
				id_getFrameQualityEstimationMode = JNIEnv.GetMethodID (class_ref, "getFrameQualityEstimationMode", "()Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode> (JNIEnv.CallObjectMethod  (Handle, id_getFrameQualityEstimationMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameQualityEstimationMode", "()Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRecognizerSettingsArray;
#pragma warning disable 0169
		static Delegate GetGetRecognizerSettingsArrayHandler ()
		{
			if (cb_getRecognizerSettingsArray == null)
				cb_getRecognizerSettingsArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecognizerSettingsArray);
			return cb_getRecognizerSettingsArray;
		}

		static IntPtr n_GetRecognizerSettingsArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRecognizerSettingsArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getRecognizerSettingsArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='getRecognizerSettingsArray' and count(parameter)=0]"
		[Register ("getRecognizerSettingsArray", "()[Lcom/microblink/recognizers/settings/RecognizerSettings;", "GetGetRecognizerSettingsArrayHandler")]
		public virtual unsafe global::Com.Microblink.Recognizers.Settings.RecognizerSettings[] GetRecognizerSettingsArray ()
		{
			if (id_getRecognizerSettingsArray == IntPtr.Zero)
				id_getRecognizerSettingsArray = JNIEnv.GetMethodID (class_ref, "getRecognizerSettingsArray", "()[Lcom/microblink/recognizers/settings/RecognizerSettings;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.Microblink.Recognizers.Settings.RecognizerSettings[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRecognizerSettingsArray), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognizers.Settings.RecognizerSettings));
				else
					return (global::Com.Microblink.Recognizers.Settings.RecognizerSettings[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecognizerSettingsArray", "()[Lcom/microblink/recognizers/settings/RecognizerSettings;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognizers.Settings.RecognizerSettings));
			} finally {
			}
		}

		static Delegate cb_setAllowMultipleScanResultsOnSingleImage_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowMultipleScanResultsOnSingleImage_ZHandler ()
		{
			if (cb_setAllowMultipleScanResultsOnSingleImage_Z == null)
				cb_setAllowMultipleScanResultsOnSingleImage_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowMultipleScanResultsOnSingleImage_Z);
			return cb_setAllowMultipleScanResultsOnSingleImage_Z;
		}

		static void n_SetAllowMultipleScanResultsOnSingleImage_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowMultipleScanResultsOnSingleImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowMultipleScanResultsOnSingleImage_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='setAllowMultipleScanResultsOnSingleImage' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowMultipleScanResultsOnSingleImage", "(Z)V", "GetSetAllowMultipleScanResultsOnSingleImage_ZHandler")]
		public virtual unsafe void SetAllowMultipleScanResultsOnSingleImage (bool p0)
		{
			if (id_setAllowMultipleScanResultsOnSingleImage_Z == IntPtr.Zero)
				id_setAllowMultipleScanResultsOnSingleImage_Z = JNIEnv.GetMethodID (class_ref, "setAllowMultipleScanResultsOnSingleImage", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAllowMultipleScanResultsOnSingleImage_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllowMultipleScanResultsOnSingleImage", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_;
#pragma warning disable 0169
		static Delegate GetSetFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_Handler ()
		{
			if (cb_setFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_ == null)
				cb_setFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_);
			return cb_setFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_;
		}

		static void n_SetFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFrameQualityEstimationMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='setFrameQualityEstimationMode' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.settings.RecognitionSettings.FrameQualityEstimationMode']]"
		[Register ("setFrameQualityEstimationMode", "(Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;)V", "GetSetFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_Handler")]
		public virtual unsafe void SetFrameQualityEstimationMode (global::Com.Microblink.Recognizers.Settings.RecognitionSettings.FrameQualityEstimationMode p0)
		{
			if (id_setFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_ == IntPtr.Zero)
				id_setFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_ = JNIEnv.GetMethodID (class_ref, "setFrameQualityEstimationMode", "(Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFrameQualityEstimationMode_Lcom_microblink_recognizers_settings_RecognitionSettings_FrameQualityEstimationMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFrameQualityEstimationMode", "(Lcom/microblink/recognizers/settings/RecognitionSettings$FrameQualityEstimationMode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_;
#pragma warning disable 0169
		static Delegate GetSetRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_Handler ()
		{
			if (cb_setRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_ == null)
				cb_setRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_);
			return cb_setRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_;
		}

		static void n_SetRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Settings.RecognizerSettings[] p0 = (global::Com.Microblink.Recognizers.Settings.RecognizerSettings[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Microblink.Recognizers.Settings.RecognizerSettings));
			__this.SetRecognizerSettingsArray (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='setRecognizerSettingsArray' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.settings.RecognizerSettings[]']]"
		[Register ("setRecognizerSettingsArray", "([Lcom/microblink/recognizers/settings/RecognizerSettings;)V", "GetSetRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_Handler")]
		public virtual unsafe void SetRecognizerSettingsArray (global::Com.Microblink.Recognizers.Settings.RecognizerSettings[] p0)
		{
			if (id_setRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_ == IntPtr.Zero)
				id_setRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_ = JNIEnv.GetMethodID (class_ref, "setRecognizerSettingsArray", "([Lcom/microblink/recognizers/settings/RecognizerSettings;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRecognizerSettingsArray_arrayLcom_microblink_recognizers_settings_RecognizerSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecognizerSettingsArray", "([Lcom/microblink/recognizers/settings/RecognizerSettings;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_shouldAllowMultipleScanResultsOnSingleImage;
#pragma warning disable 0169
		static Delegate GetShouldAllowMultipleScanResultsOnSingleImageHandler ()
		{
			if (cb_shouldAllowMultipleScanResultsOnSingleImage == null)
				cb_shouldAllowMultipleScanResultsOnSingleImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldAllowMultipleScanResultsOnSingleImage);
			return cb_shouldAllowMultipleScanResultsOnSingleImage;
		}

		static bool n_ShouldAllowMultipleScanResultsOnSingleImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldAllowMultipleScanResultsOnSingleImage ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldAllowMultipleScanResultsOnSingleImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='shouldAllowMultipleScanResultsOnSingleImage' and count(parameter)=0]"
		[Register ("shouldAllowMultipleScanResultsOnSingleImage", "()Z", "GetShouldAllowMultipleScanResultsOnSingleImageHandler")]
		public virtual unsafe bool ShouldAllowMultipleScanResultsOnSingleImage ()
		{
			if (id_shouldAllowMultipleScanResultsOnSingleImage == IntPtr.Zero)
				id_shouldAllowMultipleScanResultsOnSingleImage = JNIEnv.GetMethodID (class_ref, "shouldAllowMultipleScanResultsOnSingleImage", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldAllowMultipleScanResultsOnSingleImage);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldAllowMultipleScanResultsOnSingleImage", "()Z"));
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
			global::Com.Microblink.Recognizers.Settings.RecognitionSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognitionSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognitionSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
