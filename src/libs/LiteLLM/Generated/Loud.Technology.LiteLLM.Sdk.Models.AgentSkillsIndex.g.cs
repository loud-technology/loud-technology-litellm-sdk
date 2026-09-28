
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSkillsIndex
    {
        /// <summary>
        /// Default Value: https://schemas.agentskills.io/discovery/0.2.0/schema.json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$schema")]
        public string? x_schema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentSkillsIndexEntry> Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkillsIndex" /> class.
        /// </summary>
        /// <param name="skills"></param>
        /// <param name="x_schema">
        /// Default Value: https://schemas.agentskills.io/discovery/0.2.0/schema.json
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSkillsIndex(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentSkillsIndexEntry> skills,
            string? x_schema)
        {
            this.x_schema = x_schema;
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkillsIndex" /> class.
        /// </summary>
        public AgentSkillsIndex()
        {
        }

    }
}