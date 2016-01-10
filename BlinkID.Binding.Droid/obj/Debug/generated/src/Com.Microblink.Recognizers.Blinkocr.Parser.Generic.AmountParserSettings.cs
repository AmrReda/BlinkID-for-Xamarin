using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkocr.Parser.Generic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkocr/parser/generic/AmountParserSettings", DoNotGenerateAcw=true)]
	public partial class AmountParserSettings : global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkocr/parser/generic/AmountParserSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmountParserSettings); }
		}

		protected AmountParserSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/constructor[@name='AmountParserSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AmountParserSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AmountParserSettings)) {
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

		static Delegate cb_isAsterixOrEqualsPrefixExpected;
#pragma warning disable 0169
		static Delegate GetIsAsterixOrEqualsPrefixExpectedHandler ()
		{
			if (cb_isAsterixOrEqualsPrefixExpected == null)
				cb_isAsterixOrEqualsPrefixExpected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAsterixOrEqualsPrefixExpected);
			return cb_isAsterixOrEqualsPrefixExpected;
		}

		static bool n_IsAsterixOrEqualsPrefixExpected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAsterixOrEqualsPrefixExpected;
		}
#pragma warning restore 0169

		static IntPtr id_isAsterixOrEqualsPrefixExpected;
		public virtual unsafe bool IsAsterixOrEqualsPrefixExpected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='isAsterixOrEqualsPrefixExpected' and count(parameter)=0]"
			[Register ("isAsterixOrEqualsPrefixExpected", "()Z", "GetIsAsterixOrEqualsPrefixExpectedHandler")]
			get {
				if (id_isAsterixOrEqualsPrefixExpected == IntPtr.Zero)
					id_isAsterixOrEqualsPrefixExpected = JNIEnv.GetMethodID (class_ref, "isAsterixOrEqualsPrefixExpected", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAsterixOrEqualsPrefixExpected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAsterixOrEqualsPrefixExpected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isCurrencyPrefixExpected;
#pragma warning disable 0169
		static Delegate GetIsCurrencyPrefixExpectedHandler ()
		{
			if (cb_isCurrencyPrefixExpected == null)
				cb_isCurrencyPrefixExpected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurrencyPrefixExpected);
			return cb_isCurrencyPrefixExpected;
		}

		static bool n_IsCurrencyPrefixExpected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrencyPrefixExpected;
		}
#pragma warning restore 0169

		static IntPtr id_isCurrencyPrefixExpected;
		public virtual unsafe bool IsCurrencyPrefixExpected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='isCurrencyPrefixExpected' and count(parameter)=0]"
			[Register ("isCurrencyPrefixExpected", "()Z", "GetIsCurrencyPrefixExpectedHandler")]
			get {
				if (id_isCurrencyPrefixExpected == IntPtr.Zero)
					id_isCurrencyPrefixExpected = JNIEnv.GetMethodID (class_ref, "isCurrencyPrefixExpected", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCurrencyPrefixExpected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCurrencyPrefixExpected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_areMissingDecimalsAllowed;
#pragma warning disable 0169
		static Delegate GetAreMissingDecimalsAllowedHandler ()
		{
			if (cb_areMissingDecimalsAllowed == null)
				cb_areMissingDecimalsAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AreMissingDecimalsAllowed);
			return cb_areMissingDecimalsAllowed;
		}

		static bool n_AreMissingDecimalsAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreMissingDecimalsAllowed ();
		}
#pragma warning restore 0169

		static IntPtr id_areMissingDecimalsAllowed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='areMissingDecimalsAllowed' and count(parameter)=0]"
		[Register ("areMissingDecimalsAllowed", "()Z", "GetAreMissingDecimalsAllowedHandler")]
		public virtual unsafe bool AreMissingDecimalsAllowed ()
		{
			if (id_areMissingDecimalsAllowed == IntPtr.Zero)
				id_areMissingDecimalsAllowed = JNIEnv.GetMethodID (class_ref, "areMissingDecimalsAllowed", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_areMissingDecimalsAllowed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "areMissingDecimalsAllowed", "()Z"));
			} finally {
			}
		}

		static Delegate cb_areNegativeAmountsAllowed;
#pragma warning disable 0169
		static Delegate GetAreNegativeAmountsAllowedHandler ()
		{
			if (cb_areNegativeAmountsAllowed == null)
				cb_areNegativeAmountsAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AreNegativeAmountsAllowed);
			return cb_areNegativeAmountsAllowed;
		}

		static bool n_AreNegativeAmountsAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreNegativeAmountsAllowed ();
		}
#pragma warning restore 0169

		static IntPtr id_areNegativeAmountsAllowed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='areNegativeAmountsAllowed' and count(parameter)=0]"
		[Register ("areNegativeAmountsAllowed", "()Z", "GetAreNegativeAmountsAllowedHandler")]
		public virtual unsafe bool AreNegativeAmountsAllowed ()
		{
			if (id_areNegativeAmountsAllowed == IntPtr.Zero)
				id_areNegativeAmountsAllowed = JNIEnv.GetMethodID (class_ref, "areNegativeAmountsAllowed", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_areNegativeAmountsAllowed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "areNegativeAmountsAllowed", "()Z"));
			} finally {
			}
		}

		static Delegate cb_setAllowMissingDecimals_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowMissingDecimals_ZHandler ()
		{
			if (cb_setAllowMissingDecimals_Z == null)
				cb_setAllowMissingDecimals_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowMissingDecimals_Z);
			return cb_setAllowMissingDecimals_Z;
		}

		static void n_SetAllowMissingDecimals_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowMissingDecimals (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowMissingDecimals_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='setAllowMissingDecimals' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowMissingDecimals", "(Z)V", "GetSetAllowMissingDecimals_ZHandler")]
		public virtual unsafe void SetAllowMissingDecimals (bool p0)
		{
			if (id_setAllowMissingDecimals_Z == IntPtr.Zero)
				id_setAllowMissingDecimals_Z = JNIEnv.GetMethodID (class_ref, "setAllowMissingDecimals", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAllowMissingDecimals_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllowMissingDecimals", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAllowNegativeAmounts_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowNegativeAmounts_ZHandler ()
		{
			if (cb_setAllowNegativeAmounts_Z == null)
				cb_setAllowNegativeAmounts_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowNegativeAmounts_Z);
			return cb_setAllowNegativeAmounts_Z;
		}

		static void n_SetAllowNegativeAmounts_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowNegativeAmounts (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowNegativeAmounts_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='setAllowNegativeAmounts' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowNegativeAmounts", "(Z)V", "GetSetAllowNegativeAmounts_ZHandler")]
		public virtual unsafe void SetAllowNegativeAmounts (bool p0)
		{
			if (id_setAllowNegativeAmounts_Z == IntPtr.Zero)
				id_setAllowNegativeAmounts_Z = JNIEnv.GetMethodID (class_ref, "setAllowNegativeAmounts", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAllowNegativeAmounts_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllowNegativeAmounts", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExpectAsterixOrEqualsPrefix_Z;
#pragma warning disable 0169
		static Delegate GetSetExpectAsterixOrEqualsPrefix_ZHandler ()
		{
			if (cb_setExpectAsterixOrEqualsPrefix_Z == null)
				cb_setExpectAsterixOrEqualsPrefix_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExpectAsterixOrEqualsPrefix_Z);
			return cb_setExpectAsterixOrEqualsPrefix_Z;
		}

		static void n_SetExpectAsterixOrEqualsPrefix_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpectAsterixOrEqualsPrefix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExpectAsterixOrEqualsPrefix_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='setExpectAsterixOrEqualsPrefix' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setExpectAsterixOrEqualsPrefix", "(Z)V", "GetSetExpectAsterixOrEqualsPrefix_ZHandler")]
		public virtual unsafe void SetExpectAsterixOrEqualsPrefix (bool p0)
		{
			if (id_setExpectAsterixOrEqualsPrefix_Z == IntPtr.Zero)
				id_setExpectAsterixOrEqualsPrefix_Z = JNIEnv.GetMethodID (class_ref, "setExpectAsterixOrEqualsPrefix", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExpectAsterixOrEqualsPrefix_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpectAsterixOrEqualsPrefix", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExpectCurrencyPrefix_Z;
#pragma warning disable 0169
		static Delegate GetSetExpectCurrencyPrefix_ZHandler ()
		{
			if (cb_setExpectCurrencyPrefix_Z == null)
				cb_setExpectCurrencyPrefix_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExpectCurrencyPrefix_Z);
			return cb_setExpectCurrencyPrefix_Z;
		}

		static void n_SetExpectCurrencyPrefix_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpectCurrencyPrefix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExpectCurrencyPrefix_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='setExpectCurrencyPrefix' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setExpectCurrencyPrefix", "(Z)V", "GetSetExpectCurrencyPrefix_ZHandler")]
		public virtual unsafe void SetExpectCurrencyPrefix (bool p0)
		{
			if (id_setExpectCurrencyPrefix_Z == IntPtr.Zero)
				id_setExpectCurrencyPrefix_Z = JNIEnv.GetMethodID (class_ref, "setExpectCurrencyPrefix", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExpectCurrencyPrefix_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpectCurrencyPrefix", "(Z)V"), __args);
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
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.AmountParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='AmountParserSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
