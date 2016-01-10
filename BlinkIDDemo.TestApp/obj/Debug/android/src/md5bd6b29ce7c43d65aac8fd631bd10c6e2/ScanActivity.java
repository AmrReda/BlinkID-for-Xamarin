package md5bd6b29ce7c43d65aac8fd631bd10c6e2;


public class ScanActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		com.microblink.view.CameraEventsListener,
		com.microblink.view.recognition.ScanResultListener,
		com.microblink.hardware.camera.camera1.focus.AutofocusListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onCameraPermissionDenied:()V:GetOnCameraPermissionDeniedHandler:Com.Microblink.View.ICameraEventsListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onCameraPreviewStarted:()V:GetOnCameraPreviewStartedHandler:Com.Microblink.View.ICameraEventsListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onCameraPreviewStopped:()V:GetOnCameraPreviewStoppedHandler:Com.Microblink.View.ICameraEventsListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onError:(Ljava/lang/Throwable;)V:GetOnError_Ljava_lang_Throwable_Handler:Com.Microblink.View.ICameraEventsListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onScanningDone:(Lcom/microblink/recognizers/RecognitionResults;)V:GetOnScanningDone_Lcom_microblink_recognizers_RecognitionResults_Handler:Com.Microblink.View.Recognition.IScanResultListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onAutofocusFailed:()V:GetOnAutofocusFailedHandler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onAutofocusStarted:([Landroid/graphics/Rect;)V:GetOnAutofocusStarted_arrayLandroid_graphics_Rect_Handler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onAutofocusStopped:([Landroid/graphics/Rect;)V:GetOnAutofocusStopped_arrayLandroid_graphics_Rect_Handler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid\n" +
			"";
		mono.android.Runtime.register ("BlinkIDDemo.TestApp.ScanActivity, BlinkIDDemo.TestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ScanActivity.class, __md_methods);
	}


	public ScanActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ScanActivity.class)
			mono.android.TypeManager.Activate ("BlinkIDDemo.TestApp.ScanActivity, BlinkIDDemo.TestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


	public void onCameraPermissionDenied ()
	{
		n_onCameraPermissionDenied ();
	}

	private native void n_onCameraPermissionDenied ();


	public void onCameraPreviewStarted ()
	{
		n_onCameraPreviewStarted ();
	}

	private native void n_onCameraPreviewStarted ();


	public void onCameraPreviewStopped ()
	{
		n_onCameraPreviewStopped ();
	}

	private native void n_onCameraPreviewStopped ();


	public void onError (java.lang.Throwable p0)
	{
		n_onError (p0);
	}

	private native void n_onError (java.lang.Throwable p0);


	public void onScanningDone (com.microblink.recognizers.RecognitionResults p0)
	{
		n_onScanningDone (p0);
	}

	private native void n_onScanningDone (com.microblink.recognizers.RecognitionResults p0);


	public void onAutofocusFailed ()
	{
		n_onAutofocusFailed ();
	}

	private native void n_onAutofocusFailed ();


	public void onAutofocusStarted (android.graphics.Rect[] p0)
	{
		n_onAutofocusStarted (p0);
	}

	private native void n_onAutofocusStarted (android.graphics.Rect[] p0);


	public void onAutofocusStopped (android.graphics.Rect[] p0)
	{
		n_onAutofocusStopped (p0);
	}

	private native void n_onAutofocusStopped (android.graphics.Rect[] p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
