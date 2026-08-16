
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelInfoTier2
    {
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Paid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInfoTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInfoTier2 value)
        {
            return value switch
            {
                ModelInfoTier2.Free => "free",
                ModelInfoTier2.Paid => "paid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInfoTier2? ToEnum(string value)
        {
            return value switch
            {
                "free" => ModelInfoTier2.Free,
                "paid" => ModelInfoTier2.Paid,
                _ => null,
            };
        }
    }
}