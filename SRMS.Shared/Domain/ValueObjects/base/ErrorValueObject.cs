namespace SRMS.Shared.Domain.ValueObjects;

public class ErrorValueObject
{
    String Field { get; }
    String Message { get; }

    public ErrorValueObject(String field, String message)
    {
        Field = field;
        Message = message;
    }
}
