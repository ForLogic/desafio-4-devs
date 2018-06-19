using Microsoft.Owin;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Forlogic.Challenge.API.Helpers.Middlewares
{
    public class ErrorHandlingMiddleware : OwinMiddleware
    {
        public ErrorHandlingMiddleware(OwinMiddleware next) : base(next)
        { }

        public override async Task Invoke(IOwinContext context)
        {
            try
            {
                await Next.Invoke(context);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(context, e);
            }
        }

        private Task HandleExceptionAsync(IOwinContext context, Exception exception)
        {
            var code = System.Net.HttpStatusCode.InternalServerError;

            if (exception is ArgumentNullException) code = System.Net.HttpStatusCode.BadRequest;

            var result = JsonConvert.SerializeObject(new { error = exception.Message });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(result);
        }
    }

}