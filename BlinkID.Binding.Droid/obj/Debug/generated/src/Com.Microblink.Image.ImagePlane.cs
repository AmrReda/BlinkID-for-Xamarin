using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.image']/class[@name='ImagePlane']"
	[global::Android.Runtime.Register ("com/microblink/image/ImagePlane", DoNotGenerateAcw=true)]
	public partial class ImagePlane : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/image/ImagePlane", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImagePlane); }
		}

		protected ImagePlane (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.image']/class[@name='ImagePlane']/constructor[@name='ImagePlane' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;II)V", "")]
		public unsafe ImagePlane (global::Java.Nio.ByteBuffer p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ImagePlane)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/nio/ByteBuffer;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_II == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_II, __args);
			} finally {
			}
		}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.ImagePlane __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImagePlane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Buffer);
		}
#pragma warning restore 0169

		static IntPtr id_getBuffer;
		public virtual unsafe global::Java.Nio.ByteBuffer Buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='ImagePlane']/method[@name='getBuffer' and count(parameter)=0]"
			[Register ("getBuffer", "()Ljava/nio/ByteBuffer;", "GetGetBufferHandler")]
			get {
				if (id_getBuffer == IntPtr.Zero)
					id_getBuffer = JNIEnv.GetMethodID (class_ref, "getBuffer", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod  (Handle, id_getBuffer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuffer", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPixelStride;
#pragma warning disable 0169
		static Delegate GetGetPixelStrideHandler ()
		{
			if (cb_getPixelStride == null)
				cb_getPixelStride = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPixelStride);
			return cb_getPixelStride;
		}

		static int n_GetPixelStride (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.ImagePlane __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImagePlane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelStride;
		}
#pragma warning restore 0169

		static IntPtr id_getPixelStride;
		public virtual unsafe int PixelStride {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='ImagePlane']/method[@name='getPixelStride' and count(parameter)=0]"
			[Register ("getPixelStride", "()I", "GetGetPixelStrideHandler")]
			get {
				if (id_getPixelStride == IntPtr.Zero)
					id_getPixelStride = JNIEnv.GetMethodID (class_ref, "getPixelStride", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPixelStride);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixelStride", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRowStride;
#pragma warning disable 0169
		static Delegate GetGetRowStrideHandler ()
		{
			if (cb_getRowStride == null)
				cb_getRowStride = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRowStride);
			return cb_getRowStride;
		}

		static int n_GetRowStride (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.ImagePlane __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImagePlane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RowStride;
		}
#pragma warning restore 0169

		static IntPtr id_getRowStride;
		public virtual unsafe int RowStride {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='ImagePlane']/method[@name='getRowStride' and count(parameter)=0]"
			[Register ("getRowStride", "()I", "GetGetRowStrideHandler")]
			get {
				if (id_getRowStride == IntPtr.Zero)
					id_getRowStride = JNIEnv.GetMethodID (class_ref, "getRowStride", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRowStride);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRowStride", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.ImagePlane __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImagePlane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='ImagePlane']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/microblink/image/ImagePlane;", "GetCloneHandler")]
		public virtual unsafe global::Com.Microblink.Image.ImagePlane Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/microblink/image/ImagePlane;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImagePlane> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImagePlane> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/microblink/image/ImagePlane;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
