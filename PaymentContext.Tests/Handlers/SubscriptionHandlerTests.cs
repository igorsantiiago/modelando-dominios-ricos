using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.ValueObjects;

[TestClass]
public class SubscriptionHandlerTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenDocumentExists()
    {
        var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
        var command = new CreateBoletoSubscriptionCommand();

        command.FirstName = "Balta";
        command.LastName = "Plataform";
        command.Document = "99999999999";
        command.Email = "hello@balta.io2";
        command.BarCode = "123456789";
        command.BoletoNumber = "123456789";
        command.PaidDate = DateTime.Now;
        command.ExpireDate = DateTime.Now.AddMonths(1);
        command.Total = 60;
        command.TotalPaid = 60;
        command.Payer = "Balta Corp";
        command.PayerDocument = "00000000000";
        command.PayerDocumentType = EDocumentType.CPF;
        command.PayerEmail = "balta@balta.io";
        command.Street = "Rua";
        command.Number = "000";
        command.Neighborhood = "Bairro";
        command.City = "Cidade";
        command.State = "St";
        command.Country = "BR";
        command.ZipCode = "12345678";

        handler.Handle(command);
        Assert.AreEqual(false, handler.IsValid);
    }
}