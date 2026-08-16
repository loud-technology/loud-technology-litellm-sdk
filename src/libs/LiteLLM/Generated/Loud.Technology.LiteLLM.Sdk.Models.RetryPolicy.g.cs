
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Use this to set a custom number of retries per exception type<br/>
    /// If RateLimitErrorRetries = 3, then 3 retries will be made for RateLimitError<br/>
    /// Mapping of Exception type to number of retries<br/>
    /// https://docs.litellm.ai/docs/exception_mapping
    /// </summary>
    public sealed partial class RetryPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("BadRequestErrorRetries")]
        public int? BadRequestErrorRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("AuthenticationErrorRetries")]
        public int? AuthenticationErrorRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TimeoutErrorRetries")]
        public int? TimeoutErrorRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("RateLimitErrorRetries")]
        public int? RateLimitErrorRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContentPolicyViolationErrorRetries")]
        public int? ContentPolicyViolationErrorRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("InternalServerErrorRetries")]
        public int? InternalServerErrorRetries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryPolicy" /> class.
        /// </summary>
        /// <param name="badRequestErrorRetries"></param>
        /// <param name="authenticationErrorRetries"></param>
        /// <param name="timeoutErrorRetries"></param>
        /// <param name="rateLimitErrorRetries"></param>
        /// <param name="contentPolicyViolationErrorRetries"></param>
        /// <param name="internalServerErrorRetries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetryPolicy(
            int? badRequestErrorRetries,
            int? authenticationErrorRetries,
            int? timeoutErrorRetries,
            int? rateLimitErrorRetries,
            int? contentPolicyViolationErrorRetries,
            int? internalServerErrorRetries)
        {
            this.BadRequestErrorRetries = badRequestErrorRetries;
            this.AuthenticationErrorRetries = authenticationErrorRetries;
            this.TimeoutErrorRetries = timeoutErrorRetries;
            this.RateLimitErrorRetries = rateLimitErrorRetries;
            this.ContentPolicyViolationErrorRetries = contentPolicyViolationErrorRetries;
            this.InternalServerErrorRetries = internalServerErrorRetries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryPolicy" /> class.
        /// </summary>
        public RetryPolicy()
        {
        }

    }
}