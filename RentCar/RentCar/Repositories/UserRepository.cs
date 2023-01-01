using RentCar.Areas.Identity.Data;
using RentCar.Core.Repositories;
using RentCar.Models.Siniflar;

namespace RentCar.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly RentCarContext _context;

        public UserRepository(RentCarContext context)
        {
            _context = context;
        }

        public ICollection<RentCarUser> GetUsers()
        {
            return _context.Users.ToList();
        }

        public RentCarUser GetUser(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public RentCarUser UpdateUser(RentCarUser user)
        {
            _context.Update(user);
            _context.SaveChanges();

            return user;
        }
    }
}
