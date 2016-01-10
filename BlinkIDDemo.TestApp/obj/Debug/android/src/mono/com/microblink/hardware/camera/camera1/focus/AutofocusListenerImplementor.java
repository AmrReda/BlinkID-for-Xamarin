package mono.com.microblink.hardware.camera.camera1.focus;


public class AutofocusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microblink.hardware.camera.camera1.focus.AutofocusListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAutofocusFailed:()V:GetOnAutofocusFailedHandler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onAutofocusStarted:([Landroid/graphics/Rect;)V:GetOnAutofocusStarted_arrayLandroid_graphics_Rect_Handler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid\n" +
			"n_onAutofocusStopped:([Landroid/graphics/Rect;)V:GetOnAutofocusStopped_arrayLandroid_graphics_Rect_Handler:Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerInvoker, BlinkID.Binding.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AutofocusListenerImplementor.class, __md_methods);
	}


	public AutofocusListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AutofocusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microblink.Hardware.Camera.Camera1.Focus.IAutofocusListenerImplementor, BlinkID.Binding.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


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
