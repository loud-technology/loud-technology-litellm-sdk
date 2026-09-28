
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// What classifies the request when the LLM classifier errors, times out, or returns an unparseable response. 'heuristic' runs the local complexity scorer, which is right when the classifier grades complexity too. 'default_model' skips scoring and routes to default_model, which is what a classifier on some other taxonomy wants: a prompt that grades data sensitivity has no use for a complexity score, and scoring one produces a tier unrelated to what the operator configured. Requires default_model when set to 'default_model'. Only applies when classifier_type is 'llm', 'custom', or 'heuristic_first'.<br/>
    /// Default Value: heuristic
    /// </summary>
    public enum RequestComplexityRouterConfigClassifierFallback
    {
        /// <summary>
        /// a prompt that grades data sensitivity has no use for a complexity score, and scoring one produces a tier unrelated to what the operator configured. Requires default_model when set to 'default_model'. Only applies when classifier_type is 'llm', 'custom', or 'heuristic_first'.
        /// </summary>
        DefaultModel,
        /// <summary>
        /// a prompt that grades data sensitivity has no use for a complexity score, and scoring one produces a tier unrelated to what the operator configured. Requires default_model when set to 'default_model'. Only applies when classifier_type is 'llm', 'custom', or 'heuristic_first'.
        /// </summary>
        Heuristic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestComplexityRouterConfigClassifierFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestComplexityRouterConfigClassifierFallback value)
        {
            return value switch
            {
                RequestComplexityRouterConfigClassifierFallback.DefaultModel => "default_model",
                RequestComplexityRouterConfigClassifierFallback.Heuristic => "heuristic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestComplexityRouterConfigClassifierFallback? ToEnum(string value)
        {
            return value switch
            {
                "default_model" => RequestComplexityRouterConfigClassifierFallback.DefaultModel,
                "heuristic" => RequestComplexityRouterConfigClassifierFallback.Heuristic,
                _ => null,
            };
        }
    }
}