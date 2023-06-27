using AutoMapper;
using Insurance.Application.Interfaces;
using Insurance.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Persistence.Repositories;

public class InsuredPersonRepository : IInsuredPersonRepository
{
    private readonly InsuranceDbContext _dbContext;
    private readonly IMapper _mapper;

    public InsuredPersonRepository(InsuranceDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<InsuredPersonModel> GetInsuredPersonByIdAsync(Guid id)
    {
        var result = await _dbContext
            .InsuredPersons
            .SingleOrDefaultAsync(insuredPerson => insuredPerson.Id == id);
        return _mapper.Map<InsuredPersonModel>(result);
    }
}
