
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The canonical Cisco AI Defense rule name to evaluate.
    /// </summary>
    public enum CiscoAIDefenseRuleRuleName
    {
        /// <summary>
        ///
        /// </summary>
        CodeDetection,
        /// <summary>
        ///
        /// </summary>
        Harassment,
        /// <summary>
        ///
        /// </summary>
        HateSpeech,
        /// <summary>
        ///
        /// </summary>
        Pci,
        /// <summary>
        ///
        /// </summary>
        Phi,
        /// <summary>
        ///
        /// </summary>
        Pii,
        /// <summary>
        ///
        /// </summary>
        Profanity,
        /// <summary>
        ///
        /// </summary>
        PromptInjection,
        /// <summary>
        ///
        /// </summary>
        SexualContent_Exploitation,
        /// <summary>
        ///
        /// </summary>
        SocialDivision_Polarization,
        /// <summary>
        ///
        /// </summary>
        Violence_PublicSafetyThreats,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiscoAIDefenseRuleRuleNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiscoAIDefenseRuleRuleName value)
        {
            return value switch
            {
                CiscoAIDefenseRuleRuleName.CodeDetection => "Code Detection",
                CiscoAIDefenseRuleRuleName.Harassment => "Harassment",
                CiscoAIDefenseRuleRuleName.HateSpeech => "Hate Speech",
                CiscoAIDefenseRuleRuleName.Pci => "PCI",
                CiscoAIDefenseRuleRuleName.Phi => "PHI",
                CiscoAIDefenseRuleRuleName.Pii => "PII",
                CiscoAIDefenseRuleRuleName.Profanity => "Profanity",
                CiscoAIDefenseRuleRuleName.PromptInjection => "Prompt Injection",
                CiscoAIDefenseRuleRuleName.SexualContent_Exploitation => "Sexual Content & Exploitation",
                CiscoAIDefenseRuleRuleName.SocialDivision_Polarization => "Social Division & Polarization",
                CiscoAIDefenseRuleRuleName.Violence_PublicSafetyThreats => "Violence & Public Safety Threats",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiscoAIDefenseRuleRuleName? ToEnum(string value)
        {
            return value switch
            {
                "Code Detection" => CiscoAIDefenseRuleRuleName.CodeDetection,
                "Harassment" => CiscoAIDefenseRuleRuleName.Harassment,
                "Hate Speech" => CiscoAIDefenseRuleRuleName.HateSpeech,
                "PCI" => CiscoAIDefenseRuleRuleName.Pci,
                "PHI" => CiscoAIDefenseRuleRuleName.Phi,
                "PII" => CiscoAIDefenseRuleRuleName.Pii,
                "Profanity" => CiscoAIDefenseRuleRuleName.Profanity,
                "Prompt Injection" => CiscoAIDefenseRuleRuleName.PromptInjection,
                "Sexual Content & Exploitation" => CiscoAIDefenseRuleRuleName.SexualContent_Exploitation,
                "Social Division & Polarization" => CiscoAIDefenseRuleRuleName.SocialDivision_Polarization,
                "Violence & Public Safety Threats" => CiscoAIDefenseRuleRuleName.Violence_PublicSafetyThreats,
                _ => null,
            };
        }
    }
}