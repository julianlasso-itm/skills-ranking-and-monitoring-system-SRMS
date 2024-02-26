namespace SRMS.Shared.Domain.ValueObjects;

public abstract class IdValueObject : StringValueObject
{
    protected IdValueObject(String value) : base(value) { }

    public override void Validate()
    {
        base.Validate();
        if (!IsUUIDValid(Value))
        {
            AddError(new ErrorValueObject(Name, $"{Name} is not a valid UUID"));
        }
    }

    private bool IsUUIDValid(String value)
    {
        return Guid.TryParse(value, out _);
    }
}