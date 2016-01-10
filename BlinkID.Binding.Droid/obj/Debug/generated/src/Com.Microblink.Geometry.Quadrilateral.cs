using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Geometry {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']"
	[global::Android.Runtime.Register ("com/microblink/geometry/Quadrilateral", DoNotGenerateAcw=true)]
	public partial class Quadrilateral : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/microblink/geometry/Quadrilateral", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Quadrilateral); }
		}

		protected Quadrilateral (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFFFFFFI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/constructor[@name='Quadrilateral' and count(parameter)=9 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float'] and parameter[9][@type='int']]"
		[Register (".ctor", "(FFFFFFFFI)V", "")]
		public unsafe Quadrilateral (float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, int p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				if (GetType () != typeof (Quadrilateral)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFFFFFFI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(FFFFFFFFI)V", __args);
					return;
				}

				if (id_ctor_FFFFFFFFI == IntPtr.Zero)
					id_ctor_FFFFFFFFI = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFFFFFI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFFFFFI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_FFFFFFFFI, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/constructor[@name='Quadrilateral' and count(parameter)=4 and parameter[1][@type='com.microblink.geometry.Point'] and parameter[2][@type='com.microblink.geometry.Point'] and parameter[3][@type='com.microblink.geometry.Point'] and parameter[4][@type='com.microblink.geometry.Point']]"
		[Register (".ctor", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;)V", "")]
		public unsafe Quadrilateral (global::Com.Microblink.Geometry.Point p0, global::Com.Microblink.Geometry.Point p1, global::Com.Microblink.Geometry.Point p2, global::Com.Microblink.Geometry.Point p3)
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
				if (GetType () != typeof (Quadrilateral)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_ == IntPtr.Zero)
					id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/constructor[@name='Quadrilateral' and count(parameter)=5 and parameter[1][@type='com.microblink.geometry.Point'] and parameter[2][@type='com.microblink.geometry.Point'] and parameter[3][@type='com.microblink.geometry.Point'] and parameter[4][@type='com.microblink.geometry.Point'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;I)V", "")]
		public unsafe Quadrilateral (global::Com.Microblink.Geometry.Point p0, global::Com.Microblink.Geometry.Point p1, global::Com.Microblink.Geometry.Point p2, global::Com.Microblink.Geometry.Point p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (Quadrilateral)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_I == IntPtr.Zero)
					id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IIIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/constructor[@name='Quadrilateral' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(IIIII)V", "")]
		public unsafe Quadrilateral (int p0, int p1, int p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (Quadrilateral)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIIII)V", __args);
					return;
				}

				if (id_ctor_IIIII == IntPtr.Zero)
					id_ctor_IIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIII, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/constructor[@name='Quadrilateral' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Quadrilateral ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Quadrilateral)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/constructor[@name='Quadrilateral' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe Quadrilateral (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Quadrilateral)) {
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

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		static IntPtr id_setColor_I;
		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDefaultQuad;
#pragma warning disable 0169
		static Delegate GetIsDefaultQuadHandler ()
		{
			if (cb_isDefaultQuad == null)
				cb_isDefaultQuad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDefaultQuad);
			return cb_isDefaultQuad;
		}

		static bool n_IsDefaultQuad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDefaultQuad;
		}
#pragma warning restore 0169

		static Delegate cb_setIsDefaultQuad_Z;
#pragma warning disable 0169
		static Delegate GetSetIsDefaultQuad_ZHandler ()
		{
			if (cb_setIsDefaultQuad_Z == null)
				cb_setIsDefaultQuad_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsDefaultQuad_Z);
			return cb_setIsDefaultQuad_Z;
		}

		static void n_SetIsDefaultQuad_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsDefaultQuad = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDefaultQuad;
		static IntPtr id_setIsDefaultQuad_Z;
		public virtual unsafe bool IsDefaultQuad {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='isDefaultQuad' and count(parameter)=0]"
			[Register ("isDefaultQuad", "()Z", "GetIsDefaultQuadHandler")]
			get {
				if (id_isDefaultQuad == IntPtr.Zero)
					id_isDefaultQuad = JNIEnv.GetMethodID (class_ref, "isDefaultQuad", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDefaultQuad);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDefaultQuad", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='setIsDefaultQuad' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsDefaultQuad", "(Z)V", "GetSetIsDefaultQuad_ZHandler")]
			set {
				if (id_setIsDefaultQuad_Z == IntPtr.Zero)
					id_setIsDefaultQuad_Z = JNIEnv.GetMethodID (class_ref, "setIsDefaultQuad", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIsDefaultQuad_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsDefaultQuad", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLowerLeft;
#pragma warning disable 0169
		static Delegate GetGetLowerLeftHandler ()
		{
			if (cb_getLowerLeft == null)
				cb_getLowerLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLowerLeft);
			return cb_getLowerLeft;
		}

		static IntPtr n_GetLowerLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LowerLeft);
		}
#pragma warning restore 0169

		static IntPtr id_getLowerLeft;
		public virtual unsafe global::Com.Microblink.Geometry.Point LowerLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getLowerLeft' and count(parameter)=0]"
			[Register ("getLowerLeft", "()Lcom/microblink/geometry/Point;", "GetGetLowerLeftHandler")]
			get {
				if (id_getLowerLeft == IntPtr.Zero)
					id_getLowerLeft = JNIEnv.GetMethodID (class_ref, "getLowerLeft", "()Lcom/microblink/geometry/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_getLowerLeft), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLowerLeft", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLowerRight;
#pragma warning disable 0169
		static Delegate GetGetLowerRightHandler ()
		{
			if (cb_getLowerRight == null)
				cb_getLowerRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLowerRight);
			return cb_getLowerRight;
		}

		static IntPtr n_GetLowerRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LowerRight);
		}
#pragma warning restore 0169

		static IntPtr id_getLowerRight;
		public virtual unsafe global::Com.Microblink.Geometry.Point LowerRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getLowerRight' and count(parameter)=0]"
			[Register ("getLowerRight", "()Lcom/microblink/geometry/Point;", "GetGetLowerRightHandler")]
			get {
				if (id_getLowerRight == IntPtr.Zero)
					id_getLowerRight = JNIEnv.GetMethodID (class_ref, "getLowerRight", "()Lcom/microblink/geometry/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_getLowerRight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLowerRight", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRealLowerLeft;
#pragma warning disable 0169
		static Delegate GetGetRealLowerLeftHandler ()
		{
			if (cb_getRealLowerLeft == null)
				cb_getRealLowerLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRealLowerLeft);
			return cb_getRealLowerLeft;
		}

		static IntPtr n_GetRealLowerLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RealLowerLeft);
		}
#pragma warning restore 0169

		static IntPtr id_getRealLowerLeft;
		public virtual unsafe global::Com.Microblink.Geometry.Point RealLowerLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getRealLowerLeft' and count(parameter)=0]"
			[Register ("getRealLowerLeft", "()Lcom/microblink/geometry/Point;", "GetGetRealLowerLeftHandler")]
			get {
				if (id_getRealLowerLeft == IntPtr.Zero)
					id_getRealLowerLeft = JNIEnv.GetMethodID (class_ref, "getRealLowerLeft", "()Lcom/microblink/geometry/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_getRealLowerLeft), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRealLowerLeft", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRealLowerRight;
#pragma warning disable 0169
		static Delegate GetGetRealLowerRightHandler ()
		{
			if (cb_getRealLowerRight == null)
				cb_getRealLowerRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRealLowerRight);
			return cb_getRealLowerRight;
		}

		static IntPtr n_GetRealLowerRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RealLowerRight);
		}
#pragma warning restore 0169

		static IntPtr id_getRealLowerRight;
		public virtual unsafe global::Com.Microblink.Geometry.Point RealLowerRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getRealLowerRight' and count(parameter)=0]"
			[Register ("getRealLowerRight", "()Lcom/microblink/geometry/Point;", "GetGetRealLowerRightHandler")]
			get {
				if (id_getRealLowerRight == IntPtr.Zero)
					id_getRealLowerRight = JNIEnv.GetMethodID (class_ref, "getRealLowerRight", "()Lcom/microblink/geometry/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_getRealLowerRight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRealLowerRight", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRealUpperLeft;
#pragma warning disable 0169
		static Delegate GetGetRealUpperLeftHandler ()
		{
			if (cb_getRealUpperLeft == null)
				cb_getRealUpperLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRealUpperLeft);
			return cb_getRealUpperLeft;
		}

		static IntPtr n_GetRealUpperLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RealUpperLeft);
		}
#pragma warning restore 0169

		static IntPtr id_getRealUpperLeft;
		public virtual unsafe global::Com.Microblink.Geometry.Point RealUpperLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getRealUpperLeft' and count(parameter)=0]"
			[Register ("getRealUpperLeft", "()Lcom/microblink/geometry/Point;", "GetGetRealUpperLeftHandler")]
			get {
				if (id_getRealUpperLeft == IntPtr.Zero)
					id_getRealUpperLeft = JNIEnv.GetMethodID (class_ref, "getRealUpperLeft", "()Lcom/microblink/geometry/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_getRealUpperLeft), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRealUpperLeft", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRealUpperLeftIndex;
#pragma warning disable 0169
		static Delegate GetGetRealUpperLeftIndexHandler ()
		{
			if (cb_getRealUpperLeftIndex == null)
				cb_getRealUpperLeftIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRealUpperLeftIndex);
			return cb_getRealUpperLeftIndex;
		}

		static int n_GetRealUpperLeftIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RealUpperLeftIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setRealUpperLeftIndex_I;
#pragma warning disable 0169
		static Delegate GetSetRealUpperLeftIndex_IHandler ()
		{
			if (cb_setRealUpperLeftIndex_I == null)
				cb_setRealUpperLeftIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRealUpperLeftIndex_I);
			return cb_setRealUpperLeftIndex_I;
		}

		static void n_SetRealUpperLeftIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RealUpperLeftIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRealUpperLeftIndex;
		static IntPtr id_setRealUpperLeftIndex_I;
		public virtual unsafe int RealUpperLeftIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getRealUpperLeftIndex' and count(parameter)=0]"
			[Register ("getRealUpperLeftIndex", "()I", "GetGetRealUpperLeftIndexHandler")]
			get {
				if (id_getRealUpperLeftIndex == IntPtr.Zero)
					id_getRealUpperLeftIndex = JNIEnv.GetMethodID (class_ref, "getRealUpperLeftIndex", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRealUpperLeftIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRealUpperLeftIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='setRealUpperLeftIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRealUpperLeftIndex", "(I)V", "GetSetRealUpperLeftIndex_IHandler")]
			set {
				if (id_setRealUpperLeftIndex_I == IntPtr.Zero)
					id_setRealUpperLeftIndex_I = JNIEnv.GetMethodID (class_ref, "setRealUpperLeftIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRealUpperLeftIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRealUpperLeftIndex", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRealUpperRight;
#pragma warning disable 0169
		static Delegate GetGetRealUpperRightHandler ()
		{
			if (cb_getRealUpperRight == null)
				cb_getRealUpperRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRealUpperRight);
			return cb_getRealUpperRight;
		}

		static IntPtr n_GetRealUpperRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RealUpperRight);
		}
#pragma warning restore 0169

		static IntPtr id_getRealUpperRight;
		public virtual unsafe global::Com.Microblink.Geometry.Point RealUpperRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getRealUpperRight' and count(parameter)=0]"
			[Register ("getRealUpperRight", "()Lcom/microblink/geometry/Point;", "GetGetRealUpperRightHandler")]
			get {
				if (id_getRealUpperRight == IntPtr.Zero)
					id_getRealUpperRight = JNIEnv.GetMethodID (class_ref, "getRealUpperRight", "()Lcom/microblink/geometry/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_getRealUpperRight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRealUpperRight", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpperLeft;
#pragma warning disable 0169
		static Delegate GetGetUpperLeftHandler ()
		{
			if (cb_getUpperLeft == null)
				cb_getUpperLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpperLeft);
			return cb_getUpperLeft;
		}

		static IntPtr n_GetUpperLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UpperLeft);
		}
#pragma warning restore 0169

		static IntPtr id_getUpperLeft;
		public virtual unsafe global::Com.Microblink.Geometry.Point UpperLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getUpperLeft' and count(parameter)=0]"
			[Register ("getUpperLeft", "()Lcom/microblink/geometry/Point;", "GetGetUpperLeftHandler")]
			get {
				if (id_getUpperLeft == IntPtr.Zero)
					id_getUpperLeft = JNIEnv.GetMethodID (class_ref, "getUpperLeft", "()Lcom/microblink/geometry/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_getUpperLeft), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpperLeft", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpperRight;
#pragma warning disable 0169
		static Delegate GetGetUpperRightHandler ()
		{
			if (cb_getUpperRight == null)
				cb_getUpperRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpperRight);
			return cb_getUpperRight;
		}

		static IntPtr n_GetUpperRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UpperRight);
		}
#pragma warning restore 0169

		static IntPtr id_getUpperRight;
		public virtual unsafe global::Com.Microblink.Geometry.Point UpperRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='getUpperRight' and count(parameter)=0]"
			[Register ("getUpperRight", "()Lcom/microblink/geometry/Point;", "GetGetUpperRightHandler")]
			get {
				if (id_getUpperRight == IntPtr.Zero)
					id_getUpperRight = JNIEnv.GetMethodID (class_ref, "getUpperRight", "()Lcom/microblink/geometry/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallObjectMethod  (Handle, id_getUpperRight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpperRight", "()Lcom/microblink/geometry/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/microblink/geometry/Quadrilateral;", "GetCloneHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Quadrilateral Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/microblink/geometry/Quadrilateral;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/microblink/geometry/Quadrilateral;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_fromPointsAndCanvasSize_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_IIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='fromPointsAndCanvasSize' and count(parameter)=8 and parameter[1][@type='com.microblink.geometry.Point'] and parameter[2][@type='com.microblink.geometry.Point'] and parameter[3][@type='com.microblink.geometry.Point'] and parameter[4][@type='com.microblink.geometry.Point'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='boolean']]"
		[Register ("fromPointsAndCanvasSize", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;IIIZ)Lcom/microblink/geometry/Quadrilateral;", "")]
		public static unsafe global::Com.Microblink.Geometry.Quadrilateral FromPointsAndCanvasSize (global::Com.Microblink.Geometry.Point p0, global::Com.Microblink.Geometry.Point p1, global::Com.Microblink.Geometry.Point p2, global::Com.Microblink.Geometry.Point p3, int p4, int p5, int p6, bool p7)
		{
			if (id_fromPointsAndCanvasSize_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_IIIZ == IntPtr.Zero)
				id_fromPointsAndCanvasSize_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_IIIZ = JNIEnv.GetStaticMethodID (class_ref, "fromPointsAndCanvasSize", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;IIIZ)Lcom/microblink/geometry/Quadrilateral;");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				global::Com.Microblink.Geometry.Quadrilateral __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromPointsAndCanvasSize_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_IIIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_matchesMargins_IIIII;
#pragma warning disable 0169
		static Delegate GetMatchesMargins_IIIIIHandler ()
		{
			if (cb_matchesMargins_IIIII == null)
				cb_matchesMargins_IIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, bool>) n_MatchesMargins_IIIII);
			return cb_matchesMargins_IIIII;
		}

		static bool n_MatchesMargins_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MatchesMargins (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_matchesMargins_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='matchesMargins' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("matchesMargins", "(IIIII)Z", "GetMatchesMargins_IIIIIHandler")]
		public virtual unsafe bool MatchesMargins (int p0, int p1, int p2, int p3, int p4)
		{
			if (id_matchesMargins_IIIII == IntPtr.Zero)
				id_matchesMargins_IIIII = JNIEnv.GetMethodID (class_ref, "matchesMargins", "(IIIII)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_matchesMargins_IIIII, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "matchesMargins", "(IIIII)Z"), __args);
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
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mirror (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_mirror_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='mirror' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

		static Delegate cb_setMargins_IIIII;
#pragma warning disable 0169
		static Delegate GetSetMargins_IIIIIHandler ()
		{
			if (cb_setMargins_IIIII == null)
				cb_setMargins_IIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, int>) n_SetMargins_IIIII);
			return cb_setMargins_IIIII;
		}

		static void n_SetMargins_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMargins (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_setMargins_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='setMargins' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setMargins", "(IIIII)V", "GetSetMargins_IIIIIHandler")]
		public virtual unsafe void SetMargins (int p0, int p1, int p2, int p3, int p4)
		{
			if (id_setMargins_IIIII == IntPtr.Zero)
				id_setMargins_IIIII = JNIEnv.GetMethodID (class_ref, "setMargins", "(IIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMargins_IIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMargins", "(IIIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_;
#pragma warning disable 0169
		static Delegate GetSetPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Handler ()
		{
			if (cb_setPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_ == null)
				cb_setPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_);
			return cb_setPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_;
		}

		static void n_SetPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p1 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p2 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.Point p3 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Point> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetPoints (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='setPoints' and count(parameter)=4 and parameter[1][@type='com.microblink.geometry.Point'] and parameter[2][@type='com.microblink.geometry.Point'] and parameter[3][@type='com.microblink.geometry.Point'] and parameter[4][@type='com.microblink.geometry.Point']]"
		[Register ("setPoints", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;)V", "GetSetPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Handler")]
		public virtual unsafe void SetPoints (global::Com.Microblink.Geometry.Point p0, global::Com.Microblink.Geometry.Point p1, global::Com.Microblink.Geometry.Point p2, global::Com.Microblink.Geometry.Point p3)
		{
			if (id_setPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_ == IntPtr.Zero)
				id_setPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPoints_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_Lcom_microblink_geometry_Point_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoints", "(Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;Lcom/microblink/geometry/Point;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sortedQuad;
#pragma warning disable 0169
		static Delegate GetSortedQuadHandler ()
		{
			if (cb_sortedQuad == null)
				cb_sortedQuad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SortedQuad);
			return cb_sortedQuad;
		}

		static IntPtr n_SortedQuad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SortedQuad ());
		}
#pragma warning restore 0169

		static IntPtr id_sortedQuad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='sortedQuad' and count(parameter)=0]"
		[Register ("sortedQuad", "()Lcom/microblink/geometry/Quadrilateral;", "GetSortedQuadHandler")]
		public virtual unsafe global::Com.Microblink.Geometry.Quadrilateral SortedQuad ()
		{
			if (id_sortedQuad == IntPtr.Zero)
				id_sortedQuad = JNIEnv.GetMethodID (class_ref, "sortedQuad", "()Lcom/microblink/geometry/Quadrilateral;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallObjectMethod  (Handle, id_sortedQuad), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sortedQuad", "()Lcom/microblink/geometry/Quadrilateral;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Microblink.Geometry.Quadrilateral __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Quadrilateral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.geometry']/class[@name='Quadrilateral']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
