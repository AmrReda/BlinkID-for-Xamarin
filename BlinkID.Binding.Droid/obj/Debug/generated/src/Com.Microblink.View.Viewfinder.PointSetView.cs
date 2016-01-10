using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.Viewfinder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView']"
	[global::Android.Runtime.Register ("com/microblink/view/viewfinder/PointSetView", DoNotGenerateAcw=true)]
	public partial class PointSetView : global::Android.Views.View {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView.IlIllIlIIl']"
		[global::Android.Runtime.Register ("com/microblink/view/viewfinder/PointSetView$IlIllIlIIl", DoNotGenerateAcw=true)]
		public partial class IlIllIlIIl : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/viewfinder/PointSetView$IlIllIlIIl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IlIllIlIIl); }
			}

			protected IlIllIlIIl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_evaluate_FLjava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView.IlIllIlIIl']/method[@name='evaluate' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
			[Register ("evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
			public unsafe global::Java.Lang.Object Evaluate (float p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
			{
				if (id_evaluate_FLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_evaluate_FLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_evaluate_FLjava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView.llIIlIlIIl']"
		[global::Android.Runtime.Register ("com/microblink/view/viewfinder/PointSetView$llIIlIlIIl", DoNotGenerateAcw=true)]
		public partial class LlIIlIlIIl : global::Java.Lang.Object {


			static IntPtr IIIlllIIll_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView.llIIlIlIIl']/field[@name='IIIlllIIll']"
			[Register ("IIIlllIIll")]
			public int IIIlllIIll {
				get {
					if (IIIlllIIll_jfieldId == IntPtr.Zero)
						IIIlllIIll_jfieldId = JNIEnv.GetFieldID (class_ref, "IIIlllIIll", "I");
					return JNIEnv.GetIntField (Handle, IIIlllIIll_jfieldId);
				}
				set {
					if (IIIlllIIll_jfieldId == IntPtr.Zero)
						IIIlllIIll_jfieldId = JNIEnv.GetFieldID (class_ref, "IIIlllIIll", "I");
					try {
						JNIEnv.SetField (Handle, IIIlllIIll_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr IllllIlIIl_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView.llIIlIlIIl']/field[@name='IllllIlIIl']"
			[Register ("IllllIlIIl")]
			public int IllllIlIIl {
				get {
					if (IllllIlIIl_jfieldId == IntPtr.Zero)
						IllllIlIIl_jfieldId = JNIEnv.GetFieldID (class_ref, "IllllIlIIl", "I");
					return JNIEnv.GetIntField (Handle, IllllIlIIl_jfieldId);
				}
				set {
					if (IllllIlIIl_jfieldId == IntPtr.Zero)
						IllllIlIIl_jfieldId = JNIEnv.GetFieldID (class_ref, "IllllIlIIl", "I");
					try {
						JNIEnv.SetField (Handle, IllllIlIIl_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/viewfinder/PointSetView$llIIlIlIIl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LlIIlIlIIl); }
			}

			protected LlIIlIlIIl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_microblink_view_viewfinder_PointSetView_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView.llIIlIlIIl']/constructor[@name='PointSetView.llIIlIlIIl' and count(parameter)=3 and parameter[1][@type='com.microblink.view.viewfinder.PointSetView'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lcom/microblink/view/viewfinder/PointSetView;II)V", "")]
			public unsafe LlIIlIlIIl (global::Com.Microblink.View.Viewfinder.PointSetView __self, int p1, int p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (LlIIlIlIIl)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", __args);
						return;
					}

					if (id_ctor_Lcom_microblink_view_viewfinder_PointSetView_II == IntPtr.Zero)
						id_ctor_Lcom_microblink_view_viewfinder_PointSetView_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/viewfinder/PointSetView;II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_viewfinder_PointSetView_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_viewfinder_PointSetView_II, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/viewfinder/PointSetView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PointSetView); }
		}

		protected PointSetView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView']/constructor[@name='PointSetView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PointSetView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PointSetView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static Delegate cb_isAnimationInProgress;
#pragma warning disable 0169
		static Delegate GetIsAnimationInProgressHandler ()
		{
			if (cb_isAnimationInProgress == null)
				cb_isAnimationInProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimationInProgress);
			return cb_isAnimationInProgress;
		}

		static bool n_IsAnimationInProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.Viewfinder.PointSetView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.PointSetView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimationInProgress;
		}
#pragma warning restore 0169

		static IntPtr id_isAnimationInProgress;
		public virtual unsafe bool IsAnimationInProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView']/method[@name='isAnimationInProgress' and count(parameter)=0]"
			[Register ("isAnimationInProgress", "()Z", "GetIsAnimationInProgressHandler")]
			get {
				if (id_isAnimationInProgress == IntPtr.Zero)
					id_isAnimationInProgress = JNIEnv.GetMethodID (class_ref, "isAnimationInProgress", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAnimationInProgress);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnimationInProgress", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_setPointSet_Lcom_microblink_geometry_PointSet_;
#pragma warning disable 0169
		static Delegate GetSetPointSet_Lcom_microblink_geometry_PointSet_Handler ()
		{
			if (cb_setPointSet_Lcom_microblink_geometry_PointSet_ == null)
				cb_setPointSet_Lcom_microblink_geometry_PointSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPointSet_Lcom_microblink_geometry_PointSet_);
			return cb_setPointSet_Lcom_microblink_geometry_PointSet_;
		}

		static void n_SetPointSet_Lcom_microblink_geometry_PointSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.Viewfinder.PointSetView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.Viewfinder.PointSetView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Geometry.PointSet p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.PointSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPointSet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPointSet_Lcom_microblink_geometry_PointSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.viewfinder']/class[@name='PointSetView']/method[@name='setPointSet' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.PointSet']]"
		[Register ("setPointSet", "(Lcom/microblink/geometry/PointSet;)V", "GetSetPointSet_Lcom_microblink_geometry_PointSet_Handler")]
		public virtual unsafe void SetPointSet (global::Com.Microblink.Geometry.PointSet p0)
		{
			if (id_setPointSet_Lcom_microblink_geometry_PointSet_ == IntPtr.Zero)
				id_setPointSet_Lcom_microblink_geometry_PointSet_ = JNIEnv.GetMethodID (class_ref, "setPointSet", "(Lcom/microblink/geometry/PointSet;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPointSet_Lcom_microblink_geometry_PointSet_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPointSet", "(Lcom/microblink/geometry/PointSet;)V"), __args);
			} finally {
			}
		}

	}
}
