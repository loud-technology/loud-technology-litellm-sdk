
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum CoordinationRedisSettingsFieldSection
    {
        /// <summary>
        /// 
        /// </summary>
        Cluster,
        /// <summary>
        /// 
        /// </summary>
        Connection,
        /// <summary>
        /// 
        /// </summary>
        Sentinel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CoordinationRedisSettingsFieldSectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CoordinationRedisSettingsFieldSection value)
        {
            return value switch
            {
                CoordinationRedisSettingsFieldSection.Cluster => "cluster",
                CoordinationRedisSettingsFieldSection.Connection => "connection",
                CoordinationRedisSettingsFieldSection.Sentinel => "sentinel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CoordinationRedisSettingsFieldSection? ToEnum(string value)
        {
            return value switch
            {
                "cluster" => CoordinationRedisSettingsFieldSection.Cluster,
                "connection" => CoordinationRedisSettingsFieldSection.Connection,
                "sentinel" => CoordinationRedisSettingsFieldSection.Sentinel,
                _ => null,
            };
        }
    }
}