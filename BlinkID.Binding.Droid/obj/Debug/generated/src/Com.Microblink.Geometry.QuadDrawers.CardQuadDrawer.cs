using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry.QuadDrawers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='CardQuadDrawer']"
	[global::Android.Runtime.Register ("com/microblink/geometry/quadDrawers/CardQuadDrawer", DoNotGenerateAcw=true)]
	public partial class CardQuadDrawer : global::Java.Lang.Object, global::Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/geometry/quadDrawers/CardQuadDrawer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardQuadDrawer); }
		}

		protected CardQuadDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='CardQuadDrawer']/constructor[@name='CardQuadDrawer' and count(parameter)=2 and parameter[1][@type='com.microblink.geometry.quadTransform.IQuadTransformer'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lcom/microblink/geometry/quadTransform/IQuadTransformer;Landroid/content/Context;)V", "")]
		public unsafe CardQuadDrawer (global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer p0, global::Android.Content.Context p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CardQuadDrawer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/geometry/quadTransform/IQuadTransformer;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/geometry/quadTransform/IQuadTransformer;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/geometry/quadTransform/IQuadTransformer;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_geometry_quadTransform_IQuadTransformer_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getPaint;
#pragma warning disable 0169
		static Delegate GetGetPaintHandler ()
		{
			if (cb_getPaint == null)
				cb_getPaint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaint);
			return cb_getPaint;
		}

		static IntPtr n_GetPaint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.QuadDrawers.CardQuadDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadDrawers.CardQuadDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Paint);
		}
#pragma warning restore 0169

		static IntPtr id_getPaint;
		public virtual unsafe global::Android.Graphics.Paint Paint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='CardQuadDrawer']/method[@name='getPaint' and count(parameter)=0]"
			[Register ("getPaint", "()Landroid/graphics/Paint;", "GetGetPaintHandler")]
			get {
				if (id_getPaint == IntPtr.Zero)
					id_getPaint = JNIEnv.GetMethodID (class_ref, "getPaint", "()Landroid/graphics/Paint;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod  (Handle, id_getPaint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaint", "()Landroid/graphics/Paint;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Microblink.Geometry.QuadDrawers.CardQuadDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadDrawers.CardQuadDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QuadTransformer);
		}
#pragma warning restore 0169

		static IntPtr id_getQuadTransformer;
		public virtual unsafe global::Com.Microblink.Geometry.QuadTransform.IQuadTransformer QuadTransformer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='CardQuadDrawer']/method[@name='getQuadTransformer' and count(parameter)=0]"
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

		static Delegate cb_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_ == null)
				cb_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_);
			return cb_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_;
		}

		static void n_DrawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.Geometry.QuadDrawers.CardQuadDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadDrawers.CardQuadDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DrawQuad (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='CardQuadDrawer']/method[@name='drawQuad' and count(parameter)=2 and parameter[1][@type='com.microblink.geometry.Quadrilateral'] and parameter[2][@type='android.graphics.Canvas']]"
		[Register ("drawQuad", "(Lcom/microblink/geometry/Quadrilateral;Landroid/graphics/Canvas;)V", "GetDrawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void DrawQuad (global::Com.Microblink.Geometry.Quadrilateral p0, global::Android.Graphics.Canvas p1)
		{
			if (id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "drawQuad", "(Lcom/microblink/geometry/Quadrilateral;Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawQuad", "(Lcom/microblink/geometry/Quadrilateral;Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

	}
}
