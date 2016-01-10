using System;
using Com.Microblink.Ocr;
using Com.Microblink.Recognizers.Blinkocr.Parser.Generic; 

namespace BlinkIDDemo.TestApp
{ 
	public class Configurator {
		public static ScanConfiguration[] createScanConfigurations() {
			// here we will create scan configuration for E-Mail and Raw text
			// in Raw text parser we will enable Sieve algorithm which will
			// reuse OCR results from multiple video frames to improve quality

			RawParserSettings rawSett = new RawParserSettings();
			rawSett.setUseSieve(false);

			return new ScanConfiguration[] {
				// each scan configuration contains two string resource IDs: string shown in title bar and string shown
				// in text field above scan box. Besides that, it contains name of the result and settings object
				// which defines what will be scanned.
				new ScanConfiguration(string.date_title, string.date_msg, "Date", new DateParserSettings()),
				new ScanConfiguration(string.email_title, string.email_msg, "EMail", new EMailParserSettings()),
				new ScanConfiguration(string.raw_title, string.raw_msg, "Raw", rawSett)
			};
		}
	}
}

