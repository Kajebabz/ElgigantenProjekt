using Elgiganten.Models;

namespace Elgiganten.MockData
{
    public class MockOrdre
    {
        private static List<Ordre> _ordres = new List<Ordre>()
        {
            new Ordre(new Item("PC", "Intel", "Vision", "Kraftig computer til lav pris", 10999), new Customer("Lone", "BingBangvej 7", "23569812", "Lone@mail.dk"),new DateOnly(2022,01,20),10)
        };

        public static List<Ordre> GetMockOrdres()
        {
            return _ordres;
        }
    }
}
