using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry']/class[@name='QuadrangleEvaluator']"
	[global::Android.Runtime.Register ("com/microblink/geometry/QuadrangleEvaluator", DoNotGenerateAcw=true)]
	public partial class QuadrangleEvaluator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/geometry/QuadrangleEvaluator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuadrangleEvaluator); }
		}

		protected QuadrangleEvaluator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='QuadrangleEvaluator']/constructor[@name='QuadrangleEvaluator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QuadrangleEvaluator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (QuadrangleEvaluator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_;
#pragma warning disable 0169
		static Delegate GetEvaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_Handler ()
		{
			if (cb_evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_ == null)
				cb_evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr>) n_Evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_);
			return cb_evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_;
		}

		static IntPtr n_Evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Microblink.Geometry.QuadrangleEvaluator __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadrangleEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p1 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p2 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Evaluate (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='QuadrangleEvaluator']/method[@name='evaluate' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='com.microblink.geometry.Quadrilateral'] and parameter[3][@type='com.microblink.geometry.Quadrilateral']]"
		[Register ("evaluate", "(FLcom/microblink/geometry/Quadrilateral;Lcom/microblink/geometry/Quadrilateral;)Lcom/microblink/geometry/Quadrilateral;", "GetEvaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_Handler")]
		public virtual unsafe global::Com.Microblink.Geometry.Quadrilateral Evaluate (float p0, global::Com.Microblink.Geometry.Quadrilateral p1, global::Com.Microblink.Geometry.Quadrilateral p2)
		{
			if (id_evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_ == IntPtr.Zero)
				id_evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_ = JNIEnv.GetMethodID (class_ref, "evaluate", "(FLcom/microblink/geometry/Quadrilateral;Lcom/microblink/geometry/Quadrilateral;)Lcom/microblink/geometry/Quadrilateral;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Microblink.Geometry.Quadrilateral __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallObjectMethod  (Handle, id_evaluate_FLcom_microblink_geometry_Quadrilateral_Lcom_microblink_geometry_Quadrilateral_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "evaluate", "(FLcom/microblink/geometry/Quadrilateral;Lcom/microblink/geometry/Quadrilateral;)Lcom/microblink/geometry/Quadrilateral;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
