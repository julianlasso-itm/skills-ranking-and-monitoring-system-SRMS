namespace SRMS.Shared.Domain.ValueObjects;

public abstract class ValueObject<TypeData> : ValueObjectErrorHandler
{
    public TypeData Value { get; }
    protected String Name { get; set; }

    protected ValueObject(TypeData value)
    {
        Value = value;
        Name = "Field name not set";
    }
}
