
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Which Cisco AI Defense inspection surface to use. 'chat' scans LLM model conversations via /api/v1/inspect/chat. 'mcp' scans MCP tool calls via /api/v1/inspect/mcp. Each guardrail instance targets exactly one surface; configure two guardrails to scan both chat and MCP traffic.<br/>
    /// Default Value: chat
    /// </summary>
    public enum CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType
    {
        /// <summary>
        ///
        /// </summary>
        Chat,
        /// <summary>
        ///
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType value)
        {
            return value switch
            {
                CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType.Chat => "chat",
                CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType.Chat,
                "mcp" => CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType.Mcp,
                _ => null,
            };
        }
    }
}