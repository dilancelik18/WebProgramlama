using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Siniflar
{
	public class Arac
	{
		[Key]
		public int AracId { get; set; }
		public string aracModel { get; set; }
	    public int besgünFiyat { get; set; }

        public int onbesgünFiyat { get; set; }
        public int otuzgünFiyat { get; set; }

		public int fotoUrl { get; set; }


        public ICollection<Yorum> Yorums{ get; set; }
	}
}
