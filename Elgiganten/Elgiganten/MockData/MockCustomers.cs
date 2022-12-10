using Elgiganten.Models;

namespace Elgiganten.MockData
{
    public class MockCustomers
    {
        private static List<ShoppingCart> _customers = new List<ShoppingCart>()
        {
            new ShoppingCart (1, "Lone", "BingBangvej 7", "23569812", "Lone@mail.dk"),
            new ShoppingCart (2, "Hans", "Langvej 2", "12345678", "Hans@mail.dk"),
            new ShoppingCart (3, "Birthe", "Lillevej 67", "89456719", "Birthe@mail.dk"),
            new ShoppingCart (4, "Preben", "Solvej 12", "19283746", "Preben@mail.dk")
        };

        public static List<ShoppingCart> GetMockCustomers()
        {
            return _customers;
        }
    }
}
