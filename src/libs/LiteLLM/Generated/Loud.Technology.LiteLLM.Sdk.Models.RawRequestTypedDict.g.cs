
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RawRequestTypedDict
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_request_api_base")]
        public string? RawRequestApiBase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_request_body")]
        public object? RawRequestBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_request_headers")]
        public object? RawRequestHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawRequestTypedDict" /> class.
        /// </summary>
        /// <param name="rawRequestApiBase"></param>
        /// <param name="rawRequestBody"></param>
        /// <param name="rawRequestHeaders"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RawRequestTypedDict(
            string? rawRequestApiBase,
            object? rawRequestBody,
            object? rawRequestHeaders,
            string? error)
        {
            this.RawRequestApiBase = rawRequestApiBase;
            this.RawRequestBody = rawRequestBody;
            this.RawRequestHeaders = rawRequestHeaders;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawRequestTypedDict" /> class.
        /// </summary>
        public RawRequestTypedDict()
        {
        }

    }
}