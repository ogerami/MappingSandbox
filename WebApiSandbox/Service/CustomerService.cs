using WebApiSandbox.Models;
using WebApiSandbox.Requests;
using WebApiSandbox.Service.Interfaces;

namespace WebApiSandbox.Service
{
    public class CustomerService : ICustomerService
    {
        public CustomerModel CreateCustomer(CustomerRequest customerRequest)
        {
            return new CustomerModel(customerRequest.Name, customerRequest.Address);
        }
    }
}