
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Enum for key management routes
    /// </summary>
    public enum KeyManagementRoutes
    {
        /// <summary>
        /// 
        /// </summary>
        KeyAccessGroupAssignment,
        /// <summary>
        /// 
        /// </summary>
        KeyAliases,
        /// <summary>
        /// 
        /// </summary>
        KeyBlock,
        /// <summary>
        /// 
        /// </summary>
        KeyBulkUpdate,
        /// <summary>
        /// 
        /// </summary>
        KeyDelete,
        /// <summary>
        /// 
        /// </summary>
        KeyGenerate,
        /// <summary>
        /// 
        /// </summary>
        KeyHealth,
        /// <summary>
        /// 
        /// </summary>
        KeyInfo,
        /// <summary>
        /// 
        /// </summary>
        KeyList,
        /// <summary>
        /// 
        /// </summary>
        KeyRegenerate,
        /// <summary>
        /// 
        /// </summary>
        KeyServiceAccountGenerate,
        /// <summary>
        /// 
        /// </summary>
        KeyUnblock,
        /// <summary>
        /// 
        /// </summary>
        KeyUpdate,
        /// <summary>
        /// 
        /// </summary>
        Key_keyId_Regenerate,
        /// <summary>
        /// 
        /// </summary>
        Key_keyId_ResetSpend,
        /// <summary>
        /// 
        /// </summary>
        SpendLogs,
        /// <summary>
        /// 
        /// </summary>
        SpendLogsV2,
        /// <summary>
        /// 
        /// </summary>
        TeamDailyActivity,
        /// <summary>
        /// 
        /// </summary>
        TeamKeyBulkUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyManagementRoutesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyManagementRoutes value)
        {
            return value switch
            {
                KeyManagementRoutes.KeyAccessGroupAssignment => "/key/access_group_assignment",
                KeyManagementRoutes.KeyAliases => "/key/aliases",
                KeyManagementRoutes.KeyBlock => "/key/block",
                KeyManagementRoutes.KeyBulkUpdate => "/key/bulk_update",
                KeyManagementRoutes.KeyDelete => "/key/delete",
                KeyManagementRoutes.KeyGenerate => "/key/generate",
                KeyManagementRoutes.KeyHealth => "/key/health",
                KeyManagementRoutes.KeyInfo => "/key/info",
                KeyManagementRoutes.KeyList => "/key/list",
                KeyManagementRoutes.KeyRegenerate => "/key/regenerate",
                KeyManagementRoutes.KeyServiceAccountGenerate => "/key/service-account/generate",
                KeyManagementRoutes.KeyUnblock => "/key/unblock",
                KeyManagementRoutes.KeyUpdate => "/key/update",
                KeyManagementRoutes.Key_keyId_Regenerate => "/key/{key_id}/regenerate",
                KeyManagementRoutes.Key_keyId_ResetSpend => "/key/{key_id}/reset_spend",
                KeyManagementRoutes.SpendLogs => "/spend/logs",
                KeyManagementRoutes.SpendLogsV2 => "/spend/logs/v2",
                KeyManagementRoutes.TeamDailyActivity => "/team/daily/activity",
                KeyManagementRoutes.TeamKeyBulkUpdate => "/team/key/bulk_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyManagementRoutes? ToEnum(string value)
        {
            return value switch
            {
                "/key/access_group_assignment" => KeyManagementRoutes.KeyAccessGroupAssignment,
                "/key/aliases" => KeyManagementRoutes.KeyAliases,
                "/key/block" => KeyManagementRoutes.KeyBlock,
                "/key/bulk_update" => KeyManagementRoutes.KeyBulkUpdate,
                "/key/delete" => KeyManagementRoutes.KeyDelete,
                "/key/generate" => KeyManagementRoutes.KeyGenerate,
                "/key/health" => KeyManagementRoutes.KeyHealth,
                "/key/info" => KeyManagementRoutes.KeyInfo,
                "/key/list" => KeyManagementRoutes.KeyList,
                "/key/regenerate" => KeyManagementRoutes.KeyRegenerate,
                "/key/service-account/generate" => KeyManagementRoutes.KeyServiceAccountGenerate,
                "/key/unblock" => KeyManagementRoutes.KeyUnblock,
                "/key/update" => KeyManagementRoutes.KeyUpdate,
                "/key/{key_id}/regenerate" => KeyManagementRoutes.Key_keyId_Regenerate,
                "/key/{key_id}/reset_spend" => KeyManagementRoutes.Key_keyId_ResetSpend,
                "/spend/logs" => KeyManagementRoutes.SpendLogs,
                "/spend/logs/v2" => KeyManagementRoutes.SpendLogsV2,
                "/team/daily/activity" => KeyManagementRoutes.TeamDailyActivity,
                "/team/key/bulk_update" => KeyManagementRoutes.TeamKeyBulkUpdate,
                _ => null,
            };
        }
    }
}