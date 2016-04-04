using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace F_Gudvis
{
    class APIConnection
    {
        HttpStatusCode GETerror = HttpStatusCode.OK;

        //Send a GET request to the server and return a JSON response
        public async Task<String> GETRequest(String url)
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync(url);
            string urlContents = await getStringTask;
            return urlContents;
        }

        //Send a POST request (with JSON data) to the server and return a JSON response
        public async Task<String> POSTRequest(String url, string jsonContent)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            Task<HttpResponseMessage> getStringTask = client.PostAsync(url, new StringContent(jsonContent, Encoding.UTF8, "application/json"));
            HttpResponseMessage urlContents = await getStringTask;
            string stringContent = await urlContents.Content.ReadAsStringAsync();
            return stringContent;
        }
    }
}
