using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkid.Ukdl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkid/ukdl/UKDLRecognitionResult", DoNotGenerateAcw=true)]
	public partial class UKDLRecognitionResult : global::Com.Microblink.Recognizers.BaseRecognitionResult {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkid/ukdl/UKDLRecognitionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UKDLRecognitionResult); }
		}

		protected UKDLRecognitionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/constructor[@name='UKDLRecognitionResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JZZ)V", "")]
		public unsafe UKDLRecognitionResult (long p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UKDLRecognitionResult)) {
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

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDateOfBirth;
#pragma warning disable 0169
		static Delegate GetGetDateOfBirthHandler ()
		{
			if (cb_getDateOfBirth == null)
				cb_getDateOfBirth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateOfBirth);
			return cb_getDateOfBirth;
		}

		static IntPtr n_GetDateOfBirth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DateOfBirth);
		}
#pragma warning restore 0169

		static IntPtr id_getDateOfBirth;
		public virtual unsafe global::Java.Util.Date DateOfBirth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/method[@name='getDateOfBirth' and count(parameter)=0]"
			[Register ("getDateOfBirth", "()Ljava/util/Date;", "GetGetDateOfBirthHandler")]
			get {
				if (id_getDateOfBirth == IntPtr.Zero)
					id_getDateOfBirth = JNIEnv.GetMethodID (class_ref, "getDateOfBirth", "()Ljava/util/Date;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getDateOfBirth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateOfBirth", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDocumentExpiryDate;
#pragma warning disable 0169
		static Delegate GetGetDocumentExpiryDateHandler ()
		{
			if (cb_getDocumentExpiryDate == null)
				cb_getDocumentExpiryDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDocumentExpiryDate);
			return cb_getDocumentExpiryDate;
		}

		static IntPtr n_GetDocumentExpiryDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DocumentExpiryDate);
		}
#pragma warning restore 0169

		static IntPtr id_getDocumentExpiryDate;
		public virtual unsafe global::Java.Util.Date DocumentExpiryDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/method[@name='getDocumentExpiryDate' and count(parameter)=0]"
			[Register ("getDocumentExpiryDate", "()Ljava/util/Date;", "GetGetDocumentExpiryDateHandler")]
			get {
				if (id_getDocumentExpiryDate == IntPtr.Zero)
					id_getDocumentExpiryDate = JNIEnv.GetMethodID (class_ref, "getDocumentExpiryDate", "()Ljava/util/Date;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getDocumentExpiryDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocumentExpiryDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDocumentIssueDate;
#pragma warning disable 0169
		static Delegate GetGetDocumentIssueDateHandler ()
		{
			if (cb_getDocumentIssueDate == null)
				cb_getDocumentIssueDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDocumentIssueDate);
			return cb_getDocumentIssueDate;
		}

		static IntPtr n_GetDocumentIssueDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DocumentIssueDate);
		}
#pragma warning restore 0169

		static IntPtr id_getDocumentIssueDate;
		public virtual unsafe global::Java.Util.Date DocumentIssueDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/method[@name='getDocumentIssueDate' and count(parameter)=0]"
			[Register ("getDocumentIssueDate", "()Ljava/util/Date;", "GetGetDocumentIssueDateHandler")]
			get {
				if (id_getDocumentIssueDate == IntPtr.Zero)
					id_getDocumentIssueDate = JNIEnv.GetMethodID (class_ref, "getDocumentIssueDate", "()Ljava/util/Date;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getDocumentIssueDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocumentIssueDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDriverNumber;
#pragma warning disable 0169
		static Delegate GetGetDriverNumberHandler ()
		{
			if (cb_getDriverNumber == null)
				cb_getDriverNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDriverNumber);
			return cb_getDriverNumber;
		}

		static IntPtr n_GetDriverNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DriverNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getDriverNumber;
		public virtual unsafe string DriverNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/method[@name='getDriverNumber' and count(parameter)=0]"
			[Register ("getDriverNumber", "()Ljava/lang/String;", "GetGetDriverNumberHandler")]
			get {
				if (id_getDriverNumber == IntPtr.Zero)
					id_getDriverNumber = JNIEnv.GetMethodID (class_ref, "getDriverNumber", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDriverNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDriverNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFirstName;
#pragma warning disable 0169
		static Delegate GetGetFirstNameHandler ()
		{
			if (cb_getFirstName == null)
				cb_getFirstName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstName);
			return cb_getFirstName;
		}

		static IntPtr n_GetFirstName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		static IntPtr id_getFirstName;
		public virtual unsafe string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler")]
			get {
				if (id_getFirstName == IntPtr.Zero)
					id_getFirstName = JNIEnv.GetMethodID (class_ref, "getFirstName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFirstName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastName;
#pragma warning disable 0169
		static Delegate GetGetLastNameHandler ()
		{
			if (cb_getLastName == null)
				cb_getLastName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastName);
			return cb_getLastName;
		}

		static IntPtr n_GetLastName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastName);
		}
#pragma warning restore 0169

		static IntPtr id_getLastName;
		public virtual unsafe string LastName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/method[@name='getLastName' and count(parameter)=0]"
			[Register ("getLastName", "()Ljava/lang/String;", "GetGetLastNameHandler")]
			get {
				if (id_getLastName == IntPtr.Zero)
					id_getLastName = JNIEnv.GetMethodID (class_ref, "getLastName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLastName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlaceOfBirth;
#pragma warning disable 0169
		static Delegate GetGetPlaceOfBirthHandler ()
		{
			if (cb_getPlaceOfBirth == null)
				cb_getPlaceOfBirth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaceOfBirth);
			return cb_getPlaceOfBirth;
		}

		static IntPtr n_GetPlaceOfBirth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Ukdl.UKDLRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlaceOfBirth);
		}
#pragma warning restore 0169

		static IntPtr id_getPlaceOfBirth;
		public virtual unsafe string PlaceOfBirth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.ukdl']/class[@name='UKDLRecognitionResult']/method[@name='getPlaceOfBirth' and count(parameter)=0]"
			[Register ("getPlaceOfBirth", "()Ljava/lang/String;", "GetGetPlaceOfBirthHandler")]
			get {
				if (id_getPlaceOfBirth == IntPtr.Zero)
					id_getPlaceOfBirth = JNIEnv.GetMethodID (class_ref, "getPlaceOfBirth", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPlaceOfBirth), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlaceOfBirth", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
