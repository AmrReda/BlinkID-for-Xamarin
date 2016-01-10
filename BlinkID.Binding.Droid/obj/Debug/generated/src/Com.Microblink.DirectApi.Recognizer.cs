using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.DirectApi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']"
	[global::Android.Runtime.Register ("com/microblink/directApi/Recognizer", DoNotGenerateAcw=true)]
	public partial class Recognizer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer.State']"
		[global::Android.Runtime.Register ("com/microblink/directApi/Recognizer$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr OFFLINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer.State']/field[@name='OFFLINE']"
			[Register ("OFFLINE")]
			public static global::Com.Microblink.DirectApi.Recognizer.State Offline {
				get {
					if (OFFLINE_jfieldId == IntPtr.Zero)
						OFFLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFFLINE", "Lcom/microblink/directApi/Recognizer$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OFFLINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr READY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer.State']/field[@name='READY']"
			[Register ("READY")]
			public static global::Com.Microblink.DirectApi.Recognizer.State Ready {
				get {
					if (READY_jfieldId == IntPtr.Zero)
						READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READY", "Lcom/microblink/directApi/Recognizer$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNLOCKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer.State']/field[@name='UNLOCKED']"
			[Register ("UNLOCKED")]
			public static global::Com.Microblink.DirectApi.Recognizer.State Unlocked {
				get {
					if (UNLOCKED_jfieldId == IntPtr.Zero)
						UNLOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNLOCKED", "Lcom/microblink/directApi/Recognizer$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNLOCKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WORKING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer.State']/field[@name='WORKING']"
			[Register ("WORKING")]
			public static global::Com.Microblink.DirectApi.Recognizer.State Working {
				get {
					if (WORKING_jfieldId == IntPtr.Zero)
						WORKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WORKING", "Lcom/microblink/directApi/Recognizer$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WORKING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/microblink/directApi/Recognizer$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/directApi/Recognizer$State;", "")]
			public static unsafe global::Com.Microblink.DirectApi.Recognizer.State ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/directApi/Recognizer$State;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Microblink.DirectApi.Recognizer.State __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer.State> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/microblink/directApi/Recognizer$State;", "")]
			public static unsafe global::Com.Microblink.DirectApi.Recognizer.State[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/directApi/Recognizer$State;");
				try {
					return (global::Com.Microblink.DirectApi.Recognizer.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.DirectApi.Recognizer.State));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/directApi/Recognizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Recognizer); }
		}

		protected Recognizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCurrentState;
		public unsafe global::Com.Microblink.DirectApi.Recognizer.State CurrentState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='getCurrentState' and count(parameter)=0]"
			[Register ("getCurrentState", "()Lcom/microblink/directApi/Recognizer$State;", "GetGetCurrentStateHandler")]
			get {
				if (id_getCurrentState == IntPtr.Zero)
					id_getCurrentState = JNIEnv.GetMethodID (class_ref, "getCurrentState", "()Lcom/microblink/directApi/Recognizer$State;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer.State> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentState), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSingletonInstance;
		public static unsafe global::Com.Microblink.DirectApi.Recognizer SingletonInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='getSingletonInstance' and count(parameter)=0]"
			[Register ("getSingletonInstance", "()Lcom/microblink/directApi/Recognizer;", "GetGetSingletonInstanceHandler")]
			get {
				if (id_getSingletonInstance == IntPtr.Zero)
					id_getSingletonInstance = JNIEnv.GetStaticMethodID (class_ref, "getSingletonInstance", "()Lcom/microblink/directApi/Recognizer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSingletonInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_Lcom_microblink_recognizers_settings_RecognitionSettings_Lcom_microblink_directApi_DirectApiErrorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.microblink.recognizers.settings.RecognitionSettings'] and parameter[3][@type='com.microblink.directApi.DirectApiErrorListener']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/microblink/recognizers/settings/RecognitionSettings;Lcom/microblink/directApi/DirectApiErrorListener;)V", "")]
		public unsafe void Initialize (global::Android.Content.Context p0, global::Com.Microblink.Recognizers.Settings.RecognitionSettings p1, global::Com.Microblink.DirectApi.IDirectApiErrorListener p2)
		{
			if (id_initialize_Landroid_content_Context_Lcom_microblink_recognizers_settings_RecognitionSettings_Lcom_microblink_directApi_DirectApiErrorListener_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Lcom_microblink_recognizers_settings_RecognitionSettings_Lcom_microblink_directApi_DirectApiErrorListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Landroid/content/Context;Lcom/microblink/recognizers/settings/RecognitionSettings;Lcom/microblink/directApi/DirectApiErrorListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_initialize_Landroid_content_Context_Lcom_microblink_recognizers_settings_RecognitionSettings_Lcom_microblink_directApi_DirectApiErrorListener_, __args);
			} finally {
			}
		}

		static IntPtr id_recognizeBitmap_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_geometry_Rectangle_Lcom_microblink_view_recognition_ScanResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='recognizeBitmap' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.microblink.hardware.orientation.Orientation'] and parameter[3][@type='com.microblink.geometry.Rectangle'] and parameter[4][@type='com.microblink.view.recognition.ScanResultListener']]"
		[Register ("recognizeBitmap", "(Landroid/graphics/Bitmap;Lcom/microblink/hardware/orientation/Orientation;Lcom/microblink/geometry/Rectangle;Lcom/microblink/view/recognition/ScanResultListener;)V", "")]
		public unsafe void RecognizeBitmap (global::Android.Graphics.Bitmap p0, global::Com.Microblink.Hardware.Orientation.Orientation p1, global::Com.Microblink.Geometry.Rectangle p2, global::Com.Microblink.View.Recognition.IScanResultListener p3)
		{
			if (id_recognizeBitmap_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_geometry_Rectangle_Lcom_microblink_view_recognition_ScanResultListener_ == IntPtr.Zero)
				id_recognizeBitmap_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_geometry_Rectangle_Lcom_microblink_view_recognition_ScanResultListener_ = JNIEnv.GetMethodID (class_ref, "recognizeBitmap", "(Landroid/graphics/Bitmap;Lcom/microblink/hardware/orientation/Orientation;Lcom/microblink/geometry/Rectangle;Lcom/microblink/view/recognition/ScanResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_recognizeBitmap_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_geometry_Rectangle_Lcom_microblink_view_recognition_ScanResultListener_, __args);
			} finally {
			}
		}

		static IntPtr id_recognizeBitmap_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_view_recognition_ScanResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='recognizeBitmap' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.microblink.hardware.orientation.Orientation'] and parameter[3][@type='com.microblink.view.recognition.ScanResultListener']]"
		[Register ("recognizeBitmap", "(Landroid/graphics/Bitmap;Lcom/microblink/hardware/orientation/Orientation;Lcom/microblink/view/recognition/ScanResultListener;)V", "")]
		public unsafe void RecognizeBitmap (global::Android.Graphics.Bitmap p0, global::Com.Microblink.Hardware.Orientation.Orientation p1, global::Com.Microblink.View.Recognition.IScanResultListener p2)
		{
			if (id_recognizeBitmap_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_view_recognition_ScanResultListener_ == IntPtr.Zero)
				id_recognizeBitmap_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_view_recognition_ScanResultListener_ = JNIEnv.GetMethodID (class_ref, "recognizeBitmap", "(Landroid/graphics/Bitmap;Lcom/microblink/hardware/orientation/Orientation;Lcom/microblink/view/recognition/ScanResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_recognizeBitmap_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_view_recognition_ScanResultListener_, __args);
			} finally {
			}
		}

		static IntPtr id_recognizeBitmapWithSettings_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_geometry_Rectangle_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='recognizeBitmapWithSettings' and count(parameter)=5 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.microblink.hardware.orientation.Orientation'] and parameter[3][@type='com.microblink.geometry.Rectangle'] and parameter[4][@type='com.microblink.view.recognition.ScanResultListener'] and parameter[5][@type='com.microblink.recognizers.settings.RecognitionSettings']]"
		[Register ("recognizeBitmapWithSettings", "(Landroid/graphics/Bitmap;Lcom/microblink/hardware/orientation/Orientation;Lcom/microblink/geometry/Rectangle;Lcom/microblink/view/recognition/ScanResultListener;Lcom/microblink/recognizers/settings/RecognitionSettings;)V", "")]
		public unsafe void RecognizeBitmapWithSettings (global::Android.Graphics.Bitmap p0, global::Com.Microblink.Hardware.Orientation.Orientation p1, global::Com.Microblink.Geometry.Rectangle p2, global::Com.Microblink.View.Recognition.IScanResultListener p3, global::Com.Microblink.Recognizers.Settings.RecognitionSettings p4)
		{
			if (id_recognizeBitmapWithSettings_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_geometry_Rectangle_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_ == IntPtr.Zero)
				id_recognizeBitmapWithSettings_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_geometry_Rectangle_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_ = JNIEnv.GetMethodID (class_ref, "recognizeBitmapWithSettings", "(Landroid/graphics/Bitmap;Lcom/microblink/hardware/orientation/Orientation;Lcom/microblink/geometry/Rectangle;Lcom/microblink/view/recognition/ScanResultListener;Lcom/microblink/recognizers/settings/RecognitionSettings;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod  (Handle, id_recognizeBitmapWithSettings_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_geometry_Rectangle_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_, __args);
			} finally {
			}
		}

		static IntPtr id_recognizeBitmapWithSettings_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='recognizeBitmapWithSettings' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.microblink.hardware.orientation.Orientation'] and parameter[3][@type='com.microblink.view.recognition.ScanResultListener'] and parameter[4][@type='com.microblink.recognizers.settings.RecognitionSettings']]"
		[Register ("recognizeBitmapWithSettings", "(Landroid/graphics/Bitmap;Lcom/microblink/hardware/orientation/Orientation;Lcom/microblink/view/recognition/ScanResultListener;Lcom/microblink/recognizers/settings/RecognitionSettings;)V", "")]
		public unsafe void RecognizeBitmapWithSettings (global::Android.Graphics.Bitmap p0, global::Com.Microblink.Hardware.Orientation.Orientation p1, global::Com.Microblink.View.Recognition.IScanResultListener p2, global::Com.Microblink.Recognizers.Settings.RecognitionSettings p3)
		{
			if (id_recognizeBitmapWithSettings_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_ == IntPtr.Zero)
				id_recognizeBitmapWithSettings_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_ = JNIEnv.GetMethodID (class_ref, "recognizeBitmapWithSettings", "(Landroid/graphics/Bitmap;Lcom/microblink/hardware/orientation/Orientation;Lcom/microblink/view/recognition/ScanResultListener;Lcom/microblink/recognizers/settings/RecognitionSettings;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod  (Handle, id_recognizeBitmapWithSettings_Landroid_graphics_Bitmap_Lcom_microblink_hardware_orientation_Orientation_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_, __args);
			} finally {
			}
		}

		static IntPtr id_recognizeImage_Lcom_microblink_image_Image_Lcom_microblink_view_recognition_ScanResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='recognizeImage' and count(parameter)=2 and parameter[1][@type='com.microblink.image.Image'] and parameter[2][@type='com.microblink.view.recognition.ScanResultListener']]"
		[Register ("recognizeImage", "(Lcom/microblink/image/Image;Lcom/microblink/view/recognition/ScanResultListener;)V", "")]
		public unsafe void RecognizeImage (global::Com.Microblink.Image.Image p0, global::Com.Microblink.View.Recognition.IScanResultListener p1)
		{
			if (id_recognizeImage_Lcom_microblink_image_Image_Lcom_microblink_view_recognition_ScanResultListener_ == IntPtr.Zero)
				id_recognizeImage_Lcom_microblink_image_Image_Lcom_microblink_view_recognition_ScanResultListener_ = JNIEnv.GetMethodID (class_ref, "recognizeImage", "(Lcom/microblink/image/Image;Lcom/microblink/view/recognition/ScanResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_recognizeImage_Lcom_microblink_image_Image_Lcom_microblink_view_recognition_ScanResultListener_, __args);
			} finally {
			}
		}

		static IntPtr id_recognizeImageWithSettings_Lcom_microblink_image_Image_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='recognizeImageWithSettings' and count(parameter)=3 and parameter[1][@type='com.microblink.image.Image'] and parameter[2][@type='com.microblink.view.recognition.ScanResultListener'] and parameter[3][@type='com.microblink.recognizers.settings.RecognitionSettings']]"
		[Register ("recognizeImageWithSettings", "(Lcom/microblink/image/Image;Lcom/microblink/view/recognition/ScanResultListener;Lcom/microblink/recognizers/settings/RecognitionSettings;)V", "")]
		public unsafe void RecognizeImageWithSettings (global::Com.Microblink.Image.Image p0, global::Com.Microblink.View.Recognition.IScanResultListener p1, global::Com.Microblink.Recognizers.Settings.RecognitionSettings p2)
		{
			if (id_recognizeImageWithSettings_Lcom_microblink_image_Image_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_ == IntPtr.Zero)
				id_recognizeImageWithSettings_Lcom_microblink_image_Image_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_ = JNIEnv.GetMethodID (class_ref, "recognizeImageWithSettings", "(Lcom/microblink/image/Image;Lcom/microblink/view/recognition/ScanResultListener;Lcom/microblink/recognizers/settings/RecognitionSettings;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_recognizeImageWithSettings_Lcom_microblink_image_Image_Lcom_microblink_view_recognition_ScanResultListener_Lcom_microblink_recognizers_settings_RecognitionSettings_, __args);
			} finally {
			}
		}

		static IntPtr id_setLicenseKey_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='setLicenseKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setLicenseKey", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe void SetLicenseKey (global::Android.Content.Context p0, string p1)
		{
			if (id_setLicenseKey_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setLicenseKey_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLicenseKey", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_setLicenseKey_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setLicenseKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='setLicenseKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setLicenseKey", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetLicenseKey (string p0, string p1)
		{
			if (id_setLicenseKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setLicenseKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLicenseKey", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_setLicenseKey_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_;
#pragma warning disable 0169
		static Delegate GetSetMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_Handler ()
		{
			if (cb_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ == null)
				cb_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_);
			return cb_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_;
		}

		static void n_SetMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Microblink.DirectApi.Recognizer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Metadata.IMetadataListener p0 = (global::Com.Microblink.Metadata.IMetadataListener)global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.IMetadataListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Metadata.MetadataSettings p1 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.MetadataSettings> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMetadataListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='setMetadataListener' and count(parameter)=2 and parameter[1][@type='com.microblink.metadata.MetadataListener'] and parameter[2][@type='com.microblink.metadata.MetadataSettings']]"
		[Register ("setMetadataListener", "(Lcom/microblink/metadata/MetadataListener;Lcom/microblink/metadata/MetadataSettings;)V", "GetSetMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_Handler")]
		public virtual unsafe void SetMetadataListener (global::Com.Microblink.Metadata.IMetadataListener p0, global::Com.Microblink.Metadata.MetadataSettings p1)
		{
			if (id_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ == IntPtr.Zero)
				id_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_ = JNIEnv.GetMethodID (class_ref, "setMetadataListener", "(Lcom/microblink/metadata/MetadataListener;Lcom/microblink/metadata/MetadataSettings;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMetadataListener_Lcom_microblink_metadata_MetadataListener_Lcom_microblink_metadata_MetadataSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadataListener", "(Lcom/microblink/metadata/MetadataListener;Lcom/microblink/metadata/MetadataSettings;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_terminate;
#pragma warning disable 0169
		static Delegate GetTerminateHandler ()
		{
			if (cb_terminate == null)
				cb_terminate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Terminate);
			return cb_terminate;
		}

		static void n_Terminate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.DirectApi.Recognizer __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.DirectApi.Recognizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Terminate ();
		}
#pragma warning restore 0169

		static IntPtr id_terminate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.directApi']/class[@name='Recognizer']/method[@name='terminate' and count(parameter)=0]"
		[Register ("terminate", "()V", "GetTerminateHandler")]
		public virtual unsafe void Terminate ()
		{
			if (id_terminate == IntPtr.Zero)
				id_terminate = JNIEnv.GetMethodID (class_ref, "terminate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_terminate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "terminate", "()V"));
			} finally {
			}
		}

	}
}
