/*
order: 10
title: Chat completion
slug: chat-completion

Send a chat completion through your LiteLLM AI Gateway.
*/

// ReSharper disable once CheckNamespace
namespace Loud.Technology.LiteLLM.Sdk.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ChatCompletion()
    {
        using var client = GetAuthenticatedClient();
        var model = Environment.GetEnvironmentVariable("LITELLM_MODEL") ?? "gpt-4o-mini";

        var responseJson = await client.ChatCompletions.ChatCompletionV1ChatCompletionsPostAsync(
            new ChatCompletionV1ChatCompletionsPostRequest
            {
                Model = model,
                Messages =
                [
                    new ChatCompletionUserMessage
                    {
                        Content = "Explain why a unified AI gateway matters in one sentence.",
                    },
                ],
            });

        responseJson.Should().NotBeNullOrWhiteSpace();
    }
}
