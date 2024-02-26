using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using SRMS.Shared.Domain.ValueObjects;

namespace SRMS.Backend.AccessControl.Domain.ValueObjects;

public class PasswordValueObject : StringValueObject
{
    public String Value { get => CreateSha512Hash(base.Value); }
    const int MinLength = 8;
    const string PasswordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";

    public PasswordValueObject(string value) : base(value)
    {
        Name = "Password";
    }

    public override void Validate()
    {
        base.Validate();
        if (!IsLengthValid(Value))
        {
            AddError(new ErrorValueObject(Name, $"{Name} must be at least {MinLength} characters"));
        }

        if (!IsPasswordValid(Value))
        {
            AddError(new ErrorValueObject(Name, $"{Name} must contain at least one uppercase letter, one lowercase letter, and one number"));
        }
    }

    private bool IsLengthValid(string value)
    {
        return value.Length >= MinLength;
    }

    private bool IsPasswordValid(string value)
    {
        return Regex.IsMatch(value, PasswordRegex);
    }

    private String CreateSha512Hash(String value)
    {
        using (SHA512 sha512 = SHA512.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            byte[] hash = sha512.ComputeHash(bytes);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                stringBuilder.Append(hash[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

    }
}
