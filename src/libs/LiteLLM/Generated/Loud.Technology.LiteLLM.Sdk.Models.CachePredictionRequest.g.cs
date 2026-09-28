
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CachePredictionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentDeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidate_deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CandidateDeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CachePredictionRequest" /> class.
        /// </summary>
        /// <param name="currentDeploymentId"></param>
        /// <param name="candidateDeploymentId"></param>
        /// <param name="request"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CachePredictionRequest(
            string currentDeploymentId,
            string candidateDeploymentId,
            object request)
        {
            this.CurrentDeploymentId = currentDeploymentId ?? throw new global::System.ArgumentNullException(nameof(currentDeploymentId));
            this.CandidateDeploymentId = candidateDeploymentId ?? throw new global::System.ArgumentNullException(nameof(candidateDeploymentId));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CachePredictionRequest" /> class.
        /// </summary>
        public CachePredictionRequest()
        {
        }

    }
}