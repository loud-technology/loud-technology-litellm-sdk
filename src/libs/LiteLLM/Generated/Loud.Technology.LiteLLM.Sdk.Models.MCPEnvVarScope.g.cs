
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Scope for an MCP server environment variable.<br/>
    /// - ``global``: value is provided by the admin and used for all users.<br/>
    /// - ``user``: each user must provide their own value via the per-user<br/>
    ///   env-var endpoint. The admin-supplied ``value`` is treated as a<br/>
    ///   placeholder/hint and is not used at request time.
    /// </summary>
    public enum MCPEnvVarScope
    {
        /// <summary>
        /// value is provided by the admin and used for all users.
        /// </summary>
        Global,
        /// <summary>
        /// value is provided by the admin and used for all users.
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPEnvVarScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPEnvVarScope value)
        {
            return value switch
            {
                MCPEnvVarScope.Global => "global",
                MCPEnvVarScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPEnvVarScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => MCPEnvVarScope.Global,
                "user" => MCPEnvVarScope.User,
                _ => null,
            };
        }
    }
}