
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SCIMUserName2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("familyName")]
        public string? FamilyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted")]
        public string? Formatted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("givenName")]
        public string? GivenName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honorificPrefix")]
        public string? HonorificPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honorificSuffix")]
        public string? HonorificSuffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middleName")]
        public string? MiddleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMUserName2" /> class.
        /// </summary>
        /// <param name="familyName"></param>
        /// <param name="formatted"></param>
        /// <param name="givenName"></param>
        /// <param name="honorificPrefix"></param>
        /// <param name="honorificSuffix"></param>
        /// <param name="middleName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMUserName2(
            string? familyName,
            string? formatted,
            string? givenName,
            string? honorificPrefix,
            string? honorificSuffix,
            string? middleName)
        {
            this.FamilyName = familyName;
            this.Formatted = formatted;
            this.GivenName = givenName;
            this.HonorificPrefix = honorificPrefix;
            this.HonorificSuffix = honorificSuffix;
            this.MiddleName = middleName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMUserName2" /> class.
        /// </summary>
        public SCIMUserName2()
        {
        }

    }
}