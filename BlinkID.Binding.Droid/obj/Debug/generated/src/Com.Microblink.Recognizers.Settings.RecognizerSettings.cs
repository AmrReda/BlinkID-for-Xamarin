using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/settings/RecognizerSettings", DoNotGenerateAcw=true)]
	public abstract partial class RecognizerSettings : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr mNativeContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/field[@name='mNativeContext']"
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
				return JNIEnv.FindClass ("com/microblink/recognizers/settings/RecognizerSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognizerSettings); }
		}

		protected RecognizerSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/constructor[@name='RecognizerSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RecognizerSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RecognizerSettings)) {
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

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Settings.RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Recognizers.Settings.RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		static IntPtr id_setEnabled_Z;
		public virtual unsafe bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
			set {
				if (id_setEnabled_Z == IntPtr.Zero)
					id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnabled", "(Z)V"), __args);
				} finally {
				}
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
			global::Com.Microblink.Recognizers.Settings.RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeContext;
		}
#pragma warning restore 0169

		static IntPtr id_getNativeContext;
		public virtual unsafe long NativeContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/method[@name='getNativeContext' and count(parameter)=0]"
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
			global::Com.Microblink.Recognizers.Settings.RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_requiresAutofocus;
#pragma warning disable 0169
		static Delegate GetRequiresAutofocusHandler ()
		{
			if (cb_requiresAutofocus == null)
				cb_requiresAutofocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RequiresAutofocus);
			return cb_requiresAutofocus;
		}

		static bool n_RequiresAutofocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Settings.RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiresAutofocus ();
		}
#pragma warning restore 0169

		static IntPtr id_requiresAutofocus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/method[@name='requiresAutofocus' and count(parameter)=0]"
		[Register ("requiresAutofocus", "()Z", "GetRequiresAutofocusHandler")]
		public virtual unsafe bool RequiresAutofocus ()
		{
			if (id_requiresAutofocus == IntPtr.Zero)
				id_requiresAutofocus = JNIEnv.GetMethodID (class_ref, "requiresAutofocus", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_requiresAutofocus);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requiresAutofocus", "()Z"));
			} finally {
			}
		}

		static Delegate cb_requiresLandscapeMode;
#pragma warning disable 0169
		static Delegate GetRequiresLandscapeModeHandler ()
		{
			if (cb_requiresLandscapeMode == null)
				cb_requiresLandscapeMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RequiresLandscapeMode);
			return cb_requiresLandscapeMode;
		}

		static bool n_RequiresLandscapeMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Settings.RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiresLandscapeMode ();
		}
#pragma warning restore 0169

		static IntPtr id_requiresLandscapeMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/method[@name='requiresLandscapeMode' and count(parameter)=0]"
		[Register ("requiresLandscapeMode", "()Z", "GetRequiresLandscapeModeHandler")]
		public virtual unsafe bool RequiresLandscapeMode ()
		{
			if (id_requiresLandscapeMode == IntPtr.Zero)
				id_requiresLandscapeMode = JNIEnv.GetMethodID (class_ref, "requiresLandscapeMode", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_requiresLandscapeMode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requiresLandscapeMode", "()Z"));
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
			global::Com.Microblink.Recognizers.Settings.RecognizerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Settings.RecognizerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/microblink/recognizers/settings/RecognizerSettings", DoNotGenerateAcw=true)]
	internal partial class RecognizerSettingsInvoker : RecognizerSettings {

		public RecognizerSettingsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognizerSettingsInvoker); }
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.settings']/class[@name='RecognizerSettings']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
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
