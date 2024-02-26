using SRMS.Shared.Domain.ValueObjects;

namespace SRMS.Backend.AccessControl.Domain.ValueObjects;

public class DisableValueObject : BooleanValueObject
{
    public DisableValueObject(Boolean value) : base(value) {
        Name = "Disable";
    }
}