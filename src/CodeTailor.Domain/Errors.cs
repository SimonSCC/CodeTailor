namespace CodeTailor.Domain;

public static class Errors
{
    public static class SmartEnum
    {
        
        public static Error ParseError(string name) => Error.Validation("SmartEnum.ParseError", $"SmartEnum with name '{name}' was not found in enumeration!");
    }
}