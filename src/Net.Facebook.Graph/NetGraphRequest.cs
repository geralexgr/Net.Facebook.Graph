using Net.Facebook.Graph.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Net.Facebook.Graph
{
    public static class NetGraphRequest
    {

        public static async Task<Token> GetToken(string id, string secret)
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



        public static string CreateTokenUrl(string id, string secret)
        {
            var url = "https://graph.facebook.com/oauth/access_token?" +
                "client_id=" + id + "&client_secret=" + secret +
                "&grant_type=client_credentials";

            return url;
        }

        public static async Task<string> CreatePageRequestUrl(string id, string secret,string page)
        {
            Token token = await GetToken(id,secret);
            if (token != null)
            {
                var url = "https://graph.facebook.com/" + page + 
                    "?fields=id,link,name,about,category,single_line_address,picture.width(600).height(600)" + "&access_token=" 
                    + token.AccessToken;
                return url;
            }
            else
            {
                return String.Empty;
            }

        }

        public static async Task<Page> GetPageInfo(string url)
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Page>(result);
            }

            catch (Exception) { return new Page(); }
        }

    }
}
