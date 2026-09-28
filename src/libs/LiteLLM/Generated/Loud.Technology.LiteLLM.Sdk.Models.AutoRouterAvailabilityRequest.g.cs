
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoRouterAvailabilityRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_model_id")]
        public string? SavedModelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complexity_router_config")]
        public object? ComplexityRouterConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterAvailabilityRequest" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="savedModelId"></param>
        /// <param name="complexityRouterConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterAvailabilityRequest(
            string? teamId,
            string? savedModelId,
            object? complexityRouterConfig)
        {
            this.TeamId = teamId;
            this.SavedModelId = savedModelId;
            this.ComplexityRouterConfig = complexityRouterConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterAvailabilityRequest" /> class.
        /// </summary>
        public AutoRouterAvailabilityRequest()
        {
        }

    }
}