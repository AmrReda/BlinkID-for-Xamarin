using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognition.Callback {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']"
	[global::Android.Runtime.Register ("com/microblink/recognition/callback/RecognitionProcessCallback", DoNotGenerateAcw=true)]
	public sealed partial class RecognitionProcessCallback : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognition/callback/RecognitionProcessCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognitionProcessCallback); }
		}

		internal RecognitionProcessCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getNativeContext;
		public unsafe long NativeContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']/method[@name='getNativeContext' and count(parameter)=0]"
			[Register ("getNativeContext", "()J", "GetGetNativeContextHandler")]
			get {
				if (id_getNativeContext == IntPtr.Zero)
					id_getNativeContext = JNIEnv.GetMethodID (class_ref, "getNativeContext", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getNativeContext);
				} finally {
				}
			}
		}

		static IntPtr id_isPaused;
		static IntPtr id_setPaused_Z;
		public unsafe bool Paused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isPaused);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']/method[@name='setPaused' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPaused", "(Z)V", "GetSetPaused_ZHandler")]
			set {
				if (id_setPaused_Z == IntPtr.Zero)
					id_setPaused_Z = JNIEnv.GetMethodID (class_ref, "setPaused", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setPaused_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_dispose);
			} finally {
			}
		}

		static IntPtr id_onDetectedForm_arrayFIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']/method[@name='onDetectedForm' and count(parameter)=5 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onDetectedForm", "([FIIII)V", "")]
		public unsafe void OnDetectedForm (float[] p0, int p1, int p2, int p3, int p4)
		{
			if (id_onDetectedForm_arrayFIIII == IntPtr.Zero)
				id_onDetectedForm_arrayFIIII = JNIEnv.GetMethodID (class_ref, "onDetectedForm", "([FIIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod  (Handle, id_onDetectedForm_arrayFIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_onDetectionFailed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']/method[@name='onDetectionFailed' and count(parameter)=0]"
		[Register ("onDetectionFailed", "()V", "")]
		public unsafe void OnDetectionFailed ()
		{
			if (id_onDetectionFailed == IntPtr.Zero)
				id_onDetectionFailed = JNIEnv.GetMethodID (class_ref, "onDetectionFailed", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onDetectionFailed);
			} finally {
			}
		}

		static IntPtr id_onMetadataAvailable_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']/method[@name='onMetadataAvailable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onMetadataAvailable", "(ILjava/lang/Object;)V", "")]
		public unsafe void OnMetadataAvailable (int p0, global::Java.Lang.Object p1)
		{
			if (id_onMetadataAvailable_ILjava_lang_Object_ == IntPtr.Zero)
				id_onMetadataAvailable_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onMetadataAvailable", "(ILjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_onMetadataAvailable_ILjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_setScanningRegion_Lcom_microblink_geometry_Rectangle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognition.callback']/class[@name='RecognitionProcessCallback']/method[@name='setScanningRegion' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Rectangle']]"
		[Register ("setScanningRegion", "(Lcom/microblink/geometry/Rectangle;)V", "")]
		public unsafe void SetScanningRegion (global::Com.Microblink.Geometry.Rectangle p0)
		{
			if (id_setScanningRegion_Lcom_microblink_geometry_Rectangle_ == IntPtr.Zero)
				id_setScanningRegion_Lcom_microblink_geometry_Rectangle_ = JNIEnv.GetMethodID (class_ref, "setScanningRegion", "(Lcom/microblink/geometry/Rectangle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setScanningRegion_Lcom_microblink_geometry_Rectangle_, __args);
			} finally {
			}
		}

	}
}
