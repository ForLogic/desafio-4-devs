using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Forlogic.Challenge.API.Helpers.Auth
{
    public class Authorize : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (string.IsNullOrWhiteSpace(Token.GetProjectId(actionContext)))
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized)
                {
                    Content = new StringContent("Firebase Project ID cannot be null or empty.")
                };
                return;
            }
        }
    }
}