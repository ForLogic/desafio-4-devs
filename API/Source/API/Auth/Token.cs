using System.Web.Http.Controllers;

namespace Forlogic.Challenge.API.Auth
{
    public static class Token
    {
        public static string GetProjectId(HttpActionContext actionContext)
        {
            return actionContext?.Request?.Headers?.Authorization?.ToString();
        }
    }
}