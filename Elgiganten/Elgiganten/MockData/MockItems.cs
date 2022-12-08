using Elgiganten.Models;

namespace Elgiganten.MockData
{
    public class MockItems
    {
        private static List<Item> items = new List<Item>()
        {
            new Item(1,"PC", "Intel", "Vision", "Kraftig computer til lav pris", 10.999),
            new Item(2,"Monitor", "BenQ Skærm", "BenQ", "4k qled", 2999),
            new Item(3,"Hardware", "Tastatur", "Steelseries", "qwerty apex, mekanisk", 999),
            new Item(4,"Hardware", "Mus", "Steelseries", "8 knapper, 10000 dpi", 299)
        };

        public static List<Item> GetMockItems()
        {
            return items;
        }
    }
}
