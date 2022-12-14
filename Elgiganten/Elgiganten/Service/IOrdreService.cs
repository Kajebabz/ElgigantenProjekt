using Elgiganten.Models;
using Elgiganten.Pages.Ordre;

namespace Elgiganten.Service
{
    public interface IOrdreService
    {
        List<Ordre> GetOrdres();
        void AddOrdre(Ordre ordre);
        void UpdateOrdre(Ordre ordre);
        Ordre GetOrdre(int id);
        Ordre DeleteOrdre(int? ordreId);
       
    }
}

