namespace SRMS.Shared.Domain.ValueObjects;

public abstract class ValueObjectErrorHandler
{
    public List<ErrorValueObject> Errors { get; protected set; }
    public String ErrorMessage { get; set; }

    public ValueObjectErrorHandler()
    {
        Errors = new List<ErrorValueObject>();
        ErrorMessage = "There are some errors in the data provided";
    }

    public Boolean IsValid()
    {
        return !HasErrors();
    }

    public void AddError(ErrorValueObject error)
    {
        Errors.Add(error);
    }

    private Boolean HasErrors()
    {
        return Errors.Count > 0;
    }

    public abstract void Validate();
}
