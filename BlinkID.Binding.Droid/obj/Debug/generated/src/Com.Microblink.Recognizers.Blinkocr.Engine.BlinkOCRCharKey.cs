using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkocr.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCRCharKey']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkocr/engine/BlinkOCRCharKey", DoNotGenerateAcw=true)]
	public partial class BlinkOCRCharKey : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCRCharKey']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkocr/engine/BlinkOCRCharKey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlinkOCRCharKey); }
		}

		protected BlinkOCRCharKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILcom_microblink_results_ocr_OcrFont_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCRCharKey']/constructor[@name='BlinkOCRCharKey' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.microblink.results.ocr.OcrFont']]"
		[Register (".ctor", "(ILcom/microblink/results/ocr/OcrFont;)V", "")]
		public unsafe BlinkOCRCharKey (int p0, global::Com.Microblink.Results.Ocr.OcrFont p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BlinkOCRCharKey)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/microblink/results/ocr/OcrFont;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/microblink/results/ocr/OcrFont;)V", __args);
					return;
				}

				if (id_ctor_ILcom_microblink_results_ocr_OcrFont_ == IntPtr.Zero)
					id_ctor_ILcom_microblink_results_ocr_OcrFont_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/microblink/results/ocr/OcrFont;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_microblink_results_ocr_OcrFont_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_microblink_results_ocr_OcrFont_, __args);
			} finally {
			}
		}

		static Delegate cb_getFont;
#pragma warning disable 0169
		static Delegate GetGetFontHandler ()
		{
			if (cb_getFont == null)
				cb_getFont = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFont);
			return cb_getFont;
		}

		static IntPtr n_GetFont (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Font);
		}
#pragma warning restore 0169

		static IntPtr id_getFont;
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrFont Font {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCRCharKey']/method[@name='getFont' and count(parameter)=0]"
			[Register ("getFont", "()Lcom/microblink/results/ocr/OcrFont;", "GetGetFontHandler")]
			get {
				if (id_getFont == IntPtr.Zero)
					id_getFont = JNIEnv.GetMethodID (class_ref, "getFont", "()Lcom/microblink/results/ocr/OcrFont;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrFont> (JNIEnv.CallObjectMethod  (Handle, id_getFont), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrFont> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFont", "()Lcom/microblink/results/ocr/OcrFont;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKey);
			return cb_getKey;
		}

		static int n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Key;
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		public virtual unsafe int Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCRCharKey']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()I", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getKey);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()I"));
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
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCRCharKey']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Engine.BlinkOCRCharKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.engine']/class[@name='BlinkOCRCharKey']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
