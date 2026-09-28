
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Anthropic tool-search result block, carried through untouched so it survives a round trip.
    /// </summary>
    public sealed partial class ChatCompletionToolReferenceObject
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"tool_reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_reference";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolReferenceObject" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionToolReferenceObject(
            string toolName,
            string type = "tool_reference")
        {
            this.Type = type;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolReferenceObject" /> class.
        /// </summary>
        public ChatCompletionToolReferenceObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionToolReferenceObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionToolReferenceObject FromToolName(string toolName)
        {
            return new ChatCompletionToolReferenceObject
            {
                ToolName = toolName,
            };
        }

    }
}