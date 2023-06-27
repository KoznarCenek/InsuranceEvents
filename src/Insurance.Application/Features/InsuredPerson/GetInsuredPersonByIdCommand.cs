using MediatR;
using Insurance.Domain.Models;

namespace Insurance.Application.Features.InsuredPerson;
public class GetInsuredPersonByIdCommand : IRequest<InsuredPersonModel>
{
    public Guid Id { get; set; }
}
