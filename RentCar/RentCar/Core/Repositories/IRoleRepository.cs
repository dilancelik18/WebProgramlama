using RentCar.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace RentCar.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
