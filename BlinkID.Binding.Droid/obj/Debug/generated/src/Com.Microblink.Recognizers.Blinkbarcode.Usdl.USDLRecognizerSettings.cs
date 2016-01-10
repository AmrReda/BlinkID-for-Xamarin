using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkbarcode.Usdl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkbarcode/usdl/USDLRecognizerSettings", DoNotGenerateAcw=true)]
	public partial class USDLRecognizerSettings : global::Com.Microblink.Recognizers.Settings.RecognizerSettings {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkbarcode/usdl/USDLRecognizerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (USDLRecognizerSettings); }
		}

		protected USDLRecognizerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/constructor[@name='USDLRecognizerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe USDLRecognizerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (USDLRecognizerSettings)) {
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

		static Delegate cb_isScanning1DBarcodes;
#pragma warning disable 0169
		static Delegate GetIsScanning1DBarcodesHandler ()
		{
			if (cb_isScanning1DBarcodes == null)
				cb_isScanning1DBarcodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScanning1DBarcodes);
			return cb_isScanning1DBarcodes;
		}

		static bool n_IsScanning1DBarcodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScanning1DBarcodes;
		}
#pragma warning restore 0169

		static IntPtr id_isScanning1DBarcodes;
		public virtual unsafe bool IsScanning1DBarcodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/method[@name='isScanning1DBarcodes' and count(parameter)=0]"
			[Register ("isScanning1DBarcodes", "()Z", "GetIsScanning1DBarcodesHandler")]
			get {
				if (id_isScanning1DBarcodes == IntPtr.Zero)
					id_isScanning1DBarcodes = JNIEnv.GetMethodID (class_ref, "isScanning1DBarcodes", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isScanning1DBarcodes);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isScanning1DBarcodes", "()Z"));
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUncertainScanMode;
		}
#pragma warning restore 0169

		static IntPtr id_isUncertainScanMode;
		public virtual unsafe bool IsUncertainScanMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/method[@name='isUncertainScanMode' and count(parameter)=0]"
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NullQuietZoneAllowed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isNullQuietZoneAllowed;
		static IntPtr id_setNullQuietZoneAllowed_Z;
		public virtual unsafe bool NullQuietZoneAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/method[@name='isNullQuietZoneAllowed' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/method[@name='setNullQuietZoneAllowed' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setScan1DBarcodes_Z;
#pragma warning disable 0169
		static Delegate GetSetScan1DBarcodes_ZHandler ()
		{
			if (cb_setScan1DBarcodes_Z == null)
				cb_setScan1DBarcodes_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScan1DBarcodes_Z);
			return cb_setScan1DBarcodes_Z;
		}

		static void n_SetScan1DBarcodes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScan1DBarcodes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScan1DBarcodes_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/method[@name='setScan1DBarcodes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScan1DBarcodes", "(Z)V", "GetSetScan1DBarcodes_ZHandler")]
		public virtual unsafe void SetScan1DBarcodes (bool p0)
		{
			if (id_setScan1DBarcodes_Z == IntPtr.Zero)
				id_setScan1DBarcodes_Z = JNIEnv.GetMethodID (class_ref, "setScan1DBarcodes", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScan1DBarcodes_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScan1DBarcodes", "(Z)V"), __args);
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUncertainScanning (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUncertainScanning_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/method[@name='setUncertainScanning' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLRecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
