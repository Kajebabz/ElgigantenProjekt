using Elgiganten.Models;
using System.Text.Json;

namespace Elgiganten.Service
{
    public class JsonFileShoppingCart
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "ShoppingCart.json"); }
        }

        public JsonFileShoppingCart(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<ShoppingCartService> GetJsonShoppingCart()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<ShoppingCartService[]>(jsonFileReader.ReadToEnd());
            }
        }
        public void SaveJsonShoppingCarts(List<ShoppingCartService> shoppingCarts)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<ShoppingCartService[]>(jsonWriter, shoppingCarts.ToArray());
            }
        }

    }
}
