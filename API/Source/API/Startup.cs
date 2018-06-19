using Forlogic.Challenge.API.Helpers.Middlewares;
using Owin;
using System.Web.Http;

namespace Forlogic.Challenge.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);

            app.Use<ErrorHandlingMiddleware>();
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
    }
}