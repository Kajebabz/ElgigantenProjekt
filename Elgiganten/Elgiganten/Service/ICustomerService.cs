using Elgiganten.Models;
using Elgiganten.Pages.Customer;

namespace Elgiganten.Service
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomer(int id);
        Customer DeleteCustomer(int? CustomerId);
        IEnumerable<Customer> NameSearch(string str);
    }
}
