using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONinCSharp
{
    internal class Nomes
    {
        public String NomeCompleto { get; set; }

        public String JsonSerializar(Nomes nome)
        {
            return JsonConvert.SerializeObject(nome);

        }
        public static Nomes JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Nomes>(Json);
        }
    }
}
