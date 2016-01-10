using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkbarcode.Pdf417 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417ScanResult']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkbarcode/pdf417/Pdf417ScanResult", DoNotGenerateAcw=true)]
	public partial class Pdf417ScanResult : global::Com.Microblink.Recognizers.BaseRecognitionResult {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417ScanResult']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkbarcode/pdf417/Pdf417ScanResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pdf417ScanResult); }
		}

		protected Pdf417ScanResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417ScanResult']/constructor[@name='Pdf417ScanResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JZZ)V", "")]
		public unsafe Pdf417ScanResult (long p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Pdf417ScanResult)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417ScanResult']/constructor[@name='Pdf417ScanResult' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe Pdf417ScanResult (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Pdf417ScanResult)) {
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

		static Delegate cb_isUncertain;
#pragma warning disable 0169
		static Delegate GetIsUncertainHandler ()
		{
			if (cb_isUncertain == null)
				cb_isUncertain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUncertain);
			return cb_isUncertain;
		}

		static bool n_IsUncertain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417ScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417ScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUncertain;
		}
#pragma warning restore 0169

		static IntPtr id_isUncertain;
		public virtual unsafe bool IsUncertain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417ScanResult']/method[@name='isUncertain' and count(parameter)=0]"
			[Register ("isUncertain", "()Z", "GetIsUncertainHandler")]
			get {
				if (id_isUncertain == IntPtr.Zero)
					id_isUncertain = JNIEnv.GetMethodID (class_ref, "isUncertain", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isUncertain);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUncertain", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPositionOnImage;
#pragma warning disable 0169
		static Delegate GetGetPositionOnImageHandler ()
		{
			if (cb_getPositionOnImage == null)
				cb_getPositionOnImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPositionOnImage);
			return cb_getPositionOnImage;
		}

		static IntPtr n_GetPositionOnImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417ScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417ScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PositionOnImage);
		}
#pragma warning restore 0169

		static IntPtr id_getPositionOnImage;
		public virtual unsafe global::Com.Microblink.Geometry.Quadrilateral PositionOnImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417ScanResult']/method[@name='getPositionOnImage' and count(parameter)=0]"
			[Register ("getPositionOnImage", "()Lcom/microblink/geometry/Quadrilateral;", "GetGetPositionOnImageHandler")]
			get {
				if (id_getPositionOnImage == IntPtr.Zero)
					id_getPositionOnImage = JNIEnv.GetMethodID (class_ref, "getPositionOnImage", "()Lcom/microblink/geometry/Quadrilateral;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallObjectMethod  (Handle, id_getPositionOnImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionOnImage", "()Lcom/microblink/geometry/Quadrilateral;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417ScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417ScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawData);
		}
#pragma warning restore 0169

		static IntPtr id_getRawData;
		public virtual unsafe global::Com.Microblink.Results.Barcode.BarcodeDetailedData RawData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417ScanResult']/method[@name='getRawData' and count(parameter)=0]"
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
			global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417ScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Pdf417.Pdf417ScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StringData);
		}
#pragma warning restore 0169

		static IntPtr id_getStringData;
		public virtual unsafe string StringData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.pdf417']/class[@name='Pdf417ScanResult']/method[@name='getStringData' and count(parameter)=0]"
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
