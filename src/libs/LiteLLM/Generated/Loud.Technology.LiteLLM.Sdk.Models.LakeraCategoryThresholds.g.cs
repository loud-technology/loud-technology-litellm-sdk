
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LakeraCategoryThresholds
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jailbreak")]
        public double? Jailbreak { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injection")]
        public double? PromptInjection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LakeraCategoryThresholds" /> class.
        /// </summary>
        /// <param name="jailbreak"></param>
        /// <param name="promptInjection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LakeraCategoryThresholds(
            double? jailbreak,
            double? promptInjection)
        {
            this.Jailbreak = jailbreak;
            this.PromptInjection = promptInjection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LakeraCategoryThresholds" /> class.
        /// </summary>
        public LakeraCategoryThresholds()
        {
        }

    }
}