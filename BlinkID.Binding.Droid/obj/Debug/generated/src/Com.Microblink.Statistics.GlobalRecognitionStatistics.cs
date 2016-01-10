using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Statistics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.statistics']/class[@name='GlobalRecognitionStatistics']"
	[global::Android.Runtime.Register ("com/microblink/statistics/GlobalRecognitionStatistics", DoNotGenerateAcw=true)]
	public partial class GlobalRecognitionStatistics : global::Com.Microblink.Statistics.StatisticsWithDuration {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/statistics/GlobalRecognitionStatistics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlobalRecognitionStatistics); }
		}

		protected GlobalRecognitionStatistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getStatisticsByType;
#pragma warning disable 0169
		static Delegate GetGetStatisticsByTypeHandler ()
		{
			if (cb_getStatisticsByType == null)
				cb_getStatisticsByType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatisticsByType);
			return cb_getStatisticsByType;
		}

		static IntPtr n_GetStatisticsByType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.GlobalRecognitionStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.GlobalRecognitionStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Microblink.Statistics.RecognitionStatistics>.ToLocalJniHandle (__this.StatisticsByType);
		}
#pragma warning restore 0169

		static IntPtr id_getStatisticsByType;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Microblink.Statistics.RecognitionStatistics> StatisticsByType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='GlobalRecognitionStatistics']/method[@name='getStatisticsByType' and count(parameter)=0]"
			[Register ("getStatisticsByType", "()Ljava/util/Map;", "GetGetStatisticsByTypeHandler")]
			get {
				if (id_getStatisticsByType == IntPtr.Zero)
					id_getStatisticsByType = JNIEnv.GetMethodID (class_ref, "getStatisticsByType", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Com.Microblink.Statistics.RecognitionStatistics>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStatisticsByType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Com.Microblink.Statistics.RecognitionStatistics>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatisticsByType", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearStatistics_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetClearStatistics_Landroid_content_Context_Handler ()
		{
			if (cb_clearStatistics_Landroid_content_Context_ == null)
				cb_clearStatistics_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearStatistics_Landroid_content_Context_);
			return cb_clearStatistics_Landroid_content_Context_;
		}

		static void n_ClearStatistics_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Statistics.GlobalRecognitionStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.GlobalRecognitionStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearStatistics (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clearStatistics_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='GlobalRecognitionStatistics']/method[@name='clearStatistics' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearStatistics", "(Landroid/content/Context;)V", "GetClearStatistics_Landroid_content_Context_Handler")]
		public virtual unsafe void ClearStatistics (global::Android.Content.Context p0)
		{
			if (id_clearStatistics_Landroid_content_Context_ == IntPtr.Zero)
				id_clearStatistics_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "clearStatistics", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearStatistics_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearStatistics", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_getSharedInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='GlobalRecognitionStatistics']/method[@name='getSharedInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSharedInstance", "(Landroid/content/Context;)Lcom/microblink/statistics/GlobalRecognitionStatistics;", "")]
		public static unsafe global::Com.Microblink.Statistics.GlobalRecognitionStatistics GetSharedInstance (global::Android.Content.Context p0)
		{
			if (id_getSharedInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getSharedInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getSharedInstance", "(Landroid/content/Context;)Lcom/microblink/statistics/GlobalRecognitionStatistics;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Microblink.Statistics.GlobalRecognitionStatistics __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.GlobalRecognitionStatistics> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSharedInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUpdateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_Handler ()
		{
			if (cb_updateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_ == null)
				cb_updateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_UpdateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_);
			return cb_updateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_;
		}

		static void n_UpdateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, IntPtr native_p3)
		{
			global::Com.Microblink.Statistics.GlobalRecognitionStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.GlobalRecognitionStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.BaseRecognitionResult p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Recognizers.BaseRecognitionResult p1 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.BaseRecognitionResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStatistics (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='GlobalRecognitionStatistics']/method[@name='updateStatistics' and count(parameter)=4 and parameter[1][@type='com.microblink.recognizers.BaseRecognitionResult'] and parameter[2][@type='com.microblink.recognizers.BaseRecognitionResult'] and parameter[3][@type='long'] and parameter[4][@type='android.content.Context']]"
		[Register ("updateStatistics", "(Lcom/microblink/recognizers/BaseRecognitionResult;Lcom/microblink/recognizers/BaseRecognitionResult;JLandroid/content/Context;)V", "GetUpdateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_Handler")]
		public virtual unsafe void UpdateStatistics (global::Com.Microblink.Recognizers.BaseRecognitionResult p0, global::Com.Microblink.Recognizers.BaseRecognitionResult p1, long p2, global::Android.Content.Context p3)
		{
			if (id_updateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_ == IntPtr.Zero)
				id_updateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "updateStatistics", "(Lcom/microblink/recognizers/BaseRecognitionResult;Lcom/microblink/recognizers/BaseRecognitionResult;JLandroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateStatistics_Lcom_microblink_recognizers_BaseRecognitionResult_Lcom_microblink_recognizers_BaseRecognitionResult_JLandroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateStatistics", "(Lcom/microblink/recognizers/BaseRecognitionResult;Lcom/microblink/recognizers/BaseRecognitionResult;JLandroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUpdateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_updateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_updateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_);
			return cb_updateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_;
		}

		static void n_UpdateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.Statistics.GlobalRecognitionStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.GlobalRecognitionStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStatisticsWithCancel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='GlobalRecognitionStatistics']/method[@name='updateStatisticsWithCancel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("updateStatisticsWithCancel", "(Ljava/lang/String;Landroid/content/Context;)V", "GetUpdateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_Handler")]
		public virtual unsafe void UpdateStatisticsWithCancel (string p0, global::Android.Content.Context p1)
		{
			if (id_updateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_updateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "updateStatisticsWithCancel", "(Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateStatisticsWithCancel_Ljava_lang_String_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateStatisticsWithCancel", "(Ljava/lang/String;Landroid/content/Context;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
