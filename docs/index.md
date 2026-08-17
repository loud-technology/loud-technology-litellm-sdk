---
title: LiteLLM .NET SDK
description: One gateway, 100+ AI providers, and a native strongly typed .NET experience.
hide:
  - navigation
  - toc
---

<div class="landing-shell">
  <section class="ib-hero" aria-labelledby="hero-title">
    <div class="ib-hero__copy">
      <p class="ib-kicker" data-reveal>LiteLLM / .NET SDK</p>
      <h1 id="hero-title" data-reveal>ONE GATEWAY.<br><span>FULL .NET CONTROL.</span></h1>
      <p class="ib-hero__lede" data-reveal>Call 100+ AI providers through a generated, strongly typed client built for modern .NET.</p>
      <div class="ib-actions" data-reveal>
        <a class="ib-button ib-button--primary" href="getting-started/">Install SDK <span aria-hidden="true">→</span></a>
        <a class="ib-button ib-button--secondary" href="https://github.com/loud-technology/loud-technology-litellm-sdk">View source <span aria-hidden="true">↗</span></a>
      </div>
    </div>

    <figure class="ib-system" data-reveal aria-labelledby="system-caption">
      <figcaption id="system-caption">Provider-independent request path</figcaption>
      <div class="ib-system__providers" aria-label="Example AI providers">
        <span>OPENAI</span><span>ANTHROPIC</span><span>BEDROCK</span><span>GEMINI</span>
      </div>
      <div class="ib-system__route" aria-hidden="true"><span></span></div>
      <div class="ib-system__gateway">
        <span>LITELLM</span>
        <strong>AI GATEWAY</strong>
      </div>
      <div class="ib-system__route ib-system__route--out" aria-hidden="true"><span></span></div>
      <div class="ib-system__client">
        <img src="media/icon128.png" width="64" height="64" alt="LiteLLM .NET SDK icon">
        <div><span>STRONGLY TYPED</span><strong>C# CLIENT</strong></div>
      </div>
      <div class="ib-install">
        <code>dotnet add package LiteLLM</code>
        <button type="button" data-copy="dotnet add package LiteLLM" aria-label="Copy install command">COPY</button>
      </div>
    </figure>
  </section>

  <dl class="ib-facts" data-reveal aria-label="SDK facts">
    <div><dt>PROVIDER REACH</dt><dd>100+</dd></div>
    <div><dt>BUILD TARGET</dt><dd>.NET 10</dd></div>
    <div><dt>API SOURCE</dt><dd>OPENAPI</dd></div>
    <div><dt>REGISTRIES</dt><dd>02</dd></div>
  </dl>

  <section class="ib-statement" data-reveal aria-labelledby="statement-title">
    <div class="ib-statement__mark" aria-hidden="true">↗</div>
    <div>
      <h2 id="statement-title">CHANGE THE MODEL.<br>KEEP THE APPLICATION.</h2>
      <p>LiteLLM owns provider routing at the gateway. Your application keeps one stable client, one authentication model, and one generated API surface.</p>
    </div>
  </section>

  <section class="ib-capabilities" aria-labelledby="capabilities-title">
    <header class="ib-section-heading" data-reveal>
      <h2 id="capabilities-title">ENGINEERED FOR<br>THE FULL GATEWAY.</h2>
      <p>Inference, administration, resilience, and package delivery belong to the same typed system.</p>
    </header>
    <div class="ib-capability-grid">
      <article class="ib-capability ib-capability--carbon" data-reveal>
        <span class="ib-capability__symbol" aria-hidden="true">{ }</span>
        <h3>Generated surface</h3>
        <p>Requests, responses, enums, unions, endpoint clients, and XML documentation track LiteLLM's published specification.</p>
        <a href="guides/api-surface/">Explore API groups →</a>
      </article>
      <article class="ib-capability ib-capability--paper" data-reveal>
        <span class="ib-capability__symbol" aria-hidden="true">CTRL</span>
        <h3>Gateway administration</h3>
        <p>Manage models, virtual keys, teams, budgets, guardrails, health, and more from the root client.</p>
      </article>
      <article class="ib-capability ib-capability--red" data-reveal>
        <span class="ib-capability__symbol" aria-hidden="true">ASYNC</span>
        <h3>Modern .NET</h3>
        <p>Nullable types, cancellation, source-generated JSON, trimming analysis, signing, and reproducible Release builds.</p>
      </article>
      <article class="ib-capability ib-capability--code" data-reveal>
        <span class="ib-capability__symbol" aria-hidden="true">HTTP</span>
        <h3>Response control</h3>
        <p>Use body-first async methods or inspect status and headers through <code>AsResponseAsync</code> variants.</p>
        <a href="guides/reliability/">Handle failures →</a>
      </article>
    </div>
  </section>

  <section class="ib-quickstart" aria-labelledby="quickstart-title">
    <div class="ib-quickstart__intro" data-reveal>
      <h2 id="quickstart-title">FROM PACKAGE TO<br>FIRST REQUEST.</h2>
      <p>Configure the gateway once. The model can resolve to a provider, alias, or load-balanced deployment group.</p>
      <a class="ib-text-link" href="getting-started/">Read the complete guide →</a>
    </div>
    <div class="ib-code-panel" data-reveal>
      <div class="ib-code-panel__bar"><span>Program.cs</span><span>C# / ASYNC</span></div>
      <pre><code class="language-csharp">using LiteLLM;

using var client = LiteLLMClient.CreateFromEnvironment();

var result = await client.ChatCompletions
    .ChatCompletionV1ChatCompletionsPostAsync(
        new ChatCompletionV1ChatCompletionsPostRequest
        {
            Model = "gpt-4o-mini",
            Messages =
            [
                new ChatCompletionUserMessage
                {
                    Content = "Why use an AI gateway?",
                },
            ],
        });

Console.WriteLine(result);</code></pre>
    </div>
  </section>

  <section class="ib-surface" aria-labelledby="surface-title">
    <div class="ib-surface__header" data-reveal>
      <h2 id="surface-title">ONE ROOT CLIENT.<br>MULTIPLE CONTROL PLANES.</h2>
    </div>
    <div class="ib-surface__groups">
      <article data-reveal><h3>INFERENCE</h3><p>ChatCompletions / Responses / Embeddings / Images / Audio</p></article>
      <article data-reveal><h3>MODEL OPERATIONS</h3><p>ModelManagement / Health / Files / Batches / VectorStores</p></article>
      <article data-reveal><h3>GOVERNANCE</h3><p>Guardrails / KeyManagement / TeamManagement / BudgetManagement</p></article>
    </div>
  </section>

  <section class="ib-final" data-reveal aria-labelledby="final-title">
    <div>
      <h2 id="final-title">SHIP AGAINST<br>THE GATEWAY.</h2>
      <p>Install the package, set two environment variables, and let the generated client carry the protocol.</p>
    </div>
    <div class="ib-actions">
      <a class="ib-button ib-button--light" href="getting-started/">Install SDK <span aria-hidden="true">→</span></a>
      <a class="ib-button ib-button--outline" href="https://github.com/loud-technology/loud-technology-litellm-sdk">View source <span aria-hidden="true">↗</span></a>
    </div>
  </section>
</div>
