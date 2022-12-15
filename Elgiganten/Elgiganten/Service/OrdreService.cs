using Elgiganten.MockData;
using Elgiganten.Models;


namespace Elgiganten.Service
{
    public class OrdreService : IOrdreService
    {
        private List<Ordre> ordres;
        private JsonOrdreFileService JsonOrdreFileService { get; set; }

        public OrdreService(JsonOrdreFileService jsonOrdreFileService)
        {
            JsonOrdreFileService = jsonOrdreFileService;
            ordres = MockData.MockOrdre.GetMockOrdres();
            jsonOrdreFileService.SaveJsonOrdre(ordres);
            //ordres = JsonOrdreFileService.GetJsonOrdres().ToList();
            Ordre.nextId = ordres[^1].Id + 1;
        }

        public OrdreService()
        {
        }

        public List<Ordre> GetOrdres()
        {
            return ordres;
        }
        public void AddOrdre(Ordre ordre)
        {
            ordre.Id = Ordre.nextId++;
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
     
        //public Item CalculateQuantity(Item item)
        //{
        //    foreach (var k in ordres)
        //    {
        //        if (ordre.Quantity == k.Quantity)
        //        {
        //            double total = (ordre.Quantity * item.Price);
        //        }

        //    }
        //    return null;
        //}
    }
}
