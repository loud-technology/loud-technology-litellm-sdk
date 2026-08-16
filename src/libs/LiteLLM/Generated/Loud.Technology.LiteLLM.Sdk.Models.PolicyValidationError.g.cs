
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Represents a validation error or warning for a policy.
    /// </summary>
    public sealed partial class PolicyValidationError
    {
        /// <summary>
        /// Type of validation error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.PolicyValidationErrorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PolicyValidationErrorType ErrorType { get; set; }

        /// <summary>
        /// Specific field that caused the error (e.g., 'guardrails.add', 'scope.teams').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Name of the policy with the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PolicyName { get; set; }

        /// <summary>
        /// The invalid value that caused the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyValidationError" /> class.
        /// </summary>
        /// <param name="errorType">
        /// Type of validation error.
        /// </param>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="policyName">
        /// Name of the policy with the issue.
        /// </param>
        /// <param name="field">
        /// Specific field that caused the error (e.g., 'guardrails.add', 'scope.teams').
        /// </param>
        /// <param name="value">
        /// The invalid value that caused the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyValidationError(
            global::Loud.Technology.LiteLLM.Sdk.PolicyValidationErrorType errorType,
            string message,
            string policyName,
            string? field,
            string? value)
        {
            this.ErrorType = errorType;
            this.Field = field;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.PolicyName = policyName ?? throw new global::System.ArgumentNullException(nameof(policyName));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyValidationError" /> class.
        /// </summary>
        public PolicyValidationError()
        {
        }

    }
}