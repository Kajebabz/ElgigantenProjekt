namespace Elgiganten.Models
{
    public class Ordre
    {
        public Ordre(int id, Item item, Customer customer, double ordreDate, int quantity)
        {
            Id = id;
            Item = item;
            Customer = customer;
            OrdreDate = ordreDate;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public Item Item { get; set; }
        public Customer Customer { get; set; }
        public double OrdreDate { get; set; }
        public int Quantity { get; set; }
    }
}
