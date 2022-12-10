using Elgiganten.MockData;
using Elgiganten.Models;

namespace Elgiganten.Service
{
    public class CustomerService : ICustomerService
    {
        private List<ShoppingCart> customers;

        private JsonFileCustomerService JsonFileCustomerService { get; set; }

        public CustomerService(JsonFileCustomerService jsonFileCustomerService)
        {
            JsonFileCustomerService = jsonFileCustomerService;
            //customers = MockCustomers.GetMockCustomers();
            customers = jsonFileCustomerService.GetJsonCustomers().ToList();
        }

        public List<ShoppingCart> GetCustomers()
        {
            return customers;
        }

        public void AddCustomer(ShoppingCart customer)
        {
            customers.Add(customer);
            JsonFileCustomerService.SaveJsonCustomers(customers);
        }

        public IEnumerable<ShoppingCart> NameSearch(string str)
        {
            List<ShoppingCart> nameSearch= new List<ShoppingCart>();
            foreach (ShoppingCart customer in customers)
            {
                if (customer.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(customer);
                }
            }
            return nameSearch;
        }

        public void UpdateCustomer(ShoppingCart customer)
        {
            if (customer != null)
            {
                foreach (ShoppingCart i in customers)
                {
                    if (i.Id == customer.Id)
                    {
                        i.Name = customer.Name;
                        i.Address= customer.Address;
                        i.PhoneNr = customer.PhoneNr;
                        i.Email = customer.Email;
                      
                    }
                }
                JsonFileCustomerService.SaveJsonCustomers(customers);
            }
        }
        public ShoppingCart GetCustomer(int id)
        {
            foreach (ShoppingCart customer in customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }
        public ShoppingCart DeleteCustomer(int? CustomerId)
        {
            ShoppingCart customerToBeDeleted = null;
            foreach (ShoppingCart i in customers)
            {
                if (i.Id == CustomerId)
                {
                    customerToBeDeleted = i;
                    break;
                }
            }
            if (customerToBeDeleted != null)
            {
                customers.Remove(customerToBeDeleted);
                JsonFileCustomerService.SaveJsonCustomers(customers);
            }
            return customerToBeDeleted;
        }
    }
}
