using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace WarNov.EasyPost.NetStandard
{
    public static class EasyPost
    {
        /// <summary>
        /// Sends a post to a given open URL (no auth headers - Maybe the auth could be a token in the url: as Azure Functions work)
        /// </summary>
        /// <param name="url">The URL to send the info</param>
        /// <param name="payload">The info to be sent</param>
        /// <returns>The HttpResponseMessage with the result of the operation</returns>
        public static HttpResponseMessage Post(string url, object payload)
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
                return client.PostAsync(url, content).Result;
            }
        }
    }
}