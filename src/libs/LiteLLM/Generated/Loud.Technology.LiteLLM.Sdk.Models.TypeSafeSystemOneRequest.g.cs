
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TypeSafeSystemOneRequest
    {
        /// <summary>
        /// Content to evaluate, as plain text or structured data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, global::System.Collections.Generic.IList<object>> State { get; set; }

        /// <summary>
        /// Jev model identifier.<br/>
        /// Default Value: jev-latest
        /// </summary>
        /// <default>"jev-latest"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; } = "jev-latest";

        /// <summary>
        /// Questions to evaluate against the state, keyed by question id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.TypeSafeQuestion> Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSafeSystemOneRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// Content to evaluate, as plain text or structured data.
        /// </param>
        /// <param name="model">
        /// Jev model identifier.<br/>
        /// Default Value: jev-latest
        /// </param>
        /// <param name="questions">
        /// Questions to evaluate against the state, keyed by question id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypeSafeSystemOneRequest(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, global::System.Collections.Generic.IList<object>> state,
            string model,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.TypeSafeQuestion> questions)
        {
            this.State = state;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSafeSystemOneRequest" /> class.
        /// </summary>
        public TypeSafeSystemOneRequest()
        {
        }

    }
}