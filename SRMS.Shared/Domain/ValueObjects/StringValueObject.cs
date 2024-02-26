namespace SRMS.Shared.Domain.ValueObjects;

public abstract class StringValueObject : ValueObject<String>
{
    protected StringValueObject(string value) : base(value) { }

    public override void Validate()
    {
        if (String.IsNullOrWhiteSpace(Value))
        {
            AddError(new ErrorValueObject(Name, $"{Name} is required"));
        }
    }
}
