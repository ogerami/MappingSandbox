using System.Web;
using AutoMapper;
using WebApiSandbox.Mappers.Interfaces;
using WebApiSandbox.Requests.Base;
using WebApiSandbox.Response.Base;

namespace WebApiSandbox.Mappers
{
    public class ApiControllerMapper : IApiControllerMapper
    {
        private readonly IMapper _mapper;

        public ApiControllerMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TResponse GetResponse<TMode, TResponse>(BaseRequest request, TMode model)
            where TResponse : BaseResponse
        {
            var response = _mapper.Map<TResponse>(model);
            response.RequestId = request.RequestId;
            return response;
        }
    }
}