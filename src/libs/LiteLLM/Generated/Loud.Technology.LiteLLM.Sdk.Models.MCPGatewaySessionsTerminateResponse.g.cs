
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Stateful sessions an administrator force-closed on this proxy worker.
    /// </summary>
    public sealed partial class MCPGatewaySessionsTerminateResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPGatewaySession>? Sessions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminated_sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TerminatedSessions { get; set; }

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
        /// Initializes a new instance of the <see cref="MCPGatewaySessionsTerminateResponse" /> class.
        /// </summary>
        /// <param name="terminatedSessions"></param>
        /// <param name="workerPid"></param>
        /// <param name="sessions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPGatewaySessionsTerminateResponse(
            int terminatedSessions,
            int workerPid,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPGatewaySession>? sessions)
        {
            this.Sessions = sessions;
            this.TerminatedSessions = terminatedSessions;
            this.WorkerPid = workerPid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPGatewaySessionsTerminateResponse" /> class.
        /// </summary>
        public MCPGatewaySessionsTerminateResponse()
        {
        }

    }
}