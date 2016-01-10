using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkocr.Parser.Generic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='RawParserSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkocr/parser/generic/RawParserSettings", DoNotGenerateAcw=true)]
	public partial class RawParserSettings : global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='RawParserSettings']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkocr/parser/generic/RawParserSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RawParserSettings); }
		}

		protected RawParserSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='RawParserSettings']/constructor[@name='RawParserSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RawParserSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RawParserSettings)) {
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

		static Delegate cb_isUsingSieve;
#pragma warning disable 0169
		static Delegate GetIsUsingSieveHandler ()
		{
			if (cb_isUsingSieve == null)
				cb_isUsingSieve = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUsingSieve);
			return cb_isUsingSieve;
		}

		static bool n_IsUsingSieve (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUsingSieve;
		}
#pragma warning restore 0169

		static IntPtr id_isUsingSieve;
		public virtual unsafe bool IsUsingSieve {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='RawParserSettings']/method[@name='isUsingSieve' and count(parameter)=0]"
			[Register ("isUsingSieve", "()Z", "GetIsUsingSieveHandler")]
			get {
				if (id_isUsingSieve == IntPtr.Zero)
					id_isUsingSieve = JNIEnv.GetMethodID (class_ref, "isUsingSieve", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isUsingSieve);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUsingSieve", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOcrEngineOptions;
#pragma warning disable 0169
		static Delegate GetGetOcrEngineOptionsHandler ()
		{
			if (cb_getOcrEngineOptions == null)
				cb_getOcrEngineOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOcrEngineOptions);
			return cb_getOcrEngineOptions;
		}

		static IntPtr n_GetOcrEngineOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OcrEngineOptions);
		}
#pragma warning restore 0169

		static Delegate cb_setOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_;
#pragma warning disable 0169
		static Delegate GetSetOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_Handler ()
		{
			if (cb_setOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_ == null)
				cb_setOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_);
			return cb_setOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_;
		}

		static void n_SetOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OcrEngineOptions = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOcrEngineOptions;
		static IntPtr id_setOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_;
		public virtual unsafe global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions OcrEngineOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='RawParserSettings']/method[@name='getOcrEngineOptions' and count(parameter)=0]"
			[Register ("getOcrEngineOptions", "()Lcom/microblink/recognizers/blinkocr/engine/BlinkOCREngineOptions;", "GetGetOcrEngineOptionsHandler")]
			get {
				if (id_getOcrEngineOptions == IntPtr.Zero)
					id_getOcrEngineOptions = JNIEnv.GetMethodID (class_ref, "getOcrEngineOptions", "()Lcom/microblink/recognizers/blinkocr/engine/BlinkOCREngineOptions;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (JNIEnv.CallObjectMethod  (Handle, id_getOcrEngineOptions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCREngineOptions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOcrEngineOptions", "()Lcom/microblink/recognizers/blinkocr/engine/BlinkOCREngineOptions;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='RawParserSettings']/method[@name='setOcrEngineOptions' and count(parameter)=1 and parameter[1][@type='com.microblink.recognizers.blinkocr.engine.BlinkOCREngineOptions']]"
			[Register ("setOcrEngineOptions", "(Lcom/microblink/recognizers/blinkocr/engine/BlinkOCREngineOptions;)V", "GetSetOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_Handler")]
			set {
				if (id_setOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_ == IntPtr.Zero)
					id_setOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_ = JNIEnv.GetMethodID (class_ref, "setOcrEngineOptions", "(Lcom/microblink/recognizers/blinkocr/engine/BlinkOCREngineOptions;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOcrEngineOptions_Lcom_microblink_recognizers_blinkocr_engine_BlinkOCREngineOptions_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOcrEngineOptions", "(Lcom/microblink/recognizers/blinkocr/engine/BlinkOCREngineOptions;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_setUseSieve_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSieve_ZHandler ()
		{
			if (cb_setUseSieve_Z == null)
				cb_setUseSieve_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseSieve_Z);
			return cb_setUseSieve_Z;
		}

		static void n_SetUseSieve_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseSieve (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUseSieve_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='RawParserSettings']/method[@name='setUseSieve' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseSieve", "(Z)V", "GetSetUseSieve_ZHandler")]
		public virtual unsafe void SetUseSieve (bool p0)
		{
			if (id_setUseSieve_Z == IntPtr.Zero)
				id_setUseSieve_Z = JNIEnv.GetMethodID (class_ref, "setUseSieve", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUseSieve_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseSieve", "(Z)V"), __args);
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
			global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.Generic.RawParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser.generic']/class[@name='RawParserSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
