using Elgiganten.Service;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Elgiganten.Models
{
    public class Ordre
    {
        public int Id { get; set; } = 0;
        public Item? Item { get; set; }
        public Customer? Customer { get; set; }
        public DateTime OrdreDate { get; set; }
        public int Quantity { get; set; }
        public static int nextId = 1;

        public Ordre()
        {
        }

        OrdreService ordreservice = new OrdreService();

        public Ordre(Item item, Customer customer, DateTime ordreDate, int quantity)
        {
            Id = nextId++;
            Item = item;
            Customer = customer;
            OrdreDate = ordreDate;
            Quantity = quantity;
           

        }
        public double GetTotal()
        {
            return this.Item.Price * this.Quantity;
        }
    }
}
