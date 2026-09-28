#nullable enable

namespace Loud.Technology.LiteLLM.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType>
    {
        /// <inheritdoc />
        public override global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionTypeExtensions.ToValueString(value));
        }
    }
}
