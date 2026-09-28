
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum MCPServerUserCredentialListItemCredentialType
    {
        /// <summary>
        ///
        /// </summary>
        Byok,
        /// <summary>
        ///
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPServerUserCredentialListItemCredentialTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPServerUserCredentialListItemCredentialType value)
        {
            return value switch
            {
                MCPServerUserCredentialListItemCredentialType.Byok => "byok",
                MCPServerUserCredentialListItemCredentialType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPServerUserCredentialListItemCredentialType? ToEnum(string value)
        {
            return value switch
            {
                "byok" => MCPServerUserCredentialListItemCredentialType.Byok,
                "oauth2" => MCPServerUserCredentialListItemCredentialType.Oauth2,
                _ => null,
            };
        }
    }
}