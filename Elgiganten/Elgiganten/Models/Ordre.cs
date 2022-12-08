namespace Elgiganten.Models
{
    public class Ordre
    {  
        public double TotalPrice { get; set; }
        public int Id { get; set; }
        public string MemberName { get; set; }
        public DateOnly Date { get; set; }
        

        public Ordre()
        {
        }

        public Ordre(double totalPrice, int id, string memberName, DateOnly date)
        {
            TotalPrice = totalPrice;
            Id = id;
            MemberName = memberName;
            Date = date;
        }

        public override string ToString()
        {
            return $"{{{nameof(TotalPrice)}={TotalPrice.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(MemberName)}={MemberName}, {nameof(Date)}={Date.ToString()}}}";
        }
    }
}

