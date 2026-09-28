
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: forward
    /// </summary>
    public enum ShadowEvalJobResponseDirection
    {
        /// <summary>
        ///
        /// </summary>
        Forward,
        /// <summary>
        ///
        /// </summary>
        Reverse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShadowEvalJobResponseDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShadowEvalJobResponseDirection value)
        {
            return value switch
            {
                ShadowEvalJobResponseDirection.Forward => "forward",
                ShadowEvalJobResponseDirection.Reverse => "reverse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShadowEvalJobResponseDirection? ToEnum(string value)
        {
            return value switch
            {
                "forward" => ShadowEvalJobResponseDirection.Forward,
                "reverse" => ShadowEvalJobResponseDirection.Reverse,
                _ => null,
            };
        }
    }
}