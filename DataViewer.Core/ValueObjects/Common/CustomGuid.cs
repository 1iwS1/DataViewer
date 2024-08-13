using CSharpFunctionalExtensions;

using System.Text.RegularExpressions;


namespace DataReader.Core.ValueObjects.Common
{
  public class CustomGuid : ValueObject
  {
    private const string REGEX_FOR_GUID = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";
    public Guid? Guid { get; }

    private CustomGuid(Guid? Guid)
    {
      this.Guid = Guid;
    }

    public static Result<CustomGuid> Create(string customGuid)
    {
      if (!string.IsNullOrEmpty(customGuid))
      {
        if (!Regex.IsMatch(customGuid, REGEX_FOR_GUID))
        {
          return Result.Failure<CustomGuid>($"'{nameof(customGuid)}' must be Guid");
        }
      }

      return new CustomGuid(!string.IsNullOrEmpty(customGuid) ? new Guid(customGuid) : null);
    }

    protected override IEnumerable<IComparable?> GetEqualityComponents()
    {
      yield return Guid;
    }
  }
}
