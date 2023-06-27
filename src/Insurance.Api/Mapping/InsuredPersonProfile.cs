using AutoMapper;
using Insurance.Api.Dto.Output;
using Insurance.Domain.Models;

namespace Insurance.Api.Mapping;

public class InsuredPersonProfile : Profile
{
    public InsuredPersonProfile()
    {
        CreateMap<InsuredPersonModel, InsuredPersonDto>()
            .ReverseMap();
    }
}
