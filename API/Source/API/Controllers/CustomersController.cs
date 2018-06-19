using Forlogic.Challenge.API.Helpers.Auth;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Forlogic.Challenge.API.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        [HttpGet]
        [Route("{id?}")]
        [@Authorize]
        public async Task<IHttpActionResult> Get(string id = null)
        {
            string projectId = Token.GetProjectId(ActionContext);

            using (WebClient webClient = new WebClient())
            {
                HttpResponseMessage result = await new HttpClient().GetAsync($"https://{projectId}.firebaseio.com/customers{(string.IsNullOrWhiteSpace(id) ? null : $"/{id}")}.json");
                string responseString = await result.Content.ReadAsStringAsync();

                object response = null;
                if (!string.IsNullOrWhiteSpace(responseString))
                    response = JsonConvert.DeserializeObject(responseString);

                if (response == null)
                    return StatusCode(HttpStatusCode.NoContent);

                return Ok(response);
            }
        }

        [HttpPost]
        [Route("")]
        [@Authorize]
        public async Task<IHttpActionResult> Post([FromBody]dynamic data)
        {
            string projectId = Token.GetProjectId(ActionContext);

            using (WebClient webClient = new WebClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(data));
                HttpResponseMessage result = await new HttpClient().PostAsync($"https://{projectId}.firebaseio.com/customers.json", content);
                string responseString = await result.Content.ReadAsStringAsync();

                string id = null;
                if (!string.IsNullOrWhiteSpace(responseString) && result.IsSuccessStatusCode)
                    id = JsonConvert.DeserializeObject<dynamic>(responseString)?.name;

                if (string.IsNullOrWhiteSpace(id))
                    return StatusCode(HttpStatusCode.NoContent);

                return Created("/api/customers", new { id });
            }
        }

        [HttpPut]
        [Route("{id?}")]
        [@Authorize]
        public async Task<IHttpActionResult> Put(string id, [FromBody]dynamic data)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Customer Id cannot be null or empty.");

            string projectId = Token.GetProjectId(ActionContext);

            using (WebClient webClient = new WebClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(data));
                HttpResponseMessage result = await new HttpClient().PutAsync($"https://{projectId}.firebaseio.com/customers/{id}.json", content);

                if (!result.IsSuccessStatusCode)
                    return StatusCode(HttpStatusCode.NoContent);

                return Ok();
            }
        }

        [HttpDelete]
        [Route("{id?}")]
        [@Authorize]
        public async Task<IHttpActionResult> Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Customer Id cannot be null or empty.");

            string projectId = Token.GetProjectId(ActionContext);

            using (WebClient webClient = new WebClient())
            {
                HttpResponseMessage result = await new HttpClient().DeleteAsync($"https://{projectId}.firebaseio.com/customers/{id}.json");

                if (!result.IsSuccessStatusCode)
                    return StatusCode(HttpStatusCode.NoContent);

                return Ok();
            }
        }
    }
}
