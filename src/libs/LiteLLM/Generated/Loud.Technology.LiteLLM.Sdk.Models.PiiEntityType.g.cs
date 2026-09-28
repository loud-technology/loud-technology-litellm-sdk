
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum PiiEntityType
    {
        /// <summary>
        ///
        /// </summary>
        AuAbn,
        /// <summary>
        ///
        /// </summary>
        AuAcn,
        /// <summary>
        ///
        /// </summary>
        AuMedicare,
        /// <summary>
        ///
        /// </summary>
        AuTfn,
        /// <summary>
        ///
        /// </summary>
        CaSin,
        /// <summary>
        ///
        /// </summary>
        CreditCard,
        /// <summary>
        ///
        /// </summary>
        Crypto,
        /// <summary>
        ///
        /// </summary>
        DateTime,
        /// <summary>
        ///
        /// </summary>
        DeBsnr,
        /// <summary>
        ///
        /// </summary>
        DeFuehrerschein,
        /// <summary>
        ///
        /// </summary>
        DeHandelsregister,
        /// <summary>
        ///
        /// </summary>
        DeHealthInsurance,
        /// <summary>
        ///
        /// </summary>
        DeIdCard,
        /// <summary>
        ///
        /// </summary>
        DeKfz,
        /// <summary>
        ///
        /// </summary>
        DeLanr,
        /// <summary>
        ///
        /// </summary>
        DePassport,
        /// <summary>
        ///
        /// </summary>
        DePlz,
        /// <summary>
        ///
        /// </summary>
        DeSocialSecurity,
        /// <summary>
        ///
        /// </summary>
        DeTaxId,
        /// <summary>
        ///
        /// </summary>
        DeTaxNumber,
        /// <summary>
        ///
        /// </summary>
        DeVatId,
        /// <summary>
        ///
        /// </summary>
        EmailAddress,
        /// <summary>
        ///
        /// </summary>
        EsNie,
        /// <summary>
        ///
        /// </summary>
        EsNif,
        /// <summary>
        ///
        /// </summary>
        EsPassport,
        /// <summary>
        ///
        /// </summary>
        FiPersonalIdentityCode,
        /// <summary>
        ///
        /// </summary>
        IbanCode,
        /// <summary>
        ///
        /// </summary>
        InAadhaar,
        /// <summary>
        ///
        /// </summary>
        InGstin,
        /// <summary>
        ///
        /// </summary>
        InPan,
        /// <summary>
        ///
        /// </summary>
        InPassport,
        /// <summary>
        ///
        /// </summary>
        InVehicleRegistration,
        /// <summary>
        ///
        /// </summary>
        InVoter,
        /// <summary>
        ///
        /// </summary>
        IpAddress,
        /// <summary>
        ///
        /// </summary>
        ItDriverLicense,
        /// <summary>
        ///
        /// </summary>
        ItFiscalCode,
        /// <summary>
        ///
        /// </summary>
        ItIdentityCard,
        /// <summary>
        ///
        /// </summary>
        ItPassport,
        /// <summary>
        ///
        /// </summary>
        ItVatCode,
        /// <summary>
        ///
        /// </summary>
        KrBrn,
        /// <summary>
        ///
        /// </summary>
        KrDriverLicense,
        /// <summary>
        ///
        /// </summary>
        KrFrn,
        /// <summary>
        ///
        /// </summary>
        KrPassport,
        /// <summary>
        ///
        /// </summary>
        KrRrn,
        /// <summary>
        ///
        /// </summary>
        Location,
        /// <summary>
        ///
        /// </summary>
        MacAddress,
        /// <summary>
        ///
        /// </summary>
        MedicalLicense,
        /// <summary>
        ///
        /// </summary>
        NgNin,
        /// <summary>
        ///
        /// </summary>
        NgVehicleRegistration,
        /// <summary>
        ///
        /// </summary>
        Nrp,
        /// <summary>
        ///
        /// </summary>
        Person,
        /// <summary>
        ///
        /// </summary>
        PhoneNumber,
        /// <summary>
        ///
        /// </summary>
        PhPassport,
        /// <summary>
        ///
        /// </summary>
        PhTin,
        /// <summary>
        ///
        /// </summary>
        PhUmid,
        /// <summary>
        ///
        /// </summary>
        PlPesel,
        /// <summary>
        ///
        /// </summary>
        SeOrganisationsnummer,
        /// <summary>
        ///
        /// </summary>
        SePersonnummer,
        /// <summary>
        ///
        /// </summary>
        SgNricFin,
        /// <summary>
        ///
        /// </summary>
        SgUen,
        /// <summary>
        ///
        /// </summary>
        ThTnin,
        /// <summary>
        ///
        /// </summary>
        TrLicensePlate,
        /// <summary>
        ///
        /// </summary>
        TrNationalId,
        /// <summary>
        ///
        /// </summary>
        UkDrivingLicence,
        /// <summary>
        ///
        /// </summary>
        UkNhs,
        /// <summary>
        ///
        /// </summary>
        UkNino,
        /// <summary>
        ///
        /// </summary>
        UkPassport,
        /// <summary>
        ///
        /// </summary>
        UkPostcode,
        /// <summary>
        ///
        /// </summary>
        UkVehicleRegistration,
        /// <summary>
        ///
        /// </summary>
        Url,
        /// <summary>
        ///
        /// </summary>
        UsBankNumber,
        /// <summary>
        ///
        /// </summary>
        UsDriverLicense,
        /// <summary>
        ///
        /// </summary>
        UsItin,
        /// <summary>
        ///
        /// </summary>
        UsMbi,
        /// <summary>
        ///
        /// </summary>
        UsNpi,
        /// <summary>
        ///
        /// </summary>
        UsPassport,
        /// <summary>
        ///
        /// </summary>
        UsSsn,
        /// <summary>
        ///
        /// </summary>
        Uuid,
        /// <summary>
        ///
        /// </summary>
        ZaIdNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PiiEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PiiEntityType value)
        {
            return value switch
            {
                PiiEntityType.AuAbn => "AU_ABN",
                PiiEntityType.AuAcn => "AU_ACN",
                PiiEntityType.AuMedicare => "AU_MEDICARE",
                PiiEntityType.AuTfn => "AU_TFN",
                PiiEntityType.CaSin => "CA_SIN",
                PiiEntityType.CreditCard => "CREDIT_CARD",
                PiiEntityType.Crypto => "CRYPTO",
                PiiEntityType.DateTime => "DATE_TIME",
                PiiEntityType.DeBsnr => "DE_BSNR",
                PiiEntityType.DeFuehrerschein => "DE_FUEHRERSCHEIN",
                PiiEntityType.DeHandelsregister => "DE_HANDELSREGISTER",
                PiiEntityType.DeHealthInsurance => "DE_HEALTH_INSURANCE",
                PiiEntityType.DeIdCard => "DE_ID_CARD",
                PiiEntityType.DeKfz => "DE_KFZ",
                PiiEntityType.DeLanr => "DE_LANR",
                PiiEntityType.DePassport => "DE_PASSPORT",
                PiiEntityType.DePlz => "DE_PLZ",
                PiiEntityType.DeSocialSecurity => "DE_SOCIAL_SECURITY",
                PiiEntityType.DeTaxId => "DE_TAX_ID",
                PiiEntityType.DeTaxNumber => "DE_TAX_NUMBER",
                PiiEntityType.DeVatId => "DE_VAT_ID",
                PiiEntityType.EmailAddress => "EMAIL_ADDRESS",
                PiiEntityType.EsNie => "ES_NIE",
                PiiEntityType.EsNif => "ES_NIF",
                PiiEntityType.EsPassport => "ES_PASSPORT",
                PiiEntityType.FiPersonalIdentityCode => "FI_PERSONAL_IDENTITY_CODE",
                PiiEntityType.IbanCode => "IBAN_CODE",
                PiiEntityType.InAadhaar => "IN_AADHAAR",
                PiiEntityType.InGstin => "IN_GSTIN",
                PiiEntityType.InPan => "IN_PAN",
                PiiEntityType.InPassport => "IN_PASSPORT",
                PiiEntityType.InVehicleRegistration => "IN_VEHICLE_REGISTRATION",
                PiiEntityType.InVoter => "IN_VOTER",
                PiiEntityType.IpAddress => "IP_ADDRESS",
                PiiEntityType.ItDriverLicense => "IT_DRIVER_LICENSE",
                PiiEntityType.ItFiscalCode => "IT_FISCAL_CODE",
                PiiEntityType.ItIdentityCard => "IT_IDENTITY_CARD",
                PiiEntityType.ItPassport => "IT_PASSPORT",
                PiiEntityType.ItVatCode => "IT_VAT_CODE",
                PiiEntityType.KrBrn => "KR_BRN",
                PiiEntityType.KrDriverLicense => "KR_DRIVER_LICENSE",
                PiiEntityType.KrFrn => "KR_FRN",
                PiiEntityType.KrPassport => "KR_PASSPORT",
                PiiEntityType.KrRrn => "KR_RRN",
                PiiEntityType.Location => "LOCATION",
                PiiEntityType.MacAddress => "MAC_ADDRESS",
                PiiEntityType.MedicalLicense => "MEDICAL_LICENSE",
                PiiEntityType.NgNin => "NG_NIN",
                PiiEntityType.NgVehicleRegistration => "NG_VEHICLE_REGISTRATION",
                PiiEntityType.Nrp => "NRP",
                PiiEntityType.Person => "PERSON",
                PiiEntityType.PhoneNumber => "PHONE_NUMBER",
                PiiEntityType.PhPassport => "PH_PASSPORT",
                PiiEntityType.PhTin => "PH_TIN",
                PiiEntityType.PhUmid => "PH_UMID",
                PiiEntityType.PlPesel => "PL_PESEL",
                PiiEntityType.SeOrganisationsnummer => "SE_ORGANISATIONSNUMMER",
                PiiEntityType.SePersonnummer => "SE_PERSONNUMMER",
                PiiEntityType.SgNricFin => "SG_NRIC_FIN",
                PiiEntityType.SgUen => "SG_UEN",
                PiiEntityType.ThTnin => "TH_TNIN",
                PiiEntityType.TrLicensePlate => "TR_LICENSE_PLATE",
                PiiEntityType.TrNationalId => "TR_NATIONAL_ID",
                PiiEntityType.UkDrivingLicence => "UK_DRIVING_LICENCE",
                PiiEntityType.UkNhs => "UK_NHS",
                PiiEntityType.UkNino => "UK_NINO",
                PiiEntityType.UkPassport => "UK_PASSPORT",
                PiiEntityType.UkPostcode => "UK_POSTCODE",
                PiiEntityType.UkVehicleRegistration => "UK_VEHICLE_REGISTRATION",
                PiiEntityType.Url => "URL",
                PiiEntityType.UsBankNumber => "US_BANK_NUMBER",
                PiiEntityType.UsDriverLicense => "US_DRIVER_LICENSE",
                PiiEntityType.UsItin => "US_ITIN",
                PiiEntityType.UsMbi => "US_MBI",
                PiiEntityType.UsNpi => "US_NPI",
                PiiEntityType.UsPassport => "US_PASSPORT",
                PiiEntityType.UsSsn => "US_SSN",
                PiiEntityType.Uuid => "UUID",
                PiiEntityType.ZaIdNumber => "ZA_ID_NUMBER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PiiEntityType? ToEnum(string value)
        {
            return value switch
            {
                "AU_ABN" => PiiEntityType.AuAbn,
                "AU_ACN" => PiiEntityType.AuAcn,
                "AU_MEDICARE" => PiiEntityType.AuMedicare,
                "AU_TFN" => PiiEntityType.AuTfn,
                "CA_SIN" => PiiEntityType.CaSin,
                "CREDIT_CARD" => PiiEntityType.CreditCard,
                "CRYPTO" => PiiEntityType.Crypto,
                "DATE_TIME" => PiiEntityType.DateTime,
                "DE_BSNR" => PiiEntityType.DeBsnr,
                "DE_FUEHRERSCHEIN" => PiiEntityType.DeFuehrerschein,
                "DE_HANDELSREGISTER" => PiiEntityType.DeHandelsregister,
                "DE_HEALTH_INSURANCE" => PiiEntityType.DeHealthInsurance,
                "DE_ID_CARD" => PiiEntityType.DeIdCard,
                "DE_KFZ" => PiiEntityType.DeKfz,
                "DE_LANR" => PiiEntityType.DeLanr,
                "DE_PASSPORT" => PiiEntityType.DePassport,
                "DE_PLZ" => PiiEntityType.DePlz,
                "DE_SOCIAL_SECURITY" => PiiEntityType.DeSocialSecurity,
                "DE_TAX_ID" => PiiEntityType.DeTaxId,
                "DE_TAX_NUMBER" => PiiEntityType.DeTaxNumber,
                "DE_VAT_ID" => PiiEntityType.DeVatId,
                "EMAIL_ADDRESS" => PiiEntityType.EmailAddress,
                "ES_NIE" => PiiEntityType.EsNie,
                "ES_NIF" => PiiEntityType.EsNif,
                "ES_PASSPORT" => PiiEntityType.EsPassport,
                "FI_PERSONAL_IDENTITY_CODE" => PiiEntityType.FiPersonalIdentityCode,
                "IBAN_CODE" => PiiEntityType.IbanCode,
                "IN_AADHAAR" => PiiEntityType.InAadhaar,
                "IN_GSTIN" => PiiEntityType.InGstin,
                "IN_PAN" => PiiEntityType.InPan,
                "IN_PASSPORT" => PiiEntityType.InPassport,
                "IN_VEHICLE_REGISTRATION" => PiiEntityType.InVehicleRegistration,
                "IN_VOTER" => PiiEntityType.InVoter,
                "IP_ADDRESS" => PiiEntityType.IpAddress,
                "IT_DRIVER_LICENSE" => PiiEntityType.ItDriverLicense,
                "IT_FISCAL_CODE" => PiiEntityType.ItFiscalCode,
                "IT_IDENTITY_CARD" => PiiEntityType.ItIdentityCard,
                "IT_PASSPORT" => PiiEntityType.ItPassport,
                "IT_VAT_CODE" => PiiEntityType.ItVatCode,
                "KR_BRN" => PiiEntityType.KrBrn,
                "KR_DRIVER_LICENSE" => PiiEntityType.KrDriverLicense,
                "KR_FRN" => PiiEntityType.KrFrn,
                "KR_PASSPORT" => PiiEntityType.KrPassport,
                "KR_RRN" => PiiEntityType.KrRrn,
                "LOCATION" => PiiEntityType.Location,
                "MAC_ADDRESS" => PiiEntityType.MacAddress,
                "MEDICAL_LICENSE" => PiiEntityType.MedicalLicense,
                "NG_NIN" => PiiEntityType.NgNin,
                "NG_VEHICLE_REGISTRATION" => PiiEntityType.NgVehicleRegistration,
                "NRP" => PiiEntityType.Nrp,
                "PERSON" => PiiEntityType.Person,
                "PHONE_NUMBER" => PiiEntityType.PhoneNumber,
                "PH_PASSPORT" => PiiEntityType.PhPassport,
                "PH_TIN" => PiiEntityType.PhTin,
                "PH_UMID" => PiiEntityType.PhUmid,
                "PL_PESEL" => PiiEntityType.PlPesel,
                "SE_ORGANISATIONSNUMMER" => PiiEntityType.SeOrganisationsnummer,
                "SE_PERSONNUMMER" => PiiEntityType.SePersonnummer,
                "SG_NRIC_FIN" => PiiEntityType.SgNricFin,
                "SG_UEN" => PiiEntityType.SgUen,
                "TH_TNIN" => PiiEntityType.ThTnin,
                "TR_LICENSE_PLATE" => PiiEntityType.TrLicensePlate,
                "TR_NATIONAL_ID" => PiiEntityType.TrNationalId,
                "UK_DRIVING_LICENCE" => PiiEntityType.UkDrivingLicence,
                "UK_NHS" => PiiEntityType.UkNhs,
                "UK_NINO" => PiiEntityType.UkNino,
                "UK_PASSPORT" => PiiEntityType.UkPassport,
                "UK_POSTCODE" => PiiEntityType.UkPostcode,
                "UK_VEHICLE_REGISTRATION" => PiiEntityType.UkVehicleRegistration,
                "URL" => PiiEntityType.Url,
                "US_BANK_NUMBER" => PiiEntityType.UsBankNumber,
                "US_DRIVER_LICENSE" => PiiEntityType.UsDriverLicense,
                "US_ITIN" => PiiEntityType.UsItin,
                "US_MBI" => PiiEntityType.UsMbi,
                "US_NPI" => PiiEntityType.UsNpi,
                "US_PASSPORT" => PiiEntityType.UsPassport,
                "US_SSN" => PiiEntityType.UsSsn,
                "UUID" => PiiEntityType.Uuid,
                "ZA_ID_NUMBER" => PiiEntityType.ZaIdNumber,
                _ => null,
            };
        }
    }
}