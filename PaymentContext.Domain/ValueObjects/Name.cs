using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Name : valueObj
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        AddNotifications(new Contract<Name>().Requires()
        .IsGreaterThan(FirstName, 3, "Name.FirstName", "Nome invalido, o nome deve conter pelo menos 3 caracteres")
        .IsGreaterThan(LastName, 3, "Name.LastName", "Sobrenome invalido, o sobrenome deve conter pelo menos 3 caracteres")
        .IsLowerThan(FirstName, 40, "Name.FirstName", "Nome deve conter ate 40 caracteres")
        );
    }

    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
}