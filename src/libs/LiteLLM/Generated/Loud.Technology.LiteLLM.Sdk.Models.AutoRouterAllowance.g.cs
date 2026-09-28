
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoRouterAllowance
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_by_this_router")]
        public bool? UsedByThisRouter { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        public bool? Available { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterAllowance" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="limit"></param>
        /// <param name="remaining"></param>
        /// <param name="usedByThisRouter">
        /// Default Value: false
        /// </param>
        /// <param name="available">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterAllowance(
            string key,
            int? limit,
            int? remaining,
            bool? usedByThisRouter,
            bool? available)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Limit = limit;
            this.Remaining = remaining;
            this.UsedByThisRouter = usedByThisRouter;
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterAllowance" /> class.
        /// </summary>
        public AutoRouterAllowance()
        {
        }

    }
}