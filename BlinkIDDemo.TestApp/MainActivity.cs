using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Microblink.Util;
using Com.Microblink.Activity;
using Com.Microblink.Recognizers;

namespace BlinkIDDemo.TestApp
{
    [Activity(Label = "BlinkIDDemo.TestApp", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
       // public static int MY_BLINKID_REQUEST_CODE = 0x101;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // check if BlinkID is supported on the device
            RecognizerCompatibilityStatus supportStatus = RecognizerCompatibility.GetRecognizerCompatibilityStatus(this);
			if (supportStatus != RecognizerCompatibilityStatus.RecognizerSupported) {
				Toast.MakeText (this, "BlinkID is not supported! Reason: " + supportStatus.Name (), ToastLength.Long).Show ();
			} else {
			
				Toast.MakeText (this, "BlinkID is supported! Reason: " + supportStatus.Name (), ToastLength.Long).Show ();
			}
        }

        //       protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        //       {
        //           base.OnActivityResult(requestCode, resultCode, data);


        //           // onActivityResult is called whenever we are returned from activity started
        //           // with startActivityForResult. We need to check request code to determine
        //           // that we have really returned from BlinkID activity.
        //           if (requestCode == MY_BLINKID_REQUEST_CODE)
        //           {

        //               // make sure BlinkID activity returned result
        //               if (resultCode == ScanActivity.RESULT_OK && data != null)
        //               {

        //                   // depending on settings, we may have multiple scan results.
        //                   // we first need to obtain list of recognition results
        //                   Bundle extras = data.getExtras();
        //                   RecognitionResults results = data.GetParcelableExtra(ScanActivity.EXTRAS_RECOGNITION_RESULTS);
        //                   BaseRecognitionResult[] resArray = null;
        //                   if (results != null)
        //                   {
        //                       // get array of recognition results
        //                       resArray = results.GetRecognitionResults();
        //                   }
        //                   if (resArray != null)
        //                   {
        //                       Log.Info(this, "Data count: " + resArray.Length);
        //                       int i = 1;

        //                       for (BaseRecognitionResult res : resArray)
        //                       {
        //                           Log.Info(this, "Data #" + Integer.valueOf(i++).toString());

        //                           // Each element in resultArray inherits BaseRecognitionResult class and
        //                           // represents the scan result of one of activated recognizers that have
        //                           // been set up.

        //                           res.log();
        //                       }
        //                   }
        //                   else
        //                   {
        //                       Log.e(this, "Unable to retrieve recognition results!");
        //                   }

        //                   // set intent's component to ResultActivity and pass its contents
        //                   // to ResultActivity. ResultActivity will show how to extract
        //                   // data from result.

        //                   data.setComponent(new ComponentName(this, ResultActivity.class));
        //               startActivity(data);
        //   } else {
        //               // if BlinkID activity did not return result, user has probably
        //               // pressed Back button and cancelled scanning
        //               Toast.MakeText(this, "Scan cancelled!", Toast.Length).Show();
        //   }
        //}
    }
}

    



