using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Email : valueObj
{
    public Email(string address)
    {
        Address = address;

        AddNotifications(new Contract<Email>().Requires().IsEmail(Address, "Email.Address", "Email invalido"));
    }

    public string Address { get; private set; } = string.Empty;
}