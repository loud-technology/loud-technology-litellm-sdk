
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListToolsV1ToolListGetInputPolicy2
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Trusted,
        /// <summary>
        /// 
        /// </summary>
        Untrusted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListToolsV1ToolListGetInputPolicy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListToolsV1ToolListGetInputPolicy2 value)
        {
            return value switch
            {
                ListToolsV1ToolListGetInputPolicy2.Blocked => "blocked",
                ListToolsV1ToolListGetInputPolicy2.Trusted => "trusted",
                ListToolsV1ToolListGetInputPolicy2.Untrusted => "untrusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListToolsV1ToolListGetInputPolicy2? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ListToolsV1ToolListGetInputPolicy2.Blocked,
                "trusted" => ListToolsV1ToolListGetInputPolicy2.Trusted,
                "untrusted" => ListToolsV1ToolListGetInputPolicy2.Untrusted,
                _ => null,
            };
        }
    }
}