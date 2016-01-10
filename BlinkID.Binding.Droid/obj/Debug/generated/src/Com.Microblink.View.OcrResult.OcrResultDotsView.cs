using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.View.OcrResult {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']"
	[global::Android.Runtime.Register ("com/microblink/view/ocrResult/OcrResultDotsView", DoNotGenerateAcw=true)]
	public partial class OcrResultDotsView : global::Android.Views.ViewGroup, global::Com.Microblink.View.OcrResult.IOcrResultView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView.RandomOCRDotsGenerator']"
		[global::Android.Runtime.Register ("com/microblink/view/ocrResult/OcrResultDotsView$RandomOCRDotsGenerator", DoNotGenerateAcw=true)]
		public partial class RandomOCRDotsGenerator : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/view/ocrResult/OcrResultDotsView$RandomOCRDotsGenerator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RandomOCRDotsGenerator); }
			}

			protected RandomOCRDotsGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView.RandomOCRDotsGenerator']/constructor[@name='OcrResultDotsView.RandomOCRDotsGenerator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RandomOCRDotsGenerator ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (RandomOCRDotsGenerator)) {
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

			static Delegate cb_calculateDotPositionsForLine_Landroid_util_Pair_;
#pragma warning disable 0169
			static Delegate GetCalculateDotPositionsForLine_Landroid_util_Pair_Handler ()
			{
				if (cb_calculateDotPositionsForLine_Landroid_util_Pair_ == null)
					cb_calculateDotPositionsForLine_Landroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CalculateDotPositionsForLine_Landroid_util_Pair_);
				return cb_calculateDotPositionsForLine_Landroid_util_Pair_;
			}

			static IntPtr n_CalculateDotPositionsForLine_Landroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Microblink.View.OcrResult.OcrResultDotsView.RandomOCRDotsGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView.RandomOCRDotsGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Util.Pair p0 = global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.CalculateDotPositionsForLine (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_calculateDotPositionsForLine_Landroid_util_Pair_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView.RandomOCRDotsGenerator']/method[@name='calculateDotPositionsForLine' and count(parameter)=1 and parameter[1][@type='android.util.Pair&lt;com.microblink.results.ocr.OcrLine, android.graphics.Matrix&gt;']]"
			[Register ("calculateDotPositionsForLine", "(Landroid/util/Pair;)[F", "GetCalculateDotPositionsForLine_Landroid_util_Pair_Handler")]
			public virtual unsafe float[] CalculateDotPositionsForLine (global::Android.Util.Pair p0)
			{
				if (id_calculateDotPositionsForLine_Landroid_util_Pair_ == IntPtr.Zero)
					id_calculateDotPositionsForLine_Landroid_util_Pair_ = JNIEnv.GetMethodID (class_ref, "calculateDotPositionsForLine", "(Landroid/util/Pair;)[F");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					float[] __ret;
					if (GetType () == ThresholdType)
						__ret = (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_calculateDotPositionsForLine_Landroid_util_Pair_, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
					else
						__ret = (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateDotPositionsForLine", "(Landroid/util/Pair;)[F"), __args), JniHandleOwnership.TransferLocalRef, typeof (float));
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setDotsCount_I;
#pragma warning disable 0169
			static Delegate GetSetDotsCount_IHandler ()
			{
				if (cb_setDotsCount_I == null)
					cb_setDotsCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetDotsCount_I);
				return cb_setDotsCount_I;
			}

			static IntPtr n_SetDotsCount_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Microblink.View.OcrResult.OcrResultDotsView.RandomOCRDotsGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView.RandomOCRDotsGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDotsCount (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setDotsCount_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView.RandomOCRDotsGenerator']/method[@name='setDotsCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDotsCount", "(I)Lcom/microblink/view/ocrResult/OcrResultDotsView$RandomOCRDotsGenerator;", "GetSetDotsCount_IHandler")]
			public virtual unsafe global::Com.Microblink.View.OcrResult.OcrResultDotsView.RandomOCRDotsGenerator SetDotsCount (int p0)
			{
				if (id_setDotsCount_I == IntPtr.Zero)
					id_setDotsCount_I = JNIEnv.GetMethodID (class_ref, "setDotsCount", "(I)Lcom/microblink/view/ocrResult/OcrResultDotsView$RandomOCRDotsGenerator;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView.RandomOCRDotsGenerator> (JNIEnv.CallObjectMethod  (Handle, id_setDotsCount_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView.RandomOCRDotsGenerator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDotsCount", "(I)Lcom/microblink/view/ocrResult/OcrResultDotsView$RandomOCRDotsGenerator;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/view/ocrResult/OcrResultDotsView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OcrResultDotsView); }
		}

		protected OcrResultDotsView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/constructor[@name='OcrResultDotsView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe OcrResultDotsView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (OcrResultDotsView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/constructor[@name='OcrResultDotsView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe OcrResultDotsView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
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
				if (GetType () != typeof (OcrResultDotsView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.OcrResult.OcrResultDotsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addOcrResult_Lcom_microblink_results_ocr_OcrResult_;
#pragma warning disable 0169
		static Delegate GetAddOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler ()
		{
			if (cb_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ == null)
				cb_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOcrResult_Lcom_microblink_results_ocr_OcrResult_);
			return cb_addOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		}

		static void n_AddOcrResult_Lcom_microblink_results_ocr_OcrResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.OcrResult.OcrResultDotsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrResult p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOcrResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/method[@name='addOcrResult' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrResult']]"
		[Register ("addOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V", "GetAddOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler")]
		public virtual unsafe void AddOcrResult (global::Com.Microblink.Results.Ocr.OcrResult p0)
		{
			if (id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ == IntPtr.Zero)
				id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNIEnv.GetMethodID (class_ref, "addOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addOcrResult_Lcom_microblink_results_ocr_OcrResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearOcrResults;
#pragma warning disable 0169
		static Delegate GetClearOcrResultsHandler ()
		{
			if (cb_clearOcrResults == null)
				cb_clearOcrResults = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearOcrResults);
			return cb_clearOcrResults;
		}

		static void n_ClearOcrResults (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.View.OcrResult.OcrResultDotsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearOcrResults ();
		}
#pragma warning restore 0169

		static IntPtr id_clearOcrResults;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/method[@name='clearOcrResults' and count(parameter)=0]"
		[Register ("clearOcrResults", "()V", "GetClearOcrResultsHandler")]
		public virtual unsafe void ClearOcrResults ()
		{
			if (id_clearOcrResults == IntPtr.Zero)
				id_clearOcrResults = JNIEnv.GetMethodID (class_ref, "clearOcrResults", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearOcrResults);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearOcrResults", "()V"));
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
			global::Com.Microblink.View.OcrResult.OcrResultDotsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
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

		static Delegate cb_setHostActivityOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetHostActivityOrientation_IHandler ()
		{
			if (cb_setHostActivityOrientation_I == null)
				cb_setHostActivityOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHostActivityOrientation_I);
			return cb_setHostActivityOrientation_I;
		}

		static void n_SetHostActivityOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.View.OcrResult.OcrResultDotsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHostActivityOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHostActivityOrientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/method[@name='setHostActivityOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHostActivityOrientation", "(I)V", "GetSetHostActivityOrientation_IHandler")]
		public virtual unsafe void SetHostActivityOrientation (int p0)
		{
			if (id_setHostActivityOrientation_I == IntPtr.Zero)
				id_setHostActivityOrientation_I = JNIEnv.GetMethodID (class_ref, "setHostActivityOrientation", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHostActivityOrientation_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostActivityOrientation", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setNumberOfDots_I;
#pragma warning disable 0169
		static Delegate GetSetNumberOfDots_IHandler ()
		{
			if (cb_setNumberOfDots_I == null)
				cb_setNumberOfDots_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumberOfDots_I);
			return cb_setNumberOfDots_I;
		}

		static void n_SetNumberOfDots_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Microblink.View.OcrResult.OcrResultDotsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNumberOfDots (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNumberOfDots_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/method[@name='setNumberOfDots' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNumberOfDots", "(I)V", "GetSetNumberOfDots_IHandler")]
		public virtual unsafe void SetNumberOfDots (int p0)
		{
			if (id_setNumberOfDots_I == IntPtr.Zero)
				id_setNumberOfDots_I = JNIEnv.GetMethodID (class_ref, "setNumberOfDots", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNumberOfDots_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumberOfDots", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOcrResult_Lcom_microblink_results_ocr_OcrResult_;
#pragma warning disable 0169
		static Delegate GetSetOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler ()
		{
			if (cb_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ == null)
				cb_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOcrResult_Lcom_microblink_results_ocr_OcrResult_);
			return cb_setOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		}

		static void n_SetOcrResult_Lcom_microblink_results_ocr_OcrResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.View.OcrResult.OcrResultDotsView __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.View.OcrResult.OcrResultDotsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Results.Ocr.OcrResult p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Ocr.OcrResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOcrResult (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.view.ocrResult']/class[@name='OcrResultDotsView']/method[@name='setOcrResult' and count(parameter)=1 and parameter[1][@type='com.microblink.results.ocr.OcrResult']]"
		[Register ("setOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V", "GetSetOcrResult_Lcom_microblink_results_ocr_OcrResult_Handler")]
		public virtual unsafe void SetOcrResult (global::Com.Microblink.Results.Ocr.OcrResult p0)
		{
			if (id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ == IntPtr.Zero)
				id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_ = JNIEnv.GetMethodID (class_ref, "setOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOcrResult_Lcom_microblink_results_ocr_OcrResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOcrResult", "(Lcom/microblink/results/ocr/OcrResult;)V"), __args);
			} finally {
			}
		}

	}
}
