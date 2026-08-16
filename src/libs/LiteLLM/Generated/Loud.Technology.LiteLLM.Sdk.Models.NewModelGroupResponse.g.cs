
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModelGroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessGroup { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models_updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelsUpdated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModelGroupResponse" /> class.
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="modelsUpdated"></param>
        /// <param name="modelNames"></param>
        /// <param name="modelIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModelGroupResponse(
            string accessGroup,
            int modelsUpdated,
            global::System.Collections.Generic.IList<string>? modelNames,
            global::System.Collections.Generic.IList<string>? modelIds)
        {
            this.AccessGroup = accessGroup ?? throw new global::System.ArgumentNullException(nameof(accessGroup));
            this.ModelNames = modelNames;
            this.ModelIds = modelIds;
            this.ModelsUpdated = modelsUpdated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModelGroupResponse" /> class.
        /// </summary>
        public NewModelGroupResponse()
        {
        }

    }
}