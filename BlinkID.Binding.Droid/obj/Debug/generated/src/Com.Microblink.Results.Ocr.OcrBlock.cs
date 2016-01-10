using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Results.Ocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrBlock']"
	[global::Android.Runtime.Register ("com/microblink/results/ocr/OcrBlock", DoNotGenerateAcw=true)]
	public partial class OcrBlock : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrBlock']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/results/ocr/OcrBlock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrBlock); }
		}

		protected OcrBlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JLcom_microblink_results_ocr_OcrResult_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrBlock']/constructor[@name='OcrBlock' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.microblink.results.ocr.OcrResult']]"
		[Register (".ctor", "(JLcom/microblink/results/ocr/OcrResult;)V", "")]
		public unsafe OcrBlock (long p0, global::Com.Microblink.Results.Ocr.OcrResult p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (OcrBlock)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JLcom/microblink/results/ocr/OcrResult;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JLcom/microblink/results/ocr/OcrResult;)V", __args);
					return;
				}

				if (id_ctor_JLcom_microblink_results_ocr_OcrResult_ == IntPtr.Zero)
					id_ctor_JLcom_microblink_results_ocr_OcrResult_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JLcom/microblink/results/ocr/OcrResult;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLcom_microblink_results_ocr_OcrResult_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JLcom_microblink_results_ocr_OcrResult_, __args);
			} finally {
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrBlock __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		public virtual unsafe global::Com.Microblink.Geometry.Rectangle Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrBlock']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/microblink/geometry/Rectangle;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/microblink/geometry/Rectangle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()Lcom/microblink/geometry/Rectangle;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Results.Ocr.OcrBlock __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrBlock']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getLines;
#pragma warning disable 0169
		static Delegate GetGetLinesHandler ()
		{
			if (cb_getLines == null)
				cb_getLines = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLines);
			return cb_getLines;
		}

		static IntPtr n_GetLines (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrBlock __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLines ());
		}
#pragma warning restore 0169

		static IntPtr id_getLines;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrBlock']/method[@name='getLines' and count(parameter)=0]"
		[Register ("getLines", "()[Lcom/microblink/results/ocr/OcrLine;", "GetGetLinesHandler")]
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrLine[] GetLines ()
		{
			if (id_getLines == IntPtr.Zero)
				id_getLines = JNIEnv.GetMethodID (class_ref, "getLines", "()[Lcom/microblink/results/ocr/OcrLine;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.Microblink.Results.Ocr.OcrLine[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getLines), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Results.Ocr.OcrLine));
				else
					return (global::Com.Microblink.Results.Ocr.OcrLine[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLines", "()[Lcom/microblink/results/ocr/OcrLine;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Results.Ocr.OcrLine));
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
			global::Com.Microblink.Results.Ocr.OcrBlock __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrBlock']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
