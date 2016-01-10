using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry.QuadDrawers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='IdQuadDrawer']"
	[global::Android.Runtime.Register ("com/microblink/geometry/quadDrawers/IdQuadDrawer", DoNotGenerateAcw=true)]
	public partial class IdQuadDrawer : global::Com.Microblink.Geometry.QuadDrawers.FOVQuadDrawer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/geometry/quadDrawers/IdQuadDrawer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IdQuadDrawer); }
		}

		protected IdQuadDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='IdQuadDrawer']/constructor[@name='IdQuadDrawer' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.quadTransform.IQuadTransformer']]"
		[Register (".ctor", "(Lcom/microblink/geometry/quadTransform/IQuadTransformer;)V", "")]
		public unsafe IdQuadDrawer (global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (IdQuadDrawer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/geometry/quadTransform/IQuadTransformer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/geometry/quadTransform/IQuadTransformer;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/geometry/quadTransform/IQuadTransformer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_, __args);
			} finally {
			}
		}

		static Delegate cb_getQuadTransformer;
#pragma warning disable 0169
		static Delegate GetGetQuadTransformerHandler ()
		{
			if (cb_getQuadTransformer == null)
				cb_getQuadTransformer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuadTransformer);
			return cb_getQuadTransformer;
		}

		static IntPtr n_GetQuadTransformer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.QuadDrawers.IdQuadDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadDrawers.IdQuadDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QuadTransformer);
		}
#pragma warning restore 0169

		static IntPtr id_getQuadTransformer;
		public virtual unsafe global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer QuadTransformer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='IdQuadDrawer']/method[@name='getQuadTransformer' and count(parameter)=0]"
			[Register ("getQuadTransformer", "()Lcom/microblink/geometry/quadTransform/IQuadTransformer;", "GetGetQuadTransformerHandler")]
			get {
				if (id_getQuadTransformer == IntPtr.Zero)
					id_getQuadTransformer = JNIEnv.GetMethodID (class_ref, "getQuadTransformer", "()Lcom/microblink/geometry/quadTransform/IQuadTransformer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer> (JNIEnv.CallObjectMethod  (Handle, id_getQuadTransformer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuadTransformer", "()Lcom/microblink/geometry/quadTransform/IQuadTransformer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
