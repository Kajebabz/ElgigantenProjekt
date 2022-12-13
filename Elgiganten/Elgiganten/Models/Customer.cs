using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Elgiganten.Models
{
    public class Customer
    {


        [Display(Name = "Kunde ID")]
        [Required(ErrorMessage = "Der Skal Angives ID")]
        [Range(typeof(int), minimum: "0", maximum: "10000", ErrorMessage = "ID skal være mellem {1} og {2}")]
        public int Id { get; set; }

        [Display(Name = "Kunde Navn")]
        [Required(ErrorMessage = "Der Skal Angives Navn på Kunde")]
        public string Name { get; set; }

        [Display(Name = "Kunde Adresse")]
        [Required(ErrorMessage = "Der Skal Angives Navn på Adresse")]
        public string Address { get; set; }

        [Display(Name = "Kunde Telefon")]
        [Required(ErrorMessage = "Der Skal Angives Telefon nummer på Kunde"), MinLength(8), MaxLength(8)]
        public string PhoneNr { get; set; }

        [Display(Name = "Kunde Email")]
        [Required(ErrorMessage = "Der Skal Angives Email på Kunde")]
        public string Email { get; set; }


            public Customer()
            {
            }

            public Customer(int id, string name, string address, string phoneNr, string email)
            {
                Id = id;
                Name = name;
                Address = address;
                PhoneNr = phoneNr;
                Email = email;
            }
        
    }
}
