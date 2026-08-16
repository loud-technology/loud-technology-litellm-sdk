
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum CoordinationRedisSettingsResponseSource2
    {
        /// <summary>
        /// 
        /// </summary>
        CacheBackend,
        /// <summary>
        /// 
        /// </summary>
        CoordinationRedis,
        /// <summary>
        /// 
        /// </summary>
        Environment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CoordinationRedisSettingsResponseSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CoordinationRedisSettingsResponseSource2 value)
        {
            return value switch
            {
                CoordinationRedisSettingsResponseSource2.CacheBackend => "cache_backend",
                CoordinationRedisSettingsResponseSource2.CoordinationRedis => "coordination_redis",
                CoordinationRedisSettingsResponseSource2.Environment => "environment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CoordinationRedisSettingsResponseSource2? ToEnum(string value)
        {
            return value switch
            {
                "cache_backend" => CoordinationRedisSettingsResponseSource2.CacheBackend,
                "coordination_redis" => CoordinationRedisSettingsResponseSource2.CoordinationRedis,
                "environment" => CoordinationRedisSettingsResponseSource2.Environment,
                _ => null,
            };
        }
    }
}