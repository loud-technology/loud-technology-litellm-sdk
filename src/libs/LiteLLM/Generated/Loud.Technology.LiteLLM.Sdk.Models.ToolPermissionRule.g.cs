
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A rule defining permission for a specific tool or tool pattern
    /// </summary>
    public sealed partial class ToolPermissionRule
    {
        /// <summary>
        /// Optional regex map enforcing nested parameter values using dot/[] paths
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_param_patterns")]
        public global::System.Collections.Generic.Dictionary<string, string>? AllowedParamPatterns { get; set; }

        /// <summary>
        /// Whether to allow or deny this tool usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ToolPermissionRuleDecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ToolPermissionRuleDecision Decision { get; set; }

        /// <summary>
        /// Unique identifier for the rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Regex pattern applied to the tool's function name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// Regex pattern applied to the tool type (e.g., function)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        public string? ToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPermissionRule" /> class.
        /// </summary>
        /// <param name="decision">
        /// Whether to allow or deny this tool usage
        /// </param>
        /// <param name="id">
        /// Unique identifier for the rule
        /// </param>
        /// <param name="allowedParamPatterns">
        /// Optional regex map enforcing nested parameter values using dot/[] paths
        /// </param>
        /// <param name="toolName">
        /// Regex pattern applied to the tool's function name
        /// </param>
        /// <param name="toolType">
        /// Regex pattern applied to the tool type (e.g., function)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPermissionRule(
            global::Loud.Technology.LiteLLM.Sdk.ToolPermissionRuleDecision decision,
            string id,
            global::System.Collections.Generic.Dictionary<string, string>? allowedParamPatterns,
            string? toolName,
            string? toolType)
        {
            this.AllowedParamPatterns = allowedParamPatterns;
            this.Decision = decision;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ToolName = toolName;
            this.ToolType = toolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPermissionRule" /> class.
        /// </summary>
        public ToolPermissionRule()
        {
        }

    }
}