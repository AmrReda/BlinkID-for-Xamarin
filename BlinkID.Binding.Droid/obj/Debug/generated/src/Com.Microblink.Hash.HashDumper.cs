using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Hash {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.hash']/class[@name='HashDumper']"
	[global::Android.Runtime.Register ("com/microblink/hash/HashDumper", DoNotGenerateAcw=true)]
	public partial class HashDumper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/hash/HashDumper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HashDumper); }
		}

		protected HashDumper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.hash']/class[@name='HashDumper']/constructor[@name='HashDumper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HashDumper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HashDumper)) {
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

		static IntPtr id_dumpHashes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.hash']/class[@name='HashDumper']/method[@name='dumpHashes' and count(parameter)=0]"
		[Register ("dumpHashes", "()V", "")]
		public static unsafe void DumpHashes ()
		{
			if (id_dumpHashes == IntPtr.Zero)
				id_dumpHashes = JNIEnv.GetStaticMethodID (class_ref, "dumpHashes", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dumpHashes);
			} finally {
			}
		}

	}
}
