
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SCIMUserManager
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$ref")]
        public string? x_ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMUserManager" /> class.
        /// </summary>
        /// <param name="x_ref"></param>
        /// <param name="displayName"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMUserManager(
            string? x_ref,
            string? displayName,
            string? value)
        {
            this.x_ref = x_ref;
            this.DisplayName = displayName;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMUserManager" /> class.
        /// </summary>
        public SCIMUserManager()
        {
        }

    }
}