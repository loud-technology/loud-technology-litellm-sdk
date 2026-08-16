
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiteLLMModelTable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_aliases")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, object>? ModelAliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable? Team { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMModelTable" /> class.
        /// </summary>
        /// <param name="createdBy"></param>
        /// <param name="updatedBy"></param>
        /// <param name="id"></param>
        /// <param name="modelAliases"></param>
        /// <param name="team"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMModelTable(
            string createdBy,
            string updatedBy,
            int? id,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, object>? modelAliases,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable? team)
        {
            this.Id = id;
            this.ModelAliases = modelAliases;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
            this.Team = team;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMModelTable" /> class.
        /// </summary>
        public LiteLLMModelTable()
        {
        }

    }
}