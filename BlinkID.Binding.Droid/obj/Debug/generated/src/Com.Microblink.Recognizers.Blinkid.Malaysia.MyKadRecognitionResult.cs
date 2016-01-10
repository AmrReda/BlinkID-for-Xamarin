using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkid.Malaysia {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkid/malaysia/MyKadRecognitionResult", DoNotGenerateAcw=true)]
	public partial class MyKadRecognitionResult : global::Com.Microblink.Recognizers.BaseRecognitionResult {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkid/malaysia/MyKadRecognitionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MyKadRecognitionResult); }
		}

		protected MyKadRecognitionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']/constructor[@name='MyKadRecognitionResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JZZ)V", "")]
		public unsafe MyKadRecognitionResult (long p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MyKadRecognitionResult)) {
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

		static Delegate cb_getNRICNumber;
#pragma warning disable 0169
		static Delegate GetGetNRICNumberHandler ()
		{
			if (cb_getNRICNumber == null)
				cb_getNRICNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNRICNumber);
			return cb_getNRICNumber;
		}

		static IntPtr n_GetNRICNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NRICNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getNRICNumber;
		public virtual unsafe string NRICNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']/method[@name='getNRICNumber' and count(parameter)=0]"
			[Register ("getNRICNumber", "()Ljava/lang/String;", "GetGetNRICNumberHandler")]
			get {
				if (id_getNRICNumber == IntPtr.Zero)
					id_getNRICNumber = JNIEnv.GetMethodID (class_ref, "getNRICNumber", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNRICNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNRICNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOwnerAddress;
#pragma warning disable 0169
		static Delegate GetGetOwnerAddressHandler ()
		{
			if (cb_getOwnerAddress == null)
				cb_getOwnerAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwnerAddress);
			return cb_getOwnerAddress;
		}

		static IntPtr n_GetOwnerAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OwnerAddress);
		}
#pragma warning restore 0169

		static IntPtr id_getOwnerAddress;
		public virtual unsafe string OwnerAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']/method[@name='getOwnerAddress' and count(parameter)=0]"
			[Register ("getOwnerAddress", "()Ljava/lang/String;", "GetGetOwnerAddressHandler")]
			get {
				if (id_getOwnerAddress == IntPtr.Zero)
					id_getOwnerAddress = JNIEnv.GetMethodID (class_ref, "getOwnerAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOwnerAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwnerAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOwnerBirthDate;
#pragma warning disable 0169
		static Delegate GetGetOwnerBirthDateHandler ()
		{
			if (cb_getOwnerBirthDate == null)
				cb_getOwnerBirthDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwnerBirthDate);
			return cb_getOwnerBirthDate;
		}

		static IntPtr n_GetOwnerBirthDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OwnerBirthDate);
		}
#pragma warning restore 0169

		static IntPtr id_getOwnerBirthDate;
		public virtual unsafe string OwnerBirthDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']/method[@name='getOwnerBirthDate' and count(parameter)=0]"
			[Register ("getOwnerBirthDate", "()Ljava/lang/String;", "GetGetOwnerBirthDateHandler")]
			get {
				if (id_getOwnerBirthDate == IntPtr.Zero)
					id_getOwnerBirthDate = JNIEnv.GetMethodID (class_ref, "getOwnerBirthDate", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOwnerBirthDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwnerBirthDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOwnerFullName;
#pragma warning disable 0169
		static Delegate GetGetOwnerFullNameHandler ()
		{
			if (cb_getOwnerFullName == null)
				cb_getOwnerFullName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwnerFullName);
			return cb_getOwnerFullName;
		}

		static IntPtr n_GetOwnerFullName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OwnerFullName);
		}
#pragma warning restore 0169

		static IntPtr id_getOwnerFullName;
		public virtual unsafe string OwnerFullName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']/method[@name='getOwnerFullName' and count(parameter)=0]"
			[Register ("getOwnerFullName", "()Ljava/lang/String;", "GetGetOwnerFullNameHandler")]
			get {
				if (id_getOwnerFullName == IntPtr.Zero)
					id_getOwnerFullName = JNIEnv.GetMethodID (class_ref, "getOwnerFullName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOwnerFullName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwnerFullName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOwnerReligion;
#pragma warning disable 0169
		static Delegate GetGetOwnerReligionHandler ()
		{
			if (cb_getOwnerReligion == null)
				cb_getOwnerReligion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwnerReligion);
			return cb_getOwnerReligion;
		}

		static IntPtr n_GetOwnerReligion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OwnerReligion);
		}
#pragma warning restore 0169

		static IntPtr id_getOwnerReligion;
		public virtual unsafe string OwnerReligion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']/method[@name='getOwnerReligion' and count(parameter)=0]"
			[Register ("getOwnerReligion", "()Ljava/lang/String;", "GetGetOwnerReligionHandler")]
			get {
				if (id_getOwnerReligion == IntPtr.Zero)
					id_getOwnerReligion = JNIEnv.GetMethodID (class_ref, "getOwnerReligion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOwnerReligion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwnerReligion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOwnerSex;
#pragma warning disable 0169
		static Delegate GetGetOwnerSexHandler ()
		{
			if (cb_getOwnerSex == null)
				cb_getOwnerSex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwnerSex);
			return cb_getOwnerSex;
		}

		static IntPtr n_GetOwnerSex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Malaysia.MyKadRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OwnerSex);
		}
#pragma warning restore 0169

		static IntPtr id_getOwnerSex;
		public virtual unsafe string OwnerSex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.malaysia']/class[@name='MyKadRecognitionResult']/method[@name='getOwnerSex' and count(parameter)=0]"
			[Register ("getOwnerSex", "()Ljava/lang/String;", "GetGetOwnerSexHandler")]
			get {
				if (id_getOwnerSex == IntPtr.Zero)
					id_getOwnerSex = JNIEnv.GetMethodID (class_ref, "getOwnerSex", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOwnerSex), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwnerSex", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
