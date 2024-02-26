using SRMS.Shared.Domain.ValueObjects;

namespace SRMS.Backend.AccessControl.Domain.ValueObjects;

public class NameValueObject : StringValueObject
{
    const int MaxLength = 80;

    public NameValueObject(string value) : base(value)
    {
        Name = "Name";
    }

    public override void Validate()
    {
        base.Validate();
        if (!IsLengthValid(Value))
        {
            AddError(new ErrorValueObject(Name, $"{Name} must be less than {MaxLength} characters"));
        }
    }

    private bool IsLengthValid(string value)
    {
        return value.Length <= MaxLength;
    }
}
