using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Metadata {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.metadata']/class[@name='ImageMetadata']"
	[global::Android.Runtime.Register ("com/microblink/metadata/ImageMetadata", DoNotGenerateAcw=true)]
	public partial class ImageMetadata : global::Com.Microblink.Metadata.Metadata {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/metadata/ImageMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageMetadata); }
		}

		protected ImageMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_image_Image_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.metadata']/class[@name='ImageMetadata']/constructor[@name='ImageMetadata' and count(parameter)=1 and parameter[1][@type='com.microblink.image.Image']]"
		[Register (".ctor", "(Lcom/microblink/image/Image;)V", "")]
		public unsafe ImageMetadata (global::Com.Microblink.Image.Image p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageMetadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/image/Image;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/image/Image;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_image_Image_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_image_Image_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/image/Image;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_image_Image_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_image_Image_, __args);
			} finally {
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Metadata.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		public virtual unsafe global::Com.Microblink.Image.Image Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/class[@name='ImageMetadata']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/microblink/image/Image;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/microblink/image/Image;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Lcom/microblink/image/Image;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
