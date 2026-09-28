
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum UISettingsResponseSource2
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
    public static class UISettingsResponseSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UISettingsResponseSource2 value)
        {
            return value switch
            {
                UISettingsResponseSource2.Config => "config",
                UISettingsResponseSource2.Db => "db",
                UISettingsResponseSource2.Default => "default",
                UISettingsResponseSource2.Env => "env",
                UISettingsResponseSource2.Unset => "unset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UISettingsResponseSource2? ToEnum(string value)
        {
            return value switch
            {
                "config" => UISettingsResponseSource2.Config,
                "db" => UISettingsResponseSource2.Db,
                "default" => UISettingsResponseSource2.Default,
                "env" => UISettingsResponseSource2.Env,
                "unset" => UISettingsResponseSource2.Unset,
                _ => null,
            };
        }
    }
}