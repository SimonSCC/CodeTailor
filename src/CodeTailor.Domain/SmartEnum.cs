namespace CodeTailor.Domain;

public abstract class SmartEnum<T> where T : SmartEnum<T>
{
    public string Name { get; }

    protected SmartEnum(string name)
    {
        Name = name;
    }

    public static Result<T?> Create(string? name)
    {
        if (string.IsNullOrEmpty(name))
            return Result.Success<T?>(null);
        
        T? match = All.FirstOrDefault(x => x.Name == name);
        return match is not null
            ? Result.Success<T?>(match)
            : Result.Failure<T?>(Errors.SmartEnum.ParseError(name));
    }

    public static IReadOnlyList<T> All =>
        typeof(T)
            .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.DeclaredOnly)
            .Where(f => f.FieldType == typeof(T))
            .Select(f => (T)f.GetValue(null)!)
            .ToList();

    public override string ToString()
    {
        return Name;
    }
}