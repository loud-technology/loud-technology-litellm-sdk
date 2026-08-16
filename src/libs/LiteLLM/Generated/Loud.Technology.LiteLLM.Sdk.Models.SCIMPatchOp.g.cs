
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SCIMPatchOp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMPatchOperation> Operations { get; set; }

        /// <summary>
        /// Default Value: [urn:ietf:params:scim:api:messages:2.0:PatchOp]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        public global::System.Collections.Generic.IList<string>? Schemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMPatchOp" /> class.
        /// </summary>
        /// <param name="operations"></param>
        /// <param name="schemas">
        /// Default Value: [urn:ietf:params:scim:api:messages:2.0:PatchOp]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMPatchOp(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMPatchOperation> operations,
            global::System.Collections.Generic.IList<string>? schemas)
        {
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
            this.Schemas = schemas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMPatchOp" /> class.
        /// </summary>
        public SCIMPatchOp()
        {
        }

    }
}