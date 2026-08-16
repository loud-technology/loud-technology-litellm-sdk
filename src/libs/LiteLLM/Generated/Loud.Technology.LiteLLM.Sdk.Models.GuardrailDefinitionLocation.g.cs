
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailDefinitionLocation
    {
        /// <summary>
        /// 
        /// </summary>
        Config,
        /// <summary>
        /// 
        /// </summary>
        Db,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailDefinitionLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailDefinitionLocation value)
        {
            return value switch
            {
                GuardrailDefinitionLocation.Config => "config",
                GuardrailDefinitionLocation.Db => "db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailDefinitionLocation? ToEnum(string value)
        {
            return value switch
            {
                "config" => GuardrailDefinitionLocation.Config,
                "db" => GuardrailDefinitionLocation.Db,
                _ => null,
            };
        }
    }
}