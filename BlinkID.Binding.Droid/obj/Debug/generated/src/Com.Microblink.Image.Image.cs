using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']"
	[global::Android.Runtime.Register ("com/microblink/image/Image", DoNotGenerateAcw=true)]
	public partial class Image : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/image/Image", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Image); }
		}

		protected Image (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILcom_microblink_image_ImageType_Lcom_microblink_image_ImageFormat_Ljava_lang_String_arrayLcom_microblink_image_ImagePlane_Landroid_graphics_Rect_Lcom_microblink_hardware_orientation_Orientation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/constructor[@name='Image' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.microblink.image.ImageType'] and parameter[4][@type='com.microblink.image.ImageFormat'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.microblink.image.ImagePlane[]'] and parameter[7][@type='android.graphics.Rect'] and parameter[8][@type='com.microblink.hardware.orientation.Orientation']]"
		[Register (".ctor", "(IILcom/microblink/image/ImageType;Lcom/microblink/image/ImageFormat;Ljava/lang/String;[Lcom/microblink/image/ImagePlane;Landroid/graphics/Rect;Lcom/microblink/hardware/orientation/Orientation;)V", "")]
		public unsafe Image (int p0, int p1, global::Com.Microblink.Image.ImageType p2, global::Com.Microblink.Image.ImageFormat p3, string p4, global::Com.Microblink.Image.ImagePlane[] p5, global::Android.Graphics.Rect p6, global::Com.Microblink.Hardware.Orientation.Orientation p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (GetType () != typeof (Image)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILcom/microblink/image/ImageType;Lcom/microblink/image/ImageFormat;Ljava/lang/String;[Lcom/microblink/image/ImagePlane;Landroid/graphics/Rect;Lcom/microblink/hardware/orientation/Orientation;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILcom/microblink/image/ImageType;Lcom/microblink/image/ImageFormat;Ljava/lang/String;[Lcom/microblink/image/ImagePlane;Landroid/graphics/Rect;Lcom/microblink/hardware/orientation/Orientation;)V", __args);
					return;
				}

				if (id_ctor_IILcom_microblink_image_ImageType_Lcom_microblink_image_ImageFormat_Ljava_lang_String_arrayLcom_microblink_image_ImagePlane_Landroid_graphics_Rect_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
					id_ctor_IILcom_microblink_image_ImageType_Lcom_microblink_image_ImageFormat_Ljava_lang_String_arrayLcom_microblink_image_ImagePlane_Landroid_graphics_Rect_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILcom/microblink/image/ImageType;Lcom/microblink/image/ImageFormat;Ljava/lang/String;[Lcom/microblink/image/ImagePlane;Landroid/graphics/Rect;Lcom/microblink/hardware/orientation/Orientation;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILcom_microblink_image_ImageType_Lcom_microblink_image_ImageFormat_Ljava_lang_String_arrayLcom_microblink_image_ImagePlane_Landroid_graphics_Rect_Lcom_microblink_hardware_orientation_Orientation_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILcom_microblink_image_ImageType_Lcom_microblink_image_ImageFormat_Ljava_lang_String_arrayLcom_microblink_image_ImagePlane_Landroid_graphics_Rect_Lcom_microblink_hardware_orientation_Orientation_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static IntPtr id_ctor_IIIILjava_lang_String_IIIIILjava_nio_ByteBuffer_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/constructor[@name='Image' and count(parameter)=13 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='java.nio.ByteBuffer'] and parameter[12][@type='int'] and parameter[13][@type='int']]"
		[Register (".ctor", "(IIIILjava/lang/String;IIIIILjava/nio/ByteBuffer;II)V", "")]
		public unsafe Image (int p0, int p1, int p2, int p3, string p4, int p5, int p6, int p7, int p8, int p9, global::Java.Nio.ByteBuffer p10, int p11, int p12)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [13];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);
				__args [12] = new JValue (p12);
				if (GetType () != typeof (Image)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIILjava/lang/String;IIIIILjava/nio/ByteBuffer;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIIILjava/lang/String;IIIIILjava/nio/ByteBuffer;II)V", __args);
					return;
				}

				if (id_ctor_IIIILjava_lang_String_IIIIILjava_nio_ByteBuffer_II == IntPtr.Zero)
					id_ctor_IIIILjava_lang_String_IIIIILjava_nio_ByteBuffer_II = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIILjava/lang/String;IIIIILjava/nio/ByteBuffer;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIILjava_lang_String_IIIIILjava_nio_ByteBuffer_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIILjava_lang_String_IIIIILjava_nio_ByteBuffer_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageFormat;
#pragma warning disable 0169
		static Delegate GetGetImageFormatHandler ()
		{
			if (cb_getImageFormat == null)
				cb_getImageFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageFormat);
			return cb_getImageFormat;
		}

		static IntPtr n_GetImageFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageFormat);
		}
#pragma warning restore 0169

		static IntPtr id_getImageFormat;
		public virtual unsafe global::Com.Microblink.Image.ImageFormat ImageFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='getImageFormat' and count(parameter)=0]"
			[Register ("getImageFormat", "()Lcom/microblink/image/ImageFormat;", "GetGetImageFormatHandler")]
			get {
				if (id_getImageFormat == IntPtr.Zero)
					id_getImageFormat = JNIEnv.GetMethodID (class_ref, "getImageFormat", "()Lcom/microblink/image/ImageFormat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageFormat> (JNIEnv.CallObjectMethod  (Handle, id_getImageFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageFormat> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageFormat", "()Lcom/microblink/image/ImageFormat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageName;
#pragma warning disable 0169
		static Delegate GetGetImageNameHandler ()
		{
			if (cb_getImageName == null)
				cb_getImageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageName);
			return cb_getImageName;
		}

		static IntPtr n_GetImageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageName);
		}
#pragma warning restore 0169

		static IntPtr id_getImageName;
		public virtual unsafe string ImageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='getImageName' and count(parameter)=0]"
			[Register ("getImageName", "()Ljava/lang/String;", "GetGetImageNameHandler")]
			get {
				if (id_getImageName == IntPtr.Zero)
					id_getImageName = JNIEnv.GetMethodID (class_ref, "getImageName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImageName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageOrientation;
#pragma warning disable 0169
		static Delegate GetGetImageOrientationHandler ()
		{
			if (cb_getImageOrientation == null)
				cb_getImageOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageOrientation);
			return cb_getImageOrientation;
		}

		static IntPtr n_GetImageOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageOrientation);
		}
#pragma warning restore 0169

		static Delegate cb_setImageOrientation_Lcom_microblink_hardware_orientation_Orientation_;
#pragma warning disable 0169
		static Delegate GetSetImageOrientation_Lcom_microblink_hardware_orientation_Orientation_Handler ()
		{
			if (cb_setImageOrientation_Lcom_microblink_hardware_orientation_Orientation_ == null)
				cb_setImageOrientation_Lcom_microblink_hardware_orientation_Orientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageOrientation_Lcom_microblink_hardware_orientation_Orientation_);
			return cb_setImageOrientation_Lcom_microblink_hardware_orientation_Orientation_;
		}

		static void n_SetImageOrientation_Lcom_microblink_hardware_orientation_Orientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Orientation.Orientation p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageOrientation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageOrientation;
		static IntPtr id_setImageOrientation_Lcom_microblink_hardware_orientation_Orientation_;
		public virtual unsafe global::Com.Microblink.Hardware.Orientation.Orientation ImageOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='getImageOrientation' and count(parameter)=0]"
			[Register ("getImageOrientation", "()Lcom/microblink/hardware/orientation/Orientation;", "GetGetImageOrientationHandler")]
			get {
				if (id_getImageOrientation == IntPtr.Zero)
					id_getImageOrientation = JNIEnv.GetMethodID (class_ref, "getImageOrientation", "()Lcom/microblink/hardware/orientation/Orientation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_getImageOrientation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageOrientation", "()Lcom/microblink/hardware/orientation/Orientation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='setImageOrientation' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
			[Register ("setImageOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V", "GetSetImageOrientation_Lcom_microblink_hardware_orientation_Orientation_Handler")]
			set {
				if (id_setImageOrientation_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
					id_setImageOrientation_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "setImageOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setImageOrientation_Lcom_microblink_hardware_orientation_Orientation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageType;
#pragma warning disable 0169
		static Delegate GetGetImageTypeHandler ()
		{
			if (cb_getImageType == null)
				cb_getImageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageType);
			return cb_getImageType;
		}

		static IntPtr n_GetImageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageType);
		}
#pragma warning restore 0169

		static IntPtr id_getImageType;
		public virtual unsafe global::Com.Microblink.Image.ImageType ImageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='getImageType' and count(parameter)=0]"
			[Register ("getImageType", "()Lcom/microblink/image/ImageType;", "GetGetImageTypeHandler")]
			get {
				if (id_getImageType == IntPtr.Zero)
					id_getImageType = JNIEnv.GetMethodID (class_ref, "getImageType", "()Lcom/microblink/image/ImageType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (JNIEnv.CallObjectMethod  (Handle, id_getImageType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.ImageType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageType", "()Lcom/microblink/image/ImageType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDisposed;
#pragma warning disable 0169
		static Delegate GetIsDisposedHandler ()
		{
			if (cb_isDisposed == null)
				cb_isDisposed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDisposed);
			return cb_isDisposed;
		}

		static bool n_IsDisposed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisposed;
		}
#pragma warning restore 0169

		static IntPtr id_isDisposed;
		public virtual unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='isDisposed' and count(parameter)=0]"
			[Register ("isDisposed", "()Z", "GetIsDisposedHandler")]
			get {
				if (id_isDisposed == IntPtr.Zero)
					id_isDisposed = JNIEnv.GetMethodID (class_ref, "isDisposed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDisposed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDisposed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getROI;
#pragma warning disable 0169
		static Delegate GetGetROIHandler ()
		{
			if (cb_getROI == null)
				cb_getROI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetROI);
			return cb_getROI;
		}

		static IntPtr n_GetROI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ROI);
		}
#pragma warning restore 0169

		static Delegate cb_setROI_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetSetROI_Landroid_graphics_Rect_Handler ()
		{
			if (cb_setROI_Landroid_graphics_Rect_ == null)
				cb_setROI_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetROI_Landroid_graphics_Rect_);
			return cb_setROI_Landroid_graphics_Rect_;
		}

		static void n_SetROI_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ROI = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getROI;
		static IntPtr id_setROI_Landroid_graphics_Rect_;
		public virtual unsafe global::Android.Graphics.Rect ROI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='getROI' and count(parameter)=0]"
			[Register ("getROI", "()Landroid/graphics/Rect;", "GetGetROIHandler")]
			get {
				if (id_getROI == IntPtr.Zero)
					id_getROI = JNIEnv.GetMethodID (class_ref, "getROI", "()Landroid/graphics/Rect;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_getROI), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getROI", "()Landroid/graphics/Rect;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='setROI' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("setROI", "(Landroid/graphics/Rect;)V", "GetSetROI_Landroid_graphics_Rect_Handler")]
			set {
				if (id_setROI_Landroid_graphics_Rect_ == IntPtr.Zero)
					id_setROI_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "setROI", "(Landroid/graphics/Rect;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setROI_Landroid_graphics_Rect_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setROI", "(Landroid/graphics/Rect;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
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
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/microblink/image/Image;", "GetCloneHandler")]
		public virtual unsafe global::Com.Microblink.Image.Image Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/microblink/image/Image;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/microblink/image/Image;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_convertToBitmap;
#pragma warning disable 0169
		static Delegate GetConvertToBitmapHandler ()
		{
			if (cb_convertToBitmap == null)
				cb_convertToBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ConvertToBitmap);
			return cb_convertToBitmap;
		}

		static IntPtr n_ConvertToBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConvertToBitmap ());
		}
#pragma warning restore 0169

		static IntPtr id_convertToBitmap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='convertToBitmap' and count(parameter)=0]"
		[Register ("convertToBitmap", "()Landroid/graphics/Bitmap;", "GetConvertToBitmapHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap ConvertToBitmap ()
		{
			if (id_convertToBitmap == IntPtr.Zero)
				id_convertToBitmap = JNIEnv.GetMethodID (class_ref, "convertToBitmap", "()Landroid/graphics/Bitmap;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_convertToBitmap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertToBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

		static Delegate cb_getImagePlanes;
#pragma warning disable 0169
		static Delegate GetGetImagePlanesHandler ()
		{
			if (cb_getImagePlanes == null)
				cb_getImagePlanes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImagePlanes);
			return cb_getImagePlanes;
		}

		static IntPtr n_GetImagePlanes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Image.Image __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Image.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetImagePlanes ());
		}
#pragma warning restore 0169

		static IntPtr id_getImagePlanes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.image']/class[@name='Image']/method[@name='getImagePlanes' and count(parameter)=0]"
		[Register ("getImagePlanes", "()[Lcom/microblink/image/ImagePlane;", "GetGetImagePlanesHandler")]
		public virtual unsafe global::Com.Microblink.Image.ImagePlane[] GetImagePlanes ()
		{
			if (id_getImagePlanes == IntPtr.Zero)
				id_getImagePlanes = JNIEnv.GetMethodID (class_ref, "getImagePlanes", "()[Lcom/microblink/image/ImagePlane;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.Microblink.Image.ImagePlane[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getImagePlanes), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Image.ImagePlane));
				else
					return (global::Com.Microblink.Image.ImagePlane[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImagePlanes", "()[Lcom/microblink/image/ImagePlane;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Image.ImagePlane));
			} finally {
			}
		}

	}
}
