
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for POST /utils/test_policies_and_guardrails.
    /// </summary>
    public sealed partial class TestPoliciesAndGuardrailsRequest
    {
        /// <summary>
        /// When set, call chat completion with this model/agent for each input and include the response in the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Guardrail names to apply directly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_names")]
        public global::System.Collections.Generic.IList<string>? GuardrailNames { get; set; }

        /// <summary>
        /// Whether inputs are request or response<br/>
        /// Default Value: request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.TestPoliciesAndGuardrailsRequestInputTypeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.TestPoliciesAndGuardrailsRequestInputType? InputType { get; set; }

        /// <summary>
        /// List of GenericGuardrailAPIInputs; each item processed separately (for batch compliance testing).<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_list")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GenericGuardrailAPIInputs>? InputsList { get; set; }

        /// <summary>
        /// Policy names to resolve guardrails from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_names")]
        public global::System.Collections.Generic.IList<string>? PolicyNames { get; set; }

        /// <summary>
        /// Request context (model, user_id, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_data")]
        public object? RequestData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPoliciesAndGuardrailsRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// When set, call chat completion with this model/agent for each input and include the response in the result.
        /// </param>
        /// <param name="guardrailNames">
        /// Guardrail names to apply directly
        /// </param>
        /// <param name="inputType">
        /// Whether inputs are request or response<br/>
        /// Default Value: request
        /// </param>
        /// <param name="inputsList">
        /// List of GenericGuardrailAPIInputs; each item processed separately (for batch compliance testing).<br/>
        /// Default Value: []
        /// </param>
        /// <param name="policyNames">
        /// Policy names to resolve guardrails from
        /// </param>
        /// <param name="requestData">
        /// Request context (model, user_id, etc.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestPoliciesAndGuardrailsRequest(
            string? agentId,
            global::System.Collections.Generic.IList<string>? guardrailNames,
            global::Loud.Technology.LiteLLM.Sdk.TestPoliciesAndGuardrailsRequestInputType? inputType,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GenericGuardrailAPIInputs>? inputsList,
            global::System.Collections.Generic.IList<string>? policyNames,
            object? requestData)
        {
            this.AgentId = agentId;
            this.GuardrailNames = guardrailNames;
            this.InputType = inputType;
            this.InputsList = inputsList;
            this.PolicyNames = policyNames;
            this.RequestData = requestData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPoliciesAndGuardrailsRequest" /> class.
        /// </summary>
        public TestPoliciesAndGuardrailsRequest()
        {
        }

    }
}