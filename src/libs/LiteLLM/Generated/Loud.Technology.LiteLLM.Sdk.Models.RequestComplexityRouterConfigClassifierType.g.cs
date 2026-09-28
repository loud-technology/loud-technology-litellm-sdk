
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Classification strategy: local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call<br/>
    /// Default Value: heuristic
    /// </summary>
    public enum RequestComplexityRouterConfigClassifierType
    {
        /// <summary>
        /// local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call
        /// </summary>
        Capability,
        /// <summary>
        /// local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call
        /// </summary>
        Custom,
        /// <summary>
        /// local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call
        /// </summary>
        Heuristic,
        /// <summary>
        /// local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call
        /// </summary>
        HeuristicFirst,
        /// <summary>
        ///
        /// </summary>
        HeuristicV2,
        /// <summary>
        /// local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call
        /// </summary>
        Hybrid,
        /// <summary>
        /// local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call
        /// </summary>
        Jev,
        /// <summary>
        ///
        /// </summary>
        Llm,
        /// <summary>
        ///
        /// </summary>
        LlmV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestComplexityRouterConfigClassifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestComplexityRouterConfigClassifierType value)
        {
            return value switch
            {
                RequestComplexityRouterConfigClassifierType.Capability => "capability",
                RequestComplexityRouterConfigClassifierType.Custom => "custom",
                RequestComplexityRouterConfigClassifierType.Heuristic => "heuristic",
                RequestComplexityRouterConfigClassifierType.HeuristicFirst => "heuristic_first",
                RequestComplexityRouterConfigClassifierType.HeuristicV2 => "heuristic_v2",
                RequestComplexityRouterConfigClassifierType.Hybrid => "hybrid",
                RequestComplexityRouterConfigClassifierType.Jev => "jev",
                RequestComplexityRouterConfigClassifierType.Llm => "llm",
                RequestComplexityRouterConfigClassifierType.LlmV2 => "llm_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestComplexityRouterConfigClassifierType? ToEnum(string value)
        {
            return value switch
            {
                "capability" => RequestComplexityRouterConfigClassifierType.Capability,
                "custom" => RequestComplexityRouterConfigClassifierType.Custom,
                "heuristic" => RequestComplexityRouterConfigClassifierType.Heuristic,
                "heuristic_first" => RequestComplexityRouterConfigClassifierType.HeuristicFirst,
                "heuristic_v2" => RequestComplexityRouterConfigClassifierType.HeuristicV2,
                "hybrid" => RequestComplexityRouterConfigClassifierType.Hybrid,
                "jev" => RequestComplexityRouterConfigClassifierType.Jev,
                "llm" => RequestComplexityRouterConfigClassifierType.Llm,
                "llm_v2" => RequestComplexityRouterConfigClassifierType.LlmV2,
                _ => null,
            };
        }
    }
}