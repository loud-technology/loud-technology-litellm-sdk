
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// When to run the complexity classifier. 'every_request' (the default) classifies every inference request, including the tool-result continuation turns of an agentic loop. 'user_turn' classifies only requests whose newest turn is a new human ask and replays the session's held routing decision on continuation turns, which cuts classifier spend and eliminates mid-loop model switches. Continuations with no held decision to replay (no resolvable session_id, expired pin, fresh restart) still classify. Unlike session_affinity, a new human ask always re-classifies, so a session can still move tiers between asks. Suppressed when plugins are configured, for the same reason session_affinity is: a replayed decision would bypass the plugin pipeline.<br/>
    /// Default Value: every_request
    /// </summary>
    public enum RequestComplexityRouterConfigClassificationMode
    {
        /// <summary>
        /// a replayed decision would bypass the plugin pipeline.
        /// </summary>
        EveryRequest,
        /// <summary>
        /// a replayed decision would bypass the plugin pipeline.
        /// </summary>
        UserTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestComplexityRouterConfigClassificationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestComplexityRouterConfigClassificationMode value)
        {
            return value switch
            {
                RequestComplexityRouterConfigClassificationMode.EveryRequest => "every_request",
                RequestComplexityRouterConfigClassificationMode.UserTurn => "user_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestComplexityRouterConfigClassificationMode? ToEnum(string value)
        {
            return value switch
            {
                "every_request" => RequestComplexityRouterConfigClassificationMode.EveryRequest,
                "user_turn" => RequestComplexityRouterConfigClassificationMode.UserTurn,
                _ => null,
            };
        }
    }
}