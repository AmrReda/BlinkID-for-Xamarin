using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkid.Mrtd {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkid/mrtd/MRTDRecognizerSettings", DoNotGenerateAcw=true)]
	public partial class MRTDRecognizerSettings : global::Com.Microblink.Recognizers.Settings.RecognizerSettings {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkid/mrtd/MRTDRecognizerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRTDRecognizerSettings); }
		}

		protected MRTDRecognizerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/constructor[@name='MRTDRecognizerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MRTDRecognizerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MRTDRecognizerSettings)) {
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

		static Delegate cb_isShowingFullDocument;
#pragma warning disable 0169
		static Delegate GetIsShowingFullDocumentHandler ()
		{
			if (cb_isShowingFullDocument == null)
				cb_isShowingFullDocument = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowingFullDocument);
			return cb_isShowingFullDocument;
		}

		static bool n_IsShowingFullDocument (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowingFullDocument;
		}
#pragma warning restore 0169

		static IntPtr id_isShowingFullDocument;
		public virtual unsafe bool IsShowingFullDocument {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/method[@name='isShowingFullDocument' and count(parameter)=0]"
			[Register ("isShowingFullDocument", "()Z", "GetIsShowingFullDocumentHandler")]
			get {
				if (id_isShowingFullDocument == IntPtr.Zero)
					id_isShowingFullDocument = JNIEnv.GetMethodID (class_ref, "isShowingFullDocument", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isShowingFullDocument);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowingFullDocument", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isShowingMRZ;
#pragma warning disable 0169
		static Delegate GetIsShowingMRZHandler ()
		{
			if (cb_isShowingMRZ == null)
				cb_isShowingMRZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowingMRZ);
			return cb_isShowingMRZ;
		}

		static bool n_IsShowingMRZ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowingMRZ;
		}
#pragma warning restore 0169

		static IntPtr id_isShowingMRZ;
		public virtual unsafe bool IsShowingMRZ {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/method[@name='isShowingMRZ' and count(parameter)=0]"
			[Register ("isShowingMRZ", "()Z", "GetIsShowingMRZHandler")]
			get {
				if (id_isShowingMRZ == IntPtr.Zero)
					id_isShowingMRZ = JNIEnv.GetMethodID (class_ref, "isShowingMRZ", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isShowingMRZ);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowingMRZ", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_areUnparsedResultsAllowed;
#pragma warning disable 0169
		static Delegate GetAreUnparsedResultsAllowedHandler ()
		{
			if (cb_areUnparsedResultsAllowed == null)
				cb_areUnparsedResultsAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AreUnparsedResultsAllowed);
			return cb_areUnparsedResultsAllowed;
		}

		static bool n_AreUnparsedResultsAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreUnparsedResultsAllowed ();
		}
#pragma warning restore 0169

		static IntPtr id_areUnparsedResultsAllowed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/method[@name='areUnparsedResultsAllowed' and count(parameter)=0]"
		[Register ("areUnparsedResultsAllowed", "()Z", "GetAreUnparsedResultsAllowedHandler")]
		public virtual unsafe bool AreUnparsedResultsAllowed ()
		{
			if (id_areUnparsedResultsAllowed == IntPtr.Zero)
				id_areUnparsedResultsAllowed = JNIEnv.GetMethodID (class_ref, "areUnparsedResultsAllowed", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_areUnparsedResultsAllowed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "areUnparsedResultsAllowed", "()Z"));
			} finally {
			}
		}

		static Delegate cb_setAllowUnparsedResults_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowUnparsedResults_ZHandler ()
		{
			if (cb_setAllowUnparsedResults_Z == null)
				cb_setAllowUnparsedResults_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowUnparsedResults_Z);
			return cb_setAllowUnparsedResults_Z;
		}

		static void n_SetAllowUnparsedResults_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowUnparsedResults (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowUnparsedResults_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/method[@name='setAllowUnparsedResults' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowUnparsedResults", "(Z)V", "GetSetAllowUnparsedResults_ZHandler")]
		public virtual unsafe void SetAllowUnparsedResults (bool p0)
		{
			if (id_setAllowUnparsedResults_Z == IntPtr.Zero)
				id_setAllowUnparsedResults_Z = JNIEnv.GetMethodID (class_ref, "setAllowUnparsedResults", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAllowUnparsedResults_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllowUnparsedResults", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShowFullDocument_Z;
#pragma warning disable 0169
		static Delegate GetSetShowFullDocument_ZHandler ()
		{
			if (cb_setShowFullDocument_Z == null)
				cb_setShowFullDocument_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowFullDocument_Z);
			return cb_setShowFullDocument_Z;
		}

		static void n_SetShowFullDocument_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowFullDocument (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowFullDocument_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/method[@name='setShowFullDocument' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowFullDocument", "(Z)V", "GetSetShowFullDocument_ZHandler")]
		public virtual unsafe void SetShowFullDocument (bool p0)
		{
			if (id_setShowFullDocument_Z == IntPtr.Zero)
				id_setShowFullDocument_Z = JNIEnv.GetMethodID (class_ref, "setShowFullDocument", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowFullDocument_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowFullDocument", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShowMRZ_Z;
#pragma warning disable 0169
		static Delegate GetSetShowMRZ_ZHandler ()
		{
			if (cb_setShowMRZ_Z == null)
				cb_setShowMRZ_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowMRZ_Z);
			return cb_setShowMRZ_Z;
		}

		static void n_SetShowMRZ_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowMRZ (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowMRZ_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/method[@name='setShowMRZ' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowMRZ", "(Z)V", "GetSetShowMRZ_ZHandler")]
		public virtual unsafe void SetShowMRZ (bool p0)
		{
			if (id_setShowMRZ_Z == IntPtr.Zero)
				id_setShowMRZ_Z = JNIEnv.GetMethodID (class_ref, "setShowMRZ", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowMRZ_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowMRZ", "(Z)V"), __args);
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
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
