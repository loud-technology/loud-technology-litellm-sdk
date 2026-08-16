
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
        Location,
        /// <summary>
        /// 
        /// </summary>
        MedicalLicense,
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
        PlPesel,
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
        UkNhs,
        /// <summary>
        /// 
        /// </summary>
        UkNino,
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
        UsPassport,
        /// <summary>
        /// 
        /// </summary>
        UsSsn,
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
                PiiEntityType.CreditCard => "CREDIT_CARD",
                PiiEntityType.Crypto => "CRYPTO",
                PiiEntityType.DateTime => "DATE_TIME",
                PiiEntityType.EmailAddress => "EMAIL_ADDRESS",
                PiiEntityType.EsNie => "ES_NIE",
                PiiEntityType.EsNif => "ES_NIF",
                PiiEntityType.FiPersonalIdentityCode => "FI_PERSONAL_IDENTITY_CODE",
                PiiEntityType.IbanCode => "IBAN_CODE",
                PiiEntityType.InAadhaar => "IN_AADHAAR",
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
                PiiEntityType.Location => "LOCATION",
                PiiEntityType.MedicalLicense => "MEDICAL_LICENSE",
                PiiEntityType.Nrp => "NRP",
                PiiEntityType.Person => "PERSON",
                PiiEntityType.PhoneNumber => "PHONE_NUMBER",
                PiiEntityType.PlPesel => "PL_PESEL",
                PiiEntityType.SgNricFin => "SG_NRIC_FIN",
                PiiEntityType.SgUen => "SG_UEN",
                PiiEntityType.UkNhs => "UK_NHS",
                PiiEntityType.UkNino => "UK_NINO",
                PiiEntityType.Url => "URL",
                PiiEntityType.UsBankNumber => "US_BANK_NUMBER",
                PiiEntityType.UsDriverLicense => "US_DRIVER_LICENSE",
                PiiEntityType.UsItin => "US_ITIN",
                PiiEntityType.UsPassport => "US_PASSPORT",
                PiiEntityType.UsSsn => "US_SSN",
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
                "CREDIT_CARD" => PiiEntityType.CreditCard,
                "CRYPTO" => PiiEntityType.Crypto,
                "DATE_TIME" => PiiEntityType.DateTime,
                "EMAIL_ADDRESS" => PiiEntityType.EmailAddress,
                "ES_NIE" => PiiEntityType.EsNie,
                "ES_NIF" => PiiEntityType.EsNif,
                "FI_PERSONAL_IDENTITY_CODE" => PiiEntityType.FiPersonalIdentityCode,
                "IBAN_CODE" => PiiEntityType.IbanCode,
                "IN_AADHAAR" => PiiEntityType.InAadhaar,
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
                "LOCATION" => PiiEntityType.Location,
                "MEDICAL_LICENSE" => PiiEntityType.MedicalLicense,
                "NRP" => PiiEntityType.Nrp,
                "PERSON" => PiiEntityType.Person,
                "PHONE_NUMBER" => PiiEntityType.PhoneNumber,
                "PL_PESEL" => PiiEntityType.PlPesel,
                "SG_NRIC_FIN" => PiiEntityType.SgNricFin,
                "SG_UEN" => PiiEntityType.SgUen,
                "UK_NHS" => PiiEntityType.UkNhs,
                "UK_NINO" => PiiEntityType.UkNino,
                "URL" => PiiEntityType.Url,
                "US_BANK_NUMBER" => PiiEntityType.UsBankNumber,
                "US_DRIVER_LICENSE" => PiiEntityType.UsDriverLicense,
                "US_ITIN" => PiiEntityType.UsItin,
                "US_PASSPORT" => PiiEntityType.UsPassport,
                "US_SSN" => PiiEntityType.UsSsn,
                _ => null,
            };
        }
    }
}