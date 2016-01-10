using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware.Camera.Camera2.Frame {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']"
	[global::Android.Runtime.Register ("com/microblink/hardware/camera/camera2/frame/Camera2Frame", DoNotGenerateAcw=true)]
	public partial class Camera2Frame : global::Java.Lang.Object {


		static IntPtr IlIllIlIIl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/field[@name='IlIllIlIIl']"
		[Register ("IlIllIlIIl")]
		public long IlIllIlIIl {
			get {
				if (IlIllIlIIl_jfieldId == IntPtr.Zero)
					IlIllIlIIl_jfieldId = JNIEnv.GetFieldID (class_ref, "IlIllIlIIl", "J");
				return JNIEnv.GetLongField (Handle, IlIllIlIIl_jfieldId);
			}
			set {
				if (IlIllIlIIl_jfieldId == IntPtr.Zero)
					IlIllIlIIl_jfieldId = JNIEnv.GetFieldID (class_ref, "IlIllIlIIl", "J");
				try {
					JNIEnv.SetField (Handle, IlIllIlIIl_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr llIIlIlIIl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/field[@name='llIIlIlIIl']"
		[Register ("llIIlIlIIl")]
		public global::Android.Media.Image LlIIlIlIIl {
			get {
				if (llIIlIlIIl_jfieldId == IntPtr.Zero)
					llIIlIlIIl_jfieldId = JNIEnv.GetFieldID (class_ref, "llIIlIlIIl", "Landroid/media/Image;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, llIIlIlIIl_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Media.Image> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (llIIlIlIIl_jfieldId == IntPtr.Zero)
					llIIlIlIIl_jfieldId = JNIEnv.GetFieldID (class_ref, "llIIlIlIIl", "Landroid/media/Image;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, llIIlIlIIl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr llIlIlIlIl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/field[@name='llIlIlIlIl']"
		[Register ("llIlIlIlIl")]
		public bool LlIlIlIlIl {
			get {
				if (llIlIlIlIl_jfieldId == IntPtr.Zero)
					llIlIlIlIl_jfieldId = JNIEnv.GetFieldID (class_ref, "llIlIlIlIl", "Z");
				return JNIEnv.GetBooleanField (Handle, llIlIlIlIl_jfieldId);
			}
			set {
				if (llIlIlIlIl_jfieldId == IntPtr.Zero)
					llIlIlIlIl_jfieldId = JNIEnv.GetFieldID (class_ref, "llIlIlIlIl", "Z");
				try {
					JNIEnv.SetField (Handle, llIlIlIlIl_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFocused_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/field[@name='mFocused']"
		[Register ("mFocused")]
		public bool MFocused {
			get {
				if (mFocused_jfieldId == IntPtr.Zero)
					mFocused_jfieldId = JNIEnv.GetFieldID (class_ref, "mFocused", "Z");
				return JNIEnv.GetBooleanField (Handle, mFocused_jfieldId);
			}
			set {
				if (mFocused_jfieldId == IntPtr.Zero)
					mFocused_jfieldId = JNIEnv.GetFieldID (class_ref, "mFocused", "Z");
				try {
					JNIEnv.SetField (Handle, mFocused_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/hardware/camera/camera2/frame/Camera2Frame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Camera2Frame); }
		}

		protected Camera2Frame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getFrameID;
#pragma warning disable 0169
		static Delegate GetGetFrameIDHandler ()
		{
			if (cb_getFrameID == null)
				cb_getFrameID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFrameID);
			return cb_getFrameID;
		}

		static long n_GetFrameID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameID;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameID;
		public virtual unsafe long FrameID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='getFrameID' and count(parameter)=0]"
			[Register ("getFrameID", "()J", "GetGetFrameIDHandler")]
			get {
				if (id_getFrameID == IntPtr.Zero)
					id_getFrameID = JNIEnv.GetMethodID (class_ref, "getFrameID", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getFrameID);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameID", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getFrameQuality;
#pragma warning disable 0169
		static Delegate GetGetFrameQualityHandler ()
		{
			if (cb_getFrameQuality == null)
				cb_getFrameQuality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetFrameQuality);
			return cb_getFrameQuality;
		}

		static double n_GetFrameQuality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameQuality;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameQuality;
		public virtual unsafe double FrameQuality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='getFrameQuality' and count(parameter)=0]"
			[Register ("getFrameQuality", "()D", "GetGetFrameQualityHandler")]
			get {
				if (id_getFrameQuality == IntPtr.Zero)
					id_getFrameQuality = JNIEnv.GetMethodID (class_ref, "getFrameQuality", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getFrameQuality);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameQuality", "()D"));
				} finally {
				}
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
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='getHeight' and count(parameter)=0]"
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

		static Delegate cb_isDeviceMoving;
#pragma warning disable 0169
		static Delegate GetIsDeviceMovingHandler ()
		{
			if (cb_isDeviceMoving == null)
				cb_isDeviceMoving = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeviceMoving);
			return cb_isDeviceMoving;
		}

		static bool n_IsDeviceMoving (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeviceMoving;
		}
#pragma warning restore 0169

		static IntPtr id_isDeviceMoving;
		public virtual unsafe bool IsDeviceMoving {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='isDeviceMoving' and count(parameter)=0]"
			[Register ("isDeviceMoving", "()Z", "GetIsDeviceMovingHandler")]
			get {
				if (id_isDeviceMoving == IntPtr.Zero)
					id_isDeviceMoving = JNIEnv.GetMethodID (class_ref, "isDeviceMoving", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDeviceMoving);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeviceMoving", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isFocused;
#pragma warning disable 0169
		static Delegate GetIsFocusedHandler ()
		{
			if (cb_isFocused == null)
				cb_isFocused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFocused);
			return cb_isFocused;
		}

		static bool n_IsFocused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFocused;
		}
#pragma warning restore 0169

		static IntPtr id_isFocused;
		public virtual unsafe bool IsFocused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='isFocused' and count(parameter)=0]"
			[Register ("isFocused", "()Z", "GetIsFocusedHandler")]
			get {
				if (id_isFocused == IntPtr.Zero)
					id_isFocused = JNIEnv.GetMethodID (class_ref, "isFocused", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFocused);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFocused", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPhoto;
#pragma warning disable 0169
		static Delegate GetIsPhotoHandler ()
		{
			if (cb_isPhoto == null)
				cb_isPhoto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPhoto);
			return cb_isPhoto;
		}

		static bool n_IsPhoto (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPhoto;
		}
#pragma warning restore 0169

		static IntPtr id_isPhoto;
		public virtual unsafe bool IsPhoto {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='isPhoto' and count(parameter)=0]"
			[Register ("isPhoto", "()Z", "GetIsPhotoHandler")]
			get {
				if (id_isPhoto == IntPtr.Zero)
					id_isPhoto = JNIEnv.GetMethodID (class_ref, "isPhoto", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isPhoto);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPhoto", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNativeCameraFrame;
#pragma warning disable 0169
		static Delegate GetGetNativeCameraFrameHandler ()
		{
			if (cb_getNativeCameraFrame == null)
				cb_getNativeCameraFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeCameraFrame);
			return cb_getNativeCameraFrame;
		}

		static long n_GetNativeCameraFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeCameraFrame;
		}
#pragma warning restore 0169

		static IntPtr id_getNativeCameraFrame;
		public virtual unsafe long NativeCameraFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='getNativeCameraFrame' and count(parameter)=0]"
			[Register ("getNativeCameraFrame", "()J", "GetGetNativeCameraFrameHandler")]
			get {
				if (id_getNativeCameraFrame == IntPtr.Zero)
					id_getNativeCameraFrame = JNIEnv.GetMethodID (class_ref, "getNativeCameraFrame", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getNativeCameraFrame);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeCameraFrame", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientation);
			return cb_getOrientation;
		}

		static IntPtr n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Orientation);
		}
#pragma warning restore 0169

		static Delegate cb_setOrientation_Lcom_microblink_hardware_orientation_Orientation_;
#pragma warning disable 0169
		static Delegate GetSetOrientation_Lcom_microblink_hardware_orientation_Orientation_Handler ()
		{
			if (cb_setOrientation_Lcom_microblink_hardware_orientation_Orientation_ == null)
				cb_setOrientation_Lcom_microblink_hardware_orientation_Orientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientation_Lcom_microblink_hardware_orientation_Orientation_);
			return cb_setOrientation_Lcom_microblink_hardware_orientation_Orientation_;
		}

		static void n_SetOrientation_Lcom_microblink_hardware_orientation_Orientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Orientation.Orientation p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Orientation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		static IntPtr id_setOrientation_Lcom_microblink_hardware_orientation_Orientation_;
		public virtual unsafe global::Com.Microblink.Hardware.Orientation.Orientation Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()Lcom/microblink/hardware/orientation/Orientation;", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()Lcom/microblink/hardware/orientation/Orientation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_getOrientation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()Lcom/microblink/hardware/orientation/Orientation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
			[Register ("setOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V", "GetSetOrientation_Lcom_microblink_hardware_orientation_Orientation_Handler")]
			set {
				if (id_setOrientation_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
					id_setOrientation_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "setOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOrientation_Lcom_microblink_hardware_orientation_Orientation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVisiblePart;
#pragma warning disable 0169
		static Delegate GetGetVisiblePartHandler ()
		{
			if (cb_getVisiblePart == null)
				cb_getVisiblePart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisiblePart);
			return cb_getVisiblePart;
		}

		static IntPtr n_GetVisiblePart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisiblePart);
		}
#pragma warning restore 0169

		static Delegate cb_setVisiblePart_Lcom_microblink_geometry_Rectangle_;
#pragma warning disable 0169
		static Delegate GetSetVisiblePart_Lcom_microblink_geometry_Rectangle_Handler ()
		{
			if (cb_setVisiblePart_Lcom_microblink_geometry_Rectangle_ == null)
				cb_setVisiblePart_Lcom_microblink_geometry_Rectangle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVisiblePart_Lcom_microblink_geometry_Rectangle_);
			return cb_setVisiblePart_Lcom_microblink_geometry_Rectangle_;
		}

		static void n_SetVisiblePart_Lcom_microblink_geometry_Rectangle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Rectangle p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VisiblePart = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVisiblePart;
		static IntPtr id_setVisiblePart_Lcom_microblink_geometry_Rectangle_;
		public virtual unsafe global::Com.Microblink.Geometry.Rectangle VisiblePart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='getVisiblePart' and count(parameter)=0]"
			[Register ("getVisiblePart", "()Lcom/microblink/geometry/Rectangle;", "GetGetVisiblePartHandler")]
			get {
				if (id_getVisiblePart == IntPtr.Zero)
					id_getVisiblePart = JNIEnv.GetMethodID (class_ref, "getVisiblePart", "()Lcom/microblink/geometry/Rectangle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallObjectMethod  (Handle, id_getVisiblePart), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisiblePart", "()Lcom/microblink/geometry/Rectangle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='setVisiblePart' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Rectangle']]"
			[Register ("setVisiblePart", "(Lcom/microblink/geometry/Rectangle;)V", "GetSetVisiblePart_Lcom_microblink_geometry_Rectangle_Handler")]
			set {
				if (id_setVisiblePart_Lcom_microblink_geometry_Rectangle_ == IntPtr.Zero)
					id_setVisiblePart_Lcom_microblink_geometry_Rectangle_ = JNIEnv.GetMethodID (class_ref, "setVisiblePart", "(Lcom/microblink/geometry/Rectangle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVisiblePart_Lcom_microblink_geometry_Rectangle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisiblePart", "(Lcom/microblink/geometry/Rectangle;)V"), __args);
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
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='getWidth' and count(parameter)=0]"
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

		static Delegate cb_finalizePoolObject;
#pragma warning disable 0169
		static Delegate GetFinalizePoolObjectHandler ()
		{
			if (cb_finalizePoolObject == null)
				cb_finalizePoolObject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinalizePoolObject);
			return cb_finalizePoolObject;
		}

		static void n_FinalizePoolObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinalizePoolObject ();
		}
#pragma warning restore 0169

		static IntPtr id_finalizePoolObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='finalizePoolObject' and count(parameter)=0]"
		[Register ("finalizePoolObject", "()V", "GetFinalizePoolObjectHandler")]
		public virtual unsafe void FinalizePoolObject ()
		{
			if (id_finalizePoolObject == IntPtr.Zero)
				id_finalizePoolObject = JNIEnv.GetMethodID (class_ref, "finalizePoolObject", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_finalizePoolObject);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalizePoolObject", "()V"));
			} finally {
			}
		}

		static Delegate cb_initializeNativePart_J;
#pragma warning disable 0169
		static Delegate GetInitializeNativePart_JHandler ()
		{
			if (cb_initializeNativePart_J == null)
				cb_initializeNativePart_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_InitializeNativePart_J);
			return cb_initializeNativePart_J;
		}

		static bool n_InitializeNativePart_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitializeNativePart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initializeNativePart_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='initializeNativePart' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("initializeNativePart", "(J)Z", "GetInitializeNativePart_JHandler")]
		public virtual unsafe bool InitializeNativePart (long p0)
		{
			if (id_initializeNativePart_J == IntPtr.Zero)
				id_initializeNativePart_J = JNIEnv.GetMethodID (class_ref, "initializeNativePart", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_initializeNativePart_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeNativePart", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_initializePoolObject;
#pragma warning disable 0169
		static Delegate GetInitializePoolObjectHandler ()
		{
			if (cb_initializePoolObject == null)
				cb_initializePoolObject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializePoolObject);
			return cb_initializePoolObject;
		}

		static void n_InitializePoolObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializePoolObject ();
		}
#pragma warning restore 0169

		static IntPtr id_initializePoolObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='initializePoolObject' and count(parameter)=0]"
		[Register ("initializePoolObject", "()V", "GetInitializePoolObjectHandler")]
		public virtual unsafe void InitializePoolObject ()
		{
			if (id_initializePoolObject == IntPtr.Zero)
				id_initializePoolObject = JNIEnv.GetMethodID (class_ref, "initializePoolObject", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initializePoolObject);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializePoolObject", "()V"));
			} finally {
			}
		}

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.Camera2.Frame.Camera2Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.camera.camera2.frame']/class[@name='Camera2Frame']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recycle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
			} finally {
			}
		}

	}
}
