using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Statistics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatistics']"
	[Register ("com/microblink/statistics/IStatistics", "", "Com.Microblink.Statistics.IStatisticsInvoker")]
	public partial interface IStatistics : IJavaObject {

		int ScansCorrect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatistics']/method[@name='getScansCorrect' and count(parameter)=0]"
			[Register ("getScansCorrect", "()I", "GetGetScansCorrectHandler:Com.Microblink.Statistics.IStatisticsInvoker, BlinkID.Binding.Droid")] get;
		}

		int ScansCorrectUpTo1Element {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatistics']/method[@name='getScansCorrectUpTo1Element' and count(parameter)=0]"
			[Register ("getScansCorrectUpTo1Element", "()I", "GetGetScansCorrectUpTo1ElementHandler:Com.Microblink.Statistics.IStatisticsInvoker, BlinkID.Binding.Droid")] get;
		}

		int ScansCorrectUpToMoreThan1Element {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatistics']/method[@name='getScansCorrectUpToMoreThan1Element' and count(parameter)=0]"
			[Register ("getScansCorrectUpToMoreThan1Element", "()I", "GetGetScansCorrectUpToMoreThan1ElementHandler:Com.Microblink.Statistics.IStatisticsInvoker, BlinkID.Binding.Droid")] get;
		}

		int ScansTotal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatistics']/method[@name='getScansTotal' and count(parameter)=0]"
			[Register ("getScansTotal", "()I", "GetGetScansTotalHandler:Com.Microblink.Statistics.IStatisticsInvoker, BlinkID.Binding.Droid")] get;
		}

		string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatistics']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.Microblink.Statistics.IStatisticsInvoker, BlinkID.Binding.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/interface[@name='IStatistics']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Microblink.Statistics.IStatisticsInvoker, BlinkID.Binding.Droid")]
		void Clear ();

	}

	[global::Android.Runtime.Register ("com/microblink/statistics/IStatistics", DoNotGenerateAcw=true)]
	internal class IStatisticsInvoker : global::Java.Lang.Object, IStatistics {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/statistics/IStatistics");
		IntPtr class_ref;

		public static IStatistics GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatistics> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.statistics.IStatistics"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatisticsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStatisticsInvoker); }
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
			global::Com.Microblink.Statistics.IStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Microblink.Statistics.IStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Microblink.Statistics.IStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Microblink.Statistics.IStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Microblink.Statistics.IStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Microblink.Statistics.IStatistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.IStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
