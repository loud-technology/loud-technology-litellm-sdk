
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for tag active users metrics
    /// </summary>
    public sealed partial class TagActiveUsersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start")]
        public string? PeriodStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_end")]
        public string? PeriodEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagActiveUsersResponse" /> class.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="activeUsers"></param>
        /// <param name="date"></param>
        /// <param name="periodStart"></param>
        /// <param name="periodEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagActiveUsersResponse(
            string tag,
            int activeUsers,
            string date,
            string? periodStart,
            string? periodEnd)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.ActiveUsers = activeUsers;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagActiveUsersResponse" /> class.
        /// </summary>
        public TagActiveUsersResponse()
        {
        }

    }
}