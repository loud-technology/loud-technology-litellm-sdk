
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Where this policy is defined: 'db' (database) or 'config' (config.yaml).<br/>
    /// Default Value: db
    /// </summary>
    public enum PolicyDBResponseDefinitionLocation
    {
        /// <summary>
        /// 'db' (database) or 'config' (config.yaml).
        /// </summary>
        Config,
        /// <summary>
        /// 'db' (database) or 'config' (config.yaml).
        /// </summary>
        Db,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PolicyDBResponseDefinitionLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PolicyDBResponseDefinitionLocation value)
        {
            return value switch
            {
                PolicyDBResponseDefinitionLocation.Config => "config",
                PolicyDBResponseDefinitionLocation.Db => "db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PolicyDBResponseDefinitionLocation? ToEnum(string value)
        {
            return value switch
            {
                "config" => PolicyDBResponseDefinitionLocation.Config,
                "db" => PolicyDBResponseDefinitionLocation.Db,
                _ => null,
            };
        }
    }
}