package mono.com.microblink.metadata;


public class MetadataListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microblink.metadata.MetadataListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMetadataAvailable:(Lcom/microblink/metadata/Metadata;)V:GetOnMetadataAvailable_Lcom_microblink_metadata_Metadata_Handler:Com.Microblink.Metadata.IMetadataListenerInvoker, BlinkID.Binding.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Microblink.Metadata.IMetadataListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MetadataListenerImplementor.class, __md_methods);
	}


	public MetadataListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MetadataListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microblink.Metadata.IMetadataListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMetadataAvailable (com.microblink.metadata.Metadata p0)
	{
		n_onMetadataAvailable (p0);
	}

	private native void n_onMetadataAvailable (com.microblink.metadata.Metadata p0);

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
