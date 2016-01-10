using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Image {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.image']/interface[@name='ImageListener']"
	[Register ("com/microblink/image/ImageListener", "", "Com.Microblink.Image.IImageListenerInvoker")]
	public partial interface IImageListener : global::Android.OS.IParcelable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/interface[@name='ImageListener']/method[@name='onImageAvailable' and count(parameter)=1 and parameter[1][@type='com.microblink.image.Image']]"
		[Register ("onImageAvailable", "(Lcom/microblink/image/Image;)V", "GetOnImageAvailable_Lcom_microblink_image_Image_Handler:Com.Microblink.Image.IImageListenerInvoker, BlinkID.Binding.Droid")]
		void OnImageAvailable (global::Com.Microblink.Image.Image p0);

	}

	[global::Android.Runtime.Register ("com/microblink/image/ImageListener", DoNotGenerateAcw=true)]
	internal class IImageListenerInvoker : global::Java.Lang.Object, IImageListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/image/ImageListener");
		IntPtr class_ref;

		public static IImageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.image.ImageListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IImageListenerInvoker); }
		}

		static Delegate cb_onImageAvailable_Lcom_microblink_image_Image_;
#pragma warning disable 0169
		static Delegate GetOnImageAvailable_Lcom_microblink_image_Image_Handler ()
		{
			if (cb_onImageAvailable_Lcom_microblink_image_Image_ == null)
				cb_onImageAvailable_Lcom_microblink_image_Image_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnImageAvailable_Lcom_microblink_image_Image_);
			return cb_onImageAvailable_Lcom_microblink_image_Image_;
		}

		static void n_OnImageAvailable_Lcom_microblink_image_Image_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Image.IImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.IImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Image.Image p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnImageAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_onImageAvailable_Lcom_microblink_image_Image_;
		public unsafe void OnImageAvailable (global::Com.Microblink.Image.Image p0)
		{
			if (id_onImageAvailable_Lcom_microblink_image_Image_ == IntPtr.Zero)
				id_onImageAvailable_Lcom_microblink_image_Image_ = JNIEnv.GetMethodID (class_ref, "onImageAvailable", "(Lcom/microblink/image/Image;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onImageAvailable_Lcom_microblink_image_Image_, __args);
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
			global::Com.Microblink.Image.IImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.IImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		IntPtr id_describeContents;
		public unsafe global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod (Handle, id_describeContents);
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
			global::Com.Microblink.Image.IImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.IImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (dest);
			__args [1] = new JValue ((int) flags);
			JNIEnv.CallVoidMethod (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
		}

	}

}
