using System.ComponentModel.DataAnnotations;

namespace RentCar.Models.Siniflar
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }

        public string Mail { get; set; }
        public string yorum { get; set; }
         public Arac Arac { get; set; }
        public ICollection<Uye> uye{ get; set; }
    }
}
