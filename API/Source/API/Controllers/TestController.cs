using System.Web.Http;

namespace Forlogic.Challenge.API.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("Forlogic.Challenge.API is working!");
        }
    }
}