# Release publishing

Stable releases are published from semantic version tags to two independent NuGet-compatible registries:

| Destination | Authentication | Published artifact |
|---|---|---|
| [NuGet.org](https://www.nuget.org/packages/LiteLLM/) | Trusted Publishing with GitHub OIDC | `.nupkg` and its symbol package |
| [GitHub Packages](https://github.com/orgs/loud-technology/packages?repo_name=loud-technology-litellm-sdk) | Workflow `GITHUB_TOKEN` | `.nupkg` |

The build job creates one immutable package. Both publishing jobs download that same workflow artifact, so the package contents and version are identical across registries.

## Configure NuGet.org Trusted Publishing

The Trusted Publishing policy for this repository has already been created. In [NuGet.org](https://www.nuget.org/), open the account's **Trusted Publishing** page and verify that the existing GitHub Actions policy uses these values:

| Policy field | Value |
|---|---|
| Policy owner | The NuGet.org user or organization that owns `LiteLLM` |
| Repository Owner | `loud-technology` |
| Repository | `loud-technology-litellm-sdk` |
| Workflow File | `dotnet.yml` |
| Environment | `nuget-org` |

Enter only `dotnet.yml` in **Workflow File**, not `.github/workflows/dotnet.yml`. Policy matching is case-insensitive, but using the exact repository spelling is recommended.

!!! note "Policy managed outside the repository"
    The workflow cannot create or modify this policy. It is already present for this repository; confirm that its workflow file and environment still match before pushing the first version tag.

## Configure GitHub Actions

1. In the repository, open **Settings → Environments** and create the `nuget-org` environment.
2. Optionally add required reviewers or deployment branch/tag protection to that environment.
3. Add an Actions variable named `NUGET_USER` at repository, organization, or `nuget-org` environment scope.
4. Set `NUGET_USER` to the NuGet.org **profile username**, not an email address.

No long-lived NuGet API key is stored. The `publish-nuget-org` job has `id-token: write`, and `NuGet/login@v1` exchanges the GitHub OIDC token for a temporary NuGet API key shortly before the push. NuGet.org temporary keys are valid for one hour.

The GitHub Packages job uses the workflow's built-in `GITHUB_TOKEN` with job-scoped `packages: write`. No custom GitHub Packages secret is required.

## Publish a stable release

Create and push a semantic version tag:

```bash
git tag v1.0.0
git push origin v1.0.0
```

MinVer converts `v1.0.0` into package version `1.0.0`. The workflow then:

1. restores, builds, tests, and packs in `Release`;
2. uploads `.nupkg` and `.snupkg` as a workflow artifact;
3. publishes the `.nupkg` to GitHub Packages;
4. requests a temporary NuGet.org credential through OIDC;
5. publishes the same package to NuGet.org.

Untagged `main` builds produce development versions and artifacts but do not publish to either registry.

## Troubleshooting

- **OIDC exchange rejected:** verify all policy fields, especially `dotnet.yml` and `nuget-org`.
- **Username rejected:** confirm `NUGET_USER` is the profile username rather than the account email.
- **Package ownership rejected:** ensure the policy owner owns the package ID or is allowed to publish it.
- **Environment waiting:** approve the `nuget-org` deployment if required reviewers are enabled.
- **Duplicate version:** package versions are immutable in both registries; publish a new semantic version instead of reusing a tag.

For protocol details, see [Trusted Publishing on NuGet.org](https://learn.microsoft.com/nuget/nuget-org/trusted-publishing) and the [`NuGet/login`](https://github.com/NuGet/login) action.
