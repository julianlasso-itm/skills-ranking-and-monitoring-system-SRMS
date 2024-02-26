using System.ComponentModel.DataAnnotations;
using SRMS.Shared.Domain.ValueObjects;

namespace SRMS.Backend.AccessControl.Domain.ValueObjects;

public class EmailValueObject : StringValueObject
{
    const int MaxLength = 500;

    public EmailValueObject(string value) : base(value)
    {
        Name = "Email";
    }

    public override void Validate()
    {
        base.Validate();
        if (!IsEmailValid(Value))
        {
            AddError(new ErrorValueObject(Name, $"{Name} is not a valid email"));
        }

        if (!IsLengthValid(Value))
        {
            AddError(new ErrorValueObject(Name, $"{Name} must be less than {MaxLength} characters"));
        }
    }

    private bool IsLengthValid(string value)
    {
        return value.Length <= MaxLength;
    }

    private bool IsEmailValid(string value)
    {
        return new EmailAddressAttribute().IsValid(value);
    }
}
