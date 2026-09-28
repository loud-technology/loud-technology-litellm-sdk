using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

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

    [TestMethod]
    public async Task Rerank_SendsTypedRequestAndReturnsTypedResults()
    {
        var handler = new RecordingHandler(
            new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """
                    {
                      "id": "rerank-test",
                      "results": [
                        { "index": 1, "relevance_score": 0.91 },
                        { "index": 0, "score": 0.42 }
                      ]
                    }
                    """,
                    Encoding.UTF8,
                    "application/json"),
            });
        using var httpClient = new HttpClient(handler);
        using var client = new LiteLLMClient(
            apiKey: "test-api-key",
            httpClient: httpClient,
            baseUri: new Uri("https://proxy.example.com"),
            disposeHttpClient: false);

        var response = await client.Rerank.RerankV1RerankPostAsync(
            new RerankRequest
            {
                Model = "test-rerank-model",
                Query = "Which document is relevant?",
                Documents = ["first document", "second document"],
                TopN = 2,
            });

        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("https://proxy.example.com/v1/rerank"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-api-key"));

        using var body = JsonDocument.Parse(handler.Body!);
        var root = body.RootElement;
        root.GetProperty("model").GetString().Should().Be("test-rerank-model");
        root.GetProperty("query").GetString().Should().Be("Which document is relevant?");
        root.GetProperty("documents").GetArrayLength().Should().Be(2);
        root.GetProperty("top_n").GetInt32().Should().Be(2);

        response.Id.Should().Be("rerank-test");
        response.Results.Should().HaveCount(2);
        response.Results[0].Index.Should().Be(1);
        response.Results[0].EffectiveScore.Should().Be(0.91);
        response.Results[1].Index.Should().Be(0);
        response.Results[1].EffectiveScore.Should().Be(0.42);
    }

    [TestMethod]
    public async Task TypeSafeSystemOne_SendsTypedQuestionsAndReturnsTypedAnswers()
    {
        var handler = new RecordingHandler(
            new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """
                    {
                      "model": "jev-1.13.0",
                      "answers": {
                        "department": {
                          "type": "choice",
                          "choice": "technical",
                          "probabilities": { "billing": 0.08, "technical": 0.85, "sales": 0.07 },
                          "confidence": 0.82
                        },
                        "urgency": {
                          "type": "score",
                          "score": 1.7,
                          "legend": { "0": "low", "1": "medium", "2": "high" },
                          "probabilities": { "0": 0.05, "1": 0.2, "2": 0.75 },
                          "confidence": 0.7
                        },
                        "is_complaint": { "type": "noul", "noul": 0.95 }
                      },
                      "usage": { "input_tokens": 312, "output_tokens": 48 }
                    }
                    """,
                    Encoding.UTF8,
                    "application/json"),
            });
        using var httpClient = new HttpClient(handler);
        using var client = new LiteLLMClient(
            apiKey: "test-api-key",
            httpClient: httpClient,
            baseUri: new Uri("https://proxy.example.com"),
            disposeHttpClient: false);

        var response = await client.TypeSafe.SystemOneAsync(
            new TypeSafeSystemOneRequest
            {
                State = "Help! My payouts have been failing for 3 days.",
                Model = "jev-latest",
                Questions = new()
                {
                    ["department"] = TypeSafeQuestion.Choice(
                        "Which team should handle this?",
                        new Dictionary<string, string?>
                        {
                            ["billing"] = "Payments, invoicing, refunds",
                            ["technical"] = "Bugs, outages, integrations",
                            ["sales"] = null,
                        }),
                    ["urgency"] = TypeSafeQuestion.Score("How urgent is this?", "low", "medium", "high"),
                    ["is_complaint"] = TypeSafeQuestion.Noul("Is the customer complaining?"),
                },
            });

        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("https://proxy.example.com/typesafe/v1/systemone"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-api-key"));

        using var body = JsonDocument.Parse(handler.Body!);
        var root = body.RootElement;
        root.GetProperty("state").GetString().Should().Be("Help! My payouts have been failing for 3 days.");
        root.GetProperty("model").GetString().Should().Be("jev-latest");
        var questions = root.GetProperty("questions");
        var department = questions.GetProperty("department");
        department.GetProperty("type").GetString().Should().Be("choice");
        department.GetProperty("criteria").GetProperty("technical").GetString().Should().Be("Bugs, outages, integrations");
        department.GetProperty("criteria").GetProperty("sales").ValueKind.Should().Be(JsonValueKind.Null);
        var urgency = questions.GetProperty("urgency");
        urgency.GetProperty("type").GetString().Should().Be("score");
        urgency.GetProperty("criteria").GetArrayLength().Should().Be(3);
        var isComplaint = questions.GetProperty("is_complaint");
        isComplaint.GetProperty("type").GetString().Should().Be("noul");
        isComplaint.TryGetProperty("criteria", out _).Should().BeFalse();

        response.Model.Should().Be("jev-1.13.0");
        var choice = response.Answers["department"];
        choice.Type.Should().Be(TypeSafeAnswerType.Choice);
        choice.Choice.Should().Be("technical");
        choice.Probabilities.Should().ContainKey("technical").WhoseValue.Should().Be(0.85);
        choice.Confidence.Should().Be(0.82);
        var score = response.Answers["urgency"];
        score.Type.Should().Be(TypeSafeAnswerType.Score);
        score.Score.Should().Be(1.7);
        score.Legend.Should().ContainKey("2").WhoseValue.Should().Be("high");
        var noul = response.Answers["is_complaint"];
        noul.Type.Should().Be(TypeSafeAnswerType.Noul);
        noul.Noul.Should().Be(0.95);
        response.Usage!.InputTokens.Should().Be(312);
        response.Usage.OutputTokens.Should().Be(48);
    }

    [TestMethod]
    public void TypeSafeQuestion_FactoriesEnforceCriteriaShapeAndLimits()
    {
        var noul = TypeSafeQuestion.Noul("Is it a refund request?", whenTrue: "Customer asks for money back");
        noul.Type.Should().Be(TypeSafeQuestionType.Noul);
        noul.Criteria!.Value.Value1.Should().Equal(new Dictionary<string, string?> { ["true"] = "Customer asks for money back" });

        var score = TypeSafeQuestion.Score("How urgent?", "low", "high");
        score.Criteria!.Value.Value2.Should().Equal("low", "high");

        FluentActions.Invoking(() => TypeSafeQuestion.Score("How urgent?", "only"))
            .Should().Throw<ArgumentOutOfRangeException>();
        FluentActions.Invoking(() => TypeSafeQuestion.Score("How urgent?", Enumerable.Range(0, 11).Select(i => $"level {i}").ToArray()))
            .Should().Throw<ArgumentOutOfRangeException>();
        FluentActions.Invoking(() => TypeSafeQuestion.Choice("Which team?", new Dictionary<string, string?>()))
            .Should().Throw<ArgumentOutOfRangeException>();
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
