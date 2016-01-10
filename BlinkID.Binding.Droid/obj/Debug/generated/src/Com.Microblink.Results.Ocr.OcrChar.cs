using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Results.Ocr {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']"
	[global::Android.Runtime.Register ("com/microblink/results/ocr/OcrChar", DoNotGenerateAcw=true)]
	public partial class OcrChar : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/results/ocr/OcrChar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrChar); }
		}

		protected OcrChar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JLcom_microblink_results_ocr_OcrLine_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/constructor[@name='OcrChar' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.microblink.results.ocr.OcrLine']]"
		[Register (".ctor", "(JLcom/microblink/results/ocr/OcrLine;)V", "")]
		public unsafe OcrChar (long p0, global::Com.Microblink.Results.Ocr.OcrLine p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (OcrChar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JLcom/microblink/results/ocr/OcrLine;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JLcom/microblink/results/ocr/OcrLine;)V", __args);
					return;
				}

				if (id_ctor_JLcom_microblink_results_ocr_OcrLine_ == IntPtr.Zero)
					id_ctor_JLcom_microblink_results_ocr_OcrLine_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JLcom/microblink/results/ocr/OcrLine;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLcom_microblink_results_ocr_OcrLine_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JLcom_microblink_results_ocr_OcrLine_, __args);
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
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Font);
		}
#pragma warning restore 0169

		static IntPtr id_getFont;
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrFont Font {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='getFont' and count(parameter)=0]"
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

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isBold;
#pragma warning disable 0169
		static Delegate GetIsBoldHandler ()
		{
			if (cb_isBold == null)
				cb_isBold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBold);
			return cb_isBold;
		}

		static bool n_IsBold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBold;
		}
#pragma warning restore 0169

		static IntPtr id_isBold;
		public virtual unsafe bool IsBold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='isBold' and count(parameter)=0]"
			[Register ("isBold", "()Z", "GetIsBoldHandler")]
			get {
				if (id_isBold == IntPtr.Zero)
					id_isBold = JNIEnv.GetMethodID (class_ref, "isBold", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isBold);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBold", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isItalic;
#pragma warning disable 0169
		static Delegate GetIsItalicHandler ()
		{
			if (cb_isItalic == null)
				cb_isItalic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsItalic);
			return cb_isItalic;
		}

		static bool n_IsItalic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsItalic;
		}
#pragma warning restore 0169

		static IntPtr id_isItalic;
		public virtual unsafe bool IsItalic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='isItalic' and count(parameter)=0]"
			[Register ("isItalic", "()Z", "GetIsItalicHandler")]
			get {
				if (id_isItalic == IntPtr.Zero)
					id_isItalic = JNIEnv.GetMethodID (class_ref, "isItalic", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isItalic);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isItalic", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUncertain;
#pragma warning disable 0169
		static Delegate GetIsUncertainHandler ()
		{
			if (cb_isUncertain == null)
				cb_isUncertain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUncertain);
			return cb_isUncertain;
		}

		static bool n_IsUncertain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUncertain;
		}
#pragma warning restore 0169

		static IntPtr id_isUncertain;
		public virtual unsafe bool IsUncertain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='isUncertain' and count(parameter)=0]"
			[Register ("isUncertain", "()Z", "GetIsUncertainHandler")]
			get {
				if (id_isUncertain == IntPtr.Zero)
					id_isUncertain = JNIEnv.GetMethodID (class_ref, "isUncertain", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isUncertain);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUncertain", "()Z"));
				} finally {
				}
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
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		public virtual unsafe global::Com.Microblink.Geometry.Rectangle Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='getPosition' and count(parameter)=0]"
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

		static Delegate cb_getQuality;
#pragma warning disable 0169
		static Delegate GetGetQualityHandler ()
		{
			if (cb_getQuality == null)
				cb_getQuality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQuality);
			return cb_getQuality;
		}

		static int n_GetQuality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Quality;
		}
#pragma warning restore 0169

		static IntPtr id_getQuality;
		public virtual unsafe int Quality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='getQuality' and count(parameter)=0]"
			[Register ("getQuality", "()I", "GetGetQualityHandler")]
			get {
				if (id_getQuality == IntPtr.Zero)
					id_getQuality = JNIEnv.GetMethodID (class_ref, "getQuality", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getQuality);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuality", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_GetValue);
			return cb_getValue;
		}

		static char n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe char Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()C", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()C");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallCharMethod  (Handle, id_getValue);
					else
						return JNIEnv.CallNonvirtualCharMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()C"));
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
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getRecognitionVariants;
#pragma warning disable 0169
		static Delegate GetGetRecognitionVariantsHandler ()
		{
			if (cb_getRecognitionVariants == null)
				cb_getRecognitionVariants = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecognitionVariants);
			return cb_getRecognitionVariants;
		}

		static IntPtr n_GetRecognitionVariants (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRecognitionVariants ());
		}
#pragma warning restore 0169

		static IntPtr id_getRecognitionVariants;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='getRecognitionVariants' and count(parameter)=0]"
		[Register ("getRecognitionVariants", "()[Lcom/microblink/results/ocr/OcrChar;", "GetGetRecognitionVariantsHandler")]
		public virtual unsafe global::Com.Microblink.Results.Ocr.OcrChar[] GetRecognitionVariants ()
		{
			if (id_getRecognitionVariants == IntPtr.Zero)
				id_getRecognitionVariants = JNIEnv.GetMethodID (class_ref, "getRecognitionVariants", "()[Lcom/microblink/results/ocr/OcrChar;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.Microblink.Results.Ocr.OcrChar[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRecognitionVariants), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Results.Ocr.OcrChar));
				else
					return (global::Com.Microblink.Results.Ocr.OcrChar[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecognitionVariants", "()[Lcom/microblink/results/ocr/OcrChar;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Results.Ocr.OcrChar));
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
			global::Com.Microblink.Results.Ocr.OcrChar __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrChar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.results.ocr']/class[@name='OcrChar']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
