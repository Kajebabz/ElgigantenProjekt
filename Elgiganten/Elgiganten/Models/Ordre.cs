namespace Elgiganten.Models
{
    public class Ordre
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public Customer Customer { get; set; }
        public DateOnly OrdreDate { get; set; }
        public int Quantity { get; set; }
        public static int nextId = 1;

        public Ordre()
        {
        }

        public Ordre(Item item, Customer customer, DateOnly ordreDate, int quantity)
        {
            Id = nextId++;
            Item = item;
            Customer = customer;
            OrdreDate = ordreDate;
            Quantity = quantity;
        }
    }
}
