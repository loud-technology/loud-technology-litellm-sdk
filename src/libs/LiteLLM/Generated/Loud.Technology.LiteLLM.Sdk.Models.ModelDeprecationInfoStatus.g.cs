
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 'deprecated' if the date has passed, 'imminent' if it falls within warn_within_days, 'upcoming' otherwise.
    /// </summary>
    public enum ModelDeprecationInfoStatus
    {
        /// <summary>
        ///
        /// </summary>
        Deprecated,
        /// <summary>
        ///
        /// </summary>
        Imminent,
        /// <summary>
        ///
        /// </summary>
        Upcoming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelDeprecationInfoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelDeprecationInfoStatus value)
        {
            return value switch
            {
                ModelDeprecationInfoStatus.Deprecated => "deprecated",
                ModelDeprecationInfoStatus.Imminent => "imminent",
                ModelDeprecationInfoStatus.Upcoming => "upcoming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelDeprecationInfoStatus? ToEnum(string value)
        {
            return value switch
            {
                "deprecated" => ModelDeprecationInfoStatus.Deprecated,
                "imminent" => ModelDeprecationInfoStatus.Imminent,
                "upcoming" => ModelDeprecationInfoStatus.Upcoming,
                _ => null,
            };
        }
    }
}