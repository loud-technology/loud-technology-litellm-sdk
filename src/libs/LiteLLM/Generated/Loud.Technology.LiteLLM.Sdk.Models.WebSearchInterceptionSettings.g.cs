
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for server-side web search interception
    /// </summary>
    public sealed partial class WebSearchInterceptionSettings
    {
        /// <summary>
        /// Serve web search tool calls from a configured search tool instead of passing them upstream<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// LLM providers to intercept for (e.g. 'bedrock', 'vertex_ai'). Empty intercepts Bedrock only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_providers")]
        public global::System.Collections.Generic.IList<string>? EnabledProviders { get; set; }

        /// <summary>
        /// Name of the configured search tool to run searches through. Empty uses the first one available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_tool_name")]
        public string? SearchToolName { get; set; }

        /// <summary>
        /// How many follow-up model calls one intercepted request may chain. Empty applies the default of 3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_agentic_loops")]
        public int? MaxAgenticLoops { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchInterceptionSettings" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Serve web search tool calls from a configured search tool instead of passing them upstream<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enabledProviders">
        /// LLM providers to intercept for (e.g. 'bedrock', 'vertex_ai'). Empty intercepts Bedrock only.
        /// </param>
        /// <param name="searchToolName">
        /// Name of the configured search tool to run searches through. Empty uses the first one available.
        /// </param>
        /// <param name="maxAgenticLoops">
        /// How many follow-up model calls one intercepted request may chain. Empty applies the default of 3.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchInterceptionSettings(
            bool? enabled,
            global::System.Collections.Generic.IList<string>? enabledProviders,
            string? searchToolName,
            int? maxAgenticLoops)
        {
            this.Enabled = enabled;
            this.EnabledProviders = enabledProviders;
            this.SearchToolName = searchToolName;
            this.MaxAgenticLoops = maxAgenticLoops;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchInterceptionSettings" /> class.
        /// </summary>
        public WebSearchInterceptionSettings()
        {
        }

    }
}