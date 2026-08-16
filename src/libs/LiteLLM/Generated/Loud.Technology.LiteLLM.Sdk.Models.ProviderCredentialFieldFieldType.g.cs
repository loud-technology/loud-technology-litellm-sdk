
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum ProviderCredentialFieldFieldType
    {
        /// <summary>
        /// 
        /// </summary>
        Password,
        /// <summary>
        /// 
        /// </summary>
        Select,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Textarea,
        /// <summary>
        /// 
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderCredentialFieldFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderCredentialFieldFieldType value)
        {
            return value switch
            {
                ProviderCredentialFieldFieldType.Password => "password",
                ProviderCredentialFieldFieldType.Select => "select",
                ProviderCredentialFieldFieldType.Text => "text",
                ProviderCredentialFieldFieldType.Textarea => "textarea",
                ProviderCredentialFieldFieldType.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderCredentialFieldFieldType? ToEnum(string value)
        {
            return value switch
            {
                "password" => ProviderCredentialFieldFieldType.Password,
                "select" => ProviderCredentialFieldFieldType.Select,
                "text" => ProviderCredentialFieldFieldType.Text,
                "textarea" => ProviderCredentialFieldFieldType.Textarea,
                "upload" => ProviderCredentialFieldFieldType.Upload,
                _ => null,
            };
        }
    }
}