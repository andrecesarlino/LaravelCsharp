using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaravelClient.Model
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }

        override
        public String ToString()
        {
            return id+"-"+descricao;
        }
    }
}
