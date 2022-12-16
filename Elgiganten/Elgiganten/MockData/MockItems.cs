using Elgiganten.Models;

namespace Elgiganten.MockData
{
    public class MockItems
    {
        private static List<Item> items = new List<Item>()
        {
            new Item("PC", "Intel", "Vision", "Kraftig computer til lav pris", 10.999),
            new Item("Monitor", "BenQ Skærm", "BenQ", "4k qled", 2999),
            new Item("Hardware", "Tastatur", "Steelseries", "qwerty apex, mekanisk", 999),
            new Item("Hardware", "Mus", "Steelseries", "8 knapper, 10000 dpi", 299)
        };

        public static List<Item> GetMockItems()
        {
            return items;
        }
    }
}
