using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry.QuadDrawers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='FOVQuadDrawer']"
	[global::Android.Runtime.Register ("com/microblink/geometry/quadDrawers/FOVQuadDrawer", DoNotGenerateAcw=true)]
	public partial class FOVQuadDrawer : global::Java.Lang.Object, global::Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/geometry/quadDrawers/FOVQuadDrawer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FOVQuadDrawer); }
		}

		protected FOVQuadDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='FOVQuadDrawer']/constructor[@name='FOVQuadDrawer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FOVQuadDrawer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FOVQuadDrawer)) {
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
			global::Com.Microblink.Geometry.QuadDrawers.FOVQuadDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadDrawers.FOVQuadDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Paint);
		}
#pragma warning restore 0169

		static IntPtr id_getPaint;
		public virtual unsafe global::Android.Graphics.Paint Paint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='FOVQuadDrawer']/method[@name='getPaint' and count(parameter)=0]"
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
			global::Com.Microblink.Geometry.QuadDrawers.FOVQuadDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadDrawers.FOVQuadDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DrawQuad (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='FOVQuadDrawer']/method[@name='drawQuad' and count(parameter)=2 and parameter[1][@type='com.microblink.geometry.Quadrilateral'] and parameter[2][@type='android.graphics.Canvas']]"
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

		static IntPtr id_llIIlIlIIl_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/class[@name='FOVQuadDrawer']/method[@name='llIIlIlIIl' and count(parameter)=3 and parameter[1][@type='com.microblink.geometry.Quadrilateral'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='android.graphics.Paint']]"
		[Register ("llIIlIlIIl", "(Lcom/microblink/geometry/Quadrilateral;Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "")]
		protected static unsafe void LlIIlIlIIl (global::Com.Microblink.Geometry.Quadrilateral p0, global::Android.Graphics.Canvas p1, global::Android.Graphics.Paint p2)
		{
			if (id_llIIlIlIIl_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
				id_llIIlIlIIl_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetStaticMethodID (class_ref, "llIIlIlIIl", "(Lcom/microblink/geometry/Quadrilateral;Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_llIIlIlIIl_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_Landroid_graphics_Paint_, __args);
			} finally {
			}
		}

	}
}
