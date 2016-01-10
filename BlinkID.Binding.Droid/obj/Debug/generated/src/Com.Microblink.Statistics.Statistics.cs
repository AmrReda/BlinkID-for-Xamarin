using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Statistics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']"
	[global::Android.Runtime.Register ("com/microblink/statistics/Statistics", DoNotGenerateAcw=true)]
	public abstract partial class Statistics : global::Java.Lang.Object, global::Com.Microblink.Statistics.IStatistics {


		static IntPtr IIIIIllIll_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/field[@name='IIIIIllIll']"
		[Register ("IIIIIllIll")]
		protected int IIIIIllIll {
			get {
				if (IIIIIllIll_jfieldId == IntPtr.Zero)
					IIIIIllIll_jfieldId = JNIEnv.GetFieldID (class_ref, "IIIIIllIll", "I");
				return JNIEnv.GetIntField (Handle, IIIIIllIll_jfieldId);
			}
			set {
				if (IIIIIllIll_jfieldId == IntPtr.Zero)
					IIIIIllIll_jfieldId = JNIEnv.GetFieldID (class_ref, "IIIIIllIll", "I");
				try {
					JNIEnv.SetField (Handle, IIIIIllIll_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr IIllIllIII_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/field[@name='IIllIllIII']"
		[Register ("IIllIllIII")]
		protected int IIllIllIII {
			get {
				if (IIllIllIII_jfieldId == IntPtr.Zero)
					IIllIllIII_jfieldId = JNIEnv.GetFieldID (class_ref, "IIllIllIII", "I");
				return JNIEnv.GetIntField (Handle, IIllIllIII_jfieldId);
			}
			set {
				if (IIllIllIII_jfieldId == IntPtr.Zero)
					IIllIllIII_jfieldId = JNIEnv.GetFieldID (class_ref, "IIllIllIII", "I");
				try {
					JNIEnv.SetField (Handle, IIllIllIII_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr IllIIlIIII_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/field[@name='IllIIlIIII']"
		[Register ("IllIIlIIII")]
		protected string IllIIlIIII {
			get {
				if (IllIIlIIII_jfieldId == IntPtr.Zero)
					IllIIlIIII_jfieldId = JNIEnv.GetFieldID (class_ref, "IllIIlIIII", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, IllIIlIIII_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IllIIlIIII_jfieldId == IntPtr.Zero)
					IllIIlIIII_jfieldId = JNIEnv.GetFieldID (class_ref, "IllIIlIIII", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, IllIIlIIII_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr lIIIllIIlI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/field[@name='lIIIllIIlI']"
		[Register ("lIIIllIIlI")]
		protected int LIIIllIIlI {
			get {
				if (lIIIllIIlI_jfieldId == IntPtr.Zero)
					lIIIllIIlI_jfieldId = JNIEnv.GetFieldID (class_ref, "lIIIllIIlI", "I");
				return JNIEnv.GetIntField (Handle, lIIIllIIlI_jfieldId);
			}
			set {
				if (lIIIllIIlI_jfieldId == IntPtr.Zero)
					lIIIllIIlI_jfieldId = JNIEnv.GetFieldID (class_ref, "lIIIllIIlI", "I");
				try {
					JNIEnv.SetField (Handle, lIIIllIIlI_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr llllllllll_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/field[@name='llllllllll']"
		[Register ("llllllllll")]
		protected int Llllllllll {
			get {
				if (llllllllll_jfieldId == IntPtr.Zero)
					llllllllll_jfieldId = JNIEnv.GetFieldID (class_ref, "llllllllll", "I");
				return JNIEnv.GetIntField (Handle, llllllllll_jfieldId);
			}
			set {
				if (llllllllll_jfieldId == IntPtr.Zero)
					llllllllll_jfieldId = JNIEnv.GetFieldID (class_ref, "llllllllll", "I");
				try {
					JNIEnv.SetField (Handle, llllllllll_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/statistics/Statistics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Statistics); }
		}

		protected Statistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/constructor[@name='Statistics' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe Statistics (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Statistics)) {
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

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/constructor[@name='Statistics' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		protected unsafe Statistics (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Statistics)) {
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
			global::Com.Microblink.Statistics.Statistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScansCorrect;
		}
#pragma warning restore 0169

		static IntPtr id_getScansCorrect;
		public virtual unsafe int ScansCorrect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/method[@name='getScansCorrect' and count(parameter)=0]"
			[Register ("getScansCorrect", "()I", "GetGetScansCorrectHandler")]
			get {
				if (id_getScansCorrect == IntPtr.Zero)
					id_getScansCorrect = JNIEnv.GetMethodID (class_ref, "getScansCorrect", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getScansCorrect);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScansCorrect", "()I"));
				} finally {
				}
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
			global::Com.Microblink.Statistics.Statistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScansCorrectUpTo1Element;
		}
#pragma warning restore 0169

		static IntPtr id_getScansCorrectUpTo1Element;
		public virtual unsafe int ScansCorrectUpTo1Element {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/method[@name='getScansCorrectUpTo1Element' and count(parameter)=0]"
			[Register ("getScansCorrectUpTo1Element", "()I", "GetGetScansCorrectUpTo1ElementHandler")]
			get {
				if (id_getScansCorrectUpTo1Element == IntPtr.Zero)
					id_getScansCorrectUpTo1Element = JNIEnv.GetMethodID (class_ref, "getScansCorrectUpTo1Element", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getScansCorrectUpTo1Element);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScansCorrectUpTo1Element", "()I"));
				} finally {
				}
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
			global::Com.Microblink.Statistics.Statistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScansCorrectUpToMoreThan1Element;
		}
#pragma warning restore 0169

		static IntPtr id_getScansCorrectUpToMoreThan1Element;
		public virtual unsafe int ScansCorrectUpToMoreThan1Element {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/method[@name='getScansCorrectUpToMoreThan1Element' and count(parameter)=0]"
			[Register ("getScansCorrectUpToMoreThan1Element", "()I", "GetGetScansCorrectUpToMoreThan1ElementHandler")]
			get {
				if (id_getScansCorrectUpToMoreThan1Element == IntPtr.Zero)
					id_getScansCorrectUpToMoreThan1Element = JNIEnv.GetMethodID (class_ref, "getScansCorrectUpToMoreThan1Element", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getScansCorrectUpToMoreThan1Element);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScansCorrectUpToMoreThan1Element", "()I"));
				} finally {
				}
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
			global::Com.Microblink.Statistics.Statistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScansTotal;
		}
#pragma warning restore 0169

		static IntPtr id_getScansTotal;
		public virtual unsafe int ScansTotal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/method[@name='getScansTotal' and count(parameter)=0]"
			[Register ("getScansTotal", "()I", "GetGetScansTotalHandler")]
			get {
				if (id_getScansTotal == IntPtr.Zero)
					id_getScansTotal = JNIEnv.GetMethodID (class_ref, "getScansTotal", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getScansTotal);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScansTotal", "()I"));
				} finally {
				}
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
			global::Com.Microblink.Statistics.Statistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Microblink.Statistics.Statistics __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Statistics.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.statistics']/class[@name='Statistics']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/microblink/statistics/Statistics", DoNotGenerateAcw=true)]
	internal partial class StatisticsInvoker : Statistics {

		public StatisticsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatisticsInvoker); }
		}

	}

}
