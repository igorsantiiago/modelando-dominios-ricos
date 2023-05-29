using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories;

public interface IStudentRepository
{
    bool DocumentExists(string document);
    bool Email(string email);
    void CreateSubscription(Student student);
}