using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkbarcode.Pdf417 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkbarcode/pdf417/Pdf417RecognizerSettings", DoNotGenerateAcw=true)]
	public partial class Pdf417RecognizerSettings : global::Com.Microblink.Recognizers.Settings.RecognizerSettings {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkbarcode/pdf417/Pdf417RecognizerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pdf417RecognizerSettings); }
		}

		protected Pdf417RecognizerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/constructor[@name='Pdf417RecognizerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Pdf417RecognizerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Pdf417RecognizerSettings)) {
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInverseScanMode;
		}
#pragma warning restore 0169

		static IntPtr id_isInverseScanMode;
		public virtual unsafe bool IsInverseScanMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/method[@name='isInverseScanMode' and count(parameter)=0]"
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

		static Delegate cb_isUncertainScanMode;
#pragma warning disable 0169
		static Delegate GetIsUncertainScanModeHandler ()
		{
			if (cb_isUncertainScanMode == null)
				cb_isUncertainScanMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUncertainScanMode);
			return cb_isUncertainScanMode;
		}

		static bool n_IsUncertainScanMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUncertainScanMode;
		}
#pragma warning restore 0169

		static IntPtr id_isUncertainScanMode;
		public virtual unsafe bool IsUncertainScanMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/method[@name='isUncertainScanMode' and count(parameter)=0]"
			[Register ("isUncertainScanMode", "()Z", "GetIsUncertainScanModeHandler")]
			get {
				if (id_isUncertainScanMode == IntPtr.Zero)
					id_isUncertainScanMode = JNIEnv.GetMethodID (class_ref, "isUncertainScanMode", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isUncertainScanMode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUncertainScanMode", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNullQuietZoneAllowed;
#pragma warning disable 0169
		static Delegate GetIsNullQuietZoneAllowedHandler ()
		{
			if (cb_isNullQuietZoneAllowed == null)
				cb_isNullQuietZoneAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNullQuietZoneAllowed);
			return cb_isNullQuietZoneAllowed;
		}

		static bool n_IsNullQuietZoneAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NullQuietZoneAllowed;
		}
#pragma warning restore 0169

		static Delegate cb_setNullQuietZoneAllowed_Z;
#pragma warning disable 0169
		static Delegate GetSetNullQuietZoneAllowed_ZHandler ()
		{
			if (cb_setNullQuietZoneAllowed_Z == null)
				cb_setNullQuietZoneAllowed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNullQuietZoneAllowed_Z);
			return cb_setNullQuietZoneAllowed_Z;
		}

		static void n_SetNullQuietZoneAllowed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NullQuietZoneAllowed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isNullQuietZoneAllowed;
		static IntPtr id_setNullQuietZoneAllowed_Z;
		public virtual unsafe bool NullQuietZoneAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/method[@name='isNullQuietZoneAllowed' and count(parameter)=0]"
			[Register ("isNullQuietZoneAllowed", "()Z", "GetIsNullQuietZoneAllowedHandler")]
			get {
				if (id_isNullQuietZoneAllowed == IntPtr.Zero)
					id_isNullQuietZoneAllowed = JNIEnv.GetMethodID (class_ref, "isNullQuietZoneAllowed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isNullQuietZoneAllowed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNullQuietZoneAllowed", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/method[@name='setNullQuietZoneAllowed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNullQuietZoneAllowed", "(Z)V", "GetSetNullQuietZoneAllowed_ZHandler")]
			set {
				if (id_setNullQuietZoneAllowed_Z == IntPtr.Zero)
					id_setNullQuietZoneAllowed_Z = JNIEnv.GetMethodID (class_ref, "setNullQuietZoneAllowed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNullQuietZoneAllowed_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNullQuietZoneAllowed", "(Z)V"), __args);
				} finally {
				}
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInverseScanning (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInverseScanning_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/method[@name='setInverseScanning' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setUncertainScanning_Z;
#pragma warning disable 0169
		static Delegate GetSetUncertainScanning_ZHandler ()
		{
			if (cb_setUncertainScanning_Z == null)
				cb_setUncertainScanning_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUncertainScanning_Z);
			return cb_setUncertainScanning_Z;
		}

		static void n_SetUncertainScanning_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUncertainScanning (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUncertainScanning_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/method[@name='setUncertainScanning' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUncertainScanning", "(Z)V", "GetSetUncertainScanning_ZHandler")]
		public virtual unsafe void SetUncertainScanning (bool p0)
		{
			if (id_setUncertainScanning_Z == IntPtr.Zero)
				id_setUncertainScanning_Z = JNIEnv.GetMethodID (class_ref, "setUncertainScanning", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUncertainScanning_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUncertainScanning", "(Z)V"), __args);
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417RecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
