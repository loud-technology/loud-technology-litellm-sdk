
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for /policy/test endpoint.
    /// </summary>
    public sealed partial class PolicyTestResponse
    {
        /// <summary>
        /// Context used to match a request against policies.<br/>
        /// Contains the team alias, key alias, and model from the incoming request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PolicyMatchContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matching_policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MatchingPolicies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_guardrails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ResolvedGuardrails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTestResponse" /> class.
        /// </summary>
        /// <param name="context">
        /// Context used to match a request against policies.<br/>
        /// Contains the team alias, key alias, and model from the incoming request.
        /// </param>
        /// <param name="matchingPolicies"></param>
        /// <param name="resolvedGuardrails"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyTestResponse(
            global::Loud.Technology.LiteLLM.Sdk.PolicyMatchContext context,
            global::System.Collections.Generic.IList<string> matchingPolicies,
            global::System.Collections.Generic.IList<string> resolvedGuardrails,
            string? message)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.MatchingPolicies = matchingPolicies ?? throw new global::System.ArgumentNullException(nameof(matchingPolicies));
            this.Message = message;
            this.ResolvedGuardrails = resolvedGuardrails ?? throw new global::System.ArgumentNullException(nameof(resolvedGuardrails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyTestResponse" /> class.
        /// </summary>
        public PolicyTestResponse()
        {
        }

    }
}