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
    public class PessoaServices
    {
        public static async Task<List<Pessoa>> GetPessoa()
        {
            List<Pessoa> lista = new List<Pessoa>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.GetAsync("pessoa");
            lista = JsonConvert.DeserializeObject<List<Pessoa>>(await response.Content.ReadAsStringAsync());
            return lista;
        }

        public static async Task<string> PostPessoa([FromBody] Pessoa pessoa)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PostAsJsonAsync("pessoa", pessoa);
            return response.StatusCode.ToString();
        }

        public static async Task<string> PutPessoa([FromBody] Pessoa pessoa)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.PutAsJsonAsync("pessoa/" + pessoa.id, pessoa);
            return response.StatusCode.ToString();
        }

        public static async Task<string> DelPessoa([FromBody] Pessoa pessoa)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);
            HttpResponseMessage response = await client.DeleteAsync("pessoa/" + pessoa.id);
            return response.StatusCode.ToString();
        }
    }
}
