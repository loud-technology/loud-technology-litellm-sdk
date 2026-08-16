
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateModelGroupRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_names")]
        public global::System.Collections.Generic.IList<string>? ModelNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_ids")]
        public global::System.Collections.Generic.IList<string>? ModelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelGroupRequest" /> class.
        /// </summary>
        /// <param name="modelNames"></param>
        /// <param name="modelIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateModelGroupRequest(
            global::System.Collections.Generic.IList<string>? modelNames,
            global::System.Collections.Generic.IList<string>? modelIds)
        {
            this.ModelNames = modelNames;
            this.ModelIds = modelIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelGroupRequest" /> class.
        /// </summary>
        public UpdateModelGroupRequest()
        {
        }

    }
}