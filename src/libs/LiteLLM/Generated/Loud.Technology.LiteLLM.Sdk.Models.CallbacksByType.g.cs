
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbacksByType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Failure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_and_failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SuccessAndFailure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbacksByType" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="failure"></param>
        /// <param name="successAndFailure"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbacksByType(
            global::System.Collections.Generic.IList<string> success,
            global::System.Collections.Generic.IList<string> failure,
            global::System.Collections.Generic.IList<string> successAndFailure)
        {
            this.Success = success ?? throw new global::System.ArgumentNullException(nameof(success));
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
            this.SuccessAndFailure = successAndFailure ?? throw new global::System.ArgumentNullException(nameof(successAndFailure));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbacksByType" /> class.
        /// </summary>
        public CallbacksByType()
        {
        }

    }
}