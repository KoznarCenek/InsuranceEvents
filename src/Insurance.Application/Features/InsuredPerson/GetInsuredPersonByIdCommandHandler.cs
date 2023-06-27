using Insurance.Application.Interfaces;
using MediatR;
using Insurance.Domain.Models;

namespace Insurance.Application.Features.InsuredPerson;
public class GetInsuredPersonByIdCommandHandler : IRequestHandler<GetInsuredPersonByIdCommand, InsuredPersonModel>
{
    private readonly IInsuredPersonRepository _repository;

    public GetInsuredPersonByIdCommandHandler(IInsuredPersonRepository repository)
    {
        _repository = repository;
    }

    public async Task<InsuredPersonModel> Handle(GetInsuredPersonByIdCommand request, CancellationToken cancellationToken)
    {
        return await _repository.GetInsuredPersonByIdAsync(request.Id);
    }
}
