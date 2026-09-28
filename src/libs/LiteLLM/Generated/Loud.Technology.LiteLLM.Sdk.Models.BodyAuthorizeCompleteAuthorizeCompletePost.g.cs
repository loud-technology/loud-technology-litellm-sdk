
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyAuthorizeCompleteAuthorizeCompletePost
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        public string? Decision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        public string? Delivery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Flow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAuthorizeCompleteAuthorizeCompletePost" /> class.
        /// </summary>
        /// <param name="flow"></param>
        /// <param name="decision"></param>
        /// <param name="delivery"></param>
        /// <param name="teamId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAuthorizeCompleteAuthorizeCompletePost(
            string flow,
            string? decision,
            string? delivery,
            string? teamId)
        {
            this.Decision = decision;
            this.Delivery = delivery;
            this.Flow = flow ?? throw new global::System.ArgumentNullException(nameof(flow));
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAuthorizeCompleteAuthorizeCompletePost" /> class.
        /// </summary>
        public BodyAuthorizeCompleteAuthorizeCompletePost()
        {
        }

    }
}