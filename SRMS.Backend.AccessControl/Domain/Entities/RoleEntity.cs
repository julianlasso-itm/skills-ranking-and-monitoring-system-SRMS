using SRMS.Backend.AccessControl.Domain.ValueObjects;

namespace SRMS.Backend.AccessControl.Domain.Entities;

public class RoleEntity
{
    public RoleIdValueObject RoleId { get; private set; }
    public NameValueObject Name { get; private set; }
    public DisableValueObject IsDisable { get; private set; }
    public List<CredentialEntity> Credentials { get; private set; }

    public RoleEntity(RoleIdValueObject? roleId = null, NameValueObject? name = null, DisableValueObject? disable = null, List<CredentialEntity>? credentials = null)
    {
        if (roleId != null) RoleId = roleId;
        if (name != null) Name = name;
        if (disable != null) IsDisable = disable;
        Credentials = credentials ?? new List<CredentialEntity>();
    }

    public void Register(NameValueObject name, List<CredentialEntity>? credentials = null)
    {
        RoleId = new RoleIdValueObject(Guid.NewGuid().ToString());
        Name = name;
        IsDisable = new DisableValueObject(false);
        Credentials = credentials ?? new List<CredentialEntity>();
    }

    public void Enable()
    {
        IsDisable = new DisableValueObject(false);
    }

    public void Disable()
    {
        IsDisable = new DisableValueObject(true);
    }

    public void Update(RoleEntity role)
    {
        if (role.Name != null) Name = role.Name;
    }

    public void AddCredentials(List<CredentialEntity> credentials)
    {
        Credentials.AddRange(credentials);
    }

    public void RemoveCredentials(List<CredentialEntity> credentials)
    {
        foreach (var credential in credentials)
        {
            Credentials.Remove(credential);
        }
    }

    public void RemoveAllCredentials()
    {
        Credentials.Clear();
    }
}
