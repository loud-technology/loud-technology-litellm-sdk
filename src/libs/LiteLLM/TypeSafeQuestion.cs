namespace Loud.Technology.LiteLLM.Sdk;

public sealed partial class TypeSafeQuestion
{
    /// <summary>
    /// Creates a question that picks one of the given options.
    /// </summary>
    /// <param name="instructions">Question asked about the state.</param>
    /// <param name="options">Between 1 and 255 options mapped to optional descriptions.</param>
    public static TypeSafeQuestion Choice(
        string instructions,
        IReadOnlyDictionary<string, string?> options)
    {
        ArgumentNullException.ThrowIfNull(options);
        if (options.Count is < 1 or > 255)
        {
            throw new ArgumentOutOfRangeException(nameof(options), options.Count, "A choice question requires between 1 and 255 options.");
        }

        return new TypeSafeQuestion
        {
            Type = TypeSafeQuestionType.Choice,
            Instructions = instructions,
            Criteria = new Dictionary<string, string?>(options),
        };
    }

    /// <summary>
    /// Creates a question that rates the state against ordered levels.
    /// </summary>
    /// <param name="instructions">Question asked about the state.</param>
    /// <param name="levels">Between 2 and 10 levels, from lowest to highest.</param>
    public static TypeSafeQuestion Score(
        string instructions,
        params string[] levels)
    {
        ArgumentNullException.ThrowIfNull(levels);
        if (levels.Length is < 2 or > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(levels), levels.Length, "A score question requires between 2 and 10 levels.");
        }

        return new TypeSafeQuestion
        {
            Type = TypeSafeQuestionType.Score,
            Instructions = instructions,
            Criteria = new List<string>(levels),
        };
    }

    /// <summary>
    /// Creates a yes/no question answered with the probability that the statement is true.
    /// </summary>
    /// <param name="instructions">Statement evaluated against the state.</param>
    /// <param name="whenTrue">Optional description of what counts as true.</param>
    /// <param name="whenFalse">Optional description of what counts as false.</param>
    public static TypeSafeQuestion Noul(
        string instructions,
        string? whenTrue = null,
        string? whenFalse = null)
    {
        var question = new TypeSafeQuestion
        {
            Type = TypeSafeQuestionType.Noul,
            Instructions = instructions,
        };

        if (whenTrue is not null || whenFalse is not null)
        {
            var criteria = new Dictionary<string, string?>();
            if (whenTrue is not null)
            {
                criteria["true"] = whenTrue;
            }
            if (whenFalse is not null)
            {
                criteria["false"] = whenFalse;
            }
            question.Criteria = criteria;
        }

        return question;
    }
}
