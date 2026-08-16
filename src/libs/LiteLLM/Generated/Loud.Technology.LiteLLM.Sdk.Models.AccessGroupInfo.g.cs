
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessGroupInfo(
            string accessGroup,
            global::System.Collections.Generic.IList<string> modelNames,
            int deploymentCount)
        {
            this.AccessGroup = accessGroup ?? throw new global::System.ArgumentNullException(nameof(accessGroup));
            this.ModelNames = modelNames ?? throw new global::System.ArgumentNullException(nameof(modelNames));
            this.DeploymentCount = deploymentCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupInfo" /> class.
        /// </summary>
        public AccessGroupInfo()
        {
        }

    }
}