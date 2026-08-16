
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum AgentCredentialFieldFieldType
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
    public static class AgentCredentialFieldFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCredentialFieldFieldType value)
        {
            return value switch
            {
                AgentCredentialFieldFieldType.Password => "password",
                AgentCredentialFieldFieldType.Select => "select",
                AgentCredentialFieldFieldType.Text => "text",
                AgentCredentialFieldFieldType.Textarea => "textarea",
                AgentCredentialFieldFieldType.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCredentialFieldFieldType? ToEnum(string value)
        {
            return value switch
            {
                "password" => AgentCredentialFieldFieldType.Password,
                "select" => AgentCredentialFieldFieldType.Select,
                "text" => AgentCredentialFieldFieldType.Text,
                "textarea" => AgentCredentialFieldFieldType.Textarea,
                "upload" => AgentCredentialFieldFieldType.Upload,
                _ => null,
            };
        }
    }
}