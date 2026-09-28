
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum BedrockChecksSensitiveInformationEntityItemType
    {
        /// <summary>
        ///
        /// </summary>
        Address,
        /// <summary>
        ///
        /// </summary>
        Age,
        /// <summary>
        ///
        /// </summary>
        AwsAccessKey,
        /// <summary>
        ///
        /// </summary>
        AwsSecretKey,
        /// <summary>
        ///
        /// </summary>
        CaHealthNumber,
        /// <summary>
        ///
        /// </summary>
        CaSocialInsuranceNumber,
        /// <summary>
        ///
        /// </summary>
        CreditDebitCardCvv,
        /// <summary>
        ///
        /// </summary>
        CreditDebitCardExpiry,
        /// <summary>
        ///
        /// </summary>
        CreditDebitCardNumber,
        /// <summary>
        ///
        /// </summary>
        DriverId,
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        InternationalBankAccountNumber,
        /// <summary>
        ///
        /// </summary>
        IpAddress,
        /// <summary>
        ///
        /// </summary>
        LicensePlate,
        /// <summary>
        ///
        /// </summary>
        MacAddress,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Password,
        /// <summary>
        ///
        /// </summary>
        Phone,
        /// <summary>
        ///
        /// </summary>
        Pin,
        /// <summary>
        ///
        /// </summary>
        SwiftCode,
        /// <summary>
        ///
        /// </summary>
        UkNationalHealthServiceNumber,
        /// <summary>
        ///
        /// </summary>
        UkNationalInsuranceNumber,
        /// <summary>
        ///
        /// </summary>
        UkUniqueTaxpayerReferenceNumber,
        /// <summary>
        ///
        /// </summary>
        Url,
        /// <summary>
        ///
        /// </summary>
        Username,
        /// <summary>
        ///
        /// </summary>
        UsBankAccountNumber,
        /// <summary>
        ///
        /// </summary>
        UsBankRoutingNumber,
        /// <summary>
        ///
        /// </summary>
        UsIndividualTaxIdentificationNumber,
        /// <summary>
        ///
        /// </summary>
        UsPassportNumber,
        /// <summary>
        ///
        /// </summary>
        UsSocialSecurityNumber,
        /// <summary>
        ///
        /// </summary>
        VehicleIdentificationNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BedrockChecksSensitiveInformationEntityItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BedrockChecksSensitiveInformationEntityItemType value)
        {
            return value switch
            {
                BedrockChecksSensitiveInformationEntityItemType.Address => "ADDRESS",
                BedrockChecksSensitiveInformationEntityItemType.Age => "AGE",
                BedrockChecksSensitiveInformationEntityItemType.AwsAccessKey => "AWS_ACCESS_KEY",
                BedrockChecksSensitiveInformationEntityItemType.AwsSecretKey => "AWS_SECRET_KEY",
                BedrockChecksSensitiveInformationEntityItemType.CaHealthNumber => "CA_HEALTH_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.CaSocialInsuranceNumber => "CA_SOCIAL_INSURANCE_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.CreditDebitCardCvv => "CREDIT_DEBIT_CARD_CVV",
                BedrockChecksSensitiveInformationEntityItemType.CreditDebitCardExpiry => "CREDIT_DEBIT_CARD_EXPIRY",
                BedrockChecksSensitiveInformationEntityItemType.CreditDebitCardNumber => "CREDIT_DEBIT_CARD_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.DriverId => "DRIVER_ID",
                BedrockChecksSensitiveInformationEntityItemType.Email => "EMAIL",
                BedrockChecksSensitiveInformationEntityItemType.InternationalBankAccountNumber => "INTERNATIONAL_BANK_ACCOUNT_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.IpAddress => "IP_ADDRESS",
                BedrockChecksSensitiveInformationEntityItemType.LicensePlate => "LICENSE_PLATE",
                BedrockChecksSensitiveInformationEntityItemType.MacAddress => "MAC_ADDRESS",
                BedrockChecksSensitiveInformationEntityItemType.Name => "NAME",
                BedrockChecksSensitiveInformationEntityItemType.Password => "PASSWORD",
                BedrockChecksSensitiveInformationEntityItemType.Phone => "PHONE",
                BedrockChecksSensitiveInformationEntityItemType.Pin => "PIN",
                BedrockChecksSensitiveInformationEntityItemType.SwiftCode => "SWIFT_CODE",
                BedrockChecksSensitiveInformationEntityItemType.UkNationalHealthServiceNumber => "UK_NATIONAL_HEALTH_SERVICE_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.UkNationalInsuranceNumber => "UK_NATIONAL_INSURANCE_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.UkUniqueTaxpayerReferenceNumber => "UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.Url => "URL",
                BedrockChecksSensitiveInformationEntityItemType.Username => "USERNAME",
                BedrockChecksSensitiveInformationEntityItemType.UsBankAccountNumber => "US_BANK_ACCOUNT_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.UsBankRoutingNumber => "US_BANK_ROUTING_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.UsIndividualTaxIdentificationNumber => "US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.UsPassportNumber => "US_PASSPORT_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.UsSocialSecurityNumber => "US_SOCIAL_SECURITY_NUMBER",
                BedrockChecksSensitiveInformationEntityItemType.VehicleIdentificationNumber => "VEHICLE_IDENTIFICATION_NUMBER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BedrockChecksSensitiveInformationEntityItemType? ToEnum(string value)
        {
            return value switch
            {
                "ADDRESS" => BedrockChecksSensitiveInformationEntityItemType.Address,
                "AGE" => BedrockChecksSensitiveInformationEntityItemType.Age,
                "AWS_ACCESS_KEY" => BedrockChecksSensitiveInformationEntityItemType.AwsAccessKey,
                "AWS_SECRET_KEY" => BedrockChecksSensitiveInformationEntityItemType.AwsSecretKey,
                "CA_HEALTH_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.CaHealthNumber,
                "CA_SOCIAL_INSURANCE_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.CaSocialInsuranceNumber,
                "CREDIT_DEBIT_CARD_CVV" => BedrockChecksSensitiveInformationEntityItemType.CreditDebitCardCvv,
                "CREDIT_DEBIT_CARD_EXPIRY" => BedrockChecksSensitiveInformationEntityItemType.CreditDebitCardExpiry,
                "CREDIT_DEBIT_CARD_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.CreditDebitCardNumber,
                "DRIVER_ID" => BedrockChecksSensitiveInformationEntityItemType.DriverId,
                "EMAIL" => BedrockChecksSensitiveInformationEntityItemType.Email,
                "INTERNATIONAL_BANK_ACCOUNT_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.InternationalBankAccountNumber,
                "IP_ADDRESS" => BedrockChecksSensitiveInformationEntityItemType.IpAddress,
                "LICENSE_PLATE" => BedrockChecksSensitiveInformationEntityItemType.LicensePlate,
                "MAC_ADDRESS" => BedrockChecksSensitiveInformationEntityItemType.MacAddress,
                "NAME" => BedrockChecksSensitiveInformationEntityItemType.Name,
                "PASSWORD" => BedrockChecksSensitiveInformationEntityItemType.Password,
                "PHONE" => BedrockChecksSensitiveInformationEntityItemType.Phone,
                "PIN" => BedrockChecksSensitiveInformationEntityItemType.Pin,
                "SWIFT_CODE" => BedrockChecksSensitiveInformationEntityItemType.SwiftCode,
                "UK_NATIONAL_HEALTH_SERVICE_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.UkNationalHealthServiceNumber,
                "UK_NATIONAL_INSURANCE_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.UkNationalInsuranceNumber,
                "UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.UkUniqueTaxpayerReferenceNumber,
                "URL" => BedrockChecksSensitiveInformationEntityItemType.Url,
                "USERNAME" => BedrockChecksSensitiveInformationEntityItemType.Username,
                "US_BANK_ACCOUNT_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.UsBankAccountNumber,
                "US_BANK_ROUTING_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.UsBankRoutingNumber,
                "US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.UsIndividualTaxIdentificationNumber,
                "US_PASSPORT_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.UsPassportNumber,
                "US_SOCIAL_SECURITY_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.UsSocialSecurityNumber,
                "VEHICLE_IDENTIFICATION_NUMBER" => BedrockChecksSensitiveInformationEntityItemType.VehicleIdentificationNumber,
                _ => null,
            };
        }
    }
}