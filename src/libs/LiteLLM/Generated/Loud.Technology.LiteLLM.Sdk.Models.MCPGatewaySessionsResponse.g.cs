
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPGatewaySessionsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_client")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPGatewaySessionGroupCount>? ByClient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_user")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPGatewaySessionGroupCount>? ByUser { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPGatewaySession>? Sessions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSessions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worker_pid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkerPid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPGatewaySessionsResponse" /> class.
        /// </summary>
        /// <param name="totalSessions"></param>
        /// <param name="workerPid"></param>
        /// <param name="byClient"></param>
        /// <param name="byUser"></param>
        /// <param name="sessions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPGatewaySessionsResponse(
            int totalSessions,
            int workerPid,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPGatewaySessionGroupCount>? byClient,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPGatewaySessionGroupCount>? byUser,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPGatewaySession>? sessions)
        {
            this.ByClient = byClient;
            this.ByUser = byUser;
            this.Sessions = sessions;
            this.TotalSessions = totalSessions;
            this.WorkerPid = workerPid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPGatewaySessionsResponse" /> class.
        /// </summary>
        public MCPGatewaySessionsResponse()
        {
        }

    }
}