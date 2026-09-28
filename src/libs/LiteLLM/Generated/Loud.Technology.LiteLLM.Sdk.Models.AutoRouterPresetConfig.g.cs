
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The complexity_router_config a preset prefills.<br/>
    /// Only tiers is validated, because every dashboard consumer dereferences it; everything else<br/>
    /// passes through verbatim with unknown fields kept (extra="allow"), so a catalog published after<br/>
    /// this proxy shipped still serves its new fields intact.
    /// </summary>
    public sealed partial class AutoRouterPresetConfig
    {
        /// <summary>
        /// Exactly the four built-in tiers the dashboard's preset prefill can apply.<br/>
        /// extra="forbid" on purpose: a tier name this dashboard cannot apply would grey out or crash the<br/>
        /// picker, so such a catalog is rejected wholesale and the bundled one serves instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AutoRouterPresetTiers Tiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPresetConfig" /> class.
        /// </summary>
        /// <param name="tiers">
        /// Exactly the four built-in tiers the dashboard's preset prefill can apply.<br/>
        /// extra="forbid" on purpose: a tier name this dashboard cannot apply would grey out or crash the<br/>
        /// picker, so such a catalog is rejected wholesale and the bundled one serves instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterPresetConfig(
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterPresetTiers tiers)
        {
            this.Tiers = tiers ?? throw new global::System.ArgumentNullException(nameof(tiers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPresetConfig" /> class.
        /// </summary>
        public AutoRouterPresetConfig()
        {
        }

    }
}