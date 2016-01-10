using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Results.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='BarcodeElement']"
	[global::Android.Runtime.Register ("com/microblink/results/barcode/BarcodeElement", DoNotGenerateAcw=true)]
	public partial class BarcodeElement : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='BarcodeElement']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/results/barcode/BarcodeElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeElement); }
		}

		protected BarcodeElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JLcom_microblink_results_barcode_BarcodeDetailedData_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='BarcodeElement']/constructor[@name='BarcodeElement' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.microblink.results.barcode.BarcodeDetailedData']]"
		[Register (".ctor", "(JLcom/microblink/results/barcode/BarcodeDetailedData;)V", "")]
		public unsafe BarcodeElement (long p0, global::Com.Microblink.Results.Barcode.BarcodeDetailedData p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BarcodeElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JLcom/microblink/results/barcode/BarcodeDetailedData;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JLcom/microblink/results/barcode/BarcodeDetailedData;)V", __args);
					return;
				}

				if (id_ctor_JLcom_microblink_results_barcode_BarcodeDetailedData_ == IntPtr.Zero)
					id_ctor_JLcom_microblink_results_barcode_BarcodeDetailedData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JLcom/microblink/results/barcode/BarcodeDetailedData;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLcom_microblink_results_barcode_BarcodeDetailedData_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JLcom_microblink_results_barcode_BarcodeDetailedData_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='BarcodeElement']/constructor[@name='BarcodeElement' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe BarcodeElement (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BarcodeElement)) {
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

		static Delegate cb_getElementType;
#pragma warning disable 0169
		static Delegate GetGetElementTypeHandler ()
		{
			if (cb_getElementType == null)
				cb_getElementType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElementType);
			return cb_getElementType;
		}

		static IntPtr n_GetElementType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Barcode.BarcodeElement __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ElementType);
		}
#pragma warning restore 0169

		static IntPtr id_getElementType;
		public virtual unsafe global::Com.Microblink.Results.Barcode.ElementType ElementType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='BarcodeElement']/method[@name='getElementType' and count(parameter)=0]"
			[Register ("getElementType", "()Lcom/microblink/results/barcode/ElementType;", "GetGetElementTypeHandler")]
			get {
				if (id_getElementType == IntPtr.Zero)
					id_getElementType = JNIEnv.GetMethodID (class_ref, "getElementType", "()Lcom/microblink/results/barcode/ElementType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.ElementType> (JNIEnv.CallObjectMethod  (Handle, id_getElementType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.ElementType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElementType", "()Lcom/microblink/results/barcode/ElementType;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Results.Barcode.BarcodeElement __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='BarcodeElement']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getElementBytes;
#pragma warning disable 0169
		static Delegate GetGetElementBytesHandler ()
		{
			if (cb_getElementBytes == null)
				cb_getElementBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElementBytes);
			return cb_getElementBytes;
		}

		static IntPtr n_GetElementBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Barcode.BarcodeElement __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetElementBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getElementBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='BarcodeElement']/method[@name='getElementBytes' and count(parameter)=0]"
		[Register ("getElementBytes", "()[B", "GetGetElementBytesHandler")]
		public virtual unsafe byte[] GetElementBytes ()
		{
			if (id_getElementBytes == IntPtr.Zero)
				id_getElementBytes = JNIEnv.GetMethodID (class_ref, "getElementBytes", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getElementBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElementBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Microblink.Results.Barcode.BarcodeElement __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.barcode']/class[@name='BarcodeElement']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
