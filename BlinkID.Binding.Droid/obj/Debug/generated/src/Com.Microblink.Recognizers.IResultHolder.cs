using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']"
	[Register ("com/microblink/recognizers/IResultHolder", "", "Com.Microblink.Recognizers.IResultHolderInvoker")]
	public partial interface IResultHolder : IJavaObject {

		bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")] get;
		}

		bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")]
		bool GetBoolean (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_IHandler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")]
		int GetInt (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='getObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getObject", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetObject_Ljava_lang_String_Handler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")]
		global::Java.Lang.Object GetObject (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='getParcelable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;", "GetGetParcelable_Ljava_lang_String_Handler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")]
		global::Android.OS.IParcelable GetParcelable (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")]
		string GetString (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='keySet' and count(parameter)=0]"
		[Register ("keySet", "()Ljava/util/Set;", "GetKeySetHandler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")]
		global::System.Collections.Generic.ICollection<string> KeySet ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers']/interface[@name='IResultHolder']/method[@name='writeToParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;)V", "GetWriteToParcel_Landroid_os_Parcel_Handler:Com.Microblink.Recognizers.IResultHolderInvoker, BlinkID.Binding.Droid")]
		void WriteToParcel (global::Android.OS.Parcel p0);

	}

	[global::Android.Runtime.Register ("com/microblink/recognizers/IResultHolder", DoNotGenerateAcw=true)]
	internal class IResultHolderInvoker : global::Java.Lang.Object, IResultHolder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/recognizers/IResultHolder");
		IntPtr class_ref;

		public static IResultHolder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResultHolder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.recognizers.IResultHolder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResultHolderInvoker); }
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		IntPtr id_isEmpty;
		public unsafe bool IsEmpty {
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEmpty);
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		IntPtr id_isValid;
		public unsafe bool IsValid {
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isValid);
			}
		}

		static Delegate cb_getBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_GetBoolean_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBoolean_Ljava_lang_String_Z;
		public unsafe bool GetBoolean (string p0, bool p1)
		{
			if (id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_getBoolean_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetInt_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInt_Ljava_lang_String_I;
		public unsafe int GetInt (string p0, int p1)
		{
			if (id_getInt_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (Handle, id_getInt_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetObject_Ljava_lang_String_Handler ()
		{
			if (cb_getObject_Ljava_lang_String_ == null)
				cb_getObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetObject_Ljava_lang_String_);
			return cb_getObject_Ljava_lang_String_;
		}

		static IntPtr n_GetObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getObject_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object GetObject (string p0)
		{
			if (id_getObject_Ljava_lang_String_ == IntPtr.Zero)
				id_getObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getParcelable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParcelable_Ljava_lang_String_Handler ()
		{
			if (cb_getParcelable_Ljava_lang_String_ == null)
				cb_getParcelable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParcelable_Ljava_lang_String_);
			return cb_getParcelable_Ljava_lang_String_;
		}

		static IntPtr n_GetParcelable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetParcelable (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getParcelable_Ljava_lang_String_;
		public unsafe global::Android.OS.IParcelable GetParcelable (string p0)
		{
			if (id_getParcelable_Ljava_lang_String_ == IntPtr.Zero)
				id_getParcelable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.OS.IParcelable __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (Handle, id_getParcelable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_;
		public unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_keySet;
#pragma warning disable 0169
		static Delegate GetKeySetHandler ()
		{
			if (cb_keySet == null)
				cb_keySet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_KeySet);
			return cb_keySet;
		}

		static IntPtr n_KeySet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.KeySet ());
		}
#pragma warning restore 0169

		IntPtr id_keySet;
		public unsafe global::System.Collections.Generic.ICollection<string> KeySet ()
		{
			if (id_keySet == IntPtr.Zero)
				id_keySet = JNIEnv.GetMethodID (class_ref, "keySet", "()Ljava/util/Set;");
			return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_keySet), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_Handler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_ == null)
				cb_writeToParcel_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteToParcel_Landroid_os_Parcel_);
			return cb_writeToParcel_Landroid_os_Parcel_;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.IResultHolder __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.IResultHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteToParcel (p0);
		}
#pragma warning restore 0169

		IntPtr id_writeToParcel_Landroid_os_Parcel_;
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0)
		{
			if (id_writeToParcel_Landroid_os_Parcel_ == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_writeToParcel_Landroid_os_Parcel_, __args);
		}

	}

}
