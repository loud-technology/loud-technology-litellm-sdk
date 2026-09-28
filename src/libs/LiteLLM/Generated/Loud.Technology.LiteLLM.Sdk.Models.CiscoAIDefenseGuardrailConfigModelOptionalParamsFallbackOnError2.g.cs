
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2 value)
        {
            return value switch
            {
                CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2.Allow => "allow",
                CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2.Allow,
                "block" => CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2.Block,
                _ => null,
            };
        }
    }
}