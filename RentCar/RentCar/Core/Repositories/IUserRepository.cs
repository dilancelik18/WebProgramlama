using RentCar.Areas.Identity.Data;
namespace RentCar.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<RentCarUser> GetUsers();

        RentCarUser GetUser(string id);

        RentCarUser UpdateUser(RentCarUser user);
    }
}
