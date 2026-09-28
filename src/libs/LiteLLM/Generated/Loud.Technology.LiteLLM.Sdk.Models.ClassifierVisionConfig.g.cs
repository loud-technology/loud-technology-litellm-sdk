
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Whether the LLM classifier sees the images on the request it is classifying.<br/>
    /// Off by default because images cost far more than the text ask they arrive with, and the<br/>
    /// classifier runs on every request. A turn whose complexity lives in the image ("what is wrong in<br/>
    /// this stack trace screenshot") is invisible to a text-only classifier, which is what this buys.
    /// </summary>
    public sealed partial class ClassifierVisionConfig
    {
        /// <summary>
        /// Forward image content to the classifier. Requires a classifier model declared supports_vision, on the deployment's model_info or in the model cost map; images stay stripped otherwise, so a classifier that cannot read them is never sent one. Declare model_info.supports_vision on the deployment to enable a model the cost map does not describe. Only inline data: URIs are forwarded. A request whose images are http(s) URLs still classifies on its text alone, because some providers fetch such a URL from the proxy rather than the provider, which would let a caller aim a proxy-side request at an address of their choosing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// How many images from the newest user turn to forward, in wire order. Bounds the added cost of a turn that attaches many images. Images on earlier turns are never forwarded.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_images")]
        public int? MaxImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierVisionConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Forward image content to the classifier. Requires a classifier model declared supports_vision, on the deployment's model_info or in the model cost map; images stay stripped otherwise, so a classifier that cannot read them is never sent one. Declare model_info.supports_vision on the deployment to enable a model the cost map does not describe. Only inline data: URIs are forwarded. A request whose images are http(s) URLs still classifies on its text alone, because some providers fetch such a URL from the proxy rather than the provider, which would let a caller aim a proxy-side request at an address of their choosing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxImages">
        /// How many images from the newest user turn to forward, in wire order. Bounds the added cost of a turn that attaches many images. Images on earlier turns are never forwarded.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierVisionConfig(
            bool? enabled,
            int? maxImages)
        {
            this.Enabled = enabled;
            this.MaxImages = maxImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierVisionConfig" /> class.
        /// </summary>
        public ClassifierVisionConfig()
        {
        }

    }
}