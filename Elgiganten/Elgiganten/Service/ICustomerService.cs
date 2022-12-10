using Elgiganten.Models;
using Elgiganten.Pages.Customer;

namespace Elgiganten.Service
{
    public interface ICustomerService
    {
        List<ShoppingCart> GetCustomers();
        void AddCustomer(ShoppingCart customer);
        void UpdateCustomer(ShoppingCart customer);
        ShoppingCart GetCustomer(int id);
        ShoppingCart DeleteCustomer(int? CustomerId);
        IEnumerable<ShoppingCart> NameSearch(string str);
    }
}
