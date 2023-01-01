using RentCar.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace RentCar.Core.ViewModels
{
    public class EditUserViewModel
    {
        public RentCarUser User { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}
