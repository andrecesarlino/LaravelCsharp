using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaravelClient.Model
{
    public class Pessoa
    {
        public int id { get; set; }
        public int id_cidade { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }

        override

        public String ToString()
        {
            return id+" - "+nome;
        }
    }
}
