using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Forlogic.Challenge.API.Helpers
{
    public static class Extensions
    {
        public static void AddHeaders(this HttpResponseMessage response, Dictionary<string, string> headers)
        {
            var headersToExpose = "";
            foreach (var item in headers)
            {
                response.Headers.Add("X-" + item.Key, item.Value);
                headersToExpose += "X-" + item.Key + ", ";
            }
            response.Headers.Add("Access-Control-Expose-Headers", headersToExpose);
        }

        public static HttpResponseMessage CreateResponse(this HttpRequestMessage request, HttpStatusCode statusCode, string jsonContent, Dictionary<string, string> headers = null)
        {
            return request.CreateResponse(statusCode, jsonContent, "application/json", Encoding.UTF8, headers ?? new Dictionary<string, string>());
        }

        public static HttpResponseMessage CreateResponse(this HttpRequestMessage request, HttpStatusCode statusCode, string jsonContent, string mediaType, Encoding encoding, Dictionary<string, string> headers)
        {
            var response = request.CreateResponse(statusCode);
            response.Content = new StringContent(jsonContent, encoding, mediaType);
            response.AddHeaders(headers);
            return response;
        }
    }
}