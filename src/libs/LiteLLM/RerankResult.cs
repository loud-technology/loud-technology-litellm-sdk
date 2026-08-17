namespace Loud.Technology.LiteLLM.Sdk;

public sealed partial class RerankResult
{
    /// <summary>
    /// Gets the Cohere-compatible relevance score, falling back to a provider-specific score.
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    public double EffectiveScore => RelevanceScore ?? Score ?? 0d;
}
