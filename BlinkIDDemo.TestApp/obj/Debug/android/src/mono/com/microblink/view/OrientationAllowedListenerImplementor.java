package mono.com.microblink.view;


public class OrientationAllowedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microblink.view.OrientationAllowedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_isOrientationAllowed:(Lcom/microblink/hardware/orientation/Orientation;)Z:GetIsOrientationAllowed_Lcom_microblink_hardware_orientation_Orientation_Handler:Com.Microblink.View.IOrientationAllowedListenerInvoker, BlinkID.Binding.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Microblink.View.IOrientationAllowedListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OrientationAllowedListenerImplementor.class, __md_methods);
	}


	public OrientationAllowedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OrientationAllowedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microblink.View.IOrientationAllowedListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean isOrientationAllowed (com.microblink.hardware.orientation.Orientation p0)
	{
		return n_isOrientationAllowed (p0);
	}

	private native boolean n_isOrientationAllowed (com.microblink.hardware.orientation.Orientation p0);

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
