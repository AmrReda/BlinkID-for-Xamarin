package mono.com.microblink.view.recognition;


public class ScanResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microblink.view.recognition.ScanResultListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onScanningDone:(Lcom/microblink/recognizers/RecognitionResults;)V:GetOnScanningDone_Lcom_microblink_recognizers_RecognitionResults_Handler:Com.Microblink.View.Recognition.IScanResultListenerInvoker, BlinkID.Binding.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Microblink.View.Recognition.IScanResultListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ScanResultListenerImplementor.class, __md_methods);
	}


	public ScanResultListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ScanResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microblink.View.Recognition.IScanResultListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onScanningDone (com.microblink.recognizers.RecognitionResults p0)
	{
		n_onScanningDone (p0);
	}

	private native void n_onScanningDone (com.microblink.recognizers.RecognitionResults p0);

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
