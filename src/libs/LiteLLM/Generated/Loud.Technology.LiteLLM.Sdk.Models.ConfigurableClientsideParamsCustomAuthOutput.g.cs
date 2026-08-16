
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigurableClientsideParamsCustomAuthOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiBase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurableClientsideParamsCustomAuthOutput" /> class.
        /// </summary>
        /// <param name="apiBase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurableClientsideParamsCustomAuthOutput(
            string apiBase)
        {
            this.ApiBase = apiBase ?? throw new global::System.ArgumentNullException(nameof(apiBase));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurableClientsideParamsCustomAuthOutput" /> class.
        /// </summary>
        public ConfigurableClientsideParamsCustomAuthOutput()
        {
        }

    }
}