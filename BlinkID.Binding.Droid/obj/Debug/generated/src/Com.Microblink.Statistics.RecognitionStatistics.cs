using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Statistics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.statistics']/class[@name='RecognitionStatistics']"
	[global::Android.Runtime.Register ("com/microblink/statistics/RecognitionStatistics", DoNotGenerateAcw=true)]
	public partial class RecognitionStatistics : global::Com.Microblink.Statistics.StatisticsWithDuration {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/statistics/RecognitionStatistics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecognitionStatistics); }
		}

		protected RecognitionStatistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getFieldStats;
#pragma warning disable 0169
		static Delegate GetGetFieldStatsHandler ()
		{
			if (cb_getFieldStats == null)
				cb_getFieldStats = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFieldStats);
			return cb_getFieldStats;
		}

		static IntPtr n_GetFieldStats (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.RecognitionStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.RecognitionStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Microblink.Statistics.FieldStatistics>.ToLocalJniHandle (__this.FieldStats);
		}
#pragma warning restore 0169

		static IntPtr id_getFieldStats;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Microblink.Statistics.FieldStatistics> FieldStats {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='RecognitionStatistics']/method[@name='getFieldStats' and count(parameter)=0]"
			[Register ("getFieldStats", "()Ljava/util/Map;", "GetGetFieldStatsHandler")]
			get {
				if (id_getFieldStats == IntPtr.Zero)
					id_getFieldStats = JNIEnv.GetMethodID (class_ref, "getFieldStats", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Com.Microblink.Statistics.FieldStatistics>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getFieldStats), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Com.Microblink.Statistics.FieldStatistics>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFieldStats", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
