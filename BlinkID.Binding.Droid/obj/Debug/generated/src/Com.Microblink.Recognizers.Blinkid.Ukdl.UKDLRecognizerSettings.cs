using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkid.Ukdl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkid/ukdl/UKDLRecognizerSettings", DoNotGenerateAcw=true)]
	public partial class UKDLRecognizerSettings : global::Com.Microblink.Recognizers.Settings.RecognizerSettings {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkid/ukdl/UKDLRecognizerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UKDLRecognizerSettings); }
		}

		protected UKDLRecognizerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/constructor[@name='UKDLRecognizerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UKDLRecognizerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UKDLRecognizerSettings)) {
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

		static Delegate cb_setExtractAddress_Z;
#pragma warning disable 0169
		static Delegate GetSetExtractAddress_ZHandler ()
		{
			if (cb_setExtractAddress_Z == null)
				cb_setExtractAddress_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExtractAddress_Z);
			return cb_setExtractAddress_Z;
		}

		static void n_SetExtractAddress_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExtractAddress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExtractAddress_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/method[@name='setExtractAddress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setExtractAddress", "(Z)V", "GetSetExtractAddress_ZHandler")]
		public virtual unsafe void SetExtractAddress (bool p0)
		{
			if (id_setExtractAddress_Z == IntPtr.Zero)
				id_setExtractAddress_Z = JNIEnv.GetMethodID (class_ref, "setExtractAddress", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExtractAddress_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtractAddress", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExtractExpiryDate_Z;
#pragma warning disable 0169
		static Delegate GetSetExtractExpiryDate_ZHandler ()
		{
			if (cb_setExtractExpiryDate_Z == null)
				cb_setExtractExpiryDate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExtractExpiryDate_Z);
			return cb_setExtractExpiryDate_Z;
		}

		static void n_SetExtractExpiryDate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExtractExpiryDate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExtractExpiryDate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/method[@name='setExtractExpiryDate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setExtractExpiryDate", "(Z)V", "GetSetExtractExpiryDate_ZHandler")]
		public virtual unsafe void SetExtractExpiryDate (bool p0)
		{
			if (id_setExtractExpiryDate_Z == IntPtr.Zero)
				id_setExtractExpiryDate_Z = JNIEnv.GetMethodID (class_ref, "setExtractExpiryDate", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExtractExpiryDate_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtractExpiryDate", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExtractIssueDate_Z;
#pragma warning disable 0169
		static Delegate GetSetExtractIssueDate_ZHandler ()
		{
			if (cb_setExtractIssueDate_Z == null)
				cb_setExtractIssueDate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExtractIssueDate_Z);
			return cb_setExtractIssueDate_Z;
		}

		static void n_SetExtractIssueDate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExtractIssueDate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExtractIssueDate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/method[@name='setExtractIssueDate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setExtractIssueDate", "(Z)V", "GetSetExtractIssueDate_ZHandler")]
		public virtual unsafe void SetExtractIssueDate (bool p0)
		{
			if (id_setExtractIssueDate_Z == IntPtr.Zero)
				id_setExtractIssueDate_Z = JNIEnv.GetMethodID (class_ref, "setExtractIssueDate", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExtractIssueDate_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtractIssueDate", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shouldExtractAddress;
#pragma warning disable 0169
		static Delegate GetShouldExtractAddressHandler ()
		{
			if (cb_shouldExtractAddress == null)
				cb_shouldExtractAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldExtractAddress);
			return cb_shouldExtractAddress;
		}

		static bool n_ShouldExtractAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldExtractAddress ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldExtractAddress;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/method[@name='shouldExtractAddress' and count(parameter)=0]"
		[Register ("shouldExtractAddress", "()Z", "GetShouldExtractAddressHandler")]
		public virtual unsafe bool ShouldExtractAddress ()
		{
			if (id_shouldExtractAddress == IntPtr.Zero)
				id_shouldExtractAddress = JNIEnv.GetMethodID (class_ref, "shouldExtractAddress", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldExtractAddress);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldExtractAddress", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldExtractExpiryDate;
#pragma warning disable 0169
		static Delegate GetShouldExtractExpiryDateHandler ()
		{
			if (cb_shouldExtractExpiryDate == null)
				cb_shouldExtractExpiryDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldExtractExpiryDate);
			return cb_shouldExtractExpiryDate;
		}

		static bool n_ShouldExtractExpiryDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldExtractExpiryDate ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldExtractExpiryDate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/method[@name='shouldExtractExpiryDate' and count(parameter)=0]"
		[Register ("shouldExtractExpiryDate", "()Z", "GetShouldExtractExpiryDateHandler")]
		public virtual unsafe bool ShouldExtractExpiryDate ()
		{
			if (id_shouldExtractExpiryDate == IntPtr.Zero)
				id_shouldExtractExpiryDate = JNIEnv.GetMethodID (class_ref, "shouldExtractExpiryDate", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldExtractExpiryDate);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldExtractExpiryDate", "()Z"));
			} finally {
			}
		}

		static Delegate cb_shouldExtractIssueDate;
#pragma warning disable 0169
		static Delegate GetShouldExtractIssueDateHandler ()
		{
			if (cb_shouldExtractIssueDate == null)
				cb_shouldExtractIssueDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldExtractIssueDate);
			return cb_shouldExtractIssueDate;
		}

		static bool n_ShouldExtractIssueDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldExtractIssueDate ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldExtractIssueDate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/method[@name='shouldExtractIssueDate' and count(parameter)=0]"
		[Register ("shouldExtractIssueDate", "()Z", "GetShouldExtractIssueDateHandler")]
		public virtual unsafe bool ShouldExtractIssueDate ()
		{
			if (id_shouldExtractIssueDate == IntPtr.Zero)
				id_shouldExtractIssueDate = JNIEnv.GetMethodID (class_ref, "shouldExtractIssueDate", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldExtractIssueDate);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldExtractIssueDate", "()Z"));
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
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
