
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicModelHubFacetPublicV1ModelHubFacetGetFacet
    {
        /// <summary>
        ///
        /// </summary>
        Features,
        /// <summary>
        ///
        /// </summary>
        Modes,
        /// <summary>
        ///
        /// </summary>
        Providers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicModelHubFacetPublicV1ModelHubFacetGetFacetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicModelHubFacetPublicV1ModelHubFacetGetFacet value)
        {
            return value switch
            {
                PublicModelHubFacetPublicV1ModelHubFacetGetFacet.Features => "features",
                PublicModelHubFacetPublicV1ModelHubFacetGetFacet.Modes => "modes",
                PublicModelHubFacetPublicV1ModelHubFacetGetFacet.Providers => "providers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicModelHubFacetPublicV1ModelHubFacetGetFacet? ToEnum(string value)
        {
            return value switch
            {
                "features" => PublicModelHubFacetPublicV1ModelHubFacetGetFacet.Features,
                "modes" => PublicModelHubFacetPublicV1ModelHubFacetGetFacet.Modes,
                "providers" => PublicModelHubFacetPublicV1ModelHubFacetGetFacet.Providers,
                _ => null,
            };
        }
    }
}