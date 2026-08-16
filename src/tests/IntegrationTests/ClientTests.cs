using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace Loud.Technology.LiteLLM.Sdk.IntegrationTests;

[TestClass]
public sealed class ClientTests
{
    [TestMethod]
    public void Constructor_ConfiguresDefaultBaseUrlAndBearerAuthentication()
    {
        using var client = new LiteLLMClient("test-api-key");

        client.BaseUri.Should().Be(new Uri("http://localhost:4000/"));
        var authorization = client.Authorizations.Should().ContainSingle().Which;
        authorization.Type.Should().Be("Http");
        authorization.Name.Should().Be("Bearer");
        authorization.Value.Should().Be("test-api-key");
    }

    [TestMethod]
    public async Task ChatCompletion_SendsExpectedRequest()
    {
        var handler = new RecordingHandler(
            new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"id\":\"chatcmpl-test\"}", Encoding.UTF8, "application/json"),
            });
        using var httpClient = new HttpClient(handler);
        using var client = new LiteLLMClient(
            apiKey: "test-api-key",
            httpClient: httpClient,
            baseUri: new Uri("https://proxy.example.com"),
            disposeHttpClient: false);

        var response = await client.ChatCompletions.ChatCompletionV1ChatCompletionsPostAsync(
            new ChatCompletionV1ChatCompletionsPostRequest
            {
                Model = "test-model",
                Messages =
                [
                    new ChatCompletionUserMessage
                    {
                        Content = "Hello from .NET",
                    },
                ],
            });

        response.Should().Contain("chatcmpl-test");
        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("https://proxy.example.com/v1/chat/completions"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-api-key"));
        handler.Body.Should().Contain("\"model\":\"test-model\"");
        handler.Body.Should().Contain("Hello from .NET");
    }

    private sealed class RecordingHandler(HttpResponseMessage response) : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public AuthenticationHeaderValue? Authorization { get; private set; }
        public string? Body { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization;
            Body = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken);

            return response;
        }
    }
}
