using SRMS.Shared.Domain.ValueObjects;

namespace SRMS.Backend.AccessControl.Domain.ValueObjects;

public class CredentialIdValueObject : IdValueObject
{
    public CredentialIdValueObject(string value) : base(value) {
        Name = "CredentialId";
    }
}
