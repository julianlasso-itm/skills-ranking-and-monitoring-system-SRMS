using SRMS.Shared.Domain.ValueObjects;

namespace SRMS.Backend.AccessControl.Domain.ValueObjects;

public class RoleIdValueObject : IdValueObject
{
    public RoleIdValueObject(string value) : base(value) {
        Name = "RoleId";
    }
}
