
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Defines optional capabilities supported by an agent.
    /// </summary>
    public sealed partial class AgentCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushNotifications")]
        public bool? PushNotifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stateTransitionHistory")]
        public bool? StateTransitionHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentExtension>? Extensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCapabilities" /> class.
        /// </summary>
        /// <param name="streaming"></param>
        /// <param name="pushNotifications"></param>
        /// <param name="stateTransitionHistory"></param>
        /// <param name="extensions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCapabilities(
            bool? streaming,
            bool? pushNotifications,
            bool? stateTransitionHistory,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentExtension>? extensions)
        {
            this.Streaming = streaming;
            this.PushNotifications = pushNotifications;
            this.StateTransitionHistory = stateTransitionHistory;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCapabilities" /> class.
        /// </summary>
        public AgentCapabilities()
        {
        }

    }
}