
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessGroupInfo
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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModelNames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeploymentCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

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
        /// Initializes a new instance of the <see cref="AccessGroupInfo" /> class.
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="modelNames"></param>
        /// <param name="deploymentCount"></param>
        /// <param name="spend"></param>
        /// <param name="budget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessGroupInfo(
            string accessGroup,
            global::System.Collections.Generic.IList<string> modelNames,
            int deploymentCount,
            double? spend,
            global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudget? budget)
        {
            this.AccessGroup = accessGroup ?? throw new global::System.ArgumentNullException(nameof(accessGroup));
            this.ModelNames = modelNames ?? throw new global::System.ArgumentNullException(nameof(modelNames));
            this.DeploymentCount = deploymentCount;
            this.Spend = spend;
            this.Budget = budget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupInfo" /> class.
        /// </summary>
        public AccessGroupInfo()
        {
        }

    }
}