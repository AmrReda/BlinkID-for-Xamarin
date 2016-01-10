using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hardware.Orientation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']"
	[global::Android.Runtime.Register ("com/microblink/hardware/orientation/Orientation", DoNotGenerateAcw=true)]
	public sealed partial class Orientation : global::Java.Lang.Enum {


		static IntPtr ORIENTATION_LANDSCAPE_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/field[@name='ORIENTATION_LANDSCAPE_LEFT']"
		[Register ("ORIENTATION_LANDSCAPE_LEFT")]
		public static global::Com.Microblink.Hardware.Orientation.Orientation OrientationLandscapeLeft {
			get {
				if (ORIENTATION_LANDSCAPE_LEFT_jfieldId == IntPtr.Zero)
					ORIENTATION_LANDSCAPE_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORIENTATION_LANDSCAPE_LEFT", "Lcom/microblink/hardware/orientation/Orientation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORIENTATION_LANDSCAPE_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ORIENTATION_LANDSCAPE_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/field[@name='ORIENTATION_LANDSCAPE_RIGHT']"
		[Register ("ORIENTATION_LANDSCAPE_RIGHT")]
		public static global::Com.Microblink.Hardware.Orientation.Orientation OrientationLandscapeRight {
			get {
				if (ORIENTATION_LANDSCAPE_RIGHT_jfieldId == IntPtr.Zero)
					ORIENTATION_LANDSCAPE_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORIENTATION_LANDSCAPE_RIGHT", "Lcom/microblink/hardware/orientation/Orientation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORIENTATION_LANDSCAPE_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ORIENTATION_PORTRAIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/field[@name='ORIENTATION_PORTRAIT']"
		[Register ("ORIENTATION_PORTRAIT")]
		public static global::Com.Microblink.Hardware.Orientation.Orientation OrientationPortrait {
			get {
				if (ORIENTATION_PORTRAIT_jfieldId == IntPtr.Zero)
					ORIENTATION_PORTRAIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORIENTATION_PORTRAIT", "Lcom/microblink/hardware/orientation/Orientation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORIENTATION_PORTRAIT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ORIENTATION_PORTRAIT_UPSIDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/field[@name='ORIENTATION_PORTRAIT_UPSIDE']"
		[Register ("ORIENTATION_PORTRAIT_UPSIDE")]
		public static global::Com.Microblink.Hardware.Orientation.Orientation OrientationPortraitUpside {
			get {
				if (ORIENTATION_PORTRAIT_UPSIDE_jfieldId == IntPtr.Zero)
					ORIENTATION_PORTRAIT_UPSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORIENTATION_PORTRAIT_UPSIDE", "Lcom/microblink/hardware/orientation/Orientation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORIENTATION_PORTRAIT_UPSIDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ORIENTATION_UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/field[@name='ORIENTATION_UNKNOWN']"
		[Register ("ORIENTATION_UNKNOWN")]
		public static global::Com.Microblink.Hardware.Orientation.Orientation OrientationUnknown {
			get {
				if (ORIENTATION_UNKNOWN_jfieldId == IntPtr.Zero)
					ORIENTATION_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORIENTATION_UNKNOWN", "Lcom/microblink/hardware/orientation/Orientation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORIENTATION_UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/hardware/orientation/Orientation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Orientation); }
		}

		internal Orientation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isHorizontal;
		public unsafe bool IsHorizontal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='isHorizontal' and count(parameter)=0]"
			[Register ("isHorizontal", "()Z", "GetIsHorizontalHandler")]
			get {
				if (id_isHorizontal == IntPtr.Zero)
					id_isHorizontal = JNIEnv.GetMethodID (class_ref, "isHorizontal", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isHorizontal);
				} finally {
				}
			}
		}

		static IntPtr id_isVertical;
		public unsafe bool IsVertical {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='isVertical' and count(parameter)=0]"
			[Register ("isVertical", "()Z", "GetIsVerticalHandler")]
			get {
				if (id_isVertical == IntPtr.Zero)
					id_isVertical = JNIEnv.GetMethodID (class_ref, "isVertical", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isVertical);
				} finally {
				}
			}
		}

		static IntPtr id_fromInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromInt", "(I)Lcom/microblink/hardware/orientation/Orientation;", "")]
		public static unsafe global::Com.Microblink.Hardware.Orientation.Orientation FromInt (int p0)
		{
			if (id_fromInt_I == IntPtr.Zero)
				id_fromInt_I = JNIEnv.GetStaticMethodID (class_ref, "fromInt", "(I)Lcom/microblink/hardware/orientation/Orientation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInt_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_intValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='intValue' and count(parameter)=0]"
		[Register ("intValue", "()I", "")]
		public unsafe int IntValue ()
		{
			if (id_intValue == IntPtr.Zero)
				id_intValue = JNIEnv.GetMethodID (class_ref, "intValue", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_intValue);
			} finally {
			}
		}

		static IntPtr id_rotate180;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='rotate180' and count(parameter)=0]"
		[Register ("rotate180", "()Lcom/microblink/hardware/orientation/Orientation;", "")]
		public unsafe global::Com.Microblink.Hardware.Orientation.Orientation Rotate180 ()
		{
			if (id_rotate180 == IntPtr.Zero)
				id_rotate180 = JNIEnv.GetMethodID (class_ref, "rotate180", "()Lcom/microblink/hardware/orientation/Orientation;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_rotate180), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotate90Clockwise;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='rotate90Clockwise' and count(parameter)=0]"
		[Register ("rotate90Clockwise", "()Lcom/microblink/hardware/orientation/Orientation;", "")]
		public unsafe global::Com.Microblink.Hardware.Orientation.Orientation Rotate90Clockwise ()
		{
			if (id_rotate90Clockwise == IntPtr.Zero)
				id_rotate90Clockwise = JNIEnv.GetMethodID (class_ref, "rotate90Clockwise", "()Lcom/microblink/hardware/orientation/Orientation;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_rotate90Clockwise), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_rotate90CounterClockwise;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='rotate90CounterClockwise' and count(parameter)=0]"
		[Register ("rotate90CounterClockwise", "()Lcom/microblink/hardware/orientation/Orientation;", "")]
		public unsafe global::Com.Microblink.Hardware.Orientation.Orientation Rotate90CounterClockwise ()
		{
			if (id_rotate90CounterClockwise == IntPtr.Zero)
				id_rotate90CounterClockwise = JNIEnv.GetMethodID (class_ref, "rotate90CounterClockwise", "()Lcom/microblink/hardware/orientation/Orientation;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallObjectMethod  (Handle, id_rotate90CounterClockwise), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/microblink/hardware/orientation/Orientation;", "")]
		public static unsafe global::Com.Microblink.Hardware.Orientation.Orientation ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/microblink/hardware/orientation/Orientation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Microblink.Hardware.Orientation.Orientation __ret = global::Java.Lang.Object.GetObject<global::Com.Microblink.Hardware.Orientation.Orientation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hardware.orientation']/class[@name='Orientation']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/microblink/hardware/orientation/Orientation;", "")]
		public static unsafe global::Com.Microblink.Hardware.Orientation.Orientation[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/microblink/hardware/orientation/Orientation;");
			try {
				return (global::Com.Microblink.Hardware.Orientation.Orientation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Microblink.Hardware.Orientation.Orientation));
			} finally {
			}
		}

	}
}
