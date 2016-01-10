using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkbarcode.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkbarcode/zxing/ZXingRecognizerSettings", DoNotGenerateAcw=true)]
	public partial class ZXingRecognizerSettings : global::Com.Microblink.Recognizers.Settings.RecognizerSettings {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkbarcode/zxing/ZXingRecognizerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZXingRecognizerSettings); }
		}

		protected ZXingRecognizerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/constructor[@name='ZXingRecognizerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ZXingRecognizerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ZXingRecognizerSettings)) {
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInverseScanMode;
		}
#pragma warning restore 0169

		static IntPtr id_isInverseScanMode;
		public virtual unsafe bool IsInverseScanMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='isInverseScanMode' and count(parameter)=0]"
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

		static Delegate cb_isSlowThoroughScan;
#pragma warning disable 0169
		static Delegate GetIsSlowThoroughScanHandler ()
		{
			if (cb_isSlowThoroughScan == null)
				cb_isSlowThoroughScan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSlowThoroughScan);
			return cb_isSlowThoroughScan;
		}

		static bool n_IsSlowThoroughScan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SlowThoroughScan;
		}
#pragma warning restore 0169

		static Delegate cb_setSlowThoroughScan_Z;
#pragma warning disable 0169
		static Delegate GetSetSlowThoroughScan_ZHandler ()
		{
			if (cb_setSlowThoroughScan_Z == null)
				cb_setSlowThoroughScan_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSlowThoroughScan_Z);
			return cb_setSlowThoroughScan_Z;
		}

		static void n_SetSlowThoroughScan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlowThoroughScan = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSlowThoroughScan;
		static IntPtr id_setSlowThoroughScan_Z;
		public virtual unsafe bool SlowThoroughScan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='isSlowThoroughScan' and count(parameter)=0]"
			[Register ("isSlowThoroughScan", "()Z", "GetIsSlowThoroughScanHandler")]
			get {
				if (id_isSlowThoroughScan == IntPtr.Zero)
					id_isSlowThoroughScan = JNIEnv.GetMethodID (class_ref, "isSlowThoroughScan", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSlowThoroughScan);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSlowThoroughScan", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setSlowThoroughScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSlowThoroughScan", "(Z)V", "GetSetSlowThoroughScan_ZHandler")]
			set {
				if (id_setSlowThoroughScan_Z == IntPtr.Zero)
					id_setSlowThoroughScan_Z = JNIEnv.GetMethodID (class_ref, "setSlowThoroughScan", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSlowThoroughScan_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSlowThoroughScan", "(Z)V"), __args);
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInverseScanning (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInverseScanning_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setInverseScanning' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setScanAztecCode_Z;
#pragma warning disable 0169
		static Delegate GetSetScanAztecCode_ZHandler ()
		{
			if (cb_setScanAztecCode_Z == null)
				cb_setScanAztecCode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanAztecCode_Z);
			return cb_setScanAztecCode_Z;
		}

		static void n_SetScanAztecCode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanAztecCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanAztecCode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanAztecCode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanAztecCode", "(Z)V", "GetSetScanAztecCode_ZHandler")]
		public virtual unsafe void SetScanAztecCode (bool p0)
		{
			if (id_setScanAztecCode_Z == IntPtr.Zero)
				id_setScanAztecCode_Z = JNIEnv.GetMethodID (class_ref, "setScanAztecCode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanAztecCode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanAztecCode", "(Z)V"), __args);
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanCode128 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanCode128_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanCode128' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanCode39 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanCode39_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanCode39' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setScanDataMatrixCode_Z;
#pragma warning disable 0169
		static Delegate GetSetScanDataMatrixCode_ZHandler ()
		{
			if (cb_setScanDataMatrixCode_Z == null)
				cb_setScanDataMatrixCode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanDataMatrixCode_Z);
			return cb_setScanDataMatrixCode_Z;
		}

		static void n_SetScanDataMatrixCode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanDataMatrixCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanDataMatrixCode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanDataMatrixCode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanDataMatrixCode", "(Z)V", "GetSetScanDataMatrixCode_ZHandler")]
		public virtual unsafe void SetScanDataMatrixCode (bool p0)
		{
			if (id_setScanDataMatrixCode_Z == IntPtr.Zero)
				id_setScanDataMatrixCode_Z = JNIEnv.GetMethodID (class_ref, "setScanDataMatrixCode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanDataMatrixCode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanDataMatrixCode", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScanEAN13Code_Z;
#pragma warning disable 0169
		static Delegate GetSetScanEAN13Code_ZHandler ()
		{
			if (cb_setScanEAN13Code_Z == null)
				cb_setScanEAN13Code_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanEAN13Code_Z);
			return cb_setScanEAN13Code_Z;
		}

		static void n_SetScanEAN13Code_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanEAN13Code (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanEAN13Code_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanEAN13Code' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanEAN13Code", "(Z)V", "GetSetScanEAN13Code_ZHandler")]
		public virtual unsafe void SetScanEAN13Code (bool p0)
		{
			if (id_setScanEAN13Code_Z == IntPtr.Zero)
				id_setScanEAN13Code_Z = JNIEnv.GetMethodID (class_ref, "setScanEAN13Code", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanEAN13Code_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanEAN13Code", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScanEAN8Code_Z;
#pragma warning disable 0169
		static Delegate GetSetScanEAN8Code_ZHandler ()
		{
			if (cb_setScanEAN8Code_Z == null)
				cb_setScanEAN8Code_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanEAN8Code_Z);
			return cb_setScanEAN8Code_Z;
		}

		static void n_SetScanEAN8Code_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanEAN8Code (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanEAN8Code_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanEAN8Code' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanEAN8Code", "(Z)V", "GetSetScanEAN8Code_ZHandler")]
		public virtual unsafe void SetScanEAN8Code (bool p0)
		{
			if (id_setScanEAN8Code_Z == IntPtr.Zero)
				id_setScanEAN8Code_Z = JNIEnv.GetMethodID (class_ref, "setScanEAN8Code", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanEAN8Code_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanEAN8Code", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScanITFCode_Z;
#pragma warning disable 0169
		static Delegate GetSetScanITFCode_ZHandler ()
		{
			if (cb_setScanITFCode_Z == null)
				cb_setScanITFCode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanITFCode_Z);
			return cb_setScanITFCode_Z;
		}

		static void n_SetScanITFCode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanITFCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanITFCode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanITFCode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanITFCode", "(Z)V", "GetSetScanITFCode_ZHandler")]
		public virtual unsafe void SetScanITFCode (bool p0)
		{
			if (id_setScanITFCode_Z == IntPtr.Zero)
				id_setScanITFCode_Z = JNIEnv.GetMethodID (class_ref, "setScanITFCode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanITFCode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanITFCode", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScanQRCode_Z;
#pragma warning disable 0169
		static Delegate GetSetScanQRCode_ZHandler ()
		{
			if (cb_setScanQRCode_Z == null)
				cb_setScanQRCode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanQRCode_Z);
			return cb_setScanQRCode_Z;
		}

		static void n_SetScanQRCode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanQRCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanQRCode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanQRCode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanQRCode", "(Z)V", "GetSetScanQRCode_ZHandler")]
		public virtual unsafe void SetScanQRCode (bool p0)
		{
			if (id_setScanQRCode_Z == IntPtr.Zero)
				id_setScanQRCode_Z = JNIEnv.GetMethodID (class_ref, "setScanQRCode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanQRCode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanQRCode", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScanUPCACode_Z;
#pragma warning disable 0169
		static Delegate GetSetScanUPCACode_ZHandler ()
		{
			if (cb_setScanUPCACode_Z == null)
				cb_setScanUPCACode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanUPCACode_Z);
			return cb_setScanUPCACode_Z;
		}

		static void n_SetScanUPCACode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanUPCACode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanUPCACode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanUPCACode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanUPCACode", "(Z)V", "GetSetScanUPCACode_ZHandler")]
		public virtual unsafe void SetScanUPCACode (bool p0)
		{
			if (id_setScanUPCACode_Z == IntPtr.Zero)
				id_setScanUPCACode_Z = JNIEnv.GetMethodID (class_ref, "setScanUPCACode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanUPCACode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanUPCACode", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScanUPCECode_Z;
#pragma warning disable 0169
		static Delegate GetSetScanUPCECode_ZHandler ()
		{
			if (cb_setScanUPCECode_Z == null)
				cb_setScanUPCECode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScanUPCECode_Z);
			return cb_setScanUPCECode_Z;
		}

		static void n_SetScanUPCECode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScanUPCECode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScanUPCECode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='setScanUPCECode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScanUPCECode", "(Z)V", "GetSetScanUPCECode_ZHandler")]
		public virtual unsafe void SetScanUPCECode (bool p0)
		{
			if (id_setScanUPCECode_Z == IntPtr.Zero)
				id_setScanUPCECode_Z = JNIEnv.GetMethodID (class_ref, "setScanUPCECode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScanUPCECode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScanUPCECode", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shouldScanAztecCode;
#pragma warning disable 0169
		static Delegate GetShouldScanAztecCodeHandler ()
		{
			if (cb_shouldScanAztecCode == null)
				cb_shouldScanAztecCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanAztecCode);
			return cb_shouldScanAztecCode;
		}

		static bool n_ShouldScanAztecCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanAztecCode ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanAztecCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanAztecCode' and count(parameter)=0]"
		[Register ("shouldScanAztecCode", "()Z", "GetShouldScanAztecCodeHandler")]
		public virtual unsafe bool ShouldScanAztecCode ()
		{
			if (id_shouldScanAztecCode == IntPtr.Zero)
				id_shouldScanAztecCode = JNIEnv.GetMethodID (class_ref, "shouldScanAztecCode", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanAztecCode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanAztecCode", "()Z"));
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanCode128 ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanCode128;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanCode128' and count(parameter)=0]"
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanCode39 ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanCode39;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanCode39' and count(parameter)=0]"
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

		static Delegate cb_shouldScanDataMatrixCode;
#pragma warning disable 0169
		static Delegate GetShouldScanDataMatrixCodeHandler ()
		{
			if (cb_shouldScanDataMatrixCode == null)
				cb_shouldScanDataMatrixCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanDataMatrixCode);
			return cb_shouldScanDataMatrixCode;
		}

		static bool n_ShouldScanDataMatrixCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanDataMatrixCode ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanDataMatrixCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanDataMatrixCode' and count(parameter)=0]"
		[Register ("shouldScanDataMatrixCode", "()Z", "GetShouldScanDataMatrixCodeHandler")]
		public virtual unsafe bool ShouldScanDataMatrixCode ()
		{
			if (id_shouldScanDataMatrixCode == IntPtr.Zero)
				id_shouldScanDataMatrixCode = JNIEnv.GetMethodID (class_ref, "shouldScanDataMatrixCode", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanDataMatrixCode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanDataMatrixCode", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldScanEAN13Code;
#pragma warning disable 0169
		static Delegate GetShouldScanEAN13CodeHandler ()
		{
			if (cb_shouldScanEAN13Code == null)
				cb_shouldScanEAN13Code = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanEAN13Code);
			return cb_shouldScanEAN13Code;
		}

		static bool n_ShouldScanEAN13Code (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanEAN13Code ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanEAN13Code;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanEAN13Code' and count(parameter)=0]"
		[Register ("shouldScanEAN13Code", "()Z", "GetShouldScanEAN13CodeHandler")]
		public virtual unsafe bool ShouldScanEAN13Code ()
		{
			if (id_shouldScanEAN13Code == IntPtr.Zero)
				id_shouldScanEAN13Code = JNIEnv.GetMethodID (class_ref, "shouldScanEAN13Code", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanEAN13Code);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanEAN13Code", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldScanEAN8Code;
#pragma warning disable 0169
		static Delegate GetShouldScanEAN8CodeHandler ()
		{
			if (cb_shouldScanEAN8Code == null)
				cb_shouldScanEAN8Code = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanEAN8Code);
			return cb_shouldScanEAN8Code;
		}

		static bool n_ShouldScanEAN8Code (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanEAN8Code ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanEAN8Code;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanEAN8Code' and count(parameter)=0]"
		[Register ("shouldScanEAN8Code", "()Z", "GetShouldScanEAN8CodeHandler")]
		public virtual unsafe bool ShouldScanEAN8Code ()
		{
			if (id_shouldScanEAN8Code == IntPtr.Zero)
				id_shouldScanEAN8Code = JNIEnv.GetMethodID (class_ref, "shouldScanEAN8Code", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanEAN8Code);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanEAN8Code", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldScanITFCode;
#pragma warning disable 0169
		static Delegate GetShouldScanITFCodeHandler ()
		{
			if (cb_shouldScanITFCode == null)
				cb_shouldScanITFCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanITFCode);
			return cb_shouldScanITFCode;
		}

		static bool n_ShouldScanITFCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanITFCode ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanITFCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanITFCode' and count(parameter)=0]"
		[Register ("shouldScanITFCode", "()Z", "GetShouldScanITFCodeHandler")]
		public virtual unsafe bool ShouldScanITFCode ()
		{
			if (id_shouldScanITFCode == IntPtr.Zero)
				id_shouldScanITFCode = JNIEnv.GetMethodID (class_ref, "shouldScanITFCode", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanITFCode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanITFCode", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldScanQRCode;
#pragma warning disable 0169
		static Delegate GetShouldScanQRCodeHandler ()
		{
			if (cb_shouldScanQRCode == null)
				cb_shouldScanQRCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanQRCode);
			return cb_shouldScanQRCode;
		}

		static bool n_ShouldScanQRCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanQRCode ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanQRCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanQRCode' and count(parameter)=0]"
		[Register ("shouldScanQRCode", "()Z", "GetShouldScanQRCodeHandler")]
		public virtual unsafe bool ShouldScanQRCode ()
		{
			if (id_shouldScanQRCode == IntPtr.Zero)
				id_shouldScanQRCode = JNIEnv.GetMethodID (class_ref, "shouldScanQRCode", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanQRCode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanQRCode", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldScanUPCACode;
#pragma warning disable 0169
		static Delegate GetShouldScanUPCACodeHandler ()
		{
			if (cb_shouldScanUPCACode == null)
				cb_shouldScanUPCACode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanUPCACode);
			return cb_shouldScanUPCACode;
		}

		static bool n_ShouldScanUPCACode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanUPCACode ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanUPCACode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanUPCACode' and count(parameter)=0]"
		[Register ("shouldScanUPCACode", "()Z", "GetShouldScanUPCACodeHandler")]
		public virtual unsafe bool ShouldScanUPCACode ()
		{
			if (id_shouldScanUPCACode == IntPtr.Zero)
				id_shouldScanUPCACode = JNIEnv.GetMethodID (class_ref, "shouldScanUPCACode", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanUPCACode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanUPCACode", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldScanUPCECode;
#pragma warning disable 0169
		static Delegate GetShouldScanUPCECodeHandler ()
		{
			if (cb_shouldScanUPCECode == null)
				cb_shouldScanUPCECode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldScanUPCECode);
			return cb_shouldScanUPCECode;
		}

		static bool n_ShouldScanUPCECode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldScanUPCECode ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldScanUPCECode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='shouldScanUPCECode' and count(parameter)=0]"
		[Register ("shouldScanUPCECode", "()Z", "GetShouldScanUPCECodeHandler")]
		public virtual unsafe bool ShouldScanUPCECode ()
		{
			if (id_shouldScanUPCECode == IntPtr.Zero)
				id_shouldScanUPCECode = JNIEnv.GetMethodID (class_ref, "shouldScanUPCECode", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldScanUPCECode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldScanUPCECode", "()Z"));
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingRecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
