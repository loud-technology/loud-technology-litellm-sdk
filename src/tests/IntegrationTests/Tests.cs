namespace Loud.Technology.LiteLLM.Sdk.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LiteLLMClient GetAuthenticatedClient()
    {
        var apiKey = Environment.GetEnvironmentVariable("LITELLM_API_KEY") is { Length: > 0 } apiKeyValue
            ? apiKeyValue
            : throw new AssertInconclusiveException("LITELLM_API_KEY environment variable is not set.");

        var baseUrl = Environment.GetEnvironmentVariable("LITELLM_BASE_URL") ?? LiteLLMClient.DefaultBaseUrl;

        return new LiteLLMClient(apiKey: apiKey, baseUri: new Uri(baseUrl));
    }
}