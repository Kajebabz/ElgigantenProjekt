using Elgiganten.MockData;
using Elgiganten.Models;

namespace Elgiganten.Service
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customers;

        private JsonFileCustomerService JsonFileCustomerService { get; set; }

        public CustomerService(JsonFileCustomerService jsonFileCustomerService)
        {
            JsonFileCustomerService = jsonFileCustomerService;
            //customers = MockCustomers.GetMockCustomers();
            customers = jsonFileCustomerService.GetJsonCustomers().ToList();
            Customer.nextId = customers[^1].Id + 1;
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            customer.Id = Customer.nextId++;
            customers.Add(customer);
            JsonFileCustomerService.SaveJsonCustomers(customers);
        }

        public IEnumerable<Customer> NameSearch(string str)
        {
            List<Customer> nameSearch= new List<Customer>();
            foreach (Customer customer in customers)
            {
                if (customer.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(customer);
                }
            }
            return nameSearch;
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer != null)
            {
                foreach (Customer i in customers)
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
        public Customer GetCustomer(int id)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }
        public Customer DeleteCustomer(int? CustomerId)
        {
            Customer customerToBeDeleted = null;
            foreach (Customer i in customers)
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
