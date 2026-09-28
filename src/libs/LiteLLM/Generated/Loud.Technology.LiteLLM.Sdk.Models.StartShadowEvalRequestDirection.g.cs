
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// forward answers 'should this key adopt router_name': it samples the requests the key did NOT route through the router and duplicates them through it. reverse answers 'is the router still worth it for a key already on it': it samples the requests the router did serve and duplicates them against baseline_model. The response the caller received is always the real arm<br/>
    /// Default Value: forward
    /// </summary>
    public enum StartShadowEvalRequestDirection
    {
        /// <summary>
        /// it samples the requests the key did NOT route through the router and duplicates them through it. reverse answers 'is the router still worth it for a key already on it': it samples the requests the router did serve and duplicates them against baseline_model. The response the caller received is always the real arm
        /// </summary>
        Forward,
        /// <summary>
        /// it samples the requests the key did NOT route through the router and duplicates them through it. reverse answers 'is the router still worth it for a key already on it': it samples the requests the router did serve and duplicates them against baseline_model. The response the caller received is always the real arm
        /// </summary>
        Reverse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartShadowEvalRequestDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartShadowEvalRequestDirection value)
        {
            return value switch
            {
                StartShadowEvalRequestDirection.Forward => "forward",
                StartShadowEvalRequestDirection.Reverse => "reverse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartShadowEvalRequestDirection? ToEnum(string value)
        {
            return value switch
            {
                "forward" => StartShadowEvalRequestDirection.Forward,
                "reverse" => StartShadowEvalRequestDirection.Reverse,
                _ => null,
            };
        }
    }
}