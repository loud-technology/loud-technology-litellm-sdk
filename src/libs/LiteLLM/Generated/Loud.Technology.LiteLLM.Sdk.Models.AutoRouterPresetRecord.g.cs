
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One auto-router preset as served to the dashboard's template picker.
    /// </summary>
    public sealed partial class AutoRouterPresetRecord
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The complexity_router_config a preset prefills.<br/>
        /// Only tiers is validated, because every dashboard consumer dereferences it; everything else<br/>
        /// passes through verbatim with unknown fields kept (extra="allow"), so a catalog published after<br/>
        /// this proxy shipped still serves its new fields intact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complexity_router_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AutoRouterPresetConfig ComplexityRouterConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPresetRecord" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="description"></param>
        /// <param name="complexityRouterConfig">
        /// The complexity_router_config a preset prefills.<br/>
        /// Only tiers is validated, because every dashboard consumer dereferences it; everything else<br/>
        /// passes through verbatim with unknown fields kept (extra="allow"), so a catalog published after<br/>
        /// this proxy shipped still serves its new fields intact.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterPresetRecord(
            string label,
            string description,
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterPresetConfig complexityRouterConfig)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ComplexityRouterConfig = complexityRouterConfig ?? throw new global::System.ArgumentNullException(nameof(complexityRouterConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPresetRecord" /> class.
        /// </summary>
        public AutoRouterPresetRecord()
        {
        }

    }
}