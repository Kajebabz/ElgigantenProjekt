using Elgiganten.MockData;
using Elgiganten.Models;
using Elgiganten.Pages.Item;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Xml;

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
            //ordres = JsonOrdreFileService.GetJsonOrdres().ToList();
            Ordre.nextId = ordres[^1].Id + 1;
        }

        [BindProperty] ItemService ItemServiceItemService { get; set; }
        [BindProperty]CustomerService CustomerServicess { get; set; }

            
        
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
       //public Item CalculateQuantity(Ordre ordre)
       //{
       //     foreach (var Item in _items )
       //     {
                
       //     }
       //}
    }
}
