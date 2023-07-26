using AutoMapper;
using Courseprject.Common.Dtos;
using Courseprject.Common.Model;

namespace Courseproject.Business;

public class DtoEntityMapperProfile : Profile
{
    public DtoEntityMapperProfile()
    {
        CreateMap<AddressCreate, Address>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<AddressUpdate, Address>();
        CreateMap<Address, AddressGet>();
    }

}