using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaravelClient.Model
{
    public class ReceitaProduto
    {
        public int id { get; set; }
        public int id_receita { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }
    }
}
