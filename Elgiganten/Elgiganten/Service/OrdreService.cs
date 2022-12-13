using Elgiganten.MockData;
using Elgiganten.Models;
using System.Collections.Immutable;
using System.Xml;

namespace Elgiganten.Service
{
    public class OrdreService
    {
        private List<Ordre> ordres;
        private JsonOrdreFileService JsonOrdreFileService { get; set; }

        public OrdreService(JsonOrdreFileService jsonOrdreFileService)
        {
            JsonOrdreFileService = jsonOrdreFileService;
            ordres = MockData.MockOrdre.GetMockOrdres();
            //ordres = JsonOrdreFileService.GetJsonOrdres().ToList();
        }
       


        public List<Ordre> GetOrdres()
        {
            return ordres;
        }
        public void AddOrdre(Ordre ordre)
        {
            ordres.Add(ordre);
            JsonOrdreFileService.SaveJsonOrdre(ordres);
        }
      
        

     
        public void UpdateOrdre(Ordre ordre)
        {
            if (ordres != null)
            {
                foreach (Ordre i in ordres)
                {
                    if (i.Id == ordre.Id)
                    {
                        i.Quantity = ordre.Quantity;
                        i.OrdreDate = ordre.OrdreDate;
                    }
                }
                JsonOrdreFileService.SaveJsonOrdre(ordres);
            }
        }
        public Ordre GetOrdre(int id)
        {
            foreach (Ordre ordre in ordres)
            {
                if (ordre.Id == id)
                    return ordre;
            }
            return null;
        }
        public Ordre DeleteOrdre(int? OrdreId)
        {
            Ordre OrdreToBeDeleted = null;
            foreach (Ordre i in ordres)
            {
                if (i.Id == OrdreId)
                {
                    OrdreToBeDeleted = i;
                    break;
                }
            }

            if (OrdreToBeDeleted != null)
            {
                ordres.Remove(OrdreToBeDeleted);
                JsonOrdreFileService.SaveJsonOrdre(ordres);
            }
            return OrdreToBeDeleted;
        }

    }
}
