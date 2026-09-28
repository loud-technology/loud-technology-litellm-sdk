
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Payload for storing the calling user's per-user env var values.
    /// </summary>
    public sealed partial class MCPUserEnvVarsRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserEnvVarsRequest" /> class.
        /// </summary>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPUserEnvVarsRequest(
            global::System.Collections.Generic.Dictionary<string, string> values)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserEnvVarsRequest" /> class.
        /// </summary>
        public MCPUserEnvVarsRequest()
        {
        }

    }
}