using Net.Facebook.Graph.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Net.Facebook.Graph
{
    public class NetGraphRequest
    {

        public async Task<Token> GetToken(string id, string secret)
        {
            try
            {
                var client = new HttpClient();
                var url = CreateTokenUrl(id, secret);
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Token>(result);
            }

            catch (Exception) { return new Token(); }
        }



        public string CreateTokenUrl(string id, string secret)
        {
            var url = "https://graph.facebook.com/oauth/access_token?" +
                "client_id=" + id + "&client_secret=" + secret +
                "&grant_type=client_credentials";

            return url;
        }

    }
}
