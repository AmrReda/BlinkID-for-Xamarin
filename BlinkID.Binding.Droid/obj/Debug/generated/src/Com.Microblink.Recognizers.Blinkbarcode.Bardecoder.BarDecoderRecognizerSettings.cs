using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkbarcode.Bardecoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkbarcode/bardecoder/BarDecoderRecognizerSettings", DoNotGenerateAcw=true)]
	public partial class BarDecoderRecognizerSettings : global::Com.Microblink.Recognizers.Settings.RecognizerSettings {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkbarcode/bardecoder/BarDecoderRecognizerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarDecoderRecognizerSettings); }
		}

		protected BarDecoderRecognizerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/constructor[@name='BarDecoderRecognizerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BarDecoderRecognizerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BarDecoderRecognizerSettings)) {
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

		static Delegate cb_isAutoScaleDetectionEnabled;
#pragma warning disable 0169
		static Delegate GetIsAutoScaleDetectionEnabledHandler ()
		{
			if (cb_isAutoScaleDetectionEnabled == null)
				cb_isAutoScaleDetectionEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoScaleDetectionEnabled);
			return cb_isAutoScaleDetectionEnabled;
		}

		static bool n_IsAutoScaleDetectionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoScaleDetectionEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isAutoScaleDetectionEnabled;
		public virtual unsafe bool IsAutoScaleDetectionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='isAutoScaleDetectionEnabled' and count(parameter)=0]"
			[Register ("isAutoScaleDetectionEnabled", "()Z", "GetIsAutoScaleDetectionEnabledHandler")]
			get {
				if (id_isAutoScaleDetectionEnabled == IntPtr.Zero)
					id_isAutoScaleDetectionEnabled = JNIEnv.GetMethodID (class_ref, "isAutoScaleDetectionEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAutoScaleDetectionEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAutoScaleDetectionEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInverseScanMode;
#pragma warning disable 0169
		static Delegate GetIsInverseScanModeHandler ()
		{
			if (cb_isInverseScanMode == null)
				cb_isInverseScanMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInverseScanMode);
			return cb_isInverseScanMode;
		}

		static bool n_IsInverseScanMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInverseScanMode;
		}
#pragma warning restore 0169

		static IntPtr id_isInverseScanMode;
		public virtual unsafe bool IsInverseScanMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='isInverseScanMode' and count(parameter)=0]"
			[Register ("isInverseScanMode", "()Z", "GetIsInverseScanModeHandler")]
			get {
				if (id_isInverseScanMode == IntPtr.Zero)
					id_isInverseScanMode = JNIEnv.GetMethodID (class_ref, "isInverseScanMode", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInverseScanMode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInverseScanMode", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTryingHarder;
#pragma warning disable 0169
		static Delegate GetIsTryingHarderHandler ()
		{
			if (cb_isTryingHarder == null)
				cb_isTryingHarder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTryingHarder);
			return cb_isTryingHarder;
		}

		static bool n_IsTryingHarder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTryingHarder;
		}
#pragma warning restore 0169

		static IntPtr id_isTryingHarder;
		public virtual unsafe bool IsTryingHarder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='isTryingHarder' and count(parameter)=0]"
			[Register ("isTryingHarder", "()Z", "GetIsTryingHarderHandler")]
			get {
				if (id_isTryingHarder == IntPtr.Zero)
					id_isTryingHarder = JNIEnv.GetMethodID (class_ref, "isTryingHarder", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isTryingHarder);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTryingHarder", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_setAutoScaleDetection_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoScaleDetection_ZHandler ()
		{
			if (cb_setAutoScaleDetection_Z == null)
				cb_setAutoScaleDetection_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoScaleDetection_Z);
			return cb_setAutoScaleDetection_Z;
		}

		static void n_SetAutoScaleDetection_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAutoScaleDetection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAutoScaleDetection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='setAutoScaleDetection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoScaleDetection", "(Z)V", "GetSetAutoScaleDetection_ZHandler")]
		public virtual unsafe void SetAutoScaleDetection (bool p0)
		{
			if (id_setAutoScaleDetection_Z == IntPtr.Zero)
				id_setAutoScaleDetection_Z = JNIEnv.GetMethodID (class_ref, "setAutoScaleDetection", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAutoScaleDetection_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoScaleDetection", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setInverseScanning_Z;
#pragma warning disable 0169
		static Delegate GetSetInverseScanning_ZHandler ()
		{
			if (cb_setInverseScanning_Z == null)
				cb_setInverseScanning_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInverseScanning_Z);
			return cb_setInverseScanning_Z;
		}

		static void n_SetInverseScanning_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInverseScanning (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInverseScanning_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='setInverseScanning' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInverseScanning", "(Z)V", "GetSetInverseScanning_ZHandler")]
		public virtual unsafe void SetInverseScanning (bool p0)
		{
			if (id_setInverseScanning_Z == IntPtr.Zero)
				id_setInverseScanning_Z = JNIEnv.GetMethodID (class_ref, "setInverseScanning", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInverseScanning_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInverseScanning", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScanCode128_Z;
#pragma warning disable 0169
		static Delegate GetSetScanCode128_ZHandler ()
		{
			if (cb_setScanCode128_Z == null)
				cb_setScanCode128_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanCode128_Z);
			return cb_setScanCode128_Z;
		}

		static void n_SetScanCode128_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanCode128 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanCode128_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='setScanCode128' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanCode128", "(Z)V", "GetSetScanCode128_ZHandler")]
		public virtual unsafe void SetScanCode128 (bool p0)
		{
			if (id_setScanCode128_Z == IntPtr.Zero)
				id_setScanCode128_Z = JNIEnv.GetMethodID (class_ref, "setScanCode128", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanCode128_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanCode128", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScanCode39_Z;
#pragma warning disable 0169
		static Delegate GetSetScanCode39_ZHandler ()
		{
			if (cb_setScanCode39_Z == null)
				cb_setScanCode39_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanCode39_Z);
			return cb_setScanCode39_Z;
		}

		static void n_SetScanCode39_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanCode39 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanCode39_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='setScanCode39' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanCode39", "(Z)V", "GetSetScanCode39_ZHandler")]
		public virtual unsafe void SetScanCode39 (bool p0)
		{
			if (id_setScanCode39_Z == IntPtr.Zero)
				id_setScanCode39_Z = JNIEnv.GetMethodID (class_ref, "setScanCode39", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanCode39_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanCode39", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTryHarder_Z;
#pragma warning disable 0169
		static Delegate GetSetTryHarder_ZHandler ()
		{
			if (cb_setTryHarder_Z == null)
				cb_setTryHarder_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTryHarder_Z);
			return cb_setTryHarder_Z;
		}

		static void n_SetTryHarder_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTryHarder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTryHarder_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='setTryHarder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTryHarder", "(Z)V", "GetSetTryHarder_ZHandler")]
		public virtual unsafe void SetTryHarder (bool p0)
		{
			if (id_setTryHarder_Z == IntPtr.Zero)
				id_setTryHarder_Z = JNIEnv.GetMethodID (class_ref, "setTryHarder", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTryHarder_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTryHarder", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shouldScanCode128;
#pragma warning disable 0169
		static Delegate GetShouldScanCode128Handler ()
		{
			if (cb_shouldScanCode128 == null)
				cb_shouldScanCode128 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanCode128);
			return cb_shouldScanCode128;
		}

		static bool n_ShouldScanCode128 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanCode128 ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanCode128;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='shouldScanCode128' and count(parameter)=0]"
		[Register ("shouldScanCode128", "()Z", "GetShouldScanCode128Handler")]
		public virtual unsafe bool ShouldScanCode128 ()
		{
			if (id_shouldScanCode128 == IntPtr.Zero)
				id_shouldScanCode128 = JNIEnv.GetMethodID (class_ref, "shouldScanCode128", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanCode128);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanCode128", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldScanCode39;
#pragma warning disable 0169
		static Delegate GetShouldScanCode39Handler ()
		{
			if (cb_shouldScanCode39 == null)
				cb_shouldScanCode39 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanCode39);
			return cb_shouldScanCode39;
		}

		static bool n_ShouldScanCode39 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanCode39 ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanCode39;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='shouldScanCode39' and count(parameter)=0]"
		[Register ("shouldScanCode39", "()Z", "GetShouldScanCode39Handler")]
		public virtual unsafe bool ShouldScanCode39 ()
		{
			if (id_shouldScanCode39 == IntPtr.Zero)
				id_shouldScanCode39 = JNIEnv.GetMethodID (class_ref, "shouldScanCode39", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanCode39);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanCode39", "()Z"));
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Bardecoder.BarDecoderRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.bardecoder']/class[@name='BarDecoderRecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
