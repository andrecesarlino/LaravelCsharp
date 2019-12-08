using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaravelClient.Model
{
    public class Receita
    {
        public int id { get; set; }
        public int numero { get; set; }
        public int valor { get; set; }
        public int id_pessoa { get; set; }
        public int id_cultura { get; set; }
    }
}
