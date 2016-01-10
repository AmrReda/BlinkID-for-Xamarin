using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']"
	[global::Android.Runtime.Register ("com/microblink/geometry/Rectangle", DoNotGenerateAcw=true)]
	public partial class Rectangle : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/geometry/Rectangle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Rectangle); }
		}

		protected Rectangle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/constructor[@name='Rectangle' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(FFFF)V", "")]
		public unsafe Rectangle (float p0, float p1, float p2, float p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (Rectangle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FFFF)V", __args);
					return;
				}

				if (id_ctor_FFFF == IntPtr.Zero)
					id_ctor_FFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FFFF, __args);
			} finally {
			}
		}

		static IntPtr id_getDefaultROI;
		public static unsafe global::Com.Microblink.Geometry.Rectangle DefaultROI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='getDefaultROI' and count(parameter)=0]"
			[Register ("getDefaultROI", "()Lcom/microblink/geometry/Rectangle;", "GetGetDefaultROIHandler")]
			get {
				if (id_getDefaultROI == IntPtr.Zero)
					id_getDefaultROI = JNIEnv.GetStaticMethodID (class_ref, "getDefaultROI", "()Lcom/microblink/geometry/Rectangle;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultROI), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHeight);
			return cb_getHeight;
		}

		static float n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Rectangle __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWidth);
			return cb_getWidth;
		}

		static float n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Rectangle __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()F"));
				} finally {
				}
			}
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
			global::Com.Microblink.Geometry.Rectangle __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
			return cb_getX;
		}

		static float n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Rectangle __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "GetGetXHandler")]
		public virtual unsafe float GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getX);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()F"));
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
			return cb_getY;
		}

		static float n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Rectangle __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "GetGetYHandler")]
		public virtual unsafe float GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getY);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()F"));
			} finally {
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
			global::Com.Microblink.Geometry.Rectangle __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Log ();
		}
#pragma warning restore 0169

		static IntPtr id_log;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='log' and count(parameter)=0]"
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

		static Delegate cb_normalizeToUnitRectangle;
#pragma warning disable 0169
		static Delegate GetNormalizeToUnitRectangleHandler ()
		{
			if (cb_normalizeToUnitRectangle == null)
				cb_normalizeToUnitRectangle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NormalizeToUnitRectangle);
			return cb_normalizeToUnitRectangle;
		}

		static void n_NormalizeToUnitRectangle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Rectangle __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NormalizeToUnitRectangle ();
		}
#pragma warning restore 0169

		static IntPtr id_normalizeToUnitRectangle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='normalizeToUnitRectangle' and count(parameter)=0]"
		[Register ("normalizeToUnitRectangle", "()V", "GetNormalizeToUnitRectangleHandler")]
		public virtual unsafe void NormalizeToUnitRectangle ()
		{
			if (id_normalizeToUnitRectangle == IntPtr.Zero)
				id_normalizeToUnitRectangle = JNIEnv.GetMethodID (class_ref, "normalizeToUnitRectangle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_normalizeToUnitRectangle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizeToUnitRectangle", "()V"));
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Microblink.Geometry.Rectangle __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Rectangle']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
