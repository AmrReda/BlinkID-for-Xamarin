using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Results.Ocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrResult']"
	[global::Android.Runtime.Register ("com/microblink/results/ocr/OcrResult", DoNotGenerateAcw=true)]
	public partial class OcrResult : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrResult']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/results/ocr/OcrResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrResult); }
		}

		protected OcrResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrResult']/constructor[@name='OcrResult' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe OcrResult (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (OcrResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_getResultName;
#pragma warning disable 0169
		static Delegate GetGetResultNameHandler ()
		{
			if (cb_getResultName == null)
				cb_getResultName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResultName);
			return cb_getResultName;
		}

		static IntPtr n_GetResultName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResultName);
		}
#pragma warning restore 0169

		static IntPtr id_getResultName;
		public virtual unsafe string ResultName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrResult']/method[@name='getResultName' and count(parameter)=0]"
			[Register ("getResultName", "()Ljava/lang/String;", "GetGetResultNameHandler")]
			get {
				if (id_getResultName == IntPtr.Zero)
					id_getResultName = JNIEnv.GetMethodID (class_ref, "getResultName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResultName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransformation;
#pragma warning disable 0169
		static Delegate GetGetTransformationHandler ()
		{
			if (cb_getTransformation == null)
				cb_getTransformation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransformation);
			return cb_getTransformation;
		}

		static IntPtr n_GetTransformation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transformation);
		}
#pragma warning restore 0169

		static IntPtr id_getTransformation;
		public virtual unsafe global::Android.Graphics.Matrix Transformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrResult']/method[@name='getTransformation' and count(parameter)=0]"
			[Register ("getTransformation", "()Landroid/graphics/Matrix;", "GetGetTransformationHandler")]
			get {
				if (id_getTransformation == IntPtr.Zero)
					id_getTransformation = JNIEnv.GetMethodID (class_ref, "getTransformation", "()Landroid/graphics/Matrix;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_getTransformation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransformation", "()Landroid/graphics/Matrix;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Results.Ocr.OcrResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrResult']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getBlocks;
#pragma warning disable 0169
		static Delegate GetGetBlocksHandler ()
		{
			if (cb_getBlocks == null)
				cb_getBlocks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlocks);
			return cb_getBlocks;
		}

		static IntPtr n_GetBlocks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBlocks ());
		}
#pragma warning restore 0169

		static IntPtr id_getBlocks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrResult']/method[@name='getBlocks' and count(parameter)=0]"
		[Register ("getBlocks", "()[Lcom/microblink/results/ocr/OcrBlock;", "GetGetBlocksHandler")]
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrBlock[] GetBlocks ()
		{
			if (id_getBlocks == IntPtr.Zero)
				id_getBlocks = JNIEnv.GetMethodID (class_ref, "getBlocks", "()[Lcom/microblink/results/ocr/OcrBlock;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.Microblink.Results.Ocr.OcrBlock[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBlocks), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Results.Ocr.OcrBlock));
				else
					return (global::Com.Microblink.Results.Ocr.OcrBlock[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlocks", "()[Lcom/microblink/results/ocr/OcrBlock;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Results.Ocr.OcrBlock));
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
			global::Com.Microblink.Results.Ocr.OcrResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
