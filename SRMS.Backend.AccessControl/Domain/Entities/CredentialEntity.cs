using SRMS.Backend.AccessControl.Domain.ValueObjects;

namespace SRMS.Backend.AccessControl.Domain.Entities;

public class CredentialEntity
{
    public CredentialIdValueObject CredentialId { get; private set; }
    public EmailValueObject Email { get; private set; }
    public PasswordValueObject Password { get; private set; }
    public DisableValueObject IsDisable { get; private set; }
    public List<RoleEntity> Roles { get; private set; }

    public CredentialEntity(CredentialIdValueObject? credentialId = null, EmailValueObject? email = null, PasswordValueObject? password = null, DisableValueObject? disable = null, List<RoleEntity>? roles = null)
    {
        if (credentialId != null) CredentialId = credentialId;
        if (email != null) Email = email;
        if (password != null) Password = password;
        if (disable != null) IsDisable = disable;
        Roles = roles ?? new List<RoleEntity>();
    }

    public void Register(EmailValueObject email, PasswordValueObject password, List<RoleEntity>? roles = null)
    {
        CredentialId = new CredentialIdValueObject(Guid.NewGuid().ToString());
        Email = email;
        Password = password;
        IsDisable = new DisableValueObject(false);
        Roles = roles ?? new List<RoleEntity>();
    }

    public void UpdatePassword(PasswordValueObject password)
    {
        Password = password;
    }

    public void Enable()
    {
        IsDisable = new DisableValueObject(false);
    }

    public void Disable()
    {
        IsDisable = new DisableValueObject(true);
    }

    public void AddRoles(List<RoleEntity> roles)
    {
        Roles.AddRange(roles);
    }

    public void RemoveRoles(List<RoleEntity> roles)
    {
        foreach (var role in roles)
        {
            Roles.Remove(role);
        }
    }
}