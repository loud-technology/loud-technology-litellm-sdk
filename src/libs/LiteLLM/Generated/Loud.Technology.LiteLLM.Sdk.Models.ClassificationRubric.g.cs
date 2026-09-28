
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Which calibration examples, and for BUSINESS which tier criteria, the built-in classifier rubric carries.
    /// </summary>
    public enum ClassificationRubric
    {
        /// <summary>
        ///
        /// </summary>
        Agentic,
        /// <summary>
        ///
        /// </summary>
        Business,
        /// <summary>
        ///
        /// </summary>
        Chat,
        /// <summary>
        ///
        /// </summary>
        Legacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassificationRubricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassificationRubric value)
        {
            return value switch
            {
                ClassificationRubric.Agentic => "agentic",
                ClassificationRubric.Business => "business",
                ClassificationRubric.Chat => "chat",
                ClassificationRubric.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassificationRubric? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => ClassificationRubric.Agentic,
                "business" => ClassificationRubric.Business,
                "chat" => ClassificationRubric.Chat,
                "legacy" => ClassificationRubric.Legacy,
                _ => null,
            };
        }
    }
}