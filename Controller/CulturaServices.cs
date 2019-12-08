using LaravelClient.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LaravelClient.Controller
{
    class CulturaServices
    {
        public static async Task<List<Cultura>> GetCultura()
        {
            List<Cultura> lista = new List<Cultura>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.GetAsync("cultura");
            lista = JsonConvert.DeserializeObject<List<Cultura>>(await response.Content.ReadAsStringAsync());
            return lista;
        }

        public static async Task<string> PostCultura([FromBody] Cultura cultura)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PostAsJsonAsync("cultura", cultura);
            return response.StatusCode.ToString();
        }

        public static async Task<string> PutCultura([FromBody] Cultura cultura)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PutAsJsonAsync("cultura/" + cultura.id, cultura);
            return response.StatusCode.ToString();
        }

        public static async Task<string> DelCultura([FromBody] Cultura cultura)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.DeleteAsync("cultura/" + cultura.id);
            return response.StatusCode.ToString();
        }
    }
}
