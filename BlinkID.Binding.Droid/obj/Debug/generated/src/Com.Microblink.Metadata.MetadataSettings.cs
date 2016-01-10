using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Metadata {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']"
	[global::Android.Runtime.Register ("com/microblink/metadata/MetadataSettings", DoNotGenerateAcw=true)]
	public partial class MetadataSettings : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']"
		[global::Android.Runtime.Register ("com/microblink/metadata/MetadataSettings$ImageMetadataSettings", DoNotGenerateAcw=true)]
		public partial class ImageMetadataSettings : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/metadata/MetadataSettings$ImageMetadataSettings", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageMetadataSettings); }
			}

			protected ImageMetadataSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/constructor[@name='MetadataSettings.ImageMetadataSettings' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ImageMetadataSettings ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ImageMetadataSettings)) {
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

			static Delegate cb_isCurrentVideoFrameEnabled;
#pragma warning disable 0169
			static Delegate GetIsCurrentVideoFrameEnabledHandler ()
			{
				if (cb_isCurrentVideoFrameEnabled == null)
					cb_isCurrentVideoFrameEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurrentVideoFrameEnabled);
				return cb_isCurrentVideoFrameEnabled;
			}

			static bool n_IsCurrentVideoFrameEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CurrentVideoFrameEnabled;
			}
#pragma warning restore 0169

			static Delegate cb_setCurrentVideoFrameEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetCurrentVideoFrameEnabled_ZHandler ()
			{
				if (cb_setCurrentVideoFrameEnabled_Z == null)
					cb_setCurrentVideoFrameEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCurrentVideoFrameEnabled_Z);
				return cb_setCurrentVideoFrameEnabled_Z;
			}

			static void n_SetCurrentVideoFrameEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.CurrentVideoFrameEnabled = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isCurrentVideoFrameEnabled;
			static IntPtr id_setCurrentVideoFrameEnabled_Z;
			public virtual unsafe bool CurrentVideoFrameEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='isCurrentVideoFrameEnabled' and count(parameter)=0]"
				[Register ("isCurrentVideoFrameEnabled", "()Z", "GetIsCurrentVideoFrameEnabledHandler")]
				get {
					if (id_isCurrentVideoFrameEnabled == IntPtr.Zero)
						id_isCurrentVideoFrameEnabled = JNIEnv.GetMethodID (class_ref, "isCurrentVideoFrameEnabled", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isCurrentVideoFrameEnabled);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCurrentVideoFrameEnabled", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='setCurrentVideoFrameEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setCurrentVideoFrameEnabled", "(Z)V", "GetSetCurrentVideoFrameEnabled_ZHandler")]
				set {
					if (id_setCurrentVideoFrameEnabled_Z == IntPtr.Zero)
						id_setCurrentVideoFrameEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCurrentVideoFrameEnabled", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setCurrentVideoFrameEnabled_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentVideoFrameEnabled", "(Z)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_isDetectionImageEnabled;
#pragma warning disable 0169
			static Delegate GetIsDetectionImageEnabledHandler ()
			{
				if (cb_isDetectionImageEnabled == null)
					cb_isDetectionImageEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDetectionImageEnabled);
				return cb_isDetectionImageEnabled;
			}

			static bool n_IsDetectionImageEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DetectionImageEnabled;
			}
#pragma warning restore 0169

			static Delegate cb_setDetectionImageEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetDetectionImageEnabled_ZHandler ()
			{
				if (cb_setDetectionImageEnabled_Z == null)
					cb_setDetectionImageEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDetectionImageEnabled_Z);
				return cb_setDetectionImageEnabled_Z;
			}

			static void n_SetDetectionImageEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DetectionImageEnabled = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isDetectionImageEnabled;
			static IntPtr id_setDetectionImageEnabled_Z;
			public virtual unsafe bool DetectionImageEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='isDetectionImageEnabled' and count(parameter)=0]"
				[Register ("isDetectionImageEnabled", "()Z", "GetIsDetectionImageEnabledHandler")]
				get {
					if (id_isDetectionImageEnabled == IntPtr.Zero)
						id_isDetectionImageEnabled = JNIEnv.GetMethodID (class_ref, "isDetectionImageEnabled", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isDetectionImageEnabled);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDetectionImageEnabled", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='setDetectionImageEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setDetectionImageEnabled", "(Z)V", "GetSetDetectionImageEnabled_ZHandler")]
				set {
					if (id_setDetectionImageEnabled_Z == IntPtr.Zero)
						id_setDetectionImageEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDetectionImageEnabled", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setDetectionImageEnabled_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDetectionImageEnabled", "(Z)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_isDewarpedImageEnabled;
#pragma warning disable 0169
			static Delegate GetIsDewarpedImageEnabledHandler ()
			{
				if (cb_isDewarpedImageEnabled == null)
					cb_isDewarpedImageEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDewarpedImageEnabled);
				return cb_isDewarpedImageEnabled;
			}

			static bool n_IsDewarpedImageEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DewarpedImageEnabled;
			}
#pragma warning restore 0169

			static Delegate cb_setDewarpedImageEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetDewarpedImageEnabled_ZHandler ()
			{
				if (cb_setDewarpedImageEnabled_Z == null)
					cb_setDewarpedImageEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDewarpedImageEnabled_Z);
				return cb_setDewarpedImageEnabled_Z;
			}

			static void n_SetDewarpedImageEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DewarpedImageEnabled = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isDewarpedImageEnabled;
			static IntPtr id_setDewarpedImageEnabled_Z;
			public virtual unsafe bool DewarpedImageEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='isDewarpedImageEnabled' and count(parameter)=0]"
				[Register ("isDewarpedImageEnabled", "()Z", "GetIsDewarpedImageEnabledHandler")]
				get {
					if (id_isDewarpedImageEnabled == IntPtr.Zero)
						id_isDewarpedImageEnabled = JNIEnv.GetMethodID (class_ref, "isDewarpedImageEnabled", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isDewarpedImageEnabled);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDewarpedImageEnabled", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='setDewarpedImageEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setDewarpedImageEnabled", "(Z)V", "GetSetDewarpedImageEnabled_ZHandler")]
				set {
					if (id_setDewarpedImageEnabled_Z == IntPtr.Zero)
						id_setDewarpedImageEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDewarpedImageEnabled", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setDewarpedImageEnabled_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDewarpedImageEnabled", "(Z)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_isOcrInputImageEnabled;
#pragma warning disable 0169
			static Delegate GetIsOcrInputImageEnabledHandler ()
			{
				if (cb_isOcrInputImageEnabled == null)
					cb_isOcrInputImageEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOcrInputImageEnabled);
				return cb_isOcrInputImageEnabled;
			}

			static bool n_IsOcrInputImageEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OcrInputImageEnabled;
			}
#pragma warning restore 0169

			static Delegate cb_setOcrInputImageEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetOcrInputImageEnabled_ZHandler ()
			{
				if (cb_setOcrInputImageEnabled_Z == null)
					cb_setOcrInputImageEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOcrInputImageEnabled_Z);
				return cb_setOcrInputImageEnabled_Z;
			}

			static void n_SetOcrInputImageEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OcrInputImageEnabled = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isOcrInputImageEnabled;
			static IntPtr id_setOcrInputImageEnabled_Z;
			public virtual unsafe bool OcrInputImageEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='isOcrInputImageEnabled' and count(parameter)=0]"
				[Register ("isOcrInputImageEnabled", "()Z", "GetIsOcrInputImageEnabledHandler")]
				get {
					if (id_isOcrInputImageEnabled == IntPtr.Zero)
						id_isOcrInputImageEnabled = JNIEnv.GetMethodID (class_ref, "isOcrInputImageEnabled", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isOcrInputImageEnabled);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOcrInputImageEnabled", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='setOcrInputImageEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setOcrInputImageEnabled", "(Z)V", "GetSetOcrInputImageEnabled_ZHandler")]
				set {
					if (id_setOcrInputImageEnabled_Z == IntPtr.Zero)
						id_setOcrInputImageEnabled_Z = JNIEnv.GetMethodID (class_ref, "setOcrInputImageEnabled", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setOcrInputImageEnabled_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOcrInputImageEnabled", "(Z)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_isSuccessfulScanFrameEnabled;
#pragma warning disable 0169
			static Delegate GetIsSuccessfulScanFrameEnabledHandler ()
			{
				if (cb_isSuccessfulScanFrameEnabled == null)
					cb_isSuccessfulScanFrameEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccessfulScanFrameEnabled);
				return cb_isSuccessfulScanFrameEnabled;
			}

			static bool n_IsSuccessfulScanFrameEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SuccessfulScanFrameEnabled;
			}
#pragma warning restore 0169

			static Delegate cb_setSuccessfulScanFrameEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetSuccessfulScanFrameEnabled_ZHandler ()
			{
				if (cb_setSuccessfulScanFrameEnabled_Z == null)
					cb_setSuccessfulScanFrameEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSuccessfulScanFrameEnabled_Z);
				return cb_setSuccessfulScanFrameEnabled_Z;
			}

			static void n_SetSuccessfulScanFrameEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SuccessfulScanFrameEnabled = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isSuccessfulScanFrameEnabled;
			static IntPtr id_setSuccessfulScanFrameEnabled_Z;
			public virtual unsafe bool SuccessfulScanFrameEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='isSuccessfulScanFrameEnabled' and count(parameter)=0]"
				[Register ("isSuccessfulScanFrameEnabled", "()Z", "GetIsSuccessfulScanFrameEnabledHandler")]
				get {
					if (id_isSuccessfulScanFrameEnabled == IntPtr.Zero)
						id_isSuccessfulScanFrameEnabled = JNIEnv.GetMethodID (class_ref, "isSuccessfulScanFrameEnabled", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isSuccessfulScanFrameEnabled);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccessfulScanFrameEnabled", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings.ImageMetadataSettings']/method[@name='setSuccessfulScanFrameEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setSuccessfulScanFrameEnabled", "(Z)V", "GetSetSuccessfulScanFrameEnabled_ZHandler")]
				set {
					if (id_setSuccessfulScanFrameEnabled_Z == IntPtr.Zero)
						id_setSuccessfulScanFrameEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSuccessfulScanFrameEnabled", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setSuccessfulScanFrameEnabled_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuccessfulScanFrameEnabled", "(Z)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/metadata/MetadataSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MetadataSettings); }
		}

		protected MetadataSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/constructor[@name='MetadataSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MetadataSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MetadataSettings)) {
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

		static Delegate cb_isDebugMetadataAllowed;
#pragma warning disable 0169
		static Delegate GetIsDebugMetadataAllowedHandler ()
		{
			if (cb_isDebugMetadataAllowed == null)
				cb_isDebugMetadataAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDebugMetadataAllowed);
			return cb_isDebugMetadataAllowed;
		}

		static bool n_IsDebugMetadataAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.MetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DebugMetadataAllowed;
		}
#pragma warning restore 0169

		static Delegate cb_setDebugMetadataAllowed_Z;
#pragma warning disable 0169
		static Delegate GetSetDebugMetadataAllowed_ZHandler ()
		{
			if (cb_setDebugMetadataAllowed_Z == null)
				cb_setDebugMetadataAllowed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebugMetadataAllowed_Z);
			return cb_setDebugMetadataAllowed_Z;
		}

		static void n_SetDebugMetadataAllowed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Metadata.MetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DebugMetadataAllowed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDebugMetadataAllowed;
		static IntPtr id_setDebugMetadataAllowed_Z;
		public virtual unsafe bool DebugMetadataAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/method[@name='isDebugMetadataAllowed' and count(parameter)=0]"
			[Register ("isDebugMetadataAllowed", "()Z", "GetIsDebugMetadataAllowedHandler")]
			get {
				if (id_isDebugMetadataAllowed == IntPtr.Zero)
					id_isDebugMetadataAllowed = JNIEnv.GetMethodID (class_ref, "isDebugMetadataAllowed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDebugMetadataAllowed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDebugMetadataAllowed", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/method[@name='setDebugMetadataAllowed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugMetadataAllowed", "(Z)V", "GetSetDebugMetadataAllowed_ZHandler")]
			set {
				if (id_setDebugMetadataAllowed_Z == IntPtr.Zero)
					id_setDebugMetadataAllowed_Z = JNIEnv.GetMethodID (class_ref, "setDebugMetadataAllowed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDebugMetadataAllowed_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebugMetadataAllowed", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDetectionMetadataAllowed;
#pragma warning disable 0169
		static Delegate GetIsDetectionMetadataAllowedHandler ()
		{
			if (cb_isDetectionMetadataAllowed == null)
				cb_isDetectionMetadataAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDetectionMetadataAllowed);
			return cb_isDetectionMetadataAllowed;
		}

		static bool n_IsDetectionMetadataAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.MetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DetectionMetadataAllowed;
		}
#pragma warning restore 0169

		static Delegate cb_setDetectionMetadataAllowed_Z;
#pragma warning disable 0169
		static Delegate GetSetDetectionMetadataAllowed_ZHandler ()
		{
			if (cb_setDetectionMetadataAllowed_Z == null)
				cb_setDetectionMetadataAllowed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDetectionMetadataAllowed_Z);
			return cb_setDetectionMetadataAllowed_Z;
		}

		static void n_SetDetectionMetadataAllowed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Metadata.MetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DetectionMetadataAllowed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDetectionMetadataAllowed;
		static IntPtr id_setDetectionMetadataAllowed_Z;
		public virtual unsafe bool DetectionMetadataAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/method[@name='isDetectionMetadataAllowed' and count(parameter)=0]"
			[Register ("isDetectionMetadataAllowed", "()Z", "GetIsDetectionMetadataAllowedHandler")]
			get {
				if (id_isDetectionMetadataAllowed == IntPtr.Zero)
					id_isDetectionMetadataAllowed = JNIEnv.GetMethodID (class_ref, "isDetectionMetadataAllowed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDetectionMetadataAllowed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDetectionMetadataAllowed", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/method[@name='setDetectionMetadataAllowed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDetectionMetadataAllowed", "(Z)V", "GetSetDetectionMetadataAllowed_ZHandler")]
			set {
				if (id_setDetectionMetadataAllowed_Z == IntPtr.Zero)
					id_setDetectionMetadataAllowed_Z = JNIEnv.GetMethodID (class_ref, "setDetectionMetadataAllowed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDetectionMetadataAllowed_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDetectionMetadataAllowed", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOcrMetadataAllowed;
#pragma warning disable 0169
		static Delegate GetIsOcrMetadataAllowedHandler ()
		{
			if (cb_isOcrMetadataAllowed == null)
				cb_isOcrMetadataAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOcrMetadataAllowed);
			return cb_isOcrMetadataAllowed;
		}

		static bool n_IsOcrMetadataAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.MetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OcrMetadataAllowed;
		}
#pragma warning restore 0169

		static Delegate cb_setOcrMetadataAllowed_Z;
#pragma warning disable 0169
		static Delegate GetSetOcrMetadataAllowed_ZHandler ()
		{
			if (cb_setOcrMetadataAllowed_Z == null)
				cb_setOcrMetadataAllowed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOcrMetadataAllowed_Z);
			return cb_setOcrMetadataAllowed_Z;
		}

		static void n_SetOcrMetadataAllowed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Metadata.MetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OcrMetadataAllowed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isOcrMetadataAllowed;
		static IntPtr id_setOcrMetadataAllowed_Z;
		public virtual unsafe bool OcrMetadataAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/method[@name='isOcrMetadataAllowed' and count(parameter)=0]"
			[Register ("isOcrMetadataAllowed", "()Z", "GetIsOcrMetadataAllowedHandler")]
			get {
				if (id_isOcrMetadataAllowed == IntPtr.Zero)
					id_isOcrMetadataAllowed = JNIEnv.GetMethodID (class_ref, "isOcrMetadataAllowed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isOcrMetadataAllowed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOcrMetadataAllowed", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/method[@name='setOcrMetadataAllowed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOcrMetadataAllowed", "(Z)V", "GetSetOcrMetadataAllowed_ZHandler")]
			set {
				if (id_setOcrMetadataAllowed_Z == IntPtr.Zero)
					id_setOcrMetadataAllowed_Z = JNIEnv.GetMethodID (class_ref, "setOcrMetadataAllowed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOcrMetadataAllowed_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOcrMetadataAllowed", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageMetadataSettings;
#pragma warning disable 0169
		static Delegate GetGetImageMetadataSettingsHandler ()
		{
			if (cb_getImageMetadataSettings == null)
				cb_getImageMetadataSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageMetadataSettings);
			return cb_getImageMetadataSettings;
		}

		static IntPtr n_GetImageMetadataSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.MetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetImageMetadataSettings ());
		}
#pragma warning restore 0169

		static IntPtr id_getImageMetadataSettings;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/method[@name='getImageMetadataSettings' and count(parameter)=0]"
		[Register ("getImageMetadataSettings", "()Lcom/microblink/metadata/MetadataSettings$ImageMetadataSettings;", "GetGetImageMetadataSettingsHandler")]
		public virtual unsafe global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings GetImageMetadataSettings ()
		{
			if (id_getImageMetadataSettings == IntPtr.Zero)
				id_getImageMetadataSettings = JNIEnv.GetMethodID (class_ref, "getImageMetadataSettings", "()Lcom/microblink/metadata/MetadataSettings$ImageMetadataSettings;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (JNIEnv.CallObjectMethod  (Handle, id_getImageMetadataSettings), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageMetadataSettings", "()Lcom/microblink/metadata/MetadataSettings$ImageMetadataSettings;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_;
#pragma warning disable 0169
		static Delegate GetSetImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_Handler ()
		{
			if (cb_setImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_ == null)
				cb_setImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_);
			return cb_setImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_;
		}

		static void n_SetImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Metadata.MetadataSettings __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImageMetadataSettings (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='MetadataSettings']/method[@name='setImageMetadataSettings' and count(parameter)=1 and parameter[1][@type='com.microblink.metadata.MetadataSettings.ImageMetadataSettings']]"
		[Register ("setImageMetadataSettings", "(Lcom/microblink/metadata/MetadataSettings$ImageMetadataSettings;)V", "GetSetImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_Handler")]
		public virtual unsafe void SetImageMetadataSettings (global::Com.Microblink.Metadata.MetadataSettings.ImageMetadataSettings p0)
		{
			if (id_setImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_ == IntPtr.Zero)
				id_setImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_ = JNIEnv.GetMethodID (class_ref, "setImageMetadataSettings", "(Lcom/microblink/metadata/MetadataSettings$ImageMetadataSettings;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setImageMetadataSettings_Lcom_microblink_metadata_MetadataSettings_ImageMetadataSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageMetadataSettings", "(Lcom/microblink/metadata/MetadataSettings$ImageMetadataSettings;)V"), __args);
			} finally {
			}
		}

	}
}
