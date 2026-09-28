
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessGroupBudgetResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Spend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        public global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudget? Budget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupBudgetResponse" /> class.
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="spend"></param>
        /// <param name="budget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessGroupBudgetResponse(
            string accessGroup,
            double spend,
            global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudget? budget)
        {
            this.AccessGroup = accessGroup ?? throw new global::System.ArgumentNullException(nameof(accessGroup));
            this.Spend = spend;
            this.Budget = budget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupBudgetResponse" /> class.
        /// </summary>
        public AccessGroupBudgetResponse()
        {
        }

    }
}