package mono.com.microblink.directApi;


public class DirectApiErrorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microblink.directApi.DirectApiErrorListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onRecognizerError:(Ljava/lang/Throwable;)V:GetOnRecognizerError_Ljava_lang_Throwable_Handler:Com.Microblink.DirectApi.IDirectApiErrorListenerInvoker, BlinkID.Binding.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Microblink.DirectApi.IDirectApiErrorListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DirectApiErrorListenerImplementor.class, __md_methods);
	}


	public DirectApiErrorListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DirectApiErrorListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microblink.DirectApi.IDirectApiErrorListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onRecognizerError (java.lang.Throwable p0)
	{
		n_onRecognizerError (p0);
	}

	private native void n_onRecognizerError (java.lang.Throwable p0);

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
