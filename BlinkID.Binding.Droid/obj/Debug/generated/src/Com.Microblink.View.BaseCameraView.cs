using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']"
	[global::Android.Runtime.Register ("com/microblink/view/BaseCameraView", DoNotGenerateAcw=true)]
	public abstract partial class BaseCameraView : global::Android.Views.ViewGroup {


		static IntPtr mCameraEventsListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/field[@name='mCameraEventsListener']"
		[Register ("mCameraEventsListener")]
		public global::Com.Microblink.View.ICameraEventsListener MCameraEventsListener {
			get {
				if (mCameraEventsListener_jfieldId == IntPtr.Zero)
					mCameraEventsListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraEventsListener", "Lcom/microblink/view/CameraEventsListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCameraEventsListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCameraEventsListener_jfieldId == IntPtr.Zero)
					mCameraEventsListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraEventsListener", "Lcom/microblink/view/CameraEventsListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mCameraEventsListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCameraViewState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/field[@name='mCameraViewState']"
		[Register ("mCameraViewState")]
		public global::Com.Microblink.View.BaseCameraView.CameraViewState MCameraViewState {
			get {
				if (mCameraViewState_jfieldId == IntPtr.Zero)
					mCameraViewState_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraViewState", "Lcom/microblink/view/BaseCameraView$CameraViewState;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCameraViewState_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.CameraViewState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCameraViewState_jfieldId == IntPtr.Zero)
					mCameraViewState_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraViewState", "Lcom/microblink/view/BaseCameraView$CameraViewState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mCameraViewState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mErrorState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/field[@name='mErrorState']"
		[Register ("mErrorState")]
		public bool MErrorState {
			get {
				if (mErrorState_jfieldId == IntPtr.Zero)
					mErrorState_jfieldId = JNIEnv.GetFieldID (class_ref, "mErrorState", "Z");
				return JNIEnv.GetBooleanField (Handle, mErrorState_jfieldId);
			}
			set {
				if (mErrorState_jfieldId == IntPtr.Zero)
					mErrorState_jfieldId = JNIEnv.GetFieldID (class_ref, "mErrorState", "Z");
				try {
					JNIEnv.SetField (Handle, mErrorState_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraListener']"
		[global::Android.Runtime.Register ("com/microblink/view/BaseCameraView$BaseCameraListener", DoNotGenerateAcw=true)]
		public abstract partial class BaseCameraListener : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/BaseCameraView$BaseCameraListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseCameraListener); }
			}

			protected BaseCameraListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_microblink_view_BaseCameraView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraListener']/constructor[@name='BaseCameraView.BaseCameraListener' and count(parameter)=1 and parameter[1][@type='com.microblink.view.BaseCameraView']]"
			[Register (".ctor", "(Lcom/microblink/view/BaseCameraView;)V", "")]
			public unsafe BaseCameraListener (global::Com.Microblink.View.BaseCameraView __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (BaseCameraListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_microblink_view_BaseCameraView_ == IntPtr.Zero)
						id_ctor_Lcom_microblink_view_BaseCameraView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/BaseCameraView;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_BaseCameraView_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_BaseCameraView_, __args);
				} finally {
				}
			}

			static IntPtr id_onAutofocusFailed;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraListener']/method[@name='onAutofocusFailed' and count(parameter)=0]"
			[Register ("onAutofocusFailed", "()V", "")]
			public unsafe void OnAutofocusFailed ()
			{
				if (id_onAutofocusFailed == IntPtr.Zero)
					id_onAutofocusFailed = JNIEnv.GetMethodID (class_ref, "onAutofocusFailed", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_onAutofocusFailed);
				} finally {
				}
			}

			static IntPtr id_onAutofocusStarted_arrayLandroid_graphics_Rect_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraListener']/method[@name='onAutofocusStarted' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect[]']]"
			[Register ("onAutofocusStarted", "([Landroid/graphics/Rect;)V", "")]
			public unsafe void OnAutofocusStarted (global::Android.Graphics.Rect[] p0)
			{
				if (id_onAutofocusStarted_arrayLandroid_graphics_Rect_ == IntPtr.Zero)
					id_onAutofocusStarted_arrayLandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onAutofocusStarted", "([Landroid/graphics/Rect;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod  (Handle, id_onAutofocusStarted_arrayLandroid_graphics_Rect_, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_onAutofocusStopped_arrayLandroid_graphics_Rect_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraListener']/method[@name='onAutofocusStopped' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect[]']]"
			[Register ("onAutofocusStopped", "([Landroid/graphics/Rect;)V", "")]
			public unsafe void OnAutofocusStopped (global::Android.Graphics.Rect[] p0)
			{
				if (id_onAutofocusStopped_arrayLandroid_graphics_Rect_ == IntPtr.Zero)
					id_onAutofocusStopped_arrayLandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onAutofocusStopped", "([Landroid/graphics/Rect;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod  (Handle, id_onAutofocusStopped_arrayLandroid_graphics_Rect_, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		[global::Android.Runtime.Register ("com/microblink/view/BaseCameraView$BaseCameraListener", DoNotGenerateAcw=true)]
		internal partial class BaseCameraListenerInvoker : BaseCameraListener {

			public BaseCameraListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseCameraListenerInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraViewEventsListener']"
		[global::Android.Runtime.Register ("com/microblink/view/BaseCameraView$BaseCameraViewEventsListener", DoNotGenerateAcw=true)]
		public partial class BaseCameraViewEventsListener : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/BaseCameraView$BaseCameraViewEventsListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseCameraViewEventsListener); }
			}

			protected BaseCameraViewEventsListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_microblink_view_BaseCameraView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraViewEventsListener']/constructor[@name='BaseCameraView.BaseCameraViewEventsListener' and count(parameter)=1 and parameter[1][@type='com.microblink.view.BaseCameraView']]"
			[Register (".ctor", "(Lcom/microblink/view/BaseCameraView;)V", "")]
			protected unsafe BaseCameraViewEventsListener (global::Com.Microblink.View.BaseCameraView __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (BaseCameraViewEventsListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_microblink_view_BaseCameraView_ == IntPtr.Zero)
						id_ctor_Lcom_microblink_view_BaseCameraView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/BaseCameraView;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_BaseCameraView_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_BaseCameraView_, __args);
				} finally {
				}
			}

			static Delegate cb_onCameraPinchEvent_F;
#pragma warning disable 0169
			static Delegate GetOnCameraPinchEvent_FHandler ()
			{
				if (cb_onCameraPinchEvent_F == null)
					cb_onCameraPinchEvent_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnCameraPinchEvent_F);
				return cb_onCameraPinchEvent_F;
			}

			static void n_OnCameraPinchEvent_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Microblink.View.BaseCameraView.BaseCameraViewEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.BaseCameraViewEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraPinchEvent (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCameraPinchEvent_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraViewEventsListener']/method[@name='onCameraPinchEvent' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("onCameraPinchEvent", "(F)V", "GetOnCameraPinchEvent_FHandler")]
			public virtual unsafe void OnCameraPinchEvent (float p0)
			{
				if (id_onCameraPinchEvent_F == IntPtr.Zero)
					id_onCameraPinchEvent_F = JNIEnv.GetMethodID (class_ref, "onCameraPinchEvent", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCameraPinchEvent_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraPinchEvent", "(F)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCameraTapEvent_FF;
#pragma warning disable 0169
			static Delegate GetOnCameraTapEvent_FFHandler ()
			{
				if (cb_onCameraTapEvent_FF == null)
					cb_onCameraTapEvent_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_OnCameraTapEvent_FF);
				return cb_onCameraTapEvent_FF;
			}

			static void n_OnCameraTapEvent_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
			{
				global::Com.Microblink.View.BaseCameraView.BaseCameraViewEventsListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.BaseCameraViewEventsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraTapEvent (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onCameraTapEvent_FF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseCameraViewEventsListener']/method[@name='onCameraTapEvent' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("onCameraTapEvent", "(FF)V", "GetOnCameraTapEvent_FFHandler")]
			public virtual unsafe void OnCameraTapEvent (float p0, float p1)
			{
				if (id_onCameraTapEvent_FF == IntPtr.Zero)
					id_onCameraTapEvent_FF = JNIEnv.GetMethodID (class_ref, "onCameraTapEvent", "(FF)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCameraTapEvent_FF, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraTapEvent", "(FF)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseOrientationChangeListener']"
		[global::Android.Runtime.Register ("com/microblink/view/BaseCameraView$BaseOrientationChangeListener", DoNotGenerateAcw=true)]
		public partial class BaseOrientationChangeListener : global::Java.Lang.Object, global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/BaseCameraView$BaseOrientationChangeListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseOrientationChangeListener); }
			}

			protected BaseOrientationChangeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_microblink_view_BaseCameraView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseOrientationChangeListener']/constructor[@name='BaseCameraView.BaseOrientationChangeListener' and count(parameter)=1 and parameter[1][@type='com.microblink.view.BaseCameraView']]"
			[Register (".ctor", "(Lcom/microblink/view/BaseCameraView;)V", "")]
			public unsafe BaseOrientationChangeListener (global::Com.Microblink.View.BaseCameraView __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (BaseOrientationChangeListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_microblink_view_BaseCameraView_ == IntPtr.Zero)
						id_ctor_Lcom_microblink_view_BaseCameraView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/microblink/view/BaseCameraView;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_microblink_view_BaseCameraView_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_microblink_view_BaseCameraView_, __args);
				} finally {
				}
			}

			static Delegate cb_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_;
#pragma warning disable 0169
			static Delegate GetOnOrientationChange_Lcom_microblink_hardware_orientation_Orientation_Handler ()
			{
				if (cb_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ == null)
					cb_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOrientationChange_Lcom_microblink_hardware_orientation_Orientation_);
				return cb_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_;
			}

			static void n_OnOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Microblink.View.BaseCameraView.BaseOrientationChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.BaseOrientationChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Microblink.Hardware.Orientation.Orientation p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnOrientationChange (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.BaseOrientationChangeListener']/method[@name='onOrientationChange' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
			[Register ("onOrientationChange", "(Lcom/microblink/hardware/orientation/Orientation;)V", "GetOnOrientationChange_Lcom_microblink_hardware_orientation_Orientation_Handler")]
			public virtual unsafe void OnOrientationChange (global::Com.Microblink.Hardware.Orientation.Orientation p0)
			{
				if (id_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
					id_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "onOrientationChange", "(Lcom/microblink/hardware/orientation/Orientation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onOrientationChange_Lcom_microblink_hardware_orientation_Orientation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOrientationChange", "(Lcom/microblink/hardware/orientation/Orientation;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.CameraViewState']"
		[global::Android.Runtime.Register ("com/microblink/view/BaseCameraView$CameraViewState", DoNotGenerateAcw=true)]
		public sealed partial class CameraViewState : global::Java.Lang.Enum {


			static IntPtr CREATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.CameraViewState']/field[@name='CREATED']"
			[Register ("CREATED")]
			public static global::Com.Microblink.View.BaseCameraView.CameraViewState Created {
				get {
					if (CREATED_jfieldId == IntPtr.Zero)
						CREATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATED", "Lcom/microblink/view/BaseCameraView$CameraViewState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.CameraViewState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DESTROYED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.CameraViewState']/field[@name='DESTROYED']"
			[Register ("DESTROYED")]
			public static global::Com.Microblink.View.BaseCameraView.CameraViewState Destroyed {
				get {
					if (DESTROYED_jfieldId == IntPtr.Zero)
						DESTROYED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DESTROYED", "Lcom/microblink/view/BaseCameraView$CameraViewState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DESTROYED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.CameraViewState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RESUMED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.CameraViewState']/field[@name='RESUMED']"
			[Register ("RESUMED")]
			public static global::Com.Microblink.View.BaseCameraView.CameraViewState Resumed {
				get {
					if (RESUMED_jfieldId == IntPtr.Zero)
						RESUMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESUMED", "Lcom/microblink/view/BaseCameraView$CameraViewState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESUMED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.CameraViewState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.CameraViewState']/field[@name='STARTED']"
			[Register ("STARTED")]
			public static global::Com.Microblink.View.BaseCameraView.CameraViewState Started {
				get {
					if (STARTED_jfieldId == IntPtr.Zero)
						STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/microblink/view/BaseCameraView$CameraViewState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.CameraViewState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/BaseCameraView$CameraViewState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CameraViewState); }
			}

			internal CameraViewState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.CameraViewState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/view/BaseCameraView$CameraViewState;", "")]
			public static unsafe global::Com.Microblink.View.BaseCameraView.CameraViewState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/view/BaseCameraView$CameraViewState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Microblink.View.BaseCameraView.CameraViewState __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.CameraViewState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.CameraViewState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microblink/view/BaseCameraView$CameraViewState;", "")]
			public static unsafe global::Com.Microblink.View.BaseCameraView.CameraViewState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/view/BaseCameraView$CameraViewState;");
				try {
					return (global::Com.Microblink.View.BaseCameraView.CameraViewState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.View.BaseCameraView.CameraViewState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.LayoutParams']"
		[global::Android.Runtime.Register ("com/microblink/view/BaseCameraView$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/BaseCameraView$LayoutParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutParams); }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_ViewGroup_LayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.LayoutParams']/constructor[@name='BaseCameraView.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.LayoutParams p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/ViewGroup$LayoutParams;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/ViewGroup$LayoutParams;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
						id_ctor_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.LayoutParams']/constructor[@name='BaseCameraView.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe LayoutParams (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
						return;
					}

					if (id_ctor_II == IntPtr.Zero)
						id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.LayoutParams']/constructor[@name='BaseCameraView.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (LayoutParams)) {
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

			static Delegate cb_isRotatable;
#pragma warning disable 0169
			static Delegate GetIsRotatableHandler ()
			{
				if (cb_isRotatable == null)
					cb_isRotatable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRotatable);
				return cb_isRotatable;
			}

			static bool n_IsRotatable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Microblink.View.BaseCameraView.LayoutParams __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Rotatable;
			}
#pragma warning restore 0169

			static Delegate cb_setRotatable_Z;
#pragma warning disable 0169
			static Delegate GetSetRotatable_ZHandler ()
			{
				if (cb_setRotatable_Z == null)
					cb_setRotatable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRotatable_Z);
				return cb_setRotatable_Z;
			}

			static void n_SetRotatable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Microblink.View.BaseCameraView.LayoutParams __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Rotatable = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isRotatable;
			static IntPtr id_setRotatable_Z;
			public virtual unsafe bool Rotatable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.LayoutParams']/method[@name='isRotatable' and count(parameter)=0]"
				[Register ("isRotatable", "()Z", "GetIsRotatableHandler")]
				get {
					if (id_isRotatable == IntPtr.Zero)
						id_isRotatable = JNIEnv.GetMethodID (class_ref, "isRotatable", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isRotatable);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRotatable", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView.LayoutParams']/method[@name='setRotatable' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setRotatable", "(Z)V", "GetSetRotatable_ZHandler")]
				set {
					if (id_setRotatable_Z == IntPtr.Zero)
						id_setRotatable_Z = JNIEnv.GetMethodID (class_ref, "setRotatable", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setRotatable_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotatable", "(Z)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/BaseCameraView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCameraView); }
		}

		protected BaseCameraView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/constructor[@name='BaseCameraView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BaseCameraView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BaseCameraView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/constructor[@name='BaseCameraView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BaseCameraView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseCameraView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAspectMode;
#pragma warning disable 0169
		static Delegate GetGetAspectModeHandler ()
		{
			if (cb_getAspectMode == null)
				cb_getAspectMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAspectMode);
			return cb_getAspectMode;
		}

		static IntPtr n_GetAspectMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AspectMode);
		}
#pragma warning restore 0169

		static Delegate cb_setAspectMode_Lcom_microblink_view_CameraAspectMode_;
#pragma warning disable 0169
		static Delegate GetSetAspectMode_Lcom_microblink_view_CameraAspectMode_Handler ()
		{
			if (cb_setAspectMode_Lcom_microblink_view_CameraAspectMode_ == null)
				cb_setAspectMode_Lcom_microblink_view_CameraAspectMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAspectMode_Lcom_microblink_view_CameraAspectMode_);
			return cb_setAspectMode_Lcom_microblink_view_CameraAspectMode_;
		}

		static void n_SetAspectMode_Lcom_microblink_view_CameraAspectMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.CameraAspectMode p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.CameraAspectMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AspectMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAspectMode;
		static IntPtr id_setAspectMode_Lcom_microblink_view_CameraAspectMode_;
		public virtual unsafe global::Com.Microblink.View.CameraAspectMode AspectMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getAspectMode' and count(parameter)=0]"
			[Register ("getAspectMode", "()Lcom/microblink/view/CameraAspectMode;", "GetGetAspectModeHandler")]
			get {
				if (id_getAspectMode == IntPtr.Zero)
					id_getAspectMode = JNIEnv.GetMethodID (class_ref, "getAspectMode", "()Lcom/microblink/view/CameraAspectMode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.CameraAspectMode> (JNIEnv.CallObjectMethod  (Handle, id_getAspectMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.CameraAspectMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAspectMode", "()Lcom/microblink/view/CameraAspectMode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setAspectMode' and count(parameter)=1 and parameter[1][@type='com.microblink.view.CameraAspectMode']]"
			[Register ("setAspectMode", "(Lcom/microblink/view/CameraAspectMode;)V", "GetSetAspectMode_Lcom_microblink_view_CameraAspectMode_Handler")]
			set {
				if (id_setAspectMode_Lcom_microblink_view_CameraAspectMode_ == IntPtr.Zero)
					id_setAspectMode_Lcom_microblink_view_CameraAspectMode_ = JNIEnv.GetMethodID (class_ref, "setAspectMode", "(Lcom/microblink/view/CameraAspectMode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAspectMode_Lcom_microblink_view_CameraAspectMode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAspectMode", "(Lcom/microblink/view/CameraAspectMode;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCameraEventsListener;
#pragma warning disable 0169
		static Delegate GetGetCameraEventsListenerHandler ()
		{
			if (cb_getCameraEventsListener == null)
				cb_getCameraEventsListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraEventsListener);
			return cb_getCameraEventsListener;
		}

		static IntPtr n_GetCameraEventsListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CameraEventsListener);
		}
#pragma warning restore 0169

		static Delegate cb_setCameraEventsListener_Lcom_microblink_view_CameraEventsListener_;
#pragma warning disable 0169
		static Delegate GetSetCameraEventsListener_Lcom_microblink_view_CameraEventsListener_Handler ()
		{
			if (cb_setCameraEventsListener_Lcom_microblink_view_CameraEventsListener_ == null)
				cb_setCameraEventsListener_Lcom_microblink_view_CameraEventsListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCameraEventsListener_Lcom_microblink_view_CameraEventsListener_);
			return cb_setCameraEventsListener_Lcom_microblink_view_CameraEventsListener_;
		}

		static void n_SetCameraEventsListener_Lcom_microblink_view_CameraEventsListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.ICameraEventsListener p0 = (global::Com.Microblink.View.ICameraEventsListener)global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CameraEventsListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCameraEventsListener;
		static IntPtr id_setCameraEventsListener_Lcom_microblink_view_CameraEventsListener_;
		public virtual unsafe global::Com.Microblink.View.ICameraEventsListener CameraEventsListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getCameraEventsListener' and count(parameter)=0]"
			[Register ("getCameraEventsListener", "()Lcom/microblink/view/CameraEventsListener;", "GetGetCameraEventsListenerHandler")]
			get {
				if (id_getCameraEventsListener == IntPtr.Zero)
					id_getCameraEventsListener = JNIEnv.GetMethodID (class_ref, "getCameraEventsListener", "()Lcom/microblink/view/CameraEventsListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (JNIEnv.CallObjectMethod  (Handle, id_getCameraEventsListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.ICameraEventsListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCameraEventsListener", "()Lcom/microblink/view/CameraEventsListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setCameraEventsListener' and count(parameter)=1 and parameter[1][@type='com.microblink.view.CameraEventsListener']]"
			[Register ("setCameraEventsListener", "(Lcom/microblink/view/CameraEventsListener;)V", "GetSetCameraEventsListener_Lcom_microblink_view_CameraEventsListener_Handler")]
			set {
				if (id_setCameraEventsListener_Lcom_microblink_view_CameraEventsListener_ == IntPtr.Zero)
					id_setCameraEventsListener_Lcom_microblink_view_CameraEventsListener_ = JNIEnv.GetMethodID (class_ref, "setCameraEventsListener", "(Lcom/microblink/view/CameraEventsListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCameraEventsListener_Lcom_microblink_view_CameraEventsListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCameraEventsListener", "(Lcom/microblink/view/CameraEventsListener;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getCameraPreviewHeight;
		public unsafe int CameraPreviewHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getCameraPreviewHeight' and count(parameter)=0]"
			[Register ("getCameraPreviewHeight", "()I", "GetGetCameraPreviewHeightHandler")]
			get {
				if (id_getCameraPreviewHeight == IntPtr.Zero)
					id_getCameraPreviewHeight = JNIEnv.GetMethodID (class_ref, "getCameraPreviewHeight", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getCameraPreviewHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getCameraPreviewWidth;
		public unsafe int CameraPreviewWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getCameraPreviewWidth' and count(parameter)=0]"
			[Register ("getCameraPreviewWidth", "()I", "GetGetCameraPreviewWidthHandler")]
			get {
				if (id_getCameraPreviewWidth == IntPtr.Zero)
					id_getCameraPreviewWidth = JNIEnv.GetMethodID (class_ref, "getCameraPreviewWidth", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getCameraPreviewWidth);
				} finally {
				}
			}
		}

		static IntPtr id_getConfigurationOrientation;
		public unsafe int ConfigurationOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getConfigurationOrientation' and count(parameter)=0]"
			[Register ("getConfigurationOrientation", "()I", "GetGetConfigurationOrientationHandler")]
			get {
				if (id_getConfigurationOrientation == IntPtr.Zero)
					id_getConfigurationOrientation = JNIEnv.GetMethodID (class_ref, "getConfigurationOrientation", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getConfigurationOrientation);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentOrientation;
#pragma warning disable 0169
		static Delegate GetGetCurrentOrientationHandler ()
		{
			if (cb_getCurrentOrientation == null)
				cb_getCurrentOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentOrientation);
			return cb_getCurrentOrientation;
		}

		static IntPtr n_GetCurrentOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentOrientation);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentOrientation;
		public virtual unsafe global::Com.Microblink.Hardware.Orientation.Orientation CurrentOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getCurrentOrientation' and count(parameter)=0]"
			[Register ("getCurrentOrientation", "()Lcom/microblink/hardware/orientation/Orientation;", "GetGetCurrentOrientationHandler")]
			get {
				if (id_getCurrentOrientation == IntPtr.Zero)
					id_getCurrentOrientation = JNIEnv.GetMethodID (class_ref, "getCurrentOrientation", "()Lcom/microblink/hardware/orientation/Orientation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentOrientation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentOrientation", "()Lcom/microblink/hardware/orientation/Orientation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHostScreenOrientation;
#pragma warning disable 0169
		static Delegate GetGetHostScreenOrientationHandler ()
		{
			if (cb_getHostScreenOrientation == null)
				cb_getHostScreenOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHostScreenOrientation);
			return cb_getHostScreenOrientation;
		}

		static int n_GetHostScreenOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HostScreenOrientation;
		}
#pragma warning restore 0169

		static IntPtr id_getHostScreenOrientation;
		public virtual unsafe int HostScreenOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getHostScreenOrientation' and count(parameter)=0]"
			[Register ("getHostScreenOrientation", "()I", "GetGetHostScreenOrientationHandler")]
			get {
				if (id_getHostScreenOrientation == IntPtr.Zero)
					id_getHostScreenOrientation = JNIEnv.GetMethodID (class_ref, "getHostScreenOrientation", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHostScreenOrientation);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostScreenOrientation", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_getInitialOrientation;
		static IntPtr id_setInitialOrientation_Lcom_microblink_hardware_orientation_Orientation_;
		public unsafe global::Com.Microblink.Hardware.Orientation.Orientation InitialOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getInitialOrientation' and count(parameter)=0]"
			[Register ("getInitialOrientation", "()Lcom/microblink/hardware/orientation/Orientation;", "GetGetInitialOrientationHandler")]
			get {
				if (id_getInitialOrientation == IntPtr.Zero)
					id_getInitialOrientation = JNIEnv.GetMethodID (class_ref, "getInitialOrientation", "()Lcom/microblink/hardware/orientation/Orientation;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_getInitialOrientation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setInitialOrientation' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
			[Register ("setInitialOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V", "GetSetInitialOrientation_Lcom_microblink_hardware_orientation_Orientation_Handler")]
			set {
				if (id_setInitialOrientation_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
					id_setInitialOrientation_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "setInitialOrientation", "(Lcom/microblink/hardware/orientation/Orientation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setInitialOrientation_Lcom_microblink_hardware_orientation_Orientation_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isCameraActive;
		public unsafe bool IsCameraActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='isCameraActive' and count(parameter)=0]"
			[Register ("isCameraActive", "()Z", "GetIsCameraActiveHandler")]
			get {
				if (id_isCameraActive == IntPtr.Zero)
					id_isCameraActive = JNIEnv.GetMethodID (class_ref, "isCameraActive", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCameraActive);
				} finally {
				}
			}
		}

		static IntPtr id_isCameraFocused;
		public unsafe bool IsCameraFocused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='isCameraFocused' and count(parameter)=0]"
			[Register ("isCameraFocused", "()Z", "GetIsCameraFocusedHandler")]
			get {
				if (id_isCameraFocused == IntPtr.Zero)
					id_isCameraFocused = JNIEnv.GetMethodID (class_ref, "isCameraFocused", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCameraFocused);
				} finally {
				}
			}
		}

		static IntPtr id_isCameraTorchSupported;
		public unsafe bool IsCameraTorchSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='isCameraTorchSupported' and count(parameter)=0]"
			[Register ("isCameraTorchSupported", "()Z", "GetIsCameraTorchSupportedHandler")]
			get {
				if (id_isCameraTorchSupported == IntPtr.Zero)
					id_isCameraTorchSupported = JNIEnv.GetMethodID (class_ref, "isCameraTorchSupported", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCameraTorchSupported);
				} finally {
				}
			}
		}

		static IntPtr id_isDeviceShaking;
		public unsafe bool IsDeviceShaking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='isDeviceShaking' and count(parameter)=0]"
			[Register ("isDeviceShaking", "()Z", "GetIsDeviceShakingHandler")]
			get {
				if (id_isDeviceShaking == IntPtr.Zero)
					id_isDeviceShaking = JNIEnv.GetMethodID (class_ref, "isDeviceShaking", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isDeviceShaking);
				} finally {
				}
			}
		}

		static IntPtr id_getOpenedCameraType;
		public unsafe global::Com.Microblink.Hardware.Camera.CameraType OpenedCameraType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getOpenedCameraType' and count(parameter)=0]"
			[Register ("getOpenedCameraType", "()Lcom/microblink/hardware/camera/CameraType;", "GetGetOpenedCameraTypeHandler")]
			get {
				if (id_getOpenedCameraType == IntPtr.Zero)
					id_getOpenedCameraType = JNIEnv.GetMethodID (class_ref, "getOpenedCameraType", "()Lcom/microblink/hardware/camera/CameraType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.CameraType> (JNIEnv.CallObjectMethod  (Handle, id_getOpenedCameraType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientationChangeListener;
#pragma warning disable 0169
		static Delegate GetGetOrientationChangeListenerHandler ()
		{
			if (cb_getOrientationChangeListener == null)
				cb_getOrientationChangeListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientationChangeListener);
			return cb_getOrientationChangeListener;
		}

		static IntPtr n_GetOrientationChangeListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OrientationChangeListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_Handler ()
		{
			if (cb_setOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_ == null)
				cb_setOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_);
			return cb_setOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_;
		}

		static void n_SetOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener p0 = (global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener)global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OrientationChangeListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientationChangeListener;
		static IntPtr id_setOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_;
		public virtual unsafe global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener OrientationChangeListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getOrientationChangeListener' and count(parameter)=0]"
			[Register ("getOrientationChangeListener", "()Lcom/microblink/hardware/orientation/OrientationChangeListener;", "GetGetOrientationChangeListenerHandler")]
			get {
				if (id_getOrientationChangeListener == IntPtr.Zero)
					id_getOrientationChangeListener = JNIEnv.GetMethodID (class_ref, "getOrientationChangeListener", "()Lcom/microblink/hardware/orientation/OrientationChangeListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener> (JNIEnv.CallObjectMethod  (Handle, id_getOrientationChangeListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientationChangeListener", "()Lcom/microblink/hardware/orientation/OrientationChangeListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setOrientationChangeListener' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.OrientationChangeListener']]"
			[Register ("setOrientationChangeListener", "(Lcom/microblink/hardware/orientation/OrientationChangeListener;)V", "GetSetOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_Handler")]
			set {
				if (id_setOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_ == IntPtr.Zero)
					id_setOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOrientationChangeListener", "(Lcom/microblink/hardware/orientation/OrientationChangeListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOrientationChangeListener_Lcom_microblink_hardware_orientation_OrientationChangeListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientationChangeListener", "(Lcom/microblink/hardware/orientation/OrientationChangeListener;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_isPinchToZoomAllowed;
		static IntPtr id_setPinchToZoomAllowed_Z;
		public unsafe bool PinchToZoomAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='isPinchToZoomAllowed' and count(parameter)=0]"
			[Register ("isPinchToZoomAllowed", "()Z", "GetIsPinchToZoomAllowedHandler")]
			get {
				if (id_isPinchToZoomAllowed == IntPtr.Zero)
					id_isPinchToZoomAllowed = JNIEnv.GetMethodID (class_ref, "isPinchToZoomAllowed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isPinchToZoomAllowed);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setPinchToZoomAllowed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPinchToZoomAllowed", "(Z)V", "GetSetPinchToZoomAllowed_ZHandler")]
			set {
				if (id_setPinchToZoomAllowed_Z == IntPtr.Zero)
					id_setPinchToZoomAllowed_Z = JNIEnv.GetMethodID (class_ref, "setPinchToZoomAllowed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setPinchToZoomAllowed_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getRotationAnimationDuration;
		static IntPtr id_setRotationAnimationDuration_I;
		public unsafe int RotationAnimationDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getRotationAnimationDuration' and count(parameter)=0]"
			[Register ("getRotationAnimationDuration", "()I", "GetGetRotationAnimationDurationHandler")]
			get {
				if (id_getRotationAnimationDuration == IntPtr.Zero)
					id_getRotationAnimationDuration = JNIEnv.GetMethodID (class_ref, "getRotationAnimationDuration", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getRotationAnimationDuration);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setRotationAnimationDuration' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRotationAnimationDuration", "(I)V", "GetSetRotationAnimationDuration_IHandler")]
			set {
				if (id_setRotationAnimationDuration_I == IntPtr.Zero)
					id_setRotationAnimationDuration_I = JNIEnv.GetMethodID (class_ref, "setRotationAnimationDuration", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setRotationAnimationDuration_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isTapToFocusAllowed;
		static IntPtr id_setTapToFocusAllowed_Z;
		public unsafe bool TapToFocusAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='isTapToFocusAllowed' and count(parameter)=0]"
			[Register ("isTapToFocusAllowed", "()Z", "GetIsTapToFocusAllowedHandler")]
			get {
				if (id_isTapToFocusAllowed == IntPtr.Zero)
					id_isTapToFocusAllowed = JNIEnv.GetMethodID (class_ref, "isTapToFocusAllowed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isTapToFocusAllowed);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setTapToFocusAllowed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTapToFocusAllowed", "(Z)V", "GetSetTapToFocusAllowed_ZHandler")]
			set {
				if (id_setTapToFocusAllowed_Z == IntPtr.Zero)
					id_setTapToFocusAllowed_Z = JNIEnv.GetMethodID (class_ref, "setTapToFocusAllowed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setTapToFocusAllowed_Z, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVisiblePart;
#pragma warning disable 0169
		static Delegate GetGetVisiblePartHandler ()
		{
			if (cb_getVisiblePart == null)
				cb_getVisiblePart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisiblePart);
			return cb_getVisiblePart;
		}

		static IntPtr n_GetVisiblePart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisiblePart);
		}
#pragma warning restore 0169

		static IntPtr id_getVisiblePart;
		public virtual unsafe global::Com.Microblink.Geometry.Rectangle VisiblePart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getVisiblePart' and count(parameter)=0]"
			[Register ("getVisiblePart", "()Lcom/microblink/geometry/Rectangle;", "GetGetVisiblePartHandler")]
			get {
				if (id_getVisiblePart == IntPtr.Zero)
					id_getVisiblePart = JNIEnv.GetMethodID (class_ref, "getVisiblePart", "()Lcom/microblink/geometry/Rectangle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallObjectMethod  (Handle, id_getVisiblePart), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Geometry.Rectangle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisiblePart", "()Lcom/microblink/geometry/Rectangle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getZoomLevel;
		static IntPtr id_setZoomLevel_F;
		public unsafe float ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()F", "GetGetZoomLevelHandler")]
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getZoomLevel);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setZoomLevel' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZoomLevel", "(F)V", "GetSetZoomLevel_FHandler")]
			set {
				if (id_setZoomLevel_F == IntPtr.Zero)
					id_setZoomLevel_F = JNIEnv.GetMethodID (class_ref, "setZoomLevel", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setZoomLevel_F, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addChildView_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetAddChildView_Landroid_view_View_ZHandler ()
		{
			if (cb_addChildView_Landroid_view_View_Z == null)
				cb_addChildView_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddChildView_Landroid_view_View_Z);
			return cb_addChildView_Landroid_view_View_Z;
		}

		static void n_AddChildView_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddChildView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addChildView_Landroid_view_View_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='addChildView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("addChildView", "(Landroid/view/View;Z)V", "GetAddChildView_Landroid_view_View_ZHandler")]
		public virtual unsafe void AddChildView (global::Android.Views.View p0, bool p1)
		{
			if (id_addChildView_Landroid_view_View_Z == IntPtr.Zero)
				id_addChildView_Landroid_view_View_Z = JNIEnv.GetMethodID (class_ref, "addChildView", "(Landroid/view/View;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addChildView_Landroid_view_View_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChildView", "(Landroid/view/View;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addChildView_Landroid_view_View_ZI;
#pragma warning disable 0169
		static Delegate GetAddChildView_Landroid_view_View_ZIHandler ()
		{
			if (cb_addChildView_Landroid_view_View_ZI == null)
				cb_addChildView_Landroid_view_View_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int>) n_AddChildView_Landroid_view_View_ZI);
			return cb_addChildView_Landroid_view_View_ZI;
		}

		static void n_AddChildView_Landroid_view_View_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddChildView (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addChildView_Landroid_view_View_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='addChildView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("addChildView", "(Landroid/view/View;ZI)V", "GetAddChildView_Landroid_view_View_ZIHandler")]
		public virtual unsafe void AddChildView (global::Android.Views.View p0, bool p1, int p2)
		{
			if (id_addChildView_Landroid_view_View_ZI == IntPtr.Zero)
				id_addChildView_Landroid_view_View_ZI = JNIEnv.GetMethodID (class_ref, "addChildView", "(Landroid/view/View;ZI)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addChildView_Landroid_view_View_ZI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChildView", "(Landroid/view/View;ZI)V"), __args);
			} finally {
			}
		}

		static IntPtr id_areCameraPixelsLandscapeLeft;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='areCameraPixelsLandscapeLeft' and count(parameter)=0]"
		[Register ("areCameraPixelsLandscapeLeft", "()Z", "")]
		public unsafe bool AreCameraPixelsLandscapeLeft ()
		{
			if (id_areCameraPixelsLandscapeLeft == IntPtr.Zero)
				id_areCameraPixelsLandscapeLeft = JNIEnv.GetMethodID (class_ref, "areCameraPixelsLandscapeLeft", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_areCameraPixelsLandscapeLeft);
			} finally {
			}
		}

		static Delegate cb_changeConfiguration_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetChangeConfiguration_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_changeConfiguration_Landroid_content_res_Configuration_ == null)
				cb_changeConfiguration_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeConfiguration_Landroid_content_res_Configuration_);
			return cb_changeConfiguration_Landroid_content_res_Configuration_;
		}

		static void n_ChangeConfiguration_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeConfiguration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_changeConfiguration_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='changeConfiguration' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("changeConfiguration", "(Landroid/content/res/Configuration;)V", "GetChangeConfiguration_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void ChangeConfiguration (global::Android.Content.Res.Configuration p0)
		{
			if (id_changeConfiguration_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_changeConfiguration_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "changeConfiguration", "(Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_changeConfiguration_Landroid_content_res_Configuration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeConfiguration", "(Landroid/content/res/Configuration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_changeConfigurationInternal_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetChangeConfigurationInternal_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_changeConfigurationInternal_Landroid_content_res_Configuration_ == null)
				cb_changeConfigurationInternal_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeConfigurationInternal_Landroid_content_res_Configuration_);
			return cb_changeConfigurationInternal_Landroid_content_res_Configuration_;
		}

		static void n_ChangeConfigurationInternal_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeConfigurationInternal (p0);
		}
#pragma warning restore 0169

		static IntPtr id_changeConfigurationInternal_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='changeConfigurationInternal' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("changeConfigurationInternal", "(Landroid/content/res/Configuration;)V", "GetChangeConfigurationInternal_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void ChangeConfigurationInternal (global::Android.Content.Res.Configuration p0)
		{
			if (id_changeConfigurationInternal_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_changeConfigurationInternal_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "changeConfigurationInternal", "(Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_changeConfigurationInternal_Landroid_content_res_Configuration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeConfigurationInternal", "(Landroid/content/res/Configuration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Create);
			return cb_create;
		}

		static void n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public virtual unsafe void Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_create);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "()V"));
			} finally {
			}
		}

		static Delegate cb_createOrientationChangeListener;
#pragma warning disable 0169
		static Delegate GetCreateOrientationChangeListenerHandler ()
		{
			if (cb_createOrientationChangeListener == null)
				cb_createOrientationChangeListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateOrientationChangeListener);
			return cb_createOrientationChangeListener;
		}

		static IntPtr n_CreateOrientationChangeListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateOrientationChangeListener ());
		}
#pragma warning restore 0169

		static IntPtr id_createOrientationChangeListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='createOrientationChangeListener' and count(parameter)=0]"
		[Register ("createOrientationChangeListener", "()Lcom/microblink/hardware/orientation/OrientationChangeListener;", "GetCreateOrientationChangeListenerHandler")]
		public virtual unsafe global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener CreateOrientationChangeListener ()
		{
			if (id_createOrientationChangeListener == IntPtr.Zero)
				id_createOrientationChangeListener = JNIEnv.GetMethodID (class_ref, "createOrientationChangeListener", "()Lcom/microblink/hardware/orientation/OrientationChangeListener;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener> (JNIEnv.CallObjectMethod  (Handle, id_createOrientationChangeListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createOrientationChangeListener", "()Lcom/microblink/hardware/orientation/OrientationChangeListener;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static IntPtr id_focusCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='focusCamera' and count(parameter)=0]"
		[Register ("focusCamera", "()V", "")]
		public unsafe void FocusCamera ()
		{
			if (id_focusCamera == IntPtr.Zero)
				id_focusCamera = JNIEnv.GetMethodID (class_ref, "focusCamera", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_focusCamera);
			} finally {
			}
		}

		static IntPtr id_getCameraViewState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='getCameraViewState' and count(parameter)=0]"
		[Register ("getCameraViewState", "()Lcom/microblink/view/BaseCameraView$CameraViewState;", "")]
		public unsafe global::Com.Microblink.View.BaseCameraView.CameraViewState GetCameraViewState ()
		{
			if (id_getCameraViewState == IntPtr.Zero)
				id_getCameraViewState = JNIEnv.GetMethodID (class_ref, "getCameraViewState", "()Lcom/microblink/view/BaseCameraView$CameraViewState;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView.CameraViewState> (JNIEnv.CallObjectMethod  (Handle, id_getCameraViewState), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='isOrientationAllowed' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.orientation.Orientation']]"
		[Register ("isOrientationAllowed", "(Lcom/microblink/hardware/orientation/Orientation;)Z", "")]
		public unsafe bool IsOrientationAllowed (global::Com.Microblink.Hardware.Orientation.Orientation p0)
		{
			if (id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ == IntPtr.Zero)
				id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_ = JNIEnv.GetMethodID (class_ref, "isOrientationAllowed", "(Lcom/microblink/hardware/orientation/Orientation;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_isOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_llIIlIIIll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='llIIlIIIll' and count(parameter)=0]"
		[Register ("llIIlIIIll", "()Z", "")]
		protected unsafe bool LlIIlIIIll ()
		{
			if (id_llIIlIIIll == IntPtr.Zero)
				id_llIIlIIIll = JNIEnv.GetMethodID (class_ref, "llIIlIIIll", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_llIIlIIIll);
			} finally {
			}
		}

		static Delegate cb_onCameraPreviewStarted;
#pragma warning disable 0169
		static Delegate GetOnCameraPreviewStartedHandler ()
		{
			if (cb_onCameraPreviewStarted == null)
				cb_onCameraPreviewStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraPreviewStarted);
			return cb_onCameraPreviewStarted;
		}

		static void n_OnCameraPreviewStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraPreviewStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_onCameraPreviewStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='onCameraPreviewStarted' and count(parameter)=0]"
		[Register ("onCameraPreviewStarted", "()V", "GetOnCameraPreviewStartedHandler")]
		public virtual unsafe void OnCameraPreviewStarted ()
		{
			if (id_onCameraPreviewStarted == IntPtr.Zero)
				id_onCameraPreviewStarted = JNIEnv.GetMethodID (class_ref, "onCameraPreviewStarted", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCameraPreviewStarted);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraPreviewStarted", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCameraPreviewStopped;
#pragma warning disable 0169
		static Delegate GetOnCameraPreviewStoppedHandler ()
		{
			if (cb_onCameraPreviewStopped == null)
				cb_onCameraPreviewStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraPreviewStopped);
			return cb_onCameraPreviewStopped;
		}

		static void n_OnCameraPreviewStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraPreviewStopped ();
		}
#pragma warning restore 0169

		static IntPtr id_onCameraPreviewStopped;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='onCameraPreviewStopped' and count(parameter)=0]"
		[Register ("onCameraPreviewStopped", "()V", "GetOnCameraPreviewStoppedHandler")]
		public virtual unsafe void OnCameraPreviewStopped ()
		{
			if (id_onCameraPreviewStopped == IntPtr.Zero)
				id_onCameraPreviewStopped = JNIEnv.GetMethodID (class_ref, "onCameraPreviewStopped", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCameraPreviewStopped);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraPreviewStopped", "()V"));
			} finally {
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_requireAutofocusFeature;
#pragma warning disable 0169
		static Delegate GetRequireAutofocusFeatureHandler ()
		{
			if (cb_requireAutofocusFeature == null)
				cb_requireAutofocusFeature = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RequireAutofocusFeature);
			return cb_requireAutofocusFeature;
		}

		static bool n_RequireAutofocusFeature (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequireAutofocusFeature ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='requireAutofocusFeature' and count(parameter)=0]"
		[Register ("requireAutofocusFeature", "()Z", "GetRequireAutofocusFeatureHandler")]
		public abstract bool RequireAutofocusFeature ();

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static IntPtr id_runOnUIThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='runOnUIThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnUIThread", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void RunOnUIThread (global::Java.Lang.IRunnable p0)
		{
			if (id_runOnUIThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runOnUIThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "runOnUIThread", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_runOnUIThread_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_setAnimateRotation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setAnimateRotation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAnimateRotation", "(Z)V", "")]
		public unsafe void SetAnimateRotation (bool p0)
		{
			if (id_setAnimateRotation_Z == IntPtr.Zero)
				id_setAnimateRotation_Z = JNIEnv.GetMethodID (class_ref, "setAnimateRotation", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setAnimateRotation_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setCameraType_Lcom_microblink_hardware_camera_CameraType_;
#pragma warning disable 0169
		static Delegate GetSetCameraType_Lcom_microblink_hardware_camera_CameraType_Handler ()
		{
			if (cb_setCameraType_Lcom_microblink_hardware_camera_CameraType_ == null)
				cb_setCameraType_Lcom_microblink_hardware_camera_CameraType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCameraType_Lcom_microblink_hardware_camera_CameraType_);
			return cb_setCameraType_Lcom_microblink_hardware_camera_CameraType_;
		}

		static void n_SetCameraType_Lcom_microblink_hardware_camera_CameraType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Camera.CameraType p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Camera.CameraType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCameraType_Lcom_microblink_hardware_camera_CameraType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setCameraType' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.camera.CameraType']]"
		[Register ("setCameraType", "(Lcom/microblink/hardware/camera/CameraType;)V", "GetSetCameraType_Lcom_microblink_hardware_camera_CameraType_Handler")]
		public virtual unsafe void SetCameraType (global::Com.Microblink.Hardware.Camera.CameraType p0)
		{
			if (id_setCameraType_Lcom_microblink_hardware_camera_CameraType_ == IntPtr.Zero)
				id_setCameraType_Lcom_microblink_hardware_camera_CameraType_ = JNIEnv.GetMethodID (class_ref, "setCameraType", "(Lcom/microblink/hardware/camera/CameraType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCameraType_Lcom_microblink_hardware_camera_CameraType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCameraType", "(Lcom/microblink/hardware/camera/CameraType;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setForceUseLegacyCamera_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setForceUseLegacyCamera' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForceUseLegacyCamera", "(Z)V", "")]
		public unsafe void SetForceUseLegacyCamera (bool p0)
		{
			if (id_setForceUseLegacyCamera_Z == IntPtr.Zero)
				id_setForceUseLegacyCamera_Z = JNIEnv.GetMethodID (class_ref, "setForceUseLegacyCamera", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setForceUseLegacyCamera_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setMeteringAreas_arrayLcom_microblink_geometry_Rectangle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setMeteringAreas' and count(parameter)=1 and parameter[1][@type='com.microblink.geometry.Rectangle[]']]"
		[Register ("setMeteringAreas", "([Lcom/microblink/geometry/Rectangle;)V", "")]
		public unsafe void SetMeteringAreas (global::Com.Microblink.Geometry.Rectangle[] p0)
		{
			if (id_setMeteringAreas_arrayLcom_microblink_geometry_Rectangle_ == IntPtr.Zero)
				id_setMeteringAreas_arrayLcom_microblink_geometry_Rectangle_ = JNIEnv.GetMethodID (class_ref, "setMeteringAreas", "([Lcom/microblink/geometry/Rectangle;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_setMeteringAreas_arrayLcom_microblink_geometry_Rectangle_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_setOnSizeChangedListener_Lcom_microblink_view_OnSizeChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setOnSizeChangedListener' and count(parameter)=1 and parameter[1][@type='com.microblink.view.OnSizeChangedListener']]"
		[Register ("setOnSizeChangedListener", "(Lcom/microblink/view/OnSizeChangedListener;)V", "")]
		public unsafe void SetOnSizeChangedListener (global::Com.Microblink.View.IOnSizeChangedListener p0)
		{
			if (id_setOnSizeChangedListener_Lcom_microblink_view_OnSizeChangedListener_ == IntPtr.Zero)
				id_setOnSizeChangedListener_Lcom_microblink_view_OnSizeChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnSizeChangedListener", "(Lcom/microblink/view/OnSizeChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setOnSizeChangedListener_Lcom_microblink_view_OnSizeChangedListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOptimizeCameraForNearScan_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setOptimizeCameraForNearScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOptimizeCameraForNearScan", "(Z)V", "")]
		public unsafe void SetOptimizeCameraForNearScan (bool p0)
		{
			if (id_setOptimizeCameraForNearScan_Z == IntPtr.Zero)
				id_setOptimizeCameraForNearScan_Z = JNIEnv.GetMethodID (class_ref, "setOptimizeCameraForNearScan", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setOptimizeCameraForNearScan_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_;
#pragma warning disable 0169
		static Delegate GetSetOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_Handler ()
		{
			if (cb_setOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_ == null)
				cb_setOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_);
			return cb_setOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_;
		}

		static void n_SetOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.View.IOrientationAllowedListener p0 = (global::Com.Microblink.View.IOrientationAllowedListener)global::Java.Lang.Object.GetObject<global::Com.Microblink.View.IOrientationAllowedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientationAllowedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setOrientationAllowedListener' and count(parameter)=1 and parameter[1][@type='com.microblink.view.OrientationAllowedListener']]"
		[Register ("setOrientationAllowedListener", "(Lcom/microblink/view/OrientationAllowedListener;)V", "GetSetOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_Handler")]
		public virtual unsafe void SetOrientationAllowedListener (global::Com.Microblink.View.IOrientationAllowedListener p0)
		{
			if (id_setOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_ == IntPtr.Zero)
				id_setOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_ = JNIEnv.GetMethodID (class_ref, "setOrientationAllowedListener", "(Lcom/microblink/view/OrientationAllowedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOrientationAllowedListener_Lcom_microblink_view_OrientationAllowedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientationAllowedListener", "(Lcom/microblink/view/OrientationAllowedListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setPhotoMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setPhotoMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPhotoMode", "(Z)V", "")]
		public unsafe void SetPhotoMode (bool p0)
		{
			if (id_setPhotoMode_Z == IntPtr.Zero)
				id_setPhotoMode_Z = JNIEnv.GetMethodID (class_ref, "setPhotoMode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setPhotoMode_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_;
#pragma warning disable 0169
		static Delegate GetSetShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_Handler ()
		{
			if (cb_setShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_ == null)
				cb_setShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_);
			return cb_setShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_;
		}

		static void n_SetShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Hardware.Accelerometer.IShakeCallback p0 = (global::Com.Microblink.Hardware.Accelerometer.IShakeCallback)global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Accelerometer.IShakeCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShakeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setShakeListener' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.accelerometer.ShakeCallback']]"
		[Register ("setShakeListener", "(Lcom/microblink/hardware/accelerometer/ShakeCallback;)V", "GetSetShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_Handler")]
		public virtual unsafe void SetShakeListener (global::Com.Microblink.Hardware.Accelerometer.IShakeCallback p0)
		{
			if (id_setShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_ == IntPtr.Zero)
				id_setShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_ = JNIEnv.GetMethodID (class_ref, "setShakeListener", "(Lcom/microblink/hardware/accelerometer/ShakeCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShakeListener_Lcom_microblink_hardware_accelerometer_ShakeCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShakeListener", "(Lcom/microblink/hardware/accelerometer/ShakeCallback;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setTorchState_ZLcom_microblink_hardware_SuccessCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setTorchState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.microblink.hardware.SuccessCallback']]"
		[Register ("setTorchState", "(ZLcom/microblink/hardware/SuccessCallback;)V", "")]
		public unsafe void SetTorchState (bool p0, global::Com.Microblink.Hardware.ISuccessCallback p1)
		{
			if (id_setTorchState_ZLcom_microblink_hardware_SuccessCallback_ == IntPtr.Zero)
				id_setTorchState_ZLcom_microblink_hardware_SuccessCallback_ = JNIEnv.GetMethodID (class_ref, "setTorchState", "(ZLcom/microblink/hardware/SuccessCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setTorchState_ZLcom_microblink_hardware_SuccessCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_setUseTextureViewForCameraDisplay_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setUseTextureViewForCameraDisplay' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseTextureViewForCameraDisplay", "(Z)V", "")]
		public unsafe void SetUseTextureViewForCameraDisplay (bool p0)
		{
			if (id_setUseTextureViewForCameraDisplay_Z == IntPtr.Zero)
				id_setUseTextureViewForCameraDisplay_Z = JNIEnv.GetMethodID (class_ref, "setUseTextureViewForCameraDisplay", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setUseTextureViewForCameraDisplay_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setVideoResolutionPreset_Lcom_microblink_hardware_camera_VideoResolutionPreset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='setVideoResolutionPreset' and count(parameter)=1 and parameter[1][@type='com.microblink.hardware.camera.VideoResolutionPreset']]"
		[Register ("setVideoResolutionPreset", "(Lcom/microblink/hardware/camera/VideoResolutionPreset;)V", "")]
		public unsafe void SetVideoResolutionPreset (global::Com.Microblink.Hardware.Camera.VideoResolutionPreset p0)
		{
			if (id_setVideoResolutionPreset_Lcom_microblink_hardware_camera_VideoResolutionPreset_ == IntPtr.Zero)
				id_setVideoResolutionPreset_Lcom_microblink_hardware_camera_VideoResolutionPreset_ = JNIEnv.GetMethodID (class_ref, "setVideoResolutionPreset", "(Lcom/microblink/hardware/camera/VideoResolutionPreset;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setVideoResolutionPreset_Lcom_microblink_hardware_camera_VideoResolutionPreset_, __args);
			} finally {
			}
		}

		static IntPtr id_shouldAnimateRotation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='shouldAnimateRotation' and count(parameter)=0]"
		[Register ("shouldAnimateRotation", "()Z", "")]
		public unsafe bool ShouldAnimateRotation ()
		{
			if (id_shouldAnimateRotation == IntPtr.Zero)
				id_shouldAnimateRotation = JNIEnv.GetMethodID (class_ref, "shouldAnimateRotation", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_shouldAnimateRotation);
			} finally {
			}
		}

		static Delegate cb_shouldStartCamera;
#pragma warning disable 0169
		static Delegate GetShouldStartCameraHandler ()
		{
			if (cb_shouldStartCamera == null)
				cb_shouldStartCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldStartCamera);
			return cb_shouldStartCamera;
		}

		static bool n_ShouldStartCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldStartCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldStartCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='shouldStartCamera' and count(parameter)=0]"
		[Register ("shouldStartCamera", "()Z", "GetShouldStartCameraHandler")]
		public virtual unsafe bool ShouldStartCamera ()
		{
			if (id_shouldStartCamera == IntPtr.Zero)
				id_shouldStartCamera = JNIEnv.GetMethodID (class_ref, "shouldStartCamera", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldStartCamera);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldStartCamera", "()Z"));
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.BaseCameraView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.BaseCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Microblink.View.IOnSizeChangedListener"
		public event EventHandler<global::Com.Microblink.View.SizeChangedEventArgs> SizeChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Microblink.View.IOnSizeChangedListener, global::Com.Microblink.View.IOnSizeChangedListenerImplementor>(
						ref weak_implementor_SetOnSizeChangedListener,
						__CreateIOnSizeChangedListenerImplementor,
						SetOnSizeChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Microblink.View.IOnSizeChangedListener, global::Com.Microblink.View.IOnSizeChangedListenerImplementor>(
						ref weak_implementor_SetOnSizeChangedListener,
						global::Com.Microblink.View.IOnSizeChangedListenerImplementor.__IsEmpty,
						__v => SetOnSizeChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSizeChangedListener;

		global::Com.Microblink.View.IOnSizeChangedListenerImplementor __CreateIOnSizeChangedListenerImplementor ()
		{
			return new global::Com.Microblink.View.IOnSizeChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Microblink.View.IOrientationAllowedListener"
		public event EventHandler<global::Com.Microblink.View.OrientationAllowedEventArgs> OrientationAllowed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Microblink.View.IOrientationAllowedListener, global::Com.Microblink.View.IOrientationAllowedListenerImplementor>(
						ref weak_implementor_SetOrientationAllowedListener,
						__CreateIOrientationAllowedListenerImplementor,
						SetOrientationAllowedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Microblink.View.IOrientationAllowedListener, global::Com.Microblink.View.IOrientationAllowedListenerImplementor>(
						ref weak_implementor_SetOrientationAllowedListener,
						global::Com.Microblink.View.IOrientationAllowedListenerImplementor.__IsEmpty,
						__v => SetOrientationAllowedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOrientationAllowedListener;

		global::Com.Microblink.View.IOrientationAllowedListenerImplementor __CreateIOrientationAllowedListenerImplementor ()
		{
			return new global::Com.Microblink.View.IOrientationAllowedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Microblink.Hardware.Orientation.IOrientationChangeListener"
		public event EventHandler<global::Com.Microblink.Hardware.Orientation.OrientationChangeEventArgs> OrientationChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener, global::Com.Microblink.Hardware.Orientation.IOrientationChangeListenerImplementor>(
						ref weak_implementor___SetOrientationChangeListener,
						__CreateIOrientationChangeListenerImplementor,
						__v => OrientationChangeListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Microblink.Hardware.Orientation.IOrientationChangeListener, global::Com.Microblink.Hardware.Orientation.IOrientationChangeListenerImplementor>(
						ref weak_implementor___SetOrientationChangeListener,
						global::Com.Microblink.Hardware.Orientation.IOrientationChangeListenerImplementor.__IsEmpty,
						__v => OrientationChangeListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOrientationChangeListener;

		global::Com.Microblink.Hardware.Orientation.IOrientationChangeListenerImplementor __CreateIOrientationChangeListenerImplementor ()
		{
			return new global::Com.Microblink.Hardware.Orientation.IOrientationChangeListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/microblink/view/BaseCameraView", DoNotGenerateAcw=true)]
	internal partial class BaseCameraViewInvoker : BaseCameraView {

		public BaseCameraViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCameraViewInvoker); }
		}

		static IntPtr id_requireAutofocusFeature;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view']/class[@name='BaseCameraView']/method[@name='requireAutofocusFeature' and count(parameter)=0]"
		[Register ("requireAutofocusFeature", "()Z", "GetRequireAutofocusFeatureHandler")]
		public override unsafe bool RequireAutofocusFeature ()
		{
			if (id_requireAutofocusFeature == IntPtr.Zero)
				id_requireAutofocusFeature = JNIEnv.GetMethodID (class_ref, "requireAutofocusFeature", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_requireAutofocusFeature);
			} finally {
			}
		}

	}

}
