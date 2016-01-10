using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry.QuadTransform {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry.quadTransform']/class[@name='IdQuadTransformer']"
	[global::Android.Runtime.Register ("com/microblink/geometry/quadTransform/IdQuadTransformer", DoNotGenerateAcw=true)]
	public partial class IdQuadTransformer : global::Java.Lang.Object, global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/geometry/quadTransform/IdQuadTransformer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IdQuadTransformer); }
		}

		protected IdQuadTransformer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FLcom_microblink_hardware_orientation_Orientation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry.quadTransform']/class[@name='IdQuadTransformer']/constructor[@name='IdQuadTransformer' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.microblink.hardware.orientation.Orientation']]"
		[Register (".ctor", "(FLcom/microblink/hardware/orientation/Orientation;)V", "")]
		public unsafe IdQuadTransformer (float p0, global::Com.Microblink.Hardware.Orientation.Orientation p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (IdQuadTransformer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FLcom/microblink/hardware/orientation/Orientation;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FLcom/microblink/hardware/orientation/Orientation;)V", __args);
					return;
				}

				if (id_ctor_FLcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
					id_ctor_FLcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(FLcom/microblink/hardware/orientation/Orientation;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FLcom_microblink_hardware_orientation_Orientation_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FLcom_microblink_hardware_orientation_Orientation_, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentOrientation;
#pragma warning disable 0169
		static Delegate GetGetCurrentOrientationHandler ()
		{
			if (cb_getCurrentOrientation == null)
				cb_getCurrentOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentOrientation);
			return cb_getCurrentOrientation;
		}

		static IntPtr n_GetCurrentOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.QuadTransform.IdQuadTransformer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadTransform.IdQuadTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentOrientation);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentOrientation;
		public virtual unsafe global::Com.Microblink.Hardware.Orientation.Orientation CurrentOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadTransform']/class[@name='IdQuadTransformer']/method[@name='getCurrentOrientation' and count(parameter)=0]"
			[Register ("getCurrentOrientation", "()Lcom/microblink/hardware/orientation/Orientation;", "GetGetCurrentOrientationHandler")]
			get {
				if (id_getCurrentOrientation == IntPtr.Zero)
					id_getCurrentOrientation = JNIEnv.GetMethodID (class_ref, "getCurrentOrientation", "()Lcom/microblink/hardware/orientation/Orientation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentOrientation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentOrientation", "()Lcom/microblink/hardware/orientation/Orientation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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
			global::Com.Microblink.Geometry.QuadTransform.IdQuadTransformer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadTransform.IdQuadTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Orientation.Orientation p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOrientation_Lcom_microblink_hardware_orientation_Orientation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadTransform']/class[@name='IdQuadTransformer']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
		[Register ("setOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V", "GetSetOrientation_Lcom_microblink_hardware_orientation_Orientation_Handler")]
		public virtual unsafe void SetOrientation (global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			if (id_setOrientation_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
				id_setOrientation_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "setOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOrientation_Lcom_microblink_hardware_orientation_Orientation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_transformQuad_Lcom_microblink_geometry_Quadrilateral_;
#pragma warning disable 0169
		static Delegate GetTransformQuad_Lcom_microblink_geometry_Quadrilateral_Handler ()
		{
			if (cb_transformQuad_Lcom_microblink_geometry_Quadrilateral_ == null)
				cb_transformQuad_Lcom_microblink_geometry_Quadrilateral_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformQuad_Lcom_microblink_geometry_Quadrilateral_);
			return cb_transformQuad_Lcom_microblink_geometry_Quadrilateral_;
		}

		static IntPtr n_TransformQuad_Lcom_microblink_geometry_Quadrilateral_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Geometry.QuadTransform.IdQuadTransformer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadTransform.IdQuadTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TransformQuad (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transformQuad_Lcom_microblink_geometry_Quadrilateral_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadTransform']/class[@name='IdQuadTransformer']/method[@name='transformQuad' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Quadrilateral']]"
		[Register ("transformQuad", "(Lcom/microblink/geometry/Quadrilateral;)Lcom/microblink/geometry/Quadrilateral;", "GetTransformQuad_Lcom_microblink_geometry_Quadrilateral_Handler")]
		public virtual unsafe global::Com.Microblink.Geometry.Quadrilateral TransformQuad (global::Com.Microblink.Geometry.Quadrilateral p0)
		{
			if (id_transformQuad_Lcom_microblink_geometry_Quadrilateral_ == IntPtr.Zero)
				id_transformQuad_Lcom_microblink_geometry_Quadrilateral_ = JNIEnv.GetMethodID (class_ref, "transformQuad", "(Lcom/microblink/geometry/Quadrilateral;)Lcom/microblink/geometry/Quadrilateral;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Microblink.Geometry.Quadrilateral __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallObjectMethod  (Handle, id_transformQuad_Lcom_microblink_geometry_Quadrilateral_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transformQuad", "(Lcom/microblink/geometry/Quadrilateral;)Lcom/microblink/geometry/Quadrilateral;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
