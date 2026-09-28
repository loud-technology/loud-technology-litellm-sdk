
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One open/close delimiter pair a harness wraps injected context in.<br/>
    /// Normalizing here rather than at the scan is what makes matching case-insensitive: markers reach<br/>
    /// the scan already lowered, so it lowercases only the haystack and never the needles. Stripping<br/>
    /// keeps YAML indentation whitespace from becoming part of the delimiter.
    /// </summary>
    public sealed partial class ReminderMarkerPair
    {
        /// <summary>
        /// Opening delimiter, e.g. '&lt;system-reminder&gt;'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Open { get; set; }

        /// <summary>
        /// Closing delimiter, e.g. '&lt;/system-reminder&gt;'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Close { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReminderMarkerPair" /> class.
        /// </summary>
        /// <param name="open">
        /// Opening delimiter, e.g. '&lt;system-reminder&gt;'
        /// </param>
        /// <param name="close">
        /// Closing delimiter, e.g. '&lt;/system-reminder&gt;'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReminderMarkerPair(
            string open,
            string close)
        {
            this.Open = open ?? throw new global::System.ArgumentNullException(nameof(open));
            this.Close = close ?? throw new global::System.ArgumentNullException(nameof(close));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReminderMarkerPair" /> class.
        /// </summary>
        public ReminderMarkerPair()
        {
        }

    }
}