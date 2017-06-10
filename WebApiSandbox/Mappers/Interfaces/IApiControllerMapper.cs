using WebApiSandbox.Requests.Base;
using WebApiSandbox.Response.Base;

namespace WebApiSandbox.Mappers.Interfaces
{
    public interface IApiControllerMapper
    {
        TResponse GetResponse<TMode, TResponse>(BaseRequest request, TMode model)
            where TResponse : BaseResponse;
    }
}