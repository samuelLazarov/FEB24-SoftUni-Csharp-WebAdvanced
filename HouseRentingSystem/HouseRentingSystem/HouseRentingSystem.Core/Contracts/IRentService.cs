using HouseRentingSystem.Core.Models.Admin;
using HouseRentingSystem.Core.Models.Agent;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IRentService
    {
        Task<IEnumerable<RentServiceModel>> AllAsync();
    }
}