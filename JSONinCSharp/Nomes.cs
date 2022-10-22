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

        public bool JsonSerializarLista(List<Nomes> lista, string path)
        {
            var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
            return SaveFileNomes(strJson, path);
        }

        public static List<Nomes>JsonDesserializarLista(string path)
        {
            var strJson = OpenFileNomes(path);
            if (strJson.Substring(0, 4) != "Fail")
            {
                return JsonConvert.DeserializeObject<List<Nomes>>(strJson);
            }
            else
            {
                var listaNomes = new List<Nomes>();
                var nomes = new Nomes();
                nomes.NomeCompleto = strJson;
                listaNomes.Add(nomes);
                nomes.NomeCompleto = strJson;
                return listaNomes;
            }
        }

        private static String OpenFileNomes(string path)
        {
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    strJson = sr.ReadToEnd();
                }
                return strJson;
            }
            catch (Exception ex)
            {
                return "Fail" + ex.Message;
            }
        }

        private bool SaveFileNomes(string strJson, string path)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(strJson);  
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail" + ex.Message);
                return false;
            }
        }
    }
}
