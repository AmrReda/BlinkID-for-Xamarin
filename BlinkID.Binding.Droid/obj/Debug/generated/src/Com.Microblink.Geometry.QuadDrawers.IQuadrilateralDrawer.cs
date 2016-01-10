using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry.QuadDrawers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/interface[@name='IQuadrilateralDrawer']"
	[Register ("com/microblink/geometry/quadDrawers/IQuadrilateralDrawer", "", "Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawerInvoker")]
	public partial interface IQuadrilateralDrawer : IJavaObject {

		global::Android.Graphics.Paint Paint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/interface[@name='IQuadrilateralDrawer']/method[@name='getPaint' and count(parameter)=0]"
			[Register ("getPaint", "()Landroid/graphics/Paint;", "GetGetPaintHandler:Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawerInvoker, BlinkID.Binding.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry.quadDrawers']/interface[@name='IQuadrilateralDrawer']/method[@name='drawQuad' and count(parameter)=2 and parameter[1][@type='com.microblink.geometry.Quadrilateral'] and parameter[2][@type='android.graphics.Canvas']]"
		[Register ("drawQuad", "(Lcom/microblink/geometry/Quadrilateral;Landroid/graphics/Canvas;)V", "GetDrawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_Handler:Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawerInvoker, BlinkID.Binding.Droid")]
		void DrawQuad (global::Com.Microblink.Geometry.Quadrilateral p0, global::Android.Graphics.Canvas p1);

	}

	[global::Android.Runtime.Register ("com/microblink/geometry/quadDrawers/IQuadrilateralDrawer", DoNotGenerateAcw=true)]
	internal class IQuadrilateralDrawerInvoker : global::Java.Lang.Object, IQuadrilateralDrawer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/geometry/quadDrawers/IQuadrilateralDrawer");
		IntPtr class_ref;

		public static IQuadrilateralDrawer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQuadrilateralDrawer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.geometry.quadDrawers.IQuadrilateralDrawer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQuadrilateralDrawerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IQuadrilateralDrawerInvoker); }
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
			global::Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Paint);
		}
#pragma warning restore 0169

		IntPtr id_getPaint;
		public unsafe global::Android.Graphics.Paint Paint {
			get {
				if (id_getPaint == IntPtr.Zero)
					id_getPaint = JNIEnv.GetMethodID (class_ref, "getPaint", "()Landroid/graphics/Paint;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod (Handle, id_getPaint), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.QuadDrawers.IQuadrilateralDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Quadrilateral p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DrawQuad (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_;
		public unsafe void DrawQuad (global::Com.Microblink.Geometry.Quadrilateral p0, global::Android.Graphics.Canvas p1)
		{
			if (id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "drawQuad", "(Lcom/microblink/geometry/Quadrilateral;Landroid/graphics/Canvas;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_drawQuad_Lcom_microblink_geometry_Quadrilateral_Landroid_graphics_Canvas_, __args);
		}

	}

}
