
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FusePresetCatalog
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.FuseModelPreset> Models { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harnesses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.FuseHarnessPreset> Harnesses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusePresetCatalog" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="models"></param>
        /// <param name="harnesses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusePresetCatalog(
            string version,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.FuseModelPreset> models,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.FuseHarnessPreset> harnesses)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Harnesses = harnesses ?? throw new global::System.ArgumentNullException(nameof(harnesses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusePresetCatalog" /> class.
        /// </summary>
        public FusePresetCatalog()
        {
        }

    }
}