using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using LaravelClient.Model;


namespace LaravelClient.Controller
{
    class CidadeServices
    {
        public static async Task<List<Cidade>> GetCidade()
        {
            List<Cidade> lista = new List<Cidade>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.GetAsync("cidade");
            lista = JsonConvert.DeserializeObject<List<Cidade>>(await response.Content.ReadAsStringAsync());
            return lista;
        }

        public static async Task<string> PostCidade([FromBody] Cidade cidade)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PostAsJsonAsync("cidade", cidade);
            return response.StatusCode.ToString();
        }

        public static async Task<string> PutCidade([FromBody] Cidade cidade)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PutAsJsonAsync("cidade/" + cidade.id, cidade);
            return response.StatusCode.ToString();
        }

        public static async Task<string> DelCidade([FromBody] Cidade cidade)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.DeleteAsync("cidade/" + cidade.id);
            return response.StatusCode.ToString();
        }
    }
}
