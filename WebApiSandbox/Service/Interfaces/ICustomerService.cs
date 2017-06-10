using WebApiSandbox.Models;
using WebApiSandbox.Requests;

namespace WebApiSandbox.Service.Interfaces
{
    public interface ICustomerService
    {
        CustomerModel CreateCustomer(CustomerRequest customerRequest);
    }
}