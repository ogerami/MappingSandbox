using WebApiSandbox.Response.Base;

namespace WebApiSandbox.Response
{
    public class CustomerResponse : BaseResponse
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}