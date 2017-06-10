using AutoMapper;
using SimpleInjector;
using WebApiSandbox.Mappers;
using WebApiSandbox.Mappers.Interfaces;
using WebApiSandbox.Models;
using WebApiSandbox.Response;
using WebApiSandbox.Service;
using WebApiSandbox.Service.Interfaces;

namespace WebApiSandbox.Ioc
{
    public class InitializeIoc
    {
        public static Container GetContainer()
        {
            var container = new Container();

            container.Register<ICustomerService, CustomerService>();
            container.Register<IMapper>(
                () => new Mapper(new MapperConfiguration(expression =>
            {
                expression.CreateMap<CustomerModel, CustomerResponse>();
            })));
            container.Register<IApiControllerMapper, ApiControllerMapper>();
                
            container.Verify();
            return container;
        }
    }
}