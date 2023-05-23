using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public abstract class Payment
{
    protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
    {
        Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Payer = payer;
        Document = document;
        Address = address;
        Email = email;
    }

    public string Id { get; private set; } = string.Empty;
    public DateTime PaidDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public string Payer { get; private set; } = string.Empty;
    public Document Document { get; private set; }
    public Address Address { get; private set; }
    public Email Email { get; private set; }
}