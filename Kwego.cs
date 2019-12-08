using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KwegonianApi
{
    public class Kwego
    {
        public string Input { get; set; }

        public string KwegonianToDecimal(string kwego)
        {

            int total = 0;
            int ultimoValor = 0;
            Dictionary<string, int> dicionarioValores = null;
            try
            {
                if (dicionarioValores == null)
                {
                    dicionarioValores = new Dictionary<string, int>();
                    dicionarioValores.Add("kil", 1);
                    dicionarioValores.Add("jin", 5);
                    dicionarioValores.Add("pol", 10);
                    dicionarioValores.Add("kilow", 50);
                    dicionarioValores.Add("jij", 100);
                    dicionarioValores.Add("jinjin", 500);
                    dicionarioValores.Add("polsx", 1000);
                }

                string[] kwegoArray = kwego.Split(' ');

                if (kwegoArray.Length == 0) return "0";


                for (int i = kwegoArray.Length - 1; i >= 0; i--)
                {
                    int valorAtual = dicionarioValores[kwegoArray[i]];

                    if (valorAtual < ultimoValor)
                        total -= valorAtual;
                    else
                    {
                        total += valorAtual;
                        ultimoValor = valorAtual;
                    }
                }

                return total.ToString();
            }
            catch (KeyNotFoundException)
            {
                return "Algum dos valores em Kwegonian não foram encontrados";
            }
            catch (Exception)
            {
                return "Ocorreu um erro";
            }
        }
    }
}
