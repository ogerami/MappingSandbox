using WebApiSandbox.Requests.Base;

namespace WebApiSandbox.Requests
{
    public class CustomerRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Address { get; set; } 
    }
}