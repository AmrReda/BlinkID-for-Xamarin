using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Statistics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatisticsWithDuration']"
	[Register ("com/microblink/statistics/IStatisticsWithDuration", "", "Com.Microblink.Statistics.IStatisticsWithDurationInvoker")]
	public partial interface IStatisticsWithDuration : global::Com.Microblink.Statistics.IStatistics {

		long AverageScanDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatisticsWithDuration']/method[@name='getAverageScanDuration' and count(parameter)=0]"
			[Register ("getAverageScanDuration", "()J", "GetGetAverageScanDurationHandler:Com.Microblink.Statistics.IStatisticsWithDurationInvoker, BlinkID.Binding.Droid")] get;
		}

		int NumberOfCancels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatisticsWithDuration']/method[@name='getNumberOfCancels' and count(parameter)=0]"
			[Register ("getNumberOfCancels", "()I", "GetGetNumberOfCancelsHandler:Com.Microblink.Statistics.IStatisticsWithDurationInvoker, BlinkID.Binding.Droid")] get;
		}

	}

	[global::Android.Runtime.Register ("com/microblink/statistics/IStatisticsWithDuration", DoNotGenerateAcw=true)]
	internal class IStatisticsWithDurationInvoker : global::Java.Lang.Object, IStatisticsWithDuration {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/statistics/IStatisticsWithDuration");
		IntPtr class_ref;

		public static IStatisticsWithDuration GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatisticsWithDuration> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.statistics.IStatisticsWithDuration"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatisticsWithDurationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStatisticsWithDurationInvoker); }
		}

		static Delegate cb_getAverageScanDuration;
#pragma warning disable 0169
		static Delegate GetGetAverageScanDurationHandler ()
		{
			if (cb_getAverageScanDuration == null)
				cb_getAverageScanDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAverageScanDuration);
			return cb_getAverageScanDuration;
		}

		static long n_GetAverageScanDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.IStatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AverageScanDuration;
		}
#pragma warning restore 0169

		IntPtr id_getAverageScanDuration;
		public unsafe long AverageScanDuration {
			get {
				if (id_getAverageScanDuration == IntPtr.Zero)
					id_getAverageScanDuration = JNIEnv.GetMethodID (class_ref, "getAverageScanDuration", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getAverageScanDuration);
			}
		}

		static Delegate cb_getNumberOfCancels;
#pragma warning disable 0169
		static Delegate GetGetNumberOfCancelsHandler ()
		{
			if (cb_getNumberOfCancels == null)
				cb_getNumberOfCancels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfCancels);
			return cb_getNumberOfCancels;
		}

		static int n_GetNumberOfCancels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.IStatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfCancels;
		}
#pragma warning restore 0169

		IntPtr id_getNumberOfCancels;
		public unsafe int NumberOfCancels {
			get {
				if (id_getNumberOfCancels == IntPtr.Zero)
					id_getNumberOfCancels = JNIEnv.GetMethodID (class_ref, "getNumberOfCancels", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getNumberOfCancels);
			}
		}

		static Delegate cb_getScansCorrect;
#pragma warning disable 0169
		static Delegate GetGetScansCorrectHandler ()
		{
			if (cb_getScansCorrect == null)
				cb_getScansCorrect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScansCorrect);
			return cb_getScansCorrect;
		}

		static int n_GetScansCorrect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.IStatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScansCorrect;
		}
#pragma warning restore 0169

		IntPtr id_getScansCorrect;
		public unsafe int ScansCorrect {
			get {
				if (id_getScansCorrect == IntPtr.Zero)
					id_getScansCorrect = JNIEnv.GetMethodID (class_ref, "getScansCorrect", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getScansCorrect);
			}
		}

		static Delegate cb_getScansCorrectUpTo1Element;
#pragma warning disable 0169
		static Delegate GetGetScansCorrectUpTo1ElementHandler ()
		{
			if (cb_getScansCorrectUpTo1Element == null)
				cb_getScansCorrectUpTo1Element = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScansCorrectUpTo1Element);
			return cb_getScansCorrectUpTo1Element;
		}

		static int n_GetScansCorrectUpTo1Element (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.IStatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScansCorrectUpTo1Element;
		}
#pragma warning restore 0169

		IntPtr id_getScansCorrectUpTo1Element;
		public unsafe int ScansCorrectUpTo1Element {
			get {
				if (id_getScansCorrectUpTo1Element == IntPtr.Zero)
					id_getScansCorrectUpTo1Element = JNIEnv.GetMethodID (class_ref, "getScansCorrectUpTo1Element", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getScansCorrectUpTo1Element);
			}
		}

		static Delegate cb_getScansCorrectUpToMoreThan1Element;
#pragma warning disable 0169
		static Delegate GetGetScansCorrectUpToMoreThan1ElementHandler ()
		{
			if (cb_getScansCorrectUpToMoreThan1Element == null)
				cb_getScansCorrectUpToMoreThan1Element = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScansCorrectUpToMoreThan1Element);
			return cb_getScansCorrectUpToMoreThan1Element;
		}

		static int n_GetScansCorrectUpToMoreThan1Element (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.IStatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScansCorrectUpToMoreThan1Element;
		}
#pragma warning restore 0169

		IntPtr id_getScansCorrectUpToMoreThan1Element;
		public unsafe int ScansCorrectUpToMoreThan1Element {
			get {
				if (id_getScansCorrectUpToMoreThan1Element == IntPtr.Zero)
					id_getScansCorrectUpToMoreThan1Element = JNIEnv.GetMethodID (class_ref, "getScansCorrectUpToMoreThan1Element", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getScansCorrectUpToMoreThan1Element);
			}
		}

		static Delegate cb_getScansTotal;
#pragma warning disable 0169
		static Delegate GetGetScansTotalHandler ()
		{
			if (cb_getScansTotal == null)
				cb_getScansTotal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScansTotal);
			return cb_getScansTotal;
		}

		static int n_GetScansTotal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.IStatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScansTotal;
		}
#pragma warning restore 0169

		IntPtr id_getScansTotal;
		public unsafe int ScansTotal {
			get {
				if (id_getScansTotal == IntPtr.Zero)
					id_getScansTotal = JNIEnv.GetMethodID (class_ref, "getScansTotal", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getScansTotal);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.IStatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public unsafe string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Statistics.IStatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

	}

}
