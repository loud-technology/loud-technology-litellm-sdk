
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamCallbackDeleteResponseData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_callbacks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SuccessCallbacks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_callbacks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FailureCallbacks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamCallbackDeleteResponseData" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="successCallbacks"></param>
        /// <param name="failureCallbacks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamCallbackDeleteResponseData(
            string teamId,
            global::System.Collections.Generic.IList<string> successCallbacks,
            global::System.Collections.Generic.IList<string> failureCallbacks)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.SuccessCallbacks = successCallbacks ?? throw new global::System.ArgumentNullException(nameof(successCallbacks));
            this.FailureCallbacks = failureCallbacks ?? throw new global::System.ArgumentNullException(nameof(failureCallbacks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamCallbackDeleteResponseData" /> class.
        /// </summary>
        public TeamCallbackDeleteResponseData()
        {
        }

    }
}