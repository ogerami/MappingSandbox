using System.Web.Http;
using Owin;
using SimpleInjector.Integration.WebApi;

namespace WebApiSandbox
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(Ioc.InitializeIoc.GetContainer());

            app.UseWebApi(config);
        }
    }
}