namespace CodeTailor.Domain;

public static class ErrorFactoryMethods
{
    public static Error CreateEmptyError(string domainType) =>
        Error.Validation($"{domainType}.Empty", $"{domainType} is empty.");

    public static Error TooLow(string domainType) =>
        Error.Validation($"{domainType}.TooLow", $"{domainType} is too low.");

    public static Error TooHigh(string domainType) =>
        Error.Validation($"{domainType}.TooHigh", $"{domainType} is too high.");

    public static Error CreateTooLongError(string domainType) =>
        Error.Validation($"{domainType}.TooLong", $"{domainType} is too long.");

    public static Error CreateDoesNotMatchNumberOfDigitsError(string domainType) =>
        Error.Validation($"{domainType}.DoesNotMatchNumberOfDigits",
            $"{domainType} does not match the number of digits.");

    public static Error NegativeNumber(string domainType) =>
        Error.Validation($"{domainType}.NegativeNumber", $"{domainType} is a negative number.");

    public static Error FieldIsRequired(string domainType) =>
        Error.Validation($"{domainType}.IsRequired", $"{domainType} is required!");

    public static Error ParseError(string domainType, string name) =>
        Error.Validation($"{domainType}.ParseError",
            $"{domainType} with name '{name}' was not found in enumeration!");
    public static Error NotFound(string domainType, string requestId) =>
        Error.NotFound($"{domainType}.NotFound",
            $"{domainType} with Id '{requestId}' was not found or you do not have permission to access it.");
    
    public static Error CouldNotUpdate(string domainType, string reason) =>
        Error.Validation($"{domainType}.CouldNotUpdate",
            $"{domainType} could not be updated as {reason}.");
}