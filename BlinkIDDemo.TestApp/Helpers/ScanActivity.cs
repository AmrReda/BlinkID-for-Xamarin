using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Microblink.Ocr;
using Com.Microblink.Util;
using Com.Microblink.Recognizers;
using Com.Microblink.View;
using Com.Microblink.View.Recognition;

namespace BlinkIDDemo.TestApp
{
	public class ScanActivity : Activity, ICameraEventsListener, IScanResultListener
	{
		private static String LICENSE = "UF57DWJN-MCIEASQR-3FUVQU2V-WQ2YBMT4-SH4UTH2I-Z6MDB6FO-36NHEV7P-CZYI7I5N";
 
		private RecognizerView mRecognizerView;
		private CameraPermissionManager mCameraPermissionManager; 
		private ImageButton mFlashButton; 
		private View mResultView; 
		private EditText mResult; 
		private bool mTorchOn = false; 
		private TextView mMessage; 
		private SlidingTabLayout mTitleIndicator; 
		private ScanConfiguration[] mConfiguration = Configurator.createScanConfigurations(); 
		private int mSelectedConfiguration = 0;

		public ScanActivity ()
		{ 
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
 
			mRecognizerView = (RecognizerView) findViewById(R.id.rec_view);
			mFlashButton = (ImageButton) findViewById(R.id.btnFlash);
			mResultView = findViewById(R.id.layResult);
			mMessage = (TextView) findViewById(R.id.txtMessage);
			mResult = (EditText) findViewById(R.id.txtResult);
			mTitleIndicator = (SlidingTabLayout) findViewById(R.id.indicator);
		}

		protected override void OnStart ()
		{
			base.OnStart ();
			// all activity lifecycle events must be passed on to RecognizerView
			if(mRecognizerView != null) {
				mRecognizerView.start();
			}
		}
	}
}

