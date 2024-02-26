namespace SRMS.Shared.Domain.ValueObjects;

public abstract class BooleanValueObject : ValueObject<Boolean>
{
    protected BooleanValueObject(Boolean value) : base(value) { }

    public override void Validate()
    {
        if (Value == default)
        {
            AddError(new ErrorValueObject(Name, $"{Name} is required"));
        }
    }
}
