using System.ComponentModel.DataAnnotations;
namespace RentCar.Models.Siniflar
{
	public class Uye
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
	    public string eMail { get; set; }

		public Yorum Yorum { get; set; }
	}
}
