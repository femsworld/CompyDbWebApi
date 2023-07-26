using Courseprject.Common.Interfaces;
using Courseproject.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Courseproject.Business;

public class DIConfiguration
{
    public static void RegisterService(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DtoEntityMapperProfile));
        services.AddScoped<IAddressService, AddressService>();
    }
}
