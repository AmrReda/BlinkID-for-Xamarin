using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='RecognitionResults']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/RecognitionResults", DoNotGenerateAcw=true)]
	public partial class RecognitionResults : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='RecognitionResults']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/RecognitionResults", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognitionResults); }
		}

		protected RecognitionResults (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_view_recognition_RecognitionType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='RecognitionResults']/constructor[@name='RecognitionResults' and count(parameter)=2 and parameter[1][@type='com.microblink.recognizers.BaseRecognitionResult[]'] and parameter[2][@type='com.microblink.view.recognition.RecognitionType']]"
		[Register (".ctor", "([Lcom/microblink/recognizers/BaseRecognitionResult;Lcom/microblink/view/recognition/RecognitionType;)V", "")]
		public unsafe RecognitionResults (global::Com.Microblink.Recognizers.BaseRecognitionResult[] p0, global::Com.Microblink.View.Recognition.RecognitionType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RecognitionResults)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lcom/microblink/recognizers/BaseRecognitionResult;Lcom/microblink/view/recognition/RecognitionType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Lcom/microblink/recognizers/BaseRecognitionResult;Lcom/microblink/view/recognition/RecognitionType;)V", __args);
					return;
				}

				if (id_ctor_arrayLcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_view_recognition_RecognitionType_ == IntPtr.Zero)
					id_ctor_arrayLcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_view_recognition_RecognitionType_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lcom/microblink/recognizers/BaseRecognitionResult;Lcom/microblink/view/recognition/RecognitionType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_view_recognition_RecognitionType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_view_recognition_RecognitionType_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='RecognitionResults']/constructor[@name='RecognitionResults' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe RecognitionResults (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RecognitionResults)) {
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

		static Delegate cb_getRecognitionType;
#pragma warning disable 0169
		static Delegate GetGetRecognitionTypeHandler ()
		{
			if (cb_getRecognitionType == null)
				cb_getRecognitionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecognitionType);
			return cb_getRecognitionType;
		}

		static IntPtr n_GetRecognitionType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.RecognitionResults __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.RecognitionResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RecognitionType);
		}
#pragma warning restore 0169

		static IntPtr id_getRecognitionType;
		public virtual unsafe global::Com.Microblink.View.Recognition.RecognitionType RecognitionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='RecognitionResults']/method[@name='getRecognitionType' and count(parameter)=0]"
			[Register ("getRecognitionType", "()Lcom/microblink/view/recognition/RecognitionType;", "GetGetRecognitionTypeHandler")]
			get {
				if (id_getRecognitionType == IntPtr.Zero)
					id_getRecognitionType = JNIEnv.GetMethodID (class_ref, "getRecognitionType", "()Lcom/microblink/view/recognition/RecognitionType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognitionType> (JNIEnv.CallObjectMethod  (Handle, id_getRecognitionType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Recognition.RecognitionType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecognitionType", "()Lcom/microblink/view/recognition/RecognitionType;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Recognizers.RecognitionResults __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.RecognitionResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='RecognitionResults']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getRecognitionResults;
#pragma warning disable 0169
		static Delegate GetGetRecognitionResultsHandler ()
		{
			if (cb_getRecognitionResults == null)
				cb_getRecognitionResults = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecognitionResults);
			return cb_getRecognitionResults;
		}

		static IntPtr n_GetRecognitionResults (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.RecognitionResults __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.RecognitionResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRecognitionResults ());
		}
#pragma warning restore 0169

		static IntPtr id_getRecognitionResults;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='RecognitionResults']/method[@name='getRecognitionResults' and count(parameter)=0]"
		[Register ("getRecognitionResults", "()[Lcom/microblink/recognizers/BaseRecognitionResult;", "GetGetRecognitionResultsHandler")]
		public virtual unsafe global::Com.Microblink.Recognizers.BaseRecognitionResult[] GetRecognitionResults ()
		{
			if (id_getRecognitionResults == IntPtr.Zero)
				id_getRecognitionResults = JNIEnv.GetMethodID (class_ref, "getRecognitionResults", "()[Lcom/microblink/recognizers/BaseRecognitionResult;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.Microblink.Recognizers.BaseRecognitionResult[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRecognitionResults), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognizers.BaseRecognitionResult));
				else
					return (global::Com.Microblink.Recognizers.BaseRecognitionResult[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecognitionResults", "()[Lcom/microblink/recognizers/BaseRecognitionResult;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Recognizers.BaseRecognitionResult));
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
			global::Com.Microblink.Recognizers.RecognitionResults __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.RecognitionResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='RecognitionResults']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
