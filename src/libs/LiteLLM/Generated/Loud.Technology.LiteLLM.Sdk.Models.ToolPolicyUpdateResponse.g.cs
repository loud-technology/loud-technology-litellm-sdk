
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolPolicyUpdateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_policy")]
        public global::Loud.Technology.LiteLLM.Sdk.ToolPolicyUpdateResponseInputPolicy2? InputPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hash")]
        public string? KeyHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_policy")]
        public global::Loud.Technology.LiteLLM.Sdk.ToolPolicyUpdateResponseOutputPolicy2? OutputPolicy { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPolicyUpdateResponse" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="updated"></param>
        /// <param name="inputPolicy"></param>
        /// <param name="keyHash"></param>
        /// <param name="outputPolicy"></param>
        /// <param name="teamId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPolicyUpdateResponse(
            string toolName,
            bool updated,
            global::Loud.Technology.LiteLLM.Sdk.ToolPolicyUpdateResponseInputPolicy2? inputPolicy,
            string? keyHash,
            global::Loud.Technology.LiteLLM.Sdk.ToolPolicyUpdateResponseOutputPolicy2? outputPolicy,
            string? teamId)
        {
            this.InputPolicy = inputPolicy;
            this.KeyHash = keyHash;
            this.OutputPolicy = outputPolicy;
            this.TeamId = teamId;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPolicyUpdateResponse" /> class.
        /// </summary>
        public ToolPolicyUpdateResponse()
        {
        }

    }
}