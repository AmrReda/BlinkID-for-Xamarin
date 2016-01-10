using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.util']/class[@name='CameraPermissionManager']"
	[global::Android.Runtime.Register ("com/microblink/util/CameraPermissionManager", DoNotGenerateAcw=true)]
	public partial class CameraPermissionManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/util/CameraPermissionManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraPermissionManager); }
		}

		protected CameraPermissionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.util']/class[@name='CameraPermissionManager']/constructor[@name='CameraPermissionManager' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe CameraPermissionManager (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CameraPermissionManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static Delegate cb_getAskPermissionOverlay;
#pragma warning disable 0169
		static Delegate GetGetAskPermissionOverlayHandler ()
		{
			if (cb_getAskPermissionOverlay == null)
				cb_getAskPermissionOverlay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAskPermissionOverlay);
			return cb_getAskPermissionOverlay;
		}

		static IntPtr n_GetAskPermissionOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Util.CameraPermissionManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.CameraPermissionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AskPermissionOverlay);
		}
#pragma warning restore 0169

		static IntPtr id_getAskPermissionOverlay;
		public virtual unsafe global::Android.Views.View AskPermissionOverlay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='CameraPermissionManager']/method[@name='getAskPermissionOverlay' and count(parameter)=0]"
			[Register ("getAskPermissionOverlay", "()Landroid/view/View;", "GetGetAskPermissionOverlayHandler")]
			get {
				if (id_getAskPermissionOverlay == IntPtr.Zero)
					id_getAskPermissionOverlay = JNIEnv.GetMethodID (class_ref, "getAskPermissionOverlay", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getAskPermissionOverlay), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAskPermissionOverlay", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasCameraPermission;
#pragma warning disable 0169
		static Delegate GetHasCameraPermissionHandler ()
		{
			if (cb_hasCameraPermission == null)
				cb_hasCameraPermission = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCameraPermission);
			return cb_hasCameraPermission;
		}

		static bool n_HasCameraPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Util.CameraPermissionManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.CameraPermissionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCameraPermission;
		}
#pragma warning restore 0169

		static IntPtr id_hasCameraPermission;
		public virtual unsafe bool HasCameraPermission {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='CameraPermissionManager']/method[@name='hasCameraPermission' and count(parameter)=0]"
			[Register ("hasCameraPermission", "()Z", "GetHasCameraPermissionHandler")]
			get {
				if (id_hasCameraPermission == IntPtr.Zero)
					id_hasCameraPermission = JNIEnv.GetMethodID (class_ref, "hasCameraPermission", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasCameraPermission);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCameraPermission", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_askForCameraPermission;
#pragma warning disable 0169
		static Delegate GetAskForCameraPermissionHandler ()
		{
			if (cb_askForCameraPermission == null)
				cb_askForCameraPermission = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AskForCameraPermission);
			return cb_askForCameraPermission;
		}

		static void n_AskForCameraPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Util.CameraPermissionManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.CameraPermissionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AskForCameraPermission ();
		}
#pragma warning restore 0169

		static IntPtr id_askForCameraPermission;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='CameraPermissionManager']/method[@name='askForCameraPermission' and count(parameter)=0]"
		[Register ("askForCameraPermission", "()V", "GetAskForCameraPermissionHandler")]
		public virtual unsafe void AskForCameraPermission ()
		{
			if (id_askForCameraPermission == IntPtr.Zero)
				id_askForCameraPermission = JNIEnv.GetMethodID (class_ref, "askForCameraPermission", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_askForCameraPermission);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "askForCameraPermission", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI);
			return cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Microblink.Util.CameraPermissionManager __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.CameraPermissionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnRequestPermissionsResult (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='CameraPermissionManager']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
		[Register ("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe void OnRequestPermissionsResult (int p0, string[] p1, int[] p2)
		{
			if (id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
