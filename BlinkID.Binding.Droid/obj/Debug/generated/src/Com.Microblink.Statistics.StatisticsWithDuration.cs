using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Statistics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.statistics']/class[@name='StatisticsWithDuration']"
	[global::Android.Runtime.Register ("com/microblink/statistics/StatisticsWithDuration", DoNotGenerateAcw=true)]
	public abstract partial class StatisticsWithDuration : global::Com.Microblink.Statistics.Statistics, global::Com.Microblink.Statistics.IStatisticsWithDuration {


		static IntPtr IIIIIlIIII_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.statistics']/class[@name='StatisticsWithDuration']/field[@name='IIIIIlIIII']"
		[Register ("IIIIIlIIII")]
		protected int IIIIIlIIII {
			get {
				if (IIIIIlIIII_jfieldId == IntPtr.Zero)
					IIIIIlIIII_jfieldId = JNIEnv.GetFieldID (class_ref, "IIIIIlIIII", "I");
				return JNIEnv.GetIntField (Handle, IIIIIlIIII_jfieldId);
			}
			set {
				if (IIIIIlIIII_jfieldId == IntPtr.Zero)
					IIIIIlIIII_jfieldId = JNIEnv.GetFieldID (class_ref, "IIIIIlIIII", "I");
				try {
					JNIEnv.SetField (Handle, IIIIIlIIII_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr IlIllIlllI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.statistics']/class[@name='StatisticsWithDuration']/field[@name='IlIllIlllI']"
		[Register ("IlIllIlllI")]
		protected long IlIllIlllI {
			get {
				if (IlIllIlllI_jfieldId == IntPtr.Zero)
					IlIllIlllI_jfieldId = JNIEnv.GetFieldID (class_ref, "IlIllIlllI", "J");
				return JNIEnv.GetLongField (Handle, IlIllIlllI_jfieldId);
			}
			set {
				if (IlIllIlllI_jfieldId == IntPtr.Zero)
					IlIllIlllI_jfieldId = JNIEnv.GetFieldID (class_ref, "IlIllIlllI", "J");
				try {
					JNIEnv.SetField (Handle, IlIllIlllI_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/statistics/StatisticsWithDuration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatisticsWithDuration); }
		}

		protected StatisticsWithDuration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.statistics']/class[@name='StatisticsWithDuration']/constructor[@name='StatisticsWithDuration' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		protected unsafe StatisticsWithDuration (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StatisticsWithDuration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.statistics']/class[@name='StatisticsWithDuration']/constructor[@name='StatisticsWithDuration' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe StatisticsWithDuration (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (StatisticsWithDuration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Microblink.Statistics.StatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.StatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AverageScanDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getAverageScanDuration;
		public virtual unsafe long AverageScanDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='StatisticsWithDuration']/method[@name='getAverageScanDuration' and count(parameter)=0]"
			[Register ("getAverageScanDuration", "()J", "GetGetAverageScanDurationHandler")]
			get {
				if (id_getAverageScanDuration == IntPtr.Zero)
					id_getAverageScanDuration = JNIEnv.GetMethodID (class_ref, "getAverageScanDuration", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getAverageScanDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAverageScanDuration", "()J"));
				} finally {
				}
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
			global::Com.Microblink.Statistics.StatisticsWithDuration __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.StatisticsWithDuration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfCancels;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfCancels;
		public virtual unsafe int NumberOfCancels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='StatisticsWithDuration']/method[@name='getNumberOfCancels' and count(parameter)=0]"
			[Register ("getNumberOfCancels", "()I", "GetGetNumberOfCancelsHandler")]
			get {
				if (id_getNumberOfCancels == IntPtr.Zero)
					id_getNumberOfCancels = JNIEnv.GetMethodID (class_ref, "getNumberOfCancels", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumberOfCancels);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfCancels", "()I"));
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/microblink/statistics/StatisticsWithDuration", DoNotGenerateAcw=true)]
	internal partial class StatisticsWithDurationInvoker : StatisticsWithDuration {

		public StatisticsWithDurationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatisticsWithDurationInvoker); }
		}

	}

}
