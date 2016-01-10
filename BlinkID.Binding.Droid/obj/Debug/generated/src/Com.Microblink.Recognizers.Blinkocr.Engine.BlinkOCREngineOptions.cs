using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkocr.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkocr/engine/BlinkOCREngineOptions", DoNotGenerateAcw=true)]
	public partial class BlinkOCREngineOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkocr/engine/BlinkOCREngineOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlinkOCREngineOptions); }
		}

		protected BlinkOCREngineOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/constructor[@name='BlinkOCREngineOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlinkOCREngineOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BlinkOCREngineOptions)) {
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

		static Delegate cb_getCharWhitelist;
#pragma warning disable 0169
		static Delegate GetGetCharWhitelistHandler ()
		{
			if (cb_getCharWhitelist == null)
				cb_getCharWhitelist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharWhitelist);
			return cb_getCharWhitelist;
		}

		static IntPtr n_GetCharWhitelist (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey>.ToLocalJniHandle (__this.CharWhitelist);
		}
#pragma warning restore 0169

		static IntPtr id_getCharWhitelist;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey> CharWhitelist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='getCharWhitelist' and count(parameter)=0]"
			[Register ("getCharWhitelist", "()Ljava/util/Set;", "GetGetCharWhitelistHandler")]
			get {
				if (id_getCharWhitelist == IntPtr.Zero)
					id_getCharWhitelist = JNIEnv.GetMethodID (class_ref, "getCharWhitelist", "()Ljava/util/Set;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCharWhitelist), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharWhitelist", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isColorDropoutEnabled;
#pragma warning disable 0169
		static Delegate GetIsColorDropoutEnabledHandler ()
		{
			if (cb_isColorDropoutEnabled == null)
				cb_isColorDropoutEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsColorDropoutEnabled);
			return cb_isColorDropoutEnabled;
		}

		static bool n_IsColorDropoutEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorDropoutEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setColorDropoutEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetColorDropoutEnabled_ZHandler ()
		{
			if (cb_setColorDropoutEnabled_Z == null)
				cb_setColorDropoutEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetColorDropoutEnabled_Z);
			return cb_setColorDropoutEnabled_Z;
		}

		static void n_SetColorDropoutEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ColorDropoutEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isColorDropoutEnabled;
		static IntPtr id_setColorDropoutEnabled_Z;
		public virtual unsafe bool ColorDropoutEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='isColorDropoutEnabled' and count(parameter)=0]"
			[Register ("isColorDropoutEnabled", "()Z", "GetIsColorDropoutEnabledHandler")]
			get {
				if (id_isColorDropoutEnabled == IntPtr.Zero)
					id_isColorDropoutEnabled = JNIEnv.GetMethodID (class_ref, "isColorDropoutEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isColorDropoutEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isColorDropoutEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='setColorDropoutEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setColorDropoutEnabled", "(Z)V", "GetSetColorDropoutEnabled_ZHandler")]
			set {
				if (id_setColorDropoutEnabled_Z == IntPtr.Zero)
					id_setColorDropoutEnabled_Z = JNIEnv.GetMethodID (class_ref, "setColorDropoutEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setColorDropoutEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorDropoutEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isImageProcessingEnabled;
#pragma warning disable 0169
		static Delegate GetIsImageProcessingEnabledHandler ()
		{
			if (cb_isImageProcessingEnabled == null)
				cb_isImageProcessingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsImageProcessingEnabled);
			return cb_isImageProcessingEnabled;
		}

		static bool n_IsImageProcessingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageProcessingEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setImageProcessingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetImageProcessingEnabled_ZHandler ()
		{
			if (cb_setImageProcessingEnabled_Z == null)
				cb_setImageProcessingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetImageProcessingEnabled_Z);
			return cb_setImageProcessingEnabled_Z;
		}

		static void n_SetImageProcessingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ImageProcessingEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isImageProcessingEnabled;
		static IntPtr id_setImageProcessingEnabled_Z;
		public virtual unsafe bool ImageProcessingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='isImageProcessingEnabled' and count(parameter)=0]"
			[Register ("isImageProcessingEnabled", "()Z", "GetIsImageProcessingEnabledHandler")]
			get {
				if (id_isImageProcessingEnabled == IntPtr.Zero)
					id_isImageProcessingEnabled = JNIEnv.GetMethodID (class_ref, "isImageProcessingEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isImageProcessingEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isImageProcessingEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='setImageProcessingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setImageProcessingEnabled", "(Z)V", "GetSetImageProcessingEnabled_ZHandler")]
			set {
				if (id_setImageProcessingEnabled_Z == IntPtr.Zero)
					id_setImageProcessingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setImageProcessingEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setImageProcessingEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageProcessingEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumAllowedCharRecognitionVariants;
#pragma warning disable 0169
		static Delegate GetGetMaximumAllowedCharRecognitionVariantsHandler ()
		{
			if (cb_getMaximumAllowedCharRecognitionVariants == null)
				cb_getMaximumAllowedCharRecognitionVariants = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumAllowedCharRecognitionVariants);
			return cb_getMaximumAllowedCharRecognitionVariants;
		}

		static int n_GetMaximumAllowedCharRecognitionVariants (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumAllowedCharRecognitionVariants;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumAllowedCharRecognitionVariants_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumAllowedCharRecognitionVariants_IHandler ()
		{
			if (cb_setMaximumAllowedCharRecognitionVariants_I == null)
				cb_setMaximumAllowedCharRecognitionVariants_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumAllowedCharRecognitionVariants_I);
			return cb_setMaximumAllowedCharRecognitionVariants_I;
		}

		static void n_SetMaximumAllowedCharRecognitionVariants_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumAllowedCharRecognitionVariants = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumAllowedCharRecognitionVariants;
		static IntPtr id_setMaximumAllowedCharRecognitionVariants_I;
		public virtual unsafe int MaximumAllowedCharRecognitionVariants {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='getMaximumAllowedCharRecognitionVariants' and count(parameter)=0]"
			[Register ("getMaximumAllowedCharRecognitionVariants", "()I", "GetGetMaximumAllowedCharRecognitionVariantsHandler")]
			get {
				if (id_getMaximumAllowedCharRecognitionVariants == IntPtr.Zero)
					id_getMaximumAllowedCharRecognitionVariants = JNIEnv.GetMethodID (class_ref, "getMaximumAllowedCharRecognitionVariants", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaximumAllowedCharRecognitionVariants);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumAllowedCharRecognitionVariants", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='setMaximumAllowedCharRecognitionVariants' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximumAllowedCharRecognitionVariants", "(I)V", "GetSetMaximumAllowedCharRecognitionVariants_IHandler")]
			set {
				if (id_setMaximumAllowedCharRecognitionVariants_I == IntPtr.Zero)
					id_setMaximumAllowedCharRecognitionVariants_I = JNIEnv.GetMethodID (class_ref, "setMaximumAllowedCharRecognitionVariants", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaximumAllowedCharRecognitionVariants_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumAllowedCharRecognitionVariants", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumCharsExpected;
#pragma warning disable 0169
		static Delegate GetGetMaximumCharsExpectedHandler ()
		{
			if (cb_getMaximumCharsExpected == null)
				cb_getMaximumCharsExpected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumCharsExpected);
			return cb_getMaximumCharsExpected;
		}

		static int n_GetMaximumCharsExpected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumCharsExpected;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumCharsExpected_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumCharsExpected_IHandler ()
		{
			if (cb_setMaximumCharsExpected_I == null)
				cb_setMaximumCharsExpected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumCharsExpected_I);
			return cb_setMaximumCharsExpected_I;
		}

		static void n_SetMaximumCharsExpected_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumCharsExpected = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumCharsExpected;
		static IntPtr id_setMaximumCharsExpected_I;
		public virtual unsafe int MaximumCharsExpected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='getMaximumCharsExpected' and count(parameter)=0]"
			[Register ("getMaximumCharsExpected", "()I", "GetGetMaximumCharsExpectedHandler")]
			get {
				if (id_getMaximumCharsExpected == IntPtr.Zero)
					id_getMaximumCharsExpected = JNIEnv.GetMethodID (class_ref, "getMaximumCharsExpected", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaximumCharsExpected);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumCharsExpected", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='setMaximumCharsExpected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximumCharsExpected", "(I)V", "GetSetMaximumCharsExpected_IHandler")]
			set {
				if (id_setMaximumCharsExpected_I == IntPtr.Zero)
					id_setMaximumCharsExpected_I = JNIEnv.GetMethodID (class_ref, "setMaximumCharsExpected", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaximumCharsExpected_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumCharsExpected", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumLineHeight;
#pragma warning disable 0169
		static Delegate GetGetMaximumLineHeightHandler ()
		{
			if (cb_getMaximumLineHeight == null)
				cb_getMaximumLineHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumLineHeight);
			return cb_getMaximumLineHeight;
		}

		static int n_GetMaximumLineHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumLineHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumLineHeight_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumLineHeight_IHandler ()
		{
			if (cb_setMaximumLineHeight_I == null)
				cb_setMaximumLineHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumLineHeight_I);
			return cb_setMaximumLineHeight_I;
		}

		static void n_SetMaximumLineHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumLineHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumLineHeight;
		static IntPtr id_setMaximumLineHeight_I;
		public virtual unsafe int MaximumLineHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='getMaximumLineHeight' and count(parameter)=0]"
			[Register ("getMaximumLineHeight", "()I", "GetGetMaximumLineHeightHandler")]
			get {
				if (id_getMaximumLineHeight == IntPtr.Zero)
					id_getMaximumLineHeight = JNIEnv.GetMethodID (class_ref, "getMaximumLineHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaximumLineHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumLineHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='setMaximumLineHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximumLineHeight", "(I)V", "GetSetMaximumLineHeight_IHandler")]
			set {
				if (id_setMaximumLineHeight_I == IntPtr.Zero)
					id_setMaximumLineHeight_I = JNIEnv.GetMethodID (class_ref, "setMaximumLineHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaximumLineHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumLineHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinimumLineHeight;
#pragma warning disable 0169
		static Delegate GetGetMinimumLineHeightHandler ()
		{
			if (cb_getMinimumLineHeight == null)
				cb_getMinimumLineHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinimumLineHeight);
			return cb_getMinimumLineHeight;
		}

		static int n_GetMinimumLineHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumLineHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setMinimumLineHeight_I;
#pragma warning disable 0169
		static Delegate GetSetMinimumLineHeight_IHandler ()
		{
			if (cb_setMinimumLineHeight_I == null)
				cb_setMinimumLineHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinimumLineHeight_I);
			return cb_setMinimumLineHeight_I;
		}

		static void n_SetMinimumLineHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinimumLineHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumLineHeight;
		static IntPtr id_setMinimumLineHeight_I;
		public virtual unsafe int MinimumLineHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='getMinimumLineHeight' and count(parameter)=0]"
			[Register ("getMinimumLineHeight", "()I", "GetGetMinimumLineHeightHandler")]
			get {
				if (id_getMinimumLineHeight == IntPtr.Zero)
					id_getMinimumLineHeight = JNIEnv.GetMethodID (class_ref, "getMinimumLineHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMinimumLineHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumLineHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='setMinimumLineHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinimumLineHeight", "(I)V", "GetSetMinimumLineHeight_IHandler")]
			set {
				if (id_setMinimumLineHeight_I == IntPtr.Zero)
					id_setMinimumLineHeight_I = JNIEnv.GetMethodID (class_ref, "setMinimumLineHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinimumLineHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumLineHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNativeContext;
#pragma warning disable 0169
		static Delegate GetGetNativeContextHandler ()
		{
			if (cb_getNativeContext == null)
				cb_getNativeContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeContext);
			return cb_getNativeContext;
		}

		static long n_GetNativeContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeContext;
		}
#pragma warning restore 0169

		static IntPtr id_getNativeContext;
		public virtual unsafe long NativeContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='getNativeContext' and count(parameter)=0]"
			[Register ("getNativeContext", "()J", "GetGetNativeContextHandler")]
			get {
				if (id_getNativeContext == IntPtr.Zero)
					id_getNativeContext = JNIEnv.GetMethodID (class_ref, "getNativeContext", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getNativeContext);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeContext", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_addAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
#pragma warning disable 0169
		static Delegate GetAddAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_Handler ()
		{
			if (cb_addAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ == null)
				cb_addAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_);
			return cb_addAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
		}

		static void n_AddAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrFont p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrFont> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAllDigitsToWhitelist (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='addAllDigitsToWhitelist' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrFont']]"
		[Register ("addAllDigitsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V", "GetAddAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_Handler")]
		public virtual unsafe void AddAllDigitsToWhitelist (global::Com.Microblink.Results.Ocr.OcrFont p0)
		{
			if (id_addAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ == IntPtr.Zero)
				id_addAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ = JNIEnv.GetMethodID (class_ref, "addAllDigitsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addAllDigitsToWhitelist_Lcom_microblink_results_ocr_OcrFont_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAllDigitsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_;
#pragma warning disable 0169
		static Delegate GetAddCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_Handler ()
		{
			if (cb_addCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_ == null)
				cb_addCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char, char, IntPtr>) n_AddCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_);
			return cb_addCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_;
		}

		static void n_AddCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_ (IntPtr jnienv, IntPtr native__this, char p0, char p1, IntPtr native_p2)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrFont p2 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrFont> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddCharIntervalToWhitelist (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='addCharIntervalToWhitelist' and count(parameter)=3 and parameter[1][@type='char'] and parameter[2][@type='char'] and parameter[3][@type='com.microblink.results.ocr.OcrFont']]"
		[Register ("addCharIntervalToWhitelist", "(CCLcom/microblink/results/ocr/OcrFont;)V", "GetAddCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_Handler")]
		public virtual unsafe void AddCharIntervalToWhitelist (char p0, char p1, global::Com.Microblink.Results.Ocr.OcrFont p2)
		{
			if (id_addCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_ == IntPtr.Zero)
				id_addCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_ = JNIEnv.GetMethodID (class_ref, "addCharIntervalToWhitelist", "(CCLcom/microblink/results/ocr/OcrFont;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addCharIntervalToWhitelist_CCLcom_microblink_results_ocr_OcrFont_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCharIntervalToWhitelist", "(CCLcom/microblink/results/ocr/OcrFont;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_;
#pragma warning disable 0169
		static Delegate GetAddCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_Handler ()
		{
			if (cb_addCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_ == null)
				cb_addCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char, IntPtr>) n_AddCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_);
			return cb_addCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_;
		}

		static void n_AddCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_ (IntPtr jnienv, IntPtr native__this, char p0, IntPtr native_p1)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrFont p1 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrFont> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddCharToWhitelist (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='addCharToWhitelist' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='com.microblink.results.ocr.OcrFont']]"
		[Register ("addCharToWhitelist", "(CLcom/microblink/results/ocr/OcrFont;)V", "GetAddCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_Handler")]
		public virtual unsafe void AddCharToWhitelist (char p0, global::Com.Microblink.Results.Ocr.OcrFont p1)
		{
			if (id_addCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_ == IntPtr.Zero)
				id_addCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_ = JNIEnv.GetMethodID (class_ref, "addCharToWhitelist", "(CLcom/microblink/results/ocr/OcrFont;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addCharToWhitelist_CLcom_microblink_results_ocr_OcrFont_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCharToWhitelist", "(CLcom/microblink/results/ocr/OcrFont;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_;
#pragma warning disable 0169
		static Delegate GetAddCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_Handler ()
		{
			if (cb_addCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_ == null)
				cb_addCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_);
			return cb_addCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_;
		}

		static void n_AddCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCharToWhitelist (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='addCharToWhitelist' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.blinkocr.engine.BlinkOCRCharKey']]"
		[Register ("addCharToWhitelist", "(Lcom/microblink/recognizers/blinkocr/engine/BlinkOCRCharKey;)V", "GetAddCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_Handler")]
		public virtual unsafe void AddCharToWhitelist (global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey p0)
		{
			if (id_addCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_ == IntPtr.Zero)
				id_addCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_ = JNIEnv.GetMethodID (class_ref, "addCharToWhitelist", "(Lcom/microblink/recognizers/blinkocr/engine/BlinkOCRCharKey;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addCharToWhitelist_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCRCharKey_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCharToWhitelist", "(Lcom/microblink/recognizers/blinkocr/engine/BlinkOCRCharKey;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
#pragma warning disable 0169
		static Delegate GetAddLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_Handler ()
		{
			if (cb_addLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ == null)
				cb_addLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_);
			return cb_addLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
		}

		static void n_AddLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrFont p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrFont> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLowercaseCharsToWhitelist (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='addLowercaseCharsToWhitelist' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrFont']]"
		[Register ("addLowercaseCharsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V", "GetAddLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_Handler")]
		public virtual unsafe void AddLowercaseCharsToWhitelist (global::Com.Microblink.Results.Ocr.OcrFont p0)
		{
			if (id_addLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ == IntPtr.Zero)
				id_addLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ = JNIEnv.GetMethodID (class_ref, "addLowercaseCharsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addLowercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLowercaseCharsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
#pragma warning disable 0169
		static Delegate GetAddUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_Handler ()
		{
			if (cb_addUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ == null)
				cb_addUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_);
			return cb_addUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
		}

		static void n_AddUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrFont p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrFont> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddUppercaseCharsToWhitelist (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='addUppercaseCharsToWhitelist' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrFont']]"
		[Register ("addUppercaseCharsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V", "GetAddUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_Handler")]
		public virtual unsafe void AddUppercaseCharsToWhitelist (global::Com.Microblink.Results.Ocr.OcrFont p0)
		{
			if (id_addUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ == IntPtr.Zero)
				id_addUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_ = JNIEnv.GetMethodID (class_ref, "addUppercaseCharsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addUppercaseCharsToWhitelist_Lcom_microblink_results_ocr_OcrFont_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addUppercaseCharsToWhitelist", "(Lcom/microblink/results/ocr/OcrFont;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_allowAllCharsAndAllFonts;
#pragma warning disable 0169
		static Delegate GetAllowAllCharsAndAllFontsHandler ()
		{
			if (cb_allowAllCharsAndAllFonts == null)
				cb_allowAllCharsAndAllFonts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AllowAllCharsAndAllFonts);
			return cb_allowAllCharsAndAllFonts;
		}

		static void n_AllowAllCharsAndAllFonts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowAllCharsAndAllFonts ();
		}
#pragma warning restore 0169

		static IntPtr id_allowAllCharsAndAllFonts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='allowAllCharsAndAllFonts' and count(parameter)=0]"
		[Register ("allowAllCharsAndAllFonts", "()V", "GetAllowAllCharsAndAllFontsHandler")]
		public virtual unsafe void AllowAllCharsAndAllFonts ()
		{
			if (id_allowAllCharsAndAllFonts == IntPtr.Zero)
				id_allowAllCharsAndAllFonts = JNIEnv.GetMethodID (class_ref, "allowAllCharsAndAllFonts", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_allowAllCharsAndAllFonts);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "allowAllCharsAndAllFonts", "()V"));
			} finally {
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
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCREngineOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
