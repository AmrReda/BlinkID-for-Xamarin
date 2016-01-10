using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry.QuadTransform {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.geometry.quadTransform']/interface[@name='IQuadTransformer']"
	[Register ("com/microblink/geometry/quadTransform/IQuadTransformer", "", "Com.Microblink.Geometry.QuadTransform.IQuadTransformerInvoker")]
	public partial interface IQuadTransformer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadTransform']/interface[@name='IQuadTransformer']/method[@name='transformQuad' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Quadrilateral']]"
		[Register ("transformQuad", "(Lcom/microblink/geometry/Quadrilateral;)Lcom/microblink/geometry/Quadrilateral;", "GetTransformQuad_Lcom_microblink_geometry_Quadrilateral_Handler:Com.Microblink.Geometry.QuadTransform.IQuadTransformerInvoker, BlinkID.Binding.Droid")]
		global::Com.Microblink.Geometry.Quadrilateral TransformQuad (global::Com.Microblink.Geometry.Quadrilateral p0);

	}

	[global::Android.Runtime.Register ("com/microblink/geometry/quadTransform/IQuadTransformer", DoNotGenerateAcw=true)]
	internal class IQuadTransformerInvoker : global::Java.Lang.Object, IQuadTransformer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/geometry/quadTransform/IQuadTransformer");
		IntPtr class_ref;

		public static IQuadTransformer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQuadTransformer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.geometry.quadTransform.IQuadTransformer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQuadTransformerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IQuadTransformerInvoker); }
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
			global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TransformQuad (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_transformQuad_Lcom_microblink_geometry_Quadrilateral_;
		public unsafe global::Com.Microblink.Geometry.Quadrilateral TransformQuad (global::Com.Microblink.Geometry.Quadrilateral p0)
		{
			if (id_transformQuad_Lcom_microblink_geometry_Quadrilateral_ == IntPtr.Zero)
				id_transformQuad_Lcom_microblink_geometry_Quadrilateral_ = JNIEnv.GetMethodID (class_ref, "transformQuad", "(Lcom/microblink/geometry/Quadrilateral;)Lcom/microblink/geometry/Quadrilateral;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Microblink.Geometry.Quadrilateral __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallObjectMethod (Handle, id_transformQuad_Lcom_microblink_geometry_Quadrilateral_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
