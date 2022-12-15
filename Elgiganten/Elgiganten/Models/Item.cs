using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Elgiganten.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public static int nextId = 1;

        public Item()
        {
        }

        public Item(string type, string name, string brand, string description, double price)
        {
            Id = nextId++;
            Type = type;
            Name = name;
            Brand = brand;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"Tak for din bestilling du har bestilt ID:  {Id.ToString()}, Fra {Brand}, prisen i alt {Price.ToString()} Vi håber du glade!";
        }
    }
}
