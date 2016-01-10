using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkocr.Parser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser']/class[@name='OcrParserSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkocr/parser/OcrParserSettings", DoNotGenerateAcw=true)]
	public abstract partial class OcrParserSettings : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr mNativeContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser']/class[@name='OcrParserSettings']/field[@name='mNativeContext']"
		[Register ("mNativeContext")]
		public long MNativeContext {
			get {
				if (mNativeContext_jfieldId == IntPtr.Zero)
					mNativeContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mNativeContext", "J");
				return JNIEnv.GetLongField (Handle, mNativeContext_jfieldId);
			}
			set {
				if (mNativeContext_jfieldId == IntPtr.Zero)
					mNativeContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mNativeContext", "J");
				try {
					JNIEnv.SetField (Handle, mNativeContext_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkocr/parser/OcrParserSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrParserSettings); }
		}

		protected OcrParserSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser']/class[@name='OcrParserSettings']/constructor[@name='OcrParserSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OcrParserSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OcrParserSettings)) {
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

		static Delegate cb_getNativeContext;
#pragma warning disable 0169
		static Delegate GetGetNativeContextHandler ()
		{
			if (cb_getNativeContext == null)
				cb_getNativeContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeContext);
			return cb_getNativeContext;
		}

		static long n_GetNativeContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeContext;
		}
#pragma warning restore 0169

		static IntPtr id_getNativeContext;
		public virtual unsafe long NativeContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser']/class[@name='OcrParserSettings']/method[@name='getNativeContext' and count(parameter)=0]"
			[Register ("getNativeContext", "()J", "GetGetNativeContextHandler")]
			get {
				if (id_getNativeContext == IntPtr.Zero)
					id_getNativeContext = JNIEnv.GetMethodID (class_ref, "getNativeContext", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getNativeContext);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeContext", "()J"));
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
			global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser']/class[@name='OcrParserSettings']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkocr.Parser.OcrParserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser']/class[@name='OcrParserSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkocr/parser/OcrParserSettings", DoNotGenerateAcw=true)]
	internal partial class OcrParserSettingsInvoker : OcrParserSettings {

		public OcrParserSettingsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrParserSettingsInvoker); }
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkocr.parser']/class[@name='OcrParserSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}

}
