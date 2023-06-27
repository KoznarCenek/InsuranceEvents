using Insurance.Domain.Models;

namespace Insurance.Application.Interfaces;

public interface IInsuredPersonRepository
{
    Task<InsuredPersonModel> GetInsuredPersonByIdAsync(Guid id);
}