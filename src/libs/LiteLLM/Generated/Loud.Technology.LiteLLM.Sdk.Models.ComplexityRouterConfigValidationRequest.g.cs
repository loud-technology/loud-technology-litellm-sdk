
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A complexity-router config to validate without saving, so a form can surface the<br/>
    /// backend's own verdict inline instead of a raw 400 at write time.
    /// </summary>
    public sealed partial class ComplexityRouterConfigValidationRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complexity_router_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ComplexityRouterConfig { get; set; }

        /// <summary>
        /// Team the router is being created for. Required for a team admin, who may only validate their own team's routers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexityRouterConfigValidationRequest" /> class.
        /// </summary>
        /// <param name="complexityRouterConfig"></param>
        /// <param name="teamId">
        /// Team the router is being created for. Required for a team admin, who may only validate their own team's routers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComplexityRouterConfigValidationRequest(
            object complexityRouterConfig,
            string? teamId)
        {
            this.ComplexityRouterConfig = complexityRouterConfig ?? throw new global::System.ArgumentNullException(nameof(complexityRouterConfig));
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexityRouterConfigValidationRequest" /> class.
        /// </summary>
        public ComplexityRouterConfigValidationRequest()
        {
        }

    }
}