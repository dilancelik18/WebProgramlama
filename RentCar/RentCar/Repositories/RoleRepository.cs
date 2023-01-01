using RentCar.Areas.Identity.Data;
using RentCar.Core.Repositories;
using Microsoft.AspNetCore.Identity;
using RentCar.Models.Siniflar;

namespace RentCar.Repositories
{
    public class RoleRepository: IRoleRepository
    {
        private readonly RentCarContext _context;

        public RoleRepository(RentCarContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
