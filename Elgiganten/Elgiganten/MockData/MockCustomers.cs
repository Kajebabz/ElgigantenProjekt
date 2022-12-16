using Elgiganten.Models;

namespace Elgiganten.MockData
{
    public class MockCustomers
    {
        private static List<Customer> _customers = new List<Customer>()
        {
            new Customer ("Lone", "BingBangvej 7", "23569812", "Lone@mail.dk"),
            new Customer ("Hans", "Langvej 2", "12345678", "Hans@mail.dk"),
            new Customer ("Birthe", "Lillevej 67", "89456719", "Birthe@mail.dk"),
            new Customer ("Preben", "Solvej 12", "19283746", "Preben@mail.dk")
        };

        public static List<Customer> GetMockCustomers()
        {
            return _customers;
        }
    }
}
