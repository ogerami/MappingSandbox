using System.Web.Http;
using AutoMapper;
using WebApiSandbox.Mappers.Interfaces;
using WebApiSandbox.Models;
using WebApiSandbox.Requests;
using WebApiSandbox.Response;
using WebApiSandbox.Service.Interfaces;

namespace WebApiSandbox.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;
        private readonly IApiControllerMapper _apiControllerMapper;

        public CustomerController(ICustomerService customerService, 
            IApiControllerMapper apiControllerMapper)
        {
            _customerService = customerService;
            _apiControllerMapper = apiControllerMapper;
        }

        [Route("api/customers")]
        [HttpPost]
        public IHttpActionResult CreateCustomer([FromBody]CustomerRequest customerRequest)
        {
            var customer = _customerService.CreateCustomer(customerRequest);

            var response = _apiControllerMapper.GetResponse<CustomerModel, CustomerResponse>(customerRequest, customer);

            return Ok(response);
        }
    }
}