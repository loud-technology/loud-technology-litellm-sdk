
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Optional start date (YYYY-MM-DD). When provided together with end_date, dynamic tags are limited to those active in the window. Stored tags are always returned.
    /// </summary>
    public sealed partial class ListTagsTagListGetStartDate
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}