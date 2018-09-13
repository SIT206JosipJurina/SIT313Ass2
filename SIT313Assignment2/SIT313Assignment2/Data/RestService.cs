using Newtonsoft.Json;
using SIT313Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SIT313Assignment2.Data
{
    public class RestService
    {
        /*
        HttpClient client;
        string grant_type = "password";

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded' "));
        }
        public async Task<Token> Login(User user)
        {
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", grant_type));
            postData.Add(new KeyValuePair<string, string>("username", user.Username));
            postData.Add(new KeyValuePair<string, string>("password", user.Password));
            var content = new FormUrlEncodedContent(postData);
            var weburl = "www.test.com";
            var response = await PostResponse<Token>(weburl,content);
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            response.expiry_date = dt.AddSeconds(response.expires_in);
            return response;
        }
        public async Task<Token> PostResponse<Token>(string weburl, FormUrlEncodedContent content) where Token : class
        {          
            var response = await client.PostAsync(weburl, content);
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            var token = JsonConvert.DeserializeObject<Token>(jsonResult);
            return token;
        }
        */
    }
    
}
