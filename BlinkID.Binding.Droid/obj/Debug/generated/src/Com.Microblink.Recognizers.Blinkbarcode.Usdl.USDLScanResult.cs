using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Microblink.Recognizers.Blinkbarcode.Usdl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']"
	[global::Android.Runtime.Register ("com/microblink/recognizers/blinkbarcode/usdl/USDLScanResult", DoNotGenerateAcw=true)]
	public partial class USDLScanResult : global::Com.Microblink.Recognizers.BaseRecognitionResult {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAKADateOfBirth']"
		[Register ("kAKADateOfBirth")]
		public const string KAKADateOfBirth = (string) "Alias / AKA Date of Birth";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAKAFamilyName']"
		[Register ("kAKAFamilyName")]
		public const string KAKAFamilyName = (string) "Alias / AKA Family Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAKAFullName']"
		[Register ("kAKAFullName")]
		public const string KAKAFullName = (string) "Alias / AKA Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAKAGivenName']"
		[Register ("kAKAGivenName")]
		public const string KAKAGivenName = (string) "Alias / AKA Given Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAKAMiddleName']"
		[Register ("kAKAMiddleName")]
		public const string KAKAMiddleName = (string) "Alias / AKA Middle Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAKAPrefixName']"
		[Register ("kAKAPrefixName")]
		public const string KAKAPrefixName = (string) "Alias / AKA Prefix Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAKASocialSecurityNumber']"
		[Register ("kAKASocialSecurityNumber")]
		public const string KAKASocialSecurityNumber = (string) "Alias / AKA Social Security Number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAKASuffixName']"
		[Register ("kAKASuffixName")]
		public const string KAKASuffixName = (string) "Alias / AKA Suffix Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAddressCity']"
		[Register ("kAddressCity")]
		public const string KAddressCity = (string) "Address - City";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAddressJurisdictionCode']"
		[Register ("kAddressJurisdictionCode")]
		public const string KAddressJurisdictionCode = (string) "Address - Jurisdiction Code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAddressPostalCode']"
		[Register ("kAddressPostalCode")]
		public const string KAddressPostalCode = (string) "Address - Postal Code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAddressStreet']"
		[Register ("kAddressStreet")]
		public const string KAddressStreet = (string) "Address - Street 1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAddressStreet2']"
		[Register ("kAddressStreet2")]
		public const string KAddressStreet2 = (string) "Address - Street 2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kAuditInformation']"
		[Register ("kAuditInformation")]
		public const string KAuditInformation = (string) "Audit information";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kCardRevisionDate']"
		[Register ("kCardRevisionDate")]
		public const string KCardRevisionDate = (string) "Card Revision Date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kComplianceType']"
		[Register ("kComplianceType")]
		public const string KComplianceType = (string) "Compliance Type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kCountryIdentification']"
		[Register ("kCountryIdentification")]
		public const string KCountryIdentification = (string) "Country Identification";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kCustomerFamilyName']"
		[Register ("kCustomerFamilyName")]
		public const string KCustomerFamilyName = (string) "Customer Family Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kCustomerFirstName']"
		[Register ("kCustomerFirstName")]
		public const string KCustomerFirstName = (string) "Customer First Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kCustomerFullName']"
		[Register ("kCustomerFullName")]
		public const string KCustomerFullName = (string) "Customer Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kCustomerIdNumber']"
		[Register ("kCustomerIdNumber")]
		public const string KCustomerIdNumber = (string) "Customer ID Number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kCustomerMiddleName']"
		[Register ("kCustomerMiddleName")]
		public const string KCustomerMiddleName = (string) "Customer Middle Name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kDataDiscriminator']"
		[Register ("kDataDiscriminator")]
		public const string KDataDiscriminator = (string) "Data discriminator";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kDateOfBirth']"
		[Register ("kDateOfBirth")]
		public const string KDateOfBirth = (string) "Date of Birth";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kDocumentDiscriminator']"
		[Register ("kDocumentDiscriminator")]
		public const string KDocumentDiscriminator = (string) "Document Discriminator";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kDocumentExpirationDate']"
		[Register ("kDocumentExpirationDate")]
		public const string KDocumentExpirationDate = (string) "Document Expiration Date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kDocumentExpirationMonth']"
		[Register ("kDocumentExpirationMonth")]
		public const string KDocumentExpirationMonth = (string) "Document Expiration Month";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kDocumentIssueDate']"
		[Register ("kDocumentIssueDate")]
		public const string KDocumentIssueDate = (string) "Document Issue Date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kDocumentNonexpiring']"
		[Register ("kDocumentNonexpiring")]
		public const string KDocumentNonexpiring = (string) "Document Nonexpiring";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kDocumentType']"
		[Register ("kDocumentType")]
		public const string KDocumentType = (string) "Document Type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kEyeColor']"
		[Register ("kEyeColor")]
		public const string KEyeColor = (string) "Eye Color";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kFamilyNameTruncation']"
		[Register ("kFamilyNameTruncation")]
		public const string KFamilyNameTruncation = (string) "Family name truncation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kFederalCommercialVehicleCodes']"
		[Register ("kFederalCommercialVehicleCodes")]
		public const string KFederalCommercialVehicleCodes = (string) "Federal Commercial Vehicle Codes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kFirstNameTruncation']"
		[Register ("kFirstNameTruncation")]
		public const string KFirstNameTruncation = (string) "First name truncation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kFullAddress']"
		[Register ("kFullAddress")]
		public const string KFullAddress = (string) "Full Address";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kHAZMATExpirationDate']"
		[Register ("kHAZMATExpirationDate")]
		public const string KHAZMATExpirationDate = (string) "HAZMAT Endorsement Expiration Date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kHairColor']"
		[Register ("kHairColor")]
		public const string KHairColor = (string) "Hair color";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kHeight']"
		[Register ("kHeight")]
		public const string KHeight = (string) "Height";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kHeightCm']"
		[Register ("kHeightCm")]
		public const string KHeightCm = (string) "Height cm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kHeightIn']"
		[Register ("kHeightIn")]
		public const string KHeightIn = (string) "Height in";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kInventoryControlNumber']"
		[Register ("kInventoryControlNumber")]
		public const string KInventoryControlNumber = (string) "Inventory control number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kIssueTimestamp']"
		[Register ("kIssueTimestamp")]
		public const string KIssueTimestamp = (string) "Issue Timestamp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kIssuerIdentificationNumber']"
		[Register ("kIssuerIdentificationNumber")]
		public const string KIssuerIdentificationNumber = (string) "Issuer Identification Number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kIssuingJurisdiction']"
		[Register ("kIssuingJurisdiction")]
		public const string KIssuingJurisdiction = (string) "Issuing jurisdiction";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kJurisdictionEndorsementCodes']"
		[Register ("kJurisdictionEndorsementCodes")]
		public const string KJurisdictionEndorsementCodes = (string) "Jurisdiction-specific endorsement codes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kJurisdictionEndorsmentCodeDescription']"
		[Register ("kJurisdictionEndorsmentCodeDescription")]
		public const string KJurisdictionEndorsmentCodeDescription = (string) "Jurisdiction-specific endorsment code description";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kJurisdictionRestrictionCodeDescription']"
		[Register ("kJurisdictionRestrictionCodeDescription")]
		public const string KJurisdictionRestrictionCodeDescription = (string) "Jurisdiction-spacific restriction code description";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kJurisdictionRestrictionCodes']"
		[Register ("kJurisdictionRestrictionCodes")]
		public const string KJurisdictionRestrictionCodes = (string) "Jurisdiction-specific restriction codes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kJurisdictionVehicleClass']"
		[Register ("kJurisdictionVehicleClass")]
		public const string KJurisdictionVehicleClass = (string) "Jurisdiction-specific vehicle class";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kJurisdictionVehicleClassificationDescription']"
		[Register ("kJurisdictionVehicleClassificationDescription")]
		public const string KJurisdictionVehicleClassificationDescription = (string) "Jurisdiction-specific vehicle classification description";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kJurisdictionVersionNumber']"
		[Register ("kJurisdictionVersionNumber")]
		public const string KJurisdictionVersionNumber = (string) "Jurisdiction Version Number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kLimitedDurationDocument']"
		[Register ("kLimitedDurationDocument")]
		public const string KLimitedDurationDocument = (string) "Limited Duration Document Indicator";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kMedicalIndicator']"
		[Register ("kMedicalIndicator")]
		public const string KMedicalIndicator = (string) "Medical Indicator/Codes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kMiddleNameTruncation']"
		[Register ("kMiddleNameTruncation")]
		public const string KMiddleNameTruncation = (string) "Middle name truncation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kNamePrefix']"
		[Register ("kNamePrefix")]
		public const string KNamePrefix = (string) "Name Prefix";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kNameSuffix']"
		[Register ("kNameSuffix")]
		public const string KNameSuffix = (string) "Name Suffix";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kNonResident']"
		[Register ("kNonResident")]
		public const string KNonResident = (string) "Non-Resident Indicator";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kNumberOfDuplicates']"
		[Register ("kNumberOfDuplicates")]
		public const string KNumberOfDuplicates = (string) "Number of Duplicates";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kOrganDonor']"
		[Register ("kOrganDonor")]
		public const string KOrganDonor = (string) "Organ Donor Indicator";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kPermitExpirationDate']"
		[Register ("kPermitExpirationDate")]
		public const string KPermitExpirationDate = (string) "Driver Permit Expiration Date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kPermitIdentifier']"
		[Register ("kPermitIdentifier")]
		public const string KPermitIdentifier = (string) "Permit Identifier";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kPermitIssueDate']"
		[Register ("kPermitIssueDate")]
		public const string KPermitIssueDate = (string) "Driver Permit Issue Date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kPlaceOfBirth']"
		[Register ("kPlaceOfBirth")]
		public const string KPlaceOfBirth = (string) "Place of birth";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kRaceEthnicity']"
		[Register ("kRaceEthnicity")]
		public const string KRaceEthnicity = (string) "Race / ethnicity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kResidenceCity']"
		[Register ("kResidenceCity")]
		public const string KResidenceCity = (string) "Driver Residence City";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kResidenceFullAddress']"
		[Register ("kResidenceFullAddress")]
		public const string KResidenceFullAddress = (string) "Driver Residence Full Address";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kResidenceJurisdictionCode']"
		[Register ("kResidenceJurisdictionCode")]
		public const string KResidenceJurisdictionCode = (string) "Driver Residence Jurisdiction Code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kResidencePostalCode']"
		[Register ("kResidencePostalCode")]
		public const string KResidencePostalCode = (string) "Driver Residence Postal Code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kResidenceStreetAddress']"
		[Register ("kResidenceStreetAddress")]
		public const string KResidenceStreetAddress = (string) "Driver Residence Street Address";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kResidenceStreetAddress2']"
		[Register ("kResidenceStreetAddress2")]
		public const string KResidenceStreetAddress2 = (string) "Driver Residence Street Address 2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kSecurityVersion']"
		[Register ("kSecurityVersion")]
		public const string KSecurityVersion = (string) "Security Version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kSex']"
		[Register ("kSex")]
		public const string KSex = (string) "Sex";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kSocialSecurityNumber']"
		[Register ("kSocialSecurityNumber")]
		public const string KSocialSecurityNumber = (string) "Social Security Number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kStandardEndorsementCode']"
		[Register ("kStandardEndorsementCode")]
		public const string KStandardEndorsementCode = (string) "Standard endorsement code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kStandardRestrictionCode']"
		[Register ("kStandardRestrictionCode")]
		public const string KStandardRestrictionCode = (string) "Standard restriction code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kStandardVehicleClassification']"
		[Register ("kStandardVehicleClassification")]
		public const string KStandardVehicleClassification = (string) "Standard vehicle classification";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kStandardVersionNumber']"
		[Register ("kStandardVersionNumber")]
		public const string KStandardVersionNumber = (string) "Standard Version Number";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kUnder18']"
		[Register ("kUnder18")]
		public const string KUnder18 = (string) "Under 18 Until";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kUnder19']"
		[Register ("kUnder19")]
		public const string KUnder19 = (string) "Under 19 Until";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kUnder21']"
		[Register ("kUnder21")]
		public const string KUnder21 = (string) "Under 21 Until";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kUniqueCustomerId']"
		[Register ("kUniqueCustomerId")]
		public const string KUniqueCustomerId = (string) "Unique Customer Identifier";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kVeteran']"
		[Register ("kVeteran")]
		public const string KVeteran = (string) "Veteran Indicator";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kWeightKilograms']"
		[Register ("kWeightKilograms")]
		public const string KWeightKilograms = (string) "Weight (kilograms)";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kWeightPounds']"
		[Register ("kWeightPounds")]
		public const string KWeightPounds = (string) "Weight (pounds)";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/field[@name='kWeightRange']"
		[Register ("kWeightRange")]
		public const string KWeightRange = (string) "Weight Range";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/microblink/recognizers/blinkbarcode/usdl/USDLScanResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (USDLScanResult); }
		}

		protected USDLScanResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/constructor[@name='USDLScanResult' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(JZZ)V", "")]
		public unsafe USDLScanResult (long p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (USDLScanResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JZZ)V", __args);
					return;
				}

				if (id_ctor_JZZ == IntPtr.Zero)
					id_ctor_JZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JZZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/constructor[@name='USDLScanResult' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe USDLScanResult (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (USDLScanResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_isUncertain;
#pragma warning disable 0169
		static Delegate GetIsUncertainHandler ()
		{
			if (cb_isUncertain == null)
				cb_isUncertain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUncertain);
			return cb_isUncertain;
		}

		static bool n_IsUncertain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUncertain;
		}
#pragma warning restore 0169

		static IntPtr id_isUncertain;
		public virtual unsafe bool IsUncertain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/method[@name='isUncertain' and count(parameter)=0]"
			[Register ("isUncertain", "()Z", "GetIsUncertainHandler")]
			get {
				if (id_isUncertain == IntPtr.Zero)
					id_isUncertain = JNIEnv.GetMethodID (class_ref, "isUncertain", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isUncertain);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUncertain", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getRawData;
#pragma warning disable 0169
		static Delegate GetGetRawDataHandler ()
		{
			if (cb_getRawData == null)
				cb_getRawData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawData);
			return cb_getRawData;
		}

		static IntPtr n_GetRawData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawData);
		}
#pragma warning restore 0169

		static IntPtr id_getRawData;
		public virtual unsafe global::Com.Microblink.Results.Barcode.BarcodeDetailedData RawData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/method[@name='getRawData' and count(parameter)=0]"
			[Register ("getRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;", "GetGetRawDataHandler")]
			get {
				if (id_getRawData == IntPtr.Zero)
					id_getRawData = JNIEnv.GetMethodID (class_ref, "getRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeDetailedData> (JNIEnv.CallObjectMethod  (Handle, id_getRawData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Microblink.Results.Barcode.BarcodeDetailedData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawData", "()Lcom/microblink/results/barcode/BarcodeDetailedData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStringData;
#pragma warning disable 0169
		static Delegate GetGetStringDataHandler ()
		{
			if (cb_getStringData == null)
				cb_getStringData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStringData);
			return cb_getStringData;
		}

		static IntPtr n_GetStringData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StringData);
		}
#pragma warning restore 0169

		static IntPtr id_getStringData;
		public virtual unsafe string StringData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/method[@name='getStringData' and count(parameter)=0]"
			[Register ("getStringData", "()Ljava/lang/String;", "GetGetStringDataHandler")]
			get {
				if (id_getStringData == IntPtr.Zero)
					id_getStringData = JNIEnv.GetMethodID (class_ref, "getStringData", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStringData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetField_Ljava_lang_String_Handler ()
		{
			if (cb_getField_Ljava_lang_String_ == null)
				cb_getField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetField_Ljava_lang_String_);
			return cb_getField_Ljava_lang_String_;
		}

		static IntPtr n_GetField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLScanResult __this = global::Java.Lang.Object.GetObject<global::Com.Microblink.Recognizers.Blinkbarcode.Usdl.USDLScanResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetField (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getField_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.microblink.recognizers.blinkbarcode.usdl']/class[@name='USDLScanResult']/method[@name='getField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getField", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetField_Ljava_lang_String_Handler")]
		public virtual unsafe string GetField (string p0)
		{
			if (id_getField_Ljava_lang_String_ == IntPtr.Zero)
				id_getField_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getField", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getField_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getField", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
