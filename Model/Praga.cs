using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaravelClient.Model
{
    public class Praga
    {
        public int id { get; set; }
        public string descricao { get; set; }

        override
        public String ToString()
        {
            return id + " - " + descricao;
        }
    }
}
