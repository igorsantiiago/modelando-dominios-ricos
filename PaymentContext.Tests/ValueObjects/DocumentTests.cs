using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects;

[TestClass]
public class DocumentTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
        var doc = new Document("000", Domain.Enums.EDocumentType.CNPJ);
        Assert.IsFalse(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
        var doc = new Document("00000000000000", Domain.Enums.EDocumentType.CNPJ);
        Assert.IsTrue(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Document("111", Domain.Enums.EDocumentType.CPF);
        Assert.IsFalse(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
        var doc = new Document("11111111111", Domain.Enums.EDocumentType.CPF);
        Assert.IsTrue(doc.IsValid);
    }
}