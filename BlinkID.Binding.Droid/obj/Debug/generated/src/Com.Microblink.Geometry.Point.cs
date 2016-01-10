using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']"
	[global::Android.Runtime.Register ("com/microblink/geometry/Point", DoNotGenerateAcw=true)]
	public partial class Point : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/geometry/Point", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Point); }
		}

		protected Point (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/constructor[@name='Point' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe Point (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Point)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_FF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/constructor[@name='Point' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe Point (float p0, float p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Point)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FF)V", __args);
					return;
				}

				if (id_ctor_FF == IntPtr.Zero)
					id_ctor_FF = JNIEnv.GetMethodID (class_ref, "<init>", "(FF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FF, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/constructor[@name='Point' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Point ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Point)) {
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

		static Delegate cb_clamp_F;
#pragma warning disable 0169
		static Delegate GetClamp_FHandler ()
		{
			if (cb_clamp_F == null)
				cb_clamp_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Clamp_F);
			return cb_clamp_F;
		}

		static IntPtr n_Clamp_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clamp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_clamp_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='clamp' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("clamp", "(F)Lcom/microblink/geometry/Point;", "GetClamp_FHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point Clamp (float p0)
		{
			if (id_clamp_F == IntPtr.Zero)
				id_clamp_F = JNIEnv.GetMethodID (class_ref, "clamp", "(F)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_clamp_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clamp", "(F)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clamp_FF;
#pragma warning disable 0169
		static Delegate GetClamp_FFHandler ()
		{
			if (cb_clamp_FF == null)
				cb_clamp_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_Clamp_FF);
			return cb_clamp_FF;
		}

		static IntPtr n_Clamp_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clamp (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_clamp_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='clamp' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("clamp", "(FF)Lcom/microblink/geometry/Point;", "GetClamp_FFHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point Clamp (float p0, float p1)
		{
			if (id_clamp_FF == IntPtr.Zero)
				id_clamp_FF = JNIEnv.GetMethodID (class_ref, "clamp", "(FF)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_clamp_FF, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clamp", "(FF)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/microblink/geometry/Point;", "GetCloneHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/microblink/geometry/Point;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_distance_Lcom_microblink_geometry_Point_;
#pragma warning disable 0169
		static Delegate GetDistance_Lcom_microblink_geometry_Point_Handler ()
		{
			if (cb_distance_Lcom_microblink_geometry_Point_ == null)
				cb_distance_Lcom_microblink_geometry_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_Distance_Lcom_microblink_geometry_Point_);
			return cb_distance_Lcom_microblink_geometry_Point_;
		}

		static float n_Distance_Lcom_microblink_geometry_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.Distance (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distance_Lcom_microblink_geometry_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='distance' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Point']]"
		[Register ("distance", "(Lcom/microblink/geometry/Point;)F", "GetDistance_Lcom_microblink_geometry_Point_Handler")]
		public virtual unsafe float Distance (global::Com.Microblink.Geometry.Point p0)
		{
			if (id_distance_Lcom_microblink_geometry_Point_ == IntPtr.Zero)
				id_distance_Lcom_microblink_geometry_Point_ = JNIEnv.GetMethodID (class_ref, "distance", "(Lcom/microblink/geometry/Point;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				float __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod  (Handle, id_distance_Lcom_microblink_geometry_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distance", "(Lcom/microblink/geometry/Point;)F"), __args);
				return __ret;
			} finally {
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
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Landroid_graphics_Paint_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint'] and parameter[3][@type='int']]"
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
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='getX' and count(parameter)=0]"
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
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='getY' and count(parameter)=0]"
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
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Log ();
		}
#pragma warning restore 0169

		static IntPtr id_log;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='log' and count(parameter)=0]"
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

		static Delegate cb_mirrorX_F;
#pragma warning disable 0169
		static Delegate GetMirrorX_FHandler ()
		{
			if (cb_mirrorX_F == null)
				cb_mirrorX_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_MirrorX_F);
			return cb_mirrorX_F;
		}

		static IntPtr n_MirrorX_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MirrorX (p0));
		}
#pragma warning restore 0169

		static IntPtr id_mirrorX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='mirrorX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("mirrorX", "(F)Lcom/microblink/geometry/Point;", "GetMirrorX_FHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point MirrorX (float p0)
		{
			if (id_mirrorX_F == IntPtr.Zero)
				id_mirrorX_F = JNIEnv.GetMethodID (class_ref, "mirrorX", "(F)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_mirrorX_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mirrorX", "(F)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mirrorXY_FF;
#pragma warning disable 0169
		static Delegate GetMirrorXY_FFHandler ()
		{
			if (cb_mirrorXY_FF == null)
				cb_mirrorXY_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_MirrorXY_FF);
			return cb_mirrorXY_FF;
		}

		static IntPtr n_MirrorXY_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MirrorXY (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_mirrorXY_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='mirrorXY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("mirrorXY", "(FF)Lcom/microblink/geometry/Point;", "GetMirrorXY_FFHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point MirrorXY (float p0, float p1)
		{
			if (id_mirrorXY_FF == IntPtr.Zero)
				id_mirrorXY_FF = JNIEnv.GetMethodID (class_ref, "mirrorXY", "(FF)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_mirrorXY_FF, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mirrorXY", "(FF)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mirrorY_F;
#pragma warning disable 0169
		static Delegate GetMirrorY_FHandler ()
		{
			if (cb_mirrorY_F == null)
				cb_mirrorY_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_MirrorY_F);
			return cb_mirrorY_F;
		}

		static IntPtr n_MirrorY_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MirrorY (p0));
		}
#pragma warning restore 0169

		static IntPtr id_mirrorY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='mirrorY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("mirrorY", "(F)Lcom/microblink/geometry/Point;", "GetMirrorY_FHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point MirrorY (float p0)
		{
			if (id_mirrorY_F == IntPtr.Zero)
				id_mirrorY_F = JNIEnv.GetMethodID (class_ref, "mirrorY", "(F)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_mirrorY_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mirrorY", "(F)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_negative;
#pragma warning disable 0169
		static Delegate GetNegativeHandler ()
		{
			if (cb_negative == null)
				cb_negative = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Negative);
			return cb_negative;
		}

		static IntPtr n_Negative (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Negative ());
		}
#pragma warning restore 0169

		static IntPtr id_negative;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='negative' and count(parameter)=0]"
		[Register ("negative", "()Lcom/microblink/geometry/Point;", "GetNegativeHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point Negative ()
		{
			if (id_negative == IntPtr.Zero)
				id_negative = JNIEnv.GetMethodID (class_ref, "negative", "()Lcom/microblink/geometry/Point;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_negative), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "negative", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_negativeClone;
#pragma warning disable 0169
		static Delegate GetNegativeCloneHandler ()
		{
			if (cb_negativeClone == null)
				cb_negativeClone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NegativeClone);
			return cb_negativeClone;
		}

		static IntPtr n_NegativeClone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NegativeClone ());
		}
#pragma warning restore 0169

		static IntPtr id_negativeClone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='negativeClone' and count(parameter)=0]"
		[Register ("negativeClone", "()Lcom/microblink/geometry/Point;", "GetNegativeCloneHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point NegativeClone ()
		{
			if (id_negativeClone == IntPtr.Zero)
				id_negativeClone = JNIEnv.GetMethodID (class_ref, "negativeClone", "()Lcom/microblink/geometry/Point;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_negativeClone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "negativeClone", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_norm;
#pragma warning disable 0169
		static Delegate GetNormHandler ()
		{
			if (cb_norm == null)
				cb_norm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Norm);
			return cb_norm;
		}

		static float n_Norm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Norm ();
		}
#pragma warning restore 0169

		static IntPtr id_norm;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='norm' and count(parameter)=0]"
		[Register ("norm", "()F", "GetNormHandler")]
		public virtual unsafe float Norm ()
		{
			if (id_norm == IntPtr.Zero)
				id_norm = JNIEnv.GetMethodID (class_ref, "norm", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_norm);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "norm", "()F"));
			} finally {
			}
		}

		static Delegate cb_normalize;
#pragma warning disable 0169
		static Delegate GetNormalizeHandler ()
		{
			if (cb_normalize == null)
				cb_normalize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Normalize);
			return cb_normalize;
		}

		static IntPtr n_Normalize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Normalize ());
		}
#pragma warning restore 0169

		static IntPtr id_normalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='normalize' and count(parameter)=0]"
		[Register ("normalize", "()Lcom/microblink/geometry/Point;", "GetNormalizeHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point Normalize ()
		{
			if (id_normalize == IntPtr.Zero)
				id_normalize = JNIEnv.GetMethodID (class_ref, "normalize", "()Lcom/microblink/geometry/Point;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_normalize), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalize_F;
#pragma warning disable 0169
		static Delegate GetNormalize_FHandler ()
		{
			if (cb_normalize_F == null)
				cb_normalize_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Normalize_F);
			return cb_normalize_F;
		}

		static IntPtr n_Normalize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Normalize (p0));
		}
#pragma warning restore 0169

		static IntPtr id_normalize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("normalize", "(F)Lcom/microblink/geometry/Point;", "GetNormalize_FHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point Normalize (float p0)
		{
			if (id_normalize_F == IntPtr.Zero)
				id_normalize_F = JNIEnv.GetMethodID (class_ref, "normalize", "(F)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_normalize_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "(F)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_operatorMinus_Lcom_microblink_geometry_Point_;
#pragma warning disable 0169
		static Delegate GetOperatorMinus_Lcom_microblink_geometry_Point_Handler ()
		{
			if (cb_operatorMinus_Lcom_microblink_geometry_Point_ == null)
				cb_operatorMinus_Lcom_microblink_geometry_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OperatorMinus_Lcom_microblink_geometry_Point_);
			return cb_operatorMinus_Lcom_microblink_geometry_Point_;
		}

		static IntPtr n_OperatorMinus_Lcom_microblink_geometry_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OperatorMinus (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_operatorMinus_Lcom_microblink_geometry_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='operatorMinus' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Point']]"
		[Register ("operatorMinus", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;", "GetOperatorMinus_Lcom_microblink_geometry_Point_Handler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point OperatorMinus (global::Com.Microblink.Geometry.Point p0)
		{
			if (id_operatorMinus_Lcom_microblink_geometry_Point_ == IntPtr.Zero)
				id_operatorMinus_Lcom_microblink_geometry_Point_ = JNIEnv.GetMethodID (class_ref, "operatorMinus", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Microblink.Geometry.Point __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_operatorMinus_Lcom_microblink_geometry_Point_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "operatorMinus", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_operatorMinusEquals_Lcom_microblink_geometry_Point_;
#pragma warning disable 0169
		static Delegate GetOperatorMinusEquals_Lcom_microblink_geometry_Point_Handler ()
		{
			if (cb_operatorMinusEquals_Lcom_microblink_geometry_Point_ == null)
				cb_operatorMinusEquals_Lcom_microblink_geometry_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OperatorMinusEquals_Lcom_microblink_geometry_Point_);
			return cb_operatorMinusEquals_Lcom_microblink_geometry_Point_;
		}

		static IntPtr n_OperatorMinusEquals_Lcom_microblink_geometry_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OperatorMinusEquals (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_operatorMinusEquals_Lcom_microblink_geometry_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='operatorMinusEquals' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Point']]"
		[Register ("operatorMinusEquals", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;", "GetOperatorMinusEquals_Lcom_microblink_geometry_Point_Handler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point OperatorMinusEquals (global::Com.Microblink.Geometry.Point p0)
		{
			if (id_operatorMinusEquals_Lcom_microblink_geometry_Point_ == IntPtr.Zero)
				id_operatorMinusEquals_Lcom_microblink_geometry_Point_ = JNIEnv.GetMethodID (class_ref, "operatorMinusEquals", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Microblink.Geometry.Point __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_operatorMinusEquals_Lcom_microblink_geometry_Point_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "operatorMinusEquals", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_operatorMultiply_F;
#pragma warning disable 0169
		static Delegate GetOperatorMultiply_FHandler ()
		{
			if (cb_operatorMultiply_F == null)
				cb_operatorMultiply_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_OperatorMultiply_F);
			return cb_operatorMultiply_F;
		}

		static IntPtr n_OperatorMultiply_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OperatorMultiply (p0));
		}
#pragma warning restore 0169

		static IntPtr id_operatorMultiply_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='operatorMultiply' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("operatorMultiply", "(F)Lcom/microblink/geometry/Point;", "GetOperatorMultiply_FHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point OperatorMultiply (float p0)
		{
			if (id_operatorMultiply_F == IntPtr.Zero)
				id_operatorMultiply_F = JNIEnv.GetMethodID (class_ref, "operatorMultiply", "(F)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_operatorMultiply_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "operatorMultiply", "(F)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_operatorMultiplyEquals_F;
#pragma warning disable 0169
		static Delegate GetOperatorMultiplyEquals_FHandler ()
		{
			if (cb_operatorMultiplyEquals_F == null)
				cb_operatorMultiplyEquals_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_OperatorMultiplyEquals_F);
			return cb_operatorMultiplyEquals_F;
		}

		static IntPtr n_OperatorMultiplyEquals_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OperatorMultiplyEquals (p0));
		}
#pragma warning restore 0169

		static IntPtr id_operatorMultiplyEquals_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='operatorMultiplyEquals' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("operatorMultiplyEquals", "(F)Lcom/microblink/geometry/Point;", "GetOperatorMultiplyEquals_FHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point OperatorMultiplyEquals (float p0)
		{
			if (id_operatorMultiplyEquals_F == IntPtr.Zero)
				id_operatorMultiplyEquals_F = JNIEnv.GetMethodID (class_ref, "operatorMultiplyEquals", "(F)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_operatorMultiplyEquals_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "operatorMultiplyEquals", "(F)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_operatorPlus_Lcom_microblink_geometry_Point_;
#pragma warning disable 0169
		static Delegate GetOperatorPlus_Lcom_microblink_geometry_Point_Handler ()
		{
			if (cb_operatorPlus_Lcom_microblink_geometry_Point_ == null)
				cb_operatorPlus_Lcom_microblink_geometry_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OperatorPlus_Lcom_microblink_geometry_Point_);
			return cb_operatorPlus_Lcom_microblink_geometry_Point_;
		}

		static IntPtr n_OperatorPlus_Lcom_microblink_geometry_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OperatorPlus (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_operatorPlus_Lcom_microblink_geometry_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='operatorPlus' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Point']]"
		[Register ("operatorPlus", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;", "GetOperatorPlus_Lcom_microblink_geometry_Point_Handler")]
		public virtual unsafe global::Com.Microblink.Geometry.Point OperatorPlus (global::Com.Microblink.Geometry.Point p0)
		{
			if (id_operatorPlus_Lcom_microblink_geometry_Point_ == IntPtr.Zero)
				id_operatorPlus_Lcom_microblink_geometry_Point_ = JNIEnv.GetMethodID (class_ref, "operatorPlus", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Microblink.Geometry.Point __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_operatorPlus_Lcom_microblink_geometry_Point_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "operatorPlus", "(Lcom/microblink/geometry/Point;)Lcom/microblink/geometry/Point;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_operatorPlusEquals_Lcom_microblink_geometry_Point_;
#pragma warning disable 0169
		static Delegate GetOperatorPlusEquals_Lcom_microblink_geometry_Point_Handler ()
		{
			if (cb_operatorPlusEquals_Lcom_microblink_geometry_Point_ == null)
				cb_operatorPlusEquals_Lcom_microblink_geometry_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OperatorPlusEquals_Lcom_microblink_geometry_Point_);
			return cb_operatorPlusEquals_Lcom_microblink_geometry_Point_;
		}

		static void n_OperatorPlusEquals_Lcom_microblink_geometry_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OperatorPlusEquals (p0);
		}
#pragma warning restore 0169

		static IntPtr id_operatorPlusEquals_Lcom_microblink_geometry_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='operatorPlusEquals' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Point']]"
		[Register ("operatorPlusEquals", "(Lcom/microblink/geometry/Point;)V", "GetOperatorPlusEquals_Lcom_microblink_geometry_Point_Handler")]
		public virtual unsafe void OperatorPlusEquals (global::Com.Microblink.Geometry.Point p0)
		{
			if (id_operatorPlusEquals_Lcom_microblink_geometry_Point_ == IntPtr.Zero)
				id_operatorPlusEquals_Lcom_microblink_geometry_Point_ = JNIEnv.GetMethodID (class_ref, "operatorPlusEquals", "(Lcom/microblink/geometry/Point;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_operatorPlusEquals_Lcom_microblink_geometry_Point_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "operatorPlusEquals", "(Lcom/microblink/geometry/Point;)V"), __args);
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
			global::Com.Microblink.Geometry.Point __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Point']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
