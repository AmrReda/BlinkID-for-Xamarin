using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Metadata {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.microblink.metadata']/interface[@name='MetadataListener']"
	[Register ("com/microblink/metadata/MetadataListener", "", "Com.Microblink.Metadata.IMetadataListenerInvoker")]
	public partial interface IMetadataListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.metadata']/interface[@name='MetadataListener']/method[@name='onMetadataAvailable' and count(parameter)=1 and parameter[1][@type='com.microblink.metadata.Metadata']]"
		[Register ("onMetadataAvailable", "(Lcom/microblink/metadata/Metadata;)V", "GetOnMetadataAvailable_Lcom_microblink_metadata_Metadata_Handler:Com.Microblink.Metadata.IMetadataListenerInvoker, BlinkID.Binding.Droid")]
		void OnMetadataAvailable (global::Com.Microblink.Metadata.Metadata p0);

	}

	[global::Android.Runtime.Register ("com/microblink/metadata/MetadataListener", DoNotGenerateAcw=true)]
	internal class IMetadataListenerInvoker : global::Java.Lang.Object, IMetadataListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/microblink/metadata/MetadataListener");
		IntPtr class_ref;

		public static IMetadataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetadataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.microblink.metadata.MetadataListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetadataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMetadataListenerInvoker); }
		}

		static Delegate cb_onMetadataAvailable_Lcom_microblink_metadata_Metadata_;
#pragma warning disable 0169
		static Delegate GetOnMetadataAvailable_Lcom_microblink_metadata_Metadata_Handler ()
		{
			if (cb_onMetadataAvailable_Lcom_microblink_metadata_Metadata_ == null)
				cb_onMetadataAvailable_Lcom_microblink_metadata_Metadata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMetadataAvailable_Lcom_microblink_metadata_Metadata_);
			return cb_onMetadataAvailable_Lcom_microblink_metadata_Metadata_;
		}

		static void n_OnMetadataAvailable_Lcom_microblink_metadata_Metadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Metadata.IMetadataListener __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.IMetadataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Microblink.Metadata.Metadata p0 = global::Java.Lang.Object.GetObject<global::Com.Microblink.Metadata.Metadata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMetadataAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMetadataAvailable_Lcom_microblink_metadata_Metadata_;
		public unsafe void OnMetadataAvailable (global::Com.Microblink.Metadata.Metadata p0)
		{
			if (id_onMetadataAvailable_Lcom_microblink_metadata_Metadata_ == IntPtr.Zero)
				id_onMetadataAvailable_Lcom_microblink_metadata_Metadata_ = JNIEnv.GetMethodID (class_ref, "onMetadataAvailable", "(Lcom/microblink/metadata/Metadata;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onMetadataAvailable_Lcom_microblink_metadata_Metadata_, __args);
		}

	}

	public partial class MetadataEventArgs : global::System.EventArgs {

		public MetadataEventArgs (global::Com.Microblink.Metadata.Metadata p0)
		{
			this.p0 = p0;
		}

		global::Com.Microblink.Metadata.Metadata p0;
		public global::Com.Microblink.Metadata.Metadata P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/microblink/metadata/MetadataListenerImplementor")]
	internal sealed partial class IMetadataListenerImplementor : global::Java.Lang.Object, IMetadataListener {

		object sender;

		public IMetadataListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/microblink/metadata/MetadataListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MetadataEventArgs> Handler;
#pragma warning restore 0649

		public void OnMetadataAvailable (global::Com.Microblink.Metadata.Metadata p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MetadataEventArgs (p0));
		}

		internal static bool __IsEmpty (IMetadataListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
