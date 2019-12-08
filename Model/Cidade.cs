using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaravelClient.Model
{
    public class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cep { get; set; }

        override
            public String ToString()
        {
            return id+" - "+nome;
        }
    }
}
