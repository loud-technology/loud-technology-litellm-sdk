
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum RouterSettingsResponseSource2
    {
        /// <summary>
        ///
        /// </summary>
        Config,
        /// <summary>
        ///
        /// </summary>
        Db,
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Env,
        /// <summary>
        ///
        /// </summary>
        Unset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouterSettingsResponseSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouterSettingsResponseSource2 value)
        {
            return value switch
            {
                RouterSettingsResponseSource2.Config => "config",
                RouterSettingsResponseSource2.Db => "db",
                RouterSettingsResponseSource2.Default => "default",
                RouterSettingsResponseSource2.Env => "env",
                RouterSettingsResponseSource2.Unset => "unset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouterSettingsResponseSource2? ToEnum(string value)
        {
            return value switch
            {
                "config" => RouterSettingsResponseSource2.Config,
                "db" => RouterSettingsResponseSource2.Db,
                "default" => RouterSettingsResponseSource2.Default,
                "env" => RouterSettingsResponseSource2.Env,
                "unset" => RouterSettingsResponseSource2.Unset,
                _ => null,
            };
        }
    }
}