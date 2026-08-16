
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Where this attachment is defined: 'db' (database) or 'config' (config.yaml).<br/>
    /// Default Value: db
    /// </summary>
    public enum PolicyAttachmentDBResponseDefinitionLocation
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
    public static class PolicyAttachmentDBResponseDefinitionLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PolicyAttachmentDBResponseDefinitionLocation value)
        {
            return value switch
            {
                PolicyAttachmentDBResponseDefinitionLocation.Config => "config",
                PolicyAttachmentDBResponseDefinitionLocation.Db => "db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PolicyAttachmentDBResponseDefinitionLocation? ToEnum(string value)
        {
            return value switch
            {
                "config" => PolicyAttachmentDBResponseDefinitionLocation.Config,
                "db" => PolicyAttachmentDBResponseDefinitionLocation.Db,
                _ => null,
            };
        }
    }
}