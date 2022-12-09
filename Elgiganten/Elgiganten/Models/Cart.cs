namespace Elgiganten.Models
{
        public class CartItem
        {
            public CartItem()
            {
            }

            public CartItem(int id, string name, int quantity, decimal price)
            {
                Id = id;
                Name = name;
                Quantity = quantity;
                Price = price;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }
    
}
