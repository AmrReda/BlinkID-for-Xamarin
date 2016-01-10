using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/BaseRecognitionResult", DoNotGenerateAcw=true)]
	public abstract partial class BaseRecognitionResult : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/BaseRecognitionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseRecognitionResult); }
		}

		protected BaseRecognitionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/constructor[@name='BaseRecognitionResult' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe BaseRecognitionResult (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseRecognitionResult)) {
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

		static IntPtr id_ctor_Landroid_os_Bundle_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/constructor[@name='BaseRecognitionResult' and count(parameter)=3 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/os/Bundle;ZZ)V", "")]
		public unsafe BaseRecognitionResult (global::Android.OS.Bundle p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BaseRecognitionResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Bundle;ZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Bundle;ZZ)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Bundle_ZZ == IntPtr.Zero)
					id_ctor_Landroid_os_Bundle_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;ZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_ZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Bundle_ZZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/constructor[@name='BaseRecognitionResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JZZ)V", "")]
		public unsafe BaseRecognitionResult (long p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BaseRecognitionResult)) {
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

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.BaseRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.BaseRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_getResultHolder;
		public unsafe global::Com.Microblink.Recognizers.IResultHolder ResultHolder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='getResultHolder' and count(parameter)=0]"
			[Register ("getResultHolder", "()Lcom/microblink/recognizers/IResultHolder;", "GetGetResultHolderHandler")]
			get {
				if (id_getResultHolder == IntPtr.Zero)
					id_getResultHolder = JNIEnv.GetMethodID (class_ref, "getResultHolder", "()Lcom/microblink/recognizers/IResultHolder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (JNIEnv.CallObjectMethod  (Handle, id_getResultHolder), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.BaseRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Recognizers.BaseRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getIntElement_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetIntElement_Ljava_lang_String_Handler ()
		{
			if (cb_getIntElement_Ljava_lang_String_ == null)
				cb_getIntElement_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetIntElement_Ljava_lang_String_);
			return cb_getIntElement_Ljava_lang_String_;
		}

		static int n_GetIntElement_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.BaseRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIntElement (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIntElement_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='getIntElement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIntElement", "(Ljava/lang/String;)I", "GetGetIntElement_Ljava_lang_String_Handler")]
		public virtual unsafe int GetIntElement (string p0)
		{
			if (id_getIntElement_Ljava_lang_String_ == IntPtr.Zero)
				id_getIntElement_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getIntElement", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getIntElement_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntElement", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getStringElement_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringElement_Ljava_lang_String_Handler ()
		{
			if (cb_getStringElement_Ljava_lang_String_ == null)
				cb_getStringElement_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStringElement_Ljava_lang_String_);
			return cb_getStringElement_Ljava_lang_String_;
		}

		static IntPtr n_GetStringElement_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.BaseRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringElement (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStringElement_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='getStringElement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringElement", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetStringElement_Ljava_lang_String_Handler")]
		public virtual unsafe string GetStringElement (string p0)
		{
			if (id_getStringElement_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringElement_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getStringElement", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStringElement_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringElement", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_log;
#pragma warning disable 0169
		static Delegate GetLogHandler ()
		{
			if (cb_log == null)
				cb_log = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Log);
			return cb_log;
		}

		static void n_Log (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.BaseRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Log ();
		}
#pragma warning restore 0169

		static IntPtr id_log;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='log' and count(parameter)=0]"
		[Register ("log", "()V", "GetLogHandler")]
		public virtual unsafe void Log ()
		{
			if (id_log == IntPtr.Zero)
				id_log = JNIEnv.GetMethodID (class_ref, "log", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_log);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "log", "()V"));
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
			global::Com.Microblink.Recognizers.BaseRecognitionResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/class[@name='BaseRecognitionResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

	[global::Android.Runtime.Register ("com/microblink/recognizers/BaseRecognitionResult", DoNotGenerateAcw=true)]
	internal partial class BaseRecognitionResultInvoker : BaseRecognitionResult {

		public BaseRecognitionResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseRecognitionResultInvoker); }
		}

	}

}
