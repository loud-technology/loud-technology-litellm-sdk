
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum AllowedVectorStoreIndexItemIndexPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AllowedVectorStoreIndexItemIndexPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedVectorStoreIndexItemIndexPermission value)
        {
            return value switch
            {
                AllowedVectorStoreIndexItemIndexPermission.Read => "read",
                AllowedVectorStoreIndexItemIndexPermission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedVectorStoreIndexItemIndexPermission? ToEnum(string value)
        {
            return value switch
            {
                "read" => AllowedVectorStoreIndexItemIndexPermission.Read,
                "write" => AllowedVectorStoreIndexItemIndexPermission.Write,
                _ => null,
            };
        }
    }
}