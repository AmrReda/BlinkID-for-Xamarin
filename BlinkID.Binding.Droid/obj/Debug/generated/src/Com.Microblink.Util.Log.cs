using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']"
	[global::Android.Runtime.Register ("com/microblink/util/Log", DoNotGenerateAcw=true)]
	public partial class Log : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.util']/class[@name='Log.LogLevel']"
		[global::Android.Runtime.Register ("com/microblink/util/Log$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {


			static IntPtr LOG_DEBUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='Log.LogLevel']/field[@name='LOG_DEBUG']"
			[Register ("LOG_DEBUG")]
			public static global::Com.Microblink.Util.Log.LogLevel LogDebug {
				get {
					if (LOG_DEBUG_jfieldId == IntPtr.Zero)
						LOG_DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG_DEBUG", "Lcom/microblink/util/Log$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_DEBUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOG_INFORMATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='Log.LogLevel']/field[@name='LOG_INFORMATION']"
			[Register ("LOG_INFORMATION")]
			public static global::Com.Microblink.Util.Log.LogLevel LogInformation {
				get {
					if (LOG_INFORMATION_jfieldId == IntPtr.Zero)
						LOG_INFORMATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG_INFORMATION", "Lcom/microblink/util/Log$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_INFORMATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOG_VERBOSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='Log.LogLevel']/field[@name='LOG_VERBOSE']"
			[Register ("LOG_VERBOSE")]
			public static global::Com.Microblink.Util.Log.LogLevel LogVerbose {
				get {
					if (LOG_VERBOSE_jfieldId == IntPtr.Zero)
						LOG_VERBOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG_VERBOSE", "Lcom/microblink/util/Log$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_VERBOSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOG_WARNINGS_AND_ERRORS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.util']/class[@name='Log.LogLevel']/field[@name='LOG_WARNINGS_AND_ERRORS']"
			[Register ("LOG_WARNINGS_AND_ERRORS")]
			public static global::Com.Microblink.Util.Log.LogLevel LogWarningsAndErrors {
				get {
					if (LOG_WARNINGS_AND_ERRORS_jfieldId == IntPtr.Zero)
						LOG_WARNINGS_AND_ERRORS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG_WARNINGS_AND_ERRORS", "Lcom/microblink/util/Log$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_WARNINGS_AND_ERRORS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/util/Log$LogLevel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LogLevel); }
			}

			internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/util/Log$LogLevel;", "")]
			public static unsafe global::Com.Microblink.Util.Log.LogLevel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/util/Log$LogLevel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Microblink.Util.Log.LogLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.Log.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microblink/util/Log$LogLevel;", "")]
			public static unsafe global::Com.Microblink.Util.Log.LogLevel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/util/Log$LogLevel;");
				try {
					return (global::Com.Microblink.Util.Log.LogLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Util.Log.LogLevel));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/util/Log", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Log); }
		}

		protected Log (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/constructor[@name='Log' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Log ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Log)) {
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

		static IntPtr id_getCurrentLogLevel;
		public static unsafe global::Com.Microblink.Util.Log.LogLevel CurrentLogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='getCurrentLogLevel' and count(parameter)=0]"
			[Register ("getCurrentLogLevel", "()Lcom/microblink/util/Log$LogLevel;", "GetGetCurrentLogLevelHandler")]
			get {
				if (id_getCurrentLogLevel == IntPtr.Zero)
					id_getCurrentLogLevel = JNIEnv.GetStaticMethodID (class_ref, "getCurrentLogLevel", "()Lcom/microblink/util/Log$LogLevel;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.Util.Log.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentLogLevel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLineNumber;
		public static unsafe int LineNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='getLineNumber' and count(parameter)=0]"
			[Register ("getLineNumber", "()I", "GetGetLineNumberHandler")]
			get {
				if (id_getLineNumber == IntPtr.Zero)
					id_getLineNumber = JNIEnv.GetStaticMethodID (class_ref, "getLineNumber", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getLineNumber);
				} finally {
				}
			}
		}

		static IntPtr id_getLogFolder;
		public static unsafe string LogFolder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='getLogFolder' and count(parameter)=0]"
			[Register ("getLogFolder", "()Ljava/lang/String;", "GetGetLogFolderHandler")]
			get {
				if (id_getLogFolder == IntPtr.Zero)
					id_getLogFolder = JNIEnv.GetStaticMethodID (class_ref, "getLogFolder", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogFolder), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_d_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_d_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_d_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='d' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (global::Java.Lang.Object p0, global::Java.Lang.Throwable p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_d_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_disableFileLogging;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='disableFileLogging' and count(parameter)=0]"
		[Register ("disableFileLogging", "()V", "")]
		public static unsafe void DisableFileLogging ()
		{
			if (id_disableFileLogging == IntPtr.Zero)
				id_disableFileLogging = JNIEnv.GetStaticMethodID (class_ref, "disableFileLogging", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableFileLogging);
			} finally {
			}
		}

		static IntPtr id_e_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_e_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='e' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (global::Java.Lang.Object p0, global::Java.Lang.Throwable p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_e_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_enableFileLogging;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='enableFileLogging' and count(parameter)=0]"
		[Register ("enableFileLogging", "()V", "")]
		public static unsafe void EnableFileLogging ()
		{
			if (id_enableFileLogging == IntPtr.Zero)
				id_enableFileLogging = JNIEnv.GetStaticMethodID (class_ref, "enableFileLogging", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableFileLogging);
			} finally {
			}
		}

		static IntPtr id_i_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_i_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_i_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='i' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (global::Java.Lang.Object p0, global::Java.Lang.Throwable p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_i_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_i_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_setApplicationContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='setApplicationContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setApplicationContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetApplicationContext (global::Android.Content.Context p0)
		{
			if (id_setApplicationContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setApplicationContext_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setApplicationContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setApplicationContext_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogLevel_Lcom_microblink_util_Log_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.microblink.util.Log.LogLevel']]"
		[Register ("setLogLevel", "(Lcom/microblink/util/Log$LogLevel;)V", "")]
		public static unsafe void SetLogLevel (global::Com.Microblink.Util.Log.LogLevel p0)
		{
			if (id_setLogLevel_Lcom_microblink_util_Log_LogLevel_ == IntPtr.Zero)
				id_setLogLevel_Lcom_microblink_util_Log_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(Lcom/microblink/util/Log$LogLevel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_Lcom_microblink_util_Log_LogLevel_, __args);
			} finally {
			}
		}

		static IntPtr id_v_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_v_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_v_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_v_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='v' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (global::Java.Lang.Object p0, global::Java.Lang.Throwable p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_v_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_v_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_w_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_w_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_w_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='w' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (global::Java.Lang.Object p0, global::Java.Lang.Throwable p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_w_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_w_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_wtf_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='wtf' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_wtf_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_wtf_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.util']/class[@name='Log']/method[@name='wtf' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (global::Java.Lang.Object p0, global::Java.Lang.Throwable p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_wtf_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/Object;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_Object_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
