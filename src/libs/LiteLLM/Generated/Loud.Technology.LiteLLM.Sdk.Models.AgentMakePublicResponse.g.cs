
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentMakePublicResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_agent_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PublicAgentGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMakePublicResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="publicAgentGroups"></param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMakePublicResponse(
            string message,
            global::System.Collections.Generic.IList<string> publicAgentGroups,
            string updatedBy)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.PublicAgentGroups = publicAgentGroups ?? throw new global::System.ArgumentNullException(nameof(publicAgentGroups));
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMakePublicResponse" /> class.
        /// </summary>
        public AgentMakePublicResponse()
        {
        }

    }
}