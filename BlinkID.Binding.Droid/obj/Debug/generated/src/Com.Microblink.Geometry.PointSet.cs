using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry']/class[@name='PointSet']"
	[global::Android.Runtime.Register ("com/microblink/geometry/PointSet", DoNotGenerateAcw=true)]
	public partial class PointSet : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/geometry/PointSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PointSet); }
		}

		protected PointSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='PointSet']/constructor[@name='PointSet' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.microblink.geometry.Point&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe PointSet (global::System.Collections.Generic.IList<global::Com.Microblink.Geometry.Point> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Microblink.Geometry.Point>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (PointSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_arrayFIIIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='PointSet']/constructor[@name='PointSet' and count(parameter)=5 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "([FIIIZ)V", "")]
		public unsafe PointSet (float[] p0, int p1, int p2, int p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (PointSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([FIIIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([FIIIZ)V", __args);
					return;
				}

				if (id_ctor_arrayFIIIZ == IntPtr.Zero)
					id_ctor_arrayFIIIZ = JNIEnv.GetMethodID (class_ref, "<init>", "([FIIIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayFIIIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayFIIIZ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.PointSet __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.PointSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Microblink.Geometry.Point>.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		static IntPtr id_getPoints;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Microblink.Geometry.Point> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='PointSet']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Microblink.Geometry.Point>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Microblink.Geometry.Point>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_IHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I == null)
				cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I);
			return cb_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I;
		}

		static void n_Draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Microblink.Geometry.PointSet __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.PointSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='PointSet']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint'] and parameter[3][@type='int']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;I)V", "GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_IHandler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas p0, global::Android.Graphics.Paint p1, int p2)
		{
			if (id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_mirror_III;
#pragma warning disable 0169
		static Delegate GetMirror_IIIHandler ()
		{
			if (cb_mirror_III == null)
				cb_mirror_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_Mirror_III);
			return cb_mirror_III;
		}

		static void n_Mirror_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Com.Microblink.Geometry.PointSet __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.PointSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mirror (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_mirror_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='PointSet']/method[@name='mirror' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("mirror", "(III)V", "GetMirror_IIIHandler")]
		public virtual unsafe void Mirror (int p0, int p1, int p2)
		{
			if (id_mirror_III == IntPtr.Zero)
				id_mirror_III = JNIEnv.GetMethodID (class_ref, "mirror", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_mirror_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mirror", "(III)V"), __args);
			} finally {
			}
		}

	}
}
