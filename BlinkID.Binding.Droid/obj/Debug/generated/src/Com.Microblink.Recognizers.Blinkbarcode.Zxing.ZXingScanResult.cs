using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkbarcode.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkbarcode/zxing/ZXingScanResult", DoNotGenerateAcw=true)]
	public partial class ZXingScanResult : global::Com.Microblink.Recognizers.BaseRecognitionResult {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkbarcode/zxing/ZXingScanResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZXingScanResult); }
		}

		protected ZXingScanResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']/constructor[@name='ZXingScanResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JZZ)V", "")]
		public unsafe ZXingScanResult (long p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ZXingScanResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JZZ)V", __args);
					return;
				}

				if (id_ctor_JZZ == IntPtr.Zero)
					id_ctor_JZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JZZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']/constructor[@name='ZXingScanResult' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe ZXingScanResult (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ZXingScanResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getBarcodeType;
#pragma warning disable 0169
		static Delegate GetGetBarcodeTypeHandler ()
		{
			if (cb_getBarcodeType == null)
				cb_getBarcodeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarcodeType);
			return cb_getBarcodeType;
		}

		static IntPtr n_GetBarcodeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BarcodeType);
		}
#pragma warning restore 0169

		static IntPtr id_getBarcodeType;
		public virtual unsafe global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType BarcodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']/method[@name='getBarcodeType' and count(parameter)=0]"
			[Register ("getBarcodeType", "()Lcom/microblink/recognizers/blinkbarcode/BarcodeType;", "GetGetBarcodeTypeHandler")]
			get {
				if (id_getBarcodeType == IntPtr.Zero)
					id_getBarcodeType = JNIEnv.GetMethodID (class_ref, "getBarcodeType", "()Lcom/microblink/recognizers/blinkbarcode/BarcodeType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (JNIEnv.CallObjectMethod  (Handle, id_getBarcodeType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.BarcodeType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBarcodeType", "()Lcom/microblink/recognizers/blinkbarcode/BarcodeType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtendedRawData;
#pragma warning disable 0169
		static Delegate GetGetExtendedRawDataHandler ()
		{
			if (cb_getExtendedRawData == null)
				cb_getExtendedRawData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtendedRawData);
			return cb_getExtendedRawData;
		}

		static IntPtr n_GetExtendedRawData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtendedRawData);
		}
#pragma warning restore 0169

		static IntPtr id_getExtendedRawData;
		public virtual unsafe global::Com.Microblink.Results.Barcode.BarcodeDetailedData ExtendedRawData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']/method[@name='getExtendedRawData' and count(parameter)=0]"
			[Register ("getExtendedRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;", "GetGetExtendedRawDataHandler")]
			get {
				if (id_getExtendedRawData == IntPtr.Zero)
					id_getExtendedRawData = JNIEnv.GetMethodID (class_ref, "getExtendedRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeDetailedData> (JNIEnv.CallObjectMethod  (Handle, id_getExtendedRawData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeDetailedData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtendedRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtendedStringData;
#pragma warning disable 0169
		static Delegate GetGetExtendedStringDataHandler ()
		{
			if (cb_getExtendedStringData == null)
				cb_getExtendedStringData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtendedStringData);
			return cb_getExtendedStringData;
		}

		static IntPtr n_GetExtendedStringData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExtendedStringData);
		}
#pragma warning restore 0169

		static IntPtr id_getExtendedStringData;
		public virtual unsafe string ExtendedStringData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']/method[@name='getExtendedStringData' and count(parameter)=0]"
			[Register ("getExtendedStringData", "()Ljava/lang/String;", "GetGetExtendedStringDataHandler")]
			get {
				if (id_getExtendedStringData == IntPtr.Zero)
					id_getExtendedStringData = JNIEnv.GetMethodID (class_ref, "getExtendedStringData", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExtendedStringData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtendedStringData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawData;
#pragma warning disable 0169
		static Delegate GetGetRawDataHandler ()
		{
			if (cb_getRawData == null)
				cb_getRawData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawData);
			return cb_getRawData;
		}

		static IntPtr n_GetRawData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawData);
		}
#pragma warning restore 0169

		static IntPtr id_getRawData;
		public virtual unsafe global::Com.Microblink.Results.Barcode.BarcodeDetailedData RawData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']/method[@name='getRawData' and count(parameter)=0]"
			[Register ("getRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;", "GetGetRawDataHandler")]
			get {
				if (id_getRawData == IntPtr.Zero)
					id_getRawData = JNIEnv.GetMethodID (class_ref, "getRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeDetailedData> (JNIEnv.CallObjectMethod  (Handle, id_getRawData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeDetailedData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStringData;
#pragma warning disable 0169
		static Delegate GetGetStringDataHandler ()
		{
			if (cb_getStringData == null)
				cb_getStringData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStringData);
			return cb_getStringData;
		}

		static IntPtr n_GetStringData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Zxing.ZXingScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StringData);
		}
#pragma warning restore 0169

		static IntPtr id_getStringData;
		public virtual unsafe string StringData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.zxing']/class[@name='ZXingScanResult']/method[@name='getStringData' and count(parameter)=0]"
			[Register ("getStringData", "()Ljava/lang/String;", "GetGetStringDataHandler")]
			get {
				if (id_getStringData == IntPtr.Zero)
					id_getStringData = JNIEnv.GetMethodID (class_ref, "getStringData", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStringData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
