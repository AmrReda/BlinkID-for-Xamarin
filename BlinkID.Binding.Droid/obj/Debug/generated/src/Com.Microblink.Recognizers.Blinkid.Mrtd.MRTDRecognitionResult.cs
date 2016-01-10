using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkid.Mrtd {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkid/mrtd/MRTDRecognitionResult", DoNotGenerateAcw=true)]
	public partial class MRTDRecognitionResult : global::Com.Microblink.Recognizers.BaseRecognitionResult {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkid/mrtd/MRTDRecognitionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRTDRecognitionResult); }
		}

		protected MRTDRecognitionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/constructor[@name='MRTDRecognitionResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JZZ)V", "")]
		public unsafe MRTDRecognitionResult (long p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MRTDRecognitionResult)) {
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
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateOfBirth);
		}
#pragma warning restore 0169

		static IntPtr id_getDateOfBirth;
		public virtual unsafe string DateOfBirth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getDateOfBirth' and count(parameter)=0]"
			[Register ("getDateOfBirth", "()Ljava/lang/String;", "GetGetDateOfBirthHandler")]
			get {
				if (id_getDateOfBirth == IntPtr.Zero)
					id_getDateOfBirth = JNIEnv.GetMethodID (class_ref, "getDateOfBirth", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDateOfBirth), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateOfBirth", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDateOfExpiry;
#pragma warning disable 0169
		static Delegate GetGetDateOfExpiryHandler ()
		{
			if (cb_getDateOfExpiry == null)
				cb_getDateOfExpiry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateOfExpiry);
			return cb_getDateOfExpiry;
		}

		static IntPtr n_GetDateOfExpiry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateOfExpiry);
		}
#pragma warning restore 0169

		static IntPtr id_getDateOfExpiry;
		public virtual unsafe string DateOfExpiry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getDateOfExpiry' and count(parameter)=0]"
			[Register ("getDateOfExpiry", "()Ljava/lang/String;", "GetGetDateOfExpiryHandler")]
			get {
				if (id_getDateOfExpiry == IntPtr.Zero)
					id_getDateOfExpiry = JNIEnv.GetMethodID (class_ref, "getDateOfExpiry", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDateOfExpiry), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateOfExpiry", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDocumentCode;
#pragma warning disable 0169
		static Delegate GetGetDocumentCodeHandler ()
		{
			if (cb_getDocumentCode == null)
				cb_getDocumentCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDocumentCode);
			return cb_getDocumentCode;
		}

		static IntPtr n_GetDocumentCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DocumentCode);
		}
#pragma warning restore 0169

		static IntPtr id_getDocumentCode;
		public virtual unsafe string DocumentCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getDocumentCode' and count(parameter)=0]"
			[Register ("getDocumentCode", "()Ljava/lang/String;", "GetGetDocumentCodeHandler")]
			get {
				if (id_getDocumentCode == IntPtr.Zero)
					id_getDocumentCode = JNIEnv.GetMethodID (class_ref, "getDocumentCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDocumentCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocumentCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDocumentNumber;
#pragma warning disable 0169
		static Delegate GetGetDocumentNumberHandler ()
		{
			if (cb_getDocumentNumber == null)
				cb_getDocumentNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDocumentNumber);
			return cb_getDocumentNumber;
		}

		static IntPtr n_GetDocumentNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DocumentNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getDocumentNumber;
		public virtual unsafe string DocumentNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getDocumentNumber' and count(parameter)=0]"
			[Register ("getDocumentNumber", "()Ljava/lang/String;", "GetGetDocumentNumberHandler")]
			get {
				if (id_getDocumentNumber == IntPtr.Zero)
					id_getDocumentNumber = JNIEnv.GetMethodID (class_ref, "getDocumentNumber", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDocumentNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocumentNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isMRZParsed;
#pragma warning disable 0169
		static Delegate GetIsMRZParsedHandler ()
		{
			if (cb_isMRZParsed == null)
				cb_isMRZParsed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMRZParsed);
			return cb_isMRZParsed;
		}

		static bool n_IsMRZParsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMRZParsed;
		}
#pragma warning restore 0169

		static IntPtr id_isMRZParsed;
		public virtual unsafe bool IsMRZParsed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='isMRZParsed' and count(parameter)=0]"
			[Register ("isMRZParsed", "()Z", "GetIsMRZParsedHandler")]
			get {
				if (id_isMRZParsed == IntPtr.Zero)
					id_isMRZParsed = JNIEnv.GetMethodID (class_ref, "isMRZParsed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isMRZParsed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMRZParsed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getIssuer;
#pragma warning disable 0169
		static Delegate GetGetIssuerHandler ()
		{
			if (cb_getIssuer == null)
				cb_getIssuer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIssuer);
			return cb_getIssuer;
		}

		static IntPtr n_GetIssuer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Issuer);
		}
#pragma warning restore 0169

		static IntPtr id_getIssuer;
		public virtual unsafe string Issuer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getIssuer' and count(parameter)=0]"
			[Register ("getIssuer", "()Ljava/lang/String;", "GetGetIssuerHandler")]
			get {
				if (id_getIssuer == IntPtr.Zero)
					id_getIssuer = JNIEnv.GetMethodID (class_ref, "getIssuer", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIssuer), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIssuer", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMRZText;
#pragma warning disable 0169
		static Delegate GetGetMRZTextHandler ()
		{
			if (cb_getMRZText == null)
				cb_getMRZText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMRZText);
			return cb_getMRZText;
		}

		static IntPtr n_GetMRZText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MRZText);
		}
#pragma warning restore 0169

		static IntPtr id_getMRZText;
		public virtual unsafe string MRZText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getMRZText' and count(parameter)=0]"
			[Register ("getMRZText", "()Ljava/lang/String;", "GetGetMRZTextHandler")]
			get {
				if (id_getMRZText == IntPtr.Zero)
					id_getMRZText = JNIEnv.GetMethodID (class_ref, "getMRZText", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMRZText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMRZText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNationality;
#pragma warning disable 0169
		static Delegate GetGetNationalityHandler ()
		{
			if (cb_getNationality == null)
				cb_getNationality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNationality);
			return cb_getNationality;
		}

		static IntPtr n_GetNationality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nationality);
		}
#pragma warning restore 0169

		static IntPtr id_getNationality;
		public virtual unsafe string Nationality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getNationality' and count(parameter)=0]"
			[Register ("getNationality", "()Ljava/lang/String;", "GetGetNationalityHandler")]
			get {
				if (id_getNationality == IntPtr.Zero)
					id_getNationality = JNIEnv.GetMethodID (class_ref, "getNationality", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNationality), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNationality", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOcrResult;
#pragma warning disable 0169
		static Delegate GetGetOcrResultHandler ()
		{
			if (cb_getOcrResult == null)
				cb_getOcrResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOcrResult);
			return cb_getOcrResult;
		}

		static IntPtr n_GetOcrResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OcrResult);
		}
#pragma warning restore 0169

		static IntPtr id_getOcrResult;
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrResult OcrResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getOcrResult' and count(parameter)=0]"
			[Register ("getOcrResult", "()Lcom/microblink/results/ocr/OcrResult;", "GetGetOcrResultHandler")]
			get {
				if (id_getOcrResult == IntPtr.Zero)
					id_getOcrResult = JNIEnv.GetMethodID (class_ref, "getOcrResult", "()Lcom/microblink/results/ocr/OcrResult;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (JNIEnv.CallObjectMethod  (Handle, id_getOcrResult), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOcrResult", "()Lcom/microblink/results/ocr/OcrResult;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOpt1;
#pragma warning disable 0169
		static Delegate GetGetOpt1Handler ()
		{
			if (cb_getOpt1 == null)
				cb_getOpt1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpt1);
			return cb_getOpt1;
		}

		static IntPtr n_GetOpt1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Opt1);
		}
#pragma warning restore 0169

		static IntPtr id_getOpt1;
		public virtual unsafe string Opt1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getOpt1' and count(parameter)=0]"
			[Register ("getOpt1", "()Ljava/lang/String;", "GetGetOpt1Handler")]
			get {
				if (id_getOpt1 == IntPtr.Zero)
					id_getOpt1 = JNIEnv.GetMethodID (class_ref, "getOpt1", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOpt1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpt1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOpt2;
#pragma warning disable 0169
		static Delegate GetGetOpt2Handler ()
		{
			if (cb_getOpt2 == null)
				cb_getOpt2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpt2);
			return cb_getOpt2;
		}

		static IntPtr n_GetOpt2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Opt2);
		}
#pragma warning restore 0169

		static IntPtr id_getOpt2;
		public virtual unsafe string Opt2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getOpt2' and count(parameter)=0]"
			[Register ("getOpt2", "()Ljava/lang/String;", "GetGetOpt2Handler")]
			get {
				if (id_getOpt2 == IntPtr.Zero)
					id_getOpt2 = JNIEnv.GetMethodID (class_ref, "getOpt2", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOpt2), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpt2", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrimaryId;
#pragma warning disable 0169
		static Delegate GetGetPrimaryIdHandler ()
		{
			if (cb_getPrimaryId == null)
				cb_getPrimaryId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrimaryId);
			return cb_getPrimaryId;
		}

		static IntPtr n_GetPrimaryId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrimaryId);
		}
#pragma warning restore 0169

		static IntPtr id_getPrimaryId;
		public virtual unsafe string PrimaryId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getPrimaryId' and count(parameter)=0]"
			[Register ("getPrimaryId", "()Ljava/lang/String;", "GetGetPrimaryIdHandler")]
			get {
				if (id_getPrimaryId == IntPtr.Zero)
					id_getPrimaryId = JNIEnv.GetMethodID (class_ref, "getPrimaryId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrimaryId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrimaryId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSecondaryId;
#pragma warning disable 0169
		static Delegate GetGetSecondaryIdHandler ()
		{
			if (cb_getSecondaryId == null)
				cb_getSecondaryId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecondaryId);
			return cb_getSecondaryId;
		}

		static IntPtr n_GetSecondaryId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecondaryId);
		}
#pragma warning restore 0169

		static IntPtr id_getSecondaryId;
		public virtual unsafe string SecondaryId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getSecondaryId' and count(parameter)=0]"
			[Register ("getSecondaryId", "()Ljava/lang/String;", "GetGetSecondaryIdHandler")]
			get {
				if (id_getSecondaryId == IntPtr.Zero)
					id_getSecondaryId = JNIEnv.GetMethodID (class_ref, "getSecondaryId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSecondaryId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecondaryId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSex;
#pragma warning disable 0169
		static Delegate GetGetSexHandler ()
		{
			if (cb_getSex == null)
				cb_getSex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSex);
			return cb_getSex;
		}

		static IntPtr n_GetSex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkid.Mrtd.MRTDRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sex);
		}
#pragma warning restore 0169

		static IntPtr id_getSex;
		public virtual unsafe string Sex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkid.mrtd']/class[@name='MRTDRecognitionResult']/method[@name='getSex' and count(parameter)=0]"
			[Register ("getSex", "()Ljava/lang/String;", "GetGetSexHandler")]
			get {
				if (id_getSex == IntPtr.Zero)
					id_getSex = JNIEnv.GetMethodID (class_ref, "getSex", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSex), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSex", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
