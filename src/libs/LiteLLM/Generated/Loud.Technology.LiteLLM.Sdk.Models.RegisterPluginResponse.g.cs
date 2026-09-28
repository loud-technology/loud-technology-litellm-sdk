
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response from plugin registration.
    /// </summary>
    public sealed partial class RegisterPluginResponse
    {
        /// <summary>
        /// Action taken (created/updated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// Plugin information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PluginResponse Plugin { get; set; }

        /// <summary>
        /// Operation status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPluginResponse" /> class.
        /// </summary>
        /// <param name="action">
        /// Action taken (created/updated)
        /// </param>
        /// <param name="plugin">
        /// Plugin information
        /// </param>
        /// <param name="status">
        /// Operation status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterPluginResponse(
            string action,
            global::Loud.Technology.LiteLLM.Sdk.PluginResponse plugin,
            string status)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Plugin = plugin ?? throw new global::System.ArgumentNullException(nameof(plugin));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPluginResponse" /> class.
        /// </summary>
        public RegisterPluginResponse()
        {
        }

    }
}