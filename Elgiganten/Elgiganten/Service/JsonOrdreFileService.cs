using Elgiganten.Models;
using System.Text.Json;

namespace Elgiganten.Service
{
    public class JsonOrdreFileService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Ordres.json"); }
        }

        public JsonOrdreFileService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Ordre> GetJsonOrdres()
        {
            using (StreamReader JsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Ordre[]>(JsonFileReader.ReadToEnd());
            }
        }
        public void SaveJsonOrdre(List<Ordre> ordres)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Ordre[]>(jsonWriter, ordres.ToArray());
            }
        }
    }   
}
