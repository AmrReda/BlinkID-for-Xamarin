package mono.com.microblink.view;


public class OnSizeChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microblink.view.OnSizeChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSizeChanged:(II)V:GetOnSizeChanged_IIHandler:Com.Microblink.View.IOnSizeChangedListenerInvoker, BlinkID.Binding.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Microblink.View.IOnSizeChangedListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnSizeChangedListenerImplementor.class, __md_methods);
	}


	public OnSizeChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnSizeChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microblink.View.IOnSizeChangedListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSizeChanged (int p0, int p1)
	{
		n_onSizeChanged (p0, p1);
	}

	private native void n_onSizeChanged (int p0, int p1);

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
