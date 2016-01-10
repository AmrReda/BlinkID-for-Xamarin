using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Settings {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']"
	[global::Android.Runtime.Register ("com/microblink/settings/NativeLibraryInfo", DoNotGenerateAcw=true)]
	public partial class NativeLibraryInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/settings/NativeLibraryInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeLibraryInfo); }
		}

		protected NativeLibraryInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/constructor[@name='NativeLibraryInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NativeLibraryInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NativeLibraryInfo)) {
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

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/constructor[@name='NativeLibraryInfo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe NativeLibraryInfo (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (NativeLibraryInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_getErrorList;
#pragma warning disable 0169
		static Delegate GetGetErrorListHandler ()
		{
			if (cb_getErrorList == null)
				cb_getErrorList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorList);
			return cb_getErrorList;
		}

		static IntPtr n_GetErrorList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Settings.NativeLibraryInfo __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Settings.NativeLibraryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorList);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorList;
		public virtual unsafe string ErrorList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/method[@name='getErrorList' and count(parameter)=0]"
			[Register ("getErrorList", "()Ljava/lang/String;", "GetGetErrorListHandler")]
			get {
				if (id_getErrorList == IntPtr.Zero)
					id_getErrorList = JNIEnv.GetMethodID (class_ref, "getErrorList", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorList), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorList", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isLibrarySuccessfulyInitialized;
		public unsafe bool IsLibrarySuccessfulyInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/method[@name='isLibrarySuccessfulyInitialized' and count(parameter)=0]"
			[Register ("isLibrarySuccessfulyInitialized", "()Z", "GetIsLibrarySuccessfulyInitializedHandler")]
			get {
				if (id_isLibrarySuccessfulyInitialized == IntPtr.Zero)
					id_isLibrarySuccessfulyInitialized = JNIEnv.GetMethodID (class_ref, "isLibrarySuccessfulyInitialized", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isLibrarySuccessfulyInitialized);
				} finally {
				}
			}
		}

		static IntPtr id_isProtectionEnabled;
		public static unsafe bool IsProtectionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/method[@name='isProtectionEnabled' and count(parameter)=0]"
			[Register ("isProtectionEnabled", "()Z", "GetIsProtectionEnabledHandler")]
			get {
				if (id_isProtectionEnabled == IntPtr.Zero)
					id_isProtectionEnabled = JNIEnv.GetStaticMethodID (class_ref, "isProtectionEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isProtectionEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_isWeakProtectionEnabled;
		public static unsafe bool IsWeakProtectionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/method[@name='isWeakProtectionEnabled' and count(parameter)=0]"
			[Register ("isWeakProtectionEnabled", "()Z", "GetIsWeakProtectionEnabledHandler")]
			get {
				if (id_isWeakProtectionEnabled == IntPtr.Zero)
					id_isWeakProtectionEnabled = JNIEnv.GetStaticMethodID (class_ref, "isWeakProtectionEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWeakProtectionEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxImageSize;
		public unsafe int MaxImageSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/method[@name='getMaxImageSize' and count(parameter)=0]"
			[Register ("getMaxImageSize", "()I", "GetGetMaxImageSizeHandler")]
			get {
				if (id_getMaxImageSize == IntPtr.Zero)
					id_getMaxImageSize = JNIEnv.GetMethodID (class_ref, "getMaxImageSize", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getMaxImageSize);
				} finally {
				}
			}
		}

		static IntPtr id_getNativeBuildVersion;
		public static unsafe string NativeBuildVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/method[@name='getNativeBuildVersion' and count(parameter)=0]"
			[Register ("getNativeBuildVersion", "()Ljava/lang/String;", "GetGetNativeBuildVersionHandler")]
			get {
				if (id_getNativeBuildVersion == IntPtr.Zero)
					id_getNativeBuildVersion = JNIEnv.GetStaticMethodID (class_ref, "getNativeBuildVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNativeBuildVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Microblink.Settings.NativeLibraryInfo __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Settings.NativeLibraryInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Log ();
		}
#pragma warning restore 0169

		static IntPtr id_log;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/method[@name='log' and count(parameter)=0]"
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

		static IntPtr id_obtainProductInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.settings']/class[@name='NativeLibraryInfo']/method[@name='obtainProductInfo' and count(parameter)=0]"
		[Register ("obtainProductInfo", "()Lcom/microblink/product/ProductInfo;", "")]
		public static unsafe global::Com.Microblink.Product.ProductInfo ObtainProductInfo ()
		{
			if (id_obtainProductInfo == IntPtr.Zero)
				id_obtainProductInfo = JNIEnv.GetStaticMethodID (class_ref, "obtainProductInfo", "()Lcom/microblink/product/ProductInfo;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Product.ProductInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtainProductInfo), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
