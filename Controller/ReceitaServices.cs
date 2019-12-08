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
    class ReceitaServices
    {
        public static async Task<List<Receita>> GetReceita()
        {
            List<Receita> lista = new List<Receita>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.GetAsync("receita");
            lista = JsonConvert.DeserializeObject<List<Receita>>(await response.Content.ReadAsStringAsync());
            return lista;
        }

        public static async Task<string> PostReceita([FromBody] Receita receita)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PostAsJsonAsync("receita", receita);
            return response.StatusCode.ToString();
        }

        public static async Task<string> PutReceita([FromBody] Receita receita)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PutAsJsonAsync("receita/" + receita.id, receita);
            return response.StatusCode.ToString();
        }

        public static async Task<string> DelReceita([FromBody] Produto receita)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.DeleteAsync("receita/" + receita.id);
            return response.StatusCode.ToString();
        }
    }
}
