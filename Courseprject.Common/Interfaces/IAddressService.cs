using Courseprject.Common.Dtos;

namespace Courseprject.Common.Interfaces;

public interface IAddressService
{
    Task<int> CreateAddressAsync(AddressCreate addressCreate);
    Task UpdateAddresssAsync(AddressUpdate addressUpdate);
    Task DeleteAddressAsync(AddressDelete addressDelete);
    Task<AddressGet>  GetAddressAsync(int id);
    Task<List<AddressGet>>  GetAddressesAsync();
}
