namespace Elgiganten.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public ShoppingCart()
        {
        }

        public ShoppingCart(int id, string type, string name, string brand, string description, double price)
        {
            Id = id;
            Type = type;
            Name = name;
            Brand = brand;
            Description = description;
            Price = price;
        }
    }
}
