
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Key-value pairs of headers to be forwarded with the request. You can set any key value pair here and it will be forwarded to your target endpoint<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class PassThroughGenericEndpointHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}