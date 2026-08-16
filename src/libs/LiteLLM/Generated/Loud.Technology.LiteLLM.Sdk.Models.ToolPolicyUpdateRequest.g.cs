
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolPolicyUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_policy")]
        public global::Loud.Technology.LiteLLM.Sdk.ToolPolicyUpdateRequestInputPolicy2? InputPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_alias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hash")]
        public string? KeyHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_policy")]
        public global::Loud.Technology.LiteLLM.Sdk.ToolPolicyUpdateRequestOutputPolicy2? OutputPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolPolicyUpdateRequest" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="inputPolicy"></param>
        /// <param name="keyAlias"></param>
        /// <param name="keyHash"></param>
        /// <param name="outputPolicy"></param>
        /// <param name="teamId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPolicyUpdateRequest(
            string toolName,
            global::Loud.Technology.LiteLLM.Sdk.ToolPolicyUpdateRequestInputPolicy2? inputPolicy,
            string? keyAlias,
            string? keyHash,
            global::Loud.Technology.LiteLLM.Sdk.ToolPolicyUpdateRequestOutputPolicy2? outputPolicy,
            string? teamId)
        {
            this.InputPolicy = inputPolicy;
            this.KeyAlias = keyAlias;
            this.KeyHash = keyHash;
            this.OutputPolicy = outputPolicy;
            this.TeamId = teamId;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPolicyUpdateRequest" /> class.
        /// </summary>
        public ToolPolicyUpdateRequest()
        {
        }

    }
}