using AutoMapper;
using Insurance.Domain.Models;
using Isuranse.Persistence.Entities;

namespace Insurance.Persistence.Mapping;
internal class InsuredPersonProfile : Profile
{
    public InsuredPersonProfile()
    {
        CreateMap<InsuredPersonEntity, InsuredPersonModel>()
            .ReverseMap()
            .ForMember(d => d.Id, opt => opt.Ignore());
    }
}
