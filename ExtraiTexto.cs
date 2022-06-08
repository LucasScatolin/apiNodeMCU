using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APINodeMcu
{
    public class ExtraiTexto
    {

        int resultadoInt;


        public string GetValorOXI(string nomeParametro)
        {
            string termo = "vloxi="; // vloxi=
            int indiceTermo = nomeParametro.IndexOf(termo); // x

            string resultado = nomeParametro.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('?');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }


        public string GetValorTEMP(string nomeParametro)
        {
            string termo = "vltemp="; // vloxi=
            int indiceTermo = nomeParametro.IndexOf(termo); // x

            string resultado = nomeParametro.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('?');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }


        public string GetValorFREQ(string nomeParametro)
        {
            string termo = "vlfreq="; // vloxi=
            int indiceTermo = nomeParametro.IndexOf(termo); // x

            string resultado = nomeParametro.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('?');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }

        public int GetValorDISP(string nomeParametro)
        {
            string termo = "vldisp="; // vloxi=
            int indiceTermo = nomeParametro.IndexOf(termo); // x

            string resultado = nomeParametro.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('?');

            

            if (indiceEComercial == -1)
            {
                resultadoInt = Int32.Parse(resultado);
                return resultadoInt;
            }

            string resultadoRemE = resultado.Remove(indiceEComercial);
            resultadoInt = Int32.Parse(resultadoRemE);
            return resultadoInt;


        }

        




    }
}
