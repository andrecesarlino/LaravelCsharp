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
    class ReceitaProdutoServices
    {
        public static async Task<List<ReceitaProduto>> GetReceitaProduto()
        {
            List<ReceitaProduto> lista = new List<ReceitaProduto>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.GetAsync("receitaproduto");
            lista = JsonConvert.DeserializeObject<List<ReceitaProduto>>(await response.Content.ReadAsStringAsync());
            return lista;
        }

        public static async Task<string> PostReceitaProduto([FromBody] ReceitaProduto receitaproduto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PostAsJsonAsync("receitaproduto", receitaproduto);
            return response.StatusCode.ToString();
        }

        public static async Task<string> PutReceitaProduto([FromBody] ReceitaProduto receitaproduto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PutAsJsonAsync("receitaproduto/" + receitaproduto.id_receita, receitaproduto);
            return response.StatusCode.ToString();
        }

        public static async Task<string> DelReceitaProduto([FromBody] ReceitaProduto receitaproduto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.DeleteAsync("receitaproduto/" + receitaproduto.id);
            return response.StatusCode.ToString();
        }
    }
}
