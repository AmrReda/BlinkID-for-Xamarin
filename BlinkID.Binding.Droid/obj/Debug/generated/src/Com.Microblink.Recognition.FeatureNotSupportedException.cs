using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognition']/class[@name='FeatureNotSupportedException']"
	[global::Android.Runtime.Register ("com/microblink/recognition/FeatureNotSupportedException", DoNotGenerateAcw=true)]
	public partial class FeatureNotSupportedException : global::Java.Lang.Exception {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognition/FeatureNotSupportedException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FeatureNotSupportedException); }
		}

		protected FeatureNotSupportedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_view_NotSupportedReason_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognition']/class[@name='FeatureNotSupportedException']/constructor[@name='FeatureNotSupportedException' and count(parameter)=1 and parameter[1][@type='com.microblink.view.NotSupportedReason']]"
		[Register (".ctor", "(Lcom/microblink/view/NotSupportedReason;)V", "")]
		public unsafe FeatureNotSupportedException (global::Com.Microblink.View.NotSupportedReason p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FeatureNotSupportedException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/view/NotSupportedReason;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/view/NotSupportedReason;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_view_NotSupportedReason_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_view_NotSupportedReason_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/NotSupportedReason;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_NotSupportedReason_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_NotSupportedReason_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_microblink_view_NotSupportedReason_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognition']/class[@name='FeatureNotSupportedException']/constructor[@name='FeatureNotSupportedException' and count(parameter)=2 and parameter[1][@type='com.microblink.view.NotSupportedReason'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lcom/microblink/view/NotSupportedReason;Ljava/lang/Throwable;)V", "")]
		public unsafe FeatureNotSupportedException (global::Com.Microblink.View.NotSupportedReason p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FeatureNotSupportedException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/view/NotSupportedReason;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/view/NotSupportedReason;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_view_NotSupportedReason_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_view_NotSupportedReason_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/NotSupportedReason;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_NotSupportedReason_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_NotSupportedReason_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static Delegate cb_getReason;
#pragma warning disable 0169
		static Delegate GetGetReasonHandler ()
		{
			if (cb_getReason == null)
				cb_getReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReason);
			return cb_getReason;
		}

		static IntPtr n_GetReason (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognition.FeatureNotSupportedException __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognition.FeatureNotSupportedException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reason);
		}
#pragma warning restore 0169

		static IntPtr id_getReason;
		public virtual unsafe global::Com.Microblink.View.NotSupportedReason Reason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition']/class[@name='FeatureNotSupportedException']/method[@name='getReason' and count(parameter)=0]"
			[Register ("getReason", "()Lcom/microblink/view/NotSupportedReason;", "GetGetReasonHandler")]
			get {
				if (id_getReason == IntPtr.Zero)
					id_getReason = JNIEnv.GetMethodID (class_ref, "getReason", "()Lcom/microblink/view/NotSupportedReason;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (JNIEnv.CallObjectMethod  (Handle, id_getReason), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.NotSupportedReason> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReason", "()Lcom/microblink/view/NotSupportedReason;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
