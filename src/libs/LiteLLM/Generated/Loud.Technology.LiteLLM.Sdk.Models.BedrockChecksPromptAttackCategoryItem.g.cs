
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BedrockChecksPromptAttackCategoryItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.BedrockChecksPromptAttackCategoryItemCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.BedrockChecksPromptAttackCategoryItemCategory Category { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockChecksPromptAttackCategoryItem" /> class.
        /// </summary>
        /// <param name="category"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BedrockChecksPromptAttackCategoryItem(
            global::Loud.Technology.LiteLLM.Sdk.BedrockChecksPromptAttackCategoryItemCategory category)
        {
            this.Category = category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockChecksPromptAttackCategoryItem" /> class.
        /// </summary>
        public BedrockChecksPromptAttackCategoryItem()
        {
        }

    }
}